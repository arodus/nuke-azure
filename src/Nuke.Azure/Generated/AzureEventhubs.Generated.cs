// Copyright Matthias Koch, Sebastian Karasek 2018.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

// Generated with Nuke.CodeGeneration, Version: 0.6.1 [CommitSha: 8eca516b].
// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/AzureEventhubs.json.

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
    public static partial class AzureEventhubsTasks
    {
        /// <summary><p>Path to the AzureEventhubs executable.</p></summary>
        public static string AzureEventhubsPath => ToolPathResolver.GetPathExecutable("az");
        /// <summary><p>Manage Azure Event Hubs namespaces, eventhubs, consumergroups and geo recovery configurations - Alias.</p></summary>
        public static IReadOnlyCollection<Output> AzureEventhubs(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool logOutput = true, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzureEventhubsPath, arguments, workingDirectory, environmentVariables, timeout, logOutput, null, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Event Hubs namespaces, eventhubs, consumergroups and geo recovery configurations - Alias.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventhubs?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureEventhubs(Configure<AzureEventhubsSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureEventhubsSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Event Hubs namespaces, eventhubs, consumergroups and geo recovery configurations - Alias.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventhubs?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureEventhubsGeorecoveryAliasBreakPair(Configure<AzureEventhubsGeorecoveryAliasBreakPairSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureEventhubsGeorecoveryAliasBreakPairSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Event Hubs namespaces, eventhubs, consumergroups and geo recovery configurations - Alias.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventhubs?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureEventhubsGeorecoveryAliasDelete(Configure<AzureEventhubsGeorecoveryAliasDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureEventhubsGeorecoveryAliasDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Event Hubs namespaces, eventhubs, consumergroups and geo recovery configurations - Alias.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventhubs?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureEventhubsGeorecoveryAliasExists(Configure<AzureEventhubsGeorecoveryAliasExistsSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureEventhubsGeorecoveryAliasExistsSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Event Hubs namespaces, eventhubs, consumergroups and geo recovery configurations - Alias.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventhubs?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureEventhubsGeorecoveryAliasFailOver(Configure<AzureEventhubsGeorecoveryAliasFailOverSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureEventhubsGeorecoveryAliasFailOverSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Event Hubs namespaces, eventhubs, consumergroups and geo recovery configurations - Alias.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventhubs?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureEventhubsGeorecoveryAliasList(Configure<AzureEventhubsGeorecoveryAliasListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureEventhubsGeorecoveryAliasListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Event Hubs namespaces, eventhubs, consumergroups and geo recovery configurations - Alias.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventhubs?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureEventhubsGeorecoveryAliasSet(Configure<AzureEventhubsGeorecoveryAliasSetSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureEventhubsGeorecoveryAliasSetSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Event Hubs namespaces, eventhubs, consumergroups and geo recovery configurations - Alias.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventhubs?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureEventhubsGeorecoveryAliasShow(Configure<AzureEventhubsGeorecoveryAliasShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureEventhubsGeorecoveryAliasShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Event Hubs namespaces, eventhubs, consumergroups and geo recovery configurations - Alias.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventhubs?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureEventhubsNamespaceCreate(Configure<AzureEventhubsNamespaceCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureEventhubsNamespaceCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Event Hubs namespaces, eventhubs, consumergroups and geo recovery configurations - Alias.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventhubs?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureEventhubsNamespaceDelete(Configure<AzureEventhubsNamespaceDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureEventhubsNamespaceDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Event Hubs namespaces, eventhubs, consumergroups and geo recovery configurations - Alias.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventhubs?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureEventhubsNamespaceExists(Configure<AzureEventhubsNamespaceExistsSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureEventhubsNamespaceExistsSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Event Hubs namespaces, eventhubs, consumergroups and geo recovery configurations - Alias.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventhubs?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureEventhubsNamespaceList(Configure<AzureEventhubsNamespaceListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureEventhubsNamespaceListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Event Hubs namespaces, eventhubs, consumergroups and geo recovery configurations - Alias.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventhubs?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureEventhubsNamespaceShow(Configure<AzureEventhubsNamespaceShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureEventhubsNamespaceShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Event Hubs namespaces, eventhubs, consumergroups and geo recovery configurations - Alias.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventhubs?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureEventhubsNamespaceUpdate(Configure<AzureEventhubsNamespaceUpdateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureEventhubsNamespaceUpdateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Event Hubs namespaces, eventhubs, consumergroups and geo recovery configurations - Alias.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventhubs?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureEventhubsEventhubCreate(Configure<AzureEventhubsEventhubCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureEventhubsEventhubCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Event Hubs namespaces, eventhubs, consumergroups and geo recovery configurations - Alias.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventhubs?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureEventhubsEventhubDelete(Configure<AzureEventhubsEventhubDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureEventhubsEventhubDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Event Hubs namespaces, eventhubs, consumergroups and geo recovery configurations - Alias.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventhubs?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureEventhubsEventhubList(Configure<AzureEventhubsEventhubListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureEventhubsEventhubListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Event Hubs namespaces, eventhubs, consumergroups and geo recovery configurations - Alias.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventhubs?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureEventhubsEventhubShow(Configure<AzureEventhubsEventhubShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureEventhubsEventhubShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Event Hubs namespaces, eventhubs, consumergroups and geo recovery configurations - Alias.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventhubs?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureEventhubsEventhubUpdate(Configure<AzureEventhubsEventhubUpdateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureEventhubsEventhubUpdateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Event Hubs namespaces, eventhubs, consumergroups and geo recovery configurations - Alias.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventhubs?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureEventhubsNamespaceAuthorizationRuleCreate(Configure<AzureEventhubsNamespaceAuthorizationRuleCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureEventhubsNamespaceAuthorizationRuleCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Event Hubs namespaces, eventhubs, consumergroups and geo recovery configurations - Alias.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventhubs?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureEventhubsNamespaceAuthorizationRuleDelete(Configure<AzureEventhubsNamespaceAuthorizationRuleDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureEventhubsNamespaceAuthorizationRuleDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Event Hubs namespaces, eventhubs, consumergroups and geo recovery configurations - Alias.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventhubs?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureEventhubsNamespaceAuthorizationRuleList(Configure<AzureEventhubsNamespaceAuthorizationRuleListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureEventhubsNamespaceAuthorizationRuleListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Event Hubs namespaces, eventhubs, consumergroups and geo recovery configurations - Alias.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventhubs?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureEventhubsNamespaceAuthorizationRuleShow(Configure<AzureEventhubsNamespaceAuthorizationRuleShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureEventhubsNamespaceAuthorizationRuleShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Event Hubs namespaces, eventhubs, consumergroups and geo recovery configurations - Alias.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventhubs?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureEventhubsNamespaceAuthorizationRuleUpdate(Configure<AzureEventhubsNamespaceAuthorizationRuleUpdateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureEventhubsNamespaceAuthorizationRuleUpdateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Event Hubs namespaces, eventhubs, consumergroups and geo recovery configurations - Alias.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventhubs?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureEventhubsGeorecoveryAliasAuthorizationRuleList(Configure<AzureEventhubsGeorecoveryAliasAuthorizationRuleListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureEventhubsGeorecoveryAliasAuthorizationRuleListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Event Hubs namespaces, eventhubs, consumergroups and geo recovery configurations - Alias.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventhubs?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureEventhubsGeorecoveryAliasAuthorizationRuleShow(Configure<AzureEventhubsGeorecoveryAliasAuthorizationRuleShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureEventhubsGeorecoveryAliasAuthorizationRuleShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Event Hubs namespaces, eventhubs, consumergroups and geo recovery configurations - Alias.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventhubs?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureEventhubsEventhubConsumerGroupCreate(Configure<AzureEventhubsEventhubConsumerGroupCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureEventhubsEventhubConsumerGroupCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Event Hubs namespaces, eventhubs, consumergroups and geo recovery configurations - Alias.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventhubs?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureEventhubsEventhubConsumerGroupDelete(Configure<AzureEventhubsEventhubConsumerGroupDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureEventhubsEventhubConsumerGroupDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Event Hubs namespaces, eventhubs, consumergroups and geo recovery configurations - Alias.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventhubs?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureEventhubsEventhubConsumerGroupList(Configure<AzureEventhubsEventhubConsumerGroupListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureEventhubsEventhubConsumerGroupListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Event Hubs namespaces, eventhubs, consumergroups and geo recovery configurations - Alias.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventhubs?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureEventhubsEventhubConsumerGroupShow(Configure<AzureEventhubsEventhubConsumerGroupShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureEventhubsEventhubConsumerGroupShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Event Hubs namespaces, eventhubs, consumergroups and geo recovery configurations - Alias.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventhubs?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureEventhubsEventhubConsumerGroupUpdate(Configure<AzureEventhubsEventhubConsumerGroupUpdateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureEventhubsEventhubConsumerGroupUpdateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Event Hubs namespaces, eventhubs, consumergroups and geo recovery configurations - Alias.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventhubs?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureEventhubsEventhubAuthorizationRuleCreate(Configure<AzureEventhubsEventhubAuthorizationRuleCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureEventhubsEventhubAuthorizationRuleCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Event Hubs namespaces, eventhubs, consumergroups and geo recovery configurations - Alias.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventhubs?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureEventhubsEventhubAuthorizationRuleDelete(Configure<AzureEventhubsEventhubAuthorizationRuleDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureEventhubsEventhubAuthorizationRuleDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Event Hubs namespaces, eventhubs, consumergroups and geo recovery configurations - Alias.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventhubs?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureEventhubsEventhubAuthorizationRuleList(Configure<AzureEventhubsEventhubAuthorizationRuleListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureEventhubsEventhubAuthorizationRuleListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Event Hubs namespaces, eventhubs, consumergroups and geo recovery configurations - Alias.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventhubs?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureEventhubsEventhubAuthorizationRuleShow(Configure<AzureEventhubsEventhubAuthorizationRuleShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureEventhubsEventhubAuthorizationRuleShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Event Hubs namespaces, eventhubs, consumergroups and geo recovery configurations - Alias.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventhubs?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureEventhubsEventhubAuthorizationRuleUpdate(Configure<AzureEventhubsEventhubAuthorizationRuleUpdateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureEventhubsEventhubAuthorizationRuleUpdateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Event Hubs namespaces, eventhubs, consumergroups and geo recovery configurations - Alias.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventhubs?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureEventhubsNamespaceAuthorizationRuleKeysList(Configure<AzureEventhubsNamespaceAuthorizationRuleKeysListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureEventhubsNamespaceAuthorizationRuleKeysListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Event Hubs namespaces, eventhubs, consumergroups and geo recovery configurations - Alias.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventhubs?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureEventhubsNamespaceAuthorizationRuleKeysRenew(Configure<AzureEventhubsNamespaceAuthorizationRuleKeysRenewSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureEventhubsNamespaceAuthorizationRuleKeysRenewSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Event Hubs namespaces, eventhubs, consumergroups and geo recovery configurations - Alias.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventhubs?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureEventhubsGeorecoveryAliasAuthorizationRuleKeysList(Configure<AzureEventhubsGeorecoveryAliasAuthorizationRuleKeysListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureEventhubsGeorecoveryAliasAuthorizationRuleKeysListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Event Hubs namespaces, eventhubs, consumergroups and geo recovery configurations - Alias.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventhubs?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureEventhubsEventhubAuthorizationRuleKeysList(Configure<AzureEventhubsEventhubAuthorizationRuleKeysListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureEventhubsEventhubAuthorizationRuleKeysListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Event Hubs namespaces, eventhubs, consumergroups and geo recovery configurations - Alias.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventhubs?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureEventhubsEventhubAuthorizationRuleKeysRenew(Configure<AzureEventhubsEventhubAuthorizationRuleKeysRenewSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureEventhubsEventhubAuthorizationRuleKeysRenewSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
    }
    #region AzureEventhubsSettings
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventhubsSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureEventhubs executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureEventhubsTasks.AzureEventhubsPath;
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
              .Add("eventhubs")
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureEventhubsGeorecoveryAliasBreakPairSettings
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventhubsGeorecoveryAliasBreakPairSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureEventhubs executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureEventhubsTasks.AzureEventhubsPath;
        /// <summary><p>Name of Geo-Disaster Recovery Configuration Alias.</p></summary>
        public virtual string Alias { get; internal set; }
        /// <summary><p>Name of Namespace.</p></summary>
        public virtual string NamespaceName { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
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
              .Add("eventhubs georecovery-alias break-pair")
              .Add("--alias {value}", Alias)
              .Add("--namespace-name {value}", NamespaceName)
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
    #region AzureEventhubsGeorecoveryAliasDeleteSettings
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventhubsGeorecoveryAliasDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureEventhubs executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureEventhubsTasks.AzureEventhubsPath;
        /// <summary><p>Name of Geo-Disaster Recovery Configuration Alias.</p></summary>
        public virtual string Alias { get; internal set; }
        /// <summary><p>Name of Namespace.</p></summary>
        public virtual string NamespaceName { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
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
              .Add("eventhubs georecovery-alias delete")
              .Add("--alias {value}", Alias)
              .Add("--namespace-name {value}", NamespaceName)
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
    #region AzureEventhubsGeorecoveryAliasExistsSettings
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventhubsGeorecoveryAliasExistsSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureEventhubs executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureEventhubsTasks.AzureEventhubsPath;
        /// <summary><p>Name of Geo Recovery Configs - Alias to check availability.</p></summary>
        public virtual string Alias { get; internal set; }
        /// <summary><p>Name of Namespace.</p></summary>
        public virtual string NamespaceName { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
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
              .Add("eventhubs georecovery-alias exists")
              .Add("--alias {value}", Alias)
              .Add("--namespace-name {value}", NamespaceName)
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
    #region AzureEventhubsGeorecoveryAliasFailOverSettings
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventhubsGeorecoveryAliasFailOverSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureEventhubs executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureEventhubsTasks.AzureEventhubsPath;
        /// <summary><p>Name of Geo-Disaster Recovery Configuration Alias.</p></summary>
        public virtual string Alias { get; internal set; }
        /// <summary><p>Name of Namespace.</p></summary>
        public virtual string NamespaceName { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
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
              .Add("eventhubs georecovery-alias fail-over")
              .Add("--alias {value}", Alias)
              .Add("--namespace-name {value}", NamespaceName)
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
    #region AzureEventhubsGeorecoveryAliasListSettings
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventhubsGeorecoveryAliasListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureEventhubs executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureEventhubsTasks.AzureEventhubsPath;
        /// <summary><p>Name of Namespace.</p></summary>
        public virtual string NamespaceName { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
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
              .Add("eventhubs georecovery-alias list")
              .Add("--namespace-name {value}", NamespaceName)
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
    #region AzureEventhubsGeorecoveryAliasSetSettings
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventhubsGeorecoveryAliasSetSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureEventhubs executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureEventhubsTasks.AzureEventhubsPath;
        /// <summary><p>Name of Geo-Disaster Recovery Configuration Alias.</p></summary>
        public virtual string Alias { get; internal set; }
        /// <summary><p>Name of Namespace.</p></summary>
        public virtual string NamespaceName { get; internal set; }
        /// <summary><p>Name (if within the same resource group) or ARM Id of the Primary/Secondary eventhub namespace name, which is part of GEO DR pairing.</p></summary>
        public virtual string PartnerNamespace { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Alternate Name for the Alias, when the Namespace name and Alias name are same.</p></summary>
        public virtual string AlternateName { get; internal set; }
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
              .Add("eventhubs georecovery-alias set")
              .Add("--alias {value}", Alias)
              .Add("--namespace-name {value}", NamespaceName)
              .Add("--partner-namespace {value}", PartnerNamespace)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--alternate-name {value}", AlternateName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureEventhubsGeorecoveryAliasShowSettings
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventhubsGeorecoveryAliasShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureEventhubs executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureEventhubsTasks.AzureEventhubsPath;
        /// <summary><p>Name of Geo-Disaster Recovery Configuration Alias.</p></summary>
        public virtual string Alias { get; internal set; }
        /// <summary><p>Name of Namespace.</p></summary>
        public virtual string NamespaceName { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
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
              .Add("eventhubs georecovery-alias show")
              .Add("--alias {value}", Alias)
              .Add("--namespace-name {value}", NamespaceName)
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
    #region AzureEventhubsNamespaceCreateSettings
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventhubsNamespaceCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureEventhubs executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureEventhubsTasks.AzureEventhubsPath;
        /// <summary><p>Name of Namespace.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Capacity for Sku.</p></summary>
        public virtual string Capacity { get; internal set; }
        /// <summary><p>A boolean value that indicates whether AutoInflate is enabled for eventhub namespace.</p></summary>
        public virtual bool? EnableAutoInflate { get; internal set; }
        /// <summary><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        public virtual string Location { get; internal set; }
        /// <summary><p>Upper limit of throughput units when AutoInflate is enabled, vaule should be within 0 to 20 throughput units. ( 0 if AutoInflateEnabled = true).</p></summary>
        public virtual string MaximumThroughputUnits { get; internal set; }
        /// <summary><p></p></summary>
        public virtual EventhubsNamespaceSku Sku { get; internal set; }
        /// <summary><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        public virtual string Tags { get; internal set; }
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
              .Add("eventhubs namespace create")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--capacity {value}", Capacity)
              .Add("--enable-auto-inflate", EnableAutoInflate)
              .Add("--location {value}", Location)
              .Add("--maximum-throughput-units {value}", MaximumThroughputUnits)
              .Add("--sku {value}", Sku)
              .Add("--tags {value}", Tags)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureEventhubsNamespaceDeleteSettings
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventhubsNamespaceDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureEventhubs executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureEventhubsTasks.AzureEventhubsPath;
        /// <summary><p>Name of Namespace.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
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
              .Add("eventhubs namespace delete")
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
    #region AzureEventhubsNamespaceExistsSettings
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventhubsNamespaceExistsSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureEventhubs executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureEventhubsTasks.AzureEventhubsPath;
        /// <summary><p>Name to check the namespace name availability.</p></summary>
        public virtual string Name { get; internal set; }
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
              .Add("eventhubs namespace exists")
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
    #region AzureEventhubsNamespaceListSettings
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventhubsNamespaceListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureEventhubs executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureEventhubsTasks.AzureEventhubsPath;
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
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
              .Add("eventhubs namespace list")
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
    #region AzureEventhubsNamespaceShowSettings
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventhubsNamespaceShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureEventhubs executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureEventhubsTasks.AzureEventhubsPath;
        /// <summary><p>Name of Namespace.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
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
              .Add("eventhubs namespace show")
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
    #region AzureEventhubsNamespaceUpdateSettings
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventhubsNamespaceUpdateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureEventhubs executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureEventhubsTasks.AzureEventhubsPath;
        /// <summary><p>Name of Namespace.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Capacity for Sku.</p></summary>
        public virtual string Capacity { get; internal set; }
        /// <summary><p>A boolean value that indicates whether AutoInflate is enabled for eventhub namespace.</p></summary>
        public virtual bool? EnableAutoInflate { get; internal set; }
        /// <summary><p>Upper limit of throughput units when AutoInflate is enabled, vaule should be within 0 to 20 throughput units. ( 0 if AutoInflateEnabled = true).</p></summary>
        public virtual string MaximumThroughputUnits { get; internal set; }
        /// <summary><p></p></summary>
        public virtual EventhubsNamespaceSku Sku { get; internal set; }
        /// <summary><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        public virtual string Tags { get; internal set; }
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
              .Add("eventhubs namespace update")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--capacity {value}", Capacity)
              .Add("--enable-auto-inflate", EnableAutoInflate)
              .Add("--maximum-throughput-units {value}", MaximumThroughputUnits)
              .Add("--sku {value}", Sku)
              .Add("--tags {value}", Tags)
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
    #region AzureEventhubsEventhubCreateSettings
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventhubsEventhubCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureEventhubs executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureEventhubsTasks.AzureEventhubsPath;
        /// <summary><p>Name of Eventhub.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of Namespace.</p></summary>
        public virtual string NamespaceName { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>A boolean value that indicates whether capture description is enabled.</p></summary>
        public virtual bool? EnableCapture { get; internal set; }
        /// <summary><p>Number of days to retain events for this Event Hub, value should be 1 to 7 days.</p></summary>
        public virtual int? MessageRetention { get; internal set; }
        /// <summary><p>Number of partitions created for the Event Hub. By default, allowed values are 2-32. Lower value of 1 is supported with Kafka enabled namespaces. In presence of a custom quota, the upper limit will match the upper limit of the quota.</p></summary>
        public virtual int? PartitionCount { get; internal set; }
        /// <summary><p>Status of Eventhub.</p></summary>
        public virtual EventhubsEventhubStatus Status { get; internal set; }
        /// <summary><p>Allows you to set the frequency with which the capture to Azure Blobs will happen, value should between 60 to 900 seconds.</p></summary>
        public virtual string CaptureInterval { get; internal set; }
        /// <summary><p>Defines the amount of data built up in your Event Hub before an capture operation, value should be between 10485760 to 524288000 bytes.</p></summary>
        public virtual string CaptureSizeLimit { get; internal set; }
        /// <summary><p>Blob naming convention for archive, e.g. {Namespace}/{EventHub}/{PartitionId}/{Year}/{Month}/{Day}/{Hour}/{Minute}/{Second}. Here all the parameters (Namespace,EventHub .. etc) are mandatory irrespective of order.</p></summary>
        public virtual string ArchiveNameFormat { get; internal set; }
        /// <summary><p>Blob container Name.</p></summary>
        public virtual string BlobContainer { get; internal set; }
        /// <summary><p>Name for capture destination.</p></summary>
        public virtual string DestinationName { get; internal set; }
        /// <summary><p>Name (if within same resource group and not of type Classic Storage) or ARM id of the storage account to be used to create the blobs.</p></summary>
        public virtual string StorageAccount { get; internal set; }
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
              .Add("eventhubs eventhub create")
              .Add("--name {value}", Name)
              .Add("--namespace-name {value}", NamespaceName)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--enable-capture", EnableCapture)
              .Add("--message-retention {value}", MessageRetention)
              .Add("--partition-count {value}", PartitionCount)
              .Add("--status {value}", Status)
              .Add("--capture-interval {value}", CaptureInterval)
              .Add("--capture-size-limit {value}", CaptureSizeLimit)
              .Add("--archive-name-format {value}", ArchiveNameFormat)
              .Add("--blob-container {value}", BlobContainer)
              .Add("--destination-name {value}", DestinationName)
              .Add("--storage-account {value}", StorageAccount)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureEventhubsEventhubDeleteSettings
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventhubsEventhubDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureEventhubs executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureEventhubsTasks.AzureEventhubsPath;
        /// <summary><p>Name of Eventhub.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of Namespace.</p></summary>
        public virtual string NamespaceName { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
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
              .Add("eventhubs eventhub delete")
              .Add("--name {value}", Name)
              .Add("--namespace-name {value}", NamespaceName)
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
    #region AzureEventhubsEventhubListSettings
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventhubsEventhubListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureEventhubs executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureEventhubsTasks.AzureEventhubsPath;
        /// <summary><p>Name of Namespace.</p></summary>
        public virtual string NamespaceName { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Skip is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skip parameter that specifies a starting point to use for subsequent calls.</p></summary>
        public virtual string Skip { get; internal set; }
        /// <summary><p>May be used to limit the number of results to the most recent N usageDetails.</p></summary>
        public virtual string Top { get; internal set; }
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
              .Add("eventhubs eventhub list")
              .Add("--namespace-name {value}", NamespaceName)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--skip {value}", Skip)
              .Add("--top {value}", Top)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureEventhubsEventhubShowSettings
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventhubsEventhubShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureEventhubs executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureEventhubsTasks.AzureEventhubsPath;
        /// <summary><p>Name of Eventhub.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of Namespace.</p></summary>
        public virtual string NamespaceName { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
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
              .Add("eventhubs eventhub show")
              .Add("--name {value}", Name)
              .Add("--namespace-name {value}", NamespaceName)
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
    #region AzureEventhubsEventhubUpdateSettings
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventhubsEventhubUpdateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureEventhubs executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureEventhubsTasks.AzureEventhubsPath;
        /// <summary><p>Name of Eventhub.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of Namespace.</p></summary>
        public virtual string NamespaceName { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>A boolean value that indicates whether capture description is enabled.</p></summary>
        public virtual bool? EnableCapture { get; internal set; }
        /// <summary><p>Number of days to retain events for this Event Hub, value should be 1 to 7 days.</p></summary>
        public virtual int? MessageRetention { get; internal set; }
        /// <summary><p>Number of partitions created for the Event Hub. By default, allowed values are 2-32. Lower value of 1 is supported with Kafka enabled namespaces. In presence of a custom quota, the upper limit will match the upper limit of the quota.</p></summary>
        public virtual int? PartitionCount { get; internal set; }
        /// <summary><p>Status of Eventhub.</p></summary>
        public virtual EventhubsEventhubStatus Status { get; internal set; }
        /// <summary><p>Allows you to set the frequency with which the capture to Azure Blobs will happen, value should between 60 to 900 seconds.</p></summary>
        public virtual string CaptureInterval { get; internal set; }
        /// <summary><p>Defines the amount of data built up in your Event Hub before an capture operation, value should be between 10485760 to 524288000 bytes.</p></summary>
        public virtual string CaptureSizeLimit { get; internal set; }
        /// <summary><p>Blob naming convention for archive, e.g. {Namespace}/{EventHub}/{PartitionId}/{Year}/{Month}/{Day}/{Hour}/{Minute}/{Second}. Here all the parameters (Namespace,EventHub .. etc) are mandatory irrespective of order.</p></summary>
        public virtual string ArchiveNameFormat { get; internal set; }
        /// <summary><p>Blob container Name.</p></summary>
        public virtual string BlobContainer { get; internal set; }
        /// <summary><p>Name for capture destination.</p></summary>
        public virtual string DestinationName { get; internal set; }
        /// <summary><p>Name (if within same resource group and not of type Classic Storage) or ARM id of the storage account to be used to create the blobs.</p></summary>
        public virtual string StorageAccount { get; internal set; }
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
              .Add("eventhubs eventhub update")
              .Add("--name {value}", Name)
              .Add("--namespace-name {value}", NamespaceName)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--enable-capture", EnableCapture)
              .Add("--message-retention {value}", MessageRetention)
              .Add("--partition-count {value}", PartitionCount)
              .Add("--status {value}", Status)
              .Add("--capture-interval {value}", CaptureInterval)
              .Add("--capture-size-limit {value}", CaptureSizeLimit)
              .Add("--archive-name-format {value}", ArchiveNameFormat)
              .Add("--blob-container {value}", BlobContainer)
              .Add("--destination-name {value}", DestinationName)
              .Add("--storage-account {value}", StorageAccount)
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
    #region AzureEventhubsNamespaceAuthorizationRuleCreateSettings
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventhubsNamespaceAuthorizationRuleCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureEventhubs executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureEventhubsTasks.AzureEventhubsPath;
        /// <summary><p>Name of Namespace AuthorizationRule.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of Namespace.</p></summary>
        public virtual string NamespaceName { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Space-separated list of Authorization rule rights.</p></summary>
        public virtual IReadOnlyList<EventhubsNamespaceAuthorizationRuleRights> Rights => RightsInternal.AsReadOnly();
        internal List<EventhubsNamespaceAuthorizationRuleRights> RightsInternal { get; set; } = new List<EventhubsNamespaceAuthorizationRuleRights>();
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
              .Add("eventhubs namespace authorization-rule create")
              .Add("--name {value}", Name)
              .Add("--namespace-name {value}", NamespaceName)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--rights {value}", Rights, separator: ' ')
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureEventhubsNamespaceAuthorizationRuleDeleteSettings
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventhubsNamespaceAuthorizationRuleDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureEventhubs executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureEventhubsTasks.AzureEventhubsPath;
        /// <summary><p>Name of Namespace AuthorizationRule.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of Namespace.</p></summary>
        public virtual string NamespaceName { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
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
              .Add("eventhubs namespace authorization-rule delete")
              .Add("--name {value}", Name)
              .Add("--namespace-name {value}", NamespaceName)
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
    #region AzureEventhubsNamespaceAuthorizationRuleListSettings
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventhubsNamespaceAuthorizationRuleListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureEventhubs executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureEventhubsTasks.AzureEventhubsPath;
        /// <summary><p>Name of Namespace.</p></summary>
        public virtual string NamespaceName { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
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
              .Add("eventhubs namespace authorization-rule list")
              .Add("--namespace-name {value}", NamespaceName)
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
    #region AzureEventhubsNamespaceAuthorizationRuleShowSettings
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventhubsNamespaceAuthorizationRuleShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureEventhubs executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureEventhubsTasks.AzureEventhubsPath;
        /// <summary><p>Name of Namespace AuthorizationRule.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of Namespace.</p></summary>
        public virtual string NamespaceName { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
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
              .Add("eventhubs namespace authorization-rule show")
              .Add("--name {value}", Name)
              .Add("--namespace-name {value}", NamespaceName)
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
    #region AzureEventhubsNamespaceAuthorizationRuleUpdateSettings
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventhubsNamespaceAuthorizationRuleUpdateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureEventhubs executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureEventhubsTasks.AzureEventhubsPath;
        /// <summary><p>Name of Namespace AuthorizationRule.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of Namespace.</p></summary>
        public virtual string NamespaceName { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Space-separated list of Authorization rule rights.</p></summary>
        public virtual IReadOnlyList<EventhubsNamespaceAuthorizationRuleRights> Rights => RightsInternal.AsReadOnly();
        internal List<EventhubsNamespaceAuthorizationRuleRights> RightsInternal { get; set; } = new List<EventhubsNamespaceAuthorizationRuleRights>();
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
              .Add("eventhubs namespace authorization-rule update")
              .Add("--name {value}", Name)
              .Add("--namespace-name {value}", NamespaceName)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--rights {value}", Rights, separator: ' ')
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
    #region AzureEventhubsGeorecoveryAliasAuthorizationRuleListSettings
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventhubsGeorecoveryAliasAuthorizationRuleListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureEventhubs executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureEventhubsTasks.AzureEventhubsPath;
        /// <summary><p>Name of Geo-Disaster Recovery Configuration Alias.</p></summary>
        public virtual string Alias { get; internal set; }
        /// <summary><p>Name of Namespace.</p></summary>
        public virtual string NamespaceName { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
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
              .Add("eventhubs georecovery-alias authorization-rule list")
              .Add("--alias {value}", Alias)
              .Add("--namespace-name {value}", NamespaceName)
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
    #region AzureEventhubsGeorecoveryAliasAuthorizationRuleShowSettings
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventhubsGeorecoveryAliasAuthorizationRuleShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureEventhubs executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureEventhubsTasks.AzureEventhubsPath;
        /// <summary><p>Name of Geo-Disaster Recovery Configuration Alias.</p></summary>
        public virtual string Alias { get; internal set; }
        /// <summary><p>Name of Namespace AuthorizationRule.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of Namespace.</p></summary>
        public virtual string NamespaceName { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
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
              .Add("eventhubs georecovery-alias authorization-rule show")
              .Add("--alias {value}", Alias)
              .Add("--name {value}", Name)
              .Add("--namespace-name {value}", NamespaceName)
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
    #region AzureEventhubsEventhubConsumerGroupCreateSettings
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventhubsEventhubConsumerGroupCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureEventhubs executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureEventhubsTasks.AzureEventhubsPath;
        /// <summary><p>Name of EventHub.</p></summary>
        public virtual string EventhubName { get; internal set; }
        /// <summary><p>Name of ConsumerGroup.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of Namespace.</p></summary>
        public virtual string NamespaceName { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Usermetadata is a placeholder to store user-defined string data with maximum length 1024. e.g. it can be used to store descriptive data, such as list of teams and their contact information also user-defined configuration settings can be stored.</p></summary>
        public virtual string UserMetadata { get; internal set; }
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
              .Add("eventhubs eventhub consumer-group create")
              .Add("--eventhub-name {value}", EventhubName)
              .Add("--name {value}", Name)
              .Add("--namespace-name {value}", NamespaceName)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--user-metadata {value}", UserMetadata)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureEventhubsEventhubConsumerGroupDeleteSettings
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventhubsEventhubConsumerGroupDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureEventhubs executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureEventhubsTasks.AzureEventhubsPath;
        /// <summary><p>Name of EventHub.</p></summary>
        public virtual string EventhubName { get; internal set; }
        /// <summary><p>Name of ConsumerGroup.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of Namespace.</p></summary>
        public virtual string NamespaceName { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
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
              .Add("eventhubs eventhub consumer-group delete")
              .Add("--eventhub-name {value}", EventhubName)
              .Add("--name {value}", Name)
              .Add("--namespace-name {value}", NamespaceName)
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
    #region AzureEventhubsEventhubConsumerGroupListSettings
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventhubsEventhubConsumerGroupListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureEventhubs executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureEventhubsTasks.AzureEventhubsPath;
        /// <summary><p>Name of EventHub.</p></summary>
        public virtual string EventhubName { get; internal set; }
        /// <summary><p>Name of Namespace.</p></summary>
        public virtual string NamespaceName { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Skip is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skip parameter that specifies a starting point to use for subsequent calls.</p></summary>
        public virtual string Skip { get; internal set; }
        /// <summary><p>May be used to limit the number of results to the most recent N usageDetails.</p></summary>
        public virtual string Top { get; internal set; }
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
              .Add("eventhubs eventhub consumer-group list")
              .Add("--eventhub-name {value}", EventhubName)
              .Add("--namespace-name {value}", NamespaceName)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--skip {value}", Skip)
              .Add("--top {value}", Top)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureEventhubsEventhubConsumerGroupShowSettings
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventhubsEventhubConsumerGroupShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureEventhubs executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureEventhubsTasks.AzureEventhubsPath;
        /// <summary><p>Name of EventHub.</p></summary>
        public virtual string EventhubName { get; internal set; }
        /// <summary><p>Name of ConsumerGroup.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of Namespace.</p></summary>
        public virtual string NamespaceName { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
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
              .Add("eventhubs eventhub consumer-group show")
              .Add("--eventhub-name {value}", EventhubName)
              .Add("--name {value}", Name)
              .Add("--namespace-name {value}", NamespaceName)
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
    #region AzureEventhubsEventhubConsumerGroupUpdateSettings
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventhubsEventhubConsumerGroupUpdateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureEventhubs executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureEventhubsTasks.AzureEventhubsPath;
        /// <summary><p>Name of EventHub.</p></summary>
        public virtual string EventhubName { get; internal set; }
        /// <summary><p>Name of ConsumerGroup.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of Namespace.</p></summary>
        public virtual string NamespaceName { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Usermetadata is a placeholder to store user-defined string data with maximum length 1024. e.g. it can be used to store descriptive data, such as list of teams and their contact information also user-defined configuration settings can be stored.</p></summary>
        public virtual string UserMetadata { get; internal set; }
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
              .Add("eventhubs eventhub consumer-group update")
              .Add("--eventhub-name {value}", EventhubName)
              .Add("--name {value}", Name)
              .Add("--namespace-name {value}", NamespaceName)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--user-metadata {value}", UserMetadata)
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
    #region AzureEventhubsEventhubAuthorizationRuleCreateSettings
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventhubsEventhubAuthorizationRuleCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureEventhubs executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureEventhubsTasks.AzureEventhubsPath;
        /// <summary><p>Name of EventHub.</p></summary>
        public virtual string EventhubName { get; internal set; }
        /// <summary><p>Name of EventHub AuthorizationRule.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of Namespace.</p></summary>
        public virtual string NamespaceName { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Space-separated list of Authorization rule rights.</p></summary>
        public virtual IReadOnlyList<EventhubsNamespaceAuthorizationRuleRights> Rights => RightsInternal.AsReadOnly();
        internal List<EventhubsNamespaceAuthorizationRuleRights> RightsInternal { get; set; } = new List<EventhubsNamespaceAuthorizationRuleRights>();
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
              .Add("eventhubs eventhub authorization-rule create")
              .Add("--eventhub-name {value}", EventhubName)
              .Add("--name {value}", Name)
              .Add("--namespace-name {value}", NamespaceName)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--rights {value}", Rights, separator: ' ')
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureEventhubsEventhubAuthorizationRuleDeleteSettings
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventhubsEventhubAuthorizationRuleDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureEventhubs executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureEventhubsTasks.AzureEventhubsPath;
        /// <summary><p>Name of EventHub.</p></summary>
        public virtual string EventhubName { get; internal set; }
        /// <summary><p>Name of EventHub AuthorizationRule.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of Namespace.</p></summary>
        public virtual string NamespaceName { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
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
              .Add("eventhubs eventhub authorization-rule delete")
              .Add("--eventhub-name {value}", EventhubName)
              .Add("--name {value}", Name)
              .Add("--namespace-name {value}", NamespaceName)
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
    #region AzureEventhubsEventhubAuthorizationRuleListSettings
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventhubsEventhubAuthorizationRuleListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureEventhubs executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureEventhubsTasks.AzureEventhubsPath;
        /// <summary><p>Name of EventHub.</p></summary>
        public virtual string EventhubName { get; internal set; }
        /// <summary><p>Name of Namespace.</p></summary>
        public virtual string NamespaceName { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
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
              .Add("eventhubs eventhub authorization-rule list")
              .Add("--eventhub-name {value}", EventhubName)
              .Add("--namespace-name {value}", NamespaceName)
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
    #region AzureEventhubsEventhubAuthorizationRuleShowSettings
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventhubsEventhubAuthorizationRuleShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureEventhubs executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureEventhubsTasks.AzureEventhubsPath;
        /// <summary><p>Name of EventHub.</p></summary>
        public virtual string EventhubName { get; internal set; }
        /// <summary><p>Name of EventHub AuthorizationRule.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of Namespace.</p></summary>
        public virtual string NamespaceName { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
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
              .Add("eventhubs eventhub authorization-rule show")
              .Add("--eventhub-name {value}", EventhubName)
              .Add("--name {value}", Name)
              .Add("--namespace-name {value}", NamespaceName)
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
    #region AzureEventhubsEventhubAuthorizationRuleUpdateSettings
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventhubsEventhubAuthorizationRuleUpdateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureEventhubs executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureEventhubsTasks.AzureEventhubsPath;
        /// <summary><p>Name of EventHub.</p></summary>
        public virtual string EventhubName { get; internal set; }
        /// <summary><p>Name of EventHub AuthorizationRule.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of Namespace.</p></summary>
        public virtual string NamespaceName { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Space-separated list of Authorization rule rights.</p></summary>
        public virtual IReadOnlyList<EventhubsNamespaceAuthorizationRuleRights> Rights => RightsInternal.AsReadOnly();
        internal List<EventhubsNamespaceAuthorizationRuleRights> RightsInternal { get; set; } = new List<EventhubsNamespaceAuthorizationRuleRights>();
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
              .Add("eventhubs eventhub authorization-rule update")
              .Add("--eventhub-name {value}", EventhubName)
              .Add("--name {value}", Name)
              .Add("--namespace-name {value}", NamespaceName)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--rights {value}", Rights, separator: ' ')
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
    #region AzureEventhubsNamespaceAuthorizationRuleKeysListSettings
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventhubsNamespaceAuthorizationRuleKeysListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureEventhubs executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureEventhubsTasks.AzureEventhubsPath;
        /// <summary><p>Name of Namespace AuthorizationRule.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of Namespace.</p></summary>
        public virtual string NamespaceName { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
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
              .Add("eventhubs namespace authorization-rule keys list")
              .Add("--name {value}", Name)
              .Add("--namespace-name {value}", NamespaceName)
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
    #region AzureEventhubsNamespaceAuthorizationRuleKeysRenewSettings
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventhubsNamespaceAuthorizationRuleKeysRenewSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureEventhubs executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureEventhubsTasks.AzureEventhubsPath;
        /// <summary><p>Specifies Primary or Secondary key needs to be reset.</p></summary>
        public virtual EventhubsNamespaceAuthorizationRuleKeysKey Key { get; internal set; }
        /// <summary><p>Name of Namespace AuthorizationRule.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of Namespace.</p></summary>
        public virtual string NamespaceName { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Optional, if the key value provided, is set for KeyType or autogenerated Key value set for keyType.</p></summary>
        public virtual string KeyValue { get; internal set; }
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
              .Add("eventhubs namespace authorization-rule keys renew")
              .Add("--key {value}", Key)
              .Add("--name {value}", Name)
              .Add("--namespace-name {value}", NamespaceName)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--key-value {value}", KeyValue)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureEventhubsGeorecoveryAliasAuthorizationRuleKeysListSettings
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventhubsGeorecoveryAliasAuthorizationRuleKeysListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureEventhubs executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureEventhubsTasks.AzureEventhubsPath;
        /// <summary><p>Name of Geo-Disaster Recovery Configuration Alias.</p></summary>
        public virtual string Alias { get; internal set; }
        /// <summary><p>Name of Namespace AuthorizationRule.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of Namespace.</p></summary>
        public virtual string NamespaceName { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
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
              .Add("eventhubs georecovery-alias authorization-rule keys list")
              .Add("--alias {value}", Alias)
              .Add("--name {value}", Name)
              .Add("--namespace-name {value}", NamespaceName)
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
    #region AzureEventhubsEventhubAuthorizationRuleKeysListSettings
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventhubsEventhubAuthorizationRuleKeysListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureEventhubs executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureEventhubsTasks.AzureEventhubsPath;
        /// <summary><p>Name of EventHub.</p></summary>
        public virtual string EventhubName { get; internal set; }
        /// <summary><p>Name of EventHub AuthorizationRule.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of Namespace.</p></summary>
        public virtual string NamespaceName { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
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
              .Add("eventhubs eventhub authorization-rule keys list")
              .Add("--eventhub-name {value}", EventhubName)
              .Add("--name {value}", Name)
              .Add("--namespace-name {value}", NamespaceName)
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
    #region AzureEventhubsEventhubAuthorizationRuleKeysRenewSettings
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventhubsEventhubAuthorizationRuleKeysRenewSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureEventhubs executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureEventhubsTasks.AzureEventhubsPath;
        /// <summary><p>Name of EventHub.</p></summary>
        public virtual string EventhubName { get; internal set; }
        /// <summary><p>Specifies Primary or Secondary key needs to be reset.</p></summary>
        public virtual EventhubsNamespaceAuthorizationRuleKeysKey Key { get; internal set; }
        /// <summary><p>Name of EventHub AuthorizationRule.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of Namespace.</p></summary>
        public virtual string NamespaceName { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Optional, if the key value provided, is set for KeyType or autogenerated Key value set for keyType.</p></summary>
        public virtual string KeyValue { get; internal set; }
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
              .Add("eventhubs eventhub authorization-rule keys renew")
              .Add("--eventhub-name {value}", EventhubName)
              .Add("--key {value}", Key)
              .Add("--name {value}", Name)
              .Add("--namespace-name {value}", NamespaceName)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--key-value {value}", KeyValue)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureEventhubsSettingsExtensions
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventhubsSettingsExtensions
    {
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureEventhubsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsSettings SetDebug(this AzureEventhubsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsSettings ResetDebug(this AzureEventhubsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureEventhubsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventhubsSettings SetHelp(this AzureEventhubsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventhubsSettings ResetHelp(this AzureEventhubsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureEventhubsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventhubsSettings SetOutput(this AzureEventhubsSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventhubsSettings ResetOutput(this AzureEventhubsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureEventhubsSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventhubsSettings SetQuery(this AzureEventhubsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventhubsSettings ResetQuery(this AzureEventhubsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureEventhubsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsSettings SetVerbose(this AzureEventhubsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsSettings ResetVerbose(this AzureEventhubsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureEventhubsGeorecoveryAliasBreakPairSettingsExtensions
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventhubsGeorecoveryAliasBreakPairSettingsExtensions
    {
        #region Alias
        /// <summary><p><em>Sets <see cref="AzureEventhubsGeorecoveryAliasBreakPairSettings.Alias"/>.</em></p><p>Name of Geo-Disaster Recovery Configuration Alias.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasBreakPairSettings SetAlias(this AzureEventhubsGeorecoveryAliasBreakPairSettings toolSettings, string alias)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Alias = alias;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsGeorecoveryAliasBreakPairSettings.Alias"/>.</em></p><p>Name of Geo-Disaster Recovery Configuration Alias.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasBreakPairSettings ResetAlias(this AzureEventhubsGeorecoveryAliasBreakPairSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Alias = null;
            return toolSettings;
        }
        #endregion
        #region NamespaceName
        /// <summary><p><em>Sets <see cref="AzureEventhubsGeorecoveryAliasBreakPairSettings.NamespaceName"/>.</em></p><p>Name of Namespace.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasBreakPairSettings SetNamespaceName(this AzureEventhubsGeorecoveryAliasBreakPairSettings toolSettings, string namespaceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = namespaceName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsGeorecoveryAliasBreakPairSettings.NamespaceName"/>.</em></p><p>Name of Namespace.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasBreakPairSettings ResetNamespaceName(this AzureEventhubsGeorecoveryAliasBreakPairSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureEventhubsGeorecoveryAliasBreakPairSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasBreakPairSettings SetResourceGroup(this AzureEventhubsGeorecoveryAliasBreakPairSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsGeorecoveryAliasBreakPairSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasBreakPairSettings ResetResourceGroup(this AzureEventhubsGeorecoveryAliasBreakPairSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureEventhubsGeorecoveryAliasBreakPairSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasBreakPairSettings SetDebug(this AzureEventhubsGeorecoveryAliasBreakPairSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsGeorecoveryAliasBreakPairSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasBreakPairSettings ResetDebug(this AzureEventhubsGeorecoveryAliasBreakPairSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureEventhubsGeorecoveryAliasBreakPairSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasBreakPairSettings SetHelp(this AzureEventhubsGeorecoveryAliasBreakPairSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsGeorecoveryAliasBreakPairSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasBreakPairSettings ResetHelp(this AzureEventhubsGeorecoveryAliasBreakPairSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureEventhubsGeorecoveryAliasBreakPairSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasBreakPairSettings SetOutput(this AzureEventhubsGeorecoveryAliasBreakPairSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsGeorecoveryAliasBreakPairSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasBreakPairSettings ResetOutput(this AzureEventhubsGeorecoveryAliasBreakPairSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureEventhubsGeorecoveryAliasBreakPairSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasBreakPairSettings SetQuery(this AzureEventhubsGeorecoveryAliasBreakPairSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsGeorecoveryAliasBreakPairSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasBreakPairSettings ResetQuery(this AzureEventhubsGeorecoveryAliasBreakPairSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureEventhubsGeorecoveryAliasBreakPairSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasBreakPairSettings SetVerbose(this AzureEventhubsGeorecoveryAliasBreakPairSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsGeorecoveryAliasBreakPairSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasBreakPairSettings ResetVerbose(this AzureEventhubsGeorecoveryAliasBreakPairSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureEventhubsGeorecoveryAliasDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventhubsGeorecoveryAliasDeleteSettingsExtensions
    {
        #region Alias
        /// <summary><p><em>Sets <see cref="AzureEventhubsGeorecoveryAliasDeleteSettings.Alias"/>.</em></p><p>Name of Geo-Disaster Recovery Configuration Alias.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasDeleteSettings SetAlias(this AzureEventhubsGeorecoveryAliasDeleteSettings toolSettings, string alias)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Alias = alias;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsGeorecoveryAliasDeleteSettings.Alias"/>.</em></p><p>Name of Geo-Disaster Recovery Configuration Alias.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasDeleteSettings ResetAlias(this AzureEventhubsGeorecoveryAliasDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Alias = null;
            return toolSettings;
        }
        #endregion
        #region NamespaceName
        /// <summary><p><em>Sets <see cref="AzureEventhubsGeorecoveryAliasDeleteSettings.NamespaceName"/>.</em></p><p>Name of Namespace.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasDeleteSettings SetNamespaceName(this AzureEventhubsGeorecoveryAliasDeleteSettings toolSettings, string namespaceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = namespaceName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsGeorecoveryAliasDeleteSettings.NamespaceName"/>.</em></p><p>Name of Namespace.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasDeleteSettings ResetNamespaceName(this AzureEventhubsGeorecoveryAliasDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureEventhubsGeorecoveryAliasDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasDeleteSettings SetResourceGroup(this AzureEventhubsGeorecoveryAliasDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsGeorecoveryAliasDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasDeleteSettings ResetResourceGroup(this AzureEventhubsGeorecoveryAliasDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureEventhubsGeorecoveryAliasDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasDeleteSettings SetDebug(this AzureEventhubsGeorecoveryAliasDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsGeorecoveryAliasDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasDeleteSettings ResetDebug(this AzureEventhubsGeorecoveryAliasDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureEventhubsGeorecoveryAliasDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasDeleteSettings SetHelp(this AzureEventhubsGeorecoveryAliasDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsGeorecoveryAliasDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasDeleteSettings ResetHelp(this AzureEventhubsGeorecoveryAliasDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureEventhubsGeorecoveryAliasDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasDeleteSettings SetOutput(this AzureEventhubsGeorecoveryAliasDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsGeorecoveryAliasDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasDeleteSettings ResetOutput(this AzureEventhubsGeorecoveryAliasDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureEventhubsGeorecoveryAliasDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasDeleteSettings SetQuery(this AzureEventhubsGeorecoveryAliasDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsGeorecoveryAliasDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasDeleteSettings ResetQuery(this AzureEventhubsGeorecoveryAliasDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureEventhubsGeorecoveryAliasDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasDeleteSettings SetVerbose(this AzureEventhubsGeorecoveryAliasDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsGeorecoveryAliasDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasDeleteSettings ResetVerbose(this AzureEventhubsGeorecoveryAliasDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureEventhubsGeorecoveryAliasExistsSettingsExtensions
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventhubsGeorecoveryAliasExistsSettingsExtensions
    {
        #region Alias
        /// <summary><p><em>Sets <see cref="AzureEventhubsGeorecoveryAliasExistsSettings.Alias"/>.</em></p><p>Name of Geo Recovery Configs - Alias to check availability.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasExistsSettings SetAlias(this AzureEventhubsGeorecoveryAliasExistsSettings toolSettings, string alias)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Alias = alias;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsGeorecoveryAliasExistsSettings.Alias"/>.</em></p><p>Name of Geo Recovery Configs - Alias to check availability.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasExistsSettings ResetAlias(this AzureEventhubsGeorecoveryAliasExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Alias = null;
            return toolSettings;
        }
        #endregion
        #region NamespaceName
        /// <summary><p><em>Sets <see cref="AzureEventhubsGeorecoveryAliasExistsSettings.NamespaceName"/>.</em></p><p>Name of Namespace.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasExistsSettings SetNamespaceName(this AzureEventhubsGeorecoveryAliasExistsSettings toolSettings, string namespaceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = namespaceName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsGeorecoveryAliasExistsSettings.NamespaceName"/>.</em></p><p>Name of Namespace.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasExistsSettings ResetNamespaceName(this AzureEventhubsGeorecoveryAliasExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureEventhubsGeorecoveryAliasExistsSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasExistsSettings SetResourceGroup(this AzureEventhubsGeorecoveryAliasExistsSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsGeorecoveryAliasExistsSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasExistsSettings ResetResourceGroup(this AzureEventhubsGeorecoveryAliasExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureEventhubsGeorecoveryAliasExistsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasExistsSettings SetDebug(this AzureEventhubsGeorecoveryAliasExistsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsGeorecoveryAliasExistsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasExistsSettings ResetDebug(this AzureEventhubsGeorecoveryAliasExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureEventhubsGeorecoveryAliasExistsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasExistsSettings SetHelp(this AzureEventhubsGeorecoveryAliasExistsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsGeorecoveryAliasExistsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasExistsSettings ResetHelp(this AzureEventhubsGeorecoveryAliasExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureEventhubsGeorecoveryAliasExistsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasExistsSettings SetOutput(this AzureEventhubsGeorecoveryAliasExistsSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsGeorecoveryAliasExistsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasExistsSettings ResetOutput(this AzureEventhubsGeorecoveryAliasExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureEventhubsGeorecoveryAliasExistsSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasExistsSettings SetQuery(this AzureEventhubsGeorecoveryAliasExistsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsGeorecoveryAliasExistsSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasExistsSettings ResetQuery(this AzureEventhubsGeorecoveryAliasExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureEventhubsGeorecoveryAliasExistsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasExistsSettings SetVerbose(this AzureEventhubsGeorecoveryAliasExistsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsGeorecoveryAliasExistsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasExistsSettings ResetVerbose(this AzureEventhubsGeorecoveryAliasExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureEventhubsGeorecoveryAliasFailOverSettingsExtensions
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventhubsGeorecoveryAliasFailOverSettingsExtensions
    {
        #region Alias
        /// <summary><p><em>Sets <see cref="AzureEventhubsGeorecoveryAliasFailOverSettings.Alias"/>.</em></p><p>Name of Geo-Disaster Recovery Configuration Alias.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasFailOverSettings SetAlias(this AzureEventhubsGeorecoveryAliasFailOverSettings toolSettings, string alias)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Alias = alias;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsGeorecoveryAliasFailOverSettings.Alias"/>.</em></p><p>Name of Geo-Disaster Recovery Configuration Alias.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasFailOverSettings ResetAlias(this AzureEventhubsGeorecoveryAliasFailOverSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Alias = null;
            return toolSettings;
        }
        #endregion
        #region NamespaceName
        /// <summary><p><em>Sets <see cref="AzureEventhubsGeorecoveryAliasFailOverSettings.NamespaceName"/>.</em></p><p>Name of Namespace.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasFailOverSettings SetNamespaceName(this AzureEventhubsGeorecoveryAliasFailOverSettings toolSettings, string namespaceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = namespaceName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsGeorecoveryAliasFailOverSettings.NamespaceName"/>.</em></p><p>Name of Namespace.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasFailOverSettings ResetNamespaceName(this AzureEventhubsGeorecoveryAliasFailOverSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureEventhubsGeorecoveryAliasFailOverSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasFailOverSettings SetResourceGroup(this AzureEventhubsGeorecoveryAliasFailOverSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsGeorecoveryAliasFailOverSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasFailOverSettings ResetResourceGroup(this AzureEventhubsGeorecoveryAliasFailOverSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureEventhubsGeorecoveryAliasFailOverSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasFailOverSettings SetDebug(this AzureEventhubsGeorecoveryAliasFailOverSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsGeorecoveryAliasFailOverSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasFailOverSettings ResetDebug(this AzureEventhubsGeorecoveryAliasFailOverSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureEventhubsGeorecoveryAliasFailOverSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasFailOverSettings SetHelp(this AzureEventhubsGeorecoveryAliasFailOverSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsGeorecoveryAliasFailOverSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasFailOverSettings ResetHelp(this AzureEventhubsGeorecoveryAliasFailOverSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureEventhubsGeorecoveryAliasFailOverSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasFailOverSettings SetOutput(this AzureEventhubsGeorecoveryAliasFailOverSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsGeorecoveryAliasFailOverSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasFailOverSettings ResetOutput(this AzureEventhubsGeorecoveryAliasFailOverSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureEventhubsGeorecoveryAliasFailOverSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasFailOverSettings SetQuery(this AzureEventhubsGeorecoveryAliasFailOverSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsGeorecoveryAliasFailOverSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasFailOverSettings ResetQuery(this AzureEventhubsGeorecoveryAliasFailOverSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureEventhubsGeorecoveryAliasFailOverSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasFailOverSettings SetVerbose(this AzureEventhubsGeorecoveryAliasFailOverSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsGeorecoveryAliasFailOverSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasFailOverSettings ResetVerbose(this AzureEventhubsGeorecoveryAliasFailOverSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureEventhubsGeorecoveryAliasListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventhubsGeorecoveryAliasListSettingsExtensions
    {
        #region NamespaceName
        /// <summary><p><em>Sets <see cref="AzureEventhubsGeorecoveryAliasListSettings.NamespaceName"/>.</em></p><p>Name of Namespace.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasListSettings SetNamespaceName(this AzureEventhubsGeorecoveryAliasListSettings toolSettings, string namespaceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = namespaceName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsGeorecoveryAliasListSettings.NamespaceName"/>.</em></p><p>Name of Namespace.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasListSettings ResetNamespaceName(this AzureEventhubsGeorecoveryAliasListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureEventhubsGeorecoveryAliasListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasListSettings SetResourceGroup(this AzureEventhubsGeorecoveryAliasListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsGeorecoveryAliasListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasListSettings ResetResourceGroup(this AzureEventhubsGeorecoveryAliasListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureEventhubsGeorecoveryAliasListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasListSettings SetDebug(this AzureEventhubsGeorecoveryAliasListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsGeorecoveryAliasListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasListSettings ResetDebug(this AzureEventhubsGeorecoveryAliasListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureEventhubsGeorecoveryAliasListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasListSettings SetHelp(this AzureEventhubsGeorecoveryAliasListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsGeorecoveryAliasListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasListSettings ResetHelp(this AzureEventhubsGeorecoveryAliasListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureEventhubsGeorecoveryAliasListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasListSettings SetOutput(this AzureEventhubsGeorecoveryAliasListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsGeorecoveryAliasListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasListSettings ResetOutput(this AzureEventhubsGeorecoveryAliasListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureEventhubsGeorecoveryAliasListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasListSettings SetQuery(this AzureEventhubsGeorecoveryAliasListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsGeorecoveryAliasListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasListSettings ResetQuery(this AzureEventhubsGeorecoveryAliasListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureEventhubsGeorecoveryAliasListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasListSettings SetVerbose(this AzureEventhubsGeorecoveryAliasListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsGeorecoveryAliasListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasListSettings ResetVerbose(this AzureEventhubsGeorecoveryAliasListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureEventhubsGeorecoveryAliasSetSettingsExtensions
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventhubsGeorecoveryAliasSetSettingsExtensions
    {
        #region Alias
        /// <summary><p><em>Sets <see cref="AzureEventhubsGeorecoveryAliasSetSettings.Alias"/>.</em></p><p>Name of Geo-Disaster Recovery Configuration Alias.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasSetSettings SetAlias(this AzureEventhubsGeorecoveryAliasSetSettings toolSettings, string alias)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Alias = alias;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsGeorecoveryAliasSetSettings.Alias"/>.</em></p><p>Name of Geo-Disaster Recovery Configuration Alias.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasSetSettings ResetAlias(this AzureEventhubsGeorecoveryAliasSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Alias = null;
            return toolSettings;
        }
        #endregion
        #region NamespaceName
        /// <summary><p><em>Sets <see cref="AzureEventhubsGeorecoveryAliasSetSettings.NamespaceName"/>.</em></p><p>Name of Namespace.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasSetSettings SetNamespaceName(this AzureEventhubsGeorecoveryAliasSetSettings toolSettings, string namespaceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = namespaceName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsGeorecoveryAliasSetSettings.NamespaceName"/>.</em></p><p>Name of Namespace.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasSetSettings ResetNamespaceName(this AzureEventhubsGeorecoveryAliasSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = null;
            return toolSettings;
        }
        #endregion
        #region PartnerNamespace
        /// <summary><p><em>Sets <see cref="AzureEventhubsGeorecoveryAliasSetSettings.PartnerNamespace"/>.</em></p><p>Name (if within the same resource group) or ARM Id of the Primary/Secondary eventhub namespace name, which is part of GEO DR pairing.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasSetSettings SetPartnerNamespace(this AzureEventhubsGeorecoveryAliasSetSettings toolSettings, string partnerNamespace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PartnerNamespace = partnerNamespace;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsGeorecoveryAliasSetSettings.PartnerNamespace"/>.</em></p><p>Name (if within the same resource group) or ARM Id of the Primary/Secondary eventhub namespace name, which is part of GEO DR pairing.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasSetSettings ResetPartnerNamespace(this AzureEventhubsGeorecoveryAliasSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PartnerNamespace = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureEventhubsGeorecoveryAliasSetSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasSetSettings SetResourceGroup(this AzureEventhubsGeorecoveryAliasSetSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsGeorecoveryAliasSetSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasSetSettings ResetResourceGroup(this AzureEventhubsGeorecoveryAliasSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region AlternateName
        /// <summary><p><em>Sets <see cref="AzureEventhubsGeorecoveryAliasSetSettings.AlternateName"/>.</em></p><p>Alternate Name for the Alias, when the Namespace name and Alias name are same.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasSetSettings SetAlternateName(this AzureEventhubsGeorecoveryAliasSetSettings toolSettings, string alternateName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AlternateName = alternateName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsGeorecoveryAliasSetSettings.AlternateName"/>.</em></p><p>Alternate Name for the Alias, when the Namespace name and Alias name are same.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasSetSettings ResetAlternateName(this AzureEventhubsGeorecoveryAliasSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AlternateName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureEventhubsGeorecoveryAliasSetSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasSetSettings SetDebug(this AzureEventhubsGeorecoveryAliasSetSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsGeorecoveryAliasSetSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasSetSettings ResetDebug(this AzureEventhubsGeorecoveryAliasSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureEventhubsGeorecoveryAliasSetSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasSetSettings SetHelp(this AzureEventhubsGeorecoveryAliasSetSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsGeorecoveryAliasSetSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasSetSettings ResetHelp(this AzureEventhubsGeorecoveryAliasSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureEventhubsGeorecoveryAliasSetSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasSetSettings SetOutput(this AzureEventhubsGeorecoveryAliasSetSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsGeorecoveryAliasSetSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasSetSettings ResetOutput(this AzureEventhubsGeorecoveryAliasSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureEventhubsGeorecoveryAliasSetSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasSetSettings SetQuery(this AzureEventhubsGeorecoveryAliasSetSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsGeorecoveryAliasSetSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasSetSettings ResetQuery(this AzureEventhubsGeorecoveryAliasSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureEventhubsGeorecoveryAliasSetSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasSetSettings SetVerbose(this AzureEventhubsGeorecoveryAliasSetSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsGeorecoveryAliasSetSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasSetSettings ResetVerbose(this AzureEventhubsGeorecoveryAliasSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureEventhubsGeorecoveryAliasShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventhubsGeorecoveryAliasShowSettingsExtensions
    {
        #region Alias
        /// <summary><p><em>Sets <see cref="AzureEventhubsGeorecoveryAliasShowSettings.Alias"/>.</em></p><p>Name of Geo-Disaster Recovery Configuration Alias.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasShowSettings SetAlias(this AzureEventhubsGeorecoveryAliasShowSettings toolSettings, string alias)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Alias = alias;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsGeorecoveryAliasShowSettings.Alias"/>.</em></p><p>Name of Geo-Disaster Recovery Configuration Alias.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasShowSettings ResetAlias(this AzureEventhubsGeorecoveryAliasShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Alias = null;
            return toolSettings;
        }
        #endregion
        #region NamespaceName
        /// <summary><p><em>Sets <see cref="AzureEventhubsGeorecoveryAliasShowSettings.NamespaceName"/>.</em></p><p>Name of Namespace.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasShowSettings SetNamespaceName(this AzureEventhubsGeorecoveryAliasShowSettings toolSettings, string namespaceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = namespaceName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsGeorecoveryAliasShowSettings.NamespaceName"/>.</em></p><p>Name of Namespace.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasShowSettings ResetNamespaceName(this AzureEventhubsGeorecoveryAliasShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureEventhubsGeorecoveryAliasShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasShowSettings SetResourceGroup(this AzureEventhubsGeorecoveryAliasShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsGeorecoveryAliasShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasShowSettings ResetResourceGroup(this AzureEventhubsGeorecoveryAliasShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureEventhubsGeorecoveryAliasShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasShowSettings SetDebug(this AzureEventhubsGeorecoveryAliasShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsGeorecoveryAliasShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasShowSettings ResetDebug(this AzureEventhubsGeorecoveryAliasShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureEventhubsGeorecoveryAliasShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasShowSettings SetHelp(this AzureEventhubsGeorecoveryAliasShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsGeorecoveryAliasShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasShowSettings ResetHelp(this AzureEventhubsGeorecoveryAliasShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureEventhubsGeorecoveryAliasShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasShowSettings SetOutput(this AzureEventhubsGeorecoveryAliasShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsGeorecoveryAliasShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasShowSettings ResetOutput(this AzureEventhubsGeorecoveryAliasShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureEventhubsGeorecoveryAliasShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasShowSettings SetQuery(this AzureEventhubsGeorecoveryAliasShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsGeorecoveryAliasShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasShowSettings ResetQuery(this AzureEventhubsGeorecoveryAliasShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureEventhubsGeorecoveryAliasShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasShowSettings SetVerbose(this AzureEventhubsGeorecoveryAliasShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsGeorecoveryAliasShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasShowSettings ResetVerbose(this AzureEventhubsGeorecoveryAliasShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureEventhubsNamespaceCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventhubsNamespaceCreateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceCreateSettings.Name"/>.</em></p><p>Name of Namespace.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceCreateSettings SetName(this AzureEventhubsNamespaceCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceCreateSettings.Name"/>.</em></p><p>Name of Namespace.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceCreateSettings ResetName(this AzureEventhubsNamespaceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceCreateSettings SetResourceGroup(this AzureEventhubsNamespaceCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceCreateSettings ResetResourceGroup(this AzureEventhubsNamespaceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Capacity
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceCreateSettings.Capacity"/>.</em></p><p>Capacity for Sku.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceCreateSettings SetCapacity(this AzureEventhubsNamespaceCreateSettings toolSettings, string capacity)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Capacity = capacity;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceCreateSettings.Capacity"/>.</em></p><p>Capacity for Sku.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceCreateSettings ResetCapacity(this AzureEventhubsNamespaceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Capacity = null;
            return toolSettings;
        }
        #endregion
        #region EnableAutoInflate
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceCreateSettings.EnableAutoInflate"/>.</em></p><p>A boolean value that indicates whether AutoInflate is enabled for eventhub namespace.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceCreateSettings SetEnableAutoInflate(this AzureEventhubsNamespaceCreateSettings toolSettings, bool? enableAutoInflate)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableAutoInflate = enableAutoInflate;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceCreateSettings.EnableAutoInflate"/>.</em></p><p>A boolean value that indicates whether AutoInflate is enabled for eventhub namespace.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceCreateSettings ResetEnableAutoInflate(this AzureEventhubsNamespaceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableAutoInflate = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureEventhubsNamespaceCreateSettings.EnableAutoInflate"/>.</em></p><p>A boolean value that indicates whether AutoInflate is enabled for eventhub namespace.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceCreateSettings EnableEnableAutoInflate(this AzureEventhubsNamespaceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableAutoInflate = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureEventhubsNamespaceCreateSettings.EnableAutoInflate"/>.</em></p><p>A boolean value that indicates whether AutoInflate is enabled for eventhub namespace.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceCreateSettings DisableEnableAutoInflate(this AzureEventhubsNamespaceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableAutoInflate = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureEventhubsNamespaceCreateSettings.EnableAutoInflate"/>.</em></p><p>A boolean value that indicates whether AutoInflate is enabled for eventhub namespace.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceCreateSettings ToggleEnableAutoInflate(this AzureEventhubsNamespaceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableAutoInflate = !toolSettings.EnableAutoInflate;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceCreateSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceCreateSettings SetLocation(this AzureEventhubsNamespaceCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceCreateSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceCreateSettings ResetLocation(this AzureEventhubsNamespaceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region MaximumThroughputUnits
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceCreateSettings.MaximumThroughputUnits"/>.</em></p><p>Upper limit of throughput units when AutoInflate is enabled, vaule should be within 0 to 20 throughput units. ( 0 if AutoInflateEnabled = true).</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceCreateSettings SetMaximumThroughputUnits(this AzureEventhubsNamespaceCreateSettings toolSettings, string maximumThroughputUnits)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MaximumThroughputUnits = maximumThroughputUnits;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceCreateSettings.MaximumThroughputUnits"/>.</em></p><p>Upper limit of throughput units when AutoInflate is enabled, vaule should be within 0 to 20 throughput units. ( 0 if AutoInflateEnabled = true).</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceCreateSettings ResetMaximumThroughputUnits(this AzureEventhubsNamespaceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MaximumThroughputUnits = null;
            return toolSettings;
        }
        #endregion
        #region Sku
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceCreateSettings.Sku"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureEventhubsNamespaceCreateSettings SetSku(this AzureEventhubsNamespaceCreateSettings toolSettings, EventhubsNamespaceSku sku)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = sku;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceCreateSettings.Sku"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureEventhubsNamespaceCreateSettings ResetSku(this AzureEventhubsNamespaceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceCreateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceCreateSettings SetTags(this AzureEventhubsNamespaceCreateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceCreateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceCreateSettings ResetTags(this AzureEventhubsNamespaceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceCreateSettings SetDebug(this AzureEventhubsNamespaceCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceCreateSettings ResetDebug(this AzureEventhubsNamespaceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceCreateSettings SetHelp(this AzureEventhubsNamespaceCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceCreateSettings ResetHelp(this AzureEventhubsNamespaceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceCreateSettings SetOutput(this AzureEventhubsNamespaceCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceCreateSettings ResetOutput(this AzureEventhubsNamespaceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceCreateSettings SetQuery(this AzureEventhubsNamespaceCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceCreateSettings ResetQuery(this AzureEventhubsNamespaceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceCreateSettings SetVerbose(this AzureEventhubsNamespaceCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceCreateSettings ResetVerbose(this AzureEventhubsNamespaceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureEventhubsNamespaceDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventhubsNamespaceDeleteSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceDeleteSettings.Name"/>.</em></p><p>Name of Namespace.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceDeleteSettings SetName(this AzureEventhubsNamespaceDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceDeleteSettings.Name"/>.</em></p><p>Name of Namespace.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceDeleteSettings ResetName(this AzureEventhubsNamespaceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceDeleteSettings SetResourceGroup(this AzureEventhubsNamespaceDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceDeleteSettings ResetResourceGroup(this AzureEventhubsNamespaceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceDeleteSettings SetDebug(this AzureEventhubsNamespaceDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceDeleteSettings ResetDebug(this AzureEventhubsNamespaceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceDeleteSettings SetHelp(this AzureEventhubsNamespaceDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceDeleteSettings ResetHelp(this AzureEventhubsNamespaceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceDeleteSettings SetOutput(this AzureEventhubsNamespaceDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceDeleteSettings ResetOutput(this AzureEventhubsNamespaceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceDeleteSettings SetQuery(this AzureEventhubsNamespaceDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceDeleteSettings ResetQuery(this AzureEventhubsNamespaceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceDeleteSettings SetVerbose(this AzureEventhubsNamespaceDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceDeleteSettings ResetVerbose(this AzureEventhubsNamespaceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureEventhubsNamespaceExistsSettingsExtensions
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventhubsNamespaceExistsSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceExistsSettings.Name"/>.</em></p><p>Name to check the namespace name availability.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceExistsSettings SetName(this AzureEventhubsNamespaceExistsSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceExistsSettings.Name"/>.</em></p><p>Name to check the namespace name availability.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceExistsSettings ResetName(this AzureEventhubsNamespaceExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceExistsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceExistsSettings SetDebug(this AzureEventhubsNamespaceExistsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceExistsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceExistsSettings ResetDebug(this AzureEventhubsNamespaceExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceExistsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceExistsSettings SetHelp(this AzureEventhubsNamespaceExistsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceExistsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceExistsSettings ResetHelp(this AzureEventhubsNamespaceExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceExistsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceExistsSettings SetOutput(this AzureEventhubsNamespaceExistsSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceExistsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceExistsSettings ResetOutput(this AzureEventhubsNamespaceExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceExistsSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceExistsSettings SetQuery(this AzureEventhubsNamespaceExistsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceExistsSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceExistsSettings ResetQuery(this AzureEventhubsNamespaceExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceExistsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceExistsSettings SetVerbose(this AzureEventhubsNamespaceExistsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceExistsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceExistsSettings ResetVerbose(this AzureEventhubsNamespaceExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureEventhubsNamespaceListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventhubsNamespaceListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceListSettings SetResourceGroup(this AzureEventhubsNamespaceListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceListSettings ResetResourceGroup(this AzureEventhubsNamespaceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceListSettings SetDebug(this AzureEventhubsNamespaceListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceListSettings ResetDebug(this AzureEventhubsNamespaceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceListSettings SetHelp(this AzureEventhubsNamespaceListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceListSettings ResetHelp(this AzureEventhubsNamespaceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceListSettings SetOutput(this AzureEventhubsNamespaceListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceListSettings ResetOutput(this AzureEventhubsNamespaceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceListSettings SetQuery(this AzureEventhubsNamespaceListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceListSettings ResetQuery(this AzureEventhubsNamespaceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceListSettings SetVerbose(this AzureEventhubsNamespaceListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceListSettings ResetVerbose(this AzureEventhubsNamespaceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureEventhubsNamespaceShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventhubsNamespaceShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceShowSettings.Name"/>.</em></p><p>Name of Namespace.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceShowSettings SetName(this AzureEventhubsNamespaceShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceShowSettings.Name"/>.</em></p><p>Name of Namespace.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceShowSettings ResetName(this AzureEventhubsNamespaceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceShowSettings SetResourceGroup(this AzureEventhubsNamespaceShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceShowSettings ResetResourceGroup(this AzureEventhubsNamespaceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceShowSettings SetDebug(this AzureEventhubsNamespaceShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceShowSettings ResetDebug(this AzureEventhubsNamespaceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceShowSettings SetHelp(this AzureEventhubsNamespaceShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceShowSettings ResetHelp(this AzureEventhubsNamespaceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceShowSettings SetOutput(this AzureEventhubsNamespaceShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceShowSettings ResetOutput(this AzureEventhubsNamespaceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceShowSettings SetQuery(this AzureEventhubsNamespaceShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceShowSettings ResetQuery(this AzureEventhubsNamespaceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceShowSettings SetVerbose(this AzureEventhubsNamespaceShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceShowSettings ResetVerbose(this AzureEventhubsNamespaceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureEventhubsNamespaceUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventhubsNamespaceUpdateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceUpdateSettings.Name"/>.</em></p><p>Name of Namespace.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceUpdateSettings SetName(this AzureEventhubsNamespaceUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceUpdateSettings.Name"/>.</em></p><p>Name of Namespace.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceUpdateSettings ResetName(this AzureEventhubsNamespaceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceUpdateSettings SetResourceGroup(this AzureEventhubsNamespaceUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceUpdateSettings ResetResourceGroup(this AzureEventhubsNamespaceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Capacity
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceUpdateSettings.Capacity"/>.</em></p><p>Capacity for Sku.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceUpdateSettings SetCapacity(this AzureEventhubsNamespaceUpdateSettings toolSettings, string capacity)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Capacity = capacity;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceUpdateSettings.Capacity"/>.</em></p><p>Capacity for Sku.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceUpdateSettings ResetCapacity(this AzureEventhubsNamespaceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Capacity = null;
            return toolSettings;
        }
        #endregion
        #region EnableAutoInflate
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceUpdateSettings.EnableAutoInflate"/>.</em></p><p>A boolean value that indicates whether AutoInflate is enabled for eventhub namespace.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceUpdateSettings SetEnableAutoInflate(this AzureEventhubsNamespaceUpdateSettings toolSettings, bool? enableAutoInflate)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableAutoInflate = enableAutoInflate;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceUpdateSettings.EnableAutoInflate"/>.</em></p><p>A boolean value that indicates whether AutoInflate is enabled for eventhub namespace.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceUpdateSettings ResetEnableAutoInflate(this AzureEventhubsNamespaceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableAutoInflate = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureEventhubsNamespaceUpdateSettings.EnableAutoInflate"/>.</em></p><p>A boolean value that indicates whether AutoInflate is enabled for eventhub namespace.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceUpdateSettings EnableEnableAutoInflate(this AzureEventhubsNamespaceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableAutoInflate = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureEventhubsNamespaceUpdateSettings.EnableAutoInflate"/>.</em></p><p>A boolean value that indicates whether AutoInflate is enabled for eventhub namespace.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceUpdateSettings DisableEnableAutoInflate(this AzureEventhubsNamespaceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableAutoInflate = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureEventhubsNamespaceUpdateSettings.EnableAutoInflate"/>.</em></p><p>A boolean value that indicates whether AutoInflate is enabled for eventhub namespace.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceUpdateSettings ToggleEnableAutoInflate(this AzureEventhubsNamespaceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableAutoInflate = !toolSettings.EnableAutoInflate;
            return toolSettings;
        }
        #endregion
        #region MaximumThroughputUnits
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceUpdateSettings.MaximumThroughputUnits"/>.</em></p><p>Upper limit of throughput units when AutoInflate is enabled, vaule should be within 0 to 20 throughput units. ( 0 if AutoInflateEnabled = true).</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceUpdateSettings SetMaximumThroughputUnits(this AzureEventhubsNamespaceUpdateSettings toolSettings, string maximumThroughputUnits)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MaximumThroughputUnits = maximumThroughputUnits;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceUpdateSettings.MaximumThroughputUnits"/>.</em></p><p>Upper limit of throughput units when AutoInflate is enabled, vaule should be within 0 to 20 throughput units. ( 0 if AutoInflateEnabled = true).</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceUpdateSettings ResetMaximumThroughputUnits(this AzureEventhubsNamespaceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MaximumThroughputUnits = null;
            return toolSettings;
        }
        #endregion
        #region Sku
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceUpdateSettings.Sku"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureEventhubsNamespaceUpdateSettings SetSku(this AzureEventhubsNamespaceUpdateSettings toolSettings, EventhubsNamespaceSku sku)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = sku;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceUpdateSettings.Sku"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureEventhubsNamespaceUpdateSettings ResetSku(this AzureEventhubsNamespaceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceUpdateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceUpdateSettings SetTags(this AzureEventhubsNamespaceUpdateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceUpdateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceUpdateSettings ResetTags(this AzureEventhubsNamespaceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceUpdateSettings SetAdd(this AzureEventhubsNamespaceUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceUpdateSettings ResetAdd(this AzureEventhubsNamespaceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region ForceString
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceUpdateSettings.ForceString"/>.</em></p><p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceUpdateSettings SetForceString(this AzureEventhubsNamespaceUpdateSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceUpdateSettings.ForceString"/>.</em></p><p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceUpdateSettings ResetForceString(this AzureEventhubsNamespaceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceUpdateSettings SetRemove(this AzureEventhubsNamespaceUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceUpdateSettings ResetRemove(this AzureEventhubsNamespaceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceUpdateSettings SetSet(this AzureEventhubsNamespaceUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceUpdateSettings ResetSet(this AzureEventhubsNamespaceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceUpdateSettings SetDebug(this AzureEventhubsNamespaceUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceUpdateSettings ResetDebug(this AzureEventhubsNamespaceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceUpdateSettings SetHelp(this AzureEventhubsNamespaceUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceUpdateSettings ResetHelp(this AzureEventhubsNamespaceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceUpdateSettings SetOutput(this AzureEventhubsNamespaceUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceUpdateSettings ResetOutput(this AzureEventhubsNamespaceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceUpdateSettings SetQuery(this AzureEventhubsNamespaceUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceUpdateSettings ResetQuery(this AzureEventhubsNamespaceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceUpdateSettings SetVerbose(this AzureEventhubsNamespaceUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceUpdateSettings ResetVerbose(this AzureEventhubsNamespaceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureEventhubsEventhubCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventhubsEventhubCreateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubCreateSettings.Name"/>.</em></p><p>Name of Eventhub.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubCreateSettings SetName(this AzureEventhubsEventhubCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubCreateSettings.Name"/>.</em></p><p>Name of Eventhub.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubCreateSettings ResetName(this AzureEventhubsEventhubCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region NamespaceName
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubCreateSettings.NamespaceName"/>.</em></p><p>Name of Namespace.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubCreateSettings SetNamespaceName(this AzureEventhubsEventhubCreateSettings toolSettings, string namespaceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = namespaceName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubCreateSettings.NamespaceName"/>.</em></p><p>Name of Namespace.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubCreateSettings ResetNamespaceName(this AzureEventhubsEventhubCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubCreateSettings SetResourceGroup(this AzureEventhubsEventhubCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubCreateSettings ResetResourceGroup(this AzureEventhubsEventhubCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region EnableCapture
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubCreateSettings.EnableCapture"/>.</em></p><p>A boolean value that indicates whether capture description is enabled.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubCreateSettings SetEnableCapture(this AzureEventhubsEventhubCreateSettings toolSettings, bool? enableCapture)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableCapture = enableCapture;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubCreateSettings.EnableCapture"/>.</em></p><p>A boolean value that indicates whether capture description is enabled.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubCreateSettings ResetEnableCapture(this AzureEventhubsEventhubCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableCapture = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureEventhubsEventhubCreateSettings.EnableCapture"/>.</em></p><p>A boolean value that indicates whether capture description is enabled.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubCreateSettings EnableEnableCapture(this AzureEventhubsEventhubCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableCapture = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureEventhubsEventhubCreateSettings.EnableCapture"/>.</em></p><p>A boolean value that indicates whether capture description is enabled.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubCreateSettings DisableEnableCapture(this AzureEventhubsEventhubCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableCapture = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureEventhubsEventhubCreateSettings.EnableCapture"/>.</em></p><p>A boolean value that indicates whether capture description is enabled.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubCreateSettings ToggleEnableCapture(this AzureEventhubsEventhubCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableCapture = !toolSettings.EnableCapture;
            return toolSettings;
        }
        #endregion
        #region MessageRetention
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubCreateSettings.MessageRetention"/>.</em></p><p>Number of days to retain events for this Event Hub, value should be 1 to 7 days.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubCreateSettings SetMessageRetention(this AzureEventhubsEventhubCreateSettings toolSettings, int? messageRetention)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MessageRetention = messageRetention;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubCreateSettings.MessageRetention"/>.</em></p><p>Number of days to retain events for this Event Hub, value should be 1 to 7 days.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubCreateSettings ResetMessageRetention(this AzureEventhubsEventhubCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MessageRetention = null;
            return toolSettings;
        }
        #endregion
        #region PartitionCount
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubCreateSettings.PartitionCount"/>.</em></p><p>Number of partitions created for the Event Hub. By default, allowed values are 2-32. Lower value of 1 is supported with Kafka enabled namespaces. In presence of a custom quota, the upper limit will match the upper limit of the quota.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubCreateSettings SetPartitionCount(this AzureEventhubsEventhubCreateSettings toolSettings, int? partitionCount)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PartitionCount = partitionCount;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubCreateSettings.PartitionCount"/>.</em></p><p>Number of partitions created for the Event Hub. By default, allowed values are 2-32. Lower value of 1 is supported with Kafka enabled namespaces. In presence of a custom quota, the upper limit will match the upper limit of the quota.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubCreateSettings ResetPartitionCount(this AzureEventhubsEventhubCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PartitionCount = null;
            return toolSettings;
        }
        #endregion
        #region Status
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubCreateSettings.Status"/>.</em></p><p>Status of Eventhub.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubCreateSettings SetStatus(this AzureEventhubsEventhubCreateSettings toolSettings, EventhubsEventhubStatus status)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Status = status;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubCreateSettings.Status"/>.</em></p><p>Status of Eventhub.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubCreateSettings ResetStatus(this AzureEventhubsEventhubCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Status = null;
            return toolSettings;
        }
        #endregion
        #region CaptureInterval
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubCreateSettings.CaptureInterval"/>.</em></p><p>Allows you to set the frequency with which the capture to Azure Blobs will happen, value should between 60 to 900 seconds.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubCreateSettings SetCaptureInterval(this AzureEventhubsEventhubCreateSettings toolSettings, string captureInterval)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CaptureInterval = captureInterval;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubCreateSettings.CaptureInterval"/>.</em></p><p>Allows you to set the frequency with which the capture to Azure Blobs will happen, value should between 60 to 900 seconds.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubCreateSettings ResetCaptureInterval(this AzureEventhubsEventhubCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CaptureInterval = null;
            return toolSettings;
        }
        #endregion
        #region CaptureSizeLimit
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubCreateSettings.CaptureSizeLimit"/>.</em></p><p>Defines the amount of data built up in your Event Hub before an capture operation, value should be between 10485760 to 524288000 bytes.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubCreateSettings SetCaptureSizeLimit(this AzureEventhubsEventhubCreateSettings toolSettings, string captureSizeLimit)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CaptureSizeLimit = captureSizeLimit;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubCreateSettings.CaptureSizeLimit"/>.</em></p><p>Defines the amount of data built up in your Event Hub before an capture operation, value should be between 10485760 to 524288000 bytes.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubCreateSettings ResetCaptureSizeLimit(this AzureEventhubsEventhubCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CaptureSizeLimit = null;
            return toolSettings;
        }
        #endregion
        #region ArchiveNameFormat
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubCreateSettings.ArchiveNameFormat"/>.</em></p><p>Blob naming convention for archive, e.g. {Namespace}/{EventHub}/{PartitionId}/{Year}/{Month}/{Day}/{Hour}/{Minute}/{Second}. Here all the parameters (Namespace,EventHub .. etc) are mandatory irrespective of order.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubCreateSettings SetArchiveNameFormat(this AzureEventhubsEventhubCreateSettings toolSettings, string archiveNameFormat)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ArchiveNameFormat = archiveNameFormat;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubCreateSettings.ArchiveNameFormat"/>.</em></p><p>Blob naming convention for archive, e.g. {Namespace}/{EventHub}/{PartitionId}/{Year}/{Month}/{Day}/{Hour}/{Minute}/{Second}. Here all the parameters (Namespace,EventHub .. etc) are mandatory irrespective of order.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubCreateSettings ResetArchiveNameFormat(this AzureEventhubsEventhubCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ArchiveNameFormat = null;
            return toolSettings;
        }
        #endregion
        #region BlobContainer
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubCreateSettings.BlobContainer"/>.</em></p><p>Blob container Name.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubCreateSettings SetBlobContainer(this AzureEventhubsEventhubCreateSettings toolSettings, string blobContainer)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BlobContainer = blobContainer;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubCreateSettings.BlobContainer"/>.</em></p><p>Blob container Name.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubCreateSettings ResetBlobContainer(this AzureEventhubsEventhubCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BlobContainer = null;
            return toolSettings;
        }
        #endregion
        #region DestinationName
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubCreateSettings.DestinationName"/>.</em></p><p>Name for capture destination.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubCreateSettings SetDestinationName(this AzureEventhubsEventhubCreateSettings toolSettings, string destinationName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DestinationName = destinationName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubCreateSettings.DestinationName"/>.</em></p><p>Name for capture destination.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubCreateSettings ResetDestinationName(this AzureEventhubsEventhubCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DestinationName = null;
            return toolSettings;
        }
        #endregion
        #region StorageAccount
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubCreateSettings.StorageAccount"/>.</em></p><p>Name (if within same resource group and not of type Classic Storage) or ARM id of the storage account to be used to create the blobs.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubCreateSettings SetStorageAccount(this AzureEventhubsEventhubCreateSettings toolSettings, string storageAccount)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageAccount = storageAccount;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubCreateSettings.StorageAccount"/>.</em></p><p>Name (if within same resource group and not of type Classic Storage) or ARM id of the storage account to be used to create the blobs.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubCreateSettings ResetStorageAccount(this AzureEventhubsEventhubCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageAccount = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubCreateSettings SetDebug(this AzureEventhubsEventhubCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubCreateSettings ResetDebug(this AzureEventhubsEventhubCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubCreateSettings SetHelp(this AzureEventhubsEventhubCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubCreateSettings ResetHelp(this AzureEventhubsEventhubCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubCreateSettings SetOutput(this AzureEventhubsEventhubCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubCreateSettings ResetOutput(this AzureEventhubsEventhubCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubCreateSettings SetQuery(this AzureEventhubsEventhubCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubCreateSettings ResetQuery(this AzureEventhubsEventhubCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubCreateSettings SetVerbose(this AzureEventhubsEventhubCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubCreateSettings ResetVerbose(this AzureEventhubsEventhubCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureEventhubsEventhubDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventhubsEventhubDeleteSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubDeleteSettings.Name"/>.</em></p><p>Name of Eventhub.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubDeleteSettings SetName(this AzureEventhubsEventhubDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubDeleteSettings.Name"/>.</em></p><p>Name of Eventhub.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubDeleteSettings ResetName(this AzureEventhubsEventhubDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region NamespaceName
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubDeleteSettings.NamespaceName"/>.</em></p><p>Name of Namespace.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubDeleteSettings SetNamespaceName(this AzureEventhubsEventhubDeleteSettings toolSettings, string namespaceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = namespaceName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubDeleteSettings.NamespaceName"/>.</em></p><p>Name of Namespace.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubDeleteSettings ResetNamespaceName(this AzureEventhubsEventhubDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubDeleteSettings SetResourceGroup(this AzureEventhubsEventhubDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubDeleteSettings ResetResourceGroup(this AzureEventhubsEventhubDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubDeleteSettings SetDebug(this AzureEventhubsEventhubDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubDeleteSettings ResetDebug(this AzureEventhubsEventhubDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubDeleteSettings SetHelp(this AzureEventhubsEventhubDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubDeleteSettings ResetHelp(this AzureEventhubsEventhubDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubDeleteSettings SetOutput(this AzureEventhubsEventhubDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubDeleteSettings ResetOutput(this AzureEventhubsEventhubDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubDeleteSettings SetQuery(this AzureEventhubsEventhubDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubDeleteSettings ResetQuery(this AzureEventhubsEventhubDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubDeleteSettings SetVerbose(this AzureEventhubsEventhubDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubDeleteSettings ResetVerbose(this AzureEventhubsEventhubDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureEventhubsEventhubListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventhubsEventhubListSettingsExtensions
    {
        #region NamespaceName
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubListSettings.NamespaceName"/>.</em></p><p>Name of Namespace.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubListSettings SetNamespaceName(this AzureEventhubsEventhubListSettings toolSettings, string namespaceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = namespaceName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubListSettings.NamespaceName"/>.</em></p><p>Name of Namespace.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubListSettings ResetNamespaceName(this AzureEventhubsEventhubListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubListSettings SetResourceGroup(this AzureEventhubsEventhubListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubListSettings ResetResourceGroup(this AzureEventhubsEventhubListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Skip
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubListSettings.Skip"/>.</em></p><p>Skip is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skip parameter that specifies a starting point to use for subsequent calls.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubListSettings SetSkip(this AzureEventhubsEventhubListSettings toolSettings, string skip)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Skip = skip;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubListSettings.Skip"/>.</em></p><p>Skip is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skip parameter that specifies a starting point to use for subsequent calls.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubListSettings ResetSkip(this AzureEventhubsEventhubListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Skip = null;
            return toolSettings;
        }
        #endregion
        #region Top
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubListSettings.Top"/>.</em></p><p>May be used to limit the number of results to the most recent N usageDetails.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubListSettings SetTop(this AzureEventhubsEventhubListSettings toolSettings, string top)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = top;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubListSettings.Top"/>.</em></p><p>May be used to limit the number of results to the most recent N usageDetails.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubListSettings ResetTop(this AzureEventhubsEventhubListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubListSettings SetDebug(this AzureEventhubsEventhubListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubListSettings ResetDebug(this AzureEventhubsEventhubListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubListSettings SetHelp(this AzureEventhubsEventhubListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubListSettings ResetHelp(this AzureEventhubsEventhubListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubListSettings SetOutput(this AzureEventhubsEventhubListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubListSettings ResetOutput(this AzureEventhubsEventhubListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubListSettings SetQuery(this AzureEventhubsEventhubListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubListSettings ResetQuery(this AzureEventhubsEventhubListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubListSettings SetVerbose(this AzureEventhubsEventhubListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubListSettings ResetVerbose(this AzureEventhubsEventhubListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureEventhubsEventhubShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventhubsEventhubShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubShowSettings.Name"/>.</em></p><p>Name of Eventhub.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubShowSettings SetName(this AzureEventhubsEventhubShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubShowSettings.Name"/>.</em></p><p>Name of Eventhub.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubShowSettings ResetName(this AzureEventhubsEventhubShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region NamespaceName
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubShowSettings.NamespaceName"/>.</em></p><p>Name of Namespace.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubShowSettings SetNamespaceName(this AzureEventhubsEventhubShowSettings toolSettings, string namespaceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = namespaceName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubShowSettings.NamespaceName"/>.</em></p><p>Name of Namespace.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubShowSettings ResetNamespaceName(this AzureEventhubsEventhubShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubShowSettings SetResourceGroup(this AzureEventhubsEventhubShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubShowSettings ResetResourceGroup(this AzureEventhubsEventhubShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubShowSettings SetDebug(this AzureEventhubsEventhubShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubShowSettings ResetDebug(this AzureEventhubsEventhubShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubShowSettings SetHelp(this AzureEventhubsEventhubShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubShowSettings ResetHelp(this AzureEventhubsEventhubShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubShowSettings SetOutput(this AzureEventhubsEventhubShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubShowSettings ResetOutput(this AzureEventhubsEventhubShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubShowSettings SetQuery(this AzureEventhubsEventhubShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubShowSettings ResetQuery(this AzureEventhubsEventhubShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubShowSettings SetVerbose(this AzureEventhubsEventhubShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubShowSettings ResetVerbose(this AzureEventhubsEventhubShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureEventhubsEventhubUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventhubsEventhubUpdateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubUpdateSettings.Name"/>.</em></p><p>Name of Eventhub.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubUpdateSettings SetName(this AzureEventhubsEventhubUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubUpdateSettings.Name"/>.</em></p><p>Name of Eventhub.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubUpdateSettings ResetName(this AzureEventhubsEventhubUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region NamespaceName
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubUpdateSettings.NamespaceName"/>.</em></p><p>Name of Namespace.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubUpdateSettings SetNamespaceName(this AzureEventhubsEventhubUpdateSettings toolSettings, string namespaceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = namespaceName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubUpdateSettings.NamespaceName"/>.</em></p><p>Name of Namespace.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubUpdateSettings ResetNamespaceName(this AzureEventhubsEventhubUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubUpdateSettings SetResourceGroup(this AzureEventhubsEventhubUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubUpdateSettings ResetResourceGroup(this AzureEventhubsEventhubUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region EnableCapture
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubUpdateSettings.EnableCapture"/>.</em></p><p>A boolean value that indicates whether capture description is enabled.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubUpdateSettings SetEnableCapture(this AzureEventhubsEventhubUpdateSettings toolSettings, bool? enableCapture)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableCapture = enableCapture;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubUpdateSettings.EnableCapture"/>.</em></p><p>A boolean value that indicates whether capture description is enabled.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubUpdateSettings ResetEnableCapture(this AzureEventhubsEventhubUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableCapture = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureEventhubsEventhubUpdateSettings.EnableCapture"/>.</em></p><p>A boolean value that indicates whether capture description is enabled.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubUpdateSettings EnableEnableCapture(this AzureEventhubsEventhubUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableCapture = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureEventhubsEventhubUpdateSettings.EnableCapture"/>.</em></p><p>A boolean value that indicates whether capture description is enabled.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubUpdateSettings DisableEnableCapture(this AzureEventhubsEventhubUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableCapture = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureEventhubsEventhubUpdateSettings.EnableCapture"/>.</em></p><p>A boolean value that indicates whether capture description is enabled.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubUpdateSettings ToggleEnableCapture(this AzureEventhubsEventhubUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableCapture = !toolSettings.EnableCapture;
            return toolSettings;
        }
        #endregion
        #region MessageRetention
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubUpdateSettings.MessageRetention"/>.</em></p><p>Number of days to retain events for this Event Hub, value should be 1 to 7 days.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubUpdateSettings SetMessageRetention(this AzureEventhubsEventhubUpdateSettings toolSettings, int? messageRetention)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MessageRetention = messageRetention;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubUpdateSettings.MessageRetention"/>.</em></p><p>Number of days to retain events for this Event Hub, value should be 1 to 7 days.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubUpdateSettings ResetMessageRetention(this AzureEventhubsEventhubUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MessageRetention = null;
            return toolSettings;
        }
        #endregion
        #region PartitionCount
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubUpdateSettings.PartitionCount"/>.</em></p><p>Number of partitions created for the Event Hub. By default, allowed values are 2-32. Lower value of 1 is supported with Kafka enabled namespaces. In presence of a custom quota, the upper limit will match the upper limit of the quota.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubUpdateSettings SetPartitionCount(this AzureEventhubsEventhubUpdateSettings toolSettings, int? partitionCount)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PartitionCount = partitionCount;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubUpdateSettings.PartitionCount"/>.</em></p><p>Number of partitions created for the Event Hub. By default, allowed values are 2-32. Lower value of 1 is supported with Kafka enabled namespaces. In presence of a custom quota, the upper limit will match the upper limit of the quota.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubUpdateSettings ResetPartitionCount(this AzureEventhubsEventhubUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PartitionCount = null;
            return toolSettings;
        }
        #endregion
        #region Status
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubUpdateSettings.Status"/>.</em></p><p>Status of Eventhub.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubUpdateSettings SetStatus(this AzureEventhubsEventhubUpdateSettings toolSettings, EventhubsEventhubStatus status)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Status = status;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubUpdateSettings.Status"/>.</em></p><p>Status of Eventhub.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubUpdateSettings ResetStatus(this AzureEventhubsEventhubUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Status = null;
            return toolSettings;
        }
        #endregion
        #region CaptureInterval
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubUpdateSettings.CaptureInterval"/>.</em></p><p>Allows you to set the frequency with which the capture to Azure Blobs will happen, value should between 60 to 900 seconds.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubUpdateSettings SetCaptureInterval(this AzureEventhubsEventhubUpdateSettings toolSettings, string captureInterval)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CaptureInterval = captureInterval;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubUpdateSettings.CaptureInterval"/>.</em></p><p>Allows you to set the frequency with which the capture to Azure Blobs will happen, value should between 60 to 900 seconds.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubUpdateSettings ResetCaptureInterval(this AzureEventhubsEventhubUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CaptureInterval = null;
            return toolSettings;
        }
        #endregion
        #region CaptureSizeLimit
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubUpdateSettings.CaptureSizeLimit"/>.</em></p><p>Defines the amount of data built up in your Event Hub before an capture operation, value should be between 10485760 to 524288000 bytes.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubUpdateSettings SetCaptureSizeLimit(this AzureEventhubsEventhubUpdateSettings toolSettings, string captureSizeLimit)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CaptureSizeLimit = captureSizeLimit;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubUpdateSettings.CaptureSizeLimit"/>.</em></p><p>Defines the amount of data built up in your Event Hub before an capture operation, value should be between 10485760 to 524288000 bytes.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubUpdateSettings ResetCaptureSizeLimit(this AzureEventhubsEventhubUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CaptureSizeLimit = null;
            return toolSettings;
        }
        #endregion
        #region ArchiveNameFormat
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubUpdateSettings.ArchiveNameFormat"/>.</em></p><p>Blob naming convention for archive, e.g. {Namespace}/{EventHub}/{PartitionId}/{Year}/{Month}/{Day}/{Hour}/{Minute}/{Second}. Here all the parameters (Namespace,EventHub .. etc) are mandatory irrespective of order.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubUpdateSettings SetArchiveNameFormat(this AzureEventhubsEventhubUpdateSettings toolSettings, string archiveNameFormat)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ArchiveNameFormat = archiveNameFormat;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubUpdateSettings.ArchiveNameFormat"/>.</em></p><p>Blob naming convention for archive, e.g. {Namespace}/{EventHub}/{PartitionId}/{Year}/{Month}/{Day}/{Hour}/{Minute}/{Second}. Here all the parameters (Namespace,EventHub .. etc) are mandatory irrespective of order.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubUpdateSettings ResetArchiveNameFormat(this AzureEventhubsEventhubUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ArchiveNameFormat = null;
            return toolSettings;
        }
        #endregion
        #region BlobContainer
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubUpdateSettings.BlobContainer"/>.</em></p><p>Blob container Name.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubUpdateSettings SetBlobContainer(this AzureEventhubsEventhubUpdateSettings toolSettings, string blobContainer)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BlobContainer = blobContainer;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubUpdateSettings.BlobContainer"/>.</em></p><p>Blob container Name.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubUpdateSettings ResetBlobContainer(this AzureEventhubsEventhubUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BlobContainer = null;
            return toolSettings;
        }
        #endregion
        #region DestinationName
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubUpdateSettings.DestinationName"/>.</em></p><p>Name for capture destination.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubUpdateSettings SetDestinationName(this AzureEventhubsEventhubUpdateSettings toolSettings, string destinationName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DestinationName = destinationName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubUpdateSettings.DestinationName"/>.</em></p><p>Name for capture destination.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubUpdateSettings ResetDestinationName(this AzureEventhubsEventhubUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DestinationName = null;
            return toolSettings;
        }
        #endregion
        #region StorageAccount
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubUpdateSettings.StorageAccount"/>.</em></p><p>Name (if within same resource group and not of type Classic Storage) or ARM id of the storage account to be used to create the blobs.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubUpdateSettings SetStorageAccount(this AzureEventhubsEventhubUpdateSettings toolSettings, string storageAccount)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageAccount = storageAccount;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubUpdateSettings.StorageAccount"/>.</em></p><p>Name (if within same resource group and not of type Classic Storage) or ARM id of the storage account to be used to create the blobs.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubUpdateSettings ResetStorageAccount(this AzureEventhubsEventhubUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageAccount = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubUpdateSettings SetAdd(this AzureEventhubsEventhubUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubUpdateSettings ResetAdd(this AzureEventhubsEventhubUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region ForceString
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubUpdateSettings.ForceString"/>.</em></p><p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubUpdateSettings SetForceString(this AzureEventhubsEventhubUpdateSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubUpdateSettings.ForceString"/>.</em></p><p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubUpdateSettings ResetForceString(this AzureEventhubsEventhubUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubUpdateSettings SetRemove(this AzureEventhubsEventhubUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubUpdateSettings ResetRemove(this AzureEventhubsEventhubUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubUpdateSettings SetSet(this AzureEventhubsEventhubUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubUpdateSettings ResetSet(this AzureEventhubsEventhubUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubUpdateSettings SetDebug(this AzureEventhubsEventhubUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubUpdateSettings ResetDebug(this AzureEventhubsEventhubUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubUpdateSettings SetHelp(this AzureEventhubsEventhubUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubUpdateSettings ResetHelp(this AzureEventhubsEventhubUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubUpdateSettings SetOutput(this AzureEventhubsEventhubUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubUpdateSettings ResetOutput(this AzureEventhubsEventhubUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubUpdateSettings SetQuery(this AzureEventhubsEventhubUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubUpdateSettings ResetQuery(this AzureEventhubsEventhubUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubUpdateSettings SetVerbose(this AzureEventhubsEventhubUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubUpdateSettings ResetVerbose(this AzureEventhubsEventhubUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureEventhubsNamespaceAuthorizationRuleCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventhubsNamespaceAuthorizationRuleCreateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceAuthorizationRuleCreateSettings.Name"/>.</em></p><p>Name of Namespace AuthorizationRule.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleCreateSettings SetName(this AzureEventhubsNamespaceAuthorizationRuleCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceAuthorizationRuleCreateSettings.Name"/>.</em></p><p>Name of Namespace AuthorizationRule.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleCreateSettings ResetName(this AzureEventhubsNamespaceAuthorizationRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region NamespaceName
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceAuthorizationRuleCreateSettings.NamespaceName"/>.</em></p><p>Name of Namespace.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleCreateSettings SetNamespaceName(this AzureEventhubsNamespaceAuthorizationRuleCreateSettings toolSettings, string namespaceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = namespaceName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceAuthorizationRuleCreateSettings.NamespaceName"/>.</em></p><p>Name of Namespace.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleCreateSettings ResetNamespaceName(this AzureEventhubsNamespaceAuthorizationRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceAuthorizationRuleCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleCreateSettings SetResourceGroup(this AzureEventhubsNamespaceAuthorizationRuleCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceAuthorizationRuleCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleCreateSettings ResetResourceGroup(this AzureEventhubsNamespaceAuthorizationRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Rights
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceAuthorizationRuleCreateSettings.Rights"/> to a new list.</em></p><p>Space-separated list of Authorization rule rights.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleCreateSettings SetRights(this AzureEventhubsNamespaceAuthorizationRuleCreateSettings toolSettings, params EventhubsNamespaceAuthorizationRuleRights[] rights)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RightsInternal = rights.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceAuthorizationRuleCreateSettings.Rights"/> to a new list.</em></p><p>Space-separated list of Authorization rule rights.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleCreateSettings SetRights(this AzureEventhubsNamespaceAuthorizationRuleCreateSettings toolSettings, IEnumerable<EventhubsNamespaceAuthorizationRuleRights> rights)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RightsInternal = rights.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureEventhubsNamespaceAuthorizationRuleCreateSettings.Rights"/>.</em></p><p>Space-separated list of Authorization rule rights.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleCreateSettings AddRights(this AzureEventhubsNamespaceAuthorizationRuleCreateSettings toolSettings, params EventhubsNamespaceAuthorizationRuleRights[] rights)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RightsInternal.AddRange(rights);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureEventhubsNamespaceAuthorizationRuleCreateSettings.Rights"/>.</em></p><p>Space-separated list of Authorization rule rights.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleCreateSettings AddRights(this AzureEventhubsNamespaceAuthorizationRuleCreateSettings toolSettings, IEnumerable<EventhubsNamespaceAuthorizationRuleRights> rights)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RightsInternal.AddRange(rights);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureEventhubsNamespaceAuthorizationRuleCreateSettings.Rights"/>.</em></p><p>Space-separated list of Authorization rule rights.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleCreateSettings ClearRights(this AzureEventhubsNamespaceAuthorizationRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RightsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureEventhubsNamespaceAuthorizationRuleCreateSettings.Rights"/>.</em></p><p>Space-separated list of Authorization rule rights.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleCreateSettings RemoveRights(this AzureEventhubsNamespaceAuthorizationRuleCreateSettings toolSettings, params EventhubsNamespaceAuthorizationRuleRights[] rights)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<EventhubsNamespaceAuthorizationRuleRights>(rights);
            toolSettings.RightsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureEventhubsNamespaceAuthorizationRuleCreateSettings.Rights"/>.</em></p><p>Space-separated list of Authorization rule rights.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleCreateSettings RemoveRights(this AzureEventhubsNamespaceAuthorizationRuleCreateSettings toolSettings, IEnumerable<EventhubsNamespaceAuthorizationRuleRights> rights)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<EventhubsNamespaceAuthorizationRuleRights>(rights);
            toolSettings.RightsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceAuthorizationRuleCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleCreateSettings SetDebug(this AzureEventhubsNamespaceAuthorizationRuleCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceAuthorizationRuleCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleCreateSettings ResetDebug(this AzureEventhubsNamespaceAuthorizationRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceAuthorizationRuleCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleCreateSettings SetHelp(this AzureEventhubsNamespaceAuthorizationRuleCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceAuthorizationRuleCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleCreateSettings ResetHelp(this AzureEventhubsNamespaceAuthorizationRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceAuthorizationRuleCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleCreateSettings SetOutput(this AzureEventhubsNamespaceAuthorizationRuleCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceAuthorizationRuleCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleCreateSettings ResetOutput(this AzureEventhubsNamespaceAuthorizationRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceAuthorizationRuleCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleCreateSettings SetQuery(this AzureEventhubsNamespaceAuthorizationRuleCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceAuthorizationRuleCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleCreateSettings ResetQuery(this AzureEventhubsNamespaceAuthorizationRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceAuthorizationRuleCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleCreateSettings SetVerbose(this AzureEventhubsNamespaceAuthorizationRuleCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceAuthorizationRuleCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleCreateSettings ResetVerbose(this AzureEventhubsNamespaceAuthorizationRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureEventhubsNamespaceAuthorizationRuleDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventhubsNamespaceAuthorizationRuleDeleteSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceAuthorizationRuleDeleteSettings.Name"/>.</em></p><p>Name of Namespace AuthorizationRule.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleDeleteSettings SetName(this AzureEventhubsNamespaceAuthorizationRuleDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceAuthorizationRuleDeleteSettings.Name"/>.</em></p><p>Name of Namespace AuthorizationRule.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleDeleteSettings ResetName(this AzureEventhubsNamespaceAuthorizationRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region NamespaceName
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceAuthorizationRuleDeleteSettings.NamespaceName"/>.</em></p><p>Name of Namespace.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleDeleteSettings SetNamespaceName(this AzureEventhubsNamespaceAuthorizationRuleDeleteSettings toolSettings, string namespaceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = namespaceName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceAuthorizationRuleDeleteSettings.NamespaceName"/>.</em></p><p>Name of Namespace.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleDeleteSettings ResetNamespaceName(this AzureEventhubsNamespaceAuthorizationRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceAuthorizationRuleDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleDeleteSettings SetResourceGroup(this AzureEventhubsNamespaceAuthorizationRuleDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceAuthorizationRuleDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleDeleteSettings ResetResourceGroup(this AzureEventhubsNamespaceAuthorizationRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceAuthorizationRuleDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleDeleteSettings SetDebug(this AzureEventhubsNamespaceAuthorizationRuleDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceAuthorizationRuleDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleDeleteSettings ResetDebug(this AzureEventhubsNamespaceAuthorizationRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceAuthorizationRuleDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleDeleteSettings SetHelp(this AzureEventhubsNamespaceAuthorizationRuleDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceAuthorizationRuleDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleDeleteSettings ResetHelp(this AzureEventhubsNamespaceAuthorizationRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceAuthorizationRuleDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleDeleteSettings SetOutput(this AzureEventhubsNamespaceAuthorizationRuleDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceAuthorizationRuleDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleDeleteSettings ResetOutput(this AzureEventhubsNamespaceAuthorizationRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceAuthorizationRuleDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleDeleteSettings SetQuery(this AzureEventhubsNamespaceAuthorizationRuleDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceAuthorizationRuleDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleDeleteSettings ResetQuery(this AzureEventhubsNamespaceAuthorizationRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceAuthorizationRuleDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleDeleteSettings SetVerbose(this AzureEventhubsNamespaceAuthorizationRuleDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceAuthorizationRuleDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleDeleteSettings ResetVerbose(this AzureEventhubsNamespaceAuthorizationRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureEventhubsNamespaceAuthorizationRuleListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventhubsNamespaceAuthorizationRuleListSettingsExtensions
    {
        #region NamespaceName
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceAuthorizationRuleListSettings.NamespaceName"/>.</em></p><p>Name of Namespace.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleListSettings SetNamespaceName(this AzureEventhubsNamespaceAuthorizationRuleListSettings toolSettings, string namespaceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = namespaceName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceAuthorizationRuleListSettings.NamespaceName"/>.</em></p><p>Name of Namespace.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleListSettings ResetNamespaceName(this AzureEventhubsNamespaceAuthorizationRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceAuthorizationRuleListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleListSettings SetResourceGroup(this AzureEventhubsNamespaceAuthorizationRuleListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceAuthorizationRuleListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleListSettings ResetResourceGroup(this AzureEventhubsNamespaceAuthorizationRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceAuthorizationRuleListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleListSettings SetDebug(this AzureEventhubsNamespaceAuthorizationRuleListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceAuthorizationRuleListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleListSettings ResetDebug(this AzureEventhubsNamespaceAuthorizationRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceAuthorizationRuleListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleListSettings SetHelp(this AzureEventhubsNamespaceAuthorizationRuleListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceAuthorizationRuleListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleListSettings ResetHelp(this AzureEventhubsNamespaceAuthorizationRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceAuthorizationRuleListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleListSettings SetOutput(this AzureEventhubsNamespaceAuthorizationRuleListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceAuthorizationRuleListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleListSettings ResetOutput(this AzureEventhubsNamespaceAuthorizationRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceAuthorizationRuleListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleListSettings SetQuery(this AzureEventhubsNamespaceAuthorizationRuleListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceAuthorizationRuleListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleListSettings ResetQuery(this AzureEventhubsNamespaceAuthorizationRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceAuthorizationRuleListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleListSettings SetVerbose(this AzureEventhubsNamespaceAuthorizationRuleListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceAuthorizationRuleListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleListSettings ResetVerbose(this AzureEventhubsNamespaceAuthorizationRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureEventhubsNamespaceAuthorizationRuleShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventhubsNamespaceAuthorizationRuleShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceAuthorizationRuleShowSettings.Name"/>.</em></p><p>Name of Namespace AuthorizationRule.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleShowSettings SetName(this AzureEventhubsNamespaceAuthorizationRuleShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceAuthorizationRuleShowSettings.Name"/>.</em></p><p>Name of Namespace AuthorizationRule.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleShowSettings ResetName(this AzureEventhubsNamespaceAuthorizationRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region NamespaceName
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceAuthorizationRuleShowSettings.NamespaceName"/>.</em></p><p>Name of Namespace.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleShowSettings SetNamespaceName(this AzureEventhubsNamespaceAuthorizationRuleShowSettings toolSettings, string namespaceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = namespaceName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceAuthorizationRuleShowSettings.NamespaceName"/>.</em></p><p>Name of Namespace.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleShowSettings ResetNamespaceName(this AzureEventhubsNamespaceAuthorizationRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceAuthorizationRuleShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleShowSettings SetResourceGroup(this AzureEventhubsNamespaceAuthorizationRuleShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceAuthorizationRuleShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleShowSettings ResetResourceGroup(this AzureEventhubsNamespaceAuthorizationRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceAuthorizationRuleShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleShowSettings SetDebug(this AzureEventhubsNamespaceAuthorizationRuleShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceAuthorizationRuleShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleShowSettings ResetDebug(this AzureEventhubsNamespaceAuthorizationRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceAuthorizationRuleShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleShowSettings SetHelp(this AzureEventhubsNamespaceAuthorizationRuleShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceAuthorizationRuleShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleShowSettings ResetHelp(this AzureEventhubsNamespaceAuthorizationRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceAuthorizationRuleShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleShowSettings SetOutput(this AzureEventhubsNamespaceAuthorizationRuleShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceAuthorizationRuleShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleShowSettings ResetOutput(this AzureEventhubsNamespaceAuthorizationRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceAuthorizationRuleShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleShowSettings SetQuery(this AzureEventhubsNamespaceAuthorizationRuleShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceAuthorizationRuleShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleShowSettings ResetQuery(this AzureEventhubsNamespaceAuthorizationRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceAuthorizationRuleShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleShowSettings SetVerbose(this AzureEventhubsNamespaceAuthorizationRuleShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceAuthorizationRuleShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleShowSettings ResetVerbose(this AzureEventhubsNamespaceAuthorizationRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureEventhubsNamespaceAuthorizationRuleUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventhubsNamespaceAuthorizationRuleUpdateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceAuthorizationRuleUpdateSettings.Name"/>.</em></p><p>Name of Namespace AuthorizationRule.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleUpdateSettings SetName(this AzureEventhubsNamespaceAuthorizationRuleUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceAuthorizationRuleUpdateSettings.Name"/>.</em></p><p>Name of Namespace AuthorizationRule.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleUpdateSettings ResetName(this AzureEventhubsNamespaceAuthorizationRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region NamespaceName
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceAuthorizationRuleUpdateSettings.NamespaceName"/>.</em></p><p>Name of Namespace.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleUpdateSettings SetNamespaceName(this AzureEventhubsNamespaceAuthorizationRuleUpdateSettings toolSettings, string namespaceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = namespaceName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceAuthorizationRuleUpdateSettings.NamespaceName"/>.</em></p><p>Name of Namespace.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleUpdateSettings ResetNamespaceName(this AzureEventhubsNamespaceAuthorizationRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceAuthorizationRuleUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleUpdateSettings SetResourceGroup(this AzureEventhubsNamespaceAuthorizationRuleUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceAuthorizationRuleUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleUpdateSettings ResetResourceGroup(this AzureEventhubsNamespaceAuthorizationRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Rights
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceAuthorizationRuleUpdateSettings.Rights"/> to a new list.</em></p><p>Space-separated list of Authorization rule rights.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleUpdateSettings SetRights(this AzureEventhubsNamespaceAuthorizationRuleUpdateSettings toolSettings, params EventhubsNamespaceAuthorizationRuleRights[] rights)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RightsInternal = rights.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceAuthorizationRuleUpdateSettings.Rights"/> to a new list.</em></p><p>Space-separated list of Authorization rule rights.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleUpdateSettings SetRights(this AzureEventhubsNamespaceAuthorizationRuleUpdateSettings toolSettings, IEnumerable<EventhubsNamespaceAuthorizationRuleRights> rights)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RightsInternal = rights.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureEventhubsNamespaceAuthorizationRuleUpdateSettings.Rights"/>.</em></p><p>Space-separated list of Authorization rule rights.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleUpdateSettings AddRights(this AzureEventhubsNamespaceAuthorizationRuleUpdateSettings toolSettings, params EventhubsNamespaceAuthorizationRuleRights[] rights)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RightsInternal.AddRange(rights);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureEventhubsNamespaceAuthorizationRuleUpdateSettings.Rights"/>.</em></p><p>Space-separated list of Authorization rule rights.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleUpdateSettings AddRights(this AzureEventhubsNamespaceAuthorizationRuleUpdateSettings toolSettings, IEnumerable<EventhubsNamespaceAuthorizationRuleRights> rights)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RightsInternal.AddRange(rights);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureEventhubsNamespaceAuthorizationRuleUpdateSettings.Rights"/>.</em></p><p>Space-separated list of Authorization rule rights.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleUpdateSettings ClearRights(this AzureEventhubsNamespaceAuthorizationRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RightsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureEventhubsNamespaceAuthorizationRuleUpdateSettings.Rights"/>.</em></p><p>Space-separated list of Authorization rule rights.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleUpdateSettings RemoveRights(this AzureEventhubsNamespaceAuthorizationRuleUpdateSettings toolSettings, params EventhubsNamespaceAuthorizationRuleRights[] rights)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<EventhubsNamespaceAuthorizationRuleRights>(rights);
            toolSettings.RightsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureEventhubsNamespaceAuthorizationRuleUpdateSettings.Rights"/>.</em></p><p>Space-separated list of Authorization rule rights.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleUpdateSettings RemoveRights(this AzureEventhubsNamespaceAuthorizationRuleUpdateSettings toolSettings, IEnumerable<EventhubsNamespaceAuthorizationRuleRights> rights)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<EventhubsNamespaceAuthorizationRuleRights>(rights);
            toolSettings.RightsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceAuthorizationRuleUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleUpdateSettings SetAdd(this AzureEventhubsNamespaceAuthorizationRuleUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceAuthorizationRuleUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleUpdateSettings ResetAdd(this AzureEventhubsNamespaceAuthorizationRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region ForceString
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceAuthorizationRuleUpdateSettings.ForceString"/>.</em></p><p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleUpdateSettings SetForceString(this AzureEventhubsNamespaceAuthorizationRuleUpdateSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceAuthorizationRuleUpdateSettings.ForceString"/>.</em></p><p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleUpdateSettings ResetForceString(this AzureEventhubsNamespaceAuthorizationRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceAuthorizationRuleUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleUpdateSettings SetRemove(this AzureEventhubsNamespaceAuthorizationRuleUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceAuthorizationRuleUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleUpdateSettings ResetRemove(this AzureEventhubsNamespaceAuthorizationRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceAuthorizationRuleUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleUpdateSettings SetSet(this AzureEventhubsNamespaceAuthorizationRuleUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceAuthorizationRuleUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleUpdateSettings ResetSet(this AzureEventhubsNamespaceAuthorizationRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceAuthorizationRuleUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleUpdateSettings SetDebug(this AzureEventhubsNamespaceAuthorizationRuleUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceAuthorizationRuleUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleUpdateSettings ResetDebug(this AzureEventhubsNamespaceAuthorizationRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceAuthorizationRuleUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleUpdateSettings SetHelp(this AzureEventhubsNamespaceAuthorizationRuleUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceAuthorizationRuleUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleUpdateSettings ResetHelp(this AzureEventhubsNamespaceAuthorizationRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceAuthorizationRuleUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleUpdateSettings SetOutput(this AzureEventhubsNamespaceAuthorizationRuleUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceAuthorizationRuleUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleUpdateSettings ResetOutput(this AzureEventhubsNamespaceAuthorizationRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceAuthorizationRuleUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleUpdateSettings SetQuery(this AzureEventhubsNamespaceAuthorizationRuleUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceAuthorizationRuleUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleUpdateSettings ResetQuery(this AzureEventhubsNamespaceAuthorizationRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceAuthorizationRuleUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleUpdateSettings SetVerbose(this AzureEventhubsNamespaceAuthorizationRuleUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceAuthorizationRuleUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleUpdateSettings ResetVerbose(this AzureEventhubsNamespaceAuthorizationRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureEventhubsGeorecoveryAliasAuthorizationRuleListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventhubsGeorecoveryAliasAuthorizationRuleListSettingsExtensions
    {
        #region Alias
        /// <summary><p><em>Sets <see cref="AzureEventhubsGeorecoveryAliasAuthorizationRuleListSettings.Alias"/>.</em></p><p>Name of Geo-Disaster Recovery Configuration Alias.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasAuthorizationRuleListSettings SetAlias(this AzureEventhubsGeorecoveryAliasAuthorizationRuleListSettings toolSettings, string alias)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Alias = alias;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsGeorecoveryAliasAuthorizationRuleListSettings.Alias"/>.</em></p><p>Name of Geo-Disaster Recovery Configuration Alias.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasAuthorizationRuleListSettings ResetAlias(this AzureEventhubsGeorecoveryAliasAuthorizationRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Alias = null;
            return toolSettings;
        }
        #endregion
        #region NamespaceName
        /// <summary><p><em>Sets <see cref="AzureEventhubsGeorecoveryAliasAuthorizationRuleListSettings.NamespaceName"/>.</em></p><p>Name of Namespace.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasAuthorizationRuleListSettings SetNamespaceName(this AzureEventhubsGeorecoveryAliasAuthorizationRuleListSettings toolSettings, string namespaceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = namespaceName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsGeorecoveryAliasAuthorizationRuleListSettings.NamespaceName"/>.</em></p><p>Name of Namespace.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasAuthorizationRuleListSettings ResetNamespaceName(this AzureEventhubsGeorecoveryAliasAuthorizationRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureEventhubsGeorecoveryAliasAuthorizationRuleListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasAuthorizationRuleListSettings SetResourceGroup(this AzureEventhubsGeorecoveryAliasAuthorizationRuleListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsGeorecoveryAliasAuthorizationRuleListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasAuthorizationRuleListSettings ResetResourceGroup(this AzureEventhubsGeorecoveryAliasAuthorizationRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureEventhubsGeorecoveryAliasAuthorizationRuleListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasAuthorizationRuleListSettings SetDebug(this AzureEventhubsGeorecoveryAliasAuthorizationRuleListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsGeorecoveryAliasAuthorizationRuleListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasAuthorizationRuleListSettings ResetDebug(this AzureEventhubsGeorecoveryAliasAuthorizationRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureEventhubsGeorecoveryAliasAuthorizationRuleListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasAuthorizationRuleListSettings SetHelp(this AzureEventhubsGeorecoveryAliasAuthorizationRuleListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsGeorecoveryAliasAuthorizationRuleListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasAuthorizationRuleListSettings ResetHelp(this AzureEventhubsGeorecoveryAliasAuthorizationRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureEventhubsGeorecoveryAliasAuthorizationRuleListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasAuthorizationRuleListSettings SetOutput(this AzureEventhubsGeorecoveryAliasAuthorizationRuleListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsGeorecoveryAliasAuthorizationRuleListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasAuthorizationRuleListSettings ResetOutput(this AzureEventhubsGeorecoveryAliasAuthorizationRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureEventhubsGeorecoveryAliasAuthorizationRuleListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasAuthorizationRuleListSettings SetQuery(this AzureEventhubsGeorecoveryAliasAuthorizationRuleListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsGeorecoveryAliasAuthorizationRuleListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasAuthorizationRuleListSettings ResetQuery(this AzureEventhubsGeorecoveryAliasAuthorizationRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureEventhubsGeorecoveryAliasAuthorizationRuleListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasAuthorizationRuleListSettings SetVerbose(this AzureEventhubsGeorecoveryAliasAuthorizationRuleListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsGeorecoveryAliasAuthorizationRuleListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasAuthorizationRuleListSettings ResetVerbose(this AzureEventhubsGeorecoveryAliasAuthorizationRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureEventhubsGeorecoveryAliasAuthorizationRuleShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventhubsGeorecoveryAliasAuthorizationRuleShowSettingsExtensions
    {
        #region Alias
        /// <summary><p><em>Sets <see cref="AzureEventhubsGeorecoveryAliasAuthorizationRuleShowSettings.Alias"/>.</em></p><p>Name of Geo-Disaster Recovery Configuration Alias.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasAuthorizationRuleShowSettings SetAlias(this AzureEventhubsGeorecoveryAliasAuthorizationRuleShowSettings toolSettings, string alias)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Alias = alias;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsGeorecoveryAliasAuthorizationRuleShowSettings.Alias"/>.</em></p><p>Name of Geo-Disaster Recovery Configuration Alias.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasAuthorizationRuleShowSettings ResetAlias(this AzureEventhubsGeorecoveryAliasAuthorizationRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Alias = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureEventhubsGeorecoveryAliasAuthorizationRuleShowSettings.Name"/>.</em></p><p>Name of Namespace AuthorizationRule.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasAuthorizationRuleShowSettings SetName(this AzureEventhubsGeorecoveryAliasAuthorizationRuleShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsGeorecoveryAliasAuthorizationRuleShowSettings.Name"/>.</em></p><p>Name of Namespace AuthorizationRule.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasAuthorizationRuleShowSettings ResetName(this AzureEventhubsGeorecoveryAliasAuthorizationRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region NamespaceName
        /// <summary><p><em>Sets <see cref="AzureEventhubsGeorecoveryAliasAuthorizationRuleShowSettings.NamespaceName"/>.</em></p><p>Name of Namespace.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasAuthorizationRuleShowSettings SetNamespaceName(this AzureEventhubsGeorecoveryAliasAuthorizationRuleShowSettings toolSettings, string namespaceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = namespaceName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsGeorecoveryAliasAuthorizationRuleShowSettings.NamespaceName"/>.</em></p><p>Name of Namespace.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasAuthorizationRuleShowSettings ResetNamespaceName(this AzureEventhubsGeorecoveryAliasAuthorizationRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureEventhubsGeorecoveryAliasAuthorizationRuleShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasAuthorizationRuleShowSettings SetResourceGroup(this AzureEventhubsGeorecoveryAliasAuthorizationRuleShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsGeorecoveryAliasAuthorizationRuleShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasAuthorizationRuleShowSettings ResetResourceGroup(this AzureEventhubsGeorecoveryAliasAuthorizationRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureEventhubsGeorecoveryAliasAuthorizationRuleShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasAuthorizationRuleShowSettings SetDebug(this AzureEventhubsGeorecoveryAliasAuthorizationRuleShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsGeorecoveryAliasAuthorizationRuleShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasAuthorizationRuleShowSettings ResetDebug(this AzureEventhubsGeorecoveryAliasAuthorizationRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureEventhubsGeorecoveryAliasAuthorizationRuleShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasAuthorizationRuleShowSettings SetHelp(this AzureEventhubsGeorecoveryAliasAuthorizationRuleShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsGeorecoveryAliasAuthorizationRuleShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasAuthorizationRuleShowSettings ResetHelp(this AzureEventhubsGeorecoveryAliasAuthorizationRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureEventhubsGeorecoveryAliasAuthorizationRuleShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasAuthorizationRuleShowSettings SetOutput(this AzureEventhubsGeorecoveryAliasAuthorizationRuleShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsGeorecoveryAliasAuthorizationRuleShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasAuthorizationRuleShowSettings ResetOutput(this AzureEventhubsGeorecoveryAliasAuthorizationRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureEventhubsGeorecoveryAliasAuthorizationRuleShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasAuthorizationRuleShowSettings SetQuery(this AzureEventhubsGeorecoveryAliasAuthorizationRuleShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsGeorecoveryAliasAuthorizationRuleShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasAuthorizationRuleShowSettings ResetQuery(this AzureEventhubsGeorecoveryAliasAuthorizationRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureEventhubsGeorecoveryAliasAuthorizationRuleShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasAuthorizationRuleShowSettings SetVerbose(this AzureEventhubsGeorecoveryAliasAuthorizationRuleShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsGeorecoveryAliasAuthorizationRuleShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasAuthorizationRuleShowSettings ResetVerbose(this AzureEventhubsGeorecoveryAliasAuthorizationRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureEventhubsEventhubConsumerGroupCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventhubsEventhubConsumerGroupCreateSettingsExtensions
    {
        #region EventhubName
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubConsumerGroupCreateSettings.EventhubName"/>.</em></p><p>Name of EventHub.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupCreateSettings SetEventhubName(this AzureEventhubsEventhubConsumerGroupCreateSettings toolSettings, string eventhubName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EventhubName = eventhubName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubConsumerGroupCreateSettings.EventhubName"/>.</em></p><p>Name of EventHub.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupCreateSettings ResetEventhubName(this AzureEventhubsEventhubConsumerGroupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EventhubName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubConsumerGroupCreateSettings.Name"/>.</em></p><p>Name of ConsumerGroup.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupCreateSettings SetName(this AzureEventhubsEventhubConsumerGroupCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubConsumerGroupCreateSettings.Name"/>.</em></p><p>Name of ConsumerGroup.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupCreateSettings ResetName(this AzureEventhubsEventhubConsumerGroupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region NamespaceName
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubConsumerGroupCreateSettings.NamespaceName"/>.</em></p><p>Name of Namespace.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupCreateSettings SetNamespaceName(this AzureEventhubsEventhubConsumerGroupCreateSettings toolSettings, string namespaceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = namespaceName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubConsumerGroupCreateSettings.NamespaceName"/>.</em></p><p>Name of Namespace.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupCreateSettings ResetNamespaceName(this AzureEventhubsEventhubConsumerGroupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubConsumerGroupCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupCreateSettings SetResourceGroup(this AzureEventhubsEventhubConsumerGroupCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubConsumerGroupCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupCreateSettings ResetResourceGroup(this AzureEventhubsEventhubConsumerGroupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region UserMetadata
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubConsumerGroupCreateSettings.UserMetadata"/>.</em></p><p>Usermetadata is a placeholder to store user-defined string data with maximum length 1024. e.g. it can be used to store descriptive data, such as list of teams and their contact information also user-defined configuration settings can be stored.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupCreateSettings SetUserMetadata(this AzureEventhubsEventhubConsumerGroupCreateSettings toolSettings, string userMetadata)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UserMetadata = userMetadata;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubConsumerGroupCreateSettings.UserMetadata"/>.</em></p><p>Usermetadata is a placeholder to store user-defined string data with maximum length 1024. e.g. it can be used to store descriptive data, such as list of teams and their contact information also user-defined configuration settings can be stored.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupCreateSettings ResetUserMetadata(this AzureEventhubsEventhubConsumerGroupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UserMetadata = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubConsumerGroupCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupCreateSettings SetDebug(this AzureEventhubsEventhubConsumerGroupCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubConsumerGroupCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupCreateSettings ResetDebug(this AzureEventhubsEventhubConsumerGroupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubConsumerGroupCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupCreateSettings SetHelp(this AzureEventhubsEventhubConsumerGroupCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubConsumerGroupCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupCreateSettings ResetHelp(this AzureEventhubsEventhubConsumerGroupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubConsumerGroupCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupCreateSettings SetOutput(this AzureEventhubsEventhubConsumerGroupCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubConsumerGroupCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupCreateSettings ResetOutput(this AzureEventhubsEventhubConsumerGroupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubConsumerGroupCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupCreateSettings SetQuery(this AzureEventhubsEventhubConsumerGroupCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubConsumerGroupCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupCreateSettings ResetQuery(this AzureEventhubsEventhubConsumerGroupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubConsumerGroupCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupCreateSettings SetVerbose(this AzureEventhubsEventhubConsumerGroupCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubConsumerGroupCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupCreateSettings ResetVerbose(this AzureEventhubsEventhubConsumerGroupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureEventhubsEventhubConsumerGroupDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventhubsEventhubConsumerGroupDeleteSettingsExtensions
    {
        #region EventhubName
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubConsumerGroupDeleteSettings.EventhubName"/>.</em></p><p>Name of EventHub.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupDeleteSettings SetEventhubName(this AzureEventhubsEventhubConsumerGroupDeleteSettings toolSettings, string eventhubName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EventhubName = eventhubName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubConsumerGroupDeleteSettings.EventhubName"/>.</em></p><p>Name of EventHub.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupDeleteSettings ResetEventhubName(this AzureEventhubsEventhubConsumerGroupDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EventhubName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubConsumerGroupDeleteSettings.Name"/>.</em></p><p>Name of ConsumerGroup.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupDeleteSettings SetName(this AzureEventhubsEventhubConsumerGroupDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubConsumerGroupDeleteSettings.Name"/>.</em></p><p>Name of ConsumerGroup.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupDeleteSettings ResetName(this AzureEventhubsEventhubConsumerGroupDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region NamespaceName
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubConsumerGroupDeleteSettings.NamespaceName"/>.</em></p><p>Name of Namespace.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupDeleteSettings SetNamespaceName(this AzureEventhubsEventhubConsumerGroupDeleteSettings toolSettings, string namespaceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = namespaceName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubConsumerGroupDeleteSettings.NamespaceName"/>.</em></p><p>Name of Namespace.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupDeleteSettings ResetNamespaceName(this AzureEventhubsEventhubConsumerGroupDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubConsumerGroupDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupDeleteSettings SetResourceGroup(this AzureEventhubsEventhubConsumerGroupDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubConsumerGroupDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupDeleteSettings ResetResourceGroup(this AzureEventhubsEventhubConsumerGroupDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubConsumerGroupDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupDeleteSettings SetDebug(this AzureEventhubsEventhubConsumerGroupDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubConsumerGroupDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupDeleteSettings ResetDebug(this AzureEventhubsEventhubConsumerGroupDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubConsumerGroupDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupDeleteSettings SetHelp(this AzureEventhubsEventhubConsumerGroupDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubConsumerGroupDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupDeleteSettings ResetHelp(this AzureEventhubsEventhubConsumerGroupDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubConsumerGroupDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupDeleteSettings SetOutput(this AzureEventhubsEventhubConsumerGroupDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubConsumerGroupDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupDeleteSettings ResetOutput(this AzureEventhubsEventhubConsumerGroupDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubConsumerGroupDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupDeleteSettings SetQuery(this AzureEventhubsEventhubConsumerGroupDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubConsumerGroupDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupDeleteSettings ResetQuery(this AzureEventhubsEventhubConsumerGroupDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubConsumerGroupDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupDeleteSettings SetVerbose(this AzureEventhubsEventhubConsumerGroupDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubConsumerGroupDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupDeleteSettings ResetVerbose(this AzureEventhubsEventhubConsumerGroupDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureEventhubsEventhubConsumerGroupListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventhubsEventhubConsumerGroupListSettingsExtensions
    {
        #region EventhubName
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubConsumerGroupListSettings.EventhubName"/>.</em></p><p>Name of EventHub.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupListSettings SetEventhubName(this AzureEventhubsEventhubConsumerGroupListSettings toolSettings, string eventhubName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EventhubName = eventhubName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubConsumerGroupListSettings.EventhubName"/>.</em></p><p>Name of EventHub.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupListSettings ResetEventhubName(this AzureEventhubsEventhubConsumerGroupListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EventhubName = null;
            return toolSettings;
        }
        #endregion
        #region NamespaceName
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubConsumerGroupListSettings.NamespaceName"/>.</em></p><p>Name of Namespace.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupListSettings SetNamespaceName(this AzureEventhubsEventhubConsumerGroupListSettings toolSettings, string namespaceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = namespaceName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubConsumerGroupListSettings.NamespaceName"/>.</em></p><p>Name of Namespace.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupListSettings ResetNamespaceName(this AzureEventhubsEventhubConsumerGroupListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubConsumerGroupListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupListSettings SetResourceGroup(this AzureEventhubsEventhubConsumerGroupListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubConsumerGroupListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupListSettings ResetResourceGroup(this AzureEventhubsEventhubConsumerGroupListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Skip
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubConsumerGroupListSettings.Skip"/>.</em></p><p>Skip is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skip parameter that specifies a starting point to use for subsequent calls.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupListSettings SetSkip(this AzureEventhubsEventhubConsumerGroupListSettings toolSettings, string skip)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Skip = skip;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubConsumerGroupListSettings.Skip"/>.</em></p><p>Skip is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skip parameter that specifies a starting point to use for subsequent calls.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupListSettings ResetSkip(this AzureEventhubsEventhubConsumerGroupListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Skip = null;
            return toolSettings;
        }
        #endregion
        #region Top
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubConsumerGroupListSettings.Top"/>.</em></p><p>May be used to limit the number of results to the most recent N usageDetails.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupListSettings SetTop(this AzureEventhubsEventhubConsumerGroupListSettings toolSettings, string top)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = top;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubConsumerGroupListSettings.Top"/>.</em></p><p>May be used to limit the number of results to the most recent N usageDetails.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupListSettings ResetTop(this AzureEventhubsEventhubConsumerGroupListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubConsumerGroupListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupListSettings SetDebug(this AzureEventhubsEventhubConsumerGroupListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubConsumerGroupListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupListSettings ResetDebug(this AzureEventhubsEventhubConsumerGroupListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubConsumerGroupListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupListSettings SetHelp(this AzureEventhubsEventhubConsumerGroupListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubConsumerGroupListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupListSettings ResetHelp(this AzureEventhubsEventhubConsumerGroupListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubConsumerGroupListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupListSettings SetOutput(this AzureEventhubsEventhubConsumerGroupListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubConsumerGroupListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupListSettings ResetOutput(this AzureEventhubsEventhubConsumerGroupListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubConsumerGroupListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupListSettings SetQuery(this AzureEventhubsEventhubConsumerGroupListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubConsumerGroupListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupListSettings ResetQuery(this AzureEventhubsEventhubConsumerGroupListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubConsumerGroupListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupListSettings SetVerbose(this AzureEventhubsEventhubConsumerGroupListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubConsumerGroupListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupListSettings ResetVerbose(this AzureEventhubsEventhubConsumerGroupListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureEventhubsEventhubConsumerGroupShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventhubsEventhubConsumerGroupShowSettingsExtensions
    {
        #region EventhubName
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubConsumerGroupShowSettings.EventhubName"/>.</em></p><p>Name of EventHub.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupShowSettings SetEventhubName(this AzureEventhubsEventhubConsumerGroupShowSettings toolSettings, string eventhubName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EventhubName = eventhubName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubConsumerGroupShowSettings.EventhubName"/>.</em></p><p>Name of EventHub.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupShowSettings ResetEventhubName(this AzureEventhubsEventhubConsumerGroupShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EventhubName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubConsumerGroupShowSettings.Name"/>.</em></p><p>Name of ConsumerGroup.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupShowSettings SetName(this AzureEventhubsEventhubConsumerGroupShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubConsumerGroupShowSettings.Name"/>.</em></p><p>Name of ConsumerGroup.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupShowSettings ResetName(this AzureEventhubsEventhubConsumerGroupShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region NamespaceName
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubConsumerGroupShowSettings.NamespaceName"/>.</em></p><p>Name of Namespace.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupShowSettings SetNamespaceName(this AzureEventhubsEventhubConsumerGroupShowSettings toolSettings, string namespaceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = namespaceName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubConsumerGroupShowSettings.NamespaceName"/>.</em></p><p>Name of Namespace.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupShowSettings ResetNamespaceName(this AzureEventhubsEventhubConsumerGroupShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubConsumerGroupShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupShowSettings SetResourceGroup(this AzureEventhubsEventhubConsumerGroupShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubConsumerGroupShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupShowSettings ResetResourceGroup(this AzureEventhubsEventhubConsumerGroupShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubConsumerGroupShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupShowSettings SetDebug(this AzureEventhubsEventhubConsumerGroupShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubConsumerGroupShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupShowSettings ResetDebug(this AzureEventhubsEventhubConsumerGroupShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubConsumerGroupShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupShowSettings SetHelp(this AzureEventhubsEventhubConsumerGroupShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubConsumerGroupShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupShowSettings ResetHelp(this AzureEventhubsEventhubConsumerGroupShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubConsumerGroupShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupShowSettings SetOutput(this AzureEventhubsEventhubConsumerGroupShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubConsumerGroupShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupShowSettings ResetOutput(this AzureEventhubsEventhubConsumerGroupShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubConsumerGroupShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupShowSettings SetQuery(this AzureEventhubsEventhubConsumerGroupShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubConsumerGroupShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupShowSettings ResetQuery(this AzureEventhubsEventhubConsumerGroupShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubConsumerGroupShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupShowSettings SetVerbose(this AzureEventhubsEventhubConsumerGroupShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubConsumerGroupShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupShowSettings ResetVerbose(this AzureEventhubsEventhubConsumerGroupShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureEventhubsEventhubConsumerGroupUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventhubsEventhubConsumerGroupUpdateSettingsExtensions
    {
        #region EventhubName
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubConsumerGroupUpdateSettings.EventhubName"/>.</em></p><p>Name of EventHub.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupUpdateSettings SetEventhubName(this AzureEventhubsEventhubConsumerGroupUpdateSettings toolSettings, string eventhubName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EventhubName = eventhubName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubConsumerGroupUpdateSettings.EventhubName"/>.</em></p><p>Name of EventHub.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupUpdateSettings ResetEventhubName(this AzureEventhubsEventhubConsumerGroupUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EventhubName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubConsumerGroupUpdateSettings.Name"/>.</em></p><p>Name of ConsumerGroup.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupUpdateSettings SetName(this AzureEventhubsEventhubConsumerGroupUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubConsumerGroupUpdateSettings.Name"/>.</em></p><p>Name of ConsumerGroup.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupUpdateSettings ResetName(this AzureEventhubsEventhubConsumerGroupUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region NamespaceName
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubConsumerGroupUpdateSettings.NamespaceName"/>.</em></p><p>Name of Namespace.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupUpdateSettings SetNamespaceName(this AzureEventhubsEventhubConsumerGroupUpdateSettings toolSettings, string namespaceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = namespaceName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubConsumerGroupUpdateSettings.NamespaceName"/>.</em></p><p>Name of Namespace.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupUpdateSettings ResetNamespaceName(this AzureEventhubsEventhubConsumerGroupUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubConsumerGroupUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupUpdateSettings SetResourceGroup(this AzureEventhubsEventhubConsumerGroupUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubConsumerGroupUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupUpdateSettings ResetResourceGroup(this AzureEventhubsEventhubConsumerGroupUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region UserMetadata
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubConsumerGroupUpdateSettings.UserMetadata"/>.</em></p><p>Usermetadata is a placeholder to store user-defined string data with maximum length 1024. e.g. it can be used to store descriptive data, such as list of teams and their contact information also user-defined configuration settings can be stored.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupUpdateSettings SetUserMetadata(this AzureEventhubsEventhubConsumerGroupUpdateSettings toolSettings, string userMetadata)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UserMetadata = userMetadata;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubConsumerGroupUpdateSettings.UserMetadata"/>.</em></p><p>Usermetadata is a placeholder to store user-defined string data with maximum length 1024. e.g. it can be used to store descriptive data, such as list of teams and their contact information also user-defined configuration settings can be stored.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupUpdateSettings ResetUserMetadata(this AzureEventhubsEventhubConsumerGroupUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UserMetadata = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubConsumerGroupUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupUpdateSettings SetAdd(this AzureEventhubsEventhubConsumerGroupUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubConsumerGroupUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupUpdateSettings ResetAdd(this AzureEventhubsEventhubConsumerGroupUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region ForceString
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubConsumerGroupUpdateSettings.ForceString"/>.</em></p><p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupUpdateSettings SetForceString(this AzureEventhubsEventhubConsumerGroupUpdateSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubConsumerGroupUpdateSettings.ForceString"/>.</em></p><p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupUpdateSettings ResetForceString(this AzureEventhubsEventhubConsumerGroupUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubConsumerGroupUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupUpdateSettings SetRemove(this AzureEventhubsEventhubConsumerGroupUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubConsumerGroupUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupUpdateSettings ResetRemove(this AzureEventhubsEventhubConsumerGroupUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubConsumerGroupUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupUpdateSettings SetSet(this AzureEventhubsEventhubConsumerGroupUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubConsumerGroupUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupUpdateSettings ResetSet(this AzureEventhubsEventhubConsumerGroupUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubConsumerGroupUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupUpdateSettings SetDebug(this AzureEventhubsEventhubConsumerGroupUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubConsumerGroupUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupUpdateSettings ResetDebug(this AzureEventhubsEventhubConsumerGroupUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubConsumerGroupUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupUpdateSettings SetHelp(this AzureEventhubsEventhubConsumerGroupUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubConsumerGroupUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupUpdateSettings ResetHelp(this AzureEventhubsEventhubConsumerGroupUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubConsumerGroupUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupUpdateSettings SetOutput(this AzureEventhubsEventhubConsumerGroupUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubConsumerGroupUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupUpdateSettings ResetOutput(this AzureEventhubsEventhubConsumerGroupUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubConsumerGroupUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupUpdateSettings SetQuery(this AzureEventhubsEventhubConsumerGroupUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubConsumerGroupUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupUpdateSettings ResetQuery(this AzureEventhubsEventhubConsumerGroupUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubConsumerGroupUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupUpdateSettings SetVerbose(this AzureEventhubsEventhubConsumerGroupUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubConsumerGroupUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubConsumerGroupUpdateSettings ResetVerbose(this AzureEventhubsEventhubConsumerGroupUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureEventhubsEventhubAuthorizationRuleCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventhubsEventhubAuthorizationRuleCreateSettingsExtensions
    {
        #region EventhubName
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubAuthorizationRuleCreateSettings.EventhubName"/>.</em></p><p>Name of EventHub.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleCreateSettings SetEventhubName(this AzureEventhubsEventhubAuthorizationRuleCreateSettings toolSettings, string eventhubName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EventhubName = eventhubName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubAuthorizationRuleCreateSettings.EventhubName"/>.</em></p><p>Name of EventHub.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleCreateSettings ResetEventhubName(this AzureEventhubsEventhubAuthorizationRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EventhubName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubAuthorizationRuleCreateSettings.Name"/>.</em></p><p>Name of EventHub AuthorizationRule.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleCreateSettings SetName(this AzureEventhubsEventhubAuthorizationRuleCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubAuthorizationRuleCreateSettings.Name"/>.</em></p><p>Name of EventHub AuthorizationRule.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleCreateSettings ResetName(this AzureEventhubsEventhubAuthorizationRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region NamespaceName
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubAuthorizationRuleCreateSettings.NamespaceName"/>.</em></p><p>Name of Namespace.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleCreateSettings SetNamespaceName(this AzureEventhubsEventhubAuthorizationRuleCreateSettings toolSettings, string namespaceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = namespaceName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubAuthorizationRuleCreateSettings.NamespaceName"/>.</em></p><p>Name of Namespace.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleCreateSettings ResetNamespaceName(this AzureEventhubsEventhubAuthorizationRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubAuthorizationRuleCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleCreateSettings SetResourceGroup(this AzureEventhubsEventhubAuthorizationRuleCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubAuthorizationRuleCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleCreateSettings ResetResourceGroup(this AzureEventhubsEventhubAuthorizationRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Rights
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubAuthorizationRuleCreateSettings.Rights"/> to a new list.</em></p><p>Space-separated list of Authorization rule rights.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleCreateSettings SetRights(this AzureEventhubsEventhubAuthorizationRuleCreateSettings toolSettings, params EventhubsNamespaceAuthorizationRuleRights[] rights)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RightsInternal = rights.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubAuthorizationRuleCreateSettings.Rights"/> to a new list.</em></p><p>Space-separated list of Authorization rule rights.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleCreateSettings SetRights(this AzureEventhubsEventhubAuthorizationRuleCreateSettings toolSettings, IEnumerable<EventhubsNamespaceAuthorizationRuleRights> rights)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RightsInternal = rights.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureEventhubsEventhubAuthorizationRuleCreateSettings.Rights"/>.</em></p><p>Space-separated list of Authorization rule rights.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleCreateSettings AddRights(this AzureEventhubsEventhubAuthorizationRuleCreateSettings toolSettings, params EventhubsNamespaceAuthorizationRuleRights[] rights)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RightsInternal.AddRange(rights);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureEventhubsEventhubAuthorizationRuleCreateSettings.Rights"/>.</em></p><p>Space-separated list of Authorization rule rights.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleCreateSettings AddRights(this AzureEventhubsEventhubAuthorizationRuleCreateSettings toolSettings, IEnumerable<EventhubsNamespaceAuthorizationRuleRights> rights)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RightsInternal.AddRange(rights);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureEventhubsEventhubAuthorizationRuleCreateSettings.Rights"/>.</em></p><p>Space-separated list of Authorization rule rights.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleCreateSettings ClearRights(this AzureEventhubsEventhubAuthorizationRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RightsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureEventhubsEventhubAuthorizationRuleCreateSettings.Rights"/>.</em></p><p>Space-separated list of Authorization rule rights.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleCreateSettings RemoveRights(this AzureEventhubsEventhubAuthorizationRuleCreateSettings toolSettings, params EventhubsNamespaceAuthorizationRuleRights[] rights)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<EventhubsNamespaceAuthorizationRuleRights>(rights);
            toolSettings.RightsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureEventhubsEventhubAuthorizationRuleCreateSettings.Rights"/>.</em></p><p>Space-separated list of Authorization rule rights.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleCreateSettings RemoveRights(this AzureEventhubsEventhubAuthorizationRuleCreateSettings toolSettings, IEnumerable<EventhubsNamespaceAuthorizationRuleRights> rights)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<EventhubsNamespaceAuthorizationRuleRights>(rights);
            toolSettings.RightsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubAuthorizationRuleCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleCreateSettings SetDebug(this AzureEventhubsEventhubAuthorizationRuleCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubAuthorizationRuleCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleCreateSettings ResetDebug(this AzureEventhubsEventhubAuthorizationRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubAuthorizationRuleCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleCreateSettings SetHelp(this AzureEventhubsEventhubAuthorizationRuleCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubAuthorizationRuleCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleCreateSettings ResetHelp(this AzureEventhubsEventhubAuthorizationRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubAuthorizationRuleCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleCreateSettings SetOutput(this AzureEventhubsEventhubAuthorizationRuleCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubAuthorizationRuleCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleCreateSettings ResetOutput(this AzureEventhubsEventhubAuthorizationRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubAuthorizationRuleCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleCreateSettings SetQuery(this AzureEventhubsEventhubAuthorizationRuleCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubAuthorizationRuleCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleCreateSettings ResetQuery(this AzureEventhubsEventhubAuthorizationRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubAuthorizationRuleCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleCreateSettings SetVerbose(this AzureEventhubsEventhubAuthorizationRuleCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubAuthorizationRuleCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleCreateSettings ResetVerbose(this AzureEventhubsEventhubAuthorizationRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureEventhubsEventhubAuthorizationRuleDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventhubsEventhubAuthorizationRuleDeleteSettingsExtensions
    {
        #region EventhubName
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubAuthorizationRuleDeleteSettings.EventhubName"/>.</em></p><p>Name of EventHub.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleDeleteSettings SetEventhubName(this AzureEventhubsEventhubAuthorizationRuleDeleteSettings toolSettings, string eventhubName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EventhubName = eventhubName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubAuthorizationRuleDeleteSettings.EventhubName"/>.</em></p><p>Name of EventHub.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleDeleteSettings ResetEventhubName(this AzureEventhubsEventhubAuthorizationRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EventhubName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubAuthorizationRuleDeleteSettings.Name"/>.</em></p><p>Name of EventHub AuthorizationRule.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleDeleteSettings SetName(this AzureEventhubsEventhubAuthorizationRuleDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubAuthorizationRuleDeleteSettings.Name"/>.</em></p><p>Name of EventHub AuthorizationRule.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleDeleteSettings ResetName(this AzureEventhubsEventhubAuthorizationRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region NamespaceName
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubAuthorizationRuleDeleteSettings.NamespaceName"/>.</em></p><p>Name of Namespace.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleDeleteSettings SetNamespaceName(this AzureEventhubsEventhubAuthorizationRuleDeleteSettings toolSettings, string namespaceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = namespaceName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubAuthorizationRuleDeleteSettings.NamespaceName"/>.</em></p><p>Name of Namespace.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleDeleteSettings ResetNamespaceName(this AzureEventhubsEventhubAuthorizationRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubAuthorizationRuleDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleDeleteSettings SetResourceGroup(this AzureEventhubsEventhubAuthorizationRuleDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubAuthorizationRuleDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleDeleteSettings ResetResourceGroup(this AzureEventhubsEventhubAuthorizationRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubAuthorizationRuleDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleDeleteSettings SetDebug(this AzureEventhubsEventhubAuthorizationRuleDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubAuthorizationRuleDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleDeleteSettings ResetDebug(this AzureEventhubsEventhubAuthorizationRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubAuthorizationRuleDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleDeleteSettings SetHelp(this AzureEventhubsEventhubAuthorizationRuleDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubAuthorizationRuleDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleDeleteSettings ResetHelp(this AzureEventhubsEventhubAuthorizationRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubAuthorizationRuleDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleDeleteSettings SetOutput(this AzureEventhubsEventhubAuthorizationRuleDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubAuthorizationRuleDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleDeleteSettings ResetOutput(this AzureEventhubsEventhubAuthorizationRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubAuthorizationRuleDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleDeleteSettings SetQuery(this AzureEventhubsEventhubAuthorizationRuleDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubAuthorizationRuleDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleDeleteSettings ResetQuery(this AzureEventhubsEventhubAuthorizationRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubAuthorizationRuleDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleDeleteSettings SetVerbose(this AzureEventhubsEventhubAuthorizationRuleDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubAuthorizationRuleDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleDeleteSettings ResetVerbose(this AzureEventhubsEventhubAuthorizationRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureEventhubsEventhubAuthorizationRuleListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventhubsEventhubAuthorizationRuleListSettingsExtensions
    {
        #region EventhubName
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubAuthorizationRuleListSettings.EventhubName"/>.</em></p><p>Name of EventHub.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleListSettings SetEventhubName(this AzureEventhubsEventhubAuthorizationRuleListSettings toolSettings, string eventhubName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EventhubName = eventhubName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubAuthorizationRuleListSettings.EventhubName"/>.</em></p><p>Name of EventHub.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleListSettings ResetEventhubName(this AzureEventhubsEventhubAuthorizationRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EventhubName = null;
            return toolSettings;
        }
        #endregion
        #region NamespaceName
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubAuthorizationRuleListSettings.NamespaceName"/>.</em></p><p>Name of Namespace.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleListSettings SetNamespaceName(this AzureEventhubsEventhubAuthorizationRuleListSettings toolSettings, string namespaceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = namespaceName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubAuthorizationRuleListSettings.NamespaceName"/>.</em></p><p>Name of Namespace.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleListSettings ResetNamespaceName(this AzureEventhubsEventhubAuthorizationRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubAuthorizationRuleListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleListSettings SetResourceGroup(this AzureEventhubsEventhubAuthorizationRuleListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubAuthorizationRuleListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleListSettings ResetResourceGroup(this AzureEventhubsEventhubAuthorizationRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubAuthorizationRuleListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleListSettings SetDebug(this AzureEventhubsEventhubAuthorizationRuleListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubAuthorizationRuleListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleListSettings ResetDebug(this AzureEventhubsEventhubAuthorizationRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubAuthorizationRuleListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleListSettings SetHelp(this AzureEventhubsEventhubAuthorizationRuleListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubAuthorizationRuleListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleListSettings ResetHelp(this AzureEventhubsEventhubAuthorizationRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubAuthorizationRuleListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleListSettings SetOutput(this AzureEventhubsEventhubAuthorizationRuleListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubAuthorizationRuleListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleListSettings ResetOutput(this AzureEventhubsEventhubAuthorizationRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubAuthorizationRuleListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleListSettings SetQuery(this AzureEventhubsEventhubAuthorizationRuleListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubAuthorizationRuleListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleListSettings ResetQuery(this AzureEventhubsEventhubAuthorizationRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubAuthorizationRuleListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleListSettings SetVerbose(this AzureEventhubsEventhubAuthorizationRuleListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubAuthorizationRuleListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleListSettings ResetVerbose(this AzureEventhubsEventhubAuthorizationRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureEventhubsEventhubAuthorizationRuleShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventhubsEventhubAuthorizationRuleShowSettingsExtensions
    {
        #region EventhubName
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubAuthorizationRuleShowSettings.EventhubName"/>.</em></p><p>Name of EventHub.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleShowSettings SetEventhubName(this AzureEventhubsEventhubAuthorizationRuleShowSettings toolSettings, string eventhubName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EventhubName = eventhubName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubAuthorizationRuleShowSettings.EventhubName"/>.</em></p><p>Name of EventHub.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleShowSettings ResetEventhubName(this AzureEventhubsEventhubAuthorizationRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EventhubName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubAuthorizationRuleShowSettings.Name"/>.</em></p><p>Name of EventHub AuthorizationRule.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleShowSettings SetName(this AzureEventhubsEventhubAuthorizationRuleShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubAuthorizationRuleShowSettings.Name"/>.</em></p><p>Name of EventHub AuthorizationRule.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleShowSettings ResetName(this AzureEventhubsEventhubAuthorizationRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region NamespaceName
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubAuthorizationRuleShowSettings.NamespaceName"/>.</em></p><p>Name of Namespace.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleShowSettings SetNamespaceName(this AzureEventhubsEventhubAuthorizationRuleShowSettings toolSettings, string namespaceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = namespaceName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubAuthorizationRuleShowSettings.NamespaceName"/>.</em></p><p>Name of Namespace.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleShowSettings ResetNamespaceName(this AzureEventhubsEventhubAuthorizationRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubAuthorizationRuleShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleShowSettings SetResourceGroup(this AzureEventhubsEventhubAuthorizationRuleShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubAuthorizationRuleShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleShowSettings ResetResourceGroup(this AzureEventhubsEventhubAuthorizationRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubAuthorizationRuleShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleShowSettings SetDebug(this AzureEventhubsEventhubAuthorizationRuleShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubAuthorizationRuleShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleShowSettings ResetDebug(this AzureEventhubsEventhubAuthorizationRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubAuthorizationRuleShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleShowSettings SetHelp(this AzureEventhubsEventhubAuthorizationRuleShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubAuthorizationRuleShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleShowSettings ResetHelp(this AzureEventhubsEventhubAuthorizationRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubAuthorizationRuleShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleShowSettings SetOutput(this AzureEventhubsEventhubAuthorizationRuleShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubAuthorizationRuleShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleShowSettings ResetOutput(this AzureEventhubsEventhubAuthorizationRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubAuthorizationRuleShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleShowSettings SetQuery(this AzureEventhubsEventhubAuthorizationRuleShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubAuthorizationRuleShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleShowSettings ResetQuery(this AzureEventhubsEventhubAuthorizationRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubAuthorizationRuleShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleShowSettings SetVerbose(this AzureEventhubsEventhubAuthorizationRuleShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubAuthorizationRuleShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleShowSettings ResetVerbose(this AzureEventhubsEventhubAuthorizationRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureEventhubsEventhubAuthorizationRuleUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventhubsEventhubAuthorizationRuleUpdateSettingsExtensions
    {
        #region EventhubName
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubAuthorizationRuleUpdateSettings.EventhubName"/>.</em></p><p>Name of EventHub.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleUpdateSettings SetEventhubName(this AzureEventhubsEventhubAuthorizationRuleUpdateSettings toolSettings, string eventhubName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EventhubName = eventhubName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubAuthorizationRuleUpdateSettings.EventhubName"/>.</em></p><p>Name of EventHub.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleUpdateSettings ResetEventhubName(this AzureEventhubsEventhubAuthorizationRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EventhubName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubAuthorizationRuleUpdateSettings.Name"/>.</em></p><p>Name of EventHub AuthorizationRule.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleUpdateSettings SetName(this AzureEventhubsEventhubAuthorizationRuleUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubAuthorizationRuleUpdateSettings.Name"/>.</em></p><p>Name of EventHub AuthorizationRule.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleUpdateSettings ResetName(this AzureEventhubsEventhubAuthorizationRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region NamespaceName
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubAuthorizationRuleUpdateSettings.NamespaceName"/>.</em></p><p>Name of Namespace.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleUpdateSettings SetNamespaceName(this AzureEventhubsEventhubAuthorizationRuleUpdateSettings toolSettings, string namespaceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = namespaceName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubAuthorizationRuleUpdateSettings.NamespaceName"/>.</em></p><p>Name of Namespace.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleUpdateSettings ResetNamespaceName(this AzureEventhubsEventhubAuthorizationRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubAuthorizationRuleUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleUpdateSettings SetResourceGroup(this AzureEventhubsEventhubAuthorizationRuleUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubAuthorizationRuleUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleUpdateSettings ResetResourceGroup(this AzureEventhubsEventhubAuthorizationRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Rights
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubAuthorizationRuleUpdateSettings.Rights"/> to a new list.</em></p><p>Space-separated list of Authorization rule rights.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleUpdateSettings SetRights(this AzureEventhubsEventhubAuthorizationRuleUpdateSettings toolSettings, params EventhubsNamespaceAuthorizationRuleRights[] rights)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RightsInternal = rights.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubAuthorizationRuleUpdateSettings.Rights"/> to a new list.</em></p><p>Space-separated list of Authorization rule rights.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleUpdateSettings SetRights(this AzureEventhubsEventhubAuthorizationRuleUpdateSettings toolSettings, IEnumerable<EventhubsNamespaceAuthorizationRuleRights> rights)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RightsInternal = rights.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureEventhubsEventhubAuthorizationRuleUpdateSettings.Rights"/>.</em></p><p>Space-separated list of Authorization rule rights.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleUpdateSettings AddRights(this AzureEventhubsEventhubAuthorizationRuleUpdateSettings toolSettings, params EventhubsNamespaceAuthorizationRuleRights[] rights)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RightsInternal.AddRange(rights);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureEventhubsEventhubAuthorizationRuleUpdateSettings.Rights"/>.</em></p><p>Space-separated list of Authorization rule rights.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleUpdateSettings AddRights(this AzureEventhubsEventhubAuthorizationRuleUpdateSettings toolSettings, IEnumerable<EventhubsNamespaceAuthorizationRuleRights> rights)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RightsInternal.AddRange(rights);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureEventhubsEventhubAuthorizationRuleUpdateSettings.Rights"/>.</em></p><p>Space-separated list of Authorization rule rights.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleUpdateSettings ClearRights(this AzureEventhubsEventhubAuthorizationRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RightsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureEventhubsEventhubAuthorizationRuleUpdateSettings.Rights"/>.</em></p><p>Space-separated list of Authorization rule rights.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleUpdateSettings RemoveRights(this AzureEventhubsEventhubAuthorizationRuleUpdateSettings toolSettings, params EventhubsNamespaceAuthorizationRuleRights[] rights)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<EventhubsNamespaceAuthorizationRuleRights>(rights);
            toolSettings.RightsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureEventhubsEventhubAuthorizationRuleUpdateSettings.Rights"/>.</em></p><p>Space-separated list of Authorization rule rights.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleUpdateSettings RemoveRights(this AzureEventhubsEventhubAuthorizationRuleUpdateSettings toolSettings, IEnumerable<EventhubsNamespaceAuthorizationRuleRights> rights)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<EventhubsNamespaceAuthorizationRuleRights>(rights);
            toolSettings.RightsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubAuthorizationRuleUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleUpdateSettings SetAdd(this AzureEventhubsEventhubAuthorizationRuleUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubAuthorizationRuleUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleUpdateSettings ResetAdd(this AzureEventhubsEventhubAuthorizationRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region ForceString
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubAuthorizationRuleUpdateSettings.ForceString"/>.</em></p><p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleUpdateSettings SetForceString(this AzureEventhubsEventhubAuthorizationRuleUpdateSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubAuthorizationRuleUpdateSettings.ForceString"/>.</em></p><p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleUpdateSettings ResetForceString(this AzureEventhubsEventhubAuthorizationRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubAuthorizationRuleUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleUpdateSettings SetRemove(this AzureEventhubsEventhubAuthorizationRuleUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubAuthorizationRuleUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleUpdateSettings ResetRemove(this AzureEventhubsEventhubAuthorizationRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubAuthorizationRuleUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleUpdateSettings SetSet(this AzureEventhubsEventhubAuthorizationRuleUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubAuthorizationRuleUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleUpdateSettings ResetSet(this AzureEventhubsEventhubAuthorizationRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubAuthorizationRuleUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleUpdateSettings SetDebug(this AzureEventhubsEventhubAuthorizationRuleUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubAuthorizationRuleUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleUpdateSettings ResetDebug(this AzureEventhubsEventhubAuthorizationRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubAuthorizationRuleUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleUpdateSettings SetHelp(this AzureEventhubsEventhubAuthorizationRuleUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubAuthorizationRuleUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleUpdateSettings ResetHelp(this AzureEventhubsEventhubAuthorizationRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubAuthorizationRuleUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleUpdateSettings SetOutput(this AzureEventhubsEventhubAuthorizationRuleUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubAuthorizationRuleUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleUpdateSettings ResetOutput(this AzureEventhubsEventhubAuthorizationRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubAuthorizationRuleUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleUpdateSettings SetQuery(this AzureEventhubsEventhubAuthorizationRuleUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubAuthorizationRuleUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleUpdateSettings ResetQuery(this AzureEventhubsEventhubAuthorizationRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubAuthorizationRuleUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleUpdateSettings SetVerbose(this AzureEventhubsEventhubAuthorizationRuleUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubAuthorizationRuleUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleUpdateSettings ResetVerbose(this AzureEventhubsEventhubAuthorizationRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureEventhubsNamespaceAuthorizationRuleKeysListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventhubsNamespaceAuthorizationRuleKeysListSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceAuthorizationRuleKeysListSettings.Name"/>.</em></p><p>Name of Namespace AuthorizationRule.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleKeysListSettings SetName(this AzureEventhubsNamespaceAuthorizationRuleKeysListSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceAuthorizationRuleKeysListSettings.Name"/>.</em></p><p>Name of Namespace AuthorizationRule.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleKeysListSettings ResetName(this AzureEventhubsNamespaceAuthorizationRuleKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region NamespaceName
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceAuthorizationRuleKeysListSettings.NamespaceName"/>.</em></p><p>Name of Namespace.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleKeysListSettings SetNamespaceName(this AzureEventhubsNamespaceAuthorizationRuleKeysListSettings toolSettings, string namespaceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = namespaceName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceAuthorizationRuleKeysListSettings.NamespaceName"/>.</em></p><p>Name of Namespace.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleKeysListSettings ResetNamespaceName(this AzureEventhubsNamespaceAuthorizationRuleKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceAuthorizationRuleKeysListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleKeysListSettings SetResourceGroup(this AzureEventhubsNamespaceAuthorizationRuleKeysListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceAuthorizationRuleKeysListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleKeysListSettings ResetResourceGroup(this AzureEventhubsNamespaceAuthorizationRuleKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceAuthorizationRuleKeysListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleKeysListSettings SetDebug(this AzureEventhubsNamespaceAuthorizationRuleKeysListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceAuthorizationRuleKeysListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleKeysListSettings ResetDebug(this AzureEventhubsNamespaceAuthorizationRuleKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceAuthorizationRuleKeysListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleKeysListSettings SetHelp(this AzureEventhubsNamespaceAuthorizationRuleKeysListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceAuthorizationRuleKeysListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleKeysListSettings ResetHelp(this AzureEventhubsNamespaceAuthorizationRuleKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceAuthorizationRuleKeysListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleKeysListSettings SetOutput(this AzureEventhubsNamespaceAuthorizationRuleKeysListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceAuthorizationRuleKeysListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleKeysListSettings ResetOutput(this AzureEventhubsNamespaceAuthorizationRuleKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceAuthorizationRuleKeysListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleKeysListSettings SetQuery(this AzureEventhubsNamespaceAuthorizationRuleKeysListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceAuthorizationRuleKeysListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleKeysListSettings ResetQuery(this AzureEventhubsNamespaceAuthorizationRuleKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceAuthorizationRuleKeysListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleKeysListSettings SetVerbose(this AzureEventhubsNamespaceAuthorizationRuleKeysListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceAuthorizationRuleKeysListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleKeysListSettings ResetVerbose(this AzureEventhubsNamespaceAuthorizationRuleKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureEventhubsNamespaceAuthorizationRuleKeysRenewSettingsExtensions
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventhubsNamespaceAuthorizationRuleKeysRenewSettingsExtensions
    {
        #region Key
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceAuthorizationRuleKeysRenewSettings.Key"/>.</em></p><p>Specifies Primary or Secondary key needs to be reset.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleKeysRenewSettings SetKey(this AzureEventhubsNamespaceAuthorizationRuleKeysRenewSettings toolSettings, EventhubsNamespaceAuthorizationRuleKeysKey key)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Key = key;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceAuthorizationRuleKeysRenewSettings.Key"/>.</em></p><p>Specifies Primary or Secondary key needs to be reset.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleKeysRenewSettings ResetKey(this AzureEventhubsNamespaceAuthorizationRuleKeysRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Key = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceAuthorizationRuleKeysRenewSettings.Name"/>.</em></p><p>Name of Namespace AuthorizationRule.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleKeysRenewSettings SetName(this AzureEventhubsNamespaceAuthorizationRuleKeysRenewSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceAuthorizationRuleKeysRenewSettings.Name"/>.</em></p><p>Name of Namespace AuthorizationRule.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleKeysRenewSettings ResetName(this AzureEventhubsNamespaceAuthorizationRuleKeysRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region NamespaceName
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceAuthorizationRuleKeysRenewSettings.NamespaceName"/>.</em></p><p>Name of Namespace.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleKeysRenewSettings SetNamespaceName(this AzureEventhubsNamespaceAuthorizationRuleKeysRenewSettings toolSettings, string namespaceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = namespaceName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceAuthorizationRuleKeysRenewSettings.NamespaceName"/>.</em></p><p>Name of Namespace.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleKeysRenewSettings ResetNamespaceName(this AzureEventhubsNamespaceAuthorizationRuleKeysRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceAuthorizationRuleKeysRenewSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleKeysRenewSettings SetResourceGroup(this AzureEventhubsNamespaceAuthorizationRuleKeysRenewSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceAuthorizationRuleKeysRenewSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleKeysRenewSettings ResetResourceGroup(this AzureEventhubsNamespaceAuthorizationRuleKeysRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region KeyValue
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceAuthorizationRuleKeysRenewSettings.KeyValue"/>.</em></p><p>Optional, if the key value provided, is set for KeyType or autogenerated Key value set for keyType.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleKeysRenewSettings SetKeyValue(this AzureEventhubsNamespaceAuthorizationRuleKeysRenewSettings toolSettings, string keyValue)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyValue = keyValue;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceAuthorizationRuleKeysRenewSettings.KeyValue"/>.</em></p><p>Optional, if the key value provided, is set for KeyType or autogenerated Key value set for keyType.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleKeysRenewSettings ResetKeyValue(this AzureEventhubsNamespaceAuthorizationRuleKeysRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyValue = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceAuthorizationRuleKeysRenewSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleKeysRenewSettings SetDebug(this AzureEventhubsNamespaceAuthorizationRuleKeysRenewSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceAuthorizationRuleKeysRenewSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleKeysRenewSettings ResetDebug(this AzureEventhubsNamespaceAuthorizationRuleKeysRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceAuthorizationRuleKeysRenewSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleKeysRenewSettings SetHelp(this AzureEventhubsNamespaceAuthorizationRuleKeysRenewSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceAuthorizationRuleKeysRenewSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleKeysRenewSettings ResetHelp(this AzureEventhubsNamespaceAuthorizationRuleKeysRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceAuthorizationRuleKeysRenewSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleKeysRenewSettings SetOutput(this AzureEventhubsNamespaceAuthorizationRuleKeysRenewSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceAuthorizationRuleKeysRenewSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleKeysRenewSettings ResetOutput(this AzureEventhubsNamespaceAuthorizationRuleKeysRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceAuthorizationRuleKeysRenewSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleKeysRenewSettings SetQuery(this AzureEventhubsNamespaceAuthorizationRuleKeysRenewSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceAuthorizationRuleKeysRenewSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleKeysRenewSettings ResetQuery(this AzureEventhubsNamespaceAuthorizationRuleKeysRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureEventhubsNamespaceAuthorizationRuleKeysRenewSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleKeysRenewSettings SetVerbose(this AzureEventhubsNamespaceAuthorizationRuleKeysRenewSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsNamespaceAuthorizationRuleKeysRenewSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsNamespaceAuthorizationRuleKeysRenewSettings ResetVerbose(this AzureEventhubsNamespaceAuthorizationRuleKeysRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureEventhubsGeorecoveryAliasAuthorizationRuleKeysListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventhubsGeorecoveryAliasAuthorizationRuleKeysListSettingsExtensions
    {
        #region Alias
        /// <summary><p><em>Sets <see cref="AzureEventhubsGeorecoveryAliasAuthorizationRuleKeysListSettings.Alias"/>.</em></p><p>Name of Geo-Disaster Recovery Configuration Alias.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasAuthorizationRuleKeysListSettings SetAlias(this AzureEventhubsGeorecoveryAliasAuthorizationRuleKeysListSettings toolSettings, string alias)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Alias = alias;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsGeorecoveryAliasAuthorizationRuleKeysListSettings.Alias"/>.</em></p><p>Name of Geo-Disaster Recovery Configuration Alias.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasAuthorizationRuleKeysListSettings ResetAlias(this AzureEventhubsGeorecoveryAliasAuthorizationRuleKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Alias = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureEventhubsGeorecoveryAliasAuthorizationRuleKeysListSettings.Name"/>.</em></p><p>Name of Namespace AuthorizationRule.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasAuthorizationRuleKeysListSettings SetName(this AzureEventhubsGeorecoveryAliasAuthorizationRuleKeysListSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsGeorecoveryAliasAuthorizationRuleKeysListSettings.Name"/>.</em></p><p>Name of Namespace AuthorizationRule.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasAuthorizationRuleKeysListSettings ResetName(this AzureEventhubsGeorecoveryAliasAuthorizationRuleKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region NamespaceName
        /// <summary><p><em>Sets <see cref="AzureEventhubsGeorecoveryAliasAuthorizationRuleKeysListSettings.NamespaceName"/>.</em></p><p>Name of Namespace.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasAuthorizationRuleKeysListSettings SetNamespaceName(this AzureEventhubsGeorecoveryAliasAuthorizationRuleKeysListSettings toolSettings, string namespaceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = namespaceName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsGeorecoveryAliasAuthorizationRuleKeysListSettings.NamespaceName"/>.</em></p><p>Name of Namespace.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasAuthorizationRuleKeysListSettings ResetNamespaceName(this AzureEventhubsGeorecoveryAliasAuthorizationRuleKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureEventhubsGeorecoveryAliasAuthorizationRuleKeysListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasAuthorizationRuleKeysListSettings SetResourceGroup(this AzureEventhubsGeorecoveryAliasAuthorizationRuleKeysListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsGeorecoveryAliasAuthorizationRuleKeysListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasAuthorizationRuleKeysListSettings ResetResourceGroup(this AzureEventhubsGeorecoveryAliasAuthorizationRuleKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureEventhubsGeorecoveryAliasAuthorizationRuleKeysListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasAuthorizationRuleKeysListSettings SetDebug(this AzureEventhubsGeorecoveryAliasAuthorizationRuleKeysListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsGeorecoveryAliasAuthorizationRuleKeysListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasAuthorizationRuleKeysListSettings ResetDebug(this AzureEventhubsGeorecoveryAliasAuthorizationRuleKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureEventhubsGeorecoveryAliasAuthorizationRuleKeysListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasAuthorizationRuleKeysListSettings SetHelp(this AzureEventhubsGeorecoveryAliasAuthorizationRuleKeysListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsGeorecoveryAliasAuthorizationRuleKeysListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasAuthorizationRuleKeysListSettings ResetHelp(this AzureEventhubsGeorecoveryAliasAuthorizationRuleKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureEventhubsGeorecoveryAliasAuthorizationRuleKeysListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasAuthorizationRuleKeysListSettings SetOutput(this AzureEventhubsGeorecoveryAliasAuthorizationRuleKeysListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsGeorecoveryAliasAuthorizationRuleKeysListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasAuthorizationRuleKeysListSettings ResetOutput(this AzureEventhubsGeorecoveryAliasAuthorizationRuleKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureEventhubsGeorecoveryAliasAuthorizationRuleKeysListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasAuthorizationRuleKeysListSettings SetQuery(this AzureEventhubsGeorecoveryAliasAuthorizationRuleKeysListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsGeorecoveryAliasAuthorizationRuleKeysListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasAuthorizationRuleKeysListSettings ResetQuery(this AzureEventhubsGeorecoveryAliasAuthorizationRuleKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureEventhubsGeorecoveryAliasAuthorizationRuleKeysListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasAuthorizationRuleKeysListSettings SetVerbose(this AzureEventhubsGeorecoveryAliasAuthorizationRuleKeysListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsGeorecoveryAliasAuthorizationRuleKeysListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsGeorecoveryAliasAuthorizationRuleKeysListSettings ResetVerbose(this AzureEventhubsGeorecoveryAliasAuthorizationRuleKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureEventhubsEventhubAuthorizationRuleKeysListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventhubsEventhubAuthorizationRuleKeysListSettingsExtensions
    {
        #region EventhubName
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubAuthorizationRuleKeysListSettings.EventhubName"/>.</em></p><p>Name of EventHub.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleKeysListSettings SetEventhubName(this AzureEventhubsEventhubAuthorizationRuleKeysListSettings toolSettings, string eventhubName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EventhubName = eventhubName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubAuthorizationRuleKeysListSettings.EventhubName"/>.</em></p><p>Name of EventHub.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleKeysListSettings ResetEventhubName(this AzureEventhubsEventhubAuthorizationRuleKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EventhubName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubAuthorizationRuleKeysListSettings.Name"/>.</em></p><p>Name of EventHub AuthorizationRule.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleKeysListSettings SetName(this AzureEventhubsEventhubAuthorizationRuleKeysListSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubAuthorizationRuleKeysListSettings.Name"/>.</em></p><p>Name of EventHub AuthorizationRule.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleKeysListSettings ResetName(this AzureEventhubsEventhubAuthorizationRuleKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region NamespaceName
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubAuthorizationRuleKeysListSettings.NamespaceName"/>.</em></p><p>Name of Namespace.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleKeysListSettings SetNamespaceName(this AzureEventhubsEventhubAuthorizationRuleKeysListSettings toolSettings, string namespaceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = namespaceName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubAuthorizationRuleKeysListSettings.NamespaceName"/>.</em></p><p>Name of Namespace.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleKeysListSettings ResetNamespaceName(this AzureEventhubsEventhubAuthorizationRuleKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubAuthorizationRuleKeysListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleKeysListSettings SetResourceGroup(this AzureEventhubsEventhubAuthorizationRuleKeysListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubAuthorizationRuleKeysListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleKeysListSettings ResetResourceGroup(this AzureEventhubsEventhubAuthorizationRuleKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubAuthorizationRuleKeysListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleKeysListSettings SetDebug(this AzureEventhubsEventhubAuthorizationRuleKeysListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubAuthorizationRuleKeysListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleKeysListSettings ResetDebug(this AzureEventhubsEventhubAuthorizationRuleKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubAuthorizationRuleKeysListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleKeysListSettings SetHelp(this AzureEventhubsEventhubAuthorizationRuleKeysListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubAuthorizationRuleKeysListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleKeysListSettings ResetHelp(this AzureEventhubsEventhubAuthorizationRuleKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubAuthorizationRuleKeysListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleKeysListSettings SetOutput(this AzureEventhubsEventhubAuthorizationRuleKeysListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubAuthorizationRuleKeysListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleKeysListSettings ResetOutput(this AzureEventhubsEventhubAuthorizationRuleKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubAuthorizationRuleKeysListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleKeysListSettings SetQuery(this AzureEventhubsEventhubAuthorizationRuleKeysListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubAuthorizationRuleKeysListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleKeysListSettings ResetQuery(this AzureEventhubsEventhubAuthorizationRuleKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubAuthorizationRuleKeysListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleKeysListSettings SetVerbose(this AzureEventhubsEventhubAuthorizationRuleKeysListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubAuthorizationRuleKeysListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleKeysListSettings ResetVerbose(this AzureEventhubsEventhubAuthorizationRuleKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureEventhubsEventhubAuthorizationRuleKeysRenewSettingsExtensions
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventhubsEventhubAuthorizationRuleKeysRenewSettingsExtensions
    {
        #region EventhubName
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubAuthorizationRuleKeysRenewSettings.EventhubName"/>.</em></p><p>Name of EventHub.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleKeysRenewSettings SetEventhubName(this AzureEventhubsEventhubAuthorizationRuleKeysRenewSettings toolSettings, string eventhubName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EventhubName = eventhubName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubAuthorizationRuleKeysRenewSettings.EventhubName"/>.</em></p><p>Name of EventHub.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleKeysRenewSettings ResetEventhubName(this AzureEventhubsEventhubAuthorizationRuleKeysRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EventhubName = null;
            return toolSettings;
        }
        #endregion
        #region Key
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubAuthorizationRuleKeysRenewSettings.Key"/>.</em></p><p>Specifies Primary or Secondary key needs to be reset.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleKeysRenewSettings SetKey(this AzureEventhubsEventhubAuthorizationRuleKeysRenewSettings toolSettings, EventhubsNamespaceAuthorizationRuleKeysKey key)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Key = key;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubAuthorizationRuleKeysRenewSettings.Key"/>.</em></p><p>Specifies Primary or Secondary key needs to be reset.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleKeysRenewSettings ResetKey(this AzureEventhubsEventhubAuthorizationRuleKeysRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Key = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubAuthorizationRuleKeysRenewSettings.Name"/>.</em></p><p>Name of EventHub AuthorizationRule.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleKeysRenewSettings SetName(this AzureEventhubsEventhubAuthorizationRuleKeysRenewSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubAuthorizationRuleKeysRenewSettings.Name"/>.</em></p><p>Name of EventHub AuthorizationRule.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleKeysRenewSettings ResetName(this AzureEventhubsEventhubAuthorizationRuleKeysRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region NamespaceName
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubAuthorizationRuleKeysRenewSettings.NamespaceName"/>.</em></p><p>Name of Namespace.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleKeysRenewSettings SetNamespaceName(this AzureEventhubsEventhubAuthorizationRuleKeysRenewSettings toolSettings, string namespaceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = namespaceName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubAuthorizationRuleKeysRenewSettings.NamespaceName"/>.</em></p><p>Name of Namespace.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleKeysRenewSettings ResetNamespaceName(this AzureEventhubsEventhubAuthorizationRuleKeysRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubAuthorizationRuleKeysRenewSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleKeysRenewSettings SetResourceGroup(this AzureEventhubsEventhubAuthorizationRuleKeysRenewSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubAuthorizationRuleKeysRenewSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleKeysRenewSettings ResetResourceGroup(this AzureEventhubsEventhubAuthorizationRuleKeysRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region KeyValue
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubAuthorizationRuleKeysRenewSettings.KeyValue"/>.</em></p><p>Optional, if the key value provided, is set for KeyType or autogenerated Key value set for keyType.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleKeysRenewSettings SetKeyValue(this AzureEventhubsEventhubAuthorizationRuleKeysRenewSettings toolSettings, string keyValue)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyValue = keyValue;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubAuthorizationRuleKeysRenewSettings.KeyValue"/>.</em></p><p>Optional, if the key value provided, is set for KeyType or autogenerated Key value set for keyType.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleKeysRenewSettings ResetKeyValue(this AzureEventhubsEventhubAuthorizationRuleKeysRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyValue = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubAuthorizationRuleKeysRenewSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleKeysRenewSettings SetDebug(this AzureEventhubsEventhubAuthorizationRuleKeysRenewSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubAuthorizationRuleKeysRenewSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleKeysRenewSettings ResetDebug(this AzureEventhubsEventhubAuthorizationRuleKeysRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubAuthorizationRuleKeysRenewSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleKeysRenewSettings SetHelp(this AzureEventhubsEventhubAuthorizationRuleKeysRenewSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubAuthorizationRuleKeysRenewSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleKeysRenewSettings ResetHelp(this AzureEventhubsEventhubAuthorizationRuleKeysRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubAuthorizationRuleKeysRenewSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleKeysRenewSettings SetOutput(this AzureEventhubsEventhubAuthorizationRuleKeysRenewSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubAuthorizationRuleKeysRenewSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleKeysRenewSettings ResetOutput(this AzureEventhubsEventhubAuthorizationRuleKeysRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubAuthorizationRuleKeysRenewSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleKeysRenewSettings SetQuery(this AzureEventhubsEventhubAuthorizationRuleKeysRenewSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubAuthorizationRuleKeysRenewSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleKeysRenewSettings ResetQuery(this AzureEventhubsEventhubAuthorizationRuleKeysRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureEventhubsEventhubAuthorizationRuleKeysRenewSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleKeysRenewSettings SetVerbose(this AzureEventhubsEventhubAuthorizationRuleKeysRenewSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventhubsEventhubAuthorizationRuleKeysRenewSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventhubsEventhubAuthorizationRuleKeysRenewSettings ResetVerbose(this AzureEventhubsEventhubAuthorizationRuleKeysRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region EventhubsNamespaceSku
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class EventhubsNamespaceSku : Enumeration
    {
        public static EventhubsNamespaceSku basic = new EventhubsNamespaceSku { Value = "basic" };
        public static EventhubsNamespaceSku standard = new EventhubsNamespaceSku { Value = "standard" };
    }
    #endregion
    #region EventhubsEventhubStatus
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class EventhubsEventhubStatus : Enumeration
    {
        public static EventhubsEventhubStatus active = new EventhubsEventhubStatus { Value = "active" };
        public static EventhubsEventhubStatus disabled = new EventhubsEventhubStatus { Value = "disabled" };
        public static EventhubsEventhubStatus receivedisabled = new EventhubsEventhubStatus { Value = "receivedisabled" };
        public static EventhubsEventhubStatus senddisabled = new EventhubsEventhubStatus { Value = "senddisabled" };
    }
    #endregion
    #region EventhubsNamespaceAuthorizationRuleRights
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class EventhubsNamespaceAuthorizationRuleRights : Enumeration
    {
        public static EventhubsNamespaceAuthorizationRuleRights listen = new EventhubsNamespaceAuthorizationRuleRights { Value = "listen" };
        public static EventhubsNamespaceAuthorizationRuleRights manage = new EventhubsNamespaceAuthorizationRuleRights { Value = "manage" };
        public static EventhubsNamespaceAuthorizationRuleRights send = new EventhubsNamespaceAuthorizationRuleRights { Value = "send" };
    }
    #endregion
    #region EventhubsNamespaceAuthorizationRuleKeysKey
    /// <summary><p>Used within <see cref="AzureEventhubsTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class EventhubsNamespaceAuthorizationRuleKeysKey : Enumeration
    {
        public static EventhubsNamespaceAuthorizationRuleKeysKey primarykey = new EventhubsNamespaceAuthorizationRuleKeysKey { Value = "primarykey" };
        public static EventhubsNamespaceAuthorizationRuleKeysKey secondarykey = new EventhubsNamespaceAuthorizationRuleKeysKey { Value = "secondarykey" };
    }
    #endregion
}
