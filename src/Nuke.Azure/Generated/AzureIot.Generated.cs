// Copyright 2018 Maintainers of NUKE.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

// Generated with Nuke.CodeGeneration, Version: 0.7.0 [CommitSha: 9d3d3d7e].
// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/AzureIot.json.

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
    public static partial class AzureIotTasks
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public static string AzureIotPath => ToolPathResolver.GetPathExecutable("az");
        /// <summary><p>Manage Internet of Things (IoT) assets.</p></summary>
        public static IReadOnlyCollection<Output> AzureIot(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool logOutput = true, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzureIotPath, arguments, workingDirectory, environmentVariables, timeout, logOutput, null, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureIot(Configure<AzureIotSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureIotHubCreate(Configure<AzureIotHubCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotHubCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureIotHubDelete(Configure<AzureIotHubDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotHubDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureIotHubList(Configure<AzureIotHubListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotHubListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureIotHubListSkus(Configure<AzureIotHubListSkusSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotHubListSkusSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureIotHubShow(Configure<AzureIotHubShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotHubShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureIotHubShowConnectionString(Configure<AzureIotHubShowConnectionStringSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotHubShowConnectionStringSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureIotHubShowQuotaMetrics(Configure<AzureIotHubShowQuotaMetricsSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotHubShowQuotaMetricsSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureIotHubShowStats(Configure<AzureIotHubShowStatsSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotHubShowStatsSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureIotHubUpdate(Configure<AzureIotHubUpdateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotHubUpdateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureIotDpsCreate(Configure<AzureIotDpsCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotDpsCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureIotDpsDelete(Configure<AzureIotDpsDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotDpsDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureIotDpsList(Configure<AzureIotDpsListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotDpsListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureIotDpsShow(Configure<AzureIotDpsShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotDpsShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureIotDpsUpdate(Configure<AzureIotDpsUpdateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotDpsUpdateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureIotHubRouteCreate(Configure<AzureIotHubRouteCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotHubRouteCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureIotHubRouteDelete(Configure<AzureIotHubRouteDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotHubRouteDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureIotHubRouteList(Configure<AzureIotHubRouteListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotHubRouteListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureIotHubRouteShow(Configure<AzureIotHubRouteShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotHubRouteShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureIotHubRouteTest(Configure<AzureIotHubRouteTestSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotHubRouteTestSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureIotHubRouteUpdate(Configure<AzureIotHubRouteUpdateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotHubRouteUpdateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureIotHubRoutingEndpointCreate(Configure<AzureIotHubRoutingEndpointCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotHubRoutingEndpointCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureIotHubRoutingEndpointDelete(Configure<AzureIotHubRoutingEndpointDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotHubRoutingEndpointDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureIotHubRoutingEndpointList(Configure<AzureIotHubRoutingEndpointListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotHubRoutingEndpointListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureIotHubRoutingEndpointShow(Configure<AzureIotHubRoutingEndpointShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotHubRoutingEndpointShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureIotHubPolicyCreate(Configure<AzureIotHubPolicyCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotHubPolicyCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureIotHubPolicyDelete(Configure<AzureIotHubPolicyDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotHubPolicyDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureIotHubPolicyList(Configure<AzureIotHubPolicyListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotHubPolicyListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureIotHubPolicyShow(Configure<AzureIotHubPolicyShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotHubPolicyShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureIotHubCertificateCreate(Configure<AzureIotHubCertificateCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotHubCertificateCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureIotHubCertificateDelete(Configure<AzureIotHubCertificateDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotHubCertificateDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureIotHubCertificateGenerateVerificationCode(Configure<AzureIotHubCertificateGenerateVerificationCodeSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotHubCertificateGenerateVerificationCodeSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureIotHubCertificateList(Configure<AzureIotHubCertificateListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotHubCertificateListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureIotHubCertificateShow(Configure<AzureIotHubCertificateShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotHubCertificateShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureIotHubCertificateUpdate(Configure<AzureIotHubCertificateUpdateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotHubCertificateUpdateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureIotHubCertificateVerify(Configure<AzureIotHubCertificateVerifySettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotHubCertificateVerifySettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureIotHubConsumerGroupCreate(Configure<AzureIotHubConsumerGroupCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotHubConsumerGroupCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureIotHubConsumerGroupDelete(Configure<AzureIotHubConsumerGroupDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotHubConsumerGroupDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureIotHubConsumerGroupList(Configure<AzureIotHubConsumerGroupListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotHubConsumerGroupListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureIotHubConsumerGroupShow(Configure<AzureIotHubConsumerGroupShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotHubConsumerGroupShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureIotHubJobCancel(Configure<AzureIotHubJobCancelSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotHubJobCancelSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureIotHubJobList(Configure<AzureIotHubJobListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotHubJobListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureIotHubJobShow(Configure<AzureIotHubJobShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotHubJobShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureIotDpsAccessPolicyCreate(Configure<AzureIotDpsAccessPolicyCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotDpsAccessPolicyCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureIotDpsAccessPolicyDelete(Configure<AzureIotDpsAccessPolicyDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotDpsAccessPolicyDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureIotDpsAccessPolicyList(Configure<AzureIotDpsAccessPolicyListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotDpsAccessPolicyListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureIotDpsAccessPolicyShow(Configure<AzureIotDpsAccessPolicyShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotDpsAccessPolicyShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureIotDpsAccessPolicyUpdate(Configure<AzureIotDpsAccessPolicyUpdateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotDpsAccessPolicyUpdateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureIotDpsCertificateCreate(Configure<AzureIotDpsCertificateCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotDpsCertificateCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureIotDpsCertificateDelete(Configure<AzureIotDpsCertificateDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotDpsCertificateDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureIotDpsCertificateGenerateVerificationCode(Configure<AzureIotDpsCertificateGenerateVerificationCodeSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotDpsCertificateGenerateVerificationCodeSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureIotDpsCertificateList(Configure<AzureIotDpsCertificateListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotDpsCertificateListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureIotDpsCertificateShow(Configure<AzureIotDpsCertificateShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotDpsCertificateShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureIotDpsCertificateUpdate(Configure<AzureIotDpsCertificateUpdateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotDpsCertificateUpdateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureIotDpsCertificateVerify(Configure<AzureIotDpsCertificateVerifySettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotDpsCertificateVerifySettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureIotDpsLinkedHubCreate(Configure<AzureIotDpsLinkedHubCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotDpsLinkedHubCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureIotDpsLinkedHubDelete(Configure<AzureIotDpsLinkedHubDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotDpsLinkedHubDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureIotDpsLinkedHubList(Configure<AzureIotDpsLinkedHubListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotDpsLinkedHubListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureIotDpsLinkedHubShow(Configure<AzureIotDpsLinkedHubShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotDpsLinkedHubShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Internet of Things (IoT) assets.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureIotDpsLinkedHubUpdate(Configure<AzureIotDpsLinkedHubUpdateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureIotDpsLinkedHubUpdateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
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
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
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
        /// <summary><p>The number of partitions of the backing Event Hub for device-to-cloud messages.</p></summary>
        public virtual string PartitionCount { get; internal set; }
        /// <summary><p>Pricing tier for Azure IoT Hub. Default value is F1, which is free. Note that only one free IoT hub instance is allowed in each subscription. Exception will be thrown if free instances exceed one.</p></summary>
        public virtual IotHubCreateSku Sku { get; internal set; }
        /// <summary><p>Units in your IoT Hub.</p></summary>
        public virtual string Unit { get; internal set; }
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
              .Add("iot hub create")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--location {value}", Location)
              .Add("--partition-count {value}", PartitionCount)
              .Add("--sku {value}", Sku)
              .Add("--unit {value}", Unit)
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
    #region AzureIotHubDeleteSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotHubDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary><p>IoT Hub name.</p></summary>
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
              .Add("iot hub delete")
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
              .Add("iot hub list")
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
    #region AzureIotHubListSkusSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotHubListSkusSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary><p>IoT Hub name.</p></summary>
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
              .Add("iot hub list-skus")
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
    #region AzureIotHubShowSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotHubShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary><p>IoT Hub name.</p></summary>
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
              .Add("iot hub show")
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
    #region AzureIotHubShowConnectionStringSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotHubShowConnectionStringSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>The key to use.</p></summary>
        public virtual IotHubShowConnectionStringKey Key { get; internal set; }
        /// <summary><p>Shared access policy to use.</p></summary>
        public virtual string PolicyName { get; internal set; }
        /// <summary><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary><p>IoT Hub name.</p></summary>
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
              .Add("iot hub show-connection-string")
              .Add("--key {value}", Key)
              .Add("--policy-name {value}", PolicyName)
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
    #region AzureIotHubShowQuotaMetricsSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotHubShowQuotaMetricsSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary><p>IoT Hub name.</p></summary>
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
              .Add("iot hub show-quota-metrics")
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
    #region AzureIotHubShowStatsSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotHubShowStatsSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary><p>IoT Hub name.</p></summary>
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
              .Add("iot hub show-stats")
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
    #region AzureIotHubUpdateSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotHubUpdateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary><p>IoT Hub name.</p></summary>
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
              .Add("iot hub update")
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
              .Add("iot dps create")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--location {value}", Location)
              .Add("--sku {value}", Sku)
              .Add("--unit {value}", Unit)
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
    #region AzureIotDpsDeleteSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotDpsDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary><p>IoT Provisioning Service name.</p></summary>
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
              .Add("iot dps delete")
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
              .Add("iot dps list")
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
    #region AzureIotDpsShowSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotDpsShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary><p>IoT Provisioning Service name.</p></summary>
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
              .Add("iot dps show")
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
    #region AzureIotDpsUpdateSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotDpsUpdateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary><p>IoT Provisioning Service name.</p></summary>
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
              .Add("iot dps update")
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
    #region AzureIotHubRouteCreateSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotHubRouteCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>Name of the routing endpoint.</p></summary>
        public virtual string En { get; internal set; }
        /// <summary><p>IoT Hub name.</p></summary>
        public virtual string HubName { get; internal set; }
        /// <summary><p>Name of the Route.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Source of the route.</p></summary>
        public virtual IotHubRouteSource Source { get; internal set; }
        /// <summary><p>Condition that is evaluated to apply the routing rule.</p></summary>
        public virtual string Condition { get; internal set; }
        /// <summary><p>A boolean indicating whether to enable route to the Iot hub.</p></summary>
        public virtual bool? Enabled { get; internal set; }
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
              .Add("iot hub route create")
              .Add("--en {value}", En)
              .Add("--hub-name {value}", HubName)
              .Add("--name {value}", Name)
              .Add("--source {value}", Source)
              .Add("--condition {value}", Condition)
              .Add("--enabled", Enabled)
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
    #region AzureIotHubRouteDeleteSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotHubRouteDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>Name of the Route.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Source of the route.</p></summary>
        public virtual IotHubRouteSource Source { get; internal set; }
        /// <summary><p>IoT Hub name.</p></summary>
        public virtual string HubName { get; internal set; }
        /// <summary><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
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
              .Add("iot hub route delete")
              .Add("--name {value}", Name)
              .Add("--source {value}", Source)
              .Add("--hub-name {value}", HubName)
              .Add("--ids {value}", Ids, separator: ' ')
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
    #region AzureIotHubRouteListSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotHubRouteListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>Source of the route.</p></summary>
        public virtual IotHubRouteSource Source { get; internal set; }
        /// <summary><p>IoT Hub name.</p></summary>
        public virtual string HubName { get; internal set; }
        /// <summary><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
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
              .Add("iot hub route list")
              .Add("--source {value}", Source)
              .Add("--hub-name {value}", HubName)
              .Add("--ids {value}", Ids, separator: ' ')
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
    #region AzureIotHubRouteShowSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotHubRouteShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>Name of the Route.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>IoT Hub name.</p></summary>
        public virtual string HubName { get; internal set; }
        /// <summary><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
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
              .Add("iot hub route show")
              .Add("--name {value}", Name)
              .Add("--hub-name {value}", HubName)
              .Add("--ids {value}", Ids, separator: ' ')
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
    #region AzureIotHubRouteTestSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotHubRouteTestSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>App properties of the route message.</p></summary>
        public virtual string Ap { get; internal set; }
        /// <summary><p>Body of the route message.</p></summary>
        public virtual string Body { get; internal set; }
        /// <summary><p>Name of the Route.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Source of the route.</p></summary>
        public virtual IotHubRouteSource Source { get; internal set; }
        /// <summary><p>System properties of the route message.</p></summary>
        public virtual string Sp { get; internal set; }
        /// <summary><p>IoT Hub name.</p></summary>
        public virtual string HubName { get; internal set; }
        /// <summary><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
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
              .Add("iot hub route test")
              .Add("--ap {value}", Ap)
              .Add("--body {value}", Body)
              .Add("--name {value}", Name)
              .Add("--source {value}", Source)
              .Add("--sp {value}", Sp)
              .Add("--hub-name {value}", HubName)
              .Add("--ids {value}", Ids, separator: ' ')
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
    #region AzureIotHubRouteUpdateSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotHubRouteUpdateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>Name of the Route.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Condition that is evaluated to apply the routing rule.</p></summary>
        public virtual string Condition { get; internal set; }
        /// <summary><p>Name of the routing endpoint.</p></summary>
        public virtual string En { get; internal set; }
        /// <summary><p>A boolean indicating whether to enable route to the Iot hub.</p></summary>
        public virtual bool? Enabled { get; internal set; }
        /// <summary><p>Source of the route.</p></summary>
        public virtual IotHubRouteSource Source { get; internal set; }
        /// <summary><p>IoT Hub name.</p></summary>
        public virtual string HubName { get; internal set; }
        /// <summary><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
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
              .Add("iot hub route update")
              .Add("--name {value}", Name)
              .Add("--condition {value}", Condition)
              .Add("--en {value}", En)
              .Add("--enabled", Enabled)
              .Add("--source {value}", Source)
              .Add("--hub-name {value}", HubName)
              .Add("--ids {value}", Ids, separator: ' ')
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
    #region AzureIotHubRoutingEndpointCreateSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotHubRoutingEndpointCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>Connection string of the Routing Endpoint.</p></summary>
        public virtual string ConnectionString { get; internal set; }
        /// <summary><p>Name of the Routing Endpoint.</p></summary>
        public virtual string EndpointName { get; internal set; }
        /// <summary><p>Resource group of the Endpoint resoure.</p></summary>
        public virtual string EndpointResourceGroup { get; internal set; }
        /// <summary><p>SubscriptionId of the Endpoint resource.</p></summary>
        public virtual string EndpointSubscriptionId { get; internal set; }
        /// <summary><p>Type of the Routing Endpoint.</p></summary>
        public virtual IotHubRoutingEndpointEndpointType EndpointType { get; internal set; }
        /// <summary><p>IoT Hub name.</p></summary>
        public virtual string HubName { get; internal set; }
        /// <summary><p>Name of the storage container.</p></summary>
        public virtual string Container { get; internal set; }
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
              .Add("iot hub routing-endpoint create")
              .Add("--connection-string {value}", ConnectionString)
              .Add("--endpoint-name {value}", EndpointName)
              .Add("--endpoint-resource-group {value}", EndpointResourceGroup)
              .Add("--endpoint-subscription-id {value}", EndpointSubscriptionId)
              .Add("--endpoint-type {value}", EndpointType)
              .Add("--hub-name {value}", HubName)
              .Add("--container {value}", Container)
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
    #region AzureIotHubRoutingEndpointDeleteSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotHubRoutingEndpointDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>Name of the Routing Endpoint.</p></summary>
        public virtual string EndpointName { get; internal set; }
        /// <summary><p>Type of the Routing Endpoint.</p></summary>
        public virtual IotHubRoutingEndpointEndpointType EndpointType { get; internal set; }
        /// <summary><p>IoT Hub name.</p></summary>
        public virtual string HubName { get; internal set; }
        /// <summary><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
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
              .Add("iot hub routing-endpoint delete")
              .Add("--endpoint-name {value}", EndpointName)
              .Add("--endpoint-type {value}", EndpointType)
              .Add("--hub-name {value}", HubName)
              .Add("--ids {value}", Ids, separator: ' ')
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
    #region AzureIotHubRoutingEndpointListSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotHubRoutingEndpointListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>Type of the Routing Endpoint.</p></summary>
        public virtual IotHubRoutingEndpointEndpointType EndpointType { get; internal set; }
        /// <summary><p>IoT Hub name.</p></summary>
        public virtual string HubName { get; internal set; }
        /// <summary><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
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
              .Add("iot hub routing-endpoint list")
              .Add("--endpoint-type {value}", EndpointType)
              .Add("--hub-name {value}", HubName)
              .Add("--ids {value}", Ids, separator: ' ')
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
    #region AzureIotHubRoutingEndpointShowSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotHubRoutingEndpointShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>Name of the Routing Endpoint.</p></summary>
        public virtual string EndpointName { get; internal set; }
        /// <summary><p>IoT Hub name.</p></summary>
        public virtual string HubName { get; internal set; }
        /// <summary><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
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
              .Add("iot hub routing-endpoint show")
              .Add("--endpoint-name {value}", EndpointName)
              .Add("--hub-name {value}", HubName)
              .Add("--ids {value}", Ids, separator: ' ')
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
              .Add("iot hub policy create")
              .Add("--hub-name {value}", HubName)
              .Add("--name {value}", Name)
              .Add("--permissions {value}", Permissions)
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
        /// <summary><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary><p>Shared access policy name.</p></summary>
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
              .Add("iot hub policy delete")
              .Add("--hub-name {value}", HubName)
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
        /// <summary><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
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
              .Add("iot hub policy list")
              .Add("--hub-name {value}", HubName)
              .Add("--ids {value}", Ids, separator: ' ')
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
        /// <summary><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary><p>Shared access policy name.</p></summary>
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
              .Add("iot hub policy show")
              .Add("--hub-name {value}", HubName)
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
              .Add("iot hub certificate create")
              .Add("--hub-name {value}", HubName)
              .Add("--name {value}", Name)
              .Add("--path {value}", Path)
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
        /// <summary><p>A friendly name for the certificate.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>IoT Hub name.</p></summary>
        public virtual string HubName { get; internal set; }
        /// <summary><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
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
              .Add("iot hub certificate delete")
              .Add("--etag {value}", Etag)
              .Add("--name {value}", Name)
              .Add("--hub-name {value}", HubName)
              .Add("--ids {value}", Ids, separator: ' ')
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
        /// <summary><p>A friendly name for the certificate.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>IoT Hub name.</p></summary>
        public virtual string HubName { get; internal set; }
        /// <summary><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
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
              .Add("iot hub certificate generate-verification-code")
              .Add("--etag {value}", Etag)
              .Add("--name {value}", Name)
              .Add("--hub-name {value}", HubName)
              .Add("--ids {value}", Ids, separator: ' ')
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
        /// <summary><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
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
              .Add("iot hub certificate list")
              .Add("--hub-name {value}", HubName)
              .Add("--ids {value}", Ids, separator: ' ')
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
    #region AzureIotHubCertificateShowSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotHubCertificateShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>A friendly name for the certificate.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>IoT Hub name.</p></summary>
        public virtual string HubName { get; internal set; }
        /// <summary><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
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
              .Add("iot hub certificate show")
              .Add("--name {value}", Name)
              .Add("--hub-name {value}", HubName)
              .Add("--ids {value}", Ids, separator: ' ')
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
        /// <summary><p>A friendly name for the certificate.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>The path to the file containing the certificate.</p></summary>
        public virtual string Path { get; internal set; }
        /// <summary><p>IoT Hub name.</p></summary>
        public virtual string HubName { get; internal set; }
        /// <summary><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
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
              .Add("iot hub certificate update")
              .Add("--etag {value}", Etag)
              .Add("--name {value}", Name)
              .Add("--path {value}", Path)
              .Add("--hub-name {value}", HubName)
              .Add("--ids {value}", Ids, separator: ' ')
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
        /// <summary><p>A friendly name for the certificate.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>The path to the file containing the certificate.</p></summary>
        public virtual string Path { get; internal set; }
        /// <summary><p>IoT Hub name.</p></summary>
        public virtual string HubName { get; internal set; }
        /// <summary><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
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
              .Add("iot hub certificate verify")
              .Add("--etag {value}", Etag)
              .Add("--name {value}", Name)
              .Add("--path {value}", Path)
              .Add("--hub-name {value}", HubName)
              .Add("--ids {value}", Ids, separator: ' ')
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
              .Add("iot hub consumer-group create")
              .Add("--hub-name {value}", HubName)
              .Add("--name {value}", Name)
              .Add("--event-hub-name {value}", EventHubName)
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
    #region AzureIotHubConsumerGroupDeleteSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotHubConsumerGroupDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>Event hub endpoint name.</p></summary>
        public virtual string EventHubName { get; internal set; }
        /// <summary><p>IoT Hub name.</p></summary>
        public virtual string HubName { get; internal set; }
        /// <summary><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary><p>Event hub consumer group name.</p></summary>
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
              .Add("iot hub consumer-group delete")
              .Add("--event-hub-name {value}", EventHubName)
              .Add("--hub-name {value}", HubName)
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
    #region AzureIotHubConsumerGroupListSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotHubConsumerGroupListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>Event hub endpoint name.</p></summary>
        public virtual string EventHubName { get; internal set; }
        /// <summary><p>IoT Hub name.</p></summary>
        public virtual string HubName { get; internal set; }
        /// <summary><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
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
              .Add("iot hub consumer-group list")
              .Add("--event-hub-name {value}", EventHubName)
              .Add("--hub-name {value}", HubName)
              .Add("--ids {value}", Ids, separator: ' ')
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
    #region AzureIotHubConsumerGroupShowSettings
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotHubConsumerGroupShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureIot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureIotTasks.AzureIotPath;
        /// <summary><p>Event hub endpoint name.</p></summary>
        public virtual string EventHubName { get; internal set; }
        /// <summary><p>IoT Hub name.</p></summary>
        public virtual string HubName { get; internal set; }
        /// <summary><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary><p>Event hub consumer group name.</p></summary>
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
              .Add("iot hub consumer-group show")
              .Add("--event-hub-name {value}", EventHubName)
              .Add("--hub-name {value}", HubName)
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
        /// <summary><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary><p>Job Id.</p></summary>
        public virtual string JobId { get; internal set; }
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
              .Add("iot hub job cancel")
              .Add("--hub-name {value}", HubName)
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--job-id {value}", JobId)
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
        /// <summary><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
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
              .Add("iot hub job list")
              .Add("--hub-name {value}", HubName)
              .Add("--ids {value}", Ids, separator: ' ')
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
        /// <summary><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary><p>Job Id.</p></summary>
        public virtual string JobId { get; internal set; }
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
              .Add("iot hub job show")
              .Add("--hub-name {value}", HubName)
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--job-id {value}", JobId)
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
        public virtual bool? NoWait { get; internal set; }
        /// <summary><p>Primary SAS key value.</p></summary>
        public virtual string PrimaryKey { get; internal set; }
        /// <summary><p>Secondary SAS key value.</p></summary>
        public virtual string SecondaryKey { get; internal set; }
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
              .Add("iot dps access-policy create")
              .Add("--access-policy-name {value}", AccessPolicyName)
              .Add("--dps-name {value}", DpsName)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--rights {value}", Rights)
              .Add("--no-wait", NoWait)
              .Add("--primary-key {value}", PrimaryKey)
              .Add("--secondary-key {value}", SecondaryKey)
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
        public virtual bool? NoWait { get; internal set; }
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
              .Add("iot dps access-policy delete")
              .Add("--access-policy-name {value}", AccessPolicyName)
              .Add("--dps-name {value}", DpsName)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--no-wait", NoWait)
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
              .Add("iot dps access-policy list")
              .Add("--dps-name {value}", DpsName)
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
              .Add("iot dps access-policy show")
              .Add("--access-policy-name {value}", AccessPolicyName)
              .Add("--dps-name {value}", DpsName)
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
        public virtual bool? NoWait { get; internal set; }
        /// <summary><p>Primary SAS key value.</p></summary>
        public virtual string PrimaryKey { get; internal set; }
        /// <summary><p>Access rights for the IoT provisioning service. Use space-separated list for multiple rights.</p></summary>
        public virtual IotDpsAccessPolicyRights Rights { get; internal set; }
        /// <summary><p>Secondary SAS key value.</p></summary>
        public virtual string SecondaryKey { get; internal set; }
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
              .Add("iot dps access-policy update")
              .Add("--access-policy-name {value}", AccessPolicyName)
              .Add("--dps-name {value}", DpsName)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--no-wait", NoWait)
              .Add("--primary-key {value}", PrimaryKey)
              .Add("--rights {value}", Rights)
              .Add("--secondary-key {value}", SecondaryKey)
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
              .Add("iot dps certificate create")
              .Add("--certificate-name {value}", CertificateName)
              .Add("--dps-name {value}", DpsName)
              .Add("--path {value}", Path)
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
              .Add("iot dps certificate delete")
              .Add("--certificate-name {value}", CertificateName)
              .Add("--dps-name {value}", DpsName)
              .Add("--etag {value}", Etag)
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
              .Add("iot dps certificate generate-verification-code")
              .Add("--certificate-name {value}", CertificateName)
              .Add("--dps-name {value}", DpsName)
              .Add("--etag {value}", Etag)
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
              .Add("iot dps certificate list")
              .Add("--dps-name {value}", DpsName)
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
              .Add("iot dps certificate show")
              .Add("--certificate-name {value}", CertificateName)
              .Add("--dps-name {value}", DpsName)
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
              .Add("iot dps certificate update")
              .Add("--certificate-name {value}", CertificateName)
              .Add("--dps-name {value}", DpsName)
              .Add("--etag {value}", Etag)
              .Add("--path {value}", Path)
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
              .Add("iot dps certificate verify")
              .Add("--certificate-name {value}", CertificateName)
              .Add("--dps-name {value}", DpsName)
              .Add("--etag {value}", Etag)
              .Add("--path {value}", Path)
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
        public virtual bool? NoWait { get; internal set; }
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
              .Add("iot dps linked-hub create")
              .Add("--connection-string {value}", ConnectionString)
              .Add("--dps-name {value}", DpsName)
              .Add("--location {value}", Location)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--allocation-weight {value}", AllocationWeight)
              .Add("--apply-allocation-policy", ApplyAllocationPolicy)
              .Add("--no-wait", NoWait)
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
        public virtual bool? NoWait { get; internal set; }
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
              .Add("iot dps linked-hub delete")
              .Add("--dps-name {value}", DpsName)
              .Add("--linked-hub {value}", LinkedHub)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--no-wait", NoWait)
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
              .Add("iot dps linked-hub list")
              .Add("--dps-name {value}", DpsName)
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
              .Add("iot dps linked-hub show")
              .Add("--dps-name {value}", DpsName)
              .Add("--linked-hub {value}", LinkedHub)
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
        public virtual bool? NoWait { get; internal set; }
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
              .Add("iot dps linked-hub update")
              .Add("--dps-name {value}", DpsName)
              .Add("--linked-hub {value}", LinkedHub)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--allocation-weight {value}", AllocationWeight)
              .Add("--apply-allocation-policy", ApplyAllocationPolicy)
              .Add("--no-wait", NoWait)
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
        public static AzureIotSettings SetOutput(this AzureIotSettings toolSettings, AzureOutput output)
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
        /// <summary><p><em>Sets <see cref="AzureIotSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureIotSettings SetQuery(this AzureIotSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
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
        /// <summary><p><em>Sets <see cref="AzureIotHubCreateSettings.PartitionCount"/>.</em></p><p>The number of partitions of the backing Event Hub for device-to-cloud messages.</p></summary>
        [Pure]
        public static AzureIotHubCreateSettings SetPartitionCount(this AzureIotHubCreateSettings toolSettings, string partitionCount)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PartitionCount = partitionCount;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCreateSettings.PartitionCount"/>.</em></p><p>The number of partitions of the backing Event Hub for device-to-cloud messages.</p></summary>
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
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureIotHubCreateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotHubCreateSettings SetSubscription(this AzureIotHubCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCreateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotHubCreateSettings ResetSubscription(this AzureIotHubCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
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
        public static AzureIotHubCreateSettings SetOutput(this AzureIotHubCreateSettings toolSettings, AzureOutput output)
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
        /// <summary><p><em>Sets <see cref="AzureIotHubCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubCreateSettings SetQuery(this AzureIotHubCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
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
        #region Ids
        /// <summary><p><em>Sets <see cref="AzureIotHubDeleteSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubDeleteSettings SetIds(this AzureIotHubDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureIotHubDeleteSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubDeleteSettings SetIds(this AzureIotHubDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureIotHubDeleteSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubDeleteSettings AddIds(this AzureIotHubDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureIotHubDeleteSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubDeleteSettings AddIds(this AzureIotHubDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureIotHubDeleteSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubDeleteSettings ClearIds(this AzureIotHubDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureIotHubDeleteSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubDeleteSettings RemoveIds(this AzureIotHubDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureIotHubDeleteSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubDeleteSettings RemoveIds(this AzureIotHubDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
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
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureIotHubDeleteSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotHubDeleteSettings SetSubscription(this AzureIotHubDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubDeleteSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotHubDeleteSettings ResetSubscription(this AzureIotHubDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
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
        public static AzureIotHubDeleteSettings SetOutput(this AzureIotHubDeleteSettings toolSettings, AzureOutput output)
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
        /// <summary><p><em>Sets <see cref="AzureIotHubDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubDeleteSettings SetQuery(this AzureIotHubDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
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
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureIotHubListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotHubListSettings SetSubscription(this AzureIotHubListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotHubListSettings ResetSubscription(this AzureIotHubListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
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
        public static AzureIotHubListSettings SetOutput(this AzureIotHubListSettings toolSettings, AzureOutput output)
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
        /// <summary><p><em>Sets <see cref="AzureIotHubListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubListSettings SetQuery(this AzureIotHubListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
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
        #region Ids
        /// <summary><p><em>Sets <see cref="AzureIotHubListSkusSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubListSkusSettings SetIds(this AzureIotHubListSkusSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureIotHubListSkusSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubListSkusSettings SetIds(this AzureIotHubListSkusSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureIotHubListSkusSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubListSkusSettings AddIds(this AzureIotHubListSkusSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureIotHubListSkusSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubListSkusSettings AddIds(this AzureIotHubListSkusSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureIotHubListSkusSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubListSkusSettings ClearIds(this AzureIotHubListSkusSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureIotHubListSkusSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubListSkusSettings RemoveIds(this AzureIotHubListSkusSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureIotHubListSkusSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubListSkusSettings RemoveIds(this AzureIotHubListSkusSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
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
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureIotHubListSkusSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotHubListSkusSettings SetSubscription(this AzureIotHubListSkusSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubListSkusSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotHubListSkusSettings ResetSubscription(this AzureIotHubListSkusSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
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
        public static AzureIotHubListSkusSettings SetOutput(this AzureIotHubListSkusSettings toolSettings, AzureOutput output)
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
        /// <summary><p><em>Sets <see cref="AzureIotHubListSkusSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubListSkusSettings SetQuery(this AzureIotHubListSkusSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubListSkusSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
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
        #region Ids
        /// <summary><p><em>Sets <see cref="AzureIotHubShowSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubShowSettings SetIds(this AzureIotHubShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureIotHubShowSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubShowSettings SetIds(this AzureIotHubShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureIotHubShowSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubShowSettings AddIds(this AzureIotHubShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureIotHubShowSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubShowSettings AddIds(this AzureIotHubShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureIotHubShowSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubShowSettings ClearIds(this AzureIotHubShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureIotHubShowSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubShowSettings RemoveIds(this AzureIotHubShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureIotHubShowSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubShowSettings RemoveIds(this AzureIotHubShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
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
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureIotHubShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotHubShowSettings SetSubscription(this AzureIotHubShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotHubShowSettings ResetSubscription(this AzureIotHubShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
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
        public static AzureIotHubShowSettings SetOutput(this AzureIotHubShowSettings toolSettings, AzureOutput output)
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
        /// <summary><p><em>Sets <see cref="AzureIotHubShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubShowSettings SetQuery(this AzureIotHubShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
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
        #region Key
        /// <summary><p><em>Sets <see cref="AzureIotHubShowConnectionStringSettings.Key"/>.</em></p><p>The key to use.</p></summary>
        [Pure]
        public static AzureIotHubShowConnectionStringSettings SetKey(this AzureIotHubShowConnectionStringSettings toolSettings, IotHubShowConnectionStringKey key)
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
        #region Ids
        /// <summary><p><em>Sets <see cref="AzureIotHubShowConnectionStringSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubShowConnectionStringSettings SetIds(this AzureIotHubShowConnectionStringSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureIotHubShowConnectionStringSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubShowConnectionStringSettings SetIds(this AzureIotHubShowConnectionStringSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureIotHubShowConnectionStringSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubShowConnectionStringSettings AddIds(this AzureIotHubShowConnectionStringSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureIotHubShowConnectionStringSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubShowConnectionStringSettings AddIds(this AzureIotHubShowConnectionStringSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureIotHubShowConnectionStringSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubShowConnectionStringSettings ClearIds(this AzureIotHubShowConnectionStringSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureIotHubShowConnectionStringSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubShowConnectionStringSettings RemoveIds(this AzureIotHubShowConnectionStringSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureIotHubShowConnectionStringSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubShowConnectionStringSettings RemoveIds(this AzureIotHubShowConnectionStringSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
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
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureIotHubShowConnectionStringSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotHubShowConnectionStringSettings SetSubscription(this AzureIotHubShowConnectionStringSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubShowConnectionStringSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotHubShowConnectionStringSettings ResetSubscription(this AzureIotHubShowConnectionStringSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
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
        public static AzureIotHubShowConnectionStringSettings SetOutput(this AzureIotHubShowConnectionStringSettings toolSettings, AzureOutput output)
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
        /// <summary><p><em>Sets <see cref="AzureIotHubShowConnectionStringSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubShowConnectionStringSettings SetQuery(this AzureIotHubShowConnectionStringSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubShowConnectionStringSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
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
        #region Ids
        /// <summary><p><em>Sets <see cref="AzureIotHubShowQuotaMetricsSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubShowQuotaMetricsSettings SetIds(this AzureIotHubShowQuotaMetricsSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureIotHubShowQuotaMetricsSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubShowQuotaMetricsSettings SetIds(this AzureIotHubShowQuotaMetricsSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureIotHubShowQuotaMetricsSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubShowQuotaMetricsSettings AddIds(this AzureIotHubShowQuotaMetricsSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureIotHubShowQuotaMetricsSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubShowQuotaMetricsSettings AddIds(this AzureIotHubShowQuotaMetricsSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureIotHubShowQuotaMetricsSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubShowQuotaMetricsSettings ClearIds(this AzureIotHubShowQuotaMetricsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureIotHubShowQuotaMetricsSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubShowQuotaMetricsSettings RemoveIds(this AzureIotHubShowQuotaMetricsSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureIotHubShowQuotaMetricsSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubShowQuotaMetricsSettings RemoveIds(this AzureIotHubShowQuotaMetricsSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
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
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureIotHubShowQuotaMetricsSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotHubShowQuotaMetricsSettings SetSubscription(this AzureIotHubShowQuotaMetricsSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubShowQuotaMetricsSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotHubShowQuotaMetricsSettings ResetSubscription(this AzureIotHubShowQuotaMetricsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
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
        public static AzureIotHubShowQuotaMetricsSettings SetOutput(this AzureIotHubShowQuotaMetricsSettings toolSettings, AzureOutput output)
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
        /// <summary><p><em>Sets <see cref="AzureIotHubShowQuotaMetricsSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubShowQuotaMetricsSettings SetQuery(this AzureIotHubShowQuotaMetricsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubShowQuotaMetricsSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
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
        #region Ids
        /// <summary><p><em>Sets <see cref="AzureIotHubShowStatsSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubShowStatsSettings SetIds(this AzureIotHubShowStatsSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureIotHubShowStatsSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubShowStatsSettings SetIds(this AzureIotHubShowStatsSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureIotHubShowStatsSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubShowStatsSettings AddIds(this AzureIotHubShowStatsSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureIotHubShowStatsSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubShowStatsSettings AddIds(this AzureIotHubShowStatsSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureIotHubShowStatsSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubShowStatsSettings ClearIds(this AzureIotHubShowStatsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureIotHubShowStatsSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubShowStatsSettings RemoveIds(this AzureIotHubShowStatsSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureIotHubShowStatsSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubShowStatsSettings RemoveIds(this AzureIotHubShowStatsSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
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
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureIotHubShowStatsSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotHubShowStatsSettings SetSubscription(this AzureIotHubShowStatsSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubShowStatsSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotHubShowStatsSettings ResetSubscription(this AzureIotHubShowStatsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
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
        public static AzureIotHubShowStatsSettings SetOutput(this AzureIotHubShowStatsSettings toolSettings, AzureOutput output)
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
        /// <summary><p><em>Sets <see cref="AzureIotHubShowStatsSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubShowStatsSettings SetQuery(this AzureIotHubShowStatsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubShowStatsSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
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
        #region Ids
        /// <summary><p><em>Sets <see cref="AzureIotHubUpdateSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubUpdateSettings SetIds(this AzureIotHubUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureIotHubUpdateSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubUpdateSettings SetIds(this AzureIotHubUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureIotHubUpdateSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubUpdateSettings AddIds(this AzureIotHubUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureIotHubUpdateSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubUpdateSettings AddIds(this AzureIotHubUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureIotHubUpdateSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubUpdateSettings ClearIds(this AzureIotHubUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureIotHubUpdateSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubUpdateSettings RemoveIds(this AzureIotHubUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureIotHubUpdateSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubUpdateSettings RemoveIds(this AzureIotHubUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
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
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureIotHubUpdateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotHubUpdateSettings SetSubscription(this AzureIotHubUpdateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubUpdateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotHubUpdateSettings ResetSubscription(this AzureIotHubUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
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
        #region ForceString
        /// <summary><p><em>Sets <see cref="AzureIotHubUpdateSettings.ForceString"/>.</em></p><p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p></summary>
        [Pure]
        public static AzureIotHubUpdateSettings SetForceString(this AzureIotHubUpdateSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubUpdateSettings.ForceString"/>.</em></p><p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p></summary>
        [Pure]
        public static AzureIotHubUpdateSettings ResetForceString(this AzureIotHubUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
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
        public static AzureIotHubUpdateSettings SetOutput(this AzureIotHubUpdateSettings toolSettings, AzureOutput output)
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
        /// <summary><p><em>Sets <see cref="AzureIotHubUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubUpdateSettings SetQuery(this AzureIotHubUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
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
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureIotDpsCreateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotDpsCreateSettings SetSubscription(this AzureIotDpsCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCreateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotDpsCreateSettings ResetSubscription(this AzureIotDpsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
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
        public static AzureIotDpsCreateSettings SetOutput(this AzureIotDpsCreateSettings toolSettings, AzureOutput output)
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
        /// <summary><p><em>Sets <see cref="AzureIotDpsCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDpsCreateSettings SetQuery(this AzureIotDpsCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
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
        #region Ids
        /// <summary><p><em>Sets <see cref="AzureIotDpsDeleteSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotDpsDeleteSettings SetIds(this AzureIotDpsDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureIotDpsDeleteSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotDpsDeleteSettings SetIds(this AzureIotDpsDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureIotDpsDeleteSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotDpsDeleteSettings AddIds(this AzureIotDpsDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureIotDpsDeleteSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotDpsDeleteSettings AddIds(this AzureIotDpsDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureIotDpsDeleteSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotDpsDeleteSettings ClearIds(this AzureIotDpsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureIotDpsDeleteSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotDpsDeleteSettings RemoveIds(this AzureIotDpsDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureIotDpsDeleteSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotDpsDeleteSettings RemoveIds(this AzureIotDpsDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
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
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureIotDpsDeleteSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotDpsDeleteSettings SetSubscription(this AzureIotDpsDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsDeleteSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotDpsDeleteSettings ResetSubscription(this AzureIotDpsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
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
        public static AzureIotDpsDeleteSettings SetOutput(this AzureIotDpsDeleteSettings toolSettings, AzureOutput output)
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
        /// <summary><p><em>Sets <see cref="AzureIotDpsDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDpsDeleteSettings SetQuery(this AzureIotDpsDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
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
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureIotDpsListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotDpsListSettings SetSubscription(this AzureIotDpsListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotDpsListSettings ResetSubscription(this AzureIotDpsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
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
        public static AzureIotDpsListSettings SetOutput(this AzureIotDpsListSettings toolSettings, AzureOutput output)
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
        /// <summary><p><em>Sets <see cref="AzureIotDpsListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDpsListSettings SetQuery(this AzureIotDpsListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
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
        #region Ids
        /// <summary><p><em>Sets <see cref="AzureIotDpsShowSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotDpsShowSettings SetIds(this AzureIotDpsShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureIotDpsShowSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotDpsShowSettings SetIds(this AzureIotDpsShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureIotDpsShowSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotDpsShowSettings AddIds(this AzureIotDpsShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureIotDpsShowSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotDpsShowSettings AddIds(this AzureIotDpsShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureIotDpsShowSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotDpsShowSettings ClearIds(this AzureIotDpsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureIotDpsShowSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotDpsShowSettings RemoveIds(this AzureIotDpsShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureIotDpsShowSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotDpsShowSettings RemoveIds(this AzureIotDpsShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
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
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureIotDpsShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotDpsShowSettings SetSubscription(this AzureIotDpsShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotDpsShowSettings ResetSubscription(this AzureIotDpsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
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
        public static AzureIotDpsShowSettings SetOutput(this AzureIotDpsShowSettings toolSettings, AzureOutput output)
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
        /// <summary><p><em>Sets <see cref="AzureIotDpsShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDpsShowSettings SetQuery(this AzureIotDpsShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
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
        #region Ids
        /// <summary><p><em>Sets <see cref="AzureIotDpsUpdateSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotDpsUpdateSettings SetIds(this AzureIotDpsUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureIotDpsUpdateSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotDpsUpdateSettings SetIds(this AzureIotDpsUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureIotDpsUpdateSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotDpsUpdateSettings AddIds(this AzureIotDpsUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureIotDpsUpdateSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotDpsUpdateSettings AddIds(this AzureIotDpsUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureIotDpsUpdateSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotDpsUpdateSettings ClearIds(this AzureIotDpsUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureIotDpsUpdateSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotDpsUpdateSettings RemoveIds(this AzureIotDpsUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureIotDpsUpdateSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotDpsUpdateSettings RemoveIds(this AzureIotDpsUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
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
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureIotDpsUpdateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotDpsUpdateSettings SetSubscription(this AzureIotDpsUpdateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsUpdateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotDpsUpdateSettings ResetSubscription(this AzureIotDpsUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
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
        #region ForceString
        /// <summary><p><em>Sets <see cref="AzureIotDpsUpdateSettings.ForceString"/>.</em></p><p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p></summary>
        [Pure]
        public static AzureIotDpsUpdateSettings SetForceString(this AzureIotDpsUpdateSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsUpdateSettings.ForceString"/>.</em></p><p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p></summary>
        [Pure]
        public static AzureIotDpsUpdateSettings ResetForceString(this AzureIotDpsUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
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
        public static AzureIotDpsUpdateSettings SetOutput(this AzureIotDpsUpdateSettings toolSettings, AzureOutput output)
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
        /// <summary><p><em>Sets <see cref="AzureIotDpsUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDpsUpdateSettings SetQuery(this AzureIotDpsUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
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
    #region AzureIotHubRouteCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIotHubRouteCreateSettingsExtensions
    {
        #region En
        /// <summary><p><em>Sets <see cref="AzureIotHubRouteCreateSettings.En"/>.</em></p><p>Name of the routing endpoint.</p></summary>
        [Pure]
        public static AzureIotHubRouteCreateSettings SetEn(this AzureIotHubRouteCreateSettings toolSettings, string en)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.En = en;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRouteCreateSettings.En"/>.</em></p><p>Name of the routing endpoint.</p></summary>
        [Pure]
        public static AzureIotHubRouteCreateSettings ResetEn(this AzureIotHubRouteCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.En = null;
            return toolSettings;
        }
        #endregion
        #region HubName
        /// <summary><p><em>Sets <see cref="AzureIotHubRouteCreateSettings.HubName"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotHubRouteCreateSettings SetHubName(this AzureIotHubRouteCreateSettings toolSettings, string hubName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HubName = hubName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRouteCreateSettings.HubName"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotHubRouteCreateSettings ResetHubName(this AzureIotHubRouteCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HubName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureIotHubRouteCreateSettings.Name"/>.</em></p><p>Name of the Route.</p></summary>
        [Pure]
        public static AzureIotHubRouteCreateSettings SetName(this AzureIotHubRouteCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRouteCreateSettings.Name"/>.</em></p><p>Name of the Route.</p></summary>
        [Pure]
        public static AzureIotHubRouteCreateSettings ResetName(this AzureIotHubRouteCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Source
        /// <summary><p><em>Sets <see cref="AzureIotHubRouteCreateSettings.Source"/>.</em></p><p>Source of the route.</p></summary>
        [Pure]
        public static AzureIotHubRouteCreateSettings SetSource(this AzureIotHubRouteCreateSettings toolSettings, IotHubRouteSource source)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Source = source;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRouteCreateSettings.Source"/>.</em></p><p>Source of the route.</p></summary>
        [Pure]
        public static AzureIotHubRouteCreateSettings ResetSource(this AzureIotHubRouteCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Source = null;
            return toolSettings;
        }
        #endregion
        #region Condition
        /// <summary><p><em>Sets <see cref="AzureIotHubRouteCreateSettings.Condition"/>.</em></p><p>Condition that is evaluated to apply the routing rule.</p></summary>
        [Pure]
        public static AzureIotHubRouteCreateSettings SetCondition(this AzureIotHubRouteCreateSettings toolSettings, string condition)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Condition = condition;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRouteCreateSettings.Condition"/>.</em></p><p>Condition that is evaluated to apply the routing rule.</p></summary>
        [Pure]
        public static AzureIotHubRouteCreateSettings ResetCondition(this AzureIotHubRouteCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Condition = null;
            return toolSettings;
        }
        #endregion
        #region Enabled
        /// <summary><p><em>Sets <see cref="AzureIotHubRouteCreateSettings.Enabled"/>.</em></p><p>A boolean indicating whether to enable route to the Iot hub.</p></summary>
        [Pure]
        public static AzureIotHubRouteCreateSettings SetEnabled(this AzureIotHubRouteCreateSettings toolSettings, bool? enabled)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Enabled = enabled;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRouteCreateSettings.Enabled"/>.</em></p><p>A boolean indicating whether to enable route to the Iot hub.</p></summary>
        [Pure]
        public static AzureIotHubRouteCreateSettings ResetEnabled(this AzureIotHubRouteCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Enabled = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureIotHubRouteCreateSettings.Enabled"/>.</em></p><p>A boolean indicating whether to enable route to the Iot hub.</p></summary>
        [Pure]
        public static AzureIotHubRouteCreateSettings EnableEnabled(this AzureIotHubRouteCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Enabled = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureIotHubRouteCreateSettings.Enabled"/>.</em></p><p>A boolean indicating whether to enable route to the Iot hub.</p></summary>
        [Pure]
        public static AzureIotHubRouteCreateSettings DisableEnabled(this AzureIotHubRouteCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Enabled = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureIotHubRouteCreateSettings.Enabled"/>.</em></p><p>A boolean indicating whether to enable route to the Iot hub.</p></summary>
        [Pure]
        public static AzureIotHubRouteCreateSettings ToggleEnabled(this AzureIotHubRouteCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Enabled = !toolSettings.Enabled;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureIotHubRouteCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotHubRouteCreateSettings SetResourceGroup(this AzureIotHubRouteCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRouteCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotHubRouteCreateSettings ResetResourceGroup(this AzureIotHubRouteCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureIotHubRouteCreateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotHubRouteCreateSettings SetSubscription(this AzureIotHubRouteCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRouteCreateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotHubRouteCreateSettings ResetSubscription(this AzureIotHubRouteCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureIotHubRouteCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotHubRouteCreateSettings SetDebug(this AzureIotHubRouteCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRouteCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotHubRouteCreateSettings ResetDebug(this AzureIotHubRouteCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureIotHubRouteCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotHubRouteCreateSettings SetHelp(this AzureIotHubRouteCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRouteCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotHubRouteCreateSettings ResetHelp(this AzureIotHubRouteCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureIotHubRouteCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotHubRouteCreateSettings SetOutput(this AzureIotHubRouteCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRouteCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotHubRouteCreateSettings ResetOutput(this AzureIotHubRouteCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureIotHubRouteCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubRouteCreateSettings SetQuery(this AzureIotHubRouteCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRouteCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubRouteCreateSettings ResetQuery(this AzureIotHubRouteCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureIotHubRouteCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotHubRouteCreateSettings SetVerbose(this AzureIotHubRouteCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRouteCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotHubRouteCreateSettings ResetVerbose(this AzureIotHubRouteCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureIotHubRouteDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIotHubRouteDeleteSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureIotHubRouteDeleteSettings.Name"/>.</em></p><p>Name of the Route.</p></summary>
        [Pure]
        public static AzureIotHubRouteDeleteSettings SetName(this AzureIotHubRouteDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRouteDeleteSettings.Name"/>.</em></p><p>Name of the Route.</p></summary>
        [Pure]
        public static AzureIotHubRouteDeleteSettings ResetName(this AzureIotHubRouteDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Source
        /// <summary><p><em>Sets <see cref="AzureIotHubRouteDeleteSettings.Source"/>.</em></p><p>Source of the route.</p></summary>
        [Pure]
        public static AzureIotHubRouteDeleteSettings SetSource(this AzureIotHubRouteDeleteSettings toolSettings, IotHubRouteSource source)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Source = source;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRouteDeleteSettings.Source"/>.</em></p><p>Source of the route.</p></summary>
        [Pure]
        public static AzureIotHubRouteDeleteSettings ResetSource(this AzureIotHubRouteDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Source = null;
            return toolSettings;
        }
        #endregion
        #region HubName
        /// <summary><p><em>Sets <see cref="AzureIotHubRouteDeleteSettings.HubName"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotHubRouteDeleteSettings SetHubName(this AzureIotHubRouteDeleteSettings toolSettings, string hubName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HubName = hubName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRouteDeleteSettings.HubName"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotHubRouteDeleteSettings ResetHubName(this AzureIotHubRouteDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HubName = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary><p><em>Sets <see cref="AzureIotHubRouteDeleteSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubRouteDeleteSettings SetIds(this AzureIotHubRouteDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureIotHubRouteDeleteSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubRouteDeleteSettings SetIds(this AzureIotHubRouteDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureIotHubRouteDeleteSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubRouteDeleteSettings AddIds(this AzureIotHubRouteDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureIotHubRouteDeleteSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubRouteDeleteSettings AddIds(this AzureIotHubRouteDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureIotHubRouteDeleteSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubRouteDeleteSettings ClearIds(this AzureIotHubRouteDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureIotHubRouteDeleteSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubRouteDeleteSettings RemoveIds(this AzureIotHubRouteDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureIotHubRouteDeleteSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubRouteDeleteSettings RemoveIds(this AzureIotHubRouteDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureIotHubRouteDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotHubRouteDeleteSettings SetResourceGroup(this AzureIotHubRouteDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRouteDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotHubRouteDeleteSettings ResetResourceGroup(this AzureIotHubRouteDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureIotHubRouteDeleteSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotHubRouteDeleteSettings SetSubscription(this AzureIotHubRouteDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRouteDeleteSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotHubRouteDeleteSettings ResetSubscription(this AzureIotHubRouteDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureIotHubRouteDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotHubRouteDeleteSettings SetDebug(this AzureIotHubRouteDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRouteDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotHubRouteDeleteSettings ResetDebug(this AzureIotHubRouteDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureIotHubRouteDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotHubRouteDeleteSettings SetHelp(this AzureIotHubRouteDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRouteDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotHubRouteDeleteSettings ResetHelp(this AzureIotHubRouteDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureIotHubRouteDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotHubRouteDeleteSettings SetOutput(this AzureIotHubRouteDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRouteDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotHubRouteDeleteSettings ResetOutput(this AzureIotHubRouteDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureIotHubRouteDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubRouteDeleteSettings SetQuery(this AzureIotHubRouteDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRouteDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubRouteDeleteSettings ResetQuery(this AzureIotHubRouteDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureIotHubRouteDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotHubRouteDeleteSettings SetVerbose(this AzureIotHubRouteDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRouteDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotHubRouteDeleteSettings ResetVerbose(this AzureIotHubRouteDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureIotHubRouteListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIotHubRouteListSettingsExtensions
    {
        #region Source
        /// <summary><p><em>Sets <see cref="AzureIotHubRouteListSettings.Source"/>.</em></p><p>Source of the route.</p></summary>
        [Pure]
        public static AzureIotHubRouteListSettings SetSource(this AzureIotHubRouteListSettings toolSettings, IotHubRouteSource source)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Source = source;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRouteListSettings.Source"/>.</em></p><p>Source of the route.</p></summary>
        [Pure]
        public static AzureIotHubRouteListSettings ResetSource(this AzureIotHubRouteListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Source = null;
            return toolSettings;
        }
        #endregion
        #region HubName
        /// <summary><p><em>Sets <see cref="AzureIotHubRouteListSettings.HubName"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotHubRouteListSettings SetHubName(this AzureIotHubRouteListSettings toolSettings, string hubName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HubName = hubName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRouteListSettings.HubName"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotHubRouteListSettings ResetHubName(this AzureIotHubRouteListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HubName = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary><p><em>Sets <see cref="AzureIotHubRouteListSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubRouteListSettings SetIds(this AzureIotHubRouteListSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureIotHubRouteListSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubRouteListSettings SetIds(this AzureIotHubRouteListSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureIotHubRouteListSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubRouteListSettings AddIds(this AzureIotHubRouteListSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureIotHubRouteListSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubRouteListSettings AddIds(this AzureIotHubRouteListSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureIotHubRouteListSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubRouteListSettings ClearIds(this AzureIotHubRouteListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureIotHubRouteListSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubRouteListSettings RemoveIds(this AzureIotHubRouteListSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureIotHubRouteListSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubRouteListSettings RemoveIds(this AzureIotHubRouteListSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureIotHubRouteListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotHubRouteListSettings SetResourceGroup(this AzureIotHubRouteListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRouteListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotHubRouteListSettings ResetResourceGroup(this AzureIotHubRouteListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureIotHubRouteListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotHubRouteListSettings SetSubscription(this AzureIotHubRouteListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRouteListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotHubRouteListSettings ResetSubscription(this AzureIotHubRouteListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureIotHubRouteListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotHubRouteListSettings SetDebug(this AzureIotHubRouteListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRouteListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotHubRouteListSettings ResetDebug(this AzureIotHubRouteListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureIotHubRouteListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotHubRouteListSettings SetHelp(this AzureIotHubRouteListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRouteListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotHubRouteListSettings ResetHelp(this AzureIotHubRouteListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureIotHubRouteListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotHubRouteListSettings SetOutput(this AzureIotHubRouteListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRouteListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotHubRouteListSettings ResetOutput(this AzureIotHubRouteListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureIotHubRouteListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubRouteListSettings SetQuery(this AzureIotHubRouteListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRouteListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubRouteListSettings ResetQuery(this AzureIotHubRouteListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureIotHubRouteListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotHubRouteListSettings SetVerbose(this AzureIotHubRouteListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRouteListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotHubRouteListSettings ResetVerbose(this AzureIotHubRouteListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureIotHubRouteShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIotHubRouteShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureIotHubRouteShowSettings.Name"/>.</em></p><p>Name of the Route.</p></summary>
        [Pure]
        public static AzureIotHubRouteShowSettings SetName(this AzureIotHubRouteShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRouteShowSettings.Name"/>.</em></p><p>Name of the Route.</p></summary>
        [Pure]
        public static AzureIotHubRouteShowSettings ResetName(this AzureIotHubRouteShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region HubName
        /// <summary><p><em>Sets <see cref="AzureIotHubRouteShowSettings.HubName"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotHubRouteShowSettings SetHubName(this AzureIotHubRouteShowSettings toolSettings, string hubName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HubName = hubName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRouteShowSettings.HubName"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotHubRouteShowSettings ResetHubName(this AzureIotHubRouteShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HubName = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary><p><em>Sets <see cref="AzureIotHubRouteShowSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubRouteShowSettings SetIds(this AzureIotHubRouteShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureIotHubRouteShowSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubRouteShowSettings SetIds(this AzureIotHubRouteShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureIotHubRouteShowSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubRouteShowSettings AddIds(this AzureIotHubRouteShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureIotHubRouteShowSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubRouteShowSettings AddIds(this AzureIotHubRouteShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureIotHubRouteShowSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubRouteShowSettings ClearIds(this AzureIotHubRouteShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureIotHubRouteShowSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubRouteShowSettings RemoveIds(this AzureIotHubRouteShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureIotHubRouteShowSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubRouteShowSettings RemoveIds(this AzureIotHubRouteShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureIotHubRouteShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotHubRouteShowSettings SetResourceGroup(this AzureIotHubRouteShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRouteShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotHubRouteShowSettings ResetResourceGroup(this AzureIotHubRouteShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureIotHubRouteShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotHubRouteShowSettings SetSubscription(this AzureIotHubRouteShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRouteShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotHubRouteShowSettings ResetSubscription(this AzureIotHubRouteShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureIotHubRouteShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotHubRouteShowSettings SetDebug(this AzureIotHubRouteShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRouteShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotHubRouteShowSettings ResetDebug(this AzureIotHubRouteShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureIotHubRouteShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotHubRouteShowSettings SetHelp(this AzureIotHubRouteShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRouteShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotHubRouteShowSettings ResetHelp(this AzureIotHubRouteShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureIotHubRouteShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotHubRouteShowSettings SetOutput(this AzureIotHubRouteShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRouteShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotHubRouteShowSettings ResetOutput(this AzureIotHubRouteShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureIotHubRouteShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubRouteShowSettings SetQuery(this AzureIotHubRouteShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRouteShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubRouteShowSettings ResetQuery(this AzureIotHubRouteShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureIotHubRouteShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotHubRouteShowSettings SetVerbose(this AzureIotHubRouteShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRouteShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotHubRouteShowSettings ResetVerbose(this AzureIotHubRouteShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureIotHubRouteTestSettingsExtensions
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIotHubRouteTestSettingsExtensions
    {
        #region Ap
        /// <summary><p><em>Sets <see cref="AzureIotHubRouteTestSettings.Ap"/>.</em></p><p>App properties of the route message.</p></summary>
        [Pure]
        public static AzureIotHubRouteTestSettings SetAp(this AzureIotHubRouteTestSettings toolSettings, string ap)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Ap = ap;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRouteTestSettings.Ap"/>.</em></p><p>App properties of the route message.</p></summary>
        [Pure]
        public static AzureIotHubRouteTestSettings ResetAp(this AzureIotHubRouteTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Ap = null;
            return toolSettings;
        }
        #endregion
        #region Body
        /// <summary><p><em>Sets <see cref="AzureIotHubRouteTestSettings.Body"/>.</em></p><p>Body of the route message.</p></summary>
        [Pure]
        public static AzureIotHubRouteTestSettings SetBody(this AzureIotHubRouteTestSettings toolSettings, string body)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Body = body;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRouteTestSettings.Body"/>.</em></p><p>Body of the route message.</p></summary>
        [Pure]
        public static AzureIotHubRouteTestSettings ResetBody(this AzureIotHubRouteTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Body = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureIotHubRouteTestSettings.Name"/>.</em></p><p>Name of the Route.</p></summary>
        [Pure]
        public static AzureIotHubRouteTestSettings SetName(this AzureIotHubRouteTestSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRouteTestSettings.Name"/>.</em></p><p>Name of the Route.</p></summary>
        [Pure]
        public static AzureIotHubRouteTestSettings ResetName(this AzureIotHubRouteTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Source
        /// <summary><p><em>Sets <see cref="AzureIotHubRouteTestSettings.Source"/>.</em></p><p>Source of the route.</p></summary>
        [Pure]
        public static AzureIotHubRouteTestSettings SetSource(this AzureIotHubRouteTestSettings toolSettings, IotHubRouteSource source)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Source = source;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRouteTestSettings.Source"/>.</em></p><p>Source of the route.</p></summary>
        [Pure]
        public static AzureIotHubRouteTestSettings ResetSource(this AzureIotHubRouteTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Source = null;
            return toolSettings;
        }
        #endregion
        #region Sp
        /// <summary><p><em>Sets <see cref="AzureIotHubRouteTestSettings.Sp"/>.</em></p><p>System properties of the route message.</p></summary>
        [Pure]
        public static AzureIotHubRouteTestSettings SetSp(this AzureIotHubRouteTestSettings toolSettings, string sp)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sp = sp;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRouteTestSettings.Sp"/>.</em></p><p>System properties of the route message.</p></summary>
        [Pure]
        public static AzureIotHubRouteTestSettings ResetSp(this AzureIotHubRouteTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sp = null;
            return toolSettings;
        }
        #endregion
        #region HubName
        /// <summary><p><em>Sets <see cref="AzureIotHubRouteTestSettings.HubName"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotHubRouteTestSettings SetHubName(this AzureIotHubRouteTestSettings toolSettings, string hubName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HubName = hubName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRouteTestSettings.HubName"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotHubRouteTestSettings ResetHubName(this AzureIotHubRouteTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HubName = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary><p><em>Sets <see cref="AzureIotHubRouteTestSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubRouteTestSettings SetIds(this AzureIotHubRouteTestSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureIotHubRouteTestSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubRouteTestSettings SetIds(this AzureIotHubRouteTestSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureIotHubRouteTestSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubRouteTestSettings AddIds(this AzureIotHubRouteTestSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureIotHubRouteTestSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubRouteTestSettings AddIds(this AzureIotHubRouteTestSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureIotHubRouteTestSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubRouteTestSettings ClearIds(this AzureIotHubRouteTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureIotHubRouteTestSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubRouteTestSettings RemoveIds(this AzureIotHubRouteTestSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureIotHubRouteTestSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubRouteTestSettings RemoveIds(this AzureIotHubRouteTestSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureIotHubRouteTestSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotHubRouteTestSettings SetResourceGroup(this AzureIotHubRouteTestSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRouteTestSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotHubRouteTestSettings ResetResourceGroup(this AzureIotHubRouteTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureIotHubRouteTestSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotHubRouteTestSettings SetSubscription(this AzureIotHubRouteTestSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRouteTestSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotHubRouteTestSettings ResetSubscription(this AzureIotHubRouteTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureIotHubRouteTestSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotHubRouteTestSettings SetDebug(this AzureIotHubRouteTestSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRouteTestSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotHubRouteTestSettings ResetDebug(this AzureIotHubRouteTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureIotHubRouteTestSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotHubRouteTestSettings SetHelp(this AzureIotHubRouteTestSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRouteTestSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotHubRouteTestSettings ResetHelp(this AzureIotHubRouteTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureIotHubRouteTestSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotHubRouteTestSettings SetOutput(this AzureIotHubRouteTestSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRouteTestSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotHubRouteTestSettings ResetOutput(this AzureIotHubRouteTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureIotHubRouteTestSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubRouteTestSettings SetQuery(this AzureIotHubRouteTestSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRouteTestSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubRouteTestSettings ResetQuery(this AzureIotHubRouteTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureIotHubRouteTestSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotHubRouteTestSettings SetVerbose(this AzureIotHubRouteTestSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRouteTestSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotHubRouteTestSettings ResetVerbose(this AzureIotHubRouteTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureIotHubRouteUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIotHubRouteUpdateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureIotHubRouteUpdateSettings.Name"/>.</em></p><p>Name of the Route.</p></summary>
        [Pure]
        public static AzureIotHubRouteUpdateSettings SetName(this AzureIotHubRouteUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRouteUpdateSettings.Name"/>.</em></p><p>Name of the Route.</p></summary>
        [Pure]
        public static AzureIotHubRouteUpdateSettings ResetName(this AzureIotHubRouteUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Condition
        /// <summary><p><em>Sets <see cref="AzureIotHubRouteUpdateSettings.Condition"/>.</em></p><p>Condition that is evaluated to apply the routing rule.</p></summary>
        [Pure]
        public static AzureIotHubRouteUpdateSettings SetCondition(this AzureIotHubRouteUpdateSettings toolSettings, string condition)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Condition = condition;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRouteUpdateSettings.Condition"/>.</em></p><p>Condition that is evaluated to apply the routing rule.</p></summary>
        [Pure]
        public static AzureIotHubRouteUpdateSettings ResetCondition(this AzureIotHubRouteUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Condition = null;
            return toolSettings;
        }
        #endregion
        #region En
        /// <summary><p><em>Sets <see cref="AzureIotHubRouteUpdateSettings.En"/>.</em></p><p>Name of the routing endpoint.</p></summary>
        [Pure]
        public static AzureIotHubRouteUpdateSettings SetEn(this AzureIotHubRouteUpdateSettings toolSettings, string en)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.En = en;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRouteUpdateSettings.En"/>.</em></p><p>Name of the routing endpoint.</p></summary>
        [Pure]
        public static AzureIotHubRouteUpdateSettings ResetEn(this AzureIotHubRouteUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.En = null;
            return toolSettings;
        }
        #endregion
        #region Enabled
        /// <summary><p><em>Sets <see cref="AzureIotHubRouteUpdateSettings.Enabled"/>.</em></p><p>A boolean indicating whether to enable route to the Iot hub.</p></summary>
        [Pure]
        public static AzureIotHubRouteUpdateSettings SetEnabled(this AzureIotHubRouteUpdateSettings toolSettings, bool? enabled)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Enabled = enabled;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRouteUpdateSettings.Enabled"/>.</em></p><p>A boolean indicating whether to enable route to the Iot hub.</p></summary>
        [Pure]
        public static AzureIotHubRouteUpdateSettings ResetEnabled(this AzureIotHubRouteUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Enabled = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureIotHubRouteUpdateSettings.Enabled"/>.</em></p><p>A boolean indicating whether to enable route to the Iot hub.</p></summary>
        [Pure]
        public static AzureIotHubRouteUpdateSettings EnableEnabled(this AzureIotHubRouteUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Enabled = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureIotHubRouteUpdateSettings.Enabled"/>.</em></p><p>A boolean indicating whether to enable route to the Iot hub.</p></summary>
        [Pure]
        public static AzureIotHubRouteUpdateSettings DisableEnabled(this AzureIotHubRouteUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Enabled = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureIotHubRouteUpdateSettings.Enabled"/>.</em></p><p>A boolean indicating whether to enable route to the Iot hub.</p></summary>
        [Pure]
        public static AzureIotHubRouteUpdateSettings ToggleEnabled(this AzureIotHubRouteUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Enabled = !toolSettings.Enabled;
            return toolSettings;
        }
        #endregion
        #region Source
        /// <summary><p><em>Sets <see cref="AzureIotHubRouteUpdateSettings.Source"/>.</em></p><p>Source of the route.</p></summary>
        [Pure]
        public static AzureIotHubRouteUpdateSettings SetSource(this AzureIotHubRouteUpdateSettings toolSettings, IotHubRouteSource source)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Source = source;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRouteUpdateSettings.Source"/>.</em></p><p>Source of the route.</p></summary>
        [Pure]
        public static AzureIotHubRouteUpdateSettings ResetSource(this AzureIotHubRouteUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Source = null;
            return toolSettings;
        }
        #endregion
        #region HubName
        /// <summary><p><em>Sets <see cref="AzureIotHubRouteUpdateSettings.HubName"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotHubRouteUpdateSettings SetHubName(this AzureIotHubRouteUpdateSettings toolSettings, string hubName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HubName = hubName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRouteUpdateSettings.HubName"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotHubRouteUpdateSettings ResetHubName(this AzureIotHubRouteUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HubName = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary><p><em>Sets <see cref="AzureIotHubRouteUpdateSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubRouteUpdateSettings SetIds(this AzureIotHubRouteUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureIotHubRouteUpdateSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubRouteUpdateSettings SetIds(this AzureIotHubRouteUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureIotHubRouteUpdateSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubRouteUpdateSettings AddIds(this AzureIotHubRouteUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureIotHubRouteUpdateSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubRouteUpdateSettings AddIds(this AzureIotHubRouteUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureIotHubRouteUpdateSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubRouteUpdateSettings ClearIds(this AzureIotHubRouteUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureIotHubRouteUpdateSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubRouteUpdateSettings RemoveIds(this AzureIotHubRouteUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureIotHubRouteUpdateSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubRouteUpdateSettings RemoveIds(this AzureIotHubRouteUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureIotHubRouteUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotHubRouteUpdateSettings SetResourceGroup(this AzureIotHubRouteUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRouteUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotHubRouteUpdateSettings ResetResourceGroup(this AzureIotHubRouteUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureIotHubRouteUpdateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotHubRouteUpdateSettings SetSubscription(this AzureIotHubRouteUpdateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRouteUpdateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotHubRouteUpdateSettings ResetSubscription(this AzureIotHubRouteUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureIotHubRouteUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotHubRouteUpdateSettings SetDebug(this AzureIotHubRouteUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRouteUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotHubRouteUpdateSettings ResetDebug(this AzureIotHubRouteUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureIotHubRouteUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotHubRouteUpdateSettings SetHelp(this AzureIotHubRouteUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRouteUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotHubRouteUpdateSettings ResetHelp(this AzureIotHubRouteUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureIotHubRouteUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotHubRouteUpdateSettings SetOutput(this AzureIotHubRouteUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRouteUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotHubRouteUpdateSettings ResetOutput(this AzureIotHubRouteUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureIotHubRouteUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubRouteUpdateSettings SetQuery(this AzureIotHubRouteUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRouteUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubRouteUpdateSettings ResetQuery(this AzureIotHubRouteUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureIotHubRouteUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotHubRouteUpdateSettings SetVerbose(this AzureIotHubRouteUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRouteUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotHubRouteUpdateSettings ResetVerbose(this AzureIotHubRouteUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureIotHubRoutingEndpointCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIotHubRoutingEndpointCreateSettingsExtensions
    {
        #region ConnectionString
        /// <summary><p><em>Sets <see cref="AzureIotHubRoutingEndpointCreateSettings.ConnectionString"/>.</em></p><p>Connection string of the Routing Endpoint.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointCreateSettings SetConnectionString(this AzureIotHubRoutingEndpointCreateSettings toolSettings, string connectionString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ConnectionString = connectionString;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRoutingEndpointCreateSettings.ConnectionString"/>.</em></p><p>Connection string of the Routing Endpoint.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointCreateSettings ResetConnectionString(this AzureIotHubRoutingEndpointCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ConnectionString = null;
            return toolSettings;
        }
        #endregion
        #region EndpointName
        /// <summary><p><em>Sets <see cref="AzureIotHubRoutingEndpointCreateSettings.EndpointName"/>.</em></p><p>Name of the Routing Endpoint.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointCreateSettings SetEndpointName(this AzureIotHubRoutingEndpointCreateSettings toolSettings, string endpointName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndpointName = endpointName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRoutingEndpointCreateSettings.EndpointName"/>.</em></p><p>Name of the Routing Endpoint.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointCreateSettings ResetEndpointName(this AzureIotHubRoutingEndpointCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndpointName = null;
            return toolSettings;
        }
        #endregion
        #region EndpointResourceGroup
        /// <summary><p><em>Sets <see cref="AzureIotHubRoutingEndpointCreateSettings.EndpointResourceGroup"/>.</em></p><p>Resource group of the Endpoint resoure.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointCreateSettings SetEndpointResourceGroup(this AzureIotHubRoutingEndpointCreateSettings toolSettings, string endpointResourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndpointResourceGroup = endpointResourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRoutingEndpointCreateSettings.EndpointResourceGroup"/>.</em></p><p>Resource group of the Endpoint resoure.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointCreateSettings ResetEndpointResourceGroup(this AzureIotHubRoutingEndpointCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndpointResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region EndpointSubscriptionId
        /// <summary><p><em>Sets <see cref="AzureIotHubRoutingEndpointCreateSettings.EndpointSubscriptionId"/>.</em></p><p>SubscriptionId of the Endpoint resource.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointCreateSettings SetEndpointSubscriptionId(this AzureIotHubRoutingEndpointCreateSettings toolSettings, string endpointSubscriptionId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndpointSubscriptionId = endpointSubscriptionId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRoutingEndpointCreateSettings.EndpointSubscriptionId"/>.</em></p><p>SubscriptionId of the Endpoint resource.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointCreateSettings ResetEndpointSubscriptionId(this AzureIotHubRoutingEndpointCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndpointSubscriptionId = null;
            return toolSettings;
        }
        #endregion
        #region EndpointType
        /// <summary><p><em>Sets <see cref="AzureIotHubRoutingEndpointCreateSettings.EndpointType"/>.</em></p><p>Type of the Routing Endpoint.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointCreateSettings SetEndpointType(this AzureIotHubRoutingEndpointCreateSettings toolSettings, IotHubRoutingEndpointEndpointType endpointType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndpointType = endpointType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRoutingEndpointCreateSettings.EndpointType"/>.</em></p><p>Type of the Routing Endpoint.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointCreateSettings ResetEndpointType(this AzureIotHubRoutingEndpointCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndpointType = null;
            return toolSettings;
        }
        #endregion
        #region HubName
        /// <summary><p><em>Sets <see cref="AzureIotHubRoutingEndpointCreateSettings.HubName"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointCreateSettings SetHubName(this AzureIotHubRoutingEndpointCreateSettings toolSettings, string hubName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HubName = hubName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRoutingEndpointCreateSettings.HubName"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointCreateSettings ResetHubName(this AzureIotHubRoutingEndpointCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HubName = null;
            return toolSettings;
        }
        #endregion
        #region Container
        /// <summary><p><em>Sets <see cref="AzureIotHubRoutingEndpointCreateSettings.Container"/>.</em></p><p>Name of the storage container.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointCreateSettings SetContainer(this AzureIotHubRoutingEndpointCreateSettings toolSettings, string container)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Container = container;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRoutingEndpointCreateSettings.Container"/>.</em></p><p>Name of the storage container.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointCreateSettings ResetContainer(this AzureIotHubRoutingEndpointCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Container = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureIotHubRoutingEndpointCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointCreateSettings SetResourceGroup(this AzureIotHubRoutingEndpointCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRoutingEndpointCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointCreateSettings ResetResourceGroup(this AzureIotHubRoutingEndpointCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureIotHubRoutingEndpointCreateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointCreateSettings SetSubscription(this AzureIotHubRoutingEndpointCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRoutingEndpointCreateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointCreateSettings ResetSubscription(this AzureIotHubRoutingEndpointCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureIotHubRoutingEndpointCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointCreateSettings SetDebug(this AzureIotHubRoutingEndpointCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRoutingEndpointCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointCreateSettings ResetDebug(this AzureIotHubRoutingEndpointCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureIotHubRoutingEndpointCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointCreateSettings SetHelp(this AzureIotHubRoutingEndpointCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRoutingEndpointCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointCreateSettings ResetHelp(this AzureIotHubRoutingEndpointCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureIotHubRoutingEndpointCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointCreateSettings SetOutput(this AzureIotHubRoutingEndpointCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRoutingEndpointCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointCreateSettings ResetOutput(this AzureIotHubRoutingEndpointCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureIotHubRoutingEndpointCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointCreateSettings SetQuery(this AzureIotHubRoutingEndpointCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRoutingEndpointCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointCreateSettings ResetQuery(this AzureIotHubRoutingEndpointCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureIotHubRoutingEndpointCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointCreateSettings SetVerbose(this AzureIotHubRoutingEndpointCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRoutingEndpointCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointCreateSettings ResetVerbose(this AzureIotHubRoutingEndpointCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureIotHubRoutingEndpointDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIotHubRoutingEndpointDeleteSettingsExtensions
    {
        #region EndpointName
        /// <summary><p><em>Sets <see cref="AzureIotHubRoutingEndpointDeleteSettings.EndpointName"/>.</em></p><p>Name of the Routing Endpoint.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointDeleteSettings SetEndpointName(this AzureIotHubRoutingEndpointDeleteSettings toolSettings, string endpointName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndpointName = endpointName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRoutingEndpointDeleteSettings.EndpointName"/>.</em></p><p>Name of the Routing Endpoint.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointDeleteSettings ResetEndpointName(this AzureIotHubRoutingEndpointDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndpointName = null;
            return toolSettings;
        }
        #endregion
        #region EndpointType
        /// <summary><p><em>Sets <see cref="AzureIotHubRoutingEndpointDeleteSettings.EndpointType"/>.</em></p><p>Type of the Routing Endpoint.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointDeleteSettings SetEndpointType(this AzureIotHubRoutingEndpointDeleteSettings toolSettings, IotHubRoutingEndpointEndpointType endpointType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndpointType = endpointType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRoutingEndpointDeleteSettings.EndpointType"/>.</em></p><p>Type of the Routing Endpoint.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointDeleteSettings ResetEndpointType(this AzureIotHubRoutingEndpointDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndpointType = null;
            return toolSettings;
        }
        #endregion
        #region HubName
        /// <summary><p><em>Sets <see cref="AzureIotHubRoutingEndpointDeleteSettings.HubName"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointDeleteSettings SetHubName(this AzureIotHubRoutingEndpointDeleteSettings toolSettings, string hubName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HubName = hubName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRoutingEndpointDeleteSettings.HubName"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointDeleteSettings ResetHubName(this AzureIotHubRoutingEndpointDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HubName = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary><p><em>Sets <see cref="AzureIotHubRoutingEndpointDeleteSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointDeleteSettings SetIds(this AzureIotHubRoutingEndpointDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureIotHubRoutingEndpointDeleteSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointDeleteSettings SetIds(this AzureIotHubRoutingEndpointDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureIotHubRoutingEndpointDeleteSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointDeleteSettings AddIds(this AzureIotHubRoutingEndpointDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureIotHubRoutingEndpointDeleteSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointDeleteSettings AddIds(this AzureIotHubRoutingEndpointDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureIotHubRoutingEndpointDeleteSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointDeleteSettings ClearIds(this AzureIotHubRoutingEndpointDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureIotHubRoutingEndpointDeleteSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointDeleteSettings RemoveIds(this AzureIotHubRoutingEndpointDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureIotHubRoutingEndpointDeleteSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointDeleteSettings RemoveIds(this AzureIotHubRoutingEndpointDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureIotHubRoutingEndpointDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointDeleteSettings SetResourceGroup(this AzureIotHubRoutingEndpointDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRoutingEndpointDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointDeleteSettings ResetResourceGroup(this AzureIotHubRoutingEndpointDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureIotHubRoutingEndpointDeleteSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointDeleteSettings SetSubscription(this AzureIotHubRoutingEndpointDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRoutingEndpointDeleteSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointDeleteSettings ResetSubscription(this AzureIotHubRoutingEndpointDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureIotHubRoutingEndpointDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointDeleteSettings SetDebug(this AzureIotHubRoutingEndpointDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRoutingEndpointDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointDeleteSettings ResetDebug(this AzureIotHubRoutingEndpointDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureIotHubRoutingEndpointDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointDeleteSettings SetHelp(this AzureIotHubRoutingEndpointDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRoutingEndpointDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointDeleteSettings ResetHelp(this AzureIotHubRoutingEndpointDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureIotHubRoutingEndpointDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointDeleteSettings SetOutput(this AzureIotHubRoutingEndpointDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRoutingEndpointDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointDeleteSettings ResetOutput(this AzureIotHubRoutingEndpointDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureIotHubRoutingEndpointDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointDeleteSettings SetQuery(this AzureIotHubRoutingEndpointDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRoutingEndpointDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointDeleteSettings ResetQuery(this AzureIotHubRoutingEndpointDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureIotHubRoutingEndpointDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointDeleteSettings SetVerbose(this AzureIotHubRoutingEndpointDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRoutingEndpointDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointDeleteSettings ResetVerbose(this AzureIotHubRoutingEndpointDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureIotHubRoutingEndpointListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIotHubRoutingEndpointListSettingsExtensions
    {
        #region EndpointType
        /// <summary><p><em>Sets <see cref="AzureIotHubRoutingEndpointListSettings.EndpointType"/>.</em></p><p>Type of the Routing Endpoint.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointListSettings SetEndpointType(this AzureIotHubRoutingEndpointListSettings toolSettings, IotHubRoutingEndpointEndpointType endpointType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndpointType = endpointType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRoutingEndpointListSettings.EndpointType"/>.</em></p><p>Type of the Routing Endpoint.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointListSettings ResetEndpointType(this AzureIotHubRoutingEndpointListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndpointType = null;
            return toolSettings;
        }
        #endregion
        #region HubName
        /// <summary><p><em>Sets <see cref="AzureIotHubRoutingEndpointListSettings.HubName"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointListSettings SetHubName(this AzureIotHubRoutingEndpointListSettings toolSettings, string hubName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HubName = hubName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRoutingEndpointListSettings.HubName"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointListSettings ResetHubName(this AzureIotHubRoutingEndpointListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HubName = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary><p><em>Sets <see cref="AzureIotHubRoutingEndpointListSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointListSettings SetIds(this AzureIotHubRoutingEndpointListSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureIotHubRoutingEndpointListSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointListSettings SetIds(this AzureIotHubRoutingEndpointListSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureIotHubRoutingEndpointListSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointListSettings AddIds(this AzureIotHubRoutingEndpointListSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureIotHubRoutingEndpointListSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointListSettings AddIds(this AzureIotHubRoutingEndpointListSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureIotHubRoutingEndpointListSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointListSettings ClearIds(this AzureIotHubRoutingEndpointListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureIotHubRoutingEndpointListSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointListSettings RemoveIds(this AzureIotHubRoutingEndpointListSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureIotHubRoutingEndpointListSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointListSettings RemoveIds(this AzureIotHubRoutingEndpointListSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureIotHubRoutingEndpointListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointListSettings SetResourceGroup(this AzureIotHubRoutingEndpointListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRoutingEndpointListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointListSettings ResetResourceGroup(this AzureIotHubRoutingEndpointListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureIotHubRoutingEndpointListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointListSettings SetSubscription(this AzureIotHubRoutingEndpointListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRoutingEndpointListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointListSettings ResetSubscription(this AzureIotHubRoutingEndpointListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureIotHubRoutingEndpointListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointListSettings SetDebug(this AzureIotHubRoutingEndpointListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRoutingEndpointListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointListSettings ResetDebug(this AzureIotHubRoutingEndpointListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureIotHubRoutingEndpointListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointListSettings SetHelp(this AzureIotHubRoutingEndpointListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRoutingEndpointListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointListSettings ResetHelp(this AzureIotHubRoutingEndpointListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureIotHubRoutingEndpointListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointListSettings SetOutput(this AzureIotHubRoutingEndpointListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRoutingEndpointListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointListSettings ResetOutput(this AzureIotHubRoutingEndpointListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureIotHubRoutingEndpointListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointListSettings SetQuery(this AzureIotHubRoutingEndpointListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRoutingEndpointListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointListSettings ResetQuery(this AzureIotHubRoutingEndpointListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureIotHubRoutingEndpointListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointListSettings SetVerbose(this AzureIotHubRoutingEndpointListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRoutingEndpointListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointListSettings ResetVerbose(this AzureIotHubRoutingEndpointListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureIotHubRoutingEndpointShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIotHubRoutingEndpointShowSettingsExtensions
    {
        #region EndpointName
        /// <summary><p><em>Sets <see cref="AzureIotHubRoutingEndpointShowSettings.EndpointName"/>.</em></p><p>Name of the Routing Endpoint.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointShowSettings SetEndpointName(this AzureIotHubRoutingEndpointShowSettings toolSettings, string endpointName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndpointName = endpointName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRoutingEndpointShowSettings.EndpointName"/>.</em></p><p>Name of the Routing Endpoint.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointShowSettings ResetEndpointName(this AzureIotHubRoutingEndpointShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndpointName = null;
            return toolSettings;
        }
        #endregion
        #region HubName
        /// <summary><p><em>Sets <see cref="AzureIotHubRoutingEndpointShowSettings.HubName"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointShowSettings SetHubName(this AzureIotHubRoutingEndpointShowSettings toolSettings, string hubName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HubName = hubName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRoutingEndpointShowSettings.HubName"/>.</em></p><p>IoT Hub name.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointShowSettings ResetHubName(this AzureIotHubRoutingEndpointShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HubName = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary><p><em>Sets <see cref="AzureIotHubRoutingEndpointShowSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointShowSettings SetIds(this AzureIotHubRoutingEndpointShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureIotHubRoutingEndpointShowSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointShowSettings SetIds(this AzureIotHubRoutingEndpointShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureIotHubRoutingEndpointShowSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointShowSettings AddIds(this AzureIotHubRoutingEndpointShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureIotHubRoutingEndpointShowSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointShowSettings AddIds(this AzureIotHubRoutingEndpointShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureIotHubRoutingEndpointShowSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointShowSettings ClearIds(this AzureIotHubRoutingEndpointShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureIotHubRoutingEndpointShowSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointShowSettings RemoveIds(this AzureIotHubRoutingEndpointShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureIotHubRoutingEndpointShowSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointShowSettings RemoveIds(this AzureIotHubRoutingEndpointShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureIotHubRoutingEndpointShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointShowSettings SetResourceGroup(this AzureIotHubRoutingEndpointShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRoutingEndpointShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointShowSettings ResetResourceGroup(this AzureIotHubRoutingEndpointShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureIotHubRoutingEndpointShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointShowSettings SetSubscription(this AzureIotHubRoutingEndpointShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRoutingEndpointShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointShowSettings ResetSubscription(this AzureIotHubRoutingEndpointShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureIotHubRoutingEndpointShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointShowSettings SetDebug(this AzureIotHubRoutingEndpointShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRoutingEndpointShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointShowSettings ResetDebug(this AzureIotHubRoutingEndpointShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureIotHubRoutingEndpointShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointShowSettings SetHelp(this AzureIotHubRoutingEndpointShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRoutingEndpointShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointShowSettings ResetHelp(this AzureIotHubRoutingEndpointShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureIotHubRoutingEndpointShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointShowSettings SetOutput(this AzureIotHubRoutingEndpointShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRoutingEndpointShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointShowSettings ResetOutput(this AzureIotHubRoutingEndpointShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureIotHubRoutingEndpointShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointShowSettings SetQuery(this AzureIotHubRoutingEndpointShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRoutingEndpointShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointShowSettings ResetQuery(this AzureIotHubRoutingEndpointShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureIotHubRoutingEndpointShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointShowSettings SetVerbose(this AzureIotHubRoutingEndpointShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubRoutingEndpointShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureIotHubRoutingEndpointShowSettings ResetVerbose(this AzureIotHubRoutingEndpointShowSettings toolSettings)
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
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureIotHubPolicyCreateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotHubPolicyCreateSettings SetSubscription(this AzureIotHubPolicyCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubPolicyCreateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotHubPolicyCreateSettings ResetSubscription(this AzureIotHubPolicyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
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
        public static AzureIotHubPolicyCreateSettings SetOutput(this AzureIotHubPolicyCreateSettings toolSettings, AzureOutput output)
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
        /// <summary><p><em>Sets <see cref="AzureIotHubPolicyCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubPolicyCreateSettings SetQuery(this AzureIotHubPolicyCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubPolicyCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
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
        #region Ids
        /// <summary><p><em>Sets <see cref="AzureIotHubPolicyDeleteSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubPolicyDeleteSettings SetIds(this AzureIotHubPolicyDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureIotHubPolicyDeleteSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubPolicyDeleteSettings SetIds(this AzureIotHubPolicyDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureIotHubPolicyDeleteSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubPolicyDeleteSettings AddIds(this AzureIotHubPolicyDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureIotHubPolicyDeleteSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubPolicyDeleteSettings AddIds(this AzureIotHubPolicyDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureIotHubPolicyDeleteSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubPolicyDeleteSettings ClearIds(this AzureIotHubPolicyDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureIotHubPolicyDeleteSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubPolicyDeleteSettings RemoveIds(this AzureIotHubPolicyDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureIotHubPolicyDeleteSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubPolicyDeleteSettings RemoveIds(this AzureIotHubPolicyDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
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
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureIotHubPolicyDeleteSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotHubPolicyDeleteSettings SetSubscription(this AzureIotHubPolicyDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubPolicyDeleteSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotHubPolicyDeleteSettings ResetSubscription(this AzureIotHubPolicyDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
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
        public static AzureIotHubPolicyDeleteSettings SetOutput(this AzureIotHubPolicyDeleteSettings toolSettings, AzureOutput output)
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
        /// <summary><p><em>Sets <see cref="AzureIotHubPolicyDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubPolicyDeleteSettings SetQuery(this AzureIotHubPolicyDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubPolicyDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
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
        #region Ids
        /// <summary><p><em>Sets <see cref="AzureIotHubPolicyListSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubPolicyListSettings SetIds(this AzureIotHubPolicyListSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureIotHubPolicyListSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubPolicyListSettings SetIds(this AzureIotHubPolicyListSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureIotHubPolicyListSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubPolicyListSettings AddIds(this AzureIotHubPolicyListSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureIotHubPolicyListSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubPolicyListSettings AddIds(this AzureIotHubPolicyListSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureIotHubPolicyListSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubPolicyListSettings ClearIds(this AzureIotHubPolicyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureIotHubPolicyListSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubPolicyListSettings RemoveIds(this AzureIotHubPolicyListSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureIotHubPolicyListSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubPolicyListSettings RemoveIds(this AzureIotHubPolicyListSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
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
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureIotHubPolicyListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotHubPolicyListSettings SetSubscription(this AzureIotHubPolicyListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubPolicyListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotHubPolicyListSettings ResetSubscription(this AzureIotHubPolicyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
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
        public static AzureIotHubPolicyListSettings SetOutput(this AzureIotHubPolicyListSettings toolSettings, AzureOutput output)
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
        /// <summary><p><em>Sets <see cref="AzureIotHubPolicyListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubPolicyListSettings SetQuery(this AzureIotHubPolicyListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubPolicyListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
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
        #region Ids
        /// <summary><p><em>Sets <see cref="AzureIotHubPolicyShowSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubPolicyShowSettings SetIds(this AzureIotHubPolicyShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureIotHubPolicyShowSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubPolicyShowSettings SetIds(this AzureIotHubPolicyShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureIotHubPolicyShowSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubPolicyShowSettings AddIds(this AzureIotHubPolicyShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureIotHubPolicyShowSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubPolicyShowSettings AddIds(this AzureIotHubPolicyShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureIotHubPolicyShowSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubPolicyShowSettings ClearIds(this AzureIotHubPolicyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureIotHubPolicyShowSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubPolicyShowSettings RemoveIds(this AzureIotHubPolicyShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureIotHubPolicyShowSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubPolicyShowSettings RemoveIds(this AzureIotHubPolicyShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
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
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureIotHubPolicyShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotHubPolicyShowSettings SetSubscription(this AzureIotHubPolicyShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubPolicyShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotHubPolicyShowSettings ResetSubscription(this AzureIotHubPolicyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
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
        public static AzureIotHubPolicyShowSettings SetOutput(this AzureIotHubPolicyShowSettings toolSettings, AzureOutput output)
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
        /// <summary><p><em>Sets <see cref="AzureIotHubPolicyShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubPolicyShowSettings SetQuery(this AzureIotHubPolicyShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubPolicyShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
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
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateCreateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotHubCertificateCreateSettings SetSubscription(this AzureIotHubCertificateCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCertificateCreateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotHubCertificateCreateSettings ResetSubscription(this AzureIotHubCertificateCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
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
        public static AzureIotHubCertificateCreateSettings SetOutput(this AzureIotHubCertificateCreateSettings toolSettings, AzureOutput output)
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
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubCertificateCreateSettings SetQuery(this AzureIotHubCertificateCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCertificateCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
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
        #region Ids
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateDeleteSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubCertificateDeleteSettings SetIds(this AzureIotHubCertificateDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateDeleteSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubCertificateDeleteSettings SetIds(this AzureIotHubCertificateDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureIotHubCertificateDeleteSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubCertificateDeleteSettings AddIds(this AzureIotHubCertificateDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureIotHubCertificateDeleteSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubCertificateDeleteSettings AddIds(this AzureIotHubCertificateDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureIotHubCertificateDeleteSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubCertificateDeleteSettings ClearIds(this AzureIotHubCertificateDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureIotHubCertificateDeleteSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubCertificateDeleteSettings RemoveIds(this AzureIotHubCertificateDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureIotHubCertificateDeleteSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubCertificateDeleteSettings RemoveIds(this AzureIotHubCertificateDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
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
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateDeleteSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotHubCertificateDeleteSettings SetSubscription(this AzureIotHubCertificateDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCertificateDeleteSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotHubCertificateDeleteSettings ResetSubscription(this AzureIotHubCertificateDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
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
        public static AzureIotHubCertificateDeleteSettings SetOutput(this AzureIotHubCertificateDeleteSettings toolSettings, AzureOutput output)
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
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubCertificateDeleteSettings SetQuery(this AzureIotHubCertificateDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCertificateDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
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
        #region Ids
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateGenerateVerificationCodeSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubCertificateGenerateVerificationCodeSettings SetIds(this AzureIotHubCertificateGenerateVerificationCodeSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateGenerateVerificationCodeSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubCertificateGenerateVerificationCodeSettings SetIds(this AzureIotHubCertificateGenerateVerificationCodeSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureIotHubCertificateGenerateVerificationCodeSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubCertificateGenerateVerificationCodeSettings AddIds(this AzureIotHubCertificateGenerateVerificationCodeSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureIotHubCertificateGenerateVerificationCodeSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubCertificateGenerateVerificationCodeSettings AddIds(this AzureIotHubCertificateGenerateVerificationCodeSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureIotHubCertificateGenerateVerificationCodeSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubCertificateGenerateVerificationCodeSettings ClearIds(this AzureIotHubCertificateGenerateVerificationCodeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureIotHubCertificateGenerateVerificationCodeSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubCertificateGenerateVerificationCodeSettings RemoveIds(this AzureIotHubCertificateGenerateVerificationCodeSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureIotHubCertificateGenerateVerificationCodeSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubCertificateGenerateVerificationCodeSettings RemoveIds(this AzureIotHubCertificateGenerateVerificationCodeSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
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
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateGenerateVerificationCodeSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotHubCertificateGenerateVerificationCodeSettings SetSubscription(this AzureIotHubCertificateGenerateVerificationCodeSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCertificateGenerateVerificationCodeSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotHubCertificateGenerateVerificationCodeSettings ResetSubscription(this AzureIotHubCertificateGenerateVerificationCodeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
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
        public static AzureIotHubCertificateGenerateVerificationCodeSettings SetOutput(this AzureIotHubCertificateGenerateVerificationCodeSettings toolSettings, AzureOutput output)
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
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateGenerateVerificationCodeSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubCertificateGenerateVerificationCodeSettings SetQuery(this AzureIotHubCertificateGenerateVerificationCodeSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCertificateGenerateVerificationCodeSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
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
        #region Ids
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateListSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubCertificateListSettings SetIds(this AzureIotHubCertificateListSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateListSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubCertificateListSettings SetIds(this AzureIotHubCertificateListSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureIotHubCertificateListSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubCertificateListSettings AddIds(this AzureIotHubCertificateListSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureIotHubCertificateListSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubCertificateListSettings AddIds(this AzureIotHubCertificateListSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureIotHubCertificateListSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubCertificateListSettings ClearIds(this AzureIotHubCertificateListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureIotHubCertificateListSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubCertificateListSettings RemoveIds(this AzureIotHubCertificateListSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureIotHubCertificateListSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubCertificateListSettings RemoveIds(this AzureIotHubCertificateListSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
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
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotHubCertificateListSettings SetSubscription(this AzureIotHubCertificateListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCertificateListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotHubCertificateListSettings ResetSubscription(this AzureIotHubCertificateListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
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
        public static AzureIotHubCertificateListSettings SetOutput(this AzureIotHubCertificateListSettings toolSettings, AzureOutput output)
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
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubCertificateListSettings SetQuery(this AzureIotHubCertificateListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCertificateListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
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
        #region Ids
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateShowSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubCertificateShowSettings SetIds(this AzureIotHubCertificateShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateShowSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubCertificateShowSettings SetIds(this AzureIotHubCertificateShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureIotHubCertificateShowSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubCertificateShowSettings AddIds(this AzureIotHubCertificateShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureIotHubCertificateShowSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubCertificateShowSettings AddIds(this AzureIotHubCertificateShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureIotHubCertificateShowSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubCertificateShowSettings ClearIds(this AzureIotHubCertificateShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureIotHubCertificateShowSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubCertificateShowSettings RemoveIds(this AzureIotHubCertificateShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureIotHubCertificateShowSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubCertificateShowSettings RemoveIds(this AzureIotHubCertificateShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
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
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotHubCertificateShowSettings SetSubscription(this AzureIotHubCertificateShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCertificateShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotHubCertificateShowSettings ResetSubscription(this AzureIotHubCertificateShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
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
        public static AzureIotHubCertificateShowSettings SetOutput(this AzureIotHubCertificateShowSettings toolSettings, AzureOutput output)
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
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubCertificateShowSettings SetQuery(this AzureIotHubCertificateShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCertificateShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
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
        #region Ids
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateUpdateSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubCertificateUpdateSettings SetIds(this AzureIotHubCertificateUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateUpdateSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubCertificateUpdateSettings SetIds(this AzureIotHubCertificateUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureIotHubCertificateUpdateSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubCertificateUpdateSettings AddIds(this AzureIotHubCertificateUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureIotHubCertificateUpdateSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubCertificateUpdateSettings AddIds(this AzureIotHubCertificateUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureIotHubCertificateUpdateSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubCertificateUpdateSettings ClearIds(this AzureIotHubCertificateUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureIotHubCertificateUpdateSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubCertificateUpdateSettings RemoveIds(this AzureIotHubCertificateUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureIotHubCertificateUpdateSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubCertificateUpdateSettings RemoveIds(this AzureIotHubCertificateUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
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
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateUpdateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotHubCertificateUpdateSettings SetSubscription(this AzureIotHubCertificateUpdateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCertificateUpdateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotHubCertificateUpdateSettings ResetSubscription(this AzureIotHubCertificateUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
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
        public static AzureIotHubCertificateUpdateSettings SetOutput(this AzureIotHubCertificateUpdateSettings toolSettings, AzureOutput output)
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
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubCertificateUpdateSettings SetQuery(this AzureIotHubCertificateUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCertificateUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
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
        #region Ids
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateVerifySettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubCertificateVerifySettings SetIds(this AzureIotHubCertificateVerifySettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateVerifySettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubCertificateVerifySettings SetIds(this AzureIotHubCertificateVerifySettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureIotHubCertificateVerifySettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubCertificateVerifySettings AddIds(this AzureIotHubCertificateVerifySettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureIotHubCertificateVerifySettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubCertificateVerifySettings AddIds(this AzureIotHubCertificateVerifySettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureIotHubCertificateVerifySettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubCertificateVerifySettings ClearIds(this AzureIotHubCertificateVerifySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureIotHubCertificateVerifySettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubCertificateVerifySettings RemoveIds(this AzureIotHubCertificateVerifySettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureIotHubCertificateVerifySettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubCertificateVerifySettings RemoveIds(this AzureIotHubCertificateVerifySettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
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
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateVerifySettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotHubCertificateVerifySettings SetSubscription(this AzureIotHubCertificateVerifySettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCertificateVerifySettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotHubCertificateVerifySettings ResetSubscription(this AzureIotHubCertificateVerifySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
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
        public static AzureIotHubCertificateVerifySettings SetOutput(this AzureIotHubCertificateVerifySettings toolSettings, AzureOutput output)
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
        /// <summary><p><em>Sets <see cref="AzureIotHubCertificateVerifySettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubCertificateVerifySettings SetQuery(this AzureIotHubCertificateVerifySettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubCertificateVerifySettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
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
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureIotHubConsumerGroupCreateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupCreateSettings SetSubscription(this AzureIotHubConsumerGroupCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubConsumerGroupCreateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupCreateSettings ResetSubscription(this AzureIotHubConsumerGroupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
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
        public static AzureIotHubConsumerGroupCreateSettings SetOutput(this AzureIotHubConsumerGroupCreateSettings toolSettings, AzureOutput output)
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
        /// <summary><p><em>Sets <see cref="AzureIotHubConsumerGroupCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupCreateSettings SetQuery(this AzureIotHubConsumerGroupCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubConsumerGroupCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
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
        #region Ids
        /// <summary><p><em>Sets <see cref="AzureIotHubConsumerGroupDeleteSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupDeleteSettings SetIds(this AzureIotHubConsumerGroupDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureIotHubConsumerGroupDeleteSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupDeleteSettings SetIds(this AzureIotHubConsumerGroupDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureIotHubConsumerGroupDeleteSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupDeleteSettings AddIds(this AzureIotHubConsumerGroupDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureIotHubConsumerGroupDeleteSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupDeleteSettings AddIds(this AzureIotHubConsumerGroupDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureIotHubConsumerGroupDeleteSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupDeleteSettings ClearIds(this AzureIotHubConsumerGroupDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureIotHubConsumerGroupDeleteSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupDeleteSettings RemoveIds(this AzureIotHubConsumerGroupDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureIotHubConsumerGroupDeleteSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupDeleteSettings RemoveIds(this AzureIotHubConsumerGroupDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
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
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureIotHubConsumerGroupDeleteSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupDeleteSettings SetSubscription(this AzureIotHubConsumerGroupDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubConsumerGroupDeleteSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupDeleteSettings ResetSubscription(this AzureIotHubConsumerGroupDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
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
        public static AzureIotHubConsumerGroupDeleteSettings SetOutput(this AzureIotHubConsumerGroupDeleteSettings toolSettings, AzureOutput output)
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
        /// <summary><p><em>Sets <see cref="AzureIotHubConsumerGroupDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupDeleteSettings SetQuery(this AzureIotHubConsumerGroupDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubConsumerGroupDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
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
        #region Ids
        /// <summary><p><em>Sets <see cref="AzureIotHubConsumerGroupListSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupListSettings SetIds(this AzureIotHubConsumerGroupListSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureIotHubConsumerGroupListSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupListSettings SetIds(this AzureIotHubConsumerGroupListSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureIotHubConsumerGroupListSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupListSettings AddIds(this AzureIotHubConsumerGroupListSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureIotHubConsumerGroupListSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupListSettings AddIds(this AzureIotHubConsumerGroupListSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureIotHubConsumerGroupListSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupListSettings ClearIds(this AzureIotHubConsumerGroupListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureIotHubConsumerGroupListSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupListSettings RemoveIds(this AzureIotHubConsumerGroupListSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureIotHubConsumerGroupListSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupListSettings RemoveIds(this AzureIotHubConsumerGroupListSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
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
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureIotHubConsumerGroupListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupListSettings SetSubscription(this AzureIotHubConsumerGroupListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubConsumerGroupListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupListSettings ResetSubscription(this AzureIotHubConsumerGroupListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
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
        public static AzureIotHubConsumerGroupListSettings SetOutput(this AzureIotHubConsumerGroupListSettings toolSettings, AzureOutput output)
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
        /// <summary><p><em>Sets <see cref="AzureIotHubConsumerGroupListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupListSettings SetQuery(this AzureIotHubConsumerGroupListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubConsumerGroupListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
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
        #region Ids
        /// <summary><p><em>Sets <see cref="AzureIotHubConsumerGroupShowSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupShowSettings SetIds(this AzureIotHubConsumerGroupShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureIotHubConsumerGroupShowSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupShowSettings SetIds(this AzureIotHubConsumerGroupShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureIotHubConsumerGroupShowSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupShowSettings AddIds(this AzureIotHubConsumerGroupShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureIotHubConsumerGroupShowSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupShowSettings AddIds(this AzureIotHubConsumerGroupShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureIotHubConsumerGroupShowSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupShowSettings ClearIds(this AzureIotHubConsumerGroupShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureIotHubConsumerGroupShowSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupShowSettings RemoveIds(this AzureIotHubConsumerGroupShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureIotHubConsumerGroupShowSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupShowSettings RemoveIds(this AzureIotHubConsumerGroupShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
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
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureIotHubConsumerGroupShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupShowSettings SetSubscription(this AzureIotHubConsumerGroupShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubConsumerGroupShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupShowSettings ResetSubscription(this AzureIotHubConsumerGroupShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
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
        public static AzureIotHubConsumerGroupShowSettings SetOutput(this AzureIotHubConsumerGroupShowSettings toolSettings, AzureOutput output)
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
        /// <summary><p><em>Sets <see cref="AzureIotHubConsumerGroupShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubConsumerGroupShowSettings SetQuery(this AzureIotHubConsumerGroupShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubConsumerGroupShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
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
        #region Ids
        /// <summary><p><em>Sets <see cref="AzureIotHubJobCancelSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubJobCancelSettings SetIds(this AzureIotHubJobCancelSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureIotHubJobCancelSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubJobCancelSettings SetIds(this AzureIotHubJobCancelSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureIotHubJobCancelSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubJobCancelSettings AddIds(this AzureIotHubJobCancelSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureIotHubJobCancelSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubJobCancelSettings AddIds(this AzureIotHubJobCancelSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureIotHubJobCancelSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubJobCancelSettings ClearIds(this AzureIotHubJobCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureIotHubJobCancelSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubJobCancelSettings RemoveIds(this AzureIotHubJobCancelSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureIotHubJobCancelSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubJobCancelSettings RemoveIds(this AzureIotHubJobCancelSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
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
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureIotHubJobCancelSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotHubJobCancelSettings SetSubscription(this AzureIotHubJobCancelSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubJobCancelSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotHubJobCancelSettings ResetSubscription(this AzureIotHubJobCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
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
        public static AzureIotHubJobCancelSettings SetOutput(this AzureIotHubJobCancelSettings toolSettings, AzureOutput output)
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
        /// <summary><p><em>Sets <see cref="AzureIotHubJobCancelSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubJobCancelSettings SetQuery(this AzureIotHubJobCancelSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubJobCancelSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
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
        #region Ids
        /// <summary><p><em>Sets <see cref="AzureIotHubJobListSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubJobListSettings SetIds(this AzureIotHubJobListSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureIotHubJobListSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubJobListSettings SetIds(this AzureIotHubJobListSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureIotHubJobListSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubJobListSettings AddIds(this AzureIotHubJobListSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureIotHubJobListSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubJobListSettings AddIds(this AzureIotHubJobListSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureIotHubJobListSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubJobListSettings ClearIds(this AzureIotHubJobListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureIotHubJobListSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubJobListSettings RemoveIds(this AzureIotHubJobListSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureIotHubJobListSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubJobListSettings RemoveIds(this AzureIotHubJobListSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
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
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureIotHubJobListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotHubJobListSettings SetSubscription(this AzureIotHubJobListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubJobListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotHubJobListSettings ResetSubscription(this AzureIotHubJobListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
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
        public static AzureIotHubJobListSettings SetOutput(this AzureIotHubJobListSettings toolSettings, AzureOutput output)
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
        /// <summary><p><em>Sets <see cref="AzureIotHubJobListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubJobListSettings SetQuery(this AzureIotHubJobListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubJobListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
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
        #region Ids
        /// <summary><p><em>Sets <see cref="AzureIotHubJobShowSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubJobShowSettings SetIds(this AzureIotHubJobShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureIotHubJobShowSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubJobShowSettings SetIds(this AzureIotHubJobShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureIotHubJobShowSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubJobShowSettings AddIds(this AzureIotHubJobShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureIotHubJobShowSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubJobShowSettings AddIds(this AzureIotHubJobShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureIotHubJobShowSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubJobShowSettings ClearIds(this AzureIotHubJobShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureIotHubJobShowSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubJobShowSettings RemoveIds(this AzureIotHubJobShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureIotHubJobShowSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureIotHubJobShowSettings RemoveIds(this AzureIotHubJobShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
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
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureIotHubJobShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotHubJobShowSettings SetSubscription(this AzureIotHubJobShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubJobShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotHubJobShowSettings ResetSubscription(this AzureIotHubJobShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
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
        public static AzureIotHubJobShowSettings SetOutput(this AzureIotHubJobShowSettings toolSettings, AzureOutput output)
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
        /// <summary><p><em>Sets <see cref="AzureIotHubJobShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureIotHubJobShowSettings SetQuery(this AzureIotHubJobShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotHubJobShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
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
        public static AzureIotDpsAccessPolicyCreateSettings SetNoWait(this AzureIotDpsAccessPolicyCreateSettings toolSettings, bool? noWait)
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
        /// <summary><p><em>Enables <see cref="AzureIotDpsAccessPolicyCreateSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyCreateSettings EnableNoWait(this AzureIotDpsAccessPolicyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureIotDpsAccessPolicyCreateSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyCreateSettings DisableNoWait(this AzureIotDpsAccessPolicyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureIotDpsAccessPolicyCreateSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyCreateSettings ToggleNoWait(this AzureIotDpsAccessPolicyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
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
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureIotDpsAccessPolicyCreateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyCreateSettings SetSubscription(this AzureIotDpsAccessPolicyCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsAccessPolicyCreateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyCreateSettings ResetSubscription(this AzureIotDpsAccessPolicyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
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
        public static AzureIotDpsAccessPolicyCreateSettings SetOutput(this AzureIotDpsAccessPolicyCreateSettings toolSettings, AzureOutput output)
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
        /// <summary><p><em>Sets <see cref="AzureIotDpsAccessPolicyCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyCreateSettings SetQuery(this AzureIotDpsAccessPolicyCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsAccessPolicyCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
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
        public static AzureIotDpsAccessPolicyDeleteSettings SetNoWait(this AzureIotDpsAccessPolicyDeleteSettings toolSettings, bool? noWait)
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
        /// <summary><p><em>Enables <see cref="AzureIotDpsAccessPolicyDeleteSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyDeleteSettings EnableNoWait(this AzureIotDpsAccessPolicyDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureIotDpsAccessPolicyDeleteSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyDeleteSettings DisableNoWait(this AzureIotDpsAccessPolicyDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureIotDpsAccessPolicyDeleteSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyDeleteSettings ToggleNoWait(this AzureIotDpsAccessPolicyDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureIotDpsAccessPolicyDeleteSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyDeleteSettings SetSubscription(this AzureIotDpsAccessPolicyDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsAccessPolicyDeleteSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyDeleteSettings ResetSubscription(this AzureIotDpsAccessPolicyDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
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
        public static AzureIotDpsAccessPolicyDeleteSettings SetOutput(this AzureIotDpsAccessPolicyDeleteSettings toolSettings, AzureOutput output)
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
        /// <summary><p><em>Sets <see cref="AzureIotDpsAccessPolicyDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyDeleteSettings SetQuery(this AzureIotDpsAccessPolicyDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsAccessPolicyDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
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
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureIotDpsAccessPolicyListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyListSettings SetSubscription(this AzureIotDpsAccessPolicyListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsAccessPolicyListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyListSettings ResetSubscription(this AzureIotDpsAccessPolicyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
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
        public static AzureIotDpsAccessPolicyListSettings SetOutput(this AzureIotDpsAccessPolicyListSettings toolSettings, AzureOutput output)
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
        /// <summary><p><em>Sets <see cref="AzureIotDpsAccessPolicyListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyListSettings SetQuery(this AzureIotDpsAccessPolicyListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsAccessPolicyListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
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
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureIotDpsAccessPolicyShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyShowSettings SetSubscription(this AzureIotDpsAccessPolicyShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsAccessPolicyShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyShowSettings ResetSubscription(this AzureIotDpsAccessPolicyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
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
        public static AzureIotDpsAccessPolicyShowSettings SetOutput(this AzureIotDpsAccessPolicyShowSettings toolSettings, AzureOutput output)
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
        /// <summary><p><em>Sets <see cref="AzureIotDpsAccessPolicyShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyShowSettings SetQuery(this AzureIotDpsAccessPolicyShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsAccessPolicyShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
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
        public static AzureIotDpsAccessPolicyUpdateSettings SetNoWait(this AzureIotDpsAccessPolicyUpdateSettings toolSettings, bool? noWait)
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
        /// <summary><p><em>Enables <see cref="AzureIotDpsAccessPolicyUpdateSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyUpdateSettings EnableNoWait(this AzureIotDpsAccessPolicyUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureIotDpsAccessPolicyUpdateSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyUpdateSettings DisableNoWait(this AzureIotDpsAccessPolicyUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureIotDpsAccessPolicyUpdateSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyUpdateSettings ToggleNoWait(this AzureIotDpsAccessPolicyUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
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
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureIotDpsAccessPolicyUpdateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyUpdateSettings SetSubscription(this AzureIotDpsAccessPolicyUpdateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsAccessPolicyUpdateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyUpdateSettings ResetSubscription(this AzureIotDpsAccessPolicyUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
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
        public static AzureIotDpsAccessPolicyUpdateSettings SetOutput(this AzureIotDpsAccessPolicyUpdateSettings toolSettings, AzureOutput output)
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
        /// <summary><p><em>Sets <see cref="AzureIotDpsAccessPolicyUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDpsAccessPolicyUpdateSettings SetQuery(this AzureIotDpsAccessPolicyUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsAccessPolicyUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
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
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureIotDpsCertificateCreateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateCreateSettings SetSubscription(this AzureIotDpsCertificateCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCertificateCreateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateCreateSettings ResetSubscription(this AzureIotDpsCertificateCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
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
        public static AzureIotDpsCertificateCreateSettings SetOutput(this AzureIotDpsCertificateCreateSettings toolSettings, AzureOutput output)
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
        /// <summary><p><em>Sets <see cref="AzureIotDpsCertificateCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateCreateSettings SetQuery(this AzureIotDpsCertificateCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCertificateCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
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
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureIotDpsCertificateDeleteSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateDeleteSettings SetSubscription(this AzureIotDpsCertificateDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCertificateDeleteSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateDeleteSettings ResetSubscription(this AzureIotDpsCertificateDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
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
        public static AzureIotDpsCertificateDeleteSettings SetOutput(this AzureIotDpsCertificateDeleteSettings toolSettings, AzureOutput output)
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
        /// <summary><p><em>Sets <see cref="AzureIotDpsCertificateDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateDeleteSettings SetQuery(this AzureIotDpsCertificateDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCertificateDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
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
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureIotDpsCertificateGenerateVerificationCodeSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateGenerateVerificationCodeSettings SetSubscription(this AzureIotDpsCertificateGenerateVerificationCodeSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCertificateGenerateVerificationCodeSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateGenerateVerificationCodeSettings ResetSubscription(this AzureIotDpsCertificateGenerateVerificationCodeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
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
        public static AzureIotDpsCertificateGenerateVerificationCodeSettings SetOutput(this AzureIotDpsCertificateGenerateVerificationCodeSettings toolSettings, AzureOutput output)
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
        /// <summary><p><em>Sets <see cref="AzureIotDpsCertificateGenerateVerificationCodeSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateGenerateVerificationCodeSettings SetQuery(this AzureIotDpsCertificateGenerateVerificationCodeSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCertificateGenerateVerificationCodeSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
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
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureIotDpsCertificateListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateListSettings SetSubscription(this AzureIotDpsCertificateListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCertificateListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateListSettings ResetSubscription(this AzureIotDpsCertificateListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
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
        public static AzureIotDpsCertificateListSettings SetOutput(this AzureIotDpsCertificateListSettings toolSettings, AzureOutput output)
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
        /// <summary><p><em>Sets <see cref="AzureIotDpsCertificateListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateListSettings SetQuery(this AzureIotDpsCertificateListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCertificateListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
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
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureIotDpsCertificateShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateShowSettings SetSubscription(this AzureIotDpsCertificateShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCertificateShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateShowSettings ResetSubscription(this AzureIotDpsCertificateShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
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
        public static AzureIotDpsCertificateShowSettings SetOutput(this AzureIotDpsCertificateShowSettings toolSettings, AzureOutput output)
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
        /// <summary><p><em>Sets <see cref="AzureIotDpsCertificateShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateShowSettings SetQuery(this AzureIotDpsCertificateShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCertificateShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
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
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureIotDpsCertificateUpdateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateUpdateSettings SetSubscription(this AzureIotDpsCertificateUpdateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCertificateUpdateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateUpdateSettings ResetSubscription(this AzureIotDpsCertificateUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
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
        public static AzureIotDpsCertificateUpdateSettings SetOutput(this AzureIotDpsCertificateUpdateSettings toolSettings, AzureOutput output)
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
        /// <summary><p><em>Sets <see cref="AzureIotDpsCertificateUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateUpdateSettings SetQuery(this AzureIotDpsCertificateUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCertificateUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
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
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureIotDpsCertificateVerifySettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateVerifySettings SetSubscription(this AzureIotDpsCertificateVerifySettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCertificateVerifySettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateVerifySettings ResetSubscription(this AzureIotDpsCertificateVerifySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
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
        public static AzureIotDpsCertificateVerifySettings SetOutput(this AzureIotDpsCertificateVerifySettings toolSettings, AzureOutput output)
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
        /// <summary><p><em>Sets <see cref="AzureIotDpsCertificateVerifySettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDpsCertificateVerifySettings SetQuery(this AzureIotDpsCertificateVerifySettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsCertificateVerifySettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
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
        public static AzureIotDpsLinkedHubCreateSettings SetNoWait(this AzureIotDpsLinkedHubCreateSettings toolSettings, bool? noWait)
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
        /// <summary><p><em>Enables <see cref="AzureIotDpsLinkedHubCreateSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubCreateSettings EnableNoWait(this AzureIotDpsLinkedHubCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureIotDpsLinkedHubCreateSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubCreateSettings DisableNoWait(this AzureIotDpsLinkedHubCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureIotDpsLinkedHubCreateSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubCreateSettings ToggleNoWait(this AzureIotDpsLinkedHubCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureIotDpsLinkedHubCreateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubCreateSettings SetSubscription(this AzureIotDpsLinkedHubCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsLinkedHubCreateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubCreateSettings ResetSubscription(this AzureIotDpsLinkedHubCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
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
        public static AzureIotDpsLinkedHubCreateSettings SetOutput(this AzureIotDpsLinkedHubCreateSettings toolSettings, AzureOutput output)
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
        /// <summary><p><em>Sets <see cref="AzureIotDpsLinkedHubCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubCreateSettings SetQuery(this AzureIotDpsLinkedHubCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsLinkedHubCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
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
        public static AzureIotDpsLinkedHubDeleteSettings SetNoWait(this AzureIotDpsLinkedHubDeleteSettings toolSettings, bool? noWait)
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
        /// <summary><p><em>Enables <see cref="AzureIotDpsLinkedHubDeleteSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubDeleteSettings EnableNoWait(this AzureIotDpsLinkedHubDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureIotDpsLinkedHubDeleteSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubDeleteSettings DisableNoWait(this AzureIotDpsLinkedHubDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureIotDpsLinkedHubDeleteSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubDeleteSettings ToggleNoWait(this AzureIotDpsLinkedHubDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureIotDpsLinkedHubDeleteSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubDeleteSettings SetSubscription(this AzureIotDpsLinkedHubDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsLinkedHubDeleteSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubDeleteSettings ResetSubscription(this AzureIotDpsLinkedHubDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
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
        public static AzureIotDpsLinkedHubDeleteSettings SetOutput(this AzureIotDpsLinkedHubDeleteSettings toolSettings, AzureOutput output)
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
        /// <summary><p><em>Sets <see cref="AzureIotDpsLinkedHubDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubDeleteSettings SetQuery(this AzureIotDpsLinkedHubDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsLinkedHubDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
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
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureIotDpsLinkedHubListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubListSettings SetSubscription(this AzureIotDpsLinkedHubListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsLinkedHubListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubListSettings ResetSubscription(this AzureIotDpsLinkedHubListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
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
        public static AzureIotDpsLinkedHubListSettings SetOutput(this AzureIotDpsLinkedHubListSettings toolSettings, AzureOutput output)
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
        /// <summary><p><em>Sets <see cref="AzureIotDpsLinkedHubListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubListSettings SetQuery(this AzureIotDpsLinkedHubListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsLinkedHubListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
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
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureIotDpsLinkedHubShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubShowSettings SetSubscription(this AzureIotDpsLinkedHubShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsLinkedHubShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubShowSettings ResetSubscription(this AzureIotDpsLinkedHubShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
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
        public static AzureIotDpsLinkedHubShowSettings SetOutput(this AzureIotDpsLinkedHubShowSettings toolSettings, AzureOutput output)
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
        /// <summary><p><em>Sets <see cref="AzureIotDpsLinkedHubShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubShowSettings SetQuery(this AzureIotDpsLinkedHubShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsLinkedHubShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
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
        public static AzureIotDpsLinkedHubUpdateSettings SetNoWait(this AzureIotDpsLinkedHubUpdateSettings toolSettings, bool? noWait)
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
        /// <summary><p><em>Enables <see cref="AzureIotDpsLinkedHubUpdateSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubUpdateSettings EnableNoWait(this AzureIotDpsLinkedHubUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureIotDpsLinkedHubUpdateSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubUpdateSettings DisableNoWait(this AzureIotDpsLinkedHubUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureIotDpsLinkedHubUpdateSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubUpdateSettings ToggleNoWait(this AzureIotDpsLinkedHubUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureIotDpsLinkedHubUpdateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubUpdateSettings SetSubscription(this AzureIotDpsLinkedHubUpdateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsLinkedHubUpdateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubUpdateSettings ResetSubscription(this AzureIotDpsLinkedHubUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
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
        public static AzureIotDpsLinkedHubUpdateSettings SetOutput(this AzureIotDpsLinkedHubUpdateSettings toolSettings, AzureOutput output)
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
        /// <summary><p><em>Sets <see cref="AzureIotDpsLinkedHubUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureIotDpsLinkedHubUpdateSettings SetQuery(this AzureIotDpsLinkedHubUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureIotDpsLinkedHubUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
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
    #region IotHubCreateSku
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
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
    #region IotDpsCreateSku
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class IotDpsCreateSku : Enumeration
    {
        public static IotDpsCreateSku s1 = new IotDpsCreateSku { Value = "s1" };
    }
    #endregion
    #region IotHubShowConnectionStringKey
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class IotHubShowConnectionStringKey : Enumeration
    {
        public static IotHubShowConnectionStringKey primary = new IotHubShowConnectionStringKey { Value = "primary" };
        public static IotHubShowConnectionStringKey secondary = new IotHubShowConnectionStringKey { Value = "secondary" };
    }
    #endregion
    #region IotHubRouteSource
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class IotHubRouteSource : Enumeration
    {
        public static IotHubRouteSource devicejoblifecycleevents = new IotHubRouteSource { Value = "devicejoblifecycleevents" };
        public static IotHubRouteSource devicelifecycleevents = new IotHubRouteSource { Value = "devicelifecycleevents" };
        public static IotHubRouteSource devicemessages = new IotHubRouteSource { Value = "devicemessages" };
        public static IotHubRouteSource invalid = new IotHubRouteSource { Value = "invalid" };
        public static IotHubRouteSource twinchangeevents = new IotHubRouteSource { Value = "twinchangeevents" };
    }
    #endregion
    #region IotHubRoutingEndpointEndpointType
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class IotHubRoutingEndpointEndpointType : Enumeration
    {
        public static IotHubRoutingEndpointEndpointType azurestoragecontainer = new IotHubRoutingEndpointEndpointType { Value = "azurestoragecontainer" };
        public static IotHubRoutingEndpointEndpointType eventhub = new IotHubRoutingEndpointEndpointType { Value = "eventhub" };
        public static IotHubRoutingEndpointEndpointType servicebusqueue = new IotHubRoutingEndpointEndpointType { Value = "servicebusqueue" };
        public static IotHubRoutingEndpointEndpointType servicebustopic = new IotHubRoutingEndpointEndpointType { Value = "servicebustopic" };
    }
    #endregion
    #region IotDpsAccessPolicyRights
    /// <summary><p>Used within <see cref="AzureIotTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
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
