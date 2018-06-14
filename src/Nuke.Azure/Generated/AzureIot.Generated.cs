// Copyright Matthias Koch, Sebastian Karasek 2018.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

// Generated with Nuke.CodeGeneration, Version: 0.5.3 [CommitSha: 0aff3c55].
// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/AzureIot.json.

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
    public static partial class AzureIotTasks
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public static string AzureIotPath => ToolPathResolver.GetPathExecutable("az");
        /// <summary><p>(PREVIEW) Manage Internet of Things (IoT) assets.</p></summary>
        public static IEnumerable<string> AzureIot(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool redirectOutput = false, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzureIotPath, arguments, workingDirectory, environmentVariables, timeout, redirectOutput, outputFilter);
            process.AssertZeroExitCode();
            return process.HasOutput ? process.Output.Select(x => x.Text) : null;
        }
        static partial void PreProcess(AzureIotSettings toolSettings);
        static partial void PostProcess(AzureIotSettings toolSettings);
        /// <summary><p>(PREVIEW) Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureIot(Configure<AzureIotSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureIotDeviceCreateSettings toolSettings);
        static partial void PostProcess(AzureIotDeviceCreateSettings toolSettings);
        /// <summary><p>(PREVIEW) Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureIotDeviceCreate(Configure<AzureIotDeviceCreateSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotDeviceCreateSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureIotDeviceDeleteSettings toolSettings);
        static partial void PostProcess(AzureIotDeviceDeleteSettings toolSettings);
        /// <summary><p>(PREVIEW) Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureIotDeviceDelete(Configure<AzureIotDeviceDeleteSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotDeviceDeleteSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureIotDeviceExportSettings toolSettings);
        static partial void PostProcess(AzureIotDeviceExportSettings toolSettings);
        /// <summary><p>(PREVIEW) Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureIotDeviceExport(Configure<AzureIotDeviceExportSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotDeviceExportSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureIotDeviceImportSettings toolSettings);
        static partial void PostProcess(AzureIotDeviceImportSettings toolSettings);
        /// <summary><p>(PREVIEW) Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureIotDeviceImport(Configure<AzureIotDeviceImportSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotDeviceImportSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureIotDeviceListSettings toolSettings);
        static partial void PostProcess(AzureIotDeviceListSettings toolSettings);
        /// <summary><p>(PREVIEW) Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureIotDeviceList(Configure<AzureIotDeviceListSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotDeviceListSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureIotDeviceShowSettings toolSettings);
        static partial void PostProcess(AzureIotDeviceShowSettings toolSettings);
        /// <summary><p>(PREVIEW) Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureIotDeviceShow(Configure<AzureIotDeviceShowSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotDeviceShowSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureIotDeviceShowConnectionStringSettings toolSettings);
        static partial void PostProcess(AzureIotDeviceShowConnectionStringSettings toolSettings);
        /// <summary><p>(PREVIEW) Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureIotDeviceShowConnectionString(Configure<AzureIotDeviceShowConnectionStringSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotDeviceShowConnectionStringSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureIotDeviceUpdateSettings toolSettings);
        static partial void PostProcess(AzureIotDeviceUpdateSettings toolSettings);
        /// <summary><p>(PREVIEW) Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureIotDeviceUpdate(Configure<AzureIotDeviceUpdateSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotDeviceUpdateSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureIotDpsCreateSettings toolSettings);
        static partial void PostProcess(AzureIotDpsCreateSettings toolSettings);
        /// <summary><p>(PREVIEW) Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureIotDpsCreate(Configure<AzureIotDpsCreateSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotDpsCreateSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureIotDpsDeleteSettings toolSettings);
        static partial void PostProcess(AzureIotDpsDeleteSettings toolSettings);
        /// <summary><p>(PREVIEW) Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureIotDpsDelete(Configure<AzureIotDpsDeleteSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotDpsDeleteSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureIotDpsListSettings toolSettings);
        static partial void PostProcess(AzureIotDpsListSettings toolSettings);
        /// <summary><p>(PREVIEW) Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureIotDpsList(Configure<AzureIotDpsListSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotDpsListSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureIotDpsShowSettings toolSettings);
        static partial void PostProcess(AzureIotDpsShowSettings toolSettings);
        /// <summary><p>(PREVIEW) Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureIotDpsShow(Configure<AzureIotDpsShowSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotDpsShowSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureIotDpsUpdateSettings toolSettings);
        static partial void PostProcess(AzureIotDpsUpdateSettings toolSettings);
        /// <summary><p>(PREVIEW) Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureIotDpsUpdate(Configure<AzureIotDpsUpdateSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotDpsUpdateSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureIotHubCreateSettings toolSettings);
        static partial void PostProcess(AzureIotHubCreateSettings toolSettings);
        /// <summary><p>(PREVIEW) Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureIotHubCreate(Configure<AzureIotHubCreateSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotHubCreateSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureIotHubDeleteSettings toolSettings);
        static partial void PostProcess(AzureIotHubDeleteSettings toolSettings);
        /// <summary><p>(PREVIEW) Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureIotHubDelete(Configure<AzureIotHubDeleteSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotHubDeleteSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureIotHubListSettings toolSettings);
        static partial void PostProcess(AzureIotHubListSettings toolSettings);
        /// <summary><p>(PREVIEW) Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureIotHubList(Configure<AzureIotHubListSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotHubListSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureIotHubListSkusSettings toolSettings);
        static partial void PostProcess(AzureIotHubListSkusSettings toolSettings);
        /// <summary><p>(PREVIEW) Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureIotHubListSkus(Configure<AzureIotHubListSkusSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotHubListSkusSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureIotHubShowSettings toolSettings);
        static partial void PostProcess(AzureIotHubShowSettings toolSettings);
        /// <summary><p>(PREVIEW) Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureIotHubShow(Configure<AzureIotHubShowSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotHubShowSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureIotHubShowConnectionStringSettings toolSettings);
        static partial void PostProcess(AzureIotHubShowConnectionStringSettings toolSettings);
        /// <summary><p>(PREVIEW) Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureIotHubShowConnectionString(Configure<AzureIotHubShowConnectionStringSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotHubShowConnectionStringSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureIotHubShowQuotaMetricsSettings toolSettings);
        static partial void PostProcess(AzureIotHubShowQuotaMetricsSettings toolSettings);
        /// <summary><p>(PREVIEW) Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureIotHubShowQuotaMetrics(Configure<AzureIotHubShowQuotaMetricsSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotHubShowQuotaMetricsSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureIotHubShowStatsSettings toolSettings);
        static partial void PostProcess(AzureIotHubShowStatsSettings toolSettings);
        /// <summary><p>(PREVIEW) Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureIotHubShowStats(Configure<AzureIotHubShowStatsSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotHubShowStatsSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureIotHubUpdateSettings toolSettings);
        static partial void PostProcess(AzureIotHubUpdateSettings toolSettings);
        /// <summary><p>(PREVIEW) Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureIotHubUpdate(Configure<AzureIotHubUpdateSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotHubUpdateSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureIotDeviceMessageAbandonSettings toolSettings);
        static partial void PostProcess(AzureIotDeviceMessageAbandonSettings toolSettings);
        /// <summary><p>(PREVIEW) Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureIotDeviceMessageAbandon(Configure<AzureIotDeviceMessageAbandonSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotDeviceMessageAbandonSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureIotDeviceMessageCompleteSettings toolSettings);
        static partial void PostProcess(AzureIotDeviceMessageCompleteSettings toolSettings);
        /// <summary><p>(PREVIEW) Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureIotDeviceMessageComplete(Configure<AzureIotDeviceMessageCompleteSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotDeviceMessageCompleteSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureIotDeviceMessageReceiveSettings toolSettings);
        static partial void PostProcess(AzureIotDeviceMessageReceiveSettings toolSettings);
        /// <summary><p>(PREVIEW) Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureIotDeviceMessageReceive(Configure<AzureIotDeviceMessageReceiveSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotDeviceMessageReceiveSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureIotDeviceMessageRejectSettings toolSettings);
        static partial void PostProcess(AzureIotDeviceMessageRejectSettings toolSettings);
        /// <summary><p>(PREVIEW) Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureIotDeviceMessageReject(Configure<AzureIotDeviceMessageRejectSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotDeviceMessageRejectSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureIotDeviceMessageSendSettings toolSettings);
        static partial void PostProcess(AzureIotDeviceMessageSendSettings toolSettings);
        /// <summary><p>(PREVIEW) Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureIotDeviceMessageSend(Configure<AzureIotDeviceMessageSendSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotDeviceMessageSendSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureIotDpsAccessPolicyCreateSettings toolSettings);
        static partial void PostProcess(AzureIotDpsAccessPolicyCreateSettings toolSettings);
        /// <summary><p>(PREVIEW) Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureIotDpsAccessPolicyCreate(Configure<AzureIotDpsAccessPolicyCreateSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotDpsAccessPolicyCreateSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureIotDpsAccessPolicyDeleteSettings toolSettings);
        static partial void PostProcess(AzureIotDpsAccessPolicyDeleteSettings toolSettings);
        /// <summary><p>(PREVIEW) Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureIotDpsAccessPolicyDelete(Configure<AzureIotDpsAccessPolicyDeleteSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotDpsAccessPolicyDeleteSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureIotDpsAccessPolicyListSettings toolSettings);
        static partial void PostProcess(AzureIotDpsAccessPolicyListSettings toolSettings);
        /// <summary><p>(PREVIEW) Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureIotDpsAccessPolicyList(Configure<AzureIotDpsAccessPolicyListSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotDpsAccessPolicyListSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureIotDpsAccessPolicyShowSettings toolSettings);
        static partial void PostProcess(AzureIotDpsAccessPolicyShowSettings toolSettings);
        /// <summary><p>(PREVIEW) Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureIotDpsAccessPolicyShow(Configure<AzureIotDpsAccessPolicyShowSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotDpsAccessPolicyShowSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureIotDpsAccessPolicyUpdateSettings toolSettings);
        static partial void PostProcess(AzureIotDpsAccessPolicyUpdateSettings toolSettings);
        /// <summary><p>(PREVIEW) Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureIotDpsAccessPolicyUpdate(Configure<AzureIotDpsAccessPolicyUpdateSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotDpsAccessPolicyUpdateSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureIotDpsCertificateCreateSettings toolSettings);
        static partial void PostProcess(AzureIotDpsCertificateCreateSettings toolSettings);
        /// <summary><p>(PREVIEW) Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureIotDpsCertificateCreate(Configure<AzureIotDpsCertificateCreateSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotDpsCertificateCreateSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureIotDpsCertificateDeleteSettings toolSettings);
        static partial void PostProcess(AzureIotDpsCertificateDeleteSettings toolSettings);
        /// <summary><p>(PREVIEW) Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureIotDpsCertificateDelete(Configure<AzureIotDpsCertificateDeleteSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotDpsCertificateDeleteSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureIotDpsCertificateGenerateVerificationCodeSettings toolSettings);
        static partial void PostProcess(AzureIotDpsCertificateGenerateVerificationCodeSettings toolSettings);
        /// <summary><p>(PREVIEW) Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureIotDpsCertificateGenerateVerificationCode(Configure<AzureIotDpsCertificateGenerateVerificationCodeSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotDpsCertificateGenerateVerificationCodeSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureIotDpsCertificateListSettings toolSettings);
        static partial void PostProcess(AzureIotDpsCertificateListSettings toolSettings);
        /// <summary><p>(PREVIEW) Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureIotDpsCertificateList(Configure<AzureIotDpsCertificateListSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotDpsCertificateListSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureIotDpsCertificateShowSettings toolSettings);
        static partial void PostProcess(AzureIotDpsCertificateShowSettings toolSettings);
        /// <summary><p>(PREVIEW) Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureIotDpsCertificateShow(Configure<AzureIotDpsCertificateShowSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotDpsCertificateShowSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureIotDpsCertificateUpdateSettings toolSettings);
        static partial void PostProcess(AzureIotDpsCertificateUpdateSettings toolSettings);
        /// <summary><p>(PREVIEW) Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureIotDpsCertificateUpdate(Configure<AzureIotDpsCertificateUpdateSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotDpsCertificateUpdateSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureIotDpsCertificateVerifySettings toolSettings);
        static partial void PostProcess(AzureIotDpsCertificateVerifySettings toolSettings);
        /// <summary><p>(PREVIEW) Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureIotDpsCertificateVerify(Configure<AzureIotDpsCertificateVerifySettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotDpsCertificateVerifySettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureIotDpsLinkedHubCreateSettings toolSettings);
        static partial void PostProcess(AzureIotDpsLinkedHubCreateSettings toolSettings);
        /// <summary><p>(PREVIEW) Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureIotDpsLinkedHubCreate(Configure<AzureIotDpsLinkedHubCreateSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotDpsLinkedHubCreateSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureIotDpsLinkedHubDeleteSettings toolSettings);
        static partial void PostProcess(AzureIotDpsLinkedHubDeleteSettings toolSettings);
        /// <summary><p>(PREVIEW) Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureIotDpsLinkedHubDelete(Configure<AzureIotDpsLinkedHubDeleteSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotDpsLinkedHubDeleteSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureIotDpsLinkedHubListSettings toolSettings);
        static partial void PostProcess(AzureIotDpsLinkedHubListSettings toolSettings);
        /// <summary><p>(PREVIEW) Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureIotDpsLinkedHubList(Configure<AzureIotDpsLinkedHubListSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotDpsLinkedHubListSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureIotDpsLinkedHubShowSettings toolSettings);
        static partial void PostProcess(AzureIotDpsLinkedHubShowSettings toolSettings);
        /// <summary><p>(PREVIEW) Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureIotDpsLinkedHubShow(Configure<AzureIotDpsLinkedHubShowSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotDpsLinkedHubShowSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureIotDpsLinkedHubUpdateSettings toolSettings);
        static partial void PostProcess(AzureIotDpsLinkedHubUpdateSettings toolSettings);
        /// <summary><p>(PREVIEW) Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureIotDpsLinkedHubUpdate(Configure<AzureIotDpsLinkedHubUpdateSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotDpsLinkedHubUpdateSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureIotHubCertificateCreateSettings toolSettings);
        static partial void PostProcess(AzureIotHubCertificateCreateSettings toolSettings);
        /// <summary><p>(PREVIEW) Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureIotHubCertificateCreate(Configure<AzureIotHubCertificateCreateSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotHubCertificateCreateSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureIotHubCertificateDeleteSettings toolSettings);
        static partial void PostProcess(AzureIotHubCertificateDeleteSettings toolSettings);
        /// <summary><p>(PREVIEW) Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureIotHubCertificateDelete(Configure<AzureIotHubCertificateDeleteSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotHubCertificateDeleteSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureIotHubCertificateGenerateVerificationCodeSettings toolSettings);
        static partial void PostProcess(AzureIotHubCertificateGenerateVerificationCodeSettings toolSettings);
        /// <summary><p>(PREVIEW) Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureIotHubCertificateGenerateVerificationCode(Configure<AzureIotHubCertificateGenerateVerificationCodeSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotHubCertificateGenerateVerificationCodeSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureIotHubCertificateListSettings toolSettings);
        static partial void PostProcess(AzureIotHubCertificateListSettings toolSettings);
        /// <summary><p>(PREVIEW) Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureIotHubCertificateList(Configure<AzureIotHubCertificateListSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotHubCertificateListSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureIotHubCertificateShowSettings toolSettings);
        static partial void PostProcess(AzureIotHubCertificateShowSettings toolSettings);
        /// <summary><p>(PREVIEW) Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureIotHubCertificateShow(Configure<AzureIotHubCertificateShowSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotHubCertificateShowSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureIotHubCertificateUpdateSettings toolSettings);
        static partial void PostProcess(AzureIotHubCertificateUpdateSettings toolSettings);
        /// <summary><p>(PREVIEW) Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureIotHubCertificateUpdate(Configure<AzureIotHubCertificateUpdateSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotHubCertificateUpdateSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureIotHubCertificateVerifySettings toolSettings);
        static partial void PostProcess(AzureIotHubCertificateVerifySettings toolSettings);
        /// <summary><p>(PREVIEW) Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureIotHubCertificateVerify(Configure<AzureIotHubCertificateVerifySettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotHubCertificateVerifySettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureIotHubConsumerGroupCreateSettings toolSettings);
        static partial void PostProcess(AzureIotHubConsumerGroupCreateSettings toolSettings);
        /// <summary><p>(PREVIEW) Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureIotHubConsumerGroupCreate(Configure<AzureIotHubConsumerGroupCreateSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotHubConsumerGroupCreateSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureIotHubConsumerGroupDeleteSettings toolSettings);
        static partial void PostProcess(AzureIotHubConsumerGroupDeleteSettings toolSettings);
        /// <summary><p>(PREVIEW) Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureIotHubConsumerGroupDelete(Configure<AzureIotHubConsumerGroupDeleteSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotHubConsumerGroupDeleteSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureIotHubConsumerGroupListSettings toolSettings);
        static partial void PostProcess(AzureIotHubConsumerGroupListSettings toolSettings);
        /// <summary><p>(PREVIEW) Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureIotHubConsumerGroupList(Configure<AzureIotHubConsumerGroupListSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotHubConsumerGroupListSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureIotHubConsumerGroupShowSettings toolSettings);
        static partial void PostProcess(AzureIotHubConsumerGroupShowSettings toolSettings);
        /// <summary><p>(PREVIEW) Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureIotHubConsumerGroupShow(Configure<AzureIotHubConsumerGroupShowSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotHubConsumerGroupShowSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureIotHubJobCancelSettings toolSettings);
        static partial void PostProcess(AzureIotHubJobCancelSettings toolSettings);
        /// <summary><p>(PREVIEW) Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureIotHubJobCancel(Configure<AzureIotHubJobCancelSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotHubJobCancelSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureIotHubJobListSettings toolSettings);
        static partial void PostProcess(AzureIotHubJobListSettings toolSettings);
        /// <summary><p>(PREVIEW) Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureIotHubJobList(Configure<AzureIotHubJobListSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotHubJobListSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureIotHubJobShowSettings toolSettings);
        static partial void PostProcess(AzureIotHubJobShowSettings toolSettings);
        /// <summary><p>(PREVIEW) Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureIotHubJobShow(Configure<AzureIotHubJobShowSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotHubJobShowSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureIotHubPolicyCreateSettings toolSettings);
        static partial void PostProcess(AzureIotHubPolicyCreateSettings toolSettings);
        /// <summary><p>(PREVIEW) Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureIotHubPolicyCreate(Configure<AzureIotHubPolicyCreateSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotHubPolicyCreateSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureIotHubPolicyDeleteSettings toolSettings);
        static partial void PostProcess(AzureIotHubPolicyDeleteSettings toolSettings);
        /// <summary><p>(PREVIEW) Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureIotHubPolicyDelete(Configure<AzureIotHubPolicyDeleteSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotHubPolicyDeleteSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureIotHubPolicyListSettings toolSettings);
        static partial void PostProcess(AzureIotHubPolicyListSettings toolSettings);
        /// <summary><p>(PREVIEW) Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureIotHubPolicyList(Configure<AzureIotHubPolicyListSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotHubPolicyListSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureIotHubPolicyShowSettings toolSettings);
        static partial void PostProcess(AzureIotHubPolicyShowSettings toolSettings);
        /// <summary><p>(PREVIEW) Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureIotHubPolicyShow(Configure<AzureIotHubPolicyShowSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotHubPolicyShowSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
    }
    #region AzureIotSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
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
              .Add("iot")
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureIotDeviceCreateSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotDeviceCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>Device Id.</p></summary>
        public virtual string DeviceId { get; internal set; }
        /// <summary><p>IoT Hub name.</p></summary>
        public virtual string HubName { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Output directory for generated self-signed X.509 certificate. Default is current working directory.</p></summary>
        public virtual string OutputDir { get; internal set; }
        /// <summary><p>Primary X.509 certificate thumbprint to authenticate device.</p></summary>
        public virtual string PrimaryThumbprint { get; internal set; }
        /// <summary><p>Secondary X.509 certificate thumbprint to authenticate device.</p></summary>
        public virtual string SecondaryThumbprint { get; internal set; }
        /// <summary><p>Number of days the generated self-signed X.509 certificate should be valid for. Default validity is 365 days.</p></summary>
        public virtual int? ValidDays { get; internal set; }
        /// <summary><p>Use X.509 certificate for device authentication.</p></summary>
        public virtual string X509 { get; internal set; }
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
              .Add("iot device create")
              .Add("--device-id {value}", DeviceId)
              .Add("--hub-name {value}", HubName)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--output-dir {value}", OutputDir)
              .Add("--primary-thumbprint {value}", PrimaryThumbprint)
              .Add("--secondary-thumbprint {value}", SecondaryThumbprint)
              .Add("--valid-days {value}", ValidDays)
              .Add("--x509 {value}", X509)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureIotDeviceDeleteSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotDeviceDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>Device Id.</p></summary>
        public virtual string DeviceId { get; internal set; }
        /// <summary><p>IoT Hub name.</p></summary>
        public virtual string HubName { get; internal set; }
        /// <summary><p>ETag of the target device. It is used for the purpose of optimistic concurrency. Delete operation will be performed only if the specified ETag matches the value maintained by the server, indicating that the device identity has not been modified since it was retrieved. Default value is set to wildcard character (*) to force an unconditional delete.</p></summary>
        public virtual string Etag { get; internal set; }
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
              .Add("iot device delete")
              .Add("--device-id {value}", DeviceId)
              .Add("--hub-name {value}", HubName)
              .Add("--etag {value}", Etag)
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
    #region AzureIotDeviceExportSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotDeviceExportSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>Blob Shared Access Signature URI with write access to a blob container.This is used to output the status of the job and the results.</p></summary>
        public virtual string BlobContainerUri { get; internal set; }
        /// <summary><p>IoT Hub name.</p></summary>
        public virtual string HubName { get; internal set; }
        /// <summary><p>If set, keys are exported normally. Otherwise, keys are set to null in export output.</p></summary>
        public virtual string IncludeKeys { get; internal set; }
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
              .Add("iot device export")
              .Add("--blob-container-uri {value}", BlobContainerUri)
              .Add("--hub-name {value}", HubName)
              .Add("--include-keys {value}", IncludeKeys)
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
    #region AzureIotDeviceImportSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotDeviceImportSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>IoT Hub name.</p></summary>
        public virtual string HubName { get; internal set; }
        /// <summary><p>Blob Shared Access Signature URI with read access to a blob container.This blob contains the operations to be performed on the identity registry.</p></summary>
        public virtual string InputBlobContainerUri { get; internal set; }
        /// <summary><p>Blob Shared Access Signature URI with write access to a blob container.This is used to output the status of the job and the results.</p></summary>
        public virtual string OutputBlobContainerUri { get; internal set; }
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
              .Add("iot device import")
              .Add("--hub-name {value}", HubName)
              .Add("--input-blob-container-uri {value}", InputBlobContainerUri)
              .Add("--output-blob-container-uri {value}", OutputBlobContainerUri)
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
    #region AzureIotDeviceListSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotDeviceListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>IoT Hub name.</p></summary>
        public virtual string HubName { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Maximum number of device identities to return.</p></summary>
        public virtual string Top { get; internal set; }
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
              .Add("iot device list")
              .Add("--hub-name {value}", HubName)
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
    #region AzureIotDeviceShowSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotDeviceShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>Device Id.</p></summary>
        public virtual string DeviceId { get; internal set; }
        /// <summary><p>IoT Hub name.</p></summary>
        public virtual string HubName { get; internal set; }
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
              .Add("iot device show")
              .Add("--device-id {value}", DeviceId)
              .Add("--hub-name {value}", HubName)
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
    #region AzureIotDeviceShowConnectionStringSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotDeviceShowConnectionStringSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>IoT Hub name.</p></summary>
        public virtual string HubName { get; internal set; }
        /// <summary><p>Device Id.</p></summary>
        public virtual string DeviceId { get; internal set; }
        /// <summary><p>The key to use.</p></summary>
        public virtual IotDeviceKey Key { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Maximum number of connection strings to return.</p></summary>
        public virtual string Top { get; internal set; }
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
              .Add("iot device show-connection-string")
              .Add("--hub-name {value}", HubName)
              .Add("--device-id {value}", DeviceId)
              .Add("--key {value}", Key)
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
    #region AzureIotDeviceUpdateSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotDeviceUpdateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>Device Id.</p></summary>
        public virtual string DeviceId { get; internal set; }
        /// <summary><p>IoT Hub name.</p></summary>
        public virtual string HubName { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
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
              .Add("iot device update")
              .Add("--device-id {value}", DeviceId)
              .Add("--hub-name {value}", HubName)
              .Add("--resource-group {value}", ResourceGroup)
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
    #region AzureIotDpsCreateSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotDpsCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>IoT Provisioning Service name.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Location of your IoT Provisioning Service. Default is the location of target resource group.</p></summary>
        public virtual string Location { get; internal set; }
        /// <summary><p>Pricing tier for the IoT provisioning service.</p></summary>
        public virtual IotDpsCreateSku Sku { get; internal set; }
        /// <summary><p>Units in your IoT Provisioning Service.</p></summary>
        public virtual string Unit { get; internal set; }
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
              .Add("iot dps create")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--location {value}", Location)
              .Add("--sku {value}", Sku)
              .Add("--unit {value}", Unit)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureIotDpsDeleteSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotDpsDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>IoT Provisioning Service name.</p></summary>
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
              .Add("iot dps delete")
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
    #region AzureIotDpsListSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotDpsListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
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
              .Add("iot dps list")
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
    #region AzureIotDpsShowSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotDpsShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>IoT Provisioning Service name.</p></summary>
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
              .Add("iot dps show")
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
    #region AzureIotDpsUpdateSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotDpsUpdateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>IoT Provisioning Service name.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
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
              .Add("iot dps update")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
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
    #region AzureIotHubCreateSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotHubCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>IoT Hub name.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Location of your IoT Hub. Default is the location of target resource group.</p></summary>
        public virtual string Location { get; internal set; }
        /// <summary><p>The number of partitions for device-to-cloud messages.</p></summary>
        public virtual string PartitionCount { get; internal set; }
        /// <summary><p>Pricing tier for Azure IoT Hub. Default value is F1, which is free. Note that only one free IoT hub instance is allowed in each subscription. Exception will be thrown if free instances exceed one.</p></summary>
        public virtual IotHubCreateSku Sku { get; internal set; }
        /// <summary><p>Units in your IoT Hub.</p></summary>
        public virtual string Unit { get; internal set; }
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
              .Add("iot hub create")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--location {value}", Location)
              .Add("--partition-count {value}", PartitionCount)
              .Add("--sku {value}", Sku)
              .Add("--unit {value}", Unit)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureIotHubDeleteSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotHubDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>IoT Hub name.</p></summary>
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
              .Add("iot hub delete")
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
    #region AzureIotHubListSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotHubListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
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
              .Add("iot hub list")
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
    #region AzureIotHubListSkusSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotHubListSkusSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>IoT Hub name.</p></summary>
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
              .Add("iot hub list-skus")
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
    #region AzureIotHubShowSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotHubShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>IoT Hub name.</p></summary>
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
              .Add("iot hub show")
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
    #region AzureIotHubShowConnectionStringSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotHubShowConnectionStringSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>IoT Hub name.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>The key to use.</p></summary>
        public virtual IotDeviceKey Key { get; internal set; }
        /// <summary><p>Shared access policy to use.</p></summary>
        public virtual string PolicyName { get; internal set; }
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
              .Add("iot hub show-connection-string")
              .Add("--name {value}", Name)
              .Add("--key {value}", Key)
              .Add("--policy-name {value}", PolicyName)
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
    #region AzureIotHubShowQuotaMetricsSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotHubShowQuotaMetricsSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>IoT Hub name.</p></summary>
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
              .Add("iot hub show-quota-metrics")
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
    #region AzureIotHubShowStatsSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotHubShowStatsSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>IoT Hub name.</p></summary>
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
              .Add("iot hub show-stats")
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
    #region AzureIotHubUpdateSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotHubUpdateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>IoT Hub name.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
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
              .Add("iot hub update")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
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
    #region AzureIotDeviceMessageAbandonSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotDeviceMessageAbandonSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>Device Id.</p></summary>
        public virtual string DeviceId { get; internal set; }
        /// <summary><p>IoT Hub name.</p></summary>
        public virtual string HubName { get; internal set; }
        /// <summary><p>Message lock token.</p></summary>
        public virtual string LockToken { get; internal set; }
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
              .Add("iot device message abandon")
              .Add("--device-id {value}", DeviceId)
              .Add("--hub-name {value}", HubName)
              .Add("--lock-token {value}", LockToken)
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
    #region AzureIotDeviceMessageCompleteSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotDeviceMessageCompleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>Device Id.</p></summary>
        public virtual string DeviceId { get; internal set; }
        /// <summary><p>IoT Hub name.</p></summary>
        public virtual string HubName { get; internal set; }
        /// <summary><p>Message lock token.</p></summary>
        public virtual string LockToken { get; internal set; }
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
              .Add("iot device message complete")
              .Add("--device-id {value}", DeviceId)
              .Add("--hub-name {value}", HubName)
              .Add("--lock-token {value}", LockToken)
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
    #region AzureIotDeviceMessageReceiveSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotDeviceMessageReceiveSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>Device Id.</p></summary>
        public virtual string DeviceId { get; internal set; }
        /// <summary><p>IoT Hub name.</p></summary>
        public virtual string HubName { get; internal set; }
        /// <summary><p>In case a message returned to this call, this specifies the amount of time in seconds, the message will be invisible to other receive calls.</p></summary>
        public virtual string LockTimeout { get; internal set; }
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
              .Add("iot device message receive")
              .Add("--device-id {value}", DeviceId)
              .Add("--hub-name {value}", HubName)
              .Add("--lock-timeout {value}", LockTimeout)
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
    #region AzureIotDeviceMessageRejectSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotDeviceMessageRejectSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>Device Id.</p></summary>
        public virtual string DeviceId { get; internal set; }
        /// <summary><p>IoT Hub name.</p></summary>
        public virtual string HubName { get; internal set; }
        /// <summary><p>Message lock token.</p></summary>
        public virtual string LockToken { get; internal set; }
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
              .Add("iot device message reject")
              .Add("--device-id {value}", DeviceId)
              .Add("--hub-name {value}", HubName)
              .Add("--lock-token {value}", LockToken)
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
    #region AzureIotDeviceMessageSendSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotDeviceMessageSendSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>Device Id.</p></summary>
        public virtual string DeviceId { get; internal set; }
        /// <summary><p>IoT Hub name.</p></summary>
        public virtual string HubName { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Device-to-cloud message correlation Id.</p></summary>
        public virtual string CorrelationId { get; internal set; }
        /// <summary><p>Device-to-cloud message body.</p></summary>
        public virtual string Data { get; internal set; }
        /// <summary><p>Device-to-cloud message Id.</p></summary>
        public virtual string MessageId { get; internal set; }
        /// <summary><p>Device-to-cloud message user Id.</p></summary>
        public virtual string UserId { get; internal set; }
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
              .Add("iot device message send")
              .Add("--device-id {value}", DeviceId)
              .Add("--hub-name {value}", HubName)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--correlation-id {value}", CorrelationId)
              .Add("--data {value}", Data)
              .Add("--message-id {value}", MessageId)
              .Add("--user-id {value}", UserId)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureIotDpsAccessPolicyCreateSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotDpsAccessPolicyCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>A friendly name for DPS access policy.</p></summary>
        public virtual string AccessPolicyName { get; internal set; }
        /// <summary><p>IoT Provisioning Service name.</p></summary>
        public virtual string DpsName { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Access rights for the IoT provisioning service. Use space-separated list for multiple rights.</p></summary>
        public virtual IotDpsAccessPolicyRights Rights { get; internal set; }
        /// <summary><p>Do not wait for the long-running operation to finish.</p></summary>
        public virtual string NoWait { get; internal set; }
        /// <summary><p>Primary SAS key value.</p></summary>
        public virtual string PrimaryKey { get; internal set; }
        /// <summary><p>Secondary SAS key value.</p></summary>
        public virtual string SecondaryKey { get; internal set; }
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
              .Add("iot dps access-policy create")
              .Add("--access-policy-name {value}", AccessPolicyName)
              .Add("--dps-name {value}", DpsName)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--rights {value}", Rights)
              .Add("--no-wait {value}", NoWait)
              .Add("--primary-key {value}", PrimaryKey)
              .Add("--secondary-key {value}", SecondaryKey)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureIotDpsAccessPolicyDeleteSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotDpsAccessPolicyDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>A friendly name for DPS access policy.</p></summary>
        public virtual string AccessPolicyName { get; internal set; }
        /// <summary><p>IoT Provisioning Service name.</p></summary>
        public virtual string DpsName { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
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
              .Add("iot dps access-policy delete")
              .Add("--access-policy-name {value}", AccessPolicyName)
              .Add("--dps-name {value}", DpsName)
              .Add("--resource-group {value}", ResourceGroup)
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
    #region AzureIotDpsAccessPolicyListSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotDpsAccessPolicyListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>IoT Provisioning Service name.</p></summary>
        public virtual string DpsName { get; internal set; }
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
              .Add("iot dps access-policy list")
              .Add("--dps-name {value}", DpsName)
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
    #region AzureIotDpsAccessPolicyShowSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotDpsAccessPolicyShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>A friendly name for DPS access policy.</p></summary>
        public virtual string AccessPolicyName { get; internal set; }
        /// <summary><p>IoT Provisioning Service name.</p></summary>
        public virtual string DpsName { get; internal set; }
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
              .Add("iot dps access-policy show")
              .Add("--access-policy-name {value}", AccessPolicyName)
              .Add("--dps-name {value}", DpsName)
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
    #region AzureIotDpsAccessPolicyUpdateSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotDpsAccessPolicyUpdateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>A friendly name for DPS access policy.</p></summary>
        public virtual string AccessPolicyName { get; internal set; }
        /// <summary><p>IoT Provisioning Service name.</p></summary>
        public virtual string DpsName { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Do not wait for the long-running operation to finish.</p></summary>
        public virtual string NoWait { get; internal set; }
        /// <summary><p>Primary SAS key value.</p></summary>
        public virtual string PrimaryKey { get; internal set; }
        /// <summary><p>Access rights for the IoT provisioning service. Use space-separated list for multiple rights.</p></summary>
        public virtual IotDpsAccessPolicyRights Rights { get; internal set; }
        /// <summary><p>Secondary SAS key value.</p></summary>
        public virtual string SecondaryKey { get; internal set; }
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
              .Add("iot dps access-policy update")
              .Add("--access-policy-name {value}", AccessPolicyName)
              .Add("--dps-name {value}", DpsName)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--no-wait {value}", NoWait)
              .Add("--primary-key {value}", PrimaryKey)
              .Add("--rights {value}", Rights)
              .Add("--secondary-key {value}", SecondaryKey)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureIotDpsCertificateCreateSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotDpsCertificateCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>A friendly name for the certificate.</p></summary>
        public virtual string CertificateName { get; internal set; }
        /// <summary><p>IoT Provisioning Service name.</p></summary>
        public virtual string DpsName { get; internal set; }
        /// <summary><p>The path to the file containing the certificate.</p></summary>
        public virtual string Path { get; internal set; }
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
              .Add("iot dps certificate create")
              .Add("--certificate-name {value}", CertificateName)
              .Add("--dps-name {value}", DpsName)
              .Add("--path {value}", Path)
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
    #region AzureIotDpsCertificateDeleteSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotDpsCertificateDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>A friendly name for the certificate.</p></summary>
        public virtual string CertificateName { get; internal set; }
        /// <summary><p>IoT Provisioning Service name.</p></summary>
        public virtual string DpsName { get; internal set; }
        /// <summary><p>Entity Tag (etag) of the object.</p></summary>
        public virtual string Etag { get; internal set; }
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
              .Add("iot dps certificate delete")
              .Add("--certificate-name {value}", CertificateName)
              .Add("--dps-name {value}", DpsName)
              .Add("--etag {value}", Etag)
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
    #region AzureIotDpsCertificateGenerateVerificationCodeSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotDpsCertificateGenerateVerificationCodeSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>A friendly name for the certificate.</p></summary>
        public virtual string CertificateName { get; internal set; }
        /// <summary><p>IoT Provisioning Service name.</p></summary>
        public virtual string DpsName { get; internal set; }
        /// <summary><p>Entity Tag (etag) of the object.</p></summary>
        public virtual string Etag { get; internal set; }
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
              .Add("iot dps certificate generate-verification-code")
              .Add("--certificate-name {value}", CertificateName)
              .Add("--dps-name {value}", DpsName)
              .Add("--etag {value}", Etag)
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
    #region AzureIotDpsCertificateListSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotDpsCertificateListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>IoT Provisioning Service name.</p></summary>
        public virtual string DpsName { get; internal set; }
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
              .Add("iot dps certificate list")
              .Add("--dps-name {value}", DpsName)
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
    #region AzureIotDpsCertificateShowSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotDpsCertificateShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>A friendly name for the certificate.</p></summary>
        public virtual string CertificateName { get; internal set; }
        /// <summary><p>IoT Provisioning Service name.</p></summary>
        public virtual string DpsName { get; internal set; }
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
              .Add("iot dps certificate show")
              .Add("--certificate-name {value}", CertificateName)
              .Add("--dps-name {value}", DpsName)
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
    #region AzureIotDpsCertificateUpdateSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotDpsCertificateUpdateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>A friendly name for the certificate.</p></summary>
        public virtual string CertificateName { get; internal set; }
        /// <summary><p>IoT Provisioning Service name.</p></summary>
        public virtual string DpsName { get; internal set; }
        /// <summary><p>Entity Tag (etag) of the object.</p></summary>
        public virtual string Etag { get; internal set; }
        /// <summary><p>The path to the file containing the certificate.</p></summary>
        public virtual string Path { get; internal set; }
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
              .Add("iot dps certificate update")
              .Add("--certificate-name {value}", CertificateName)
              .Add("--dps-name {value}", DpsName)
              .Add("--etag {value}", Etag)
              .Add("--path {value}", Path)
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
    #region AzureIotDpsCertificateVerifySettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotDpsCertificateVerifySettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>A friendly name for the certificate.</p></summary>
        public virtual string CertificateName { get; internal set; }
        /// <summary><p>IoT Provisioning Service name.</p></summary>
        public virtual string DpsName { get; internal set; }
        /// <summary><p>Entity Tag (etag) of the object.</p></summary>
        public virtual string Etag { get; internal set; }
        /// <summary><p>The path to the file containing the certificate.</p></summary>
        public virtual string Path { get; internal set; }
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
              .Add("iot dps certificate verify")
              .Add("--certificate-name {value}", CertificateName)
              .Add("--dps-name {value}", DpsName)
              .Add("--etag {value}", Etag)
              .Add("--path {value}", Path)
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
    #region AzureIotDpsLinkedHubCreateSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotDpsLinkedHubCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>Connection string of the IoT hub.</p></summary>
        public virtual string ConnectionString { get; internal set; }
        /// <summary><p>IoT Provisioning Service name.</p></summary>
        public virtual string DpsName { get; internal set; }
        /// <summary><p>Location of the IoT hub.</p></summary>
        public virtual string Location { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Allocation weight of the IoT hub.</p></summary>
        public virtual string AllocationWeight { get; internal set; }
        /// <summary><p>A boolean indicating whether to apply allocation policy to the IoT hub.</p></summary>
        public virtual bool? ApplyAllocationPolicy { get; internal set; }
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
              .Add("iot dps linked-hub create")
              .Add("--connection-string {value}", ConnectionString)
              .Add("--dps-name {value}", DpsName)
              .Add("--location {value}", Location)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--allocation-weight {value}", AllocationWeight)
              .Add("--apply-allocation-policy", ApplyAllocationPolicy)
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
    #region AzureIotDpsLinkedHubDeleteSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotDpsLinkedHubDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>IoT Provisioning Service name.</p></summary>
        public virtual string DpsName { get; internal set; }
        /// <summary><p>Host name of linked IoT Hub.</p></summary>
        public virtual string LinkedHub { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
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
              .Add("iot dps linked-hub delete")
              .Add("--dps-name {value}", DpsName)
              .Add("--linked-hub {value}", LinkedHub)
              .Add("--resource-group {value}", ResourceGroup)
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
    #region AzureIotDpsLinkedHubListSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotDpsLinkedHubListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>IoT Provisioning Service name.</p></summary>
        public virtual string DpsName { get; internal set; }
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
              .Add("iot dps linked-hub list")
              .Add("--dps-name {value}", DpsName)
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
    #region AzureIotDpsLinkedHubShowSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotDpsLinkedHubShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>IoT Provisioning Service name.</p></summary>
        public virtual string DpsName { get; internal set; }
        /// <summary><p>Host name of linked IoT Hub.</p></summary>
        public virtual string LinkedHub { get; internal set; }
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
              .Add("iot dps linked-hub show")
              .Add("--dps-name {value}", DpsName)
              .Add("--linked-hub {value}", LinkedHub)
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
    #region AzureIotDpsLinkedHubUpdateSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotDpsLinkedHubUpdateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>IoT Provisioning Service name.</p></summary>
        public virtual string DpsName { get; internal set; }
        /// <summary><p>Host name of linked IoT Hub.</p></summary>
        public virtual string LinkedHub { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Allocation weight of the IoT hub.</p></summary>
        public virtual string AllocationWeight { get; internal set; }
        /// <summary><p>A boolean indicating whether to apply allocation policy to the Iot hub.</p></summary>
        public virtual bool? ApplyAllocationPolicy { get; internal set; }
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
              .Add("iot dps linked-hub update")
              .Add("--dps-name {value}", DpsName)
              .Add("--linked-hub {value}", LinkedHub)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--allocation-weight {value}", AllocationWeight)
              .Add("--apply-allocation-policy", ApplyAllocationPolicy)
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
    #region AzureIotHubCertificateCreateSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotHubCertificateCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>IoT Hub name.</p></summary>
        public virtual string HubName { get; internal set; }
        /// <summary><p>A friendly name for the certificate.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>The path to the file containing the certificate.</p></summary>
        public virtual string Path { get; internal set; }
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
              .Add("iot hub certificate create")
              .Add("--hub-name {value}", HubName)
              .Add("--name {value}", Name)
              .Add("--path {value}", Path)
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
    #region AzureIotHubCertificateDeleteSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotHubCertificateDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>Entity Tag (etag) of the object.</p></summary>
        public virtual string Etag { get; internal set; }
        /// <summary><p>IoT Hub name.</p></summary>
        public virtual string HubName { get; internal set; }
        /// <summary><p>A friendly name for the certificate.</p></summary>
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
              .Add("iot hub certificate delete")
              .Add("--etag {value}", Etag)
              .Add("--hub-name {value}", HubName)
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
    #region AzureIotHubCertificateGenerateVerificationCodeSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotHubCertificateGenerateVerificationCodeSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>Entity Tag (etag) of the object.</p></summary>
        public virtual string Etag { get; internal set; }
        /// <summary><p>IoT Hub name.</p></summary>
        public virtual string HubName { get; internal set; }
        /// <summary><p>A friendly name for the certificate.</p></summary>
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
              .Add("iot hub certificate generate-verification-code")
              .Add("--etag {value}", Etag)
              .Add("--hub-name {value}", HubName)
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
    #region AzureIotHubCertificateListSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotHubCertificateListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>IoT Hub name.</p></summary>
        public virtual string HubName { get; internal set; }
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
              .Add("iot hub certificate list")
              .Add("--hub-name {value}", HubName)
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
    #region AzureIotHubCertificateShowSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotHubCertificateShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>IoT Hub name.</p></summary>
        public virtual string HubName { get; internal set; }
        /// <summary><p>A friendly name for the certificate.</p></summary>
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
              .Add("iot hub certificate show")
              .Add("--hub-name {value}", HubName)
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
    #region AzureIotHubCertificateUpdateSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotHubCertificateUpdateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>Entity Tag (etag) of the object.</p></summary>
        public virtual string Etag { get; internal set; }
        /// <summary><p>IoT Hub name.</p></summary>
        public virtual string HubName { get; internal set; }
        /// <summary><p>A friendly name for the certificate.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>The path to the file containing the certificate.</p></summary>
        public virtual string Path { get; internal set; }
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
              .Add("iot hub certificate update")
              .Add("--etag {value}", Etag)
              .Add("--hub-name {value}", HubName)
              .Add("--name {value}", Name)
              .Add("--path {value}", Path)
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
    #region AzureIotHubCertificateVerifySettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotHubCertificateVerifySettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>Entity Tag (etag) of the object.</p></summary>
        public virtual string Etag { get; internal set; }
        /// <summary><p>IoT Hub name.</p></summary>
        public virtual string HubName { get; internal set; }
        /// <summary><p>A friendly name for the certificate.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>The path to the file containing the certificate.</p></summary>
        public virtual string Path { get; internal set; }
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
              .Add("iot hub certificate verify")
              .Add("--etag {value}", Etag)
              .Add("--hub-name {value}", HubName)
              .Add("--name {value}", Name)
              .Add("--path {value}", Path)
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
    #region AzureIotHubConsumerGroupCreateSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotHubConsumerGroupCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>IoT Hub name.</p></summary>
        public virtual string HubName { get; internal set; }
        /// <summary><p>Event hub consumer group name.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Event hub endpoint name.</p></summary>
        public virtual string EventHubName { get; internal set; }
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
              .Add("iot hub consumer-group create")
              .Add("--hub-name {value}", HubName)
              .Add("--name {value}", Name)
              .Add("--event-hub-name {value}", EventHubName)
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
    #region AzureIotHubConsumerGroupDeleteSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotHubConsumerGroupDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>IoT Hub name.</p></summary>
        public virtual string HubName { get; internal set; }
        /// <summary><p>Event hub consumer group name.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Event hub endpoint name.</p></summary>
        public virtual string EventHubName { get; internal set; }
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
              .Add("iot hub consumer-group delete")
              .Add("--hub-name {value}", HubName)
              .Add("--name {value}", Name)
              .Add("--event-hub-name {value}", EventHubName)
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
    #region AzureIotHubConsumerGroupListSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotHubConsumerGroupListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>IoT Hub name.</p></summary>
        public virtual string HubName { get; internal set; }
        /// <summary><p>Event hub endpoint name.</p></summary>
        public virtual string EventHubName { get; internal set; }
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
              .Add("iot hub consumer-group list")
              .Add("--hub-name {value}", HubName)
              .Add("--event-hub-name {value}", EventHubName)
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
    #region AzureIotHubConsumerGroupShowSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotHubConsumerGroupShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>IoT Hub name.</p></summary>
        public virtual string HubName { get; internal set; }
        /// <summary><p>Event hub consumer group name.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Event hub endpoint name.</p></summary>
        public virtual string EventHubName { get; internal set; }
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
              .Add("iot hub consumer-group show")
              .Add("--hub-name {value}", HubName)
              .Add("--name {value}", Name)
              .Add("--event-hub-name {value}", EventHubName)
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
    #region AzureIotHubJobCancelSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotHubJobCancelSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>IoT Hub name.</p></summary>
        public virtual string HubName { get; internal set; }
        /// <summary><p>Job Id.</p></summary>
        public virtual string JobId { get; internal set; }
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
              .Add("iot hub job cancel")
              .Add("--hub-name {value}", HubName)
              .Add("--job-id {value}", JobId)
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
    #region AzureIotHubJobListSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotHubJobListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>IoT Hub name.</p></summary>
        public virtual string HubName { get; internal set; }
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
              .Add("iot hub job list")
              .Add("--hub-name {value}", HubName)
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
    #region AzureIotHubJobShowSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotHubJobShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>IoT Hub name.</p></summary>
        public virtual string HubName { get; internal set; }
        /// <summary><p>Job Id.</p></summary>
        public virtual string JobId { get; internal set; }
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
              .Add("iot hub job show")
              .Add("--hub-name {value}", HubName)
              .Add("--job-id {value}", JobId)
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
    #region AzureIotHubPolicyCreateSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotHubPolicyCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>IoT Hub name.</p></summary>
        public virtual string HubName { get; internal set; }
        /// <summary><p>Shared access policy name.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Permissions of shared access policy. Use space-separated list for multiple permissions. Possible values: RegistryRead, RegistryWrite, ServiceConnect, DeviceConnect.</p></summary>
        public virtual string Permissions { get; internal set; }
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
              .Add("iot hub policy create")
              .Add("--hub-name {value}", HubName)
              .Add("--name {value}", Name)
              .Add("--permissions {value}", Permissions)
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
    #region AzureIotHubPolicyDeleteSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotHubPolicyDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>IoT Hub name.</p></summary>
        public virtual string HubName { get; internal set; }
        /// <summary><p>Shared access policy name.</p></summary>
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
              .Add("iot hub policy delete")
              .Add("--hub-name {value}", HubName)
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
    #region AzureIotHubPolicyListSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotHubPolicyListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>IoT Hub name.</p></summary>
        public virtual string HubName { get; internal set; }
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
              .Add("iot hub policy list")
              .Add("--hub-name {value}", HubName)
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
    #region AzureIotHubPolicyShowSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotHubPolicyShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>IoT Hub name.</p></summary>
        public virtual string HubName { get; internal set; }
        /// <summary><p>Shared access policy name.</p></summary>
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
              .Add("iot hub policy show")
              .Add("--hub-name {value}", HubName)
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
    #region AzureIotSettingsExtensions
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIotSettingsExtensions
    {
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureIotSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotSettings SetDebug(this AzureIotSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotSettings ResetDebug(this AzureIotSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureIotSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotSettings SetHelp(this AzureIotSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotSettings ResetHelp(this AzureIotSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureIotSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotSettings SetOutput(this AzureIotSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotSettings ResetOutput(this AzureIotSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureIotSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotSettings SetQuery(this AzureIotSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotSettings ResetQuery(this AzureIotSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureIotSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotSettings SetVerbose(this AzureIotSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotSettings ResetVerbose(this AzureIotSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureIotDeviceCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIotDeviceCreateSettingsExtensions
    {
        #region DeviceId
        /// <summary><p><em>Sets <see cref="AzureIotDeviceCreateSettings.DeviceId"/>.</em></p><p>Device Id.</p></summary>
        [Pure]
        public static AzureIotDeviceCreateSettings SetDeviceId(this AzureIotDeviceCreateSettings toolSettings, string deviceId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DeviceId = deviceId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceCreateSettings.DeviceId"/>.</em></p><p>Device Id.</p></summary>
        [Pure]
        public static AzureIotDeviceCreateSettings ResetDeviceId(this AzureIotDeviceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DeviceId = null;
            return toolSettings;
        }
        #endregion
        #region HubName
        /// <summary><p><em>Sets <see cref="AzureIotDeviceCreateSettings.HubName"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotDeviceCreateSettings SetHubName(this AzureIotDeviceCreateSettings toolSettings, string hubName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HubName = hubName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceCreateSettings.HubName"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotDeviceCreateSettings ResetHubName(this AzureIotDeviceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HubName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureIotDeviceCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotDeviceCreateSettings SetResourceGroup(this AzureIotDeviceCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotDeviceCreateSettings ResetResourceGroup(this AzureIotDeviceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region OutputDir
        /// <summary><p><em>Sets <see cref="AzureIotDeviceCreateSettings.OutputDir"/>.</em></p><p>Output directory for generated self-signed X.509 certificate. Default is current working directory.</p></summary>
        [Pure]
        public static AzureIotDeviceCreateSettings SetOutputDir(this AzureIotDeviceCreateSettings toolSettings, string outputDir)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OutputDir = outputDir;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceCreateSettings.OutputDir"/>.</em></p><p>Output directory for generated self-signed X.509 certificate. Default is current working directory.</p></summary>
        [Pure]
        public static AzureIotDeviceCreateSettings ResetOutputDir(this AzureIotDeviceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OutputDir = null;
            return toolSettings;
        }
        #endregion
        #region PrimaryThumbprint
        /// <summary><p><em>Sets <see cref="AzureIotDeviceCreateSettings.PrimaryThumbprint"/>.</em></p><p>Primary X.509 certificate thumbprint to authenticate device.</p></summary>
        [Pure]
        public static AzureIotDeviceCreateSettings SetPrimaryThumbprint(this AzureIotDeviceCreateSettings toolSettings, string primaryThumbprint)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PrimaryThumbprint = primaryThumbprint;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceCreateSettings.PrimaryThumbprint"/>.</em></p><p>Primary X.509 certificate thumbprint to authenticate device.</p></summary>
        [Pure]
        public static AzureIotDeviceCreateSettings ResetPrimaryThumbprint(this AzureIotDeviceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PrimaryThumbprint = null;
            return toolSettings;
        }
        #endregion
        #region SecondaryThumbprint
        /// <summary><p><em>Sets <see cref="AzureIotDeviceCreateSettings.SecondaryThumbprint"/>.</em></p><p>Secondary X.509 certificate thumbprint to authenticate device.</p></summary>
        [Pure]
        public static AzureIotDeviceCreateSettings SetSecondaryThumbprint(this AzureIotDeviceCreateSettings toolSettings, string secondaryThumbprint)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SecondaryThumbprint = secondaryThumbprint;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceCreateSettings.SecondaryThumbprint"/>.</em></p><p>Secondary X.509 certificate thumbprint to authenticate device.</p></summary>
        [Pure]
        public static AzureIotDeviceCreateSettings ResetSecondaryThumbprint(this AzureIotDeviceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SecondaryThumbprint = null;
            return toolSettings;
        }
        #endregion
        #region ValidDays
        /// <summary><p><em>Sets <see cref="AzureIotDeviceCreateSettings.ValidDays"/>.</em></p><p>Number of days the generated self-signed X.509 certificate should be valid for. Default validity is 365 days.</p></summary>
        [Pure]
        public static AzureIotDeviceCreateSettings SetValidDays(this AzureIotDeviceCreateSettings toolSettings, int? validDays)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ValidDays = validDays;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceCreateSettings.ValidDays"/>.</em></p><p>Number of days the generated self-signed X.509 certificate should be valid for. Default validity is 365 days.</p></summary>
        [Pure]
        public static AzureIotDeviceCreateSettings ResetValidDays(this AzureIotDeviceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ValidDays = null;
            return toolSettings;
        }
        #endregion
        #region X509
        /// <summary><p><em>Sets <see cref="AzureIotDeviceCreateSettings.X509"/>.</em></p><p>Use X.509 certificate for device authentication.</p></summary>
        [Pure]
        public static AzureIotDeviceCreateSettings SetX509(this AzureIotDeviceCreateSettings toolSettings, string x509)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.X509 = x509;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceCreateSettings.X509"/>.</em></p><p>Use X.509 certificate for device authentication.</p></summary>
        [Pure]
        public static AzureIotDeviceCreateSettings ResetX509(this AzureIotDeviceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.X509 = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureIotDeviceCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotDeviceCreateSettings SetDebug(this AzureIotDeviceCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotDeviceCreateSettings ResetDebug(this AzureIotDeviceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureIotDeviceCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotDeviceCreateSettings SetHelp(this AzureIotDeviceCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotDeviceCreateSettings ResetHelp(this AzureIotDeviceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureIotDeviceCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotDeviceCreateSettings SetOutput(this AzureIotDeviceCreateSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotDeviceCreateSettings ResetOutput(this AzureIotDeviceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureIotDeviceCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDeviceCreateSettings SetQuery(this AzureIotDeviceCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDeviceCreateSettings ResetQuery(this AzureIotDeviceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureIotDeviceCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotDeviceCreateSettings SetVerbose(this AzureIotDeviceCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotDeviceCreateSettings ResetVerbose(this AzureIotDeviceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureIotDeviceDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIotDeviceDeleteSettingsExtensions
    {
        #region DeviceId
        /// <summary><p><em>Sets <see cref="AzureIotDeviceDeleteSettings.DeviceId"/>.</em></p><p>Device Id.</p></summary>
        [Pure]
        public static AzureIotDeviceDeleteSettings SetDeviceId(this AzureIotDeviceDeleteSettings toolSettings, string deviceId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DeviceId = deviceId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceDeleteSettings.DeviceId"/>.</em></p><p>Device Id.</p></summary>
        [Pure]
        public static AzureIotDeviceDeleteSettings ResetDeviceId(this AzureIotDeviceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DeviceId = null;
            return toolSettings;
        }
        #endregion
        #region HubName
        /// <summary><p><em>Sets <see cref="AzureIotDeviceDeleteSettings.HubName"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotDeviceDeleteSettings SetHubName(this AzureIotDeviceDeleteSettings toolSettings, string hubName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HubName = hubName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceDeleteSettings.HubName"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotDeviceDeleteSettings ResetHubName(this AzureIotDeviceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HubName = null;
            return toolSettings;
        }
        #endregion
        #region Etag
        /// <summary><p><em>Sets <see cref="AzureIotDeviceDeleteSettings.Etag"/>.</em></p><p>ETag of the target device. It is used for the purpose of optimistic concurrency. Delete operation will be performed only if the specified ETag matches the value maintained by the server, indicating that the device identity has not been modified since it was retrieved. Default value is set to wildcard character (*) to force an unconditional delete.</p></summary>
        [Pure]
        public static AzureIotDeviceDeleteSettings SetEtag(this AzureIotDeviceDeleteSettings toolSettings, string etag)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Etag = etag;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceDeleteSettings.Etag"/>.</em></p><p>ETag of the target device. It is used for the purpose of optimistic concurrency. Delete operation will be performed only if the specified ETag matches the value maintained by the server, indicating that the device identity has not been modified since it was retrieved. Default value is set to wildcard character (*) to force an unconditional delete.</p></summary>
        [Pure]
        public static AzureIotDeviceDeleteSettings ResetEtag(this AzureIotDeviceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Etag = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureIotDeviceDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotDeviceDeleteSettings SetResourceGroup(this AzureIotDeviceDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotDeviceDeleteSettings ResetResourceGroup(this AzureIotDeviceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureIotDeviceDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotDeviceDeleteSettings SetDebug(this AzureIotDeviceDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotDeviceDeleteSettings ResetDebug(this AzureIotDeviceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureIotDeviceDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotDeviceDeleteSettings SetHelp(this AzureIotDeviceDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotDeviceDeleteSettings ResetHelp(this AzureIotDeviceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureIotDeviceDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotDeviceDeleteSettings SetOutput(this AzureIotDeviceDeleteSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotDeviceDeleteSettings ResetOutput(this AzureIotDeviceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureIotDeviceDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDeviceDeleteSettings SetQuery(this AzureIotDeviceDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDeviceDeleteSettings ResetQuery(this AzureIotDeviceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureIotDeviceDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotDeviceDeleteSettings SetVerbose(this AzureIotDeviceDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotDeviceDeleteSettings ResetVerbose(this AzureIotDeviceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureIotDeviceExportSettingsExtensions
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIotDeviceExportSettingsExtensions
    {
        #region BlobContainerUri
        /// <summary><p><em>Sets <see cref="AzureIotDeviceExportSettings.BlobContainerUri"/>.</em></p><p>Blob Shared Access Signature URI with write access to a blob container.This is used to output the status of the job and the results.</p></summary>
        [Pure]
        public static AzureIotDeviceExportSettings SetBlobContainerUri(this AzureIotDeviceExportSettings toolSettings, string blobContainerUri)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BlobContainerUri = blobContainerUri;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceExportSettings.BlobContainerUri"/>.</em></p><p>Blob Shared Access Signature URI with write access to a blob container.This is used to output the status of the job and the results.</p></summary>
        [Pure]
        public static AzureIotDeviceExportSettings ResetBlobContainerUri(this AzureIotDeviceExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BlobContainerUri = null;
            return toolSettings;
        }
        #endregion
        #region HubName
        /// <summary><p><em>Sets <see cref="AzureIotDeviceExportSettings.HubName"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotDeviceExportSettings SetHubName(this AzureIotDeviceExportSettings toolSettings, string hubName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HubName = hubName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceExportSettings.HubName"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotDeviceExportSettings ResetHubName(this AzureIotDeviceExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HubName = null;
            return toolSettings;
        }
        #endregion
        #region IncludeKeys
        /// <summary><p><em>Sets <see cref="AzureIotDeviceExportSettings.IncludeKeys"/>.</em></p><p>If set, keys are exported normally. Otherwise, keys are set to null in export output.</p></summary>
        [Pure]
        public static AzureIotDeviceExportSettings SetIncludeKeys(this AzureIotDeviceExportSettings toolSettings, string includeKeys)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeKeys = includeKeys;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceExportSettings.IncludeKeys"/>.</em></p><p>If set, keys are exported normally. Otherwise, keys are set to null in export output.</p></summary>
        [Pure]
        public static AzureIotDeviceExportSettings ResetIncludeKeys(this AzureIotDeviceExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeKeys = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureIotDeviceExportSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotDeviceExportSettings SetResourceGroup(this AzureIotDeviceExportSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceExportSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotDeviceExportSettings ResetResourceGroup(this AzureIotDeviceExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureIotDeviceExportSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotDeviceExportSettings SetDebug(this AzureIotDeviceExportSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceExportSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotDeviceExportSettings ResetDebug(this AzureIotDeviceExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureIotDeviceExportSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotDeviceExportSettings SetHelp(this AzureIotDeviceExportSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceExportSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotDeviceExportSettings ResetHelp(this AzureIotDeviceExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureIotDeviceExportSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotDeviceExportSettings SetOutput(this AzureIotDeviceExportSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceExportSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotDeviceExportSettings ResetOutput(this AzureIotDeviceExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureIotDeviceExportSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDeviceExportSettings SetQuery(this AzureIotDeviceExportSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceExportSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDeviceExportSettings ResetQuery(this AzureIotDeviceExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureIotDeviceExportSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotDeviceExportSettings SetVerbose(this AzureIotDeviceExportSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceExportSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotDeviceExportSettings ResetVerbose(this AzureIotDeviceExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureIotDeviceImportSettingsExtensions
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIotDeviceImportSettingsExtensions
    {
        #region HubName
        /// <summary><p><em>Sets <see cref="AzureIotDeviceImportSettings.HubName"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotDeviceImportSettings SetHubName(this AzureIotDeviceImportSettings toolSettings, string hubName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HubName = hubName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceImportSettings.HubName"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotDeviceImportSettings ResetHubName(this AzureIotDeviceImportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HubName = null;
            return toolSettings;
        }
        #endregion
        #region InputBlobContainerUri
        /// <summary><p><em>Sets <see cref="AzureIotDeviceImportSettings.InputBlobContainerUri"/>.</em></p><p>Blob Shared Access Signature URI with read access to a blob container.This blob contains the operations to be performed on the identity registry.</p></summary>
        [Pure]
        public static AzureIotDeviceImportSettings SetInputBlobContainerUri(this AzureIotDeviceImportSettings toolSettings, string inputBlobContainerUri)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InputBlobContainerUri = inputBlobContainerUri;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceImportSettings.InputBlobContainerUri"/>.</em></p><p>Blob Shared Access Signature URI with read access to a blob container.This blob contains the operations to be performed on the identity registry.</p></summary>
        [Pure]
        public static AzureIotDeviceImportSettings ResetInputBlobContainerUri(this AzureIotDeviceImportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InputBlobContainerUri = null;
            return toolSettings;
        }
        #endregion
        #region OutputBlobContainerUri
        /// <summary><p><em>Sets <see cref="AzureIotDeviceImportSettings.OutputBlobContainerUri"/>.</em></p><p>Blob Shared Access Signature URI with write access to a blob container.This is used to output the status of the job and the results.</p></summary>
        [Pure]
        public static AzureIotDeviceImportSettings SetOutputBlobContainerUri(this AzureIotDeviceImportSettings toolSettings, string outputBlobContainerUri)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OutputBlobContainerUri = outputBlobContainerUri;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceImportSettings.OutputBlobContainerUri"/>.</em></p><p>Blob Shared Access Signature URI with write access to a blob container.This is used to output the status of the job and the results.</p></summary>
        [Pure]
        public static AzureIotDeviceImportSettings ResetOutputBlobContainerUri(this AzureIotDeviceImportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OutputBlobContainerUri = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureIotDeviceImportSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotDeviceImportSettings SetResourceGroup(this AzureIotDeviceImportSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceImportSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotDeviceImportSettings ResetResourceGroup(this AzureIotDeviceImportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureIotDeviceImportSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotDeviceImportSettings SetDebug(this AzureIotDeviceImportSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceImportSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotDeviceImportSettings ResetDebug(this AzureIotDeviceImportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureIotDeviceImportSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotDeviceImportSettings SetHelp(this AzureIotDeviceImportSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceImportSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotDeviceImportSettings ResetHelp(this AzureIotDeviceImportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureIotDeviceImportSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotDeviceImportSettings SetOutput(this AzureIotDeviceImportSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceImportSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotDeviceImportSettings ResetOutput(this AzureIotDeviceImportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureIotDeviceImportSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDeviceImportSettings SetQuery(this AzureIotDeviceImportSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceImportSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDeviceImportSettings ResetQuery(this AzureIotDeviceImportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureIotDeviceImportSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotDeviceImportSettings SetVerbose(this AzureIotDeviceImportSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceImportSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotDeviceImportSettings ResetVerbose(this AzureIotDeviceImportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureIotDeviceListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIotDeviceListSettingsExtensions
    {
        #region HubName
        /// <summary><p><em>Sets <see cref="AzureIotDeviceListSettings.HubName"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotDeviceListSettings SetHubName(this AzureIotDeviceListSettings toolSettings, string hubName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HubName = hubName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceListSettings.HubName"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotDeviceListSettings ResetHubName(this AzureIotDeviceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HubName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureIotDeviceListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotDeviceListSettings SetResourceGroup(this AzureIotDeviceListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotDeviceListSettings ResetResourceGroup(this AzureIotDeviceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Top
        /// <summary><p><em>Sets <see cref="AzureIotDeviceListSettings.Top"/>.</em></p><p>Maximum number of device identities to return.</p></summary>
        [Pure]
        public static AzureIotDeviceListSettings SetTop(this AzureIotDeviceListSettings toolSettings, string top)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = top;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceListSettings.Top"/>.</em></p><p>Maximum number of device identities to return.</p></summary>
        [Pure]
        public static AzureIotDeviceListSettings ResetTop(this AzureIotDeviceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureIotDeviceListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotDeviceListSettings SetDebug(this AzureIotDeviceListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotDeviceListSettings ResetDebug(this AzureIotDeviceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureIotDeviceListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotDeviceListSettings SetHelp(this AzureIotDeviceListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotDeviceListSettings ResetHelp(this AzureIotDeviceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureIotDeviceListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotDeviceListSettings SetOutput(this AzureIotDeviceListSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotDeviceListSettings ResetOutput(this AzureIotDeviceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureIotDeviceListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDeviceListSettings SetQuery(this AzureIotDeviceListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDeviceListSettings ResetQuery(this AzureIotDeviceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureIotDeviceListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotDeviceListSettings SetVerbose(this AzureIotDeviceListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotDeviceListSettings ResetVerbose(this AzureIotDeviceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureIotDeviceShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIotDeviceShowSettingsExtensions
    {
        #region DeviceId
        /// <summary><p><em>Sets <see cref="AzureIotDeviceShowSettings.DeviceId"/>.</em></p><p>Device Id.</p></summary>
        [Pure]
        public static AzureIotDeviceShowSettings SetDeviceId(this AzureIotDeviceShowSettings toolSettings, string deviceId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DeviceId = deviceId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceShowSettings.DeviceId"/>.</em></p><p>Device Id.</p></summary>
        [Pure]
        public static AzureIotDeviceShowSettings ResetDeviceId(this AzureIotDeviceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DeviceId = null;
            return toolSettings;
        }
        #endregion
        #region HubName
        /// <summary><p><em>Sets <see cref="AzureIotDeviceShowSettings.HubName"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotDeviceShowSettings SetHubName(this AzureIotDeviceShowSettings toolSettings, string hubName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HubName = hubName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceShowSettings.HubName"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotDeviceShowSettings ResetHubName(this AzureIotDeviceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HubName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureIotDeviceShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotDeviceShowSettings SetResourceGroup(this AzureIotDeviceShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotDeviceShowSettings ResetResourceGroup(this AzureIotDeviceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureIotDeviceShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotDeviceShowSettings SetDebug(this AzureIotDeviceShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotDeviceShowSettings ResetDebug(this AzureIotDeviceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureIotDeviceShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotDeviceShowSettings SetHelp(this AzureIotDeviceShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotDeviceShowSettings ResetHelp(this AzureIotDeviceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureIotDeviceShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotDeviceShowSettings SetOutput(this AzureIotDeviceShowSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotDeviceShowSettings ResetOutput(this AzureIotDeviceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureIotDeviceShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDeviceShowSettings SetQuery(this AzureIotDeviceShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDeviceShowSettings ResetQuery(this AzureIotDeviceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureIotDeviceShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotDeviceShowSettings SetVerbose(this AzureIotDeviceShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotDeviceShowSettings ResetVerbose(this AzureIotDeviceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureIotDeviceShowConnectionStringSettingsExtensions
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIotDeviceShowConnectionStringSettingsExtensions
    {
        #region HubName
        /// <summary><p><em>Sets <see cref="AzureIotDeviceShowConnectionStringSettings.HubName"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotDeviceShowConnectionStringSettings SetHubName(this AzureIotDeviceShowConnectionStringSettings toolSettings, string hubName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HubName = hubName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceShowConnectionStringSettings.HubName"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotDeviceShowConnectionStringSettings ResetHubName(this AzureIotDeviceShowConnectionStringSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HubName = null;
            return toolSettings;
        }
        #endregion
        #region DeviceId
        /// <summary><p><em>Sets <see cref="AzureIotDeviceShowConnectionStringSettings.DeviceId"/>.</em></p><p>Device Id.</p></summary>
        [Pure]
        public static AzureIotDeviceShowConnectionStringSettings SetDeviceId(this AzureIotDeviceShowConnectionStringSettings toolSettings, string deviceId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DeviceId = deviceId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceShowConnectionStringSettings.DeviceId"/>.</em></p><p>Device Id.</p></summary>
        [Pure]
        public static AzureIotDeviceShowConnectionStringSettings ResetDeviceId(this AzureIotDeviceShowConnectionStringSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DeviceId = null;
            return toolSettings;
        }
        #endregion
        #region Key
        /// <summary><p><em>Sets <see cref="AzureIotDeviceShowConnectionStringSettings.Key"/>.</em></p><p>The key to use.</p></summary>
        [Pure]
        public static AzureIotDeviceShowConnectionStringSettings SetKey(this AzureIotDeviceShowConnectionStringSettings toolSettings, IotDeviceKey key)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Key = key;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceShowConnectionStringSettings.Key"/>.</em></p><p>The key to use.</p></summary>
        [Pure]
        public static AzureIotDeviceShowConnectionStringSettings ResetKey(this AzureIotDeviceShowConnectionStringSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Key = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureIotDeviceShowConnectionStringSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotDeviceShowConnectionStringSettings SetResourceGroup(this AzureIotDeviceShowConnectionStringSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceShowConnectionStringSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotDeviceShowConnectionStringSettings ResetResourceGroup(this AzureIotDeviceShowConnectionStringSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Top
        /// <summary><p><em>Sets <see cref="AzureIotDeviceShowConnectionStringSettings.Top"/>.</em></p><p>Maximum number of connection strings to return.</p></summary>
        [Pure]
        public static AzureIotDeviceShowConnectionStringSettings SetTop(this AzureIotDeviceShowConnectionStringSettings toolSettings, string top)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = top;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceShowConnectionStringSettings.Top"/>.</em></p><p>Maximum number of connection strings to return.</p></summary>
        [Pure]
        public static AzureIotDeviceShowConnectionStringSettings ResetTop(this AzureIotDeviceShowConnectionStringSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureIotDeviceShowConnectionStringSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotDeviceShowConnectionStringSettings SetDebug(this AzureIotDeviceShowConnectionStringSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceShowConnectionStringSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotDeviceShowConnectionStringSettings ResetDebug(this AzureIotDeviceShowConnectionStringSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureIotDeviceShowConnectionStringSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotDeviceShowConnectionStringSettings SetHelp(this AzureIotDeviceShowConnectionStringSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceShowConnectionStringSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotDeviceShowConnectionStringSettings ResetHelp(this AzureIotDeviceShowConnectionStringSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureIotDeviceShowConnectionStringSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotDeviceShowConnectionStringSettings SetOutput(this AzureIotDeviceShowConnectionStringSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceShowConnectionStringSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotDeviceShowConnectionStringSettings ResetOutput(this AzureIotDeviceShowConnectionStringSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureIotDeviceShowConnectionStringSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDeviceShowConnectionStringSettings SetQuery(this AzureIotDeviceShowConnectionStringSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceShowConnectionStringSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDeviceShowConnectionStringSettings ResetQuery(this AzureIotDeviceShowConnectionStringSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureIotDeviceShowConnectionStringSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotDeviceShowConnectionStringSettings SetVerbose(this AzureIotDeviceShowConnectionStringSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceShowConnectionStringSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotDeviceShowConnectionStringSettings ResetVerbose(this AzureIotDeviceShowConnectionStringSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureIotDeviceUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIotDeviceUpdateSettingsExtensions
    {
        #region DeviceId
        /// <summary><p><em>Sets <see cref="AzureIotDeviceUpdateSettings.DeviceId"/>.</em></p><p>Device Id.</p></summary>
        [Pure]
        public static AzureIotDeviceUpdateSettings SetDeviceId(this AzureIotDeviceUpdateSettings toolSettings, string deviceId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DeviceId = deviceId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceUpdateSettings.DeviceId"/>.</em></p><p>Device Id.</p></summary>
        [Pure]
        public static AzureIotDeviceUpdateSettings ResetDeviceId(this AzureIotDeviceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DeviceId = null;
            return toolSettings;
        }
        #endregion
        #region HubName
        /// <summary><p><em>Sets <see cref="AzureIotDeviceUpdateSettings.HubName"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotDeviceUpdateSettings SetHubName(this AzureIotDeviceUpdateSettings toolSettings, string hubName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HubName = hubName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceUpdateSettings.HubName"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotDeviceUpdateSettings ResetHubName(this AzureIotDeviceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HubName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureIotDeviceUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotDeviceUpdateSettings SetResourceGroup(this AzureIotDeviceUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotDeviceUpdateSettings ResetResourceGroup(this AzureIotDeviceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary><p><em>Sets <see cref="AzureIotDeviceUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureIotDeviceUpdateSettings SetAdd(this AzureIotDeviceUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureIotDeviceUpdateSettings ResetAdd(this AzureIotDeviceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary><p><em>Sets <see cref="AzureIotDeviceUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureIotDeviceUpdateSettings SetRemove(this AzureIotDeviceUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureIotDeviceUpdateSettings ResetRemove(this AzureIotDeviceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary><p><em>Sets <see cref="AzureIotDeviceUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureIotDeviceUpdateSettings SetSet(this AzureIotDeviceUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureIotDeviceUpdateSettings ResetSet(this AzureIotDeviceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureIotDeviceUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotDeviceUpdateSettings SetDebug(this AzureIotDeviceUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotDeviceUpdateSettings ResetDebug(this AzureIotDeviceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureIotDeviceUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotDeviceUpdateSettings SetHelp(this AzureIotDeviceUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotDeviceUpdateSettings ResetHelp(this AzureIotDeviceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureIotDeviceUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotDeviceUpdateSettings SetOutput(this AzureIotDeviceUpdateSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotDeviceUpdateSettings ResetOutput(this AzureIotDeviceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureIotDeviceUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDeviceUpdateSettings SetQuery(this AzureIotDeviceUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDeviceUpdateSettings ResetQuery(this AzureIotDeviceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureIotDeviceUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotDeviceUpdateSettings SetVerbose(this AzureIotDeviceUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotDeviceUpdateSettings ResetVerbose(this AzureIotDeviceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureIotDpsCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIotDpsCreateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureIotDpsCreateSettings.Name"/>.</em></p><p>IoT Provisioning Service name.</p></summary>
        [Pure]
        public static AzureIotDpsCreateSettings SetName(this AzureIotDpsCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCreateSettings.Name"/>.</em></p><p>IoT Provisioning Service name.</p></summary>
        [Pure]
        public static AzureIotDpsCreateSettings ResetName(this AzureIotDpsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureIotDpsCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotDpsCreateSettings SetResourceGroup(this AzureIotDpsCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotDpsCreateSettings ResetResourceGroup(this AzureIotDpsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary><p><em>Sets <see cref="AzureIotDpsCreateSettings.Location"/>.</em></p><p>Location of your IoT Provisioning Service. Default is the location of target resource group.</p></summary>
        [Pure]
        public static AzureIotDpsCreateSettings SetLocation(this AzureIotDpsCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCreateSettings.Location"/>.</em></p><p>Location of your IoT Provisioning Service. Default is the location of target resource group.</p></summary>
        [Pure]
        public static AzureIotDpsCreateSettings ResetLocation(this AzureIotDpsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region Sku
        /// <summary><p><em>Sets <see cref="AzureIotDpsCreateSettings.Sku"/>.</em></p><p>Pricing tier for the IoT provisioning service.</p></summary>
        [Pure]
        public static AzureIotDpsCreateSettings SetSku(this AzureIotDpsCreateSettings toolSettings, IotDpsCreateSku sku)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = sku;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCreateSettings.Sku"/>.</em></p><p>Pricing tier for the IoT provisioning service.</p></summary>
        [Pure]
        public static AzureIotDpsCreateSettings ResetSku(this AzureIotDpsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = null;
            return toolSettings;
        }
        #endregion
        #region Unit
        /// <summary><p><em>Sets <see cref="AzureIotDpsCreateSettings.Unit"/>.</em></p><p>Units in your IoT Provisioning Service.</p></summary>
        [Pure]
        public static AzureIotDpsCreateSettings SetUnit(this AzureIotDpsCreateSettings toolSettings, string unit)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Unit = unit;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCreateSettings.Unit"/>.</em></p><p>Units in your IoT Provisioning Service.</p></summary>
        [Pure]
        public static AzureIotDpsCreateSettings ResetUnit(this AzureIotDpsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Unit = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureIotDpsCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsCreateSettings SetDebug(this AzureIotDpsCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsCreateSettings ResetDebug(this AzureIotDpsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureIotDpsCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotDpsCreateSettings SetHelp(this AzureIotDpsCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotDpsCreateSettings ResetHelp(this AzureIotDpsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureIotDpsCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotDpsCreateSettings SetOutput(this AzureIotDpsCreateSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotDpsCreateSettings ResetOutput(this AzureIotDpsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureIotDpsCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDpsCreateSettings SetQuery(this AzureIotDpsCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDpsCreateSettings ResetQuery(this AzureIotDpsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureIotDpsCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsCreateSettings SetVerbose(this AzureIotDpsCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsCreateSettings ResetVerbose(this AzureIotDpsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureIotDpsDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIotDpsDeleteSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureIotDpsDeleteSettings.Name"/>.</em></p><p>IoT Provisioning Service name.</p></summary>
        [Pure]
        public static AzureIotDpsDeleteSettings SetName(this AzureIotDpsDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsDeleteSettings.Name"/>.</em></p><p>IoT Provisioning Service name.</p></summary>
        [Pure]
        public static AzureIotDpsDeleteSettings ResetName(this AzureIotDpsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureIotDpsDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotDpsDeleteSettings SetResourceGroup(this AzureIotDpsDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotDpsDeleteSettings ResetResourceGroup(this AzureIotDpsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureIotDpsDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsDeleteSettings SetDebug(this AzureIotDpsDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsDeleteSettings ResetDebug(this AzureIotDpsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureIotDpsDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotDpsDeleteSettings SetHelp(this AzureIotDpsDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotDpsDeleteSettings ResetHelp(this AzureIotDpsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureIotDpsDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotDpsDeleteSettings SetOutput(this AzureIotDpsDeleteSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotDpsDeleteSettings ResetOutput(this AzureIotDpsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureIotDpsDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDpsDeleteSettings SetQuery(this AzureIotDpsDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDpsDeleteSettings ResetQuery(this AzureIotDpsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureIotDpsDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsDeleteSettings SetVerbose(this AzureIotDpsDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsDeleteSettings ResetVerbose(this AzureIotDpsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureIotDpsListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIotDpsListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureIotDpsListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotDpsListSettings SetResourceGroup(this AzureIotDpsListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotDpsListSettings ResetResourceGroup(this AzureIotDpsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureIotDpsListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsListSettings SetDebug(this AzureIotDpsListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsListSettings ResetDebug(this AzureIotDpsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureIotDpsListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotDpsListSettings SetHelp(this AzureIotDpsListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotDpsListSettings ResetHelp(this AzureIotDpsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureIotDpsListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotDpsListSettings SetOutput(this AzureIotDpsListSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotDpsListSettings ResetOutput(this AzureIotDpsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureIotDpsListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDpsListSettings SetQuery(this AzureIotDpsListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDpsListSettings ResetQuery(this AzureIotDpsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureIotDpsListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsListSettings SetVerbose(this AzureIotDpsListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsListSettings ResetVerbose(this AzureIotDpsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureIotDpsShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIotDpsShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureIotDpsShowSettings.Name"/>.</em></p><p>IoT Provisioning Service name.</p></summary>
        [Pure]
        public static AzureIotDpsShowSettings SetName(this AzureIotDpsShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsShowSettings.Name"/>.</em></p><p>IoT Provisioning Service name.</p></summary>
        [Pure]
        public static AzureIotDpsShowSettings ResetName(this AzureIotDpsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureIotDpsShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotDpsShowSettings SetResourceGroup(this AzureIotDpsShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotDpsShowSettings ResetResourceGroup(this AzureIotDpsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureIotDpsShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsShowSettings SetDebug(this AzureIotDpsShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsShowSettings ResetDebug(this AzureIotDpsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureIotDpsShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotDpsShowSettings SetHelp(this AzureIotDpsShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotDpsShowSettings ResetHelp(this AzureIotDpsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureIotDpsShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotDpsShowSettings SetOutput(this AzureIotDpsShowSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotDpsShowSettings ResetOutput(this AzureIotDpsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureIotDpsShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDpsShowSettings SetQuery(this AzureIotDpsShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDpsShowSettings ResetQuery(this AzureIotDpsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureIotDpsShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsShowSettings SetVerbose(this AzureIotDpsShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsShowSettings ResetVerbose(this AzureIotDpsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureIotDpsUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIotDpsUpdateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureIotDpsUpdateSettings.Name"/>.</em></p><p>IoT Provisioning Service name.</p></summary>
        [Pure]
        public static AzureIotDpsUpdateSettings SetName(this AzureIotDpsUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsUpdateSettings.Name"/>.</em></p><p>IoT Provisioning Service name.</p></summary>
        [Pure]
        public static AzureIotDpsUpdateSettings ResetName(this AzureIotDpsUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureIotDpsUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotDpsUpdateSettings SetResourceGroup(this AzureIotDpsUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotDpsUpdateSettings ResetResourceGroup(this AzureIotDpsUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary><p><em>Sets <see cref="AzureIotDpsUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureIotDpsUpdateSettings SetAdd(this AzureIotDpsUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureIotDpsUpdateSettings ResetAdd(this AzureIotDpsUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary><p><em>Sets <see cref="AzureIotDpsUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureIotDpsUpdateSettings SetRemove(this AzureIotDpsUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureIotDpsUpdateSettings ResetRemove(this AzureIotDpsUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary><p><em>Sets <see cref="AzureIotDpsUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureIotDpsUpdateSettings SetSet(this AzureIotDpsUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureIotDpsUpdateSettings ResetSet(this AzureIotDpsUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureIotDpsUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsUpdateSettings SetDebug(this AzureIotDpsUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsUpdateSettings ResetDebug(this AzureIotDpsUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureIotDpsUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotDpsUpdateSettings SetHelp(this AzureIotDpsUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotDpsUpdateSettings ResetHelp(this AzureIotDpsUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureIotDpsUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotDpsUpdateSettings SetOutput(this AzureIotDpsUpdateSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotDpsUpdateSettings ResetOutput(this AzureIotDpsUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureIotDpsUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDpsUpdateSettings SetQuery(this AzureIotDpsUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDpsUpdateSettings ResetQuery(this AzureIotDpsUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureIotDpsUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsUpdateSettings SetVerbose(this AzureIotDpsUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsUpdateSettings ResetVerbose(this AzureIotDpsUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureIotHubCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIotHubCreateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureIotHubCreateSettings.Name"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotHubCreateSettings SetName(this AzureIotHubCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCreateSettings.Name"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotHubCreateSettings ResetName(this AzureIotHubCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureIotHubCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotHubCreateSettings SetResourceGroup(this AzureIotHubCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotHubCreateSettings ResetResourceGroup(this AzureIotHubCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary><p><em>Sets <see cref="AzureIotHubCreateSettings.Location"/>.</em></p><p>Location of your IoT Hub. Default is the location of target resource group.</p></summary>
        [Pure]
        public static AzureIotHubCreateSettings SetLocation(this AzureIotHubCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCreateSettings.Location"/>.</em></p><p>Location of your IoT Hub. Default is the location of target resource group.</p></summary>
        [Pure]
        public static AzureIotHubCreateSettings ResetLocation(this AzureIotHubCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region PartitionCount
        /// <summary><p><em>Sets <see cref="AzureIotHubCreateSettings.PartitionCount"/>.</em></p><p>The number of partitions for device-to-cloud messages.</p></summary>
        [Pure]
        public static AzureIotHubCreateSettings SetPartitionCount(this AzureIotHubCreateSettings toolSettings, string partitionCount)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PartitionCount = partitionCount;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCreateSettings.PartitionCount"/>.</em></p><p>The number of partitions for device-to-cloud messages.</p></summary>
        [Pure]
        public static AzureIotHubCreateSettings ResetPartitionCount(this AzureIotHubCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PartitionCount = null;
            return toolSettings;
        }
        #endregion
        #region Sku
        /// <summary><p><em>Sets <see cref="AzureIotHubCreateSettings.Sku"/>.</em></p><p>Pricing tier for Azure IoT Hub. Default value is F1, which is free. Note that only one free IoT hub instance is allowed in each subscription. Exception will be thrown if free instances exceed one.</p></summary>
        [Pure]
        public static AzureIotHubCreateSettings SetSku(this AzureIotHubCreateSettings toolSettings, IotHubCreateSku sku)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = sku;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCreateSettings.Sku"/>.</em></p><p>Pricing tier for Azure IoT Hub. Default value is F1, which is free. Note that only one free IoT hub instance is allowed in each subscription. Exception will be thrown if free instances exceed one.</p></summary>
        [Pure]
        public static AzureIotHubCreateSettings ResetSku(this AzureIotHubCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = null;
            return toolSettings;
        }
        #endregion
        #region Unit
        /// <summary><p><em>Sets <see cref="AzureIotHubCreateSettings.Unit"/>.</em></p><p>Units in your IoT Hub.</p></summary>
        [Pure]
        public static AzureIotHubCreateSettings SetUnit(this AzureIotHubCreateSettings toolSettings, string unit)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Unit = unit;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCreateSettings.Unit"/>.</em></p><p>Units in your IoT Hub.</p></summary>
        [Pure]
        public static AzureIotHubCreateSettings ResetUnit(this AzureIotHubCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Unit = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureIotHubCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotHubCreateSettings SetDebug(this AzureIotHubCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotHubCreateSettings ResetDebug(this AzureIotHubCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureIotHubCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotHubCreateSettings SetHelp(this AzureIotHubCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotHubCreateSettings ResetHelp(this AzureIotHubCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureIotHubCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotHubCreateSettings SetOutput(this AzureIotHubCreateSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotHubCreateSettings ResetOutput(this AzureIotHubCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureIotHubCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubCreateSettings SetQuery(this AzureIotHubCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubCreateSettings ResetQuery(this AzureIotHubCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureIotHubCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotHubCreateSettings SetVerbose(this AzureIotHubCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotHubCreateSettings ResetVerbose(this AzureIotHubCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureIotHubDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIotHubDeleteSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureIotHubDeleteSettings.Name"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotHubDeleteSettings SetName(this AzureIotHubDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubDeleteSettings.Name"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotHubDeleteSettings ResetName(this AzureIotHubDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureIotHubDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotHubDeleteSettings SetResourceGroup(this AzureIotHubDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotHubDeleteSettings ResetResourceGroup(this AzureIotHubDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureIotHubDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotHubDeleteSettings SetDebug(this AzureIotHubDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotHubDeleteSettings ResetDebug(this AzureIotHubDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureIotHubDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotHubDeleteSettings SetHelp(this AzureIotHubDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotHubDeleteSettings ResetHelp(this AzureIotHubDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureIotHubDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotHubDeleteSettings SetOutput(this AzureIotHubDeleteSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotHubDeleteSettings ResetOutput(this AzureIotHubDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureIotHubDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubDeleteSettings SetQuery(this AzureIotHubDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubDeleteSettings ResetQuery(this AzureIotHubDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureIotHubDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotHubDeleteSettings SetVerbose(this AzureIotHubDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotHubDeleteSettings ResetVerbose(this AzureIotHubDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureIotHubListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIotHubListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureIotHubListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotHubListSettings SetResourceGroup(this AzureIotHubListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotHubListSettings ResetResourceGroup(this AzureIotHubListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureIotHubListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotHubListSettings SetDebug(this AzureIotHubListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotHubListSettings ResetDebug(this AzureIotHubListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureIotHubListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotHubListSettings SetHelp(this AzureIotHubListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotHubListSettings ResetHelp(this AzureIotHubListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureIotHubListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotHubListSettings SetOutput(this AzureIotHubListSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotHubListSettings ResetOutput(this AzureIotHubListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureIotHubListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubListSettings SetQuery(this AzureIotHubListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubListSettings ResetQuery(this AzureIotHubListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureIotHubListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotHubListSettings SetVerbose(this AzureIotHubListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotHubListSettings ResetVerbose(this AzureIotHubListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureIotHubListSkusSettingsExtensions
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIotHubListSkusSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureIotHubListSkusSettings.Name"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotHubListSkusSettings SetName(this AzureIotHubListSkusSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubListSkusSettings.Name"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotHubListSkusSettings ResetName(this AzureIotHubListSkusSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureIotHubListSkusSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotHubListSkusSettings SetResourceGroup(this AzureIotHubListSkusSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubListSkusSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotHubListSkusSettings ResetResourceGroup(this AzureIotHubListSkusSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureIotHubListSkusSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotHubListSkusSettings SetDebug(this AzureIotHubListSkusSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubListSkusSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotHubListSkusSettings ResetDebug(this AzureIotHubListSkusSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureIotHubListSkusSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotHubListSkusSettings SetHelp(this AzureIotHubListSkusSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubListSkusSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotHubListSkusSettings ResetHelp(this AzureIotHubListSkusSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureIotHubListSkusSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotHubListSkusSettings SetOutput(this AzureIotHubListSkusSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubListSkusSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotHubListSkusSettings ResetOutput(this AzureIotHubListSkusSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureIotHubListSkusSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubListSkusSettings SetQuery(this AzureIotHubListSkusSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubListSkusSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubListSkusSettings ResetQuery(this AzureIotHubListSkusSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureIotHubListSkusSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotHubListSkusSettings SetVerbose(this AzureIotHubListSkusSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubListSkusSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotHubListSkusSettings ResetVerbose(this AzureIotHubListSkusSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureIotHubShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIotHubShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureIotHubShowSettings.Name"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotHubShowSettings SetName(this AzureIotHubShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubShowSettings.Name"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotHubShowSettings ResetName(this AzureIotHubShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureIotHubShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotHubShowSettings SetResourceGroup(this AzureIotHubShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotHubShowSettings ResetResourceGroup(this AzureIotHubShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureIotHubShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotHubShowSettings SetDebug(this AzureIotHubShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotHubShowSettings ResetDebug(this AzureIotHubShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureIotHubShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotHubShowSettings SetHelp(this AzureIotHubShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotHubShowSettings ResetHelp(this AzureIotHubShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureIotHubShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotHubShowSettings SetOutput(this AzureIotHubShowSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotHubShowSettings ResetOutput(this AzureIotHubShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureIotHubShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubShowSettings SetQuery(this AzureIotHubShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubShowSettings ResetQuery(this AzureIotHubShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureIotHubShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotHubShowSettings SetVerbose(this AzureIotHubShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotHubShowSettings ResetVerbose(this AzureIotHubShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureIotHubShowConnectionStringSettingsExtensions
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIotHubShowConnectionStringSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureIotHubShowConnectionStringSettings.Name"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotHubShowConnectionStringSettings SetName(this AzureIotHubShowConnectionStringSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubShowConnectionStringSettings.Name"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotHubShowConnectionStringSettings ResetName(this AzureIotHubShowConnectionStringSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Key
        /// <summary><p><em>Sets <see cref="AzureIotHubShowConnectionStringSettings.Key"/>.</em></p><p>The key to use.</p></summary>
        [Pure]
        public static AzureIotHubShowConnectionStringSettings SetKey(this AzureIotHubShowConnectionStringSettings toolSettings, IotDeviceKey key)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Key = key;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubShowConnectionStringSettings.Key"/>.</em></p><p>The key to use.</p></summary>
        [Pure]
        public static AzureIotHubShowConnectionStringSettings ResetKey(this AzureIotHubShowConnectionStringSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Key = null;
            return toolSettings;
        }
        #endregion
        #region PolicyName
        /// <summary><p><em>Sets <see cref="AzureIotHubShowConnectionStringSettings.PolicyName"/>.</em></p><p>Shared access policy to use.</p></summary>
        [Pure]
        public static AzureIotHubShowConnectionStringSettings SetPolicyName(this AzureIotHubShowConnectionStringSettings toolSettings, string policyName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PolicyName = policyName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubShowConnectionStringSettings.PolicyName"/>.</em></p><p>Shared access policy to use.</p></summary>
        [Pure]
        public static AzureIotHubShowConnectionStringSettings ResetPolicyName(this AzureIotHubShowConnectionStringSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PolicyName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureIotHubShowConnectionStringSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotHubShowConnectionStringSettings SetResourceGroup(this AzureIotHubShowConnectionStringSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubShowConnectionStringSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotHubShowConnectionStringSettings ResetResourceGroup(this AzureIotHubShowConnectionStringSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureIotHubShowConnectionStringSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotHubShowConnectionStringSettings SetDebug(this AzureIotHubShowConnectionStringSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubShowConnectionStringSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotHubShowConnectionStringSettings ResetDebug(this AzureIotHubShowConnectionStringSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureIotHubShowConnectionStringSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotHubShowConnectionStringSettings SetHelp(this AzureIotHubShowConnectionStringSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubShowConnectionStringSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotHubShowConnectionStringSettings ResetHelp(this AzureIotHubShowConnectionStringSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureIotHubShowConnectionStringSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotHubShowConnectionStringSettings SetOutput(this AzureIotHubShowConnectionStringSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubShowConnectionStringSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotHubShowConnectionStringSettings ResetOutput(this AzureIotHubShowConnectionStringSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureIotHubShowConnectionStringSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubShowConnectionStringSettings SetQuery(this AzureIotHubShowConnectionStringSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubShowConnectionStringSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubShowConnectionStringSettings ResetQuery(this AzureIotHubShowConnectionStringSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureIotHubShowConnectionStringSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotHubShowConnectionStringSettings SetVerbose(this AzureIotHubShowConnectionStringSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubShowConnectionStringSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotHubShowConnectionStringSettings ResetVerbose(this AzureIotHubShowConnectionStringSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureIotHubShowQuotaMetricsSettingsExtensions
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIotHubShowQuotaMetricsSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureIotHubShowQuotaMetricsSettings.Name"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotHubShowQuotaMetricsSettings SetName(this AzureIotHubShowQuotaMetricsSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubShowQuotaMetricsSettings.Name"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotHubShowQuotaMetricsSettings ResetName(this AzureIotHubShowQuotaMetricsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureIotHubShowQuotaMetricsSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotHubShowQuotaMetricsSettings SetResourceGroup(this AzureIotHubShowQuotaMetricsSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubShowQuotaMetricsSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotHubShowQuotaMetricsSettings ResetResourceGroup(this AzureIotHubShowQuotaMetricsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureIotHubShowQuotaMetricsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotHubShowQuotaMetricsSettings SetDebug(this AzureIotHubShowQuotaMetricsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubShowQuotaMetricsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotHubShowQuotaMetricsSettings ResetDebug(this AzureIotHubShowQuotaMetricsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureIotHubShowQuotaMetricsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotHubShowQuotaMetricsSettings SetHelp(this AzureIotHubShowQuotaMetricsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubShowQuotaMetricsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotHubShowQuotaMetricsSettings ResetHelp(this AzureIotHubShowQuotaMetricsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureIotHubShowQuotaMetricsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotHubShowQuotaMetricsSettings SetOutput(this AzureIotHubShowQuotaMetricsSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubShowQuotaMetricsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotHubShowQuotaMetricsSettings ResetOutput(this AzureIotHubShowQuotaMetricsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureIotHubShowQuotaMetricsSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubShowQuotaMetricsSettings SetQuery(this AzureIotHubShowQuotaMetricsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubShowQuotaMetricsSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubShowQuotaMetricsSettings ResetQuery(this AzureIotHubShowQuotaMetricsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureIotHubShowQuotaMetricsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotHubShowQuotaMetricsSettings SetVerbose(this AzureIotHubShowQuotaMetricsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubShowQuotaMetricsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotHubShowQuotaMetricsSettings ResetVerbose(this AzureIotHubShowQuotaMetricsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureIotHubShowStatsSettingsExtensions
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIotHubShowStatsSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureIotHubShowStatsSettings.Name"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotHubShowStatsSettings SetName(this AzureIotHubShowStatsSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubShowStatsSettings.Name"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotHubShowStatsSettings ResetName(this AzureIotHubShowStatsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureIotHubShowStatsSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotHubShowStatsSettings SetResourceGroup(this AzureIotHubShowStatsSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubShowStatsSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotHubShowStatsSettings ResetResourceGroup(this AzureIotHubShowStatsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureIotHubShowStatsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotHubShowStatsSettings SetDebug(this AzureIotHubShowStatsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubShowStatsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotHubShowStatsSettings ResetDebug(this AzureIotHubShowStatsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureIotHubShowStatsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotHubShowStatsSettings SetHelp(this AzureIotHubShowStatsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubShowStatsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotHubShowStatsSettings ResetHelp(this AzureIotHubShowStatsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureIotHubShowStatsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotHubShowStatsSettings SetOutput(this AzureIotHubShowStatsSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubShowStatsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotHubShowStatsSettings ResetOutput(this AzureIotHubShowStatsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureIotHubShowStatsSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubShowStatsSettings SetQuery(this AzureIotHubShowStatsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubShowStatsSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubShowStatsSettings ResetQuery(this AzureIotHubShowStatsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureIotHubShowStatsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotHubShowStatsSettings SetVerbose(this AzureIotHubShowStatsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubShowStatsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotHubShowStatsSettings ResetVerbose(this AzureIotHubShowStatsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureIotHubUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIotHubUpdateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureIotHubUpdateSettings.Name"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotHubUpdateSettings SetName(this AzureIotHubUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubUpdateSettings.Name"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotHubUpdateSettings ResetName(this AzureIotHubUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureIotHubUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotHubUpdateSettings SetResourceGroup(this AzureIotHubUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotHubUpdateSettings ResetResourceGroup(this AzureIotHubUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary><p><em>Sets <see cref="AzureIotHubUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureIotHubUpdateSettings SetAdd(this AzureIotHubUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureIotHubUpdateSettings ResetAdd(this AzureIotHubUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary><p><em>Sets <see cref="AzureIotHubUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureIotHubUpdateSettings SetRemove(this AzureIotHubUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureIotHubUpdateSettings ResetRemove(this AzureIotHubUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary><p><em>Sets <see cref="AzureIotHubUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureIotHubUpdateSettings SetSet(this AzureIotHubUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureIotHubUpdateSettings ResetSet(this AzureIotHubUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureIotHubUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotHubUpdateSettings SetDebug(this AzureIotHubUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotHubUpdateSettings ResetDebug(this AzureIotHubUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureIotHubUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotHubUpdateSettings SetHelp(this AzureIotHubUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotHubUpdateSettings ResetHelp(this AzureIotHubUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureIotHubUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotHubUpdateSettings SetOutput(this AzureIotHubUpdateSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotHubUpdateSettings ResetOutput(this AzureIotHubUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureIotHubUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubUpdateSettings SetQuery(this AzureIotHubUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubUpdateSettings ResetQuery(this AzureIotHubUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureIotHubUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotHubUpdateSettings SetVerbose(this AzureIotHubUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotHubUpdateSettings ResetVerbose(this AzureIotHubUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureIotDeviceMessageAbandonSettingsExtensions
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIotDeviceMessageAbandonSettingsExtensions
    {
        #region DeviceId
        /// <summary><p><em>Sets <see cref="AzureIotDeviceMessageAbandonSettings.DeviceId"/>.</em></p><p>Device Id.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageAbandonSettings SetDeviceId(this AzureIotDeviceMessageAbandonSettings toolSettings, string deviceId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DeviceId = deviceId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceMessageAbandonSettings.DeviceId"/>.</em></p><p>Device Id.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageAbandonSettings ResetDeviceId(this AzureIotDeviceMessageAbandonSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DeviceId = null;
            return toolSettings;
        }
        #endregion
        #region HubName
        /// <summary><p><em>Sets <see cref="AzureIotDeviceMessageAbandonSettings.HubName"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageAbandonSettings SetHubName(this AzureIotDeviceMessageAbandonSettings toolSettings, string hubName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HubName = hubName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceMessageAbandonSettings.HubName"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageAbandonSettings ResetHubName(this AzureIotDeviceMessageAbandonSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HubName = null;
            return toolSettings;
        }
        #endregion
        #region LockToken
        /// <summary><p><em>Sets <see cref="AzureIotDeviceMessageAbandonSettings.LockToken"/>.</em></p><p>Message lock token.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageAbandonSettings SetLockToken(this AzureIotDeviceMessageAbandonSettings toolSettings, string lockToken)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LockToken = lockToken;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceMessageAbandonSettings.LockToken"/>.</em></p><p>Message lock token.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageAbandonSettings ResetLockToken(this AzureIotDeviceMessageAbandonSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LockToken = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureIotDeviceMessageAbandonSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageAbandonSettings SetResourceGroup(this AzureIotDeviceMessageAbandonSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceMessageAbandonSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageAbandonSettings ResetResourceGroup(this AzureIotDeviceMessageAbandonSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureIotDeviceMessageAbandonSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageAbandonSettings SetDebug(this AzureIotDeviceMessageAbandonSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceMessageAbandonSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageAbandonSettings ResetDebug(this AzureIotDeviceMessageAbandonSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureIotDeviceMessageAbandonSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageAbandonSettings SetHelp(this AzureIotDeviceMessageAbandonSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceMessageAbandonSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageAbandonSettings ResetHelp(this AzureIotDeviceMessageAbandonSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureIotDeviceMessageAbandonSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageAbandonSettings SetOutput(this AzureIotDeviceMessageAbandonSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceMessageAbandonSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageAbandonSettings ResetOutput(this AzureIotDeviceMessageAbandonSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureIotDeviceMessageAbandonSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageAbandonSettings SetQuery(this AzureIotDeviceMessageAbandonSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceMessageAbandonSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageAbandonSettings ResetQuery(this AzureIotDeviceMessageAbandonSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureIotDeviceMessageAbandonSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageAbandonSettings SetVerbose(this AzureIotDeviceMessageAbandonSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceMessageAbandonSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageAbandonSettings ResetVerbose(this AzureIotDeviceMessageAbandonSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureIotDeviceMessageCompleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIotDeviceMessageCompleteSettingsExtensions
    {
        #region DeviceId
        /// <summary><p><em>Sets <see cref="AzureIotDeviceMessageCompleteSettings.DeviceId"/>.</em></p><p>Device Id.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageCompleteSettings SetDeviceId(this AzureIotDeviceMessageCompleteSettings toolSettings, string deviceId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DeviceId = deviceId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceMessageCompleteSettings.DeviceId"/>.</em></p><p>Device Id.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageCompleteSettings ResetDeviceId(this AzureIotDeviceMessageCompleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DeviceId = null;
            return toolSettings;
        }
        #endregion
        #region HubName
        /// <summary><p><em>Sets <see cref="AzureIotDeviceMessageCompleteSettings.HubName"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageCompleteSettings SetHubName(this AzureIotDeviceMessageCompleteSettings toolSettings, string hubName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HubName = hubName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceMessageCompleteSettings.HubName"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageCompleteSettings ResetHubName(this AzureIotDeviceMessageCompleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HubName = null;
            return toolSettings;
        }
        #endregion
        #region LockToken
        /// <summary><p><em>Sets <see cref="AzureIotDeviceMessageCompleteSettings.LockToken"/>.</em></p><p>Message lock token.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageCompleteSettings SetLockToken(this AzureIotDeviceMessageCompleteSettings toolSettings, string lockToken)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LockToken = lockToken;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceMessageCompleteSettings.LockToken"/>.</em></p><p>Message lock token.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageCompleteSettings ResetLockToken(this AzureIotDeviceMessageCompleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LockToken = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureIotDeviceMessageCompleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageCompleteSettings SetResourceGroup(this AzureIotDeviceMessageCompleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceMessageCompleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageCompleteSettings ResetResourceGroup(this AzureIotDeviceMessageCompleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureIotDeviceMessageCompleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageCompleteSettings SetDebug(this AzureIotDeviceMessageCompleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceMessageCompleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageCompleteSettings ResetDebug(this AzureIotDeviceMessageCompleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureIotDeviceMessageCompleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageCompleteSettings SetHelp(this AzureIotDeviceMessageCompleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceMessageCompleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageCompleteSettings ResetHelp(this AzureIotDeviceMessageCompleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureIotDeviceMessageCompleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageCompleteSettings SetOutput(this AzureIotDeviceMessageCompleteSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceMessageCompleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageCompleteSettings ResetOutput(this AzureIotDeviceMessageCompleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureIotDeviceMessageCompleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageCompleteSettings SetQuery(this AzureIotDeviceMessageCompleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceMessageCompleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageCompleteSettings ResetQuery(this AzureIotDeviceMessageCompleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureIotDeviceMessageCompleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageCompleteSettings SetVerbose(this AzureIotDeviceMessageCompleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceMessageCompleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageCompleteSettings ResetVerbose(this AzureIotDeviceMessageCompleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureIotDeviceMessageReceiveSettingsExtensions
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIotDeviceMessageReceiveSettingsExtensions
    {
        #region DeviceId
        /// <summary><p><em>Sets <see cref="AzureIotDeviceMessageReceiveSettings.DeviceId"/>.</em></p><p>Device Id.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageReceiveSettings SetDeviceId(this AzureIotDeviceMessageReceiveSettings toolSettings, string deviceId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DeviceId = deviceId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceMessageReceiveSettings.DeviceId"/>.</em></p><p>Device Id.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageReceiveSettings ResetDeviceId(this AzureIotDeviceMessageReceiveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DeviceId = null;
            return toolSettings;
        }
        #endregion
        #region HubName
        /// <summary><p><em>Sets <see cref="AzureIotDeviceMessageReceiveSettings.HubName"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageReceiveSettings SetHubName(this AzureIotDeviceMessageReceiveSettings toolSettings, string hubName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HubName = hubName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceMessageReceiveSettings.HubName"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageReceiveSettings ResetHubName(this AzureIotDeviceMessageReceiveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HubName = null;
            return toolSettings;
        }
        #endregion
        #region LockTimeout
        /// <summary><p><em>Sets <see cref="AzureIotDeviceMessageReceiveSettings.LockTimeout"/>.</em></p><p>In case a message returned to this call, this specifies the amount of time in seconds, the message will be invisible to other receive calls.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageReceiveSettings SetLockTimeout(this AzureIotDeviceMessageReceiveSettings toolSettings, string lockTimeout)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LockTimeout = lockTimeout;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceMessageReceiveSettings.LockTimeout"/>.</em></p><p>In case a message returned to this call, this specifies the amount of time in seconds, the message will be invisible to other receive calls.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageReceiveSettings ResetLockTimeout(this AzureIotDeviceMessageReceiveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LockTimeout = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureIotDeviceMessageReceiveSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageReceiveSettings SetResourceGroup(this AzureIotDeviceMessageReceiveSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceMessageReceiveSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageReceiveSettings ResetResourceGroup(this AzureIotDeviceMessageReceiveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureIotDeviceMessageReceiveSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageReceiveSettings SetDebug(this AzureIotDeviceMessageReceiveSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceMessageReceiveSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageReceiveSettings ResetDebug(this AzureIotDeviceMessageReceiveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureIotDeviceMessageReceiveSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageReceiveSettings SetHelp(this AzureIotDeviceMessageReceiveSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceMessageReceiveSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageReceiveSettings ResetHelp(this AzureIotDeviceMessageReceiveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureIotDeviceMessageReceiveSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageReceiveSettings SetOutput(this AzureIotDeviceMessageReceiveSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceMessageReceiveSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageReceiveSettings ResetOutput(this AzureIotDeviceMessageReceiveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureIotDeviceMessageReceiveSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageReceiveSettings SetQuery(this AzureIotDeviceMessageReceiveSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceMessageReceiveSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageReceiveSettings ResetQuery(this AzureIotDeviceMessageReceiveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureIotDeviceMessageReceiveSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageReceiveSettings SetVerbose(this AzureIotDeviceMessageReceiveSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceMessageReceiveSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageReceiveSettings ResetVerbose(this AzureIotDeviceMessageReceiveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureIotDeviceMessageRejectSettingsExtensions
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIotDeviceMessageRejectSettingsExtensions
    {
        #region DeviceId
        /// <summary><p><em>Sets <see cref="AzureIotDeviceMessageRejectSettings.DeviceId"/>.</em></p><p>Device Id.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageRejectSettings SetDeviceId(this AzureIotDeviceMessageRejectSettings toolSettings, string deviceId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DeviceId = deviceId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceMessageRejectSettings.DeviceId"/>.</em></p><p>Device Id.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageRejectSettings ResetDeviceId(this AzureIotDeviceMessageRejectSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DeviceId = null;
            return toolSettings;
        }
        #endregion
        #region HubName
        /// <summary><p><em>Sets <see cref="AzureIotDeviceMessageRejectSettings.HubName"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageRejectSettings SetHubName(this AzureIotDeviceMessageRejectSettings toolSettings, string hubName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HubName = hubName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceMessageRejectSettings.HubName"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageRejectSettings ResetHubName(this AzureIotDeviceMessageRejectSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HubName = null;
            return toolSettings;
        }
        #endregion
        #region LockToken
        /// <summary><p><em>Sets <see cref="AzureIotDeviceMessageRejectSettings.LockToken"/>.</em></p><p>Message lock token.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageRejectSettings SetLockToken(this AzureIotDeviceMessageRejectSettings toolSettings, string lockToken)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LockToken = lockToken;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceMessageRejectSettings.LockToken"/>.</em></p><p>Message lock token.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageRejectSettings ResetLockToken(this AzureIotDeviceMessageRejectSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LockToken = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureIotDeviceMessageRejectSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageRejectSettings SetResourceGroup(this AzureIotDeviceMessageRejectSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceMessageRejectSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageRejectSettings ResetResourceGroup(this AzureIotDeviceMessageRejectSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureIotDeviceMessageRejectSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageRejectSettings SetDebug(this AzureIotDeviceMessageRejectSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceMessageRejectSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageRejectSettings ResetDebug(this AzureIotDeviceMessageRejectSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureIotDeviceMessageRejectSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageRejectSettings SetHelp(this AzureIotDeviceMessageRejectSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceMessageRejectSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageRejectSettings ResetHelp(this AzureIotDeviceMessageRejectSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureIotDeviceMessageRejectSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageRejectSettings SetOutput(this AzureIotDeviceMessageRejectSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceMessageRejectSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageRejectSettings ResetOutput(this AzureIotDeviceMessageRejectSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureIotDeviceMessageRejectSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageRejectSettings SetQuery(this AzureIotDeviceMessageRejectSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceMessageRejectSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageRejectSettings ResetQuery(this AzureIotDeviceMessageRejectSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureIotDeviceMessageRejectSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageRejectSettings SetVerbose(this AzureIotDeviceMessageRejectSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceMessageRejectSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageRejectSettings ResetVerbose(this AzureIotDeviceMessageRejectSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureIotDeviceMessageSendSettingsExtensions
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIotDeviceMessageSendSettingsExtensions
    {
        #region DeviceId
        /// <summary><p><em>Sets <see cref="AzureIotDeviceMessageSendSettings.DeviceId"/>.</em></p><p>Device Id.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageSendSettings SetDeviceId(this AzureIotDeviceMessageSendSettings toolSettings, string deviceId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DeviceId = deviceId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceMessageSendSettings.DeviceId"/>.</em></p><p>Device Id.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageSendSettings ResetDeviceId(this AzureIotDeviceMessageSendSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DeviceId = null;
            return toolSettings;
        }
        #endregion
        #region HubName
        /// <summary><p><em>Sets <see cref="AzureIotDeviceMessageSendSettings.HubName"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageSendSettings SetHubName(this AzureIotDeviceMessageSendSettings toolSettings, string hubName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HubName = hubName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceMessageSendSettings.HubName"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageSendSettings ResetHubName(this AzureIotDeviceMessageSendSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HubName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureIotDeviceMessageSendSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageSendSettings SetResourceGroup(this AzureIotDeviceMessageSendSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceMessageSendSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageSendSettings ResetResourceGroup(this AzureIotDeviceMessageSendSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region CorrelationId
        /// <summary><p><em>Sets <see cref="AzureIotDeviceMessageSendSettings.CorrelationId"/>.</em></p><p>Device-to-cloud message correlation Id.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageSendSettings SetCorrelationId(this AzureIotDeviceMessageSendSettings toolSettings, string correlationId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CorrelationId = correlationId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceMessageSendSettings.CorrelationId"/>.</em></p><p>Device-to-cloud message correlation Id.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageSendSettings ResetCorrelationId(this AzureIotDeviceMessageSendSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CorrelationId = null;
            return toolSettings;
        }
        #endregion
        #region Data
        /// <summary><p><em>Sets <see cref="AzureIotDeviceMessageSendSettings.Data"/>.</em></p><p>Device-to-cloud message body.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageSendSettings SetData(this AzureIotDeviceMessageSendSettings toolSettings, string data)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Data = data;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceMessageSendSettings.Data"/>.</em></p><p>Device-to-cloud message body.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageSendSettings ResetData(this AzureIotDeviceMessageSendSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Data = null;
            return toolSettings;
        }
        #endregion
        #region MessageId
        /// <summary><p><em>Sets <see cref="AzureIotDeviceMessageSendSettings.MessageId"/>.</em></p><p>Device-to-cloud message Id.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageSendSettings SetMessageId(this AzureIotDeviceMessageSendSettings toolSettings, string messageId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MessageId = messageId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceMessageSendSettings.MessageId"/>.</em></p><p>Device-to-cloud message Id.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageSendSettings ResetMessageId(this AzureIotDeviceMessageSendSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MessageId = null;
            return toolSettings;
        }
        #endregion
        #region UserId
        /// <summary><p><em>Sets <see cref="AzureIotDeviceMessageSendSettings.UserId"/>.</em></p><p>Device-to-cloud message user Id.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageSendSettings SetUserId(this AzureIotDeviceMessageSendSettings toolSettings, string userId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UserId = userId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceMessageSendSettings.UserId"/>.</em></p><p>Device-to-cloud message user Id.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageSendSettings ResetUserId(this AzureIotDeviceMessageSendSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UserId = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureIotDeviceMessageSendSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageSendSettings SetDebug(this AzureIotDeviceMessageSendSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceMessageSendSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageSendSettings ResetDebug(this AzureIotDeviceMessageSendSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureIotDeviceMessageSendSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageSendSettings SetHelp(this AzureIotDeviceMessageSendSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceMessageSendSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageSendSettings ResetHelp(this AzureIotDeviceMessageSendSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureIotDeviceMessageSendSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageSendSettings SetOutput(this AzureIotDeviceMessageSendSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceMessageSendSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageSendSettings ResetOutput(this AzureIotDeviceMessageSendSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureIotDeviceMessageSendSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageSendSettings SetQuery(this AzureIotDeviceMessageSendSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceMessageSendSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageSendSettings ResetQuery(this AzureIotDeviceMessageSendSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureIotDeviceMessageSendSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageSendSettings SetVerbose(this AzureIotDeviceMessageSendSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDeviceMessageSendSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotDeviceMessageSendSettings ResetVerbose(this AzureIotDeviceMessageSendSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureIotDpsAccessPolicyCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIotDpsAccessPolicyCreateSettingsExtensions
    {
        #region AccessPolicyName
        /// <summary><p><em>Sets <see cref="AzureIotDpsAccessPolicyCreateSettings.AccessPolicyName"/>.</em></p><p>A friendly name for DPS access policy.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyCreateSettings SetAccessPolicyName(this AzureIotDpsAccessPolicyCreateSettings toolSettings, string accessPolicyName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccessPolicyName = accessPolicyName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsAccessPolicyCreateSettings.AccessPolicyName"/>.</em></p><p>A friendly name for DPS access policy.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyCreateSettings ResetAccessPolicyName(this AzureIotDpsAccessPolicyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccessPolicyName = null;
            return toolSettings;
        }
        #endregion
        #region DpsName
        /// <summary><p><em>Sets <see cref="AzureIotDpsAccessPolicyCreateSettings.DpsName"/>.</em></p><p>IoT Provisioning Service name.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyCreateSettings SetDpsName(this AzureIotDpsAccessPolicyCreateSettings toolSettings, string dpsName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DpsName = dpsName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsAccessPolicyCreateSettings.DpsName"/>.</em></p><p>IoT Provisioning Service name.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyCreateSettings ResetDpsName(this AzureIotDpsAccessPolicyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DpsName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureIotDpsAccessPolicyCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyCreateSettings SetResourceGroup(this AzureIotDpsAccessPolicyCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsAccessPolicyCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyCreateSettings ResetResourceGroup(this AzureIotDpsAccessPolicyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Rights
        /// <summary><p><em>Sets <see cref="AzureIotDpsAccessPolicyCreateSettings.Rights"/>.</em></p><p>Access rights for the IoT provisioning service. Use space-separated list for multiple rights.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyCreateSettings SetRights(this AzureIotDpsAccessPolicyCreateSettings toolSettings, IotDpsAccessPolicyRights rights)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Rights = rights;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsAccessPolicyCreateSettings.Rights"/>.</em></p><p>Access rights for the IoT provisioning service. Use space-separated list for multiple rights.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyCreateSettings ResetRights(this AzureIotDpsAccessPolicyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Rights = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary><p><em>Sets <see cref="AzureIotDpsAccessPolicyCreateSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyCreateSettings SetNoWait(this AzureIotDpsAccessPolicyCreateSettings toolSettings, string noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsAccessPolicyCreateSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyCreateSettings ResetNoWait(this AzureIotDpsAccessPolicyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        #endregion
        #region PrimaryKey
        /// <summary><p><em>Sets <see cref="AzureIotDpsAccessPolicyCreateSettings.PrimaryKey"/>.</em></p><p>Primary SAS key value.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyCreateSettings SetPrimaryKey(this AzureIotDpsAccessPolicyCreateSettings toolSettings, string primaryKey)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PrimaryKey = primaryKey;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsAccessPolicyCreateSettings.PrimaryKey"/>.</em></p><p>Primary SAS key value.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyCreateSettings ResetPrimaryKey(this AzureIotDpsAccessPolicyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PrimaryKey = null;
            return toolSettings;
        }
        #endregion
        #region SecondaryKey
        /// <summary><p><em>Sets <see cref="AzureIotDpsAccessPolicyCreateSettings.SecondaryKey"/>.</em></p><p>Secondary SAS key value.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyCreateSettings SetSecondaryKey(this AzureIotDpsAccessPolicyCreateSettings toolSettings, string secondaryKey)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SecondaryKey = secondaryKey;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsAccessPolicyCreateSettings.SecondaryKey"/>.</em></p><p>Secondary SAS key value.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyCreateSettings ResetSecondaryKey(this AzureIotDpsAccessPolicyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SecondaryKey = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureIotDpsAccessPolicyCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyCreateSettings SetDebug(this AzureIotDpsAccessPolicyCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsAccessPolicyCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyCreateSettings ResetDebug(this AzureIotDpsAccessPolicyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureIotDpsAccessPolicyCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyCreateSettings SetHelp(this AzureIotDpsAccessPolicyCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsAccessPolicyCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyCreateSettings ResetHelp(this AzureIotDpsAccessPolicyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureIotDpsAccessPolicyCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyCreateSettings SetOutput(this AzureIotDpsAccessPolicyCreateSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsAccessPolicyCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyCreateSettings ResetOutput(this AzureIotDpsAccessPolicyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureIotDpsAccessPolicyCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyCreateSettings SetQuery(this AzureIotDpsAccessPolicyCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsAccessPolicyCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyCreateSettings ResetQuery(this AzureIotDpsAccessPolicyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureIotDpsAccessPolicyCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyCreateSettings SetVerbose(this AzureIotDpsAccessPolicyCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsAccessPolicyCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyCreateSettings ResetVerbose(this AzureIotDpsAccessPolicyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureIotDpsAccessPolicyDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIotDpsAccessPolicyDeleteSettingsExtensions
    {
        #region AccessPolicyName
        /// <summary><p><em>Sets <see cref="AzureIotDpsAccessPolicyDeleteSettings.AccessPolicyName"/>.</em></p><p>A friendly name for DPS access policy.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyDeleteSettings SetAccessPolicyName(this AzureIotDpsAccessPolicyDeleteSettings toolSettings, string accessPolicyName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccessPolicyName = accessPolicyName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsAccessPolicyDeleteSettings.AccessPolicyName"/>.</em></p><p>A friendly name for DPS access policy.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyDeleteSettings ResetAccessPolicyName(this AzureIotDpsAccessPolicyDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccessPolicyName = null;
            return toolSettings;
        }
        #endregion
        #region DpsName
        /// <summary><p><em>Sets <see cref="AzureIotDpsAccessPolicyDeleteSettings.DpsName"/>.</em></p><p>IoT Provisioning Service name.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyDeleteSettings SetDpsName(this AzureIotDpsAccessPolicyDeleteSettings toolSettings, string dpsName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DpsName = dpsName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsAccessPolicyDeleteSettings.DpsName"/>.</em></p><p>IoT Provisioning Service name.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyDeleteSettings ResetDpsName(this AzureIotDpsAccessPolicyDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DpsName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureIotDpsAccessPolicyDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyDeleteSettings SetResourceGroup(this AzureIotDpsAccessPolicyDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsAccessPolicyDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyDeleteSettings ResetResourceGroup(this AzureIotDpsAccessPolicyDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary><p><em>Sets <see cref="AzureIotDpsAccessPolicyDeleteSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyDeleteSettings SetNoWait(this AzureIotDpsAccessPolicyDeleteSettings toolSettings, string noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsAccessPolicyDeleteSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyDeleteSettings ResetNoWait(this AzureIotDpsAccessPolicyDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureIotDpsAccessPolicyDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyDeleteSettings SetDebug(this AzureIotDpsAccessPolicyDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsAccessPolicyDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyDeleteSettings ResetDebug(this AzureIotDpsAccessPolicyDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureIotDpsAccessPolicyDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyDeleteSettings SetHelp(this AzureIotDpsAccessPolicyDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsAccessPolicyDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyDeleteSettings ResetHelp(this AzureIotDpsAccessPolicyDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureIotDpsAccessPolicyDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyDeleteSettings SetOutput(this AzureIotDpsAccessPolicyDeleteSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsAccessPolicyDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyDeleteSettings ResetOutput(this AzureIotDpsAccessPolicyDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureIotDpsAccessPolicyDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyDeleteSettings SetQuery(this AzureIotDpsAccessPolicyDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsAccessPolicyDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyDeleteSettings ResetQuery(this AzureIotDpsAccessPolicyDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureIotDpsAccessPolicyDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyDeleteSettings SetVerbose(this AzureIotDpsAccessPolicyDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsAccessPolicyDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyDeleteSettings ResetVerbose(this AzureIotDpsAccessPolicyDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureIotDpsAccessPolicyListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIotDpsAccessPolicyListSettingsExtensions
    {
        #region DpsName
        /// <summary><p><em>Sets <see cref="AzureIotDpsAccessPolicyListSettings.DpsName"/>.</em></p><p>IoT Provisioning Service name.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyListSettings SetDpsName(this AzureIotDpsAccessPolicyListSettings toolSettings, string dpsName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DpsName = dpsName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsAccessPolicyListSettings.DpsName"/>.</em></p><p>IoT Provisioning Service name.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyListSettings ResetDpsName(this AzureIotDpsAccessPolicyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DpsName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureIotDpsAccessPolicyListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyListSettings SetResourceGroup(this AzureIotDpsAccessPolicyListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsAccessPolicyListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyListSettings ResetResourceGroup(this AzureIotDpsAccessPolicyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureIotDpsAccessPolicyListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyListSettings SetDebug(this AzureIotDpsAccessPolicyListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsAccessPolicyListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyListSettings ResetDebug(this AzureIotDpsAccessPolicyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureIotDpsAccessPolicyListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyListSettings SetHelp(this AzureIotDpsAccessPolicyListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsAccessPolicyListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyListSettings ResetHelp(this AzureIotDpsAccessPolicyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureIotDpsAccessPolicyListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyListSettings SetOutput(this AzureIotDpsAccessPolicyListSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsAccessPolicyListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyListSettings ResetOutput(this AzureIotDpsAccessPolicyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureIotDpsAccessPolicyListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyListSettings SetQuery(this AzureIotDpsAccessPolicyListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsAccessPolicyListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyListSettings ResetQuery(this AzureIotDpsAccessPolicyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureIotDpsAccessPolicyListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyListSettings SetVerbose(this AzureIotDpsAccessPolicyListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsAccessPolicyListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyListSettings ResetVerbose(this AzureIotDpsAccessPolicyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureIotDpsAccessPolicyShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIotDpsAccessPolicyShowSettingsExtensions
    {
        #region AccessPolicyName
        /// <summary><p><em>Sets <see cref="AzureIotDpsAccessPolicyShowSettings.AccessPolicyName"/>.</em></p><p>A friendly name for DPS access policy.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyShowSettings SetAccessPolicyName(this AzureIotDpsAccessPolicyShowSettings toolSettings, string accessPolicyName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccessPolicyName = accessPolicyName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsAccessPolicyShowSettings.AccessPolicyName"/>.</em></p><p>A friendly name for DPS access policy.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyShowSettings ResetAccessPolicyName(this AzureIotDpsAccessPolicyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccessPolicyName = null;
            return toolSettings;
        }
        #endregion
        #region DpsName
        /// <summary><p><em>Sets <see cref="AzureIotDpsAccessPolicyShowSettings.DpsName"/>.</em></p><p>IoT Provisioning Service name.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyShowSettings SetDpsName(this AzureIotDpsAccessPolicyShowSettings toolSettings, string dpsName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DpsName = dpsName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsAccessPolicyShowSettings.DpsName"/>.</em></p><p>IoT Provisioning Service name.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyShowSettings ResetDpsName(this AzureIotDpsAccessPolicyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DpsName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureIotDpsAccessPolicyShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyShowSettings SetResourceGroup(this AzureIotDpsAccessPolicyShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsAccessPolicyShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyShowSettings ResetResourceGroup(this AzureIotDpsAccessPolicyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureIotDpsAccessPolicyShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyShowSettings SetDebug(this AzureIotDpsAccessPolicyShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsAccessPolicyShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyShowSettings ResetDebug(this AzureIotDpsAccessPolicyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureIotDpsAccessPolicyShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyShowSettings SetHelp(this AzureIotDpsAccessPolicyShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsAccessPolicyShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyShowSettings ResetHelp(this AzureIotDpsAccessPolicyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureIotDpsAccessPolicyShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyShowSettings SetOutput(this AzureIotDpsAccessPolicyShowSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsAccessPolicyShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyShowSettings ResetOutput(this AzureIotDpsAccessPolicyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureIotDpsAccessPolicyShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyShowSettings SetQuery(this AzureIotDpsAccessPolicyShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsAccessPolicyShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyShowSettings ResetQuery(this AzureIotDpsAccessPolicyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureIotDpsAccessPolicyShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyShowSettings SetVerbose(this AzureIotDpsAccessPolicyShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsAccessPolicyShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyShowSettings ResetVerbose(this AzureIotDpsAccessPolicyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureIotDpsAccessPolicyUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIotDpsAccessPolicyUpdateSettingsExtensions
    {
        #region AccessPolicyName
        /// <summary><p><em>Sets <see cref="AzureIotDpsAccessPolicyUpdateSettings.AccessPolicyName"/>.</em></p><p>A friendly name for DPS access policy.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyUpdateSettings SetAccessPolicyName(this AzureIotDpsAccessPolicyUpdateSettings toolSettings, string accessPolicyName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccessPolicyName = accessPolicyName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsAccessPolicyUpdateSettings.AccessPolicyName"/>.</em></p><p>A friendly name for DPS access policy.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyUpdateSettings ResetAccessPolicyName(this AzureIotDpsAccessPolicyUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccessPolicyName = null;
            return toolSettings;
        }
        #endregion
        #region DpsName
        /// <summary><p><em>Sets <see cref="AzureIotDpsAccessPolicyUpdateSettings.DpsName"/>.</em></p><p>IoT Provisioning Service name.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyUpdateSettings SetDpsName(this AzureIotDpsAccessPolicyUpdateSettings toolSettings, string dpsName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DpsName = dpsName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsAccessPolicyUpdateSettings.DpsName"/>.</em></p><p>IoT Provisioning Service name.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyUpdateSettings ResetDpsName(this AzureIotDpsAccessPolicyUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DpsName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureIotDpsAccessPolicyUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyUpdateSettings SetResourceGroup(this AzureIotDpsAccessPolicyUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsAccessPolicyUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyUpdateSettings ResetResourceGroup(this AzureIotDpsAccessPolicyUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary><p><em>Sets <see cref="AzureIotDpsAccessPolicyUpdateSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyUpdateSettings SetNoWait(this AzureIotDpsAccessPolicyUpdateSettings toolSettings, string noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsAccessPolicyUpdateSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyUpdateSettings ResetNoWait(this AzureIotDpsAccessPolicyUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        #endregion
        #region PrimaryKey
        /// <summary><p><em>Sets <see cref="AzureIotDpsAccessPolicyUpdateSettings.PrimaryKey"/>.</em></p><p>Primary SAS key value.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyUpdateSettings SetPrimaryKey(this AzureIotDpsAccessPolicyUpdateSettings toolSettings, string primaryKey)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PrimaryKey = primaryKey;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsAccessPolicyUpdateSettings.PrimaryKey"/>.</em></p><p>Primary SAS key value.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyUpdateSettings ResetPrimaryKey(this AzureIotDpsAccessPolicyUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PrimaryKey = null;
            return toolSettings;
        }
        #endregion
        #region Rights
        /// <summary><p><em>Sets <see cref="AzureIotDpsAccessPolicyUpdateSettings.Rights"/>.</em></p><p>Access rights for the IoT provisioning service. Use space-separated list for multiple rights.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyUpdateSettings SetRights(this AzureIotDpsAccessPolicyUpdateSettings toolSettings, IotDpsAccessPolicyRights rights)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Rights = rights;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsAccessPolicyUpdateSettings.Rights"/>.</em></p><p>Access rights for the IoT provisioning service. Use space-separated list for multiple rights.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyUpdateSettings ResetRights(this AzureIotDpsAccessPolicyUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Rights = null;
            return toolSettings;
        }
        #endregion
        #region SecondaryKey
        /// <summary><p><em>Sets <see cref="AzureIotDpsAccessPolicyUpdateSettings.SecondaryKey"/>.</em></p><p>Secondary SAS key value.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyUpdateSettings SetSecondaryKey(this AzureIotDpsAccessPolicyUpdateSettings toolSettings, string secondaryKey)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SecondaryKey = secondaryKey;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsAccessPolicyUpdateSettings.SecondaryKey"/>.</em></p><p>Secondary SAS key value.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyUpdateSettings ResetSecondaryKey(this AzureIotDpsAccessPolicyUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SecondaryKey = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureIotDpsAccessPolicyUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyUpdateSettings SetDebug(this AzureIotDpsAccessPolicyUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsAccessPolicyUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyUpdateSettings ResetDebug(this AzureIotDpsAccessPolicyUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureIotDpsAccessPolicyUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyUpdateSettings SetHelp(this AzureIotDpsAccessPolicyUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsAccessPolicyUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyUpdateSettings ResetHelp(this AzureIotDpsAccessPolicyUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureIotDpsAccessPolicyUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyUpdateSettings SetOutput(this AzureIotDpsAccessPolicyUpdateSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsAccessPolicyUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyUpdateSettings ResetOutput(this AzureIotDpsAccessPolicyUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureIotDpsAccessPolicyUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyUpdateSettings SetQuery(this AzureIotDpsAccessPolicyUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsAccessPolicyUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyUpdateSettings ResetQuery(this AzureIotDpsAccessPolicyUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureIotDpsAccessPolicyUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyUpdateSettings SetVerbose(this AzureIotDpsAccessPolicyUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsAccessPolicyUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyUpdateSettings ResetVerbose(this AzureIotDpsAccessPolicyUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureIotDpsCertificateCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIotDpsCertificateCreateSettingsExtensions
    {
        #region CertificateName
        /// <summary><p><em>Sets <see cref="AzureIotDpsCertificateCreateSettings.CertificateName"/>.</em></p><p>A friendly name for the certificate.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateCreateSettings SetCertificateName(this AzureIotDpsCertificateCreateSettings toolSettings, string certificateName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertificateName = certificateName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCertificateCreateSettings.CertificateName"/>.</em></p><p>A friendly name for the certificate.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateCreateSettings ResetCertificateName(this AzureIotDpsCertificateCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertificateName = null;
            return toolSettings;
        }
        #endregion
        #region DpsName
        /// <summary><p><em>Sets <see cref="AzureIotDpsCertificateCreateSettings.DpsName"/>.</em></p><p>IoT Provisioning Service name.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateCreateSettings SetDpsName(this AzureIotDpsCertificateCreateSettings toolSettings, string dpsName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DpsName = dpsName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCertificateCreateSettings.DpsName"/>.</em></p><p>IoT Provisioning Service name.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateCreateSettings ResetDpsName(this AzureIotDpsCertificateCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DpsName = null;
            return toolSettings;
        }
        #endregion
        #region Path
        /// <summary><p><em>Sets <see cref="AzureIotDpsCertificateCreateSettings.Path"/>.</em></p><p>The path to the file containing the certificate.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateCreateSettings SetPath(this AzureIotDpsCertificateCreateSettings toolSettings, string path)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = path;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCertificateCreateSettings.Path"/>.</em></p><p>The path to the file containing the certificate.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateCreateSettings ResetPath(this AzureIotDpsCertificateCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureIotDpsCertificateCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateCreateSettings SetResourceGroup(this AzureIotDpsCertificateCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCertificateCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateCreateSettings ResetResourceGroup(this AzureIotDpsCertificateCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureIotDpsCertificateCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateCreateSettings SetDebug(this AzureIotDpsCertificateCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCertificateCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateCreateSettings ResetDebug(this AzureIotDpsCertificateCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureIotDpsCertificateCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateCreateSettings SetHelp(this AzureIotDpsCertificateCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCertificateCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateCreateSettings ResetHelp(this AzureIotDpsCertificateCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureIotDpsCertificateCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateCreateSettings SetOutput(this AzureIotDpsCertificateCreateSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCertificateCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateCreateSettings ResetOutput(this AzureIotDpsCertificateCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureIotDpsCertificateCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateCreateSettings SetQuery(this AzureIotDpsCertificateCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCertificateCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateCreateSettings ResetQuery(this AzureIotDpsCertificateCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureIotDpsCertificateCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateCreateSettings SetVerbose(this AzureIotDpsCertificateCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCertificateCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateCreateSettings ResetVerbose(this AzureIotDpsCertificateCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureIotDpsCertificateDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIotDpsCertificateDeleteSettingsExtensions
    {
        #region CertificateName
        /// <summary><p><em>Sets <see cref="AzureIotDpsCertificateDeleteSettings.CertificateName"/>.</em></p><p>A friendly name for the certificate.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateDeleteSettings SetCertificateName(this AzureIotDpsCertificateDeleteSettings toolSettings, string certificateName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertificateName = certificateName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCertificateDeleteSettings.CertificateName"/>.</em></p><p>A friendly name for the certificate.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateDeleteSettings ResetCertificateName(this AzureIotDpsCertificateDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertificateName = null;
            return toolSettings;
        }
        #endregion
        #region DpsName
        /// <summary><p><em>Sets <see cref="AzureIotDpsCertificateDeleteSettings.DpsName"/>.</em></p><p>IoT Provisioning Service name.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateDeleteSettings SetDpsName(this AzureIotDpsCertificateDeleteSettings toolSettings, string dpsName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DpsName = dpsName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCertificateDeleteSettings.DpsName"/>.</em></p><p>IoT Provisioning Service name.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateDeleteSettings ResetDpsName(this AzureIotDpsCertificateDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DpsName = null;
            return toolSettings;
        }
        #endregion
        #region Etag
        /// <summary><p><em>Sets <see cref="AzureIotDpsCertificateDeleteSettings.Etag"/>.</em></p><p>Entity Tag (etag) of the object.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateDeleteSettings SetEtag(this AzureIotDpsCertificateDeleteSettings toolSettings, string etag)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Etag = etag;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCertificateDeleteSettings.Etag"/>.</em></p><p>Entity Tag (etag) of the object.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateDeleteSettings ResetEtag(this AzureIotDpsCertificateDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Etag = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureIotDpsCertificateDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateDeleteSettings SetResourceGroup(this AzureIotDpsCertificateDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCertificateDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateDeleteSettings ResetResourceGroup(this AzureIotDpsCertificateDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureIotDpsCertificateDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateDeleteSettings SetDebug(this AzureIotDpsCertificateDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCertificateDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateDeleteSettings ResetDebug(this AzureIotDpsCertificateDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureIotDpsCertificateDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateDeleteSettings SetHelp(this AzureIotDpsCertificateDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCertificateDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateDeleteSettings ResetHelp(this AzureIotDpsCertificateDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureIotDpsCertificateDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateDeleteSettings SetOutput(this AzureIotDpsCertificateDeleteSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCertificateDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateDeleteSettings ResetOutput(this AzureIotDpsCertificateDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureIotDpsCertificateDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateDeleteSettings SetQuery(this AzureIotDpsCertificateDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCertificateDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateDeleteSettings ResetQuery(this AzureIotDpsCertificateDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureIotDpsCertificateDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateDeleteSettings SetVerbose(this AzureIotDpsCertificateDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCertificateDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateDeleteSettings ResetVerbose(this AzureIotDpsCertificateDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureIotDpsCertificateGenerateVerificationCodeSettingsExtensions
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIotDpsCertificateGenerateVerificationCodeSettingsExtensions
    {
        #region CertificateName
        /// <summary><p><em>Sets <see cref="AzureIotDpsCertificateGenerateVerificationCodeSettings.CertificateName"/>.</em></p><p>A friendly name for the certificate.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateGenerateVerificationCodeSettings SetCertificateName(this AzureIotDpsCertificateGenerateVerificationCodeSettings toolSettings, string certificateName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertificateName = certificateName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCertificateGenerateVerificationCodeSettings.CertificateName"/>.</em></p><p>A friendly name for the certificate.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateGenerateVerificationCodeSettings ResetCertificateName(this AzureIotDpsCertificateGenerateVerificationCodeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertificateName = null;
            return toolSettings;
        }
        #endregion
        #region DpsName
        /// <summary><p><em>Sets <see cref="AzureIotDpsCertificateGenerateVerificationCodeSettings.DpsName"/>.</em></p><p>IoT Provisioning Service name.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateGenerateVerificationCodeSettings SetDpsName(this AzureIotDpsCertificateGenerateVerificationCodeSettings toolSettings, string dpsName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DpsName = dpsName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCertificateGenerateVerificationCodeSettings.DpsName"/>.</em></p><p>IoT Provisioning Service name.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateGenerateVerificationCodeSettings ResetDpsName(this AzureIotDpsCertificateGenerateVerificationCodeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DpsName = null;
            return toolSettings;
        }
        #endregion
        #region Etag
        /// <summary><p><em>Sets <see cref="AzureIotDpsCertificateGenerateVerificationCodeSettings.Etag"/>.</em></p><p>Entity Tag (etag) of the object.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateGenerateVerificationCodeSettings SetEtag(this AzureIotDpsCertificateGenerateVerificationCodeSettings toolSettings, string etag)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Etag = etag;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCertificateGenerateVerificationCodeSettings.Etag"/>.</em></p><p>Entity Tag (etag) of the object.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateGenerateVerificationCodeSettings ResetEtag(this AzureIotDpsCertificateGenerateVerificationCodeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Etag = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureIotDpsCertificateGenerateVerificationCodeSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateGenerateVerificationCodeSettings SetResourceGroup(this AzureIotDpsCertificateGenerateVerificationCodeSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCertificateGenerateVerificationCodeSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateGenerateVerificationCodeSettings ResetResourceGroup(this AzureIotDpsCertificateGenerateVerificationCodeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureIotDpsCertificateGenerateVerificationCodeSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateGenerateVerificationCodeSettings SetDebug(this AzureIotDpsCertificateGenerateVerificationCodeSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCertificateGenerateVerificationCodeSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateGenerateVerificationCodeSettings ResetDebug(this AzureIotDpsCertificateGenerateVerificationCodeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureIotDpsCertificateGenerateVerificationCodeSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateGenerateVerificationCodeSettings SetHelp(this AzureIotDpsCertificateGenerateVerificationCodeSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCertificateGenerateVerificationCodeSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateGenerateVerificationCodeSettings ResetHelp(this AzureIotDpsCertificateGenerateVerificationCodeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureIotDpsCertificateGenerateVerificationCodeSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateGenerateVerificationCodeSettings SetOutput(this AzureIotDpsCertificateGenerateVerificationCodeSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCertificateGenerateVerificationCodeSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateGenerateVerificationCodeSettings ResetOutput(this AzureIotDpsCertificateGenerateVerificationCodeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureIotDpsCertificateGenerateVerificationCodeSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateGenerateVerificationCodeSettings SetQuery(this AzureIotDpsCertificateGenerateVerificationCodeSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCertificateGenerateVerificationCodeSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateGenerateVerificationCodeSettings ResetQuery(this AzureIotDpsCertificateGenerateVerificationCodeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureIotDpsCertificateGenerateVerificationCodeSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateGenerateVerificationCodeSettings SetVerbose(this AzureIotDpsCertificateGenerateVerificationCodeSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCertificateGenerateVerificationCodeSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateGenerateVerificationCodeSettings ResetVerbose(this AzureIotDpsCertificateGenerateVerificationCodeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureIotDpsCertificateListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIotDpsCertificateListSettingsExtensions
    {
        #region DpsName
        /// <summary><p><em>Sets <see cref="AzureIotDpsCertificateListSettings.DpsName"/>.</em></p><p>IoT Provisioning Service name.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateListSettings SetDpsName(this AzureIotDpsCertificateListSettings toolSettings, string dpsName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DpsName = dpsName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCertificateListSettings.DpsName"/>.</em></p><p>IoT Provisioning Service name.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateListSettings ResetDpsName(this AzureIotDpsCertificateListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DpsName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureIotDpsCertificateListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateListSettings SetResourceGroup(this AzureIotDpsCertificateListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCertificateListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateListSettings ResetResourceGroup(this AzureIotDpsCertificateListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureIotDpsCertificateListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateListSettings SetDebug(this AzureIotDpsCertificateListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCertificateListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateListSettings ResetDebug(this AzureIotDpsCertificateListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureIotDpsCertificateListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateListSettings SetHelp(this AzureIotDpsCertificateListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCertificateListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateListSettings ResetHelp(this AzureIotDpsCertificateListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureIotDpsCertificateListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateListSettings SetOutput(this AzureIotDpsCertificateListSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCertificateListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateListSettings ResetOutput(this AzureIotDpsCertificateListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureIotDpsCertificateListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateListSettings SetQuery(this AzureIotDpsCertificateListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCertificateListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateListSettings ResetQuery(this AzureIotDpsCertificateListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureIotDpsCertificateListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateListSettings SetVerbose(this AzureIotDpsCertificateListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCertificateListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateListSettings ResetVerbose(this AzureIotDpsCertificateListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureIotDpsCertificateShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIotDpsCertificateShowSettingsExtensions
    {
        #region CertificateName
        /// <summary><p><em>Sets <see cref="AzureIotDpsCertificateShowSettings.CertificateName"/>.</em></p><p>A friendly name for the certificate.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateShowSettings SetCertificateName(this AzureIotDpsCertificateShowSettings toolSettings, string certificateName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertificateName = certificateName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCertificateShowSettings.CertificateName"/>.</em></p><p>A friendly name for the certificate.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateShowSettings ResetCertificateName(this AzureIotDpsCertificateShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertificateName = null;
            return toolSettings;
        }
        #endregion
        #region DpsName
        /// <summary><p><em>Sets <see cref="AzureIotDpsCertificateShowSettings.DpsName"/>.</em></p><p>IoT Provisioning Service name.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateShowSettings SetDpsName(this AzureIotDpsCertificateShowSettings toolSettings, string dpsName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DpsName = dpsName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCertificateShowSettings.DpsName"/>.</em></p><p>IoT Provisioning Service name.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateShowSettings ResetDpsName(this AzureIotDpsCertificateShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DpsName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureIotDpsCertificateShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateShowSettings SetResourceGroup(this AzureIotDpsCertificateShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCertificateShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateShowSettings ResetResourceGroup(this AzureIotDpsCertificateShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureIotDpsCertificateShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateShowSettings SetDebug(this AzureIotDpsCertificateShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCertificateShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateShowSettings ResetDebug(this AzureIotDpsCertificateShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureIotDpsCertificateShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateShowSettings SetHelp(this AzureIotDpsCertificateShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCertificateShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateShowSettings ResetHelp(this AzureIotDpsCertificateShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureIotDpsCertificateShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateShowSettings SetOutput(this AzureIotDpsCertificateShowSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCertificateShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateShowSettings ResetOutput(this AzureIotDpsCertificateShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureIotDpsCertificateShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateShowSettings SetQuery(this AzureIotDpsCertificateShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCertificateShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateShowSettings ResetQuery(this AzureIotDpsCertificateShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureIotDpsCertificateShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateShowSettings SetVerbose(this AzureIotDpsCertificateShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCertificateShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateShowSettings ResetVerbose(this AzureIotDpsCertificateShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureIotDpsCertificateUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIotDpsCertificateUpdateSettingsExtensions
    {
        #region CertificateName
        /// <summary><p><em>Sets <see cref="AzureIotDpsCertificateUpdateSettings.CertificateName"/>.</em></p><p>A friendly name for the certificate.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateUpdateSettings SetCertificateName(this AzureIotDpsCertificateUpdateSettings toolSettings, string certificateName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertificateName = certificateName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCertificateUpdateSettings.CertificateName"/>.</em></p><p>A friendly name for the certificate.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateUpdateSettings ResetCertificateName(this AzureIotDpsCertificateUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertificateName = null;
            return toolSettings;
        }
        #endregion
        #region DpsName
        /// <summary><p><em>Sets <see cref="AzureIotDpsCertificateUpdateSettings.DpsName"/>.</em></p><p>IoT Provisioning Service name.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateUpdateSettings SetDpsName(this AzureIotDpsCertificateUpdateSettings toolSettings, string dpsName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DpsName = dpsName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCertificateUpdateSettings.DpsName"/>.</em></p><p>IoT Provisioning Service name.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateUpdateSettings ResetDpsName(this AzureIotDpsCertificateUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DpsName = null;
            return toolSettings;
        }
        #endregion
        #region Etag
        /// <summary><p><em>Sets <see cref="AzureIotDpsCertificateUpdateSettings.Etag"/>.</em></p><p>Entity Tag (etag) of the object.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateUpdateSettings SetEtag(this AzureIotDpsCertificateUpdateSettings toolSettings, string etag)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Etag = etag;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCertificateUpdateSettings.Etag"/>.</em></p><p>Entity Tag (etag) of the object.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateUpdateSettings ResetEtag(this AzureIotDpsCertificateUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Etag = null;
            return toolSettings;
        }
        #endregion
        #region Path
        /// <summary><p><em>Sets <see cref="AzureIotDpsCertificateUpdateSettings.Path"/>.</em></p><p>The path to the file containing the certificate.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateUpdateSettings SetPath(this AzureIotDpsCertificateUpdateSettings toolSettings, string path)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = path;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCertificateUpdateSettings.Path"/>.</em></p><p>The path to the file containing the certificate.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateUpdateSettings ResetPath(this AzureIotDpsCertificateUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureIotDpsCertificateUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateUpdateSettings SetResourceGroup(this AzureIotDpsCertificateUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCertificateUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateUpdateSettings ResetResourceGroup(this AzureIotDpsCertificateUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureIotDpsCertificateUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateUpdateSettings SetDebug(this AzureIotDpsCertificateUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCertificateUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateUpdateSettings ResetDebug(this AzureIotDpsCertificateUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureIotDpsCertificateUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateUpdateSettings SetHelp(this AzureIotDpsCertificateUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCertificateUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateUpdateSettings ResetHelp(this AzureIotDpsCertificateUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureIotDpsCertificateUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateUpdateSettings SetOutput(this AzureIotDpsCertificateUpdateSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCertificateUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateUpdateSettings ResetOutput(this AzureIotDpsCertificateUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureIotDpsCertificateUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateUpdateSettings SetQuery(this AzureIotDpsCertificateUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCertificateUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateUpdateSettings ResetQuery(this AzureIotDpsCertificateUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureIotDpsCertificateUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateUpdateSettings SetVerbose(this AzureIotDpsCertificateUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCertificateUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateUpdateSettings ResetVerbose(this AzureIotDpsCertificateUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureIotDpsCertificateVerifySettingsExtensions
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIotDpsCertificateVerifySettingsExtensions
    {
        #region CertificateName
        /// <summary><p><em>Sets <see cref="AzureIotDpsCertificateVerifySettings.CertificateName"/>.</em></p><p>A friendly name for the certificate.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateVerifySettings SetCertificateName(this AzureIotDpsCertificateVerifySettings toolSettings, string certificateName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertificateName = certificateName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCertificateVerifySettings.CertificateName"/>.</em></p><p>A friendly name for the certificate.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateVerifySettings ResetCertificateName(this AzureIotDpsCertificateVerifySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertificateName = null;
            return toolSettings;
        }
        #endregion
        #region DpsName
        /// <summary><p><em>Sets <see cref="AzureIotDpsCertificateVerifySettings.DpsName"/>.</em></p><p>IoT Provisioning Service name.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateVerifySettings SetDpsName(this AzureIotDpsCertificateVerifySettings toolSettings, string dpsName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DpsName = dpsName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCertificateVerifySettings.DpsName"/>.</em></p><p>IoT Provisioning Service name.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateVerifySettings ResetDpsName(this AzureIotDpsCertificateVerifySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DpsName = null;
            return toolSettings;
        }
        #endregion
        #region Etag
        /// <summary><p><em>Sets <see cref="AzureIotDpsCertificateVerifySettings.Etag"/>.</em></p><p>Entity Tag (etag) of the object.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateVerifySettings SetEtag(this AzureIotDpsCertificateVerifySettings toolSettings, string etag)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Etag = etag;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCertificateVerifySettings.Etag"/>.</em></p><p>Entity Tag (etag) of the object.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateVerifySettings ResetEtag(this AzureIotDpsCertificateVerifySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Etag = null;
            return toolSettings;
        }
        #endregion
        #region Path
        /// <summary><p><em>Sets <see cref="AzureIotDpsCertificateVerifySettings.Path"/>.</em></p><p>The path to the file containing the certificate.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateVerifySettings SetPath(this AzureIotDpsCertificateVerifySettings toolSettings, string path)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = path;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCertificateVerifySettings.Path"/>.</em></p><p>The path to the file containing the certificate.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateVerifySettings ResetPath(this AzureIotDpsCertificateVerifySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureIotDpsCertificateVerifySettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateVerifySettings SetResourceGroup(this AzureIotDpsCertificateVerifySettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCertificateVerifySettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateVerifySettings ResetResourceGroup(this AzureIotDpsCertificateVerifySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureIotDpsCertificateVerifySettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateVerifySettings SetDebug(this AzureIotDpsCertificateVerifySettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCertificateVerifySettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateVerifySettings ResetDebug(this AzureIotDpsCertificateVerifySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureIotDpsCertificateVerifySettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateVerifySettings SetHelp(this AzureIotDpsCertificateVerifySettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCertificateVerifySettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateVerifySettings ResetHelp(this AzureIotDpsCertificateVerifySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureIotDpsCertificateVerifySettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateVerifySettings SetOutput(this AzureIotDpsCertificateVerifySettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCertificateVerifySettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateVerifySettings ResetOutput(this AzureIotDpsCertificateVerifySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureIotDpsCertificateVerifySettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateVerifySettings SetQuery(this AzureIotDpsCertificateVerifySettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCertificateVerifySettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateVerifySettings ResetQuery(this AzureIotDpsCertificateVerifySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureIotDpsCertificateVerifySettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateVerifySettings SetVerbose(this AzureIotDpsCertificateVerifySettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCertificateVerifySettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateVerifySettings ResetVerbose(this AzureIotDpsCertificateVerifySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureIotDpsLinkedHubCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIotDpsLinkedHubCreateSettingsExtensions
    {
        #region ConnectionString
        /// <summary><p><em>Sets <see cref="AzureIotDpsLinkedHubCreateSettings.ConnectionString"/>.</em></p><p>Connection string of the IoT hub.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubCreateSettings SetConnectionString(this AzureIotDpsLinkedHubCreateSettings toolSettings, string connectionString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ConnectionString = connectionString;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsLinkedHubCreateSettings.ConnectionString"/>.</em></p><p>Connection string of the IoT hub.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubCreateSettings ResetConnectionString(this AzureIotDpsLinkedHubCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ConnectionString = null;
            return toolSettings;
        }
        #endregion
        #region DpsName
        /// <summary><p><em>Sets <see cref="AzureIotDpsLinkedHubCreateSettings.DpsName"/>.</em></p><p>IoT Provisioning Service name.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubCreateSettings SetDpsName(this AzureIotDpsLinkedHubCreateSettings toolSettings, string dpsName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DpsName = dpsName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsLinkedHubCreateSettings.DpsName"/>.</em></p><p>IoT Provisioning Service name.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubCreateSettings ResetDpsName(this AzureIotDpsLinkedHubCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DpsName = null;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary><p><em>Sets <see cref="AzureIotDpsLinkedHubCreateSettings.Location"/>.</em></p><p>Location of the IoT hub.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubCreateSettings SetLocation(this AzureIotDpsLinkedHubCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsLinkedHubCreateSettings.Location"/>.</em></p><p>Location of the IoT hub.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubCreateSettings ResetLocation(this AzureIotDpsLinkedHubCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureIotDpsLinkedHubCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubCreateSettings SetResourceGroup(this AzureIotDpsLinkedHubCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsLinkedHubCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubCreateSettings ResetResourceGroup(this AzureIotDpsLinkedHubCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region AllocationWeight
        /// <summary><p><em>Sets <see cref="AzureIotDpsLinkedHubCreateSettings.AllocationWeight"/>.</em></p><p>Allocation weight of the IoT hub.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubCreateSettings SetAllocationWeight(this AzureIotDpsLinkedHubCreateSettings toolSettings, string allocationWeight)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AllocationWeight = allocationWeight;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsLinkedHubCreateSettings.AllocationWeight"/>.</em></p><p>Allocation weight of the IoT hub.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubCreateSettings ResetAllocationWeight(this AzureIotDpsLinkedHubCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AllocationWeight = null;
            return toolSettings;
        }
        #endregion
        #region ApplyAllocationPolicy
        /// <summary><p><em>Sets <see cref="AzureIotDpsLinkedHubCreateSettings.ApplyAllocationPolicy"/>.</em></p><p>A boolean indicating whether to apply allocation policy to the IoT hub.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubCreateSettings SetApplyAllocationPolicy(this AzureIotDpsLinkedHubCreateSettings toolSettings, bool? applyAllocationPolicy)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ApplyAllocationPolicy = applyAllocationPolicy;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsLinkedHubCreateSettings.ApplyAllocationPolicy"/>.</em></p><p>A boolean indicating whether to apply allocation policy to the IoT hub.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubCreateSettings ResetApplyAllocationPolicy(this AzureIotDpsLinkedHubCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ApplyAllocationPolicy = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureIotDpsLinkedHubCreateSettings.ApplyAllocationPolicy"/>.</em></p><p>A boolean indicating whether to apply allocation policy to the IoT hub.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubCreateSettings EnableApplyAllocationPolicy(this AzureIotDpsLinkedHubCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ApplyAllocationPolicy = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureIotDpsLinkedHubCreateSettings.ApplyAllocationPolicy"/>.</em></p><p>A boolean indicating whether to apply allocation policy to the IoT hub.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubCreateSettings DisableApplyAllocationPolicy(this AzureIotDpsLinkedHubCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ApplyAllocationPolicy = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureIotDpsLinkedHubCreateSettings.ApplyAllocationPolicy"/>.</em></p><p>A boolean indicating whether to apply allocation policy to the IoT hub.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubCreateSettings ToggleApplyAllocationPolicy(this AzureIotDpsLinkedHubCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ApplyAllocationPolicy = !toolSettings.ApplyAllocationPolicy;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary><p><em>Sets <see cref="AzureIotDpsLinkedHubCreateSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubCreateSettings SetNoWait(this AzureIotDpsLinkedHubCreateSettings toolSettings, string noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsLinkedHubCreateSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubCreateSettings ResetNoWait(this AzureIotDpsLinkedHubCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureIotDpsLinkedHubCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubCreateSettings SetDebug(this AzureIotDpsLinkedHubCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsLinkedHubCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubCreateSettings ResetDebug(this AzureIotDpsLinkedHubCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureIotDpsLinkedHubCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubCreateSettings SetHelp(this AzureIotDpsLinkedHubCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsLinkedHubCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubCreateSettings ResetHelp(this AzureIotDpsLinkedHubCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureIotDpsLinkedHubCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubCreateSettings SetOutput(this AzureIotDpsLinkedHubCreateSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsLinkedHubCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubCreateSettings ResetOutput(this AzureIotDpsLinkedHubCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureIotDpsLinkedHubCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubCreateSettings SetQuery(this AzureIotDpsLinkedHubCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsLinkedHubCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubCreateSettings ResetQuery(this AzureIotDpsLinkedHubCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureIotDpsLinkedHubCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubCreateSettings SetVerbose(this AzureIotDpsLinkedHubCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsLinkedHubCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubCreateSettings ResetVerbose(this AzureIotDpsLinkedHubCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureIotDpsLinkedHubDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIotDpsLinkedHubDeleteSettingsExtensions
    {
        #region DpsName
        /// <summary><p><em>Sets <see cref="AzureIotDpsLinkedHubDeleteSettings.DpsName"/>.</em></p><p>IoT Provisioning Service name.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubDeleteSettings SetDpsName(this AzureIotDpsLinkedHubDeleteSettings toolSettings, string dpsName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DpsName = dpsName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsLinkedHubDeleteSettings.DpsName"/>.</em></p><p>IoT Provisioning Service name.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubDeleteSettings ResetDpsName(this AzureIotDpsLinkedHubDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DpsName = null;
            return toolSettings;
        }
        #endregion
        #region LinkedHub
        /// <summary><p><em>Sets <see cref="AzureIotDpsLinkedHubDeleteSettings.LinkedHub"/>.</em></p><p>Host name of linked IoT Hub.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubDeleteSettings SetLinkedHub(this AzureIotDpsLinkedHubDeleteSettings toolSettings, string linkedHub)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LinkedHub = linkedHub;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsLinkedHubDeleteSettings.LinkedHub"/>.</em></p><p>Host name of linked IoT Hub.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubDeleteSettings ResetLinkedHub(this AzureIotDpsLinkedHubDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LinkedHub = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureIotDpsLinkedHubDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubDeleteSettings SetResourceGroup(this AzureIotDpsLinkedHubDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsLinkedHubDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubDeleteSettings ResetResourceGroup(this AzureIotDpsLinkedHubDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary><p><em>Sets <see cref="AzureIotDpsLinkedHubDeleteSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubDeleteSettings SetNoWait(this AzureIotDpsLinkedHubDeleteSettings toolSettings, string noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsLinkedHubDeleteSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubDeleteSettings ResetNoWait(this AzureIotDpsLinkedHubDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureIotDpsLinkedHubDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubDeleteSettings SetDebug(this AzureIotDpsLinkedHubDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsLinkedHubDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubDeleteSettings ResetDebug(this AzureIotDpsLinkedHubDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureIotDpsLinkedHubDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubDeleteSettings SetHelp(this AzureIotDpsLinkedHubDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsLinkedHubDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubDeleteSettings ResetHelp(this AzureIotDpsLinkedHubDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureIotDpsLinkedHubDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubDeleteSettings SetOutput(this AzureIotDpsLinkedHubDeleteSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsLinkedHubDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubDeleteSettings ResetOutput(this AzureIotDpsLinkedHubDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureIotDpsLinkedHubDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubDeleteSettings SetQuery(this AzureIotDpsLinkedHubDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsLinkedHubDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubDeleteSettings ResetQuery(this AzureIotDpsLinkedHubDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureIotDpsLinkedHubDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubDeleteSettings SetVerbose(this AzureIotDpsLinkedHubDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsLinkedHubDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubDeleteSettings ResetVerbose(this AzureIotDpsLinkedHubDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureIotDpsLinkedHubListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIotDpsLinkedHubListSettingsExtensions
    {
        #region DpsName
        /// <summary><p><em>Sets <see cref="AzureIotDpsLinkedHubListSettings.DpsName"/>.</em></p><p>IoT Provisioning Service name.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubListSettings SetDpsName(this AzureIotDpsLinkedHubListSettings toolSettings, string dpsName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DpsName = dpsName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsLinkedHubListSettings.DpsName"/>.</em></p><p>IoT Provisioning Service name.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubListSettings ResetDpsName(this AzureIotDpsLinkedHubListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DpsName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureIotDpsLinkedHubListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubListSettings SetResourceGroup(this AzureIotDpsLinkedHubListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsLinkedHubListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubListSettings ResetResourceGroup(this AzureIotDpsLinkedHubListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureIotDpsLinkedHubListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubListSettings SetDebug(this AzureIotDpsLinkedHubListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsLinkedHubListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubListSettings ResetDebug(this AzureIotDpsLinkedHubListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureIotDpsLinkedHubListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubListSettings SetHelp(this AzureIotDpsLinkedHubListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsLinkedHubListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubListSettings ResetHelp(this AzureIotDpsLinkedHubListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureIotDpsLinkedHubListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubListSettings SetOutput(this AzureIotDpsLinkedHubListSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsLinkedHubListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubListSettings ResetOutput(this AzureIotDpsLinkedHubListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureIotDpsLinkedHubListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubListSettings SetQuery(this AzureIotDpsLinkedHubListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsLinkedHubListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubListSettings ResetQuery(this AzureIotDpsLinkedHubListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureIotDpsLinkedHubListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubListSettings SetVerbose(this AzureIotDpsLinkedHubListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsLinkedHubListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubListSettings ResetVerbose(this AzureIotDpsLinkedHubListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureIotDpsLinkedHubShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIotDpsLinkedHubShowSettingsExtensions
    {
        #region DpsName
        /// <summary><p><em>Sets <see cref="AzureIotDpsLinkedHubShowSettings.DpsName"/>.</em></p><p>IoT Provisioning Service name.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubShowSettings SetDpsName(this AzureIotDpsLinkedHubShowSettings toolSettings, string dpsName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DpsName = dpsName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsLinkedHubShowSettings.DpsName"/>.</em></p><p>IoT Provisioning Service name.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubShowSettings ResetDpsName(this AzureIotDpsLinkedHubShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DpsName = null;
            return toolSettings;
        }
        #endregion
        #region LinkedHub
        /// <summary><p><em>Sets <see cref="AzureIotDpsLinkedHubShowSettings.LinkedHub"/>.</em></p><p>Host name of linked IoT Hub.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubShowSettings SetLinkedHub(this AzureIotDpsLinkedHubShowSettings toolSettings, string linkedHub)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LinkedHub = linkedHub;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsLinkedHubShowSettings.LinkedHub"/>.</em></p><p>Host name of linked IoT Hub.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubShowSettings ResetLinkedHub(this AzureIotDpsLinkedHubShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LinkedHub = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureIotDpsLinkedHubShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubShowSettings SetResourceGroup(this AzureIotDpsLinkedHubShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsLinkedHubShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubShowSettings ResetResourceGroup(this AzureIotDpsLinkedHubShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureIotDpsLinkedHubShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubShowSettings SetDebug(this AzureIotDpsLinkedHubShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsLinkedHubShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubShowSettings ResetDebug(this AzureIotDpsLinkedHubShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureIotDpsLinkedHubShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubShowSettings SetHelp(this AzureIotDpsLinkedHubShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsLinkedHubShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubShowSettings ResetHelp(this AzureIotDpsLinkedHubShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureIotDpsLinkedHubShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubShowSettings SetOutput(this AzureIotDpsLinkedHubShowSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsLinkedHubShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubShowSettings ResetOutput(this AzureIotDpsLinkedHubShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureIotDpsLinkedHubShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubShowSettings SetQuery(this AzureIotDpsLinkedHubShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsLinkedHubShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubShowSettings ResetQuery(this AzureIotDpsLinkedHubShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureIotDpsLinkedHubShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubShowSettings SetVerbose(this AzureIotDpsLinkedHubShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsLinkedHubShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubShowSettings ResetVerbose(this AzureIotDpsLinkedHubShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureIotDpsLinkedHubUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIotDpsLinkedHubUpdateSettingsExtensions
    {
        #region DpsName
        /// <summary><p><em>Sets <see cref="AzureIotDpsLinkedHubUpdateSettings.DpsName"/>.</em></p><p>IoT Provisioning Service name.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubUpdateSettings SetDpsName(this AzureIotDpsLinkedHubUpdateSettings toolSettings, string dpsName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DpsName = dpsName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsLinkedHubUpdateSettings.DpsName"/>.</em></p><p>IoT Provisioning Service name.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubUpdateSettings ResetDpsName(this AzureIotDpsLinkedHubUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DpsName = null;
            return toolSettings;
        }
        #endregion
        #region LinkedHub
        /// <summary><p><em>Sets <see cref="AzureIotDpsLinkedHubUpdateSettings.LinkedHub"/>.</em></p><p>Host name of linked IoT Hub.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubUpdateSettings SetLinkedHub(this AzureIotDpsLinkedHubUpdateSettings toolSettings, string linkedHub)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LinkedHub = linkedHub;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsLinkedHubUpdateSettings.LinkedHub"/>.</em></p><p>Host name of linked IoT Hub.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubUpdateSettings ResetLinkedHub(this AzureIotDpsLinkedHubUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LinkedHub = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureIotDpsLinkedHubUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubUpdateSettings SetResourceGroup(this AzureIotDpsLinkedHubUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsLinkedHubUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubUpdateSettings ResetResourceGroup(this AzureIotDpsLinkedHubUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region AllocationWeight
        /// <summary><p><em>Sets <see cref="AzureIotDpsLinkedHubUpdateSettings.AllocationWeight"/>.</em></p><p>Allocation weight of the IoT hub.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubUpdateSettings SetAllocationWeight(this AzureIotDpsLinkedHubUpdateSettings toolSettings, string allocationWeight)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AllocationWeight = allocationWeight;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsLinkedHubUpdateSettings.AllocationWeight"/>.</em></p><p>Allocation weight of the IoT hub.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubUpdateSettings ResetAllocationWeight(this AzureIotDpsLinkedHubUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AllocationWeight = null;
            return toolSettings;
        }
        #endregion
        #region ApplyAllocationPolicy
        /// <summary><p><em>Sets <see cref="AzureIotDpsLinkedHubUpdateSettings.ApplyAllocationPolicy"/>.</em></p><p>A boolean indicating whether to apply allocation policy to the Iot hub.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubUpdateSettings SetApplyAllocationPolicy(this AzureIotDpsLinkedHubUpdateSettings toolSettings, bool? applyAllocationPolicy)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ApplyAllocationPolicy = applyAllocationPolicy;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsLinkedHubUpdateSettings.ApplyAllocationPolicy"/>.</em></p><p>A boolean indicating whether to apply allocation policy to the Iot hub.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubUpdateSettings ResetApplyAllocationPolicy(this AzureIotDpsLinkedHubUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ApplyAllocationPolicy = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureIotDpsLinkedHubUpdateSettings.ApplyAllocationPolicy"/>.</em></p><p>A boolean indicating whether to apply allocation policy to the Iot hub.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubUpdateSettings EnableApplyAllocationPolicy(this AzureIotDpsLinkedHubUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ApplyAllocationPolicy = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureIotDpsLinkedHubUpdateSettings.ApplyAllocationPolicy"/>.</em></p><p>A boolean indicating whether to apply allocation policy to the Iot hub.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubUpdateSettings DisableApplyAllocationPolicy(this AzureIotDpsLinkedHubUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ApplyAllocationPolicy = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureIotDpsLinkedHubUpdateSettings.ApplyAllocationPolicy"/>.</em></p><p>A boolean indicating whether to apply allocation policy to the Iot hub.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubUpdateSettings ToggleApplyAllocationPolicy(this AzureIotDpsLinkedHubUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ApplyAllocationPolicy = !toolSettings.ApplyAllocationPolicy;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary><p><em>Sets <see cref="AzureIotDpsLinkedHubUpdateSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubUpdateSettings SetNoWait(this AzureIotDpsLinkedHubUpdateSettings toolSettings, string noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsLinkedHubUpdateSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubUpdateSettings ResetNoWait(this AzureIotDpsLinkedHubUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureIotDpsLinkedHubUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubUpdateSettings SetDebug(this AzureIotDpsLinkedHubUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsLinkedHubUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubUpdateSettings ResetDebug(this AzureIotDpsLinkedHubUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureIotDpsLinkedHubUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubUpdateSettings SetHelp(this AzureIotDpsLinkedHubUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsLinkedHubUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubUpdateSettings ResetHelp(this AzureIotDpsLinkedHubUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureIotDpsLinkedHubUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubUpdateSettings SetOutput(this AzureIotDpsLinkedHubUpdateSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsLinkedHubUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubUpdateSettings ResetOutput(this AzureIotDpsLinkedHubUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureIotDpsLinkedHubUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubUpdateSettings SetQuery(this AzureIotDpsLinkedHubUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsLinkedHubUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubUpdateSettings ResetQuery(this AzureIotDpsLinkedHubUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureIotDpsLinkedHubUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubUpdateSettings SetVerbose(this AzureIotDpsLinkedHubUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsLinkedHubUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubUpdateSettings ResetVerbose(this AzureIotDpsLinkedHubUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureIotHubCertificateCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIotHubCertificateCreateSettingsExtensions
    {
        #region HubName
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateCreateSettings.HubName"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotHubCertificateCreateSettings SetHubName(this AzureIotHubCertificateCreateSettings toolSettings, string hubName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HubName = hubName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCertificateCreateSettings.HubName"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotHubCertificateCreateSettings ResetHubName(this AzureIotHubCertificateCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HubName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateCreateSettings.Name"/>.</em></p><p>A friendly name for the certificate.</p></summary>
        [Pure]
        public static AzureIotHubCertificateCreateSettings SetName(this AzureIotHubCertificateCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCertificateCreateSettings.Name"/>.</em></p><p>A friendly name for the certificate.</p></summary>
        [Pure]
        public static AzureIotHubCertificateCreateSettings ResetName(this AzureIotHubCertificateCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Path
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateCreateSettings.Path"/>.</em></p><p>The path to the file containing the certificate.</p></summary>
        [Pure]
        public static AzureIotHubCertificateCreateSettings SetPath(this AzureIotHubCertificateCreateSettings toolSettings, string path)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = path;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCertificateCreateSettings.Path"/>.</em></p><p>The path to the file containing the certificate.</p></summary>
        [Pure]
        public static AzureIotHubCertificateCreateSettings ResetPath(this AzureIotHubCertificateCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotHubCertificateCreateSettings SetResourceGroup(this AzureIotHubCertificateCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCertificateCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotHubCertificateCreateSettings ResetResourceGroup(this AzureIotHubCertificateCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotHubCertificateCreateSettings SetDebug(this AzureIotHubCertificateCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCertificateCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotHubCertificateCreateSettings ResetDebug(this AzureIotHubCertificateCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotHubCertificateCreateSettings SetHelp(this AzureIotHubCertificateCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCertificateCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotHubCertificateCreateSettings ResetHelp(this AzureIotHubCertificateCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotHubCertificateCreateSettings SetOutput(this AzureIotHubCertificateCreateSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCertificateCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotHubCertificateCreateSettings ResetOutput(this AzureIotHubCertificateCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubCertificateCreateSettings SetQuery(this AzureIotHubCertificateCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCertificateCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubCertificateCreateSettings ResetQuery(this AzureIotHubCertificateCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotHubCertificateCreateSettings SetVerbose(this AzureIotHubCertificateCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCertificateCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotHubCertificateCreateSettings ResetVerbose(this AzureIotHubCertificateCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureIotHubCertificateDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIotHubCertificateDeleteSettingsExtensions
    {
        #region Etag
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateDeleteSettings.Etag"/>.</em></p><p>Entity Tag (etag) of the object.</p></summary>
        [Pure]
        public static AzureIotHubCertificateDeleteSettings SetEtag(this AzureIotHubCertificateDeleteSettings toolSettings, string etag)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Etag = etag;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCertificateDeleteSettings.Etag"/>.</em></p><p>Entity Tag (etag) of the object.</p></summary>
        [Pure]
        public static AzureIotHubCertificateDeleteSettings ResetEtag(this AzureIotHubCertificateDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Etag = null;
            return toolSettings;
        }
        #endregion
        #region HubName
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateDeleteSettings.HubName"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotHubCertificateDeleteSettings SetHubName(this AzureIotHubCertificateDeleteSettings toolSettings, string hubName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HubName = hubName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCertificateDeleteSettings.HubName"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotHubCertificateDeleteSettings ResetHubName(this AzureIotHubCertificateDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HubName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateDeleteSettings.Name"/>.</em></p><p>A friendly name for the certificate.</p></summary>
        [Pure]
        public static AzureIotHubCertificateDeleteSettings SetName(this AzureIotHubCertificateDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCertificateDeleteSettings.Name"/>.</em></p><p>A friendly name for the certificate.</p></summary>
        [Pure]
        public static AzureIotHubCertificateDeleteSettings ResetName(this AzureIotHubCertificateDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotHubCertificateDeleteSettings SetResourceGroup(this AzureIotHubCertificateDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCertificateDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotHubCertificateDeleteSettings ResetResourceGroup(this AzureIotHubCertificateDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotHubCertificateDeleteSettings SetDebug(this AzureIotHubCertificateDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCertificateDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotHubCertificateDeleteSettings ResetDebug(this AzureIotHubCertificateDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotHubCertificateDeleteSettings SetHelp(this AzureIotHubCertificateDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCertificateDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotHubCertificateDeleteSettings ResetHelp(this AzureIotHubCertificateDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotHubCertificateDeleteSettings SetOutput(this AzureIotHubCertificateDeleteSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCertificateDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotHubCertificateDeleteSettings ResetOutput(this AzureIotHubCertificateDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubCertificateDeleteSettings SetQuery(this AzureIotHubCertificateDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCertificateDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubCertificateDeleteSettings ResetQuery(this AzureIotHubCertificateDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotHubCertificateDeleteSettings SetVerbose(this AzureIotHubCertificateDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCertificateDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotHubCertificateDeleteSettings ResetVerbose(this AzureIotHubCertificateDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureIotHubCertificateGenerateVerificationCodeSettingsExtensions
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIotHubCertificateGenerateVerificationCodeSettingsExtensions
    {
        #region Etag
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateGenerateVerificationCodeSettings.Etag"/>.</em></p><p>Entity Tag (etag) of the object.</p></summary>
        [Pure]
        public static AzureIotHubCertificateGenerateVerificationCodeSettings SetEtag(this AzureIotHubCertificateGenerateVerificationCodeSettings toolSettings, string etag)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Etag = etag;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCertificateGenerateVerificationCodeSettings.Etag"/>.</em></p><p>Entity Tag (etag) of the object.</p></summary>
        [Pure]
        public static AzureIotHubCertificateGenerateVerificationCodeSettings ResetEtag(this AzureIotHubCertificateGenerateVerificationCodeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Etag = null;
            return toolSettings;
        }
        #endregion
        #region HubName
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateGenerateVerificationCodeSettings.HubName"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotHubCertificateGenerateVerificationCodeSettings SetHubName(this AzureIotHubCertificateGenerateVerificationCodeSettings toolSettings, string hubName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HubName = hubName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCertificateGenerateVerificationCodeSettings.HubName"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotHubCertificateGenerateVerificationCodeSettings ResetHubName(this AzureIotHubCertificateGenerateVerificationCodeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HubName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateGenerateVerificationCodeSettings.Name"/>.</em></p><p>A friendly name for the certificate.</p></summary>
        [Pure]
        public static AzureIotHubCertificateGenerateVerificationCodeSettings SetName(this AzureIotHubCertificateGenerateVerificationCodeSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCertificateGenerateVerificationCodeSettings.Name"/>.</em></p><p>A friendly name for the certificate.</p></summary>
        [Pure]
        public static AzureIotHubCertificateGenerateVerificationCodeSettings ResetName(this AzureIotHubCertificateGenerateVerificationCodeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateGenerateVerificationCodeSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotHubCertificateGenerateVerificationCodeSettings SetResourceGroup(this AzureIotHubCertificateGenerateVerificationCodeSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCertificateGenerateVerificationCodeSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotHubCertificateGenerateVerificationCodeSettings ResetResourceGroup(this AzureIotHubCertificateGenerateVerificationCodeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateGenerateVerificationCodeSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotHubCertificateGenerateVerificationCodeSettings SetDebug(this AzureIotHubCertificateGenerateVerificationCodeSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCertificateGenerateVerificationCodeSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotHubCertificateGenerateVerificationCodeSettings ResetDebug(this AzureIotHubCertificateGenerateVerificationCodeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateGenerateVerificationCodeSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotHubCertificateGenerateVerificationCodeSettings SetHelp(this AzureIotHubCertificateGenerateVerificationCodeSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCertificateGenerateVerificationCodeSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotHubCertificateGenerateVerificationCodeSettings ResetHelp(this AzureIotHubCertificateGenerateVerificationCodeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateGenerateVerificationCodeSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotHubCertificateGenerateVerificationCodeSettings SetOutput(this AzureIotHubCertificateGenerateVerificationCodeSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCertificateGenerateVerificationCodeSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotHubCertificateGenerateVerificationCodeSettings ResetOutput(this AzureIotHubCertificateGenerateVerificationCodeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateGenerateVerificationCodeSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubCertificateGenerateVerificationCodeSettings SetQuery(this AzureIotHubCertificateGenerateVerificationCodeSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCertificateGenerateVerificationCodeSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubCertificateGenerateVerificationCodeSettings ResetQuery(this AzureIotHubCertificateGenerateVerificationCodeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateGenerateVerificationCodeSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotHubCertificateGenerateVerificationCodeSettings SetVerbose(this AzureIotHubCertificateGenerateVerificationCodeSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCertificateGenerateVerificationCodeSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotHubCertificateGenerateVerificationCodeSettings ResetVerbose(this AzureIotHubCertificateGenerateVerificationCodeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureIotHubCertificateListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIotHubCertificateListSettingsExtensions
    {
        #region HubName
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateListSettings.HubName"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotHubCertificateListSettings SetHubName(this AzureIotHubCertificateListSettings toolSettings, string hubName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HubName = hubName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCertificateListSettings.HubName"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotHubCertificateListSettings ResetHubName(this AzureIotHubCertificateListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HubName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotHubCertificateListSettings SetResourceGroup(this AzureIotHubCertificateListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCertificateListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotHubCertificateListSettings ResetResourceGroup(this AzureIotHubCertificateListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotHubCertificateListSettings SetDebug(this AzureIotHubCertificateListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCertificateListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotHubCertificateListSettings ResetDebug(this AzureIotHubCertificateListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotHubCertificateListSettings SetHelp(this AzureIotHubCertificateListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCertificateListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotHubCertificateListSettings ResetHelp(this AzureIotHubCertificateListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotHubCertificateListSettings SetOutput(this AzureIotHubCertificateListSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCertificateListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotHubCertificateListSettings ResetOutput(this AzureIotHubCertificateListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubCertificateListSettings SetQuery(this AzureIotHubCertificateListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCertificateListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubCertificateListSettings ResetQuery(this AzureIotHubCertificateListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotHubCertificateListSettings SetVerbose(this AzureIotHubCertificateListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCertificateListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotHubCertificateListSettings ResetVerbose(this AzureIotHubCertificateListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureIotHubCertificateShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIotHubCertificateShowSettingsExtensions
    {
        #region HubName
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateShowSettings.HubName"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotHubCertificateShowSettings SetHubName(this AzureIotHubCertificateShowSettings toolSettings, string hubName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HubName = hubName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCertificateShowSettings.HubName"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotHubCertificateShowSettings ResetHubName(this AzureIotHubCertificateShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HubName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateShowSettings.Name"/>.</em></p><p>A friendly name for the certificate.</p></summary>
        [Pure]
        public static AzureIotHubCertificateShowSettings SetName(this AzureIotHubCertificateShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCertificateShowSettings.Name"/>.</em></p><p>A friendly name for the certificate.</p></summary>
        [Pure]
        public static AzureIotHubCertificateShowSettings ResetName(this AzureIotHubCertificateShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotHubCertificateShowSettings SetResourceGroup(this AzureIotHubCertificateShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCertificateShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotHubCertificateShowSettings ResetResourceGroup(this AzureIotHubCertificateShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotHubCertificateShowSettings SetDebug(this AzureIotHubCertificateShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCertificateShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotHubCertificateShowSettings ResetDebug(this AzureIotHubCertificateShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotHubCertificateShowSettings SetHelp(this AzureIotHubCertificateShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCertificateShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotHubCertificateShowSettings ResetHelp(this AzureIotHubCertificateShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotHubCertificateShowSettings SetOutput(this AzureIotHubCertificateShowSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCertificateShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotHubCertificateShowSettings ResetOutput(this AzureIotHubCertificateShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubCertificateShowSettings SetQuery(this AzureIotHubCertificateShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCertificateShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubCertificateShowSettings ResetQuery(this AzureIotHubCertificateShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotHubCertificateShowSettings SetVerbose(this AzureIotHubCertificateShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCertificateShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotHubCertificateShowSettings ResetVerbose(this AzureIotHubCertificateShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureIotHubCertificateUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIotHubCertificateUpdateSettingsExtensions
    {
        #region Etag
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateUpdateSettings.Etag"/>.</em></p><p>Entity Tag (etag) of the object.</p></summary>
        [Pure]
        public static AzureIotHubCertificateUpdateSettings SetEtag(this AzureIotHubCertificateUpdateSettings toolSettings, string etag)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Etag = etag;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCertificateUpdateSettings.Etag"/>.</em></p><p>Entity Tag (etag) of the object.</p></summary>
        [Pure]
        public static AzureIotHubCertificateUpdateSettings ResetEtag(this AzureIotHubCertificateUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Etag = null;
            return toolSettings;
        }
        #endregion
        #region HubName
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateUpdateSettings.HubName"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotHubCertificateUpdateSettings SetHubName(this AzureIotHubCertificateUpdateSettings toolSettings, string hubName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HubName = hubName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCertificateUpdateSettings.HubName"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotHubCertificateUpdateSettings ResetHubName(this AzureIotHubCertificateUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HubName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateUpdateSettings.Name"/>.</em></p><p>A friendly name for the certificate.</p></summary>
        [Pure]
        public static AzureIotHubCertificateUpdateSettings SetName(this AzureIotHubCertificateUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCertificateUpdateSettings.Name"/>.</em></p><p>A friendly name for the certificate.</p></summary>
        [Pure]
        public static AzureIotHubCertificateUpdateSettings ResetName(this AzureIotHubCertificateUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Path
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateUpdateSettings.Path"/>.</em></p><p>The path to the file containing the certificate.</p></summary>
        [Pure]
        public static AzureIotHubCertificateUpdateSettings SetPath(this AzureIotHubCertificateUpdateSettings toolSettings, string path)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = path;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCertificateUpdateSettings.Path"/>.</em></p><p>The path to the file containing the certificate.</p></summary>
        [Pure]
        public static AzureIotHubCertificateUpdateSettings ResetPath(this AzureIotHubCertificateUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotHubCertificateUpdateSettings SetResourceGroup(this AzureIotHubCertificateUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCertificateUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotHubCertificateUpdateSettings ResetResourceGroup(this AzureIotHubCertificateUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotHubCertificateUpdateSettings SetDebug(this AzureIotHubCertificateUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCertificateUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotHubCertificateUpdateSettings ResetDebug(this AzureIotHubCertificateUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotHubCertificateUpdateSettings SetHelp(this AzureIotHubCertificateUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCertificateUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotHubCertificateUpdateSettings ResetHelp(this AzureIotHubCertificateUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotHubCertificateUpdateSettings SetOutput(this AzureIotHubCertificateUpdateSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCertificateUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotHubCertificateUpdateSettings ResetOutput(this AzureIotHubCertificateUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubCertificateUpdateSettings SetQuery(this AzureIotHubCertificateUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCertificateUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubCertificateUpdateSettings ResetQuery(this AzureIotHubCertificateUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotHubCertificateUpdateSettings SetVerbose(this AzureIotHubCertificateUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCertificateUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotHubCertificateUpdateSettings ResetVerbose(this AzureIotHubCertificateUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureIotHubCertificateVerifySettingsExtensions
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIotHubCertificateVerifySettingsExtensions
    {
        #region Etag
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateVerifySettings.Etag"/>.</em></p><p>Entity Tag (etag) of the object.</p></summary>
        [Pure]
        public static AzureIotHubCertificateVerifySettings SetEtag(this AzureIotHubCertificateVerifySettings toolSettings, string etag)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Etag = etag;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCertificateVerifySettings.Etag"/>.</em></p><p>Entity Tag (etag) of the object.</p></summary>
        [Pure]
        public static AzureIotHubCertificateVerifySettings ResetEtag(this AzureIotHubCertificateVerifySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Etag = null;
            return toolSettings;
        }
        #endregion
        #region HubName
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateVerifySettings.HubName"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotHubCertificateVerifySettings SetHubName(this AzureIotHubCertificateVerifySettings toolSettings, string hubName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HubName = hubName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCertificateVerifySettings.HubName"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotHubCertificateVerifySettings ResetHubName(this AzureIotHubCertificateVerifySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HubName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateVerifySettings.Name"/>.</em></p><p>A friendly name for the certificate.</p></summary>
        [Pure]
        public static AzureIotHubCertificateVerifySettings SetName(this AzureIotHubCertificateVerifySettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCertificateVerifySettings.Name"/>.</em></p><p>A friendly name for the certificate.</p></summary>
        [Pure]
        public static AzureIotHubCertificateVerifySettings ResetName(this AzureIotHubCertificateVerifySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Path
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateVerifySettings.Path"/>.</em></p><p>The path to the file containing the certificate.</p></summary>
        [Pure]
        public static AzureIotHubCertificateVerifySettings SetPath(this AzureIotHubCertificateVerifySettings toolSettings, string path)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = path;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCertificateVerifySettings.Path"/>.</em></p><p>The path to the file containing the certificate.</p></summary>
        [Pure]
        public static AzureIotHubCertificateVerifySettings ResetPath(this AzureIotHubCertificateVerifySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateVerifySettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotHubCertificateVerifySettings SetResourceGroup(this AzureIotHubCertificateVerifySettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCertificateVerifySettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotHubCertificateVerifySettings ResetResourceGroup(this AzureIotHubCertificateVerifySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateVerifySettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotHubCertificateVerifySettings SetDebug(this AzureIotHubCertificateVerifySettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCertificateVerifySettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotHubCertificateVerifySettings ResetDebug(this AzureIotHubCertificateVerifySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateVerifySettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotHubCertificateVerifySettings SetHelp(this AzureIotHubCertificateVerifySettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCertificateVerifySettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotHubCertificateVerifySettings ResetHelp(this AzureIotHubCertificateVerifySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateVerifySettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotHubCertificateVerifySettings SetOutput(this AzureIotHubCertificateVerifySettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCertificateVerifySettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotHubCertificateVerifySettings ResetOutput(this AzureIotHubCertificateVerifySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateVerifySettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubCertificateVerifySettings SetQuery(this AzureIotHubCertificateVerifySettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCertificateVerifySettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubCertificateVerifySettings ResetQuery(this AzureIotHubCertificateVerifySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateVerifySettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotHubCertificateVerifySettings SetVerbose(this AzureIotHubCertificateVerifySettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCertificateVerifySettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotHubCertificateVerifySettings ResetVerbose(this AzureIotHubCertificateVerifySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureIotHubConsumerGroupCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIotHubConsumerGroupCreateSettingsExtensions
    {
        #region HubName
        /// <summary><p><em>Sets <see cref="AzureIotHubConsumerGroupCreateSettings.HubName"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupCreateSettings SetHubName(this AzureIotHubConsumerGroupCreateSettings toolSettings, string hubName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HubName = hubName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubConsumerGroupCreateSettings.HubName"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupCreateSettings ResetHubName(this AzureIotHubConsumerGroupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HubName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureIotHubConsumerGroupCreateSettings.Name"/>.</em></p><p>Event hub consumer group name.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupCreateSettings SetName(this AzureIotHubConsumerGroupCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubConsumerGroupCreateSettings.Name"/>.</em></p><p>Event hub consumer group name.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupCreateSettings ResetName(this AzureIotHubConsumerGroupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region EventHubName
        /// <summary><p><em>Sets <see cref="AzureIotHubConsumerGroupCreateSettings.EventHubName"/>.</em></p><p>Event hub endpoint name.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupCreateSettings SetEventHubName(this AzureIotHubConsumerGroupCreateSettings toolSettings, string eventHubName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EventHubName = eventHubName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubConsumerGroupCreateSettings.EventHubName"/>.</em></p><p>Event hub endpoint name.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupCreateSettings ResetEventHubName(this AzureIotHubConsumerGroupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EventHubName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureIotHubConsumerGroupCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupCreateSettings SetResourceGroup(this AzureIotHubConsumerGroupCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubConsumerGroupCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupCreateSettings ResetResourceGroup(this AzureIotHubConsumerGroupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureIotHubConsumerGroupCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupCreateSettings SetDebug(this AzureIotHubConsumerGroupCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubConsumerGroupCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupCreateSettings ResetDebug(this AzureIotHubConsumerGroupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureIotHubConsumerGroupCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupCreateSettings SetHelp(this AzureIotHubConsumerGroupCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubConsumerGroupCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupCreateSettings ResetHelp(this AzureIotHubConsumerGroupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureIotHubConsumerGroupCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupCreateSettings SetOutput(this AzureIotHubConsumerGroupCreateSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubConsumerGroupCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupCreateSettings ResetOutput(this AzureIotHubConsumerGroupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureIotHubConsumerGroupCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupCreateSettings SetQuery(this AzureIotHubConsumerGroupCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubConsumerGroupCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupCreateSettings ResetQuery(this AzureIotHubConsumerGroupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureIotHubConsumerGroupCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupCreateSettings SetVerbose(this AzureIotHubConsumerGroupCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubConsumerGroupCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupCreateSettings ResetVerbose(this AzureIotHubConsumerGroupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureIotHubConsumerGroupDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIotHubConsumerGroupDeleteSettingsExtensions
    {
        #region HubName
        /// <summary><p><em>Sets <see cref="AzureIotHubConsumerGroupDeleteSettings.HubName"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupDeleteSettings SetHubName(this AzureIotHubConsumerGroupDeleteSettings toolSettings, string hubName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HubName = hubName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubConsumerGroupDeleteSettings.HubName"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupDeleteSettings ResetHubName(this AzureIotHubConsumerGroupDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HubName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureIotHubConsumerGroupDeleteSettings.Name"/>.</em></p><p>Event hub consumer group name.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupDeleteSettings SetName(this AzureIotHubConsumerGroupDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubConsumerGroupDeleteSettings.Name"/>.</em></p><p>Event hub consumer group name.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupDeleteSettings ResetName(this AzureIotHubConsumerGroupDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region EventHubName
        /// <summary><p><em>Sets <see cref="AzureIotHubConsumerGroupDeleteSettings.EventHubName"/>.</em></p><p>Event hub endpoint name.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupDeleteSettings SetEventHubName(this AzureIotHubConsumerGroupDeleteSettings toolSettings, string eventHubName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EventHubName = eventHubName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubConsumerGroupDeleteSettings.EventHubName"/>.</em></p><p>Event hub endpoint name.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupDeleteSettings ResetEventHubName(this AzureIotHubConsumerGroupDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EventHubName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureIotHubConsumerGroupDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupDeleteSettings SetResourceGroup(this AzureIotHubConsumerGroupDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubConsumerGroupDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupDeleteSettings ResetResourceGroup(this AzureIotHubConsumerGroupDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureIotHubConsumerGroupDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupDeleteSettings SetDebug(this AzureIotHubConsumerGroupDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubConsumerGroupDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupDeleteSettings ResetDebug(this AzureIotHubConsumerGroupDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureIotHubConsumerGroupDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupDeleteSettings SetHelp(this AzureIotHubConsumerGroupDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubConsumerGroupDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupDeleteSettings ResetHelp(this AzureIotHubConsumerGroupDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureIotHubConsumerGroupDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupDeleteSettings SetOutput(this AzureIotHubConsumerGroupDeleteSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubConsumerGroupDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupDeleteSettings ResetOutput(this AzureIotHubConsumerGroupDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureIotHubConsumerGroupDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupDeleteSettings SetQuery(this AzureIotHubConsumerGroupDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubConsumerGroupDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupDeleteSettings ResetQuery(this AzureIotHubConsumerGroupDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureIotHubConsumerGroupDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupDeleteSettings SetVerbose(this AzureIotHubConsumerGroupDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubConsumerGroupDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupDeleteSettings ResetVerbose(this AzureIotHubConsumerGroupDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureIotHubConsumerGroupListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIotHubConsumerGroupListSettingsExtensions
    {
        #region HubName
        /// <summary><p><em>Sets <see cref="AzureIotHubConsumerGroupListSettings.HubName"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupListSettings SetHubName(this AzureIotHubConsumerGroupListSettings toolSettings, string hubName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HubName = hubName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubConsumerGroupListSettings.HubName"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupListSettings ResetHubName(this AzureIotHubConsumerGroupListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HubName = null;
            return toolSettings;
        }
        #endregion
        #region EventHubName
        /// <summary><p><em>Sets <see cref="AzureIotHubConsumerGroupListSettings.EventHubName"/>.</em></p><p>Event hub endpoint name.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupListSettings SetEventHubName(this AzureIotHubConsumerGroupListSettings toolSettings, string eventHubName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EventHubName = eventHubName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubConsumerGroupListSettings.EventHubName"/>.</em></p><p>Event hub endpoint name.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupListSettings ResetEventHubName(this AzureIotHubConsumerGroupListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EventHubName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureIotHubConsumerGroupListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupListSettings SetResourceGroup(this AzureIotHubConsumerGroupListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubConsumerGroupListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupListSettings ResetResourceGroup(this AzureIotHubConsumerGroupListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureIotHubConsumerGroupListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupListSettings SetDebug(this AzureIotHubConsumerGroupListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubConsumerGroupListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupListSettings ResetDebug(this AzureIotHubConsumerGroupListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureIotHubConsumerGroupListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupListSettings SetHelp(this AzureIotHubConsumerGroupListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubConsumerGroupListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupListSettings ResetHelp(this AzureIotHubConsumerGroupListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureIotHubConsumerGroupListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupListSettings SetOutput(this AzureIotHubConsumerGroupListSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubConsumerGroupListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupListSettings ResetOutput(this AzureIotHubConsumerGroupListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureIotHubConsumerGroupListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupListSettings SetQuery(this AzureIotHubConsumerGroupListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubConsumerGroupListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupListSettings ResetQuery(this AzureIotHubConsumerGroupListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureIotHubConsumerGroupListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupListSettings SetVerbose(this AzureIotHubConsumerGroupListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubConsumerGroupListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupListSettings ResetVerbose(this AzureIotHubConsumerGroupListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureIotHubConsumerGroupShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIotHubConsumerGroupShowSettingsExtensions
    {
        #region HubName
        /// <summary><p><em>Sets <see cref="AzureIotHubConsumerGroupShowSettings.HubName"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupShowSettings SetHubName(this AzureIotHubConsumerGroupShowSettings toolSettings, string hubName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HubName = hubName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubConsumerGroupShowSettings.HubName"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupShowSettings ResetHubName(this AzureIotHubConsumerGroupShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HubName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureIotHubConsumerGroupShowSettings.Name"/>.</em></p><p>Event hub consumer group name.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupShowSettings SetName(this AzureIotHubConsumerGroupShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubConsumerGroupShowSettings.Name"/>.</em></p><p>Event hub consumer group name.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupShowSettings ResetName(this AzureIotHubConsumerGroupShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region EventHubName
        /// <summary><p><em>Sets <see cref="AzureIotHubConsumerGroupShowSettings.EventHubName"/>.</em></p><p>Event hub endpoint name.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupShowSettings SetEventHubName(this AzureIotHubConsumerGroupShowSettings toolSettings, string eventHubName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EventHubName = eventHubName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubConsumerGroupShowSettings.EventHubName"/>.</em></p><p>Event hub endpoint name.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupShowSettings ResetEventHubName(this AzureIotHubConsumerGroupShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EventHubName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureIotHubConsumerGroupShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupShowSettings SetResourceGroup(this AzureIotHubConsumerGroupShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubConsumerGroupShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupShowSettings ResetResourceGroup(this AzureIotHubConsumerGroupShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureIotHubConsumerGroupShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupShowSettings SetDebug(this AzureIotHubConsumerGroupShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubConsumerGroupShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupShowSettings ResetDebug(this AzureIotHubConsumerGroupShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureIotHubConsumerGroupShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupShowSettings SetHelp(this AzureIotHubConsumerGroupShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubConsumerGroupShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupShowSettings ResetHelp(this AzureIotHubConsumerGroupShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureIotHubConsumerGroupShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupShowSettings SetOutput(this AzureIotHubConsumerGroupShowSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubConsumerGroupShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupShowSettings ResetOutput(this AzureIotHubConsumerGroupShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureIotHubConsumerGroupShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupShowSettings SetQuery(this AzureIotHubConsumerGroupShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubConsumerGroupShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupShowSettings ResetQuery(this AzureIotHubConsumerGroupShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureIotHubConsumerGroupShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupShowSettings SetVerbose(this AzureIotHubConsumerGroupShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubConsumerGroupShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupShowSettings ResetVerbose(this AzureIotHubConsumerGroupShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureIotHubJobCancelSettingsExtensions
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIotHubJobCancelSettingsExtensions
    {
        #region HubName
        /// <summary><p><em>Sets <see cref="AzureIotHubJobCancelSettings.HubName"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotHubJobCancelSettings SetHubName(this AzureIotHubJobCancelSettings toolSettings, string hubName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HubName = hubName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubJobCancelSettings.HubName"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotHubJobCancelSettings ResetHubName(this AzureIotHubJobCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HubName = null;
            return toolSettings;
        }
        #endregion
        #region JobId
        /// <summary><p><em>Sets <see cref="AzureIotHubJobCancelSettings.JobId"/>.</em></p><p>Job Id.</p></summary>
        [Pure]
        public static AzureIotHubJobCancelSettings SetJobId(this AzureIotHubJobCancelSettings toolSettings, string jobId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.JobId = jobId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubJobCancelSettings.JobId"/>.</em></p><p>Job Id.</p></summary>
        [Pure]
        public static AzureIotHubJobCancelSettings ResetJobId(this AzureIotHubJobCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.JobId = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureIotHubJobCancelSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotHubJobCancelSettings SetResourceGroup(this AzureIotHubJobCancelSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubJobCancelSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotHubJobCancelSettings ResetResourceGroup(this AzureIotHubJobCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureIotHubJobCancelSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotHubJobCancelSettings SetDebug(this AzureIotHubJobCancelSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubJobCancelSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotHubJobCancelSettings ResetDebug(this AzureIotHubJobCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureIotHubJobCancelSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotHubJobCancelSettings SetHelp(this AzureIotHubJobCancelSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubJobCancelSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotHubJobCancelSettings ResetHelp(this AzureIotHubJobCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureIotHubJobCancelSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotHubJobCancelSettings SetOutput(this AzureIotHubJobCancelSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubJobCancelSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotHubJobCancelSettings ResetOutput(this AzureIotHubJobCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureIotHubJobCancelSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubJobCancelSettings SetQuery(this AzureIotHubJobCancelSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubJobCancelSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubJobCancelSettings ResetQuery(this AzureIotHubJobCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureIotHubJobCancelSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotHubJobCancelSettings SetVerbose(this AzureIotHubJobCancelSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubJobCancelSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotHubJobCancelSettings ResetVerbose(this AzureIotHubJobCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureIotHubJobListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIotHubJobListSettingsExtensions
    {
        #region HubName
        /// <summary><p><em>Sets <see cref="AzureIotHubJobListSettings.HubName"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotHubJobListSettings SetHubName(this AzureIotHubJobListSettings toolSettings, string hubName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HubName = hubName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubJobListSettings.HubName"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotHubJobListSettings ResetHubName(this AzureIotHubJobListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HubName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureIotHubJobListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotHubJobListSettings SetResourceGroup(this AzureIotHubJobListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubJobListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotHubJobListSettings ResetResourceGroup(this AzureIotHubJobListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureIotHubJobListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotHubJobListSettings SetDebug(this AzureIotHubJobListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubJobListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotHubJobListSettings ResetDebug(this AzureIotHubJobListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureIotHubJobListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotHubJobListSettings SetHelp(this AzureIotHubJobListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubJobListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotHubJobListSettings ResetHelp(this AzureIotHubJobListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureIotHubJobListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotHubJobListSettings SetOutput(this AzureIotHubJobListSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubJobListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotHubJobListSettings ResetOutput(this AzureIotHubJobListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureIotHubJobListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubJobListSettings SetQuery(this AzureIotHubJobListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubJobListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubJobListSettings ResetQuery(this AzureIotHubJobListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureIotHubJobListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotHubJobListSettings SetVerbose(this AzureIotHubJobListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubJobListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotHubJobListSettings ResetVerbose(this AzureIotHubJobListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureIotHubJobShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIotHubJobShowSettingsExtensions
    {
        #region HubName
        /// <summary><p><em>Sets <see cref="AzureIotHubJobShowSettings.HubName"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotHubJobShowSettings SetHubName(this AzureIotHubJobShowSettings toolSettings, string hubName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HubName = hubName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubJobShowSettings.HubName"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotHubJobShowSettings ResetHubName(this AzureIotHubJobShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HubName = null;
            return toolSettings;
        }
        #endregion
        #region JobId
        /// <summary><p><em>Sets <see cref="AzureIotHubJobShowSettings.JobId"/>.</em></p><p>Job Id.</p></summary>
        [Pure]
        public static AzureIotHubJobShowSettings SetJobId(this AzureIotHubJobShowSettings toolSettings, string jobId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.JobId = jobId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubJobShowSettings.JobId"/>.</em></p><p>Job Id.</p></summary>
        [Pure]
        public static AzureIotHubJobShowSettings ResetJobId(this AzureIotHubJobShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.JobId = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureIotHubJobShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotHubJobShowSettings SetResourceGroup(this AzureIotHubJobShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubJobShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotHubJobShowSettings ResetResourceGroup(this AzureIotHubJobShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureIotHubJobShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotHubJobShowSettings SetDebug(this AzureIotHubJobShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubJobShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotHubJobShowSettings ResetDebug(this AzureIotHubJobShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureIotHubJobShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotHubJobShowSettings SetHelp(this AzureIotHubJobShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubJobShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotHubJobShowSettings ResetHelp(this AzureIotHubJobShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureIotHubJobShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotHubJobShowSettings SetOutput(this AzureIotHubJobShowSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubJobShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotHubJobShowSettings ResetOutput(this AzureIotHubJobShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureIotHubJobShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubJobShowSettings SetQuery(this AzureIotHubJobShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubJobShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubJobShowSettings ResetQuery(this AzureIotHubJobShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureIotHubJobShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotHubJobShowSettings SetVerbose(this AzureIotHubJobShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubJobShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotHubJobShowSettings ResetVerbose(this AzureIotHubJobShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureIotHubPolicyCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIotHubPolicyCreateSettingsExtensions
    {
        #region HubName
        /// <summary><p><em>Sets <see cref="AzureIotHubPolicyCreateSettings.HubName"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotHubPolicyCreateSettings SetHubName(this AzureIotHubPolicyCreateSettings toolSettings, string hubName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HubName = hubName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubPolicyCreateSettings.HubName"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotHubPolicyCreateSettings ResetHubName(this AzureIotHubPolicyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HubName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureIotHubPolicyCreateSettings.Name"/>.</em></p><p>Shared access policy name.</p></summary>
        [Pure]
        public static AzureIotHubPolicyCreateSettings SetName(this AzureIotHubPolicyCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubPolicyCreateSettings.Name"/>.</em></p><p>Shared access policy name.</p></summary>
        [Pure]
        public static AzureIotHubPolicyCreateSettings ResetName(this AzureIotHubPolicyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Permissions
        /// <summary><p><em>Sets <see cref="AzureIotHubPolicyCreateSettings.Permissions"/>.</em></p><p>Permissions of shared access policy. Use space-separated list for multiple permissions. Possible values: RegistryRead, RegistryWrite, ServiceConnect, DeviceConnect.</p></summary>
        [Pure]
        public static AzureIotHubPolicyCreateSettings SetPermissions(this AzureIotHubPolicyCreateSettings toolSettings, string permissions)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Permissions = permissions;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubPolicyCreateSettings.Permissions"/>.</em></p><p>Permissions of shared access policy. Use space-separated list for multiple permissions. Possible values: RegistryRead, RegistryWrite, ServiceConnect, DeviceConnect.</p></summary>
        [Pure]
        public static AzureIotHubPolicyCreateSettings ResetPermissions(this AzureIotHubPolicyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Permissions = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureIotHubPolicyCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotHubPolicyCreateSettings SetResourceGroup(this AzureIotHubPolicyCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubPolicyCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotHubPolicyCreateSettings ResetResourceGroup(this AzureIotHubPolicyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureIotHubPolicyCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotHubPolicyCreateSettings SetDebug(this AzureIotHubPolicyCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubPolicyCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotHubPolicyCreateSettings ResetDebug(this AzureIotHubPolicyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureIotHubPolicyCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotHubPolicyCreateSettings SetHelp(this AzureIotHubPolicyCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubPolicyCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotHubPolicyCreateSettings ResetHelp(this AzureIotHubPolicyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureIotHubPolicyCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotHubPolicyCreateSettings SetOutput(this AzureIotHubPolicyCreateSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubPolicyCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotHubPolicyCreateSettings ResetOutput(this AzureIotHubPolicyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureIotHubPolicyCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubPolicyCreateSettings SetQuery(this AzureIotHubPolicyCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubPolicyCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubPolicyCreateSettings ResetQuery(this AzureIotHubPolicyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureIotHubPolicyCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotHubPolicyCreateSettings SetVerbose(this AzureIotHubPolicyCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubPolicyCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotHubPolicyCreateSettings ResetVerbose(this AzureIotHubPolicyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureIotHubPolicyDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIotHubPolicyDeleteSettingsExtensions
    {
        #region HubName
        /// <summary><p><em>Sets <see cref="AzureIotHubPolicyDeleteSettings.HubName"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotHubPolicyDeleteSettings SetHubName(this AzureIotHubPolicyDeleteSettings toolSettings, string hubName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HubName = hubName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubPolicyDeleteSettings.HubName"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotHubPolicyDeleteSettings ResetHubName(this AzureIotHubPolicyDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HubName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureIotHubPolicyDeleteSettings.Name"/>.</em></p><p>Shared access policy name.</p></summary>
        [Pure]
        public static AzureIotHubPolicyDeleteSettings SetName(this AzureIotHubPolicyDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubPolicyDeleteSettings.Name"/>.</em></p><p>Shared access policy name.</p></summary>
        [Pure]
        public static AzureIotHubPolicyDeleteSettings ResetName(this AzureIotHubPolicyDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureIotHubPolicyDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotHubPolicyDeleteSettings SetResourceGroup(this AzureIotHubPolicyDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubPolicyDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotHubPolicyDeleteSettings ResetResourceGroup(this AzureIotHubPolicyDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureIotHubPolicyDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotHubPolicyDeleteSettings SetDebug(this AzureIotHubPolicyDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubPolicyDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotHubPolicyDeleteSettings ResetDebug(this AzureIotHubPolicyDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureIotHubPolicyDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotHubPolicyDeleteSettings SetHelp(this AzureIotHubPolicyDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubPolicyDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotHubPolicyDeleteSettings ResetHelp(this AzureIotHubPolicyDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureIotHubPolicyDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotHubPolicyDeleteSettings SetOutput(this AzureIotHubPolicyDeleteSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubPolicyDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotHubPolicyDeleteSettings ResetOutput(this AzureIotHubPolicyDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureIotHubPolicyDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubPolicyDeleteSettings SetQuery(this AzureIotHubPolicyDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubPolicyDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubPolicyDeleteSettings ResetQuery(this AzureIotHubPolicyDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureIotHubPolicyDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotHubPolicyDeleteSettings SetVerbose(this AzureIotHubPolicyDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubPolicyDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotHubPolicyDeleteSettings ResetVerbose(this AzureIotHubPolicyDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureIotHubPolicyListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIotHubPolicyListSettingsExtensions
    {
        #region HubName
        /// <summary><p><em>Sets <see cref="AzureIotHubPolicyListSettings.HubName"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotHubPolicyListSettings SetHubName(this AzureIotHubPolicyListSettings toolSettings, string hubName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HubName = hubName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubPolicyListSettings.HubName"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotHubPolicyListSettings ResetHubName(this AzureIotHubPolicyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HubName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureIotHubPolicyListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotHubPolicyListSettings SetResourceGroup(this AzureIotHubPolicyListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubPolicyListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotHubPolicyListSettings ResetResourceGroup(this AzureIotHubPolicyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureIotHubPolicyListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotHubPolicyListSettings SetDebug(this AzureIotHubPolicyListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubPolicyListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotHubPolicyListSettings ResetDebug(this AzureIotHubPolicyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureIotHubPolicyListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotHubPolicyListSettings SetHelp(this AzureIotHubPolicyListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubPolicyListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotHubPolicyListSettings ResetHelp(this AzureIotHubPolicyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureIotHubPolicyListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotHubPolicyListSettings SetOutput(this AzureIotHubPolicyListSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubPolicyListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotHubPolicyListSettings ResetOutput(this AzureIotHubPolicyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureIotHubPolicyListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubPolicyListSettings SetQuery(this AzureIotHubPolicyListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubPolicyListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubPolicyListSettings ResetQuery(this AzureIotHubPolicyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureIotHubPolicyListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotHubPolicyListSettings SetVerbose(this AzureIotHubPolicyListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubPolicyListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotHubPolicyListSettings ResetVerbose(this AzureIotHubPolicyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureIotHubPolicyShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIotHubPolicyShowSettingsExtensions
    {
        #region HubName
        /// <summary><p><em>Sets <see cref="AzureIotHubPolicyShowSettings.HubName"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotHubPolicyShowSettings SetHubName(this AzureIotHubPolicyShowSettings toolSettings, string hubName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HubName = hubName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubPolicyShowSettings.HubName"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotHubPolicyShowSettings ResetHubName(this AzureIotHubPolicyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HubName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureIotHubPolicyShowSettings.Name"/>.</em></p><p>Shared access policy name.</p></summary>
        [Pure]
        public static AzureIotHubPolicyShowSettings SetName(this AzureIotHubPolicyShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubPolicyShowSettings.Name"/>.</em></p><p>Shared access policy name.</p></summary>
        [Pure]
        public static AzureIotHubPolicyShowSettings ResetName(this AzureIotHubPolicyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureIotHubPolicyShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotHubPolicyShowSettings SetResourceGroup(this AzureIotHubPolicyShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubPolicyShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotHubPolicyShowSettings ResetResourceGroup(this AzureIotHubPolicyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureIotHubPolicyShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotHubPolicyShowSettings SetDebug(this AzureIotHubPolicyShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubPolicyShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotHubPolicyShowSettings ResetDebug(this AzureIotHubPolicyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureIotHubPolicyShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotHubPolicyShowSettings SetHelp(this AzureIotHubPolicyShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubPolicyShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotHubPolicyShowSettings ResetHelp(this AzureIotHubPolicyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureIotHubPolicyShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotHubPolicyShowSettings SetOutput(this AzureIotHubPolicyShowSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubPolicyShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotHubPolicyShowSettings ResetOutput(this AzureIotHubPolicyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureIotHubPolicyShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubPolicyShowSettings SetQuery(this AzureIotHubPolicyShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubPolicyShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubPolicyShowSettings ResetQuery(this AzureIotHubPolicyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureIotHubPolicyShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotHubPolicyShowSettings SetVerbose(this AzureIotHubPolicyShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubPolicyShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotHubPolicyShowSettings ResetVerbose(this AzureIotHubPolicyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region IotDeviceKey
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    public partial class IotDeviceKey : Enumeration
    {
        public static IotDeviceKey primary = new IotDeviceKey { Value = "primary" };
        public static IotDeviceKey secondary = new IotDeviceKey { Value = "secondary" };
    }
    #endregion
    #region IotDpsCreateSku
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    public partial class IotDpsCreateSku : Enumeration
    {
        public static IotDpsCreateSku s1 = new IotDpsCreateSku { Value = "s1" };
    }
    #endregion
    #region IotHubCreateSku
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    public partial class IotHubCreateSku : Enumeration
    {
        public static IotHubCreateSku b1 = new IotHubCreateSku { Value = "b1" };
        public static IotHubCreateSku b2 = new IotHubCreateSku { Value = "b2" };
        public static IotHubCreateSku b3 = new IotHubCreateSku { Value = "b3" };
        public static IotHubCreateSku f1 = new IotHubCreateSku { Value = "f1" };
        public static IotHubCreateSku s1 = new IotHubCreateSku { Value = "s1" };
        public static IotHubCreateSku s2 = new IotHubCreateSku { Value = "s2" };
        public static IotHubCreateSku s3 = new IotHubCreateSku { Value = "s3" };
    }
    #endregion
    #region IotDpsAccessPolicyRights
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    public partial class IotDpsAccessPolicyRights : Enumeration
    {
        public static IotDpsAccessPolicyRights deviceconnect = new IotDpsAccessPolicyRights { Value = "deviceconnect" };
        public static IotDpsAccessPolicyRights enrollmentread = new IotDpsAccessPolicyRights { Value = "enrollmentread" };
        public static IotDpsAccessPolicyRights enrollmentwrite = new IotDpsAccessPolicyRights { Value = "enrollmentwrite" };
        public static IotDpsAccessPolicyRights registrationstatusread = new IotDpsAccessPolicyRights { Value = "registrationstatusread" };
        public static IotDpsAccessPolicyRights registrationstatuswrite = new IotDpsAccessPolicyRights { Value = "registrationstatuswrite" };
        public static IotDpsAccessPolicyRights serviceconfig = new IotDpsAccessPolicyRights { Value = "serviceconfig" };
    }
    #endregion
}
