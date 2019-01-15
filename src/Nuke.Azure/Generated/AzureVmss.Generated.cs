// Copyright 2019 Maintainers of NUKE.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

// Generated with Nuke.CodeGeneration, Version: 0.7.0 [CommitSha: 9d3d3d7e].
// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/AzureVmss.json.

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
    public static partial class AzureVmssTasks
    {
        /// <summary><p>Path to the AzureVmss executable.</p></summary>
        public static string AzureVmssPath => ToolPathResolver.GetPathExecutable("az");
        /// <summary><p>Manage groupings of virtual machines in an Azure Virtual Machine Scale Set (VMSS).</p></summary>
        public static IReadOnlyCollection<Output> AzureVmss(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool logOutput = true, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzureVmssPath, arguments, workingDirectory, environmentVariables, timeout, logOutput, null, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage groupings of virtual machines in an Azure Virtual Machine Scale Set (VMSS).</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vmss?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmssCreate(Configure<AzureVmssCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmssCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage groupings of virtual machines in an Azure Virtual Machine Scale Set (VMSS).</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vmss?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmssDeallocate(Configure<AzureVmssDeallocateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmssDeallocateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage groupings of virtual machines in an Azure Virtual Machine Scale Set (VMSS).</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vmss?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmssDelete(Configure<AzureVmssDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmssDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage groupings of virtual machines in an Azure Virtual Machine Scale Set (VMSS).</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vmss?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmssDeleteInstances(Configure<AzureVmssDeleteInstancesSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmssDeleteInstancesSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage groupings of virtual machines in an Azure Virtual Machine Scale Set (VMSS).</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vmss?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmssGetInstanceView(Configure<AzureVmssGetInstanceViewSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmssGetInstanceViewSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage groupings of virtual machines in an Azure Virtual Machine Scale Set (VMSS).</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vmss?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmssGetOsUpgradeHistory(Configure<AzureVmssGetOsUpgradeHistorySettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmssGetOsUpgradeHistorySettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage groupings of virtual machines in an Azure Virtual Machine Scale Set (VMSS).</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vmss?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmssList(Configure<AzureVmssListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmssListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage groupings of virtual machines in an Azure Virtual Machine Scale Set (VMSS).</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vmss?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmssListInstanceConnectionInfo(Configure<AzureVmssListInstanceConnectionInfoSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmssListInstanceConnectionInfoSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage groupings of virtual machines in an Azure Virtual Machine Scale Set (VMSS).</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vmss?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmssListInstancePublicIps(Configure<AzureVmssListInstancePublicIpsSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmssListInstancePublicIpsSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage groupings of virtual machines in an Azure Virtual Machine Scale Set (VMSS).</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vmss?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmssListInstances(Configure<AzureVmssListInstancesSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmssListInstancesSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage groupings of virtual machines in an Azure Virtual Machine Scale Set (VMSS).</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vmss?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmssListSkus(Configure<AzureVmssListSkusSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmssListSkusSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage groupings of virtual machines in an Azure Virtual Machine Scale Set (VMSS).</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vmss?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmssPerformMaintenance(Configure<AzureVmssPerformMaintenanceSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmssPerformMaintenanceSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage groupings of virtual machines in an Azure Virtual Machine Scale Set (VMSS).</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vmss?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmssReimage(Configure<AzureVmssReimageSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmssReimageSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage groupings of virtual machines in an Azure Virtual Machine Scale Set (VMSS).</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vmss?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmssRestart(Configure<AzureVmssRestartSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmssRestartSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage groupings of virtual machines in an Azure Virtual Machine Scale Set (VMSS).</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vmss?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmssScale(Configure<AzureVmssScaleSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmssScaleSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage groupings of virtual machines in an Azure Virtual Machine Scale Set (VMSS).</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vmss?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmssShow(Configure<AzureVmssShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmssShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage groupings of virtual machines in an Azure Virtual Machine Scale Set (VMSS).</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vmss?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmssStart(Configure<AzureVmssStartSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmssStartSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage groupings of virtual machines in an Azure Virtual Machine Scale Set (VMSS).</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vmss?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmssStop(Configure<AzureVmssStopSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmssStopSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage groupings of virtual machines in an Azure Virtual Machine Scale Set (VMSS).</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vmss?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmssUpdate(Configure<AzureVmssUpdateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmssUpdateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage groupings of virtual machines in an Azure Virtual Machine Scale Set (VMSS).</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vmss?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmssUpdateInstances(Configure<AzureVmssUpdateInstancesSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmssUpdateInstancesSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage groupings of virtual machines in an Azure Virtual Machine Scale Set (VMSS).</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vmss?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmssWait(Configure<AzureVmssWaitSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmssWaitSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage groupings of virtual machines in an Azure Virtual Machine Scale Set (VMSS).</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vmss?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmssNicList(Configure<AzureVmssNicListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmssNicListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage groupings of virtual machines in an Azure Virtual Machine Scale Set (VMSS).</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vmss?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmssNicListVmNics(Configure<AzureVmssNicListVmNicsSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmssNicListVmNicsSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage groupings of virtual machines in an Azure Virtual Machine Scale Set (VMSS).</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vmss?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmssNicShow(Configure<AzureVmssNicShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmssNicShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage groupings of virtual machines in an Azure Virtual Machine Scale Set (VMSS).</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vmss?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmssEncryptionDisable(Configure<AzureVmssEncryptionDisableSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmssEncryptionDisableSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage groupings of virtual machines in an Azure Virtual Machine Scale Set (VMSS).</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vmss?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmssEncryptionEnable(Configure<AzureVmssEncryptionEnableSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmssEncryptionEnableSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage groupings of virtual machines in an Azure Virtual Machine Scale Set (VMSS).</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vmss?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmssEncryptionShow(Configure<AzureVmssEncryptionShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmssEncryptionShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage groupings of virtual machines in an Azure Virtual Machine Scale Set (VMSS).</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vmss?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmssRollingUpgradeCancel(Configure<AzureVmssRollingUpgradeCancelSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmssRollingUpgradeCancelSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage groupings of virtual machines in an Azure Virtual Machine Scale Set (VMSS).</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vmss?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmssRollingUpgradeGetLatest(Configure<AzureVmssRollingUpgradeGetLatestSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmssRollingUpgradeGetLatestSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage groupings of virtual machines in an Azure Virtual Machine Scale Set (VMSS).</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vmss?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmssRollingUpgradeStart(Configure<AzureVmssRollingUpgradeStartSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmssRollingUpgradeStartSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage groupings of virtual machines in an Azure Virtual Machine Scale Set (VMSS).</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vmss?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmssDiskAttach(Configure<AzureVmssDiskAttachSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmssDiskAttachSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage groupings of virtual machines in an Azure Virtual Machine Scale Set (VMSS).</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vmss?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmssDiskDetach(Configure<AzureVmssDiskDetachSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmssDiskDetachSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage groupings of virtual machines in an Azure Virtual Machine Scale Set (VMSS).</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vmss?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmssExtensionDelete(Configure<AzureVmssExtensionDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmssExtensionDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage groupings of virtual machines in an Azure Virtual Machine Scale Set (VMSS).</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vmss?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmssExtensionList(Configure<AzureVmssExtensionListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmssExtensionListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage groupings of virtual machines in an Azure Virtual Machine Scale Set (VMSS).</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vmss?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmssExtensionSet(Configure<AzureVmssExtensionSetSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmssExtensionSetSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage groupings of virtual machines in an Azure Virtual Machine Scale Set (VMSS).</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vmss?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmssExtensionShow(Configure<AzureVmssExtensionShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmssExtensionShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage groupings of virtual machines in an Azure Virtual Machine Scale Set (VMSS).</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vmss?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmssDiagnosticsGetDefaultConfig(Configure<AzureVmssDiagnosticsGetDefaultConfigSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmssDiagnosticsGetDefaultConfigSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage groupings of virtual machines in an Azure Virtual Machine Scale Set (VMSS).</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vmss?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmssDiagnosticsSet(Configure<AzureVmssDiagnosticsSetSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmssDiagnosticsSetSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage groupings of virtual machines in an Azure Virtual Machine Scale Set (VMSS).</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vmss?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmssIdentityAssign(Configure<AzureVmssIdentityAssignSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmssIdentityAssignSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage groupings of virtual machines in an Azure Virtual Machine Scale Set (VMSS).</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vmss?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmssIdentityRemove(Configure<AzureVmssIdentityRemoveSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmssIdentityRemoveSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage groupings of virtual machines in an Azure Virtual Machine Scale Set (VMSS).</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vmss?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmssIdentityShow(Configure<AzureVmssIdentityShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmssIdentityShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage groupings of virtual machines in an Azure Virtual Machine Scale Set (VMSS).</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vmss?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmssExtensionImageList(Configure<AzureVmssExtensionImageListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmssExtensionImageListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage groupings of virtual machines in an Azure Virtual Machine Scale Set (VMSS).</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vmss?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmssExtensionImageListNames(Configure<AzureVmssExtensionImageListNamesSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmssExtensionImageListNamesSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage groupings of virtual machines in an Azure Virtual Machine Scale Set (VMSS).</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vmss?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmssExtensionImageListVersions(Configure<AzureVmssExtensionImageListVersionsSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmssExtensionImageListVersionsSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage groupings of virtual machines in an Azure Virtual Machine Scale Set (VMSS).</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/vmss?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureVmssExtensionImageShow(Configure<AzureVmssExtensionImageShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureVmssExtensionImageShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
    }
    #region AzureVmssCreateSettings
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmssCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVmss executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmssTasks.AzureVmssPath;
        /// <summary><p>The name of the operating system image as a URN alias, URN, custom image name or ID, or VHD blob URI. Valid URN format: "Publisher:Offer:Sku:Version".</p></summary>
        public virtual string Image { get; internal set; }
        /// <summary><p>Name of the virtual machine scale set.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Custom init script file or text (cloud-init, cloud-config, etc..).</p></summary>
        public virtual string CustomData { get; internal set; }
        /// <summary><p>Overprovision option (see <a href="https://azure.microsoft.com/en-us/documentation/articles/virtual-machine-scale-sets-overview/">https://azure.microsoft.com/en-us/documentation/articles/virtual-machine-scale-sets-overview/</a> for details).</p></summary>
        public virtual string DisableOverprovision { get; internal set; }
        /// <summary><p>(PREVIEW) The eviction policy for virtual machines in a low priority scale set.</p></summary>
        public virtual VmssCreateEvictionPolicy EvictionPolicy { get; internal set; }
        /// <summary><p>(Preview) probe name from the existing load balancer, mainly used for rolling upgrade.</p></summary>
        public virtual string HealthProbe { get; internal set; }
        /// <summary><p>Number of VMs in the scale set.</p></summary>
        public virtual int? InstanceCount { get; internal set; }
        /// <summary><p>License type if the Windows image or disk used was licensed on-premises.</p></summary>
        public virtual VmssLicenseType LicenseType { get; internal set; }
        /// <summary><p>Location in which to create VM and related resources. If default location is not configured, will default to the resource group's location.</p></summary>
        public virtual string Location { get; internal set; }
        /// <summary><p>Do not wait for the long-running operation to finish.</p></summary>
        public virtual bool? NoWait { get; internal set; }
        /// <summary><p>Fault Domain count for each placement group in the availability zone.</p></summary>
        public virtual string PlatformFaultDomainCount { get; internal set; }
        /// <summary><p>Priority. Use 'Low' to run short-lived workloads in a cost-effective way.</p></summary>
        public virtual VmssCreatePriority Priority { get; internal set; }
        /// <summary><p>One or many Key Vault secrets as JSON strings or files via `@{path}` containing `[{ "sourceVault": { "id": "value" }, "vaultCertificates": [{ "certificateUrl": "value", "certificateStore": "cert store name (only on windows)"}] }]`.</p></summary>
        public virtual string Secrets { get; internal set; }
        /// <summary><p>Enable replicate using fault domains within the same cluster. Default to 'false' for any zonals, or with 100+ instances See <a href="https://docs.microsoft.com/en-us/azure/virtual-machine-scale-sets/virtual-machine-scale-sets-placement-groups">https://docs.microsoft.com/en-us/azure/virtual-machine-scale-sets/virtual-machine-scale-sets-placement-groups</a> for details.</p></summary>
        public virtual bool? SinglePlacementGroup { get; internal set; }
        /// <summary><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        public virtual string Tags { get; internal set; }
        /// <summary><p></p></summary>
        public virtual VmssCreateUpgradePolicyMode UpgradePolicyMode { get; internal set; }
        /// <summary><p>Generate and validate the ARM template without creating any resources.</p></summary>
        public virtual string Validate { get; internal set; }
        /// <summary><p>Size of VMs in the scale set. Default to "Standard_DS1_v2". See <a href="https://azure.microsoft.com/en-us/pricing/details/virtual-machines/">https://azure.microsoft.com/en-us/pricing/details/virtual-machines/</a> for size info.</p></summary>
        public virtual string VmSku { get; internal set; }
        /// <summary><p>Space-separated list of availability zones into which to provision the resource.</p></summary>
        public virtual IReadOnlyList<VmssCreateZones> Zones => ZonesInternal.AsReadOnly();
        internal List<VmssCreateZones> ZonesInternal { get; set; } = new List<VmssCreateZones>();
        /// <summary><p>Password for the VM if authentication type is 'Password'.</p></summary>
        public virtual string AdminPassword { get; internal set; }
        /// <summary><p>Username for the VM.</p></summary>
        public virtual string AdminUsername { get; internal set; }
        /// <summary><p>Type of authentication to use with the VM. Defaults to password for Windows and SSH public key for Linux. "all" enables both ssh and password authentication.</p></summary>
        public virtual VmssCreateAuthenticationType AuthenticationType { get; internal set; }
        /// <summary><p>Generate SSH public and private key files if missing. The keys will be stored in the ~/.ssh directory.</p></summary>
        public virtual string GenerateSshKeys { get; internal set; }
        /// <summary><p>Destination file path on the VM for the SSH key.</p></summary>
        public virtual string SshDestKeyPath { get; internal set; }
        /// <summary><p>SSH public key or public key file path.</p></summary>
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
        /// <summary><p>Space-separated IP addresses of DNS servers, e.g. 10.0.0.5 10.0.0.6.</p></summary>
        public virtual IReadOnlyList<string> DnsServers => DnsServersInternal.AsReadOnly();
        internal List<string> DnsServersInternal { get; set; } = new List<string>();
        /// <summary><p>Name or ID of an existing Network Security Group.</p></summary>
        public virtual string Nsg { get; internal set; }
        /// <summary><p>Name of the public IP address when creating one (default) or referencing an existing one. Can also reference an existing public IP by ID or specify "" for None.</p></summary>
        public virtual string PublicIpAddress { get; internal set; }
        /// <summary><p></p></summary>
        public virtual VmssCreatePublicIpAddressAllocation PublicIpAddressAllocation { get; internal set; }
        /// <summary><p>Globally unique DNS name for a newly created public IP.</p></summary>
        public virtual string PublicIpAddressDnsName { get; internal set; }
        /// <summary><p>Each VM instance will have a public ip. For security, you can use '--nsg' to apply appropriate rules.</p></summary>
        public virtual string PublicIpPerVm { get; internal set; }
        /// <summary><p>The name of the subnet when creating a new VNet or referencing an existing one. Can also reference an existing subnet by ID. If omitted, an appropriate VNet and subnet will be selected automatically, or a new one will be created.</p></summary>
        public virtual string Subnet { get; internal set; }
        /// <summary><p>The subnet IP address prefix to use when creating a new VNet in CIDR format.</p></summary>
        public virtual string SubnetAddressPrefix { get; internal set; }
        /// <summary><p>Domain name of VM instances, once configured, the FQDN is 'vm&lt;vm-index&gt;.&lt;vm-domain-name&gt;.&lt;..rest..&gt;'.</p></summary>
        public virtual string VmDomainName { get; internal set; }
        /// <summary><p>The IP address prefix to use when creating a new VNet in CIDR format.</p></summary>
        public virtual string VnetAddressPrefix { get; internal set; }
        /// <summary><p>Name of the virtual network when creating a new one or referencing an existing one.</p></summary>
        public virtual string VnetName { get; internal set; }
        /// <summary><p>Name to use when creating a new application gateway (default) or referencing an existing one. Can also reference an existing application gateway by ID or specify "" for none.</p></summary>
        public virtual string AppGateway { get; internal set; }
        /// <summary><p>The number of instances to use when creating a new application gateway.</p></summary>
        public virtual string AppGatewayCapacity { get; internal set; }
        /// <summary><p>SKU when creating a new application gateway.</p></summary>
        public virtual string AppGatewaySku { get; internal set; }
        /// <summary><p>The subnet IP address prefix to use when creating a new application gateway in CIDR format.</p></summary>
        public virtual string AppGatewaySubnetAddressPrefix { get; internal set; }
        /// <summary><p>Name to use for the backend pool when creating a new load balancer or application gateway.</p></summary>
        public virtual string BackendPoolName { get; internal set; }
        /// <summary><p>When creating a new load balancer, backend port to open with NAT rules (Defaults to 22 on Linux and 3389 on Windows). When creating an application gateway, the backend port to use for the backend HTTP settings.</p></summary>
        public virtual string BackendPort { get; internal set; }
        /// <summary><p>Name to use when creating a new load balancer (default) or referencing an existing one. Can also reference an existing load balancer by ID or specify "" for none.</p></summary>
        public virtual string Lb { get; internal set; }
        /// <summary><p>Name to use for the NAT pool when creating a new load balancer.</p></summary>
        public virtual string LbNatPoolName { get; internal set; }
        /// <summary><p>Sku of the Load Balancer to create. Default to 'Standard' when single placement group is turned off; otherwise, default to 'Basic'.</p></summary>
        public virtual VmssCreateLbSku LbSku { get; internal set; }
        /// <summary><p>Storage caching type for data disk(s), including 'None', 'ReadOnly', 'ReadWrite', etc. Use a singular value to apply on all disks, or use '&lt;lun&gt;=&lt;vaule1&gt; &lt;lun&gt;=&lt;value2&gt;' to configure individual disk.</p></summary>
        public virtual string DataDiskCaching { get; internal set; }
        /// <summary><p>Space-separated empty managed data disk sizes in GB to create.</p></summary>
        public virtual IReadOnlyList<string> DataDiskSizesGb => DataDiskSizesGbInternal.AsReadOnly();
        internal List<string> DataDiskSizesGbInternal { get; set; } = new List<string>();
        /// <summary><p>(Preview) Allows you to create an OS disk directly on the host node, providing local disk performance and faster VM/VMSS reimage time.</p></summary>
        public virtual bool? EphemeralOsDisk { get; internal set; }
        /// <summary><p>Storage caching type for the VM OS disk. Default: ReadWrite.</p></summary>
        public virtual VmssCreateOsDiskCaching OsDiskCaching { get; internal set; }
        /// <summary><p>The name of the new VM OS disk.</p></summary>
        public virtual string OsDiskName { get; internal set; }
        /// <summary><p>Type of OS installed on a custom VHD. Do not use when specifying an URN or URN alias.</p></summary>
        public virtual VmssCreateOsType OsType { get; internal set; }
        /// <summary><p>Only applicable when used with `--use-unmanaged-disk`. Name of the storage container for the VM OS disk. Default: vhds.</p></summary>
        public virtual string StorageContainerName { get; internal set; }
        /// <summary><p>The SKU of the storage account with which to persist VM. Use a singular sku that would be applied across all disks, or specify individual disks. Usage: [--storage-sku SKU | --storage-sku ID=SKU ID=SKU ID=SKU...], where each ID is "os" or a 0-indexed lun. Allowed values: Standard_LRS, Premium_LRS, StandardSSD_LRS, UltraSSD_LRS.</p></summary>
        public virtual IReadOnlyList<string> StorageSku => StorageSkuInternal.AsReadOnly();
        internal List<string> StorageSkuInternal { get; set; } = new List<string>();
        /// <summary><p>(PREVIEW) Enables or disables the capability to have 1 or more managed data disks with UltraSSD_LRS storage account.</p></summary>
        public virtual bool? UltraSsdEnabled { get; internal set; }
        /// <summary><p>Do not use managed disk to persist VM.</p></summary>
        public virtual string UseUnmanagedDisk { get; internal set; }
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
              .Add("vmss create")
              .Add("--image {value}", Image)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--custom-data {value}", CustomData)
              .Add("--disable-overprovision {value}", DisableOverprovision)
              .Add("--eviction-policy {value}", EvictionPolicy)
              .Add("--health-probe {value}", HealthProbe)
              .Add("--instance-count {value}", InstanceCount)
              .Add("--license-type {value}", LicenseType)
              .Add("--location {value}", Location)
              .Add("--no-wait", NoWait)
              .Add("--platform-fault-domain-count {value}", PlatformFaultDomainCount)
              .Add("--priority {value}", Priority)
              .Add("--secrets {value}", Secrets, secret: true)
              .Add("--single-placement-group", SinglePlacementGroup)
              .Add("--tags {value}", Tags)
              .Add("--upgrade-policy-mode {value}", UpgradePolicyMode)
              .Add("--validate {value}", Validate)
              .Add("--vm-sku {value}", VmSku)
              .Add("--zones {value}", Zones, separator: ' ')
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
              .Add("--dns-servers {value}", DnsServers, separator: ' ')
              .Add("--nsg {value}", Nsg)
              .Add("--public-ip-address {value}", PublicIpAddress)
              .Add("--public-ip-address-allocation {value}", PublicIpAddressAllocation)
              .Add("--public-ip-address-dns-name {value}", PublicIpAddressDnsName)
              .Add("--public-ip-per-vm {value}", PublicIpPerVm)
              .Add("--subnet {value}", Subnet)
              .Add("--subnet-address-prefix {value}", SubnetAddressPrefix)
              .Add("--vm-domain-name {value}", VmDomainName)
              .Add("--vnet-address-prefix {value}", VnetAddressPrefix)
              .Add("--vnet-name {value}", VnetName)
              .Add("--app-gateway {value}", AppGateway)
              .Add("--app-gateway-capacity {value}", AppGatewayCapacity)
              .Add("--app-gateway-sku {value}", AppGatewaySku)
              .Add("--app-gateway-subnet-address-prefix {value}", AppGatewaySubnetAddressPrefix)
              .Add("--backend-pool-name {value}", BackendPoolName)
              .Add("--backend-port {value}", BackendPort)
              .Add("--lb {value}", Lb)
              .Add("--lb-nat-pool-name {value}", LbNatPoolName)
              .Add("--lb-sku {value}", LbSku)
              .Add("--data-disk-caching {value}", DataDiskCaching)
              .Add("--data-disk-sizes-gb {value}", DataDiskSizesGb, separator: ' ')
              .Add("--ephemeral-os-disk", EphemeralOsDisk)
              .Add("--os-disk-caching {value}", OsDiskCaching)
              .Add("--os-disk-name {value}", OsDiskName)
              .Add("--os-type {value}", OsType)
              .Add("--storage-container-name {value}", StorageContainerName)
              .Add("--storage-sku {value}", StorageSku, separator: ' ')
              .Add("--ultra-ssd-enabled", UltraSsdEnabled)
              .Add("--use-unmanaged-disk {value}", UseUnmanagedDisk)
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
    #region AzureVmssDeallocateSettings
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmssDeallocateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVmss executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmssTasks.AzureVmssPath;
        /// <summary><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Space-separated list of IDs (ex: 1 2 3 ...) or * for all instances. If not provided, the action will be applied on the scaleset itself.</p></summary>
        public virtual IReadOnlyList<string> InstanceIds => InstanceIdsInternal.AsReadOnly();
        internal List<string> InstanceIdsInternal { get; set; } = new List<string>();
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
              .Add("vmss deallocate")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--instance-ids {value}", InstanceIds, separator: ' ')
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
    #region AzureVmssDeleteSettings
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmssDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVmss executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmssTasks.AzureVmssPath;
        /// <summary><p>Do not wait for the long-running operation to finish.</p></summary>
        public virtual bool? NoWait { get; internal set; }
        /// <summary><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
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
              .Add("vmss delete")
              .Add("--no-wait", NoWait)
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
    #region AzureVmssDeleteInstancesSettings
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmssDeleteInstancesSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVmss executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmssTasks.AzureVmssPath;
        /// <summary><p>Space-separated list of IDs (ex: 1 2 3 ...) or * for all instances.</p></summary>
        public virtual IReadOnlyList<string> InstanceIds => InstanceIdsInternal.AsReadOnly();
        internal List<string> InstanceIdsInternal { get; set; } = new List<string>();
        /// <summary><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string Name { get; internal set; }
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
              .Add("vmss delete-instances")
              .Add("--instance-ids {value}", InstanceIds, separator: ' ')
              .Add("--name {value}", Name)
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
    #region AzureVmssGetInstanceViewSettings
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmssGetInstanceViewSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVmss executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmssTasks.AzureVmssPath;
        /// <summary><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary><p>A VM instance ID or "*" to list instance view for all VMs in a scale set.</p></summary>
        public virtual string InstanceId { get; internal set; }
        /// <summary><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
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
              .Add("vmss get-instance-view")
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--instance-id {value}", InstanceId)
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
    #region AzureVmssGetOsUpgradeHistorySettings
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmssGetOsUpgradeHistorySettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVmss executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmssTasks.AzureVmssPath;
        /// <summary><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
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
              .Add("vmss get-os-upgrade-history")
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
    #region AzureVmssListSettings
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmssListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVmss executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmssTasks.AzureVmssPath;
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
              .Add("vmss list")
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
    #region AzureVmssListInstanceConnectionInfoSettings
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmssListInstanceConnectionInfoSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVmss executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmssTasks.AzureVmssPath;
        /// <summary><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
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
              .Add("vmss list-instance-connection-info")
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
    #region AzureVmssListInstancePublicIpsSettings
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmssListInstancePublicIpsSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVmss executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmssTasks.AzureVmssPath;
        /// <summary><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
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
              .Add("vmss list-instance-public-ips")
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
    #region AzureVmssListInstancesSettings
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmssListInstancesSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVmss executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmssTasks.AzureVmssPath;
        /// <summary><p>The expand expression to apply to the operation.</p></summary>
        public virtual string Expand { get; internal set; }
        /// <summary><p>The filter to apply to the operation.</p></summary>
        public virtual string Filter { get; internal set; }
        /// <summary><p>The list parameters.</p></summary>
        public virtual string Select { get; internal set; }
        /// <summary><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
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
              .Add("vmss list-instances")
              .Add("--expand {value}", Expand)
              .Add("--filter {value}", Filter)
              .Add("--select {value}", Select)
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
    #region AzureVmssListSkusSettings
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmssListSkusSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVmss executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmssTasks.AzureVmssPath;
        /// <summary><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
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
              .Add("vmss list-skus")
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
    #region AzureVmssPerformMaintenanceSettings
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmssPerformMaintenanceSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVmss executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmssTasks.AzureVmssPath;
        /// <summary><p>Space-separated list of IDs (ex: 1 2 3 ...) or * for all instances. If not provided, the action will be applied on the scaleset itself.</p></summary>
        public virtual IReadOnlyList<string> InstanceIds => InstanceIdsInternal.AsReadOnly();
        internal List<string> InstanceIdsInternal { get; set; } = new List<string>();
        /// <summary><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
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
              .Add("vmss perform-maintenance")
              .Add("--instance-ids {value}", InstanceIds, separator: ' ')
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
    #region AzureVmssReimageSettings
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmssReimageSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVmss executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmssTasks.AzureVmssPath;
        /// <summary><p>Do not wait for the long-running operation to finish.</p></summary>
        public virtual bool? NoWait { get; internal set; }
        /// <summary><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary><p>VM instance ID. If missing, reimage all instances.</p></summary>
        public virtual string InstanceId { get; internal set; }
        /// <summary><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
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
              .Add("vmss reimage")
              .Add("--no-wait", NoWait)
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--instance-id {value}", InstanceId)
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
    #region AzureVmssRestartSettings
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmssRestartSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVmss executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmssTasks.AzureVmssPath;
        /// <summary><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Space-separated list of IDs (ex: 1 2 3 ...) or * for all instances. If not provided, the action will be applied on the scaleset itself.</p></summary>
        public virtual IReadOnlyList<string> InstanceIds => InstanceIdsInternal.AsReadOnly();
        internal List<string> InstanceIdsInternal { get; set; } = new List<string>();
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
              .Add("vmss restart")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--instance-ids {value}", InstanceIds, separator: ' ')
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
    #region AzureVmssScaleSettings
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmssScaleSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVmss executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmssTasks.AzureVmssPath;
        /// <summary><p>Number of VMs in the VMSS.</p></summary>
        public virtual int? NewCapacity { get; internal set; }
        /// <summary><p>Do not wait for the long-running operation to finish.</p></summary>
        public virtual bool? NoWait { get; internal set; }
        /// <summary><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
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
              .Add("vmss scale")
              .Add("--new-capacity {value}", NewCapacity)
              .Add("--no-wait", NoWait)
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
    #region AzureVmssShowSettings
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmssShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVmss executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmssTasks.AzureVmssPath;
        /// <summary><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>VM instance ID. If missing, show the VMSS.</p></summary>
        public virtual string InstanceId { get; internal set; }
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
              .Add("vmss show")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--instance-id {value}", InstanceId)
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
    #region AzureVmssStartSettings
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmssStartSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVmss executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmssTasks.AzureVmssPath;
        /// <summary><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Space-separated list of IDs (ex: 1 2 3 ...) or * for all instances. If not provided, the action will be applied on the scaleset itself.</p></summary>
        public virtual IReadOnlyList<string> InstanceIds => InstanceIdsInternal.AsReadOnly();
        internal List<string> InstanceIdsInternal { get; set; } = new List<string>();
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
              .Add("vmss start")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--instance-ids {value}", InstanceIds, separator: ' ')
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
    #region AzureVmssStopSettings
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmssStopSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVmss executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmssTasks.AzureVmssPath;
        /// <summary><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Space-separated list of IDs (ex: 1 2 3 ...) or * for all instances. If not provided, the action will be applied on the scaleset itself.</p></summary>
        public virtual IReadOnlyList<string> InstanceIds => InstanceIdsInternal.AsReadOnly();
        internal List<string> InstanceIdsInternal { get; set; } = new List<string>();
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
              .Add("vmss stop")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--instance-ids {value}", InstanceIds, separator: ' ')
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
    #region AzureVmssUpdateSettings
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmssUpdateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVmss executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmssTasks.AzureVmssPath;
        /// <summary><p>License type if the Windows image or disk used was licensed on-premises.</p></summary>
        public virtual VmssLicenseType LicenseType { get; internal set; }
        /// <summary><p>Do not wait for the long-running operation to finish.</p></summary>
        public virtual bool? NoWait { get; internal set; }
        /// <summary><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
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
              .Add("vmss update")
              .Add("--license-type {value}", LicenseType)
              .Add("--no-wait", NoWait)
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
    #region AzureVmssUpdateInstancesSettings
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmssUpdateInstancesSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVmss executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmssTasks.AzureVmssPath;
        /// <summary><p>Space-separated list of IDs (ex: 1 2 3 ...) or * for all instances.</p></summary>
        public virtual IReadOnlyList<string> InstanceIds => InstanceIdsInternal.AsReadOnly();
        internal List<string> InstanceIdsInternal { get; set; } = new List<string>();
        /// <summary><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string Name { get; internal set; }
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
              .Add("vmss update-instances")
              .Add("--instance-ids {value}", InstanceIds, separator: ' ')
              .Add("--name {value}", Name)
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
    #region AzureVmssWaitSettings
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmssWaitSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVmss executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmssTasks.AzureVmssPath;
        /// <summary><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        public virtual string Subscription { get; internal set; }
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
              .Add("vmss wait")
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--subscription {value}", Subscription)
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
    #region AzureVmssNicListSettings
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmssNicListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVmss executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmssTasks.AzureVmssPath;
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string VmssName { get; internal set; }
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
              .Add("vmss nic list")
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--vmss-name {value}", VmssName)
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
    #region AzureVmssNicListVmNicsSettings
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmssNicListVmNicsSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVmss executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmssTasks.AzureVmssPath;
        /// <summary><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary><p>The virtual machine index.</p></summary>
        public virtual string InstanceId { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        public virtual string Subscription { get; internal set; }
        /// <summary><p>Scale set name.</p></summary>
        public virtual string VmssName { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("vmss nic list-vm-nics")
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--instance-id {value}", InstanceId)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--subscription {value}", Subscription)
              .Add("--vmss-name {value}", VmssName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureVmssNicShowSettings
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmssNicShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVmss executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmssTasks.AzureVmssPath;
        /// <summary><p>Expands referenced resources.</p></summary>
        public virtual string Expand { get; internal set; }
        /// <summary><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary><p>The virtual machine index.</p></summary>
        public virtual string InstanceId { get; internal set; }
        /// <summary><p>The network interface (NIC).</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        public virtual string Subscription { get; internal set; }
        /// <summary><p>Scale set name.</p></summary>
        public virtual string VmssName { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("vmss nic show")
              .Add("--expand {value}", Expand)
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--instance-id {value}", InstanceId)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--subscription {value}", Subscription)
              .Add("--vmss-name {value}", VmssName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureVmssEncryptionDisableSettings
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmssEncryptionDisableSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVmss executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmssTasks.AzureVmssPath;
        /// <summary><p>Continue by ignoring client side validation errors.</p></summary>
        public virtual string Force { get; internal set; }
        /// <summary><p>Type of volume that the encryption operation is performed on.</p></summary>
        public virtual VmssEncryptionVolumeType VolumeType { get; internal set; }
        /// <summary><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
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
              .Add("vmss encryption disable")
              .Add("--force {value}", Force)
              .Add("--volume-type {value}", VolumeType)
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
    #region AzureVmssEncryptionEnableSettings
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmssEncryptionEnableSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVmss executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmssTasks.AzureVmssPath;
        /// <summary><p>The key vault where the generated encryption key will be placed.</p></summary>
        public virtual string DiskEncryptionKeyvault { get; internal set; }
        /// <summary><p>Continue by ignoring client side validation errors.</p></summary>
        public virtual string Force { get; internal set; }
        /// <summary><p></p></summary>
        public virtual string KeyEncryptionAlgorithm { get; internal set; }
        /// <summary><p>Key vault key name or URL used to encrypt the disk encryption key.</p></summary>
        public virtual string KeyEncryptionKey { get; internal set; }
        /// <summary><p>The key vault containing the key encryption key used to encrypt the disk encryption key. If missing, CLI will use `--disk-encryption-keyvault`.</p></summary>
        public virtual string KeyEncryptionKeyvault { get; internal set; }
        /// <summary><p>Type of volume that the encryption operation is performed on.</p></summary>
        public virtual VmssEncryptionVolumeType VolumeType { get; internal set; }
        /// <summary><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
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
              .Add("vmss encryption enable")
              .Add("--disk-encryption-keyvault {value}", DiskEncryptionKeyvault)
              .Add("--force {value}", Force)
              .Add("--key-encryption-algorithm {value}", KeyEncryptionAlgorithm)
              .Add("--key-encryption-key {value}", KeyEncryptionKey)
              .Add("--key-encryption-keyvault {value}", KeyEncryptionKeyvault)
              .Add("--volume-type {value}", VolumeType)
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
    #region AzureVmssEncryptionShowSettings
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmssEncryptionShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVmss executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmssTasks.AzureVmssPath;
        /// <summary><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
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
              .Add("vmss encryption show")
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
    #region AzureVmssRollingUpgradeCancelSettings
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmssRollingUpgradeCancelSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVmss executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmssTasks.AzureVmssPath;
        /// <summary><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
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
              .Add("vmss rolling-upgrade cancel")
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
    #region AzureVmssRollingUpgradeGetLatestSettings
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmssRollingUpgradeGetLatestSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVmss executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmssTasks.AzureVmssPath;
        /// <summary><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
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
              .Add("vmss rolling-upgrade get-latest")
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
    #region AzureVmssRollingUpgradeStartSettings
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmssRollingUpgradeStartSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVmss executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmssTasks.AzureVmssPath;
        /// <summary><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
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
              .Add("vmss rolling-upgrade start")
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
    #region AzureVmssDiskAttachSettings
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmssDiskAttachSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVmss executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmssTasks.AzureVmssPath;
        /// <summary><p>Disk caching policy.</p></summary>
        public virtual VmssCreateOsDiskCaching Caching { get; internal set; }
        /// <summary><p>Existing disk name or ID to attach or detach from VM instances.</p></summary>
        public virtual string Disk { get; internal set; }
        /// <summary><p>0-based logical unit number (LUN). Max value depends on the Virtual Machine instance size.</p></summary>
        public virtual string Lun { get; internal set; }
        /// <summary><p>Size in GB.</p></summary>
        public virtual string SizeGb { get; internal set; }
        /// <summary><p>Underlying storage SKU.</p></summary>
        public virtual VmssDiskAttachSku Sku { get; internal set; }
        /// <summary><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary><p>Scale set VM instance id.</p></summary>
        public virtual string InstanceId { get; internal set; }
        /// <summary><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
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
              .Add("vmss disk attach")
              .Add("--caching {value}", Caching)
              .Add("--disk {value}", Disk)
              .Add("--lun {value}", Lun)
              .Add("--size-gb {value}", SizeGb)
              .Add("--sku {value}", Sku)
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--instance-id {value}", InstanceId)
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
    #region AzureVmssDiskDetachSettings
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmssDiskDetachSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVmss executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmssTasks.AzureVmssPath;
        /// <summary><p>0-based logical unit number (LUN). Max value depends on the Virtual Machine instance size.</p></summary>
        public virtual string Lun { get; internal set; }
        /// <summary><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary><p>Scale set VM instance id.</p></summary>
        public virtual string InstanceId { get; internal set; }
        /// <summary><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
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
              .Add("vmss disk detach")
              .Add("--lun {value}", Lun)
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--instance-id {value}", InstanceId)
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
    #region AzureVmssExtensionDeleteSettings
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmssExtensionDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVmss executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmssTasks.AzureVmssPath;
        /// <summary><p>Name of the extension.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string VmssName { get; internal set; }
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
              .Add("vmss extension delete")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--vmss-name {value}", VmssName)
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
    #region AzureVmssExtensionListSettings
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmssExtensionListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVmss executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmssTasks.AzureVmssPath;
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string VmssName { get; internal set; }
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
              .Add("vmss extension list")
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--vmss-name {value}", VmssName)
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
    #region AzureVmssExtensionSetSettings
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmssExtensionSetSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVmss executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmssTasks.AzureVmssPath;
        /// <summary><p>Name of the extension.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>The name of the extension publisher.</p></summary>
        public virtual string Publisher { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string VmssName { get; internal set; }
        /// <summary><p>Name of the vm's instance of the extension. Default: name of the extension.</p></summary>
        public virtual string ExtensionInstanceName { get; internal set; }
        /// <summary><p>Force to update even if the extension configuration has not changed.</p></summary>
        public virtual string ForceUpdate { get; internal set; }
        /// <summary><p>By doing this, extension system will not pick the highest minor version for the specified version number, and will not auto update to the latest build/revision number on any scale set updates in future.</p></summary>
        public virtual bool? NoAutoUpgrade { get; internal set; }
        /// <summary><p>Do not wait for the long-running operation to finish.</p></summary>
        public virtual bool? NoWait { get; internal set; }
        /// <summary><p>Protected settings in JSON format for sensitive information like credentials. A JSON file path is also accepted.</p></summary>
        public virtual string ProtectedSettings { get; internal set; }
        /// <summary><p>Extension settings in JSON format. A JSON file path is also accepted.</p></summary>
        public virtual string Settings { get; internal set; }
        /// <summary><p>The version of the extension.</p></summary>
        public virtual string Version { get; internal set; }
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
              .Add("vmss extension set")
              .Add("--name {value}", Name)
              .Add("--publisher {value}", Publisher)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--vmss-name {value}", VmssName)
              .Add("--extension-instance-name {value}", ExtensionInstanceName)
              .Add("--force-update {value}", ForceUpdate)
              .Add("--no-auto-upgrade", NoAutoUpgrade)
              .Add("--no-wait", NoWait)
              .Add("--protected-settings {value}", ProtectedSettings)
              .Add("--settings {value}", Settings)
              .Add("--version {value}", Version)
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
    #region AzureVmssExtensionShowSettings
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmssExtensionShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVmss executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmssTasks.AzureVmssPath;
        /// <summary><p>Name of the extension.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string VmssName { get; internal set; }
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
              .Add("vmss extension show")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--vmss-name {value}", VmssName)
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
    #region AzureVmssDiagnosticsGetDefaultConfigSettings
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmssDiagnosticsGetDefaultConfigSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVmss executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmssTasks.AzureVmssPath;
        /// <summary><p>For Windows VMs.</p></summary>
        public virtual string IsWindowsOs { get; internal set; }
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
              .Add("vmss diagnostics get-default-config")
              .Add("--is-windows-os {value}", IsWindowsOs)
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
    #region AzureVmssDiagnosticsSetSettings
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmssDiagnosticsSetSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVmss executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmssTasks.AzureVmssPath;
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Json string or a file path, which defines data to be collected.</p></summary>
        public virtual string Settings { get; internal set; }
        /// <summary><p>Scale set name.</p></summary>
        public virtual string VmssName { get; internal set; }
        /// <summary><p>By doing this, extension system will not pick the highest minor version for the specified version number, and will not auto update to the latest build/revision number on any scale set updates in future.</p></summary>
        public virtual bool? NoAutoUpgrade { get; internal set; }
        /// <summary><p>Json string or a file path containing private configurations such as storage account keys, etc.</p></summary>
        public virtual string ProtectedSettings { get; internal set; }
        /// <summary><p>Version of the diagnostics extension. Will use the latest if not specfied.</p></summary>
        public virtual string Version { get; internal set; }
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
              .Add("vmss diagnostics set")
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--settings {value}", Settings)
              .Add("--vmss-name {value}", VmssName)
              .Add("--no-auto-upgrade", NoAutoUpgrade)
              .Add("--protected-settings {value}", ProtectedSettings)
              .Add("--version {value}", Version)
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
    #region AzureVmssIdentityAssignSettings
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmssIdentityAssignSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVmss executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmssTasks.AzureVmssPath;
        /// <summary><p>Space-separated identities to assign. Use '[system]' to refer to the system assigned identity. Default: '[system]'.</p></summary>
        public virtual IReadOnlyList<string> Identities => IdentitiesInternal.AsReadOnly();
        internal List<string> IdentitiesInternal { get; set; } = new List<string>();
        /// <summary><p>Role name or id the system assigned identity will have.</p></summary>
        public virtual string Role { get; internal set; }
        /// <summary><p>Scope that the system assigned identity can access.</p></summary>
        public virtual string Scope { get; internal set; }
        /// <summary><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
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
              .Add("vmss identity assign")
              .Add("--identities {value}", Identities, separator: ' ')
              .Add("--role {value}", Role)
              .Add("--scope {value}", Scope)
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
    #region AzureVmssIdentityRemoveSettings
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmssIdentityRemoveSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVmss executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmssTasks.AzureVmssPath;
        /// <summary><p>Space-separated identities to remove. Use '[system]' to refer to the system assigned identity. Default: '[system]'.</p></summary>
        public virtual IReadOnlyList<string> Identities => IdentitiesInternal.AsReadOnly();
        internal List<string> IdentitiesInternal { get; set; } = new List<string>();
        /// <summary><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
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
              .Add("vmss identity remove")
              .Add("--identities {value}", Identities, separator: ' ')
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
    #region AzureVmssIdentityShowSettings
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmssIdentityShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVmss executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmssTasks.AzureVmssPath;
        /// <summary><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
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
              .Add("vmss identity show")
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
    #region AzureVmssExtensionImageListSettings
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmssExtensionImageListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVmss executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmssTasks.AzureVmssPath;
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
              .Add("vmss extension image list")
              .Add("--latest", Latest)
              .Add("--location {value}", Location)
              .Add("--name {value}", Name)
              .Add("--publisher {value}", Publisher)
              .Add("--version {value}", Version)
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
    #region AzureVmssExtensionImageListNamesSettings
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmssExtensionImageListNamesSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVmss executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmssTasks.AzureVmssPath;
        /// <summary><p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        public virtual string Location { get; internal set; }
        /// <summary><p>Image publisher name.</p></summary>
        public virtual string Publisher { get; internal set; }
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
              .Add("vmss extension image list-names")
              .Add("--location {value}", Location)
              .Add("--publisher {value}", Publisher)
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
    #region AzureVmssExtensionImageListVersionsSettings
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmssExtensionImageListVersionsSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVmss executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmssTasks.AzureVmssPath;
        /// <summary><p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
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
              .Add("vmss extension image list-versions")
              .Add("--location {value}", Location)
              .Add("--name {value}", Name)
              .Add("--publisher {value}", Publisher)
              .Add("--filter {value}", Filter)
              .Add("--orderby {value}", Orderby)
              .Add("--top {value}", Top)
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
    #region AzureVmssExtensionImageShowSettings
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureVmssExtensionImageShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureVmss executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureVmssTasks.AzureVmssPath;
        /// <summary><p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        public virtual string Location { get; internal set; }
        /// <summary><p>Name of the extension.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Image publisher name.</p></summary>
        public virtual string Publisher { get; internal set; }
        /// <summary><p>Extension version.</p></summary>
        public virtual string Version { get; internal set; }
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
              .Add("vmss extension image show")
              .Add("--location {value}", Location)
              .Add("--name {value}", Name)
              .Add("--publisher {value}", Publisher)
              .Add("--version {value}", Version)
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
    #region AzureVmssCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmssCreateSettingsExtensions
    {
        #region Image
        /// <summary><p><em>Sets <see cref="AzureVmssCreateSettings.Image"/>.</em></p><p>The name of the operating system image as a URN alias, URN, custom image name or ID, or VHD blob URI. Valid URN format: "Publisher:Offer:Sku:Version".</p></summary>
        [Pure]
        public static AzureVmssCreateSettings SetImage(this AzureVmssCreateSettings toolSettings, string image)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Image = image;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssCreateSettings.Image"/>.</em></p><p>The name of the operating system image as a URN alias, URN, custom image name or ID, or VHD blob URI. Valid URN format: "Publisher:Offer:Sku:Version".</p></summary>
        [Pure]
        public static AzureVmssCreateSettings ResetImage(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Image = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmssCreateSettings.Name"/>.</em></p><p>Name of the virtual machine scale set.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings SetName(this AzureVmssCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssCreateSettings.Name"/>.</em></p><p>Name of the virtual machine scale set.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings ResetName(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmssCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings SetResourceGroup(this AzureVmssCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings ResetResourceGroup(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region CustomData
        /// <summary><p><em>Sets <see cref="AzureVmssCreateSettings.CustomData"/>.</em></p><p>Custom init script file or text (cloud-init, cloud-config, etc..).</p></summary>
        [Pure]
        public static AzureVmssCreateSettings SetCustomData(this AzureVmssCreateSettings toolSettings, string customData)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CustomData = customData;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssCreateSettings.CustomData"/>.</em></p><p>Custom init script file or text (cloud-init, cloud-config, etc..).</p></summary>
        [Pure]
        public static AzureVmssCreateSettings ResetCustomData(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CustomData = null;
            return toolSettings;
        }
        #endregion
        #region DisableOverprovision
        /// <summary><p><em>Sets <see cref="AzureVmssCreateSettings.DisableOverprovision"/>.</em></p><p>Overprovision option (see <a href="https://azure.microsoft.com/en-us/documentation/articles/virtual-machine-scale-sets-overview/">https://azure.microsoft.com/en-us/documentation/articles/virtual-machine-scale-sets-overview/</a> for details).</p></summary>
        [Pure]
        public static AzureVmssCreateSettings SetDisableOverprovision(this AzureVmssCreateSettings toolSettings, string disableOverprovision)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableOverprovision = disableOverprovision;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssCreateSettings.DisableOverprovision"/>.</em></p><p>Overprovision option (see <a href="https://azure.microsoft.com/en-us/documentation/articles/virtual-machine-scale-sets-overview/">https://azure.microsoft.com/en-us/documentation/articles/virtual-machine-scale-sets-overview/</a> for details).</p></summary>
        [Pure]
        public static AzureVmssCreateSettings ResetDisableOverprovision(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableOverprovision = null;
            return toolSettings;
        }
        #endregion
        #region EvictionPolicy
        /// <summary><p><em>Sets <see cref="AzureVmssCreateSettings.EvictionPolicy"/>.</em></p><p>(PREVIEW) The eviction policy for virtual machines in a low priority scale set.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings SetEvictionPolicy(this AzureVmssCreateSettings toolSettings, VmssCreateEvictionPolicy evictionPolicy)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EvictionPolicy = evictionPolicy;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssCreateSettings.EvictionPolicy"/>.</em></p><p>(PREVIEW) The eviction policy for virtual machines in a low priority scale set.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings ResetEvictionPolicy(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EvictionPolicy = null;
            return toolSettings;
        }
        #endregion
        #region HealthProbe
        /// <summary><p><em>Sets <see cref="AzureVmssCreateSettings.HealthProbe"/>.</em></p><p>(Preview) probe name from the existing load balancer, mainly used for rolling upgrade.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings SetHealthProbe(this AzureVmssCreateSettings toolSettings, string healthProbe)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HealthProbe = healthProbe;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssCreateSettings.HealthProbe"/>.</em></p><p>(Preview) probe name from the existing load balancer, mainly used for rolling upgrade.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings ResetHealthProbe(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HealthProbe = null;
            return toolSettings;
        }
        #endregion
        #region InstanceCount
        /// <summary><p><em>Sets <see cref="AzureVmssCreateSettings.InstanceCount"/>.</em></p><p>Number of VMs in the scale set.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings SetInstanceCount(this AzureVmssCreateSettings toolSettings, int? instanceCount)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InstanceCount = instanceCount;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssCreateSettings.InstanceCount"/>.</em></p><p>Number of VMs in the scale set.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings ResetInstanceCount(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InstanceCount = null;
            return toolSettings;
        }
        #endregion
        #region LicenseType
        /// <summary><p><em>Sets <see cref="AzureVmssCreateSettings.LicenseType"/>.</em></p><p>License type if the Windows image or disk used was licensed on-premises.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings SetLicenseType(this AzureVmssCreateSettings toolSettings, VmssLicenseType licenseType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LicenseType = licenseType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssCreateSettings.LicenseType"/>.</em></p><p>License type if the Windows image or disk used was licensed on-premises.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings ResetLicenseType(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LicenseType = null;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary><p><em>Sets <see cref="AzureVmssCreateSettings.Location"/>.</em></p><p>Location in which to create VM and related resources. If default location is not configured, will default to the resource group's location.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings SetLocation(this AzureVmssCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssCreateSettings.Location"/>.</em></p><p>Location in which to create VM and related resources. If default location is not configured, will default to the resource group's location.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings ResetLocation(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary><p><em>Sets <see cref="AzureVmssCreateSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings SetNoWait(this AzureVmssCreateSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssCreateSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings ResetNoWait(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureVmssCreateSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings EnableNoWait(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureVmssCreateSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings DisableNoWait(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureVmssCreateSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings ToggleNoWait(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region PlatformFaultDomainCount
        /// <summary><p><em>Sets <see cref="AzureVmssCreateSettings.PlatformFaultDomainCount"/>.</em></p><p>Fault Domain count for each placement group in the availability zone.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings SetPlatformFaultDomainCount(this AzureVmssCreateSettings toolSettings, string platformFaultDomainCount)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PlatformFaultDomainCount = platformFaultDomainCount;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssCreateSettings.PlatformFaultDomainCount"/>.</em></p><p>Fault Domain count for each placement group in the availability zone.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings ResetPlatformFaultDomainCount(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PlatformFaultDomainCount = null;
            return toolSettings;
        }
        #endregion
        #region Priority
        /// <summary><p><em>Sets <see cref="AzureVmssCreateSettings.Priority"/>.</em></p><p>Priority. Use 'Low' to run short-lived workloads in a cost-effective way.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings SetPriority(this AzureVmssCreateSettings toolSettings, VmssCreatePriority priority)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Priority = priority;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssCreateSettings.Priority"/>.</em></p><p>Priority. Use 'Low' to run short-lived workloads in a cost-effective way.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings ResetPriority(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Priority = null;
            return toolSettings;
        }
        #endregion
        #region Secrets
        /// <summary><p><em>Sets <see cref="AzureVmssCreateSettings.Secrets"/>.</em></p><p>One or many Key Vault secrets as JSON strings or files via `@{path}` containing `[{ "sourceVault": { "id": "value" }, "vaultCertificates": [{ "certificateUrl": "value", "certificateStore": "cert store name (only on windows)"}] }]`.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings SetSecrets(this AzureVmssCreateSettings toolSettings, string secrets)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Secrets = secrets;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssCreateSettings.Secrets"/>.</em></p><p>One or many Key Vault secrets as JSON strings or files via `@{path}` containing `[{ "sourceVault": { "id": "value" }, "vaultCertificates": [{ "certificateUrl": "value", "certificateStore": "cert store name (only on windows)"}] }]`.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings ResetSecrets(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Secrets = null;
            return toolSettings;
        }
        #endregion
        #region SinglePlacementGroup
        /// <summary><p><em>Sets <see cref="AzureVmssCreateSettings.SinglePlacementGroup"/>.</em></p><p>Enable replicate using fault domains within the same cluster. Default to 'false' for any zonals, or with 100+ instances See <a href="https://docs.microsoft.com/en-us/azure/virtual-machine-scale-sets/virtual-machine-scale-sets-placement-groups">https://docs.microsoft.com/en-us/azure/virtual-machine-scale-sets/virtual-machine-scale-sets-placement-groups</a> for details.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings SetSinglePlacementGroup(this AzureVmssCreateSettings toolSettings, bool? singlePlacementGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SinglePlacementGroup = singlePlacementGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssCreateSettings.SinglePlacementGroup"/>.</em></p><p>Enable replicate using fault domains within the same cluster. Default to 'false' for any zonals, or with 100+ instances See <a href="https://docs.microsoft.com/en-us/azure/virtual-machine-scale-sets/virtual-machine-scale-sets-placement-groups">https://docs.microsoft.com/en-us/azure/virtual-machine-scale-sets/virtual-machine-scale-sets-placement-groups</a> for details.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings ResetSinglePlacementGroup(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SinglePlacementGroup = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureVmssCreateSettings.SinglePlacementGroup"/>.</em></p><p>Enable replicate using fault domains within the same cluster. Default to 'false' for any zonals, or with 100+ instances See <a href="https://docs.microsoft.com/en-us/azure/virtual-machine-scale-sets/virtual-machine-scale-sets-placement-groups">https://docs.microsoft.com/en-us/azure/virtual-machine-scale-sets/virtual-machine-scale-sets-placement-groups</a> for details.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings EnableSinglePlacementGroup(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SinglePlacementGroup = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureVmssCreateSettings.SinglePlacementGroup"/>.</em></p><p>Enable replicate using fault domains within the same cluster. Default to 'false' for any zonals, or with 100+ instances See <a href="https://docs.microsoft.com/en-us/azure/virtual-machine-scale-sets/virtual-machine-scale-sets-placement-groups">https://docs.microsoft.com/en-us/azure/virtual-machine-scale-sets/virtual-machine-scale-sets-placement-groups</a> for details.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings DisableSinglePlacementGroup(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SinglePlacementGroup = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureVmssCreateSettings.SinglePlacementGroup"/>.</em></p><p>Enable replicate using fault domains within the same cluster. Default to 'false' for any zonals, or with 100+ instances See <a href="https://docs.microsoft.com/en-us/azure/virtual-machine-scale-sets/virtual-machine-scale-sets-placement-groups">https://docs.microsoft.com/en-us/azure/virtual-machine-scale-sets/virtual-machine-scale-sets-placement-groups</a> for details.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings ToggleSinglePlacementGroup(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SinglePlacementGroup = !toolSettings.SinglePlacementGroup;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary><p><em>Sets <see cref="AzureVmssCreateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings SetTags(this AzureVmssCreateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssCreateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings ResetTags(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region UpgradePolicyMode
        /// <summary><p><em>Sets <see cref="AzureVmssCreateSettings.UpgradePolicyMode"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureVmssCreateSettings SetUpgradePolicyMode(this AzureVmssCreateSettings toolSettings, VmssCreateUpgradePolicyMode upgradePolicyMode)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UpgradePolicyMode = upgradePolicyMode;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssCreateSettings.UpgradePolicyMode"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureVmssCreateSettings ResetUpgradePolicyMode(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UpgradePolicyMode = null;
            return toolSettings;
        }
        #endregion
        #region Validate
        /// <summary><p><em>Sets <see cref="AzureVmssCreateSettings.Validate"/>.</em></p><p>Generate and validate the ARM template without creating any resources.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings SetValidate(this AzureVmssCreateSettings toolSettings, string validate)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Validate = validate;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssCreateSettings.Validate"/>.</em></p><p>Generate and validate the ARM template without creating any resources.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings ResetValidate(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Validate = null;
            return toolSettings;
        }
        #endregion
        #region VmSku
        /// <summary><p><em>Sets <see cref="AzureVmssCreateSettings.VmSku"/>.</em></p><p>Size of VMs in the scale set. Default to "Standard_DS1_v2". See <a href="https://azure.microsoft.com/en-us/pricing/details/virtual-machines/">https://azure.microsoft.com/en-us/pricing/details/virtual-machines/</a> for size info.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings SetVmSku(this AzureVmssCreateSettings toolSettings, string vmSku)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmSku = vmSku;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssCreateSettings.VmSku"/>.</em></p><p>Size of VMs in the scale set. Default to "Standard_DS1_v2". See <a href="https://azure.microsoft.com/en-us/pricing/details/virtual-machines/">https://azure.microsoft.com/en-us/pricing/details/virtual-machines/</a> for size info.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings ResetVmSku(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmSku = null;
            return toolSettings;
        }
        #endregion
        #region Zones
        /// <summary><p><em>Sets <see cref="AzureVmssCreateSettings.Zones"/> to a new list.</em></p><p>Space-separated list of availability zones into which to provision the resource.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings SetZones(this AzureVmssCreateSettings toolSettings, params VmssCreateZones[] zones)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ZonesInternal = zones.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureVmssCreateSettings.Zones"/> to a new list.</em></p><p>Space-separated list of availability zones into which to provision the resource.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings SetZones(this AzureVmssCreateSettings toolSettings, IEnumerable<VmssCreateZones> zones)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ZonesInternal = zones.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmssCreateSettings.Zones"/>.</em></p><p>Space-separated list of availability zones into which to provision the resource.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings AddZones(this AzureVmssCreateSettings toolSettings, params VmssCreateZones[] zones)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ZonesInternal.AddRange(zones);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmssCreateSettings.Zones"/>.</em></p><p>Space-separated list of availability zones into which to provision the resource.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings AddZones(this AzureVmssCreateSettings toolSettings, IEnumerable<VmssCreateZones> zones)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ZonesInternal.AddRange(zones);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureVmssCreateSettings.Zones"/>.</em></p><p>Space-separated list of availability zones into which to provision the resource.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings ClearZones(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ZonesInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmssCreateSettings.Zones"/>.</em></p><p>Space-separated list of availability zones into which to provision the resource.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings RemoveZones(this AzureVmssCreateSettings toolSettings, params VmssCreateZones[] zones)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<VmssCreateZones>(zones);
            toolSettings.ZonesInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmssCreateSettings.Zones"/>.</em></p><p>Space-separated list of availability zones into which to provision the resource.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings RemoveZones(this AzureVmssCreateSettings toolSettings, IEnumerable<VmssCreateZones> zones)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<VmssCreateZones>(zones);
            toolSettings.ZonesInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region AdminPassword
        /// <summary><p><em>Sets <see cref="AzureVmssCreateSettings.AdminPassword"/>.</em></p><p>Password for the VM if authentication type is 'Password'.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings SetAdminPassword(this AzureVmssCreateSettings toolSettings, string adminPassword)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdminPassword = adminPassword;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssCreateSettings.AdminPassword"/>.</em></p><p>Password for the VM if authentication type is 'Password'.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings ResetAdminPassword(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdminPassword = null;
            return toolSettings;
        }
        #endregion
        #region AdminUsername
        /// <summary><p><em>Sets <see cref="AzureVmssCreateSettings.AdminUsername"/>.</em></p><p>Username for the VM.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings SetAdminUsername(this AzureVmssCreateSettings toolSettings, string adminUsername)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdminUsername = adminUsername;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssCreateSettings.AdminUsername"/>.</em></p><p>Username for the VM.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings ResetAdminUsername(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdminUsername = null;
            return toolSettings;
        }
        #endregion
        #region AuthenticationType
        /// <summary><p><em>Sets <see cref="AzureVmssCreateSettings.AuthenticationType"/>.</em></p><p>Type of authentication to use with the VM. Defaults to password for Windows and SSH public key for Linux. "all" enables both ssh and password authentication.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings SetAuthenticationType(this AzureVmssCreateSettings toolSettings, VmssCreateAuthenticationType authenticationType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AuthenticationType = authenticationType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssCreateSettings.AuthenticationType"/>.</em></p><p>Type of authentication to use with the VM. Defaults to password for Windows and SSH public key for Linux. "all" enables both ssh and password authentication.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings ResetAuthenticationType(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AuthenticationType = null;
            return toolSettings;
        }
        #endregion
        #region GenerateSshKeys
        /// <summary><p><em>Sets <see cref="AzureVmssCreateSettings.GenerateSshKeys"/>.</em></p><p>Generate SSH public and private key files if missing. The keys will be stored in the ~/.ssh directory.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings SetGenerateSshKeys(this AzureVmssCreateSettings toolSettings, string generateSshKeys)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GenerateSshKeys = generateSshKeys;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssCreateSettings.GenerateSshKeys"/>.</em></p><p>Generate SSH public and private key files if missing. The keys will be stored in the ~/.ssh directory.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings ResetGenerateSshKeys(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GenerateSshKeys = null;
            return toolSettings;
        }
        #endregion
        #region SshDestKeyPath
        /// <summary><p><em>Sets <see cref="AzureVmssCreateSettings.SshDestKeyPath"/>.</em></p><p>Destination file path on the VM for the SSH key.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings SetSshDestKeyPath(this AzureVmssCreateSettings toolSettings, string sshDestKeyPath)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SshDestKeyPath = sshDestKeyPath;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssCreateSettings.SshDestKeyPath"/>.</em></p><p>Destination file path on the VM for the SSH key.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings ResetSshDestKeyPath(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SshDestKeyPath = null;
            return toolSettings;
        }
        #endregion
        #region SshKeyValue
        /// <summary><p><em>Sets <see cref="AzureVmssCreateSettings.SshKeyValue"/>.</em></p><p>SSH public key or public key file path.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings SetSshKeyValue(this AzureVmssCreateSettings toolSettings, string sshKeyValue)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SshKeyValue = sshKeyValue;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssCreateSettings.SshKeyValue"/>.</em></p><p>SSH public key or public key file path.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings ResetSshKeyValue(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SshKeyValue = null;
            return toolSettings;
        }
        #endregion
        #region AssignIdentity
        /// <summary><p><em>Sets <see cref="AzureVmssCreateSettings.AssignIdentity"/>.</em></p><p>Accept system or user assigned identities separated by spaces. Use '[system]' to refer system assigned identity, or a resource id to refer user assigned identity. Check out help for more examples.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings SetAssignIdentity(this AzureVmssCreateSettings toolSettings, string assignIdentity)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AssignIdentity = assignIdentity;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssCreateSettings.AssignIdentity"/>.</em></p><p>Accept system or user assigned identities separated by spaces. Use '[system]' to refer system assigned identity, or a resource id to refer user assigned identity. Check out help for more examples.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings ResetAssignIdentity(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AssignIdentity = null;
            return toolSettings;
        }
        #endregion
        #region Role
        /// <summary><p><em>Sets <see cref="AzureVmssCreateSettings.Role"/>.</em></p><p>Role name or id the system assigned identity will have.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings SetRole(this AzureVmssCreateSettings toolSettings, string role)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Role = role;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssCreateSettings.Role"/>.</em></p><p>Role name or id the system assigned identity will have.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings ResetRole(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Role = null;
            return toolSettings;
        }
        #endregion
        #region Scope
        /// <summary><p><em>Sets <see cref="AzureVmssCreateSettings.Scope"/>.</em></p><p>Scope that the system assigned identity can access.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings SetScope(this AzureVmssCreateSettings toolSettings, string scope)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Scope = scope;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssCreateSettings.Scope"/>.</em></p><p>Scope that the system assigned identity can access.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings ResetScope(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Scope = null;
            return toolSettings;
        }
        #endregion
        #region PlanName
        /// <summary><p><em>Sets <see cref="AzureVmssCreateSettings.PlanName"/>.</em></p><p>Plan name.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings SetPlanName(this AzureVmssCreateSettings toolSettings, string planName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PlanName = planName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssCreateSettings.PlanName"/>.</em></p><p>Plan name.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings ResetPlanName(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PlanName = null;
            return toolSettings;
        }
        #endregion
        #region PlanProduct
        /// <summary><p><em>Sets <see cref="AzureVmssCreateSettings.PlanProduct"/>.</em></p><p>Plan product.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings SetPlanProduct(this AzureVmssCreateSettings toolSettings, string planProduct)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PlanProduct = planProduct;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssCreateSettings.PlanProduct"/>.</em></p><p>Plan product.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings ResetPlanProduct(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PlanProduct = null;
            return toolSettings;
        }
        #endregion
        #region PlanPromotionCode
        /// <summary><p><em>Sets <see cref="AzureVmssCreateSettings.PlanPromotionCode"/>.</em></p><p>Plan promotion code.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings SetPlanPromotionCode(this AzureVmssCreateSettings toolSettings, string planPromotionCode)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PlanPromotionCode = planPromotionCode;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssCreateSettings.PlanPromotionCode"/>.</em></p><p>Plan promotion code.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings ResetPlanPromotionCode(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PlanPromotionCode = null;
            return toolSettings;
        }
        #endregion
        #region PlanPublisher
        /// <summary><p><em>Sets <see cref="AzureVmssCreateSettings.PlanPublisher"/>.</em></p><p>Plan publisher.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings SetPlanPublisher(this AzureVmssCreateSettings toolSettings, string planPublisher)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PlanPublisher = planPublisher;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssCreateSettings.PlanPublisher"/>.</em></p><p>Plan publisher.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings ResetPlanPublisher(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PlanPublisher = null;
            return toolSettings;
        }
        #endregion
        #region AcceleratedNetworking
        /// <summary><p><em>Sets <see cref="AzureVmssCreateSettings.AcceleratedNetworking"/>.</em></p><p>Enable accelerated networking. Unless specified, CLI will enable it based on machine image and size.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings SetAcceleratedNetworking(this AzureVmssCreateSettings toolSettings, bool? acceleratedNetworking)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AcceleratedNetworking = acceleratedNetworking;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssCreateSettings.AcceleratedNetworking"/>.</em></p><p>Enable accelerated networking. Unless specified, CLI will enable it based on machine image and size.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings ResetAcceleratedNetworking(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AcceleratedNetworking = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureVmssCreateSettings.AcceleratedNetworking"/>.</em></p><p>Enable accelerated networking. Unless specified, CLI will enable it based on machine image and size.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings EnableAcceleratedNetworking(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AcceleratedNetworking = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureVmssCreateSettings.AcceleratedNetworking"/>.</em></p><p>Enable accelerated networking. Unless specified, CLI will enable it based on machine image and size.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings DisableAcceleratedNetworking(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AcceleratedNetworking = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureVmssCreateSettings.AcceleratedNetworking"/>.</em></p><p>Enable accelerated networking. Unless specified, CLI will enable it based on machine image and size.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings ToggleAcceleratedNetworking(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AcceleratedNetworking = !toolSettings.AcceleratedNetworking;
            return toolSettings;
        }
        #endregion
        #region Asgs
        /// <summary><p><em>Sets <see cref="AzureVmssCreateSettings.Asgs"/> to a new list.</em></p><p>Space-separated list of existing application security groups to associate with the VM.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings SetAsgs(this AzureVmssCreateSettings toolSettings, params string[] asgs)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AsgsInternal = asgs.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureVmssCreateSettings.Asgs"/> to a new list.</em></p><p>Space-separated list of existing application security groups to associate with the VM.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings SetAsgs(this AzureVmssCreateSettings toolSettings, IEnumerable<string> asgs)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AsgsInternal = asgs.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmssCreateSettings.Asgs"/>.</em></p><p>Space-separated list of existing application security groups to associate with the VM.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings AddAsgs(this AzureVmssCreateSettings toolSettings, params string[] asgs)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AsgsInternal.AddRange(asgs);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmssCreateSettings.Asgs"/>.</em></p><p>Space-separated list of existing application security groups to associate with the VM.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings AddAsgs(this AzureVmssCreateSettings toolSettings, IEnumerable<string> asgs)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AsgsInternal.AddRange(asgs);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureVmssCreateSettings.Asgs"/>.</em></p><p>Space-separated list of existing application security groups to associate with the VM.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings ClearAsgs(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AsgsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmssCreateSettings.Asgs"/>.</em></p><p>Space-separated list of existing application security groups to associate with the VM.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings RemoveAsgs(this AzureVmssCreateSettings toolSettings, params string[] asgs)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(asgs);
            toolSettings.AsgsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmssCreateSettings.Asgs"/>.</em></p><p>Space-separated list of existing application security groups to associate with the VM.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings RemoveAsgs(this AzureVmssCreateSettings toolSettings, IEnumerable<string> asgs)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(asgs);
            toolSettings.AsgsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region DnsServers
        /// <summary><p><em>Sets <see cref="AzureVmssCreateSettings.DnsServers"/> to a new list.</em></p><p>Space-separated IP addresses of DNS servers, e.g. 10.0.0.5 10.0.0.6.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings SetDnsServers(this AzureVmssCreateSettings toolSettings, params string[] dnsServers)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DnsServersInternal = dnsServers.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureVmssCreateSettings.DnsServers"/> to a new list.</em></p><p>Space-separated IP addresses of DNS servers, e.g. 10.0.0.5 10.0.0.6.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings SetDnsServers(this AzureVmssCreateSettings toolSettings, IEnumerable<string> dnsServers)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DnsServersInternal = dnsServers.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmssCreateSettings.DnsServers"/>.</em></p><p>Space-separated IP addresses of DNS servers, e.g. 10.0.0.5 10.0.0.6.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings AddDnsServers(this AzureVmssCreateSettings toolSettings, params string[] dnsServers)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DnsServersInternal.AddRange(dnsServers);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmssCreateSettings.DnsServers"/>.</em></p><p>Space-separated IP addresses of DNS servers, e.g. 10.0.0.5 10.0.0.6.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings AddDnsServers(this AzureVmssCreateSettings toolSettings, IEnumerable<string> dnsServers)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DnsServersInternal.AddRange(dnsServers);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureVmssCreateSettings.DnsServers"/>.</em></p><p>Space-separated IP addresses of DNS servers, e.g. 10.0.0.5 10.0.0.6.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings ClearDnsServers(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DnsServersInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmssCreateSettings.DnsServers"/>.</em></p><p>Space-separated IP addresses of DNS servers, e.g. 10.0.0.5 10.0.0.6.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings RemoveDnsServers(this AzureVmssCreateSettings toolSettings, params string[] dnsServers)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(dnsServers);
            toolSettings.DnsServersInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmssCreateSettings.DnsServers"/>.</em></p><p>Space-separated IP addresses of DNS servers, e.g. 10.0.0.5 10.0.0.6.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings RemoveDnsServers(this AzureVmssCreateSettings toolSettings, IEnumerable<string> dnsServers)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(dnsServers);
            toolSettings.DnsServersInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Nsg
        /// <summary><p><em>Sets <see cref="AzureVmssCreateSettings.Nsg"/>.</em></p><p>Name or ID of an existing Network Security Group.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings SetNsg(this AzureVmssCreateSettings toolSettings, string nsg)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Nsg = nsg;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssCreateSettings.Nsg"/>.</em></p><p>Name or ID of an existing Network Security Group.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings ResetNsg(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Nsg = null;
            return toolSettings;
        }
        #endregion
        #region PublicIpAddress
        /// <summary><p><em>Sets <see cref="AzureVmssCreateSettings.PublicIpAddress"/>.</em></p><p>Name of the public IP address when creating one (default) or referencing an existing one. Can also reference an existing public IP by ID or specify "" for None.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings SetPublicIpAddress(this AzureVmssCreateSettings toolSettings, string publicIpAddress)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PublicIpAddress = publicIpAddress;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssCreateSettings.PublicIpAddress"/>.</em></p><p>Name of the public IP address when creating one (default) or referencing an existing one. Can also reference an existing public IP by ID or specify "" for None.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings ResetPublicIpAddress(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PublicIpAddress = null;
            return toolSettings;
        }
        #endregion
        #region PublicIpAddressAllocation
        /// <summary><p><em>Sets <see cref="AzureVmssCreateSettings.PublicIpAddressAllocation"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureVmssCreateSettings SetPublicIpAddressAllocation(this AzureVmssCreateSettings toolSettings, VmssCreatePublicIpAddressAllocation publicIpAddressAllocation)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PublicIpAddressAllocation = publicIpAddressAllocation;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssCreateSettings.PublicIpAddressAllocation"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureVmssCreateSettings ResetPublicIpAddressAllocation(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PublicIpAddressAllocation = null;
            return toolSettings;
        }
        #endregion
        #region PublicIpAddressDnsName
        /// <summary><p><em>Sets <see cref="AzureVmssCreateSettings.PublicIpAddressDnsName"/>.</em></p><p>Globally unique DNS name for a newly created public IP.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings SetPublicIpAddressDnsName(this AzureVmssCreateSettings toolSettings, string publicIpAddressDnsName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PublicIpAddressDnsName = publicIpAddressDnsName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssCreateSettings.PublicIpAddressDnsName"/>.</em></p><p>Globally unique DNS name for a newly created public IP.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings ResetPublicIpAddressDnsName(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PublicIpAddressDnsName = null;
            return toolSettings;
        }
        #endregion
        #region PublicIpPerVm
        /// <summary><p><em>Sets <see cref="AzureVmssCreateSettings.PublicIpPerVm"/>.</em></p><p>Each VM instance will have a public ip. For security, you can use '--nsg' to apply appropriate rules.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings SetPublicIpPerVm(this AzureVmssCreateSettings toolSettings, string publicIpPerVm)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PublicIpPerVm = publicIpPerVm;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssCreateSettings.PublicIpPerVm"/>.</em></p><p>Each VM instance will have a public ip. For security, you can use '--nsg' to apply appropriate rules.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings ResetPublicIpPerVm(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PublicIpPerVm = null;
            return toolSettings;
        }
        #endregion
        #region Subnet
        /// <summary><p><em>Sets <see cref="AzureVmssCreateSettings.Subnet"/>.</em></p><p>The name of the subnet when creating a new VNet or referencing an existing one. Can also reference an existing subnet by ID. If omitted, an appropriate VNet and subnet will be selected automatically, or a new one will be created.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings SetSubnet(this AzureVmssCreateSettings toolSettings, string subnet)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subnet = subnet;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssCreateSettings.Subnet"/>.</em></p><p>The name of the subnet when creating a new VNet or referencing an existing one. Can also reference an existing subnet by ID. If omitted, an appropriate VNet and subnet will be selected automatically, or a new one will be created.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings ResetSubnet(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subnet = null;
            return toolSettings;
        }
        #endregion
        #region SubnetAddressPrefix
        /// <summary><p><em>Sets <see cref="AzureVmssCreateSettings.SubnetAddressPrefix"/>.</em></p><p>The subnet IP address prefix to use when creating a new VNet in CIDR format.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings SetSubnetAddressPrefix(this AzureVmssCreateSettings toolSettings, string subnetAddressPrefix)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SubnetAddressPrefix = subnetAddressPrefix;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssCreateSettings.SubnetAddressPrefix"/>.</em></p><p>The subnet IP address prefix to use when creating a new VNet in CIDR format.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings ResetSubnetAddressPrefix(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SubnetAddressPrefix = null;
            return toolSettings;
        }
        #endregion
        #region VmDomainName
        /// <summary><p><em>Sets <see cref="AzureVmssCreateSettings.VmDomainName"/>.</em></p><p>Domain name of VM instances, once configured, the FQDN is 'vm&lt;vm-index&gt;.&lt;vm-domain-name&gt;.&lt;..rest..&gt;'.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings SetVmDomainName(this AzureVmssCreateSettings toolSettings, string vmDomainName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmDomainName = vmDomainName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssCreateSettings.VmDomainName"/>.</em></p><p>Domain name of VM instances, once configured, the FQDN is 'vm&lt;vm-index&gt;.&lt;vm-domain-name&gt;.&lt;..rest..&gt;'.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings ResetVmDomainName(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmDomainName = null;
            return toolSettings;
        }
        #endregion
        #region VnetAddressPrefix
        /// <summary><p><em>Sets <see cref="AzureVmssCreateSettings.VnetAddressPrefix"/>.</em></p><p>The IP address prefix to use when creating a new VNet in CIDR format.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings SetVnetAddressPrefix(this AzureVmssCreateSettings toolSettings, string vnetAddressPrefix)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VnetAddressPrefix = vnetAddressPrefix;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssCreateSettings.VnetAddressPrefix"/>.</em></p><p>The IP address prefix to use when creating a new VNet in CIDR format.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings ResetVnetAddressPrefix(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VnetAddressPrefix = null;
            return toolSettings;
        }
        #endregion
        #region VnetName
        /// <summary><p><em>Sets <see cref="AzureVmssCreateSettings.VnetName"/>.</em></p><p>Name of the virtual network when creating a new one or referencing an existing one.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings SetVnetName(this AzureVmssCreateSettings toolSettings, string vnetName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VnetName = vnetName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssCreateSettings.VnetName"/>.</em></p><p>Name of the virtual network when creating a new one or referencing an existing one.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings ResetVnetName(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VnetName = null;
            return toolSettings;
        }
        #endregion
        #region AppGateway
        /// <summary><p><em>Sets <see cref="AzureVmssCreateSettings.AppGateway"/>.</em></p><p>Name to use when creating a new application gateway (default) or referencing an existing one. Can also reference an existing application gateway by ID or specify "" for none.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings SetAppGateway(this AzureVmssCreateSettings toolSettings, string appGateway)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AppGateway = appGateway;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssCreateSettings.AppGateway"/>.</em></p><p>Name to use when creating a new application gateway (default) or referencing an existing one. Can also reference an existing application gateway by ID or specify "" for none.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings ResetAppGateway(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AppGateway = null;
            return toolSettings;
        }
        #endregion
        #region AppGatewayCapacity
        /// <summary><p><em>Sets <see cref="AzureVmssCreateSettings.AppGatewayCapacity"/>.</em></p><p>The number of instances to use when creating a new application gateway.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings SetAppGatewayCapacity(this AzureVmssCreateSettings toolSettings, string appGatewayCapacity)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AppGatewayCapacity = appGatewayCapacity;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssCreateSettings.AppGatewayCapacity"/>.</em></p><p>The number of instances to use when creating a new application gateway.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings ResetAppGatewayCapacity(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AppGatewayCapacity = null;
            return toolSettings;
        }
        #endregion
        #region AppGatewaySku
        /// <summary><p><em>Sets <see cref="AzureVmssCreateSettings.AppGatewaySku"/>.</em></p><p>SKU when creating a new application gateway.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings SetAppGatewaySku(this AzureVmssCreateSettings toolSettings, string appGatewaySku)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AppGatewaySku = appGatewaySku;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssCreateSettings.AppGatewaySku"/>.</em></p><p>SKU when creating a new application gateway.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings ResetAppGatewaySku(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AppGatewaySku = null;
            return toolSettings;
        }
        #endregion
        #region AppGatewaySubnetAddressPrefix
        /// <summary><p><em>Sets <see cref="AzureVmssCreateSettings.AppGatewaySubnetAddressPrefix"/>.</em></p><p>The subnet IP address prefix to use when creating a new application gateway in CIDR format.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings SetAppGatewaySubnetAddressPrefix(this AzureVmssCreateSettings toolSettings, string appGatewaySubnetAddressPrefix)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AppGatewaySubnetAddressPrefix = appGatewaySubnetAddressPrefix;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssCreateSettings.AppGatewaySubnetAddressPrefix"/>.</em></p><p>The subnet IP address prefix to use when creating a new application gateway in CIDR format.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings ResetAppGatewaySubnetAddressPrefix(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AppGatewaySubnetAddressPrefix = null;
            return toolSettings;
        }
        #endregion
        #region BackendPoolName
        /// <summary><p><em>Sets <see cref="AzureVmssCreateSettings.BackendPoolName"/>.</em></p><p>Name to use for the backend pool when creating a new load balancer or application gateway.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings SetBackendPoolName(this AzureVmssCreateSettings toolSettings, string backendPoolName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BackendPoolName = backendPoolName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssCreateSettings.BackendPoolName"/>.</em></p><p>Name to use for the backend pool when creating a new load balancer or application gateway.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings ResetBackendPoolName(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BackendPoolName = null;
            return toolSettings;
        }
        #endregion
        #region BackendPort
        /// <summary><p><em>Sets <see cref="AzureVmssCreateSettings.BackendPort"/>.</em></p><p>When creating a new load balancer, backend port to open with NAT rules (Defaults to 22 on Linux and 3389 on Windows). When creating an application gateway, the backend port to use for the backend HTTP settings.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings SetBackendPort(this AzureVmssCreateSettings toolSettings, string backendPort)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BackendPort = backendPort;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssCreateSettings.BackendPort"/>.</em></p><p>When creating a new load balancer, backend port to open with NAT rules (Defaults to 22 on Linux and 3389 on Windows). When creating an application gateway, the backend port to use for the backend HTTP settings.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings ResetBackendPort(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BackendPort = null;
            return toolSettings;
        }
        #endregion
        #region Lb
        /// <summary><p><em>Sets <see cref="AzureVmssCreateSettings.Lb"/>.</em></p><p>Name to use when creating a new load balancer (default) or referencing an existing one. Can also reference an existing load balancer by ID or specify "" for none.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings SetLb(this AzureVmssCreateSettings toolSettings, string lb)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Lb = lb;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssCreateSettings.Lb"/>.</em></p><p>Name to use when creating a new load balancer (default) or referencing an existing one. Can also reference an existing load balancer by ID or specify "" for none.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings ResetLb(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Lb = null;
            return toolSettings;
        }
        #endregion
        #region LbNatPoolName
        /// <summary><p><em>Sets <see cref="AzureVmssCreateSettings.LbNatPoolName"/>.</em></p><p>Name to use for the NAT pool when creating a new load balancer.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings SetLbNatPoolName(this AzureVmssCreateSettings toolSettings, string lbNatPoolName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LbNatPoolName = lbNatPoolName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssCreateSettings.LbNatPoolName"/>.</em></p><p>Name to use for the NAT pool when creating a new load balancer.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings ResetLbNatPoolName(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LbNatPoolName = null;
            return toolSettings;
        }
        #endregion
        #region LbSku
        /// <summary><p><em>Sets <see cref="AzureVmssCreateSettings.LbSku"/>.</em></p><p>Sku of the Load Balancer to create. Default to 'Standard' when single placement group is turned off; otherwise, default to 'Basic'.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings SetLbSku(this AzureVmssCreateSettings toolSettings, VmssCreateLbSku lbSku)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LbSku = lbSku;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssCreateSettings.LbSku"/>.</em></p><p>Sku of the Load Balancer to create. Default to 'Standard' when single placement group is turned off; otherwise, default to 'Basic'.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings ResetLbSku(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LbSku = null;
            return toolSettings;
        }
        #endregion
        #region DataDiskCaching
        /// <summary><p><em>Sets <see cref="AzureVmssCreateSettings.DataDiskCaching"/>.</em></p><p>Storage caching type for data disk(s), including 'None', 'ReadOnly', 'ReadWrite', etc. Use a singular value to apply on all disks, or use '&lt;lun&gt;=&lt;vaule1&gt; &lt;lun&gt;=&lt;value2&gt;' to configure individual disk.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings SetDataDiskCaching(this AzureVmssCreateSettings toolSettings, string dataDiskCaching)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DataDiskCaching = dataDiskCaching;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssCreateSettings.DataDiskCaching"/>.</em></p><p>Storage caching type for data disk(s), including 'None', 'ReadOnly', 'ReadWrite', etc. Use a singular value to apply on all disks, or use '&lt;lun&gt;=&lt;vaule1&gt; &lt;lun&gt;=&lt;value2&gt;' to configure individual disk.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings ResetDataDiskCaching(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DataDiskCaching = null;
            return toolSettings;
        }
        #endregion
        #region DataDiskSizesGb
        /// <summary><p><em>Sets <see cref="AzureVmssCreateSettings.DataDiskSizesGb"/> to a new list.</em></p><p>Space-separated empty managed data disk sizes in GB to create.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings SetDataDiskSizesGb(this AzureVmssCreateSettings toolSettings, params string[] dataDiskSizesGb)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DataDiskSizesGbInternal = dataDiskSizesGb.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureVmssCreateSettings.DataDiskSizesGb"/> to a new list.</em></p><p>Space-separated empty managed data disk sizes in GB to create.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings SetDataDiskSizesGb(this AzureVmssCreateSettings toolSettings, IEnumerable<string> dataDiskSizesGb)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DataDiskSizesGbInternal = dataDiskSizesGb.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmssCreateSettings.DataDiskSizesGb"/>.</em></p><p>Space-separated empty managed data disk sizes in GB to create.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings AddDataDiskSizesGb(this AzureVmssCreateSettings toolSettings, params string[] dataDiskSizesGb)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DataDiskSizesGbInternal.AddRange(dataDiskSizesGb);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmssCreateSettings.DataDiskSizesGb"/>.</em></p><p>Space-separated empty managed data disk sizes in GB to create.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings AddDataDiskSizesGb(this AzureVmssCreateSettings toolSettings, IEnumerable<string> dataDiskSizesGb)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DataDiskSizesGbInternal.AddRange(dataDiskSizesGb);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureVmssCreateSettings.DataDiskSizesGb"/>.</em></p><p>Space-separated empty managed data disk sizes in GB to create.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings ClearDataDiskSizesGb(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DataDiskSizesGbInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmssCreateSettings.DataDiskSizesGb"/>.</em></p><p>Space-separated empty managed data disk sizes in GB to create.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings RemoveDataDiskSizesGb(this AzureVmssCreateSettings toolSettings, params string[] dataDiskSizesGb)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(dataDiskSizesGb);
            toolSettings.DataDiskSizesGbInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmssCreateSettings.DataDiskSizesGb"/>.</em></p><p>Space-separated empty managed data disk sizes in GB to create.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings RemoveDataDiskSizesGb(this AzureVmssCreateSettings toolSettings, IEnumerable<string> dataDiskSizesGb)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(dataDiskSizesGb);
            toolSettings.DataDiskSizesGbInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region EphemeralOsDisk
        /// <summary><p><em>Sets <see cref="AzureVmssCreateSettings.EphemeralOsDisk"/>.</em></p><p>(Preview) Allows you to create an OS disk directly on the host node, providing local disk performance and faster VM/VMSS reimage time.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings SetEphemeralOsDisk(this AzureVmssCreateSettings toolSettings, bool? ephemeralOsDisk)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EphemeralOsDisk = ephemeralOsDisk;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssCreateSettings.EphemeralOsDisk"/>.</em></p><p>(Preview) Allows you to create an OS disk directly on the host node, providing local disk performance and faster VM/VMSS reimage time.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings ResetEphemeralOsDisk(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EphemeralOsDisk = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureVmssCreateSettings.EphemeralOsDisk"/>.</em></p><p>(Preview) Allows you to create an OS disk directly on the host node, providing local disk performance and faster VM/VMSS reimage time.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings EnableEphemeralOsDisk(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EphemeralOsDisk = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureVmssCreateSettings.EphemeralOsDisk"/>.</em></p><p>(Preview) Allows you to create an OS disk directly on the host node, providing local disk performance and faster VM/VMSS reimage time.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings DisableEphemeralOsDisk(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EphemeralOsDisk = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureVmssCreateSettings.EphemeralOsDisk"/>.</em></p><p>(Preview) Allows you to create an OS disk directly on the host node, providing local disk performance and faster VM/VMSS reimage time.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings ToggleEphemeralOsDisk(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EphemeralOsDisk = !toolSettings.EphemeralOsDisk;
            return toolSettings;
        }
        #endregion
        #region OsDiskCaching
        /// <summary><p><em>Sets <see cref="AzureVmssCreateSettings.OsDiskCaching"/>.</em></p><p>Storage caching type for the VM OS disk. Default: ReadWrite.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings SetOsDiskCaching(this AzureVmssCreateSettings toolSettings, VmssCreateOsDiskCaching osDiskCaching)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OsDiskCaching = osDiskCaching;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssCreateSettings.OsDiskCaching"/>.</em></p><p>Storage caching type for the VM OS disk. Default: ReadWrite.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings ResetOsDiskCaching(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OsDiskCaching = null;
            return toolSettings;
        }
        #endregion
        #region OsDiskName
        /// <summary><p><em>Sets <see cref="AzureVmssCreateSettings.OsDiskName"/>.</em></p><p>The name of the new VM OS disk.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings SetOsDiskName(this AzureVmssCreateSettings toolSettings, string osDiskName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OsDiskName = osDiskName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssCreateSettings.OsDiskName"/>.</em></p><p>The name of the new VM OS disk.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings ResetOsDiskName(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OsDiskName = null;
            return toolSettings;
        }
        #endregion
        #region OsType
        /// <summary><p><em>Sets <see cref="AzureVmssCreateSettings.OsType"/>.</em></p><p>Type of OS installed on a custom VHD. Do not use when specifying an URN or URN alias.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings SetOsType(this AzureVmssCreateSettings toolSettings, VmssCreateOsType osType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OsType = osType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssCreateSettings.OsType"/>.</em></p><p>Type of OS installed on a custom VHD. Do not use when specifying an URN or URN alias.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings ResetOsType(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OsType = null;
            return toolSettings;
        }
        #endregion
        #region StorageContainerName
        /// <summary><p><em>Sets <see cref="AzureVmssCreateSettings.StorageContainerName"/>.</em></p><p>Only applicable when used with `--use-unmanaged-disk`. Name of the storage container for the VM OS disk. Default: vhds.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings SetStorageContainerName(this AzureVmssCreateSettings toolSettings, string storageContainerName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageContainerName = storageContainerName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssCreateSettings.StorageContainerName"/>.</em></p><p>Only applicable when used with `--use-unmanaged-disk`. Name of the storage container for the VM OS disk. Default: vhds.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings ResetStorageContainerName(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageContainerName = null;
            return toolSettings;
        }
        #endregion
        #region StorageSku
        /// <summary><p><em>Sets <see cref="AzureVmssCreateSettings.StorageSku"/> to a new list.</em></p><p>The SKU of the storage account with which to persist VM. Use a singular sku that would be applied across all disks, or specify individual disks. Usage: [--storage-sku SKU | --storage-sku ID=SKU ID=SKU ID=SKU...], where each ID is "os" or a 0-indexed lun. Allowed values: Standard_LRS, Premium_LRS, StandardSSD_LRS, UltraSSD_LRS.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings SetStorageSku(this AzureVmssCreateSettings toolSettings, params string[] storageSku)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageSkuInternal = storageSku.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureVmssCreateSettings.StorageSku"/> to a new list.</em></p><p>The SKU of the storage account with which to persist VM. Use a singular sku that would be applied across all disks, or specify individual disks. Usage: [--storage-sku SKU | --storage-sku ID=SKU ID=SKU ID=SKU...], where each ID is "os" or a 0-indexed lun. Allowed values: Standard_LRS, Premium_LRS, StandardSSD_LRS, UltraSSD_LRS.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings SetStorageSku(this AzureVmssCreateSettings toolSettings, IEnumerable<string> storageSku)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageSkuInternal = storageSku.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmssCreateSettings.StorageSku"/>.</em></p><p>The SKU of the storage account with which to persist VM. Use a singular sku that would be applied across all disks, or specify individual disks. Usage: [--storage-sku SKU | --storage-sku ID=SKU ID=SKU ID=SKU...], where each ID is "os" or a 0-indexed lun. Allowed values: Standard_LRS, Premium_LRS, StandardSSD_LRS, UltraSSD_LRS.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings AddStorageSku(this AzureVmssCreateSettings toolSettings, params string[] storageSku)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageSkuInternal.AddRange(storageSku);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmssCreateSettings.StorageSku"/>.</em></p><p>The SKU of the storage account with which to persist VM. Use a singular sku that would be applied across all disks, or specify individual disks. Usage: [--storage-sku SKU | --storage-sku ID=SKU ID=SKU ID=SKU...], where each ID is "os" or a 0-indexed lun. Allowed values: Standard_LRS, Premium_LRS, StandardSSD_LRS, UltraSSD_LRS.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings AddStorageSku(this AzureVmssCreateSettings toolSettings, IEnumerable<string> storageSku)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageSkuInternal.AddRange(storageSku);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureVmssCreateSettings.StorageSku"/>.</em></p><p>The SKU of the storage account with which to persist VM. Use a singular sku that would be applied across all disks, or specify individual disks. Usage: [--storage-sku SKU | --storage-sku ID=SKU ID=SKU ID=SKU...], where each ID is "os" or a 0-indexed lun. Allowed values: Standard_LRS, Premium_LRS, StandardSSD_LRS, UltraSSD_LRS.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings ClearStorageSku(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageSkuInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmssCreateSettings.StorageSku"/>.</em></p><p>The SKU of the storage account with which to persist VM. Use a singular sku that would be applied across all disks, or specify individual disks. Usage: [--storage-sku SKU | --storage-sku ID=SKU ID=SKU ID=SKU...], where each ID is "os" or a 0-indexed lun. Allowed values: Standard_LRS, Premium_LRS, StandardSSD_LRS, UltraSSD_LRS.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings RemoveStorageSku(this AzureVmssCreateSettings toolSettings, params string[] storageSku)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(storageSku);
            toolSettings.StorageSkuInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmssCreateSettings.StorageSku"/>.</em></p><p>The SKU of the storage account with which to persist VM. Use a singular sku that would be applied across all disks, or specify individual disks. Usage: [--storage-sku SKU | --storage-sku ID=SKU ID=SKU ID=SKU...], where each ID is "os" or a 0-indexed lun. Allowed values: Standard_LRS, Premium_LRS, StandardSSD_LRS, UltraSSD_LRS.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings RemoveStorageSku(this AzureVmssCreateSettings toolSettings, IEnumerable<string> storageSku)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(storageSku);
            toolSettings.StorageSkuInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region UltraSsdEnabled
        /// <summary><p><em>Sets <see cref="AzureVmssCreateSettings.UltraSsdEnabled"/>.</em></p><p>(PREVIEW) Enables or disables the capability to have 1 or more managed data disks with UltraSSD_LRS storage account.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings SetUltraSsdEnabled(this AzureVmssCreateSettings toolSettings, bool? ultraSsdEnabled)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UltraSsdEnabled = ultraSsdEnabled;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssCreateSettings.UltraSsdEnabled"/>.</em></p><p>(PREVIEW) Enables or disables the capability to have 1 or more managed data disks with UltraSSD_LRS storage account.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings ResetUltraSsdEnabled(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UltraSsdEnabled = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureVmssCreateSettings.UltraSsdEnabled"/>.</em></p><p>(PREVIEW) Enables or disables the capability to have 1 or more managed data disks with UltraSSD_LRS storage account.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings EnableUltraSsdEnabled(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UltraSsdEnabled = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureVmssCreateSettings.UltraSsdEnabled"/>.</em></p><p>(PREVIEW) Enables or disables the capability to have 1 or more managed data disks with UltraSSD_LRS storage account.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings DisableUltraSsdEnabled(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UltraSsdEnabled = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureVmssCreateSettings.UltraSsdEnabled"/>.</em></p><p>(PREVIEW) Enables or disables the capability to have 1 or more managed data disks with UltraSSD_LRS storage account.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings ToggleUltraSsdEnabled(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UltraSsdEnabled = !toolSettings.UltraSsdEnabled;
            return toolSettings;
        }
        #endregion
        #region UseUnmanagedDisk
        /// <summary><p><em>Sets <see cref="AzureVmssCreateSettings.UseUnmanagedDisk"/>.</em></p><p>Do not use managed disk to persist VM.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings SetUseUnmanagedDisk(this AzureVmssCreateSettings toolSettings, string useUnmanagedDisk)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UseUnmanagedDisk = useUnmanagedDisk;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssCreateSettings.UseUnmanagedDisk"/>.</em></p><p>Do not use managed disk to persist VM.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings ResetUseUnmanagedDisk(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UseUnmanagedDisk = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureVmssCreateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings SetSubscription(this AzureVmssCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssCreateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings ResetSubscription(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmssCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings SetDebug(this AzureVmssCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings ResetDebug(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmssCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings SetHelp(this AzureVmssCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings ResetHelp(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmssCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings SetOutput(this AzureVmssCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings ResetOutput(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmssCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings SetQuery(this AzureVmssCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings ResetQuery(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmssCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings SetVerbose(this AzureVmssCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssCreateSettings ResetVerbose(this AzureVmssCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmssDeallocateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmssDeallocateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmssDeallocateSettings.Name"/>.</em></p><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssDeallocateSettings SetName(this AzureVmssDeallocateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssDeallocateSettings.Name"/>.</em></p><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssDeallocateSettings ResetName(this AzureVmssDeallocateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmssDeallocateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssDeallocateSettings SetResourceGroup(this AzureVmssDeallocateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssDeallocateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssDeallocateSettings ResetResourceGroup(this AzureVmssDeallocateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region InstanceIds
        /// <summary><p><em>Sets <see cref="AzureVmssDeallocateSettings.InstanceIds"/> to a new list.</em></p><p>Space-separated list of IDs (ex: 1 2 3 ...) or * for all instances. If not provided, the action will be applied on the scaleset itself.</p></summary>
        [Pure]
        public static AzureVmssDeallocateSettings SetInstanceIds(this AzureVmssDeallocateSettings toolSettings, params string[] instanceIds)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InstanceIdsInternal = instanceIds.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureVmssDeallocateSettings.InstanceIds"/> to a new list.</em></p><p>Space-separated list of IDs (ex: 1 2 3 ...) or * for all instances. If not provided, the action will be applied on the scaleset itself.</p></summary>
        [Pure]
        public static AzureVmssDeallocateSettings SetInstanceIds(this AzureVmssDeallocateSettings toolSettings, IEnumerable<string> instanceIds)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InstanceIdsInternal = instanceIds.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmssDeallocateSettings.InstanceIds"/>.</em></p><p>Space-separated list of IDs (ex: 1 2 3 ...) or * for all instances. If not provided, the action will be applied on the scaleset itself.</p></summary>
        [Pure]
        public static AzureVmssDeallocateSettings AddInstanceIds(this AzureVmssDeallocateSettings toolSettings, params string[] instanceIds)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InstanceIdsInternal.AddRange(instanceIds);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmssDeallocateSettings.InstanceIds"/>.</em></p><p>Space-separated list of IDs (ex: 1 2 3 ...) or * for all instances. If not provided, the action will be applied on the scaleset itself.</p></summary>
        [Pure]
        public static AzureVmssDeallocateSettings AddInstanceIds(this AzureVmssDeallocateSettings toolSettings, IEnumerable<string> instanceIds)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InstanceIdsInternal.AddRange(instanceIds);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureVmssDeallocateSettings.InstanceIds"/>.</em></p><p>Space-separated list of IDs (ex: 1 2 3 ...) or * for all instances. If not provided, the action will be applied on the scaleset itself.</p></summary>
        [Pure]
        public static AzureVmssDeallocateSettings ClearInstanceIds(this AzureVmssDeallocateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InstanceIdsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmssDeallocateSettings.InstanceIds"/>.</em></p><p>Space-separated list of IDs (ex: 1 2 3 ...) or * for all instances. If not provided, the action will be applied on the scaleset itself.</p></summary>
        [Pure]
        public static AzureVmssDeallocateSettings RemoveInstanceIds(this AzureVmssDeallocateSettings toolSettings, params string[] instanceIds)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(instanceIds);
            toolSettings.InstanceIdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmssDeallocateSettings.InstanceIds"/>.</em></p><p>Space-separated list of IDs (ex: 1 2 3 ...) or * for all instances. If not provided, the action will be applied on the scaleset itself.</p></summary>
        [Pure]
        public static AzureVmssDeallocateSettings RemoveInstanceIds(this AzureVmssDeallocateSettings toolSettings, IEnumerable<string> instanceIds)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(instanceIds);
            toolSettings.InstanceIdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary><p><em>Sets <see cref="AzureVmssDeallocateSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmssDeallocateSettings SetNoWait(this AzureVmssDeallocateSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssDeallocateSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmssDeallocateSettings ResetNoWait(this AzureVmssDeallocateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureVmssDeallocateSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmssDeallocateSettings EnableNoWait(this AzureVmssDeallocateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureVmssDeallocateSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmssDeallocateSettings DisableNoWait(this AzureVmssDeallocateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureVmssDeallocateSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmssDeallocateSettings ToggleNoWait(this AzureVmssDeallocateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureVmssDeallocateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssDeallocateSettings SetSubscription(this AzureVmssDeallocateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssDeallocateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssDeallocateSettings ResetSubscription(this AzureVmssDeallocateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmssDeallocateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssDeallocateSettings SetDebug(this AzureVmssDeallocateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssDeallocateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssDeallocateSettings ResetDebug(this AzureVmssDeallocateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmssDeallocateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssDeallocateSettings SetHelp(this AzureVmssDeallocateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssDeallocateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssDeallocateSettings ResetHelp(this AzureVmssDeallocateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmssDeallocateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssDeallocateSettings SetOutput(this AzureVmssDeallocateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssDeallocateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssDeallocateSettings ResetOutput(this AzureVmssDeallocateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmssDeallocateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssDeallocateSettings SetQuery(this AzureVmssDeallocateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssDeallocateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssDeallocateSettings ResetQuery(this AzureVmssDeallocateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmssDeallocateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssDeallocateSettings SetVerbose(this AzureVmssDeallocateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssDeallocateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssDeallocateSettings ResetVerbose(this AzureVmssDeallocateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmssDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmssDeleteSettingsExtensions
    {
        #region NoWait
        /// <summary><p><em>Sets <see cref="AzureVmssDeleteSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmssDeleteSettings SetNoWait(this AzureVmssDeleteSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssDeleteSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmssDeleteSettings ResetNoWait(this AzureVmssDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureVmssDeleteSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmssDeleteSettings EnableNoWait(this AzureVmssDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureVmssDeleteSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmssDeleteSettings DisableNoWait(this AzureVmssDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureVmssDeleteSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmssDeleteSettings ToggleNoWait(this AzureVmssDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary><p><em>Sets <see cref="AzureVmssDeleteSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssDeleteSettings SetIds(this AzureVmssDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureVmssDeleteSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssDeleteSettings SetIds(this AzureVmssDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmssDeleteSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssDeleteSettings AddIds(this AzureVmssDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmssDeleteSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssDeleteSettings AddIds(this AzureVmssDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureVmssDeleteSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssDeleteSettings ClearIds(this AzureVmssDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmssDeleteSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssDeleteSettings RemoveIds(this AzureVmssDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmssDeleteSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssDeleteSettings RemoveIds(this AzureVmssDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmssDeleteSettings.Name"/>.</em></p><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssDeleteSettings SetName(this AzureVmssDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssDeleteSettings.Name"/>.</em></p><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssDeleteSettings ResetName(this AzureVmssDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmssDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssDeleteSettings SetResourceGroup(this AzureVmssDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssDeleteSettings ResetResourceGroup(this AzureVmssDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureVmssDeleteSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssDeleteSettings SetSubscription(this AzureVmssDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssDeleteSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssDeleteSettings ResetSubscription(this AzureVmssDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmssDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssDeleteSettings SetDebug(this AzureVmssDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssDeleteSettings ResetDebug(this AzureVmssDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmssDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssDeleteSettings SetHelp(this AzureVmssDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssDeleteSettings ResetHelp(this AzureVmssDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmssDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssDeleteSettings SetOutput(this AzureVmssDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssDeleteSettings ResetOutput(this AzureVmssDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmssDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssDeleteSettings SetQuery(this AzureVmssDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssDeleteSettings ResetQuery(this AzureVmssDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmssDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssDeleteSettings SetVerbose(this AzureVmssDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssDeleteSettings ResetVerbose(this AzureVmssDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmssDeleteInstancesSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmssDeleteInstancesSettingsExtensions
    {
        #region InstanceIds
        /// <summary><p><em>Sets <see cref="AzureVmssDeleteInstancesSettings.InstanceIds"/> to a new list.</em></p><p>Space-separated list of IDs (ex: 1 2 3 ...) or * for all instances.</p></summary>
        [Pure]
        public static AzureVmssDeleteInstancesSettings SetInstanceIds(this AzureVmssDeleteInstancesSettings toolSettings, params string[] instanceIds)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InstanceIdsInternal = instanceIds.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureVmssDeleteInstancesSettings.InstanceIds"/> to a new list.</em></p><p>Space-separated list of IDs (ex: 1 2 3 ...) or * for all instances.</p></summary>
        [Pure]
        public static AzureVmssDeleteInstancesSettings SetInstanceIds(this AzureVmssDeleteInstancesSettings toolSettings, IEnumerable<string> instanceIds)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InstanceIdsInternal = instanceIds.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmssDeleteInstancesSettings.InstanceIds"/>.</em></p><p>Space-separated list of IDs (ex: 1 2 3 ...) or * for all instances.</p></summary>
        [Pure]
        public static AzureVmssDeleteInstancesSettings AddInstanceIds(this AzureVmssDeleteInstancesSettings toolSettings, params string[] instanceIds)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InstanceIdsInternal.AddRange(instanceIds);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmssDeleteInstancesSettings.InstanceIds"/>.</em></p><p>Space-separated list of IDs (ex: 1 2 3 ...) or * for all instances.</p></summary>
        [Pure]
        public static AzureVmssDeleteInstancesSettings AddInstanceIds(this AzureVmssDeleteInstancesSettings toolSettings, IEnumerable<string> instanceIds)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InstanceIdsInternal.AddRange(instanceIds);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureVmssDeleteInstancesSettings.InstanceIds"/>.</em></p><p>Space-separated list of IDs (ex: 1 2 3 ...) or * for all instances.</p></summary>
        [Pure]
        public static AzureVmssDeleteInstancesSettings ClearInstanceIds(this AzureVmssDeleteInstancesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InstanceIdsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmssDeleteInstancesSettings.InstanceIds"/>.</em></p><p>Space-separated list of IDs (ex: 1 2 3 ...) or * for all instances.</p></summary>
        [Pure]
        public static AzureVmssDeleteInstancesSettings RemoveInstanceIds(this AzureVmssDeleteInstancesSettings toolSettings, params string[] instanceIds)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(instanceIds);
            toolSettings.InstanceIdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmssDeleteInstancesSettings.InstanceIds"/>.</em></p><p>Space-separated list of IDs (ex: 1 2 3 ...) or * for all instances.</p></summary>
        [Pure]
        public static AzureVmssDeleteInstancesSettings RemoveInstanceIds(this AzureVmssDeleteInstancesSettings toolSettings, IEnumerable<string> instanceIds)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(instanceIds);
            toolSettings.InstanceIdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmssDeleteInstancesSettings.Name"/>.</em></p><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssDeleteInstancesSettings SetName(this AzureVmssDeleteInstancesSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssDeleteInstancesSettings.Name"/>.</em></p><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssDeleteInstancesSettings ResetName(this AzureVmssDeleteInstancesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmssDeleteInstancesSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssDeleteInstancesSettings SetResourceGroup(this AzureVmssDeleteInstancesSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssDeleteInstancesSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssDeleteInstancesSettings ResetResourceGroup(this AzureVmssDeleteInstancesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary><p><em>Sets <see cref="AzureVmssDeleteInstancesSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmssDeleteInstancesSettings SetNoWait(this AzureVmssDeleteInstancesSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssDeleteInstancesSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmssDeleteInstancesSettings ResetNoWait(this AzureVmssDeleteInstancesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureVmssDeleteInstancesSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmssDeleteInstancesSettings EnableNoWait(this AzureVmssDeleteInstancesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureVmssDeleteInstancesSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmssDeleteInstancesSettings DisableNoWait(this AzureVmssDeleteInstancesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureVmssDeleteInstancesSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmssDeleteInstancesSettings ToggleNoWait(this AzureVmssDeleteInstancesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureVmssDeleteInstancesSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssDeleteInstancesSettings SetSubscription(this AzureVmssDeleteInstancesSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssDeleteInstancesSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssDeleteInstancesSettings ResetSubscription(this AzureVmssDeleteInstancesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmssDeleteInstancesSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssDeleteInstancesSettings SetDebug(this AzureVmssDeleteInstancesSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssDeleteInstancesSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssDeleteInstancesSettings ResetDebug(this AzureVmssDeleteInstancesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmssDeleteInstancesSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssDeleteInstancesSettings SetHelp(this AzureVmssDeleteInstancesSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssDeleteInstancesSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssDeleteInstancesSettings ResetHelp(this AzureVmssDeleteInstancesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmssDeleteInstancesSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssDeleteInstancesSettings SetOutput(this AzureVmssDeleteInstancesSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssDeleteInstancesSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssDeleteInstancesSettings ResetOutput(this AzureVmssDeleteInstancesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmssDeleteInstancesSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssDeleteInstancesSettings SetQuery(this AzureVmssDeleteInstancesSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssDeleteInstancesSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssDeleteInstancesSettings ResetQuery(this AzureVmssDeleteInstancesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmssDeleteInstancesSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssDeleteInstancesSettings SetVerbose(this AzureVmssDeleteInstancesSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssDeleteInstancesSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssDeleteInstancesSettings ResetVerbose(this AzureVmssDeleteInstancesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmssGetInstanceViewSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmssGetInstanceViewSettingsExtensions
    {
        #region Ids
        /// <summary><p><em>Sets <see cref="AzureVmssGetInstanceViewSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssGetInstanceViewSettings SetIds(this AzureVmssGetInstanceViewSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureVmssGetInstanceViewSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssGetInstanceViewSettings SetIds(this AzureVmssGetInstanceViewSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmssGetInstanceViewSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssGetInstanceViewSettings AddIds(this AzureVmssGetInstanceViewSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmssGetInstanceViewSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssGetInstanceViewSettings AddIds(this AzureVmssGetInstanceViewSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureVmssGetInstanceViewSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssGetInstanceViewSettings ClearIds(this AzureVmssGetInstanceViewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmssGetInstanceViewSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssGetInstanceViewSettings RemoveIds(this AzureVmssGetInstanceViewSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmssGetInstanceViewSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssGetInstanceViewSettings RemoveIds(this AzureVmssGetInstanceViewSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region InstanceId
        /// <summary><p><em>Sets <see cref="AzureVmssGetInstanceViewSettings.InstanceId"/>.</em></p><p>A VM instance ID or "*" to list instance view for all VMs in a scale set.</p></summary>
        [Pure]
        public static AzureVmssGetInstanceViewSettings SetInstanceId(this AzureVmssGetInstanceViewSettings toolSettings, string instanceId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InstanceId = instanceId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssGetInstanceViewSettings.InstanceId"/>.</em></p><p>A VM instance ID or "*" to list instance view for all VMs in a scale set.</p></summary>
        [Pure]
        public static AzureVmssGetInstanceViewSettings ResetInstanceId(this AzureVmssGetInstanceViewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InstanceId = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmssGetInstanceViewSettings.Name"/>.</em></p><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssGetInstanceViewSettings SetName(this AzureVmssGetInstanceViewSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssGetInstanceViewSettings.Name"/>.</em></p><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssGetInstanceViewSettings ResetName(this AzureVmssGetInstanceViewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmssGetInstanceViewSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssGetInstanceViewSettings SetResourceGroup(this AzureVmssGetInstanceViewSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssGetInstanceViewSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssGetInstanceViewSettings ResetResourceGroup(this AzureVmssGetInstanceViewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureVmssGetInstanceViewSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssGetInstanceViewSettings SetSubscription(this AzureVmssGetInstanceViewSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssGetInstanceViewSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssGetInstanceViewSettings ResetSubscription(this AzureVmssGetInstanceViewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmssGetInstanceViewSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssGetInstanceViewSettings SetDebug(this AzureVmssGetInstanceViewSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssGetInstanceViewSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssGetInstanceViewSettings ResetDebug(this AzureVmssGetInstanceViewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmssGetInstanceViewSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssGetInstanceViewSettings SetHelp(this AzureVmssGetInstanceViewSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssGetInstanceViewSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssGetInstanceViewSettings ResetHelp(this AzureVmssGetInstanceViewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmssGetInstanceViewSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssGetInstanceViewSettings SetOutput(this AzureVmssGetInstanceViewSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssGetInstanceViewSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssGetInstanceViewSettings ResetOutput(this AzureVmssGetInstanceViewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmssGetInstanceViewSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssGetInstanceViewSettings SetQuery(this AzureVmssGetInstanceViewSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssGetInstanceViewSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssGetInstanceViewSettings ResetQuery(this AzureVmssGetInstanceViewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmssGetInstanceViewSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssGetInstanceViewSettings SetVerbose(this AzureVmssGetInstanceViewSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssGetInstanceViewSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssGetInstanceViewSettings ResetVerbose(this AzureVmssGetInstanceViewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmssGetOsUpgradeHistorySettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmssGetOsUpgradeHistorySettingsExtensions
    {
        #region Ids
        /// <summary><p><em>Sets <see cref="AzureVmssGetOsUpgradeHistorySettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssGetOsUpgradeHistorySettings SetIds(this AzureVmssGetOsUpgradeHistorySettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureVmssGetOsUpgradeHistorySettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssGetOsUpgradeHistorySettings SetIds(this AzureVmssGetOsUpgradeHistorySettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmssGetOsUpgradeHistorySettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssGetOsUpgradeHistorySettings AddIds(this AzureVmssGetOsUpgradeHistorySettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmssGetOsUpgradeHistorySettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssGetOsUpgradeHistorySettings AddIds(this AzureVmssGetOsUpgradeHistorySettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureVmssGetOsUpgradeHistorySettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssGetOsUpgradeHistorySettings ClearIds(this AzureVmssGetOsUpgradeHistorySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmssGetOsUpgradeHistorySettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssGetOsUpgradeHistorySettings RemoveIds(this AzureVmssGetOsUpgradeHistorySettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmssGetOsUpgradeHistorySettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssGetOsUpgradeHistorySettings RemoveIds(this AzureVmssGetOsUpgradeHistorySettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmssGetOsUpgradeHistorySettings.Name"/>.</em></p><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssGetOsUpgradeHistorySettings SetName(this AzureVmssGetOsUpgradeHistorySettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssGetOsUpgradeHistorySettings.Name"/>.</em></p><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssGetOsUpgradeHistorySettings ResetName(this AzureVmssGetOsUpgradeHistorySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmssGetOsUpgradeHistorySettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssGetOsUpgradeHistorySettings SetResourceGroup(this AzureVmssGetOsUpgradeHistorySettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssGetOsUpgradeHistorySettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssGetOsUpgradeHistorySettings ResetResourceGroup(this AzureVmssGetOsUpgradeHistorySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureVmssGetOsUpgradeHistorySettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssGetOsUpgradeHistorySettings SetSubscription(this AzureVmssGetOsUpgradeHistorySettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssGetOsUpgradeHistorySettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssGetOsUpgradeHistorySettings ResetSubscription(this AzureVmssGetOsUpgradeHistorySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmssGetOsUpgradeHistorySettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssGetOsUpgradeHistorySettings SetDebug(this AzureVmssGetOsUpgradeHistorySettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssGetOsUpgradeHistorySettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssGetOsUpgradeHistorySettings ResetDebug(this AzureVmssGetOsUpgradeHistorySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmssGetOsUpgradeHistorySettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssGetOsUpgradeHistorySettings SetHelp(this AzureVmssGetOsUpgradeHistorySettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssGetOsUpgradeHistorySettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssGetOsUpgradeHistorySettings ResetHelp(this AzureVmssGetOsUpgradeHistorySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmssGetOsUpgradeHistorySettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssGetOsUpgradeHistorySettings SetOutput(this AzureVmssGetOsUpgradeHistorySettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssGetOsUpgradeHistorySettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssGetOsUpgradeHistorySettings ResetOutput(this AzureVmssGetOsUpgradeHistorySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmssGetOsUpgradeHistorySettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssGetOsUpgradeHistorySettings SetQuery(this AzureVmssGetOsUpgradeHistorySettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssGetOsUpgradeHistorySettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssGetOsUpgradeHistorySettings ResetQuery(this AzureVmssGetOsUpgradeHistorySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmssGetOsUpgradeHistorySettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssGetOsUpgradeHistorySettings SetVerbose(this AzureVmssGetOsUpgradeHistorySettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssGetOsUpgradeHistorySettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssGetOsUpgradeHistorySettings ResetVerbose(this AzureVmssGetOsUpgradeHistorySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmssListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmssListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmssListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssListSettings SetResourceGroup(this AzureVmssListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssListSettings ResetResourceGroup(this AzureVmssListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureVmssListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssListSettings SetSubscription(this AzureVmssListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssListSettings ResetSubscription(this AzureVmssListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmssListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssListSettings SetDebug(this AzureVmssListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssListSettings ResetDebug(this AzureVmssListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmssListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssListSettings SetHelp(this AzureVmssListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssListSettings ResetHelp(this AzureVmssListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmssListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssListSettings SetOutput(this AzureVmssListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssListSettings ResetOutput(this AzureVmssListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmssListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssListSettings SetQuery(this AzureVmssListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssListSettings ResetQuery(this AzureVmssListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmssListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssListSettings SetVerbose(this AzureVmssListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssListSettings ResetVerbose(this AzureVmssListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmssListInstanceConnectionInfoSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmssListInstanceConnectionInfoSettingsExtensions
    {
        #region Ids
        /// <summary><p><em>Sets <see cref="AzureVmssListInstanceConnectionInfoSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssListInstanceConnectionInfoSettings SetIds(this AzureVmssListInstanceConnectionInfoSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureVmssListInstanceConnectionInfoSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssListInstanceConnectionInfoSettings SetIds(this AzureVmssListInstanceConnectionInfoSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmssListInstanceConnectionInfoSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssListInstanceConnectionInfoSettings AddIds(this AzureVmssListInstanceConnectionInfoSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmssListInstanceConnectionInfoSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssListInstanceConnectionInfoSettings AddIds(this AzureVmssListInstanceConnectionInfoSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureVmssListInstanceConnectionInfoSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssListInstanceConnectionInfoSettings ClearIds(this AzureVmssListInstanceConnectionInfoSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmssListInstanceConnectionInfoSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssListInstanceConnectionInfoSettings RemoveIds(this AzureVmssListInstanceConnectionInfoSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmssListInstanceConnectionInfoSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssListInstanceConnectionInfoSettings RemoveIds(this AzureVmssListInstanceConnectionInfoSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmssListInstanceConnectionInfoSettings.Name"/>.</em></p><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssListInstanceConnectionInfoSettings SetName(this AzureVmssListInstanceConnectionInfoSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssListInstanceConnectionInfoSettings.Name"/>.</em></p><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssListInstanceConnectionInfoSettings ResetName(this AzureVmssListInstanceConnectionInfoSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmssListInstanceConnectionInfoSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssListInstanceConnectionInfoSettings SetResourceGroup(this AzureVmssListInstanceConnectionInfoSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssListInstanceConnectionInfoSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssListInstanceConnectionInfoSettings ResetResourceGroup(this AzureVmssListInstanceConnectionInfoSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureVmssListInstanceConnectionInfoSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssListInstanceConnectionInfoSettings SetSubscription(this AzureVmssListInstanceConnectionInfoSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssListInstanceConnectionInfoSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssListInstanceConnectionInfoSettings ResetSubscription(this AzureVmssListInstanceConnectionInfoSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmssListInstanceConnectionInfoSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssListInstanceConnectionInfoSettings SetDebug(this AzureVmssListInstanceConnectionInfoSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssListInstanceConnectionInfoSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssListInstanceConnectionInfoSettings ResetDebug(this AzureVmssListInstanceConnectionInfoSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmssListInstanceConnectionInfoSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssListInstanceConnectionInfoSettings SetHelp(this AzureVmssListInstanceConnectionInfoSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssListInstanceConnectionInfoSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssListInstanceConnectionInfoSettings ResetHelp(this AzureVmssListInstanceConnectionInfoSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmssListInstanceConnectionInfoSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssListInstanceConnectionInfoSettings SetOutput(this AzureVmssListInstanceConnectionInfoSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssListInstanceConnectionInfoSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssListInstanceConnectionInfoSettings ResetOutput(this AzureVmssListInstanceConnectionInfoSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmssListInstanceConnectionInfoSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssListInstanceConnectionInfoSettings SetQuery(this AzureVmssListInstanceConnectionInfoSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssListInstanceConnectionInfoSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssListInstanceConnectionInfoSettings ResetQuery(this AzureVmssListInstanceConnectionInfoSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmssListInstanceConnectionInfoSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssListInstanceConnectionInfoSettings SetVerbose(this AzureVmssListInstanceConnectionInfoSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssListInstanceConnectionInfoSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssListInstanceConnectionInfoSettings ResetVerbose(this AzureVmssListInstanceConnectionInfoSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmssListInstancePublicIpsSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmssListInstancePublicIpsSettingsExtensions
    {
        #region Ids
        /// <summary><p><em>Sets <see cref="AzureVmssListInstancePublicIpsSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssListInstancePublicIpsSettings SetIds(this AzureVmssListInstancePublicIpsSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureVmssListInstancePublicIpsSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssListInstancePublicIpsSettings SetIds(this AzureVmssListInstancePublicIpsSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmssListInstancePublicIpsSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssListInstancePublicIpsSettings AddIds(this AzureVmssListInstancePublicIpsSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmssListInstancePublicIpsSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssListInstancePublicIpsSettings AddIds(this AzureVmssListInstancePublicIpsSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureVmssListInstancePublicIpsSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssListInstancePublicIpsSettings ClearIds(this AzureVmssListInstancePublicIpsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmssListInstancePublicIpsSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssListInstancePublicIpsSettings RemoveIds(this AzureVmssListInstancePublicIpsSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmssListInstancePublicIpsSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssListInstancePublicIpsSettings RemoveIds(this AzureVmssListInstancePublicIpsSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmssListInstancePublicIpsSettings.Name"/>.</em></p><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssListInstancePublicIpsSettings SetName(this AzureVmssListInstancePublicIpsSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssListInstancePublicIpsSettings.Name"/>.</em></p><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssListInstancePublicIpsSettings ResetName(this AzureVmssListInstancePublicIpsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmssListInstancePublicIpsSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssListInstancePublicIpsSettings SetResourceGroup(this AzureVmssListInstancePublicIpsSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssListInstancePublicIpsSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssListInstancePublicIpsSettings ResetResourceGroup(this AzureVmssListInstancePublicIpsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureVmssListInstancePublicIpsSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssListInstancePublicIpsSettings SetSubscription(this AzureVmssListInstancePublicIpsSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssListInstancePublicIpsSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssListInstancePublicIpsSettings ResetSubscription(this AzureVmssListInstancePublicIpsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmssListInstancePublicIpsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssListInstancePublicIpsSettings SetDebug(this AzureVmssListInstancePublicIpsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssListInstancePublicIpsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssListInstancePublicIpsSettings ResetDebug(this AzureVmssListInstancePublicIpsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmssListInstancePublicIpsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssListInstancePublicIpsSettings SetHelp(this AzureVmssListInstancePublicIpsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssListInstancePublicIpsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssListInstancePublicIpsSettings ResetHelp(this AzureVmssListInstancePublicIpsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmssListInstancePublicIpsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssListInstancePublicIpsSettings SetOutput(this AzureVmssListInstancePublicIpsSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssListInstancePublicIpsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssListInstancePublicIpsSettings ResetOutput(this AzureVmssListInstancePublicIpsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmssListInstancePublicIpsSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssListInstancePublicIpsSettings SetQuery(this AzureVmssListInstancePublicIpsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssListInstancePublicIpsSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssListInstancePublicIpsSettings ResetQuery(this AzureVmssListInstancePublicIpsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmssListInstancePublicIpsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssListInstancePublicIpsSettings SetVerbose(this AzureVmssListInstancePublicIpsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssListInstancePublicIpsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssListInstancePublicIpsSettings ResetVerbose(this AzureVmssListInstancePublicIpsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmssListInstancesSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmssListInstancesSettingsExtensions
    {
        #region Expand
        /// <summary><p><em>Sets <see cref="AzureVmssListInstancesSettings.Expand"/>.</em></p><p>The expand expression to apply to the operation.</p></summary>
        [Pure]
        public static AzureVmssListInstancesSettings SetExpand(this AzureVmssListInstancesSettings toolSettings, string expand)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expand = expand;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssListInstancesSettings.Expand"/>.</em></p><p>The expand expression to apply to the operation.</p></summary>
        [Pure]
        public static AzureVmssListInstancesSettings ResetExpand(this AzureVmssListInstancesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expand = null;
            return toolSettings;
        }
        #endregion
        #region Filter
        /// <summary><p><em>Sets <see cref="AzureVmssListInstancesSettings.Filter"/>.</em></p><p>The filter to apply to the operation.</p></summary>
        [Pure]
        public static AzureVmssListInstancesSettings SetFilter(this AzureVmssListInstancesSettings toolSettings, string filter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = filter;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssListInstancesSettings.Filter"/>.</em></p><p>The filter to apply to the operation.</p></summary>
        [Pure]
        public static AzureVmssListInstancesSettings ResetFilter(this AzureVmssListInstancesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = null;
            return toolSettings;
        }
        #endregion
        #region Select
        /// <summary><p><em>Sets <see cref="AzureVmssListInstancesSettings.Select"/>.</em></p><p>The list parameters.</p></summary>
        [Pure]
        public static AzureVmssListInstancesSettings SetSelect(this AzureVmssListInstancesSettings toolSettings, string select)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Select = select;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssListInstancesSettings.Select"/>.</em></p><p>The list parameters.</p></summary>
        [Pure]
        public static AzureVmssListInstancesSettings ResetSelect(this AzureVmssListInstancesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Select = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary><p><em>Sets <see cref="AzureVmssListInstancesSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssListInstancesSettings SetIds(this AzureVmssListInstancesSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureVmssListInstancesSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssListInstancesSettings SetIds(this AzureVmssListInstancesSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmssListInstancesSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssListInstancesSettings AddIds(this AzureVmssListInstancesSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmssListInstancesSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssListInstancesSettings AddIds(this AzureVmssListInstancesSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureVmssListInstancesSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssListInstancesSettings ClearIds(this AzureVmssListInstancesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmssListInstancesSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssListInstancesSettings RemoveIds(this AzureVmssListInstancesSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmssListInstancesSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssListInstancesSettings RemoveIds(this AzureVmssListInstancesSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmssListInstancesSettings.Name"/>.</em></p><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssListInstancesSettings SetName(this AzureVmssListInstancesSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssListInstancesSettings.Name"/>.</em></p><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssListInstancesSettings ResetName(this AzureVmssListInstancesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmssListInstancesSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssListInstancesSettings SetResourceGroup(this AzureVmssListInstancesSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssListInstancesSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssListInstancesSettings ResetResourceGroup(this AzureVmssListInstancesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureVmssListInstancesSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssListInstancesSettings SetSubscription(this AzureVmssListInstancesSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssListInstancesSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssListInstancesSettings ResetSubscription(this AzureVmssListInstancesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmssListInstancesSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssListInstancesSettings SetDebug(this AzureVmssListInstancesSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssListInstancesSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssListInstancesSettings ResetDebug(this AzureVmssListInstancesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmssListInstancesSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssListInstancesSettings SetHelp(this AzureVmssListInstancesSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssListInstancesSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssListInstancesSettings ResetHelp(this AzureVmssListInstancesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmssListInstancesSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssListInstancesSettings SetOutput(this AzureVmssListInstancesSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssListInstancesSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssListInstancesSettings ResetOutput(this AzureVmssListInstancesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmssListInstancesSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssListInstancesSettings SetQuery(this AzureVmssListInstancesSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssListInstancesSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssListInstancesSettings ResetQuery(this AzureVmssListInstancesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmssListInstancesSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssListInstancesSettings SetVerbose(this AzureVmssListInstancesSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssListInstancesSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssListInstancesSettings ResetVerbose(this AzureVmssListInstancesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmssListSkusSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmssListSkusSettingsExtensions
    {
        #region Ids
        /// <summary><p><em>Sets <see cref="AzureVmssListSkusSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssListSkusSettings SetIds(this AzureVmssListSkusSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureVmssListSkusSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssListSkusSettings SetIds(this AzureVmssListSkusSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmssListSkusSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssListSkusSettings AddIds(this AzureVmssListSkusSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmssListSkusSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssListSkusSettings AddIds(this AzureVmssListSkusSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureVmssListSkusSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssListSkusSettings ClearIds(this AzureVmssListSkusSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmssListSkusSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssListSkusSettings RemoveIds(this AzureVmssListSkusSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmssListSkusSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssListSkusSettings RemoveIds(this AzureVmssListSkusSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmssListSkusSettings.Name"/>.</em></p><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssListSkusSettings SetName(this AzureVmssListSkusSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssListSkusSettings.Name"/>.</em></p><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssListSkusSettings ResetName(this AzureVmssListSkusSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmssListSkusSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssListSkusSettings SetResourceGroup(this AzureVmssListSkusSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssListSkusSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssListSkusSettings ResetResourceGroup(this AzureVmssListSkusSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureVmssListSkusSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssListSkusSettings SetSubscription(this AzureVmssListSkusSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssListSkusSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssListSkusSettings ResetSubscription(this AzureVmssListSkusSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmssListSkusSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssListSkusSettings SetDebug(this AzureVmssListSkusSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssListSkusSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssListSkusSettings ResetDebug(this AzureVmssListSkusSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmssListSkusSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssListSkusSettings SetHelp(this AzureVmssListSkusSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssListSkusSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssListSkusSettings ResetHelp(this AzureVmssListSkusSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmssListSkusSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssListSkusSettings SetOutput(this AzureVmssListSkusSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssListSkusSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssListSkusSettings ResetOutput(this AzureVmssListSkusSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmssListSkusSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssListSkusSettings SetQuery(this AzureVmssListSkusSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssListSkusSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssListSkusSettings ResetQuery(this AzureVmssListSkusSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmssListSkusSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssListSkusSettings SetVerbose(this AzureVmssListSkusSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssListSkusSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssListSkusSettings ResetVerbose(this AzureVmssListSkusSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmssPerformMaintenanceSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmssPerformMaintenanceSettingsExtensions
    {
        #region InstanceIds
        /// <summary><p><em>Sets <see cref="AzureVmssPerformMaintenanceSettings.InstanceIds"/> to a new list.</em></p><p>Space-separated list of IDs (ex: 1 2 3 ...) or * for all instances. If not provided, the action will be applied on the scaleset itself.</p></summary>
        [Pure]
        public static AzureVmssPerformMaintenanceSettings SetInstanceIds(this AzureVmssPerformMaintenanceSettings toolSettings, params string[] instanceIds)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InstanceIdsInternal = instanceIds.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureVmssPerformMaintenanceSettings.InstanceIds"/> to a new list.</em></p><p>Space-separated list of IDs (ex: 1 2 3 ...) or * for all instances. If not provided, the action will be applied on the scaleset itself.</p></summary>
        [Pure]
        public static AzureVmssPerformMaintenanceSettings SetInstanceIds(this AzureVmssPerformMaintenanceSettings toolSettings, IEnumerable<string> instanceIds)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InstanceIdsInternal = instanceIds.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmssPerformMaintenanceSettings.InstanceIds"/>.</em></p><p>Space-separated list of IDs (ex: 1 2 3 ...) or * for all instances. If not provided, the action will be applied on the scaleset itself.</p></summary>
        [Pure]
        public static AzureVmssPerformMaintenanceSettings AddInstanceIds(this AzureVmssPerformMaintenanceSettings toolSettings, params string[] instanceIds)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InstanceIdsInternal.AddRange(instanceIds);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmssPerformMaintenanceSettings.InstanceIds"/>.</em></p><p>Space-separated list of IDs (ex: 1 2 3 ...) or * for all instances. If not provided, the action will be applied on the scaleset itself.</p></summary>
        [Pure]
        public static AzureVmssPerformMaintenanceSettings AddInstanceIds(this AzureVmssPerformMaintenanceSettings toolSettings, IEnumerable<string> instanceIds)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InstanceIdsInternal.AddRange(instanceIds);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureVmssPerformMaintenanceSettings.InstanceIds"/>.</em></p><p>Space-separated list of IDs (ex: 1 2 3 ...) or * for all instances. If not provided, the action will be applied on the scaleset itself.</p></summary>
        [Pure]
        public static AzureVmssPerformMaintenanceSettings ClearInstanceIds(this AzureVmssPerformMaintenanceSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InstanceIdsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmssPerformMaintenanceSettings.InstanceIds"/>.</em></p><p>Space-separated list of IDs (ex: 1 2 3 ...) or * for all instances. If not provided, the action will be applied on the scaleset itself.</p></summary>
        [Pure]
        public static AzureVmssPerformMaintenanceSettings RemoveInstanceIds(this AzureVmssPerformMaintenanceSettings toolSettings, params string[] instanceIds)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(instanceIds);
            toolSettings.InstanceIdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmssPerformMaintenanceSettings.InstanceIds"/>.</em></p><p>Space-separated list of IDs (ex: 1 2 3 ...) or * for all instances. If not provided, the action will be applied on the scaleset itself.</p></summary>
        [Pure]
        public static AzureVmssPerformMaintenanceSettings RemoveInstanceIds(this AzureVmssPerformMaintenanceSettings toolSettings, IEnumerable<string> instanceIds)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(instanceIds);
            toolSettings.InstanceIdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary><p><em>Sets <see cref="AzureVmssPerformMaintenanceSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssPerformMaintenanceSettings SetIds(this AzureVmssPerformMaintenanceSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureVmssPerformMaintenanceSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssPerformMaintenanceSettings SetIds(this AzureVmssPerformMaintenanceSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmssPerformMaintenanceSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssPerformMaintenanceSettings AddIds(this AzureVmssPerformMaintenanceSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmssPerformMaintenanceSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssPerformMaintenanceSettings AddIds(this AzureVmssPerformMaintenanceSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureVmssPerformMaintenanceSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssPerformMaintenanceSettings ClearIds(this AzureVmssPerformMaintenanceSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmssPerformMaintenanceSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssPerformMaintenanceSettings RemoveIds(this AzureVmssPerformMaintenanceSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmssPerformMaintenanceSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssPerformMaintenanceSettings RemoveIds(this AzureVmssPerformMaintenanceSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmssPerformMaintenanceSettings.Name"/>.</em></p><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssPerformMaintenanceSettings SetName(this AzureVmssPerformMaintenanceSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssPerformMaintenanceSettings.Name"/>.</em></p><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssPerformMaintenanceSettings ResetName(this AzureVmssPerformMaintenanceSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmssPerformMaintenanceSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssPerformMaintenanceSettings SetResourceGroup(this AzureVmssPerformMaintenanceSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssPerformMaintenanceSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssPerformMaintenanceSettings ResetResourceGroup(this AzureVmssPerformMaintenanceSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureVmssPerformMaintenanceSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssPerformMaintenanceSettings SetSubscription(this AzureVmssPerformMaintenanceSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssPerformMaintenanceSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssPerformMaintenanceSettings ResetSubscription(this AzureVmssPerformMaintenanceSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmssPerformMaintenanceSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssPerformMaintenanceSettings SetDebug(this AzureVmssPerformMaintenanceSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssPerformMaintenanceSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssPerformMaintenanceSettings ResetDebug(this AzureVmssPerformMaintenanceSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmssPerformMaintenanceSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssPerformMaintenanceSettings SetHelp(this AzureVmssPerformMaintenanceSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssPerformMaintenanceSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssPerformMaintenanceSettings ResetHelp(this AzureVmssPerformMaintenanceSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmssPerformMaintenanceSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssPerformMaintenanceSettings SetOutput(this AzureVmssPerformMaintenanceSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssPerformMaintenanceSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssPerformMaintenanceSettings ResetOutput(this AzureVmssPerformMaintenanceSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmssPerformMaintenanceSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssPerformMaintenanceSettings SetQuery(this AzureVmssPerformMaintenanceSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssPerformMaintenanceSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssPerformMaintenanceSettings ResetQuery(this AzureVmssPerformMaintenanceSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmssPerformMaintenanceSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssPerformMaintenanceSettings SetVerbose(this AzureVmssPerformMaintenanceSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssPerformMaintenanceSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssPerformMaintenanceSettings ResetVerbose(this AzureVmssPerformMaintenanceSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmssReimageSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmssReimageSettingsExtensions
    {
        #region NoWait
        /// <summary><p><em>Sets <see cref="AzureVmssReimageSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmssReimageSettings SetNoWait(this AzureVmssReimageSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssReimageSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmssReimageSettings ResetNoWait(this AzureVmssReimageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureVmssReimageSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmssReimageSettings EnableNoWait(this AzureVmssReimageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureVmssReimageSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmssReimageSettings DisableNoWait(this AzureVmssReimageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureVmssReimageSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmssReimageSettings ToggleNoWait(this AzureVmssReimageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary><p><em>Sets <see cref="AzureVmssReimageSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssReimageSettings SetIds(this AzureVmssReimageSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureVmssReimageSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssReimageSettings SetIds(this AzureVmssReimageSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmssReimageSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssReimageSettings AddIds(this AzureVmssReimageSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmssReimageSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssReimageSettings AddIds(this AzureVmssReimageSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureVmssReimageSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssReimageSettings ClearIds(this AzureVmssReimageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmssReimageSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssReimageSettings RemoveIds(this AzureVmssReimageSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmssReimageSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssReimageSettings RemoveIds(this AzureVmssReimageSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region InstanceId
        /// <summary><p><em>Sets <see cref="AzureVmssReimageSettings.InstanceId"/>.</em></p><p>VM instance ID. If missing, reimage all instances.</p></summary>
        [Pure]
        public static AzureVmssReimageSettings SetInstanceId(this AzureVmssReimageSettings toolSettings, string instanceId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InstanceId = instanceId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssReimageSettings.InstanceId"/>.</em></p><p>VM instance ID. If missing, reimage all instances.</p></summary>
        [Pure]
        public static AzureVmssReimageSettings ResetInstanceId(this AzureVmssReimageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InstanceId = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmssReimageSettings.Name"/>.</em></p><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssReimageSettings SetName(this AzureVmssReimageSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssReimageSettings.Name"/>.</em></p><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssReimageSettings ResetName(this AzureVmssReimageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmssReimageSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssReimageSettings SetResourceGroup(this AzureVmssReimageSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssReimageSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssReimageSettings ResetResourceGroup(this AzureVmssReimageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureVmssReimageSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssReimageSettings SetSubscription(this AzureVmssReimageSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssReimageSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssReimageSettings ResetSubscription(this AzureVmssReimageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmssReimageSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssReimageSettings SetDebug(this AzureVmssReimageSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssReimageSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssReimageSettings ResetDebug(this AzureVmssReimageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmssReimageSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssReimageSettings SetHelp(this AzureVmssReimageSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssReimageSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssReimageSettings ResetHelp(this AzureVmssReimageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmssReimageSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssReimageSettings SetOutput(this AzureVmssReimageSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssReimageSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssReimageSettings ResetOutput(this AzureVmssReimageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmssReimageSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssReimageSettings SetQuery(this AzureVmssReimageSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssReimageSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssReimageSettings ResetQuery(this AzureVmssReimageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmssReimageSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssReimageSettings SetVerbose(this AzureVmssReimageSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssReimageSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssReimageSettings ResetVerbose(this AzureVmssReimageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmssRestartSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmssRestartSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmssRestartSettings.Name"/>.</em></p><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssRestartSettings SetName(this AzureVmssRestartSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssRestartSettings.Name"/>.</em></p><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssRestartSettings ResetName(this AzureVmssRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmssRestartSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssRestartSettings SetResourceGroup(this AzureVmssRestartSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssRestartSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssRestartSettings ResetResourceGroup(this AzureVmssRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region InstanceIds
        /// <summary><p><em>Sets <see cref="AzureVmssRestartSettings.InstanceIds"/> to a new list.</em></p><p>Space-separated list of IDs (ex: 1 2 3 ...) or * for all instances. If not provided, the action will be applied on the scaleset itself.</p></summary>
        [Pure]
        public static AzureVmssRestartSettings SetInstanceIds(this AzureVmssRestartSettings toolSettings, params string[] instanceIds)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InstanceIdsInternal = instanceIds.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureVmssRestartSettings.InstanceIds"/> to a new list.</em></p><p>Space-separated list of IDs (ex: 1 2 3 ...) or * for all instances. If not provided, the action will be applied on the scaleset itself.</p></summary>
        [Pure]
        public static AzureVmssRestartSettings SetInstanceIds(this AzureVmssRestartSettings toolSettings, IEnumerable<string> instanceIds)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InstanceIdsInternal = instanceIds.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmssRestartSettings.InstanceIds"/>.</em></p><p>Space-separated list of IDs (ex: 1 2 3 ...) or * for all instances. If not provided, the action will be applied on the scaleset itself.</p></summary>
        [Pure]
        public static AzureVmssRestartSettings AddInstanceIds(this AzureVmssRestartSettings toolSettings, params string[] instanceIds)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InstanceIdsInternal.AddRange(instanceIds);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmssRestartSettings.InstanceIds"/>.</em></p><p>Space-separated list of IDs (ex: 1 2 3 ...) or * for all instances. If not provided, the action will be applied on the scaleset itself.</p></summary>
        [Pure]
        public static AzureVmssRestartSettings AddInstanceIds(this AzureVmssRestartSettings toolSettings, IEnumerable<string> instanceIds)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InstanceIdsInternal.AddRange(instanceIds);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureVmssRestartSettings.InstanceIds"/>.</em></p><p>Space-separated list of IDs (ex: 1 2 3 ...) or * for all instances. If not provided, the action will be applied on the scaleset itself.</p></summary>
        [Pure]
        public static AzureVmssRestartSettings ClearInstanceIds(this AzureVmssRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InstanceIdsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmssRestartSettings.InstanceIds"/>.</em></p><p>Space-separated list of IDs (ex: 1 2 3 ...) or * for all instances. If not provided, the action will be applied on the scaleset itself.</p></summary>
        [Pure]
        public static AzureVmssRestartSettings RemoveInstanceIds(this AzureVmssRestartSettings toolSettings, params string[] instanceIds)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(instanceIds);
            toolSettings.InstanceIdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmssRestartSettings.InstanceIds"/>.</em></p><p>Space-separated list of IDs (ex: 1 2 3 ...) or * for all instances. If not provided, the action will be applied on the scaleset itself.</p></summary>
        [Pure]
        public static AzureVmssRestartSettings RemoveInstanceIds(this AzureVmssRestartSettings toolSettings, IEnumerable<string> instanceIds)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(instanceIds);
            toolSettings.InstanceIdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary><p><em>Sets <see cref="AzureVmssRestartSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmssRestartSettings SetNoWait(this AzureVmssRestartSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssRestartSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmssRestartSettings ResetNoWait(this AzureVmssRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureVmssRestartSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmssRestartSettings EnableNoWait(this AzureVmssRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureVmssRestartSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmssRestartSettings DisableNoWait(this AzureVmssRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureVmssRestartSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmssRestartSettings ToggleNoWait(this AzureVmssRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureVmssRestartSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssRestartSettings SetSubscription(this AzureVmssRestartSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssRestartSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssRestartSettings ResetSubscription(this AzureVmssRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmssRestartSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssRestartSettings SetDebug(this AzureVmssRestartSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssRestartSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssRestartSettings ResetDebug(this AzureVmssRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmssRestartSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssRestartSettings SetHelp(this AzureVmssRestartSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssRestartSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssRestartSettings ResetHelp(this AzureVmssRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmssRestartSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssRestartSettings SetOutput(this AzureVmssRestartSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssRestartSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssRestartSettings ResetOutput(this AzureVmssRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmssRestartSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssRestartSettings SetQuery(this AzureVmssRestartSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssRestartSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssRestartSettings ResetQuery(this AzureVmssRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmssRestartSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssRestartSettings SetVerbose(this AzureVmssRestartSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssRestartSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssRestartSettings ResetVerbose(this AzureVmssRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmssScaleSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmssScaleSettingsExtensions
    {
        #region NewCapacity
        /// <summary><p><em>Sets <see cref="AzureVmssScaleSettings.NewCapacity"/>.</em></p><p>Number of VMs in the VMSS.</p></summary>
        [Pure]
        public static AzureVmssScaleSettings SetNewCapacity(this AzureVmssScaleSettings toolSettings, int? newCapacity)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NewCapacity = newCapacity;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssScaleSettings.NewCapacity"/>.</em></p><p>Number of VMs in the VMSS.</p></summary>
        [Pure]
        public static AzureVmssScaleSettings ResetNewCapacity(this AzureVmssScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NewCapacity = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary><p><em>Sets <see cref="AzureVmssScaleSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmssScaleSettings SetNoWait(this AzureVmssScaleSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssScaleSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmssScaleSettings ResetNoWait(this AzureVmssScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureVmssScaleSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmssScaleSettings EnableNoWait(this AzureVmssScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureVmssScaleSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmssScaleSettings DisableNoWait(this AzureVmssScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureVmssScaleSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmssScaleSettings ToggleNoWait(this AzureVmssScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary><p><em>Sets <see cref="AzureVmssScaleSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssScaleSettings SetIds(this AzureVmssScaleSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureVmssScaleSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssScaleSettings SetIds(this AzureVmssScaleSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmssScaleSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssScaleSettings AddIds(this AzureVmssScaleSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmssScaleSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssScaleSettings AddIds(this AzureVmssScaleSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureVmssScaleSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssScaleSettings ClearIds(this AzureVmssScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmssScaleSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssScaleSettings RemoveIds(this AzureVmssScaleSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmssScaleSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssScaleSettings RemoveIds(this AzureVmssScaleSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmssScaleSettings.Name"/>.</em></p><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssScaleSettings SetName(this AzureVmssScaleSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssScaleSettings.Name"/>.</em></p><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssScaleSettings ResetName(this AzureVmssScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmssScaleSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssScaleSettings SetResourceGroup(this AzureVmssScaleSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssScaleSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssScaleSettings ResetResourceGroup(this AzureVmssScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureVmssScaleSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssScaleSettings SetSubscription(this AzureVmssScaleSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssScaleSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssScaleSettings ResetSubscription(this AzureVmssScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmssScaleSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssScaleSettings SetDebug(this AzureVmssScaleSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssScaleSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssScaleSettings ResetDebug(this AzureVmssScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmssScaleSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssScaleSettings SetHelp(this AzureVmssScaleSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssScaleSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssScaleSettings ResetHelp(this AzureVmssScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmssScaleSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssScaleSettings SetOutput(this AzureVmssScaleSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssScaleSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssScaleSettings ResetOutput(this AzureVmssScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmssScaleSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssScaleSettings SetQuery(this AzureVmssScaleSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssScaleSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssScaleSettings ResetQuery(this AzureVmssScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmssScaleSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssScaleSettings SetVerbose(this AzureVmssScaleSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssScaleSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssScaleSettings ResetVerbose(this AzureVmssScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmssShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmssShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmssShowSettings.Name"/>.</em></p><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssShowSettings SetName(this AzureVmssShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssShowSettings.Name"/>.</em></p><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssShowSettings ResetName(this AzureVmssShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmssShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssShowSettings SetResourceGroup(this AzureVmssShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssShowSettings ResetResourceGroup(this AzureVmssShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region InstanceId
        /// <summary><p><em>Sets <see cref="AzureVmssShowSettings.InstanceId"/>.</em></p><p>VM instance ID. If missing, show the VMSS.</p></summary>
        [Pure]
        public static AzureVmssShowSettings SetInstanceId(this AzureVmssShowSettings toolSettings, string instanceId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InstanceId = instanceId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssShowSettings.InstanceId"/>.</em></p><p>VM instance ID. If missing, show the VMSS.</p></summary>
        [Pure]
        public static AzureVmssShowSettings ResetInstanceId(this AzureVmssShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InstanceId = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureVmssShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssShowSettings SetSubscription(this AzureVmssShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssShowSettings ResetSubscription(this AzureVmssShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmssShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssShowSettings SetDebug(this AzureVmssShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssShowSettings ResetDebug(this AzureVmssShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmssShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssShowSettings SetHelp(this AzureVmssShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssShowSettings ResetHelp(this AzureVmssShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmssShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssShowSettings SetOutput(this AzureVmssShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssShowSettings ResetOutput(this AzureVmssShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmssShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssShowSettings SetQuery(this AzureVmssShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssShowSettings ResetQuery(this AzureVmssShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmssShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssShowSettings SetVerbose(this AzureVmssShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssShowSettings ResetVerbose(this AzureVmssShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmssStartSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmssStartSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmssStartSettings.Name"/>.</em></p><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssStartSettings SetName(this AzureVmssStartSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssStartSettings.Name"/>.</em></p><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssStartSettings ResetName(this AzureVmssStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmssStartSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssStartSettings SetResourceGroup(this AzureVmssStartSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssStartSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssStartSettings ResetResourceGroup(this AzureVmssStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region InstanceIds
        /// <summary><p><em>Sets <see cref="AzureVmssStartSettings.InstanceIds"/> to a new list.</em></p><p>Space-separated list of IDs (ex: 1 2 3 ...) or * for all instances. If not provided, the action will be applied on the scaleset itself.</p></summary>
        [Pure]
        public static AzureVmssStartSettings SetInstanceIds(this AzureVmssStartSettings toolSettings, params string[] instanceIds)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InstanceIdsInternal = instanceIds.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureVmssStartSettings.InstanceIds"/> to a new list.</em></p><p>Space-separated list of IDs (ex: 1 2 3 ...) or * for all instances. If not provided, the action will be applied on the scaleset itself.</p></summary>
        [Pure]
        public static AzureVmssStartSettings SetInstanceIds(this AzureVmssStartSettings toolSettings, IEnumerable<string> instanceIds)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InstanceIdsInternal = instanceIds.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmssStartSettings.InstanceIds"/>.</em></p><p>Space-separated list of IDs (ex: 1 2 3 ...) or * for all instances. If not provided, the action will be applied on the scaleset itself.</p></summary>
        [Pure]
        public static AzureVmssStartSettings AddInstanceIds(this AzureVmssStartSettings toolSettings, params string[] instanceIds)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InstanceIdsInternal.AddRange(instanceIds);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmssStartSettings.InstanceIds"/>.</em></p><p>Space-separated list of IDs (ex: 1 2 3 ...) or * for all instances. If not provided, the action will be applied on the scaleset itself.</p></summary>
        [Pure]
        public static AzureVmssStartSettings AddInstanceIds(this AzureVmssStartSettings toolSettings, IEnumerable<string> instanceIds)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InstanceIdsInternal.AddRange(instanceIds);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureVmssStartSettings.InstanceIds"/>.</em></p><p>Space-separated list of IDs (ex: 1 2 3 ...) or * for all instances. If not provided, the action will be applied on the scaleset itself.</p></summary>
        [Pure]
        public static AzureVmssStartSettings ClearInstanceIds(this AzureVmssStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InstanceIdsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmssStartSettings.InstanceIds"/>.</em></p><p>Space-separated list of IDs (ex: 1 2 3 ...) or * for all instances. If not provided, the action will be applied on the scaleset itself.</p></summary>
        [Pure]
        public static AzureVmssStartSettings RemoveInstanceIds(this AzureVmssStartSettings toolSettings, params string[] instanceIds)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(instanceIds);
            toolSettings.InstanceIdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmssStartSettings.InstanceIds"/>.</em></p><p>Space-separated list of IDs (ex: 1 2 3 ...) or * for all instances. If not provided, the action will be applied on the scaleset itself.</p></summary>
        [Pure]
        public static AzureVmssStartSettings RemoveInstanceIds(this AzureVmssStartSettings toolSettings, IEnumerable<string> instanceIds)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(instanceIds);
            toolSettings.InstanceIdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary><p><em>Sets <see cref="AzureVmssStartSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmssStartSettings SetNoWait(this AzureVmssStartSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssStartSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmssStartSettings ResetNoWait(this AzureVmssStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureVmssStartSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmssStartSettings EnableNoWait(this AzureVmssStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureVmssStartSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmssStartSettings DisableNoWait(this AzureVmssStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureVmssStartSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmssStartSettings ToggleNoWait(this AzureVmssStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureVmssStartSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssStartSettings SetSubscription(this AzureVmssStartSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssStartSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssStartSettings ResetSubscription(this AzureVmssStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmssStartSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssStartSettings SetDebug(this AzureVmssStartSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssStartSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssStartSettings ResetDebug(this AzureVmssStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmssStartSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssStartSettings SetHelp(this AzureVmssStartSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssStartSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssStartSettings ResetHelp(this AzureVmssStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmssStartSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssStartSettings SetOutput(this AzureVmssStartSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssStartSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssStartSettings ResetOutput(this AzureVmssStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmssStartSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssStartSettings SetQuery(this AzureVmssStartSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssStartSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssStartSettings ResetQuery(this AzureVmssStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmssStartSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssStartSettings SetVerbose(this AzureVmssStartSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssStartSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssStartSettings ResetVerbose(this AzureVmssStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmssStopSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmssStopSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmssStopSettings.Name"/>.</em></p><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssStopSettings SetName(this AzureVmssStopSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssStopSettings.Name"/>.</em></p><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssStopSettings ResetName(this AzureVmssStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmssStopSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssStopSettings SetResourceGroup(this AzureVmssStopSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssStopSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssStopSettings ResetResourceGroup(this AzureVmssStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region InstanceIds
        /// <summary><p><em>Sets <see cref="AzureVmssStopSettings.InstanceIds"/> to a new list.</em></p><p>Space-separated list of IDs (ex: 1 2 3 ...) or * for all instances. If not provided, the action will be applied on the scaleset itself.</p></summary>
        [Pure]
        public static AzureVmssStopSettings SetInstanceIds(this AzureVmssStopSettings toolSettings, params string[] instanceIds)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InstanceIdsInternal = instanceIds.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureVmssStopSettings.InstanceIds"/> to a new list.</em></p><p>Space-separated list of IDs (ex: 1 2 3 ...) or * for all instances. If not provided, the action will be applied on the scaleset itself.</p></summary>
        [Pure]
        public static AzureVmssStopSettings SetInstanceIds(this AzureVmssStopSettings toolSettings, IEnumerable<string> instanceIds)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InstanceIdsInternal = instanceIds.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmssStopSettings.InstanceIds"/>.</em></p><p>Space-separated list of IDs (ex: 1 2 3 ...) or * for all instances. If not provided, the action will be applied on the scaleset itself.</p></summary>
        [Pure]
        public static AzureVmssStopSettings AddInstanceIds(this AzureVmssStopSettings toolSettings, params string[] instanceIds)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InstanceIdsInternal.AddRange(instanceIds);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmssStopSettings.InstanceIds"/>.</em></p><p>Space-separated list of IDs (ex: 1 2 3 ...) or * for all instances. If not provided, the action will be applied on the scaleset itself.</p></summary>
        [Pure]
        public static AzureVmssStopSettings AddInstanceIds(this AzureVmssStopSettings toolSettings, IEnumerable<string> instanceIds)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InstanceIdsInternal.AddRange(instanceIds);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureVmssStopSettings.InstanceIds"/>.</em></p><p>Space-separated list of IDs (ex: 1 2 3 ...) or * for all instances. If not provided, the action will be applied on the scaleset itself.</p></summary>
        [Pure]
        public static AzureVmssStopSettings ClearInstanceIds(this AzureVmssStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InstanceIdsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmssStopSettings.InstanceIds"/>.</em></p><p>Space-separated list of IDs (ex: 1 2 3 ...) or * for all instances. If not provided, the action will be applied on the scaleset itself.</p></summary>
        [Pure]
        public static AzureVmssStopSettings RemoveInstanceIds(this AzureVmssStopSettings toolSettings, params string[] instanceIds)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(instanceIds);
            toolSettings.InstanceIdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmssStopSettings.InstanceIds"/>.</em></p><p>Space-separated list of IDs (ex: 1 2 3 ...) or * for all instances. If not provided, the action will be applied on the scaleset itself.</p></summary>
        [Pure]
        public static AzureVmssStopSettings RemoveInstanceIds(this AzureVmssStopSettings toolSettings, IEnumerable<string> instanceIds)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(instanceIds);
            toolSettings.InstanceIdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary><p><em>Sets <see cref="AzureVmssStopSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmssStopSettings SetNoWait(this AzureVmssStopSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssStopSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmssStopSettings ResetNoWait(this AzureVmssStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureVmssStopSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmssStopSettings EnableNoWait(this AzureVmssStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureVmssStopSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmssStopSettings DisableNoWait(this AzureVmssStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureVmssStopSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmssStopSettings ToggleNoWait(this AzureVmssStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureVmssStopSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssStopSettings SetSubscription(this AzureVmssStopSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssStopSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssStopSettings ResetSubscription(this AzureVmssStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmssStopSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssStopSettings SetDebug(this AzureVmssStopSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssStopSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssStopSettings ResetDebug(this AzureVmssStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmssStopSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssStopSettings SetHelp(this AzureVmssStopSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssStopSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssStopSettings ResetHelp(this AzureVmssStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmssStopSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssStopSettings SetOutput(this AzureVmssStopSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssStopSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssStopSettings ResetOutput(this AzureVmssStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmssStopSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssStopSettings SetQuery(this AzureVmssStopSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssStopSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssStopSettings ResetQuery(this AzureVmssStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmssStopSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssStopSettings SetVerbose(this AzureVmssStopSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssStopSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssStopSettings ResetVerbose(this AzureVmssStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmssUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmssUpdateSettingsExtensions
    {
        #region LicenseType
        /// <summary><p><em>Sets <see cref="AzureVmssUpdateSettings.LicenseType"/>.</em></p><p>License type if the Windows image or disk used was licensed on-premises.</p></summary>
        [Pure]
        public static AzureVmssUpdateSettings SetLicenseType(this AzureVmssUpdateSettings toolSettings, VmssLicenseType licenseType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LicenseType = licenseType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssUpdateSettings.LicenseType"/>.</em></p><p>License type if the Windows image or disk used was licensed on-premises.</p></summary>
        [Pure]
        public static AzureVmssUpdateSettings ResetLicenseType(this AzureVmssUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LicenseType = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary><p><em>Sets <see cref="AzureVmssUpdateSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmssUpdateSettings SetNoWait(this AzureVmssUpdateSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssUpdateSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmssUpdateSettings ResetNoWait(this AzureVmssUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureVmssUpdateSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmssUpdateSettings EnableNoWait(this AzureVmssUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureVmssUpdateSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmssUpdateSettings DisableNoWait(this AzureVmssUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureVmssUpdateSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmssUpdateSettings ToggleNoWait(this AzureVmssUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary><p><em>Sets <see cref="AzureVmssUpdateSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssUpdateSettings SetIds(this AzureVmssUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureVmssUpdateSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssUpdateSettings SetIds(this AzureVmssUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmssUpdateSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssUpdateSettings AddIds(this AzureVmssUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmssUpdateSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssUpdateSettings AddIds(this AzureVmssUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureVmssUpdateSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssUpdateSettings ClearIds(this AzureVmssUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmssUpdateSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssUpdateSettings RemoveIds(this AzureVmssUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmssUpdateSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssUpdateSettings RemoveIds(this AzureVmssUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmssUpdateSettings.Name"/>.</em></p><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssUpdateSettings SetName(this AzureVmssUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssUpdateSettings.Name"/>.</em></p><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssUpdateSettings ResetName(this AzureVmssUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmssUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssUpdateSettings SetResourceGroup(this AzureVmssUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssUpdateSettings ResetResourceGroup(this AzureVmssUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureVmssUpdateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssUpdateSettings SetSubscription(this AzureVmssUpdateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssUpdateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssUpdateSettings ResetSubscription(this AzureVmssUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary><p><em>Sets <see cref="AzureVmssUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureVmssUpdateSettings SetAdd(this AzureVmssUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureVmssUpdateSettings ResetAdd(this AzureVmssUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region ForceString
        /// <summary><p><em>Sets <see cref="AzureVmssUpdateSettings.ForceString"/>.</em></p><p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p></summary>
        [Pure]
        public static AzureVmssUpdateSettings SetForceString(this AzureVmssUpdateSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssUpdateSettings.ForceString"/>.</em></p><p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p></summary>
        [Pure]
        public static AzureVmssUpdateSettings ResetForceString(this AzureVmssUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary><p><em>Sets <see cref="AzureVmssUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureVmssUpdateSettings SetRemove(this AzureVmssUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureVmssUpdateSettings ResetRemove(this AzureVmssUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary><p><em>Sets <see cref="AzureVmssUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureVmssUpdateSettings SetSet(this AzureVmssUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureVmssUpdateSettings ResetSet(this AzureVmssUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmssUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssUpdateSettings SetDebug(this AzureVmssUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssUpdateSettings ResetDebug(this AzureVmssUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmssUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssUpdateSettings SetHelp(this AzureVmssUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssUpdateSettings ResetHelp(this AzureVmssUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmssUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssUpdateSettings SetOutput(this AzureVmssUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssUpdateSettings ResetOutput(this AzureVmssUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmssUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssUpdateSettings SetQuery(this AzureVmssUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssUpdateSettings ResetQuery(this AzureVmssUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmssUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssUpdateSettings SetVerbose(this AzureVmssUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssUpdateSettings ResetVerbose(this AzureVmssUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmssUpdateInstancesSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmssUpdateInstancesSettingsExtensions
    {
        #region InstanceIds
        /// <summary><p><em>Sets <see cref="AzureVmssUpdateInstancesSettings.InstanceIds"/> to a new list.</em></p><p>Space-separated list of IDs (ex: 1 2 3 ...) or * for all instances.</p></summary>
        [Pure]
        public static AzureVmssUpdateInstancesSettings SetInstanceIds(this AzureVmssUpdateInstancesSettings toolSettings, params string[] instanceIds)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InstanceIdsInternal = instanceIds.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureVmssUpdateInstancesSettings.InstanceIds"/> to a new list.</em></p><p>Space-separated list of IDs (ex: 1 2 3 ...) or * for all instances.</p></summary>
        [Pure]
        public static AzureVmssUpdateInstancesSettings SetInstanceIds(this AzureVmssUpdateInstancesSettings toolSettings, IEnumerable<string> instanceIds)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InstanceIdsInternal = instanceIds.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmssUpdateInstancesSettings.InstanceIds"/>.</em></p><p>Space-separated list of IDs (ex: 1 2 3 ...) or * for all instances.</p></summary>
        [Pure]
        public static AzureVmssUpdateInstancesSettings AddInstanceIds(this AzureVmssUpdateInstancesSettings toolSettings, params string[] instanceIds)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InstanceIdsInternal.AddRange(instanceIds);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmssUpdateInstancesSettings.InstanceIds"/>.</em></p><p>Space-separated list of IDs (ex: 1 2 3 ...) or * for all instances.</p></summary>
        [Pure]
        public static AzureVmssUpdateInstancesSettings AddInstanceIds(this AzureVmssUpdateInstancesSettings toolSettings, IEnumerable<string> instanceIds)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InstanceIdsInternal.AddRange(instanceIds);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureVmssUpdateInstancesSettings.InstanceIds"/>.</em></p><p>Space-separated list of IDs (ex: 1 2 3 ...) or * for all instances.</p></summary>
        [Pure]
        public static AzureVmssUpdateInstancesSettings ClearInstanceIds(this AzureVmssUpdateInstancesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InstanceIdsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmssUpdateInstancesSettings.InstanceIds"/>.</em></p><p>Space-separated list of IDs (ex: 1 2 3 ...) or * for all instances.</p></summary>
        [Pure]
        public static AzureVmssUpdateInstancesSettings RemoveInstanceIds(this AzureVmssUpdateInstancesSettings toolSettings, params string[] instanceIds)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(instanceIds);
            toolSettings.InstanceIdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmssUpdateInstancesSettings.InstanceIds"/>.</em></p><p>Space-separated list of IDs (ex: 1 2 3 ...) or * for all instances.</p></summary>
        [Pure]
        public static AzureVmssUpdateInstancesSettings RemoveInstanceIds(this AzureVmssUpdateInstancesSettings toolSettings, IEnumerable<string> instanceIds)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(instanceIds);
            toolSettings.InstanceIdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmssUpdateInstancesSettings.Name"/>.</em></p><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssUpdateInstancesSettings SetName(this AzureVmssUpdateInstancesSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssUpdateInstancesSettings.Name"/>.</em></p><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssUpdateInstancesSettings ResetName(this AzureVmssUpdateInstancesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmssUpdateInstancesSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssUpdateInstancesSettings SetResourceGroup(this AzureVmssUpdateInstancesSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssUpdateInstancesSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssUpdateInstancesSettings ResetResourceGroup(this AzureVmssUpdateInstancesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary><p><em>Sets <see cref="AzureVmssUpdateInstancesSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmssUpdateInstancesSettings SetNoWait(this AzureVmssUpdateInstancesSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssUpdateInstancesSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmssUpdateInstancesSettings ResetNoWait(this AzureVmssUpdateInstancesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureVmssUpdateInstancesSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmssUpdateInstancesSettings EnableNoWait(this AzureVmssUpdateInstancesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureVmssUpdateInstancesSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmssUpdateInstancesSettings DisableNoWait(this AzureVmssUpdateInstancesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureVmssUpdateInstancesSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmssUpdateInstancesSettings ToggleNoWait(this AzureVmssUpdateInstancesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureVmssUpdateInstancesSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssUpdateInstancesSettings SetSubscription(this AzureVmssUpdateInstancesSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssUpdateInstancesSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssUpdateInstancesSettings ResetSubscription(this AzureVmssUpdateInstancesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmssUpdateInstancesSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssUpdateInstancesSettings SetDebug(this AzureVmssUpdateInstancesSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssUpdateInstancesSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssUpdateInstancesSettings ResetDebug(this AzureVmssUpdateInstancesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmssUpdateInstancesSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssUpdateInstancesSettings SetHelp(this AzureVmssUpdateInstancesSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssUpdateInstancesSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssUpdateInstancesSettings ResetHelp(this AzureVmssUpdateInstancesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmssUpdateInstancesSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssUpdateInstancesSettings SetOutput(this AzureVmssUpdateInstancesSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssUpdateInstancesSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssUpdateInstancesSettings ResetOutput(this AzureVmssUpdateInstancesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmssUpdateInstancesSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssUpdateInstancesSettings SetQuery(this AzureVmssUpdateInstancesSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssUpdateInstancesSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssUpdateInstancesSettings ResetQuery(this AzureVmssUpdateInstancesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmssUpdateInstancesSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssUpdateInstancesSettings SetVerbose(this AzureVmssUpdateInstancesSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssUpdateInstancesSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssUpdateInstancesSettings ResetVerbose(this AzureVmssUpdateInstancesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmssWaitSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmssWaitSettingsExtensions
    {
        #region Ids
        /// <summary><p><em>Sets <see cref="AzureVmssWaitSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssWaitSettings SetIds(this AzureVmssWaitSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureVmssWaitSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssWaitSettings SetIds(this AzureVmssWaitSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmssWaitSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssWaitSettings AddIds(this AzureVmssWaitSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmssWaitSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssWaitSettings AddIds(this AzureVmssWaitSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureVmssWaitSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssWaitSettings ClearIds(this AzureVmssWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmssWaitSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssWaitSettings RemoveIds(this AzureVmssWaitSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmssWaitSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssWaitSettings RemoveIds(this AzureVmssWaitSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmssWaitSettings.Name"/>.</em></p><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssWaitSettings SetName(this AzureVmssWaitSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssWaitSettings.Name"/>.</em></p><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssWaitSettings ResetName(this AzureVmssWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmssWaitSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssWaitSettings SetResourceGroup(this AzureVmssWaitSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssWaitSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssWaitSettings ResetResourceGroup(this AzureVmssWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureVmssWaitSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssWaitSettings SetSubscription(this AzureVmssWaitSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssWaitSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssWaitSettings ResetSubscription(this AzureVmssWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Created
        /// <summary><p><em>Sets <see cref="AzureVmssWaitSettings.Created"/>.</em></p><p>Wait until created with 'provisioningState' at 'Succeeded'.</p></summary>
        [Pure]
        public static AzureVmssWaitSettings SetCreated(this AzureVmssWaitSettings toolSettings, string created)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Created = created;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssWaitSettings.Created"/>.</em></p><p>Wait until created with 'provisioningState' at 'Succeeded'.</p></summary>
        [Pure]
        public static AzureVmssWaitSettings ResetCreated(this AzureVmssWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Created = null;
            return toolSettings;
        }
        #endregion
        #region Custom
        /// <summary><p><em>Sets <see cref="AzureVmssWaitSettings.Custom"/>.</em></p><p>Wait until the condition satisfies a custom JMESPath query. E.g. provisioningState!='InProgress', instanceView.statuses[?code=='PowerState/running'].</p></summary>
        [Pure]
        public static AzureVmssWaitSettings SetCustom(this AzureVmssWaitSettings toolSettings, string custom)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Custom = custom;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssWaitSettings.Custom"/>.</em></p><p>Wait until the condition satisfies a custom JMESPath query. E.g. provisioningState!='InProgress', instanceView.statuses[?code=='PowerState/running'].</p></summary>
        [Pure]
        public static AzureVmssWaitSettings ResetCustom(this AzureVmssWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Custom = null;
            return toolSettings;
        }
        #endregion
        #region Deleted
        /// <summary><p><em>Sets <see cref="AzureVmssWaitSettings.Deleted"/>.</em></p><p>Wait until deleted.</p></summary>
        [Pure]
        public static AzureVmssWaitSettings SetDeleted(this AzureVmssWaitSettings toolSettings, string deleted)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Deleted = deleted;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssWaitSettings.Deleted"/>.</em></p><p>Wait until deleted.</p></summary>
        [Pure]
        public static AzureVmssWaitSettings ResetDeleted(this AzureVmssWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Deleted = null;
            return toolSettings;
        }
        #endregion
        #region Exists
        /// <summary><p><em>Sets <see cref="AzureVmssWaitSettings.Exists"/>.</em></p><p>Wait until the resource exists.</p></summary>
        [Pure]
        public static AzureVmssWaitSettings SetExists(this AzureVmssWaitSettings toolSettings, string exists)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Exists = exists;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssWaitSettings.Exists"/>.</em></p><p>Wait until the resource exists.</p></summary>
        [Pure]
        public static AzureVmssWaitSettings ResetExists(this AzureVmssWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Exists = null;
            return toolSettings;
        }
        #endregion
        #region Interval
        /// <summary><p><em>Sets <see cref="AzureVmssWaitSettings.Interval"/>.</em></p><p>Polling interval in seconds.</p></summary>
        [Pure]
        public static AzureVmssWaitSettings SetInterval(this AzureVmssWaitSettings toolSettings, string interval)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Interval = interval;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssWaitSettings.Interval"/>.</em></p><p>Polling interval in seconds.</p></summary>
        [Pure]
        public static AzureVmssWaitSettings ResetInterval(this AzureVmssWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Interval = null;
            return toolSettings;
        }
        #endregion
        #region Timeout
        /// <summary><p><em>Sets <see cref="AzureVmssWaitSettings.Timeout"/>.</em></p><p>Maximum wait in seconds.</p></summary>
        [Pure]
        public static AzureVmssWaitSettings SetTimeout(this AzureVmssWaitSettings toolSettings, string timeout)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Timeout = timeout;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssWaitSettings.Timeout"/>.</em></p><p>Maximum wait in seconds.</p></summary>
        [Pure]
        public static AzureVmssWaitSettings ResetTimeout(this AzureVmssWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Timeout = null;
            return toolSettings;
        }
        #endregion
        #region Updated
        /// <summary><p><em>Sets <see cref="AzureVmssWaitSettings.Updated"/>.</em></p><p>Wait until updated with provisioningState at 'Succeeded'.</p></summary>
        [Pure]
        public static AzureVmssWaitSettings SetUpdated(this AzureVmssWaitSettings toolSettings, string updated)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Updated = updated;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssWaitSettings.Updated"/>.</em></p><p>Wait until updated with provisioningState at 'Succeeded'.</p></summary>
        [Pure]
        public static AzureVmssWaitSettings ResetUpdated(this AzureVmssWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Updated = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmssWaitSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssWaitSettings SetDebug(this AzureVmssWaitSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssWaitSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssWaitSettings ResetDebug(this AzureVmssWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmssWaitSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssWaitSettings SetHelp(this AzureVmssWaitSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssWaitSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssWaitSettings ResetHelp(this AzureVmssWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmssWaitSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssWaitSettings SetOutput(this AzureVmssWaitSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssWaitSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssWaitSettings ResetOutput(this AzureVmssWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmssWaitSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssWaitSettings SetQuery(this AzureVmssWaitSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssWaitSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssWaitSettings ResetQuery(this AzureVmssWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmssWaitSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssWaitSettings SetVerbose(this AzureVmssWaitSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssWaitSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssWaitSettings ResetVerbose(this AzureVmssWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmssNicListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmssNicListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmssNicListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssNicListSettings SetResourceGroup(this AzureVmssNicListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssNicListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssNicListSettings ResetResourceGroup(this AzureVmssNicListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region VmssName
        /// <summary><p><em>Sets <see cref="AzureVmssNicListSettings.VmssName"/>.</em></p><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssNicListSettings SetVmssName(this AzureVmssNicListSettings toolSettings, string vmssName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmssName = vmssName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssNicListSettings.VmssName"/>.</em></p><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssNicListSettings ResetVmssName(this AzureVmssNicListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmssName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureVmssNicListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssNicListSettings SetSubscription(this AzureVmssNicListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssNicListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssNicListSettings ResetSubscription(this AzureVmssNicListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmssNicListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssNicListSettings SetDebug(this AzureVmssNicListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssNicListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssNicListSettings ResetDebug(this AzureVmssNicListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmssNicListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssNicListSettings SetHelp(this AzureVmssNicListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssNicListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssNicListSettings ResetHelp(this AzureVmssNicListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmssNicListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssNicListSettings SetOutput(this AzureVmssNicListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssNicListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssNicListSettings ResetOutput(this AzureVmssNicListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmssNicListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssNicListSettings SetQuery(this AzureVmssNicListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssNicListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssNicListSettings ResetQuery(this AzureVmssNicListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmssNicListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssNicListSettings SetVerbose(this AzureVmssNicListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssNicListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssNicListSettings ResetVerbose(this AzureVmssNicListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmssNicListVmNicsSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmssNicListVmNicsSettingsExtensions
    {
        #region Ids
        /// <summary><p><em>Sets <see cref="AzureVmssNicListVmNicsSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssNicListVmNicsSettings SetIds(this AzureVmssNicListVmNicsSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureVmssNicListVmNicsSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssNicListVmNicsSettings SetIds(this AzureVmssNicListVmNicsSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmssNicListVmNicsSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssNicListVmNicsSettings AddIds(this AzureVmssNicListVmNicsSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmssNicListVmNicsSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssNicListVmNicsSettings AddIds(this AzureVmssNicListVmNicsSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureVmssNicListVmNicsSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssNicListVmNicsSettings ClearIds(this AzureVmssNicListVmNicsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmssNicListVmNicsSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssNicListVmNicsSettings RemoveIds(this AzureVmssNicListVmNicsSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmssNicListVmNicsSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssNicListVmNicsSettings RemoveIds(this AzureVmssNicListVmNicsSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region InstanceId
        /// <summary><p><em>Sets <see cref="AzureVmssNicListVmNicsSettings.InstanceId"/>.</em></p><p>The virtual machine index.</p></summary>
        [Pure]
        public static AzureVmssNicListVmNicsSettings SetInstanceId(this AzureVmssNicListVmNicsSettings toolSettings, string instanceId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InstanceId = instanceId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssNicListVmNicsSettings.InstanceId"/>.</em></p><p>The virtual machine index.</p></summary>
        [Pure]
        public static AzureVmssNicListVmNicsSettings ResetInstanceId(this AzureVmssNicListVmNicsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InstanceId = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmssNicListVmNicsSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssNicListVmNicsSettings SetResourceGroup(this AzureVmssNicListVmNicsSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssNicListVmNicsSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssNicListVmNicsSettings ResetResourceGroup(this AzureVmssNicListVmNicsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureVmssNicListVmNicsSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssNicListVmNicsSettings SetSubscription(this AzureVmssNicListVmNicsSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssNicListVmNicsSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssNicListVmNicsSettings ResetSubscription(this AzureVmssNicListVmNicsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region VmssName
        /// <summary><p><em>Sets <see cref="AzureVmssNicListVmNicsSettings.VmssName"/>.</em></p><p>Scale set name.</p></summary>
        [Pure]
        public static AzureVmssNicListVmNicsSettings SetVmssName(this AzureVmssNicListVmNicsSettings toolSettings, string vmssName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmssName = vmssName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssNicListVmNicsSettings.VmssName"/>.</em></p><p>Scale set name.</p></summary>
        [Pure]
        public static AzureVmssNicListVmNicsSettings ResetVmssName(this AzureVmssNicListVmNicsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmssName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmssNicListVmNicsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssNicListVmNicsSettings SetDebug(this AzureVmssNicListVmNicsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssNicListVmNicsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssNicListVmNicsSettings ResetDebug(this AzureVmssNicListVmNicsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmssNicListVmNicsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssNicListVmNicsSettings SetHelp(this AzureVmssNicListVmNicsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssNicListVmNicsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssNicListVmNicsSettings ResetHelp(this AzureVmssNicListVmNicsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmssNicListVmNicsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssNicListVmNicsSettings SetOutput(this AzureVmssNicListVmNicsSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssNicListVmNicsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssNicListVmNicsSettings ResetOutput(this AzureVmssNicListVmNicsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmssNicListVmNicsSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssNicListVmNicsSettings SetQuery(this AzureVmssNicListVmNicsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssNicListVmNicsSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssNicListVmNicsSettings ResetQuery(this AzureVmssNicListVmNicsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmssNicListVmNicsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssNicListVmNicsSettings SetVerbose(this AzureVmssNicListVmNicsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssNicListVmNicsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssNicListVmNicsSettings ResetVerbose(this AzureVmssNicListVmNicsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmssNicShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmssNicShowSettingsExtensions
    {
        #region Expand
        /// <summary><p><em>Sets <see cref="AzureVmssNicShowSettings.Expand"/>.</em></p><p>Expands referenced resources.</p></summary>
        [Pure]
        public static AzureVmssNicShowSettings SetExpand(this AzureVmssNicShowSettings toolSettings, string expand)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expand = expand;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssNicShowSettings.Expand"/>.</em></p><p>Expands referenced resources.</p></summary>
        [Pure]
        public static AzureVmssNicShowSettings ResetExpand(this AzureVmssNicShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expand = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary><p><em>Sets <see cref="AzureVmssNicShowSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssNicShowSettings SetIds(this AzureVmssNicShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureVmssNicShowSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssNicShowSettings SetIds(this AzureVmssNicShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmssNicShowSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssNicShowSettings AddIds(this AzureVmssNicShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmssNicShowSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssNicShowSettings AddIds(this AzureVmssNicShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureVmssNicShowSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssNicShowSettings ClearIds(this AzureVmssNicShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmssNicShowSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssNicShowSettings RemoveIds(this AzureVmssNicShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmssNicShowSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssNicShowSettings RemoveIds(this AzureVmssNicShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region InstanceId
        /// <summary><p><em>Sets <see cref="AzureVmssNicShowSettings.InstanceId"/>.</em></p><p>The virtual machine index.</p></summary>
        [Pure]
        public static AzureVmssNicShowSettings SetInstanceId(this AzureVmssNicShowSettings toolSettings, string instanceId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InstanceId = instanceId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssNicShowSettings.InstanceId"/>.</em></p><p>The virtual machine index.</p></summary>
        [Pure]
        public static AzureVmssNicShowSettings ResetInstanceId(this AzureVmssNicShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InstanceId = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmssNicShowSettings.Name"/>.</em></p><p>The network interface (NIC).</p></summary>
        [Pure]
        public static AzureVmssNicShowSettings SetName(this AzureVmssNicShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssNicShowSettings.Name"/>.</em></p><p>The network interface (NIC).</p></summary>
        [Pure]
        public static AzureVmssNicShowSettings ResetName(this AzureVmssNicShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmssNicShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssNicShowSettings SetResourceGroup(this AzureVmssNicShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssNicShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssNicShowSettings ResetResourceGroup(this AzureVmssNicShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureVmssNicShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssNicShowSettings SetSubscription(this AzureVmssNicShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssNicShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssNicShowSettings ResetSubscription(this AzureVmssNicShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region VmssName
        /// <summary><p><em>Sets <see cref="AzureVmssNicShowSettings.VmssName"/>.</em></p><p>Scale set name.</p></summary>
        [Pure]
        public static AzureVmssNicShowSettings SetVmssName(this AzureVmssNicShowSettings toolSettings, string vmssName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmssName = vmssName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssNicShowSettings.VmssName"/>.</em></p><p>Scale set name.</p></summary>
        [Pure]
        public static AzureVmssNicShowSettings ResetVmssName(this AzureVmssNicShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmssName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmssNicShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssNicShowSettings SetDebug(this AzureVmssNicShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssNicShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssNicShowSettings ResetDebug(this AzureVmssNicShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmssNicShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssNicShowSettings SetHelp(this AzureVmssNicShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssNicShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssNicShowSettings ResetHelp(this AzureVmssNicShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmssNicShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssNicShowSettings SetOutput(this AzureVmssNicShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssNicShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssNicShowSettings ResetOutput(this AzureVmssNicShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmssNicShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssNicShowSettings SetQuery(this AzureVmssNicShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssNicShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssNicShowSettings ResetQuery(this AzureVmssNicShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmssNicShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssNicShowSettings SetVerbose(this AzureVmssNicShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssNicShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssNicShowSettings ResetVerbose(this AzureVmssNicShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmssEncryptionDisableSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmssEncryptionDisableSettingsExtensions
    {
        #region Force
        /// <summary><p><em>Sets <see cref="AzureVmssEncryptionDisableSettings.Force"/>.</em></p><p>Continue by ignoring client side validation errors.</p></summary>
        [Pure]
        public static AzureVmssEncryptionDisableSettings SetForce(this AzureVmssEncryptionDisableSettings toolSettings, string force)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Force = force;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssEncryptionDisableSettings.Force"/>.</em></p><p>Continue by ignoring client side validation errors.</p></summary>
        [Pure]
        public static AzureVmssEncryptionDisableSettings ResetForce(this AzureVmssEncryptionDisableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Force = null;
            return toolSettings;
        }
        #endregion
        #region VolumeType
        /// <summary><p><em>Sets <see cref="AzureVmssEncryptionDisableSettings.VolumeType"/>.</em></p><p>Type of volume that the encryption operation is performed on.</p></summary>
        [Pure]
        public static AzureVmssEncryptionDisableSettings SetVolumeType(this AzureVmssEncryptionDisableSettings toolSettings, VmssEncryptionVolumeType volumeType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VolumeType = volumeType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssEncryptionDisableSettings.VolumeType"/>.</em></p><p>Type of volume that the encryption operation is performed on.</p></summary>
        [Pure]
        public static AzureVmssEncryptionDisableSettings ResetVolumeType(this AzureVmssEncryptionDisableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VolumeType = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary><p><em>Sets <see cref="AzureVmssEncryptionDisableSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssEncryptionDisableSettings SetIds(this AzureVmssEncryptionDisableSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureVmssEncryptionDisableSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssEncryptionDisableSettings SetIds(this AzureVmssEncryptionDisableSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmssEncryptionDisableSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssEncryptionDisableSettings AddIds(this AzureVmssEncryptionDisableSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmssEncryptionDisableSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssEncryptionDisableSettings AddIds(this AzureVmssEncryptionDisableSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureVmssEncryptionDisableSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssEncryptionDisableSettings ClearIds(this AzureVmssEncryptionDisableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmssEncryptionDisableSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssEncryptionDisableSettings RemoveIds(this AzureVmssEncryptionDisableSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmssEncryptionDisableSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssEncryptionDisableSettings RemoveIds(this AzureVmssEncryptionDisableSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmssEncryptionDisableSettings.Name"/>.</em></p><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssEncryptionDisableSettings SetName(this AzureVmssEncryptionDisableSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssEncryptionDisableSettings.Name"/>.</em></p><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssEncryptionDisableSettings ResetName(this AzureVmssEncryptionDisableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmssEncryptionDisableSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssEncryptionDisableSettings SetResourceGroup(this AzureVmssEncryptionDisableSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssEncryptionDisableSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssEncryptionDisableSettings ResetResourceGroup(this AzureVmssEncryptionDisableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureVmssEncryptionDisableSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssEncryptionDisableSettings SetSubscription(this AzureVmssEncryptionDisableSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssEncryptionDisableSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssEncryptionDisableSettings ResetSubscription(this AzureVmssEncryptionDisableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmssEncryptionDisableSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssEncryptionDisableSettings SetDebug(this AzureVmssEncryptionDisableSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssEncryptionDisableSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssEncryptionDisableSettings ResetDebug(this AzureVmssEncryptionDisableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmssEncryptionDisableSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssEncryptionDisableSettings SetHelp(this AzureVmssEncryptionDisableSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssEncryptionDisableSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssEncryptionDisableSettings ResetHelp(this AzureVmssEncryptionDisableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmssEncryptionDisableSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssEncryptionDisableSettings SetOutput(this AzureVmssEncryptionDisableSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssEncryptionDisableSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssEncryptionDisableSettings ResetOutput(this AzureVmssEncryptionDisableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmssEncryptionDisableSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssEncryptionDisableSettings SetQuery(this AzureVmssEncryptionDisableSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssEncryptionDisableSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssEncryptionDisableSettings ResetQuery(this AzureVmssEncryptionDisableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmssEncryptionDisableSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssEncryptionDisableSettings SetVerbose(this AzureVmssEncryptionDisableSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssEncryptionDisableSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssEncryptionDisableSettings ResetVerbose(this AzureVmssEncryptionDisableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmssEncryptionEnableSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmssEncryptionEnableSettingsExtensions
    {
        #region DiskEncryptionKeyvault
        /// <summary><p><em>Sets <see cref="AzureVmssEncryptionEnableSettings.DiskEncryptionKeyvault"/>.</em></p><p>The key vault where the generated encryption key will be placed.</p></summary>
        [Pure]
        public static AzureVmssEncryptionEnableSettings SetDiskEncryptionKeyvault(this AzureVmssEncryptionEnableSettings toolSettings, string diskEncryptionKeyvault)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DiskEncryptionKeyvault = diskEncryptionKeyvault;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssEncryptionEnableSettings.DiskEncryptionKeyvault"/>.</em></p><p>The key vault where the generated encryption key will be placed.</p></summary>
        [Pure]
        public static AzureVmssEncryptionEnableSettings ResetDiskEncryptionKeyvault(this AzureVmssEncryptionEnableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DiskEncryptionKeyvault = null;
            return toolSettings;
        }
        #endregion
        #region Force
        /// <summary><p><em>Sets <see cref="AzureVmssEncryptionEnableSettings.Force"/>.</em></p><p>Continue by ignoring client side validation errors.</p></summary>
        [Pure]
        public static AzureVmssEncryptionEnableSettings SetForce(this AzureVmssEncryptionEnableSettings toolSettings, string force)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Force = force;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssEncryptionEnableSettings.Force"/>.</em></p><p>Continue by ignoring client side validation errors.</p></summary>
        [Pure]
        public static AzureVmssEncryptionEnableSettings ResetForce(this AzureVmssEncryptionEnableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Force = null;
            return toolSettings;
        }
        #endregion
        #region KeyEncryptionAlgorithm
        /// <summary><p><em>Sets <see cref="AzureVmssEncryptionEnableSettings.KeyEncryptionAlgorithm"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureVmssEncryptionEnableSettings SetKeyEncryptionAlgorithm(this AzureVmssEncryptionEnableSettings toolSettings, string keyEncryptionAlgorithm)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyEncryptionAlgorithm = keyEncryptionAlgorithm;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssEncryptionEnableSettings.KeyEncryptionAlgorithm"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureVmssEncryptionEnableSettings ResetKeyEncryptionAlgorithm(this AzureVmssEncryptionEnableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyEncryptionAlgorithm = null;
            return toolSettings;
        }
        #endregion
        #region KeyEncryptionKey
        /// <summary><p><em>Sets <see cref="AzureVmssEncryptionEnableSettings.KeyEncryptionKey"/>.</em></p><p>Key vault key name or URL used to encrypt the disk encryption key.</p></summary>
        [Pure]
        public static AzureVmssEncryptionEnableSettings SetKeyEncryptionKey(this AzureVmssEncryptionEnableSettings toolSettings, string keyEncryptionKey)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyEncryptionKey = keyEncryptionKey;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssEncryptionEnableSettings.KeyEncryptionKey"/>.</em></p><p>Key vault key name or URL used to encrypt the disk encryption key.</p></summary>
        [Pure]
        public static AzureVmssEncryptionEnableSettings ResetKeyEncryptionKey(this AzureVmssEncryptionEnableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyEncryptionKey = null;
            return toolSettings;
        }
        #endregion
        #region KeyEncryptionKeyvault
        /// <summary><p><em>Sets <see cref="AzureVmssEncryptionEnableSettings.KeyEncryptionKeyvault"/>.</em></p><p>The key vault containing the key encryption key used to encrypt the disk encryption key. If missing, CLI will use `--disk-encryption-keyvault`.</p></summary>
        [Pure]
        public static AzureVmssEncryptionEnableSettings SetKeyEncryptionKeyvault(this AzureVmssEncryptionEnableSettings toolSettings, string keyEncryptionKeyvault)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyEncryptionKeyvault = keyEncryptionKeyvault;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssEncryptionEnableSettings.KeyEncryptionKeyvault"/>.</em></p><p>The key vault containing the key encryption key used to encrypt the disk encryption key. If missing, CLI will use `--disk-encryption-keyvault`.</p></summary>
        [Pure]
        public static AzureVmssEncryptionEnableSettings ResetKeyEncryptionKeyvault(this AzureVmssEncryptionEnableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyEncryptionKeyvault = null;
            return toolSettings;
        }
        #endregion
        #region VolumeType
        /// <summary><p><em>Sets <see cref="AzureVmssEncryptionEnableSettings.VolumeType"/>.</em></p><p>Type of volume that the encryption operation is performed on.</p></summary>
        [Pure]
        public static AzureVmssEncryptionEnableSettings SetVolumeType(this AzureVmssEncryptionEnableSettings toolSettings, VmssEncryptionVolumeType volumeType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VolumeType = volumeType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssEncryptionEnableSettings.VolumeType"/>.</em></p><p>Type of volume that the encryption operation is performed on.</p></summary>
        [Pure]
        public static AzureVmssEncryptionEnableSettings ResetVolumeType(this AzureVmssEncryptionEnableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VolumeType = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary><p><em>Sets <see cref="AzureVmssEncryptionEnableSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssEncryptionEnableSettings SetIds(this AzureVmssEncryptionEnableSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureVmssEncryptionEnableSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssEncryptionEnableSettings SetIds(this AzureVmssEncryptionEnableSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmssEncryptionEnableSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssEncryptionEnableSettings AddIds(this AzureVmssEncryptionEnableSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmssEncryptionEnableSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssEncryptionEnableSettings AddIds(this AzureVmssEncryptionEnableSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureVmssEncryptionEnableSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssEncryptionEnableSettings ClearIds(this AzureVmssEncryptionEnableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmssEncryptionEnableSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssEncryptionEnableSettings RemoveIds(this AzureVmssEncryptionEnableSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmssEncryptionEnableSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssEncryptionEnableSettings RemoveIds(this AzureVmssEncryptionEnableSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmssEncryptionEnableSettings.Name"/>.</em></p><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssEncryptionEnableSettings SetName(this AzureVmssEncryptionEnableSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssEncryptionEnableSettings.Name"/>.</em></p><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssEncryptionEnableSettings ResetName(this AzureVmssEncryptionEnableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmssEncryptionEnableSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssEncryptionEnableSettings SetResourceGroup(this AzureVmssEncryptionEnableSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssEncryptionEnableSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssEncryptionEnableSettings ResetResourceGroup(this AzureVmssEncryptionEnableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureVmssEncryptionEnableSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssEncryptionEnableSettings SetSubscription(this AzureVmssEncryptionEnableSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssEncryptionEnableSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssEncryptionEnableSettings ResetSubscription(this AzureVmssEncryptionEnableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmssEncryptionEnableSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssEncryptionEnableSettings SetDebug(this AzureVmssEncryptionEnableSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssEncryptionEnableSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssEncryptionEnableSettings ResetDebug(this AzureVmssEncryptionEnableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmssEncryptionEnableSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssEncryptionEnableSettings SetHelp(this AzureVmssEncryptionEnableSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssEncryptionEnableSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssEncryptionEnableSettings ResetHelp(this AzureVmssEncryptionEnableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmssEncryptionEnableSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssEncryptionEnableSettings SetOutput(this AzureVmssEncryptionEnableSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssEncryptionEnableSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssEncryptionEnableSettings ResetOutput(this AzureVmssEncryptionEnableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmssEncryptionEnableSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssEncryptionEnableSettings SetQuery(this AzureVmssEncryptionEnableSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssEncryptionEnableSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssEncryptionEnableSettings ResetQuery(this AzureVmssEncryptionEnableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmssEncryptionEnableSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssEncryptionEnableSettings SetVerbose(this AzureVmssEncryptionEnableSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssEncryptionEnableSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssEncryptionEnableSettings ResetVerbose(this AzureVmssEncryptionEnableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmssEncryptionShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmssEncryptionShowSettingsExtensions
    {
        #region Ids
        /// <summary><p><em>Sets <see cref="AzureVmssEncryptionShowSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssEncryptionShowSettings SetIds(this AzureVmssEncryptionShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureVmssEncryptionShowSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssEncryptionShowSettings SetIds(this AzureVmssEncryptionShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmssEncryptionShowSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssEncryptionShowSettings AddIds(this AzureVmssEncryptionShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmssEncryptionShowSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssEncryptionShowSettings AddIds(this AzureVmssEncryptionShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureVmssEncryptionShowSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssEncryptionShowSettings ClearIds(this AzureVmssEncryptionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmssEncryptionShowSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssEncryptionShowSettings RemoveIds(this AzureVmssEncryptionShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmssEncryptionShowSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssEncryptionShowSettings RemoveIds(this AzureVmssEncryptionShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmssEncryptionShowSettings.Name"/>.</em></p><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssEncryptionShowSettings SetName(this AzureVmssEncryptionShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssEncryptionShowSettings.Name"/>.</em></p><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssEncryptionShowSettings ResetName(this AzureVmssEncryptionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmssEncryptionShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssEncryptionShowSettings SetResourceGroup(this AzureVmssEncryptionShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssEncryptionShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssEncryptionShowSettings ResetResourceGroup(this AzureVmssEncryptionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureVmssEncryptionShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssEncryptionShowSettings SetSubscription(this AzureVmssEncryptionShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssEncryptionShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssEncryptionShowSettings ResetSubscription(this AzureVmssEncryptionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmssEncryptionShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssEncryptionShowSettings SetDebug(this AzureVmssEncryptionShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssEncryptionShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssEncryptionShowSettings ResetDebug(this AzureVmssEncryptionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmssEncryptionShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssEncryptionShowSettings SetHelp(this AzureVmssEncryptionShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssEncryptionShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssEncryptionShowSettings ResetHelp(this AzureVmssEncryptionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmssEncryptionShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssEncryptionShowSettings SetOutput(this AzureVmssEncryptionShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssEncryptionShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssEncryptionShowSettings ResetOutput(this AzureVmssEncryptionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmssEncryptionShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssEncryptionShowSettings SetQuery(this AzureVmssEncryptionShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssEncryptionShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssEncryptionShowSettings ResetQuery(this AzureVmssEncryptionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmssEncryptionShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssEncryptionShowSettings SetVerbose(this AzureVmssEncryptionShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssEncryptionShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssEncryptionShowSettings ResetVerbose(this AzureVmssEncryptionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmssRollingUpgradeCancelSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmssRollingUpgradeCancelSettingsExtensions
    {
        #region Ids
        /// <summary><p><em>Sets <see cref="AzureVmssRollingUpgradeCancelSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssRollingUpgradeCancelSettings SetIds(this AzureVmssRollingUpgradeCancelSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureVmssRollingUpgradeCancelSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssRollingUpgradeCancelSettings SetIds(this AzureVmssRollingUpgradeCancelSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmssRollingUpgradeCancelSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssRollingUpgradeCancelSettings AddIds(this AzureVmssRollingUpgradeCancelSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmssRollingUpgradeCancelSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssRollingUpgradeCancelSettings AddIds(this AzureVmssRollingUpgradeCancelSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureVmssRollingUpgradeCancelSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssRollingUpgradeCancelSettings ClearIds(this AzureVmssRollingUpgradeCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmssRollingUpgradeCancelSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssRollingUpgradeCancelSettings RemoveIds(this AzureVmssRollingUpgradeCancelSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmssRollingUpgradeCancelSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssRollingUpgradeCancelSettings RemoveIds(this AzureVmssRollingUpgradeCancelSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmssRollingUpgradeCancelSettings.Name"/>.</em></p><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssRollingUpgradeCancelSettings SetName(this AzureVmssRollingUpgradeCancelSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssRollingUpgradeCancelSettings.Name"/>.</em></p><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssRollingUpgradeCancelSettings ResetName(this AzureVmssRollingUpgradeCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmssRollingUpgradeCancelSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssRollingUpgradeCancelSettings SetResourceGroup(this AzureVmssRollingUpgradeCancelSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssRollingUpgradeCancelSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssRollingUpgradeCancelSettings ResetResourceGroup(this AzureVmssRollingUpgradeCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureVmssRollingUpgradeCancelSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssRollingUpgradeCancelSettings SetSubscription(this AzureVmssRollingUpgradeCancelSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssRollingUpgradeCancelSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssRollingUpgradeCancelSettings ResetSubscription(this AzureVmssRollingUpgradeCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmssRollingUpgradeCancelSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssRollingUpgradeCancelSettings SetDebug(this AzureVmssRollingUpgradeCancelSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssRollingUpgradeCancelSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssRollingUpgradeCancelSettings ResetDebug(this AzureVmssRollingUpgradeCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmssRollingUpgradeCancelSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssRollingUpgradeCancelSettings SetHelp(this AzureVmssRollingUpgradeCancelSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssRollingUpgradeCancelSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssRollingUpgradeCancelSettings ResetHelp(this AzureVmssRollingUpgradeCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmssRollingUpgradeCancelSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssRollingUpgradeCancelSettings SetOutput(this AzureVmssRollingUpgradeCancelSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssRollingUpgradeCancelSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssRollingUpgradeCancelSettings ResetOutput(this AzureVmssRollingUpgradeCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmssRollingUpgradeCancelSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssRollingUpgradeCancelSettings SetQuery(this AzureVmssRollingUpgradeCancelSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssRollingUpgradeCancelSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssRollingUpgradeCancelSettings ResetQuery(this AzureVmssRollingUpgradeCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmssRollingUpgradeCancelSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssRollingUpgradeCancelSettings SetVerbose(this AzureVmssRollingUpgradeCancelSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssRollingUpgradeCancelSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssRollingUpgradeCancelSettings ResetVerbose(this AzureVmssRollingUpgradeCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmssRollingUpgradeGetLatestSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmssRollingUpgradeGetLatestSettingsExtensions
    {
        #region Ids
        /// <summary><p><em>Sets <see cref="AzureVmssRollingUpgradeGetLatestSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssRollingUpgradeGetLatestSettings SetIds(this AzureVmssRollingUpgradeGetLatestSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureVmssRollingUpgradeGetLatestSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssRollingUpgradeGetLatestSettings SetIds(this AzureVmssRollingUpgradeGetLatestSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmssRollingUpgradeGetLatestSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssRollingUpgradeGetLatestSettings AddIds(this AzureVmssRollingUpgradeGetLatestSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmssRollingUpgradeGetLatestSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssRollingUpgradeGetLatestSettings AddIds(this AzureVmssRollingUpgradeGetLatestSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureVmssRollingUpgradeGetLatestSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssRollingUpgradeGetLatestSettings ClearIds(this AzureVmssRollingUpgradeGetLatestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmssRollingUpgradeGetLatestSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssRollingUpgradeGetLatestSettings RemoveIds(this AzureVmssRollingUpgradeGetLatestSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmssRollingUpgradeGetLatestSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssRollingUpgradeGetLatestSettings RemoveIds(this AzureVmssRollingUpgradeGetLatestSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmssRollingUpgradeGetLatestSettings.Name"/>.</em></p><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssRollingUpgradeGetLatestSettings SetName(this AzureVmssRollingUpgradeGetLatestSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssRollingUpgradeGetLatestSettings.Name"/>.</em></p><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssRollingUpgradeGetLatestSettings ResetName(this AzureVmssRollingUpgradeGetLatestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmssRollingUpgradeGetLatestSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssRollingUpgradeGetLatestSettings SetResourceGroup(this AzureVmssRollingUpgradeGetLatestSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssRollingUpgradeGetLatestSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssRollingUpgradeGetLatestSettings ResetResourceGroup(this AzureVmssRollingUpgradeGetLatestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureVmssRollingUpgradeGetLatestSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssRollingUpgradeGetLatestSettings SetSubscription(this AzureVmssRollingUpgradeGetLatestSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssRollingUpgradeGetLatestSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssRollingUpgradeGetLatestSettings ResetSubscription(this AzureVmssRollingUpgradeGetLatestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmssRollingUpgradeGetLatestSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssRollingUpgradeGetLatestSettings SetDebug(this AzureVmssRollingUpgradeGetLatestSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssRollingUpgradeGetLatestSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssRollingUpgradeGetLatestSettings ResetDebug(this AzureVmssRollingUpgradeGetLatestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmssRollingUpgradeGetLatestSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssRollingUpgradeGetLatestSettings SetHelp(this AzureVmssRollingUpgradeGetLatestSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssRollingUpgradeGetLatestSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssRollingUpgradeGetLatestSettings ResetHelp(this AzureVmssRollingUpgradeGetLatestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmssRollingUpgradeGetLatestSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssRollingUpgradeGetLatestSettings SetOutput(this AzureVmssRollingUpgradeGetLatestSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssRollingUpgradeGetLatestSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssRollingUpgradeGetLatestSettings ResetOutput(this AzureVmssRollingUpgradeGetLatestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmssRollingUpgradeGetLatestSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssRollingUpgradeGetLatestSettings SetQuery(this AzureVmssRollingUpgradeGetLatestSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssRollingUpgradeGetLatestSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssRollingUpgradeGetLatestSettings ResetQuery(this AzureVmssRollingUpgradeGetLatestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmssRollingUpgradeGetLatestSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssRollingUpgradeGetLatestSettings SetVerbose(this AzureVmssRollingUpgradeGetLatestSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssRollingUpgradeGetLatestSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssRollingUpgradeGetLatestSettings ResetVerbose(this AzureVmssRollingUpgradeGetLatestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmssRollingUpgradeStartSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmssRollingUpgradeStartSettingsExtensions
    {
        #region Ids
        /// <summary><p><em>Sets <see cref="AzureVmssRollingUpgradeStartSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssRollingUpgradeStartSettings SetIds(this AzureVmssRollingUpgradeStartSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureVmssRollingUpgradeStartSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssRollingUpgradeStartSettings SetIds(this AzureVmssRollingUpgradeStartSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmssRollingUpgradeStartSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssRollingUpgradeStartSettings AddIds(this AzureVmssRollingUpgradeStartSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmssRollingUpgradeStartSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssRollingUpgradeStartSettings AddIds(this AzureVmssRollingUpgradeStartSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureVmssRollingUpgradeStartSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssRollingUpgradeStartSettings ClearIds(this AzureVmssRollingUpgradeStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmssRollingUpgradeStartSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssRollingUpgradeStartSettings RemoveIds(this AzureVmssRollingUpgradeStartSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmssRollingUpgradeStartSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssRollingUpgradeStartSettings RemoveIds(this AzureVmssRollingUpgradeStartSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmssRollingUpgradeStartSettings.Name"/>.</em></p><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssRollingUpgradeStartSettings SetName(this AzureVmssRollingUpgradeStartSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssRollingUpgradeStartSettings.Name"/>.</em></p><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssRollingUpgradeStartSettings ResetName(this AzureVmssRollingUpgradeStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmssRollingUpgradeStartSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssRollingUpgradeStartSettings SetResourceGroup(this AzureVmssRollingUpgradeStartSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssRollingUpgradeStartSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssRollingUpgradeStartSettings ResetResourceGroup(this AzureVmssRollingUpgradeStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureVmssRollingUpgradeStartSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssRollingUpgradeStartSettings SetSubscription(this AzureVmssRollingUpgradeStartSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssRollingUpgradeStartSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssRollingUpgradeStartSettings ResetSubscription(this AzureVmssRollingUpgradeStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmssRollingUpgradeStartSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssRollingUpgradeStartSettings SetDebug(this AzureVmssRollingUpgradeStartSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssRollingUpgradeStartSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssRollingUpgradeStartSettings ResetDebug(this AzureVmssRollingUpgradeStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmssRollingUpgradeStartSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssRollingUpgradeStartSettings SetHelp(this AzureVmssRollingUpgradeStartSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssRollingUpgradeStartSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssRollingUpgradeStartSettings ResetHelp(this AzureVmssRollingUpgradeStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmssRollingUpgradeStartSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssRollingUpgradeStartSettings SetOutput(this AzureVmssRollingUpgradeStartSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssRollingUpgradeStartSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssRollingUpgradeStartSettings ResetOutput(this AzureVmssRollingUpgradeStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmssRollingUpgradeStartSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssRollingUpgradeStartSettings SetQuery(this AzureVmssRollingUpgradeStartSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssRollingUpgradeStartSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssRollingUpgradeStartSettings ResetQuery(this AzureVmssRollingUpgradeStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmssRollingUpgradeStartSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssRollingUpgradeStartSettings SetVerbose(this AzureVmssRollingUpgradeStartSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssRollingUpgradeStartSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssRollingUpgradeStartSettings ResetVerbose(this AzureVmssRollingUpgradeStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmssDiskAttachSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmssDiskAttachSettingsExtensions
    {
        #region Caching
        /// <summary><p><em>Sets <see cref="AzureVmssDiskAttachSettings.Caching"/>.</em></p><p>Disk caching policy.</p></summary>
        [Pure]
        public static AzureVmssDiskAttachSettings SetCaching(this AzureVmssDiskAttachSettings toolSettings, VmssCreateOsDiskCaching caching)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Caching = caching;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssDiskAttachSettings.Caching"/>.</em></p><p>Disk caching policy.</p></summary>
        [Pure]
        public static AzureVmssDiskAttachSettings ResetCaching(this AzureVmssDiskAttachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Caching = null;
            return toolSettings;
        }
        #endregion
        #region Disk
        /// <summary><p><em>Sets <see cref="AzureVmssDiskAttachSettings.Disk"/>.</em></p><p>Existing disk name or ID to attach or detach from VM instances.</p></summary>
        [Pure]
        public static AzureVmssDiskAttachSettings SetDisk(this AzureVmssDiskAttachSettings toolSettings, string disk)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Disk = disk;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssDiskAttachSettings.Disk"/>.</em></p><p>Existing disk name or ID to attach or detach from VM instances.</p></summary>
        [Pure]
        public static AzureVmssDiskAttachSettings ResetDisk(this AzureVmssDiskAttachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Disk = null;
            return toolSettings;
        }
        #endregion
        #region Lun
        /// <summary><p><em>Sets <see cref="AzureVmssDiskAttachSettings.Lun"/>.</em></p><p>0-based logical unit number (LUN). Max value depends on the Virtual Machine instance size.</p></summary>
        [Pure]
        public static AzureVmssDiskAttachSettings SetLun(this AzureVmssDiskAttachSettings toolSettings, string lun)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Lun = lun;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssDiskAttachSettings.Lun"/>.</em></p><p>0-based logical unit number (LUN). Max value depends on the Virtual Machine instance size.</p></summary>
        [Pure]
        public static AzureVmssDiskAttachSettings ResetLun(this AzureVmssDiskAttachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Lun = null;
            return toolSettings;
        }
        #endregion
        #region SizeGb
        /// <summary><p><em>Sets <see cref="AzureVmssDiskAttachSettings.SizeGb"/>.</em></p><p>Size in GB.</p></summary>
        [Pure]
        public static AzureVmssDiskAttachSettings SetSizeGb(this AzureVmssDiskAttachSettings toolSettings, string sizeGb)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SizeGb = sizeGb;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssDiskAttachSettings.SizeGb"/>.</em></p><p>Size in GB.</p></summary>
        [Pure]
        public static AzureVmssDiskAttachSettings ResetSizeGb(this AzureVmssDiskAttachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SizeGb = null;
            return toolSettings;
        }
        #endregion
        #region Sku
        /// <summary><p><em>Sets <see cref="AzureVmssDiskAttachSettings.Sku"/>.</em></p><p>Underlying storage SKU.</p></summary>
        [Pure]
        public static AzureVmssDiskAttachSettings SetSku(this AzureVmssDiskAttachSettings toolSettings, VmssDiskAttachSku sku)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = sku;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssDiskAttachSettings.Sku"/>.</em></p><p>Underlying storage SKU.</p></summary>
        [Pure]
        public static AzureVmssDiskAttachSettings ResetSku(this AzureVmssDiskAttachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary><p><em>Sets <see cref="AzureVmssDiskAttachSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssDiskAttachSettings SetIds(this AzureVmssDiskAttachSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureVmssDiskAttachSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssDiskAttachSettings SetIds(this AzureVmssDiskAttachSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmssDiskAttachSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssDiskAttachSettings AddIds(this AzureVmssDiskAttachSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmssDiskAttachSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssDiskAttachSettings AddIds(this AzureVmssDiskAttachSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureVmssDiskAttachSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssDiskAttachSettings ClearIds(this AzureVmssDiskAttachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmssDiskAttachSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssDiskAttachSettings RemoveIds(this AzureVmssDiskAttachSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmssDiskAttachSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssDiskAttachSettings RemoveIds(this AzureVmssDiskAttachSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region InstanceId
        /// <summary><p><em>Sets <see cref="AzureVmssDiskAttachSettings.InstanceId"/>.</em></p><p>Scale set VM instance id.</p></summary>
        [Pure]
        public static AzureVmssDiskAttachSettings SetInstanceId(this AzureVmssDiskAttachSettings toolSettings, string instanceId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InstanceId = instanceId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssDiskAttachSettings.InstanceId"/>.</em></p><p>Scale set VM instance id.</p></summary>
        [Pure]
        public static AzureVmssDiskAttachSettings ResetInstanceId(this AzureVmssDiskAttachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InstanceId = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmssDiskAttachSettings.Name"/>.</em></p><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssDiskAttachSettings SetName(this AzureVmssDiskAttachSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssDiskAttachSettings.Name"/>.</em></p><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssDiskAttachSettings ResetName(this AzureVmssDiskAttachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmssDiskAttachSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssDiskAttachSettings SetResourceGroup(this AzureVmssDiskAttachSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssDiskAttachSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssDiskAttachSettings ResetResourceGroup(this AzureVmssDiskAttachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureVmssDiskAttachSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssDiskAttachSettings SetSubscription(this AzureVmssDiskAttachSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssDiskAttachSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssDiskAttachSettings ResetSubscription(this AzureVmssDiskAttachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmssDiskAttachSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssDiskAttachSettings SetDebug(this AzureVmssDiskAttachSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssDiskAttachSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssDiskAttachSettings ResetDebug(this AzureVmssDiskAttachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmssDiskAttachSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssDiskAttachSettings SetHelp(this AzureVmssDiskAttachSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssDiskAttachSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssDiskAttachSettings ResetHelp(this AzureVmssDiskAttachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmssDiskAttachSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssDiskAttachSettings SetOutput(this AzureVmssDiskAttachSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssDiskAttachSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssDiskAttachSettings ResetOutput(this AzureVmssDiskAttachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmssDiskAttachSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssDiskAttachSettings SetQuery(this AzureVmssDiskAttachSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssDiskAttachSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssDiskAttachSettings ResetQuery(this AzureVmssDiskAttachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmssDiskAttachSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssDiskAttachSettings SetVerbose(this AzureVmssDiskAttachSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssDiskAttachSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssDiskAttachSettings ResetVerbose(this AzureVmssDiskAttachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmssDiskDetachSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmssDiskDetachSettingsExtensions
    {
        #region Lun
        /// <summary><p><em>Sets <see cref="AzureVmssDiskDetachSettings.Lun"/>.</em></p><p>0-based logical unit number (LUN). Max value depends on the Virtual Machine instance size.</p></summary>
        [Pure]
        public static AzureVmssDiskDetachSettings SetLun(this AzureVmssDiskDetachSettings toolSettings, string lun)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Lun = lun;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssDiskDetachSettings.Lun"/>.</em></p><p>0-based logical unit number (LUN). Max value depends on the Virtual Machine instance size.</p></summary>
        [Pure]
        public static AzureVmssDiskDetachSettings ResetLun(this AzureVmssDiskDetachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Lun = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary><p><em>Sets <see cref="AzureVmssDiskDetachSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssDiskDetachSettings SetIds(this AzureVmssDiskDetachSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureVmssDiskDetachSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssDiskDetachSettings SetIds(this AzureVmssDiskDetachSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmssDiskDetachSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssDiskDetachSettings AddIds(this AzureVmssDiskDetachSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmssDiskDetachSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssDiskDetachSettings AddIds(this AzureVmssDiskDetachSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureVmssDiskDetachSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssDiskDetachSettings ClearIds(this AzureVmssDiskDetachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmssDiskDetachSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssDiskDetachSettings RemoveIds(this AzureVmssDiskDetachSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmssDiskDetachSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssDiskDetachSettings RemoveIds(this AzureVmssDiskDetachSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region InstanceId
        /// <summary><p><em>Sets <see cref="AzureVmssDiskDetachSettings.InstanceId"/>.</em></p><p>Scale set VM instance id.</p></summary>
        [Pure]
        public static AzureVmssDiskDetachSettings SetInstanceId(this AzureVmssDiskDetachSettings toolSettings, string instanceId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InstanceId = instanceId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssDiskDetachSettings.InstanceId"/>.</em></p><p>Scale set VM instance id.</p></summary>
        [Pure]
        public static AzureVmssDiskDetachSettings ResetInstanceId(this AzureVmssDiskDetachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InstanceId = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmssDiskDetachSettings.Name"/>.</em></p><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssDiskDetachSettings SetName(this AzureVmssDiskDetachSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssDiskDetachSettings.Name"/>.</em></p><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssDiskDetachSettings ResetName(this AzureVmssDiskDetachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmssDiskDetachSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssDiskDetachSettings SetResourceGroup(this AzureVmssDiskDetachSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssDiskDetachSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssDiskDetachSettings ResetResourceGroup(this AzureVmssDiskDetachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureVmssDiskDetachSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssDiskDetachSettings SetSubscription(this AzureVmssDiskDetachSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssDiskDetachSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssDiskDetachSettings ResetSubscription(this AzureVmssDiskDetachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmssDiskDetachSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssDiskDetachSettings SetDebug(this AzureVmssDiskDetachSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssDiskDetachSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssDiskDetachSettings ResetDebug(this AzureVmssDiskDetachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmssDiskDetachSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssDiskDetachSettings SetHelp(this AzureVmssDiskDetachSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssDiskDetachSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssDiskDetachSettings ResetHelp(this AzureVmssDiskDetachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmssDiskDetachSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssDiskDetachSettings SetOutput(this AzureVmssDiskDetachSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssDiskDetachSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssDiskDetachSettings ResetOutput(this AzureVmssDiskDetachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmssDiskDetachSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssDiskDetachSettings SetQuery(this AzureVmssDiskDetachSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssDiskDetachSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssDiskDetachSettings ResetQuery(this AzureVmssDiskDetachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmssDiskDetachSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssDiskDetachSettings SetVerbose(this AzureVmssDiskDetachSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssDiskDetachSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssDiskDetachSettings ResetVerbose(this AzureVmssDiskDetachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmssExtensionDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmssExtensionDeleteSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionDeleteSettings.Name"/>.</em></p><p>Name of the extension.</p></summary>
        [Pure]
        public static AzureVmssExtensionDeleteSettings SetName(this AzureVmssExtensionDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionDeleteSettings.Name"/>.</em></p><p>Name of the extension.</p></summary>
        [Pure]
        public static AzureVmssExtensionDeleteSettings ResetName(this AzureVmssExtensionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssExtensionDeleteSettings SetResourceGroup(this AzureVmssExtensionDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssExtensionDeleteSettings ResetResourceGroup(this AzureVmssExtensionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region VmssName
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionDeleteSettings.VmssName"/>.</em></p><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssExtensionDeleteSettings SetVmssName(this AzureVmssExtensionDeleteSettings toolSettings, string vmssName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmssName = vmssName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionDeleteSettings.VmssName"/>.</em></p><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssExtensionDeleteSettings ResetVmssName(this AzureVmssExtensionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmssName = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionDeleteSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmssExtensionDeleteSettings SetNoWait(this AzureVmssExtensionDeleteSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionDeleteSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmssExtensionDeleteSettings ResetNoWait(this AzureVmssExtensionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureVmssExtensionDeleteSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmssExtensionDeleteSettings EnableNoWait(this AzureVmssExtensionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureVmssExtensionDeleteSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmssExtensionDeleteSettings DisableNoWait(this AzureVmssExtensionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureVmssExtensionDeleteSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmssExtensionDeleteSettings ToggleNoWait(this AzureVmssExtensionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionDeleteSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssExtensionDeleteSettings SetSubscription(this AzureVmssExtensionDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionDeleteSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssExtensionDeleteSettings ResetSubscription(this AzureVmssExtensionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssExtensionDeleteSettings SetDebug(this AzureVmssExtensionDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssExtensionDeleteSettings ResetDebug(this AzureVmssExtensionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssExtensionDeleteSettings SetHelp(this AzureVmssExtensionDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssExtensionDeleteSettings ResetHelp(this AzureVmssExtensionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssExtensionDeleteSettings SetOutput(this AzureVmssExtensionDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssExtensionDeleteSettings ResetOutput(this AzureVmssExtensionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssExtensionDeleteSettings SetQuery(this AzureVmssExtensionDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssExtensionDeleteSettings ResetQuery(this AzureVmssExtensionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssExtensionDeleteSettings SetVerbose(this AzureVmssExtensionDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssExtensionDeleteSettings ResetVerbose(this AzureVmssExtensionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmssExtensionListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmssExtensionListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssExtensionListSettings SetResourceGroup(this AzureVmssExtensionListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssExtensionListSettings ResetResourceGroup(this AzureVmssExtensionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region VmssName
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionListSettings.VmssName"/>.</em></p><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssExtensionListSettings SetVmssName(this AzureVmssExtensionListSettings toolSettings, string vmssName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmssName = vmssName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionListSettings.VmssName"/>.</em></p><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssExtensionListSettings ResetVmssName(this AzureVmssExtensionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmssName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssExtensionListSettings SetSubscription(this AzureVmssExtensionListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssExtensionListSettings ResetSubscription(this AzureVmssExtensionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssExtensionListSettings SetDebug(this AzureVmssExtensionListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssExtensionListSettings ResetDebug(this AzureVmssExtensionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssExtensionListSettings SetHelp(this AzureVmssExtensionListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssExtensionListSettings ResetHelp(this AzureVmssExtensionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssExtensionListSettings SetOutput(this AzureVmssExtensionListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssExtensionListSettings ResetOutput(this AzureVmssExtensionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssExtensionListSettings SetQuery(this AzureVmssExtensionListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssExtensionListSettings ResetQuery(this AzureVmssExtensionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssExtensionListSettings SetVerbose(this AzureVmssExtensionListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssExtensionListSettings ResetVerbose(this AzureVmssExtensionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmssExtensionSetSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmssExtensionSetSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionSetSettings.Name"/>.</em></p><p>Name of the extension.</p></summary>
        [Pure]
        public static AzureVmssExtensionSetSettings SetName(this AzureVmssExtensionSetSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionSetSettings.Name"/>.</em></p><p>Name of the extension.</p></summary>
        [Pure]
        public static AzureVmssExtensionSetSettings ResetName(this AzureVmssExtensionSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Publisher
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionSetSettings.Publisher"/>.</em></p><p>The name of the extension publisher.</p></summary>
        [Pure]
        public static AzureVmssExtensionSetSettings SetPublisher(this AzureVmssExtensionSetSettings toolSettings, string publisher)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Publisher = publisher;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionSetSettings.Publisher"/>.</em></p><p>The name of the extension publisher.</p></summary>
        [Pure]
        public static AzureVmssExtensionSetSettings ResetPublisher(this AzureVmssExtensionSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Publisher = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionSetSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssExtensionSetSettings SetResourceGroup(this AzureVmssExtensionSetSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionSetSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssExtensionSetSettings ResetResourceGroup(this AzureVmssExtensionSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region VmssName
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionSetSettings.VmssName"/>.</em></p><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssExtensionSetSettings SetVmssName(this AzureVmssExtensionSetSettings toolSettings, string vmssName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmssName = vmssName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionSetSettings.VmssName"/>.</em></p><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssExtensionSetSettings ResetVmssName(this AzureVmssExtensionSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmssName = null;
            return toolSettings;
        }
        #endregion
        #region ExtensionInstanceName
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionSetSettings.ExtensionInstanceName"/>.</em></p><p>Name of the vm's instance of the extension. Default: name of the extension.</p></summary>
        [Pure]
        public static AzureVmssExtensionSetSettings SetExtensionInstanceName(this AzureVmssExtensionSetSettings toolSettings, string extensionInstanceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ExtensionInstanceName = extensionInstanceName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionSetSettings.ExtensionInstanceName"/>.</em></p><p>Name of the vm's instance of the extension. Default: name of the extension.</p></summary>
        [Pure]
        public static AzureVmssExtensionSetSettings ResetExtensionInstanceName(this AzureVmssExtensionSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ExtensionInstanceName = null;
            return toolSettings;
        }
        #endregion
        #region ForceUpdate
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionSetSettings.ForceUpdate"/>.</em></p><p>Force to update even if the extension configuration has not changed.</p></summary>
        [Pure]
        public static AzureVmssExtensionSetSettings SetForceUpdate(this AzureVmssExtensionSetSettings toolSettings, string forceUpdate)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceUpdate = forceUpdate;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionSetSettings.ForceUpdate"/>.</em></p><p>Force to update even if the extension configuration has not changed.</p></summary>
        [Pure]
        public static AzureVmssExtensionSetSettings ResetForceUpdate(this AzureVmssExtensionSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceUpdate = null;
            return toolSettings;
        }
        #endregion
        #region NoAutoUpgrade
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionSetSettings.NoAutoUpgrade"/>.</em></p><p>By doing this, extension system will not pick the highest minor version for the specified version number, and will not auto update to the latest build/revision number on any scale set updates in future.</p></summary>
        [Pure]
        public static AzureVmssExtensionSetSettings SetNoAutoUpgrade(this AzureVmssExtensionSetSettings toolSettings, bool? noAutoUpgrade)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoAutoUpgrade = noAutoUpgrade;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionSetSettings.NoAutoUpgrade"/>.</em></p><p>By doing this, extension system will not pick the highest minor version for the specified version number, and will not auto update to the latest build/revision number on any scale set updates in future.</p></summary>
        [Pure]
        public static AzureVmssExtensionSetSettings ResetNoAutoUpgrade(this AzureVmssExtensionSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoAutoUpgrade = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureVmssExtensionSetSettings.NoAutoUpgrade"/>.</em></p><p>By doing this, extension system will not pick the highest minor version for the specified version number, and will not auto update to the latest build/revision number on any scale set updates in future.</p></summary>
        [Pure]
        public static AzureVmssExtensionSetSettings EnableNoAutoUpgrade(this AzureVmssExtensionSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoAutoUpgrade = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureVmssExtensionSetSettings.NoAutoUpgrade"/>.</em></p><p>By doing this, extension system will not pick the highest minor version for the specified version number, and will not auto update to the latest build/revision number on any scale set updates in future.</p></summary>
        [Pure]
        public static AzureVmssExtensionSetSettings DisableNoAutoUpgrade(this AzureVmssExtensionSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoAutoUpgrade = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureVmssExtensionSetSettings.NoAutoUpgrade"/>.</em></p><p>By doing this, extension system will not pick the highest minor version for the specified version number, and will not auto update to the latest build/revision number on any scale set updates in future.</p></summary>
        [Pure]
        public static AzureVmssExtensionSetSettings ToggleNoAutoUpgrade(this AzureVmssExtensionSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoAutoUpgrade = !toolSettings.NoAutoUpgrade;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionSetSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmssExtensionSetSettings SetNoWait(this AzureVmssExtensionSetSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionSetSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmssExtensionSetSettings ResetNoWait(this AzureVmssExtensionSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureVmssExtensionSetSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmssExtensionSetSettings EnableNoWait(this AzureVmssExtensionSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureVmssExtensionSetSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmssExtensionSetSettings DisableNoWait(this AzureVmssExtensionSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureVmssExtensionSetSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureVmssExtensionSetSettings ToggleNoWait(this AzureVmssExtensionSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region ProtectedSettings
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionSetSettings.ProtectedSettings"/>.</em></p><p>Protected settings in JSON format for sensitive information like credentials. A JSON file path is also accepted.</p></summary>
        [Pure]
        public static AzureVmssExtensionSetSettings SetProtectedSettings(this AzureVmssExtensionSetSettings toolSettings, string protectedSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProtectedSettings = protectedSettings;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionSetSettings.ProtectedSettings"/>.</em></p><p>Protected settings in JSON format for sensitive information like credentials. A JSON file path is also accepted.</p></summary>
        [Pure]
        public static AzureVmssExtensionSetSettings ResetProtectedSettings(this AzureVmssExtensionSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProtectedSettings = null;
            return toolSettings;
        }
        #endregion
        #region Settings
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionSetSettings.Settings"/>.</em></p><p>Extension settings in JSON format. A JSON file path is also accepted.</p></summary>
        [Pure]
        public static AzureVmssExtensionSetSettings SetSettings(this AzureVmssExtensionSetSettings toolSettings, string settings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Settings = settings;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionSetSettings.Settings"/>.</em></p><p>Extension settings in JSON format. A JSON file path is also accepted.</p></summary>
        [Pure]
        public static AzureVmssExtensionSetSettings ResetSettings(this AzureVmssExtensionSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Settings = null;
            return toolSettings;
        }
        #endregion
        #region Version
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionSetSettings.Version"/>.</em></p><p>The version of the extension.</p></summary>
        [Pure]
        public static AzureVmssExtensionSetSettings SetVersion(this AzureVmssExtensionSetSettings toolSettings, string version)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = version;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionSetSettings.Version"/>.</em></p><p>The version of the extension.</p></summary>
        [Pure]
        public static AzureVmssExtensionSetSettings ResetVersion(this AzureVmssExtensionSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionSetSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssExtensionSetSettings SetSubscription(this AzureVmssExtensionSetSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionSetSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssExtensionSetSettings ResetSubscription(this AzureVmssExtensionSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionSetSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssExtensionSetSettings SetDebug(this AzureVmssExtensionSetSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionSetSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssExtensionSetSettings ResetDebug(this AzureVmssExtensionSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionSetSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssExtensionSetSettings SetHelp(this AzureVmssExtensionSetSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionSetSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssExtensionSetSettings ResetHelp(this AzureVmssExtensionSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionSetSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssExtensionSetSettings SetOutput(this AzureVmssExtensionSetSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionSetSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssExtensionSetSettings ResetOutput(this AzureVmssExtensionSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionSetSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssExtensionSetSettings SetQuery(this AzureVmssExtensionSetSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionSetSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssExtensionSetSettings ResetQuery(this AzureVmssExtensionSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionSetSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssExtensionSetSettings SetVerbose(this AzureVmssExtensionSetSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionSetSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssExtensionSetSettings ResetVerbose(this AzureVmssExtensionSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmssExtensionShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmssExtensionShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionShowSettings.Name"/>.</em></p><p>Name of the extension.</p></summary>
        [Pure]
        public static AzureVmssExtensionShowSettings SetName(this AzureVmssExtensionShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionShowSettings.Name"/>.</em></p><p>Name of the extension.</p></summary>
        [Pure]
        public static AzureVmssExtensionShowSettings ResetName(this AzureVmssExtensionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssExtensionShowSettings SetResourceGroup(this AzureVmssExtensionShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssExtensionShowSettings ResetResourceGroup(this AzureVmssExtensionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region VmssName
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionShowSettings.VmssName"/>.</em></p><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssExtensionShowSettings SetVmssName(this AzureVmssExtensionShowSettings toolSettings, string vmssName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmssName = vmssName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionShowSettings.VmssName"/>.</em></p><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssExtensionShowSettings ResetVmssName(this AzureVmssExtensionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmssName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssExtensionShowSettings SetSubscription(this AzureVmssExtensionShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssExtensionShowSettings ResetSubscription(this AzureVmssExtensionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssExtensionShowSettings SetDebug(this AzureVmssExtensionShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssExtensionShowSettings ResetDebug(this AzureVmssExtensionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssExtensionShowSettings SetHelp(this AzureVmssExtensionShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssExtensionShowSettings ResetHelp(this AzureVmssExtensionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssExtensionShowSettings SetOutput(this AzureVmssExtensionShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssExtensionShowSettings ResetOutput(this AzureVmssExtensionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssExtensionShowSettings SetQuery(this AzureVmssExtensionShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssExtensionShowSettings ResetQuery(this AzureVmssExtensionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssExtensionShowSettings SetVerbose(this AzureVmssExtensionShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssExtensionShowSettings ResetVerbose(this AzureVmssExtensionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmssDiagnosticsGetDefaultConfigSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmssDiagnosticsGetDefaultConfigSettingsExtensions
    {
        #region IsWindowsOs
        /// <summary><p><em>Sets <see cref="AzureVmssDiagnosticsGetDefaultConfigSettings.IsWindowsOs"/>.</em></p><p>For Windows VMs.</p></summary>
        [Pure]
        public static AzureVmssDiagnosticsGetDefaultConfigSettings SetIsWindowsOs(this AzureVmssDiagnosticsGetDefaultConfigSettings toolSettings, string isWindowsOs)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IsWindowsOs = isWindowsOs;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssDiagnosticsGetDefaultConfigSettings.IsWindowsOs"/>.</em></p><p>For Windows VMs.</p></summary>
        [Pure]
        public static AzureVmssDiagnosticsGetDefaultConfigSettings ResetIsWindowsOs(this AzureVmssDiagnosticsGetDefaultConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IsWindowsOs = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureVmssDiagnosticsGetDefaultConfigSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssDiagnosticsGetDefaultConfigSettings SetSubscription(this AzureVmssDiagnosticsGetDefaultConfigSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssDiagnosticsGetDefaultConfigSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssDiagnosticsGetDefaultConfigSettings ResetSubscription(this AzureVmssDiagnosticsGetDefaultConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmssDiagnosticsGetDefaultConfigSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssDiagnosticsGetDefaultConfigSettings SetDebug(this AzureVmssDiagnosticsGetDefaultConfigSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssDiagnosticsGetDefaultConfigSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssDiagnosticsGetDefaultConfigSettings ResetDebug(this AzureVmssDiagnosticsGetDefaultConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmssDiagnosticsGetDefaultConfigSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssDiagnosticsGetDefaultConfigSettings SetHelp(this AzureVmssDiagnosticsGetDefaultConfigSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssDiagnosticsGetDefaultConfigSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssDiagnosticsGetDefaultConfigSettings ResetHelp(this AzureVmssDiagnosticsGetDefaultConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmssDiagnosticsGetDefaultConfigSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssDiagnosticsGetDefaultConfigSettings SetOutput(this AzureVmssDiagnosticsGetDefaultConfigSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssDiagnosticsGetDefaultConfigSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssDiagnosticsGetDefaultConfigSettings ResetOutput(this AzureVmssDiagnosticsGetDefaultConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmssDiagnosticsGetDefaultConfigSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssDiagnosticsGetDefaultConfigSettings SetQuery(this AzureVmssDiagnosticsGetDefaultConfigSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssDiagnosticsGetDefaultConfigSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssDiagnosticsGetDefaultConfigSettings ResetQuery(this AzureVmssDiagnosticsGetDefaultConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmssDiagnosticsGetDefaultConfigSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssDiagnosticsGetDefaultConfigSettings SetVerbose(this AzureVmssDiagnosticsGetDefaultConfigSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssDiagnosticsGetDefaultConfigSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssDiagnosticsGetDefaultConfigSettings ResetVerbose(this AzureVmssDiagnosticsGetDefaultConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmssDiagnosticsSetSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmssDiagnosticsSetSettingsExtensions
    {
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmssDiagnosticsSetSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssDiagnosticsSetSettings SetResourceGroup(this AzureVmssDiagnosticsSetSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssDiagnosticsSetSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssDiagnosticsSetSettings ResetResourceGroup(this AzureVmssDiagnosticsSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Settings
        /// <summary><p><em>Sets <see cref="AzureVmssDiagnosticsSetSettings.Settings"/>.</em></p><p>Json string or a file path, which defines data to be collected.</p></summary>
        [Pure]
        public static AzureVmssDiagnosticsSetSettings SetSettings(this AzureVmssDiagnosticsSetSettings toolSettings, string settings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Settings = settings;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssDiagnosticsSetSettings.Settings"/>.</em></p><p>Json string or a file path, which defines data to be collected.</p></summary>
        [Pure]
        public static AzureVmssDiagnosticsSetSettings ResetSettings(this AzureVmssDiagnosticsSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Settings = null;
            return toolSettings;
        }
        #endregion
        #region VmssName
        /// <summary><p><em>Sets <see cref="AzureVmssDiagnosticsSetSettings.VmssName"/>.</em></p><p>Scale set name.</p></summary>
        [Pure]
        public static AzureVmssDiagnosticsSetSettings SetVmssName(this AzureVmssDiagnosticsSetSettings toolSettings, string vmssName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmssName = vmssName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssDiagnosticsSetSettings.VmssName"/>.</em></p><p>Scale set name.</p></summary>
        [Pure]
        public static AzureVmssDiagnosticsSetSettings ResetVmssName(this AzureVmssDiagnosticsSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmssName = null;
            return toolSettings;
        }
        #endregion
        #region NoAutoUpgrade
        /// <summary><p><em>Sets <see cref="AzureVmssDiagnosticsSetSettings.NoAutoUpgrade"/>.</em></p><p>By doing this, extension system will not pick the highest minor version for the specified version number, and will not auto update to the latest build/revision number on any scale set updates in future.</p></summary>
        [Pure]
        public static AzureVmssDiagnosticsSetSettings SetNoAutoUpgrade(this AzureVmssDiagnosticsSetSettings toolSettings, bool? noAutoUpgrade)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoAutoUpgrade = noAutoUpgrade;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssDiagnosticsSetSettings.NoAutoUpgrade"/>.</em></p><p>By doing this, extension system will not pick the highest minor version for the specified version number, and will not auto update to the latest build/revision number on any scale set updates in future.</p></summary>
        [Pure]
        public static AzureVmssDiagnosticsSetSettings ResetNoAutoUpgrade(this AzureVmssDiagnosticsSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoAutoUpgrade = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureVmssDiagnosticsSetSettings.NoAutoUpgrade"/>.</em></p><p>By doing this, extension system will not pick the highest minor version for the specified version number, and will not auto update to the latest build/revision number on any scale set updates in future.</p></summary>
        [Pure]
        public static AzureVmssDiagnosticsSetSettings EnableNoAutoUpgrade(this AzureVmssDiagnosticsSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoAutoUpgrade = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureVmssDiagnosticsSetSettings.NoAutoUpgrade"/>.</em></p><p>By doing this, extension system will not pick the highest minor version for the specified version number, and will not auto update to the latest build/revision number on any scale set updates in future.</p></summary>
        [Pure]
        public static AzureVmssDiagnosticsSetSettings DisableNoAutoUpgrade(this AzureVmssDiagnosticsSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoAutoUpgrade = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureVmssDiagnosticsSetSettings.NoAutoUpgrade"/>.</em></p><p>By doing this, extension system will not pick the highest minor version for the specified version number, and will not auto update to the latest build/revision number on any scale set updates in future.</p></summary>
        [Pure]
        public static AzureVmssDiagnosticsSetSettings ToggleNoAutoUpgrade(this AzureVmssDiagnosticsSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoAutoUpgrade = !toolSettings.NoAutoUpgrade;
            return toolSettings;
        }
        #endregion
        #region ProtectedSettings
        /// <summary><p><em>Sets <see cref="AzureVmssDiagnosticsSetSettings.ProtectedSettings"/>.</em></p><p>Json string or a file path containing private configurations such as storage account keys, etc.</p></summary>
        [Pure]
        public static AzureVmssDiagnosticsSetSettings SetProtectedSettings(this AzureVmssDiagnosticsSetSettings toolSettings, string protectedSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProtectedSettings = protectedSettings;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssDiagnosticsSetSettings.ProtectedSettings"/>.</em></p><p>Json string or a file path containing private configurations such as storage account keys, etc.</p></summary>
        [Pure]
        public static AzureVmssDiagnosticsSetSettings ResetProtectedSettings(this AzureVmssDiagnosticsSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProtectedSettings = null;
            return toolSettings;
        }
        #endregion
        #region Version
        /// <summary><p><em>Sets <see cref="AzureVmssDiagnosticsSetSettings.Version"/>.</em></p><p>Version of the diagnostics extension. Will use the latest if not specfied.</p></summary>
        [Pure]
        public static AzureVmssDiagnosticsSetSettings SetVersion(this AzureVmssDiagnosticsSetSettings toolSettings, string version)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = version;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssDiagnosticsSetSettings.Version"/>.</em></p><p>Version of the diagnostics extension. Will use the latest if not specfied.</p></summary>
        [Pure]
        public static AzureVmssDiagnosticsSetSettings ResetVersion(this AzureVmssDiagnosticsSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureVmssDiagnosticsSetSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssDiagnosticsSetSettings SetSubscription(this AzureVmssDiagnosticsSetSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssDiagnosticsSetSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssDiagnosticsSetSettings ResetSubscription(this AzureVmssDiagnosticsSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmssDiagnosticsSetSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssDiagnosticsSetSettings SetDebug(this AzureVmssDiagnosticsSetSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssDiagnosticsSetSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssDiagnosticsSetSettings ResetDebug(this AzureVmssDiagnosticsSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmssDiagnosticsSetSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssDiagnosticsSetSettings SetHelp(this AzureVmssDiagnosticsSetSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssDiagnosticsSetSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssDiagnosticsSetSettings ResetHelp(this AzureVmssDiagnosticsSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmssDiagnosticsSetSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssDiagnosticsSetSettings SetOutput(this AzureVmssDiagnosticsSetSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssDiagnosticsSetSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssDiagnosticsSetSettings ResetOutput(this AzureVmssDiagnosticsSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmssDiagnosticsSetSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssDiagnosticsSetSettings SetQuery(this AzureVmssDiagnosticsSetSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssDiagnosticsSetSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssDiagnosticsSetSettings ResetQuery(this AzureVmssDiagnosticsSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmssDiagnosticsSetSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssDiagnosticsSetSettings SetVerbose(this AzureVmssDiagnosticsSetSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssDiagnosticsSetSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssDiagnosticsSetSettings ResetVerbose(this AzureVmssDiagnosticsSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmssIdentityAssignSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmssIdentityAssignSettingsExtensions
    {
        #region Identities
        /// <summary><p><em>Sets <see cref="AzureVmssIdentityAssignSettings.Identities"/> to a new list.</em></p><p>Space-separated identities to assign. Use '[system]' to refer to the system assigned identity. Default: '[system]'.</p></summary>
        [Pure]
        public static AzureVmssIdentityAssignSettings SetIdentities(this AzureVmssIdentityAssignSettings toolSettings, params string[] identities)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdentitiesInternal = identities.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureVmssIdentityAssignSettings.Identities"/> to a new list.</em></p><p>Space-separated identities to assign. Use '[system]' to refer to the system assigned identity. Default: '[system]'.</p></summary>
        [Pure]
        public static AzureVmssIdentityAssignSettings SetIdentities(this AzureVmssIdentityAssignSettings toolSettings, IEnumerable<string> identities)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdentitiesInternal = identities.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmssIdentityAssignSettings.Identities"/>.</em></p><p>Space-separated identities to assign. Use '[system]' to refer to the system assigned identity. Default: '[system]'.</p></summary>
        [Pure]
        public static AzureVmssIdentityAssignSettings AddIdentities(this AzureVmssIdentityAssignSettings toolSettings, params string[] identities)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdentitiesInternal.AddRange(identities);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmssIdentityAssignSettings.Identities"/>.</em></p><p>Space-separated identities to assign. Use '[system]' to refer to the system assigned identity. Default: '[system]'.</p></summary>
        [Pure]
        public static AzureVmssIdentityAssignSettings AddIdentities(this AzureVmssIdentityAssignSettings toolSettings, IEnumerable<string> identities)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdentitiesInternal.AddRange(identities);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureVmssIdentityAssignSettings.Identities"/>.</em></p><p>Space-separated identities to assign. Use '[system]' to refer to the system assigned identity. Default: '[system]'.</p></summary>
        [Pure]
        public static AzureVmssIdentityAssignSettings ClearIdentities(this AzureVmssIdentityAssignSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdentitiesInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmssIdentityAssignSettings.Identities"/>.</em></p><p>Space-separated identities to assign. Use '[system]' to refer to the system assigned identity. Default: '[system]'.</p></summary>
        [Pure]
        public static AzureVmssIdentityAssignSettings RemoveIdentities(this AzureVmssIdentityAssignSettings toolSettings, params string[] identities)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(identities);
            toolSettings.IdentitiesInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmssIdentityAssignSettings.Identities"/>.</em></p><p>Space-separated identities to assign. Use '[system]' to refer to the system assigned identity. Default: '[system]'.</p></summary>
        [Pure]
        public static AzureVmssIdentityAssignSettings RemoveIdentities(this AzureVmssIdentityAssignSettings toolSettings, IEnumerable<string> identities)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(identities);
            toolSettings.IdentitiesInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Role
        /// <summary><p><em>Sets <see cref="AzureVmssIdentityAssignSettings.Role"/>.</em></p><p>Role name or id the system assigned identity will have.</p></summary>
        [Pure]
        public static AzureVmssIdentityAssignSettings SetRole(this AzureVmssIdentityAssignSettings toolSettings, string role)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Role = role;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssIdentityAssignSettings.Role"/>.</em></p><p>Role name or id the system assigned identity will have.</p></summary>
        [Pure]
        public static AzureVmssIdentityAssignSettings ResetRole(this AzureVmssIdentityAssignSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Role = null;
            return toolSettings;
        }
        #endregion
        #region Scope
        /// <summary><p><em>Sets <see cref="AzureVmssIdentityAssignSettings.Scope"/>.</em></p><p>Scope that the system assigned identity can access.</p></summary>
        [Pure]
        public static AzureVmssIdentityAssignSettings SetScope(this AzureVmssIdentityAssignSettings toolSettings, string scope)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Scope = scope;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssIdentityAssignSettings.Scope"/>.</em></p><p>Scope that the system assigned identity can access.</p></summary>
        [Pure]
        public static AzureVmssIdentityAssignSettings ResetScope(this AzureVmssIdentityAssignSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Scope = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary><p><em>Sets <see cref="AzureVmssIdentityAssignSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssIdentityAssignSettings SetIds(this AzureVmssIdentityAssignSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureVmssIdentityAssignSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssIdentityAssignSettings SetIds(this AzureVmssIdentityAssignSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmssIdentityAssignSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssIdentityAssignSettings AddIds(this AzureVmssIdentityAssignSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmssIdentityAssignSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssIdentityAssignSettings AddIds(this AzureVmssIdentityAssignSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureVmssIdentityAssignSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssIdentityAssignSettings ClearIds(this AzureVmssIdentityAssignSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmssIdentityAssignSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssIdentityAssignSettings RemoveIds(this AzureVmssIdentityAssignSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmssIdentityAssignSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssIdentityAssignSettings RemoveIds(this AzureVmssIdentityAssignSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmssIdentityAssignSettings.Name"/>.</em></p><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssIdentityAssignSettings SetName(this AzureVmssIdentityAssignSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssIdentityAssignSettings.Name"/>.</em></p><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssIdentityAssignSettings ResetName(this AzureVmssIdentityAssignSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmssIdentityAssignSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssIdentityAssignSettings SetResourceGroup(this AzureVmssIdentityAssignSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssIdentityAssignSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssIdentityAssignSettings ResetResourceGroup(this AzureVmssIdentityAssignSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureVmssIdentityAssignSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssIdentityAssignSettings SetSubscription(this AzureVmssIdentityAssignSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssIdentityAssignSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssIdentityAssignSettings ResetSubscription(this AzureVmssIdentityAssignSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmssIdentityAssignSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssIdentityAssignSettings SetDebug(this AzureVmssIdentityAssignSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssIdentityAssignSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssIdentityAssignSettings ResetDebug(this AzureVmssIdentityAssignSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmssIdentityAssignSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssIdentityAssignSettings SetHelp(this AzureVmssIdentityAssignSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssIdentityAssignSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssIdentityAssignSettings ResetHelp(this AzureVmssIdentityAssignSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmssIdentityAssignSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssIdentityAssignSettings SetOutput(this AzureVmssIdentityAssignSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssIdentityAssignSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssIdentityAssignSettings ResetOutput(this AzureVmssIdentityAssignSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmssIdentityAssignSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssIdentityAssignSettings SetQuery(this AzureVmssIdentityAssignSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssIdentityAssignSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssIdentityAssignSettings ResetQuery(this AzureVmssIdentityAssignSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmssIdentityAssignSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssIdentityAssignSettings SetVerbose(this AzureVmssIdentityAssignSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssIdentityAssignSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssIdentityAssignSettings ResetVerbose(this AzureVmssIdentityAssignSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmssIdentityRemoveSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmssIdentityRemoveSettingsExtensions
    {
        #region Identities
        /// <summary><p><em>Sets <see cref="AzureVmssIdentityRemoveSettings.Identities"/> to a new list.</em></p><p>Space-separated identities to remove. Use '[system]' to refer to the system assigned identity. Default: '[system]'.</p></summary>
        [Pure]
        public static AzureVmssIdentityRemoveSettings SetIdentities(this AzureVmssIdentityRemoveSettings toolSettings, params string[] identities)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdentitiesInternal = identities.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureVmssIdentityRemoveSettings.Identities"/> to a new list.</em></p><p>Space-separated identities to remove. Use '[system]' to refer to the system assigned identity. Default: '[system]'.</p></summary>
        [Pure]
        public static AzureVmssIdentityRemoveSettings SetIdentities(this AzureVmssIdentityRemoveSettings toolSettings, IEnumerable<string> identities)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdentitiesInternal = identities.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmssIdentityRemoveSettings.Identities"/>.</em></p><p>Space-separated identities to remove. Use '[system]' to refer to the system assigned identity. Default: '[system]'.</p></summary>
        [Pure]
        public static AzureVmssIdentityRemoveSettings AddIdentities(this AzureVmssIdentityRemoveSettings toolSettings, params string[] identities)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdentitiesInternal.AddRange(identities);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmssIdentityRemoveSettings.Identities"/>.</em></p><p>Space-separated identities to remove. Use '[system]' to refer to the system assigned identity. Default: '[system]'.</p></summary>
        [Pure]
        public static AzureVmssIdentityRemoveSettings AddIdentities(this AzureVmssIdentityRemoveSettings toolSettings, IEnumerable<string> identities)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdentitiesInternal.AddRange(identities);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureVmssIdentityRemoveSettings.Identities"/>.</em></p><p>Space-separated identities to remove. Use '[system]' to refer to the system assigned identity. Default: '[system]'.</p></summary>
        [Pure]
        public static AzureVmssIdentityRemoveSettings ClearIdentities(this AzureVmssIdentityRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdentitiesInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmssIdentityRemoveSettings.Identities"/>.</em></p><p>Space-separated identities to remove. Use '[system]' to refer to the system assigned identity. Default: '[system]'.</p></summary>
        [Pure]
        public static AzureVmssIdentityRemoveSettings RemoveIdentities(this AzureVmssIdentityRemoveSettings toolSettings, params string[] identities)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(identities);
            toolSettings.IdentitiesInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmssIdentityRemoveSettings.Identities"/>.</em></p><p>Space-separated identities to remove. Use '[system]' to refer to the system assigned identity. Default: '[system]'.</p></summary>
        [Pure]
        public static AzureVmssIdentityRemoveSettings RemoveIdentities(this AzureVmssIdentityRemoveSettings toolSettings, IEnumerable<string> identities)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(identities);
            toolSettings.IdentitiesInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary><p><em>Sets <see cref="AzureVmssIdentityRemoveSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssIdentityRemoveSettings SetIds(this AzureVmssIdentityRemoveSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureVmssIdentityRemoveSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssIdentityRemoveSettings SetIds(this AzureVmssIdentityRemoveSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmssIdentityRemoveSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssIdentityRemoveSettings AddIds(this AzureVmssIdentityRemoveSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmssIdentityRemoveSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssIdentityRemoveSettings AddIds(this AzureVmssIdentityRemoveSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureVmssIdentityRemoveSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssIdentityRemoveSettings ClearIds(this AzureVmssIdentityRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmssIdentityRemoveSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssIdentityRemoveSettings RemoveIds(this AzureVmssIdentityRemoveSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmssIdentityRemoveSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssIdentityRemoveSettings RemoveIds(this AzureVmssIdentityRemoveSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmssIdentityRemoveSettings.Name"/>.</em></p><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssIdentityRemoveSettings SetName(this AzureVmssIdentityRemoveSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssIdentityRemoveSettings.Name"/>.</em></p><p>Scale set name. You can configure the default using `az configure --defaults vmss=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssIdentityRemoveSettings ResetName(this AzureVmssIdentityRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmssIdentityRemoveSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssIdentityRemoveSettings SetResourceGroup(this AzureVmssIdentityRemoveSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssIdentityRemoveSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssIdentityRemoveSettings ResetResourceGroup(this AzureVmssIdentityRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureVmssIdentityRemoveSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssIdentityRemoveSettings SetSubscription(this AzureVmssIdentityRemoveSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssIdentityRemoveSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssIdentityRemoveSettings ResetSubscription(this AzureVmssIdentityRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmssIdentityRemoveSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssIdentityRemoveSettings SetDebug(this AzureVmssIdentityRemoveSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssIdentityRemoveSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssIdentityRemoveSettings ResetDebug(this AzureVmssIdentityRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmssIdentityRemoveSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssIdentityRemoveSettings SetHelp(this AzureVmssIdentityRemoveSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssIdentityRemoveSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssIdentityRemoveSettings ResetHelp(this AzureVmssIdentityRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmssIdentityRemoveSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssIdentityRemoveSettings SetOutput(this AzureVmssIdentityRemoveSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssIdentityRemoveSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssIdentityRemoveSettings ResetOutput(this AzureVmssIdentityRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmssIdentityRemoveSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssIdentityRemoveSettings SetQuery(this AzureVmssIdentityRemoveSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssIdentityRemoveSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssIdentityRemoveSettings ResetQuery(this AzureVmssIdentityRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmssIdentityRemoveSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssIdentityRemoveSettings SetVerbose(this AzureVmssIdentityRemoveSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssIdentityRemoveSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssIdentityRemoveSettings ResetVerbose(this AzureVmssIdentityRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmssIdentityShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmssIdentityShowSettingsExtensions
    {
        #region Ids
        /// <summary><p><em>Sets <see cref="AzureVmssIdentityShowSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssIdentityShowSettings SetIds(this AzureVmssIdentityShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureVmssIdentityShowSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssIdentityShowSettings SetIds(this AzureVmssIdentityShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmssIdentityShowSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssIdentityShowSettings AddIds(this AzureVmssIdentityShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureVmssIdentityShowSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssIdentityShowSettings AddIds(this AzureVmssIdentityShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureVmssIdentityShowSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssIdentityShowSettings ClearIds(this AzureVmssIdentityShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmssIdentityShowSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssIdentityShowSettings RemoveIds(this AzureVmssIdentityShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureVmssIdentityShowSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureVmssIdentityShowSettings RemoveIds(this AzureVmssIdentityShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmssIdentityShowSettings.Name"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssIdentityShowSettings SetName(this AzureVmssIdentityShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssIdentityShowSettings.Name"/>.</em></p><p>The name of the Virtual Machine. You can configure the default using `az configure --defaults vm=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssIdentityShowSettings ResetName(this AzureVmssIdentityShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureVmssIdentityShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssIdentityShowSettings SetResourceGroup(this AzureVmssIdentityShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssIdentityShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssIdentityShowSettings ResetResourceGroup(this AzureVmssIdentityShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureVmssIdentityShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssIdentityShowSettings SetSubscription(this AzureVmssIdentityShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssIdentityShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssIdentityShowSettings ResetSubscription(this AzureVmssIdentityShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmssIdentityShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssIdentityShowSettings SetDebug(this AzureVmssIdentityShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssIdentityShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssIdentityShowSettings ResetDebug(this AzureVmssIdentityShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmssIdentityShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssIdentityShowSettings SetHelp(this AzureVmssIdentityShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssIdentityShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssIdentityShowSettings ResetHelp(this AzureVmssIdentityShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmssIdentityShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssIdentityShowSettings SetOutput(this AzureVmssIdentityShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssIdentityShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssIdentityShowSettings ResetOutput(this AzureVmssIdentityShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmssIdentityShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssIdentityShowSettings SetQuery(this AzureVmssIdentityShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssIdentityShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssIdentityShowSettings ResetQuery(this AzureVmssIdentityShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmssIdentityShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssIdentityShowSettings SetVerbose(this AzureVmssIdentityShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssIdentityShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssIdentityShowSettings ResetVerbose(this AzureVmssIdentityShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmssExtensionImageListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmssExtensionImageListSettingsExtensions
    {
        #region Latest
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionImageListSettings.Latest"/>.</em></p><p>Show the latest version only.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageListSettings SetLatest(this AzureVmssExtensionImageListSettings toolSettings, bool? latest)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Latest = latest;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionImageListSettings.Latest"/>.</em></p><p>Show the latest version only.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageListSettings ResetLatest(this AzureVmssExtensionImageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Latest = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureVmssExtensionImageListSettings.Latest"/>.</em></p><p>Show the latest version only.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageListSettings EnableLatest(this AzureVmssExtensionImageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Latest = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureVmssExtensionImageListSettings.Latest"/>.</em></p><p>Show the latest version only.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageListSettings DisableLatest(this AzureVmssExtensionImageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Latest = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureVmssExtensionImageListSettings.Latest"/>.</em></p><p>Show the latest version only.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageListSettings ToggleLatest(this AzureVmssExtensionImageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Latest = !toolSettings.Latest;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionImageListSettings.Location"/>.</em></p><p>Image location.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageListSettings SetLocation(this AzureVmssExtensionImageListSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionImageListSettings.Location"/>.</em></p><p>Image location.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageListSettings ResetLocation(this AzureVmssExtensionImageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionImageListSettings.Name"/>.</em></p><p>Image name.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageListSettings SetName(this AzureVmssExtensionImageListSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionImageListSettings.Name"/>.</em></p><p>Image name.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageListSettings ResetName(this AzureVmssExtensionImageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Publisher
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionImageListSettings.Publisher"/>.</em></p><p>Image publisher name.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageListSettings SetPublisher(this AzureVmssExtensionImageListSettings toolSettings, string publisher)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Publisher = publisher;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionImageListSettings.Publisher"/>.</em></p><p>Image publisher name.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageListSettings ResetPublisher(this AzureVmssExtensionImageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Publisher = null;
            return toolSettings;
        }
        #endregion
        #region Version
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionImageListSettings.Version"/>.</em></p><p>Extension version.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageListSettings SetVersion(this AzureVmssExtensionImageListSettings toolSettings, string version)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = version;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionImageListSettings.Version"/>.</em></p><p>Extension version.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageListSettings ResetVersion(this AzureVmssExtensionImageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionImageListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageListSettings SetSubscription(this AzureVmssExtensionImageListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionImageListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageListSettings ResetSubscription(this AzureVmssExtensionImageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionImageListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageListSettings SetDebug(this AzureVmssExtensionImageListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionImageListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageListSettings ResetDebug(this AzureVmssExtensionImageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionImageListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageListSettings SetHelp(this AzureVmssExtensionImageListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionImageListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageListSettings ResetHelp(this AzureVmssExtensionImageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionImageListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageListSettings SetOutput(this AzureVmssExtensionImageListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionImageListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageListSettings ResetOutput(this AzureVmssExtensionImageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionImageListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageListSettings SetQuery(this AzureVmssExtensionImageListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionImageListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageListSettings ResetQuery(this AzureVmssExtensionImageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionImageListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageListSettings SetVerbose(this AzureVmssExtensionImageListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionImageListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageListSettings ResetVerbose(this AzureVmssExtensionImageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmssExtensionImageListNamesSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmssExtensionImageListNamesSettingsExtensions
    {
        #region Location
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionImageListNamesSettings.Location"/>.</em></p><p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageListNamesSettings SetLocation(this AzureVmssExtensionImageListNamesSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionImageListNamesSettings.Location"/>.</em></p><p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageListNamesSettings ResetLocation(this AzureVmssExtensionImageListNamesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region Publisher
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionImageListNamesSettings.Publisher"/>.</em></p><p>Image publisher name.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageListNamesSettings SetPublisher(this AzureVmssExtensionImageListNamesSettings toolSettings, string publisher)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Publisher = publisher;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionImageListNamesSettings.Publisher"/>.</em></p><p>Image publisher name.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageListNamesSettings ResetPublisher(this AzureVmssExtensionImageListNamesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Publisher = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionImageListNamesSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageListNamesSettings SetSubscription(this AzureVmssExtensionImageListNamesSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionImageListNamesSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageListNamesSettings ResetSubscription(this AzureVmssExtensionImageListNamesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionImageListNamesSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageListNamesSettings SetDebug(this AzureVmssExtensionImageListNamesSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionImageListNamesSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageListNamesSettings ResetDebug(this AzureVmssExtensionImageListNamesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionImageListNamesSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageListNamesSettings SetHelp(this AzureVmssExtensionImageListNamesSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionImageListNamesSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageListNamesSettings ResetHelp(this AzureVmssExtensionImageListNamesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionImageListNamesSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageListNamesSettings SetOutput(this AzureVmssExtensionImageListNamesSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionImageListNamesSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageListNamesSettings ResetOutput(this AzureVmssExtensionImageListNamesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionImageListNamesSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageListNamesSettings SetQuery(this AzureVmssExtensionImageListNamesSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionImageListNamesSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageListNamesSettings ResetQuery(this AzureVmssExtensionImageListNamesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionImageListNamesSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageListNamesSettings SetVerbose(this AzureVmssExtensionImageListNamesSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionImageListNamesSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageListNamesSettings ResetVerbose(this AzureVmssExtensionImageListNamesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmssExtensionImageListVersionsSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmssExtensionImageListVersionsSettingsExtensions
    {
        #region Location
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionImageListVersionsSettings.Location"/>.</em></p><p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageListVersionsSettings SetLocation(this AzureVmssExtensionImageListVersionsSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionImageListVersionsSettings.Location"/>.</em></p><p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageListVersionsSettings ResetLocation(this AzureVmssExtensionImageListVersionsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionImageListVersionsSettings.Name"/>.</em></p><p>Name of the extension.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageListVersionsSettings SetName(this AzureVmssExtensionImageListVersionsSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionImageListVersionsSettings.Name"/>.</em></p><p>Name of the extension.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageListVersionsSettings ResetName(this AzureVmssExtensionImageListVersionsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Publisher
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionImageListVersionsSettings.Publisher"/>.</em></p><p>Image publisher name.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageListVersionsSettings SetPublisher(this AzureVmssExtensionImageListVersionsSettings toolSettings, string publisher)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Publisher = publisher;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionImageListVersionsSettings.Publisher"/>.</em></p><p>Image publisher name.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageListVersionsSettings ResetPublisher(this AzureVmssExtensionImageListVersionsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Publisher = null;
            return toolSettings;
        }
        #endregion
        #region Filter
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionImageListVersionsSettings.Filter"/>.</em></p><p>The filter to apply on the operation.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageListVersionsSettings SetFilter(this AzureVmssExtensionImageListVersionsSettings toolSettings, string filter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = filter;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionImageListVersionsSettings.Filter"/>.</em></p><p>The filter to apply on the operation.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageListVersionsSettings ResetFilter(this AzureVmssExtensionImageListVersionsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = null;
            return toolSettings;
        }
        #endregion
        #region Orderby
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionImageListVersionsSettings.Orderby"/>.</em></p><p>The $orderby odata query option.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageListVersionsSettings SetOrderby(this AzureVmssExtensionImageListVersionsSettings toolSettings, string orderby)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Orderby = orderby;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionImageListVersionsSettings.Orderby"/>.</em></p><p>The $orderby odata query option.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageListVersionsSettings ResetOrderby(this AzureVmssExtensionImageListVersionsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Orderby = null;
            return toolSettings;
        }
        #endregion
        #region Top
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionImageListVersionsSettings.Top"/>.</em></p><p>The $top odata query option.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageListVersionsSettings SetTop(this AzureVmssExtensionImageListVersionsSettings toolSettings, string top)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = top;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionImageListVersionsSettings.Top"/>.</em></p><p>The $top odata query option.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageListVersionsSettings ResetTop(this AzureVmssExtensionImageListVersionsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionImageListVersionsSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageListVersionsSettings SetSubscription(this AzureVmssExtensionImageListVersionsSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionImageListVersionsSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageListVersionsSettings ResetSubscription(this AzureVmssExtensionImageListVersionsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionImageListVersionsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageListVersionsSettings SetDebug(this AzureVmssExtensionImageListVersionsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionImageListVersionsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageListVersionsSettings ResetDebug(this AzureVmssExtensionImageListVersionsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionImageListVersionsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageListVersionsSettings SetHelp(this AzureVmssExtensionImageListVersionsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionImageListVersionsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageListVersionsSettings ResetHelp(this AzureVmssExtensionImageListVersionsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionImageListVersionsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageListVersionsSettings SetOutput(this AzureVmssExtensionImageListVersionsSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionImageListVersionsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageListVersionsSettings ResetOutput(this AzureVmssExtensionImageListVersionsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionImageListVersionsSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageListVersionsSettings SetQuery(this AzureVmssExtensionImageListVersionsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionImageListVersionsSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageListVersionsSettings ResetQuery(this AzureVmssExtensionImageListVersionsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionImageListVersionsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageListVersionsSettings SetVerbose(this AzureVmssExtensionImageListVersionsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionImageListVersionsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageListVersionsSettings ResetVerbose(this AzureVmssExtensionImageListVersionsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureVmssExtensionImageShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureVmssExtensionImageShowSettingsExtensions
    {
        #region Location
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionImageShowSettings.Location"/>.</em></p><p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageShowSettings SetLocation(this AzureVmssExtensionImageShowSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionImageShowSettings.Location"/>.</em></p><p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageShowSettings ResetLocation(this AzureVmssExtensionImageShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionImageShowSettings.Name"/>.</em></p><p>Name of the extension.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageShowSettings SetName(this AzureVmssExtensionImageShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionImageShowSettings.Name"/>.</em></p><p>Name of the extension.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageShowSettings ResetName(this AzureVmssExtensionImageShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Publisher
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionImageShowSettings.Publisher"/>.</em></p><p>Image publisher name.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageShowSettings SetPublisher(this AzureVmssExtensionImageShowSettings toolSettings, string publisher)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Publisher = publisher;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionImageShowSettings.Publisher"/>.</em></p><p>Image publisher name.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageShowSettings ResetPublisher(this AzureVmssExtensionImageShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Publisher = null;
            return toolSettings;
        }
        #endregion
        #region Version
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionImageShowSettings.Version"/>.</em></p><p>Extension version.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageShowSettings SetVersion(this AzureVmssExtensionImageShowSettings toolSettings, string version)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = version;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionImageShowSettings.Version"/>.</em></p><p>Extension version.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageShowSettings ResetVersion(this AzureVmssExtensionImageShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionImageShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageShowSettings SetSubscription(this AzureVmssExtensionImageShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionImageShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageShowSettings ResetSubscription(this AzureVmssExtensionImageShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionImageShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageShowSettings SetDebug(this AzureVmssExtensionImageShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionImageShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageShowSettings ResetDebug(this AzureVmssExtensionImageShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionImageShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageShowSettings SetHelp(this AzureVmssExtensionImageShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionImageShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageShowSettings ResetHelp(this AzureVmssExtensionImageShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionImageShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageShowSettings SetOutput(this AzureVmssExtensionImageShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionImageShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageShowSettings ResetOutput(this AzureVmssExtensionImageShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionImageShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageShowSettings SetQuery(this AzureVmssExtensionImageShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionImageShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageShowSettings ResetQuery(this AzureVmssExtensionImageShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureVmssExtensionImageShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageShowSettings SetVerbose(this AzureVmssExtensionImageShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureVmssExtensionImageShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureVmssExtensionImageShowSettings ResetVerbose(this AzureVmssExtensionImageShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region VmssCreateEvictionPolicy
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class VmssCreateEvictionPolicy : Enumeration
    {
        public static VmssCreateEvictionPolicy deallocate = new VmssCreateEvictionPolicy { Value = "deallocate" };
        public static VmssCreateEvictionPolicy delete = new VmssCreateEvictionPolicy { Value = "delete" };
    }
    #endregion
    #region VmssLicenseType
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class VmssLicenseType : Enumeration
    {
        public static VmssLicenseType none = new VmssLicenseType { Value = "none" };
        public static VmssLicenseType windows_client = new VmssLicenseType { Value = "windows_client" };
        public static VmssLicenseType windows_server = new VmssLicenseType { Value = "windows_server" };
    }
    #endregion
    #region VmssCreatePriority
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class VmssCreatePriority : Enumeration
    {
        public static VmssCreatePriority low = new VmssCreatePriority { Value = "low" };
        public static VmssCreatePriority regular = new VmssCreatePriority { Value = "regular" };
    }
    #endregion
    #region VmssCreateUpgradePolicyMode
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class VmssCreateUpgradePolicyMode : Enumeration
    {
        public static VmssCreateUpgradePolicyMode automatic = new VmssCreateUpgradePolicyMode { Value = "automatic" };
        public static VmssCreateUpgradePolicyMode manual = new VmssCreateUpgradePolicyMode { Value = "manual" };
        public static VmssCreateUpgradePolicyMode rolling = new VmssCreateUpgradePolicyMode { Value = "rolling" };
    }
    #endregion
    #region VmssCreateZones
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class VmssCreateZones : Enumeration
    {
        public static VmssCreateZones _1 = new VmssCreateZones { Value = "1" };
        public static VmssCreateZones _2 = new VmssCreateZones { Value = "2" };
        public static VmssCreateZones _3 = new VmssCreateZones { Value = "3" };
    }
    #endregion
    #region VmssCreateAuthenticationType
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class VmssCreateAuthenticationType : Enumeration
    {
        public static VmssCreateAuthenticationType all = new VmssCreateAuthenticationType { Value = "all" };
        public static VmssCreateAuthenticationType password = new VmssCreateAuthenticationType { Value = "password" };
        public static VmssCreateAuthenticationType ssh = new VmssCreateAuthenticationType { Value = "ssh" };
    }
    #endregion
    #region VmssCreatePublicIpAddressAllocation
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class VmssCreatePublicIpAddressAllocation : Enumeration
    {
        public static VmssCreatePublicIpAddressAllocation dynamic = new VmssCreatePublicIpAddressAllocation { Value = "dynamic" };
        public static VmssCreatePublicIpAddressAllocation static_ = new VmssCreatePublicIpAddressAllocation { Value = "static" };
    }
    #endregion
    #region VmssCreateLbSku
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class VmssCreateLbSku : Enumeration
    {
        public static VmssCreateLbSku basic = new VmssCreateLbSku { Value = "basic" };
        public static VmssCreateLbSku standard = new VmssCreateLbSku { Value = "standard" };
    }
    #endregion
    #region VmssCreateOsDiskCaching
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class VmssCreateOsDiskCaching : Enumeration
    {
        public static VmssCreateOsDiskCaching none = new VmssCreateOsDiskCaching { Value = "none" };
        public static VmssCreateOsDiskCaching readonly_ = new VmssCreateOsDiskCaching { Value = "readonly" };
        public static VmssCreateOsDiskCaching readwrite = new VmssCreateOsDiskCaching { Value = "readwrite" };
    }
    #endregion
    #region VmssCreateOsType
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class VmssCreateOsType : Enumeration
    {
        public static VmssCreateOsType linux = new VmssCreateOsType { Value = "linux" };
        public static VmssCreateOsType windows = new VmssCreateOsType { Value = "windows" };
    }
    #endregion
    #region VmssEncryptionVolumeType
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class VmssEncryptionVolumeType : Enumeration
    {
        public static VmssEncryptionVolumeType all = new VmssEncryptionVolumeType { Value = "all" };
        public static VmssEncryptionVolumeType data = new VmssEncryptionVolumeType { Value = "data" };
        public static VmssEncryptionVolumeType os = new VmssEncryptionVolumeType { Value = "os" };
    }
    #endregion
    #region VmssDiskAttachSku
    /// <summary><p>Used within <see cref="AzureVmssTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class VmssDiskAttachSku : Enumeration
    {
        public static VmssDiskAttachSku premium_lrs = new VmssDiskAttachSku { Value = "premium_lrs" };
        public static VmssDiskAttachSku standardssd_lrs = new VmssDiskAttachSku { Value = "standardssd_lrs" };
        public static VmssDiskAttachSku standard_lrs = new VmssDiskAttachSku { Value = "standard_lrs" };
        public static VmssDiskAttachSku ultrassd_lrs = new VmssDiskAttachSku { Value = "ultrassd_lrs" };
    }
    #endregion
}
