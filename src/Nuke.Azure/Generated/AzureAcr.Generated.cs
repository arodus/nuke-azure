// Copyright Matthias Koch, Sebastian Karasek 2018.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

// Generated with Nuke.CodeGeneration, Version: 0.6.2 [CommitSha: ff25463a].
// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/AzureAcr.json.

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
    public static partial class AzureAcrTasks
    {
        /// <summary><p>Path to the AzureAcr executable.</p></summary>
        public static string AzureAcrPath => ToolPathResolver.GetPathExecutable("az");
        /// <summary><p>Manage Azure Container Registries for private registries within Azure.</p></summary>
        public static IReadOnlyCollection<Output> AzureAcr(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool logOutput = true, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzureAcrPath, arguments, workingDirectory, environmentVariables, timeout, logOutput, null, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Container Registries for private registries within Azure.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acr?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAcrBuild(Configure<AzureAcrBuildSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcrBuildSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Container Registries for private registries within Azure.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acr?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAcrCheckName(Configure<AzureAcrCheckNameSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcrCheckNameSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Container Registries for private registries within Azure.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acr?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAcrCreate(Configure<AzureAcrCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcrCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Container Registries for private registries within Azure.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acr?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAcrDelete(Configure<AzureAcrDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcrDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Container Registries for private registries within Azure.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acr?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAcrImport(Configure<AzureAcrImportSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcrImportSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Container Registries for private registries within Azure.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acr?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAcrList(Configure<AzureAcrListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcrListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Container Registries for private registries within Azure.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acr?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAcrLogin(Configure<AzureAcrLoginSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcrLoginSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Container Registries for private registries within Azure.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acr?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAcrShow(Configure<AzureAcrShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcrShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Container Registries for private registries within Azure.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acr?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAcrShowUsage(Configure<AzureAcrShowUsageSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcrShowUsageSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Container Registries for private registries within Azure.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acr?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAcrUpdate(Configure<AzureAcrUpdateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcrUpdateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Container Registries for private registries within Azure.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acr?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAcrBuildTaskCreate(Configure<AzureAcrBuildTaskCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcrBuildTaskCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Container Registries for private registries within Azure.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acr?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAcrBuildTaskDelete(Configure<AzureAcrBuildTaskDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcrBuildTaskDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Container Registries for private registries within Azure.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acr?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAcrBuildTaskList(Configure<AzureAcrBuildTaskListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcrBuildTaskListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Container Registries for private registries within Azure.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acr?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAcrBuildTaskListBuilds(Configure<AzureAcrBuildTaskListBuildsSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcrBuildTaskListBuildsSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Container Registries for private registries within Azure.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acr?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAcrBuildTaskLogs(Configure<AzureAcrBuildTaskLogsSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcrBuildTaskLogsSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Container Registries for private registries within Azure.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acr?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAcrBuildTaskRun(Configure<AzureAcrBuildTaskRunSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcrBuildTaskRunSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Container Registries for private registries within Azure.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acr?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAcrBuildTaskShow(Configure<AzureAcrBuildTaskShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcrBuildTaskShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Container Registries for private registries within Azure.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acr?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAcrBuildTaskShowBuild(Configure<AzureAcrBuildTaskShowBuildSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcrBuildTaskShowBuildSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Container Registries for private registries within Azure.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acr?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAcrBuildTaskUpdate(Configure<AzureAcrBuildTaskUpdateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcrBuildTaskUpdateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Container Registries for private registries within Azure.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acr?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAcrBuildTaskUpdateBuild(Configure<AzureAcrBuildTaskUpdateBuildSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcrBuildTaskUpdateBuildSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Container Registries for private registries within Azure.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acr?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAcrConfig(Configure<AzureAcrConfigSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcrConfigSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Container Registries for private registries within Azure.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acr?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAcrCredentialRenew(Configure<AzureAcrCredentialRenewSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcrCredentialRenewSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Container Registries for private registries within Azure.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acr?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAcrCredentialShow(Configure<AzureAcrCredentialShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcrCredentialShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Container Registries for private registries within Azure.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acr?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAcrReplicationCreate(Configure<AzureAcrReplicationCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcrReplicationCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Container Registries for private registries within Azure.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acr?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAcrReplicationDelete(Configure<AzureAcrReplicationDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcrReplicationDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Container Registries for private registries within Azure.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acr?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAcrReplicationList(Configure<AzureAcrReplicationListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcrReplicationListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Container Registries for private registries within Azure.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acr?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAcrReplicationShow(Configure<AzureAcrReplicationShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcrReplicationShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Container Registries for private registries within Azure.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acr?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAcrReplicationUpdate(Configure<AzureAcrReplicationUpdateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcrReplicationUpdateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Container Registries for private registries within Azure.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acr?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAcrRepositoryDelete(Configure<AzureAcrRepositoryDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcrRepositoryDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Container Registries for private registries within Azure.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acr?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAcrRepositoryList(Configure<AzureAcrRepositoryListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcrRepositoryListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Container Registries for private registries within Azure.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acr?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAcrRepositoryShow(Configure<AzureAcrRepositoryShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcrRepositoryShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Container Registries for private registries within Azure.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acr?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAcrRepositoryShowManifests(Configure<AzureAcrRepositoryShowManifestsSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcrRepositoryShowManifestsSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Container Registries for private registries within Azure.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acr?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAcrRepositoryShowTags(Configure<AzureAcrRepositoryShowTagsSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcrRepositoryShowTagsSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Container Registries for private registries within Azure.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acr?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAcrRepositoryUntag(Configure<AzureAcrRepositoryUntagSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcrRepositoryUntagSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Container Registries for private registries within Azure.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acr?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAcrRepositoryUpdate(Configure<AzureAcrRepositoryUpdateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcrRepositoryUpdateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Container Registries for private registries within Azure.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acr?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAcrWebhookCreate(Configure<AzureAcrWebhookCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcrWebhookCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Container Registries for private registries within Azure.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acr?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAcrWebhookDelete(Configure<AzureAcrWebhookDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcrWebhookDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Container Registries for private registries within Azure.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acr?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAcrWebhookGetConfig(Configure<AzureAcrWebhookGetConfigSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcrWebhookGetConfigSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Container Registries for private registries within Azure.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acr?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAcrWebhookList(Configure<AzureAcrWebhookListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcrWebhookListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Container Registries for private registries within Azure.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acr?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAcrWebhookListEvents(Configure<AzureAcrWebhookListEventsSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcrWebhookListEventsSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Container Registries for private registries within Azure.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acr?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAcrWebhookPing(Configure<AzureAcrWebhookPingSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcrWebhookPingSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Container Registries for private registries within Azure.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acr?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAcrWebhookShow(Configure<AzureAcrWebhookShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcrWebhookShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Container Registries for private registries within Azure.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acr?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAcrWebhookUpdate(Configure<AzureAcrWebhookUpdateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcrWebhookUpdateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Container Registries for private registries within Azure.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acr?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAcrConfigContentTrustShow(Configure<AzureAcrConfigContentTrustShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcrConfigContentTrustShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Container Registries for private registries within Azure.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acr?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAcrConfigContentTrustUpdate(Configure<AzureAcrConfigContentTrustUpdateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcrConfigContentTrustUpdateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
    }
    #region AzureAcrBuildSettings
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcrBuildSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcr executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcrTasks.AzureAcrPath;
        /// <summary><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        public virtual string Registry { get; internal set; }
        /// <summary><p>Build argument in 'name[=value]' format.</p></summary>
        public virtual string BuildArg { get; internal set; }
        /// <summary><p>The relative path of the the docker file to the source code root folder.</p></summary>
        public virtual string File { get; internal set; }
        /// <summary><p>The name of the image. May include a tag in the format 'name:tag'.</p></summary>
        public virtual string Image { get; internal set; }
        /// <summary><p>Do not show logs after successfully queuing the build.</p></summary>
        public virtual bool? NoLogs { get; internal set; }
        /// <summary><p>Indicates whether the image built should be pushed to the registry.</p></summary>
        public virtual bool? NoPush { get; internal set; }
        /// <summary><p>The operating system type required for the build.</p></summary>
        public virtual AcrOs Os { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Secret build argument in 'name[=value]' format.</p></summary>
        public virtual string SecretBuildArg { get; internal set; }
        /// <summary><p>The build timeout in seconds.</p></summary>
        public virtual string Timeout { get; internal set; }
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
              .Add("acr build")
              .Add("--registry {value}", Registry)
              .Add("--build-arg {value}", BuildArg)
              .Add("--file {value}", File)
              .Add("--image {value}", Image)
              .Add("--no-logs", NoLogs)
              .Add("--no-push", NoPush)
              .Add("--os {value}", Os)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--secret-build-arg {value}", SecretBuildArg, secret: true)
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
    #region AzureAcrCheckNameSettings
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcrCheckNameSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcr executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcrTasks.AzureAcrPath;
        /// <summary><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
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
              .Add("acr check-name")
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
    #region AzureAcrCreateSettings
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcrCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcr executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcrTasks.AzureAcrPath;
        /// <summary><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The SKU of the container registry.</p></summary>
        public virtual AcrSku Sku { get; internal set; }
        /// <summary><p>Indicates whether the admin user is enabled.</p></summary>
        public virtual bool? AdminEnabled { get; internal set; }
        /// <summary><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        public virtual string Location { get; internal set; }
        /// <summary><p>Provide the name of an existing storage account if you're recreating a container registry over a previous registry created storage account. Only applicable to Classic SKU.</p></summary>
        public virtual string StorageAccountName { get; internal set; }
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
              .Add("acr create")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--sku {value}", Sku)
              .Add("--admin-enabled", AdminEnabled)
              .Add("--location {value}", Location)
              .Add("--storage-account-name {value}", StorageAccountName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureAcrDeleteSettings
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcrDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcr executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcrTasks.AzureAcrPath;
        /// <summary><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
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
              .Add("acr delete")
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
    #region AzureAcrImportSettings
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcrImportSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcr executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcrTasks.AzureAcrPath;
        /// <summary><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>The source identifier in the format '[registry.azurecr.io/]repository[:tag]' or '[registry.azurecr.io/]repository@digest'.</p></summary>
        public virtual string Source { get; internal set; }
        /// <summary><p>Overwrite the existing tag of the image to be imported.</p></summary>
        public virtual string Force { get; internal set; }
        /// <summary><p>The name of the image. May include a tag in the format 'name:tag'.</p></summary>
        public virtual string Image { get; internal set; }
        /// <summary><p>The source container registry can be name, login server or resource ID of the source registry.</p></summary>
        public virtual string Registry { get; internal set; }
        /// <summary><p>The repository name to do a manifest-only copy for images.</p></summary>
        public virtual string Repository { get; internal set; }
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
              .Add("acr import")
              .Add("--name {value}", Name)
              .Add("--source {value}", Source)
              .Add("--force {value}", Force)
              .Add("--image {value}", Image)
              .Add("--registry {value}", Registry)
              .Add("--repository {value}", Repository)
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
    #region AzureAcrListSettings
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcrListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcr executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcrTasks.AzureAcrPath;
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
              .Add("acr list")
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
    #region AzureAcrLoginSettings
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcrLoginSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcr executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcrTasks.AzureAcrPath;
        /// <summary><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>The password used to log into a container registry.</p></summary>
        public virtual string Password { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The username used to log into a container registry.</p></summary>
        public virtual string Username { get; internal set; }
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
              .Add("acr login")
              .Add("--name {value}", Name)
              .Add("--password {value}", Password, secret: true)
              .Add("--resource-group {value}", ResourceGroup)
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
    #region AzureAcrShowSettings
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcrShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcr executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcrTasks.AzureAcrPath;
        /// <summary><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
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
              .Add("acr show")
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
    #region AzureAcrShowUsageSettings
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcrShowUsageSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcr executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcrTasks.AzureAcrPath;
        /// <summary><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
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
              .Add("acr show-usage")
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
    #region AzureAcrUpdateSettings
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcrUpdateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcr executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcrTasks.AzureAcrPath;
        /// <summary><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Indicates whether the admin user is enabled.</p></summary>
        public virtual bool? AdminEnabled { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The SKU of the container registry.</p></summary>
        public virtual AcrSku Sku { get; internal set; }
        /// <summary><p>Provide the name of an existing storage account if you're recreating a container registry over a previous registry created storage account. Only applicable to Classic SKU.</p></summary>
        public virtual string StorageAccountName { get; internal set; }
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
              .Add("acr update")
              .Add("--name {value}", Name)
              .Add("--admin-enabled", AdminEnabled)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--sku {value}", Sku)
              .Add("--storage-account-name {value}", StorageAccountName)
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
    #region AzureAcrBuildTaskCreateSettings
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcrBuildTaskCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcr executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcrTasks.AzureAcrPath;
        /// <summary><p>The full URL to the source code respository.</p></summary>
        public virtual string Context { get; internal set; }
        /// <summary><p>The access token used to access the source control provider.</p></summary>
        public virtual string GitAccessToken { get; internal set; }
        /// <summary><p>The name of the image. May include a tag in the format 'name:tag'.</p></summary>
        public virtual string Image { get; internal set; }
        /// <summary><p>The name of the build task.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        public virtual string Registry { get; internal set; }
        /// <summary><p>The alternative name for build task. Default to the build task name.</p></summary>
        public virtual string Alias { get; internal set; }
        /// <summary><p>The type of the auto trigger for base image dependency updates.</p></summary>
        public virtual AcrBuildTaskBaseImageTrigger BaseImageTrigger { get; internal set; }
        /// <summary><p>The source control branch name.</p></summary>
        public virtual string Branch { get; internal set; }
        /// <summary><p>Build argument in 'name[=value]' format.</p></summary>
        public virtual string BuildArg { get; internal set; }
        /// <summary><p>Indicates whether the source control commit trigger is enabled.</p></summary>
        public virtual bool? CommitTriggerEnabled { get; internal set; }
        /// <summary><p>The CPU configuration in terms of number of cores required for the build.</p></summary>
        public virtual string Cpu { get; internal set; }
        /// <summary><p>The relative path of the the docker file to the source code root folder.</p></summary>
        public virtual string File { get; internal set; }
        /// <summary><p>Indicates whether the image cache is enabled.</p></summary>
        public virtual bool? NoCache { get; internal set; }
        /// <summary><p>Indicates whether the image built should be pushed to the registry.</p></summary>
        public virtual bool? NoPush { get; internal set; }
        /// <summary><p>The operating system type required for the build.</p></summary>
        public virtual AcrOs Os { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Secret build argument in 'name[=value]' format.</p></summary>
        public virtual string SecretBuildArg { get; internal set; }
        /// <summary><p>The current status of build task.</p></summary>
        public virtual AcrBuildTaskStatus Status { get; internal set; }
        /// <summary><p>The build timeout in seconds.</p></summary>
        public virtual string Timeout { get; internal set; }
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
              .Add("acr build-task create")
              .Add("--context {value}", Context)
              .Add("--git-access-token {value}", GitAccessToken)
              .Add("--image {value}", Image)
              .Add("--name {value}", Name)
              .Add("--registry {value}", Registry)
              .Add("--alias {value}", Alias)
              .Add("--base-image-trigger {value}", BaseImageTrigger)
              .Add("--branch {value}", Branch)
              .Add("--build-arg {value}", BuildArg)
              .Add("--commit-trigger-enabled", CommitTriggerEnabled)
              .Add("--cpu {value}", Cpu)
              .Add("--file {value}", File)
              .Add("--no-cache", NoCache)
              .Add("--no-push", NoPush)
              .Add("--os {value}", Os)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--secret-build-arg {value}", SecretBuildArg, secret: true)
              .Add("--status {value}", Status)
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
    #region AzureAcrBuildTaskDeleteSettings
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcrBuildTaskDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcr executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcrTasks.AzureAcrPath;
        /// <summary><p>The name of the build task.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        public virtual string Registry { get; internal set; }
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
              .Add("acr build-task delete")
              .Add("--name {value}", Name)
              .Add("--registry {value}", Registry)
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
    #region AzureAcrBuildTaskListSettings
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcrBuildTaskListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcr executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcrTasks.AzureAcrPath;
        /// <summary><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        public virtual string Registry { get; internal set; }
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
              .Add("acr build-task list")
              .Add("--registry {value}", Registry)
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
    #region AzureAcrBuildTaskListBuildsSettings
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcrBuildTaskListBuildsSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcr executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcrTasks.AzureAcrPath;
        /// <summary><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        public virtual string Registry { get; internal set; }
        /// <summary><p>The current status of build.</p></summary>
        public virtual AcrBuildTaskListBuildsBuildStatus BuildStatus { get; internal set; }
        /// <summary><p>The name of the image. May include a tag in the format 'name:tag' or digest in the format 'name@digest'.</p></summary>
        public virtual string Image { get; internal set; }
        /// <summary><p>The name of the build task.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Limit the number of latest builds in the results.</p></summary>
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
              .Add("acr build-task list-builds")
              .Add("--registry {value}", Registry)
              .Add("--build-status {value}", BuildStatus)
              .Add("--image {value}", Image)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
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
    #region AzureAcrBuildTaskLogsSettings
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcrBuildTaskLogsSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcr executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcrTasks.AzureAcrPath;
        /// <summary><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        public virtual string Registry { get; internal set; }
        /// <summary><p>The unique build identifier.</p></summary>
        public virtual string BuildId { get; internal set; }
        /// <summary><p>The name of the image. May include a tag in the format 'name:tag' or digest in the format 'name@digest'.</p></summary>
        public virtual string Image { get; internal set; }
        /// <summary><p>The name of the build task.</p></summary>
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
              .Add("acr build-task logs")
              .Add("--registry {value}", Registry)
              .Add("--build-id {value}", BuildId)
              .Add("--image {value}", Image)
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
    #region AzureAcrBuildTaskRunSettings
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcrBuildTaskRunSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcr executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcrTasks.AzureAcrPath;
        /// <summary><p>The name of the build task.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        public virtual string Registry { get; internal set; }
        /// <summary><p>Do not show logs after successfully queuing the build.</p></summary>
        public virtual bool? NoLogs { get; internal set; }
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
              .Add("acr build-task run")
              .Add("--name {value}", Name)
              .Add("--registry {value}", Registry)
              .Add("--no-logs", NoLogs)
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
    #region AzureAcrBuildTaskShowSettings
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcrBuildTaskShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcr executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcrTasks.AzureAcrPath;
        /// <summary><p>The name of the build task.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        public virtual string Registry { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Indicates whether the secure properties of a build task should be returned.</p></summary>
        public virtual string WithSecureProperties { get; internal set; }
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
              .Add("acr build-task show")
              .Add("--name {value}", Name)
              .Add("--registry {value}", Registry)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--with-secure-properties {value}", WithSecureProperties)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureAcrBuildTaskShowBuildSettings
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcrBuildTaskShowBuildSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcr executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcrTasks.AzureAcrPath;
        /// <summary><p>The unique build identifier.</p></summary>
        public virtual string BuildId { get; internal set; }
        /// <summary><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        public virtual string Registry { get; internal set; }
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
              .Add("acr build-task show-build")
              .Add("--build-id {value}", BuildId)
              .Add("--registry {value}", Registry)
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
    #region AzureAcrBuildTaskUpdateSettings
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcrBuildTaskUpdateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcr executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcrTasks.AzureAcrPath;
        /// <summary><p>The name of the build task.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        public virtual string Registry { get; internal set; }
        /// <summary><p>The alternative name for build task. Default to the build task name.</p></summary>
        public virtual string Alias { get; internal set; }
        /// <summary><p>The type of the auto trigger for base image dependency updates.</p></summary>
        public virtual AcrBuildTaskBaseImageTrigger BaseImageTrigger { get; internal set; }
        /// <summary><p>The source control branch name.</p></summary>
        public virtual string Branch { get; internal set; }
        /// <summary><p>Build argument in 'name[=value]' format.</p></summary>
        public virtual string BuildArg { get; internal set; }
        /// <summary><p>Indicates whether the source control commit trigger is enabled.</p></summary>
        public virtual bool? CommitTriggerEnabled { get; internal set; }
        /// <summary><p>The full URL to the source code respository.</p></summary>
        public virtual string Context { get; internal set; }
        /// <summary><p>The CPU configuration in terms of number of cores required for the build.</p></summary>
        public virtual string Cpu { get; internal set; }
        /// <summary><p>The relative path of the the docker file to the source code root folder.</p></summary>
        public virtual string File { get; internal set; }
        /// <summary><p>The access token used to access the source control provider.</p></summary>
        public virtual string GitAccessToken { get; internal set; }
        /// <summary><p>The name of the image. May include a tag in the format 'name:tag'.</p></summary>
        public virtual string Image { get; internal set; }
        /// <summary><p>Indicates whether the image cache is enabled.</p></summary>
        public virtual bool? NoCache { get; internal set; }
        /// <summary><p>Indicates whether the image built should be pushed to the registry.</p></summary>
        public virtual bool? NoPush { get; internal set; }
        /// <summary><p>The operating system type required for the build.</p></summary>
        public virtual AcrOs Os { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Secret build argument in 'name[=value]' format.</p></summary>
        public virtual string SecretBuildArg { get; internal set; }
        /// <summary><p>The current status of build task.</p></summary>
        public virtual AcrBuildTaskStatus Status { get; internal set; }
        /// <summary><p>The build timeout in seconds.</p></summary>
        public virtual string Timeout { get; internal set; }
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
              .Add("acr build-task update")
              .Add("--name {value}", Name)
              .Add("--registry {value}", Registry)
              .Add("--alias {value}", Alias)
              .Add("--base-image-trigger {value}", BaseImageTrigger)
              .Add("--branch {value}", Branch)
              .Add("--build-arg {value}", BuildArg)
              .Add("--commit-trigger-enabled", CommitTriggerEnabled)
              .Add("--context {value}", Context)
              .Add("--cpu {value}", Cpu)
              .Add("--file {value}", File)
              .Add("--git-access-token {value}", GitAccessToken)
              .Add("--image {value}", Image)
              .Add("--no-cache", NoCache)
              .Add("--no-push", NoPush)
              .Add("--os {value}", Os)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--secret-build-arg {value}", SecretBuildArg, secret: true)
              .Add("--status {value}", Status)
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
    #region AzureAcrBuildTaskUpdateBuildSettings
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcrBuildTaskUpdateBuildSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcr executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcrTasks.AzureAcrPath;
        /// <summary><p>The unique build identifier.</p></summary>
        public virtual string BuildId { get; internal set; }
        /// <summary><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        public virtual string Registry { get; internal set; }
        /// <summary><p>Indicates whether the build should be archived.</p></summary>
        public virtual bool? NoArchive { get; internal set; }
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
              .Add("acr build-task update-build")
              .Add("--build-id {value}", BuildId)
              .Add("--registry {value}", Registry)
              .Add("--no-archive", NoArchive)
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
    #region AzureAcrConfigSettings
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcrConfigSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcr executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcrTasks.AzureAcrPath;
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
              .Add("acr config")
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureAcrCredentialRenewSettings
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcrCredentialRenewSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcr executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcrTasks.AzureAcrPath;
        /// <summary><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>The name of password to regenerate.</p></summary>
        public virtual AcrCredentialRenewPasswordName PasswordName { get; internal set; }
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
              .Add("acr credential renew")
              .Add("--name {value}", Name)
              .Add("--password-name {value}", PasswordName, secret: true)
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
    #region AzureAcrCredentialShowSettings
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcrCredentialShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcr executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcrTasks.AzureAcrPath;
        /// <summary><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
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
              .Add("acr credential show")
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
    #region AzureAcrReplicationCreateSettings
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcrReplicationCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcr executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcrTasks.AzureAcrPath;
        /// <summary><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        public virtual string Location { get; internal set; }
        /// <summary><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        public virtual string Registry { get; internal set; }
        /// <summary><p>The name of the replication. Default to the location name.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
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
              .Add("acr replication create")
              .Add("--location {value}", Location)
              .Add("--registry {value}", Registry)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
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
    #region AzureAcrReplicationDeleteSettings
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcrReplicationDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcr executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcrTasks.AzureAcrPath;
        /// <summary><p>The name of the replication.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        public virtual string Registry { get; internal set; }
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
              .Add("acr replication delete")
              .Add("--name {value}", Name)
              .Add("--registry {value}", Registry)
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
    #region AzureAcrReplicationListSettings
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcrReplicationListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcr executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcrTasks.AzureAcrPath;
        /// <summary><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        public virtual string Registry { get; internal set; }
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
              .Add("acr replication list")
              .Add("--registry {value}", Registry)
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
    #region AzureAcrReplicationShowSettings
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcrReplicationShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcr executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcrTasks.AzureAcrPath;
        /// <summary><p>The name of the replication.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        public virtual string Registry { get; internal set; }
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
              .Add("acr replication show")
              .Add("--name {value}", Name)
              .Add("--registry {value}", Registry)
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
    #region AzureAcrReplicationUpdateSettings
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcrReplicationUpdateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcr executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcrTasks.AzureAcrPath;
        /// <summary><p>The name of the replication.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        public virtual string Registry { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
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
              .Add("acr replication update")
              .Add("--name {value}", Name)
              .Add("--registry {value}", Registry)
              .Add("--resource-group {value}", ResourceGroup)
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
    #region AzureAcrRepositoryDeleteSettings
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcrRepositoryDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcr executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcrTasks.AzureAcrPath;
        /// <summary><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>The name of the image. May include a tag in the format 'name:tag' or digest in the format 'name@digest'.</p></summary>
        public virtual string Image { get; internal set; }
        /// <summary><p>The password used to log into a container registry.</p></summary>
        public virtual string Password { get; internal set; }
        /// <summary><p>The name of the repository.</p></summary>
        public virtual string Repository { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The username used to log into a container registry.</p></summary>
        public virtual string Username { get; internal set; }
        /// <summary><p>Do not prompt for confirmation.</p></summary>
        public virtual string Yes { get; internal set; }
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
              .Add("acr repository delete")
              .Add("--name {value}", Name)
              .Add("--image {value}", Image)
              .Add("--password {value}", Password, secret: true)
              .Add("--repository {value}", Repository)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--username {value}", Username)
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
    #region AzureAcrRepositoryListSettings
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcrRepositoryListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcr executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcrTasks.AzureAcrPath;
        /// <summary><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>The password used to log into a container registry.</p></summary>
        public virtual string Password { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Limit the number of items in the results.</p></summary>
        public virtual string Top { get; internal set; }
        /// <summary><p>The username used to log into a container registry.</p></summary>
        public virtual string Username { get; internal set; }
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
              .Add("acr repository list")
              .Add("--name {value}", Name)
              .Add("--password {value}", Password, secret: true)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--top {value}", Top)
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
    #region AzureAcrRepositoryShowSettings
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcrRepositoryShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcr executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcrTasks.AzureAcrPath;
        /// <summary><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>The name of the image. May include a tag in the format 'name:tag' or digest in the format 'name@digest'.</p></summary>
        public virtual string Image { get; internal set; }
        /// <summary><p>The password used to log into a container registry.</p></summary>
        public virtual string Password { get; internal set; }
        /// <summary><p>The name of the repository.</p></summary>
        public virtual string Repository { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The username used to log into a container registry.</p></summary>
        public virtual string Username { get; internal set; }
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
              .Add("acr repository show")
              .Add("--name {value}", Name)
              .Add("--image {value}", Image)
              .Add("--password {value}", Password, secret: true)
              .Add("--repository {value}", Repository)
              .Add("--resource-group {value}", ResourceGroup)
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
    #region AzureAcrRepositoryShowManifestsSettings
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcrRepositoryShowManifestsSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcr executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcrTasks.AzureAcrPath;
        /// <summary><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>The name of the repository.</p></summary>
        public virtual string Repository { get; internal set; }
        /// <summary><p>Show detailed information.</p></summary>
        public virtual string Detail { get; internal set; }
        /// <summary><p>Order the items in the results. Default to alphabetical order of names.</p></summary>
        public virtual AcrRepositoryOrderby Orderby { get; internal set; }
        /// <summary><p>The password used to log into a container registry.</p></summary>
        public virtual string Password { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Limit the number of items in the results.</p></summary>
        public virtual string Top { get; internal set; }
        /// <summary><p>The username used to log into a container registry.</p></summary>
        public virtual string Username { get; internal set; }
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
              .Add("acr repository show-manifests")
              .Add("--name {value}", Name)
              .Add("--repository {value}", Repository)
              .Add("--detail {value}", Detail)
              .Add("--orderby {value}", Orderby)
              .Add("--password {value}", Password, secret: true)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--top {value}", Top)
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
    #region AzureAcrRepositoryShowTagsSettings
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcrRepositoryShowTagsSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcr executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcrTasks.AzureAcrPath;
        /// <summary><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>The name of the repository.</p></summary>
        public virtual string Repository { get; internal set; }
        /// <summary><p>Show detailed information.</p></summary>
        public virtual string Detail { get; internal set; }
        /// <summary><p>Order the items in the results. Default to alphabetical order of names.</p></summary>
        public virtual AcrRepositoryOrderby Orderby { get; internal set; }
        /// <summary><p>The password used to log into a container registry.</p></summary>
        public virtual string Password { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Limit the number of items in the results.</p></summary>
        public virtual string Top { get; internal set; }
        /// <summary><p>The username used to log into a container registry.</p></summary>
        public virtual string Username { get; internal set; }
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
              .Add("acr repository show-tags")
              .Add("--name {value}", Name)
              .Add("--repository {value}", Repository)
              .Add("--detail {value}", Detail)
              .Add("--orderby {value}", Orderby)
              .Add("--password {value}", Password, secret: true)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--top {value}", Top)
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
    #region AzureAcrRepositoryUntagSettings
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcrRepositoryUntagSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcr executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcrTasks.AzureAcrPath;
        /// <summary><p>The name of the image. May include a tag in the format 'name:tag'.</p></summary>
        public virtual string Image { get; internal set; }
        /// <summary><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>The password used to log into a container registry.</p></summary>
        public virtual string Password { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The username used to log into a container registry.</p></summary>
        public virtual string Username { get; internal set; }
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
              .Add("acr repository untag")
              .Add("--image {value}", Image)
              .Add("--name {value}", Name)
              .Add("--password {value}", Password, secret: true)
              .Add("--resource-group {value}", ResourceGroup)
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
    #region AzureAcrRepositoryUpdateSettings
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcrRepositoryUpdateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcr executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcrTasks.AzureAcrPath;
        /// <summary><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Indicates whether delete operation is allowed.</p></summary>
        public virtual bool? DeleteEnabled { get; internal set; }
        /// <summary><p>The name of the image. May include a tag in the format 'name:tag' or digest in the format 'name@digest'.</p></summary>
        public virtual string Image { get; internal set; }
        /// <summary><p>Indicates whether this item shows in list operation results.</p></summary>
        public virtual bool? ListEnabled { get; internal set; }
        /// <summary><p>The password used to log into a container registry.</p></summary>
        public virtual string Password { get; internal set; }
        /// <summary><p>Indicates whether read operation is allowed.</p></summary>
        public virtual bool? ReadEnabled { get; internal set; }
        /// <summary><p>The name of the repository.</p></summary>
        public virtual string Repository { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The username used to log into a container registry.</p></summary>
        public virtual string Username { get; internal set; }
        /// <summary><p>Indicates whether write or delete operation is allowed.</p></summary>
        public virtual bool? WriteEnabled { get; internal set; }
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
              .Add("acr repository update")
              .Add("--name {value}", Name)
              .Add("--delete-enabled", DeleteEnabled)
              .Add("--image {value}", Image)
              .Add("--list-enabled", ListEnabled)
              .Add("--password {value}", Password, secret: true)
              .Add("--read-enabled", ReadEnabled)
              .Add("--repository {value}", Repository)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--username {value}", Username)
              .Add("--write-enabled", WriteEnabled)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureAcrWebhookCreateSettings
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcrWebhookCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcr executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcrTasks.AzureAcrPath;
        /// <summary><p>Space-separated list of actions that trigger the webhook to post notifications.</p></summary>
        public virtual IReadOnlyList<AcrWebhookActions> Actions => ActionsInternal.AsReadOnly();
        internal List<AcrWebhookActions> ActionsInternal { get; set; } = new List<AcrWebhookActions>();
        /// <summary><p>The name of the webhook.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        public virtual string Registry { get; internal set; }
        /// <summary><p>The service URI for the webhook to post notifications.</p></summary>
        public virtual string Uri { get; internal set; }
        /// <summary><p>Space-separated custom headers in 'key[=value]' format that will be added to the webhook notifications. Use "" to clear existing headers.</p></summary>
        public virtual string Headers { get; internal set; }
        /// <summary><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        public virtual string Location { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The scope of repositories where the event can be triggered. For example, 'foo:*' means events for all tags under repository 'foo'. 'foo:bar' means events for 'foo:bar' only. 'foo' is equivalent to 'foo:latest'. Empty means events for all repositories.</p></summary>
        public virtual string Scope { get; internal set; }
        /// <summary><p>Indicates whether the webhook is enabled.</p></summary>
        public virtual AcrBuildTaskStatus Status { get; internal set; }
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
              .Add("acr webhook create")
              .Add("--actions {value}", Actions, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--registry {value}", Registry)
              .Add("--uri {value}", Uri)
              .Add("--headers {value}", Headers)
              .Add("--location {value}", Location)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--scope {value}", Scope)
              .Add("--status {value}", Status)
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
    #region AzureAcrWebhookDeleteSettings
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcrWebhookDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcr executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcrTasks.AzureAcrPath;
        /// <summary><p>The name of the webhook.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        public virtual string Registry { get; internal set; }
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
              .Add("acr webhook delete")
              .Add("--name {value}", Name)
              .Add("--registry {value}", Registry)
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
    #region AzureAcrWebhookGetConfigSettings
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcrWebhookGetConfigSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcr executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcrTasks.AzureAcrPath;
        /// <summary><p>The name of the webhook.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        public virtual string Registry { get; internal set; }
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
              .Add("acr webhook get-config")
              .Add("--name {value}", Name)
              .Add("--registry {value}", Registry)
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
    #region AzureAcrWebhookListSettings
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcrWebhookListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcr executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcrTasks.AzureAcrPath;
        /// <summary><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        public virtual string Registry { get; internal set; }
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
              .Add("acr webhook list")
              .Add("--registry {value}", Registry)
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
    #region AzureAcrWebhookListEventsSettings
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcrWebhookListEventsSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcr executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcrTasks.AzureAcrPath;
        /// <summary><p>The name of the webhook.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        public virtual string Registry { get; internal set; }
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
              .Add("acr webhook list-events")
              .Add("--name {value}", Name)
              .Add("--registry {value}", Registry)
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
    #region AzureAcrWebhookPingSettings
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcrWebhookPingSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcr executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcrTasks.AzureAcrPath;
        /// <summary><p>The name of the webhook.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        public virtual string Registry { get; internal set; }
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
              .Add("acr webhook ping")
              .Add("--name {value}", Name)
              .Add("--registry {value}", Registry)
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
    #region AzureAcrWebhookShowSettings
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcrWebhookShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcr executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcrTasks.AzureAcrPath;
        /// <summary><p>The name of the webhook.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        public virtual string Registry { get; internal set; }
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
              .Add("acr webhook show")
              .Add("--name {value}", Name)
              .Add("--registry {value}", Registry)
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
    #region AzureAcrWebhookUpdateSettings
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcrWebhookUpdateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcr executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcrTasks.AzureAcrPath;
        /// <summary><p>The name of the webhook.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        public virtual string Registry { get; internal set; }
        /// <summary><p>Space-separated list of actions that trigger the webhook to post notifications.</p></summary>
        public virtual IReadOnlyList<AcrWebhookActions> Actions => ActionsInternal.AsReadOnly();
        internal List<AcrWebhookActions> ActionsInternal { get; set; } = new List<AcrWebhookActions>();
        /// <summary><p>Space-separated custom headers in 'key[=value]' format that will be added to the webhook notifications. Use "" to clear existing headers.</p></summary>
        public virtual string Headers { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The scope of repositories where the event can be triggered. For example, 'foo:*' means events for all tags under repository 'foo'. 'foo:bar' means events for 'foo:bar' only. 'foo' is equivalent to 'foo:latest'. Empty means events for all repositories.</p></summary>
        public virtual string Scope { get; internal set; }
        /// <summary><p>Indicates whether the webhook is enabled.</p></summary>
        public virtual AcrBuildTaskStatus Status { get; internal set; }
        /// <summary><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        public virtual string Tags { get; internal set; }
        /// <summary><p>The service URI for the webhook to post notifications.</p></summary>
        public virtual string Uri { get; internal set; }
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
              .Add("acr webhook update")
              .Add("--name {value}", Name)
              .Add("--registry {value}", Registry)
              .Add("--actions {value}", Actions, separator: ' ')
              .Add("--headers {value}", Headers)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--scope {value}", Scope)
              .Add("--status {value}", Status)
              .Add("--tags {value}", Tags)
              .Add("--uri {value}", Uri)
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
    #region AzureAcrConfigContentTrustShowSettings
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcrConfigContentTrustShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcr executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcrTasks.AzureAcrPath;
        /// <summary><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
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
              .Add("acr config content-trust show")
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
    #region AzureAcrConfigContentTrustUpdateSettings
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcrConfigContentTrustUpdateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcr executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcrTasks.AzureAcrPath;
        /// <summary><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Indicates whether content-trust is enabled or disabled.</p></summary>
        public virtual AcrBuildTaskStatus Status { get; internal set; }
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
              .Add("acr config content-trust update")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--status {value}", Status)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureAcrBuildSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcrBuildSettingsExtensions
    {
        #region Registry
        /// <summary><p><em>Sets <see cref="AzureAcrBuildSettings.Registry"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrBuildSettings SetRegistry(this AzureAcrBuildSettings toolSettings, string registry)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Registry = registry;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildSettings.Registry"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrBuildSettings ResetRegistry(this AzureAcrBuildSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Registry = null;
            return toolSettings;
        }
        #endregion
        #region BuildArg
        /// <summary><p><em>Sets <see cref="AzureAcrBuildSettings.BuildArg"/>.</em></p><p>Build argument in 'name[=value]' format.</p></summary>
        [Pure]
        public static AzureAcrBuildSettings SetBuildArg(this AzureAcrBuildSettings toolSettings, string buildArg)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BuildArg = buildArg;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildSettings.BuildArg"/>.</em></p><p>Build argument in 'name[=value]' format.</p></summary>
        [Pure]
        public static AzureAcrBuildSettings ResetBuildArg(this AzureAcrBuildSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BuildArg = null;
            return toolSettings;
        }
        #endregion
        #region File
        /// <summary><p><em>Sets <see cref="AzureAcrBuildSettings.File"/>.</em></p><p>The relative path of the the docker file to the source code root folder.</p></summary>
        [Pure]
        public static AzureAcrBuildSettings SetFile(this AzureAcrBuildSettings toolSettings, string file)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.File = file;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildSettings.File"/>.</em></p><p>The relative path of the the docker file to the source code root folder.</p></summary>
        [Pure]
        public static AzureAcrBuildSettings ResetFile(this AzureAcrBuildSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.File = null;
            return toolSettings;
        }
        #endregion
        #region Image
        /// <summary><p><em>Sets <see cref="AzureAcrBuildSettings.Image"/>.</em></p><p>The name of the image. May include a tag in the format 'name:tag'.</p></summary>
        [Pure]
        public static AzureAcrBuildSettings SetImage(this AzureAcrBuildSettings toolSettings, string image)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Image = image;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildSettings.Image"/>.</em></p><p>The name of the image. May include a tag in the format 'name:tag'.</p></summary>
        [Pure]
        public static AzureAcrBuildSettings ResetImage(this AzureAcrBuildSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Image = null;
            return toolSettings;
        }
        #endregion
        #region NoLogs
        /// <summary><p><em>Sets <see cref="AzureAcrBuildSettings.NoLogs"/>.</em></p><p>Do not show logs after successfully queuing the build.</p></summary>
        [Pure]
        public static AzureAcrBuildSettings SetNoLogs(this AzureAcrBuildSettings toolSettings, bool? noLogs)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoLogs = noLogs;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildSettings.NoLogs"/>.</em></p><p>Do not show logs after successfully queuing the build.</p></summary>
        [Pure]
        public static AzureAcrBuildSettings ResetNoLogs(this AzureAcrBuildSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoLogs = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureAcrBuildSettings.NoLogs"/>.</em></p><p>Do not show logs after successfully queuing the build.</p></summary>
        [Pure]
        public static AzureAcrBuildSettings EnableNoLogs(this AzureAcrBuildSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoLogs = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureAcrBuildSettings.NoLogs"/>.</em></p><p>Do not show logs after successfully queuing the build.</p></summary>
        [Pure]
        public static AzureAcrBuildSettings DisableNoLogs(this AzureAcrBuildSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoLogs = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureAcrBuildSettings.NoLogs"/>.</em></p><p>Do not show logs after successfully queuing the build.</p></summary>
        [Pure]
        public static AzureAcrBuildSettings ToggleNoLogs(this AzureAcrBuildSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoLogs = !toolSettings.NoLogs;
            return toolSettings;
        }
        #endregion
        #region NoPush
        /// <summary><p><em>Sets <see cref="AzureAcrBuildSettings.NoPush"/>.</em></p><p>Indicates whether the image built should be pushed to the registry.</p></summary>
        [Pure]
        public static AzureAcrBuildSettings SetNoPush(this AzureAcrBuildSettings toolSettings, bool? noPush)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoPush = noPush;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildSettings.NoPush"/>.</em></p><p>Indicates whether the image built should be pushed to the registry.</p></summary>
        [Pure]
        public static AzureAcrBuildSettings ResetNoPush(this AzureAcrBuildSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoPush = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureAcrBuildSettings.NoPush"/>.</em></p><p>Indicates whether the image built should be pushed to the registry.</p></summary>
        [Pure]
        public static AzureAcrBuildSettings EnableNoPush(this AzureAcrBuildSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoPush = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureAcrBuildSettings.NoPush"/>.</em></p><p>Indicates whether the image built should be pushed to the registry.</p></summary>
        [Pure]
        public static AzureAcrBuildSettings DisableNoPush(this AzureAcrBuildSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoPush = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureAcrBuildSettings.NoPush"/>.</em></p><p>Indicates whether the image built should be pushed to the registry.</p></summary>
        [Pure]
        public static AzureAcrBuildSettings ToggleNoPush(this AzureAcrBuildSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoPush = !toolSettings.NoPush;
            return toolSettings;
        }
        #endregion
        #region Os
        /// <summary><p><em>Sets <see cref="AzureAcrBuildSettings.Os"/>.</em></p><p>The operating system type required for the build.</p></summary>
        [Pure]
        public static AzureAcrBuildSettings SetOs(this AzureAcrBuildSettings toolSettings, AcrOs os)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Os = os;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildSettings.Os"/>.</em></p><p>The operating system type required for the build.</p></summary>
        [Pure]
        public static AzureAcrBuildSettings ResetOs(this AzureAcrBuildSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Os = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAcrBuildSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrBuildSettings SetResourceGroup(this AzureAcrBuildSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrBuildSettings ResetResourceGroup(this AzureAcrBuildSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region SecretBuildArg
        /// <summary><p><em>Sets <see cref="AzureAcrBuildSettings.SecretBuildArg"/>.</em></p><p>Secret build argument in 'name[=value]' format.</p></summary>
        [Pure]
        public static AzureAcrBuildSettings SetSecretBuildArg(this AzureAcrBuildSettings toolSettings, string secretBuildArg)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SecretBuildArg = secretBuildArg;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildSettings.SecretBuildArg"/>.</em></p><p>Secret build argument in 'name[=value]' format.</p></summary>
        [Pure]
        public static AzureAcrBuildSettings ResetSecretBuildArg(this AzureAcrBuildSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SecretBuildArg = null;
            return toolSettings;
        }
        #endregion
        #region Timeout
        /// <summary><p><em>Sets <see cref="AzureAcrBuildSettings.Timeout"/>.</em></p><p>The build timeout in seconds.</p></summary>
        [Pure]
        public static AzureAcrBuildSettings SetTimeout(this AzureAcrBuildSettings toolSettings, string timeout)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Timeout = timeout;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildSettings.Timeout"/>.</em></p><p>The build timeout in seconds.</p></summary>
        [Pure]
        public static AzureAcrBuildSettings ResetTimeout(this AzureAcrBuildSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Timeout = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcrBuildSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrBuildSettings SetDebug(this AzureAcrBuildSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrBuildSettings ResetDebug(this AzureAcrBuildSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcrBuildSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrBuildSettings SetHelp(this AzureAcrBuildSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrBuildSettings ResetHelp(this AzureAcrBuildSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcrBuildSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrBuildSettings SetOutput(this AzureAcrBuildSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrBuildSettings ResetOutput(this AzureAcrBuildSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcrBuildSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrBuildSettings SetQuery(this AzureAcrBuildSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrBuildSettings ResetQuery(this AzureAcrBuildSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcrBuildSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrBuildSettings SetVerbose(this AzureAcrBuildSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrBuildSettings ResetVerbose(this AzureAcrBuildSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcrCheckNameSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcrCheckNameSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAcrCheckNameSettings.Name"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrCheckNameSettings SetName(this AzureAcrCheckNameSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrCheckNameSettings.Name"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrCheckNameSettings ResetName(this AzureAcrCheckNameSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcrCheckNameSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrCheckNameSettings SetDebug(this AzureAcrCheckNameSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrCheckNameSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrCheckNameSettings ResetDebug(this AzureAcrCheckNameSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcrCheckNameSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrCheckNameSettings SetHelp(this AzureAcrCheckNameSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrCheckNameSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrCheckNameSettings ResetHelp(this AzureAcrCheckNameSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcrCheckNameSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrCheckNameSettings SetOutput(this AzureAcrCheckNameSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrCheckNameSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrCheckNameSettings ResetOutput(this AzureAcrCheckNameSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcrCheckNameSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrCheckNameSettings SetQuery(this AzureAcrCheckNameSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrCheckNameSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrCheckNameSettings ResetQuery(this AzureAcrCheckNameSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcrCheckNameSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrCheckNameSettings SetVerbose(this AzureAcrCheckNameSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrCheckNameSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrCheckNameSettings ResetVerbose(this AzureAcrCheckNameSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcrCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcrCreateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAcrCreateSettings.Name"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrCreateSettings SetName(this AzureAcrCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrCreateSettings.Name"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrCreateSettings ResetName(this AzureAcrCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAcrCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrCreateSettings SetResourceGroup(this AzureAcrCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrCreateSettings ResetResourceGroup(this AzureAcrCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Sku
        /// <summary><p><em>Sets <see cref="AzureAcrCreateSettings.Sku"/>.</em></p><p>The SKU of the container registry.</p></summary>
        [Pure]
        public static AzureAcrCreateSettings SetSku(this AzureAcrCreateSettings toolSettings, AcrSku sku)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = sku;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrCreateSettings.Sku"/>.</em></p><p>The SKU of the container registry.</p></summary>
        [Pure]
        public static AzureAcrCreateSettings ResetSku(this AzureAcrCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = null;
            return toolSettings;
        }
        #endregion
        #region AdminEnabled
        /// <summary><p><em>Sets <see cref="AzureAcrCreateSettings.AdminEnabled"/>.</em></p><p>Indicates whether the admin user is enabled.</p></summary>
        [Pure]
        public static AzureAcrCreateSettings SetAdminEnabled(this AzureAcrCreateSettings toolSettings, bool? adminEnabled)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdminEnabled = adminEnabled;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrCreateSettings.AdminEnabled"/>.</em></p><p>Indicates whether the admin user is enabled.</p></summary>
        [Pure]
        public static AzureAcrCreateSettings ResetAdminEnabled(this AzureAcrCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdminEnabled = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureAcrCreateSettings.AdminEnabled"/>.</em></p><p>Indicates whether the admin user is enabled.</p></summary>
        [Pure]
        public static AzureAcrCreateSettings EnableAdminEnabled(this AzureAcrCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdminEnabled = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureAcrCreateSettings.AdminEnabled"/>.</em></p><p>Indicates whether the admin user is enabled.</p></summary>
        [Pure]
        public static AzureAcrCreateSettings DisableAdminEnabled(this AzureAcrCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdminEnabled = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureAcrCreateSettings.AdminEnabled"/>.</em></p><p>Indicates whether the admin user is enabled.</p></summary>
        [Pure]
        public static AzureAcrCreateSettings ToggleAdminEnabled(this AzureAcrCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdminEnabled = !toolSettings.AdminEnabled;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary><p><em>Sets <see cref="AzureAcrCreateSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrCreateSettings SetLocation(this AzureAcrCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrCreateSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrCreateSettings ResetLocation(this AzureAcrCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region StorageAccountName
        /// <summary><p><em>Sets <see cref="AzureAcrCreateSettings.StorageAccountName"/>.</em></p><p>Provide the name of an existing storage account if you're recreating a container registry over a previous registry created storage account. Only applicable to Classic SKU.</p></summary>
        [Pure]
        public static AzureAcrCreateSettings SetStorageAccountName(this AzureAcrCreateSettings toolSettings, string storageAccountName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageAccountName = storageAccountName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrCreateSettings.StorageAccountName"/>.</em></p><p>Provide the name of an existing storage account if you're recreating a container registry over a previous registry created storage account. Only applicable to Classic SKU.</p></summary>
        [Pure]
        public static AzureAcrCreateSettings ResetStorageAccountName(this AzureAcrCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageAccountName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcrCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrCreateSettings SetDebug(this AzureAcrCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrCreateSettings ResetDebug(this AzureAcrCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcrCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrCreateSettings SetHelp(this AzureAcrCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrCreateSettings ResetHelp(this AzureAcrCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcrCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrCreateSettings SetOutput(this AzureAcrCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrCreateSettings ResetOutput(this AzureAcrCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcrCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrCreateSettings SetQuery(this AzureAcrCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrCreateSettings ResetQuery(this AzureAcrCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcrCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrCreateSettings SetVerbose(this AzureAcrCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrCreateSettings ResetVerbose(this AzureAcrCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcrDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcrDeleteSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAcrDeleteSettings.Name"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrDeleteSettings SetName(this AzureAcrDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrDeleteSettings.Name"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrDeleteSettings ResetName(this AzureAcrDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAcrDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrDeleteSettings SetResourceGroup(this AzureAcrDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrDeleteSettings ResetResourceGroup(this AzureAcrDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcrDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrDeleteSettings SetDebug(this AzureAcrDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrDeleteSettings ResetDebug(this AzureAcrDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcrDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrDeleteSettings SetHelp(this AzureAcrDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrDeleteSettings ResetHelp(this AzureAcrDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcrDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrDeleteSettings SetOutput(this AzureAcrDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrDeleteSettings ResetOutput(this AzureAcrDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcrDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrDeleteSettings SetQuery(this AzureAcrDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrDeleteSettings ResetQuery(this AzureAcrDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcrDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrDeleteSettings SetVerbose(this AzureAcrDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrDeleteSettings ResetVerbose(this AzureAcrDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcrImportSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcrImportSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAcrImportSettings.Name"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrImportSettings SetName(this AzureAcrImportSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrImportSettings.Name"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrImportSettings ResetName(this AzureAcrImportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Source
        /// <summary><p><em>Sets <see cref="AzureAcrImportSettings.Source"/>.</em></p><p>The source identifier in the format '[registry.azurecr.io/]repository[:tag]' or '[registry.azurecr.io/]repository@digest'.</p></summary>
        [Pure]
        public static AzureAcrImportSettings SetSource(this AzureAcrImportSettings toolSettings, string source)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Source = source;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrImportSettings.Source"/>.</em></p><p>The source identifier in the format '[registry.azurecr.io/]repository[:tag]' or '[registry.azurecr.io/]repository@digest'.</p></summary>
        [Pure]
        public static AzureAcrImportSettings ResetSource(this AzureAcrImportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Source = null;
            return toolSettings;
        }
        #endregion
        #region Force
        /// <summary><p><em>Sets <see cref="AzureAcrImportSettings.Force"/>.</em></p><p>Overwrite the existing tag of the image to be imported.</p></summary>
        [Pure]
        public static AzureAcrImportSettings SetForce(this AzureAcrImportSettings toolSettings, string force)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Force = force;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrImportSettings.Force"/>.</em></p><p>Overwrite the existing tag of the image to be imported.</p></summary>
        [Pure]
        public static AzureAcrImportSettings ResetForce(this AzureAcrImportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Force = null;
            return toolSettings;
        }
        #endregion
        #region Image
        /// <summary><p><em>Sets <see cref="AzureAcrImportSettings.Image"/>.</em></p><p>The name of the image. May include a tag in the format 'name:tag'.</p></summary>
        [Pure]
        public static AzureAcrImportSettings SetImage(this AzureAcrImportSettings toolSettings, string image)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Image = image;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrImportSettings.Image"/>.</em></p><p>The name of the image. May include a tag in the format 'name:tag'.</p></summary>
        [Pure]
        public static AzureAcrImportSettings ResetImage(this AzureAcrImportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Image = null;
            return toolSettings;
        }
        #endregion
        #region Registry
        /// <summary><p><em>Sets <see cref="AzureAcrImportSettings.Registry"/>.</em></p><p>The source container registry can be name, login server or resource ID of the source registry.</p></summary>
        [Pure]
        public static AzureAcrImportSettings SetRegistry(this AzureAcrImportSettings toolSettings, string registry)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Registry = registry;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrImportSettings.Registry"/>.</em></p><p>The source container registry can be name, login server or resource ID of the source registry.</p></summary>
        [Pure]
        public static AzureAcrImportSettings ResetRegistry(this AzureAcrImportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Registry = null;
            return toolSettings;
        }
        #endregion
        #region Repository
        /// <summary><p><em>Sets <see cref="AzureAcrImportSettings.Repository"/>.</em></p><p>The repository name to do a manifest-only copy for images.</p></summary>
        [Pure]
        public static AzureAcrImportSettings SetRepository(this AzureAcrImportSettings toolSettings, string repository)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Repository = repository;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrImportSettings.Repository"/>.</em></p><p>The repository name to do a manifest-only copy for images.</p></summary>
        [Pure]
        public static AzureAcrImportSettings ResetRepository(this AzureAcrImportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Repository = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAcrImportSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrImportSettings SetResourceGroup(this AzureAcrImportSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrImportSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrImportSettings ResetResourceGroup(this AzureAcrImportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcrImportSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrImportSettings SetDebug(this AzureAcrImportSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrImportSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrImportSettings ResetDebug(this AzureAcrImportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcrImportSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrImportSettings SetHelp(this AzureAcrImportSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrImportSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrImportSettings ResetHelp(this AzureAcrImportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcrImportSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrImportSettings SetOutput(this AzureAcrImportSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrImportSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrImportSettings ResetOutput(this AzureAcrImportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcrImportSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrImportSettings SetQuery(this AzureAcrImportSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrImportSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrImportSettings ResetQuery(this AzureAcrImportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcrImportSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrImportSettings SetVerbose(this AzureAcrImportSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrImportSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrImportSettings ResetVerbose(this AzureAcrImportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcrListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcrListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAcrListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrListSettings SetResourceGroup(this AzureAcrListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrListSettings ResetResourceGroup(this AzureAcrListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcrListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrListSettings SetDebug(this AzureAcrListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrListSettings ResetDebug(this AzureAcrListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcrListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrListSettings SetHelp(this AzureAcrListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrListSettings ResetHelp(this AzureAcrListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcrListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrListSettings SetOutput(this AzureAcrListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrListSettings ResetOutput(this AzureAcrListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcrListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrListSettings SetQuery(this AzureAcrListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrListSettings ResetQuery(this AzureAcrListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcrListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrListSettings SetVerbose(this AzureAcrListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrListSettings ResetVerbose(this AzureAcrListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcrLoginSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcrLoginSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAcrLoginSettings.Name"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrLoginSettings SetName(this AzureAcrLoginSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrLoginSettings.Name"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrLoginSettings ResetName(this AzureAcrLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Password
        /// <summary><p><em>Sets <see cref="AzureAcrLoginSettings.Password"/>.</em></p><p>The password used to log into a container registry.</p></summary>
        [Pure]
        public static AzureAcrLoginSettings SetPassword(this AzureAcrLoginSettings toolSettings, string password)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = password;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrLoginSettings.Password"/>.</em></p><p>The password used to log into a container registry.</p></summary>
        [Pure]
        public static AzureAcrLoginSettings ResetPassword(this AzureAcrLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAcrLoginSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrLoginSettings SetResourceGroup(this AzureAcrLoginSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrLoginSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrLoginSettings ResetResourceGroup(this AzureAcrLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Username
        /// <summary><p><em>Sets <see cref="AzureAcrLoginSettings.Username"/>.</em></p><p>The username used to log into a container registry.</p></summary>
        [Pure]
        public static AzureAcrLoginSettings SetUsername(this AzureAcrLoginSettings toolSettings, string username)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Username = username;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrLoginSettings.Username"/>.</em></p><p>The username used to log into a container registry.</p></summary>
        [Pure]
        public static AzureAcrLoginSettings ResetUsername(this AzureAcrLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Username = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcrLoginSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrLoginSettings SetDebug(this AzureAcrLoginSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrLoginSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrLoginSettings ResetDebug(this AzureAcrLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcrLoginSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrLoginSettings SetHelp(this AzureAcrLoginSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrLoginSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrLoginSettings ResetHelp(this AzureAcrLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcrLoginSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrLoginSettings SetOutput(this AzureAcrLoginSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrLoginSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrLoginSettings ResetOutput(this AzureAcrLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcrLoginSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrLoginSettings SetQuery(this AzureAcrLoginSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrLoginSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrLoginSettings ResetQuery(this AzureAcrLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcrLoginSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrLoginSettings SetVerbose(this AzureAcrLoginSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrLoginSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrLoginSettings ResetVerbose(this AzureAcrLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcrShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcrShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAcrShowSettings.Name"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrShowSettings SetName(this AzureAcrShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrShowSettings.Name"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrShowSettings ResetName(this AzureAcrShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAcrShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrShowSettings SetResourceGroup(this AzureAcrShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrShowSettings ResetResourceGroup(this AzureAcrShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcrShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrShowSettings SetDebug(this AzureAcrShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrShowSettings ResetDebug(this AzureAcrShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcrShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrShowSettings SetHelp(this AzureAcrShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrShowSettings ResetHelp(this AzureAcrShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcrShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrShowSettings SetOutput(this AzureAcrShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrShowSettings ResetOutput(this AzureAcrShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcrShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrShowSettings SetQuery(this AzureAcrShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrShowSettings ResetQuery(this AzureAcrShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcrShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrShowSettings SetVerbose(this AzureAcrShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrShowSettings ResetVerbose(this AzureAcrShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcrShowUsageSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcrShowUsageSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAcrShowUsageSettings.Name"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrShowUsageSettings SetName(this AzureAcrShowUsageSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrShowUsageSettings.Name"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrShowUsageSettings ResetName(this AzureAcrShowUsageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAcrShowUsageSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrShowUsageSettings SetResourceGroup(this AzureAcrShowUsageSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrShowUsageSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrShowUsageSettings ResetResourceGroup(this AzureAcrShowUsageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcrShowUsageSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrShowUsageSettings SetDebug(this AzureAcrShowUsageSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrShowUsageSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrShowUsageSettings ResetDebug(this AzureAcrShowUsageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcrShowUsageSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrShowUsageSettings SetHelp(this AzureAcrShowUsageSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrShowUsageSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrShowUsageSettings ResetHelp(this AzureAcrShowUsageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcrShowUsageSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrShowUsageSettings SetOutput(this AzureAcrShowUsageSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrShowUsageSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrShowUsageSettings ResetOutput(this AzureAcrShowUsageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcrShowUsageSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrShowUsageSettings SetQuery(this AzureAcrShowUsageSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrShowUsageSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrShowUsageSettings ResetQuery(this AzureAcrShowUsageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcrShowUsageSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrShowUsageSettings SetVerbose(this AzureAcrShowUsageSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrShowUsageSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrShowUsageSettings ResetVerbose(this AzureAcrShowUsageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcrUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcrUpdateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAcrUpdateSettings.Name"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrUpdateSettings SetName(this AzureAcrUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrUpdateSettings.Name"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrUpdateSettings ResetName(this AzureAcrUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region AdminEnabled
        /// <summary><p><em>Sets <see cref="AzureAcrUpdateSettings.AdminEnabled"/>.</em></p><p>Indicates whether the admin user is enabled.</p></summary>
        [Pure]
        public static AzureAcrUpdateSettings SetAdminEnabled(this AzureAcrUpdateSettings toolSettings, bool? adminEnabled)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdminEnabled = adminEnabled;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrUpdateSettings.AdminEnabled"/>.</em></p><p>Indicates whether the admin user is enabled.</p></summary>
        [Pure]
        public static AzureAcrUpdateSettings ResetAdminEnabled(this AzureAcrUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdminEnabled = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureAcrUpdateSettings.AdminEnabled"/>.</em></p><p>Indicates whether the admin user is enabled.</p></summary>
        [Pure]
        public static AzureAcrUpdateSettings EnableAdminEnabled(this AzureAcrUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdminEnabled = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureAcrUpdateSettings.AdminEnabled"/>.</em></p><p>Indicates whether the admin user is enabled.</p></summary>
        [Pure]
        public static AzureAcrUpdateSettings DisableAdminEnabled(this AzureAcrUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdminEnabled = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureAcrUpdateSettings.AdminEnabled"/>.</em></p><p>Indicates whether the admin user is enabled.</p></summary>
        [Pure]
        public static AzureAcrUpdateSettings ToggleAdminEnabled(this AzureAcrUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdminEnabled = !toolSettings.AdminEnabled;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAcrUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrUpdateSettings SetResourceGroup(this AzureAcrUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrUpdateSettings ResetResourceGroup(this AzureAcrUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Sku
        /// <summary><p><em>Sets <see cref="AzureAcrUpdateSettings.Sku"/>.</em></p><p>The SKU of the container registry.</p></summary>
        [Pure]
        public static AzureAcrUpdateSettings SetSku(this AzureAcrUpdateSettings toolSettings, AcrSku sku)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = sku;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrUpdateSettings.Sku"/>.</em></p><p>The SKU of the container registry.</p></summary>
        [Pure]
        public static AzureAcrUpdateSettings ResetSku(this AzureAcrUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = null;
            return toolSettings;
        }
        #endregion
        #region StorageAccountName
        /// <summary><p><em>Sets <see cref="AzureAcrUpdateSettings.StorageAccountName"/>.</em></p><p>Provide the name of an existing storage account if you're recreating a container registry over a previous registry created storage account. Only applicable to Classic SKU.</p></summary>
        [Pure]
        public static AzureAcrUpdateSettings SetStorageAccountName(this AzureAcrUpdateSettings toolSettings, string storageAccountName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageAccountName = storageAccountName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrUpdateSettings.StorageAccountName"/>.</em></p><p>Provide the name of an existing storage account if you're recreating a container registry over a previous registry created storage account. Only applicable to Classic SKU.</p></summary>
        [Pure]
        public static AzureAcrUpdateSettings ResetStorageAccountName(this AzureAcrUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageAccountName = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary><p><em>Sets <see cref="AzureAcrUpdateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureAcrUpdateSettings SetTags(this AzureAcrUpdateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrUpdateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureAcrUpdateSettings ResetTags(this AzureAcrUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary><p><em>Sets <see cref="AzureAcrUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureAcrUpdateSettings SetAdd(this AzureAcrUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureAcrUpdateSettings ResetAdd(this AzureAcrUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region ForceString
        /// <summary><p><em>Sets <see cref="AzureAcrUpdateSettings.ForceString"/>.</em></p><p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p></summary>
        [Pure]
        public static AzureAcrUpdateSettings SetForceString(this AzureAcrUpdateSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrUpdateSettings.ForceString"/>.</em></p><p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p></summary>
        [Pure]
        public static AzureAcrUpdateSettings ResetForceString(this AzureAcrUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary><p><em>Sets <see cref="AzureAcrUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureAcrUpdateSettings SetRemove(this AzureAcrUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureAcrUpdateSettings ResetRemove(this AzureAcrUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary><p><em>Sets <see cref="AzureAcrUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureAcrUpdateSettings SetSet(this AzureAcrUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureAcrUpdateSettings ResetSet(this AzureAcrUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcrUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrUpdateSettings SetDebug(this AzureAcrUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrUpdateSettings ResetDebug(this AzureAcrUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcrUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrUpdateSettings SetHelp(this AzureAcrUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrUpdateSettings ResetHelp(this AzureAcrUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcrUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrUpdateSettings SetOutput(this AzureAcrUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrUpdateSettings ResetOutput(this AzureAcrUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcrUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrUpdateSettings SetQuery(this AzureAcrUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrUpdateSettings ResetQuery(this AzureAcrUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcrUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrUpdateSettings SetVerbose(this AzureAcrUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrUpdateSettings ResetVerbose(this AzureAcrUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcrBuildTaskCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcrBuildTaskCreateSettingsExtensions
    {
        #region Context
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskCreateSettings.Context"/>.</em></p><p>The full URL to the source code respository.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskCreateSettings SetContext(this AzureAcrBuildTaskCreateSettings toolSettings, string context)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Context = context;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskCreateSettings.Context"/>.</em></p><p>The full URL to the source code respository.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskCreateSettings ResetContext(this AzureAcrBuildTaskCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Context = null;
            return toolSettings;
        }
        #endregion
        #region GitAccessToken
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskCreateSettings.GitAccessToken"/>.</em></p><p>The access token used to access the source control provider.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskCreateSettings SetGitAccessToken(this AzureAcrBuildTaskCreateSettings toolSettings, string gitAccessToken)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GitAccessToken = gitAccessToken;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskCreateSettings.GitAccessToken"/>.</em></p><p>The access token used to access the source control provider.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskCreateSettings ResetGitAccessToken(this AzureAcrBuildTaskCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GitAccessToken = null;
            return toolSettings;
        }
        #endregion
        #region Image
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskCreateSettings.Image"/>.</em></p><p>The name of the image. May include a tag in the format 'name:tag'.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskCreateSettings SetImage(this AzureAcrBuildTaskCreateSettings toolSettings, string image)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Image = image;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskCreateSettings.Image"/>.</em></p><p>The name of the image. May include a tag in the format 'name:tag'.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskCreateSettings ResetImage(this AzureAcrBuildTaskCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Image = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskCreateSettings.Name"/>.</em></p><p>The name of the build task.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskCreateSettings SetName(this AzureAcrBuildTaskCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskCreateSettings.Name"/>.</em></p><p>The name of the build task.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskCreateSettings ResetName(this AzureAcrBuildTaskCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Registry
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskCreateSettings.Registry"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskCreateSettings SetRegistry(this AzureAcrBuildTaskCreateSettings toolSettings, string registry)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Registry = registry;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskCreateSettings.Registry"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskCreateSettings ResetRegistry(this AzureAcrBuildTaskCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Registry = null;
            return toolSettings;
        }
        #endregion
        #region Alias
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskCreateSettings.Alias"/>.</em></p><p>The alternative name for build task. Default to the build task name.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskCreateSettings SetAlias(this AzureAcrBuildTaskCreateSettings toolSettings, string alias)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Alias = alias;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskCreateSettings.Alias"/>.</em></p><p>The alternative name for build task. Default to the build task name.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskCreateSettings ResetAlias(this AzureAcrBuildTaskCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Alias = null;
            return toolSettings;
        }
        #endregion
        #region BaseImageTrigger
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskCreateSettings.BaseImageTrigger"/>.</em></p><p>The type of the auto trigger for base image dependency updates.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskCreateSettings SetBaseImageTrigger(this AzureAcrBuildTaskCreateSettings toolSettings, AcrBuildTaskBaseImageTrigger baseImageTrigger)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BaseImageTrigger = baseImageTrigger;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskCreateSettings.BaseImageTrigger"/>.</em></p><p>The type of the auto trigger for base image dependency updates.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskCreateSettings ResetBaseImageTrigger(this AzureAcrBuildTaskCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BaseImageTrigger = null;
            return toolSettings;
        }
        #endregion
        #region Branch
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskCreateSettings.Branch"/>.</em></p><p>The source control branch name.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskCreateSettings SetBranch(this AzureAcrBuildTaskCreateSettings toolSettings, string branch)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Branch = branch;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskCreateSettings.Branch"/>.</em></p><p>The source control branch name.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskCreateSettings ResetBranch(this AzureAcrBuildTaskCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Branch = null;
            return toolSettings;
        }
        #endregion
        #region BuildArg
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskCreateSettings.BuildArg"/>.</em></p><p>Build argument in 'name[=value]' format.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskCreateSettings SetBuildArg(this AzureAcrBuildTaskCreateSettings toolSettings, string buildArg)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BuildArg = buildArg;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskCreateSettings.BuildArg"/>.</em></p><p>Build argument in 'name[=value]' format.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskCreateSettings ResetBuildArg(this AzureAcrBuildTaskCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BuildArg = null;
            return toolSettings;
        }
        #endregion
        #region CommitTriggerEnabled
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskCreateSettings.CommitTriggerEnabled"/>.</em></p><p>Indicates whether the source control commit trigger is enabled.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskCreateSettings SetCommitTriggerEnabled(this AzureAcrBuildTaskCreateSettings toolSettings, bool? commitTriggerEnabled)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CommitTriggerEnabled = commitTriggerEnabled;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskCreateSettings.CommitTriggerEnabled"/>.</em></p><p>Indicates whether the source control commit trigger is enabled.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskCreateSettings ResetCommitTriggerEnabled(this AzureAcrBuildTaskCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CommitTriggerEnabled = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureAcrBuildTaskCreateSettings.CommitTriggerEnabled"/>.</em></p><p>Indicates whether the source control commit trigger is enabled.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskCreateSettings EnableCommitTriggerEnabled(this AzureAcrBuildTaskCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CommitTriggerEnabled = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureAcrBuildTaskCreateSettings.CommitTriggerEnabled"/>.</em></p><p>Indicates whether the source control commit trigger is enabled.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskCreateSettings DisableCommitTriggerEnabled(this AzureAcrBuildTaskCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CommitTriggerEnabled = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureAcrBuildTaskCreateSettings.CommitTriggerEnabled"/>.</em></p><p>Indicates whether the source control commit trigger is enabled.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskCreateSettings ToggleCommitTriggerEnabled(this AzureAcrBuildTaskCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CommitTriggerEnabled = !toolSettings.CommitTriggerEnabled;
            return toolSettings;
        }
        #endregion
        #region Cpu
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskCreateSettings.Cpu"/>.</em></p><p>The CPU configuration in terms of number of cores required for the build.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskCreateSettings SetCpu(this AzureAcrBuildTaskCreateSettings toolSettings, string cpu)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cpu = cpu;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskCreateSettings.Cpu"/>.</em></p><p>The CPU configuration in terms of number of cores required for the build.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskCreateSettings ResetCpu(this AzureAcrBuildTaskCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cpu = null;
            return toolSettings;
        }
        #endregion
        #region File
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskCreateSettings.File"/>.</em></p><p>The relative path of the the docker file to the source code root folder.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskCreateSettings SetFile(this AzureAcrBuildTaskCreateSettings toolSettings, string file)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.File = file;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskCreateSettings.File"/>.</em></p><p>The relative path of the the docker file to the source code root folder.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskCreateSettings ResetFile(this AzureAcrBuildTaskCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.File = null;
            return toolSettings;
        }
        #endregion
        #region NoCache
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskCreateSettings.NoCache"/>.</em></p><p>Indicates whether the image cache is enabled.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskCreateSettings SetNoCache(this AzureAcrBuildTaskCreateSettings toolSettings, bool? noCache)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoCache = noCache;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskCreateSettings.NoCache"/>.</em></p><p>Indicates whether the image cache is enabled.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskCreateSettings ResetNoCache(this AzureAcrBuildTaskCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoCache = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureAcrBuildTaskCreateSettings.NoCache"/>.</em></p><p>Indicates whether the image cache is enabled.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskCreateSettings EnableNoCache(this AzureAcrBuildTaskCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoCache = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureAcrBuildTaskCreateSettings.NoCache"/>.</em></p><p>Indicates whether the image cache is enabled.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskCreateSettings DisableNoCache(this AzureAcrBuildTaskCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoCache = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureAcrBuildTaskCreateSettings.NoCache"/>.</em></p><p>Indicates whether the image cache is enabled.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskCreateSettings ToggleNoCache(this AzureAcrBuildTaskCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoCache = !toolSettings.NoCache;
            return toolSettings;
        }
        #endregion
        #region NoPush
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskCreateSettings.NoPush"/>.</em></p><p>Indicates whether the image built should be pushed to the registry.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskCreateSettings SetNoPush(this AzureAcrBuildTaskCreateSettings toolSettings, bool? noPush)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoPush = noPush;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskCreateSettings.NoPush"/>.</em></p><p>Indicates whether the image built should be pushed to the registry.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskCreateSettings ResetNoPush(this AzureAcrBuildTaskCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoPush = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureAcrBuildTaskCreateSettings.NoPush"/>.</em></p><p>Indicates whether the image built should be pushed to the registry.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskCreateSettings EnableNoPush(this AzureAcrBuildTaskCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoPush = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureAcrBuildTaskCreateSettings.NoPush"/>.</em></p><p>Indicates whether the image built should be pushed to the registry.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskCreateSettings DisableNoPush(this AzureAcrBuildTaskCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoPush = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureAcrBuildTaskCreateSettings.NoPush"/>.</em></p><p>Indicates whether the image built should be pushed to the registry.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskCreateSettings ToggleNoPush(this AzureAcrBuildTaskCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoPush = !toolSettings.NoPush;
            return toolSettings;
        }
        #endregion
        #region Os
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskCreateSettings.Os"/>.</em></p><p>The operating system type required for the build.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskCreateSettings SetOs(this AzureAcrBuildTaskCreateSettings toolSettings, AcrOs os)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Os = os;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskCreateSettings.Os"/>.</em></p><p>The operating system type required for the build.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskCreateSettings ResetOs(this AzureAcrBuildTaskCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Os = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskCreateSettings SetResourceGroup(this AzureAcrBuildTaskCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskCreateSettings ResetResourceGroup(this AzureAcrBuildTaskCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region SecretBuildArg
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskCreateSettings.SecretBuildArg"/>.</em></p><p>Secret build argument in 'name[=value]' format.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskCreateSettings SetSecretBuildArg(this AzureAcrBuildTaskCreateSettings toolSettings, string secretBuildArg)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SecretBuildArg = secretBuildArg;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskCreateSettings.SecretBuildArg"/>.</em></p><p>Secret build argument in 'name[=value]' format.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskCreateSettings ResetSecretBuildArg(this AzureAcrBuildTaskCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SecretBuildArg = null;
            return toolSettings;
        }
        #endregion
        #region Status
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskCreateSettings.Status"/>.</em></p><p>The current status of build task.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskCreateSettings SetStatus(this AzureAcrBuildTaskCreateSettings toolSettings, AcrBuildTaskStatus status)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Status = status;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskCreateSettings.Status"/>.</em></p><p>The current status of build task.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskCreateSettings ResetStatus(this AzureAcrBuildTaskCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Status = null;
            return toolSettings;
        }
        #endregion
        #region Timeout
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskCreateSettings.Timeout"/>.</em></p><p>The build timeout in seconds.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskCreateSettings SetTimeout(this AzureAcrBuildTaskCreateSettings toolSettings, string timeout)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Timeout = timeout;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskCreateSettings.Timeout"/>.</em></p><p>The build timeout in seconds.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskCreateSettings ResetTimeout(this AzureAcrBuildTaskCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Timeout = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskCreateSettings SetDebug(this AzureAcrBuildTaskCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskCreateSettings ResetDebug(this AzureAcrBuildTaskCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskCreateSettings SetHelp(this AzureAcrBuildTaskCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskCreateSettings ResetHelp(this AzureAcrBuildTaskCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskCreateSettings SetOutput(this AzureAcrBuildTaskCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskCreateSettings ResetOutput(this AzureAcrBuildTaskCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskCreateSettings SetQuery(this AzureAcrBuildTaskCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskCreateSettings ResetQuery(this AzureAcrBuildTaskCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskCreateSettings SetVerbose(this AzureAcrBuildTaskCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskCreateSettings ResetVerbose(this AzureAcrBuildTaskCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcrBuildTaskDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcrBuildTaskDeleteSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskDeleteSettings.Name"/>.</em></p><p>The name of the build task.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskDeleteSettings SetName(this AzureAcrBuildTaskDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskDeleteSettings.Name"/>.</em></p><p>The name of the build task.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskDeleteSettings ResetName(this AzureAcrBuildTaskDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Registry
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskDeleteSettings.Registry"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskDeleteSettings SetRegistry(this AzureAcrBuildTaskDeleteSettings toolSettings, string registry)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Registry = registry;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskDeleteSettings.Registry"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskDeleteSettings ResetRegistry(this AzureAcrBuildTaskDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Registry = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskDeleteSettings SetResourceGroup(this AzureAcrBuildTaskDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskDeleteSettings ResetResourceGroup(this AzureAcrBuildTaskDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskDeleteSettings SetDebug(this AzureAcrBuildTaskDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskDeleteSettings ResetDebug(this AzureAcrBuildTaskDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskDeleteSettings SetHelp(this AzureAcrBuildTaskDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskDeleteSettings ResetHelp(this AzureAcrBuildTaskDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskDeleteSettings SetOutput(this AzureAcrBuildTaskDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskDeleteSettings ResetOutput(this AzureAcrBuildTaskDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskDeleteSettings SetQuery(this AzureAcrBuildTaskDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskDeleteSettings ResetQuery(this AzureAcrBuildTaskDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskDeleteSettings SetVerbose(this AzureAcrBuildTaskDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskDeleteSettings ResetVerbose(this AzureAcrBuildTaskDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcrBuildTaskListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcrBuildTaskListSettingsExtensions
    {
        #region Registry
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskListSettings.Registry"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskListSettings SetRegistry(this AzureAcrBuildTaskListSettings toolSettings, string registry)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Registry = registry;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskListSettings.Registry"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskListSettings ResetRegistry(this AzureAcrBuildTaskListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Registry = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskListSettings SetResourceGroup(this AzureAcrBuildTaskListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskListSettings ResetResourceGroup(this AzureAcrBuildTaskListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskListSettings SetDebug(this AzureAcrBuildTaskListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskListSettings ResetDebug(this AzureAcrBuildTaskListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskListSettings SetHelp(this AzureAcrBuildTaskListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskListSettings ResetHelp(this AzureAcrBuildTaskListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskListSettings SetOutput(this AzureAcrBuildTaskListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskListSettings ResetOutput(this AzureAcrBuildTaskListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskListSettings SetQuery(this AzureAcrBuildTaskListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskListSettings ResetQuery(this AzureAcrBuildTaskListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskListSettings SetVerbose(this AzureAcrBuildTaskListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskListSettings ResetVerbose(this AzureAcrBuildTaskListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcrBuildTaskListBuildsSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcrBuildTaskListBuildsSettingsExtensions
    {
        #region Registry
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskListBuildsSettings.Registry"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskListBuildsSettings SetRegistry(this AzureAcrBuildTaskListBuildsSettings toolSettings, string registry)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Registry = registry;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskListBuildsSettings.Registry"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskListBuildsSettings ResetRegistry(this AzureAcrBuildTaskListBuildsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Registry = null;
            return toolSettings;
        }
        #endregion
        #region BuildStatus
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskListBuildsSettings.BuildStatus"/>.</em></p><p>The current status of build.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskListBuildsSettings SetBuildStatus(this AzureAcrBuildTaskListBuildsSettings toolSettings, AcrBuildTaskListBuildsBuildStatus buildStatus)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BuildStatus = buildStatus;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskListBuildsSettings.BuildStatus"/>.</em></p><p>The current status of build.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskListBuildsSettings ResetBuildStatus(this AzureAcrBuildTaskListBuildsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BuildStatus = null;
            return toolSettings;
        }
        #endregion
        #region Image
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskListBuildsSettings.Image"/>.</em></p><p>The name of the image. May include a tag in the format 'name:tag' or digest in the format 'name@digest'.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskListBuildsSettings SetImage(this AzureAcrBuildTaskListBuildsSettings toolSettings, string image)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Image = image;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskListBuildsSettings.Image"/>.</em></p><p>The name of the image. May include a tag in the format 'name:tag' or digest in the format 'name@digest'.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskListBuildsSettings ResetImage(this AzureAcrBuildTaskListBuildsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Image = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskListBuildsSettings.Name"/>.</em></p><p>The name of the build task.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskListBuildsSettings SetName(this AzureAcrBuildTaskListBuildsSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskListBuildsSettings.Name"/>.</em></p><p>The name of the build task.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskListBuildsSettings ResetName(this AzureAcrBuildTaskListBuildsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskListBuildsSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskListBuildsSettings SetResourceGroup(this AzureAcrBuildTaskListBuildsSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskListBuildsSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskListBuildsSettings ResetResourceGroup(this AzureAcrBuildTaskListBuildsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Top
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskListBuildsSettings.Top"/>.</em></p><p>Limit the number of latest builds in the results.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskListBuildsSettings SetTop(this AzureAcrBuildTaskListBuildsSettings toolSettings, string top)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = top;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskListBuildsSettings.Top"/>.</em></p><p>Limit the number of latest builds in the results.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskListBuildsSettings ResetTop(this AzureAcrBuildTaskListBuildsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskListBuildsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskListBuildsSettings SetDebug(this AzureAcrBuildTaskListBuildsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskListBuildsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskListBuildsSettings ResetDebug(this AzureAcrBuildTaskListBuildsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskListBuildsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskListBuildsSettings SetHelp(this AzureAcrBuildTaskListBuildsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskListBuildsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskListBuildsSettings ResetHelp(this AzureAcrBuildTaskListBuildsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskListBuildsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskListBuildsSettings SetOutput(this AzureAcrBuildTaskListBuildsSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskListBuildsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskListBuildsSettings ResetOutput(this AzureAcrBuildTaskListBuildsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskListBuildsSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskListBuildsSettings SetQuery(this AzureAcrBuildTaskListBuildsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskListBuildsSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskListBuildsSettings ResetQuery(this AzureAcrBuildTaskListBuildsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskListBuildsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskListBuildsSettings SetVerbose(this AzureAcrBuildTaskListBuildsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskListBuildsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskListBuildsSettings ResetVerbose(this AzureAcrBuildTaskListBuildsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcrBuildTaskLogsSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcrBuildTaskLogsSettingsExtensions
    {
        #region Registry
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskLogsSettings.Registry"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskLogsSettings SetRegistry(this AzureAcrBuildTaskLogsSettings toolSettings, string registry)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Registry = registry;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskLogsSettings.Registry"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskLogsSettings ResetRegistry(this AzureAcrBuildTaskLogsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Registry = null;
            return toolSettings;
        }
        #endregion
        #region BuildId
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskLogsSettings.BuildId"/>.</em></p><p>The unique build identifier.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskLogsSettings SetBuildId(this AzureAcrBuildTaskLogsSettings toolSettings, string buildId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BuildId = buildId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskLogsSettings.BuildId"/>.</em></p><p>The unique build identifier.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskLogsSettings ResetBuildId(this AzureAcrBuildTaskLogsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BuildId = null;
            return toolSettings;
        }
        #endregion
        #region Image
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskLogsSettings.Image"/>.</em></p><p>The name of the image. May include a tag in the format 'name:tag' or digest in the format 'name@digest'.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskLogsSettings SetImage(this AzureAcrBuildTaskLogsSettings toolSettings, string image)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Image = image;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskLogsSettings.Image"/>.</em></p><p>The name of the image. May include a tag in the format 'name:tag' or digest in the format 'name@digest'.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskLogsSettings ResetImage(this AzureAcrBuildTaskLogsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Image = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskLogsSettings.Name"/>.</em></p><p>The name of the build task.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskLogsSettings SetName(this AzureAcrBuildTaskLogsSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskLogsSettings.Name"/>.</em></p><p>The name of the build task.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskLogsSettings ResetName(this AzureAcrBuildTaskLogsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskLogsSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskLogsSettings SetResourceGroup(this AzureAcrBuildTaskLogsSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskLogsSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskLogsSettings ResetResourceGroup(this AzureAcrBuildTaskLogsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskLogsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskLogsSettings SetDebug(this AzureAcrBuildTaskLogsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskLogsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskLogsSettings ResetDebug(this AzureAcrBuildTaskLogsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskLogsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskLogsSettings SetHelp(this AzureAcrBuildTaskLogsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskLogsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskLogsSettings ResetHelp(this AzureAcrBuildTaskLogsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskLogsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskLogsSettings SetOutput(this AzureAcrBuildTaskLogsSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskLogsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskLogsSettings ResetOutput(this AzureAcrBuildTaskLogsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskLogsSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskLogsSettings SetQuery(this AzureAcrBuildTaskLogsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskLogsSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskLogsSettings ResetQuery(this AzureAcrBuildTaskLogsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskLogsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskLogsSettings SetVerbose(this AzureAcrBuildTaskLogsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskLogsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskLogsSettings ResetVerbose(this AzureAcrBuildTaskLogsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcrBuildTaskRunSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcrBuildTaskRunSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskRunSettings.Name"/>.</em></p><p>The name of the build task.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskRunSettings SetName(this AzureAcrBuildTaskRunSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskRunSettings.Name"/>.</em></p><p>The name of the build task.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskRunSettings ResetName(this AzureAcrBuildTaskRunSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Registry
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskRunSettings.Registry"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskRunSettings SetRegistry(this AzureAcrBuildTaskRunSettings toolSettings, string registry)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Registry = registry;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskRunSettings.Registry"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskRunSettings ResetRegistry(this AzureAcrBuildTaskRunSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Registry = null;
            return toolSettings;
        }
        #endregion
        #region NoLogs
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskRunSettings.NoLogs"/>.</em></p><p>Do not show logs after successfully queuing the build.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskRunSettings SetNoLogs(this AzureAcrBuildTaskRunSettings toolSettings, bool? noLogs)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoLogs = noLogs;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskRunSettings.NoLogs"/>.</em></p><p>Do not show logs after successfully queuing the build.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskRunSettings ResetNoLogs(this AzureAcrBuildTaskRunSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoLogs = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureAcrBuildTaskRunSettings.NoLogs"/>.</em></p><p>Do not show logs after successfully queuing the build.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskRunSettings EnableNoLogs(this AzureAcrBuildTaskRunSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoLogs = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureAcrBuildTaskRunSettings.NoLogs"/>.</em></p><p>Do not show logs after successfully queuing the build.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskRunSettings DisableNoLogs(this AzureAcrBuildTaskRunSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoLogs = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureAcrBuildTaskRunSettings.NoLogs"/>.</em></p><p>Do not show logs after successfully queuing the build.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskRunSettings ToggleNoLogs(this AzureAcrBuildTaskRunSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoLogs = !toolSettings.NoLogs;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskRunSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskRunSettings SetResourceGroup(this AzureAcrBuildTaskRunSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskRunSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskRunSettings ResetResourceGroup(this AzureAcrBuildTaskRunSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskRunSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskRunSettings SetDebug(this AzureAcrBuildTaskRunSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskRunSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskRunSettings ResetDebug(this AzureAcrBuildTaskRunSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskRunSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskRunSettings SetHelp(this AzureAcrBuildTaskRunSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskRunSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskRunSettings ResetHelp(this AzureAcrBuildTaskRunSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskRunSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskRunSettings SetOutput(this AzureAcrBuildTaskRunSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskRunSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskRunSettings ResetOutput(this AzureAcrBuildTaskRunSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskRunSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskRunSettings SetQuery(this AzureAcrBuildTaskRunSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskRunSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskRunSettings ResetQuery(this AzureAcrBuildTaskRunSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskRunSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskRunSettings SetVerbose(this AzureAcrBuildTaskRunSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskRunSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskRunSettings ResetVerbose(this AzureAcrBuildTaskRunSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcrBuildTaskShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcrBuildTaskShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskShowSettings.Name"/>.</em></p><p>The name of the build task.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskShowSettings SetName(this AzureAcrBuildTaskShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskShowSettings.Name"/>.</em></p><p>The name of the build task.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskShowSettings ResetName(this AzureAcrBuildTaskShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Registry
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskShowSettings.Registry"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskShowSettings SetRegistry(this AzureAcrBuildTaskShowSettings toolSettings, string registry)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Registry = registry;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskShowSettings.Registry"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskShowSettings ResetRegistry(this AzureAcrBuildTaskShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Registry = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskShowSettings SetResourceGroup(this AzureAcrBuildTaskShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskShowSettings ResetResourceGroup(this AzureAcrBuildTaskShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region WithSecureProperties
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskShowSettings.WithSecureProperties"/>.</em></p><p>Indicates whether the secure properties of a build task should be returned.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskShowSettings SetWithSecureProperties(this AzureAcrBuildTaskShowSettings toolSettings, string withSecureProperties)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WithSecureProperties = withSecureProperties;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskShowSettings.WithSecureProperties"/>.</em></p><p>Indicates whether the secure properties of a build task should be returned.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskShowSettings ResetWithSecureProperties(this AzureAcrBuildTaskShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WithSecureProperties = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskShowSettings SetDebug(this AzureAcrBuildTaskShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskShowSettings ResetDebug(this AzureAcrBuildTaskShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskShowSettings SetHelp(this AzureAcrBuildTaskShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskShowSettings ResetHelp(this AzureAcrBuildTaskShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskShowSettings SetOutput(this AzureAcrBuildTaskShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskShowSettings ResetOutput(this AzureAcrBuildTaskShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskShowSettings SetQuery(this AzureAcrBuildTaskShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskShowSettings ResetQuery(this AzureAcrBuildTaskShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskShowSettings SetVerbose(this AzureAcrBuildTaskShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskShowSettings ResetVerbose(this AzureAcrBuildTaskShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcrBuildTaskShowBuildSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcrBuildTaskShowBuildSettingsExtensions
    {
        #region BuildId
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskShowBuildSettings.BuildId"/>.</em></p><p>The unique build identifier.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskShowBuildSettings SetBuildId(this AzureAcrBuildTaskShowBuildSettings toolSettings, string buildId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BuildId = buildId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskShowBuildSettings.BuildId"/>.</em></p><p>The unique build identifier.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskShowBuildSettings ResetBuildId(this AzureAcrBuildTaskShowBuildSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BuildId = null;
            return toolSettings;
        }
        #endregion
        #region Registry
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskShowBuildSettings.Registry"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskShowBuildSettings SetRegistry(this AzureAcrBuildTaskShowBuildSettings toolSettings, string registry)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Registry = registry;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskShowBuildSettings.Registry"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskShowBuildSettings ResetRegistry(this AzureAcrBuildTaskShowBuildSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Registry = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskShowBuildSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskShowBuildSettings SetResourceGroup(this AzureAcrBuildTaskShowBuildSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskShowBuildSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskShowBuildSettings ResetResourceGroup(this AzureAcrBuildTaskShowBuildSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskShowBuildSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskShowBuildSettings SetDebug(this AzureAcrBuildTaskShowBuildSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskShowBuildSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskShowBuildSettings ResetDebug(this AzureAcrBuildTaskShowBuildSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskShowBuildSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskShowBuildSettings SetHelp(this AzureAcrBuildTaskShowBuildSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskShowBuildSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskShowBuildSettings ResetHelp(this AzureAcrBuildTaskShowBuildSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskShowBuildSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskShowBuildSettings SetOutput(this AzureAcrBuildTaskShowBuildSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskShowBuildSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskShowBuildSettings ResetOutput(this AzureAcrBuildTaskShowBuildSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskShowBuildSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskShowBuildSettings SetQuery(this AzureAcrBuildTaskShowBuildSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskShowBuildSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskShowBuildSettings ResetQuery(this AzureAcrBuildTaskShowBuildSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskShowBuildSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskShowBuildSettings SetVerbose(this AzureAcrBuildTaskShowBuildSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskShowBuildSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskShowBuildSettings ResetVerbose(this AzureAcrBuildTaskShowBuildSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcrBuildTaskUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcrBuildTaskUpdateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskUpdateSettings.Name"/>.</em></p><p>The name of the build task.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskUpdateSettings SetName(this AzureAcrBuildTaskUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskUpdateSettings.Name"/>.</em></p><p>The name of the build task.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskUpdateSettings ResetName(this AzureAcrBuildTaskUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Registry
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskUpdateSettings.Registry"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskUpdateSettings SetRegistry(this AzureAcrBuildTaskUpdateSettings toolSettings, string registry)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Registry = registry;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskUpdateSettings.Registry"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskUpdateSettings ResetRegistry(this AzureAcrBuildTaskUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Registry = null;
            return toolSettings;
        }
        #endregion
        #region Alias
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskUpdateSettings.Alias"/>.</em></p><p>The alternative name for build task. Default to the build task name.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskUpdateSettings SetAlias(this AzureAcrBuildTaskUpdateSettings toolSettings, string alias)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Alias = alias;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskUpdateSettings.Alias"/>.</em></p><p>The alternative name for build task. Default to the build task name.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskUpdateSettings ResetAlias(this AzureAcrBuildTaskUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Alias = null;
            return toolSettings;
        }
        #endregion
        #region BaseImageTrigger
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskUpdateSettings.BaseImageTrigger"/>.</em></p><p>The type of the auto trigger for base image dependency updates.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskUpdateSettings SetBaseImageTrigger(this AzureAcrBuildTaskUpdateSettings toolSettings, AcrBuildTaskBaseImageTrigger baseImageTrigger)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BaseImageTrigger = baseImageTrigger;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskUpdateSettings.BaseImageTrigger"/>.</em></p><p>The type of the auto trigger for base image dependency updates.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskUpdateSettings ResetBaseImageTrigger(this AzureAcrBuildTaskUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BaseImageTrigger = null;
            return toolSettings;
        }
        #endregion
        #region Branch
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskUpdateSettings.Branch"/>.</em></p><p>The source control branch name.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskUpdateSettings SetBranch(this AzureAcrBuildTaskUpdateSettings toolSettings, string branch)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Branch = branch;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskUpdateSettings.Branch"/>.</em></p><p>The source control branch name.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskUpdateSettings ResetBranch(this AzureAcrBuildTaskUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Branch = null;
            return toolSettings;
        }
        #endregion
        #region BuildArg
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskUpdateSettings.BuildArg"/>.</em></p><p>Build argument in 'name[=value]' format.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskUpdateSettings SetBuildArg(this AzureAcrBuildTaskUpdateSettings toolSettings, string buildArg)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BuildArg = buildArg;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskUpdateSettings.BuildArg"/>.</em></p><p>Build argument in 'name[=value]' format.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskUpdateSettings ResetBuildArg(this AzureAcrBuildTaskUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BuildArg = null;
            return toolSettings;
        }
        #endregion
        #region CommitTriggerEnabled
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskUpdateSettings.CommitTriggerEnabled"/>.</em></p><p>Indicates whether the source control commit trigger is enabled.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskUpdateSettings SetCommitTriggerEnabled(this AzureAcrBuildTaskUpdateSettings toolSettings, bool? commitTriggerEnabled)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CommitTriggerEnabled = commitTriggerEnabled;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskUpdateSettings.CommitTriggerEnabled"/>.</em></p><p>Indicates whether the source control commit trigger is enabled.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskUpdateSettings ResetCommitTriggerEnabled(this AzureAcrBuildTaskUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CommitTriggerEnabled = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureAcrBuildTaskUpdateSettings.CommitTriggerEnabled"/>.</em></p><p>Indicates whether the source control commit trigger is enabled.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskUpdateSettings EnableCommitTriggerEnabled(this AzureAcrBuildTaskUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CommitTriggerEnabled = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureAcrBuildTaskUpdateSettings.CommitTriggerEnabled"/>.</em></p><p>Indicates whether the source control commit trigger is enabled.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskUpdateSettings DisableCommitTriggerEnabled(this AzureAcrBuildTaskUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CommitTriggerEnabled = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureAcrBuildTaskUpdateSettings.CommitTriggerEnabled"/>.</em></p><p>Indicates whether the source control commit trigger is enabled.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskUpdateSettings ToggleCommitTriggerEnabled(this AzureAcrBuildTaskUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CommitTriggerEnabled = !toolSettings.CommitTriggerEnabled;
            return toolSettings;
        }
        #endregion
        #region Context
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskUpdateSettings.Context"/>.</em></p><p>The full URL to the source code respository.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskUpdateSettings SetContext(this AzureAcrBuildTaskUpdateSettings toolSettings, string context)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Context = context;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskUpdateSettings.Context"/>.</em></p><p>The full URL to the source code respository.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskUpdateSettings ResetContext(this AzureAcrBuildTaskUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Context = null;
            return toolSettings;
        }
        #endregion
        #region Cpu
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskUpdateSettings.Cpu"/>.</em></p><p>The CPU configuration in terms of number of cores required for the build.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskUpdateSettings SetCpu(this AzureAcrBuildTaskUpdateSettings toolSettings, string cpu)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cpu = cpu;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskUpdateSettings.Cpu"/>.</em></p><p>The CPU configuration in terms of number of cores required for the build.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskUpdateSettings ResetCpu(this AzureAcrBuildTaskUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cpu = null;
            return toolSettings;
        }
        #endregion
        #region File
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskUpdateSettings.File"/>.</em></p><p>The relative path of the the docker file to the source code root folder.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskUpdateSettings SetFile(this AzureAcrBuildTaskUpdateSettings toolSettings, string file)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.File = file;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskUpdateSettings.File"/>.</em></p><p>The relative path of the the docker file to the source code root folder.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskUpdateSettings ResetFile(this AzureAcrBuildTaskUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.File = null;
            return toolSettings;
        }
        #endregion
        #region GitAccessToken
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskUpdateSettings.GitAccessToken"/>.</em></p><p>The access token used to access the source control provider.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskUpdateSettings SetGitAccessToken(this AzureAcrBuildTaskUpdateSettings toolSettings, string gitAccessToken)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GitAccessToken = gitAccessToken;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskUpdateSettings.GitAccessToken"/>.</em></p><p>The access token used to access the source control provider.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskUpdateSettings ResetGitAccessToken(this AzureAcrBuildTaskUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GitAccessToken = null;
            return toolSettings;
        }
        #endregion
        #region Image
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskUpdateSettings.Image"/>.</em></p><p>The name of the image. May include a tag in the format 'name:tag'.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskUpdateSettings SetImage(this AzureAcrBuildTaskUpdateSettings toolSettings, string image)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Image = image;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskUpdateSettings.Image"/>.</em></p><p>The name of the image. May include a tag in the format 'name:tag'.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskUpdateSettings ResetImage(this AzureAcrBuildTaskUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Image = null;
            return toolSettings;
        }
        #endregion
        #region NoCache
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskUpdateSettings.NoCache"/>.</em></p><p>Indicates whether the image cache is enabled.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskUpdateSettings SetNoCache(this AzureAcrBuildTaskUpdateSettings toolSettings, bool? noCache)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoCache = noCache;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskUpdateSettings.NoCache"/>.</em></p><p>Indicates whether the image cache is enabled.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskUpdateSettings ResetNoCache(this AzureAcrBuildTaskUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoCache = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureAcrBuildTaskUpdateSettings.NoCache"/>.</em></p><p>Indicates whether the image cache is enabled.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskUpdateSettings EnableNoCache(this AzureAcrBuildTaskUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoCache = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureAcrBuildTaskUpdateSettings.NoCache"/>.</em></p><p>Indicates whether the image cache is enabled.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskUpdateSettings DisableNoCache(this AzureAcrBuildTaskUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoCache = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureAcrBuildTaskUpdateSettings.NoCache"/>.</em></p><p>Indicates whether the image cache is enabled.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskUpdateSettings ToggleNoCache(this AzureAcrBuildTaskUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoCache = !toolSettings.NoCache;
            return toolSettings;
        }
        #endregion
        #region NoPush
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskUpdateSettings.NoPush"/>.</em></p><p>Indicates whether the image built should be pushed to the registry.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskUpdateSettings SetNoPush(this AzureAcrBuildTaskUpdateSettings toolSettings, bool? noPush)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoPush = noPush;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskUpdateSettings.NoPush"/>.</em></p><p>Indicates whether the image built should be pushed to the registry.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskUpdateSettings ResetNoPush(this AzureAcrBuildTaskUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoPush = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureAcrBuildTaskUpdateSettings.NoPush"/>.</em></p><p>Indicates whether the image built should be pushed to the registry.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskUpdateSettings EnableNoPush(this AzureAcrBuildTaskUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoPush = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureAcrBuildTaskUpdateSettings.NoPush"/>.</em></p><p>Indicates whether the image built should be pushed to the registry.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskUpdateSettings DisableNoPush(this AzureAcrBuildTaskUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoPush = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureAcrBuildTaskUpdateSettings.NoPush"/>.</em></p><p>Indicates whether the image built should be pushed to the registry.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskUpdateSettings ToggleNoPush(this AzureAcrBuildTaskUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoPush = !toolSettings.NoPush;
            return toolSettings;
        }
        #endregion
        #region Os
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskUpdateSettings.Os"/>.</em></p><p>The operating system type required for the build.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskUpdateSettings SetOs(this AzureAcrBuildTaskUpdateSettings toolSettings, AcrOs os)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Os = os;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskUpdateSettings.Os"/>.</em></p><p>The operating system type required for the build.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskUpdateSettings ResetOs(this AzureAcrBuildTaskUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Os = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskUpdateSettings SetResourceGroup(this AzureAcrBuildTaskUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskUpdateSettings ResetResourceGroup(this AzureAcrBuildTaskUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region SecretBuildArg
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskUpdateSettings.SecretBuildArg"/>.</em></p><p>Secret build argument in 'name[=value]' format.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskUpdateSettings SetSecretBuildArg(this AzureAcrBuildTaskUpdateSettings toolSettings, string secretBuildArg)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SecretBuildArg = secretBuildArg;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskUpdateSettings.SecretBuildArg"/>.</em></p><p>Secret build argument in 'name[=value]' format.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskUpdateSettings ResetSecretBuildArg(this AzureAcrBuildTaskUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SecretBuildArg = null;
            return toolSettings;
        }
        #endregion
        #region Status
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskUpdateSettings.Status"/>.</em></p><p>The current status of build task.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskUpdateSettings SetStatus(this AzureAcrBuildTaskUpdateSettings toolSettings, AcrBuildTaskStatus status)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Status = status;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskUpdateSettings.Status"/>.</em></p><p>The current status of build task.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskUpdateSettings ResetStatus(this AzureAcrBuildTaskUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Status = null;
            return toolSettings;
        }
        #endregion
        #region Timeout
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskUpdateSettings.Timeout"/>.</em></p><p>The build timeout in seconds.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskUpdateSettings SetTimeout(this AzureAcrBuildTaskUpdateSettings toolSettings, string timeout)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Timeout = timeout;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskUpdateSettings.Timeout"/>.</em></p><p>The build timeout in seconds.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskUpdateSettings ResetTimeout(this AzureAcrBuildTaskUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Timeout = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskUpdateSettings SetDebug(this AzureAcrBuildTaskUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskUpdateSettings ResetDebug(this AzureAcrBuildTaskUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskUpdateSettings SetHelp(this AzureAcrBuildTaskUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskUpdateSettings ResetHelp(this AzureAcrBuildTaskUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskUpdateSettings SetOutput(this AzureAcrBuildTaskUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskUpdateSettings ResetOutput(this AzureAcrBuildTaskUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskUpdateSettings SetQuery(this AzureAcrBuildTaskUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskUpdateSettings ResetQuery(this AzureAcrBuildTaskUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskUpdateSettings SetVerbose(this AzureAcrBuildTaskUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskUpdateSettings ResetVerbose(this AzureAcrBuildTaskUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcrBuildTaskUpdateBuildSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcrBuildTaskUpdateBuildSettingsExtensions
    {
        #region BuildId
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskUpdateBuildSettings.BuildId"/>.</em></p><p>The unique build identifier.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskUpdateBuildSettings SetBuildId(this AzureAcrBuildTaskUpdateBuildSettings toolSettings, string buildId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BuildId = buildId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskUpdateBuildSettings.BuildId"/>.</em></p><p>The unique build identifier.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskUpdateBuildSettings ResetBuildId(this AzureAcrBuildTaskUpdateBuildSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BuildId = null;
            return toolSettings;
        }
        #endregion
        #region Registry
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskUpdateBuildSettings.Registry"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskUpdateBuildSettings SetRegistry(this AzureAcrBuildTaskUpdateBuildSettings toolSettings, string registry)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Registry = registry;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskUpdateBuildSettings.Registry"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskUpdateBuildSettings ResetRegistry(this AzureAcrBuildTaskUpdateBuildSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Registry = null;
            return toolSettings;
        }
        #endregion
        #region NoArchive
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskUpdateBuildSettings.NoArchive"/>.</em></p><p>Indicates whether the build should be archived.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskUpdateBuildSettings SetNoArchive(this AzureAcrBuildTaskUpdateBuildSettings toolSettings, bool? noArchive)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoArchive = noArchive;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskUpdateBuildSettings.NoArchive"/>.</em></p><p>Indicates whether the build should be archived.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskUpdateBuildSettings ResetNoArchive(this AzureAcrBuildTaskUpdateBuildSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoArchive = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureAcrBuildTaskUpdateBuildSettings.NoArchive"/>.</em></p><p>Indicates whether the build should be archived.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskUpdateBuildSettings EnableNoArchive(this AzureAcrBuildTaskUpdateBuildSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoArchive = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureAcrBuildTaskUpdateBuildSettings.NoArchive"/>.</em></p><p>Indicates whether the build should be archived.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskUpdateBuildSettings DisableNoArchive(this AzureAcrBuildTaskUpdateBuildSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoArchive = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureAcrBuildTaskUpdateBuildSettings.NoArchive"/>.</em></p><p>Indicates whether the build should be archived.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskUpdateBuildSettings ToggleNoArchive(this AzureAcrBuildTaskUpdateBuildSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoArchive = !toolSettings.NoArchive;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskUpdateBuildSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskUpdateBuildSettings SetResourceGroup(this AzureAcrBuildTaskUpdateBuildSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskUpdateBuildSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskUpdateBuildSettings ResetResourceGroup(this AzureAcrBuildTaskUpdateBuildSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskUpdateBuildSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskUpdateBuildSettings SetDebug(this AzureAcrBuildTaskUpdateBuildSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskUpdateBuildSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskUpdateBuildSettings ResetDebug(this AzureAcrBuildTaskUpdateBuildSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskUpdateBuildSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskUpdateBuildSettings SetHelp(this AzureAcrBuildTaskUpdateBuildSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskUpdateBuildSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskUpdateBuildSettings ResetHelp(this AzureAcrBuildTaskUpdateBuildSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskUpdateBuildSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskUpdateBuildSettings SetOutput(this AzureAcrBuildTaskUpdateBuildSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskUpdateBuildSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskUpdateBuildSettings ResetOutput(this AzureAcrBuildTaskUpdateBuildSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskUpdateBuildSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskUpdateBuildSettings SetQuery(this AzureAcrBuildTaskUpdateBuildSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskUpdateBuildSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskUpdateBuildSettings ResetQuery(this AzureAcrBuildTaskUpdateBuildSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcrBuildTaskUpdateBuildSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskUpdateBuildSettings SetVerbose(this AzureAcrBuildTaskUpdateBuildSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrBuildTaskUpdateBuildSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrBuildTaskUpdateBuildSettings ResetVerbose(this AzureAcrBuildTaskUpdateBuildSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcrConfigSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcrConfigSettingsExtensions
    {
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcrConfigSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrConfigSettings SetDebug(this AzureAcrConfigSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrConfigSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrConfigSettings ResetDebug(this AzureAcrConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcrConfigSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrConfigSettings SetHelp(this AzureAcrConfigSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrConfigSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrConfigSettings ResetHelp(this AzureAcrConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcrConfigSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrConfigSettings SetOutput(this AzureAcrConfigSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrConfigSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrConfigSettings ResetOutput(this AzureAcrConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcrConfigSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrConfigSettings SetQuery(this AzureAcrConfigSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrConfigSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrConfigSettings ResetQuery(this AzureAcrConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcrConfigSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrConfigSettings SetVerbose(this AzureAcrConfigSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrConfigSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrConfigSettings ResetVerbose(this AzureAcrConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcrCredentialRenewSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcrCredentialRenewSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAcrCredentialRenewSettings.Name"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrCredentialRenewSettings SetName(this AzureAcrCredentialRenewSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrCredentialRenewSettings.Name"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrCredentialRenewSettings ResetName(this AzureAcrCredentialRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region PasswordName
        /// <summary><p><em>Sets <see cref="AzureAcrCredentialRenewSettings.PasswordName"/>.</em></p><p>The name of password to regenerate.</p></summary>
        [Pure]
        public static AzureAcrCredentialRenewSettings SetPasswordName(this AzureAcrCredentialRenewSettings toolSettings, AcrCredentialRenewPasswordName passwordName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PasswordName = passwordName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrCredentialRenewSettings.PasswordName"/>.</em></p><p>The name of password to regenerate.</p></summary>
        [Pure]
        public static AzureAcrCredentialRenewSettings ResetPasswordName(this AzureAcrCredentialRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PasswordName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAcrCredentialRenewSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrCredentialRenewSettings SetResourceGroup(this AzureAcrCredentialRenewSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrCredentialRenewSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrCredentialRenewSettings ResetResourceGroup(this AzureAcrCredentialRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcrCredentialRenewSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrCredentialRenewSettings SetDebug(this AzureAcrCredentialRenewSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrCredentialRenewSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrCredentialRenewSettings ResetDebug(this AzureAcrCredentialRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcrCredentialRenewSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrCredentialRenewSettings SetHelp(this AzureAcrCredentialRenewSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrCredentialRenewSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrCredentialRenewSettings ResetHelp(this AzureAcrCredentialRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcrCredentialRenewSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrCredentialRenewSettings SetOutput(this AzureAcrCredentialRenewSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrCredentialRenewSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrCredentialRenewSettings ResetOutput(this AzureAcrCredentialRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcrCredentialRenewSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrCredentialRenewSettings SetQuery(this AzureAcrCredentialRenewSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrCredentialRenewSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrCredentialRenewSettings ResetQuery(this AzureAcrCredentialRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcrCredentialRenewSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrCredentialRenewSettings SetVerbose(this AzureAcrCredentialRenewSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrCredentialRenewSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrCredentialRenewSettings ResetVerbose(this AzureAcrCredentialRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcrCredentialShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcrCredentialShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAcrCredentialShowSettings.Name"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrCredentialShowSettings SetName(this AzureAcrCredentialShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrCredentialShowSettings.Name"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrCredentialShowSettings ResetName(this AzureAcrCredentialShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAcrCredentialShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrCredentialShowSettings SetResourceGroup(this AzureAcrCredentialShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrCredentialShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrCredentialShowSettings ResetResourceGroup(this AzureAcrCredentialShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcrCredentialShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrCredentialShowSettings SetDebug(this AzureAcrCredentialShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrCredentialShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrCredentialShowSettings ResetDebug(this AzureAcrCredentialShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcrCredentialShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrCredentialShowSettings SetHelp(this AzureAcrCredentialShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrCredentialShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrCredentialShowSettings ResetHelp(this AzureAcrCredentialShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcrCredentialShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrCredentialShowSettings SetOutput(this AzureAcrCredentialShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrCredentialShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrCredentialShowSettings ResetOutput(this AzureAcrCredentialShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcrCredentialShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrCredentialShowSettings SetQuery(this AzureAcrCredentialShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrCredentialShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrCredentialShowSettings ResetQuery(this AzureAcrCredentialShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcrCredentialShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrCredentialShowSettings SetVerbose(this AzureAcrCredentialShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrCredentialShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrCredentialShowSettings ResetVerbose(this AzureAcrCredentialShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcrReplicationCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcrReplicationCreateSettingsExtensions
    {
        #region Location
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationCreateSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrReplicationCreateSettings SetLocation(this AzureAcrReplicationCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationCreateSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrReplicationCreateSettings ResetLocation(this AzureAcrReplicationCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region Registry
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationCreateSettings.Registry"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrReplicationCreateSettings SetRegistry(this AzureAcrReplicationCreateSettings toolSettings, string registry)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Registry = registry;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationCreateSettings.Registry"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrReplicationCreateSettings ResetRegistry(this AzureAcrReplicationCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Registry = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationCreateSettings.Name"/>.</em></p><p>The name of the replication. Default to the location name.</p></summary>
        [Pure]
        public static AzureAcrReplicationCreateSettings SetName(this AzureAcrReplicationCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationCreateSettings.Name"/>.</em></p><p>The name of the replication. Default to the location name.</p></summary>
        [Pure]
        public static AzureAcrReplicationCreateSettings ResetName(this AzureAcrReplicationCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrReplicationCreateSettings SetResourceGroup(this AzureAcrReplicationCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrReplicationCreateSettings ResetResourceGroup(this AzureAcrReplicationCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationCreateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureAcrReplicationCreateSettings SetTags(this AzureAcrReplicationCreateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationCreateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureAcrReplicationCreateSettings ResetTags(this AzureAcrReplicationCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrReplicationCreateSettings SetDebug(this AzureAcrReplicationCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrReplicationCreateSettings ResetDebug(this AzureAcrReplicationCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrReplicationCreateSettings SetHelp(this AzureAcrReplicationCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrReplicationCreateSettings ResetHelp(this AzureAcrReplicationCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrReplicationCreateSettings SetOutput(this AzureAcrReplicationCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrReplicationCreateSettings ResetOutput(this AzureAcrReplicationCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrReplicationCreateSettings SetQuery(this AzureAcrReplicationCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrReplicationCreateSettings ResetQuery(this AzureAcrReplicationCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrReplicationCreateSettings SetVerbose(this AzureAcrReplicationCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrReplicationCreateSettings ResetVerbose(this AzureAcrReplicationCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcrReplicationDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcrReplicationDeleteSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationDeleteSettings.Name"/>.</em></p><p>The name of the replication.</p></summary>
        [Pure]
        public static AzureAcrReplicationDeleteSettings SetName(this AzureAcrReplicationDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationDeleteSettings.Name"/>.</em></p><p>The name of the replication.</p></summary>
        [Pure]
        public static AzureAcrReplicationDeleteSettings ResetName(this AzureAcrReplicationDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Registry
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationDeleteSettings.Registry"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrReplicationDeleteSettings SetRegistry(this AzureAcrReplicationDeleteSettings toolSettings, string registry)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Registry = registry;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationDeleteSettings.Registry"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrReplicationDeleteSettings ResetRegistry(this AzureAcrReplicationDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Registry = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrReplicationDeleteSettings SetResourceGroup(this AzureAcrReplicationDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrReplicationDeleteSettings ResetResourceGroup(this AzureAcrReplicationDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrReplicationDeleteSettings SetDebug(this AzureAcrReplicationDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrReplicationDeleteSettings ResetDebug(this AzureAcrReplicationDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrReplicationDeleteSettings SetHelp(this AzureAcrReplicationDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrReplicationDeleteSettings ResetHelp(this AzureAcrReplicationDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrReplicationDeleteSettings SetOutput(this AzureAcrReplicationDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrReplicationDeleteSettings ResetOutput(this AzureAcrReplicationDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrReplicationDeleteSettings SetQuery(this AzureAcrReplicationDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrReplicationDeleteSettings ResetQuery(this AzureAcrReplicationDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrReplicationDeleteSettings SetVerbose(this AzureAcrReplicationDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrReplicationDeleteSettings ResetVerbose(this AzureAcrReplicationDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcrReplicationListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcrReplicationListSettingsExtensions
    {
        #region Registry
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationListSettings.Registry"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrReplicationListSettings SetRegistry(this AzureAcrReplicationListSettings toolSettings, string registry)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Registry = registry;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationListSettings.Registry"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrReplicationListSettings ResetRegistry(this AzureAcrReplicationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Registry = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrReplicationListSettings SetResourceGroup(this AzureAcrReplicationListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrReplicationListSettings ResetResourceGroup(this AzureAcrReplicationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrReplicationListSettings SetDebug(this AzureAcrReplicationListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrReplicationListSettings ResetDebug(this AzureAcrReplicationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrReplicationListSettings SetHelp(this AzureAcrReplicationListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrReplicationListSettings ResetHelp(this AzureAcrReplicationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrReplicationListSettings SetOutput(this AzureAcrReplicationListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrReplicationListSettings ResetOutput(this AzureAcrReplicationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrReplicationListSettings SetQuery(this AzureAcrReplicationListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrReplicationListSettings ResetQuery(this AzureAcrReplicationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrReplicationListSettings SetVerbose(this AzureAcrReplicationListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrReplicationListSettings ResetVerbose(this AzureAcrReplicationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcrReplicationShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcrReplicationShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationShowSettings.Name"/>.</em></p><p>The name of the replication.</p></summary>
        [Pure]
        public static AzureAcrReplicationShowSettings SetName(this AzureAcrReplicationShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationShowSettings.Name"/>.</em></p><p>The name of the replication.</p></summary>
        [Pure]
        public static AzureAcrReplicationShowSettings ResetName(this AzureAcrReplicationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Registry
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationShowSettings.Registry"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrReplicationShowSettings SetRegistry(this AzureAcrReplicationShowSettings toolSettings, string registry)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Registry = registry;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationShowSettings.Registry"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrReplicationShowSettings ResetRegistry(this AzureAcrReplicationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Registry = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrReplicationShowSettings SetResourceGroup(this AzureAcrReplicationShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrReplicationShowSettings ResetResourceGroup(this AzureAcrReplicationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrReplicationShowSettings SetDebug(this AzureAcrReplicationShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrReplicationShowSettings ResetDebug(this AzureAcrReplicationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrReplicationShowSettings SetHelp(this AzureAcrReplicationShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrReplicationShowSettings ResetHelp(this AzureAcrReplicationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrReplicationShowSettings SetOutput(this AzureAcrReplicationShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrReplicationShowSettings ResetOutput(this AzureAcrReplicationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrReplicationShowSettings SetQuery(this AzureAcrReplicationShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrReplicationShowSettings ResetQuery(this AzureAcrReplicationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrReplicationShowSettings SetVerbose(this AzureAcrReplicationShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrReplicationShowSettings ResetVerbose(this AzureAcrReplicationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcrReplicationUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcrReplicationUpdateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationUpdateSettings.Name"/>.</em></p><p>The name of the replication.</p></summary>
        [Pure]
        public static AzureAcrReplicationUpdateSettings SetName(this AzureAcrReplicationUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationUpdateSettings.Name"/>.</em></p><p>The name of the replication.</p></summary>
        [Pure]
        public static AzureAcrReplicationUpdateSettings ResetName(this AzureAcrReplicationUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Registry
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationUpdateSettings.Registry"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrReplicationUpdateSettings SetRegistry(this AzureAcrReplicationUpdateSettings toolSettings, string registry)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Registry = registry;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationUpdateSettings.Registry"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrReplicationUpdateSettings ResetRegistry(this AzureAcrReplicationUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Registry = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrReplicationUpdateSettings SetResourceGroup(this AzureAcrReplicationUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrReplicationUpdateSettings ResetResourceGroup(this AzureAcrReplicationUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationUpdateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureAcrReplicationUpdateSettings SetTags(this AzureAcrReplicationUpdateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationUpdateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureAcrReplicationUpdateSettings ResetTags(this AzureAcrReplicationUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureAcrReplicationUpdateSettings SetAdd(this AzureAcrReplicationUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureAcrReplicationUpdateSettings ResetAdd(this AzureAcrReplicationUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region ForceString
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationUpdateSettings.ForceString"/>.</em></p><p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p></summary>
        [Pure]
        public static AzureAcrReplicationUpdateSettings SetForceString(this AzureAcrReplicationUpdateSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationUpdateSettings.ForceString"/>.</em></p><p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p></summary>
        [Pure]
        public static AzureAcrReplicationUpdateSettings ResetForceString(this AzureAcrReplicationUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureAcrReplicationUpdateSettings SetRemove(this AzureAcrReplicationUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureAcrReplicationUpdateSettings ResetRemove(this AzureAcrReplicationUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureAcrReplicationUpdateSettings SetSet(this AzureAcrReplicationUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureAcrReplicationUpdateSettings ResetSet(this AzureAcrReplicationUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrReplicationUpdateSettings SetDebug(this AzureAcrReplicationUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrReplicationUpdateSettings ResetDebug(this AzureAcrReplicationUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrReplicationUpdateSettings SetHelp(this AzureAcrReplicationUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrReplicationUpdateSettings ResetHelp(this AzureAcrReplicationUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrReplicationUpdateSettings SetOutput(this AzureAcrReplicationUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrReplicationUpdateSettings ResetOutput(this AzureAcrReplicationUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrReplicationUpdateSettings SetQuery(this AzureAcrReplicationUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrReplicationUpdateSettings ResetQuery(this AzureAcrReplicationUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrReplicationUpdateSettings SetVerbose(this AzureAcrReplicationUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrReplicationUpdateSettings ResetVerbose(this AzureAcrReplicationUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcrRepositoryDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcrRepositoryDeleteSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryDeleteSettings.Name"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrRepositoryDeleteSettings SetName(this AzureAcrRepositoryDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryDeleteSettings.Name"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrRepositoryDeleteSettings ResetName(this AzureAcrRepositoryDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Image
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryDeleteSettings.Image"/>.</em></p><p>The name of the image. May include a tag in the format 'name:tag' or digest in the format 'name@digest'.</p></summary>
        [Pure]
        public static AzureAcrRepositoryDeleteSettings SetImage(this AzureAcrRepositoryDeleteSettings toolSettings, string image)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Image = image;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryDeleteSettings.Image"/>.</em></p><p>The name of the image. May include a tag in the format 'name:tag' or digest in the format 'name@digest'.</p></summary>
        [Pure]
        public static AzureAcrRepositoryDeleteSettings ResetImage(this AzureAcrRepositoryDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Image = null;
            return toolSettings;
        }
        #endregion
        #region Password
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryDeleteSettings.Password"/>.</em></p><p>The password used to log into a container registry.</p></summary>
        [Pure]
        public static AzureAcrRepositoryDeleteSettings SetPassword(this AzureAcrRepositoryDeleteSettings toolSettings, string password)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = password;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryDeleteSettings.Password"/>.</em></p><p>The password used to log into a container registry.</p></summary>
        [Pure]
        public static AzureAcrRepositoryDeleteSettings ResetPassword(this AzureAcrRepositoryDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = null;
            return toolSettings;
        }
        #endregion
        #region Repository
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryDeleteSettings.Repository"/>.</em></p><p>The name of the repository.</p></summary>
        [Pure]
        public static AzureAcrRepositoryDeleteSettings SetRepository(this AzureAcrRepositoryDeleteSettings toolSettings, string repository)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Repository = repository;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryDeleteSettings.Repository"/>.</em></p><p>The name of the repository.</p></summary>
        [Pure]
        public static AzureAcrRepositoryDeleteSettings ResetRepository(this AzureAcrRepositoryDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Repository = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrRepositoryDeleteSettings SetResourceGroup(this AzureAcrRepositoryDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrRepositoryDeleteSettings ResetResourceGroup(this AzureAcrRepositoryDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Username
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryDeleteSettings.Username"/>.</em></p><p>The username used to log into a container registry.</p></summary>
        [Pure]
        public static AzureAcrRepositoryDeleteSettings SetUsername(this AzureAcrRepositoryDeleteSettings toolSettings, string username)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Username = username;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryDeleteSettings.Username"/>.</em></p><p>The username used to log into a container registry.</p></summary>
        [Pure]
        public static AzureAcrRepositoryDeleteSettings ResetUsername(this AzureAcrRepositoryDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Username = null;
            return toolSettings;
        }
        #endregion
        #region Yes
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryDeleteSettings.Yes"/>.</em></p><p>Do not prompt for confirmation.</p></summary>
        [Pure]
        public static AzureAcrRepositoryDeleteSettings SetYes(this AzureAcrRepositoryDeleteSettings toolSettings, string yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryDeleteSettings.Yes"/>.</em></p><p>Do not prompt for confirmation.</p></summary>
        [Pure]
        public static AzureAcrRepositoryDeleteSettings ResetYes(this AzureAcrRepositoryDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrRepositoryDeleteSettings SetDebug(this AzureAcrRepositoryDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrRepositoryDeleteSettings ResetDebug(this AzureAcrRepositoryDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrRepositoryDeleteSettings SetHelp(this AzureAcrRepositoryDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrRepositoryDeleteSettings ResetHelp(this AzureAcrRepositoryDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrRepositoryDeleteSettings SetOutput(this AzureAcrRepositoryDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrRepositoryDeleteSettings ResetOutput(this AzureAcrRepositoryDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrRepositoryDeleteSettings SetQuery(this AzureAcrRepositoryDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrRepositoryDeleteSettings ResetQuery(this AzureAcrRepositoryDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrRepositoryDeleteSettings SetVerbose(this AzureAcrRepositoryDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrRepositoryDeleteSettings ResetVerbose(this AzureAcrRepositoryDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcrRepositoryListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcrRepositoryListSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryListSettings.Name"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrRepositoryListSettings SetName(this AzureAcrRepositoryListSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryListSettings.Name"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrRepositoryListSettings ResetName(this AzureAcrRepositoryListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Password
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryListSettings.Password"/>.</em></p><p>The password used to log into a container registry.</p></summary>
        [Pure]
        public static AzureAcrRepositoryListSettings SetPassword(this AzureAcrRepositoryListSettings toolSettings, string password)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = password;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryListSettings.Password"/>.</em></p><p>The password used to log into a container registry.</p></summary>
        [Pure]
        public static AzureAcrRepositoryListSettings ResetPassword(this AzureAcrRepositoryListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrRepositoryListSettings SetResourceGroup(this AzureAcrRepositoryListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrRepositoryListSettings ResetResourceGroup(this AzureAcrRepositoryListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Top
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryListSettings.Top"/>.</em></p><p>Limit the number of items in the results.</p></summary>
        [Pure]
        public static AzureAcrRepositoryListSettings SetTop(this AzureAcrRepositoryListSettings toolSettings, string top)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = top;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryListSettings.Top"/>.</em></p><p>Limit the number of items in the results.</p></summary>
        [Pure]
        public static AzureAcrRepositoryListSettings ResetTop(this AzureAcrRepositoryListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = null;
            return toolSettings;
        }
        #endregion
        #region Username
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryListSettings.Username"/>.</em></p><p>The username used to log into a container registry.</p></summary>
        [Pure]
        public static AzureAcrRepositoryListSettings SetUsername(this AzureAcrRepositoryListSettings toolSettings, string username)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Username = username;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryListSettings.Username"/>.</em></p><p>The username used to log into a container registry.</p></summary>
        [Pure]
        public static AzureAcrRepositoryListSettings ResetUsername(this AzureAcrRepositoryListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Username = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrRepositoryListSettings SetDebug(this AzureAcrRepositoryListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrRepositoryListSettings ResetDebug(this AzureAcrRepositoryListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrRepositoryListSettings SetHelp(this AzureAcrRepositoryListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrRepositoryListSettings ResetHelp(this AzureAcrRepositoryListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrRepositoryListSettings SetOutput(this AzureAcrRepositoryListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrRepositoryListSettings ResetOutput(this AzureAcrRepositoryListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrRepositoryListSettings SetQuery(this AzureAcrRepositoryListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrRepositoryListSettings ResetQuery(this AzureAcrRepositoryListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrRepositoryListSettings SetVerbose(this AzureAcrRepositoryListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrRepositoryListSettings ResetVerbose(this AzureAcrRepositoryListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcrRepositoryShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcrRepositoryShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryShowSettings.Name"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowSettings SetName(this AzureAcrRepositoryShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryShowSettings.Name"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowSettings ResetName(this AzureAcrRepositoryShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Image
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryShowSettings.Image"/>.</em></p><p>The name of the image. May include a tag in the format 'name:tag' or digest in the format 'name@digest'.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowSettings SetImage(this AzureAcrRepositoryShowSettings toolSettings, string image)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Image = image;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryShowSettings.Image"/>.</em></p><p>The name of the image. May include a tag in the format 'name:tag' or digest in the format 'name@digest'.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowSettings ResetImage(this AzureAcrRepositoryShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Image = null;
            return toolSettings;
        }
        #endregion
        #region Password
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryShowSettings.Password"/>.</em></p><p>The password used to log into a container registry.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowSettings SetPassword(this AzureAcrRepositoryShowSettings toolSettings, string password)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = password;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryShowSettings.Password"/>.</em></p><p>The password used to log into a container registry.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowSettings ResetPassword(this AzureAcrRepositoryShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = null;
            return toolSettings;
        }
        #endregion
        #region Repository
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryShowSettings.Repository"/>.</em></p><p>The name of the repository.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowSettings SetRepository(this AzureAcrRepositoryShowSettings toolSettings, string repository)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Repository = repository;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryShowSettings.Repository"/>.</em></p><p>The name of the repository.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowSettings ResetRepository(this AzureAcrRepositoryShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Repository = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowSettings SetResourceGroup(this AzureAcrRepositoryShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowSettings ResetResourceGroup(this AzureAcrRepositoryShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Username
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryShowSettings.Username"/>.</em></p><p>The username used to log into a container registry.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowSettings SetUsername(this AzureAcrRepositoryShowSettings toolSettings, string username)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Username = username;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryShowSettings.Username"/>.</em></p><p>The username used to log into a container registry.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowSettings ResetUsername(this AzureAcrRepositoryShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Username = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowSettings SetDebug(this AzureAcrRepositoryShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowSettings ResetDebug(this AzureAcrRepositoryShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowSettings SetHelp(this AzureAcrRepositoryShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowSettings ResetHelp(this AzureAcrRepositoryShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowSettings SetOutput(this AzureAcrRepositoryShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowSettings ResetOutput(this AzureAcrRepositoryShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowSettings SetQuery(this AzureAcrRepositoryShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowSettings ResetQuery(this AzureAcrRepositoryShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowSettings SetVerbose(this AzureAcrRepositoryShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowSettings ResetVerbose(this AzureAcrRepositoryShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcrRepositoryShowManifestsSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcrRepositoryShowManifestsSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryShowManifestsSettings.Name"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowManifestsSettings SetName(this AzureAcrRepositoryShowManifestsSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryShowManifestsSettings.Name"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowManifestsSettings ResetName(this AzureAcrRepositoryShowManifestsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Repository
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryShowManifestsSettings.Repository"/>.</em></p><p>The name of the repository.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowManifestsSettings SetRepository(this AzureAcrRepositoryShowManifestsSettings toolSettings, string repository)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Repository = repository;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryShowManifestsSettings.Repository"/>.</em></p><p>The name of the repository.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowManifestsSettings ResetRepository(this AzureAcrRepositoryShowManifestsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Repository = null;
            return toolSettings;
        }
        #endregion
        #region Detail
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryShowManifestsSettings.Detail"/>.</em></p><p>Show detailed information.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowManifestsSettings SetDetail(this AzureAcrRepositoryShowManifestsSettings toolSettings, string detail)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detail = detail;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryShowManifestsSettings.Detail"/>.</em></p><p>Show detailed information.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowManifestsSettings ResetDetail(this AzureAcrRepositoryShowManifestsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detail = null;
            return toolSettings;
        }
        #endregion
        #region Orderby
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryShowManifestsSettings.Orderby"/>.</em></p><p>Order the items in the results. Default to alphabetical order of names.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowManifestsSettings SetOrderby(this AzureAcrRepositoryShowManifestsSettings toolSettings, AcrRepositoryOrderby orderby)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Orderby = orderby;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryShowManifestsSettings.Orderby"/>.</em></p><p>Order the items in the results. Default to alphabetical order of names.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowManifestsSettings ResetOrderby(this AzureAcrRepositoryShowManifestsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Orderby = null;
            return toolSettings;
        }
        #endregion
        #region Password
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryShowManifestsSettings.Password"/>.</em></p><p>The password used to log into a container registry.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowManifestsSettings SetPassword(this AzureAcrRepositoryShowManifestsSettings toolSettings, string password)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = password;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryShowManifestsSettings.Password"/>.</em></p><p>The password used to log into a container registry.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowManifestsSettings ResetPassword(this AzureAcrRepositoryShowManifestsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryShowManifestsSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowManifestsSettings SetResourceGroup(this AzureAcrRepositoryShowManifestsSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryShowManifestsSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowManifestsSettings ResetResourceGroup(this AzureAcrRepositoryShowManifestsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Top
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryShowManifestsSettings.Top"/>.</em></p><p>Limit the number of items in the results.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowManifestsSettings SetTop(this AzureAcrRepositoryShowManifestsSettings toolSettings, string top)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = top;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryShowManifestsSettings.Top"/>.</em></p><p>Limit the number of items in the results.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowManifestsSettings ResetTop(this AzureAcrRepositoryShowManifestsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = null;
            return toolSettings;
        }
        #endregion
        #region Username
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryShowManifestsSettings.Username"/>.</em></p><p>The username used to log into a container registry.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowManifestsSettings SetUsername(this AzureAcrRepositoryShowManifestsSettings toolSettings, string username)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Username = username;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryShowManifestsSettings.Username"/>.</em></p><p>The username used to log into a container registry.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowManifestsSettings ResetUsername(this AzureAcrRepositoryShowManifestsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Username = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryShowManifestsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowManifestsSettings SetDebug(this AzureAcrRepositoryShowManifestsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryShowManifestsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowManifestsSettings ResetDebug(this AzureAcrRepositoryShowManifestsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryShowManifestsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowManifestsSettings SetHelp(this AzureAcrRepositoryShowManifestsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryShowManifestsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowManifestsSettings ResetHelp(this AzureAcrRepositoryShowManifestsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryShowManifestsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowManifestsSettings SetOutput(this AzureAcrRepositoryShowManifestsSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryShowManifestsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowManifestsSettings ResetOutput(this AzureAcrRepositoryShowManifestsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryShowManifestsSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowManifestsSettings SetQuery(this AzureAcrRepositoryShowManifestsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryShowManifestsSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowManifestsSettings ResetQuery(this AzureAcrRepositoryShowManifestsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryShowManifestsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowManifestsSettings SetVerbose(this AzureAcrRepositoryShowManifestsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryShowManifestsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowManifestsSettings ResetVerbose(this AzureAcrRepositoryShowManifestsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcrRepositoryShowTagsSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcrRepositoryShowTagsSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryShowTagsSettings.Name"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowTagsSettings SetName(this AzureAcrRepositoryShowTagsSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryShowTagsSettings.Name"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowTagsSettings ResetName(this AzureAcrRepositoryShowTagsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Repository
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryShowTagsSettings.Repository"/>.</em></p><p>The name of the repository.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowTagsSettings SetRepository(this AzureAcrRepositoryShowTagsSettings toolSettings, string repository)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Repository = repository;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryShowTagsSettings.Repository"/>.</em></p><p>The name of the repository.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowTagsSettings ResetRepository(this AzureAcrRepositoryShowTagsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Repository = null;
            return toolSettings;
        }
        #endregion
        #region Detail
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryShowTagsSettings.Detail"/>.</em></p><p>Show detailed information.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowTagsSettings SetDetail(this AzureAcrRepositoryShowTagsSettings toolSettings, string detail)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detail = detail;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryShowTagsSettings.Detail"/>.</em></p><p>Show detailed information.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowTagsSettings ResetDetail(this AzureAcrRepositoryShowTagsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detail = null;
            return toolSettings;
        }
        #endregion
        #region Orderby
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryShowTagsSettings.Orderby"/>.</em></p><p>Order the items in the results. Default to alphabetical order of names.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowTagsSettings SetOrderby(this AzureAcrRepositoryShowTagsSettings toolSettings, AcrRepositoryOrderby orderby)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Orderby = orderby;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryShowTagsSettings.Orderby"/>.</em></p><p>Order the items in the results. Default to alphabetical order of names.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowTagsSettings ResetOrderby(this AzureAcrRepositoryShowTagsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Orderby = null;
            return toolSettings;
        }
        #endregion
        #region Password
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryShowTagsSettings.Password"/>.</em></p><p>The password used to log into a container registry.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowTagsSettings SetPassword(this AzureAcrRepositoryShowTagsSettings toolSettings, string password)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = password;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryShowTagsSettings.Password"/>.</em></p><p>The password used to log into a container registry.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowTagsSettings ResetPassword(this AzureAcrRepositoryShowTagsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryShowTagsSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowTagsSettings SetResourceGroup(this AzureAcrRepositoryShowTagsSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryShowTagsSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowTagsSettings ResetResourceGroup(this AzureAcrRepositoryShowTagsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Top
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryShowTagsSettings.Top"/>.</em></p><p>Limit the number of items in the results.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowTagsSettings SetTop(this AzureAcrRepositoryShowTagsSettings toolSettings, string top)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = top;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryShowTagsSettings.Top"/>.</em></p><p>Limit the number of items in the results.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowTagsSettings ResetTop(this AzureAcrRepositoryShowTagsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = null;
            return toolSettings;
        }
        #endregion
        #region Username
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryShowTagsSettings.Username"/>.</em></p><p>The username used to log into a container registry.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowTagsSettings SetUsername(this AzureAcrRepositoryShowTagsSettings toolSettings, string username)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Username = username;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryShowTagsSettings.Username"/>.</em></p><p>The username used to log into a container registry.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowTagsSettings ResetUsername(this AzureAcrRepositoryShowTagsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Username = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryShowTagsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowTagsSettings SetDebug(this AzureAcrRepositoryShowTagsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryShowTagsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowTagsSettings ResetDebug(this AzureAcrRepositoryShowTagsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryShowTagsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowTagsSettings SetHelp(this AzureAcrRepositoryShowTagsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryShowTagsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowTagsSettings ResetHelp(this AzureAcrRepositoryShowTagsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryShowTagsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowTagsSettings SetOutput(this AzureAcrRepositoryShowTagsSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryShowTagsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowTagsSettings ResetOutput(this AzureAcrRepositoryShowTagsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryShowTagsSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowTagsSettings SetQuery(this AzureAcrRepositoryShowTagsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryShowTagsSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowTagsSettings ResetQuery(this AzureAcrRepositoryShowTagsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryShowTagsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowTagsSettings SetVerbose(this AzureAcrRepositoryShowTagsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryShowTagsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowTagsSettings ResetVerbose(this AzureAcrRepositoryShowTagsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcrRepositoryUntagSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcrRepositoryUntagSettingsExtensions
    {
        #region Image
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryUntagSettings.Image"/>.</em></p><p>The name of the image. May include a tag in the format 'name:tag'.</p></summary>
        [Pure]
        public static AzureAcrRepositoryUntagSettings SetImage(this AzureAcrRepositoryUntagSettings toolSettings, string image)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Image = image;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryUntagSettings.Image"/>.</em></p><p>The name of the image. May include a tag in the format 'name:tag'.</p></summary>
        [Pure]
        public static AzureAcrRepositoryUntagSettings ResetImage(this AzureAcrRepositoryUntagSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Image = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryUntagSettings.Name"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrRepositoryUntagSettings SetName(this AzureAcrRepositoryUntagSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryUntagSettings.Name"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrRepositoryUntagSettings ResetName(this AzureAcrRepositoryUntagSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Password
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryUntagSettings.Password"/>.</em></p><p>The password used to log into a container registry.</p></summary>
        [Pure]
        public static AzureAcrRepositoryUntagSettings SetPassword(this AzureAcrRepositoryUntagSettings toolSettings, string password)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = password;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryUntagSettings.Password"/>.</em></p><p>The password used to log into a container registry.</p></summary>
        [Pure]
        public static AzureAcrRepositoryUntagSettings ResetPassword(this AzureAcrRepositoryUntagSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryUntagSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrRepositoryUntagSettings SetResourceGroup(this AzureAcrRepositoryUntagSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryUntagSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrRepositoryUntagSettings ResetResourceGroup(this AzureAcrRepositoryUntagSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Username
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryUntagSettings.Username"/>.</em></p><p>The username used to log into a container registry.</p></summary>
        [Pure]
        public static AzureAcrRepositoryUntagSettings SetUsername(this AzureAcrRepositoryUntagSettings toolSettings, string username)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Username = username;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryUntagSettings.Username"/>.</em></p><p>The username used to log into a container registry.</p></summary>
        [Pure]
        public static AzureAcrRepositoryUntagSettings ResetUsername(this AzureAcrRepositoryUntagSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Username = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryUntagSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrRepositoryUntagSettings SetDebug(this AzureAcrRepositoryUntagSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryUntagSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrRepositoryUntagSettings ResetDebug(this AzureAcrRepositoryUntagSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryUntagSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrRepositoryUntagSettings SetHelp(this AzureAcrRepositoryUntagSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryUntagSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrRepositoryUntagSettings ResetHelp(this AzureAcrRepositoryUntagSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryUntagSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrRepositoryUntagSettings SetOutput(this AzureAcrRepositoryUntagSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryUntagSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrRepositoryUntagSettings ResetOutput(this AzureAcrRepositoryUntagSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryUntagSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrRepositoryUntagSettings SetQuery(this AzureAcrRepositoryUntagSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryUntagSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrRepositoryUntagSettings ResetQuery(this AzureAcrRepositoryUntagSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryUntagSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrRepositoryUntagSettings SetVerbose(this AzureAcrRepositoryUntagSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryUntagSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrRepositoryUntagSettings ResetVerbose(this AzureAcrRepositoryUntagSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcrRepositoryUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcrRepositoryUpdateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryUpdateSettings.Name"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrRepositoryUpdateSettings SetName(this AzureAcrRepositoryUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryUpdateSettings.Name"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrRepositoryUpdateSettings ResetName(this AzureAcrRepositoryUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region DeleteEnabled
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryUpdateSettings.DeleteEnabled"/>.</em></p><p>Indicates whether delete operation is allowed.</p></summary>
        [Pure]
        public static AzureAcrRepositoryUpdateSettings SetDeleteEnabled(this AzureAcrRepositoryUpdateSettings toolSettings, bool? deleteEnabled)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DeleteEnabled = deleteEnabled;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryUpdateSettings.DeleteEnabled"/>.</em></p><p>Indicates whether delete operation is allowed.</p></summary>
        [Pure]
        public static AzureAcrRepositoryUpdateSettings ResetDeleteEnabled(this AzureAcrRepositoryUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DeleteEnabled = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureAcrRepositoryUpdateSettings.DeleteEnabled"/>.</em></p><p>Indicates whether delete operation is allowed.</p></summary>
        [Pure]
        public static AzureAcrRepositoryUpdateSettings EnableDeleteEnabled(this AzureAcrRepositoryUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DeleteEnabled = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureAcrRepositoryUpdateSettings.DeleteEnabled"/>.</em></p><p>Indicates whether delete operation is allowed.</p></summary>
        [Pure]
        public static AzureAcrRepositoryUpdateSettings DisableDeleteEnabled(this AzureAcrRepositoryUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DeleteEnabled = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureAcrRepositoryUpdateSettings.DeleteEnabled"/>.</em></p><p>Indicates whether delete operation is allowed.</p></summary>
        [Pure]
        public static AzureAcrRepositoryUpdateSettings ToggleDeleteEnabled(this AzureAcrRepositoryUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DeleteEnabled = !toolSettings.DeleteEnabled;
            return toolSettings;
        }
        #endregion
        #region Image
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryUpdateSettings.Image"/>.</em></p><p>The name of the image. May include a tag in the format 'name:tag' or digest in the format 'name@digest'.</p></summary>
        [Pure]
        public static AzureAcrRepositoryUpdateSettings SetImage(this AzureAcrRepositoryUpdateSettings toolSettings, string image)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Image = image;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryUpdateSettings.Image"/>.</em></p><p>The name of the image. May include a tag in the format 'name:tag' or digest in the format 'name@digest'.</p></summary>
        [Pure]
        public static AzureAcrRepositoryUpdateSettings ResetImage(this AzureAcrRepositoryUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Image = null;
            return toolSettings;
        }
        #endregion
        #region ListEnabled
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryUpdateSettings.ListEnabled"/>.</em></p><p>Indicates whether this item shows in list operation results.</p></summary>
        [Pure]
        public static AzureAcrRepositoryUpdateSettings SetListEnabled(this AzureAcrRepositoryUpdateSettings toolSettings, bool? listEnabled)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ListEnabled = listEnabled;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryUpdateSettings.ListEnabled"/>.</em></p><p>Indicates whether this item shows in list operation results.</p></summary>
        [Pure]
        public static AzureAcrRepositoryUpdateSettings ResetListEnabled(this AzureAcrRepositoryUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ListEnabled = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureAcrRepositoryUpdateSettings.ListEnabled"/>.</em></p><p>Indicates whether this item shows in list operation results.</p></summary>
        [Pure]
        public static AzureAcrRepositoryUpdateSettings EnableListEnabled(this AzureAcrRepositoryUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ListEnabled = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureAcrRepositoryUpdateSettings.ListEnabled"/>.</em></p><p>Indicates whether this item shows in list operation results.</p></summary>
        [Pure]
        public static AzureAcrRepositoryUpdateSettings DisableListEnabled(this AzureAcrRepositoryUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ListEnabled = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureAcrRepositoryUpdateSettings.ListEnabled"/>.</em></p><p>Indicates whether this item shows in list operation results.</p></summary>
        [Pure]
        public static AzureAcrRepositoryUpdateSettings ToggleListEnabled(this AzureAcrRepositoryUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ListEnabled = !toolSettings.ListEnabled;
            return toolSettings;
        }
        #endregion
        #region Password
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryUpdateSettings.Password"/>.</em></p><p>The password used to log into a container registry.</p></summary>
        [Pure]
        public static AzureAcrRepositoryUpdateSettings SetPassword(this AzureAcrRepositoryUpdateSettings toolSettings, string password)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = password;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryUpdateSettings.Password"/>.</em></p><p>The password used to log into a container registry.</p></summary>
        [Pure]
        public static AzureAcrRepositoryUpdateSettings ResetPassword(this AzureAcrRepositoryUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = null;
            return toolSettings;
        }
        #endregion
        #region ReadEnabled
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryUpdateSettings.ReadEnabled"/>.</em></p><p>Indicates whether read operation is allowed.</p></summary>
        [Pure]
        public static AzureAcrRepositoryUpdateSettings SetReadEnabled(this AzureAcrRepositoryUpdateSettings toolSettings, bool? readEnabled)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReadEnabled = readEnabled;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryUpdateSettings.ReadEnabled"/>.</em></p><p>Indicates whether read operation is allowed.</p></summary>
        [Pure]
        public static AzureAcrRepositoryUpdateSettings ResetReadEnabled(this AzureAcrRepositoryUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReadEnabled = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureAcrRepositoryUpdateSettings.ReadEnabled"/>.</em></p><p>Indicates whether read operation is allowed.</p></summary>
        [Pure]
        public static AzureAcrRepositoryUpdateSettings EnableReadEnabled(this AzureAcrRepositoryUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReadEnabled = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureAcrRepositoryUpdateSettings.ReadEnabled"/>.</em></p><p>Indicates whether read operation is allowed.</p></summary>
        [Pure]
        public static AzureAcrRepositoryUpdateSettings DisableReadEnabled(this AzureAcrRepositoryUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReadEnabled = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureAcrRepositoryUpdateSettings.ReadEnabled"/>.</em></p><p>Indicates whether read operation is allowed.</p></summary>
        [Pure]
        public static AzureAcrRepositoryUpdateSettings ToggleReadEnabled(this AzureAcrRepositoryUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReadEnabled = !toolSettings.ReadEnabled;
            return toolSettings;
        }
        #endregion
        #region Repository
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryUpdateSettings.Repository"/>.</em></p><p>The name of the repository.</p></summary>
        [Pure]
        public static AzureAcrRepositoryUpdateSettings SetRepository(this AzureAcrRepositoryUpdateSettings toolSettings, string repository)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Repository = repository;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryUpdateSettings.Repository"/>.</em></p><p>The name of the repository.</p></summary>
        [Pure]
        public static AzureAcrRepositoryUpdateSettings ResetRepository(this AzureAcrRepositoryUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Repository = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrRepositoryUpdateSettings SetResourceGroup(this AzureAcrRepositoryUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrRepositoryUpdateSettings ResetResourceGroup(this AzureAcrRepositoryUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Username
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryUpdateSettings.Username"/>.</em></p><p>The username used to log into a container registry.</p></summary>
        [Pure]
        public static AzureAcrRepositoryUpdateSettings SetUsername(this AzureAcrRepositoryUpdateSettings toolSettings, string username)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Username = username;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryUpdateSettings.Username"/>.</em></p><p>The username used to log into a container registry.</p></summary>
        [Pure]
        public static AzureAcrRepositoryUpdateSettings ResetUsername(this AzureAcrRepositoryUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Username = null;
            return toolSettings;
        }
        #endregion
        #region WriteEnabled
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryUpdateSettings.WriteEnabled"/>.</em></p><p>Indicates whether write or delete operation is allowed.</p></summary>
        [Pure]
        public static AzureAcrRepositoryUpdateSettings SetWriteEnabled(this AzureAcrRepositoryUpdateSettings toolSettings, bool? writeEnabled)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WriteEnabled = writeEnabled;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryUpdateSettings.WriteEnabled"/>.</em></p><p>Indicates whether write or delete operation is allowed.</p></summary>
        [Pure]
        public static AzureAcrRepositoryUpdateSettings ResetWriteEnabled(this AzureAcrRepositoryUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WriteEnabled = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureAcrRepositoryUpdateSettings.WriteEnabled"/>.</em></p><p>Indicates whether write or delete operation is allowed.</p></summary>
        [Pure]
        public static AzureAcrRepositoryUpdateSettings EnableWriteEnabled(this AzureAcrRepositoryUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WriteEnabled = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureAcrRepositoryUpdateSettings.WriteEnabled"/>.</em></p><p>Indicates whether write or delete operation is allowed.</p></summary>
        [Pure]
        public static AzureAcrRepositoryUpdateSettings DisableWriteEnabled(this AzureAcrRepositoryUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WriteEnabled = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureAcrRepositoryUpdateSettings.WriteEnabled"/>.</em></p><p>Indicates whether write or delete operation is allowed.</p></summary>
        [Pure]
        public static AzureAcrRepositoryUpdateSettings ToggleWriteEnabled(this AzureAcrRepositoryUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WriteEnabled = !toolSettings.WriteEnabled;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrRepositoryUpdateSettings SetDebug(this AzureAcrRepositoryUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrRepositoryUpdateSettings ResetDebug(this AzureAcrRepositoryUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrRepositoryUpdateSettings SetHelp(this AzureAcrRepositoryUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrRepositoryUpdateSettings ResetHelp(this AzureAcrRepositoryUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrRepositoryUpdateSettings SetOutput(this AzureAcrRepositoryUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrRepositoryUpdateSettings ResetOutput(this AzureAcrRepositoryUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrRepositoryUpdateSettings SetQuery(this AzureAcrRepositoryUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrRepositoryUpdateSettings ResetQuery(this AzureAcrRepositoryUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrRepositoryUpdateSettings SetVerbose(this AzureAcrRepositoryUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrRepositoryUpdateSettings ResetVerbose(this AzureAcrRepositoryUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcrWebhookCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcrWebhookCreateSettingsExtensions
    {
        #region Actions
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookCreateSettings.Actions"/> to a new list.</em></p><p>Space-separated list of actions that trigger the webhook to post notifications.</p></summary>
        [Pure]
        public static AzureAcrWebhookCreateSettings SetActions(this AzureAcrWebhookCreateSettings toolSettings, params AcrWebhookActions[] actions)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ActionsInternal = actions.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookCreateSettings.Actions"/> to a new list.</em></p><p>Space-separated list of actions that trigger the webhook to post notifications.</p></summary>
        [Pure]
        public static AzureAcrWebhookCreateSettings SetActions(this AzureAcrWebhookCreateSettings toolSettings, IEnumerable<AcrWebhookActions> actions)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ActionsInternal = actions.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureAcrWebhookCreateSettings.Actions"/>.</em></p><p>Space-separated list of actions that trigger the webhook to post notifications.</p></summary>
        [Pure]
        public static AzureAcrWebhookCreateSettings AddActions(this AzureAcrWebhookCreateSettings toolSettings, params AcrWebhookActions[] actions)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ActionsInternal.AddRange(actions);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureAcrWebhookCreateSettings.Actions"/>.</em></p><p>Space-separated list of actions that trigger the webhook to post notifications.</p></summary>
        [Pure]
        public static AzureAcrWebhookCreateSettings AddActions(this AzureAcrWebhookCreateSettings toolSettings, IEnumerable<AcrWebhookActions> actions)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ActionsInternal.AddRange(actions);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureAcrWebhookCreateSettings.Actions"/>.</em></p><p>Space-separated list of actions that trigger the webhook to post notifications.</p></summary>
        [Pure]
        public static AzureAcrWebhookCreateSettings ClearActions(this AzureAcrWebhookCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ActionsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureAcrWebhookCreateSettings.Actions"/>.</em></p><p>Space-separated list of actions that trigger the webhook to post notifications.</p></summary>
        [Pure]
        public static AzureAcrWebhookCreateSettings RemoveActions(this AzureAcrWebhookCreateSettings toolSettings, params AcrWebhookActions[] actions)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<AcrWebhookActions>(actions);
            toolSettings.ActionsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureAcrWebhookCreateSettings.Actions"/>.</em></p><p>Space-separated list of actions that trigger the webhook to post notifications.</p></summary>
        [Pure]
        public static AzureAcrWebhookCreateSettings RemoveActions(this AzureAcrWebhookCreateSettings toolSettings, IEnumerable<AcrWebhookActions> actions)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<AcrWebhookActions>(actions);
            toolSettings.ActionsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookCreateSettings.Name"/>.</em></p><p>The name of the webhook.</p></summary>
        [Pure]
        public static AzureAcrWebhookCreateSettings SetName(this AzureAcrWebhookCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookCreateSettings.Name"/>.</em></p><p>The name of the webhook.</p></summary>
        [Pure]
        public static AzureAcrWebhookCreateSettings ResetName(this AzureAcrWebhookCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Registry
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookCreateSettings.Registry"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrWebhookCreateSettings SetRegistry(this AzureAcrWebhookCreateSettings toolSettings, string registry)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Registry = registry;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookCreateSettings.Registry"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrWebhookCreateSettings ResetRegistry(this AzureAcrWebhookCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Registry = null;
            return toolSettings;
        }
        #endregion
        #region Uri
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookCreateSettings.Uri"/>.</em></p><p>The service URI for the webhook to post notifications.</p></summary>
        [Pure]
        public static AzureAcrWebhookCreateSettings SetUri(this AzureAcrWebhookCreateSettings toolSettings, string uri)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Uri = uri;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookCreateSettings.Uri"/>.</em></p><p>The service URI for the webhook to post notifications.</p></summary>
        [Pure]
        public static AzureAcrWebhookCreateSettings ResetUri(this AzureAcrWebhookCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Uri = null;
            return toolSettings;
        }
        #endregion
        #region Headers
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookCreateSettings.Headers"/>.</em></p><p>Space-separated custom headers in 'key[=value]' format that will be added to the webhook notifications. Use "" to clear existing headers.</p></summary>
        [Pure]
        public static AzureAcrWebhookCreateSettings SetHeaders(this AzureAcrWebhookCreateSettings toolSettings, string headers)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Headers = headers;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookCreateSettings.Headers"/>.</em></p><p>Space-separated custom headers in 'key[=value]' format that will be added to the webhook notifications. Use "" to clear existing headers.</p></summary>
        [Pure]
        public static AzureAcrWebhookCreateSettings ResetHeaders(this AzureAcrWebhookCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Headers = null;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookCreateSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrWebhookCreateSettings SetLocation(this AzureAcrWebhookCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookCreateSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrWebhookCreateSettings ResetLocation(this AzureAcrWebhookCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrWebhookCreateSettings SetResourceGroup(this AzureAcrWebhookCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrWebhookCreateSettings ResetResourceGroup(this AzureAcrWebhookCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Scope
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookCreateSettings.Scope"/>.</em></p><p>The scope of repositories where the event can be triggered. For example, 'foo:*' means events for all tags under repository 'foo'. 'foo:bar' means events for 'foo:bar' only. 'foo' is equivalent to 'foo:latest'. Empty means events for all repositories.</p></summary>
        [Pure]
        public static AzureAcrWebhookCreateSettings SetScope(this AzureAcrWebhookCreateSettings toolSettings, string scope)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Scope = scope;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookCreateSettings.Scope"/>.</em></p><p>The scope of repositories where the event can be triggered. For example, 'foo:*' means events for all tags under repository 'foo'. 'foo:bar' means events for 'foo:bar' only. 'foo' is equivalent to 'foo:latest'. Empty means events for all repositories.</p></summary>
        [Pure]
        public static AzureAcrWebhookCreateSettings ResetScope(this AzureAcrWebhookCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Scope = null;
            return toolSettings;
        }
        #endregion
        #region Status
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookCreateSettings.Status"/>.</em></p><p>Indicates whether the webhook is enabled.</p></summary>
        [Pure]
        public static AzureAcrWebhookCreateSettings SetStatus(this AzureAcrWebhookCreateSettings toolSettings, AcrBuildTaskStatus status)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Status = status;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookCreateSettings.Status"/>.</em></p><p>Indicates whether the webhook is enabled.</p></summary>
        [Pure]
        public static AzureAcrWebhookCreateSettings ResetStatus(this AzureAcrWebhookCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Status = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookCreateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureAcrWebhookCreateSettings SetTags(this AzureAcrWebhookCreateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookCreateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureAcrWebhookCreateSettings ResetTags(this AzureAcrWebhookCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrWebhookCreateSettings SetDebug(this AzureAcrWebhookCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrWebhookCreateSettings ResetDebug(this AzureAcrWebhookCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrWebhookCreateSettings SetHelp(this AzureAcrWebhookCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrWebhookCreateSettings ResetHelp(this AzureAcrWebhookCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrWebhookCreateSettings SetOutput(this AzureAcrWebhookCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrWebhookCreateSettings ResetOutput(this AzureAcrWebhookCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrWebhookCreateSettings SetQuery(this AzureAcrWebhookCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrWebhookCreateSettings ResetQuery(this AzureAcrWebhookCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrWebhookCreateSettings SetVerbose(this AzureAcrWebhookCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrWebhookCreateSettings ResetVerbose(this AzureAcrWebhookCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcrWebhookDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcrWebhookDeleteSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookDeleteSettings.Name"/>.</em></p><p>The name of the webhook.</p></summary>
        [Pure]
        public static AzureAcrWebhookDeleteSettings SetName(this AzureAcrWebhookDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookDeleteSettings.Name"/>.</em></p><p>The name of the webhook.</p></summary>
        [Pure]
        public static AzureAcrWebhookDeleteSettings ResetName(this AzureAcrWebhookDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Registry
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookDeleteSettings.Registry"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrWebhookDeleteSettings SetRegistry(this AzureAcrWebhookDeleteSettings toolSettings, string registry)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Registry = registry;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookDeleteSettings.Registry"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrWebhookDeleteSettings ResetRegistry(this AzureAcrWebhookDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Registry = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrWebhookDeleteSettings SetResourceGroup(this AzureAcrWebhookDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrWebhookDeleteSettings ResetResourceGroup(this AzureAcrWebhookDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrWebhookDeleteSettings SetDebug(this AzureAcrWebhookDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrWebhookDeleteSettings ResetDebug(this AzureAcrWebhookDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrWebhookDeleteSettings SetHelp(this AzureAcrWebhookDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrWebhookDeleteSettings ResetHelp(this AzureAcrWebhookDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrWebhookDeleteSettings SetOutput(this AzureAcrWebhookDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrWebhookDeleteSettings ResetOutput(this AzureAcrWebhookDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrWebhookDeleteSettings SetQuery(this AzureAcrWebhookDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrWebhookDeleteSettings ResetQuery(this AzureAcrWebhookDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrWebhookDeleteSettings SetVerbose(this AzureAcrWebhookDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrWebhookDeleteSettings ResetVerbose(this AzureAcrWebhookDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcrWebhookGetConfigSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcrWebhookGetConfigSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookGetConfigSettings.Name"/>.</em></p><p>The name of the webhook.</p></summary>
        [Pure]
        public static AzureAcrWebhookGetConfigSettings SetName(this AzureAcrWebhookGetConfigSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookGetConfigSettings.Name"/>.</em></p><p>The name of the webhook.</p></summary>
        [Pure]
        public static AzureAcrWebhookGetConfigSettings ResetName(this AzureAcrWebhookGetConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Registry
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookGetConfigSettings.Registry"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrWebhookGetConfigSettings SetRegistry(this AzureAcrWebhookGetConfigSettings toolSettings, string registry)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Registry = registry;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookGetConfigSettings.Registry"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrWebhookGetConfigSettings ResetRegistry(this AzureAcrWebhookGetConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Registry = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookGetConfigSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrWebhookGetConfigSettings SetResourceGroup(this AzureAcrWebhookGetConfigSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookGetConfigSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrWebhookGetConfigSettings ResetResourceGroup(this AzureAcrWebhookGetConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookGetConfigSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrWebhookGetConfigSettings SetDebug(this AzureAcrWebhookGetConfigSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookGetConfigSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrWebhookGetConfigSettings ResetDebug(this AzureAcrWebhookGetConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookGetConfigSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrWebhookGetConfigSettings SetHelp(this AzureAcrWebhookGetConfigSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookGetConfigSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrWebhookGetConfigSettings ResetHelp(this AzureAcrWebhookGetConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookGetConfigSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrWebhookGetConfigSettings SetOutput(this AzureAcrWebhookGetConfigSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookGetConfigSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrWebhookGetConfigSettings ResetOutput(this AzureAcrWebhookGetConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookGetConfigSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrWebhookGetConfigSettings SetQuery(this AzureAcrWebhookGetConfigSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookGetConfigSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrWebhookGetConfigSettings ResetQuery(this AzureAcrWebhookGetConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookGetConfigSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrWebhookGetConfigSettings SetVerbose(this AzureAcrWebhookGetConfigSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookGetConfigSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrWebhookGetConfigSettings ResetVerbose(this AzureAcrWebhookGetConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcrWebhookListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcrWebhookListSettingsExtensions
    {
        #region Registry
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookListSettings.Registry"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrWebhookListSettings SetRegistry(this AzureAcrWebhookListSettings toolSettings, string registry)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Registry = registry;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookListSettings.Registry"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrWebhookListSettings ResetRegistry(this AzureAcrWebhookListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Registry = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrWebhookListSettings SetResourceGroup(this AzureAcrWebhookListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrWebhookListSettings ResetResourceGroup(this AzureAcrWebhookListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrWebhookListSettings SetDebug(this AzureAcrWebhookListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrWebhookListSettings ResetDebug(this AzureAcrWebhookListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrWebhookListSettings SetHelp(this AzureAcrWebhookListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrWebhookListSettings ResetHelp(this AzureAcrWebhookListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrWebhookListSettings SetOutput(this AzureAcrWebhookListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrWebhookListSettings ResetOutput(this AzureAcrWebhookListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrWebhookListSettings SetQuery(this AzureAcrWebhookListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrWebhookListSettings ResetQuery(this AzureAcrWebhookListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrWebhookListSettings SetVerbose(this AzureAcrWebhookListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrWebhookListSettings ResetVerbose(this AzureAcrWebhookListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcrWebhookListEventsSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcrWebhookListEventsSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookListEventsSettings.Name"/>.</em></p><p>The name of the webhook.</p></summary>
        [Pure]
        public static AzureAcrWebhookListEventsSettings SetName(this AzureAcrWebhookListEventsSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookListEventsSettings.Name"/>.</em></p><p>The name of the webhook.</p></summary>
        [Pure]
        public static AzureAcrWebhookListEventsSettings ResetName(this AzureAcrWebhookListEventsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Registry
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookListEventsSettings.Registry"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrWebhookListEventsSettings SetRegistry(this AzureAcrWebhookListEventsSettings toolSettings, string registry)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Registry = registry;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookListEventsSettings.Registry"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrWebhookListEventsSettings ResetRegistry(this AzureAcrWebhookListEventsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Registry = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookListEventsSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrWebhookListEventsSettings SetResourceGroup(this AzureAcrWebhookListEventsSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookListEventsSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrWebhookListEventsSettings ResetResourceGroup(this AzureAcrWebhookListEventsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookListEventsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrWebhookListEventsSettings SetDebug(this AzureAcrWebhookListEventsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookListEventsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrWebhookListEventsSettings ResetDebug(this AzureAcrWebhookListEventsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookListEventsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrWebhookListEventsSettings SetHelp(this AzureAcrWebhookListEventsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookListEventsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrWebhookListEventsSettings ResetHelp(this AzureAcrWebhookListEventsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookListEventsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrWebhookListEventsSettings SetOutput(this AzureAcrWebhookListEventsSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookListEventsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrWebhookListEventsSettings ResetOutput(this AzureAcrWebhookListEventsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookListEventsSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrWebhookListEventsSettings SetQuery(this AzureAcrWebhookListEventsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookListEventsSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrWebhookListEventsSettings ResetQuery(this AzureAcrWebhookListEventsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookListEventsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrWebhookListEventsSettings SetVerbose(this AzureAcrWebhookListEventsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookListEventsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrWebhookListEventsSettings ResetVerbose(this AzureAcrWebhookListEventsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcrWebhookPingSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcrWebhookPingSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookPingSettings.Name"/>.</em></p><p>The name of the webhook.</p></summary>
        [Pure]
        public static AzureAcrWebhookPingSettings SetName(this AzureAcrWebhookPingSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookPingSettings.Name"/>.</em></p><p>The name of the webhook.</p></summary>
        [Pure]
        public static AzureAcrWebhookPingSettings ResetName(this AzureAcrWebhookPingSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Registry
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookPingSettings.Registry"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrWebhookPingSettings SetRegistry(this AzureAcrWebhookPingSettings toolSettings, string registry)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Registry = registry;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookPingSettings.Registry"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrWebhookPingSettings ResetRegistry(this AzureAcrWebhookPingSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Registry = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookPingSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrWebhookPingSettings SetResourceGroup(this AzureAcrWebhookPingSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookPingSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrWebhookPingSettings ResetResourceGroup(this AzureAcrWebhookPingSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookPingSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrWebhookPingSettings SetDebug(this AzureAcrWebhookPingSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookPingSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrWebhookPingSettings ResetDebug(this AzureAcrWebhookPingSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookPingSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrWebhookPingSettings SetHelp(this AzureAcrWebhookPingSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookPingSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrWebhookPingSettings ResetHelp(this AzureAcrWebhookPingSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookPingSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrWebhookPingSettings SetOutput(this AzureAcrWebhookPingSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookPingSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrWebhookPingSettings ResetOutput(this AzureAcrWebhookPingSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookPingSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrWebhookPingSettings SetQuery(this AzureAcrWebhookPingSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookPingSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrWebhookPingSettings ResetQuery(this AzureAcrWebhookPingSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookPingSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrWebhookPingSettings SetVerbose(this AzureAcrWebhookPingSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookPingSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrWebhookPingSettings ResetVerbose(this AzureAcrWebhookPingSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcrWebhookShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcrWebhookShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookShowSettings.Name"/>.</em></p><p>The name of the webhook.</p></summary>
        [Pure]
        public static AzureAcrWebhookShowSettings SetName(this AzureAcrWebhookShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookShowSettings.Name"/>.</em></p><p>The name of the webhook.</p></summary>
        [Pure]
        public static AzureAcrWebhookShowSettings ResetName(this AzureAcrWebhookShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Registry
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookShowSettings.Registry"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrWebhookShowSettings SetRegistry(this AzureAcrWebhookShowSettings toolSettings, string registry)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Registry = registry;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookShowSettings.Registry"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrWebhookShowSettings ResetRegistry(this AzureAcrWebhookShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Registry = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrWebhookShowSettings SetResourceGroup(this AzureAcrWebhookShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrWebhookShowSettings ResetResourceGroup(this AzureAcrWebhookShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrWebhookShowSettings SetDebug(this AzureAcrWebhookShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrWebhookShowSettings ResetDebug(this AzureAcrWebhookShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrWebhookShowSettings SetHelp(this AzureAcrWebhookShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrWebhookShowSettings ResetHelp(this AzureAcrWebhookShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrWebhookShowSettings SetOutput(this AzureAcrWebhookShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrWebhookShowSettings ResetOutput(this AzureAcrWebhookShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrWebhookShowSettings SetQuery(this AzureAcrWebhookShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrWebhookShowSettings ResetQuery(this AzureAcrWebhookShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrWebhookShowSettings SetVerbose(this AzureAcrWebhookShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrWebhookShowSettings ResetVerbose(this AzureAcrWebhookShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcrWebhookUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcrWebhookUpdateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookUpdateSettings.Name"/>.</em></p><p>The name of the webhook.</p></summary>
        [Pure]
        public static AzureAcrWebhookUpdateSettings SetName(this AzureAcrWebhookUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookUpdateSettings.Name"/>.</em></p><p>The name of the webhook.</p></summary>
        [Pure]
        public static AzureAcrWebhookUpdateSettings ResetName(this AzureAcrWebhookUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Registry
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookUpdateSettings.Registry"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrWebhookUpdateSettings SetRegistry(this AzureAcrWebhookUpdateSettings toolSettings, string registry)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Registry = registry;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookUpdateSettings.Registry"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrWebhookUpdateSettings ResetRegistry(this AzureAcrWebhookUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Registry = null;
            return toolSettings;
        }
        #endregion
        #region Actions
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookUpdateSettings.Actions"/> to a new list.</em></p><p>Space-separated list of actions that trigger the webhook to post notifications.</p></summary>
        [Pure]
        public static AzureAcrWebhookUpdateSettings SetActions(this AzureAcrWebhookUpdateSettings toolSettings, params AcrWebhookActions[] actions)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ActionsInternal = actions.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookUpdateSettings.Actions"/> to a new list.</em></p><p>Space-separated list of actions that trigger the webhook to post notifications.</p></summary>
        [Pure]
        public static AzureAcrWebhookUpdateSettings SetActions(this AzureAcrWebhookUpdateSettings toolSettings, IEnumerable<AcrWebhookActions> actions)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ActionsInternal = actions.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureAcrWebhookUpdateSettings.Actions"/>.</em></p><p>Space-separated list of actions that trigger the webhook to post notifications.</p></summary>
        [Pure]
        public static AzureAcrWebhookUpdateSettings AddActions(this AzureAcrWebhookUpdateSettings toolSettings, params AcrWebhookActions[] actions)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ActionsInternal.AddRange(actions);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureAcrWebhookUpdateSettings.Actions"/>.</em></p><p>Space-separated list of actions that trigger the webhook to post notifications.</p></summary>
        [Pure]
        public static AzureAcrWebhookUpdateSettings AddActions(this AzureAcrWebhookUpdateSettings toolSettings, IEnumerable<AcrWebhookActions> actions)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ActionsInternal.AddRange(actions);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureAcrWebhookUpdateSettings.Actions"/>.</em></p><p>Space-separated list of actions that trigger the webhook to post notifications.</p></summary>
        [Pure]
        public static AzureAcrWebhookUpdateSettings ClearActions(this AzureAcrWebhookUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ActionsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureAcrWebhookUpdateSettings.Actions"/>.</em></p><p>Space-separated list of actions that trigger the webhook to post notifications.</p></summary>
        [Pure]
        public static AzureAcrWebhookUpdateSettings RemoveActions(this AzureAcrWebhookUpdateSettings toolSettings, params AcrWebhookActions[] actions)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<AcrWebhookActions>(actions);
            toolSettings.ActionsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureAcrWebhookUpdateSettings.Actions"/>.</em></p><p>Space-separated list of actions that trigger the webhook to post notifications.</p></summary>
        [Pure]
        public static AzureAcrWebhookUpdateSettings RemoveActions(this AzureAcrWebhookUpdateSettings toolSettings, IEnumerable<AcrWebhookActions> actions)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<AcrWebhookActions>(actions);
            toolSettings.ActionsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Headers
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookUpdateSettings.Headers"/>.</em></p><p>Space-separated custom headers in 'key[=value]' format that will be added to the webhook notifications. Use "" to clear existing headers.</p></summary>
        [Pure]
        public static AzureAcrWebhookUpdateSettings SetHeaders(this AzureAcrWebhookUpdateSettings toolSettings, string headers)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Headers = headers;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookUpdateSettings.Headers"/>.</em></p><p>Space-separated custom headers in 'key[=value]' format that will be added to the webhook notifications. Use "" to clear existing headers.</p></summary>
        [Pure]
        public static AzureAcrWebhookUpdateSettings ResetHeaders(this AzureAcrWebhookUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Headers = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrWebhookUpdateSettings SetResourceGroup(this AzureAcrWebhookUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrWebhookUpdateSettings ResetResourceGroup(this AzureAcrWebhookUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Scope
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookUpdateSettings.Scope"/>.</em></p><p>The scope of repositories where the event can be triggered. For example, 'foo:*' means events for all tags under repository 'foo'. 'foo:bar' means events for 'foo:bar' only. 'foo' is equivalent to 'foo:latest'. Empty means events for all repositories.</p></summary>
        [Pure]
        public static AzureAcrWebhookUpdateSettings SetScope(this AzureAcrWebhookUpdateSettings toolSettings, string scope)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Scope = scope;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookUpdateSettings.Scope"/>.</em></p><p>The scope of repositories where the event can be triggered. For example, 'foo:*' means events for all tags under repository 'foo'. 'foo:bar' means events for 'foo:bar' only. 'foo' is equivalent to 'foo:latest'. Empty means events for all repositories.</p></summary>
        [Pure]
        public static AzureAcrWebhookUpdateSettings ResetScope(this AzureAcrWebhookUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Scope = null;
            return toolSettings;
        }
        #endregion
        #region Status
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookUpdateSettings.Status"/>.</em></p><p>Indicates whether the webhook is enabled.</p></summary>
        [Pure]
        public static AzureAcrWebhookUpdateSettings SetStatus(this AzureAcrWebhookUpdateSettings toolSettings, AcrBuildTaskStatus status)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Status = status;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookUpdateSettings.Status"/>.</em></p><p>Indicates whether the webhook is enabled.</p></summary>
        [Pure]
        public static AzureAcrWebhookUpdateSettings ResetStatus(this AzureAcrWebhookUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Status = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookUpdateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureAcrWebhookUpdateSettings SetTags(this AzureAcrWebhookUpdateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookUpdateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureAcrWebhookUpdateSettings ResetTags(this AzureAcrWebhookUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Uri
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookUpdateSettings.Uri"/>.</em></p><p>The service URI for the webhook to post notifications.</p></summary>
        [Pure]
        public static AzureAcrWebhookUpdateSettings SetUri(this AzureAcrWebhookUpdateSettings toolSettings, string uri)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Uri = uri;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookUpdateSettings.Uri"/>.</em></p><p>The service URI for the webhook to post notifications.</p></summary>
        [Pure]
        public static AzureAcrWebhookUpdateSettings ResetUri(this AzureAcrWebhookUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Uri = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureAcrWebhookUpdateSettings SetAdd(this AzureAcrWebhookUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureAcrWebhookUpdateSettings ResetAdd(this AzureAcrWebhookUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region ForceString
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookUpdateSettings.ForceString"/>.</em></p><p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p></summary>
        [Pure]
        public static AzureAcrWebhookUpdateSettings SetForceString(this AzureAcrWebhookUpdateSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookUpdateSettings.ForceString"/>.</em></p><p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p></summary>
        [Pure]
        public static AzureAcrWebhookUpdateSettings ResetForceString(this AzureAcrWebhookUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureAcrWebhookUpdateSettings SetRemove(this AzureAcrWebhookUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureAcrWebhookUpdateSettings ResetRemove(this AzureAcrWebhookUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureAcrWebhookUpdateSettings SetSet(this AzureAcrWebhookUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureAcrWebhookUpdateSettings ResetSet(this AzureAcrWebhookUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrWebhookUpdateSettings SetDebug(this AzureAcrWebhookUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrWebhookUpdateSettings ResetDebug(this AzureAcrWebhookUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrWebhookUpdateSettings SetHelp(this AzureAcrWebhookUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrWebhookUpdateSettings ResetHelp(this AzureAcrWebhookUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrWebhookUpdateSettings SetOutput(this AzureAcrWebhookUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrWebhookUpdateSettings ResetOutput(this AzureAcrWebhookUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrWebhookUpdateSettings SetQuery(this AzureAcrWebhookUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrWebhookUpdateSettings ResetQuery(this AzureAcrWebhookUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrWebhookUpdateSettings SetVerbose(this AzureAcrWebhookUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrWebhookUpdateSettings ResetVerbose(this AzureAcrWebhookUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcrConfigContentTrustShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcrConfigContentTrustShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAcrConfigContentTrustShowSettings.Name"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrConfigContentTrustShowSettings SetName(this AzureAcrConfigContentTrustShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrConfigContentTrustShowSettings.Name"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrConfigContentTrustShowSettings ResetName(this AzureAcrConfigContentTrustShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAcrConfigContentTrustShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrConfigContentTrustShowSettings SetResourceGroup(this AzureAcrConfigContentTrustShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrConfigContentTrustShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrConfigContentTrustShowSettings ResetResourceGroup(this AzureAcrConfigContentTrustShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcrConfigContentTrustShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrConfigContentTrustShowSettings SetDebug(this AzureAcrConfigContentTrustShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrConfigContentTrustShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrConfigContentTrustShowSettings ResetDebug(this AzureAcrConfigContentTrustShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcrConfigContentTrustShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrConfigContentTrustShowSettings SetHelp(this AzureAcrConfigContentTrustShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrConfigContentTrustShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrConfigContentTrustShowSettings ResetHelp(this AzureAcrConfigContentTrustShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcrConfigContentTrustShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrConfigContentTrustShowSettings SetOutput(this AzureAcrConfigContentTrustShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrConfigContentTrustShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrConfigContentTrustShowSettings ResetOutput(this AzureAcrConfigContentTrustShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcrConfigContentTrustShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrConfigContentTrustShowSettings SetQuery(this AzureAcrConfigContentTrustShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrConfigContentTrustShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrConfigContentTrustShowSettings ResetQuery(this AzureAcrConfigContentTrustShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcrConfigContentTrustShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrConfigContentTrustShowSettings SetVerbose(this AzureAcrConfigContentTrustShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrConfigContentTrustShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrConfigContentTrustShowSettings ResetVerbose(this AzureAcrConfigContentTrustShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcrConfigContentTrustUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcrConfigContentTrustUpdateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAcrConfigContentTrustUpdateSettings.Name"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrConfigContentTrustUpdateSettings SetName(this AzureAcrConfigContentTrustUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrConfigContentTrustUpdateSettings.Name"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrConfigContentTrustUpdateSettings ResetName(this AzureAcrConfigContentTrustUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAcrConfigContentTrustUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrConfigContentTrustUpdateSettings SetResourceGroup(this AzureAcrConfigContentTrustUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrConfigContentTrustUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrConfigContentTrustUpdateSettings ResetResourceGroup(this AzureAcrConfigContentTrustUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Status
        /// <summary><p><em>Sets <see cref="AzureAcrConfigContentTrustUpdateSettings.Status"/>.</em></p><p>Indicates whether content-trust is enabled or disabled.</p></summary>
        [Pure]
        public static AzureAcrConfigContentTrustUpdateSettings SetStatus(this AzureAcrConfigContentTrustUpdateSettings toolSettings, AcrBuildTaskStatus status)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Status = status;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrConfigContentTrustUpdateSettings.Status"/>.</em></p><p>Indicates whether content-trust is enabled or disabled.</p></summary>
        [Pure]
        public static AzureAcrConfigContentTrustUpdateSettings ResetStatus(this AzureAcrConfigContentTrustUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Status = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcrConfigContentTrustUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrConfigContentTrustUpdateSettings SetDebug(this AzureAcrConfigContentTrustUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrConfigContentTrustUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrConfigContentTrustUpdateSettings ResetDebug(this AzureAcrConfigContentTrustUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcrConfigContentTrustUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrConfigContentTrustUpdateSettings SetHelp(this AzureAcrConfigContentTrustUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrConfigContentTrustUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrConfigContentTrustUpdateSettings ResetHelp(this AzureAcrConfigContentTrustUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcrConfigContentTrustUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrConfigContentTrustUpdateSettings SetOutput(this AzureAcrConfigContentTrustUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrConfigContentTrustUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrConfigContentTrustUpdateSettings ResetOutput(this AzureAcrConfigContentTrustUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcrConfigContentTrustUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrConfigContentTrustUpdateSettings SetQuery(this AzureAcrConfigContentTrustUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrConfigContentTrustUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrConfigContentTrustUpdateSettings ResetQuery(this AzureAcrConfigContentTrustUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcrConfigContentTrustUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrConfigContentTrustUpdateSettings SetVerbose(this AzureAcrConfigContentTrustUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrConfigContentTrustUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrConfigContentTrustUpdateSettings ResetVerbose(this AzureAcrConfigContentTrustUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AcrOs
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class AcrOs : Enumeration
    {
        public static AcrOs linux = new AcrOs { Value = "linux" };
        public static AcrOs windows = new AcrOs { Value = "windows" };
    }
    #endregion
    #region AcrSku
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class AcrSku : Enumeration
    {
        public static AcrSku basic = new AcrSku { Value = "basic" };
        public static AcrSku classic = new AcrSku { Value = "classic" };
        public static AcrSku premium = new AcrSku { Value = "premium" };
        public static AcrSku standard = new AcrSku { Value = "standard" };
    }
    #endregion
    #region AcrBuildTaskBaseImageTrigger
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class AcrBuildTaskBaseImageTrigger : Enumeration
    {
        public static AcrBuildTaskBaseImageTrigger all = new AcrBuildTaskBaseImageTrigger { Value = "all" };
        public static AcrBuildTaskBaseImageTrigger none = new AcrBuildTaskBaseImageTrigger { Value = "none" };
        public static AcrBuildTaskBaseImageTrigger runtime = new AcrBuildTaskBaseImageTrigger { Value = "runtime" };
    }
    #endregion
    #region AcrBuildTaskStatus
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class AcrBuildTaskStatus : Enumeration
    {
        public static AcrBuildTaskStatus disabled = new AcrBuildTaskStatus { Value = "disabled" };
        public static AcrBuildTaskStatus enabled = new AcrBuildTaskStatus { Value = "enabled" };
    }
    #endregion
    #region AcrBuildTaskListBuildsBuildStatus
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class AcrBuildTaskListBuildsBuildStatus : Enumeration
    {
        public static AcrBuildTaskListBuildsBuildStatus canceled = new AcrBuildTaskListBuildsBuildStatus { Value = "canceled" };
        public static AcrBuildTaskListBuildsBuildStatus error = new AcrBuildTaskListBuildsBuildStatus { Value = "error" };
        public static AcrBuildTaskListBuildsBuildStatus failed = new AcrBuildTaskListBuildsBuildStatus { Value = "failed" };
        public static AcrBuildTaskListBuildsBuildStatus queued = new AcrBuildTaskListBuildsBuildStatus { Value = "queued" };
        public static AcrBuildTaskListBuildsBuildStatus running = new AcrBuildTaskListBuildsBuildStatus { Value = "running" };
        public static AcrBuildTaskListBuildsBuildStatus started = new AcrBuildTaskListBuildsBuildStatus { Value = "started" };
        public static AcrBuildTaskListBuildsBuildStatus succeeded = new AcrBuildTaskListBuildsBuildStatus { Value = "succeeded" };
        public static AcrBuildTaskListBuildsBuildStatus timeout = new AcrBuildTaskListBuildsBuildStatus { Value = "timeout" };
    }
    #endregion
    #region AcrCredentialRenewPasswordName
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class AcrCredentialRenewPasswordName : Enumeration
    {
        public static AcrCredentialRenewPasswordName password = new AcrCredentialRenewPasswordName { Value = "password" };
        public static AcrCredentialRenewPasswordName password2 = new AcrCredentialRenewPasswordName { Value = "password2" };
    }
    #endregion
    #region AcrRepositoryOrderby
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class AcrRepositoryOrderby : Enumeration
    {
        public static AcrRepositoryOrderby time_asc = new AcrRepositoryOrderby { Value = "time_asc" };
        public static AcrRepositoryOrderby time_desc = new AcrRepositoryOrderby { Value = "time_desc" };
    }
    #endregion
    #region AcrWebhookActions
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class AcrWebhookActions : Enumeration
    {
        public static AcrWebhookActions delete = new AcrWebhookActions { Value = "delete" };
        public static AcrWebhookActions push = new AcrWebhookActions { Value = "push" };
        public static AcrWebhookActions quarantine = new AcrWebhookActions { Value = "quarantine" };
    }
    #endregion
}
