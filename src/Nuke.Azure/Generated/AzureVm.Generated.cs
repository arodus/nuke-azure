// Copyright Matthias Koch, Sebastian Karasek 2018.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

// Generated with Nuke.CodeGeneration, Version: 0.6.0 [CommitSha: 5a428f0d].
// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/AzureVm.json.

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
    public static partial class AzureVmTasks
    {
        /// <summary><p>Path to the AzureVm executable.</p></summary>
        public static string AzureVmPath => ToolPathResolver.GetPathExecutable("az");
        /// <summary><p>Manage Linux or Windows virtual machines.</p></summary>
        public static IReadOnlyCollection<Output> AzureVm(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool logOutput = true, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzureVmPath, arguments, workingDirectory, environmentVariables, timeout, logOutput, null, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Linux or Windows virtual machines.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vm?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmCapture(Configure<AzureVmCaptureSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmCaptureSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Linux or Windows virtual machines.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vm?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmConvert(Configure<AzureVmConvertSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmConvertSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Linux or Windows virtual machines.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vm?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmCreate(Configure<AzureVmCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Linux or Windows virtual machines.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vm?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmDeallocate(Configure<AzureVmDeallocateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmDeallocateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Linux or Windows virtual machines.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vm?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmDelete(Configure<AzureVmDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Linux or Windows virtual machines.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vm?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmGeneralize(Configure<AzureVmGeneralizeSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmGeneralizeSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Linux or Windows virtual machines.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vm?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmGetInstanceView(Configure<AzureVmGetInstanceViewSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmGetInstanceViewSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Linux or Windows virtual machines.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vm?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmList(Configure<AzureVmListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Linux or Windows virtual machines.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vm?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmListIpAddresses(Configure<AzureVmListIpAddressesSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmListIpAddressesSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Linux or Windows virtual machines.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vm?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmListSizes(Configure<AzureVmListSizesSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmListSizesSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Linux or Windows virtual machines.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vm?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmListSkus(Configure<AzureVmListSkusSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmListSkusSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Linux or Windows virtual machines.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vm?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmListUsage(Configure<AzureVmListUsageSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmListUsageSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Linux or Windows virtual machines.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vm?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmListVmResizeOptions(Configure<AzureVmListVmResizeOptionsSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmListVmResizeOptionsSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Linux or Windows virtual machines.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vm?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmOpenPort(Configure<AzureVmOpenPortSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmOpenPortSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Linux or Windows virtual machines.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vm?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmPerformMaintenance(Configure<AzureVmPerformMaintenanceSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmPerformMaintenanceSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Linux or Windows virtual machines.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vm?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmRedeploy(Configure<AzureVmRedeploySettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmRedeploySettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Linux or Windows virtual machines.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vm?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmResize(Configure<AzureVmResizeSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmResizeSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Linux or Windows virtual machines.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vm?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmRestart(Configure<AzureVmRestartSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmRestartSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Linux or Windows virtual machines.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vm?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmShow(Configure<AzureVmShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Linux or Windows virtual machines.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vm?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmStart(Configure<AzureVmStartSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmStartSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Linux or Windows virtual machines.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vm?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmStop(Configure<AzureVmStopSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmStopSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Linux or Windows virtual machines.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vm?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmUpdate(Configure<AzureVmUpdateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmUpdateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Linux or Windows virtual machines.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vm?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmWait(Configure<AzureVmWaitSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmWaitSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Linux or Windows virtual machines.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vm?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmAvailabilitySetConvert(Configure<AzureVmAvailabilitySetConvertSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmAvailabilitySetConvertSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Linux or Windows virtual machines.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vm?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmAvailabilitySetCreate(Configure<AzureVmAvailabilitySetCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmAvailabilitySetCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Linux or Windows virtual machines.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vm?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmAvailabilitySetDelete(Configure<AzureVmAvailabilitySetDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmAvailabilitySetDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Linux or Windows virtual machines.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vm?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmAvailabilitySetList(Configure<AzureVmAvailabilitySetListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmAvailabilitySetListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Linux or Windows virtual machines.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vm?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmAvailabilitySetListSizes(Configure<AzureVmAvailabilitySetListSizesSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmAvailabilitySetListSizesSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Linux or Windows virtual machines.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vm?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmAvailabilitySetShow(Configure<AzureVmAvailabilitySetShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmAvailabilitySetShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Linux or Windows virtual machines.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vm?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmAvailabilitySetUpdate(Configure<AzureVmAvailabilitySetUpdateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmAvailabilitySetUpdateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Linux or Windows virtual machines.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vm?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmBootDiagnosticsDisable(Configure<AzureVmBootDiagnosticsDisableSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmBootDiagnosticsDisableSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Linux or Windows virtual machines.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vm?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmBootDiagnosticsEnable(Configure<AzureVmBootDiagnosticsEnableSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmBootDiagnosticsEnableSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Linux or Windows virtual machines.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vm?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmBootDiagnosticsGetBootLog(Configure<AzureVmBootDiagnosticsGetBootLogSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmBootDiagnosticsGetBootLogSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Linux or Windows virtual machines.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vm?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmDiagnosticsGetDefaultConfig(Configure<AzureVmDiagnosticsGetDefaultConfigSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmDiagnosticsGetDefaultConfigSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Linux or Windows virtual machines.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vm?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmDiagnosticsSet(Configure<AzureVmDiagnosticsSetSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmDiagnosticsSetSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Linux or Windows virtual machines.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vm?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmDiskAttach(Configure<AzureVmDiskAttachSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmDiskAttachSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Linux or Windows virtual machines.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vm?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmDiskDetach(Configure<AzureVmDiskDetachSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmDiskDetachSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Linux or Windows virtual machines.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vm?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmEncryptionDisable(Configure<AzureVmEncryptionDisableSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmEncryptionDisableSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Linux or Windows virtual machines.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vm?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmEncryptionEnable(Configure<AzureVmEncryptionEnableSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmEncryptionEnableSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Linux or Windows virtual machines.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vm?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmEncryptionShow(Configure<AzureVmEncryptionShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmEncryptionShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Linux or Windows virtual machines.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vm?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmExtensionDelete(Configure<AzureVmExtensionDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmExtensionDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Linux or Windows virtual machines.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vm?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmExtensionList(Configure<AzureVmExtensionListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmExtensionListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Linux or Windows virtual machines.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vm?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmExtensionSet(Configure<AzureVmExtensionSetSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmExtensionSetSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Linux or Windows virtual machines.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vm?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmExtensionShow(Configure<AzureVmExtensionShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmExtensionShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Linux or Windows virtual machines.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vm?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmExtensionWait(Configure<AzureVmExtensionWaitSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmExtensionWaitSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Linux or Windows virtual machines.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vm?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmIdentityAssign(Configure<AzureVmIdentityAssignSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmIdentityAssignSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Linux or Windows virtual machines.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vm?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmIdentityRemove(Configure<AzureVmIdentityRemoveSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmIdentityRemoveSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Linux or Windows virtual machines.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vm?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmIdentityShow(Configure<AzureVmIdentityShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmIdentityShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Linux or Windows virtual machines.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vm?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmImageAcceptTerms(Configure<AzureVmImageAcceptTermsSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmImageAcceptTermsSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Linux or Windows virtual machines.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vm?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmImageList(Configure<AzureVmImageListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmImageListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Linux or Windows virtual machines.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vm?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmImageListOffers(Configure<AzureVmImageListOffersSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmImageListOffersSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Linux or Windows virtual machines.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vm?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmImageListPublishers(Configure<AzureVmImageListPublishersSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmImageListPublishersSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Linux or Windows virtual machines.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vm?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmImageListSkus(Configure<AzureVmImageListSkusSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmImageListSkusSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Linux or Windows virtual machines.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vm?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmImageShow(Configure<AzureVmImageShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmImageShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Linux or Windows virtual machines.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vm?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmNicAdd(Configure<AzureVmNicAddSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmNicAddSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Linux or Windows virtual machines.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vm?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmNicList(Configure<AzureVmNicListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmNicListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Linux or Windows virtual machines.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vm?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmNicRemove(Configure<AzureVmNicRemoveSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmNicRemoveSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Linux or Windows virtual machines.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vm?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmNicSet(Configure<AzureVmNicSetSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmNicSetSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Linux or Windows virtual machines.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vm?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmNicShow(Configure<AzureVmNicShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmNicShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Linux or Windows virtual machines.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vm?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmRunCommandInvoke(Configure<AzureVmRunCommandInvokeSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmRunCommandInvokeSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Linux or Windows virtual machines.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vm?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmRunCommandList(Configure<AzureVmRunCommandListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmRunCommandListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Linux or Windows virtual machines.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vm?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmRunCommandShow(Configure<AzureVmRunCommandShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmRunCommandShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Linux or Windows virtual machines.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vm?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmSecretAdd(Configure<AzureVmSecretAddSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmSecretAddSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Linux or Windows virtual machines.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vm?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmSecretFormat(Configure<AzureVmSecretFormatSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmSecretFormatSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Linux or Windows virtual machines.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vm?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmSecretList(Configure<AzureVmSecretListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmSecretListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Linux or Windows virtual machines.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vm?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmSecretRemove(Configure<AzureVmSecretRemoveSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmSecretRemoveSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Linux or Windows virtual machines.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vm?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmUnmanagedDiskAttach(Configure<AzureVmUnmanagedDiskAttachSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmUnmanagedDiskAttachSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Linux or Windows virtual machines.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vm?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmUnmanagedDiskDetach(Configure<AzureVmUnmanagedDiskDetachSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmUnmanagedDiskDetachSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Linux or Windows virtual machines.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vm?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmUnmanagedDiskList(Configure<AzureVmUnmanagedDiskListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmUnmanagedDiskListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Linux or Windows virtual machines.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vm?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmUserDelete(Configure<AzureVmUserDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmUserDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Linux or Windows virtual machines.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vm?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmUserResetSsh(Configure<AzureVmUserResetSshSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmUserResetSshSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Linux or Windows virtual machines.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vm?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmUserUpdate(Configure<AzureVmUserUpdateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmUserUpdateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Linux or Windows virtual machines.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vm?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmExtensionImageList(Configure<AzureVmExtensionImageListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmExtensionImageListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Linux or Windows virtual machines.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vm?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmExtensionImageListNames(Configure<AzureVmExtensionImageListNamesSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmExtensionImageListNamesSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Linux or Windows virtual machines.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vm?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmExtensionImageListVersions(Configure<AzureVmExtensionImageListVersionsSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmExtensionImageListVersionsSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Linux or Windows virtual machines.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vm?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmExtensionImageShow(Configure<AzureVmExtensionImageShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmExtensionImageShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
    }
    #region AzureVmCaptureSettings
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmCaptureSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmTasks.AzureVmPath;
        /// <summary><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The VHD name prefix specify for the VM disks.</p></summary>
        public virtual string VhdNamePrefix { get; internal set; }
        /// <summary><p>Overwrite the existing disk file.</p></summary>
        public virtual string Overwrite { get; internal set; }
        /// <summary><p>The storage account container name in which to save the disks.</p></summary>
        public virtual string StorageContainer { get; internal set; }
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
              .Add("vm capture")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--vhd-name-prefix {value}", VhdNamePrefix)
              .Add("--overwrite {value}", Overwrite)
              .Add("--storage-container {value}", StorageContainer)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureVmConvertSettings
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmConvertSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmTasks.AzureVmPath;
        /// <summary><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
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
              .Add("vm convert")
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
    #region AzureVmCreateSettings
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmTasks.AzureVmPath;
        /// <summary><p>Name of the virtual machine.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Attach existing data disks to the VM. Can use the name or ID of a managed disk or the URI to an unmanaged disk VHD.</p></summary>
        public virtual string AttachDataDisks { get; internal set; }
        /// <summary><p>Attach an existing OS disk to the VM. Can use the name or ID of a managed disk or the URI to an unmanaged disk VHD.</p></summary>
        public virtual string AttachOsDisk { get; internal set; }
        /// <summary><p>Name or ID of an existing availability set to add the VM to. None by default.</p></summary>
        public virtual string AvailabilitySet { get; internal set; }
        /// <summary><p>Pre-existing storage account name or its blob uri to capture boot diagnostics. Its sku should be one of Standard_GRS, Standard_LRS and Standard_RAGRS.</p></summary>
        public virtual string BootDiagnosticsStorage { get; internal set; }
        /// <summary><p>Custom init script file or text (cloud-init, cloud-config, etc..).</p></summary>
        public virtual string CustomData { get; internal set; }
        /// <summary><p>The name of the operating system image as a URN alias, URN, custom image name or ID, or VHD blob URI. This parameter is required unless using `--attach-os-disk.`.</p></summary>
        public virtual string Image { get; internal set; }
        /// <summary><p>License type if the Windows image or disk used was licensed on-premises.</p></summary>
        public virtual VmLicenseType LicenseType { get; internal set; }
        /// <summary><p>Location in which to create VM and related resources. If default location is not configured, will default to the resource group's location.</p></summary>
        public virtual string Location { get; internal set; }
        /// <summary><p>Do not wait for the long-running operation to finish.</p></summary>
        public virtual string NoWait { get; internal set; }
        /// <summary><p>One or many Key Vault secrets as JSON strings or files via `@&amp;lt;file path&amp;gt;` containing `[{ "sourceVault": { "id": "value" }, "vaultCertificates": [{ "certificateUrl": "value", "certificateStore": "cert store name (only on windows)"}] }]`.</p></summary>
        public virtual string Secrets { get; internal set; }
        /// <summary><p>The VM size to be created. See <a href="https://azure.microsoft.com/en-us/pricing/details/virtual-machines/">https://azure.microsoft.com/en-us/pricing/details/virtual-machines/</a> for size info.</p></summary>
        public virtual string Size { get; internal set; }
        /// <summary><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        public virtual string Tags { get; internal set; }
        /// <summary><p>Generate and validate the ARM template without creating any resources.</p></summary>
        public virtual string Validate { get; internal set; }
        /// <summary><p>Availability zone into which to provision the resource.</p></summary>
        public virtual VmCreateZone Zone { get; internal set; }
        /// <summary><p>Password for the VM if authentication type is 'Password'.</p></summary>
        public virtual string AdminPassword { get; internal set; }
        /// <summary><p>Username for the VM.</p></summary>
        public virtual string AdminUsername { get; internal set; }
        /// <summary><p>Type of authentication to use with the VM. Defaults to password for Windows and SSH public key for Linux.</p></summary>
        public virtual VmCreateAuthenticationType AuthenticationType { get; internal set; }
        /// <summary><p>Generate SSH public and private key files if missing. The keys will be stored in the ~/.ssh directory.</p></summary>
        public virtual string GenerateSshKeys { get; internal set; }
        /// <summary><p>Destination file path on the VM for the SSH key.</p></summary>
        public virtual string SshDestKeyPath { get; internal set; }
        /// <summary><p>The SSH public key or public key file path.</p></summary>
        public virtual string SshKeyValue { get; internal set; }
        /// <summary><p>Accept system or user assigned identities separated by spaces. Use '[system]' to refer system assigned identity, or a resource id to refer user assigned identity. Check out help for more examples.</p></summary>
        public virtual string AssignIdentity { get; internal set; }
        /// <summary><p>Role name or id the system assigned identity will have.</p></summary>
        public virtual string Role { get; internal set; }
        /// <summary><p>Scope that the system assigned identity can access.</p></summary>
        public virtual string Scope { get; internal set; }
        /// <summary><p>Plan name.</p></summary>
        public virtual string PlanName { get; internal set; }
        /// <summary><p>Plan product.</p></summary>
        public virtual string PlanProduct { get; internal set; }
        /// <summary><p>Plan promotion code.</p></summary>
        public virtual string PlanPromotionCode { get; internal set; }
        /// <summary><p>Plan publisher.</p></summary>
        public virtual string PlanPublisher { get; internal set; }
        /// <summary><p>Enable accelerated networking. Unless specified, CLI will enable it based on machine image and size.</p></summary>
        public virtual bool? AcceleratedNetworking { get; internal set; }
        /// <summary><p>Space-separated list of existing application security groups to associate with the VM.</p></summary>
        public virtual IReadOnlyList<string> Asgs => AsgsInternal.AsReadOnly();
        internal List<string> AsgsInternal { get; set; } = new List<string>();
        /// <summary><p>Names or IDs of existing NICs to attach to the VM. The first NIC will be designated as primary. If omitted, a new NIC will be created. If an existing NIC is specified, do not specify subnet, VNet, public IP or NSG.</p></summary>
        public virtual string Nics { get; internal set; }
        /// <summary><p>The name to use when creating a new Network Security Group (default) or referencing an existing one. Can also reference an existing NSG by ID or specify "" for none.</p></summary>
        public virtual string Nsg { get; internal set; }
        /// <summary><p>NSG rule to create when creating a new NSG. Defaults to open ports for allowing RDP on Windows and allowing SSH on Linux.</p></summary>
        public virtual VmCreateNsgRule NsgRule { get; internal set; }
        /// <summary><p>Static private IP address (e.g. 10.0.0.5).</p></summary>
        public virtual string PrivateIpAddress { get; internal set; }
        /// <summary><p>Name of the public IP address when creating one (default) or referencing an existing one. Can also reference an existing public IP by ID or specify "" for None.</p></summary>
        public virtual string PublicIpAddress { get; internal set; }
        /// <summary><p></p></summary>
        public virtual VmCreatePublicIpAddressAllocation PublicIpAddressAllocation { get; internal set; }
        /// <summary><p>Globally unique DNS name for a newly created public IP.</p></summary>
        public virtual string PublicIpAddressDnsName { get; internal set; }
        /// <summary><p>Sku.</p></summary>
        public virtual VmCreatePublicIpSku PublicIpSku { get; internal set; }
        /// <summary><p>The name of the subnet when creating a new VNet or referencing an existing one. Can also reference an existing subnet by ID. If omitted, an appropriate VNet and subnet will be selected automatically, or a new one will be created.</p></summary>
        public virtual string Subnet { get; internal set; }
        /// <summary><p>The subnet IP address prefix to use when creating a new VNet in CIDR format.</p></summary>
        public virtual string SubnetAddressPrefix { get; internal set; }
        /// <summary><p>The IP address prefix to use when creating a new VNet in CIDR format.</p></summary>
        public virtual string VnetAddressPrefix { get; internal set; }
        /// <summary><p>Name of the virtual network when creating a new one or referencing an existing one.</p></summary>
        public virtual string VnetName { get; internal set; }
        /// <summary><p>Storage caching type for data disk(s), including 'None', 'ReadOnly', 'ReadWrite', etc. Use a singular value to apply on all disks, or use '&lt;lun&gt;=&lt;vaule1&gt; &lt;lun&gt;=&lt;value2&gt;' to configure individual disk.</p></summary>
        public virtual string DataDiskCaching { get; internal set; }
        /// <summary><p>Space-separated empty managed data disk sizes in GB to create.</p></summary>
        public virtual string DataDiskSizesGb { get; internal set; }
        /// <summary><p>Storage caching type for the VM OS disk. Default: ReadWrite.</p></summary>
        public virtual VmCreateOsDiskCaching OsDiskCaching { get; internal set; }
        /// <summary><p>The name of the new VM OS disk.</p></summary>
        public virtual string OsDiskName { get; internal set; }
        /// <summary><p>The size of the os disk in GB.</p></summary>
        public virtual string OsDiskSizeGb { get; internal set; }
        /// <summary><p>Type of OS installed on a custom VHD. Do not use when specifying an URN or URN alias.</p></summary>
        public virtual VmCreateOsType OsType { get; internal set; }
        /// <summary><p>Only applicable when used with `--use-unmanaged-disk`. The name to use when creating a new storage account or referencing an existing one. If omitted, an appropriate storage account in the same resource group and location will be used, or a new one will be created.</p></summary>
        public virtual string StorageAccount { get; internal set; }
        /// <summary><p>Only applicable when used with `--use-unmanaged-disk`. Name of the storage container for the VM OS disk. Default: vhds.</p></summary>
        public virtual string StorageContainerName { get; internal set; }
        /// <summary><p>The SKU of the storage account with which to persist VM.</p></summary>
        public virtual VmCreateStorageSku StorageSku { get; internal set; }
        /// <summary><p>Do not use managed disk to persist VM.</p></summary>
        public virtual string UseUnmanagedDisk { get; internal set; }
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
              .Add("vm create")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--attach-data-disks {value}", AttachDataDisks)
              .Add("--attach-os-disk {value}", AttachOsDisk)
              .Add("--availability-set {value}", AvailabilitySet)
              .Add("--boot-diagnostics-storage {value}", BootDiagnosticsStorage)
              .Add("--custom-data {value}", CustomData)
              .Add("--image {value}", Image)
              .Add("--license-type {value}", LicenseType)
              .Add("--location {value}", Location)
              .Add("--no-wait {value}", NoWait)
              .Add("--secrets {value}", Secrets, secret: true)
              .Add("--size {value}", Size)
              .Add("--tags {value}", Tags)
              .Add("--validate {value}", Validate)
              .Add("--zone {value}", Zone)
              .Add("--admin-password {value}", AdminPassword, secret: true)
              .Add("--admin-username {value}", AdminUsername)
              .Add("--authentication-type {value}", AuthenticationType)
              .Add("--generate-ssh-keys {value}", GenerateSshKeys)
              .Add("--ssh-dest-key-path {value}", SshDestKeyPath)
              .Add("--ssh-key-value {value}", SshKeyValue)
              .Add("--assign-identity {value}", AssignIdentity)
              .Add("--role {value}", Role)
              .Add("--scope {value}", Scope)
              .Add("--plan-name {value}", PlanName)
              .Add("--plan-product {value}", PlanProduct)
              .Add("--plan-promotion-code {value}", PlanPromotionCode)
              .Add("--plan-publisher {value}", PlanPublisher)
              .Add("--accelerated-networking", AcceleratedNetworking)
              .Add("--asgs {value}", Asgs, separator: ' ')
              .Add("--nics {value}", Nics)
              .Add("--nsg {value}", Nsg)
              .Add("--nsg-rule {value}", NsgRule)
              .Add("--private-ip-address {value}", PrivateIpAddress)
              .Add("--public-ip-address {value}", PublicIpAddress)
              .Add("--public-ip-address-allocation {value}", PublicIpAddressAllocation)
              .Add("--public-ip-address-dns-name {value}", PublicIpAddressDnsName)
              .Add("--public-ip-sku {value}", PublicIpSku)
              .Add("--subnet {value}", Subnet)
              .Add("--subnet-address-prefix {value}", SubnetAddressPrefix)
              .Add("--vnet-address-prefix {value}", VnetAddressPrefix)
              .Add("--vnet-name {value}", VnetName)
              .Add("--data-disk-caching {value}", DataDiskCaching)
              .Add("--data-disk-sizes-gb {value}", DataDiskSizesGb)
              .Add("--os-disk-caching {value}", OsDiskCaching)
              .Add("--os-disk-name {value}", OsDiskName)
              .Add("--os-disk-size-gb {value}", OsDiskSizeGb)
              .Add("--os-type {value}", OsType)
              .Add("--storage-account {value}", StorageAccount)
              .Add("--storage-container-name {value}", StorageContainerName)
              .Add("--storage-sku {value}", StorageSku)
              .Add("--use-unmanaged-disk {value}", UseUnmanagedDisk)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureVmDeallocateSettings
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmDeallocateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmTasks.AzureVmPath;
        /// <summary><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Do not wait for the long-running operation to finish.</p></summary>
        public virtual string NoWait { get; internal set; }
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
              .Add("vm deallocate")
              .Add("--name {value}", Name)
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
    #region AzureVmDeleteSettings
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmTasks.AzureVmPath;
        /// <summary><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Do not wait for the long-running operation to finish.</p></summary>
        public virtual string NoWait { get; internal set; }
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
              .Add("vm delete")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--no-wait {value}", NoWait)
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
    #region AzureVmGeneralizeSettings
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmGeneralizeSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmTasks.AzureVmPath;
        /// <summary><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Do not wait for the long-running operation to finish.</p></summary>
        public virtual string NoWait { get; internal set; }
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
              .Add("vm generalize")
              .Add("--name {value}", Name)
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
    #region AzureVmGetInstanceViewSettings
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmGetInstanceViewSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmTasks.AzureVmPath;
        /// <summary><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
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
              .Add("vm get-instance-view")
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
    #region AzureVmListSettings
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmTasks.AzureVmPath;
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Show public ip address, FQDN, and power states. command will run slow.</p></summary>
        public virtual bool? ShowDetails { get; internal set; }
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
              .Add("vm list")
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--show-details", ShowDetails)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureVmListIpAddressesSettings
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmListIpAddressesSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmTasks.AzureVmPath;
        /// <summary><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
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
              .Add("vm list-ip-addresses")
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
    #region AzureVmListSizesSettings
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmListSizesSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmTasks.AzureVmPath;
        /// <summary><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        public virtual string Location { get; internal set; }
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
              .Add("vm list-sizes")
              .Add("--location {value}", Location)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureVmListSkusSettings
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmListSkusSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmTasks.AzureVmPath;
        /// <summary><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        public virtual string Location { get; internal set; }
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
              .Add("vm list-skus")
              .Add("--location {value}", Location)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureVmListUsageSettings
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmListUsageSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmTasks.AzureVmPath;
        /// <summary><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        public virtual string Location { get; internal set; }
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
              .Add("vm list-usage")
              .Add("--location {value}", Location)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureVmListVmResizeOptionsSettings
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmListVmResizeOptionsSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmTasks.AzureVmPath;
        /// <summary><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
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
              .Add("vm list-vm-resize-options")
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
    #region AzureVmOpenPortSettings
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmOpenPortSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmTasks.AzureVmPath;
        /// <summary><p>The name of the virtual machine to open inbound traffic on.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>The port or port range (ex: 80-100) to open inbound traffic to. Use '*' to allow traffic to all ports.</p></summary>
        public virtual string Port { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Allow inbound traffic on the subnet instead of the NIC.</p></summary>
        public virtual string ApplyToSubnet { get; internal set; }
        /// <summary><p>The name of the network security group to create if one does not exist. Ignored if an NSG already exists.</p></summary>
        public virtual string NsgName { get; internal set; }
        /// <summary><p>Rule priority, between 100 (highest priority) and 4096 (lowest priority). Must be unique for each rule in the collection.</p></summary>
        public virtual string Priority { get; internal set; }
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
              .Add("vm open-port")
              .Add("--name {value}", Name)
              .Add("--port {value}", Port)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--apply-to-subnet {value}", ApplyToSubnet)
              .Add("--nsg-name {value}", NsgName)
              .Add("--priority {value}", Priority)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureVmPerformMaintenanceSettings
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmPerformMaintenanceSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmTasks.AzureVmPath;
        /// <summary><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
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
              .Add("vm perform-maintenance")
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
    #region AzureVmRedeploySettings
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmRedeploySettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmTasks.AzureVmPath;
        /// <summary><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Do not wait for the long-running operation to finish.</p></summary>
        public virtual string NoWait { get; internal set; }
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
              .Add("vm redeploy")
              .Add("--name {value}", Name)
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
    #region AzureVmResizeSettings
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmResizeSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmTasks.AzureVmPath;
        /// <summary><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The VM size.</p></summary>
        public virtual string Size { get; internal set; }
        /// <summary><p>Do not wait for the long-running operation to finish.</p></summary>
        public virtual string NoWait { get; internal set; }
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
              .Add("vm resize")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--size {value}", Size)
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
    #region AzureVmRestartSettings
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmRestartSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmTasks.AzureVmPath;
        /// <summary><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Do not wait for the long-running operation to finish.</p></summary>
        public virtual string NoWait { get; internal set; }
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
              .Add("vm restart")
              .Add("--name {value}", Name)
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
    #region AzureVmShowSettings
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmTasks.AzureVmPath;
        /// <summary><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Show public ip address, FQDN, and power states. command will run slow.</p></summary>
        public virtual bool? ShowDetails { get; internal set; }
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
              .Add("vm show")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--show-details", ShowDetails)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureVmStartSettings
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmStartSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmTasks.AzureVmPath;
        /// <summary><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Do not wait for the long-running operation to finish.</p></summary>
        public virtual string NoWait { get; internal set; }
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
              .Add("vm start")
              .Add("--name {value}", Name)
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
    #region AzureVmStopSettings
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmStopSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmTasks.AzureVmPath;
        /// <summary><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Do not wait for the long-running operation to finish.</p></summary>
        public virtual string NoWait { get; internal set; }
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
              .Add("vm stop")
              .Add("--name {value}", Name)
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
    #region AzureVmUpdateSettings
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmUpdateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmTasks.AzureVmPath;
        /// <summary><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Use singular value to apply across, or specify individual disks, e.g. 'os=ReadWrite 0=None 1=ReadOnly' should enable update os disk and 2 data disks.</p></summary>
        public virtual IReadOnlyList<string> DiskCaching => DiskCachingInternal.AsReadOnly();
        internal List<string> DiskCachingInternal { get; set; } = new List<string>();
        /// <summary><p>License type if the Windows image or disk used was licensed on-premises.</p></summary>
        public virtual VmLicenseType LicenseType { get; internal set; }
        /// <summary><p>Do not wait for the long-running operation to finish.</p></summary>
        public virtual string NoWait { get; internal set; }
        /// <summary><p>Managed OS disk ID or name to swap to. Feature registration for 'Microsoft.Compute/AllowManagedDisksReplaceOSDisk' is needed.</p></summary>
        public virtual string OsDisk { get; internal set; }
        /// <summary><p>Enable/disable disk write accelerator. Use singular value 'true/false' to apply across, or specify individual disks, e.g.'os=true 1=true 2=true' for os disk and data disks with lun of 1 &amp; 2.</p></summary>
        public virtual IReadOnlyList<string> WriteAccelerator => WriteAcceleratorInternal.AsReadOnly();
        internal List<string> WriteAcceleratorInternal { get; set; } = new List<string>();
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
              .Add("vm update")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--disk-caching {value}", DiskCaching, separator: ' ')
              .Add("--license-type {value}", LicenseType)
              .Add("--no-wait {value}", NoWait)
              .Add("--os-disk {value}", OsDisk)
              .Add("--write-accelerator {value}", WriteAccelerator, separator: ' ')
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
    #region AzureVmWaitSettings
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmWaitSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmTasks.AzureVmPath;
        /// <summary><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Wait until created with 'provisioningState' at 'Succeeded'.</p></summary>
        public virtual string Created { get; internal set; }
        /// <summary><p>Wait until the condition satisfies a custom JMESPath query. E.g. provisioningState!='InProgress', instanceView.statuses[?code=='PowerState/running'].</p></summary>
        public virtual string Custom { get; internal set; }
        /// <summary><p>Wait until deleted.</p></summary>
        public virtual string Deleted { get; internal set; }
        /// <summary><p>Wait until the resource exists.</p></summary>
        public virtual string Exists { get; internal set; }
        /// <summary><p>Polling interval in seconds.</p></summary>
        public virtual string Interval { get; internal set; }
        /// <summary><p>Maximum wait in seconds.</p></summary>
        public virtual string Timeout { get; internal set; }
        /// <summary><p>Wait until updated with provisioningState at 'Succeeded'.</p></summary>
        public virtual string Updated { get; internal set; }
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
              .Add("vm wait")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--created {value}", Created)
              .Add("--custom {value}", Custom)
              .Add("--deleted {value}", Deleted)
              .Add("--exists {value}", Exists)
              .Add("--interval {value}", Interval)
              .Add("--timeout {value}", Timeout)
              .Add("--updated {value}", Updated)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureVmAvailabilitySetConvertSettings
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmAvailabilitySetConvertSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmTasks.AzureVmPath;
        /// <summary><p>Name of the availability set.</p></summary>
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
              .Add("vm availability-set convert")
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
    #region AzureVmAvailabilitySetCreateSettings
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmAvailabilitySetCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmTasks.AzureVmPath;
        /// <summary><p>Name of the availability set.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        public virtual string Location { get; internal set; }
        /// <summary><p>Do not wait for the long-running operation to finish.</p></summary>
        public virtual string NoWait { get; internal set; }
        /// <summary><p>Fault Domain count.</p></summary>
        public virtual string PlatformFaultDomainCount { get; internal set; }
        /// <summary><p>Update Domain count. If unspecified, server picks the most optimal number like 5. For the latest defaults see <a href="https://docs.microsoft.com/en-us/rest/api/compute/availabilitysets/availabilitysets-create">https://docs.microsoft.com/en-us/rest/api/compute/availabilitysets/availabilitysets-create</a>.</p></summary>
        public virtual string PlatformUpdateDomainCount { get; internal set; }
        /// <summary><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        public virtual string Tags { get; internal set; }
        /// <summary><p>Contained VMs should use unmanaged disks.</p></summary>
        public virtual string Unmanaged { get; internal set; }
        /// <summary><p>Generate and validate the ARM template without creating any resources.</p></summary>
        public virtual string Validate { get; internal set; }
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
              .Add("vm availability-set create")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--location {value}", Location)
              .Add("--no-wait {value}", NoWait)
              .Add("--platform-fault-domain-count {value}", PlatformFaultDomainCount)
              .Add("--platform-update-domain-count {value}", PlatformUpdateDomainCount)
              .Add("--tags {value}", Tags)
              .Add("--unmanaged {value}", Unmanaged)
              .Add("--validate {value}", Validate)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureVmAvailabilitySetDeleteSettings
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmAvailabilitySetDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmTasks.AzureVmPath;
        /// <summary><p>Name of the availability set.</p></summary>
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
              .Add("vm availability-set delete")
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
    #region AzureVmAvailabilitySetListSettings
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmAvailabilitySetListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmTasks.AzureVmPath;
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
              .Add("vm availability-set list")
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
    #region AzureVmAvailabilitySetListSizesSettings
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmAvailabilitySetListSizesSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmTasks.AzureVmPath;
        /// <summary><p>Name of the availability set.</p></summary>
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
              .Add("vm availability-set list-sizes")
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
    #region AzureVmAvailabilitySetShowSettings
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmAvailabilitySetShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmTasks.AzureVmPath;
        /// <summary><p>Name of the availability set.</p></summary>
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
              .Add("vm availability-set show")
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
    #region AzureVmAvailabilitySetUpdateSettings
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmAvailabilitySetUpdateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmTasks.AzureVmPath;
        /// <summary><p>Name of the availability set.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
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
              .Add("vm availability-set update")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
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
    #region AzureVmBootDiagnosticsDisableSettings
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmBootDiagnosticsDisableSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmTasks.AzureVmPath;
        /// <summary><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
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
              .Add("vm boot-diagnostics disable")
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
    #region AzureVmBootDiagnosticsEnableSettings
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmBootDiagnosticsEnableSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmTasks.AzureVmPath;
        /// <summary><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name or URI of a storage account (e.g. <a href="https://your_storage_account_name.blob.core.windows.net/">https://your_storage_account_name.blob.core.windows.net/</a>).</p></summary>
        public virtual string Storage { get; internal set; }
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
              .Add("vm boot-diagnostics enable")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--storage {value}", Storage)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureVmBootDiagnosticsGetBootLogSettings
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmBootDiagnosticsGetBootLogSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmTasks.AzureVmPath;
        /// <summary><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
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
              .Add("vm boot-diagnostics get-boot-log")
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
    #region AzureVmDiagnosticsGetDefaultConfigSettings
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmDiagnosticsGetDefaultConfigSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmTasks.AzureVmPath;
        /// <summary><p>For Windows VMs.</p></summary>
        public virtual string IsWindowsOs { get; internal set; }
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
              .Add("vm diagnostics get-default-config")
              .Add("--is-windows-os {value}", IsWindowsOs)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureVmDiagnosticsSetSettings
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmDiagnosticsSetSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmTasks.AzureVmPath;
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Json string or a file path, which defines data to be collected.</p></summary>
        public virtual string Settings { get; internal set; }
        /// <summary><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string VmName { get; internal set; }
        /// <summary><p>By doing this, extension system will not pick the highest minor version for the specified version number, and will not auto update to the latest build/revision number on any scale set updates in future.</p></summary>
        public virtual string NoAutoUpgrade { get; internal set; }
        /// <summary><p>Json string or a file path containing private configurations such as storage account keys, etc.</p></summary>
        public virtual string ProtectedSettings { get; internal set; }
        /// <summary><p>Version of the diagnostics extension. Will use the latest if not specfied.</p></summary>
        public virtual string Version { get; internal set; }
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
              .Add("vm diagnostics set")
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--settings {value}", Settings)
              .Add("--vm-name {value}", VmName)
              .Add("--no-auto-upgrade {value}", NoAutoUpgrade)
              .Add("--protected-settings {value}", ProtectedSettings)
              .Add("--version {value}", Version)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureVmDiskAttachSettings
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmDiskAttachSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmTasks.AzureVmPath;
        /// <summary><p>Disk name or ID.</p></summary>
        public virtual string Disk { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string VmName { get; internal set; }
        /// <summary><p>Disk caching policy.</p></summary>
        public virtual VmCreateOsDiskCaching Caching { get; internal set; }
        /// <summary><p>Enable write accelerator.</p></summary>
        public virtual string EnableWriteAccelerator { get; internal set; }
        /// <summary><p>0-based logical unit number (LUN). Max value depends on the Virtual Machine size.</p></summary>
        public virtual string Lun { get; internal set; }
        /// <summary><p>Create a new disk.</p></summary>
        public virtual string New { get; internal set; }
        /// <summary><p>Size in GB.</p></summary>
        public virtual string SizeGb { get; internal set; }
        /// <summary><p>Underlying storage SKU.</p></summary>
        public virtual VmCreateStorageSku Sku { get; internal set; }
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
              .Add("vm disk attach")
              .Add("--disk {value}", Disk)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--vm-name {value}", VmName)
              .Add("--caching {value}", Caching)
              .Add("--enable-write-accelerator {value}", EnableWriteAccelerator)
              .Add("--lun {value}", Lun)
              .Add("--new {value}", New)
              .Add("--size-gb {value}", SizeGb)
              .Add("--sku {value}", Sku)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureVmDiskDetachSettings
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmDiskDetachSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmTasks.AzureVmPath;
        /// <summary><p>The data disk name.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string VmName { get; internal set; }
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
              .Add("vm disk detach")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--vm-name {value}", VmName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureVmEncryptionDisableSettings
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmEncryptionDisableSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmTasks.AzureVmPath;
        /// <summary><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Continue by ignoring client side validation errors.</p></summary>
        public virtual string Force { get; internal set; }
        /// <summary><p>Type of volume that the encryption operation is performed on.</p></summary>
        public virtual VmEncryptionVolumeType VolumeType { get; internal set; }
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
              .Add("vm encryption disable")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--force {value}", Force)
              .Add("--volume-type {value}", VolumeType)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureVmEncryptionEnableSettings
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmEncryptionEnableSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmTasks.AzureVmPath;
        /// <summary><p>The key vault where the generated encryption key will be placed.</p></summary>
        public virtual string DiskEncryptionKeyvault { get; internal set; }
        /// <summary><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Thumbprint of the AAD app certificate with permissions to write secrets to the key vault.</p></summary>
        public virtual string AadClientCertThumbprint { get; internal set; }
        /// <summary><p>Client ID of an AAD app with permissions to write secrets to the key vault.</p></summary>
        public virtual string AadClientId { get; internal set; }
        /// <summary><p>Client secret of the AAD app with permissions to write secrets to the key vault.</p></summary>
        public virtual string AadClientSecret { get; internal set; }
        /// <summary><p>Encrypts-formats data disks instead of encrypting them. Encrypt-formatting is a lot faster than in-place encryption but wipes out the partition getting encrypt-formatted.</p></summary>
        public virtual string EncryptFormatAll { get; internal set; }
        /// <summary><p></p></summary>
        public virtual string KeyEncryptionAlgorithm { get; internal set; }
        /// <summary><p>Key vault key name or URL used to encrypt the disk encryption key.</p></summary>
        public virtual string KeyEncryptionKey { get; internal set; }
        /// <summary><p>The key vault containing the key encryption key used to encrypt the disk encryption key. If missing, CLI will use `--disk-encryption-keyvault`.</p></summary>
        public virtual string KeyEncryptionKeyvault { get; internal set; }
        /// <summary><p>Type of volume that the encryption operation is performed on.</p></summary>
        public virtual VmEncryptionVolumeType VolumeType { get; internal set; }
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
              .Add("vm encryption enable")
              .Add("--disk-encryption-keyvault {value}", DiskEncryptionKeyvault)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--aad-client-cert-thumbprint {value}", AadClientCertThumbprint)
              .Add("--aad-client-id {value}", AadClientId)
              .Add("--aad-client-secret {value}", AadClientSecret, secret: true)
              .Add("--encrypt-format-all {value}", EncryptFormatAll)
              .Add("--key-encryption-algorithm {value}", KeyEncryptionAlgorithm)
              .Add("--key-encryption-key {value}", KeyEncryptionKey)
              .Add("--key-encryption-keyvault {value}", KeyEncryptionKeyvault)
              .Add("--volume-type {value}", VolumeType)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureVmEncryptionShowSettings
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmEncryptionShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmTasks.AzureVmPath;
        /// <summary><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
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
              .Add("vm encryption show")
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
    #region AzureVmExtensionDeleteSettings
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmExtensionDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmTasks.AzureVmPath;
        /// <summary><p>Extension name.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string VmName { get; internal set; }
        /// <summary><p>Do not wait for the long-running operation to finish.</p></summary>
        public virtual string NoWait { get; internal set; }
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
              .Add("vm extension delete")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--vm-name {value}", VmName)
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
    #region AzureVmExtensionListSettings
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmExtensionListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmTasks.AzureVmPath;
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string VmName { get; internal set; }
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
              .Add("vm extension list")
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--vm-name {value}", VmName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureVmExtensionSetSettings
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmExtensionSetSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmTasks.AzureVmPath;
        /// <summary><p>Extension name.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>The name of the extension publisher.</p></summary>
        public virtual string Publisher { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string VmName { get; internal set; }
        /// <summary><p>Force to update even if the extension configuration has not changed.</p></summary>
        public virtual string ForceUpdate { get; internal set; }
        /// <summary><p>By doing this, extension system will not pick the highest minor version for the specified version number, and will not auto update to the latest build/revision number on any scale set updates in future.</p></summary>
        public virtual string NoAutoUpgrade { get; internal set; }
        /// <summary><p>Do not wait for the long-running operation to finish.</p></summary>
        public virtual string NoWait { get; internal set; }
        /// <summary><p>Protected settings in JSON format for sensitive information like credentials. A JSON file path is also accepted.</p></summary>
        public virtual string ProtectedSettings { get; internal set; }
        /// <summary><p>Extension settings in JSON format. A JSON file path is also accepted.</p></summary>
        public virtual string Settings { get; internal set; }
        /// <summary><p>The version of the extension.</p></summary>
        public virtual string Version { get; internal set; }
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
              .Add("vm extension set")
              .Add("--name {value}", Name)
              .Add("--publisher {value}", Publisher)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--vm-name {value}", VmName)
              .Add("--force-update {value}", ForceUpdate)
              .Add("--no-auto-upgrade {value}", NoAutoUpgrade)
              .Add("--no-wait {value}", NoWait)
              .Add("--protected-settings {value}", ProtectedSettings)
              .Add("--settings {value}", Settings)
              .Add("--version {value}", Version)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureVmExtensionShowSettings
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmExtensionShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmTasks.AzureVmPath;
        /// <summary><p>Extension name.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string VmName { get; internal set; }
        /// <summary><p>The expand expression to apply on the operation.</p></summary>
        public virtual string Expand { get; internal set; }
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
              .Add("vm extension show")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--vm-name {value}", VmName)
              .Add("--expand {value}", Expand)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureVmExtensionWaitSettings
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmExtensionWaitSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmTasks.AzureVmPath;
        /// <summary><p>Extension name.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string VmName { get; internal set; }
        /// <summary><p>The expand expression to apply on the operation.</p></summary>
        public virtual string Expand { get; internal set; }
        /// <summary><p>Wait until created with 'provisioningState' at 'Succeeded'.</p></summary>
        public virtual string Created { get; internal set; }
        /// <summary><p>Wait until the condition satisfies a custom JMESPath query. E.g. provisioningState!='InProgress', instanceView.statuses[?code=='PowerState/running'].</p></summary>
        public virtual string Custom { get; internal set; }
        /// <summary><p>Wait until deleted.</p></summary>
        public virtual string Deleted { get; internal set; }
        /// <summary><p>Wait until the resource exists.</p></summary>
        public virtual string Exists { get; internal set; }
        /// <summary><p>Polling interval in seconds.</p></summary>
        public virtual string Interval { get; internal set; }
        /// <summary><p>Maximum wait in seconds.</p></summary>
        public virtual string Timeout { get; internal set; }
        /// <summary><p>Wait until updated with provisioningState at 'Succeeded'.</p></summary>
        public virtual string Updated { get; internal set; }
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
              .Add("vm extension wait")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--vm-name {value}", VmName)
              .Add("--expand {value}", Expand)
              .Add("--created {value}", Created)
              .Add("--custom {value}", Custom)
              .Add("--deleted {value}", Deleted)
              .Add("--exists {value}", Exists)
              .Add("--interval {value}", Interval)
              .Add("--timeout {value}", Timeout)
              .Add("--updated {value}", Updated)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureVmIdentityAssignSettings
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmIdentityAssignSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmTasks.AzureVmPath;
        /// <summary><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The identities to assign.</p></summary>
        public virtual string Identities { get; internal set; }
        /// <summary><p>Role name or id the system assigned identity will have.</p></summary>
        public virtual string Role { get; internal set; }
        /// <summary><p>Scope that the system assigned identity can access.</p></summary>
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
              .Add("vm identity assign")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--identities {value}", Identities)
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
    #region AzureVmIdentityRemoveSettings
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmIdentityRemoveSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmTasks.AzureVmPath;
        /// <summary><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Space-separated identities to remove. Use '[system]' to refer system assigned identity.</p></summary>
        public virtual string Identities { get; internal set; }
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
              .Add("vm identity remove")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--identities {value}", Identities)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureVmIdentityShowSettings
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmIdentityShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmTasks.AzureVmPath;
        /// <summary><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
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
              .Add("vm identity show")
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
    #region AzureVmImageAcceptTermsSettings
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmImageAcceptTermsSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmTasks.AzureVmPath;
        /// <summary><p>Image offer.</p></summary>
        public virtual string Offer { get; internal set; }
        /// <summary><p>Image billing plan.</p></summary>
        public virtual string Plan { get; internal set; }
        /// <summary><p>Image publisher.</p></summary>
        public virtual string Publisher { get; internal set; }
        /// <summary><p>URN, in format of 'publisher:offer:sku:version'. If specified, other argument values can be omitted.</p></summary>
        public virtual string Urn { get; internal set; }
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
              .Add("vm image accept-terms")
              .Add("--offer {value}", Offer)
              .Add("--plan {value}", Plan)
              .Add("--publisher {value}", Publisher)
              .Add("--urn {value}", Urn)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureVmImageListSettings
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmImageListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmTasks.AzureVmPath;
        /// <summary><p>Retrieve image list from live Azure service rather using an offline image list.</p></summary>
        public virtual string All { get; internal set; }
        /// <summary><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        public virtual string Location { get; internal set; }
        /// <summary><p>Image offer name, partial name is accepted.</p></summary>
        public virtual string Offer { get; internal set; }
        /// <summary><p>Image publisher name, partial name is accepted.</p></summary>
        public virtual string Publisher { get; internal set; }
        /// <summary><p>Image sku name, partial name is accepted.</p></summary>
        public virtual string Sku { get; internal set; }
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
              .Add("vm image list")
              .Add("--all {value}", All)
              .Add("--location {value}", Location)
              .Add("--offer {value}", Offer)
              .Add("--publisher {value}", Publisher)
              .Add("--sku {value}", Sku)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureVmImageListOffersSettings
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmImageListOffersSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmTasks.AzureVmPath;
        /// <summary><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        public virtual string Location { get; internal set; }
        /// <summary><p>A valid image publisher.</p></summary>
        public virtual string Publisher { get; internal set; }
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
              .Add("vm image list-offers")
              .Add("--location {value}", Location)
              .Add("--publisher {value}", Publisher)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureVmImageListPublishersSettings
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmImageListPublishersSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmTasks.AzureVmPath;
        /// <summary><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        public virtual string Location { get; internal set; }
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
              .Add("vm image list-publishers")
              .Add("--location {value}", Location)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureVmImageListSkusSettings
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmImageListSkusSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmTasks.AzureVmPath;
        /// <summary><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        public virtual string Location { get; internal set; }
        /// <summary><p>Image offer.</p></summary>
        public virtual string Offer { get; internal set; }
        /// <summary><p>A valid image publisher.</p></summary>
        public virtual string Publisher { get; internal set; }
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
              .Add("vm image list-skus")
              .Add("--location {value}", Location)
              .Add("--offer {value}", Offer)
              .Add("--publisher {value}", Publisher)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureVmImageShowSettings
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmImageShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmTasks.AzureVmPath;
        /// <summary><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        public virtual string Location { get; internal set; }
        /// <summary><p>Image offer.</p></summary>
        public virtual string Offer { get; internal set; }
        /// <summary><p>Image publisher.</p></summary>
        public virtual string Publisher { get; internal set; }
        /// <summary><p>Image sku.</p></summary>
        public virtual string Sku { get; internal set; }
        /// <summary><p>URN, in format of 'publisher:offer:sku:version'. If specified, other argument values can be omitted.</p></summary>
        public virtual string Urn { get; internal set; }
        /// <summary><p>Image sku's version.</p></summary>
        public virtual string Version { get; internal set; }
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
              .Add("vm image show")
              .Add("--location {value}", Location)
              .Add("--offer {value}", Offer)
              .Add("--publisher {value}", Publisher)
              .Add("--sku {value}", Sku)
              .Add("--urn {value}", Urn)
              .Add("--version {value}", Version)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureVmNicAddSettings
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmNicAddSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmTasks.AzureVmPath;
        /// <summary><p>Names or IDs of NICs.</p></summary>
        public virtual string Nics { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string VmName { get; internal set; }
        /// <summary><p>Name or ID of the primary NIC. If missing, the first NIC in the list will be the primary.</p></summary>
        public virtual string PrimaryNic { get; internal set; }
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
              .Add("vm nic add")
              .Add("--nics {value}", Nics)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--vm-name {value}", VmName)
              .Add("--primary-nic {value}", PrimaryNic)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureVmNicListSettings
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmNicListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmTasks.AzureVmPath;
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string VmName { get; internal set; }
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
              .Add("vm nic list")
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--vm-name {value}", VmName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureVmNicRemoveSettings
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmNicRemoveSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmTasks.AzureVmPath;
        /// <summary><p>Names or IDs of NICs.</p></summary>
        public virtual string Nics { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string VmName { get; internal set; }
        /// <summary><p>Name or ID of the primary NIC. If missing, the first NIC in the list will be the primary.</p></summary>
        public virtual string PrimaryNic { get; internal set; }
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
              .Add("vm nic remove")
              .Add("--nics {value}", Nics)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--vm-name {value}", VmName)
              .Add("--primary-nic {value}", PrimaryNic)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureVmNicSetSettings
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmNicSetSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmTasks.AzureVmPath;
        /// <summary><p>Names or IDs of NICs.</p></summary>
        public virtual string Nics { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string VmName { get; internal set; }
        /// <summary><p>Name or ID of the primary NIC. If missing, the first NIC in the list will be the primary.</p></summary>
        public virtual string PrimaryNic { get; internal set; }
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
              .Add("vm nic set")
              .Add("--nics {value}", Nics)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--vm-name {value}", VmName)
              .Add("--primary-nic {value}", PrimaryNic)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureVmNicShowSettings
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmNicShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmTasks.AzureVmPath;
        /// <summary><p>NIC name or ID.</p></summary>
        public virtual string Nic { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string VmName { get; internal set; }
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
              .Add("vm nic show")
              .Add("--nic {value}", Nic)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--vm-name {value}", VmName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureVmRunCommandInvokeSettings
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmRunCommandInvokeSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmTasks.AzureVmPath;
        /// <summary><p>The run command ID.</p></summary>
        public virtual string CommandId { get; internal set; }
        /// <summary><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Space-separated parameters in the format of '[name=]value'.</p></summary>
        public virtual string Parameters { get; internal set; }
        /// <summary><p>Script lines separated by whites spaces. Use @{file} to load from a file.</p></summary>
        public virtual string Scripts { get; internal set; }
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
              .Add("vm run-command invoke")
              .Add("--command-id {value}", CommandId)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--parameters {value}", Parameters)
              .Add("--scripts {value}", Scripts)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureVmRunCommandListSettings
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmRunCommandListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmTasks.AzureVmPath;
        /// <summary><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        public virtual string Location { get; internal set; }
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
              .Add("vm run-command list")
              .Add("--location {value}", Location)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureVmRunCommandShowSettings
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmRunCommandShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmTasks.AzureVmPath;
        /// <summary><p>The run command ID.</p></summary>
        public virtual string CommandId { get; internal set; }
        /// <summary><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        public virtual string Location { get; internal set; }
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
              .Add("vm run-command show")
              .Add("--command-id {value}", CommandId)
              .Add("--location {value}", Location)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureVmSecretAddSettings
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmSecretAddSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmTasks.AzureVmPath;
        /// <summary><p>Key vault certificate name or its full secret URL.</p></summary>
        public virtual string Certificate { get; internal set; }
        /// <summary><p>Name or ID of the key vault.</p></summary>
        public virtual string Keyvault { get; internal set; }
        /// <summary><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Windows certificate store names. Default: My.</p></summary>
        public virtual string CertificateStore { get; internal set; }
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
              .Add("vm secret add")
              .Add("--certificate {value}", Certificate)
              .Add("--keyvault {value}", Keyvault)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--certificate-store {value}", CertificateStore)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureVmSecretFormatSettings
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmSecretFormatSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmTasks.AzureVmPath;
        /// <summary><p>Space-separated list of key vault secret URIs. Perhaps, produced by 'az keyvault secret list-versions --vault-name vaultname -n cert1 --query "[?attributes.enabled].id" -o tsv'.</p></summary>
        public virtual IReadOnlyList<string> Secrets => SecretsInternal.AsReadOnly();
        internal List<string> SecretsInternal { get; set; } = new List<string>();
        /// <summary><p>Windows certificate store names. Default: My.</p></summary>
        public virtual string CertificateStore { get; internal set; }
        /// <summary><p>Name or ID of the key vault.</p></summary>
        public virtual string Keyvault { get; internal set; }
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
              .Add("vm secret format")
              .Add("--secrets {value}", Secrets, separator: ' ')
              .Add("--certificate-store {value}", CertificateStore)
              .Add("--keyvault {value}", Keyvault)
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
    #region AzureVmSecretListSettings
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmSecretListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmTasks.AzureVmPath;
        /// <summary><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
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
              .Add("vm secret list")
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
    #region AzureVmSecretRemoveSettings
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmSecretRemoveSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmTasks.AzureVmPath;
        /// <summary><p>Name or ID of the key vault.</p></summary>
        public virtual string Keyvault { get; internal set; }
        /// <summary><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Key vault certificate name or its full secret URL.</p></summary>
        public virtual string Certificate { get; internal set; }
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
              .Add("vm secret remove")
              .Add("--keyvault {value}", Keyvault)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--certificate {value}", Certificate)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureVmUnmanagedDiskAttachSettings
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmUnmanagedDiskAttachSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmTasks.AzureVmPath;
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string VmName { get; internal set; }
        /// <summary><p>Disk caching policy.</p></summary>
        public virtual VmCreateOsDiskCaching Caching { get; internal set; }
        /// <summary><p>0-based logical unit number (LUN). Max value depends on the Virtual Machine size.</p></summary>
        public virtual string Lun { get; internal set; }
        /// <summary><p>The data disk name(optional when create a new disk).</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Create a new disk.</p></summary>
        public virtual string New { get; internal set; }
        /// <summary><p></p></summary>
        public virtual string SizeGb { get; internal set; }
        /// <summary><p>Virtual hard disk URI. For example: <a href="https://mystorage.blob.core.windows.net/vhds/d1.vhd">https://mystorage.blob.core.windows.net/vhds/d1.vhd</a>.</p></summary>
        public virtual string VhdUri { get; internal set; }
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
              .Add("vm unmanaged-disk attach")
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--vm-name {value}", VmName)
              .Add("--caching {value}", Caching)
              .Add("--lun {value}", Lun)
              .Add("--name {value}", Name)
              .Add("--new {value}", New)
              .Add("--size-gb {value}", SizeGb)
              .Add("--vhd-uri {value}", VhdUri)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureVmUnmanagedDiskDetachSettings
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmUnmanagedDiskDetachSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmTasks.AzureVmPath;
        /// <summary><p>The data disk name.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string VmName { get; internal set; }
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
              .Add("vm unmanaged-disk detach")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--vm-name {value}", VmName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureVmUnmanagedDiskListSettings
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmUnmanagedDiskListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmTasks.AzureVmPath;
        /// <summary><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
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
              .Add("vm unmanaged-disk list")
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
    #region AzureVmUserDeleteSettings
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmUserDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmTasks.AzureVmPath;
        /// <summary><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The user name.</p></summary>
        public virtual string Username { get; internal set; }
        /// <summary><p>Do not wait for the long-running operation to finish.</p></summary>
        public virtual string NoWait { get; internal set; }
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
              .Add("vm user delete")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--username {value}", Username)
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
    #region AzureVmUserResetSshSettings
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmUserResetSshSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmTasks.AzureVmPath;
        /// <summary><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Do not wait for the long-running operation to finish.</p></summary>
        public virtual string NoWait { get; internal set; }
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
              .Add("vm user reset-ssh")
              .Add("--name {value}", Name)
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
    #region AzureVmUserUpdateSettings
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmUserUpdateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmTasks.AzureVmPath;
        /// <summary><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The user name.</p></summary>
        public virtual string Username { get; internal set; }
        /// <summary><p>Do not wait for the long-running operation to finish.</p></summary>
        public virtual string NoWait { get; internal set; }
        /// <summary><p>The user password.</p></summary>
        public virtual string Password { get; internal set; }
        /// <summary><p>SSH public key file value or public key file path.</p></summary>
        public virtual string SshKeyValue { get; internal set; }
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
              .Add("vm user update")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--username {value}", Username)
              .Add("--no-wait {value}", NoWait)
              .Add("--password {value}", Password, secret: true)
              .Add("--ssh-key-value {value}", SshKeyValue)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureVmExtensionImageListSettings
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmExtensionImageListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmTasks.AzureVmPath;
        /// <summary><p>Show the latest version only.</p></summary>
        public virtual bool? Latest { get; internal set; }
        /// <summary><p>Image location.</p></summary>
        public virtual string Location { get; internal set; }
        /// <summary><p>Image name.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Image publisher name.</p></summary>
        public virtual string Publisher { get; internal set; }
        /// <summary><p>Extension version.</p></summary>
        public virtual string Version { get; internal set; }
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
              .Add("vm extension image list")
              .Add("--latest", Latest)
              .Add("--location {value}", Location)
              .Add("--name {value}", Name)
              .Add("--publisher {value}", Publisher)
              .Add("--version {value}", Version)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureVmExtensionImageListNamesSettings
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmExtensionImageListNamesSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmTasks.AzureVmPath;
        /// <summary><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        public virtual string Location { get; internal set; }
        /// <summary><p>Image publisher name.</p></summary>
        public virtual string Publisher { get; internal set; }
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
              .Add("vm extension image list-names")
              .Add("--location {value}", Location)
              .Add("--publisher {value}", Publisher)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureVmExtensionImageListVersionsSettings
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmExtensionImageListVersionsSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmTasks.AzureVmPath;
        /// <summary><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        public virtual string Location { get; internal set; }
        /// <summary><p>Name of the extension.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Image publisher name.</p></summary>
        public virtual string Publisher { get; internal set; }
        /// <summary><p>The filter to apply on the operation.</p></summary>
        public virtual string Filter { get; internal set; }
        /// <summary><p>The $orderby odata query option.</p></summary>
        public virtual string Orderby { get; internal set; }
        /// <summary><p>The $top odata query option.</p></summary>
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
              .Add("vm extension image list-versions")
              .Add("--location {value}", Location)
              .Add("--name {value}", Name)
              .Add("--publisher {value}", Publisher)
              .Add("--filter {value}", Filter)
              .Add("--orderby {value}", Orderby)
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
    #region AzureVmExtensionImageShowSettings
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmExtensionImageShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmTasks.AzureVmPath;
        /// <summary><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        public virtual string Location { get; internal set; }
        /// <summary><p>Name of the extension.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Image publisher name.</p></summary>
        public virtual string Publisher { get; internal set; }
        /// <summary><p>Extension version.</p></summary>
        public virtual string Version { get; internal set; }
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
              .Add("vm extension image show")
              .Add("--location {value}", Location)
              .Add("--name {value}", Name)
              .Add("--publisher {value}", Publisher)
              .Add("--version {value}", Version)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureVmCaptureSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmCaptureSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmCaptureSettings.Name"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmCaptureSettings SetName(this AzureVmCaptureSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmCaptureSettings.Name"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmCaptureSettings ResetName(this AzureVmCaptureSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmCaptureSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmCaptureSettings SetResourceGroup(this AzureVmCaptureSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmCaptureSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmCaptureSettings ResetResourceGroup(this AzureVmCaptureSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region VhdNamePrefix
        /// <summary><p><em>Sets <see cref="AzureVmCaptureSettings.VhdNamePrefix"/>.</em></p><p>The VHD name prefix specify for the VM disks.</p></summary>
        [Pure]
        public static AzureVmCaptureSettings SetVhdNamePrefix(this AzureVmCaptureSettings toolSettings, string vhdNamePrefix)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VhdNamePrefix = vhdNamePrefix;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmCaptureSettings.VhdNamePrefix"/>.</em></p><p>The VHD name prefix specify for the VM disks.</p></summary>
        [Pure]
        public static AzureVmCaptureSettings ResetVhdNamePrefix(this AzureVmCaptureSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VhdNamePrefix = null;
            return toolSettings;
        }
        #endregion
        #region Overwrite
        /// <summary><p><em>Sets <see cref="AzureVmCaptureSettings.Overwrite"/>.</em></p><p>Overwrite the existing disk file.</p></summary>
        [Pure]
        public static AzureVmCaptureSettings SetOverwrite(this AzureVmCaptureSettings toolSettings, string overwrite)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Overwrite = overwrite;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmCaptureSettings.Overwrite"/>.</em></p><p>Overwrite the existing disk file.</p></summary>
        [Pure]
        public static AzureVmCaptureSettings ResetOverwrite(this AzureVmCaptureSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Overwrite = null;
            return toolSettings;
        }
        #endregion
        #region StorageContainer
        /// <summary><p><em>Sets <see cref="AzureVmCaptureSettings.StorageContainer"/>.</em></p><p>The storage account container name in which to save the disks.</p></summary>
        [Pure]
        public static AzureVmCaptureSettings SetStorageContainer(this AzureVmCaptureSettings toolSettings, string storageContainer)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageContainer = storageContainer;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmCaptureSettings.StorageContainer"/>.</em></p><p>The storage account container name in which to save the disks.</p></summary>
        [Pure]
        public static AzureVmCaptureSettings ResetStorageContainer(this AzureVmCaptureSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageContainer = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmCaptureSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmCaptureSettings SetDebug(this AzureVmCaptureSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmCaptureSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmCaptureSettings ResetDebug(this AzureVmCaptureSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmCaptureSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmCaptureSettings SetHelp(this AzureVmCaptureSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmCaptureSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmCaptureSettings ResetHelp(this AzureVmCaptureSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmCaptureSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmCaptureSettings SetOutput(this AzureVmCaptureSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmCaptureSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmCaptureSettings ResetOutput(this AzureVmCaptureSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmCaptureSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmCaptureSettings SetQuery(this AzureVmCaptureSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmCaptureSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmCaptureSettings ResetQuery(this AzureVmCaptureSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmCaptureSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmCaptureSettings SetVerbose(this AzureVmCaptureSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmCaptureSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmCaptureSettings ResetVerbose(this AzureVmCaptureSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmConvertSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmConvertSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmConvertSettings.Name"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmConvertSettings SetName(this AzureVmConvertSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmConvertSettings.Name"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmConvertSettings ResetName(this AzureVmConvertSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmConvertSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmConvertSettings SetResourceGroup(this AzureVmConvertSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmConvertSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmConvertSettings ResetResourceGroup(this AzureVmConvertSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmConvertSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmConvertSettings SetDebug(this AzureVmConvertSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmConvertSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmConvertSettings ResetDebug(this AzureVmConvertSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmConvertSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmConvertSettings SetHelp(this AzureVmConvertSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmConvertSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmConvertSettings ResetHelp(this AzureVmConvertSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmConvertSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmConvertSettings SetOutput(this AzureVmConvertSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmConvertSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmConvertSettings ResetOutput(this AzureVmConvertSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmConvertSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmConvertSettings SetQuery(this AzureVmConvertSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmConvertSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmConvertSettings ResetQuery(this AzureVmConvertSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmConvertSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmConvertSettings SetVerbose(this AzureVmConvertSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmConvertSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmConvertSettings ResetVerbose(this AzureVmConvertSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmCreateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmCreateSettings.Name"/>.</em></p><p>Name of the virtual machine.</p></summary>
        [Pure]
        public static AzureVmCreateSettings SetName(this AzureVmCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmCreateSettings.Name"/>.</em></p><p>Name of the virtual machine.</p></summary>
        [Pure]
        public static AzureVmCreateSettings ResetName(this AzureVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmCreateSettings SetResourceGroup(this AzureVmCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmCreateSettings ResetResourceGroup(this AzureVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region AttachDataDisks
        /// <summary><p><em>Sets <see cref="AzureVmCreateSettings.AttachDataDisks"/>.</em></p><p>Attach existing data disks to the VM. Can use the name or ID of a managed disk or the URI to an unmanaged disk VHD.</p></summary>
        [Pure]
        public static AzureVmCreateSettings SetAttachDataDisks(this AzureVmCreateSettings toolSettings, string attachDataDisks)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AttachDataDisks = attachDataDisks;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmCreateSettings.AttachDataDisks"/>.</em></p><p>Attach existing data disks to the VM. Can use the name or ID of a managed disk or the URI to an unmanaged disk VHD.</p></summary>
        [Pure]
        public static AzureVmCreateSettings ResetAttachDataDisks(this AzureVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AttachDataDisks = null;
            return toolSettings;
        }
        #endregion
        #region AttachOsDisk
        /// <summary><p><em>Sets <see cref="AzureVmCreateSettings.AttachOsDisk"/>.</em></p><p>Attach an existing OS disk to the VM. Can use the name or ID of a managed disk or the URI to an unmanaged disk VHD.</p></summary>
        [Pure]
        public static AzureVmCreateSettings SetAttachOsDisk(this AzureVmCreateSettings toolSettings, string attachOsDisk)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AttachOsDisk = attachOsDisk;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmCreateSettings.AttachOsDisk"/>.</em></p><p>Attach an existing OS disk to the VM. Can use the name or ID of a managed disk or the URI to an unmanaged disk VHD.</p></summary>
        [Pure]
        public static AzureVmCreateSettings ResetAttachOsDisk(this AzureVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AttachOsDisk = null;
            return toolSettings;
        }
        #endregion
        #region AvailabilitySet
        /// <summary><p><em>Sets <see cref="AzureVmCreateSettings.AvailabilitySet"/>.</em></p><p>Name or ID of an existing availability set to add the VM to. None by default.</p></summary>
        [Pure]
        public static AzureVmCreateSettings SetAvailabilitySet(this AzureVmCreateSettings toolSettings, string availabilitySet)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AvailabilitySet = availabilitySet;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmCreateSettings.AvailabilitySet"/>.</em></p><p>Name or ID of an existing availability set to add the VM to. None by default.</p></summary>
        [Pure]
        public static AzureVmCreateSettings ResetAvailabilitySet(this AzureVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AvailabilitySet = null;
            return toolSettings;
        }
        #endregion
        #region BootDiagnosticsStorage
        /// <summary><p><em>Sets <see cref="AzureVmCreateSettings.BootDiagnosticsStorage"/>.</em></p><p>Pre-existing storage account name or its blob uri to capture boot diagnostics. Its sku should be one of Standard_GRS, Standard_LRS and Standard_RAGRS.</p></summary>
        [Pure]
        public static AzureVmCreateSettings SetBootDiagnosticsStorage(this AzureVmCreateSettings toolSettings, string bootDiagnosticsStorage)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BootDiagnosticsStorage = bootDiagnosticsStorage;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmCreateSettings.BootDiagnosticsStorage"/>.</em></p><p>Pre-existing storage account name or its blob uri to capture boot diagnostics. Its sku should be one of Standard_GRS, Standard_LRS and Standard_RAGRS.</p></summary>
        [Pure]
        public static AzureVmCreateSettings ResetBootDiagnosticsStorage(this AzureVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BootDiagnosticsStorage = null;
            return toolSettings;
        }
        #endregion
        #region CustomData
        /// <summary><p><em>Sets <see cref="AzureVmCreateSettings.CustomData"/>.</em></p><p>Custom init script file or text (cloud-init, cloud-config, etc..).</p></summary>
        [Pure]
        public static AzureVmCreateSettings SetCustomData(this AzureVmCreateSettings toolSettings, string customData)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CustomData = customData;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmCreateSettings.CustomData"/>.</em></p><p>Custom init script file or text (cloud-init, cloud-config, etc..).</p></summary>
        [Pure]
        public static AzureVmCreateSettings ResetCustomData(this AzureVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CustomData = null;
            return toolSettings;
        }
        #endregion
        #region Image
        /// <summary><p><em>Sets <see cref="AzureVmCreateSettings.Image"/>.</em></p><p>The name of the operating system image as a URN alias, URN, custom image name or ID, or VHD blob URI. This parameter is required unless using `--attach-os-disk.`.</p></summary>
        [Pure]
        public static AzureVmCreateSettings SetImage(this AzureVmCreateSettings toolSettings, string image)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Image = image;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmCreateSettings.Image"/>.</em></p><p>The name of the operating system image as a URN alias, URN, custom image name or ID, or VHD blob URI. This parameter is required unless using `--attach-os-disk.`.</p></summary>
        [Pure]
        public static AzureVmCreateSettings ResetImage(this AzureVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Image = null;
            return toolSettings;
        }
        #endregion
        #region LicenseType
        /// <summary><p><em>Sets <see cref="AzureVmCreateSettings.LicenseType"/>.</em></p><p>License type if the Windows image or disk used was licensed on-premises.</p></summary>
        [Pure]
        public static AzureVmCreateSettings SetLicenseType(this AzureVmCreateSettings toolSettings, VmLicenseType licenseType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LicenseType = licenseType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmCreateSettings.LicenseType"/>.</em></p><p>License type if the Windows image or disk used was licensed on-premises.</p></summary>
        [Pure]
        public static AzureVmCreateSettings ResetLicenseType(this AzureVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LicenseType = null;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary><p><em>Sets <see cref="AzureVmCreateSettings.Location"/>.</em></p><p>Location in which to create VM and related resources. If default location is not configured, will default to the resource group's location.</p></summary>
        [Pure]
        public static AzureVmCreateSettings SetLocation(this AzureVmCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmCreateSettings.Location"/>.</em></p><p>Location in which to create VM and related resources. If default location is not configured, will default to the resource group's location.</p></summary>
        [Pure]
        public static AzureVmCreateSettings ResetLocation(this AzureVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary><p><em>Sets <see cref="AzureVmCreateSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmCreateSettings SetNoWait(this AzureVmCreateSettings toolSettings, string noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmCreateSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmCreateSettings ResetNoWait(this AzureVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        #endregion
        #region Secrets
        /// <summary><p><em>Sets <see cref="AzureVmCreateSettings.Secrets"/>.</em></p><p>One or many Key Vault secrets as JSON strings or files via `@&amp;lt;file path&amp;gt;` containing `[{ "sourceVault": { "id": "value" }, "vaultCertificates": [{ "certificateUrl": "value", "certificateStore": "cert store name (only on windows)"}] }]`.</p></summary>
        [Pure]
        public static AzureVmCreateSettings SetSecrets(this AzureVmCreateSettings toolSettings, string secrets)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Secrets = secrets;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmCreateSettings.Secrets"/>.</em></p><p>One or many Key Vault secrets as JSON strings or files via `@&amp;lt;file path&amp;gt;` containing `[{ "sourceVault": { "id": "value" }, "vaultCertificates": [{ "certificateUrl": "value", "certificateStore": "cert store name (only on windows)"}] }]`.</p></summary>
        [Pure]
        public static AzureVmCreateSettings ResetSecrets(this AzureVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Secrets = null;
            return toolSettings;
        }
        #endregion
        #region Size
        /// <summary><p><em>Sets <see cref="AzureVmCreateSettings.Size"/>.</em></p><p>The VM size to be created. See <a href="https://azure.microsoft.com/en-us/pricing/details/virtual-machines/">https://azure.microsoft.com/en-us/pricing/details/virtual-machines/</a> for size info.</p></summary>
        [Pure]
        public static AzureVmCreateSettings SetSize(this AzureVmCreateSettings toolSettings, string size)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Size = size;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmCreateSettings.Size"/>.</em></p><p>The VM size to be created. See <a href="https://azure.microsoft.com/en-us/pricing/details/virtual-machines/">https://azure.microsoft.com/en-us/pricing/details/virtual-machines/</a> for size info.</p></summary>
        [Pure]
        public static AzureVmCreateSettings ResetSize(this AzureVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Size = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary><p><em>Sets <see cref="AzureVmCreateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureVmCreateSettings SetTags(this AzureVmCreateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmCreateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureVmCreateSettings ResetTags(this AzureVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Validate
        /// <summary><p><em>Sets <see cref="AzureVmCreateSettings.Validate"/>.</em></p><p>Generate and validate the ARM template without creating any resources.</p></summary>
        [Pure]
        public static AzureVmCreateSettings SetValidate(this AzureVmCreateSettings toolSettings, string validate)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Validate = validate;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmCreateSettings.Validate"/>.</em></p><p>Generate and validate the ARM template without creating any resources.</p></summary>
        [Pure]
        public static AzureVmCreateSettings ResetValidate(this AzureVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Validate = null;
            return toolSettings;
        }
        #endregion
        #region Zone
        /// <summary><p><em>Sets <see cref="AzureVmCreateSettings.Zone"/>.</em></p><p>Availability zone into which to provision the resource.</p></summary>
        [Pure]
        public static AzureVmCreateSettings SetZone(this AzureVmCreateSettings toolSettings, VmCreateZone zone)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Zone = zone;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmCreateSettings.Zone"/>.</em></p><p>Availability zone into which to provision the resource.</p></summary>
        [Pure]
        public static AzureVmCreateSettings ResetZone(this AzureVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Zone = null;
            return toolSettings;
        }
        #endregion
        #region AdminPassword
        /// <summary><p><em>Sets <see cref="AzureVmCreateSettings.AdminPassword"/>.</em></p><p>Password for the VM if authentication type is 'Password'.</p></summary>
        [Pure]
        public static AzureVmCreateSettings SetAdminPassword(this AzureVmCreateSettings toolSettings, string adminPassword)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdminPassword = adminPassword;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmCreateSettings.AdminPassword"/>.</em></p><p>Password for the VM if authentication type is 'Password'.</p></summary>
        [Pure]
        public static AzureVmCreateSettings ResetAdminPassword(this AzureVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdminPassword = null;
            return toolSettings;
        }
        #endregion
        #region AdminUsername
        /// <summary><p><em>Sets <see cref="AzureVmCreateSettings.AdminUsername"/>.</em></p><p>Username for the VM.</p></summary>
        [Pure]
        public static AzureVmCreateSettings SetAdminUsername(this AzureVmCreateSettings toolSettings, string adminUsername)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdminUsername = adminUsername;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmCreateSettings.AdminUsername"/>.</em></p><p>Username for the VM.</p></summary>
        [Pure]
        public static AzureVmCreateSettings ResetAdminUsername(this AzureVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdminUsername = null;
            return toolSettings;
        }
        #endregion
        #region AuthenticationType
        /// <summary><p><em>Sets <see cref="AzureVmCreateSettings.AuthenticationType"/>.</em></p><p>Type of authentication to use with the VM. Defaults to password for Windows and SSH public key for Linux.</p></summary>
        [Pure]
        public static AzureVmCreateSettings SetAuthenticationType(this AzureVmCreateSettings toolSettings, VmCreateAuthenticationType authenticationType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AuthenticationType = authenticationType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmCreateSettings.AuthenticationType"/>.</em></p><p>Type of authentication to use with the VM. Defaults to password for Windows and SSH public key for Linux.</p></summary>
        [Pure]
        public static AzureVmCreateSettings ResetAuthenticationType(this AzureVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AuthenticationType = null;
            return toolSettings;
        }
        #endregion
        #region GenerateSshKeys
        /// <summary><p><em>Sets <see cref="AzureVmCreateSettings.GenerateSshKeys"/>.</em></p><p>Generate SSH public and private key files if missing. The keys will be stored in the ~/.ssh directory.</p></summary>
        [Pure]
        public static AzureVmCreateSettings SetGenerateSshKeys(this AzureVmCreateSettings toolSettings, string generateSshKeys)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GenerateSshKeys = generateSshKeys;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmCreateSettings.GenerateSshKeys"/>.</em></p><p>Generate SSH public and private key files if missing. The keys will be stored in the ~/.ssh directory.</p></summary>
        [Pure]
        public static AzureVmCreateSettings ResetGenerateSshKeys(this AzureVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GenerateSshKeys = null;
            return toolSettings;
        }
        #endregion
        #region SshDestKeyPath
        /// <summary><p><em>Sets <see cref="AzureVmCreateSettings.SshDestKeyPath"/>.</em></p><p>Destination file path on the VM for the SSH key.</p></summary>
        [Pure]
        public static AzureVmCreateSettings SetSshDestKeyPath(this AzureVmCreateSettings toolSettings, string sshDestKeyPath)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SshDestKeyPath = sshDestKeyPath;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmCreateSettings.SshDestKeyPath"/>.</em></p><p>Destination file path on the VM for the SSH key.</p></summary>
        [Pure]
        public static AzureVmCreateSettings ResetSshDestKeyPath(this AzureVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SshDestKeyPath = null;
            return toolSettings;
        }
        #endregion
        #region SshKeyValue
        /// <summary><p><em>Sets <see cref="AzureVmCreateSettings.SshKeyValue"/>.</em></p><p>The SSH public key or public key file path.</p></summary>
        [Pure]
        public static AzureVmCreateSettings SetSshKeyValue(this AzureVmCreateSettings toolSettings, string sshKeyValue)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SshKeyValue = sshKeyValue;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmCreateSettings.SshKeyValue"/>.</em></p><p>The SSH public key or public key file path.</p></summary>
        [Pure]
        public static AzureVmCreateSettings ResetSshKeyValue(this AzureVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SshKeyValue = null;
            return toolSettings;
        }
        #endregion
        #region AssignIdentity
        /// <summary><p><em>Sets <see cref="AzureVmCreateSettings.AssignIdentity"/>.</em></p><p>Accept system or user assigned identities separated by spaces. Use '[system]' to refer system assigned identity, or a resource id to refer user assigned identity. Check out help for more examples.</p></summary>
        [Pure]
        public static AzureVmCreateSettings SetAssignIdentity(this AzureVmCreateSettings toolSettings, string assignIdentity)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AssignIdentity = assignIdentity;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmCreateSettings.AssignIdentity"/>.</em></p><p>Accept system or user assigned identities separated by spaces. Use '[system]' to refer system assigned identity, or a resource id to refer user assigned identity. Check out help for more examples.</p></summary>
        [Pure]
        public static AzureVmCreateSettings ResetAssignIdentity(this AzureVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AssignIdentity = null;
            return toolSettings;
        }
        #endregion
        #region Role
        /// <summary><p><em>Sets <see cref="AzureVmCreateSettings.Role"/>.</em></p><p>Role name or id the system assigned identity will have.</p></summary>
        [Pure]
        public static AzureVmCreateSettings SetRole(this AzureVmCreateSettings toolSettings, string role)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Role = role;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmCreateSettings.Role"/>.</em></p><p>Role name or id the system assigned identity will have.</p></summary>
        [Pure]
        public static AzureVmCreateSettings ResetRole(this AzureVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Role = null;
            return toolSettings;
        }
        #endregion
        #region Scope
        /// <summary><p><em>Sets <see cref="AzureVmCreateSettings.Scope"/>.</em></p><p>Scope that the system assigned identity can access.</p></summary>
        [Pure]
        public static AzureVmCreateSettings SetScope(this AzureVmCreateSettings toolSettings, string scope)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Scope = scope;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmCreateSettings.Scope"/>.</em></p><p>Scope that the system assigned identity can access.</p></summary>
        [Pure]
        public static AzureVmCreateSettings ResetScope(this AzureVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Scope = null;
            return toolSettings;
        }
        #endregion
        #region PlanName
        /// <summary><p><em>Sets <see cref="AzureVmCreateSettings.PlanName"/>.</em></p><p>Plan name.</p></summary>
        [Pure]
        public static AzureVmCreateSettings SetPlanName(this AzureVmCreateSettings toolSettings, string planName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PlanName = planName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmCreateSettings.PlanName"/>.</em></p><p>Plan name.</p></summary>
        [Pure]
        public static AzureVmCreateSettings ResetPlanName(this AzureVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PlanName = null;
            return toolSettings;
        }
        #endregion
        #region PlanProduct
        /// <summary><p><em>Sets <see cref="AzureVmCreateSettings.PlanProduct"/>.</em></p><p>Plan product.</p></summary>
        [Pure]
        public static AzureVmCreateSettings SetPlanProduct(this AzureVmCreateSettings toolSettings, string planProduct)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PlanProduct = planProduct;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmCreateSettings.PlanProduct"/>.</em></p><p>Plan product.</p></summary>
        [Pure]
        public static AzureVmCreateSettings ResetPlanProduct(this AzureVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PlanProduct = null;
            return toolSettings;
        }
        #endregion
        #region PlanPromotionCode
        /// <summary><p><em>Sets <see cref="AzureVmCreateSettings.PlanPromotionCode"/>.</em></p><p>Plan promotion code.</p></summary>
        [Pure]
        public static AzureVmCreateSettings SetPlanPromotionCode(this AzureVmCreateSettings toolSettings, string planPromotionCode)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PlanPromotionCode = planPromotionCode;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmCreateSettings.PlanPromotionCode"/>.</em></p><p>Plan promotion code.</p></summary>
        [Pure]
        public static AzureVmCreateSettings ResetPlanPromotionCode(this AzureVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PlanPromotionCode = null;
            return toolSettings;
        }
        #endregion
        #region PlanPublisher
        /// <summary><p><em>Sets <see cref="AzureVmCreateSettings.PlanPublisher"/>.</em></p><p>Plan publisher.</p></summary>
        [Pure]
        public static AzureVmCreateSettings SetPlanPublisher(this AzureVmCreateSettings toolSettings, string planPublisher)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PlanPublisher = planPublisher;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmCreateSettings.PlanPublisher"/>.</em></p><p>Plan publisher.</p></summary>
        [Pure]
        public static AzureVmCreateSettings ResetPlanPublisher(this AzureVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PlanPublisher = null;
            return toolSettings;
        }
        #endregion
        #region AcceleratedNetworking
        /// <summary><p><em>Sets <see cref="AzureVmCreateSettings.AcceleratedNetworking"/>.</em></p><p>Enable accelerated networking. Unless specified, CLI will enable it based on machine image and size.</p></summary>
        [Pure]
        public static AzureVmCreateSettings SetAcceleratedNetworking(this AzureVmCreateSettings toolSettings, bool? acceleratedNetworking)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AcceleratedNetworking = acceleratedNetworking;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmCreateSettings.AcceleratedNetworking"/>.</em></p><p>Enable accelerated networking. Unless specified, CLI will enable it based on machine image and size.</p></summary>
        [Pure]
        public static AzureVmCreateSettings ResetAcceleratedNetworking(this AzureVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AcceleratedNetworking = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureVmCreateSettings.AcceleratedNetworking"/>.</em></p><p>Enable accelerated networking. Unless specified, CLI will enable it based on machine image and size.</p></summary>
        [Pure]
        public static AzureVmCreateSettings EnableAcceleratedNetworking(this AzureVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AcceleratedNetworking = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureVmCreateSettings.AcceleratedNetworking"/>.</em></p><p>Enable accelerated networking. Unless specified, CLI will enable it based on machine image and size.</p></summary>
        [Pure]
        public static AzureVmCreateSettings DisableAcceleratedNetworking(this AzureVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AcceleratedNetworking = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureVmCreateSettings.AcceleratedNetworking"/>.</em></p><p>Enable accelerated networking. Unless specified, CLI will enable it based on machine image and size.</p></summary>
        [Pure]
        public static AzureVmCreateSettings ToggleAcceleratedNetworking(this AzureVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AcceleratedNetworking = !toolSettings.AcceleratedNetworking;
            return toolSettings;
        }
        #endregion
        #region Asgs
        /// <summary><p><em>Sets <see cref="AzureVmCreateSettings.Asgs"/> to a new list.</em></p><p>Space-separated list of existing application security groups to associate with the VM.</p></summary>
        [Pure]
        public static AzureVmCreateSettings SetAsgs(this AzureVmCreateSettings toolSettings, params string[] asgs)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AsgsInternal = asgs.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureVmCreateSettings.Asgs"/> to a new list.</em></p><p>Space-separated list of existing application security groups to associate with the VM.</p></summary>
        [Pure]
        public static AzureVmCreateSettings SetAsgs(this AzureVmCreateSettings toolSettings, IEnumerable<string> asgs)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AsgsInternal = asgs.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmCreateSettings.Asgs"/>.</em></p><p>Space-separated list of existing application security groups to associate with the VM.</p></summary>
        [Pure]
        public static AzureVmCreateSettings AddAsgs(this AzureVmCreateSettings toolSettings, params string[] asgs)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AsgsInternal.AddRange(asgs);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmCreateSettings.Asgs"/>.</em></p><p>Space-separated list of existing application security groups to associate with the VM.</p></summary>
        [Pure]
        public static AzureVmCreateSettings AddAsgs(this AzureVmCreateSettings toolSettings, IEnumerable<string> asgs)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AsgsInternal.AddRange(asgs);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureVmCreateSettings.Asgs"/>.</em></p><p>Space-separated list of existing application security groups to associate with the VM.</p></summary>
        [Pure]
        public static AzureVmCreateSettings ClearAsgs(this AzureVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AsgsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmCreateSettings.Asgs"/>.</em></p><p>Space-separated list of existing application security groups to associate with the VM.</p></summary>
        [Pure]
        public static AzureVmCreateSettings RemoveAsgs(this AzureVmCreateSettings toolSettings, params string[] asgs)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(asgs);
            toolSettings.AsgsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmCreateSettings.Asgs"/>.</em></p><p>Space-separated list of existing application security groups to associate with the VM.</p></summary>
        [Pure]
        public static AzureVmCreateSettings RemoveAsgs(this AzureVmCreateSettings toolSettings, IEnumerable<string> asgs)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(asgs);
            toolSettings.AsgsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Nics
        /// <summary><p><em>Sets <see cref="AzureVmCreateSettings.Nics"/>.</em></p><p>Names or IDs of existing NICs to attach to the VM. The first NIC will be designated as primary. If omitted, a new NIC will be created. If an existing NIC is specified, do not specify subnet, VNet, public IP or NSG.</p></summary>
        [Pure]
        public static AzureVmCreateSettings SetNics(this AzureVmCreateSettings toolSettings, string nics)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Nics = nics;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmCreateSettings.Nics"/>.</em></p><p>Names or IDs of existing NICs to attach to the VM. The first NIC will be designated as primary. If omitted, a new NIC will be created. If an existing NIC is specified, do not specify subnet, VNet, public IP or NSG.</p></summary>
        [Pure]
        public static AzureVmCreateSettings ResetNics(this AzureVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Nics = null;
            return toolSettings;
        }
        #endregion
        #region Nsg
        /// <summary><p><em>Sets <see cref="AzureVmCreateSettings.Nsg"/>.</em></p><p>The name to use when creating a new Network Security Group (default) or referencing an existing one. Can also reference an existing NSG by ID or specify "" for none.</p></summary>
        [Pure]
        public static AzureVmCreateSettings SetNsg(this AzureVmCreateSettings toolSettings, string nsg)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Nsg = nsg;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmCreateSettings.Nsg"/>.</em></p><p>The name to use when creating a new Network Security Group (default) or referencing an existing one. Can also reference an existing NSG by ID or specify "" for none.</p></summary>
        [Pure]
        public static AzureVmCreateSettings ResetNsg(this AzureVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Nsg = null;
            return toolSettings;
        }
        #endregion
        #region NsgRule
        /// <summary><p><em>Sets <see cref="AzureVmCreateSettings.NsgRule"/>.</em></p><p>NSG rule to create when creating a new NSG. Defaults to open ports for allowing RDP on Windows and allowing SSH on Linux.</p></summary>
        [Pure]
        public static AzureVmCreateSettings SetNsgRule(this AzureVmCreateSettings toolSettings, VmCreateNsgRule nsgRule)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NsgRule = nsgRule;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmCreateSettings.NsgRule"/>.</em></p><p>NSG rule to create when creating a new NSG. Defaults to open ports for allowing RDP on Windows and allowing SSH on Linux.</p></summary>
        [Pure]
        public static AzureVmCreateSettings ResetNsgRule(this AzureVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NsgRule = null;
            return toolSettings;
        }
        #endregion
        #region PrivateIpAddress
        /// <summary><p><em>Sets <see cref="AzureVmCreateSettings.PrivateIpAddress"/>.</em></p><p>Static private IP address (e.g. 10.0.0.5).</p></summary>
        [Pure]
        public static AzureVmCreateSettings SetPrivateIpAddress(this AzureVmCreateSettings toolSettings, string privateIpAddress)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PrivateIpAddress = privateIpAddress;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmCreateSettings.PrivateIpAddress"/>.</em></p><p>Static private IP address (e.g. 10.0.0.5).</p></summary>
        [Pure]
        public static AzureVmCreateSettings ResetPrivateIpAddress(this AzureVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PrivateIpAddress = null;
            return toolSettings;
        }
        #endregion
        #region PublicIpAddress
        /// <summary><p><em>Sets <see cref="AzureVmCreateSettings.PublicIpAddress"/>.</em></p><p>Name of the public IP address when creating one (default) or referencing an existing one. Can also reference an existing public IP by ID or specify "" for None.</p></summary>
        [Pure]
        public static AzureVmCreateSettings SetPublicIpAddress(this AzureVmCreateSettings toolSettings, string publicIpAddress)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PublicIpAddress = publicIpAddress;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmCreateSettings.PublicIpAddress"/>.</em></p><p>Name of the public IP address when creating one (default) or referencing an existing one. Can also reference an existing public IP by ID or specify "" for None.</p></summary>
        [Pure]
        public static AzureVmCreateSettings ResetPublicIpAddress(this AzureVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PublicIpAddress = null;
            return toolSettings;
        }
        #endregion
        #region PublicIpAddressAllocation
        /// <summary><p><em>Sets <see cref="AzureVmCreateSettings.PublicIpAddressAllocation"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureVmCreateSettings SetPublicIpAddressAllocation(this AzureVmCreateSettings toolSettings, VmCreatePublicIpAddressAllocation publicIpAddressAllocation)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PublicIpAddressAllocation = publicIpAddressAllocation;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmCreateSettings.PublicIpAddressAllocation"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureVmCreateSettings ResetPublicIpAddressAllocation(this AzureVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PublicIpAddressAllocation = null;
            return toolSettings;
        }
        #endregion
        #region PublicIpAddressDnsName
        /// <summary><p><em>Sets <see cref="AzureVmCreateSettings.PublicIpAddressDnsName"/>.</em></p><p>Globally unique DNS name for a newly created public IP.</p></summary>
        [Pure]
        public static AzureVmCreateSettings SetPublicIpAddressDnsName(this AzureVmCreateSettings toolSettings, string publicIpAddressDnsName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PublicIpAddressDnsName = publicIpAddressDnsName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmCreateSettings.PublicIpAddressDnsName"/>.</em></p><p>Globally unique DNS name for a newly created public IP.</p></summary>
        [Pure]
        public static AzureVmCreateSettings ResetPublicIpAddressDnsName(this AzureVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PublicIpAddressDnsName = null;
            return toolSettings;
        }
        #endregion
        #region PublicIpSku
        /// <summary><p><em>Sets <see cref="AzureVmCreateSettings.PublicIpSku"/>.</em></p><p>Sku.</p></summary>
        [Pure]
        public static AzureVmCreateSettings SetPublicIpSku(this AzureVmCreateSettings toolSettings, VmCreatePublicIpSku publicIpSku)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PublicIpSku = publicIpSku;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmCreateSettings.PublicIpSku"/>.</em></p><p>Sku.</p></summary>
        [Pure]
        public static AzureVmCreateSettings ResetPublicIpSku(this AzureVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PublicIpSku = null;
            return toolSettings;
        }
        #endregion
        #region Subnet
        /// <summary><p><em>Sets <see cref="AzureVmCreateSettings.Subnet"/>.</em></p><p>The name of the subnet when creating a new VNet or referencing an existing one. Can also reference an existing subnet by ID. If omitted, an appropriate VNet and subnet will be selected automatically, or a new one will be created.</p></summary>
        [Pure]
        public static AzureVmCreateSettings SetSubnet(this AzureVmCreateSettings toolSettings, string subnet)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subnet = subnet;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmCreateSettings.Subnet"/>.</em></p><p>The name of the subnet when creating a new VNet or referencing an existing one. Can also reference an existing subnet by ID. If omitted, an appropriate VNet and subnet will be selected automatically, or a new one will be created.</p></summary>
        [Pure]
        public static AzureVmCreateSettings ResetSubnet(this AzureVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subnet = null;
            return toolSettings;
        }
        #endregion
        #region SubnetAddressPrefix
        /// <summary><p><em>Sets <see cref="AzureVmCreateSettings.SubnetAddressPrefix"/>.</em></p><p>The subnet IP address prefix to use when creating a new VNet in CIDR format.</p></summary>
        [Pure]
        public static AzureVmCreateSettings SetSubnetAddressPrefix(this AzureVmCreateSettings toolSettings, string subnetAddressPrefix)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SubnetAddressPrefix = subnetAddressPrefix;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmCreateSettings.SubnetAddressPrefix"/>.</em></p><p>The subnet IP address prefix to use when creating a new VNet in CIDR format.</p></summary>
        [Pure]
        public static AzureVmCreateSettings ResetSubnetAddressPrefix(this AzureVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SubnetAddressPrefix = null;
            return toolSettings;
        }
        #endregion
        #region VnetAddressPrefix
        /// <summary><p><em>Sets <see cref="AzureVmCreateSettings.VnetAddressPrefix"/>.</em></p><p>The IP address prefix to use when creating a new VNet in CIDR format.</p></summary>
        [Pure]
        public static AzureVmCreateSettings SetVnetAddressPrefix(this AzureVmCreateSettings toolSettings, string vnetAddressPrefix)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VnetAddressPrefix = vnetAddressPrefix;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmCreateSettings.VnetAddressPrefix"/>.</em></p><p>The IP address prefix to use when creating a new VNet in CIDR format.</p></summary>
        [Pure]
        public static AzureVmCreateSettings ResetVnetAddressPrefix(this AzureVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VnetAddressPrefix = null;
            return toolSettings;
        }
        #endregion
        #region VnetName
        /// <summary><p><em>Sets <see cref="AzureVmCreateSettings.VnetName"/>.</em></p><p>Name of the virtual network when creating a new one or referencing an existing one.</p></summary>
        [Pure]
        public static AzureVmCreateSettings SetVnetName(this AzureVmCreateSettings toolSettings, string vnetName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VnetName = vnetName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmCreateSettings.VnetName"/>.</em></p><p>Name of the virtual network when creating a new one or referencing an existing one.</p></summary>
        [Pure]
        public static AzureVmCreateSettings ResetVnetName(this AzureVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VnetName = null;
            return toolSettings;
        }
        #endregion
        #region DataDiskCaching
        /// <summary><p><em>Sets <see cref="AzureVmCreateSettings.DataDiskCaching"/>.</em></p><p>Storage caching type for data disk(s), including 'None', 'ReadOnly', 'ReadWrite', etc. Use a singular value to apply on all disks, or use '&lt;lun&gt;=&lt;vaule1&gt; &lt;lun&gt;=&lt;value2&gt;' to configure individual disk.</p></summary>
        [Pure]
        public static AzureVmCreateSettings SetDataDiskCaching(this AzureVmCreateSettings toolSettings, string dataDiskCaching)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DataDiskCaching = dataDiskCaching;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmCreateSettings.DataDiskCaching"/>.</em></p><p>Storage caching type for data disk(s), including 'None', 'ReadOnly', 'ReadWrite', etc. Use a singular value to apply on all disks, or use '&lt;lun&gt;=&lt;vaule1&gt; &lt;lun&gt;=&lt;value2&gt;' to configure individual disk.</p></summary>
        [Pure]
        public static AzureVmCreateSettings ResetDataDiskCaching(this AzureVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DataDiskCaching = null;
            return toolSettings;
        }
        #endregion
        #region DataDiskSizesGb
        /// <summary><p><em>Sets <see cref="AzureVmCreateSettings.DataDiskSizesGb"/>.</em></p><p>Space-separated empty managed data disk sizes in GB to create.</p></summary>
        [Pure]
        public static AzureVmCreateSettings SetDataDiskSizesGb(this AzureVmCreateSettings toolSettings, string dataDiskSizesGb)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DataDiskSizesGb = dataDiskSizesGb;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmCreateSettings.DataDiskSizesGb"/>.</em></p><p>Space-separated empty managed data disk sizes in GB to create.</p></summary>
        [Pure]
        public static AzureVmCreateSettings ResetDataDiskSizesGb(this AzureVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DataDiskSizesGb = null;
            return toolSettings;
        }
        #endregion
        #region OsDiskCaching
        /// <summary><p><em>Sets <see cref="AzureVmCreateSettings.OsDiskCaching"/>.</em></p><p>Storage caching type for the VM OS disk. Default: ReadWrite.</p></summary>
        [Pure]
        public static AzureVmCreateSettings SetOsDiskCaching(this AzureVmCreateSettings toolSettings, VmCreateOsDiskCaching osDiskCaching)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OsDiskCaching = osDiskCaching;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmCreateSettings.OsDiskCaching"/>.</em></p><p>Storage caching type for the VM OS disk. Default: ReadWrite.</p></summary>
        [Pure]
        public static AzureVmCreateSettings ResetOsDiskCaching(this AzureVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OsDiskCaching = null;
            return toolSettings;
        }
        #endregion
        #region OsDiskName
        /// <summary><p><em>Sets <see cref="AzureVmCreateSettings.OsDiskName"/>.</em></p><p>The name of the new VM OS disk.</p></summary>
        [Pure]
        public static AzureVmCreateSettings SetOsDiskName(this AzureVmCreateSettings toolSettings, string osDiskName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OsDiskName = osDiskName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmCreateSettings.OsDiskName"/>.</em></p><p>The name of the new VM OS disk.</p></summary>
        [Pure]
        public static AzureVmCreateSettings ResetOsDiskName(this AzureVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OsDiskName = null;
            return toolSettings;
        }
        #endregion
        #region OsDiskSizeGb
        /// <summary><p><em>Sets <see cref="AzureVmCreateSettings.OsDiskSizeGb"/>.</em></p><p>The size of the os disk in GB.</p></summary>
        [Pure]
        public static AzureVmCreateSettings SetOsDiskSizeGb(this AzureVmCreateSettings toolSettings, string osDiskSizeGb)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OsDiskSizeGb = osDiskSizeGb;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmCreateSettings.OsDiskSizeGb"/>.</em></p><p>The size of the os disk in GB.</p></summary>
        [Pure]
        public static AzureVmCreateSettings ResetOsDiskSizeGb(this AzureVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OsDiskSizeGb = null;
            return toolSettings;
        }
        #endregion
        #region OsType
        /// <summary><p><em>Sets <see cref="AzureVmCreateSettings.OsType"/>.</em></p><p>Type of OS installed on a custom VHD. Do not use when specifying an URN or URN alias.</p></summary>
        [Pure]
        public static AzureVmCreateSettings SetOsType(this AzureVmCreateSettings toolSettings, VmCreateOsType osType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OsType = osType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmCreateSettings.OsType"/>.</em></p><p>Type of OS installed on a custom VHD. Do not use when specifying an URN or URN alias.</p></summary>
        [Pure]
        public static AzureVmCreateSettings ResetOsType(this AzureVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OsType = null;
            return toolSettings;
        }
        #endregion
        #region StorageAccount
        /// <summary><p><em>Sets <see cref="AzureVmCreateSettings.StorageAccount"/>.</em></p><p>Only applicable when used with `--use-unmanaged-disk`. The name to use when creating a new storage account or referencing an existing one. If omitted, an appropriate storage account in the same resource group and location will be used, or a new one will be created.</p></summary>
        [Pure]
        public static AzureVmCreateSettings SetStorageAccount(this AzureVmCreateSettings toolSettings, string storageAccount)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageAccount = storageAccount;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmCreateSettings.StorageAccount"/>.</em></p><p>Only applicable when used with `--use-unmanaged-disk`. The name to use when creating a new storage account or referencing an existing one. If omitted, an appropriate storage account in the same resource group and location will be used, or a new one will be created.</p></summary>
        [Pure]
        public static AzureVmCreateSettings ResetStorageAccount(this AzureVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageAccount = null;
            return toolSettings;
        }
        #endregion
        #region StorageContainerName
        /// <summary><p><em>Sets <see cref="AzureVmCreateSettings.StorageContainerName"/>.</em></p><p>Only applicable when used with `--use-unmanaged-disk`. Name of the storage container for the VM OS disk. Default: vhds.</p></summary>
        [Pure]
        public static AzureVmCreateSettings SetStorageContainerName(this AzureVmCreateSettings toolSettings, string storageContainerName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageContainerName = storageContainerName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmCreateSettings.StorageContainerName"/>.</em></p><p>Only applicable when used with `--use-unmanaged-disk`. Name of the storage container for the VM OS disk. Default: vhds.</p></summary>
        [Pure]
        public static AzureVmCreateSettings ResetStorageContainerName(this AzureVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageContainerName = null;
            return toolSettings;
        }
        #endregion
        #region StorageSku
        /// <summary><p><em>Sets <see cref="AzureVmCreateSettings.StorageSku"/>.</em></p><p>The SKU of the storage account with which to persist VM.</p></summary>
        [Pure]
        public static AzureVmCreateSettings SetStorageSku(this AzureVmCreateSettings toolSettings, VmCreateStorageSku storageSku)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageSku = storageSku;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmCreateSettings.StorageSku"/>.</em></p><p>The SKU of the storage account with which to persist VM.</p></summary>
        [Pure]
        public static AzureVmCreateSettings ResetStorageSku(this AzureVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageSku = null;
            return toolSettings;
        }
        #endregion
        #region UseUnmanagedDisk
        /// <summary><p><em>Sets <see cref="AzureVmCreateSettings.UseUnmanagedDisk"/>.</em></p><p>Do not use managed disk to persist VM.</p></summary>
        [Pure]
        public static AzureVmCreateSettings SetUseUnmanagedDisk(this AzureVmCreateSettings toolSettings, string useUnmanagedDisk)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UseUnmanagedDisk = useUnmanagedDisk;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmCreateSettings.UseUnmanagedDisk"/>.</em></p><p>Do not use managed disk to persist VM.</p></summary>
        [Pure]
        public static AzureVmCreateSettings ResetUseUnmanagedDisk(this AzureVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UseUnmanagedDisk = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmCreateSettings SetDebug(this AzureVmCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmCreateSettings ResetDebug(this AzureVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmCreateSettings SetHelp(this AzureVmCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmCreateSettings ResetHelp(this AzureVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmCreateSettings SetOutput(this AzureVmCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmCreateSettings ResetOutput(this AzureVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmCreateSettings SetQuery(this AzureVmCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmCreateSettings ResetQuery(this AzureVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmCreateSettings SetVerbose(this AzureVmCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmCreateSettings ResetVerbose(this AzureVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmDeallocateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmDeallocateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmDeallocateSettings.Name"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmDeallocateSettings SetName(this AzureVmDeallocateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmDeallocateSettings.Name"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmDeallocateSettings ResetName(this AzureVmDeallocateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmDeallocateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmDeallocateSettings SetResourceGroup(this AzureVmDeallocateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmDeallocateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmDeallocateSettings ResetResourceGroup(this AzureVmDeallocateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary><p><em>Sets <see cref="AzureVmDeallocateSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmDeallocateSettings SetNoWait(this AzureVmDeallocateSettings toolSettings, string noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmDeallocateSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmDeallocateSettings ResetNoWait(this AzureVmDeallocateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmDeallocateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmDeallocateSettings SetDebug(this AzureVmDeallocateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmDeallocateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmDeallocateSettings ResetDebug(this AzureVmDeallocateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmDeallocateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmDeallocateSettings SetHelp(this AzureVmDeallocateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmDeallocateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmDeallocateSettings ResetHelp(this AzureVmDeallocateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmDeallocateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmDeallocateSettings SetOutput(this AzureVmDeallocateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmDeallocateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmDeallocateSettings ResetOutput(this AzureVmDeallocateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmDeallocateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmDeallocateSettings SetQuery(this AzureVmDeallocateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmDeallocateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmDeallocateSettings ResetQuery(this AzureVmDeallocateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmDeallocateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmDeallocateSettings SetVerbose(this AzureVmDeallocateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmDeallocateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmDeallocateSettings ResetVerbose(this AzureVmDeallocateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmDeleteSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmDeleteSettings.Name"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmDeleteSettings SetName(this AzureVmDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmDeleteSettings.Name"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmDeleteSettings ResetName(this AzureVmDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmDeleteSettings SetResourceGroup(this AzureVmDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmDeleteSettings ResetResourceGroup(this AzureVmDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary><p><em>Sets <see cref="AzureVmDeleteSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmDeleteSettings SetNoWait(this AzureVmDeleteSettings toolSettings, string noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmDeleteSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmDeleteSettings ResetNoWait(this AzureVmDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        #endregion
        #region Yes
        /// <summary><p><em>Sets <see cref="AzureVmDeleteSettings.Yes"/>.</em></p><p>Do not prompt for confirmation.</p></summary>
        [Pure]
        public static AzureVmDeleteSettings SetYes(this AzureVmDeleteSettings toolSettings, string yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmDeleteSettings.Yes"/>.</em></p><p>Do not prompt for confirmation.</p></summary>
        [Pure]
        public static AzureVmDeleteSettings ResetYes(this AzureVmDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmDeleteSettings SetDebug(this AzureVmDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmDeleteSettings ResetDebug(this AzureVmDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmDeleteSettings SetHelp(this AzureVmDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmDeleteSettings ResetHelp(this AzureVmDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmDeleteSettings SetOutput(this AzureVmDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmDeleteSettings ResetOutput(this AzureVmDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmDeleteSettings SetQuery(this AzureVmDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmDeleteSettings ResetQuery(this AzureVmDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmDeleteSettings SetVerbose(this AzureVmDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmDeleteSettings ResetVerbose(this AzureVmDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmGeneralizeSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmGeneralizeSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmGeneralizeSettings.Name"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmGeneralizeSettings SetName(this AzureVmGeneralizeSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmGeneralizeSettings.Name"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmGeneralizeSettings ResetName(this AzureVmGeneralizeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmGeneralizeSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmGeneralizeSettings SetResourceGroup(this AzureVmGeneralizeSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmGeneralizeSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmGeneralizeSettings ResetResourceGroup(this AzureVmGeneralizeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary><p><em>Sets <see cref="AzureVmGeneralizeSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmGeneralizeSettings SetNoWait(this AzureVmGeneralizeSettings toolSettings, string noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmGeneralizeSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmGeneralizeSettings ResetNoWait(this AzureVmGeneralizeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmGeneralizeSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmGeneralizeSettings SetDebug(this AzureVmGeneralizeSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmGeneralizeSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmGeneralizeSettings ResetDebug(this AzureVmGeneralizeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmGeneralizeSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmGeneralizeSettings SetHelp(this AzureVmGeneralizeSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmGeneralizeSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmGeneralizeSettings ResetHelp(this AzureVmGeneralizeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmGeneralizeSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmGeneralizeSettings SetOutput(this AzureVmGeneralizeSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmGeneralizeSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmGeneralizeSettings ResetOutput(this AzureVmGeneralizeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmGeneralizeSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmGeneralizeSettings SetQuery(this AzureVmGeneralizeSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmGeneralizeSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmGeneralizeSettings ResetQuery(this AzureVmGeneralizeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmGeneralizeSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmGeneralizeSettings SetVerbose(this AzureVmGeneralizeSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmGeneralizeSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmGeneralizeSettings ResetVerbose(this AzureVmGeneralizeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmGetInstanceViewSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmGetInstanceViewSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmGetInstanceViewSettings.Name"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmGetInstanceViewSettings SetName(this AzureVmGetInstanceViewSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmGetInstanceViewSettings.Name"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmGetInstanceViewSettings ResetName(this AzureVmGetInstanceViewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmGetInstanceViewSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmGetInstanceViewSettings SetResourceGroup(this AzureVmGetInstanceViewSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmGetInstanceViewSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmGetInstanceViewSettings ResetResourceGroup(this AzureVmGetInstanceViewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmGetInstanceViewSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmGetInstanceViewSettings SetDebug(this AzureVmGetInstanceViewSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmGetInstanceViewSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmGetInstanceViewSettings ResetDebug(this AzureVmGetInstanceViewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmGetInstanceViewSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmGetInstanceViewSettings SetHelp(this AzureVmGetInstanceViewSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmGetInstanceViewSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmGetInstanceViewSettings ResetHelp(this AzureVmGetInstanceViewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmGetInstanceViewSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmGetInstanceViewSettings SetOutput(this AzureVmGetInstanceViewSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmGetInstanceViewSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmGetInstanceViewSettings ResetOutput(this AzureVmGetInstanceViewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmGetInstanceViewSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmGetInstanceViewSettings SetQuery(this AzureVmGetInstanceViewSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmGetInstanceViewSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmGetInstanceViewSettings ResetQuery(this AzureVmGetInstanceViewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmGetInstanceViewSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmGetInstanceViewSettings SetVerbose(this AzureVmGetInstanceViewSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmGetInstanceViewSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmGetInstanceViewSettings ResetVerbose(this AzureVmGetInstanceViewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmListSettings SetResourceGroup(this AzureVmListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmListSettings ResetResourceGroup(this AzureVmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ShowDetails
        /// <summary><p><em>Sets <see cref="AzureVmListSettings.ShowDetails"/>.</em></p><p>Show public ip address, FQDN, and power states. command will run slow.</p></summary>
        [Pure]
        public static AzureVmListSettings SetShowDetails(this AzureVmListSettings toolSettings, bool? showDetails)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowDetails = showDetails;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmListSettings.ShowDetails"/>.</em></p><p>Show public ip address, FQDN, and power states. command will run slow.</p></summary>
        [Pure]
        public static AzureVmListSettings ResetShowDetails(this AzureVmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowDetails = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureVmListSettings.ShowDetails"/>.</em></p><p>Show public ip address, FQDN, and power states. command will run slow.</p></summary>
        [Pure]
        public static AzureVmListSettings EnableShowDetails(this AzureVmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowDetails = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureVmListSettings.ShowDetails"/>.</em></p><p>Show public ip address, FQDN, and power states. command will run slow.</p></summary>
        [Pure]
        public static AzureVmListSettings DisableShowDetails(this AzureVmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowDetails = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureVmListSettings.ShowDetails"/>.</em></p><p>Show public ip address, FQDN, and power states. command will run slow.</p></summary>
        [Pure]
        public static AzureVmListSettings ToggleShowDetails(this AzureVmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowDetails = !toolSettings.ShowDetails;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmListSettings SetDebug(this AzureVmListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmListSettings ResetDebug(this AzureVmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmListSettings SetHelp(this AzureVmListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmListSettings ResetHelp(this AzureVmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmListSettings SetOutput(this AzureVmListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmListSettings ResetOutput(this AzureVmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmListSettings SetQuery(this AzureVmListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmListSettings ResetQuery(this AzureVmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmListSettings SetVerbose(this AzureVmListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmListSettings ResetVerbose(this AzureVmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmListIpAddressesSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmListIpAddressesSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmListIpAddressesSettings.Name"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmListIpAddressesSettings SetName(this AzureVmListIpAddressesSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmListIpAddressesSettings.Name"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmListIpAddressesSettings ResetName(this AzureVmListIpAddressesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmListIpAddressesSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmListIpAddressesSettings SetResourceGroup(this AzureVmListIpAddressesSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmListIpAddressesSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmListIpAddressesSettings ResetResourceGroup(this AzureVmListIpAddressesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmListIpAddressesSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmListIpAddressesSettings SetDebug(this AzureVmListIpAddressesSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmListIpAddressesSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmListIpAddressesSettings ResetDebug(this AzureVmListIpAddressesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmListIpAddressesSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmListIpAddressesSettings SetHelp(this AzureVmListIpAddressesSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmListIpAddressesSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmListIpAddressesSettings ResetHelp(this AzureVmListIpAddressesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmListIpAddressesSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmListIpAddressesSettings SetOutput(this AzureVmListIpAddressesSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmListIpAddressesSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmListIpAddressesSettings ResetOutput(this AzureVmListIpAddressesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmListIpAddressesSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmListIpAddressesSettings SetQuery(this AzureVmListIpAddressesSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmListIpAddressesSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmListIpAddressesSettings ResetQuery(this AzureVmListIpAddressesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmListIpAddressesSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmListIpAddressesSettings SetVerbose(this AzureVmListIpAddressesSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmListIpAddressesSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmListIpAddressesSettings ResetVerbose(this AzureVmListIpAddressesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmListSizesSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmListSizesSettingsExtensions
    {
        #region Location
        /// <summary><p><em>Sets <see cref="AzureVmListSizesSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmListSizesSettings SetLocation(this AzureVmListSizesSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmListSizesSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmListSizesSettings ResetLocation(this AzureVmListSizesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmListSizesSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmListSizesSettings SetDebug(this AzureVmListSizesSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmListSizesSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmListSizesSettings ResetDebug(this AzureVmListSizesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmListSizesSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmListSizesSettings SetHelp(this AzureVmListSizesSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmListSizesSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmListSizesSettings ResetHelp(this AzureVmListSizesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmListSizesSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmListSizesSettings SetOutput(this AzureVmListSizesSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmListSizesSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmListSizesSettings ResetOutput(this AzureVmListSizesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmListSizesSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmListSizesSettings SetQuery(this AzureVmListSizesSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmListSizesSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmListSizesSettings ResetQuery(this AzureVmListSizesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmListSizesSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmListSizesSettings SetVerbose(this AzureVmListSizesSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmListSizesSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmListSizesSettings ResetVerbose(this AzureVmListSizesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmListSkusSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmListSkusSettingsExtensions
    {
        #region Location
        /// <summary><p><em>Sets <see cref="AzureVmListSkusSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmListSkusSettings SetLocation(this AzureVmListSkusSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmListSkusSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmListSkusSettings ResetLocation(this AzureVmListSkusSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmListSkusSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmListSkusSettings SetDebug(this AzureVmListSkusSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmListSkusSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmListSkusSettings ResetDebug(this AzureVmListSkusSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmListSkusSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmListSkusSettings SetHelp(this AzureVmListSkusSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmListSkusSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmListSkusSettings ResetHelp(this AzureVmListSkusSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmListSkusSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmListSkusSettings SetOutput(this AzureVmListSkusSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmListSkusSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmListSkusSettings ResetOutput(this AzureVmListSkusSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmListSkusSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmListSkusSettings SetQuery(this AzureVmListSkusSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmListSkusSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmListSkusSettings ResetQuery(this AzureVmListSkusSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmListSkusSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmListSkusSettings SetVerbose(this AzureVmListSkusSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmListSkusSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmListSkusSettings ResetVerbose(this AzureVmListSkusSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmListUsageSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmListUsageSettingsExtensions
    {
        #region Location
        /// <summary><p><em>Sets <see cref="AzureVmListUsageSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmListUsageSettings SetLocation(this AzureVmListUsageSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmListUsageSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmListUsageSettings ResetLocation(this AzureVmListUsageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmListUsageSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmListUsageSettings SetDebug(this AzureVmListUsageSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmListUsageSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmListUsageSettings ResetDebug(this AzureVmListUsageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmListUsageSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmListUsageSettings SetHelp(this AzureVmListUsageSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmListUsageSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmListUsageSettings ResetHelp(this AzureVmListUsageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmListUsageSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmListUsageSettings SetOutput(this AzureVmListUsageSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmListUsageSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmListUsageSettings ResetOutput(this AzureVmListUsageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmListUsageSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmListUsageSettings SetQuery(this AzureVmListUsageSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmListUsageSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmListUsageSettings ResetQuery(this AzureVmListUsageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmListUsageSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmListUsageSettings SetVerbose(this AzureVmListUsageSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmListUsageSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmListUsageSettings ResetVerbose(this AzureVmListUsageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmListVmResizeOptionsSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmListVmResizeOptionsSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmListVmResizeOptionsSettings.Name"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmListVmResizeOptionsSettings SetName(this AzureVmListVmResizeOptionsSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmListVmResizeOptionsSettings.Name"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmListVmResizeOptionsSettings ResetName(this AzureVmListVmResizeOptionsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmListVmResizeOptionsSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmListVmResizeOptionsSettings SetResourceGroup(this AzureVmListVmResizeOptionsSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmListVmResizeOptionsSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmListVmResizeOptionsSettings ResetResourceGroup(this AzureVmListVmResizeOptionsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmListVmResizeOptionsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmListVmResizeOptionsSettings SetDebug(this AzureVmListVmResizeOptionsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmListVmResizeOptionsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmListVmResizeOptionsSettings ResetDebug(this AzureVmListVmResizeOptionsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmListVmResizeOptionsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmListVmResizeOptionsSettings SetHelp(this AzureVmListVmResizeOptionsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmListVmResizeOptionsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmListVmResizeOptionsSettings ResetHelp(this AzureVmListVmResizeOptionsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmListVmResizeOptionsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmListVmResizeOptionsSettings SetOutput(this AzureVmListVmResizeOptionsSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmListVmResizeOptionsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmListVmResizeOptionsSettings ResetOutput(this AzureVmListVmResizeOptionsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmListVmResizeOptionsSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmListVmResizeOptionsSettings SetQuery(this AzureVmListVmResizeOptionsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmListVmResizeOptionsSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmListVmResizeOptionsSettings ResetQuery(this AzureVmListVmResizeOptionsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmListVmResizeOptionsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmListVmResizeOptionsSettings SetVerbose(this AzureVmListVmResizeOptionsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmListVmResizeOptionsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmListVmResizeOptionsSettings ResetVerbose(this AzureVmListVmResizeOptionsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmOpenPortSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmOpenPortSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmOpenPortSettings.Name"/>.</em></p><p>The name of the virtual machine to open inbound traffic on.</p></summary>
        [Pure]
        public static AzureVmOpenPortSettings SetName(this AzureVmOpenPortSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmOpenPortSettings.Name"/>.</em></p><p>The name of the virtual machine to open inbound traffic on.</p></summary>
        [Pure]
        public static AzureVmOpenPortSettings ResetName(this AzureVmOpenPortSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Port
        /// <summary><p><em>Sets <see cref="AzureVmOpenPortSettings.Port"/>.</em></p><p>The port or port range (ex: 80-100) to open inbound traffic to. Use '*' to allow traffic to all ports.</p></summary>
        [Pure]
        public static AzureVmOpenPortSettings SetPort(this AzureVmOpenPortSettings toolSettings, string port)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Port = port;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmOpenPortSettings.Port"/>.</em></p><p>The port or port range (ex: 80-100) to open inbound traffic to. Use '*' to allow traffic to all ports.</p></summary>
        [Pure]
        public static AzureVmOpenPortSettings ResetPort(this AzureVmOpenPortSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Port = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmOpenPortSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmOpenPortSettings SetResourceGroup(this AzureVmOpenPortSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmOpenPortSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmOpenPortSettings ResetResourceGroup(this AzureVmOpenPortSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ApplyToSubnet
        /// <summary><p><em>Sets <see cref="AzureVmOpenPortSettings.ApplyToSubnet"/>.</em></p><p>Allow inbound traffic on the subnet instead of the NIC.</p></summary>
        [Pure]
        public static AzureVmOpenPortSettings SetApplyToSubnet(this AzureVmOpenPortSettings toolSettings, string applyToSubnet)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ApplyToSubnet = applyToSubnet;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmOpenPortSettings.ApplyToSubnet"/>.</em></p><p>Allow inbound traffic on the subnet instead of the NIC.</p></summary>
        [Pure]
        public static AzureVmOpenPortSettings ResetApplyToSubnet(this AzureVmOpenPortSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ApplyToSubnet = null;
            return toolSettings;
        }
        #endregion
        #region NsgName
        /// <summary><p><em>Sets <see cref="AzureVmOpenPortSettings.NsgName"/>.</em></p><p>The name of the network security group to create if one does not exist. Ignored if an NSG already exists.</p></summary>
        [Pure]
        public static AzureVmOpenPortSettings SetNsgName(this AzureVmOpenPortSettings toolSettings, string nsgName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NsgName = nsgName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmOpenPortSettings.NsgName"/>.</em></p><p>The name of the network security group to create if one does not exist. Ignored if an NSG already exists.</p></summary>
        [Pure]
        public static AzureVmOpenPortSettings ResetNsgName(this AzureVmOpenPortSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NsgName = null;
            return toolSettings;
        }
        #endregion
        #region Priority
        /// <summary><p><em>Sets <see cref="AzureVmOpenPortSettings.Priority"/>.</em></p><p>Rule priority, between 100 (highest priority) and 4096 (lowest priority). Must be unique for each rule in the collection.</p></summary>
        [Pure]
        public static AzureVmOpenPortSettings SetPriority(this AzureVmOpenPortSettings toolSettings, string priority)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Priority = priority;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmOpenPortSettings.Priority"/>.</em></p><p>Rule priority, between 100 (highest priority) and 4096 (lowest priority). Must be unique for each rule in the collection.</p></summary>
        [Pure]
        public static AzureVmOpenPortSettings ResetPriority(this AzureVmOpenPortSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Priority = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmOpenPortSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmOpenPortSettings SetDebug(this AzureVmOpenPortSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmOpenPortSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmOpenPortSettings ResetDebug(this AzureVmOpenPortSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmOpenPortSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmOpenPortSettings SetHelp(this AzureVmOpenPortSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmOpenPortSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmOpenPortSettings ResetHelp(this AzureVmOpenPortSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmOpenPortSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmOpenPortSettings SetOutput(this AzureVmOpenPortSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmOpenPortSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmOpenPortSettings ResetOutput(this AzureVmOpenPortSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmOpenPortSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmOpenPortSettings SetQuery(this AzureVmOpenPortSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmOpenPortSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmOpenPortSettings ResetQuery(this AzureVmOpenPortSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmOpenPortSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmOpenPortSettings SetVerbose(this AzureVmOpenPortSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmOpenPortSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmOpenPortSettings ResetVerbose(this AzureVmOpenPortSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmPerformMaintenanceSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmPerformMaintenanceSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmPerformMaintenanceSettings.Name"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmPerformMaintenanceSettings SetName(this AzureVmPerformMaintenanceSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmPerformMaintenanceSettings.Name"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmPerformMaintenanceSettings ResetName(this AzureVmPerformMaintenanceSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmPerformMaintenanceSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmPerformMaintenanceSettings SetResourceGroup(this AzureVmPerformMaintenanceSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmPerformMaintenanceSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmPerformMaintenanceSettings ResetResourceGroup(this AzureVmPerformMaintenanceSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmPerformMaintenanceSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmPerformMaintenanceSettings SetDebug(this AzureVmPerformMaintenanceSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmPerformMaintenanceSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmPerformMaintenanceSettings ResetDebug(this AzureVmPerformMaintenanceSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmPerformMaintenanceSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmPerformMaintenanceSettings SetHelp(this AzureVmPerformMaintenanceSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmPerformMaintenanceSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmPerformMaintenanceSettings ResetHelp(this AzureVmPerformMaintenanceSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmPerformMaintenanceSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmPerformMaintenanceSettings SetOutput(this AzureVmPerformMaintenanceSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmPerformMaintenanceSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmPerformMaintenanceSettings ResetOutput(this AzureVmPerformMaintenanceSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmPerformMaintenanceSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmPerformMaintenanceSettings SetQuery(this AzureVmPerformMaintenanceSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmPerformMaintenanceSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmPerformMaintenanceSettings ResetQuery(this AzureVmPerformMaintenanceSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmPerformMaintenanceSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmPerformMaintenanceSettings SetVerbose(this AzureVmPerformMaintenanceSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmPerformMaintenanceSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmPerformMaintenanceSettings ResetVerbose(this AzureVmPerformMaintenanceSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmRedeploySettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmRedeploySettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmRedeploySettings.Name"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmRedeploySettings SetName(this AzureVmRedeploySettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmRedeploySettings.Name"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmRedeploySettings ResetName(this AzureVmRedeploySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmRedeploySettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmRedeploySettings SetResourceGroup(this AzureVmRedeploySettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmRedeploySettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmRedeploySettings ResetResourceGroup(this AzureVmRedeploySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary><p><em>Sets <see cref="AzureVmRedeploySettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmRedeploySettings SetNoWait(this AzureVmRedeploySettings toolSettings, string noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmRedeploySettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmRedeploySettings ResetNoWait(this AzureVmRedeploySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmRedeploySettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmRedeploySettings SetDebug(this AzureVmRedeploySettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmRedeploySettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmRedeploySettings ResetDebug(this AzureVmRedeploySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmRedeploySettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmRedeploySettings SetHelp(this AzureVmRedeploySettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmRedeploySettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmRedeploySettings ResetHelp(this AzureVmRedeploySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmRedeploySettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmRedeploySettings SetOutput(this AzureVmRedeploySettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmRedeploySettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmRedeploySettings ResetOutput(this AzureVmRedeploySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmRedeploySettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmRedeploySettings SetQuery(this AzureVmRedeploySettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmRedeploySettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmRedeploySettings ResetQuery(this AzureVmRedeploySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmRedeploySettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmRedeploySettings SetVerbose(this AzureVmRedeploySettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmRedeploySettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmRedeploySettings ResetVerbose(this AzureVmRedeploySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmResizeSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmResizeSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmResizeSettings.Name"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmResizeSettings SetName(this AzureVmResizeSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmResizeSettings.Name"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmResizeSettings ResetName(this AzureVmResizeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmResizeSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmResizeSettings SetResourceGroup(this AzureVmResizeSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmResizeSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmResizeSettings ResetResourceGroup(this AzureVmResizeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Size
        /// <summary><p><em>Sets <see cref="AzureVmResizeSettings.Size"/>.</em></p><p>The VM size.</p></summary>
        [Pure]
        public static AzureVmResizeSettings SetSize(this AzureVmResizeSettings toolSettings, string size)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Size = size;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmResizeSettings.Size"/>.</em></p><p>The VM size.</p></summary>
        [Pure]
        public static AzureVmResizeSettings ResetSize(this AzureVmResizeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Size = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary><p><em>Sets <see cref="AzureVmResizeSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmResizeSettings SetNoWait(this AzureVmResizeSettings toolSettings, string noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmResizeSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmResizeSettings ResetNoWait(this AzureVmResizeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmResizeSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmResizeSettings SetDebug(this AzureVmResizeSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmResizeSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmResizeSettings ResetDebug(this AzureVmResizeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmResizeSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmResizeSettings SetHelp(this AzureVmResizeSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmResizeSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmResizeSettings ResetHelp(this AzureVmResizeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmResizeSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmResizeSettings SetOutput(this AzureVmResizeSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmResizeSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmResizeSettings ResetOutput(this AzureVmResizeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmResizeSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmResizeSettings SetQuery(this AzureVmResizeSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmResizeSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmResizeSettings ResetQuery(this AzureVmResizeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmResizeSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmResizeSettings SetVerbose(this AzureVmResizeSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmResizeSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmResizeSettings ResetVerbose(this AzureVmResizeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmRestartSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmRestartSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmRestartSettings.Name"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmRestartSettings SetName(this AzureVmRestartSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmRestartSettings.Name"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmRestartSettings ResetName(this AzureVmRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmRestartSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmRestartSettings SetResourceGroup(this AzureVmRestartSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmRestartSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmRestartSettings ResetResourceGroup(this AzureVmRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary><p><em>Sets <see cref="AzureVmRestartSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmRestartSettings SetNoWait(this AzureVmRestartSettings toolSettings, string noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmRestartSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmRestartSettings ResetNoWait(this AzureVmRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmRestartSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmRestartSettings SetDebug(this AzureVmRestartSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmRestartSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmRestartSettings ResetDebug(this AzureVmRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmRestartSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmRestartSettings SetHelp(this AzureVmRestartSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmRestartSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmRestartSettings ResetHelp(this AzureVmRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmRestartSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmRestartSettings SetOutput(this AzureVmRestartSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmRestartSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmRestartSettings ResetOutput(this AzureVmRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmRestartSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmRestartSettings SetQuery(this AzureVmRestartSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmRestartSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmRestartSettings ResetQuery(this AzureVmRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmRestartSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmRestartSettings SetVerbose(this AzureVmRestartSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmRestartSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmRestartSettings ResetVerbose(this AzureVmRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmShowSettings.Name"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmShowSettings SetName(this AzureVmShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmShowSettings.Name"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmShowSettings ResetName(this AzureVmShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmShowSettings SetResourceGroup(this AzureVmShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmShowSettings ResetResourceGroup(this AzureVmShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ShowDetails
        /// <summary><p><em>Sets <see cref="AzureVmShowSettings.ShowDetails"/>.</em></p><p>Show public ip address, FQDN, and power states. command will run slow.</p></summary>
        [Pure]
        public static AzureVmShowSettings SetShowDetails(this AzureVmShowSettings toolSettings, bool? showDetails)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowDetails = showDetails;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmShowSettings.ShowDetails"/>.</em></p><p>Show public ip address, FQDN, and power states. command will run slow.</p></summary>
        [Pure]
        public static AzureVmShowSettings ResetShowDetails(this AzureVmShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowDetails = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureVmShowSettings.ShowDetails"/>.</em></p><p>Show public ip address, FQDN, and power states. command will run slow.</p></summary>
        [Pure]
        public static AzureVmShowSettings EnableShowDetails(this AzureVmShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowDetails = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureVmShowSettings.ShowDetails"/>.</em></p><p>Show public ip address, FQDN, and power states. command will run slow.</p></summary>
        [Pure]
        public static AzureVmShowSettings DisableShowDetails(this AzureVmShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowDetails = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureVmShowSettings.ShowDetails"/>.</em></p><p>Show public ip address, FQDN, and power states. command will run slow.</p></summary>
        [Pure]
        public static AzureVmShowSettings ToggleShowDetails(this AzureVmShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowDetails = !toolSettings.ShowDetails;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmShowSettings SetDebug(this AzureVmShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmShowSettings ResetDebug(this AzureVmShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmShowSettings SetHelp(this AzureVmShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmShowSettings ResetHelp(this AzureVmShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmShowSettings SetOutput(this AzureVmShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmShowSettings ResetOutput(this AzureVmShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmShowSettings SetQuery(this AzureVmShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmShowSettings ResetQuery(this AzureVmShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmShowSettings SetVerbose(this AzureVmShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmShowSettings ResetVerbose(this AzureVmShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmStartSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmStartSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmStartSettings.Name"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmStartSettings SetName(this AzureVmStartSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmStartSettings.Name"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmStartSettings ResetName(this AzureVmStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmStartSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmStartSettings SetResourceGroup(this AzureVmStartSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmStartSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmStartSettings ResetResourceGroup(this AzureVmStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary><p><em>Sets <see cref="AzureVmStartSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmStartSettings SetNoWait(this AzureVmStartSettings toolSettings, string noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmStartSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmStartSettings ResetNoWait(this AzureVmStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmStartSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmStartSettings SetDebug(this AzureVmStartSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmStartSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmStartSettings ResetDebug(this AzureVmStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmStartSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmStartSettings SetHelp(this AzureVmStartSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmStartSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmStartSettings ResetHelp(this AzureVmStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmStartSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmStartSettings SetOutput(this AzureVmStartSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmStartSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmStartSettings ResetOutput(this AzureVmStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmStartSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmStartSettings SetQuery(this AzureVmStartSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmStartSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmStartSettings ResetQuery(this AzureVmStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmStartSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmStartSettings SetVerbose(this AzureVmStartSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmStartSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmStartSettings ResetVerbose(this AzureVmStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmStopSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmStopSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmStopSettings.Name"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmStopSettings SetName(this AzureVmStopSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmStopSettings.Name"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmStopSettings ResetName(this AzureVmStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmStopSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmStopSettings SetResourceGroup(this AzureVmStopSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmStopSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmStopSettings ResetResourceGroup(this AzureVmStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary><p><em>Sets <see cref="AzureVmStopSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmStopSettings SetNoWait(this AzureVmStopSettings toolSettings, string noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmStopSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmStopSettings ResetNoWait(this AzureVmStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmStopSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmStopSettings SetDebug(this AzureVmStopSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmStopSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmStopSettings ResetDebug(this AzureVmStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmStopSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmStopSettings SetHelp(this AzureVmStopSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmStopSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmStopSettings ResetHelp(this AzureVmStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmStopSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmStopSettings SetOutput(this AzureVmStopSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmStopSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmStopSettings ResetOutput(this AzureVmStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmStopSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmStopSettings SetQuery(this AzureVmStopSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmStopSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmStopSettings ResetQuery(this AzureVmStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmStopSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmStopSettings SetVerbose(this AzureVmStopSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmStopSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmStopSettings ResetVerbose(this AzureVmStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmUpdateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmUpdateSettings.Name"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmUpdateSettings SetName(this AzureVmUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmUpdateSettings.Name"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmUpdateSettings ResetName(this AzureVmUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmUpdateSettings SetResourceGroup(this AzureVmUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmUpdateSettings ResetResourceGroup(this AzureVmUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region DiskCaching
        /// <summary><p><em>Sets <see cref="AzureVmUpdateSettings.DiskCaching"/> to a new list.</em></p><p>Use singular value to apply across, or specify individual disks, e.g. 'os=ReadWrite 0=None 1=ReadOnly' should enable update os disk and 2 data disks.</p></summary>
        [Pure]
        public static AzureVmUpdateSettings SetDiskCaching(this AzureVmUpdateSettings toolSettings, params string[] diskCaching)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DiskCachingInternal = diskCaching.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureVmUpdateSettings.DiskCaching"/> to a new list.</em></p><p>Use singular value to apply across, or specify individual disks, e.g. 'os=ReadWrite 0=None 1=ReadOnly' should enable update os disk and 2 data disks.</p></summary>
        [Pure]
        public static AzureVmUpdateSettings SetDiskCaching(this AzureVmUpdateSettings toolSettings, IEnumerable<string> diskCaching)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DiskCachingInternal = diskCaching.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmUpdateSettings.DiskCaching"/>.</em></p><p>Use singular value to apply across, or specify individual disks, e.g. 'os=ReadWrite 0=None 1=ReadOnly' should enable update os disk and 2 data disks.</p></summary>
        [Pure]
        public static AzureVmUpdateSettings AddDiskCaching(this AzureVmUpdateSettings toolSettings, params string[] diskCaching)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DiskCachingInternal.AddRange(diskCaching);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmUpdateSettings.DiskCaching"/>.</em></p><p>Use singular value to apply across, or specify individual disks, e.g. 'os=ReadWrite 0=None 1=ReadOnly' should enable update os disk and 2 data disks.</p></summary>
        [Pure]
        public static AzureVmUpdateSettings AddDiskCaching(this AzureVmUpdateSettings toolSettings, IEnumerable<string> diskCaching)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DiskCachingInternal.AddRange(diskCaching);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureVmUpdateSettings.DiskCaching"/>.</em></p><p>Use singular value to apply across, or specify individual disks, e.g. 'os=ReadWrite 0=None 1=ReadOnly' should enable update os disk and 2 data disks.</p></summary>
        [Pure]
        public static AzureVmUpdateSettings ClearDiskCaching(this AzureVmUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DiskCachingInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmUpdateSettings.DiskCaching"/>.</em></p><p>Use singular value to apply across, or specify individual disks, e.g. 'os=ReadWrite 0=None 1=ReadOnly' should enable update os disk and 2 data disks.</p></summary>
        [Pure]
        public static AzureVmUpdateSettings RemoveDiskCaching(this AzureVmUpdateSettings toolSettings, params string[] diskCaching)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(diskCaching);
            toolSettings.DiskCachingInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmUpdateSettings.DiskCaching"/>.</em></p><p>Use singular value to apply across, or specify individual disks, e.g. 'os=ReadWrite 0=None 1=ReadOnly' should enable update os disk and 2 data disks.</p></summary>
        [Pure]
        public static AzureVmUpdateSettings RemoveDiskCaching(this AzureVmUpdateSettings toolSettings, IEnumerable<string> diskCaching)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(diskCaching);
            toolSettings.DiskCachingInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region LicenseType
        /// <summary><p><em>Sets <see cref="AzureVmUpdateSettings.LicenseType"/>.</em></p><p>License type if the Windows image or disk used was licensed on-premises.</p></summary>
        [Pure]
        public static AzureVmUpdateSettings SetLicenseType(this AzureVmUpdateSettings toolSettings, VmLicenseType licenseType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LicenseType = licenseType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmUpdateSettings.LicenseType"/>.</em></p><p>License type if the Windows image or disk used was licensed on-premises.</p></summary>
        [Pure]
        public static AzureVmUpdateSettings ResetLicenseType(this AzureVmUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LicenseType = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary><p><em>Sets <see cref="AzureVmUpdateSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmUpdateSettings SetNoWait(this AzureVmUpdateSettings toolSettings, string noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmUpdateSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmUpdateSettings ResetNoWait(this AzureVmUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        #endregion
        #region OsDisk
        /// <summary><p><em>Sets <see cref="AzureVmUpdateSettings.OsDisk"/>.</em></p><p>Managed OS disk ID or name to swap to. Feature registration for 'Microsoft.Compute/AllowManagedDisksReplaceOSDisk' is needed.</p></summary>
        [Pure]
        public static AzureVmUpdateSettings SetOsDisk(this AzureVmUpdateSettings toolSettings, string osDisk)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OsDisk = osDisk;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmUpdateSettings.OsDisk"/>.</em></p><p>Managed OS disk ID or name to swap to. Feature registration for 'Microsoft.Compute/AllowManagedDisksReplaceOSDisk' is needed.</p></summary>
        [Pure]
        public static AzureVmUpdateSettings ResetOsDisk(this AzureVmUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OsDisk = null;
            return toolSettings;
        }
        #endregion
        #region WriteAccelerator
        /// <summary><p><em>Sets <see cref="AzureVmUpdateSettings.WriteAccelerator"/> to a new list.</em></p><p>Enable/disable disk write accelerator. Use singular value 'true/false' to apply across, or specify individual disks, e.g.'os=true 1=true 2=true' for os disk and data disks with lun of 1 &amp; 2.</p></summary>
        [Pure]
        public static AzureVmUpdateSettings SetWriteAccelerator(this AzureVmUpdateSettings toolSettings, params string[] writeAccelerator)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WriteAcceleratorInternal = writeAccelerator.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureVmUpdateSettings.WriteAccelerator"/> to a new list.</em></p><p>Enable/disable disk write accelerator. Use singular value 'true/false' to apply across, or specify individual disks, e.g.'os=true 1=true 2=true' for os disk and data disks with lun of 1 &amp; 2.</p></summary>
        [Pure]
        public static AzureVmUpdateSettings SetWriteAccelerator(this AzureVmUpdateSettings toolSettings, IEnumerable<string> writeAccelerator)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WriteAcceleratorInternal = writeAccelerator.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmUpdateSettings.WriteAccelerator"/>.</em></p><p>Enable/disable disk write accelerator. Use singular value 'true/false' to apply across, or specify individual disks, e.g.'os=true 1=true 2=true' for os disk and data disks with lun of 1 &amp; 2.</p></summary>
        [Pure]
        public static AzureVmUpdateSettings AddWriteAccelerator(this AzureVmUpdateSettings toolSettings, params string[] writeAccelerator)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WriteAcceleratorInternal.AddRange(writeAccelerator);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmUpdateSettings.WriteAccelerator"/>.</em></p><p>Enable/disable disk write accelerator. Use singular value 'true/false' to apply across, or specify individual disks, e.g.'os=true 1=true 2=true' for os disk and data disks with lun of 1 &amp; 2.</p></summary>
        [Pure]
        public static AzureVmUpdateSettings AddWriteAccelerator(this AzureVmUpdateSettings toolSettings, IEnumerable<string> writeAccelerator)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WriteAcceleratorInternal.AddRange(writeAccelerator);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureVmUpdateSettings.WriteAccelerator"/>.</em></p><p>Enable/disable disk write accelerator. Use singular value 'true/false' to apply across, or specify individual disks, e.g.'os=true 1=true 2=true' for os disk and data disks with lun of 1 &amp; 2.</p></summary>
        [Pure]
        public static AzureVmUpdateSettings ClearWriteAccelerator(this AzureVmUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WriteAcceleratorInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmUpdateSettings.WriteAccelerator"/>.</em></p><p>Enable/disable disk write accelerator. Use singular value 'true/false' to apply across, or specify individual disks, e.g.'os=true 1=true 2=true' for os disk and data disks with lun of 1 &amp; 2.</p></summary>
        [Pure]
        public static AzureVmUpdateSettings RemoveWriteAccelerator(this AzureVmUpdateSettings toolSettings, params string[] writeAccelerator)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(writeAccelerator);
            toolSettings.WriteAcceleratorInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmUpdateSettings.WriteAccelerator"/>.</em></p><p>Enable/disable disk write accelerator. Use singular value 'true/false' to apply across, or specify individual disks, e.g.'os=true 1=true 2=true' for os disk and data disks with lun of 1 &amp; 2.</p></summary>
        [Pure]
        public static AzureVmUpdateSettings RemoveWriteAccelerator(this AzureVmUpdateSettings toolSettings, IEnumerable<string> writeAccelerator)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(writeAccelerator);
            toolSettings.WriteAcceleratorInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary><p><em>Sets <see cref="AzureVmUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureVmUpdateSettings SetAdd(this AzureVmUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureVmUpdateSettings ResetAdd(this AzureVmUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region ForceString
        /// <summary><p><em>Sets <see cref="AzureVmUpdateSettings.ForceString"/>.</em></p><p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p></summary>
        [Pure]
        public static AzureVmUpdateSettings SetForceString(this AzureVmUpdateSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmUpdateSettings.ForceString"/>.</em></p><p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p></summary>
        [Pure]
        public static AzureVmUpdateSettings ResetForceString(this AzureVmUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary><p><em>Sets <see cref="AzureVmUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureVmUpdateSettings SetRemove(this AzureVmUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureVmUpdateSettings ResetRemove(this AzureVmUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary><p><em>Sets <see cref="AzureVmUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureVmUpdateSettings SetSet(this AzureVmUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureVmUpdateSettings ResetSet(this AzureVmUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmUpdateSettings SetDebug(this AzureVmUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmUpdateSettings ResetDebug(this AzureVmUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmUpdateSettings SetHelp(this AzureVmUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmUpdateSettings ResetHelp(this AzureVmUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmUpdateSettings SetOutput(this AzureVmUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmUpdateSettings ResetOutput(this AzureVmUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmUpdateSettings SetQuery(this AzureVmUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmUpdateSettings ResetQuery(this AzureVmUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmUpdateSettings SetVerbose(this AzureVmUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmUpdateSettings ResetVerbose(this AzureVmUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmWaitSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmWaitSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmWaitSettings.Name"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmWaitSettings SetName(this AzureVmWaitSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmWaitSettings.Name"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmWaitSettings ResetName(this AzureVmWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmWaitSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmWaitSettings SetResourceGroup(this AzureVmWaitSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmWaitSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmWaitSettings ResetResourceGroup(this AzureVmWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Created
        /// <summary><p><em>Sets <see cref="AzureVmWaitSettings.Created"/>.</em></p><p>Wait until created with 'provisioningState' at 'Succeeded'.</p></summary>
        [Pure]
        public static AzureVmWaitSettings SetCreated(this AzureVmWaitSettings toolSettings, string created)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Created = created;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmWaitSettings.Created"/>.</em></p><p>Wait until created with 'provisioningState' at 'Succeeded'.</p></summary>
        [Pure]
        public static AzureVmWaitSettings ResetCreated(this AzureVmWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Created = null;
            return toolSettings;
        }
        #endregion
        #region Custom
        /// <summary><p><em>Sets <see cref="AzureVmWaitSettings.Custom"/>.</em></p><p>Wait until the condition satisfies a custom JMESPath query. E.g. provisioningState!='InProgress', instanceView.statuses[?code=='PowerState/running'].</p></summary>
        [Pure]
        public static AzureVmWaitSettings SetCustom(this AzureVmWaitSettings toolSettings, string custom)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Custom = custom;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmWaitSettings.Custom"/>.</em></p><p>Wait until the condition satisfies a custom JMESPath query. E.g. provisioningState!='InProgress', instanceView.statuses[?code=='PowerState/running'].</p></summary>
        [Pure]
        public static AzureVmWaitSettings ResetCustom(this AzureVmWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Custom = null;
            return toolSettings;
        }
        #endregion
        #region Deleted
        /// <summary><p><em>Sets <see cref="AzureVmWaitSettings.Deleted"/>.</em></p><p>Wait until deleted.</p></summary>
        [Pure]
        public static AzureVmWaitSettings SetDeleted(this AzureVmWaitSettings toolSettings, string deleted)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Deleted = deleted;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmWaitSettings.Deleted"/>.</em></p><p>Wait until deleted.</p></summary>
        [Pure]
        public static AzureVmWaitSettings ResetDeleted(this AzureVmWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Deleted = null;
            return toolSettings;
        }
        #endregion
        #region Exists
        /// <summary><p><em>Sets <see cref="AzureVmWaitSettings.Exists"/>.</em></p><p>Wait until the resource exists.</p></summary>
        [Pure]
        public static AzureVmWaitSettings SetExists(this AzureVmWaitSettings toolSettings, string exists)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Exists = exists;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmWaitSettings.Exists"/>.</em></p><p>Wait until the resource exists.</p></summary>
        [Pure]
        public static AzureVmWaitSettings ResetExists(this AzureVmWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Exists = null;
            return toolSettings;
        }
        #endregion
        #region Interval
        /// <summary><p><em>Sets <see cref="AzureVmWaitSettings.Interval"/>.</em></p><p>Polling interval in seconds.</p></summary>
        [Pure]
        public static AzureVmWaitSettings SetInterval(this AzureVmWaitSettings toolSettings, string interval)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Interval = interval;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmWaitSettings.Interval"/>.</em></p><p>Polling interval in seconds.</p></summary>
        [Pure]
        public static AzureVmWaitSettings ResetInterval(this AzureVmWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Interval = null;
            return toolSettings;
        }
        #endregion
        #region Timeout
        /// <summary><p><em>Sets <see cref="AzureVmWaitSettings.Timeout"/>.</em></p><p>Maximum wait in seconds.</p></summary>
        [Pure]
        public static AzureVmWaitSettings SetTimeout(this AzureVmWaitSettings toolSettings, string timeout)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Timeout = timeout;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmWaitSettings.Timeout"/>.</em></p><p>Maximum wait in seconds.</p></summary>
        [Pure]
        public static AzureVmWaitSettings ResetTimeout(this AzureVmWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Timeout = null;
            return toolSettings;
        }
        #endregion
        #region Updated
        /// <summary><p><em>Sets <see cref="AzureVmWaitSettings.Updated"/>.</em></p><p>Wait until updated with provisioningState at 'Succeeded'.</p></summary>
        [Pure]
        public static AzureVmWaitSettings SetUpdated(this AzureVmWaitSettings toolSettings, string updated)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Updated = updated;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmWaitSettings.Updated"/>.</em></p><p>Wait until updated with provisioningState at 'Succeeded'.</p></summary>
        [Pure]
        public static AzureVmWaitSettings ResetUpdated(this AzureVmWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Updated = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmWaitSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmWaitSettings SetDebug(this AzureVmWaitSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmWaitSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmWaitSettings ResetDebug(this AzureVmWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmWaitSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmWaitSettings SetHelp(this AzureVmWaitSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmWaitSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmWaitSettings ResetHelp(this AzureVmWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmWaitSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmWaitSettings SetOutput(this AzureVmWaitSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmWaitSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmWaitSettings ResetOutput(this AzureVmWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmWaitSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmWaitSettings SetQuery(this AzureVmWaitSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmWaitSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmWaitSettings ResetQuery(this AzureVmWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmWaitSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmWaitSettings SetVerbose(this AzureVmWaitSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmWaitSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmWaitSettings ResetVerbose(this AzureVmWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmAvailabilitySetConvertSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmAvailabilitySetConvertSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmAvailabilitySetConvertSettings.Name"/>.</em></p><p>Name of the availability set.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetConvertSettings SetName(this AzureVmAvailabilitySetConvertSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmAvailabilitySetConvertSettings.Name"/>.</em></p><p>Name of the availability set.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetConvertSettings ResetName(this AzureVmAvailabilitySetConvertSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmAvailabilitySetConvertSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetConvertSettings SetResourceGroup(this AzureVmAvailabilitySetConvertSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmAvailabilitySetConvertSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetConvertSettings ResetResourceGroup(this AzureVmAvailabilitySetConvertSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmAvailabilitySetConvertSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetConvertSettings SetDebug(this AzureVmAvailabilitySetConvertSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmAvailabilitySetConvertSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetConvertSettings ResetDebug(this AzureVmAvailabilitySetConvertSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmAvailabilitySetConvertSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetConvertSettings SetHelp(this AzureVmAvailabilitySetConvertSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmAvailabilitySetConvertSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetConvertSettings ResetHelp(this AzureVmAvailabilitySetConvertSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmAvailabilitySetConvertSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetConvertSettings SetOutput(this AzureVmAvailabilitySetConvertSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmAvailabilitySetConvertSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetConvertSettings ResetOutput(this AzureVmAvailabilitySetConvertSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmAvailabilitySetConvertSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetConvertSettings SetQuery(this AzureVmAvailabilitySetConvertSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmAvailabilitySetConvertSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetConvertSettings ResetQuery(this AzureVmAvailabilitySetConvertSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmAvailabilitySetConvertSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetConvertSettings SetVerbose(this AzureVmAvailabilitySetConvertSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmAvailabilitySetConvertSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetConvertSettings ResetVerbose(this AzureVmAvailabilitySetConvertSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmAvailabilitySetCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmAvailabilitySetCreateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmAvailabilitySetCreateSettings.Name"/>.</em></p><p>Name of the availability set.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetCreateSettings SetName(this AzureVmAvailabilitySetCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmAvailabilitySetCreateSettings.Name"/>.</em></p><p>Name of the availability set.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetCreateSettings ResetName(this AzureVmAvailabilitySetCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmAvailabilitySetCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetCreateSettings SetResourceGroup(this AzureVmAvailabilitySetCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmAvailabilitySetCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetCreateSettings ResetResourceGroup(this AzureVmAvailabilitySetCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary><p><em>Sets <see cref="AzureVmAvailabilitySetCreateSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetCreateSettings SetLocation(this AzureVmAvailabilitySetCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmAvailabilitySetCreateSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetCreateSettings ResetLocation(this AzureVmAvailabilitySetCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary><p><em>Sets <see cref="AzureVmAvailabilitySetCreateSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetCreateSettings SetNoWait(this AzureVmAvailabilitySetCreateSettings toolSettings, string noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmAvailabilitySetCreateSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetCreateSettings ResetNoWait(this AzureVmAvailabilitySetCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        #endregion
        #region PlatformFaultDomainCount
        /// <summary><p><em>Sets <see cref="AzureVmAvailabilitySetCreateSettings.PlatformFaultDomainCount"/>.</em></p><p>Fault Domain count.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetCreateSettings SetPlatformFaultDomainCount(this AzureVmAvailabilitySetCreateSettings toolSettings, string platformFaultDomainCount)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PlatformFaultDomainCount = platformFaultDomainCount;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmAvailabilitySetCreateSettings.PlatformFaultDomainCount"/>.</em></p><p>Fault Domain count.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetCreateSettings ResetPlatformFaultDomainCount(this AzureVmAvailabilitySetCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PlatformFaultDomainCount = null;
            return toolSettings;
        }
        #endregion
        #region PlatformUpdateDomainCount
        /// <summary><p><em>Sets <see cref="AzureVmAvailabilitySetCreateSettings.PlatformUpdateDomainCount"/>.</em></p><p>Update Domain count. If unspecified, server picks the most optimal number like 5. For the latest defaults see <a href="https://docs.microsoft.com/en-us/rest/api/compute/availabilitysets/availabilitysets-create">https://docs.microsoft.com/en-us/rest/api/compute/availabilitysets/availabilitysets-create</a>.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetCreateSettings SetPlatformUpdateDomainCount(this AzureVmAvailabilitySetCreateSettings toolSettings, string platformUpdateDomainCount)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PlatformUpdateDomainCount = platformUpdateDomainCount;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmAvailabilitySetCreateSettings.PlatformUpdateDomainCount"/>.</em></p><p>Update Domain count. If unspecified, server picks the most optimal number like 5. For the latest defaults see <a href="https://docs.microsoft.com/en-us/rest/api/compute/availabilitysets/availabilitysets-create">https://docs.microsoft.com/en-us/rest/api/compute/availabilitysets/availabilitysets-create</a>.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetCreateSettings ResetPlatformUpdateDomainCount(this AzureVmAvailabilitySetCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PlatformUpdateDomainCount = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary><p><em>Sets <see cref="AzureVmAvailabilitySetCreateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetCreateSettings SetTags(this AzureVmAvailabilitySetCreateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmAvailabilitySetCreateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetCreateSettings ResetTags(this AzureVmAvailabilitySetCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Unmanaged
        /// <summary><p><em>Sets <see cref="AzureVmAvailabilitySetCreateSettings.Unmanaged"/>.</em></p><p>Contained VMs should use unmanaged disks.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetCreateSettings SetUnmanaged(this AzureVmAvailabilitySetCreateSettings toolSettings, string unmanaged)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Unmanaged = unmanaged;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmAvailabilitySetCreateSettings.Unmanaged"/>.</em></p><p>Contained VMs should use unmanaged disks.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetCreateSettings ResetUnmanaged(this AzureVmAvailabilitySetCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Unmanaged = null;
            return toolSettings;
        }
        #endregion
        #region Validate
        /// <summary><p><em>Sets <see cref="AzureVmAvailabilitySetCreateSettings.Validate"/>.</em></p><p>Generate and validate the ARM template without creating any resources.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetCreateSettings SetValidate(this AzureVmAvailabilitySetCreateSettings toolSettings, string validate)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Validate = validate;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmAvailabilitySetCreateSettings.Validate"/>.</em></p><p>Generate and validate the ARM template without creating any resources.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetCreateSettings ResetValidate(this AzureVmAvailabilitySetCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Validate = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmAvailabilitySetCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetCreateSettings SetDebug(this AzureVmAvailabilitySetCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmAvailabilitySetCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetCreateSettings ResetDebug(this AzureVmAvailabilitySetCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmAvailabilitySetCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetCreateSettings SetHelp(this AzureVmAvailabilitySetCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmAvailabilitySetCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetCreateSettings ResetHelp(this AzureVmAvailabilitySetCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmAvailabilitySetCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetCreateSettings SetOutput(this AzureVmAvailabilitySetCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmAvailabilitySetCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetCreateSettings ResetOutput(this AzureVmAvailabilitySetCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmAvailabilitySetCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetCreateSettings SetQuery(this AzureVmAvailabilitySetCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmAvailabilitySetCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetCreateSettings ResetQuery(this AzureVmAvailabilitySetCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmAvailabilitySetCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetCreateSettings SetVerbose(this AzureVmAvailabilitySetCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmAvailabilitySetCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetCreateSettings ResetVerbose(this AzureVmAvailabilitySetCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmAvailabilitySetDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmAvailabilitySetDeleteSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmAvailabilitySetDeleteSettings.Name"/>.</em></p><p>Name of the availability set.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetDeleteSettings SetName(this AzureVmAvailabilitySetDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmAvailabilitySetDeleteSettings.Name"/>.</em></p><p>Name of the availability set.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetDeleteSettings ResetName(this AzureVmAvailabilitySetDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmAvailabilitySetDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetDeleteSettings SetResourceGroup(this AzureVmAvailabilitySetDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmAvailabilitySetDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetDeleteSettings ResetResourceGroup(this AzureVmAvailabilitySetDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmAvailabilitySetDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetDeleteSettings SetDebug(this AzureVmAvailabilitySetDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmAvailabilitySetDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetDeleteSettings ResetDebug(this AzureVmAvailabilitySetDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmAvailabilitySetDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetDeleteSettings SetHelp(this AzureVmAvailabilitySetDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmAvailabilitySetDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetDeleteSettings ResetHelp(this AzureVmAvailabilitySetDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmAvailabilitySetDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetDeleteSettings SetOutput(this AzureVmAvailabilitySetDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmAvailabilitySetDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetDeleteSettings ResetOutput(this AzureVmAvailabilitySetDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmAvailabilitySetDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetDeleteSettings SetQuery(this AzureVmAvailabilitySetDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmAvailabilitySetDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetDeleteSettings ResetQuery(this AzureVmAvailabilitySetDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmAvailabilitySetDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetDeleteSettings SetVerbose(this AzureVmAvailabilitySetDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmAvailabilitySetDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetDeleteSettings ResetVerbose(this AzureVmAvailabilitySetDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmAvailabilitySetListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmAvailabilitySetListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmAvailabilitySetListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetListSettings SetResourceGroup(this AzureVmAvailabilitySetListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmAvailabilitySetListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetListSettings ResetResourceGroup(this AzureVmAvailabilitySetListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmAvailabilitySetListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetListSettings SetDebug(this AzureVmAvailabilitySetListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmAvailabilitySetListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetListSettings ResetDebug(this AzureVmAvailabilitySetListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmAvailabilitySetListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetListSettings SetHelp(this AzureVmAvailabilitySetListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmAvailabilitySetListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetListSettings ResetHelp(this AzureVmAvailabilitySetListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmAvailabilitySetListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetListSettings SetOutput(this AzureVmAvailabilitySetListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmAvailabilitySetListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetListSettings ResetOutput(this AzureVmAvailabilitySetListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmAvailabilitySetListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetListSettings SetQuery(this AzureVmAvailabilitySetListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmAvailabilitySetListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetListSettings ResetQuery(this AzureVmAvailabilitySetListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmAvailabilitySetListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetListSettings SetVerbose(this AzureVmAvailabilitySetListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmAvailabilitySetListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetListSettings ResetVerbose(this AzureVmAvailabilitySetListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmAvailabilitySetListSizesSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmAvailabilitySetListSizesSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmAvailabilitySetListSizesSettings.Name"/>.</em></p><p>Name of the availability set.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetListSizesSettings SetName(this AzureVmAvailabilitySetListSizesSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmAvailabilitySetListSizesSettings.Name"/>.</em></p><p>Name of the availability set.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetListSizesSettings ResetName(this AzureVmAvailabilitySetListSizesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmAvailabilitySetListSizesSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetListSizesSettings SetResourceGroup(this AzureVmAvailabilitySetListSizesSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmAvailabilitySetListSizesSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetListSizesSettings ResetResourceGroup(this AzureVmAvailabilitySetListSizesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmAvailabilitySetListSizesSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetListSizesSettings SetDebug(this AzureVmAvailabilitySetListSizesSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmAvailabilitySetListSizesSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetListSizesSettings ResetDebug(this AzureVmAvailabilitySetListSizesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmAvailabilitySetListSizesSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetListSizesSettings SetHelp(this AzureVmAvailabilitySetListSizesSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmAvailabilitySetListSizesSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetListSizesSettings ResetHelp(this AzureVmAvailabilitySetListSizesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmAvailabilitySetListSizesSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetListSizesSettings SetOutput(this AzureVmAvailabilitySetListSizesSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmAvailabilitySetListSizesSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetListSizesSettings ResetOutput(this AzureVmAvailabilitySetListSizesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmAvailabilitySetListSizesSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetListSizesSettings SetQuery(this AzureVmAvailabilitySetListSizesSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmAvailabilitySetListSizesSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetListSizesSettings ResetQuery(this AzureVmAvailabilitySetListSizesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmAvailabilitySetListSizesSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetListSizesSettings SetVerbose(this AzureVmAvailabilitySetListSizesSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmAvailabilitySetListSizesSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetListSizesSettings ResetVerbose(this AzureVmAvailabilitySetListSizesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmAvailabilitySetShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmAvailabilitySetShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmAvailabilitySetShowSettings.Name"/>.</em></p><p>Name of the availability set.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetShowSettings SetName(this AzureVmAvailabilitySetShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmAvailabilitySetShowSettings.Name"/>.</em></p><p>Name of the availability set.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetShowSettings ResetName(this AzureVmAvailabilitySetShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmAvailabilitySetShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetShowSettings SetResourceGroup(this AzureVmAvailabilitySetShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmAvailabilitySetShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetShowSettings ResetResourceGroup(this AzureVmAvailabilitySetShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmAvailabilitySetShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetShowSettings SetDebug(this AzureVmAvailabilitySetShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmAvailabilitySetShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetShowSettings ResetDebug(this AzureVmAvailabilitySetShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmAvailabilitySetShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetShowSettings SetHelp(this AzureVmAvailabilitySetShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmAvailabilitySetShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetShowSettings ResetHelp(this AzureVmAvailabilitySetShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmAvailabilitySetShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetShowSettings SetOutput(this AzureVmAvailabilitySetShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmAvailabilitySetShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetShowSettings ResetOutput(this AzureVmAvailabilitySetShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmAvailabilitySetShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetShowSettings SetQuery(this AzureVmAvailabilitySetShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmAvailabilitySetShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetShowSettings ResetQuery(this AzureVmAvailabilitySetShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmAvailabilitySetShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetShowSettings SetVerbose(this AzureVmAvailabilitySetShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmAvailabilitySetShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetShowSettings ResetVerbose(this AzureVmAvailabilitySetShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmAvailabilitySetUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmAvailabilitySetUpdateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmAvailabilitySetUpdateSettings.Name"/>.</em></p><p>Name of the availability set.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetUpdateSettings SetName(this AzureVmAvailabilitySetUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmAvailabilitySetUpdateSettings.Name"/>.</em></p><p>Name of the availability set.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetUpdateSettings ResetName(this AzureVmAvailabilitySetUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmAvailabilitySetUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetUpdateSettings SetResourceGroup(this AzureVmAvailabilitySetUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmAvailabilitySetUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetUpdateSettings ResetResourceGroup(this AzureVmAvailabilitySetUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary><p><em>Sets <see cref="AzureVmAvailabilitySetUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetUpdateSettings SetAdd(this AzureVmAvailabilitySetUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmAvailabilitySetUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetUpdateSettings ResetAdd(this AzureVmAvailabilitySetUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region ForceString
        /// <summary><p><em>Sets <see cref="AzureVmAvailabilitySetUpdateSettings.ForceString"/>.</em></p><p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetUpdateSettings SetForceString(this AzureVmAvailabilitySetUpdateSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmAvailabilitySetUpdateSettings.ForceString"/>.</em></p><p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetUpdateSettings ResetForceString(this AzureVmAvailabilitySetUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary><p><em>Sets <see cref="AzureVmAvailabilitySetUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetUpdateSettings SetRemove(this AzureVmAvailabilitySetUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmAvailabilitySetUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetUpdateSettings ResetRemove(this AzureVmAvailabilitySetUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary><p><em>Sets <see cref="AzureVmAvailabilitySetUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetUpdateSettings SetSet(this AzureVmAvailabilitySetUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmAvailabilitySetUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetUpdateSettings ResetSet(this AzureVmAvailabilitySetUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmAvailabilitySetUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetUpdateSettings SetDebug(this AzureVmAvailabilitySetUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmAvailabilitySetUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetUpdateSettings ResetDebug(this AzureVmAvailabilitySetUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmAvailabilitySetUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetUpdateSettings SetHelp(this AzureVmAvailabilitySetUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmAvailabilitySetUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetUpdateSettings ResetHelp(this AzureVmAvailabilitySetUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmAvailabilitySetUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetUpdateSettings SetOutput(this AzureVmAvailabilitySetUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmAvailabilitySetUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetUpdateSettings ResetOutput(this AzureVmAvailabilitySetUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmAvailabilitySetUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetUpdateSettings SetQuery(this AzureVmAvailabilitySetUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmAvailabilitySetUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetUpdateSettings ResetQuery(this AzureVmAvailabilitySetUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmAvailabilitySetUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetUpdateSettings SetVerbose(this AzureVmAvailabilitySetUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmAvailabilitySetUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmAvailabilitySetUpdateSettings ResetVerbose(this AzureVmAvailabilitySetUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmBootDiagnosticsDisableSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmBootDiagnosticsDisableSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmBootDiagnosticsDisableSettings.Name"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmBootDiagnosticsDisableSettings SetName(this AzureVmBootDiagnosticsDisableSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmBootDiagnosticsDisableSettings.Name"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmBootDiagnosticsDisableSettings ResetName(this AzureVmBootDiagnosticsDisableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmBootDiagnosticsDisableSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmBootDiagnosticsDisableSettings SetResourceGroup(this AzureVmBootDiagnosticsDisableSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmBootDiagnosticsDisableSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmBootDiagnosticsDisableSettings ResetResourceGroup(this AzureVmBootDiagnosticsDisableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmBootDiagnosticsDisableSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmBootDiagnosticsDisableSettings SetDebug(this AzureVmBootDiagnosticsDisableSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmBootDiagnosticsDisableSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmBootDiagnosticsDisableSettings ResetDebug(this AzureVmBootDiagnosticsDisableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmBootDiagnosticsDisableSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmBootDiagnosticsDisableSettings SetHelp(this AzureVmBootDiagnosticsDisableSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmBootDiagnosticsDisableSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmBootDiagnosticsDisableSettings ResetHelp(this AzureVmBootDiagnosticsDisableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmBootDiagnosticsDisableSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmBootDiagnosticsDisableSettings SetOutput(this AzureVmBootDiagnosticsDisableSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmBootDiagnosticsDisableSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmBootDiagnosticsDisableSettings ResetOutput(this AzureVmBootDiagnosticsDisableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmBootDiagnosticsDisableSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmBootDiagnosticsDisableSettings SetQuery(this AzureVmBootDiagnosticsDisableSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmBootDiagnosticsDisableSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmBootDiagnosticsDisableSettings ResetQuery(this AzureVmBootDiagnosticsDisableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmBootDiagnosticsDisableSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmBootDiagnosticsDisableSettings SetVerbose(this AzureVmBootDiagnosticsDisableSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmBootDiagnosticsDisableSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmBootDiagnosticsDisableSettings ResetVerbose(this AzureVmBootDiagnosticsDisableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmBootDiagnosticsEnableSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmBootDiagnosticsEnableSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmBootDiagnosticsEnableSettings.Name"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmBootDiagnosticsEnableSettings SetName(this AzureVmBootDiagnosticsEnableSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmBootDiagnosticsEnableSettings.Name"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmBootDiagnosticsEnableSettings ResetName(this AzureVmBootDiagnosticsEnableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmBootDiagnosticsEnableSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmBootDiagnosticsEnableSettings SetResourceGroup(this AzureVmBootDiagnosticsEnableSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmBootDiagnosticsEnableSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmBootDiagnosticsEnableSettings ResetResourceGroup(this AzureVmBootDiagnosticsEnableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Storage
        /// <summary><p><em>Sets <see cref="AzureVmBootDiagnosticsEnableSettings.Storage"/>.</em></p><p>Name or URI of a storage account (e.g. <a href="https://your_storage_account_name.blob.core.windows.net/">https://your_storage_account_name.blob.core.windows.net/</a>).</p></summary>
        [Pure]
        public static AzureVmBootDiagnosticsEnableSettings SetStorage(this AzureVmBootDiagnosticsEnableSettings toolSettings, string storage)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Storage = storage;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmBootDiagnosticsEnableSettings.Storage"/>.</em></p><p>Name or URI of a storage account (e.g. <a href="https://your_storage_account_name.blob.core.windows.net/">https://your_storage_account_name.blob.core.windows.net/</a>).</p></summary>
        [Pure]
        public static AzureVmBootDiagnosticsEnableSettings ResetStorage(this AzureVmBootDiagnosticsEnableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Storage = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmBootDiagnosticsEnableSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmBootDiagnosticsEnableSettings SetDebug(this AzureVmBootDiagnosticsEnableSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmBootDiagnosticsEnableSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmBootDiagnosticsEnableSettings ResetDebug(this AzureVmBootDiagnosticsEnableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmBootDiagnosticsEnableSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmBootDiagnosticsEnableSettings SetHelp(this AzureVmBootDiagnosticsEnableSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmBootDiagnosticsEnableSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmBootDiagnosticsEnableSettings ResetHelp(this AzureVmBootDiagnosticsEnableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmBootDiagnosticsEnableSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmBootDiagnosticsEnableSettings SetOutput(this AzureVmBootDiagnosticsEnableSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmBootDiagnosticsEnableSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmBootDiagnosticsEnableSettings ResetOutput(this AzureVmBootDiagnosticsEnableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmBootDiagnosticsEnableSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmBootDiagnosticsEnableSettings SetQuery(this AzureVmBootDiagnosticsEnableSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmBootDiagnosticsEnableSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmBootDiagnosticsEnableSettings ResetQuery(this AzureVmBootDiagnosticsEnableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmBootDiagnosticsEnableSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmBootDiagnosticsEnableSettings SetVerbose(this AzureVmBootDiagnosticsEnableSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmBootDiagnosticsEnableSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmBootDiagnosticsEnableSettings ResetVerbose(this AzureVmBootDiagnosticsEnableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmBootDiagnosticsGetBootLogSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmBootDiagnosticsGetBootLogSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmBootDiagnosticsGetBootLogSettings.Name"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmBootDiagnosticsGetBootLogSettings SetName(this AzureVmBootDiagnosticsGetBootLogSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmBootDiagnosticsGetBootLogSettings.Name"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmBootDiagnosticsGetBootLogSettings ResetName(this AzureVmBootDiagnosticsGetBootLogSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmBootDiagnosticsGetBootLogSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmBootDiagnosticsGetBootLogSettings SetResourceGroup(this AzureVmBootDiagnosticsGetBootLogSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmBootDiagnosticsGetBootLogSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmBootDiagnosticsGetBootLogSettings ResetResourceGroup(this AzureVmBootDiagnosticsGetBootLogSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmBootDiagnosticsGetBootLogSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmBootDiagnosticsGetBootLogSettings SetDebug(this AzureVmBootDiagnosticsGetBootLogSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmBootDiagnosticsGetBootLogSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmBootDiagnosticsGetBootLogSettings ResetDebug(this AzureVmBootDiagnosticsGetBootLogSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmBootDiagnosticsGetBootLogSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmBootDiagnosticsGetBootLogSettings SetHelp(this AzureVmBootDiagnosticsGetBootLogSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmBootDiagnosticsGetBootLogSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmBootDiagnosticsGetBootLogSettings ResetHelp(this AzureVmBootDiagnosticsGetBootLogSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmBootDiagnosticsGetBootLogSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmBootDiagnosticsGetBootLogSettings SetOutput(this AzureVmBootDiagnosticsGetBootLogSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmBootDiagnosticsGetBootLogSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmBootDiagnosticsGetBootLogSettings ResetOutput(this AzureVmBootDiagnosticsGetBootLogSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmBootDiagnosticsGetBootLogSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmBootDiagnosticsGetBootLogSettings SetQuery(this AzureVmBootDiagnosticsGetBootLogSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmBootDiagnosticsGetBootLogSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmBootDiagnosticsGetBootLogSettings ResetQuery(this AzureVmBootDiagnosticsGetBootLogSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmBootDiagnosticsGetBootLogSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmBootDiagnosticsGetBootLogSettings SetVerbose(this AzureVmBootDiagnosticsGetBootLogSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmBootDiagnosticsGetBootLogSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmBootDiagnosticsGetBootLogSettings ResetVerbose(this AzureVmBootDiagnosticsGetBootLogSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmDiagnosticsGetDefaultConfigSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmDiagnosticsGetDefaultConfigSettingsExtensions
    {
        #region IsWindowsOs
        /// <summary><p><em>Sets <see cref="AzureVmDiagnosticsGetDefaultConfigSettings.IsWindowsOs"/>.</em></p><p>For Windows VMs.</p></summary>
        [Pure]
        public static AzureVmDiagnosticsGetDefaultConfigSettings SetIsWindowsOs(this AzureVmDiagnosticsGetDefaultConfigSettings toolSettings, string isWindowsOs)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IsWindowsOs = isWindowsOs;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmDiagnosticsGetDefaultConfigSettings.IsWindowsOs"/>.</em></p><p>For Windows VMs.</p></summary>
        [Pure]
        public static AzureVmDiagnosticsGetDefaultConfigSettings ResetIsWindowsOs(this AzureVmDiagnosticsGetDefaultConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IsWindowsOs = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmDiagnosticsGetDefaultConfigSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmDiagnosticsGetDefaultConfigSettings SetDebug(this AzureVmDiagnosticsGetDefaultConfigSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmDiagnosticsGetDefaultConfigSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmDiagnosticsGetDefaultConfigSettings ResetDebug(this AzureVmDiagnosticsGetDefaultConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmDiagnosticsGetDefaultConfigSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmDiagnosticsGetDefaultConfigSettings SetHelp(this AzureVmDiagnosticsGetDefaultConfigSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmDiagnosticsGetDefaultConfigSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmDiagnosticsGetDefaultConfigSettings ResetHelp(this AzureVmDiagnosticsGetDefaultConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmDiagnosticsGetDefaultConfigSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmDiagnosticsGetDefaultConfigSettings SetOutput(this AzureVmDiagnosticsGetDefaultConfigSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmDiagnosticsGetDefaultConfigSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmDiagnosticsGetDefaultConfigSettings ResetOutput(this AzureVmDiagnosticsGetDefaultConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmDiagnosticsGetDefaultConfigSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmDiagnosticsGetDefaultConfigSettings SetQuery(this AzureVmDiagnosticsGetDefaultConfigSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmDiagnosticsGetDefaultConfigSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmDiagnosticsGetDefaultConfigSettings ResetQuery(this AzureVmDiagnosticsGetDefaultConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmDiagnosticsGetDefaultConfigSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmDiagnosticsGetDefaultConfigSettings SetVerbose(this AzureVmDiagnosticsGetDefaultConfigSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmDiagnosticsGetDefaultConfigSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmDiagnosticsGetDefaultConfigSettings ResetVerbose(this AzureVmDiagnosticsGetDefaultConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmDiagnosticsSetSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmDiagnosticsSetSettingsExtensions
    {
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmDiagnosticsSetSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmDiagnosticsSetSettings SetResourceGroup(this AzureVmDiagnosticsSetSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmDiagnosticsSetSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmDiagnosticsSetSettings ResetResourceGroup(this AzureVmDiagnosticsSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Settings
        /// <summary><p><em>Sets <see cref="AzureVmDiagnosticsSetSettings.Settings"/>.</em></p><p>Json string or a file path, which defines data to be collected.</p></summary>
        [Pure]
        public static AzureVmDiagnosticsSetSettings SetSettings(this AzureVmDiagnosticsSetSettings toolSettings, string settings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Settings = settings;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmDiagnosticsSetSettings.Settings"/>.</em></p><p>Json string or a file path, which defines data to be collected.</p></summary>
        [Pure]
        public static AzureVmDiagnosticsSetSettings ResetSettings(this AzureVmDiagnosticsSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Settings = null;
            return toolSettings;
        }
        #endregion
        #region VmName
        /// <summary><p><em>Sets <see cref="AzureVmDiagnosticsSetSettings.VmName"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmDiagnosticsSetSettings SetVmName(this AzureVmDiagnosticsSetSettings toolSettings, string vmName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmName = vmName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmDiagnosticsSetSettings.VmName"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmDiagnosticsSetSettings ResetVmName(this AzureVmDiagnosticsSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmName = null;
            return toolSettings;
        }
        #endregion
        #region NoAutoUpgrade
        /// <summary><p><em>Sets <see cref="AzureVmDiagnosticsSetSettings.NoAutoUpgrade"/>.</em></p><p>By doing this, extension system will not pick the highest minor version for the specified version number, and will not auto update to the latest build/revision number on any scale set updates in future.</p></summary>
        [Pure]
        public static AzureVmDiagnosticsSetSettings SetNoAutoUpgrade(this AzureVmDiagnosticsSetSettings toolSettings, string noAutoUpgrade)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoAutoUpgrade = noAutoUpgrade;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmDiagnosticsSetSettings.NoAutoUpgrade"/>.</em></p><p>By doing this, extension system will not pick the highest minor version for the specified version number, and will not auto update to the latest build/revision number on any scale set updates in future.</p></summary>
        [Pure]
        public static AzureVmDiagnosticsSetSettings ResetNoAutoUpgrade(this AzureVmDiagnosticsSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoAutoUpgrade = null;
            return toolSettings;
        }
        #endregion
        #region ProtectedSettings
        /// <summary><p><em>Sets <see cref="AzureVmDiagnosticsSetSettings.ProtectedSettings"/>.</em></p><p>Json string or a file path containing private configurations such as storage account keys, etc.</p></summary>
        [Pure]
        public static AzureVmDiagnosticsSetSettings SetProtectedSettings(this AzureVmDiagnosticsSetSettings toolSettings, string protectedSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProtectedSettings = protectedSettings;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmDiagnosticsSetSettings.ProtectedSettings"/>.</em></p><p>Json string or a file path containing private configurations such as storage account keys, etc.</p></summary>
        [Pure]
        public static AzureVmDiagnosticsSetSettings ResetProtectedSettings(this AzureVmDiagnosticsSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProtectedSettings = null;
            return toolSettings;
        }
        #endregion
        #region Version
        /// <summary><p><em>Sets <see cref="AzureVmDiagnosticsSetSettings.Version"/>.</em></p><p>Version of the diagnostics extension. Will use the latest if not specfied.</p></summary>
        [Pure]
        public static AzureVmDiagnosticsSetSettings SetVersion(this AzureVmDiagnosticsSetSettings toolSettings, string version)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = version;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmDiagnosticsSetSettings.Version"/>.</em></p><p>Version of the diagnostics extension. Will use the latest if not specfied.</p></summary>
        [Pure]
        public static AzureVmDiagnosticsSetSettings ResetVersion(this AzureVmDiagnosticsSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmDiagnosticsSetSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmDiagnosticsSetSettings SetDebug(this AzureVmDiagnosticsSetSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmDiagnosticsSetSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmDiagnosticsSetSettings ResetDebug(this AzureVmDiagnosticsSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmDiagnosticsSetSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmDiagnosticsSetSettings SetHelp(this AzureVmDiagnosticsSetSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmDiagnosticsSetSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmDiagnosticsSetSettings ResetHelp(this AzureVmDiagnosticsSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmDiagnosticsSetSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmDiagnosticsSetSettings SetOutput(this AzureVmDiagnosticsSetSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmDiagnosticsSetSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmDiagnosticsSetSettings ResetOutput(this AzureVmDiagnosticsSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmDiagnosticsSetSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmDiagnosticsSetSettings SetQuery(this AzureVmDiagnosticsSetSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmDiagnosticsSetSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmDiagnosticsSetSettings ResetQuery(this AzureVmDiagnosticsSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmDiagnosticsSetSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmDiagnosticsSetSettings SetVerbose(this AzureVmDiagnosticsSetSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmDiagnosticsSetSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmDiagnosticsSetSettings ResetVerbose(this AzureVmDiagnosticsSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmDiskAttachSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmDiskAttachSettingsExtensions
    {
        #region Disk
        /// <summary><p><em>Sets <see cref="AzureVmDiskAttachSettings.Disk"/>.</em></p><p>Disk name or ID.</p></summary>
        [Pure]
        public static AzureVmDiskAttachSettings SetDisk(this AzureVmDiskAttachSettings toolSettings, string disk)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Disk = disk;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmDiskAttachSettings.Disk"/>.</em></p><p>Disk name or ID.</p></summary>
        [Pure]
        public static AzureVmDiskAttachSettings ResetDisk(this AzureVmDiskAttachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Disk = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmDiskAttachSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmDiskAttachSettings SetResourceGroup(this AzureVmDiskAttachSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmDiskAttachSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmDiskAttachSettings ResetResourceGroup(this AzureVmDiskAttachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region VmName
        /// <summary><p><em>Sets <see cref="AzureVmDiskAttachSettings.VmName"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmDiskAttachSettings SetVmName(this AzureVmDiskAttachSettings toolSettings, string vmName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmName = vmName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmDiskAttachSettings.VmName"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmDiskAttachSettings ResetVmName(this AzureVmDiskAttachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmName = null;
            return toolSettings;
        }
        #endregion
        #region Caching
        /// <summary><p><em>Sets <see cref="AzureVmDiskAttachSettings.Caching"/>.</em></p><p>Disk caching policy.</p></summary>
        [Pure]
        public static AzureVmDiskAttachSettings SetCaching(this AzureVmDiskAttachSettings toolSettings, VmCreateOsDiskCaching caching)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Caching = caching;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmDiskAttachSettings.Caching"/>.</em></p><p>Disk caching policy.</p></summary>
        [Pure]
        public static AzureVmDiskAttachSettings ResetCaching(this AzureVmDiskAttachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Caching = null;
            return toolSettings;
        }
        #endregion
        #region EnableWriteAccelerator
        /// <summary><p><em>Sets <see cref="AzureVmDiskAttachSettings.EnableWriteAccelerator"/>.</em></p><p>Enable write accelerator.</p></summary>
        [Pure]
        public static AzureVmDiskAttachSettings SetEnableWriteAccelerator(this AzureVmDiskAttachSettings toolSettings, string enableWriteAccelerator)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableWriteAccelerator = enableWriteAccelerator;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmDiskAttachSettings.EnableWriteAccelerator"/>.</em></p><p>Enable write accelerator.</p></summary>
        [Pure]
        public static AzureVmDiskAttachSettings ResetEnableWriteAccelerator(this AzureVmDiskAttachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableWriteAccelerator = null;
            return toolSettings;
        }
        #endregion
        #region Lun
        /// <summary><p><em>Sets <see cref="AzureVmDiskAttachSettings.Lun"/>.</em></p><p>0-based logical unit number (LUN). Max value depends on the Virtual Machine size.</p></summary>
        [Pure]
        public static AzureVmDiskAttachSettings SetLun(this AzureVmDiskAttachSettings toolSettings, string lun)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Lun = lun;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmDiskAttachSettings.Lun"/>.</em></p><p>0-based logical unit number (LUN). Max value depends on the Virtual Machine size.</p></summary>
        [Pure]
        public static AzureVmDiskAttachSettings ResetLun(this AzureVmDiskAttachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Lun = null;
            return toolSettings;
        }
        #endregion
        #region New
        /// <summary><p><em>Sets <see cref="AzureVmDiskAttachSettings.New"/>.</em></p><p>Create a new disk.</p></summary>
        [Pure]
        public static AzureVmDiskAttachSettings SetNew(this AzureVmDiskAttachSettings toolSettings, string @new)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.New = @new;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmDiskAttachSettings.New"/>.</em></p><p>Create a new disk.</p></summary>
        [Pure]
        public static AzureVmDiskAttachSettings ResetNew(this AzureVmDiskAttachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.New = null;
            return toolSettings;
        }
        #endregion
        #region SizeGb
        /// <summary><p><em>Sets <see cref="AzureVmDiskAttachSettings.SizeGb"/>.</em></p><p>Size in GB.</p></summary>
        [Pure]
        public static AzureVmDiskAttachSettings SetSizeGb(this AzureVmDiskAttachSettings toolSettings, string sizeGb)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SizeGb = sizeGb;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmDiskAttachSettings.SizeGb"/>.</em></p><p>Size in GB.</p></summary>
        [Pure]
        public static AzureVmDiskAttachSettings ResetSizeGb(this AzureVmDiskAttachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SizeGb = null;
            return toolSettings;
        }
        #endregion
        #region Sku
        /// <summary><p><em>Sets <see cref="AzureVmDiskAttachSettings.Sku"/>.</em></p><p>Underlying storage SKU.</p></summary>
        [Pure]
        public static AzureVmDiskAttachSettings SetSku(this AzureVmDiskAttachSettings toolSettings, VmCreateStorageSku sku)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = sku;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmDiskAttachSettings.Sku"/>.</em></p><p>Underlying storage SKU.</p></summary>
        [Pure]
        public static AzureVmDiskAttachSettings ResetSku(this AzureVmDiskAttachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmDiskAttachSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmDiskAttachSettings SetDebug(this AzureVmDiskAttachSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmDiskAttachSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmDiskAttachSettings ResetDebug(this AzureVmDiskAttachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmDiskAttachSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmDiskAttachSettings SetHelp(this AzureVmDiskAttachSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmDiskAttachSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmDiskAttachSettings ResetHelp(this AzureVmDiskAttachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmDiskAttachSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmDiskAttachSettings SetOutput(this AzureVmDiskAttachSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmDiskAttachSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmDiskAttachSettings ResetOutput(this AzureVmDiskAttachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmDiskAttachSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmDiskAttachSettings SetQuery(this AzureVmDiskAttachSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmDiskAttachSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmDiskAttachSettings ResetQuery(this AzureVmDiskAttachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmDiskAttachSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmDiskAttachSettings SetVerbose(this AzureVmDiskAttachSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmDiskAttachSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmDiskAttachSettings ResetVerbose(this AzureVmDiskAttachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmDiskDetachSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmDiskDetachSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmDiskDetachSettings.Name"/>.</em></p><p>The data disk name.</p></summary>
        [Pure]
        public static AzureVmDiskDetachSettings SetName(this AzureVmDiskDetachSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmDiskDetachSettings.Name"/>.</em></p><p>The data disk name.</p></summary>
        [Pure]
        public static AzureVmDiskDetachSettings ResetName(this AzureVmDiskDetachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmDiskDetachSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmDiskDetachSettings SetResourceGroup(this AzureVmDiskDetachSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmDiskDetachSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmDiskDetachSettings ResetResourceGroup(this AzureVmDiskDetachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region VmName
        /// <summary><p><em>Sets <see cref="AzureVmDiskDetachSettings.VmName"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmDiskDetachSettings SetVmName(this AzureVmDiskDetachSettings toolSettings, string vmName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmName = vmName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmDiskDetachSettings.VmName"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmDiskDetachSettings ResetVmName(this AzureVmDiskDetachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmDiskDetachSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmDiskDetachSettings SetDebug(this AzureVmDiskDetachSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmDiskDetachSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmDiskDetachSettings ResetDebug(this AzureVmDiskDetachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmDiskDetachSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmDiskDetachSettings SetHelp(this AzureVmDiskDetachSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmDiskDetachSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmDiskDetachSettings ResetHelp(this AzureVmDiskDetachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmDiskDetachSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmDiskDetachSettings SetOutput(this AzureVmDiskDetachSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmDiskDetachSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmDiskDetachSettings ResetOutput(this AzureVmDiskDetachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmDiskDetachSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmDiskDetachSettings SetQuery(this AzureVmDiskDetachSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmDiskDetachSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmDiskDetachSettings ResetQuery(this AzureVmDiskDetachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmDiskDetachSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmDiskDetachSettings SetVerbose(this AzureVmDiskDetachSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmDiskDetachSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmDiskDetachSettings ResetVerbose(this AzureVmDiskDetachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmEncryptionDisableSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmEncryptionDisableSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmEncryptionDisableSettings.Name"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmEncryptionDisableSettings SetName(this AzureVmEncryptionDisableSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmEncryptionDisableSettings.Name"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmEncryptionDisableSettings ResetName(this AzureVmEncryptionDisableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmEncryptionDisableSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmEncryptionDisableSettings SetResourceGroup(this AzureVmEncryptionDisableSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmEncryptionDisableSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmEncryptionDisableSettings ResetResourceGroup(this AzureVmEncryptionDisableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Force
        /// <summary><p><em>Sets <see cref="AzureVmEncryptionDisableSettings.Force"/>.</em></p><p>Continue by ignoring client side validation errors.</p></summary>
        [Pure]
        public static AzureVmEncryptionDisableSettings SetForce(this AzureVmEncryptionDisableSettings toolSettings, string force)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Force = force;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmEncryptionDisableSettings.Force"/>.</em></p><p>Continue by ignoring client side validation errors.</p></summary>
        [Pure]
        public static AzureVmEncryptionDisableSettings ResetForce(this AzureVmEncryptionDisableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Force = null;
            return toolSettings;
        }
        #endregion
        #region VolumeType
        /// <summary><p><em>Sets <see cref="AzureVmEncryptionDisableSettings.VolumeType"/>.</em></p><p>Type of volume that the encryption operation is performed on.</p></summary>
        [Pure]
        public static AzureVmEncryptionDisableSettings SetVolumeType(this AzureVmEncryptionDisableSettings toolSettings, VmEncryptionVolumeType volumeType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VolumeType = volumeType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmEncryptionDisableSettings.VolumeType"/>.</em></p><p>Type of volume that the encryption operation is performed on.</p></summary>
        [Pure]
        public static AzureVmEncryptionDisableSettings ResetVolumeType(this AzureVmEncryptionDisableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VolumeType = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmEncryptionDisableSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmEncryptionDisableSettings SetDebug(this AzureVmEncryptionDisableSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmEncryptionDisableSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmEncryptionDisableSettings ResetDebug(this AzureVmEncryptionDisableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmEncryptionDisableSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmEncryptionDisableSettings SetHelp(this AzureVmEncryptionDisableSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmEncryptionDisableSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmEncryptionDisableSettings ResetHelp(this AzureVmEncryptionDisableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmEncryptionDisableSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmEncryptionDisableSettings SetOutput(this AzureVmEncryptionDisableSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmEncryptionDisableSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmEncryptionDisableSettings ResetOutput(this AzureVmEncryptionDisableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmEncryptionDisableSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmEncryptionDisableSettings SetQuery(this AzureVmEncryptionDisableSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmEncryptionDisableSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmEncryptionDisableSettings ResetQuery(this AzureVmEncryptionDisableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmEncryptionDisableSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmEncryptionDisableSettings SetVerbose(this AzureVmEncryptionDisableSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmEncryptionDisableSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmEncryptionDisableSettings ResetVerbose(this AzureVmEncryptionDisableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmEncryptionEnableSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmEncryptionEnableSettingsExtensions
    {
        #region DiskEncryptionKeyvault
        /// <summary><p><em>Sets <see cref="AzureVmEncryptionEnableSettings.DiskEncryptionKeyvault"/>.</em></p><p>The key vault where the generated encryption key will be placed.</p></summary>
        [Pure]
        public static AzureVmEncryptionEnableSettings SetDiskEncryptionKeyvault(this AzureVmEncryptionEnableSettings toolSettings, string diskEncryptionKeyvault)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DiskEncryptionKeyvault = diskEncryptionKeyvault;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmEncryptionEnableSettings.DiskEncryptionKeyvault"/>.</em></p><p>The key vault where the generated encryption key will be placed.</p></summary>
        [Pure]
        public static AzureVmEncryptionEnableSettings ResetDiskEncryptionKeyvault(this AzureVmEncryptionEnableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DiskEncryptionKeyvault = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmEncryptionEnableSettings.Name"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmEncryptionEnableSettings SetName(this AzureVmEncryptionEnableSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmEncryptionEnableSettings.Name"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmEncryptionEnableSettings ResetName(this AzureVmEncryptionEnableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmEncryptionEnableSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmEncryptionEnableSettings SetResourceGroup(this AzureVmEncryptionEnableSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmEncryptionEnableSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmEncryptionEnableSettings ResetResourceGroup(this AzureVmEncryptionEnableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region AadClientCertThumbprint
        /// <summary><p><em>Sets <see cref="AzureVmEncryptionEnableSettings.AadClientCertThumbprint"/>.</em></p><p>Thumbprint of the AAD app certificate with permissions to write secrets to the key vault.</p></summary>
        [Pure]
        public static AzureVmEncryptionEnableSettings SetAadClientCertThumbprint(this AzureVmEncryptionEnableSettings toolSettings, string aadClientCertThumbprint)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AadClientCertThumbprint = aadClientCertThumbprint;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmEncryptionEnableSettings.AadClientCertThumbprint"/>.</em></p><p>Thumbprint of the AAD app certificate with permissions to write secrets to the key vault.</p></summary>
        [Pure]
        public static AzureVmEncryptionEnableSettings ResetAadClientCertThumbprint(this AzureVmEncryptionEnableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AadClientCertThumbprint = null;
            return toolSettings;
        }
        #endregion
        #region AadClientId
        /// <summary><p><em>Sets <see cref="AzureVmEncryptionEnableSettings.AadClientId"/>.</em></p><p>Client ID of an AAD app with permissions to write secrets to the key vault.</p></summary>
        [Pure]
        public static AzureVmEncryptionEnableSettings SetAadClientId(this AzureVmEncryptionEnableSettings toolSettings, string aadClientId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AadClientId = aadClientId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmEncryptionEnableSettings.AadClientId"/>.</em></p><p>Client ID of an AAD app with permissions to write secrets to the key vault.</p></summary>
        [Pure]
        public static AzureVmEncryptionEnableSettings ResetAadClientId(this AzureVmEncryptionEnableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AadClientId = null;
            return toolSettings;
        }
        #endregion
        #region AadClientSecret
        /// <summary><p><em>Sets <see cref="AzureVmEncryptionEnableSettings.AadClientSecret"/>.</em></p><p>Client secret of the AAD app with permissions to write secrets to the key vault.</p></summary>
        [Pure]
        public static AzureVmEncryptionEnableSettings SetAadClientSecret(this AzureVmEncryptionEnableSettings toolSettings, string aadClientSecret)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AadClientSecret = aadClientSecret;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmEncryptionEnableSettings.AadClientSecret"/>.</em></p><p>Client secret of the AAD app with permissions to write secrets to the key vault.</p></summary>
        [Pure]
        public static AzureVmEncryptionEnableSettings ResetAadClientSecret(this AzureVmEncryptionEnableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AadClientSecret = null;
            return toolSettings;
        }
        #endregion
        #region EncryptFormatAll
        /// <summary><p><em>Sets <see cref="AzureVmEncryptionEnableSettings.EncryptFormatAll"/>.</em></p><p>Encrypts-formats data disks instead of encrypting them. Encrypt-formatting is a lot faster than in-place encryption but wipes out the partition getting encrypt-formatted.</p></summary>
        [Pure]
        public static AzureVmEncryptionEnableSettings SetEncryptFormatAll(this AzureVmEncryptionEnableSettings toolSettings, string encryptFormatAll)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EncryptFormatAll = encryptFormatAll;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmEncryptionEnableSettings.EncryptFormatAll"/>.</em></p><p>Encrypts-formats data disks instead of encrypting them. Encrypt-formatting is a lot faster than in-place encryption but wipes out the partition getting encrypt-formatted.</p></summary>
        [Pure]
        public static AzureVmEncryptionEnableSettings ResetEncryptFormatAll(this AzureVmEncryptionEnableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EncryptFormatAll = null;
            return toolSettings;
        }
        #endregion
        #region KeyEncryptionAlgorithm
        /// <summary><p><em>Sets <see cref="AzureVmEncryptionEnableSettings.KeyEncryptionAlgorithm"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureVmEncryptionEnableSettings SetKeyEncryptionAlgorithm(this AzureVmEncryptionEnableSettings toolSettings, string keyEncryptionAlgorithm)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyEncryptionAlgorithm = keyEncryptionAlgorithm;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmEncryptionEnableSettings.KeyEncryptionAlgorithm"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureVmEncryptionEnableSettings ResetKeyEncryptionAlgorithm(this AzureVmEncryptionEnableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyEncryptionAlgorithm = null;
            return toolSettings;
        }
        #endregion
        #region KeyEncryptionKey
        /// <summary><p><em>Sets <see cref="AzureVmEncryptionEnableSettings.KeyEncryptionKey"/>.</em></p><p>Key vault key name or URL used to encrypt the disk encryption key.</p></summary>
        [Pure]
        public static AzureVmEncryptionEnableSettings SetKeyEncryptionKey(this AzureVmEncryptionEnableSettings toolSettings, string keyEncryptionKey)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyEncryptionKey = keyEncryptionKey;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmEncryptionEnableSettings.KeyEncryptionKey"/>.</em></p><p>Key vault key name or URL used to encrypt the disk encryption key.</p></summary>
        [Pure]
        public static AzureVmEncryptionEnableSettings ResetKeyEncryptionKey(this AzureVmEncryptionEnableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyEncryptionKey = null;
            return toolSettings;
        }
        #endregion
        #region KeyEncryptionKeyvault
        /// <summary><p><em>Sets <see cref="AzureVmEncryptionEnableSettings.KeyEncryptionKeyvault"/>.</em></p><p>The key vault containing the key encryption key used to encrypt the disk encryption key. If missing, CLI will use `--disk-encryption-keyvault`.</p></summary>
        [Pure]
        public static AzureVmEncryptionEnableSettings SetKeyEncryptionKeyvault(this AzureVmEncryptionEnableSettings toolSettings, string keyEncryptionKeyvault)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyEncryptionKeyvault = keyEncryptionKeyvault;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmEncryptionEnableSettings.KeyEncryptionKeyvault"/>.</em></p><p>The key vault containing the key encryption key used to encrypt the disk encryption key. If missing, CLI will use `--disk-encryption-keyvault`.</p></summary>
        [Pure]
        public static AzureVmEncryptionEnableSettings ResetKeyEncryptionKeyvault(this AzureVmEncryptionEnableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyEncryptionKeyvault = null;
            return toolSettings;
        }
        #endregion
        #region VolumeType
        /// <summary><p><em>Sets <see cref="AzureVmEncryptionEnableSettings.VolumeType"/>.</em></p><p>Type of volume that the encryption operation is performed on.</p></summary>
        [Pure]
        public static AzureVmEncryptionEnableSettings SetVolumeType(this AzureVmEncryptionEnableSettings toolSettings, VmEncryptionVolumeType volumeType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VolumeType = volumeType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmEncryptionEnableSettings.VolumeType"/>.</em></p><p>Type of volume that the encryption operation is performed on.</p></summary>
        [Pure]
        public static AzureVmEncryptionEnableSettings ResetVolumeType(this AzureVmEncryptionEnableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VolumeType = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmEncryptionEnableSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmEncryptionEnableSettings SetDebug(this AzureVmEncryptionEnableSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmEncryptionEnableSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmEncryptionEnableSettings ResetDebug(this AzureVmEncryptionEnableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmEncryptionEnableSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmEncryptionEnableSettings SetHelp(this AzureVmEncryptionEnableSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmEncryptionEnableSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmEncryptionEnableSettings ResetHelp(this AzureVmEncryptionEnableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmEncryptionEnableSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmEncryptionEnableSettings SetOutput(this AzureVmEncryptionEnableSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmEncryptionEnableSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmEncryptionEnableSettings ResetOutput(this AzureVmEncryptionEnableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmEncryptionEnableSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmEncryptionEnableSettings SetQuery(this AzureVmEncryptionEnableSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmEncryptionEnableSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmEncryptionEnableSettings ResetQuery(this AzureVmEncryptionEnableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmEncryptionEnableSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmEncryptionEnableSettings SetVerbose(this AzureVmEncryptionEnableSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmEncryptionEnableSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmEncryptionEnableSettings ResetVerbose(this AzureVmEncryptionEnableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmEncryptionShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmEncryptionShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmEncryptionShowSettings.Name"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmEncryptionShowSettings SetName(this AzureVmEncryptionShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmEncryptionShowSettings.Name"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmEncryptionShowSettings ResetName(this AzureVmEncryptionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmEncryptionShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmEncryptionShowSettings SetResourceGroup(this AzureVmEncryptionShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmEncryptionShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmEncryptionShowSettings ResetResourceGroup(this AzureVmEncryptionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmEncryptionShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmEncryptionShowSettings SetDebug(this AzureVmEncryptionShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmEncryptionShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmEncryptionShowSettings ResetDebug(this AzureVmEncryptionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmEncryptionShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmEncryptionShowSettings SetHelp(this AzureVmEncryptionShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmEncryptionShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmEncryptionShowSettings ResetHelp(this AzureVmEncryptionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmEncryptionShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmEncryptionShowSettings SetOutput(this AzureVmEncryptionShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmEncryptionShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmEncryptionShowSettings ResetOutput(this AzureVmEncryptionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmEncryptionShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmEncryptionShowSettings SetQuery(this AzureVmEncryptionShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmEncryptionShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmEncryptionShowSettings ResetQuery(this AzureVmEncryptionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmEncryptionShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmEncryptionShowSettings SetVerbose(this AzureVmEncryptionShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmEncryptionShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmEncryptionShowSettings ResetVerbose(this AzureVmEncryptionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmExtensionDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmExtensionDeleteSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmExtensionDeleteSettings.Name"/>.</em></p><p>Extension name.</p></summary>
        [Pure]
        public static AzureVmExtensionDeleteSettings SetName(this AzureVmExtensionDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionDeleteSettings.Name"/>.</em></p><p>Extension name.</p></summary>
        [Pure]
        public static AzureVmExtensionDeleteSettings ResetName(this AzureVmExtensionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmExtensionDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmExtensionDeleteSettings SetResourceGroup(this AzureVmExtensionDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmExtensionDeleteSettings ResetResourceGroup(this AzureVmExtensionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region VmName
        /// <summary><p><em>Sets <see cref="AzureVmExtensionDeleteSettings.VmName"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmExtensionDeleteSettings SetVmName(this AzureVmExtensionDeleteSettings toolSettings, string vmName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmName = vmName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionDeleteSettings.VmName"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmExtensionDeleteSettings ResetVmName(this AzureVmExtensionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmName = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary><p><em>Sets <see cref="AzureVmExtensionDeleteSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmExtensionDeleteSettings SetNoWait(this AzureVmExtensionDeleteSettings toolSettings, string noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionDeleteSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmExtensionDeleteSettings ResetNoWait(this AzureVmExtensionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmExtensionDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmExtensionDeleteSettings SetDebug(this AzureVmExtensionDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmExtensionDeleteSettings ResetDebug(this AzureVmExtensionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmExtensionDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmExtensionDeleteSettings SetHelp(this AzureVmExtensionDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmExtensionDeleteSettings ResetHelp(this AzureVmExtensionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmExtensionDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmExtensionDeleteSettings SetOutput(this AzureVmExtensionDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmExtensionDeleteSettings ResetOutput(this AzureVmExtensionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmExtensionDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmExtensionDeleteSettings SetQuery(this AzureVmExtensionDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmExtensionDeleteSettings ResetQuery(this AzureVmExtensionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmExtensionDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmExtensionDeleteSettings SetVerbose(this AzureVmExtensionDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmExtensionDeleteSettings ResetVerbose(this AzureVmExtensionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmExtensionListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmExtensionListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmExtensionListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmExtensionListSettings SetResourceGroup(this AzureVmExtensionListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmExtensionListSettings ResetResourceGroup(this AzureVmExtensionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region VmName
        /// <summary><p><em>Sets <see cref="AzureVmExtensionListSettings.VmName"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmExtensionListSettings SetVmName(this AzureVmExtensionListSettings toolSettings, string vmName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmName = vmName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionListSettings.VmName"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmExtensionListSettings ResetVmName(this AzureVmExtensionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmExtensionListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmExtensionListSettings SetDebug(this AzureVmExtensionListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmExtensionListSettings ResetDebug(this AzureVmExtensionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmExtensionListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmExtensionListSettings SetHelp(this AzureVmExtensionListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmExtensionListSettings ResetHelp(this AzureVmExtensionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmExtensionListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmExtensionListSettings SetOutput(this AzureVmExtensionListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmExtensionListSettings ResetOutput(this AzureVmExtensionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmExtensionListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmExtensionListSettings SetQuery(this AzureVmExtensionListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmExtensionListSettings ResetQuery(this AzureVmExtensionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmExtensionListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmExtensionListSettings SetVerbose(this AzureVmExtensionListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmExtensionListSettings ResetVerbose(this AzureVmExtensionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmExtensionSetSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmExtensionSetSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmExtensionSetSettings.Name"/>.</em></p><p>Extension name.</p></summary>
        [Pure]
        public static AzureVmExtensionSetSettings SetName(this AzureVmExtensionSetSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionSetSettings.Name"/>.</em></p><p>Extension name.</p></summary>
        [Pure]
        public static AzureVmExtensionSetSettings ResetName(this AzureVmExtensionSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Publisher
        /// <summary><p><em>Sets <see cref="AzureVmExtensionSetSettings.Publisher"/>.</em></p><p>The name of the extension publisher.</p></summary>
        [Pure]
        public static AzureVmExtensionSetSettings SetPublisher(this AzureVmExtensionSetSettings toolSettings, string publisher)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Publisher = publisher;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionSetSettings.Publisher"/>.</em></p><p>The name of the extension publisher.</p></summary>
        [Pure]
        public static AzureVmExtensionSetSettings ResetPublisher(this AzureVmExtensionSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Publisher = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmExtensionSetSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmExtensionSetSettings SetResourceGroup(this AzureVmExtensionSetSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionSetSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmExtensionSetSettings ResetResourceGroup(this AzureVmExtensionSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region VmName
        /// <summary><p><em>Sets <see cref="AzureVmExtensionSetSettings.VmName"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmExtensionSetSettings SetVmName(this AzureVmExtensionSetSettings toolSettings, string vmName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmName = vmName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionSetSettings.VmName"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmExtensionSetSettings ResetVmName(this AzureVmExtensionSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmName = null;
            return toolSettings;
        }
        #endregion
        #region ForceUpdate
        /// <summary><p><em>Sets <see cref="AzureVmExtensionSetSettings.ForceUpdate"/>.</em></p><p>Force to update even if the extension configuration has not changed.</p></summary>
        [Pure]
        public static AzureVmExtensionSetSettings SetForceUpdate(this AzureVmExtensionSetSettings toolSettings, string forceUpdate)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceUpdate = forceUpdate;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionSetSettings.ForceUpdate"/>.</em></p><p>Force to update even if the extension configuration has not changed.</p></summary>
        [Pure]
        public static AzureVmExtensionSetSettings ResetForceUpdate(this AzureVmExtensionSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceUpdate = null;
            return toolSettings;
        }
        #endregion
        #region NoAutoUpgrade
        /// <summary><p><em>Sets <see cref="AzureVmExtensionSetSettings.NoAutoUpgrade"/>.</em></p><p>By doing this, extension system will not pick the highest minor version for the specified version number, and will not auto update to the latest build/revision number on any scale set updates in future.</p></summary>
        [Pure]
        public static AzureVmExtensionSetSettings SetNoAutoUpgrade(this AzureVmExtensionSetSettings toolSettings, string noAutoUpgrade)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoAutoUpgrade = noAutoUpgrade;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionSetSettings.NoAutoUpgrade"/>.</em></p><p>By doing this, extension system will not pick the highest minor version for the specified version number, and will not auto update to the latest build/revision number on any scale set updates in future.</p></summary>
        [Pure]
        public static AzureVmExtensionSetSettings ResetNoAutoUpgrade(this AzureVmExtensionSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoAutoUpgrade = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary><p><em>Sets <see cref="AzureVmExtensionSetSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmExtensionSetSettings SetNoWait(this AzureVmExtensionSetSettings toolSettings, string noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionSetSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmExtensionSetSettings ResetNoWait(this AzureVmExtensionSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        #endregion
        #region ProtectedSettings
        /// <summary><p><em>Sets <see cref="AzureVmExtensionSetSettings.ProtectedSettings"/>.</em></p><p>Protected settings in JSON format for sensitive information like credentials. A JSON file path is also accepted.</p></summary>
        [Pure]
        public static AzureVmExtensionSetSettings SetProtectedSettings(this AzureVmExtensionSetSettings toolSettings, string protectedSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProtectedSettings = protectedSettings;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionSetSettings.ProtectedSettings"/>.</em></p><p>Protected settings in JSON format for sensitive information like credentials. A JSON file path is also accepted.</p></summary>
        [Pure]
        public static AzureVmExtensionSetSettings ResetProtectedSettings(this AzureVmExtensionSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProtectedSettings = null;
            return toolSettings;
        }
        #endregion
        #region Settings
        /// <summary><p><em>Sets <see cref="AzureVmExtensionSetSettings.Settings"/>.</em></p><p>Extension settings in JSON format. A JSON file path is also accepted.</p></summary>
        [Pure]
        public static AzureVmExtensionSetSettings SetSettings(this AzureVmExtensionSetSettings toolSettings, string settings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Settings = settings;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionSetSettings.Settings"/>.</em></p><p>Extension settings in JSON format. A JSON file path is also accepted.</p></summary>
        [Pure]
        public static AzureVmExtensionSetSettings ResetSettings(this AzureVmExtensionSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Settings = null;
            return toolSettings;
        }
        #endregion
        #region Version
        /// <summary><p><em>Sets <see cref="AzureVmExtensionSetSettings.Version"/>.</em></p><p>The version of the extension.</p></summary>
        [Pure]
        public static AzureVmExtensionSetSettings SetVersion(this AzureVmExtensionSetSettings toolSettings, string version)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = version;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionSetSettings.Version"/>.</em></p><p>The version of the extension.</p></summary>
        [Pure]
        public static AzureVmExtensionSetSettings ResetVersion(this AzureVmExtensionSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmExtensionSetSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmExtensionSetSettings SetDebug(this AzureVmExtensionSetSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionSetSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmExtensionSetSettings ResetDebug(this AzureVmExtensionSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmExtensionSetSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmExtensionSetSettings SetHelp(this AzureVmExtensionSetSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionSetSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmExtensionSetSettings ResetHelp(this AzureVmExtensionSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmExtensionSetSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmExtensionSetSettings SetOutput(this AzureVmExtensionSetSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionSetSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmExtensionSetSettings ResetOutput(this AzureVmExtensionSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmExtensionSetSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmExtensionSetSettings SetQuery(this AzureVmExtensionSetSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionSetSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmExtensionSetSettings ResetQuery(this AzureVmExtensionSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmExtensionSetSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmExtensionSetSettings SetVerbose(this AzureVmExtensionSetSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionSetSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmExtensionSetSettings ResetVerbose(this AzureVmExtensionSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmExtensionShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmExtensionShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmExtensionShowSettings.Name"/>.</em></p><p>Extension name.</p></summary>
        [Pure]
        public static AzureVmExtensionShowSettings SetName(this AzureVmExtensionShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionShowSettings.Name"/>.</em></p><p>Extension name.</p></summary>
        [Pure]
        public static AzureVmExtensionShowSettings ResetName(this AzureVmExtensionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmExtensionShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmExtensionShowSettings SetResourceGroup(this AzureVmExtensionShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmExtensionShowSettings ResetResourceGroup(this AzureVmExtensionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region VmName
        /// <summary><p><em>Sets <see cref="AzureVmExtensionShowSettings.VmName"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmExtensionShowSettings SetVmName(this AzureVmExtensionShowSettings toolSettings, string vmName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmName = vmName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionShowSettings.VmName"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmExtensionShowSettings ResetVmName(this AzureVmExtensionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmName = null;
            return toolSettings;
        }
        #endregion
        #region Expand
        /// <summary><p><em>Sets <see cref="AzureVmExtensionShowSettings.Expand"/>.</em></p><p>The expand expression to apply on the operation.</p></summary>
        [Pure]
        public static AzureVmExtensionShowSettings SetExpand(this AzureVmExtensionShowSettings toolSettings, string expand)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expand = expand;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionShowSettings.Expand"/>.</em></p><p>The expand expression to apply on the operation.</p></summary>
        [Pure]
        public static AzureVmExtensionShowSettings ResetExpand(this AzureVmExtensionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expand = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmExtensionShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmExtensionShowSettings SetDebug(this AzureVmExtensionShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmExtensionShowSettings ResetDebug(this AzureVmExtensionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmExtensionShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmExtensionShowSettings SetHelp(this AzureVmExtensionShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmExtensionShowSettings ResetHelp(this AzureVmExtensionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmExtensionShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmExtensionShowSettings SetOutput(this AzureVmExtensionShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmExtensionShowSettings ResetOutput(this AzureVmExtensionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmExtensionShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmExtensionShowSettings SetQuery(this AzureVmExtensionShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmExtensionShowSettings ResetQuery(this AzureVmExtensionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmExtensionShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmExtensionShowSettings SetVerbose(this AzureVmExtensionShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmExtensionShowSettings ResetVerbose(this AzureVmExtensionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmExtensionWaitSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmExtensionWaitSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmExtensionWaitSettings.Name"/>.</em></p><p>Extension name.</p></summary>
        [Pure]
        public static AzureVmExtensionWaitSettings SetName(this AzureVmExtensionWaitSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionWaitSettings.Name"/>.</em></p><p>Extension name.</p></summary>
        [Pure]
        public static AzureVmExtensionWaitSettings ResetName(this AzureVmExtensionWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmExtensionWaitSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmExtensionWaitSettings SetResourceGroup(this AzureVmExtensionWaitSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionWaitSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmExtensionWaitSettings ResetResourceGroup(this AzureVmExtensionWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region VmName
        /// <summary><p><em>Sets <see cref="AzureVmExtensionWaitSettings.VmName"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmExtensionWaitSettings SetVmName(this AzureVmExtensionWaitSettings toolSettings, string vmName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmName = vmName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionWaitSettings.VmName"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmExtensionWaitSettings ResetVmName(this AzureVmExtensionWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmName = null;
            return toolSettings;
        }
        #endregion
        #region Expand
        /// <summary><p><em>Sets <see cref="AzureVmExtensionWaitSettings.Expand"/>.</em></p><p>The expand expression to apply on the operation.</p></summary>
        [Pure]
        public static AzureVmExtensionWaitSettings SetExpand(this AzureVmExtensionWaitSettings toolSettings, string expand)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expand = expand;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionWaitSettings.Expand"/>.</em></p><p>The expand expression to apply on the operation.</p></summary>
        [Pure]
        public static AzureVmExtensionWaitSettings ResetExpand(this AzureVmExtensionWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expand = null;
            return toolSettings;
        }
        #endregion
        #region Created
        /// <summary><p><em>Sets <see cref="AzureVmExtensionWaitSettings.Created"/>.</em></p><p>Wait until created with 'provisioningState' at 'Succeeded'.</p></summary>
        [Pure]
        public static AzureVmExtensionWaitSettings SetCreated(this AzureVmExtensionWaitSettings toolSettings, string created)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Created = created;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionWaitSettings.Created"/>.</em></p><p>Wait until created with 'provisioningState' at 'Succeeded'.</p></summary>
        [Pure]
        public static AzureVmExtensionWaitSettings ResetCreated(this AzureVmExtensionWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Created = null;
            return toolSettings;
        }
        #endregion
        #region Custom
        /// <summary><p><em>Sets <see cref="AzureVmExtensionWaitSettings.Custom"/>.</em></p><p>Wait until the condition satisfies a custom JMESPath query. E.g. provisioningState!='InProgress', instanceView.statuses[?code=='PowerState/running'].</p></summary>
        [Pure]
        public static AzureVmExtensionWaitSettings SetCustom(this AzureVmExtensionWaitSettings toolSettings, string custom)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Custom = custom;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionWaitSettings.Custom"/>.</em></p><p>Wait until the condition satisfies a custom JMESPath query. E.g. provisioningState!='InProgress', instanceView.statuses[?code=='PowerState/running'].</p></summary>
        [Pure]
        public static AzureVmExtensionWaitSettings ResetCustom(this AzureVmExtensionWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Custom = null;
            return toolSettings;
        }
        #endregion
        #region Deleted
        /// <summary><p><em>Sets <see cref="AzureVmExtensionWaitSettings.Deleted"/>.</em></p><p>Wait until deleted.</p></summary>
        [Pure]
        public static AzureVmExtensionWaitSettings SetDeleted(this AzureVmExtensionWaitSettings toolSettings, string deleted)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Deleted = deleted;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionWaitSettings.Deleted"/>.</em></p><p>Wait until deleted.</p></summary>
        [Pure]
        public static AzureVmExtensionWaitSettings ResetDeleted(this AzureVmExtensionWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Deleted = null;
            return toolSettings;
        }
        #endregion
        #region Exists
        /// <summary><p><em>Sets <see cref="AzureVmExtensionWaitSettings.Exists"/>.</em></p><p>Wait until the resource exists.</p></summary>
        [Pure]
        public static AzureVmExtensionWaitSettings SetExists(this AzureVmExtensionWaitSettings toolSettings, string exists)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Exists = exists;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionWaitSettings.Exists"/>.</em></p><p>Wait until the resource exists.</p></summary>
        [Pure]
        public static AzureVmExtensionWaitSettings ResetExists(this AzureVmExtensionWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Exists = null;
            return toolSettings;
        }
        #endregion
        #region Interval
        /// <summary><p><em>Sets <see cref="AzureVmExtensionWaitSettings.Interval"/>.</em></p><p>Polling interval in seconds.</p></summary>
        [Pure]
        public static AzureVmExtensionWaitSettings SetInterval(this AzureVmExtensionWaitSettings toolSettings, string interval)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Interval = interval;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionWaitSettings.Interval"/>.</em></p><p>Polling interval in seconds.</p></summary>
        [Pure]
        public static AzureVmExtensionWaitSettings ResetInterval(this AzureVmExtensionWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Interval = null;
            return toolSettings;
        }
        #endregion
        #region Timeout
        /// <summary><p><em>Sets <see cref="AzureVmExtensionWaitSettings.Timeout"/>.</em></p><p>Maximum wait in seconds.</p></summary>
        [Pure]
        public static AzureVmExtensionWaitSettings SetTimeout(this AzureVmExtensionWaitSettings toolSettings, string timeout)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Timeout = timeout;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionWaitSettings.Timeout"/>.</em></p><p>Maximum wait in seconds.</p></summary>
        [Pure]
        public static AzureVmExtensionWaitSettings ResetTimeout(this AzureVmExtensionWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Timeout = null;
            return toolSettings;
        }
        #endregion
        #region Updated
        /// <summary><p><em>Sets <see cref="AzureVmExtensionWaitSettings.Updated"/>.</em></p><p>Wait until updated with provisioningState at 'Succeeded'.</p></summary>
        [Pure]
        public static AzureVmExtensionWaitSettings SetUpdated(this AzureVmExtensionWaitSettings toolSettings, string updated)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Updated = updated;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionWaitSettings.Updated"/>.</em></p><p>Wait until updated with provisioningState at 'Succeeded'.</p></summary>
        [Pure]
        public static AzureVmExtensionWaitSettings ResetUpdated(this AzureVmExtensionWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Updated = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmExtensionWaitSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmExtensionWaitSettings SetDebug(this AzureVmExtensionWaitSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionWaitSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmExtensionWaitSettings ResetDebug(this AzureVmExtensionWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmExtensionWaitSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmExtensionWaitSettings SetHelp(this AzureVmExtensionWaitSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionWaitSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmExtensionWaitSettings ResetHelp(this AzureVmExtensionWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmExtensionWaitSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmExtensionWaitSettings SetOutput(this AzureVmExtensionWaitSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionWaitSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmExtensionWaitSettings ResetOutput(this AzureVmExtensionWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmExtensionWaitSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmExtensionWaitSettings SetQuery(this AzureVmExtensionWaitSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionWaitSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmExtensionWaitSettings ResetQuery(this AzureVmExtensionWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmExtensionWaitSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmExtensionWaitSettings SetVerbose(this AzureVmExtensionWaitSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionWaitSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmExtensionWaitSettings ResetVerbose(this AzureVmExtensionWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmIdentityAssignSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmIdentityAssignSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmIdentityAssignSettings.Name"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmIdentityAssignSettings SetName(this AzureVmIdentityAssignSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmIdentityAssignSettings.Name"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmIdentityAssignSettings ResetName(this AzureVmIdentityAssignSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmIdentityAssignSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmIdentityAssignSettings SetResourceGroup(this AzureVmIdentityAssignSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmIdentityAssignSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmIdentityAssignSettings ResetResourceGroup(this AzureVmIdentityAssignSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Identities
        /// <summary><p><em>Sets <see cref="AzureVmIdentityAssignSettings.Identities"/>.</em></p><p>The identities to assign.</p></summary>
        [Pure]
        public static AzureVmIdentityAssignSettings SetIdentities(this AzureVmIdentityAssignSettings toolSettings, string identities)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Identities = identities;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmIdentityAssignSettings.Identities"/>.</em></p><p>The identities to assign.</p></summary>
        [Pure]
        public static AzureVmIdentityAssignSettings ResetIdentities(this AzureVmIdentityAssignSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Identities = null;
            return toolSettings;
        }
        #endregion
        #region Role
        /// <summary><p><em>Sets <see cref="AzureVmIdentityAssignSettings.Role"/>.</em></p><p>Role name or id the system assigned identity will have.</p></summary>
        [Pure]
        public static AzureVmIdentityAssignSettings SetRole(this AzureVmIdentityAssignSettings toolSettings, string role)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Role = role;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmIdentityAssignSettings.Role"/>.</em></p><p>Role name or id the system assigned identity will have.</p></summary>
        [Pure]
        public static AzureVmIdentityAssignSettings ResetRole(this AzureVmIdentityAssignSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Role = null;
            return toolSettings;
        }
        #endregion
        #region Scope
        /// <summary><p><em>Sets <see cref="AzureVmIdentityAssignSettings.Scope"/>.</em></p><p>Scope that the system assigned identity can access.</p></summary>
        [Pure]
        public static AzureVmIdentityAssignSettings SetScope(this AzureVmIdentityAssignSettings toolSettings, string scope)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Scope = scope;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmIdentityAssignSettings.Scope"/>.</em></p><p>Scope that the system assigned identity can access.</p></summary>
        [Pure]
        public static AzureVmIdentityAssignSettings ResetScope(this AzureVmIdentityAssignSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Scope = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmIdentityAssignSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmIdentityAssignSettings SetDebug(this AzureVmIdentityAssignSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmIdentityAssignSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmIdentityAssignSettings ResetDebug(this AzureVmIdentityAssignSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmIdentityAssignSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmIdentityAssignSettings SetHelp(this AzureVmIdentityAssignSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmIdentityAssignSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmIdentityAssignSettings ResetHelp(this AzureVmIdentityAssignSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmIdentityAssignSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmIdentityAssignSettings SetOutput(this AzureVmIdentityAssignSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmIdentityAssignSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmIdentityAssignSettings ResetOutput(this AzureVmIdentityAssignSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmIdentityAssignSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmIdentityAssignSettings SetQuery(this AzureVmIdentityAssignSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmIdentityAssignSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmIdentityAssignSettings ResetQuery(this AzureVmIdentityAssignSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmIdentityAssignSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmIdentityAssignSettings SetVerbose(this AzureVmIdentityAssignSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmIdentityAssignSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmIdentityAssignSettings ResetVerbose(this AzureVmIdentityAssignSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmIdentityRemoveSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmIdentityRemoveSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmIdentityRemoveSettings.Name"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmIdentityRemoveSettings SetName(this AzureVmIdentityRemoveSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmIdentityRemoveSettings.Name"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmIdentityRemoveSettings ResetName(this AzureVmIdentityRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmIdentityRemoveSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmIdentityRemoveSettings SetResourceGroup(this AzureVmIdentityRemoveSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmIdentityRemoveSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmIdentityRemoveSettings ResetResourceGroup(this AzureVmIdentityRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Identities
        /// <summary><p><em>Sets <see cref="AzureVmIdentityRemoveSettings.Identities"/>.</em></p><p>Space-separated identities to remove. Use '[system]' to refer system assigned identity.</p></summary>
        [Pure]
        public static AzureVmIdentityRemoveSettings SetIdentities(this AzureVmIdentityRemoveSettings toolSettings, string identities)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Identities = identities;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmIdentityRemoveSettings.Identities"/>.</em></p><p>Space-separated identities to remove. Use '[system]' to refer system assigned identity.</p></summary>
        [Pure]
        public static AzureVmIdentityRemoveSettings ResetIdentities(this AzureVmIdentityRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Identities = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmIdentityRemoveSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmIdentityRemoveSettings SetDebug(this AzureVmIdentityRemoveSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmIdentityRemoveSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmIdentityRemoveSettings ResetDebug(this AzureVmIdentityRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmIdentityRemoveSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmIdentityRemoveSettings SetHelp(this AzureVmIdentityRemoveSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmIdentityRemoveSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmIdentityRemoveSettings ResetHelp(this AzureVmIdentityRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmIdentityRemoveSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmIdentityRemoveSettings SetOutput(this AzureVmIdentityRemoveSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmIdentityRemoveSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmIdentityRemoveSettings ResetOutput(this AzureVmIdentityRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmIdentityRemoveSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmIdentityRemoveSettings SetQuery(this AzureVmIdentityRemoveSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmIdentityRemoveSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmIdentityRemoveSettings ResetQuery(this AzureVmIdentityRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmIdentityRemoveSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmIdentityRemoveSettings SetVerbose(this AzureVmIdentityRemoveSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmIdentityRemoveSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmIdentityRemoveSettings ResetVerbose(this AzureVmIdentityRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmIdentityShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmIdentityShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmIdentityShowSettings.Name"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmIdentityShowSettings SetName(this AzureVmIdentityShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmIdentityShowSettings.Name"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmIdentityShowSettings ResetName(this AzureVmIdentityShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmIdentityShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmIdentityShowSettings SetResourceGroup(this AzureVmIdentityShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmIdentityShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmIdentityShowSettings ResetResourceGroup(this AzureVmIdentityShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmIdentityShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmIdentityShowSettings SetDebug(this AzureVmIdentityShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmIdentityShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmIdentityShowSettings ResetDebug(this AzureVmIdentityShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmIdentityShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmIdentityShowSettings SetHelp(this AzureVmIdentityShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmIdentityShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmIdentityShowSettings ResetHelp(this AzureVmIdentityShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmIdentityShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmIdentityShowSettings SetOutput(this AzureVmIdentityShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmIdentityShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmIdentityShowSettings ResetOutput(this AzureVmIdentityShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmIdentityShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmIdentityShowSettings SetQuery(this AzureVmIdentityShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmIdentityShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmIdentityShowSettings ResetQuery(this AzureVmIdentityShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmIdentityShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmIdentityShowSettings SetVerbose(this AzureVmIdentityShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmIdentityShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmIdentityShowSettings ResetVerbose(this AzureVmIdentityShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmImageAcceptTermsSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmImageAcceptTermsSettingsExtensions
    {
        #region Offer
        /// <summary><p><em>Sets <see cref="AzureVmImageAcceptTermsSettings.Offer"/>.</em></p><p>Image offer.</p></summary>
        [Pure]
        public static AzureVmImageAcceptTermsSettings SetOffer(this AzureVmImageAcceptTermsSettings toolSettings, string offer)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Offer = offer;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmImageAcceptTermsSettings.Offer"/>.</em></p><p>Image offer.</p></summary>
        [Pure]
        public static AzureVmImageAcceptTermsSettings ResetOffer(this AzureVmImageAcceptTermsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Offer = null;
            return toolSettings;
        }
        #endregion
        #region Plan
        /// <summary><p><em>Sets <see cref="AzureVmImageAcceptTermsSettings.Plan"/>.</em></p><p>Image billing plan.</p></summary>
        [Pure]
        public static AzureVmImageAcceptTermsSettings SetPlan(this AzureVmImageAcceptTermsSettings toolSettings, string plan)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Plan = plan;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmImageAcceptTermsSettings.Plan"/>.</em></p><p>Image billing plan.</p></summary>
        [Pure]
        public static AzureVmImageAcceptTermsSettings ResetPlan(this AzureVmImageAcceptTermsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Plan = null;
            return toolSettings;
        }
        #endregion
        #region Publisher
        /// <summary><p><em>Sets <see cref="AzureVmImageAcceptTermsSettings.Publisher"/>.</em></p><p>Image publisher.</p></summary>
        [Pure]
        public static AzureVmImageAcceptTermsSettings SetPublisher(this AzureVmImageAcceptTermsSettings toolSettings, string publisher)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Publisher = publisher;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmImageAcceptTermsSettings.Publisher"/>.</em></p><p>Image publisher.</p></summary>
        [Pure]
        public static AzureVmImageAcceptTermsSettings ResetPublisher(this AzureVmImageAcceptTermsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Publisher = null;
            return toolSettings;
        }
        #endregion
        #region Urn
        /// <summary><p><em>Sets <see cref="AzureVmImageAcceptTermsSettings.Urn"/>.</em></p><p>URN, in format of 'publisher:offer:sku:version'. If specified, other argument values can be omitted.</p></summary>
        [Pure]
        public static AzureVmImageAcceptTermsSettings SetUrn(this AzureVmImageAcceptTermsSettings toolSettings, string urn)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Urn = urn;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmImageAcceptTermsSettings.Urn"/>.</em></p><p>URN, in format of 'publisher:offer:sku:version'. If specified, other argument values can be omitted.</p></summary>
        [Pure]
        public static AzureVmImageAcceptTermsSettings ResetUrn(this AzureVmImageAcceptTermsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Urn = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmImageAcceptTermsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmImageAcceptTermsSettings SetDebug(this AzureVmImageAcceptTermsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmImageAcceptTermsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmImageAcceptTermsSettings ResetDebug(this AzureVmImageAcceptTermsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmImageAcceptTermsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmImageAcceptTermsSettings SetHelp(this AzureVmImageAcceptTermsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmImageAcceptTermsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmImageAcceptTermsSettings ResetHelp(this AzureVmImageAcceptTermsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmImageAcceptTermsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmImageAcceptTermsSettings SetOutput(this AzureVmImageAcceptTermsSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmImageAcceptTermsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmImageAcceptTermsSettings ResetOutput(this AzureVmImageAcceptTermsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmImageAcceptTermsSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmImageAcceptTermsSettings SetQuery(this AzureVmImageAcceptTermsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmImageAcceptTermsSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmImageAcceptTermsSettings ResetQuery(this AzureVmImageAcceptTermsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmImageAcceptTermsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmImageAcceptTermsSettings SetVerbose(this AzureVmImageAcceptTermsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmImageAcceptTermsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmImageAcceptTermsSettings ResetVerbose(this AzureVmImageAcceptTermsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmImageListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmImageListSettingsExtensions
    {
        #region All
        /// <summary><p><em>Sets <see cref="AzureVmImageListSettings.All"/>.</em></p><p>Retrieve image list from live Azure service rather using an offline image list.</p></summary>
        [Pure]
        public static AzureVmImageListSettings SetAll(this AzureVmImageListSettings toolSettings, string all)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.All = all;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmImageListSettings.All"/>.</em></p><p>Retrieve image list from live Azure service rather using an offline image list.</p></summary>
        [Pure]
        public static AzureVmImageListSettings ResetAll(this AzureVmImageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.All = null;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary><p><em>Sets <see cref="AzureVmImageListSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmImageListSettings SetLocation(this AzureVmImageListSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmImageListSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmImageListSettings ResetLocation(this AzureVmImageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region Offer
        /// <summary><p><em>Sets <see cref="AzureVmImageListSettings.Offer"/>.</em></p><p>Image offer name, partial name is accepted.</p></summary>
        [Pure]
        public static AzureVmImageListSettings SetOffer(this AzureVmImageListSettings toolSettings, string offer)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Offer = offer;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmImageListSettings.Offer"/>.</em></p><p>Image offer name, partial name is accepted.</p></summary>
        [Pure]
        public static AzureVmImageListSettings ResetOffer(this AzureVmImageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Offer = null;
            return toolSettings;
        }
        #endregion
        #region Publisher
        /// <summary><p><em>Sets <see cref="AzureVmImageListSettings.Publisher"/>.</em></p><p>Image publisher name, partial name is accepted.</p></summary>
        [Pure]
        public static AzureVmImageListSettings SetPublisher(this AzureVmImageListSettings toolSettings, string publisher)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Publisher = publisher;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmImageListSettings.Publisher"/>.</em></p><p>Image publisher name, partial name is accepted.</p></summary>
        [Pure]
        public static AzureVmImageListSettings ResetPublisher(this AzureVmImageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Publisher = null;
            return toolSettings;
        }
        #endregion
        #region Sku
        /// <summary><p><em>Sets <see cref="AzureVmImageListSettings.Sku"/>.</em></p><p>Image sku name, partial name is accepted.</p></summary>
        [Pure]
        public static AzureVmImageListSettings SetSku(this AzureVmImageListSettings toolSettings, string sku)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = sku;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmImageListSettings.Sku"/>.</em></p><p>Image sku name, partial name is accepted.</p></summary>
        [Pure]
        public static AzureVmImageListSettings ResetSku(this AzureVmImageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmImageListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmImageListSettings SetDebug(this AzureVmImageListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmImageListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmImageListSettings ResetDebug(this AzureVmImageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmImageListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmImageListSettings SetHelp(this AzureVmImageListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmImageListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmImageListSettings ResetHelp(this AzureVmImageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmImageListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmImageListSettings SetOutput(this AzureVmImageListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmImageListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmImageListSettings ResetOutput(this AzureVmImageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmImageListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmImageListSettings SetQuery(this AzureVmImageListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmImageListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmImageListSettings ResetQuery(this AzureVmImageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmImageListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmImageListSettings SetVerbose(this AzureVmImageListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmImageListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmImageListSettings ResetVerbose(this AzureVmImageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmImageListOffersSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmImageListOffersSettingsExtensions
    {
        #region Location
        /// <summary><p><em>Sets <see cref="AzureVmImageListOffersSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmImageListOffersSettings SetLocation(this AzureVmImageListOffersSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmImageListOffersSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmImageListOffersSettings ResetLocation(this AzureVmImageListOffersSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region Publisher
        /// <summary><p><em>Sets <see cref="AzureVmImageListOffersSettings.Publisher"/>.</em></p><p>A valid image publisher.</p></summary>
        [Pure]
        public static AzureVmImageListOffersSettings SetPublisher(this AzureVmImageListOffersSettings toolSettings, string publisher)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Publisher = publisher;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmImageListOffersSettings.Publisher"/>.</em></p><p>A valid image publisher.</p></summary>
        [Pure]
        public static AzureVmImageListOffersSettings ResetPublisher(this AzureVmImageListOffersSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Publisher = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmImageListOffersSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmImageListOffersSettings SetDebug(this AzureVmImageListOffersSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmImageListOffersSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmImageListOffersSettings ResetDebug(this AzureVmImageListOffersSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmImageListOffersSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmImageListOffersSettings SetHelp(this AzureVmImageListOffersSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmImageListOffersSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmImageListOffersSettings ResetHelp(this AzureVmImageListOffersSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmImageListOffersSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmImageListOffersSettings SetOutput(this AzureVmImageListOffersSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmImageListOffersSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmImageListOffersSettings ResetOutput(this AzureVmImageListOffersSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmImageListOffersSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmImageListOffersSettings SetQuery(this AzureVmImageListOffersSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmImageListOffersSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmImageListOffersSettings ResetQuery(this AzureVmImageListOffersSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmImageListOffersSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmImageListOffersSettings SetVerbose(this AzureVmImageListOffersSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmImageListOffersSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmImageListOffersSettings ResetVerbose(this AzureVmImageListOffersSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmImageListPublishersSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmImageListPublishersSettingsExtensions
    {
        #region Location
        /// <summary><p><em>Sets <see cref="AzureVmImageListPublishersSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmImageListPublishersSettings SetLocation(this AzureVmImageListPublishersSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmImageListPublishersSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmImageListPublishersSettings ResetLocation(this AzureVmImageListPublishersSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmImageListPublishersSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmImageListPublishersSettings SetDebug(this AzureVmImageListPublishersSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmImageListPublishersSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmImageListPublishersSettings ResetDebug(this AzureVmImageListPublishersSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmImageListPublishersSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmImageListPublishersSettings SetHelp(this AzureVmImageListPublishersSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmImageListPublishersSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmImageListPublishersSettings ResetHelp(this AzureVmImageListPublishersSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmImageListPublishersSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmImageListPublishersSettings SetOutput(this AzureVmImageListPublishersSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmImageListPublishersSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmImageListPublishersSettings ResetOutput(this AzureVmImageListPublishersSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmImageListPublishersSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmImageListPublishersSettings SetQuery(this AzureVmImageListPublishersSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmImageListPublishersSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmImageListPublishersSettings ResetQuery(this AzureVmImageListPublishersSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmImageListPublishersSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmImageListPublishersSettings SetVerbose(this AzureVmImageListPublishersSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmImageListPublishersSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmImageListPublishersSettings ResetVerbose(this AzureVmImageListPublishersSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmImageListSkusSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmImageListSkusSettingsExtensions
    {
        #region Location
        /// <summary><p><em>Sets <see cref="AzureVmImageListSkusSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmImageListSkusSettings SetLocation(this AzureVmImageListSkusSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmImageListSkusSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmImageListSkusSettings ResetLocation(this AzureVmImageListSkusSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region Offer
        /// <summary><p><em>Sets <see cref="AzureVmImageListSkusSettings.Offer"/>.</em></p><p>Image offer.</p></summary>
        [Pure]
        public static AzureVmImageListSkusSettings SetOffer(this AzureVmImageListSkusSettings toolSettings, string offer)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Offer = offer;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmImageListSkusSettings.Offer"/>.</em></p><p>Image offer.</p></summary>
        [Pure]
        public static AzureVmImageListSkusSettings ResetOffer(this AzureVmImageListSkusSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Offer = null;
            return toolSettings;
        }
        #endregion
        #region Publisher
        /// <summary><p><em>Sets <see cref="AzureVmImageListSkusSettings.Publisher"/>.</em></p><p>A valid image publisher.</p></summary>
        [Pure]
        public static AzureVmImageListSkusSettings SetPublisher(this AzureVmImageListSkusSettings toolSettings, string publisher)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Publisher = publisher;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmImageListSkusSettings.Publisher"/>.</em></p><p>A valid image publisher.</p></summary>
        [Pure]
        public static AzureVmImageListSkusSettings ResetPublisher(this AzureVmImageListSkusSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Publisher = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmImageListSkusSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmImageListSkusSettings SetDebug(this AzureVmImageListSkusSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmImageListSkusSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmImageListSkusSettings ResetDebug(this AzureVmImageListSkusSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmImageListSkusSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmImageListSkusSettings SetHelp(this AzureVmImageListSkusSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmImageListSkusSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmImageListSkusSettings ResetHelp(this AzureVmImageListSkusSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmImageListSkusSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmImageListSkusSettings SetOutput(this AzureVmImageListSkusSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmImageListSkusSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmImageListSkusSettings ResetOutput(this AzureVmImageListSkusSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmImageListSkusSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmImageListSkusSettings SetQuery(this AzureVmImageListSkusSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmImageListSkusSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmImageListSkusSettings ResetQuery(this AzureVmImageListSkusSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmImageListSkusSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmImageListSkusSettings SetVerbose(this AzureVmImageListSkusSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmImageListSkusSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmImageListSkusSettings ResetVerbose(this AzureVmImageListSkusSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmImageShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmImageShowSettingsExtensions
    {
        #region Location
        /// <summary><p><em>Sets <see cref="AzureVmImageShowSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmImageShowSettings SetLocation(this AzureVmImageShowSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmImageShowSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmImageShowSettings ResetLocation(this AzureVmImageShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region Offer
        /// <summary><p><em>Sets <see cref="AzureVmImageShowSettings.Offer"/>.</em></p><p>Image offer.</p></summary>
        [Pure]
        public static AzureVmImageShowSettings SetOffer(this AzureVmImageShowSettings toolSettings, string offer)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Offer = offer;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmImageShowSettings.Offer"/>.</em></p><p>Image offer.</p></summary>
        [Pure]
        public static AzureVmImageShowSettings ResetOffer(this AzureVmImageShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Offer = null;
            return toolSettings;
        }
        #endregion
        #region Publisher
        /// <summary><p><em>Sets <see cref="AzureVmImageShowSettings.Publisher"/>.</em></p><p>Image publisher.</p></summary>
        [Pure]
        public static AzureVmImageShowSettings SetPublisher(this AzureVmImageShowSettings toolSettings, string publisher)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Publisher = publisher;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmImageShowSettings.Publisher"/>.</em></p><p>Image publisher.</p></summary>
        [Pure]
        public static AzureVmImageShowSettings ResetPublisher(this AzureVmImageShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Publisher = null;
            return toolSettings;
        }
        #endregion
        #region Sku
        /// <summary><p><em>Sets <see cref="AzureVmImageShowSettings.Sku"/>.</em></p><p>Image sku.</p></summary>
        [Pure]
        public static AzureVmImageShowSettings SetSku(this AzureVmImageShowSettings toolSettings, string sku)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = sku;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmImageShowSettings.Sku"/>.</em></p><p>Image sku.</p></summary>
        [Pure]
        public static AzureVmImageShowSettings ResetSku(this AzureVmImageShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = null;
            return toolSettings;
        }
        #endregion
        #region Urn
        /// <summary><p><em>Sets <see cref="AzureVmImageShowSettings.Urn"/>.</em></p><p>URN, in format of 'publisher:offer:sku:version'. If specified, other argument values can be omitted.</p></summary>
        [Pure]
        public static AzureVmImageShowSettings SetUrn(this AzureVmImageShowSettings toolSettings, string urn)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Urn = urn;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmImageShowSettings.Urn"/>.</em></p><p>URN, in format of 'publisher:offer:sku:version'. If specified, other argument values can be omitted.</p></summary>
        [Pure]
        public static AzureVmImageShowSettings ResetUrn(this AzureVmImageShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Urn = null;
            return toolSettings;
        }
        #endregion
        #region Version
        /// <summary><p><em>Sets <see cref="AzureVmImageShowSettings.Version"/>.</em></p><p>Image sku's version.</p></summary>
        [Pure]
        public static AzureVmImageShowSettings SetVersion(this AzureVmImageShowSettings toolSettings, string version)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = version;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmImageShowSettings.Version"/>.</em></p><p>Image sku's version.</p></summary>
        [Pure]
        public static AzureVmImageShowSettings ResetVersion(this AzureVmImageShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmImageShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmImageShowSettings SetDebug(this AzureVmImageShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmImageShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmImageShowSettings ResetDebug(this AzureVmImageShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmImageShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmImageShowSettings SetHelp(this AzureVmImageShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmImageShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmImageShowSettings ResetHelp(this AzureVmImageShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmImageShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmImageShowSettings SetOutput(this AzureVmImageShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmImageShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmImageShowSettings ResetOutput(this AzureVmImageShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmImageShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmImageShowSettings SetQuery(this AzureVmImageShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmImageShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmImageShowSettings ResetQuery(this AzureVmImageShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmImageShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmImageShowSettings SetVerbose(this AzureVmImageShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmImageShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmImageShowSettings ResetVerbose(this AzureVmImageShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmNicAddSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmNicAddSettingsExtensions
    {
        #region Nics
        /// <summary><p><em>Sets <see cref="AzureVmNicAddSettings.Nics"/>.</em></p><p>Names or IDs of NICs.</p></summary>
        [Pure]
        public static AzureVmNicAddSettings SetNics(this AzureVmNicAddSettings toolSettings, string nics)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Nics = nics;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmNicAddSettings.Nics"/>.</em></p><p>Names or IDs of NICs.</p></summary>
        [Pure]
        public static AzureVmNicAddSettings ResetNics(this AzureVmNicAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Nics = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmNicAddSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmNicAddSettings SetResourceGroup(this AzureVmNicAddSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmNicAddSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmNicAddSettings ResetResourceGroup(this AzureVmNicAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region VmName
        /// <summary><p><em>Sets <see cref="AzureVmNicAddSettings.VmName"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmNicAddSettings SetVmName(this AzureVmNicAddSettings toolSettings, string vmName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmName = vmName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmNicAddSettings.VmName"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmNicAddSettings ResetVmName(this AzureVmNicAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmName = null;
            return toolSettings;
        }
        #endregion
        #region PrimaryNic
        /// <summary><p><em>Sets <see cref="AzureVmNicAddSettings.PrimaryNic"/>.</em></p><p>Name or ID of the primary NIC. If missing, the first NIC in the list will be the primary.</p></summary>
        [Pure]
        public static AzureVmNicAddSettings SetPrimaryNic(this AzureVmNicAddSettings toolSettings, string primaryNic)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PrimaryNic = primaryNic;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmNicAddSettings.PrimaryNic"/>.</em></p><p>Name or ID of the primary NIC. If missing, the first NIC in the list will be the primary.</p></summary>
        [Pure]
        public static AzureVmNicAddSettings ResetPrimaryNic(this AzureVmNicAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PrimaryNic = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmNicAddSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmNicAddSettings SetDebug(this AzureVmNicAddSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmNicAddSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmNicAddSettings ResetDebug(this AzureVmNicAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmNicAddSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmNicAddSettings SetHelp(this AzureVmNicAddSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmNicAddSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmNicAddSettings ResetHelp(this AzureVmNicAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmNicAddSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmNicAddSettings SetOutput(this AzureVmNicAddSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmNicAddSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmNicAddSettings ResetOutput(this AzureVmNicAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmNicAddSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmNicAddSettings SetQuery(this AzureVmNicAddSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmNicAddSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmNicAddSettings ResetQuery(this AzureVmNicAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmNicAddSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmNicAddSettings SetVerbose(this AzureVmNicAddSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmNicAddSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmNicAddSettings ResetVerbose(this AzureVmNicAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmNicListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmNicListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmNicListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmNicListSettings SetResourceGroup(this AzureVmNicListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmNicListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmNicListSettings ResetResourceGroup(this AzureVmNicListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region VmName
        /// <summary><p><em>Sets <see cref="AzureVmNicListSettings.VmName"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmNicListSettings SetVmName(this AzureVmNicListSettings toolSettings, string vmName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmName = vmName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmNicListSettings.VmName"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmNicListSettings ResetVmName(this AzureVmNicListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmNicListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmNicListSettings SetDebug(this AzureVmNicListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmNicListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmNicListSettings ResetDebug(this AzureVmNicListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmNicListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmNicListSettings SetHelp(this AzureVmNicListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmNicListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmNicListSettings ResetHelp(this AzureVmNicListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmNicListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmNicListSettings SetOutput(this AzureVmNicListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmNicListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmNicListSettings ResetOutput(this AzureVmNicListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmNicListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmNicListSettings SetQuery(this AzureVmNicListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmNicListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmNicListSettings ResetQuery(this AzureVmNicListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmNicListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmNicListSettings SetVerbose(this AzureVmNicListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmNicListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmNicListSettings ResetVerbose(this AzureVmNicListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmNicRemoveSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmNicRemoveSettingsExtensions
    {
        #region Nics
        /// <summary><p><em>Sets <see cref="AzureVmNicRemoveSettings.Nics"/>.</em></p><p>Names or IDs of NICs.</p></summary>
        [Pure]
        public static AzureVmNicRemoveSettings SetNics(this AzureVmNicRemoveSettings toolSettings, string nics)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Nics = nics;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmNicRemoveSettings.Nics"/>.</em></p><p>Names or IDs of NICs.</p></summary>
        [Pure]
        public static AzureVmNicRemoveSettings ResetNics(this AzureVmNicRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Nics = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmNicRemoveSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmNicRemoveSettings SetResourceGroup(this AzureVmNicRemoveSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmNicRemoveSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmNicRemoveSettings ResetResourceGroup(this AzureVmNicRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region VmName
        /// <summary><p><em>Sets <see cref="AzureVmNicRemoveSettings.VmName"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmNicRemoveSettings SetVmName(this AzureVmNicRemoveSettings toolSettings, string vmName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmName = vmName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmNicRemoveSettings.VmName"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmNicRemoveSettings ResetVmName(this AzureVmNicRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmName = null;
            return toolSettings;
        }
        #endregion
        #region PrimaryNic
        /// <summary><p><em>Sets <see cref="AzureVmNicRemoveSettings.PrimaryNic"/>.</em></p><p>Name or ID of the primary NIC. If missing, the first NIC in the list will be the primary.</p></summary>
        [Pure]
        public static AzureVmNicRemoveSettings SetPrimaryNic(this AzureVmNicRemoveSettings toolSettings, string primaryNic)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PrimaryNic = primaryNic;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmNicRemoveSettings.PrimaryNic"/>.</em></p><p>Name or ID of the primary NIC. If missing, the first NIC in the list will be the primary.</p></summary>
        [Pure]
        public static AzureVmNicRemoveSettings ResetPrimaryNic(this AzureVmNicRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PrimaryNic = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmNicRemoveSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmNicRemoveSettings SetDebug(this AzureVmNicRemoveSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmNicRemoveSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmNicRemoveSettings ResetDebug(this AzureVmNicRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmNicRemoveSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmNicRemoveSettings SetHelp(this AzureVmNicRemoveSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmNicRemoveSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmNicRemoveSettings ResetHelp(this AzureVmNicRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmNicRemoveSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmNicRemoveSettings SetOutput(this AzureVmNicRemoveSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmNicRemoveSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmNicRemoveSettings ResetOutput(this AzureVmNicRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmNicRemoveSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmNicRemoveSettings SetQuery(this AzureVmNicRemoveSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmNicRemoveSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmNicRemoveSettings ResetQuery(this AzureVmNicRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmNicRemoveSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmNicRemoveSettings SetVerbose(this AzureVmNicRemoveSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmNicRemoveSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmNicRemoveSettings ResetVerbose(this AzureVmNicRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmNicSetSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmNicSetSettingsExtensions
    {
        #region Nics
        /// <summary><p><em>Sets <see cref="AzureVmNicSetSettings.Nics"/>.</em></p><p>Names or IDs of NICs.</p></summary>
        [Pure]
        public static AzureVmNicSetSettings SetNics(this AzureVmNicSetSettings toolSettings, string nics)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Nics = nics;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmNicSetSettings.Nics"/>.</em></p><p>Names or IDs of NICs.</p></summary>
        [Pure]
        public static AzureVmNicSetSettings ResetNics(this AzureVmNicSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Nics = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmNicSetSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmNicSetSettings SetResourceGroup(this AzureVmNicSetSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmNicSetSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmNicSetSettings ResetResourceGroup(this AzureVmNicSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region VmName
        /// <summary><p><em>Sets <see cref="AzureVmNicSetSettings.VmName"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmNicSetSettings SetVmName(this AzureVmNicSetSettings toolSettings, string vmName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmName = vmName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmNicSetSettings.VmName"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmNicSetSettings ResetVmName(this AzureVmNicSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmName = null;
            return toolSettings;
        }
        #endregion
        #region PrimaryNic
        /// <summary><p><em>Sets <see cref="AzureVmNicSetSettings.PrimaryNic"/>.</em></p><p>Name or ID of the primary NIC. If missing, the first NIC in the list will be the primary.</p></summary>
        [Pure]
        public static AzureVmNicSetSettings SetPrimaryNic(this AzureVmNicSetSettings toolSettings, string primaryNic)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PrimaryNic = primaryNic;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmNicSetSettings.PrimaryNic"/>.</em></p><p>Name or ID of the primary NIC. If missing, the first NIC in the list will be the primary.</p></summary>
        [Pure]
        public static AzureVmNicSetSettings ResetPrimaryNic(this AzureVmNicSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PrimaryNic = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmNicSetSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmNicSetSettings SetDebug(this AzureVmNicSetSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmNicSetSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmNicSetSettings ResetDebug(this AzureVmNicSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmNicSetSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmNicSetSettings SetHelp(this AzureVmNicSetSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmNicSetSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmNicSetSettings ResetHelp(this AzureVmNicSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmNicSetSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmNicSetSettings SetOutput(this AzureVmNicSetSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmNicSetSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmNicSetSettings ResetOutput(this AzureVmNicSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmNicSetSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmNicSetSettings SetQuery(this AzureVmNicSetSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmNicSetSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmNicSetSettings ResetQuery(this AzureVmNicSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmNicSetSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmNicSetSettings SetVerbose(this AzureVmNicSetSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmNicSetSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmNicSetSettings ResetVerbose(this AzureVmNicSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmNicShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmNicShowSettingsExtensions
    {
        #region Nic
        /// <summary><p><em>Sets <see cref="AzureVmNicShowSettings.Nic"/>.</em></p><p>NIC name or ID.</p></summary>
        [Pure]
        public static AzureVmNicShowSettings SetNic(this AzureVmNicShowSettings toolSettings, string nic)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Nic = nic;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmNicShowSettings.Nic"/>.</em></p><p>NIC name or ID.</p></summary>
        [Pure]
        public static AzureVmNicShowSettings ResetNic(this AzureVmNicShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Nic = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmNicShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmNicShowSettings SetResourceGroup(this AzureVmNicShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmNicShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmNicShowSettings ResetResourceGroup(this AzureVmNicShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region VmName
        /// <summary><p><em>Sets <see cref="AzureVmNicShowSettings.VmName"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmNicShowSettings SetVmName(this AzureVmNicShowSettings toolSettings, string vmName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmName = vmName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmNicShowSettings.VmName"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmNicShowSettings ResetVmName(this AzureVmNicShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmNicShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmNicShowSettings SetDebug(this AzureVmNicShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmNicShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmNicShowSettings ResetDebug(this AzureVmNicShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmNicShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmNicShowSettings SetHelp(this AzureVmNicShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmNicShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmNicShowSettings ResetHelp(this AzureVmNicShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmNicShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmNicShowSettings SetOutput(this AzureVmNicShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmNicShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmNicShowSettings ResetOutput(this AzureVmNicShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmNicShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmNicShowSettings SetQuery(this AzureVmNicShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmNicShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmNicShowSettings ResetQuery(this AzureVmNicShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmNicShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmNicShowSettings SetVerbose(this AzureVmNicShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmNicShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmNicShowSettings ResetVerbose(this AzureVmNicShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmRunCommandInvokeSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmRunCommandInvokeSettingsExtensions
    {
        #region CommandId
        /// <summary><p><em>Sets <see cref="AzureVmRunCommandInvokeSettings.CommandId"/>.</em></p><p>The run command ID.</p></summary>
        [Pure]
        public static AzureVmRunCommandInvokeSettings SetCommandId(this AzureVmRunCommandInvokeSettings toolSettings, string commandId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CommandId = commandId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmRunCommandInvokeSettings.CommandId"/>.</em></p><p>The run command ID.</p></summary>
        [Pure]
        public static AzureVmRunCommandInvokeSettings ResetCommandId(this AzureVmRunCommandInvokeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CommandId = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmRunCommandInvokeSettings.Name"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmRunCommandInvokeSettings SetName(this AzureVmRunCommandInvokeSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmRunCommandInvokeSettings.Name"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmRunCommandInvokeSettings ResetName(this AzureVmRunCommandInvokeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmRunCommandInvokeSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmRunCommandInvokeSettings SetResourceGroup(this AzureVmRunCommandInvokeSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmRunCommandInvokeSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmRunCommandInvokeSettings ResetResourceGroup(this AzureVmRunCommandInvokeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Parameters
        /// <summary><p><em>Sets <see cref="AzureVmRunCommandInvokeSettings.Parameters"/>.</em></p><p>Space-separated parameters in the format of '[name=]value'.</p></summary>
        [Pure]
        public static AzureVmRunCommandInvokeSettings SetParameters(this AzureVmRunCommandInvokeSettings toolSettings, string parameters)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parameters = parameters;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmRunCommandInvokeSettings.Parameters"/>.</em></p><p>Space-separated parameters in the format of '[name=]value'.</p></summary>
        [Pure]
        public static AzureVmRunCommandInvokeSettings ResetParameters(this AzureVmRunCommandInvokeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parameters = null;
            return toolSettings;
        }
        #endregion
        #region Scripts
        /// <summary><p><em>Sets <see cref="AzureVmRunCommandInvokeSettings.Scripts"/>.</em></p><p>Script lines separated by whites spaces. Use @{file} to load from a file.</p></summary>
        [Pure]
        public static AzureVmRunCommandInvokeSettings SetScripts(this AzureVmRunCommandInvokeSettings toolSettings, string scripts)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Scripts = scripts;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmRunCommandInvokeSettings.Scripts"/>.</em></p><p>Script lines separated by whites spaces. Use @{file} to load from a file.</p></summary>
        [Pure]
        public static AzureVmRunCommandInvokeSettings ResetScripts(this AzureVmRunCommandInvokeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Scripts = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmRunCommandInvokeSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmRunCommandInvokeSettings SetDebug(this AzureVmRunCommandInvokeSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmRunCommandInvokeSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmRunCommandInvokeSettings ResetDebug(this AzureVmRunCommandInvokeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmRunCommandInvokeSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmRunCommandInvokeSettings SetHelp(this AzureVmRunCommandInvokeSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmRunCommandInvokeSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmRunCommandInvokeSettings ResetHelp(this AzureVmRunCommandInvokeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmRunCommandInvokeSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmRunCommandInvokeSettings SetOutput(this AzureVmRunCommandInvokeSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmRunCommandInvokeSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmRunCommandInvokeSettings ResetOutput(this AzureVmRunCommandInvokeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmRunCommandInvokeSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmRunCommandInvokeSettings SetQuery(this AzureVmRunCommandInvokeSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmRunCommandInvokeSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmRunCommandInvokeSettings ResetQuery(this AzureVmRunCommandInvokeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmRunCommandInvokeSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmRunCommandInvokeSettings SetVerbose(this AzureVmRunCommandInvokeSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmRunCommandInvokeSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmRunCommandInvokeSettings ResetVerbose(this AzureVmRunCommandInvokeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmRunCommandListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmRunCommandListSettingsExtensions
    {
        #region Location
        /// <summary><p><em>Sets <see cref="AzureVmRunCommandListSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmRunCommandListSettings SetLocation(this AzureVmRunCommandListSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmRunCommandListSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmRunCommandListSettings ResetLocation(this AzureVmRunCommandListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmRunCommandListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmRunCommandListSettings SetDebug(this AzureVmRunCommandListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmRunCommandListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmRunCommandListSettings ResetDebug(this AzureVmRunCommandListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmRunCommandListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmRunCommandListSettings SetHelp(this AzureVmRunCommandListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmRunCommandListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmRunCommandListSettings ResetHelp(this AzureVmRunCommandListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmRunCommandListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmRunCommandListSettings SetOutput(this AzureVmRunCommandListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmRunCommandListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmRunCommandListSettings ResetOutput(this AzureVmRunCommandListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmRunCommandListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmRunCommandListSettings SetQuery(this AzureVmRunCommandListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmRunCommandListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmRunCommandListSettings ResetQuery(this AzureVmRunCommandListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmRunCommandListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmRunCommandListSettings SetVerbose(this AzureVmRunCommandListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmRunCommandListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmRunCommandListSettings ResetVerbose(this AzureVmRunCommandListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmRunCommandShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmRunCommandShowSettingsExtensions
    {
        #region CommandId
        /// <summary><p><em>Sets <see cref="AzureVmRunCommandShowSettings.CommandId"/>.</em></p><p>The run command ID.</p></summary>
        [Pure]
        public static AzureVmRunCommandShowSettings SetCommandId(this AzureVmRunCommandShowSettings toolSettings, string commandId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CommandId = commandId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmRunCommandShowSettings.CommandId"/>.</em></p><p>The run command ID.</p></summary>
        [Pure]
        public static AzureVmRunCommandShowSettings ResetCommandId(this AzureVmRunCommandShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CommandId = null;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary><p><em>Sets <see cref="AzureVmRunCommandShowSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmRunCommandShowSettings SetLocation(this AzureVmRunCommandShowSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmRunCommandShowSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmRunCommandShowSettings ResetLocation(this AzureVmRunCommandShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmRunCommandShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmRunCommandShowSettings SetDebug(this AzureVmRunCommandShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmRunCommandShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmRunCommandShowSettings ResetDebug(this AzureVmRunCommandShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmRunCommandShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmRunCommandShowSettings SetHelp(this AzureVmRunCommandShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmRunCommandShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmRunCommandShowSettings ResetHelp(this AzureVmRunCommandShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmRunCommandShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmRunCommandShowSettings SetOutput(this AzureVmRunCommandShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmRunCommandShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmRunCommandShowSettings ResetOutput(this AzureVmRunCommandShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmRunCommandShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmRunCommandShowSettings SetQuery(this AzureVmRunCommandShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmRunCommandShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmRunCommandShowSettings ResetQuery(this AzureVmRunCommandShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmRunCommandShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmRunCommandShowSettings SetVerbose(this AzureVmRunCommandShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmRunCommandShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmRunCommandShowSettings ResetVerbose(this AzureVmRunCommandShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmSecretAddSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmSecretAddSettingsExtensions
    {
        #region Certificate
        /// <summary><p><em>Sets <see cref="AzureVmSecretAddSettings.Certificate"/>.</em></p><p>Key vault certificate name or its full secret URL.</p></summary>
        [Pure]
        public static AzureVmSecretAddSettings SetCertificate(this AzureVmSecretAddSettings toolSettings, string certificate)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Certificate = certificate;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmSecretAddSettings.Certificate"/>.</em></p><p>Key vault certificate name or its full secret URL.</p></summary>
        [Pure]
        public static AzureVmSecretAddSettings ResetCertificate(this AzureVmSecretAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Certificate = null;
            return toolSettings;
        }
        #endregion
        #region Keyvault
        /// <summary><p><em>Sets <see cref="AzureVmSecretAddSettings.Keyvault"/>.</em></p><p>Name or ID of the key vault.</p></summary>
        [Pure]
        public static AzureVmSecretAddSettings SetKeyvault(this AzureVmSecretAddSettings toolSettings, string keyvault)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Keyvault = keyvault;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmSecretAddSettings.Keyvault"/>.</em></p><p>Name or ID of the key vault.</p></summary>
        [Pure]
        public static AzureVmSecretAddSettings ResetKeyvault(this AzureVmSecretAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Keyvault = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmSecretAddSettings.Name"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmSecretAddSettings SetName(this AzureVmSecretAddSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmSecretAddSettings.Name"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmSecretAddSettings ResetName(this AzureVmSecretAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmSecretAddSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmSecretAddSettings SetResourceGroup(this AzureVmSecretAddSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmSecretAddSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmSecretAddSettings ResetResourceGroup(this AzureVmSecretAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region CertificateStore
        /// <summary><p><em>Sets <see cref="AzureVmSecretAddSettings.CertificateStore"/>.</em></p><p>Windows certificate store names. Default: My.</p></summary>
        [Pure]
        public static AzureVmSecretAddSettings SetCertificateStore(this AzureVmSecretAddSettings toolSettings, string certificateStore)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertificateStore = certificateStore;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmSecretAddSettings.CertificateStore"/>.</em></p><p>Windows certificate store names. Default: My.</p></summary>
        [Pure]
        public static AzureVmSecretAddSettings ResetCertificateStore(this AzureVmSecretAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertificateStore = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmSecretAddSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmSecretAddSettings SetDebug(this AzureVmSecretAddSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmSecretAddSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmSecretAddSettings ResetDebug(this AzureVmSecretAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmSecretAddSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmSecretAddSettings SetHelp(this AzureVmSecretAddSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmSecretAddSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmSecretAddSettings ResetHelp(this AzureVmSecretAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmSecretAddSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmSecretAddSettings SetOutput(this AzureVmSecretAddSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmSecretAddSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmSecretAddSettings ResetOutput(this AzureVmSecretAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmSecretAddSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmSecretAddSettings SetQuery(this AzureVmSecretAddSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmSecretAddSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmSecretAddSettings ResetQuery(this AzureVmSecretAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmSecretAddSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmSecretAddSettings SetVerbose(this AzureVmSecretAddSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmSecretAddSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmSecretAddSettings ResetVerbose(this AzureVmSecretAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmSecretFormatSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmSecretFormatSettingsExtensions
    {
        #region Secrets
        /// <summary><p><em>Sets <see cref="AzureVmSecretFormatSettings.Secrets"/> to a new list.</em></p><p>Space-separated list of key vault secret URIs. Perhaps, produced by 'az keyvault secret list-versions --vault-name vaultname -n cert1 --query "[?attributes.enabled].id" -o tsv'.</p></summary>
        [Pure]
        public static AzureVmSecretFormatSettings SetSecrets(this AzureVmSecretFormatSettings toolSettings, params string[] secrets)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SecretsInternal = secrets.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureVmSecretFormatSettings.Secrets"/> to a new list.</em></p><p>Space-separated list of key vault secret URIs. Perhaps, produced by 'az keyvault secret list-versions --vault-name vaultname -n cert1 --query "[?attributes.enabled].id" -o tsv'.</p></summary>
        [Pure]
        public static AzureVmSecretFormatSettings SetSecrets(this AzureVmSecretFormatSettings toolSettings, IEnumerable<string> secrets)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SecretsInternal = secrets.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmSecretFormatSettings.Secrets"/>.</em></p><p>Space-separated list of key vault secret URIs. Perhaps, produced by 'az keyvault secret list-versions --vault-name vaultname -n cert1 --query "[?attributes.enabled].id" -o tsv'.</p></summary>
        [Pure]
        public static AzureVmSecretFormatSettings AddSecrets(this AzureVmSecretFormatSettings toolSettings, params string[] secrets)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SecretsInternal.AddRange(secrets);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmSecretFormatSettings.Secrets"/>.</em></p><p>Space-separated list of key vault secret URIs. Perhaps, produced by 'az keyvault secret list-versions --vault-name vaultname -n cert1 --query "[?attributes.enabled].id" -o tsv'.</p></summary>
        [Pure]
        public static AzureVmSecretFormatSettings AddSecrets(this AzureVmSecretFormatSettings toolSettings, IEnumerable<string> secrets)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SecretsInternal.AddRange(secrets);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureVmSecretFormatSettings.Secrets"/>.</em></p><p>Space-separated list of key vault secret URIs. Perhaps, produced by 'az keyvault secret list-versions --vault-name vaultname -n cert1 --query "[?attributes.enabled].id" -o tsv'.</p></summary>
        [Pure]
        public static AzureVmSecretFormatSettings ClearSecrets(this AzureVmSecretFormatSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SecretsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmSecretFormatSettings.Secrets"/>.</em></p><p>Space-separated list of key vault secret URIs. Perhaps, produced by 'az keyvault secret list-versions --vault-name vaultname -n cert1 --query "[?attributes.enabled].id" -o tsv'.</p></summary>
        [Pure]
        public static AzureVmSecretFormatSettings RemoveSecrets(this AzureVmSecretFormatSettings toolSettings, params string[] secrets)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(secrets);
            toolSettings.SecretsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmSecretFormatSettings.Secrets"/>.</em></p><p>Space-separated list of key vault secret URIs. Perhaps, produced by 'az keyvault secret list-versions --vault-name vaultname -n cert1 --query "[?attributes.enabled].id" -o tsv'.</p></summary>
        [Pure]
        public static AzureVmSecretFormatSettings RemoveSecrets(this AzureVmSecretFormatSettings toolSettings, IEnumerable<string> secrets)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(secrets);
            toolSettings.SecretsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region CertificateStore
        /// <summary><p><em>Sets <see cref="AzureVmSecretFormatSettings.CertificateStore"/>.</em></p><p>Windows certificate store names. Default: My.</p></summary>
        [Pure]
        public static AzureVmSecretFormatSettings SetCertificateStore(this AzureVmSecretFormatSettings toolSettings, string certificateStore)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertificateStore = certificateStore;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmSecretFormatSettings.CertificateStore"/>.</em></p><p>Windows certificate store names. Default: My.</p></summary>
        [Pure]
        public static AzureVmSecretFormatSettings ResetCertificateStore(this AzureVmSecretFormatSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertificateStore = null;
            return toolSettings;
        }
        #endregion
        #region Keyvault
        /// <summary><p><em>Sets <see cref="AzureVmSecretFormatSettings.Keyvault"/>.</em></p><p>Name or ID of the key vault.</p></summary>
        [Pure]
        public static AzureVmSecretFormatSettings SetKeyvault(this AzureVmSecretFormatSettings toolSettings, string keyvault)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Keyvault = keyvault;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmSecretFormatSettings.Keyvault"/>.</em></p><p>Name or ID of the key vault.</p></summary>
        [Pure]
        public static AzureVmSecretFormatSettings ResetKeyvault(this AzureVmSecretFormatSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Keyvault = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmSecretFormatSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmSecretFormatSettings SetResourceGroup(this AzureVmSecretFormatSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmSecretFormatSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmSecretFormatSettings ResetResourceGroup(this AzureVmSecretFormatSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmSecretFormatSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmSecretFormatSettings SetDebug(this AzureVmSecretFormatSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmSecretFormatSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmSecretFormatSettings ResetDebug(this AzureVmSecretFormatSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmSecretFormatSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmSecretFormatSettings SetHelp(this AzureVmSecretFormatSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmSecretFormatSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmSecretFormatSettings ResetHelp(this AzureVmSecretFormatSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmSecretFormatSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmSecretFormatSettings SetOutput(this AzureVmSecretFormatSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmSecretFormatSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmSecretFormatSettings ResetOutput(this AzureVmSecretFormatSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmSecretFormatSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmSecretFormatSettings SetQuery(this AzureVmSecretFormatSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmSecretFormatSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmSecretFormatSettings ResetQuery(this AzureVmSecretFormatSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmSecretFormatSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmSecretFormatSettings SetVerbose(this AzureVmSecretFormatSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmSecretFormatSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmSecretFormatSettings ResetVerbose(this AzureVmSecretFormatSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmSecretListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmSecretListSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmSecretListSettings.Name"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmSecretListSettings SetName(this AzureVmSecretListSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmSecretListSettings.Name"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmSecretListSettings ResetName(this AzureVmSecretListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmSecretListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmSecretListSettings SetResourceGroup(this AzureVmSecretListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmSecretListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmSecretListSettings ResetResourceGroup(this AzureVmSecretListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmSecretListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmSecretListSettings SetDebug(this AzureVmSecretListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmSecretListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmSecretListSettings ResetDebug(this AzureVmSecretListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmSecretListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmSecretListSettings SetHelp(this AzureVmSecretListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmSecretListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmSecretListSettings ResetHelp(this AzureVmSecretListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmSecretListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmSecretListSettings SetOutput(this AzureVmSecretListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmSecretListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmSecretListSettings ResetOutput(this AzureVmSecretListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmSecretListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmSecretListSettings SetQuery(this AzureVmSecretListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmSecretListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmSecretListSettings ResetQuery(this AzureVmSecretListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmSecretListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmSecretListSettings SetVerbose(this AzureVmSecretListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmSecretListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmSecretListSettings ResetVerbose(this AzureVmSecretListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmSecretRemoveSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmSecretRemoveSettingsExtensions
    {
        #region Keyvault
        /// <summary><p><em>Sets <see cref="AzureVmSecretRemoveSettings.Keyvault"/>.</em></p><p>Name or ID of the key vault.</p></summary>
        [Pure]
        public static AzureVmSecretRemoveSettings SetKeyvault(this AzureVmSecretRemoveSettings toolSettings, string keyvault)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Keyvault = keyvault;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmSecretRemoveSettings.Keyvault"/>.</em></p><p>Name or ID of the key vault.</p></summary>
        [Pure]
        public static AzureVmSecretRemoveSettings ResetKeyvault(this AzureVmSecretRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Keyvault = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmSecretRemoveSettings.Name"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmSecretRemoveSettings SetName(this AzureVmSecretRemoveSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmSecretRemoveSettings.Name"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmSecretRemoveSettings ResetName(this AzureVmSecretRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmSecretRemoveSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmSecretRemoveSettings SetResourceGroup(this AzureVmSecretRemoveSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmSecretRemoveSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmSecretRemoveSettings ResetResourceGroup(this AzureVmSecretRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Certificate
        /// <summary><p><em>Sets <see cref="AzureVmSecretRemoveSettings.Certificate"/>.</em></p><p>Key vault certificate name or its full secret URL.</p></summary>
        [Pure]
        public static AzureVmSecretRemoveSettings SetCertificate(this AzureVmSecretRemoveSettings toolSettings, string certificate)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Certificate = certificate;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmSecretRemoveSettings.Certificate"/>.</em></p><p>Key vault certificate name or its full secret URL.</p></summary>
        [Pure]
        public static AzureVmSecretRemoveSettings ResetCertificate(this AzureVmSecretRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Certificate = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmSecretRemoveSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmSecretRemoveSettings SetDebug(this AzureVmSecretRemoveSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmSecretRemoveSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmSecretRemoveSettings ResetDebug(this AzureVmSecretRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmSecretRemoveSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmSecretRemoveSettings SetHelp(this AzureVmSecretRemoveSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmSecretRemoveSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmSecretRemoveSettings ResetHelp(this AzureVmSecretRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmSecretRemoveSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmSecretRemoveSettings SetOutput(this AzureVmSecretRemoveSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmSecretRemoveSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmSecretRemoveSettings ResetOutput(this AzureVmSecretRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmSecretRemoveSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmSecretRemoveSettings SetQuery(this AzureVmSecretRemoveSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmSecretRemoveSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmSecretRemoveSettings ResetQuery(this AzureVmSecretRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmSecretRemoveSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmSecretRemoveSettings SetVerbose(this AzureVmSecretRemoveSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmSecretRemoveSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmSecretRemoveSettings ResetVerbose(this AzureVmSecretRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmUnmanagedDiskAttachSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmUnmanagedDiskAttachSettingsExtensions
    {
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmUnmanagedDiskAttachSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmUnmanagedDiskAttachSettings SetResourceGroup(this AzureVmUnmanagedDiskAttachSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmUnmanagedDiskAttachSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmUnmanagedDiskAttachSettings ResetResourceGroup(this AzureVmUnmanagedDiskAttachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region VmName
        /// <summary><p><em>Sets <see cref="AzureVmUnmanagedDiskAttachSettings.VmName"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmUnmanagedDiskAttachSettings SetVmName(this AzureVmUnmanagedDiskAttachSettings toolSettings, string vmName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmName = vmName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmUnmanagedDiskAttachSettings.VmName"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmUnmanagedDiskAttachSettings ResetVmName(this AzureVmUnmanagedDiskAttachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmName = null;
            return toolSettings;
        }
        #endregion
        #region Caching
        /// <summary><p><em>Sets <see cref="AzureVmUnmanagedDiskAttachSettings.Caching"/>.</em></p><p>Disk caching policy.</p></summary>
        [Pure]
        public static AzureVmUnmanagedDiskAttachSettings SetCaching(this AzureVmUnmanagedDiskAttachSettings toolSettings, VmCreateOsDiskCaching caching)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Caching = caching;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmUnmanagedDiskAttachSettings.Caching"/>.</em></p><p>Disk caching policy.</p></summary>
        [Pure]
        public static AzureVmUnmanagedDiskAttachSettings ResetCaching(this AzureVmUnmanagedDiskAttachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Caching = null;
            return toolSettings;
        }
        #endregion
        #region Lun
        /// <summary><p><em>Sets <see cref="AzureVmUnmanagedDiskAttachSettings.Lun"/>.</em></p><p>0-based logical unit number (LUN). Max value depends on the Virtual Machine size.</p></summary>
        [Pure]
        public static AzureVmUnmanagedDiskAttachSettings SetLun(this AzureVmUnmanagedDiskAttachSettings toolSettings, string lun)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Lun = lun;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmUnmanagedDiskAttachSettings.Lun"/>.</em></p><p>0-based logical unit number (LUN). Max value depends on the Virtual Machine size.</p></summary>
        [Pure]
        public static AzureVmUnmanagedDiskAttachSettings ResetLun(this AzureVmUnmanagedDiskAttachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Lun = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmUnmanagedDiskAttachSettings.Name"/>.</em></p><p>The data disk name(optional when create a new disk).</p></summary>
        [Pure]
        public static AzureVmUnmanagedDiskAttachSettings SetName(this AzureVmUnmanagedDiskAttachSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmUnmanagedDiskAttachSettings.Name"/>.</em></p><p>The data disk name(optional when create a new disk).</p></summary>
        [Pure]
        public static AzureVmUnmanagedDiskAttachSettings ResetName(this AzureVmUnmanagedDiskAttachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region New
        /// <summary><p><em>Sets <see cref="AzureVmUnmanagedDiskAttachSettings.New"/>.</em></p><p>Create a new disk.</p></summary>
        [Pure]
        public static AzureVmUnmanagedDiskAttachSettings SetNew(this AzureVmUnmanagedDiskAttachSettings toolSettings, string @new)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.New = @new;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmUnmanagedDiskAttachSettings.New"/>.</em></p><p>Create a new disk.</p></summary>
        [Pure]
        public static AzureVmUnmanagedDiskAttachSettings ResetNew(this AzureVmUnmanagedDiskAttachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.New = null;
            return toolSettings;
        }
        #endregion
        #region SizeGb
        /// <summary><p><em>Sets <see cref="AzureVmUnmanagedDiskAttachSettings.SizeGb"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureVmUnmanagedDiskAttachSettings SetSizeGb(this AzureVmUnmanagedDiskAttachSettings toolSettings, string sizeGb)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SizeGb = sizeGb;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmUnmanagedDiskAttachSettings.SizeGb"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureVmUnmanagedDiskAttachSettings ResetSizeGb(this AzureVmUnmanagedDiskAttachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SizeGb = null;
            return toolSettings;
        }
        #endregion
        #region VhdUri
        /// <summary><p><em>Sets <see cref="AzureVmUnmanagedDiskAttachSettings.VhdUri"/>.</em></p><p>Virtual hard disk URI. For example: <a href="https://mystorage.blob.core.windows.net/vhds/d1.vhd">https://mystorage.blob.core.windows.net/vhds/d1.vhd</a>.</p></summary>
        [Pure]
        public static AzureVmUnmanagedDiskAttachSettings SetVhdUri(this AzureVmUnmanagedDiskAttachSettings toolSettings, string vhdUri)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VhdUri = vhdUri;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmUnmanagedDiskAttachSettings.VhdUri"/>.</em></p><p>Virtual hard disk URI. For example: <a href="https://mystorage.blob.core.windows.net/vhds/d1.vhd">https://mystorage.blob.core.windows.net/vhds/d1.vhd</a>.</p></summary>
        [Pure]
        public static AzureVmUnmanagedDiskAttachSettings ResetVhdUri(this AzureVmUnmanagedDiskAttachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VhdUri = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmUnmanagedDiskAttachSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmUnmanagedDiskAttachSettings SetDebug(this AzureVmUnmanagedDiskAttachSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmUnmanagedDiskAttachSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmUnmanagedDiskAttachSettings ResetDebug(this AzureVmUnmanagedDiskAttachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmUnmanagedDiskAttachSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmUnmanagedDiskAttachSettings SetHelp(this AzureVmUnmanagedDiskAttachSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmUnmanagedDiskAttachSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmUnmanagedDiskAttachSettings ResetHelp(this AzureVmUnmanagedDiskAttachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmUnmanagedDiskAttachSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmUnmanagedDiskAttachSettings SetOutput(this AzureVmUnmanagedDiskAttachSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmUnmanagedDiskAttachSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmUnmanagedDiskAttachSettings ResetOutput(this AzureVmUnmanagedDiskAttachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmUnmanagedDiskAttachSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmUnmanagedDiskAttachSettings SetQuery(this AzureVmUnmanagedDiskAttachSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmUnmanagedDiskAttachSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmUnmanagedDiskAttachSettings ResetQuery(this AzureVmUnmanagedDiskAttachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmUnmanagedDiskAttachSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmUnmanagedDiskAttachSettings SetVerbose(this AzureVmUnmanagedDiskAttachSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmUnmanagedDiskAttachSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmUnmanagedDiskAttachSettings ResetVerbose(this AzureVmUnmanagedDiskAttachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmUnmanagedDiskDetachSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmUnmanagedDiskDetachSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmUnmanagedDiskDetachSettings.Name"/>.</em></p><p>The data disk name.</p></summary>
        [Pure]
        public static AzureVmUnmanagedDiskDetachSettings SetName(this AzureVmUnmanagedDiskDetachSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmUnmanagedDiskDetachSettings.Name"/>.</em></p><p>The data disk name.</p></summary>
        [Pure]
        public static AzureVmUnmanagedDiskDetachSettings ResetName(this AzureVmUnmanagedDiskDetachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmUnmanagedDiskDetachSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmUnmanagedDiskDetachSettings SetResourceGroup(this AzureVmUnmanagedDiskDetachSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmUnmanagedDiskDetachSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmUnmanagedDiskDetachSettings ResetResourceGroup(this AzureVmUnmanagedDiskDetachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region VmName
        /// <summary><p><em>Sets <see cref="AzureVmUnmanagedDiskDetachSettings.VmName"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmUnmanagedDiskDetachSettings SetVmName(this AzureVmUnmanagedDiskDetachSettings toolSettings, string vmName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmName = vmName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmUnmanagedDiskDetachSettings.VmName"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmUnmanagedDiskDetachSettings ResetVmName(this AzureVmUnmanagedDiskDetachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmUnmanagedDiskDetachSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmUnmanagedDiskDetachSettings SetDebug(this AzureVmUnmanagedDiskDetachSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmUnmanagedDiskDetachSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmUnmanagedDiskDetachSettings ResetDebug(this AzureVmUnmanagedDiskDetachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmUnmanagedDiskDetachSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmUnmanagedDiskDetachSettings SetHelp(this AzureVmUnmanagedDiskDetachSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmUnmanagedDiskDetachSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmUnmanagedDiskDetachSettings ResetHelp(this AzureVmUnmanagedDiskDetachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmUnmanagedDiskDetachSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmUnmanagedDiskDetachSettings SetOutput(this AzureVmUnmanagedDiskDetachSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmUnmanagedDiskDetachSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmUnmanagedDiskDetachSettings ResetOutput(this AzureVmUnmanagedDiskDetachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmUnmanagedDiskDetachSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmUnmanagedDiskDetachSettings SetQuery(this AzureVmUnmanagedDiskDetachSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmUnmanagedDiskDetachSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmUnmanagedDiskDetachSettings ResetQuery(this AzureVmUnmanagedDiskDetachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmUnmanagedDiskDetachSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmUnmanagedDiskDetachSettings SetVerbose(this AzureVmUnmanagedDiskDetachSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmUnmanagedDiskDetachSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmUnmanagedDiskDetachSettings ResetVerbose(this AzureVmUnmanagedDiskDetachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmUnmanagedDiskListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmUnmanagedDiskListSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmUnmanagedDiskListSettings.Name"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmUnmanagedDiskListSettings SetName(this AzureVmUnmanagedDiskListSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmUnmanagedDiskListSettings.Name"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmUnmanagedDiskListSettings ResetName(this AzureVmUnmanagedDiskListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmUnmanagedDiskListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmUnmanagedDiskListSettings SetResourceGroup(this AzureVmUnmanagedDiskListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmUnmanagedDiskListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmUnmanagedDiskListSettings ResetResourceGroup(this AzureVmUnmanagedDiskListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmUnmanagedDiskListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmUnmanagedDiskListSettings SetDebug(this AzureVmUnmanagedDiskListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmUnmanagedDiskListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmUnmanagedDiskListSettings ResetDebug(this AzureVmUnmanagedDiskListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmUnmanagedDiskListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmUnmanagedDiskListSettings SetHelp(this AzureVmUnmanagedDiskListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmUnmanagedDiskListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmUnmanagedDiskListSettings ResetHelp(this AzureVmUnmanagedDiskListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmUnmanagedDiskListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmUnmanagedDiskListSettings SetOutput(this AzureVmUnmanagedDiskListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmUnmanagedDiskListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmUnmanagedDiskListSettings ResetOutput(this AzureVmUnmanagedDiskListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmUnmanagedDiskListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmUnmanagedDiskListSettings SetQuery(this AzureVmUnmanagedDiskListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmUnmanagedDiskListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmUnmanagedDiskListSettings ResetQuery(this AzureVmUnmanagedDiskListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmUnmanagedDiskListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmUnmanagedDiskListSettings SetVerbose(this AzureVmUnmanagedDiskListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmUnmanagedDiskListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmUnmanagedDiskListSettings ResetVerbose(this AzureVmUnmanagedDiskListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmUserDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmUserDeleteSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmUserDeleteSettings.Name"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmUserDeleteSettings SetName(this AzureVmUserDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmUserDeleteSettings.Name"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmUserDeleteSettings ResetName(this AzureVmUserDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmUserDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmUserDeleteSettings SetResourceGroup(this AzureVmUserDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmUserDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmUserDeleteSettings ResetResourceGroup(this AzureVmUserDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Username
        /// <summary><p><em>Sets <see cref="AzureVmUserDeleteSettings.Username"/>.</em></p><p>The user name.</p></summary>
        [Pure]
        public static AzureVmUserDeleteSettings SetUsername(this AzureVmUserDeleteSettings toolSettings, string username)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Username = username;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmUserDeleteSettings.Username"/>.</em></p><p>The user name.</p></summary>
        [Pure]
        public static AzureVmUserDeleteSettings ResetUsername(this AzureVmUserDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Username = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary><p><em>Sets <see cref="AzureVmUserDeleteSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmUserDeleteSettings SetNoWait(this AzureVmUserDeleteSettings toolSettings, string noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmUserDeleteSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmUserDeleteSettings ResetNoWait(this AzureVmUserDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmUserDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmUserDeleteSettings SetDebug(this AzureVmUserDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmUserDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmUserDeleteSettings ResetDebug(this AzureVmUserDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmUserDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmUserDeleteSettings SetHelp(this AzureVmUserDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmUserDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmUserDeleteSettings ResetHelp(this AzureVmUserDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmUserDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmUserDeleteSettings SetOutput(this AzureVmUserDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmUserDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmUserDeleteSettings ResetOutput(this AzureVmUserDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmUserDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmUserDeleteSettings SetQuery(this AzureVmUserDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmUserDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmUserDeleteSettings ResetQuery(this AzureVmUserDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmUserDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmUserDeleteSettings SetVerbose(this AzureVmUserDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmUserDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmUserDeleteSettings ResetVerbose(this AzureVmUserDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmUserResetSshSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmUserResetSshSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmUserResetSshSettings.Name"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmUserResetSshSettings SetName(this AzureVmUserResetSshSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmUserResetSshSettings.Name"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmUserResetSshSettings ResetName(this AzureVmUserResetSshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmUserResetSshSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmUserResetSshSettings SetResourceGroup(this AzureVmUserResetSshSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmUserResetSshSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmUserResetSshSettings ResetResourceGroup(this AzureVmUserResetSshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary><p><em>Sets <see cref="AzureVmUserResetSshSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmUserResetSshSettings SetNoWait(this AzureVmUserResetSshSettings toolSettings, string noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmUserResetSshSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmUserResetSshSettings ResetNoWait(this AzureVmUserResetSshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmUserResetSshSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmUserResetSshSettings SetDebug(this AzureVmUserResetSshSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmUserResetSshSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmUserResetSshSettings ResetDebug(this AzureVmUserResetSshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmUserResetSshSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmUserResetSshSettings SetHelp(this AzureVmUserResetSshSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmUserResetSshSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmUserResetSshSettings ResetHelp(this AzureVmUserResetSshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmUserResetSshSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmUserResetSshSettings SetOutput(this AzureVmUserResetSshSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmUserResetSshSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmUserResetSshSettings ResetOutput(this AzureVmUserResetSshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmUserResetSshSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmUserResetSshSettings SetQuery(this AzureVmUserResetSshSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmUserResetSshSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmUserResetSshSettings ResetQuery(this AzureVmUserResetSshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmUserResetSshSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmUserResetSshSettings SetVerbose(this AzureVmUserResetSshSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmUserResetSshSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmUserResetSshSettings ResetVerbose(this AzureVmUserResetSshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmUserUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmUserUpdateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmUserUpdateSettings.Name"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmUserUpdateSettings SetName(this AzureVmUserUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmUserUpdateSettings.Name"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmUserUpdateSettings ResetName(this AzureVmUserUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmUserUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmUserUpdateSettings SetResourceGroup(this AzureVmUserUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmUserUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmUserUpdateSettings ResetResourceGroup(this AzureVmUserUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Username
        /// <summary><p><em>Sets <see cref="AzureVmUserUpdateSettings.Username"/>.</em></p><p>The user name.</p></summary>
        [Pure]
        public static AzureVmUserUpdateSettings SetUsername(this AzureVmUserUpdateSettings toolSettings, string username)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Username = username;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmUserUpdateSettings.Username"/>.</em></p><p>The user name.</p></summary>
        [Pure]
        public static AzureVmUserUpdateSettings ResetUsername(this AzureVmUserUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Username = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary><p><em>Sets <see cref="AzureVmUserUpdateSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmUserUpdateSettings SetNoWait(this AzureVmUserUpdateSettings toolSettings, string noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmUserUpdateSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmUserUpdateSettings ResetNoWait(this AzureVmUserUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        #endregion
        #region Password
        /// <summary><p><em>Sets <see cref="AzureVmUserUpdateSettings.Password"/>.</em></p><p>The user password.</p></summary>
        [Pure]
        public static AzureVmUserUpdateSettings SetPassword(this AzureVmUserUpdateSettings toolSettings, string password)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = password;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmUserUpdateSettings.Password"/>.</em></p><p>The user password.</p></summary>
        [Pure]
        public static AzureVmUserUpdateSettings ResetPassword(this AzureVmUserUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = null;
            return toolSettings;
        }
        #endregion
        #region SshKeyValue
        /// <summary><p><em>Sets <see cref="AzureVmUserUpdateSettings.SshKeyValue"/>.</em></p><p>SSH public key file value or public key file path.</p></summary>
        [Pure]
        public static AzureVmUserUpdateSettings SetSshKeyValue(this AzureVmUserUpdateSettings toolSettings, string sshKeyValue)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SshKeyValue = sshKeyValue;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmUserUpdateSettings.SshKeyValue"/>.</em></p><p>SSH public key file value or public key file path.</p></summary>
        [Pure]
        public static AzureVmUserUpdateSettings ResetSshKeyValue(this AzureVmUserUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SshKeyValue = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmUserUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmUserUpdateSettings SetDebug(this AzureVmUserUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmUserUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmUserUpdateSettings ResetDebug(this AzureVmUserUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmUserUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmUserUpdateSettings SetHelp(this AzureVmUserUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmUserUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmUserUpdateSettings ResetHelp(this AzureVmUserUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmUserUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmUserUpdateSettings SetOutput(this AzureVmUserUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmUserUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmUserUpdateSettings ResetOutput(this AzureVmUserUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmUserUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmUserUpdateSettings SetQuery(this AzureVmUserUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmUserUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmUserUpdateSettings ResetQuery(this AzureVmUserUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmUserUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmUserUpdateSettings SetVerbose(this AzureVmUserUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmUserUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmUserUpdateSettings ResetVerbose(this AzureVmUserUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmExtensionImageListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmExtensionImageListSettingsExtensions
    {
        #region Latest
        /// <summary><p><em>Sets <see cref="AzureVmExtensionImageListSettings.Latest"/>.</em></p><p>Show the latest version only.</p></summary>
        [Pure]
        public static AzureVmExtensionImageListSettings SetLatest(this AzureVmExtensionImageListSettings toolSettings, bool? latest)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Latest = latest;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionImageListSettings.Latest"/>.</em></p><p>Show the latest version only.</p></summary>
        [Pure]
        public static AzureVmExtensionImageListSettings ResetLatest(this AzureVmExtensionImageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Latest = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureVmExtensionImageListSettings.Latest"/>.</em></p><p>Show the latest version only.</p></summary>
        [Pure]
        public static AzureVmExtensionImageListSettings EnableLatest(this AzureVmExtensionImageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Latest = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureVmExtensionImageListSettings.Latest"/>.</em></p><p>Show the latest version only.</p></summary>
        [Pure]
        public static AzureVmExtensionImageListSettings DisableLatest(this AzureVmExtensionImageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Latest = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureVmExtensionImageListSettings.Latest"/>.</em></p><p>Show the latest version only.</p></summary>
        [Pure]
        public static AzureVmExtensionImageListSettings ToggleLatest(this AzureVmExtensionImageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Latest = !toolSettings.Latest;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary><p><em>Sets <see cref="AzureVmExtensionImageListSettings.Location"/>.</em></p><p>Image location.</p></summary>
        [Pure]
        public static AzureVmExtensionImageListSettings SetLocation(this AzureVmExtensionImageListSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionImageListSettings.Location"/>.</em></p><p>Image location.</p></summary>
        [Pure]
        public static AzureVmExtensionImageListSettings ResetLocation(this AzureVmExtensionImageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmExtensionImageListSettings.Name"/>.</em></p><p>Image name.</p></summary>
        [Pure]
        public static AzureVmExtensionImageListSettings SetName(this AzureVmExtensionImageListSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionImageListSettings.Name"/>.</em></p><p>Image name.</p></summary>
        [Pure]
        public static AzureVmExtensionImageListSettings ResetName(this AzureVmExtensionImageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Publisher
        /// <summary><p><em>Sets <see cref="AzureVmExtensionImageListSettings.Publisher"/>.</em></p><p>Image publisher name.</p></summary>
        [Pure]
        public static AzureVmExtensionImageListSettings SetPublisher(this AzureVmExtensionImageListSettings toolSettings, string publisher)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Publisher = publisher;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionImageListSettings.Publisher"/>.</em></p><p>Image publisher name.</p></summary>
        [Pure]
        public static AzureVmExtensionImageListSettings ResetPublisher(this AzureVmExtensionImageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Publisher = null;
            return toolSettings;
        }
        #endregion
        #region Version
        /// <summary><p><em>Sets <see cref="AzureVmExtensionImageListSettings.Version"/>.</em></p><p>Extension version.</p></summary>
        [Pure]
        public static AzureVmExtensionImageListSettings SetVersion(this AzureVmExtensionImageListSettings toolSettings, string version)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = version;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionImageListSettings.Version"/>.</em></p><p>Extension version.</p></summary>
        [Pure]
        public static AzureVmExtensionImageListSettings ResetVersion(this AzureVmExtensionImageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmExtensionImageListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmExtensionImageListSettings SetDebug(this AzureVmExtensionImageListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionImageListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmExtensionImageListSettings ResetDebug(this AzureVmExtensionImageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmExtensionImageListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmExtensionImageListSettings SetHelp(this AzureVmExtensionImageListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionImageListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmExtensionImageListSettings ResetHelp(this AzureVmExtensionImageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmExtensionImageListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmExtensionImageListSettings SetOutput(this AzureVmExtensionImageListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionImageListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmExtensionImageListSettings ResetOutput(this AzureVmExtensionImageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmExtensionImageListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmExtensionImageListSettings SetQuery(this AzureVmExtensionImageListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionImageListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmExtensionImageListSettings ResetQuery(this AzureVmExtensionImageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmExtensionImageListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmExtensionImageListSettings SetVerbose(this AzureVmExtensionImageListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionImageListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmExtensionImageListSettings ResetVerbose(this AzureVmExtensionImageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmExtensionImageListNamesSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmExtensionImageListNamesSettingsExtensions
    {
        #region Location
        /// <summary><p><em>Sets <see cref="AzureVmExtensionImageListNamesSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmExtensionImageListNamesSettings SetLocation(this AzureVmExtensionImageListNamesSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionImageListNamesSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmExtensionImageListNamesSettings ResetLocation(this AzureVmExtensionImageListNamesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region Publisher
        /// <summary><p><em>Sets <see cref="AzureVmExtensionImageListNamesSettings.Publisher"/>.</em></p><p>Image publisher name.</p></summary>
        [Pure]
        public static AzureVmExtensionImageListNamesSettings SetPublisher(this AzureVmExtensionImageListNamesSettings toolSettings, string publisher)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Publisher = publisher;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionImageListNamesSettings.Publisher"/>.</em></p><p>Image publisher name.</p></summary>
        [Pure]
        public static AzureVmExtensionImageListNamesSettings ResetPublisher(this AzureVmExtensionImageListNamesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Publisher = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmExtensionImageListNamesSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmExtensionImageListNamesSettings SetDebug(this AzureVmExtensionImageListNamesSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionImageListNamesSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmExtensionImageListNamesSettings ResetDebug(this AzureVmExtensionImageListNamesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmExtensionImageListNamesSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmExtensionImageListNamesSettings SetHelp(this AzureVmExtensionImageListNamesSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionImageListNamesSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmExtensionImageListNamesSettings ResetHelp(this AzureVmExtensionImageListNamesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmExtensionImageListNamesSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmExtensionImageListNamesSettings SetOutput(this AzureVmExtensionImageListNamesSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionImageListNamesSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmExtensionImageListNamesSettings ResetOutput(this AzureVmExtensionImageListNamesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmExtensionImageListNamesSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmExtensionImageListNamesSettings SetQuery(this AzureVmExtensionImageListNamesSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionImageListNamesSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmExtensionImageListNamesSettings ResetQuery(this AzureVmExtensionImageListNamesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmExtensionImageListNamesSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmExtensionImageListNamesSettings SetVerbose(this AzureVmExtensionImageListNamesSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionImageListNamesSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmExtensionImageListNamesSettings ResetVerbose(this AzureVmExtensionImageListNamesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmExtensionImageListVersionsSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmExtensionImageListVersionsSettingsExtensions
    {
        #region Location
        /// <summary><p><em>Sets <see cref="AzureVmExtensionImageListVersionsSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmExtensionImageListVersionsSettings SetLocation(this AzureVmExtensionImageListVersionsSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionImageListVersionsSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmExtensionImageListVersionsSettings ResetLocation(this AzureVmExtensionImageListVersionsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmExtensionImageListVersionsSettings.Name"/>.</em></p><p>Name of the extension.</p></summary>
        [Pure]
        public static AzureVmExtensionImageListVersionsSettings SetName(this AzureVmExtensionImageListVersionsSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionImageListVersionsSettings.Name"/>.</em></p><p>Name of the extension.</p></summary>
        [Pure]
        public static AzureVmExtensionImageListVersionsSettings ResetName(this AzureVmExtensionImageListVersionsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Publisher
        /// <summary><p><em>Sets <see cref="AzureVmExtensionImageListVersionsSettings.Publisher"/>.</em></p><p>Image publisher name.</p></summary>
        [Pure]
        public static AzureVmExtensionImageListVersionsSettings SetPublisher(this AzureVmExtensionImageListVersionsSettings toolSettings, string publisher)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Publisher = publisher;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionImageListVersionsSettings.Publisher"/>.</em></p><p>Image publisher name.</p></summary>
        [Pure]
        public static AzureVmExtensionImageListVersionsSettings ResetPublisher(this AzureVmExtensionImageListVersionsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Publisher = null;
            return toolSettings;
        }
        #endregion
        #region Filter
        /// <summary><p><em>Sets <see cref="AzureVmExtensionImageListVersionsSettings.Filter"/>.</em></p><p>The filter to apply on the operation.</p></summary>
        [Pure]
        public static AzureVmExtensionImageListVersionsSettings SetFilter(this AzureVmExtensionImageListVersionsSettings toolSettings, string filter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = filter;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionImageListVersionsSettings.Filter"/>.</em></p><p>The filter to apply on the operation.</p></summary>
        [Pure]
        public static AzureVmExtensionImageListVersionsSettings ResetFilter(this AzureVmExtensionImageListVersionsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = null;
            return toolSettings;
        }
        #endregion
        #region Orderby
        /// <summary><p><em>Sets <see cref="AzureVmExtensionImageListVersionsSettings.Orderby"/>.</em></p><p>The $orderby odata query option.</p></summary>
        [Pure]
        public static AzureVmExtensionImageListVersionsSettings SetOrderby(this AzureVmExtensionImageListVersionsSettings toolSettings, string orderby)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Orderby = orderby;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionImageListVersionsSettings.Orderby"/>.</em></p><p>The $orderby odata query option.</p></summary>
        [Pure]
        public static AzureVmExtensionImageListVersionsSettings ResetOrderby(this AzureVmExtensionImageListVersionsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Orderby = null;
            return toolSettings;
        }
        #endregion
        #region Top
        /// <summary><p><em>Sets <see cref="AzureVmExtensionImageListVersionsSettings.Top"/>.</em></p><p>The $top odata query option.</p></summary>
        [Pure]
        public static AzureVmExtensionImageListVersionsSettings SetTop(this AzureVmExtensionImageListVersionsSettings toolSettings, string top)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = top;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionImageListVersionsSettings.Top"/>.</em></p><p>The $top odata query option.</p></summary>
        [Pure]
        public static AzureVmExtensionImageListVersionsSettings ResetTop(this AzureVmExtensionImageListVersionsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmExtensionImageListVersionsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmExtensionImageListVersionsSettings SetDebug(this AzureVmExtensionImageListVersionsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionImageListVersionsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmExtensionImageListVersionsSettings ResetDebug(this AzureVmExtensionImageListVersionsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmExtensionImageListVersionsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmExtensionImageListVersionsSettings SetHelp(this AzureVmExtensionImageListVersionsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionImageListVersionsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmExtensionImageListVersionsSettings ResetHelp(this AzureVmExtensionImageListVersionsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmExtensionImageListVersionsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmExtensionImageListVersionsSettings SetOutput(this AzureVmExtensionImageListVersionsSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionImageListVersionsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmExtensionImageListVersionsSettings ResetOutput(this AzureVmExtensionImageListVersionsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmExtensionImageListVersionsSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmExtensionImageListVersionsSettings SetQuery(this AzureVmExtensionImageListVersionsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionImageListVersionsSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmExtensionImageListVersionsSettings ResetQuery(this AzureVmExtensionImageListVersionsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmExtensionImageListVersionsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmExtensionImageListVersionsSettings SetVerbose(this AzureVmExtensionImageListVersionsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionImageListVersionsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmExtensionImageListVersionsSettings ResetVerbose(this AzureVmExtensionImageListVersionsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmExtensionImageShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmExtensionImageShowSettingsExtensions
    {
        #region Location
        /// <summary><p><em>Sets <see cref="AzureVmExtensionImageShowSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmExtensionImageShowSettings SetLocation(this AzureVmExtensionImageShowSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionImageShowSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmExtensionImageShowSettings ResetLocation(this AzureVmExtensionImageShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmExtensionImageShowSettings.Name"/>.</em></p><p>Name of the extension.</p></summary>
        [Pure]
        public static AzureVmExtensionImageShowSettings SetName(this AzureVmExtensionImageShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionImageShowSettings.Name"/>.</em></p><p>Name of the extension.</p></summary>
        [Pure]
        public static AzureVmExtensionImageShowSettings ResetName(this AzureVmExtensionImageShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Publisher
        /// <summary><p><em>Sets <see cref="AzureVmExtensionImageShowSettings.Publisher"/>.</em></p><p>Image publisher name.</p></summary>
        [Pure]
        public static AzureVmExtensionImageShowSettings SetPublisher(this AzureVmExtensionImageShowSettings toolSettings, string publisher)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Publisher = publisher;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionImageShowSettings.Publisher"/>.</em></p><p>Image publisher name.</p></summary>
        [Pure]
        public static AzureVmExtensionImageShowSettings ResetPublisher(this AzureVmExtensionImageShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Publisher = null;
            return toolSettings;
        }
        #endregion
        #region Version
        /// <summary><p><em>Sets <see cref="AzureVmExtensionImageShowSettings.Version"/>.</em></p><p>Extension version.</p></summary>
        [Pure]
        public static AzureVmExtensionImageShowSettings SetVersion(this AzureVmExtensionImageShowSettings toolSettings, string version)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = version;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionImageShowSettings.Version"/>.</em></p><p>Extension version.</p></summary>
        [Pure]
        public static AzureVmExtensionImageShowSettings ResetVersion(this AzureVmExtensionImageShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmExtensionImageShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmExtensionImageShowSettings SetDebug(this AzureVmExtensionImageShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionImageShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmExtensionImageShowSettings ResetDebug(this AzureVmExtensionImageShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmExtensionImageShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmExtensionImageShowSettings SetHelp(this AzureVmExtensionImageShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionImageShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmExtensionImageShowSettings ResetHelp(this AzureVmExtensionImageShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmExtensionImageShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmExtensionImageShowSettings SetOutput(this AzureVmExtensionImageShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionImageShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmExtensionImageShowSettings ResetOutput(this AzureVmExtensionImageShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmExtensionImageShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmExtensionImageShowSettings SetQuery(this AzureVmExtensionImageShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionImageShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmExtensionImageShowSettings ResetQuery(this AzureVmExtensionImageShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmExtensionImageShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmExtensionImageShowSettings SetVerbose(this AzureVmExtensionImageShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmExtensionImageShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmExtensionImageShowSettings ResetVerbose(this AzureVmExtensionImageShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region VmLicenseType
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class VmLicenseType : Enumeration
    {
        public static VmLicenseType none = new VmLicenseType { Value = "none" };
        public static VmLicenseType windows_client = new VmLicenseType { Value = "windows_client" };
        public static VmLicenseType windows_server = new VmLicenseType { Value = "windows_server" };
    }
    #endregion
    #region VmCreateZone
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class VmCreateZone : Enumeration
    {
        public static VmCreateZone _1 = new VmCreateZone { Value = "1" };
        public static VmCreateZone _2 = new VmCreateZone { Value = "2" };
        public static VmCreateZone _3 = new VmCreateZone { Value = "3" };
    }
    #endregion
    #region VmCreateAuthenticationType
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class VmCreateAuthenticationType : Enumeration
    {
        public static VmCreateAuthenticationType password = new VmCreateAuthenticationType { Value = "password" };
        public static VmCreateAuthenticationType ssh = new VmCreateAuthenticationType { Value = "ssh" };
    }
    #endregion
    #region VmCreateNsgRule
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class VmCreateNsgRule : Enumeration
    {
        public static VmCreateNsgRule rdp = new VmCreateNsgRule { Value = "rdp" };
        public static VmCreateNsgRule ssh = new VmCreateNsgRule { Value = "ssh" };
    }
    #endregion
    #region VmCreatePublicIpAddressAllocation
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class VmCreatePublicIpAddressAllocation : Enumeration
    {
        public static VmCreatePublicIpAddressAllocation dynamic = new VmCreatePublicIpAddressAllocation { Value = "dynamic" };
        public static VmCreatePublicIpAddressAllocation static_ = new VmCreatePublicIpAddressAllocation { Value = "static" };
    }
    #endregion
    #region VmCreatePublicIpSku
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class VmCreatePublicIpSku : Enumeration
    {
        public static VmCreatePublicIpSku basic = new VmCreatePublicIpSku { Value = "basic" };
        public static VmCreatePublicIpSku standard = new VmCreatePublicIpSku { Value = "standard" };
    }
    #endregion
    #region VmCreateOsDiskCaching
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class VmCreateOsDiskCaching : Enumeration
    {
        public static VmCreateOsDiskCaching none = new VmCreateOsDiskCaching { Value = "none" };
        public static VmCreateOsDiskCaching readonly_ = new VmCreateOsDiskCaching { Value = "readonly" };
        public static VmCreateOsDiskCaching readwrite = new VmCreateOsDiskCaching { Value = "readwrite" };
    }
    #endregion
    #region VmCreateOsType
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class VmCreateOsType : Enumeration
    {
        public static VmCreateOsType linux = new VmCreateOsType { Value = "linux" };
        public static VmCreateOsType windows = new VmCreateOsType { Value = "windows" };
    }
    #endregion
    #region VmCreateStorageSku
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class VmCreateStorageSku : Enumeration
    {
        public static VmCreateStorageSku premium_lrs = new VmCreateStorageSku { Value = "premium_lrs" };
        public static VmCreateStorageSku standardssd_lrs = new VmCreateStorageSku { Value = "standardssd_lrs" };
        public static VmCreateStorageSku standard_lrs = new VmCreateStorageSku { Value = "standard_lrs" };
    }
    #endregion
    #region VmEncryptionVolumeType
    /// <summary><p>Used within <see cref="AzureVmTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class VmEncryptionVolumeType : Enumeration
    {
        public static VmEncryptionVolumeType all = new VmEncryptionVolumeType { Value = "all" };
        public static VmEncryptionVolumeType data = new VmEncryptionVolumeType { Value = "data" };
        public static VmEncryptionVolumeType os = new VmEncryptionVolumeType { Value = "os" };
    }
    #endregion
}
