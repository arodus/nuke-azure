// Copyright Matthias Koch, Sebastian Karasek 2018.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

// Generated with Nuke.CodeGeneration, Version: 0.6.2 [CommitSha: ff25463a].
// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/AzureMonitor.json.

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
    public static partial class AzureMonitorTasks
    {
        /// <summary><p>Path to the AzureMonitor executable.</p></summary>
        public static string AzureMonitorPath => ToolPathResolver.GetPathExecutable("az");
        /// <summary><p>Manage the Azure Monitor Service.</p></summary>
        public static IReadOnlyCollection<Output> AzureMonitor(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool logOutput = true, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzureMonitorPath, arguments, workingDirectory, environmentVariables, timeout, logOutput, null, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage the Azure Monitor Service.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/monitor?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureMonitor(Configure<AzureMonitorSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMonitorSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage the Azure Monitor Service.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/monitor?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureMonitorActionGroupCreate(Configure<AzureMonitorActionGroupCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMonitorActionGroupCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage the Azure Monitor Service.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/monitor?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureMonitorActionGroupDelete(Configure<AzureMonitorActionGroupDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMonitorActionGroupDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage the Azure Monitor Service.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/monitor?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureMonitorActionGroupEnableReceiver(Configure<AzureMonitorActionGroupEnableReceiverSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMonitorActionGroupEnableReceiverSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage the Azure Monitor Service.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/monitor?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureMonitorActionGroupList(Configure<AzureMonitorActionGroupListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMonitorActionGroupListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage the Azure Monitor Service.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/monitor?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureMonitorActionGroupShow(Configure<AzureMonitorActionGroupShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMonitorActionGroupShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage the Azure Monitor Service.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/monitor?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureMonitorActionGroupUpdate(Configure<AzureMonitorActionGroupUpdateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMonitorActionGroupUpdateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage the Azure Monitor Service.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/monitor?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureMonitorActivityLogList(Configure<AzureMonitorActivityLogListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMonitorActivityLogListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage the Azure Monitor Service.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/monitor?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureMonitorActivityLogListCategories(Configure<AzureMonitorActivityLogListCategoriesSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMonitorActivityLogListCategoriesSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage the Azure Monitor Service.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/monitor?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureMonitorAlertCreate(Configure<AzureMonitorAlertCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMonitorAlertCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage the Azure Monitor Service.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/monitor?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureMonitorAlertDelete(Configure<AzureMonitorAlertDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMonitorAlertDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage the Azure Monitor Service.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/monitor?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureMonitorAlertList(Configure<AzureMonitorAlertListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMonitorAlertListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage the Azure Monitor Service.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/monitor?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureMonitorAlertListIncidents(Configure<AzureMonitorAlertListIncidentsSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMonitorAlertListIncidentsSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage the Azure Monitor Service.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/monitor?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureMonitorAlertShow(Configure<AzureMonitorAlertShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMonitorAlertShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage the Azure Monitor Service.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/monitor?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureMonitorAlertShowIncident(Configure<AzureMonitorAlertShowIncidentSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMonitorAlertShowIncidentSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage the Azure Monitor Service.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/monitor?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureMonitorAlertUpdate(Configure<AzureMonitorAlertUpdateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMonitorAlertUpdateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage the Azure Monitor Service.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/monitor?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureMonitorAutoscaleSettingsCreate(Configure<AzureMonitorAutoscaleSettingsCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMonitorAutoscaleSettingsCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage the Azure Monitor Service.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/monitor?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureMonitorAutoscaleSettingsDelete(Configure<AzureMonitorAutoscaleSettingsDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMonitorAutoscaleSettingsDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage the Azure Monitor Service.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/monitor?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureMonitorAutoscaleSettingsGetParametersTemplate(Configure<AzureMonitorAutoscaleSettingsGetParametersTemplateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMonitorAutoscaleSettingsGetParametersTemplateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage the Azure Monitor Service.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/monitor?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureMonitorAutoscaleSettingsList(Configure<AzureMonitorAutoscaleSettingsListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMonitorAutoscaleSettingsListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage the Azure Monitor Service.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/monitor?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureMonitorAutoscaleSettingsShow(Configure<AzureMonitorAutoscaleSettingsShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMonitorAutoscaleSettingsShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage the Azure Monitor Service.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/monitor?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureMonitorAutoscaleSettingsUpdate(Configure<AzureMonitorAutoscaleSettingsUpdateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMonitorAutoscaleSettingsUpdateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage the Azure Monitor Service.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/monitor?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureMonitorAutoscaleCreate(Configure<AzureMonitorAutoscaleCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMonitorAutoscaleCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage the Azure Monitor Service.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/monitor?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureMonitorAutoscaleDelete(Configure<AzureMonitorAutoscaleDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMonitorAutoscaleDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage the Azure Monitor Service.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/monitor?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureMonitorAutoscaleList(Configure<AzureMonitorAutoscaleListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMonitorAutoscaleListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage the Azure Monitor Service.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/monitor?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureMonitorAutoscaleShow(Configure<AzureMonitorAutoscaleShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMonitorAutoscaleShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage the Azure Monitor Service.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/monitor?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureMonitorAutoscaleUpdate(Configure<AzureMonitorAutoscaleUpdateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMonitorAutoscaleUpdateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage the Azure Monitor Service.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/monitor?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureMonitorDiagnosticSettingsCreate(Configure<AzureMonitorDiagnosticSettingsCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMonitorDiagnosticSettingsCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage the Azure Monitor Service.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/monitor?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureMonitorDiagnosticSettingsDelete(Configure<AzureMonitorDiagnosticSettingsDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMonitorDiagnosticSettingsDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage the Azure Monitor Service.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/monitor?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureMonitorDiagnosticSettingsList(Configure<AzureMonitorDiagnosticSettingsListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMonitorDiagnosticSettingsListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage the Azure Monitor Service.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/monitor?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureMonitorDiagnosticSettingsShow(Configure<AzureMonitorDiagnosticSettingsShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMonitorDiagnosticSettingsShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage the Azure Monitor Service.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/monitor?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureMonitorDiagnosticSettingsUpdate(Configure<AzureMonitorDiagnosticSettingsUpdateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMonitorDiagnosticSettingsUpdateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage the Azure Monitor Service.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/monitor?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureMonitorLogProfilesCreate(Configure<AzureMonitorLogProfilesCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMonitorLogProfilesCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage the Azure Monitor Service.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/monitor?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureMonitorLogProfilesDelete(Configure<AzureMonitorLogProfilesDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMonitorLogProfilesDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage the Azure Monitor Service.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/monitor?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureMonitorLogProfilesList(Configure<AzureMonitorLogProfilesListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMonitorLogProfilesListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage the Azure Monitor Service.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/monitor?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureMonitorLogProfilesShow(Configure<AzureMonitorLogProfilesShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMonitorLogProfilesShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage the Azure Monitor Service.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/monitor?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureMonitorLogProfilesUpdate(Configure<AzureMonitorLogProfilesUpdateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMonitorLogProfilesUpdateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage the Azure Monitor Service.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/monitor?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureMonitorMetricsList(Configure<AzureMonitorMetricsListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMonitorMetricsListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage the Azure Monitor Service.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/monitor?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureMonitorMetricsListDefinitions(Configure<AzureMonitorMetricsListDefinitionsSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMonitorMetricsListDefinitionsSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage the Azure Monitor Service.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/monitor?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureMonitorActivityLogAlertCreate(Configure<AzureMonitorActivityLogAlertCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMonitorActivityLogAlertCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage the Azure Monitor Service.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/monitor?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureMonitorActivityLogAlertDelete(Configure<AzureMonitorActivityLogAlertDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMonitorActivityLogAlertDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage the Azure Monitor Service.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/monitor?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureMonitorActivityLogAlertList(Configure<AzureMonitorActivityLogAlertListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMonitorActivityLogAlertListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage the Azure Monitor Service.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/monitor?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureMonitorActivityLogAlertShow(Configure<AzureMonitorActivityLogAlertShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMonitorActivityLogAlertShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage the Azure Monitor Service.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/monitor?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureMonitorActivityLogAlertUpdate(Configure<AzureMonitorActivityLogAlertUpdateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMonitorActivityLogAlertUpdateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage the Azure Monitor Service.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/monitor?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureMonitorAutoscaleProfileCreate(Configure<AzureMonitorAutoscaleProfileCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMonitorAutoscaleProfileCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage the Azure Monitor Service.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/monitor?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureMonitorAutoscaleProfileDelete(Configure<AzureMonitorAutoscaleProfileDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMonitorAutoscaleProfileDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage the Azure Monitor Service.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/monitor?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureMonitorAutoscaleProfileList(Configure<AzureMonitorAutoscaleProfileListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMonitorAutoscaleProfileListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage the Azure Monitor Service.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/monitor?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureMonitorAutoscaleProfileListTimezones(Configure<AzureMonitorAutoscaleProfileListTimezonesSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMonitorAutoscaleProfileListTimezonesSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage the Azure Monitor Service.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/monitor?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureMonitorAutoscaleProfileShow(Configure<AzureMonitorAutoscaleProfileShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMonitorAutoscaleProfileShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage the Azure Monitor Service.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/monitor?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureMonitorAutoscaleRuleCopy(Configure<AzureMonitorAutoscaleRuleCopySettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMonitorAutoscaleRuleCopySettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage the Azure Monitor Service.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/monitor?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureMonitorAutoscaleRuleCreate(Configure<AzureMonitorAutoscaleRuleCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMonitorAutoscaleRuleCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage the Azure Monitor Service.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/monitor?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureMonitorAutoscaleRuleDelete(Configure<AzureMonitorAutoscaleRuleDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMonitorAutoscaleRuleDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage the Azure Monitor Service.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/monitor?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureMonitorAutoscaleRuleList(Configure<AzureMonitorAutoscaleRuleListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMonitorAutoscaleRuleListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage the Azure Monitor Service.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/monitor?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureMonitorDiagnosticSettingsCategoriesList(Configure<AzureMonitorDiagnosticSettingsCategoriesListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMonitorDiagnosticSettingsCategoriesListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage the Azure Monitor Service.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/monitor?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureMonitorDiagnosticSettingsCategoriesShow(Configure<AzureMonitorDiagnosticSettingsCategoriesShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMonitorDiagnosticSettingsCategoriesShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage the Azure Monitor Service.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/monitor?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureMonitorMetricsAlertCreate(Configure<AzureMonitorMetricsAlertCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMonitorMetricsAlertCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage the Azure Monitor Service.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/monitor?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureMonitorMetricsAlertDelete(Configure<AzureMonitorMetricsAlertDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMonitorMetricsAlertDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage the Azure Monitor Service.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/monitor?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureMonitorMetricsAlertList(Configure<AzureMonitorMetricsAlertListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMonitorMetricsAlertListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage the Azure Monitor Service.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/monitor?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureMonitorMetricsAlertShow(Configure<AzureMonitorMetricsAlertShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMonitorMetricsAlertShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage the Azure Monitor Service.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/monitor?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureMonitorMetricsAlertUpdate(Configure<AzureMonitorMetricsAlertUpdateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMonitorMetricsAlertUpdateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage the Azure Monitor Service.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/monitor?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureMonitorActivityLogAlertActionGroupAdd(Configure<AzureMonitorActivityLogAlertActionGroupAddSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMonitorActivityLogAlertActionGroupAddSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage the Azure Monitor Service.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/monitor?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureMonitorActivityLogAlertActionGroupRemove(Configure<AzureMonitorActivityLogAlertActionGroupRemoveSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMonitorActivityLogAlertActionGroupRemoveSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage the Azure Monitor Service.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/monitor?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureMonitorActivityLogAlertScopeAdd(Configure<AzureMonitorActivityLogAlertScopeAddSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMonitorActivityLogAlertScopeAddSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage the Azure Monitor Service.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/monitor?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureMonitorActivityLogAlertScopeRemove(Configure<AzureMonitorActivityLogAlertScopeRemoveSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMonitorActivityLogAlertScopeRemoveSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
    }
    #region AzureMonitorSettings
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMonitorSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMonitor executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMonitorTasks.AzureMonitorPath;
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("monitor")
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureMonitorActionGroupCreateSettings
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMonitorActionGroupCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMonitor executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMonitorTasks.AzureMonitorPath;
        /// <summary><p>The name of the action group.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The short name of the action group.</p></summary>
        public virtual string ShortName { get; internal set; }
        /// <summary><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        public virtual string Tags { get; internal set; }
        /// <summary><p>Add receivers to the action group during the creation.</p></summary>
        public virtual string Action { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("monitor action-group create")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--short-name {value}", ShortName)
              .Add("--tags {value}", Tags)
              .Add("--action {value}", Action)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureMonitorActionGroupDeleteSettings
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMonitorActionGroupDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMonitor executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMonitorTasks.AzureMonitorPath;
        /// <summary><p>The name of the action group.</p></summary>
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
              .Add("monitor action-group delete")
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
    #region AzureMonitorActionGroupEnableReceiverSettings
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMonitorActionGroupEnableReceiverSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMonitor executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMonitorTasks.AzureMonitorPath;
        /// <summary><p>The name of the action group.</p></summary>
        public virtual string ActionGroup { get; internal set; }
        /// <summary><p>The name of the receiver to resubscribe.</p></summary>
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
              .Add("monitor action-group enable-receiver")
              .Add("--action-group {value}", ActionGroup)
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
    #region AzureMonitorActionGroupListSettings
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMonitorActionGroupListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMonitor executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMonitorTasks.AzureMonitorPath;
        /// <summary><p>Name of the resource group under which the action groups are being listed. If it is omitted, all the action groups under the current subscription are listed.</p></summary>
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
              .Add("monitor action-group list")
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
    #region AzureMonitorActionGroupShowSettings
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMonitorActionGroupShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMonitor executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMonitorTasks.AzureMonitorPath;
        /// <summary><p>The name of the action group.</p></summary>
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
              .Add("monitor action-group show")
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
    #region AzureMonitorActionGroupUpdateSettings
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMonitorActionGroupUpdateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMonitor executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMonitorTasks.AzureMonitorPath;
        /// <summary><p>The name of the action group.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Update the group short name of the action group.</p></summary>
        public virtual string ShortName { get; internal set; }
        /// <summary><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        public virtual string Tags { get; internal set; }
        /// <summary><p>Add receivers to the action group.</p></summary>
        public virtual string AddAction { get; internal set; }
        /// <summary><p>Remove receivers from the action group. Accept space-separated list of receiver names.</p></summary>
        public virtual string RemoveAction { get; internal set; }
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
              .Add("monitor action-group update")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--short-name {value}", ShortName)
              .Add("--tags {value}", Tags)
              .Add("--add-action {value}", AddAction)
              .Add("--remove-action {value}", RemoveAction)
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
    #region AzureMonitorActivityLogListSettings
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMonitorActivityLogListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMonitor executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMonitorTasks.AzureMonitorPath;
        /// <summary><p>The OData filter for the list activity logs. If this argument is provided OData Filter Arguments will be ignored.</p></summary>
        public virtual string Filters { get; internal set; }
        /// <summary><p>The maximum number of records to be returned by the command.</p></summary>
        public virtual int? MaxEvents { get; internal set; }
        /// <summary><p>The list of event names.</p></summary>
        public virtual string Select { get; internal set; }
        /// <summary><p>The caller to look for when querying.</p></summary>
        public virtual string Caller { get; internal set; }
        /// <summary><p>The correlation id of the query.</p></summary>
        public virtual string CorrelationId { get; internal set; }
        /// <summary><p>The end time of the query. In ISO format with explicit indication of timezone: 1970-01-01T00:00:00Z, 1970-01-01T00:00:00-0500. Defaults to current time.</p></summary>
        public virtual string EndTime { get; internal set; }
        /// <summary><p>The resource group.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The identifier of the resource.</p></summary>
        public virtual string ResourceId { get; internal set; }
        /// <summary><p>The resource provider.</p></summary>
        public virtual string ResourceProvider { get; internal set; }
        /// <summary><p>The start time of the query. In ISO format with explicit indication of timezone: 1970-01-01T00:00:00Z, 1970-01-01T00:00:00-0500. Defaults to 1 Hour prior to the current time.</p></summary>
        public virtual string StartTime { get; internal set; }
        /// <summary><p>The status value to query (ex: Failed).</p></summary>
        public virtual string Status { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("monitor activity-log list")
              .Add("--filters {value}", Filters)
              .Add("--max-events {value}", MaxEvents)
              .Add("--select {value}", Select)
              .Add("--caller {value}", Caller)
              .Add("--correlation-id {value}", CorrelationId)
              .Add("--end-time {value}", EndTime)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--resource-id {value}", ResourceId)
              .Add("--resource-provider {value}", ResourceProvider)
              .Add("--start-time {value}", StartTime)
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
    #region AzureMonitorActivityLogListCategoriesSettings
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMonitorActivityLogListCategoriesSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMonitor executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMonitorTasks.AzureMonitorPath;
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("monitor activity-log list-categories")
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureMonitorAlertCreateSettings
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMonitorAlertCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMonitor executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMonitorTasks.AzureMonitorPath;
        /// <summary><p>The condition which triggers the rule.</p></summary>
        public virtual string Condition { get; internal set; }
        /// <summary><p>Name of the alert rule.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Free-text description of the rule. Defaults to the condition expression.</p></summary>
        public virtual string Description { get; internal set; }
        /// <summary><p>Create the rule in a disabled state.</p></summary>
        public virtual bool? Disabled { get; internal set; }
        /// <summary><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        public virtual string Location { get; internal set; }
        /// <summary><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        public virtual string Tags { get; internal set; }
        /// <summary><p>Add an action to fire when the alert is triggered.</p></summary>
        public virtual string Action { get; internal set; }
        /// <summary><p>Email the service owners if an alert is triggered.</p></summary>
        public virtual bool? EmailServiceOwners { get; internal set; }
        /// <summary><p>Name or ID of the target resource.</p></summary>
        public virtual string Target { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Target resource provider namespace.</p></summary>
        public virtual string TargetNamespace { get; internal set; }
        /// <summary><p>Target resource parent path, if applicable.</p></summary>
        public virtual string TargetParent { get; internal set; }
        /// <summary><p>Target resource type. Can also accept namespace/type format (Ex: 'Microsoft.Compute/virtualMachines)').</p></summary>
        public virtual string TargetType { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("monitor alert create")
              .Add("--condition {value}", Condition)
              .Add("--name {value}", Name)
              .Add("--description {value}", Description)
              .Add("--disabled", Disabled)
              .Add("--location {value}", Location)
              .Add("--tags {value}", Tags)
              .Add("--action {value}", Action)
              .Add("--email-service-owners", EmailServiceOwners)
              .Add("--target {value}", Target)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--target-namespace {value}", TargetNamespace)
              .Add("--target-parent {value}", TargetParent)
              .Add("--target-type {value}", TargetType)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureMonitorAlertDeleteSettings
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMonitorAlertDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMonitor executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMonitorTasks.AzureMonitorPath;
        /// <summary><p>Name of the alert rule.</p></summary>
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
              .Add("monitor alert delete")
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
    #region AzureMonitorAlertListSettings
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMonitorAlertListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMonitor executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMonitorTasks.AzureMonitorPath;
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
              .Add("monitor alert list")
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
    #region AzureMonitorAlertListIncidentsSettings
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMonitorAlertListIncidentsSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMonitor executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMonitorTasks.AzureMonitorPath;
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name of the alert rule.</p></summary>
        public virtual string RuleName { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("monitor alert list-incidents")
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--rule-name {value}", RuleName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureMonitorAlertShowSettings
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMonitorAlertShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMonitor executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMonitorTasks.AzureMonitorPath;
        /// <summary><p>Name of the alert rule.</p></summary>
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
              .Add("monitor alert show")
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
    #region AzureMonitorAlertShowIncidentSettings
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMonitorAlertShowIncidentSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMonitor executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMonitorTasks.AzureMonitorPath;
        /// <summary><p>The name of the incident to retrieve.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name of the alert rule.</p></summary>
        public virtual string RuleName { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("monitor alert show-incident")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--rule-name {value}", RuleName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureMonitorAlertUpdateSettings
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMonitorAlertUpdateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMonitor executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMonitorTasks.AzureMonitorPath;
        /// <summary><p>Name of the alert rule.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Description of the rule.</p></summary>
        public virtual string Description { get; internal set; }
        /// <summary><p></p></summary>
        public virtual string Enabled { get; internal set; }
        /// <summary><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        public virtual string Tags { get; internal set; }
        /// <summary><p>Add an action to fire when the alert is triggered.</p></summary>
        public virtual string AddAction { get; internal set; }
        /// <summary><p>Email the service owners if an alert is triggered.</p></summary>
        public virtual bool? EmailServiceOwners { get; internal set; }
        /// <summary><p>Remove one or more actions.</p></summary>
        public virtual string RemoveAction { get; internal set; }
        /// <summary><p>Type of aggregation to apply based on --period.</p></summary>
        public virtual MonitorAlertUpdateAggregation Aggregation { get; internal set; }
        /// <summary><p>The condition which triggers the rule.</p></summary>
        public virtual string Condition { get; internal set; }
        /// <summary><p>Name of the metric to base the rule on.</p></summary>
        public virtual string Metric { get; internal set; }
        /// <summary><p>How to compare the metric against the threshold.</p></summary>
        public virtual MonitorAlertUpdateOperator Operator { get; internal set; }
        /// <summary><p>Time span over which to apply --aggregation, in nDnHnMnS shorthand or full ISO8601 format.</p></summary>
        public virtual string Period { get; internal set; }
        /// <summary><p>Numeric threshold at which to trigger the alert.</p></summary>
        public virtual string Threshold { get; internal set; }
        /// <summary><p>Name or ID of the target resource.</p></summary>
        public virtual string Resource { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Target resource provider namespace.</p></summary>
        public virtual string ResourceNamespace { get; internal set; }
        /// <summary><p>Target resource parent path, if applicable.</p></summary>
        public virtual string ResourceParent { get; internal set; }
        /// <summary><p>Target resource type. Can also accept namespace/type format (Ex: 'Microsoft.Compute/virtualMachines)').</p></summary>
        public virtual string ResourceType { get; internal set; }
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
              .Add("monitor alert update")
              .Add("--name {value}", Name)
              .Add("--description {value}", Description)
              .Add("--enabled {value}", Enabled)
              .Add("--tags {value}", Tags)
              .Add("--add-action {value}", AddAction)
              .Add("--email-service-owners", EmailServiceOwners)
              .Add("--remove-action {value}", RemoveAction)
              .Add("--aggregation {value}", Aggregation)
              .Add("--condition {value}", Condition)
              .Add("--metric {value}", Metric)
              .Add("--operator {value}", Operator)
              .Add("--period {value}", Period)
              .Add("--threshold {value}", Threshold)
              .Add("--resource {value}", Resource)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--resource-namespace {value}", ResourceNamespace)
              .Add("--resource-parent {value}", ResourceParent)
              .Add("--resource-type {value}", ResourceType)
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
    #region AzureMonitorAutoscaleSettingsCreateSettings
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMonitorAutoscaleSettingsCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMonitor executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMonitorTasks.AzureMonitorPath;
        /// <summary><p>The autoscale setting name.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>JSON encoded parameters configuration. Use @{file} to load from a file. Use az autoscale-settings get-parameters-template to export json template.</p></summary>
        public virtual string Parameters { get; internal set; }
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
              .Add("monitor autoscale-settings create")
              .Add("--name {value}", Name)
              .Add("--parameters {value}", Parameters)
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
    #region AzureMonitorAutoscaleSettingsDeleteSettings
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMonitorAutoscaleSettingsDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMonitor executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMonitorTasks.AzureMonitorPath;
        /// <summary><p>The autoscale setting name.</p></summary>
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
              .Add("monitor autoscale-settings delete")
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
    #region AzureMonitorAutoscaleSettingsGetParametersTemplateSettings
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMonitorAutoscaleSettingsGetParametersTemplateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMonitor executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMonitorTasks.AzureMonitorPath;
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("monitor autoscale-settings get-parameters-template")
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureMonitorAutoscaleSettingsListSettings
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMonitorAutoscaleSettingsListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMonitor executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMonitorTasks.AzureMonitorPath;
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
              .Add("monitor autoscale-settings list")
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
    #region AzureMonitorAutoscaleSettingsShowSettings
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMonitorAutoscaleSettingsShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMonitor executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMonitorTasks.AzureMonitorPath;
        /// <summary><p>The autoscale setting name.</p></summary>
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
              .Add("monitor autoscale-settings show")
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
    #region AzureMonitorAutoscaleSettingsUpdateSettings
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMonitorAutoscaleSettingsUpdateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMonitor executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMonitorTasks.AzureMonitorPath;
        /// <summary><p>The autoscale setting name.</p></summary>
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
              .Add("monitor autoscale-settings update")
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
    #region AzureMonitorAutoscaleCreateSettings
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMonitorAutoscaleCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMonitor executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMonitorTasks.AzureMonitorPath;
        /// <summary><p>Create the autoscale settings in a disabled state.</p></summary>
        public virtual bool? Disabled { get; internal set; }
        /// <summary><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        public virtual string Location { get; internal set; }
        /// <summary><p>Name of the autoscale settings.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        public virtual string Tags { get; internal set; }
        /// <summary><p>The numer of instances to use. If used with --min/max-count, the default number of instances to use.</p></summary>
        public virtual string Count { get; internal set; }
        /// <summary><p>The maximum number of instances.</p></summary>
        public virtual int? MaxCount { get; internal set; }
        /// <summary><p>The minimum number of instances.</p></summary>
        public virtual int? MinCount { get; internal set; }
        /// <summary><p>Add an action to fire when a scaling event occurs.</p></summary>
        public virtual string Action { get; internal set; }
        /// <summary><p>Send email to subscription administrator on scaling.</p></summary>
        public virtual bool? EmailAdministrator { get; internal set; }
        /// <summary><p>Send email to subscription co-administrators on scaling.</p></summary>
        public virtual bool? EmailCoadministrators { get; internal set; }
        /// <summary><p>Name or ID of the target resource.</p></summary>
        public virtual string Resource { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Target resource provider namespace.</p></summary>
        public virtual string ResourceNamespace { get; internal set; }
        /// <summary><p>Target resource parent path, if applicable.</p></summary>
        public virtual string ResourceParent { get; internal set; }
        /// <summary><p>Target resource type. Can also accept namespace/type format (Ex: 'Microsoft.Compute/virtualMachines)').</p></summary>
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
              .Add("monitor autoscale create")
              .Add("--disabled", Disabled)
              .Add("--location {value}", Location)
              .Add("--name {value}", Name)
              .Add("--tags {value}", Tags)
              .Add("--count {value}", Count)
              .Add("--max-count {value}", MaxCount)
              .Add("--min-count {value}", MinCount)
              .Add("--action {value}", Action)
              .Add("--email-administrator", EmailAdministrator)
              .Add("--email-coadministrators", EmailCoadministrators)
              .Add("--resource {value}", Resource)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--resource-namespace {value}", ResourceNamespace)
              .Add("--resource-parent {value}", ResourceParent)
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
    #region AzureMonitorAutoscaleDeleteSettings
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMonitorAutoscaleDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMonitor executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMonitorTasks.AzureMonitorPath;
        /// <summary><p>Name of the autoscale settings.</p></summary>
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
              .Add("monitor autoscale delete")
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
    #region AzureMonitorAutoscaleListSettings
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMonitorAutoscaleListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMonitor executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMonitorTasks.AzureMonitorPath;
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
              .Add("monitor autoscale list")
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
    #region AzureMonitorAutoscaleShowSettings
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMonitorAutoscaleShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMonitor executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMonitorTasks.AzureMonitorPath;
        /// <summary><p>Name of the autoscale settings.</p></summary>
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
              .Add("monitor autoscale show")
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
    #region AzureMonitorAutoscaleUpdateSettings
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMonitorAutoscaleUpdateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMonitor executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMonitorTasks.AzureMonitorPath;
        /// <summary><p>Name of the autoscale settings.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Autoscale settings enabled status.</p></summary>
        public virtual bool? Enabled { get; internal set; }
        /// <summary><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        public virtual string Tags { get; internal set; }
        /// <summary><p>The numer of instances to use. If used with --min/max-count, the default number of instances to use.</p></summary>
        public virtual string Count { get; internal set; }
        /// <summary><p>The maximum number of instances.</p></summary>
        public virtual int? MaxCount { get; internal set; }
        /// <summary><p>The minimum number of instances.</p></summary>
        public virtual int? MinCount { get; internal set; }
        /// <summary><p>Add an action to fire when a scaling event occurs.</p></summary>
        public virtual string AddAction { get; internal set; }
        /// <summary><p>Send email to subscription administrator on scaling.</p></summary>
        public virtual bool? EmailAdministrator { get; internal set; }
        /// <summary><p>Send email to subscription co-administrators on scaling.</p></summary>
        public virtual bool? EmailCoadministrators { get; internal set; }
        /// <summary><p>Remove one or more actions.</p></summary>
        public virtual string RemoveAction { get; internal set; }
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
              .Add("monitor autoscale update")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--enabled", Enabled)
              .Add("--tags {value}", Tags)
              .Add("--count {value}", Count)
              .Add("--max-count {value}", MaxCount)
              .Add("--min-count {value}", MinCount)
              .Add("--add-action {value}", AddAction)
              .Add("--email-administrator", EmailAdministrator)
              .Add("--email-coadministrators", EmailCoadministrators)
              .Add("--remove-action {value}", RemoveAction)
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
    #region AzureMonitorDiagnosticSettingsCreateSettings
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMonitorDiagnosticSettingsCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMonitor executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMonitorTasks.AzureMonitorPath;
        /// <summary><p>The name of the diagnostic settings.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>The name of the event hub. If none is specified, the default event hub will be selected.</p></summary>
        public virtual string EventHub { get; internal set; }
        /// <summary><p>The resource Id for the event hub authorization rule.</p></summary>
        public virtual string EventHubRule { get; internal set; }
        /// <summary><p>JSON encoded list of logs settings. Use '@{file}' to load from a file.</p></summary>
        public virtual string Logs { get; internal set; }
        /// <summary><p>JSON encoded list of metric settings. Use '@{file}' to load from a file.</p></summary>
        public virtual string Metrics { get; internal set; }
        /// <summary><p>Name or ID of the storage account to send diagnostic logs to.</p></summary>
        public virtual string StorageAccount { get; internal set; }
        /// <summary><p>Name or ID of the Log Analytics workspace to send diagnostic logs to.</p></summary>
        public virtual string Workspace { get; internal set; }
        /// <summary><p>Name or ID of the target resource.</p></summary>
        public virtual string Resource { get; internal set; }
        /// <summary><p>Name of the resource group for the Log Analytics and Storage Account when the name of the service instead of a full resource ID is given.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Target resource provider namespace.</p></summary>
        public virtual string ResourceNamespace { get; internal set; }
        /// <summary><p>Target resource parent path, if applicable.</p></summary>
        public virtual string ResourceParent { get; internal set; }
        /// <summary><p>Target resource type. Can also accept namespace/type format (Ex: 'Microsoft.Compute/virtualMachines)').</p></summary>
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
              .Add("monitor diagnostic-settings create")
              .Add("--name {value}", Name)
              .Add("--event-hub {value}", EventHub)
              .Add("--event-hub-rule {value}", EventHubRule)
              .Add("--logs {value}", Logs)
              .Add("--metrics {value}", Metrics)
              .Add("--storage-account {value}", StorageAccount)
              .Add("--workspace {value}", Workspace)
              .Add("--resource {value}", Resource)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--resource-namespace {value}", ResourceNamespace)
              .Add("--resource-parent {value}", ResourceParent)
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
    #region AzureMonitorDiagnosticSettingsDeleteSettings
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMonitorDiagnosticSettingsDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMonitor executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMonitorTasks.AzureMonitorPath;
        /// <summary><p>The name of the diagnostic setting.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name or ID of the target resource.</p></summary>
        public virtual string Resource { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Target resource provider namespace.</p></summary>
        public virtual string ResourceNamespace { get; internal set; }
        /// <summary><p>Target resource parent path, if applicable.</p></summary>
        public virtual string ResourceParent { get; internal set; }
        /// <summary><p>Target resource type. Can also accept namespace/type format (Ex: 'Microsoft.Compute/virtualMachines)').</p></summary>
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
              .Add("monitor diagnostic-settings delete")
              .Add("--name {value}", Name)
              .Add("--resource {value}", Resource)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--resource-namespace {value}", ResourceNamespace)
              .Add("--resource-parent {value}", ResourceParent)
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
    #region AzureMonitorDiagnosticSettingsListSettings
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMonitorDiagnosticSettingsListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMonitor executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMonitorTasks.AzureMonitorPath;
        /// <summary><p>Name or ID of the target resource.</p></summary>
        public virtual string Resource { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Target resource provider namespace.</p></summary>
        public virtual string ResourceNamespace { get; internal set; }
        /// <summary><p>Target resource parent path, if applicable.</p></summary>
        public virtual string ResourceParent { get; internal set; }
        /// <summary><p>Target resource type. Can also accept namespace/type format (Ex: 'Microsoft.Compute/virtualMachines)').</p></summary>
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
              .Add("monitor diagnostic-settings list")
              .Add("--resource {value}", Resource)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--resource-namespace {value}", ResourceNamespace)
              .Add("--resource-parent {value}", ResourceParent)
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
    #region AzureMonitorDiagnosticSettingsShowSettings
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMonitorDiagnosticSettingsShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMonitor executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMonitorTasks.AzureMonitorPath;
        /// <summary><p>The name of the diagnostic setting.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name or ID of the target resource.</p></summary>
        public virtual string Resource { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Target resource provider namespace.</p></summary>
        public virtual string ResourceNamespace { get; internal set; }
        /// <summary><p>Target resource parent path, if applicable.</p></summary>
        public virtual string ResourceParent { get; internal set; }
        /// <summary><p>Target resource type. Can also accept namespace/type format (Ex: 'Microsoft.Compute/virtualMachines)').</p></summary>
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
              .Add("monitor diagnostic-settings show")
              .Add("--name {value}", Name)
              .Add("--resource {value}", Resource)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--resource-namespace {value}", ResourceNamespace)
              .Add("--resource-parent {value}", ResourceParent)
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
    #region AzureMonitorDiagnosticSettingsUpdateSettings
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMonitorDiagnosticSettingsUpdateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMonitor executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMonitorTasks.AzureMonitorPath;
        /// <summary><p>The name of the diagnostic setting.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name or ID of the target resource.</p></summary>
        public virtual string Resource { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Target resource provider namespace.</p></summary>
        public virtual string ResourceNamespace { get; internal set; }
        /// <summary><p>Target resource parent path, if applicable.</p></summary>
        public virtual string ResourceParent { get; internal set; }
        /// <summary><p>Target resource type. Can also accept namespace/type format (Ex: 'Microsoft.Compute/virtualMachines)').</p></summary>
        public virtual string ResourceType { get; internal set; }
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
              .Add("monitor diagnostic-settings update")
              .Add("--name {value}", Name)
              .Add("--resource {value}", Resource)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--resource-namespace {value}", ResourceNamespace)
              .Add("--resource-parent {value}", ResourceParent)
              .Add("--resource-type {value}", ResourceType)
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
    #region AzureMonitorLogProfilesCreateSettings
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMonitorLogProfilesCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMonitor executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMonitorTasks.AzureMonitorPath;
        /// <summary><p>Space-separated categories of the logs. These categories are created as is convenient to the user. Some values are Write, Delete, and/or Action.</p></summary>
        public virtual IReadOnlyList<string> Categories => CategoriesInternal.AsReadOnly();
        internal List<string> CategoriesInternal { get; set; } = new List<string>();
        /// <summary><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        public virtual string Location { get; internal set; }
        /// <summary><p>Space-separated list of regions for which Activity Log events should be stored.</p></summary>
        public virtual IReadOnlyList<string> Locations => LocationsInternal.AsReadOnly();
        internal List<string> LocationsInternal { get; set; } = new List<string>();
        /// <summary><p>The name of the log profile.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>The service bus rule ID of the service bus namespace in which you would like to have Event Hubs created for streaming the Activity Log. The rule ID is of the format '{service bus resource ID}/authorizationrules/{key name}'.</p></summary>
        public virtual string ServiceBusRuleId { get; internal set; }
        /// <summary><p>The resource id of the storage account to which you would like to send the Activity Log.</p></summary>
        public virtual string StorageAccountId { get; internal set; }
        /// <summary><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        public virtual string Tags { get; internal set; }
        /// <summary><p>The number of days for the retention in days. A value of 0 will retain the events indefinitely.</p></summary>
        public virtual string Days { get; internal set; }
        /// <summary><p>Whether the retention policy is enabled.</p></summary>
        public virtual bool? Enabled { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("monitor log-profiles create")
              .Add("--categories {value}", Categories, separator: ' ')
              .Add("--location {value}", Location)
              .Add("--locations {value}", Locations, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--service-bus-rule-id {value}", ServiceBusRuleId)
              .Add("--storage-account-id {value}", StorageAccountId)
              .Add("--tags {value}", Tags)
              .Add("--days {value}", Days)
              .Add("--enabled", Enabled)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureMonitorLogProfilesDeleteSettings
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMonitorLogProfilesDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMonitor executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMonitorTasks.AzureMonitorPath;
        /// <summary><p>The name of the log profile.</p></summary>
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
              .Add("monitor log-profiles delete")
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
    #region AzureMonitorLogProfilesListSettings
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMonitorLogProfilesListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMonitor executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMonitorTasks.AzureMonitorPath;
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("monitor log-profiles list")
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureMonitorLogProfilesShowSettings
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMonitorLogProfilesShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMonitor executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMonitorTasks.AzureMonitorPath;
        /// <summary><p>The name of the log profile.</p></summary>
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
              .Add("monitor log-profiles show")
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
    #region AzureMonitorLogProfilesUpdateSettings
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMonitorLogProfilesUpdateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMonitor executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMonitorTasks.AzureMonitorPath;
        /// <summary><p>The name of the log profile.</p></summary>
        public virtual string Name { get; internal set; }
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
              .Add("monitor log-profiles update")
              .Add("--name {value}", Name)
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
    #region AzureMonitorMetricsListSettings
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMonitorMetricsListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMonitor executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMonitorTasks.AzureMonitorPath;
        /// <summary><p>The list of aggregation types (space-separated) to retrieve.</p></summary>
        public virtual MonitorMetricsListAggregation Aggregation { get; internal set; }
        /// <summary><p>The list of dimensions (space-separated) the metrics are queried into.</p></summary>
        public virtual string Dimension { get; internal set; }
        /// <summary><p>A string used to reduce the set of metric data returned. eg. "BlobType eq '*'".</p></summary>
        public virtual string Filter { get; internal set; }
        /// <summary><p>Returns the metadata values instead of metric data.</p></summary>
        public virtual string Metadata { get; internal set; }
        /// <summary><p>Space-separated list of metric names to retrieve.</p></summary>
        public virtual IReadOnlyList<string> Metrics => MetricsInternal.AsReadOnly();
        internal List<string> MetricsInternal { get; set; } = new List<string>();
        /// <summary><p>Namespace to query metric definitions for.</p></summary>
        public virtual string Namespace { get; internal set; }
        /// <summary><p>The aggregation to use for sorting results and the direction of the sort. Only one order can be specified. Examples: sum asc.</p></summary>
        public virtual string Orderby { get; internal set; }
        /// <summary><p>The maximum number of records to retrieve. Valid only if $filter is specified. Defaults to 10.</p></summary>
        public virtual int? Top { get; internal set; }
        /// <summary><p>Name or ID of the target resource.</p></summary>
        public virtual string Resource { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Target resource provider namespace.</p></summary>
        public virtual string ResourceNamespace { get; internal set; }
        /// <summary><p>Target resource parent path, if applicable.</p></summary>
        public virtual string ResourceParent { get; internal set; }
        /// <summary><p>Target resource type. Can also accept namespace/type format (Ex: 'Microsoft.Compute/virtualMachines)').</p></summary>
        public virtual string ResourceType { get; internal set; }
        /// <summary><p>The end time of the query. In ISO format with explicit indication of timezone, 1970-01-01T00:00:00Z, 1970-01-01T00:00:00-0500. Defaults to the current time.</p></summary>
        public virtual string EndTime { get; internal set; }
        /// <summary><p>The interval of the metric query. In ISO 8601 duration format, eg "PT1M".</p></summary>
        public virtual string Interval { get; internal set; }
        /// <summary><p>The start time of the query. In ISO format with explicit indication of timezone, 1970-01-01T00:00:00Z, 1970-01-01T00:00:00-0500. Defaults to 1 Hour prior to the current time.</p></summary>
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
              .Add("monitor metrics list")
              .Add("--aggregation {value}", Aggregation)
              .Add("--dimension {value}", Dimension)
              .Add("--filter {value}", Filter)
              .Add("--metadata {value}", Metadata)
              .Add("--metrics {value}", Metrics, separator: ' ')
              .Add("--namespace {value}", Namespace)
              .Add("--orderby {value}", Orderby)
              .Add("--top {value}", Top)
              .Add("--resource {value}", Resource)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--resource-namespace {value}", ResourceNamespace)
              .Add("--resource-parent {value}", ResourceParent)
              .Add("--resource-type {value}", ResourceType)
              .Add("--end-time {value}", EndTime)
              .Add("--interval {value}", Interval)
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
    #region AzureMonitorMetricsListDefinitionsSettings
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMonitorMetricsListDefinitionsSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMonitor executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMonitorTasks.AzureMonitorPath;
        /// <summary><p>Namespace to query metric definitions for.</p></summary>
        public virtual string Namespace { get; internal set; }
        /// <summary><p>Name or ID of the target resource.</p></summary>
        public virtual string Resource { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Target resource provider namespace.</p></summary>
        public virtual string ResourceNamespace { get; internal set; }
        /// <summary><p>Target resource parent path, if applicable.</p></summary>
        public virtual string ResourceParent { get; internal set; }
        /// <summary><p>Target resource type. Can also accept namespace/type format (Ex: 'Microsoft.Compute/virtualMachines)').</p></summary>
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
              .Add("monitor metrics list-definitions")
              .Add("--namespace {value}", Namespace)
              .Add("--resource {value}", Resource)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--resource-namespace {value}", ResourceNamespace)
              .Add("--resource-parent {value}", ResourceParent)
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
    #region AzureMonitorActivityLogAlertCreateSettings
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMonitorActivityLogAlertCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMonitor executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMonitorTasks.AzureMonitorPath;
        /// <summary><p>Name of the activity log alerts.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Add an action group. Accepts space-separated action group identifiers. The identifier can be the action group's name or its resource ID.</p></summary>
        public virtual string ActionGroup { get; internal set; }
        /// <summary><p>The condition that will cause the alert to activate. The format is FIELD=VALUE[ and FIELD=VALUE...].</p></summary>
        public virtual string Condition { get; internal set; }
        /// <summary><p>A description of this activity log alert.</p></summary>
        public virtual string Description { get; internal set; }
        /// <summary><p>Disable the activity log alert after it is created.</p></summary>
        public virtual string Disable { get; internal set; }
        /// <summary><p>A list of strings that will be used as prefixes.</p></summary>
        public virtual string Scope { get; internal set; }
        /// <summary><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        public virtual string Tags { get; internal set; }
        /// <summary><p>Space-separated webhook properties in 'key[=value]' format. These properties are associated with the action groups added in this command.</p></summary>
        public virtual IReadOnlyList<string> WebhookProperties => WebhookPropertiesInternal.AsReadOnly();
        internal List<string> WebhookPropertiesInternal { get; set; } = new List<string>();
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("monitor activity-log alert create")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--action-group {value}", ActionGroup)
              .Add("--condition {value}", Condition)
              .Add("--description {value}", Description)
              .Add("--disable {value}", Disable)
              .Add("--scope {value}", Scope)
              .Add("--tags {value}", Tags)
              .Add("--webhook-properties {value}", WebhookProperties, separator: ' ')
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureMonitorActivityLogAlertDeleteSettings
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMonitorActivityLogAlertDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMonitor executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMonitorTasks.AzureMonitorPath;
        /// <summary><p>The name of the activity log alert.</p></summary>
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
              .Add("monitor activity-log alert delete")
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
    #region AzureMonitorActivityLogAlertListSettings
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMonitorActivityLogAlertListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMonitor executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMonitorTasks.AzureMonitorPath;
        /// <summary><p>Name of the resource group under which the activity log alerts are being listed. If it is omitted, all the activity log alerts under the current subscription are listed.</p></summary>
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
              .Add("monitor activity-log alert list")
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
    #region AzureMonitorActivityLogAlertShowSettings
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMonitorActivityLogAlertShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMonitor executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMonitorTasks.AzureMonitorPath;
        /// <summary><p>The name of the activity log alert.</p></summary>
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
              .Add("monitor activity-log alert show")
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
    #region AzureMonitorActivityLogAlertUpdateSettings
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMonitorActivityLogAlertUpdateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMonitor executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMonitorTasks.AzureMonitorPath;
        /// <summary><p>The name of the activity log alert.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The conditional expression that will cause the alert to activate. The format is FIELD=VALUE[ and FIELD=VALUE...].</p></summary>
        public virtual string Condition { get; internal set; }
        /// <summary><p>A description of this activity log alert.</p></summary>
        public virtual string Description { get; internal set; }
        /// <summary><p></p></summary>
        public virtual bool? Enabled { get; internal set; }
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
              .Add("monitor activity-log alert update")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--condition {value}", Condition)
              .Add("--description {value}", Description)
              .Add("--enabled", Enabled)
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
    #region AzureMonitorAutoscaleProfileCreateSettings
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMonitorAutoscaleProfileCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMonitor executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMonitorTasks.AzureMonitorPath;
        /// <summary><p>Name of the autoscale settings.</p></summary>
        public virtual string AutoscaleName { get; internal set; }
        /// <summary><p>Name of the autoscale profile.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name of an existing schedule from which to copy the scaling rules for the new schedule.</p></summary>
        public virtual string CopyRules { get; internal set; }
        /// <summary><p>The numer of instances to use. If used with --min/max-count, the default number of instances to use.</p></summary>
        public virtual string Count { get; internal set; }
        /// <summary><p>The maximum number of instances.</p></summary>
        public virtual int? MaxCount { get; internal set; }
        /// <summary><p>The minimum number of instances.</p></summary>
        public virtual int? MinCount { get; internal set; }
        /// <summary><p>Timezone name.</p></summary>
        public virtual string Timezone { get; internal set; }
        /// <summary><p>When the autoscale profile ends. Format depends on the type of profile.</p></summary>
        public virtual string End { get; internal set; }
        /// <summary><p>When the profile recurs. If omitted, a fixed (non-recurring) profile is created.</p></summary>
        public virtual string Recurrence { get; internal set; }
        /// <summary><p>When the autoscale profile begins. Format depends on the type of profile.</p></summary>
        public virtual string Start { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("monitor autoscale profile create")
              .Add("--autoscale-name {value}", AutoscaleName)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--copy-rules {value}", CopyRules)
              .Add("--count {value}", Count)
              .Add("--max-count {value}", MaxCount)
              .Add("--min-count {value}", MinCount)
              .Add("--timezone {value}", Timezone)
              .Add("--end {value}", End)
              .Add("--recurrence {value}", Recurrence)
              .Add("--start {value}", Start)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureMonitorAutoscaleProfileDeleteSettings
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMonitorAutoscaleProfileDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMonitor executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMonitorTasks.AzureMonitorPath;
        /// <summary><p>Name of the autoscale settings.</p></summary>
        public virtual string AutoscaleName { get; internal set; }
        /// <summary><p>Name of the autoscale profile.</p></summary>
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
              .Add("monitor autoscale profile delete")
              .Add("--autoscale-name {value}", AutoscaleName)
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
    #region AzureMonitorAutoscaleProfileListSettings
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMonitorAutoscaleProfileListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMonitor executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMonitorTasks.AzureMonitorPath;
        /// <summary><p>Name of the autoscale settings.</p></summary>
        public virtual string AutoscaleName { get; internal set; }
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
              .Add("monitor autoscale profile list")
              .Add("--autoscale-name {value}", AutoscaleName)
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
    #region AzureMonitorAutoscaleProfileListTimezonesSettings
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMonitorAutoscaleProfileListTimezonesSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMonitor executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMonitorTasks.AzureMonitorPath;
        /// <summary><p>Filter results based on UTC hour offset.</p></summary>
        public virtual string Offset { get; internal set; }
        /// <summary><p>Query text to find.</p></summary>
        public virtual string SearchQuery { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("monitor autoscale profile list-timezones")
              .Add("--offset {value}", Offset)
              .Add("--search-query {value}", SearchQuery)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureMonitorAutoscaleProfileShowSettings
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMonitorAutoscaleProfileShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMonitor executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMonitorTasks.AzureMonitorPath;
        /// <summary><p>Name of the autoscale settings.</p></summary>
        public virtual string AutoscaleName { get; internal set; }
        /// <summary><p>Name of the autoscale profile.</p></summary>
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
              .Add("monitor autoscale profile show")
              .Add("--autoscale-name {value}", AutoscaleName)
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
    #region AzureMonitorAutoscaleRuleCopySettings
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMonitorAutoscaleRuleCopySettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMonitor executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMonitorTasks.AzureMonitorPath;
        /// <summary><p>Name of the autoscale settings.</p></summary>
        public virtual string AutoscaleName { get; internal set; }
        /// <summary><p>Name of the profile to copy rules to.</p></summary>
        public virtual string DestSchedule { get; internal set; }
        /// <summary><p>Space-separated list of rule indices to copy, or '*' to copy all rules.</p></summary>
        public virtual IReadOnlyList<string> Index => IndexInternal.AsReadOnly();
        internal List<string> IndexInternal { get; set; } = new List<string>();
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name of the profile to copy rules from.</p></summary>
        public virtual string SourceSchedule { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("monitor autoscale rule copy")
              .Add("--autoscale-name {value}", AutoscaleName)
              .Add("--dest-schedule {value}", DestSchedule)
              .Add("--index {value}", Index, separator: ' ')
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--source-schedule {value}", SourceSchedule)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureMonitorAutoscaleRuleCreateSettings
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMonitorAutoscaleRuleCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMonitor executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMonitorTasks.AzureMonitorPath;
        /// <summary><p>Name of the autoscale settings.</p></summary>
        public virtual string AutoscaleName { get; internal set; }
        /// <summary><p>The condition which triggers the scaling action.</p></summary>
        public virtual string Condition { get; internal set; }
        /// <summary><p>The direction and amount to scale.</p></summary>
        public virtual string Scale { get; internal set; }
        /// <summary><p>The number of minutes that must elapse before another scaling event can occur.</p></summary>
        public virtual string Cooldown { get; internal set; }
        /// <summary><p>Name of the autoscale profile.</p></summary>
        public virtual string ProfileName { get; internal set; }
        /// <summary><p>The way metrics are polled across instances.</p></summary>
        public virtual string Timegrain { get; internal set; }
        /// <summary><p>Name or ID of the target resource.</p></summary>
        public virtual string Resource { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Target resource provider namespace.</p></summary>
        public virtual string ResourceNamespace { get; internal set; }
        /// <summary><p>Target resource parent path, if applicable.</p></summary>
        public virtual string ResourceParent { get; internal set; }
        /// <summary><p>Target resource type. Can also accept namespace/type format (Ex: 'Microsoft.Compute/virtualMachines)').</p></summary>
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
              .Add("monitor autoscale rule create")
              .Add("--autoscale-name {value}", AutoscaleName)
              .Add("--condition {value}", Condition)
              .Add("--scale {value}", Scale)
              .Add("--cooldown {value}", Cooldown)
              .Add("--profile-name {value}", ProfileName)
              .Add("--timegrain {value}", Timegrain)
              .Add("--resource {value}", Resource)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--resource-namespace {value}", ResourceNamespace)
              .Add("--resource-parent {value}", ResourceParent)
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
    #region AzureMonitorAutoscaleRuleDeleteSettings
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMonitorAutoscaleRuleDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMonitor executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMonitorTasks.AzureMonitorPath;
        /// <summary><p>Name of the autoscale settings.</p></summary>
        public virtual string AutoscaleName { get; internal set; }
        /// <summary><p>Space-separated list of rule indices to remove, or '*' to clear all rules.</p></summary>
        public virtual IReadOnlyList<string> Index => IndexInternal.AsReadOnly();
        internal List<string> IndexInternal { get; set; } = new List<string>();
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name of the autoscale profile.</p></summary>
        public virtual string ProfileName { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("monitor autoscale rule delete")
              .Add("--autoscale-name {value}", AutoscaleName)
              .Add("--index {value}", Index, separator: ' ')
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--profile-name {value}", ProfileName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureMonitorAutoscaleRuleListSettings
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMonitorAutoscaleRuleListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMonitor executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMonitorTasks.AzureMonitorPath;
        /// <summary><p>Name of the autoscale settings.</p></summary>
        public virtual string AutoscaleName { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name of the autoscale profile.</p></summary>
        public virtual string ProfileName { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("monitor autoscale rule list")
              .Add("--autoscale-name {value}", AutoscaleName)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--profile-name {value}", ProfileName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureMonitorDiagnosticSettingsCategoriesListSettings
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMonitorDiagnosticSettingsCategoriesListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMonitor executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMonitorTasks.AzureMonitorPath;
        /// <summary><p>Name or ID of the target resource.</p></summary>
        public virtual string Resource { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Target resource provider namespace.</p></summary>
        public virtual string ResourceNamespace { get; internal set; }
        /// <summary><p>Target resource parent path, if applicable.</p></summary>
        public virtual string ResourceParent { get; internal set; }
        /// <summary><p>Target resource type. Can also accept namespace/type format (Ex: 'Microsoft.Compute/virtualMachines)').</p></summary>
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
              .Add("monitor diagnostic-settings categories list")
              .Add("--resource {value}", Resource)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--resource-namespace {value}", ResourceNamespace)
              .Add("--resource-parent {value}", ResourceParent)
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
    #region AzureMonitorDiagnosticSettingsCategoriesShowSettings
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMonitorDiagnosticSettingsCategoriesShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMonitor executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMonitorTasks.AzureMonitorPath;
        /// <summary><p>The name of the diagnostic setting.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name or ID of the target resource.</p></summary>
        public virtual string Resource { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Target resource provider namespace.</p></summary>
        public virtual string ResourceNamespace { get; internal set; }
        /// <summary><p>Target resource parent path, if applicable.</p></summary>
        public virtual string ResourceParent { get; internal set; }
        /// <summary><p>Target resource type. Can also accept namespace/type format (Ex: 'Microsoft.Compute/virtualMachines)').</p></summary>
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
              .Add("monitor diagnostic-settings categories show")
              .Add("--name {value}", Name)
              .Add("--resource {value}", Resource)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--resource-namespace {value}", ResourceNamespace)
              .Add("--resource-parent {value}", ResourceParent)
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
    #region AzureMonitorMetricsAlertCreateSettings
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMonitorMetricsAlertCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMonitor executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMonitorTasks.AzureMonitorPath;
        /// <summary><p>The condition which triggers the rule.</p></summary>
        public virtual string Condition { get; internal set; }
        /// <summary><p>Free-text description of the rule.</p></summary>
        public virtual string Description { get; internal set; }
        /// <summary><p>Name of the alert rule.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Space-separated list of scopes the rule applies to.</p></summary>
        public virtual IReadOnlyList<string> Scopes => ScopesInternal.AsReadOnly();
        internal List<string> ScopesInternal { get; set; } = new List<string>();
        /// <summary><p>Add an action group and optional webhook properties to fire when the alert is triggered.</p></summary>
        public virtual string Action { get; internal set; }
        /// <summary><p>Automatically resolve the alert.</p></summary>
        public virtual bool? AutoMitigate { get; internal set; }
        /// <summary><p>Create the rule in a disabled state.</p></summary>
        public virtual bool? Disabled { get; internal set; }
        /// <summary><p>Frequency with which to evaluate the rule in "##h##m##s" format.</p></summary>
        public virtual string EvaluationFrequency { get; internal set; }
        /// <summary><p>Severity of the alert from 0 (low) to 4 (high).</p></summary>
        public virtual string Severity { get; internal set; }
        /// <summary><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        public virtual string Tags { get; internal set; }
        /// <summary><p>Time over which to aggregate metrics in "##h##m##s" format.</p></summary>
        public virtual string WindowSize { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("monitor metrics alert create")
              .Add("--condition {value}", Condition)
              .Add("--description {value}", Description)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--scopes {value}", Scopes, separator: ' ')
              .Add("--action {value}", Action)
              .Add("--auto-mitigate", AutoMitigate)
              .Add("--disabled", Disabled)
              .Add("--evaluation-frequency {value}", EvaluationFrequency)
              .Add("--severity {value}", Severity)
              .Add("--tags {value}", Tags)
              .Add("--window-size {value}", WindowSize)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureMonitorMetricsAlertDeleteSettings
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMonitorMetricsAlertDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMonitor executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMonitorTasks.AzureMonitorPath;
        /// <summary><p>Name of the alert rule.</p></summary>
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
              .Add("monitor metrics alert delete")
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
    #region AzureMonitorMetricsAlertListSettings
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMonitorMetricsAlertListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMonitor executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMonitorTasks.AzureMonitorPath;
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
              .Add("monitor metrics alert list")
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
    #region AzureMonitorMetricsAlertShowSettings
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMonitorMetricsAlertShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMonitor executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMonitorTasks.AzureMonitorPath;
        /// <summary><p>Name of the alert rule.</p></summary>
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
              .Add("monitor metrics alert show")
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
    #region AzureMonitorMetricsAlertUpdateSettings
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMonitorMetricsAlertUpdateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMonitor executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMonitorTasks.AzureMonitorPath;
        /// <summary><p>Name of the alert rule.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Automatically resolve the alert.</p></summary>
        public virtual bool? AutoMitigate { get; internal set; }
        /// <summary><p>Free-text description of the rule.</p></summary>
        public virtual string Description { get; internal set; }
        /// <summary><p>Whether the metric alert rule is enabled.</p></summary>
        public virtual bool? Enabled { get; internal set; }
        /// <summary><p>Frequency with which to evaluate the rule in "##h##m##s" format.</p></summary>
        public virtual string EvaluationFrequency { get; internal set; }
        /// <summary><p>Space-separated list of scopes the rule applies to.</p></summary>
        public virtual IReadOnlyList<string> Scopes => ScopesInternal.AsReadOnly();
        internal List<string> ScopesInternal { get; set; } = new List<string>();
        /// <summary><p>Severity of the alert from 0 (low) to 4 (high).</p></summary>
        public virtual string Severity { get; internal set; }
        /// <summary><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        public virtual string Tags { get; internal set; }
        /// <summary><p>Time over which to aggregate metrics in "##h##m##s" format.</p></summary>
        public virtual string WindowSize { get; internal set; }
        /// <summary><p>Add an action group and optional webhook properties to fire when the alert is triggered.</p></summary>
        public virtual string AddAction { get; internal set; }
        /// <summary><p>Space-separated list of action group names to remove.</p></summary>
        public virtual IReadOnlyList<string> RemoveActions => RemoveActionsInternal.AsReadOnly();
        internal List<string> RemoveActionsInternal { get; set; } = new List<string>();
        /// <summary><p>Add a condition which triggers the rule.</p></summary>
        public virtual string AddCondition { get; internal set; }
        /// <summary><p>Space-separated list of condition names to remove.</p></summary>
        public virtual IReadOnlyList<string> RemoveConditions => RemoveConditionsInternal.AsReadOnly();
        internal List<string> RemoveConditionsInternal { get; set; } = new List<string>();
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
              .Add("monitor metrics alert update")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--auto-mitigate", AutoMitigate)
              .Add("--description {value}", Description)
              .Add("--enabled", Enabled)
              .Add("--evaluation-frequency {value}", EvaluationFrequency)
              .Add("--scopes {value}", Scopes, separator: ' ')
              .Add("--severity {value}", Severity)
              .Add("--tags {value}", Tags)
              .Add("--window-size {value}", WindowSize)
              .Add("--add-action {value}", AddAction)
              .Add("--remove-actions {value}", RemoveActions, separator: ' ')
              .Add("--add-condition {value}", AddCondition)
              .Add("--remove-conditions {value}", RemoveConditions, separator: ' ')
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
    #region AzureMonitorActivityLogAlertActionGroupAddSettings
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMonitorActivityLogAlertActionGroupAddSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMonitor executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMonitorTasks.AzureMonitorPath;
        /// <summary><p>The names or the resource ids of the action groups to be added.</p></summary>
        public virtual string ActionGroup { get; internal set; }
        /// <summary><p>Name of the activity log alerts.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Remove all the existing action groups before add new conditions.</p></summary>
        public virtual string Reset { get; internal set; }
        /// <summary><p>Fails the command if an action group to be added will change existing webhook properties.</p></summary>
        public virtual string Strict { get; internal set; }
        /// <summary><p>Space-separated webhook properties in 'key[=value]' format. These properties will be associated with the action groups added in this command.</p></summary>
        public virtual IReadOnlyList<string> WebhookProperties => WebhookPropertiesInternal.AsReadOnly();
        internal List<string> WebhookPropertiesInternal { get; set; } = new List<string>();
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("monitor activity-log alert action-group add")
              .Add("--action-group {value}", ActionGroup)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--reset {value}", Reset)
              .Add("--strict {value}", Strict)
              .Add("--webhook-properties {value}", WebhookProperties, separator: ' ')
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureMonitorActivityLogAlertActionGroupRemoveSettings
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMonitorActivityLogAlertActionGroupRemoveSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMonitor executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMonitorTasks.AzureMonitorPath;
        /// <summary><p>The names or the resource ids of the action groups to be added.</p></summary>
        public virtual string ActionGroup { get; internal set; }
        /// <summary><p>Name of the activity log alerts.</p></summary>
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
              .Add("monitor activity-log alert action-group remove")
              .Add("--action-group {value}", ActionGroup)
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
    #region AzureMonitorActivityLogAlertScopeAddSettings
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMonitorActivityLogAlertScopeAddSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMonitor executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMonitorTasks.AzureMonitorPath;
        /// <summary><p>Name of the activity log alerts.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The scopes to add.</p></summary>
        public virtual string Scope { get; internal set; }
        /// <summary><p>Remove all the existing scopes before add new scopes.</p></summary>
        public virtual string Reset { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("monitor activity-log alert scope add")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--scope {value}", Scope)
              .Add("--reset {value}", Reset)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureMonitorActivityLogAlertScopeRemoveSettings
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMonitorActivityLogAlertScopeRemoveSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMonitor executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMonitorTasks.AzureMonitorPath;
        /// <summary><p>Name of the activity log alerts.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The scopes to remove.</p></summary>
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
              .Add("monitor activity-log alert scope remove")
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
    #region AzureMonitorSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMonitorSettingsExtensions
    {
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMonitorSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorSettings SetDebug(this AzureMonitorSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorSettings ResetDebug(this AzureMonitorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMonitorSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorSettings SetHelp(this AzureMonitorSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorSettings ResetHelp(this AzureMonitorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMonitorSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorSettings SetOutput(this AzureMonitorSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorSettings ResetOutput(this AzureMonitorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMonitorSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorSettings SetQuery(this AzureMonitorSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorSettings ResetQuery(this AzureMonitorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMonitorSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorSettings SetVerbose(this AzureMonitorSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorSettings ResetVerbose(this AzureMonitorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMonitorActionGroupCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMonitorActionGroupCreateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureMonitorActionGroupCreateSettings.Name"/>.</em></p><p>The name of the action group.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupCreateSettings SetName(this AzureMonitorActionGroupCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActionGroupCreateSettings.Name"/>.</em></p><p>The name of the action group.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupCreateSettings ResetName(this AzureMonitorActionGroupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureMonitorActionGroupCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupCreateSettings SetResourceGroup(this AzureMonitorActionGroupCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActionGroupCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupCreateSettings ResetResourceGroup(this AzureMonitorActionGroupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ShortName
        /// <summary><p><em>Sets <see cref="AzureMonitorActionGroupCreateSettings.ShortName"/>.</em></p><p>The short name of the action group.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupCreateSettings SetShortName(this AzureMonitorActionGroupCreateSettings toolSettings, string shortName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShortName = shortName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActionGroupCreateSettings.ShortName"/>.</em></p><p>The short name of the action group.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupCreateSettings ResetShortName(this AzureMonitorActionGroupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShortName = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary><p><em>Sets <see cref="AzureMonitorActionGroupCreateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupCreateSettings SetTags(this AzureMonitorActionGroupCreateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActionGroupCreateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupCreateSettings ResetTags(this AzureMonitorActionGroupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Action
        /// <summary><p><em>Sets <see cref="AzureMonitorActionGroupCreateSettings.Action"/>.</em></p><p>Add receivers to the action group during the creation.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupCreateSettings SetAction(this AzureMonitorActionGroupCreateSettings toolSettings, string action)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Action = action;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActionGroupCreateSettings.Action"/>.</em></p><p>Add receivers to the action group during the creation.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupCreateSettings ResetAction(this AzureMonitorActionGroupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Action = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMonitorActionGroupCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupCreateSettings SetDebug(this AzureMonitorActionGroupCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActionGroupCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupCreateSettings ResetDebug(this AzureMonitorActionGroupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMonitorActionGroupCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupCreateSettings SetHelp(this AzureMonitorActionGroupCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActionGroupCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupCreateSettings ResetHelp(this AzureMonitorActionGroupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMonitorActionGroupCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupCreateSettings SetOutput(this AzureMonitorActionGroupCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActionGroupCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupCreateSettings ResetOutput(this AzureMonitorActionGroupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMonitorActionGroupCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupCreateSettings SetQuery(this AzureMonitorActionGroupCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActionGroupCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupCreateSettings ResetQuery(this AzureMonitorActionGroupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMonitorActionGroupCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupCreateSettings SetVerbose(this AzureMonitorActionGroupCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActionGroupCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupCreateSettings ResetVerbose(this AzureMonitorActionGroupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMonitorActionGroupDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMonitorActionGroupDeleteSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureMonitorActionGroupDeleteSettings.Name"/>.</em></p><p>The name of the action group.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupDeleteSettings SetName(this AzureMonitorActionGroupDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActionGroupDeleteSettings.Name"/>.</em></p><p>The name of the action group.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupDeleteSettings ResetName(this AzureMonitorActionGroupDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureMonitorActionGroupDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupDeleteSettings SetResourceGroup(this AzureMonitorActionGroupDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActionGroupDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupDeleteSettings ResetResourceGroup(this AzureMonitorActionGroupDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMonitorActionGroupDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupDeleteSettings SetDebug(this AzureMonitorActionGroupDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActionGroupDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupDeleteSettings ResetDebug(this AzureMonitorActionGroupDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMonitorActionGroupDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupDeleteSettings SetHelp(this AzureMonitorActionGroupDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActionGroupDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupDeleteSettings ResetHelp(this AzureMonitorActionGroupDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMonitorActionGroupDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupDeleteSettings SetOutput(this AzureMonitorActionGroupDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActionGroupDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupDeleteSettings ResetOutput(this AzureMonitorActionGroupDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMonitorActionGroupDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupDeleteSettings SetQuery(this AzureMonitorActionGroupDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActionGroupDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupDeleteSettings ResetQuery(this AzureMonitorActionGroupDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMonitorActionGroupDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupDeleteSettings SetVerbose(this AzureMonitorActionGroupDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActionGroupDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupDeleteSettings ResetVerbose(this AzureMonitorActionGroupDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMonitorActionGroupEnableReceiverSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMonitorActionGroupEnableReceiverSettingsExtensions
    {
        #region ActionGroup
        /// <summary><p><em>Sets <see cref="AzureMonitorActionGroupEnableReceiverSettings.ActionGroup"/>.</em></p><p>The name of the action group.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupEnableReceiverSettings SetActionGroup(this AzureMonitorActionGroupEnableReceiverSettings toolSettings, string actionGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ActionGroup = actionGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActionGroupEnableReceiverSettings.ActionGroup"/>.</em></p><p>The name of the action group.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupEnableReceiverSettings ResetActionGroup(this AzureMonitorActionGroupEnableReceiverSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ActionGroup = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureMonitorActionGroupEnableReceiverSettings.Name"/>.</em></p><p>The name of the receiver to resubscribe.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupEnableReceiverSettings SetName(this AzureMonitorActionGroupEnableReceiverSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActionGroupEnableReceiverSettings.Name"/>.</em></p><p>The name of the receiver to resubscribe.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupEnableReceiverSettings ResetName(this AzureMonitorActionGroupEnableReceiverSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureMonitorActionGroupEnableReceiverSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupEnableReceiverSettings SetResourceGroup(this AzureMonitorActionGroupEnableReceiverSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActionGroupEnableReceiverSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupEnableReceiverSettings ResetResourceGroup(this AzureMonitorActionGroupEnableReceiverSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMonitorActionGroupEnableReceiverSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupEnableReceiverSettings SetDebug(this AzureMonitorActionGroupEnableReceiverSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActionGroupEnableReceiverSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupEnableReceiverSettings ResetDebug(this AzureMonitorActionGroupEnableReceiverSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMonitorActionGroupEnableReceiverSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupEnableReceiverSettings SetHelp(this AzureMonitorActionGroupEnableReceiverSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActionGroupEnableReceiverSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupEnableReceiverSettings ResetHelp(this AzureMonitorActionGroupEnableReceiverSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMonitorActionGroupEnableReceiverSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupEnableReceiverSettings SetOutput(this AzureMonitorActionGroupEnableReceiverSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActionGroupEnableReceiverSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupEnableReceiverSettings ResetOutput(this AzureMonitorActionGroupEnableReceiverSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMonitorActionGroupEnableReceiverSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupEnableReceiverSettings SetQuery(this AzureMonitorActionGroupEnableReceiverSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActionGroupEnableReceiverSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupEnableReceiverSettings ResetQuery(this AzureMonitorActionGroupEnableReceiverSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMonitorActionGroupEnableReceiverSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupEnableReceiverSettings SetVerbose(this AzureMonitorActionGroupEnableReceiverSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActionGroupEnableReceiverSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupEnableReceiverSettings ResetVerbose(this AzureMonitorActionGroupEnableReceiverSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMonitorActionGroupListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMonitorActionGroupListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureMonitorActionGroupListSettings.ResourceGroup"/>.</em></p><p>Name of the resource group under which the action groups are being listed. If it is omitted, all the action groups under the current subscription are listed.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupListSettings SetResourceGroup(this AzureMonitorActionGroupListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActionGroupListSettings.ResourceGroup"/>.</em></p><p>Name of the resource group under which the action groups are being listed. If it is omitted, all the action groups under the current subscription are listed.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupListSettings ResetResourceGroup(this AzureMonitorActionGroupListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMonitorActionGroupListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupListSettings SetDebug(this AzureMonitorActionGroupListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActionGroupListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupListSettings ResetDebug(this AzureMonitorActionGroupListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMonitorActionGroupListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupListSettings SetHelp(this AzureMonitorActionGroupListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActionGroupListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupListSettings ResetHelp(this AzureMonitorActionGroupListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMonitorActionGroupListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupListSettings SetOutput(this AzureMonitorActionGroupListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActionGroupListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupListSettings ResetOutput(this AzureMonitorActionGroupListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMonitorActionGroupListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupListSettings SetQuery(this AzureMonitorActionGroupListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActionGroupListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupListSettings ResetQuery(this AzureMonitorActionGroupListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMonitorActionGroupListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupListSettings SetVerbose(this AzureMonitorActionGroupListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActionGroupListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupListSettings ResetVerbose(this AzureMonitorActionGroupListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMonitorActionGroupShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMonitorActionGroupShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureMonitorActionGroupShowSettings.Name"/>.</em></p><p>The name of the action group.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupShowSettings SetName(this AzureMonitorActionGroupShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActionGroupShowSettings.Name"/>.</em></p><p>The name of the action group.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupShowSettings ResetName(this AzureMonitorActionGroupShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureMonitorActionGroupShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupShowSettings SetResourceGroup(this AzureMonitorActionGroupShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActionGroupShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupShowSettings ResetResourceGroup(this AzureMonitorActionGroupShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMonitorActionGroupShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupShowSettings SetDebug(this AzureMonitorActionGroupShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActionGroupShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupShowSettings ResetDebug(this AzureMonitorActionGroupShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMonitorActionGroupShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupShowSettings SetHelp(this AzureMonitorActionGroupShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActionGroupShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupShowSettings ResetHelp(this AzureMonitorActionGroupShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMonitorActionGroupShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupShowSettings SetOutput(this AzureMonitorActionGroupShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActionGroupShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupShowSettings ResetOutput(this AzureMonitorActionGroupShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMonitorActionGroupShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupShowSettings SetQuery(this AzureMonitorActionGroupShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActionGroupShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupShowSettings ResetQuery(this AzureMonitorActionGroupShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMonitorActionGroupShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupShowSettings SetVerbose(this AzureMonitorActionGroupShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActionGroupShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupShowSettings ResetVerbose(this AzureMonitorActionGroupShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMonitorActionGroupUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMonitorActionGroupUpdateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureMonitorActionGroupUpdateSettings.Name"/>.</em></p><p>The name of the action group.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupUpdateSettings SetName(this AzureMonitorActionGroupUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActionGroupUpdateSettings.Name"/>.</em></p><p>The name of the action group.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupUpdateSettings ResetName(this AzureMonitorActionGroupUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureMonitorActionGroupUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupUpdateSettings SetResourceGroup(this AzureMonitorActionGroupUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActionGroupUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupUpdateSettings ResetResourceGroup(this AzureMonitorActionGroupUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ShortName
        /// <summary><p><em>Sets <see cref="AzureMonitorActionGroupUpdateSettings.ShortName"/>.</em></p><p>Update the group short name of the action group.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupUpdateSettings SetShortName(this AzureMonitorActionGroupUpdateSettings toolSettings, string shortName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShortName = shortName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActionGroupUpdateSettings.ShortName"/>.</em></p><p>Update the group short name of the action group.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupUpdateSettings ResetShortName(this AzureMonitorActionGroupUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShortName = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary><p><em>Sets <see cref="AzureMonitorActionGroupUpdateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupUpdateSettings SetTags(this AzureMonitorActionGroupUpdateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActionGroupUpdateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupUpdateSettings ResetTags(this AzureMonitorActionGroupUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region AddAction
        /// <summary><p><em>Sets <see cref="AzureMonitorActionGroupUpdateSettings.AddAction"/>.</em></p><p>Add receivers to the action group.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupUpdateSettings SetAddAction(this AzureMonitorActionGroupUpdateSettings toolSettings, string addAction)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AddAction = addAction;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActionGroupUpdateSettings.AddAction"/>.</em></p><p>Add receivers to the action group.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupUpdateSettings ResetAddAction(this AzureMonitorActionGroupUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AddAction = null;
            return toolSettings;
        }
        #endregion
        #region RemoveAction
        /// <summary><p><em>Sets <see cref="AzureMonitorActionGroupUpdateSettings.RemoveAction"/>.</em></p><p>Remove receivers from the action group. Accept space-separated list of receiver names.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupUpdateSettings SetRemoveAction(this AzureMonitorActionGroupUpdateSettings toolSettings, string removeAction)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RemoveAction = removeAction;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActionGroupUpdateSettings.RemoveAction"/>.</em></p><p>Remove receivers from the action group. Accept space-separated list of receiver names.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupUpdateSettings ResetRemoveAction(this AzureMonitorActionGroupUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RemoveAction = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary><p><em>Sets <see cref="AzureMonitorActionGroupUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupUpdateSettings SetAdd(this AzureMonitorActionGroupUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActionGroupUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupUpdateSettings ResetAdd(this AzureMonitorActionGroupUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region ForceString
        /// <summary><p><em>Sets <see cref="AzureMonitorActionGroupUpdateSettings.ForceString"/>.</em></p><p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupUpdateSettings SetForceString(this AzureMonitorActionGroupUpdateSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActionGroupUpdateSettings.ForceString"/>.</em></p><p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupUpdateSettings ResetForceString(this AzureMonitorActionGroupUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary><p><em>Sets <see cref="AzureMonitorActionGroupUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupUpdateSettings SetRemove(this AzureMonitorActionGroupUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActionGroupUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupUpdateSettings ResetRemove(this AzureMonitorActionGroupUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary><p><em>Sets <see cref="AzureMonitorActionGroupUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupUpdateSettings SetSet(this AzureMonitorActionGroupUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActionGroupUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupUpdateSettings ResetSet(this AzureMonitorActionGroupUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMonitorActionGroupUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupUpdateSettings SetDebug(this AzureMonitorActionGroupUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActionGroupUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupUpdateSettings ResetDebug(this AzureMonitorActionGroupUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMonitorActionGroupUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupUpdateSettings SetHelp(this AzureMonitorActionGroupUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActionGroupUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupUpdateSettings ResetHelp(this AzureMonitorActionGroupUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMonitorActionGroupUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupUpdateSettings SetOutput(this AzureMonitorActionGroupUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActionGroupUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupUpdateSettings ResetOutput(this AzureMonitorActionGroupUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMonitorActionGroupUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupUpdateSettings SetQuery(this AzureMonitorActionGroupUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActionGroupUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupUpdateSettings ResetQuery(this AzureMonitorActionGroupUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMonitorActionGroupUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupUpdateSettings SetVerbose(this AzureMonitorActionGroupUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActionGroupUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorActionGroupUpdateSettings ResetVerbose(this AzureMonitorActionGroupUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMonitorActivityLogListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMonitorActivityLogListSettingsExtensions
    {
        #region Filters
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogListSettings.Filters"/>.</em></p><p>The OData filter for the list activity logs. If this argument is provided OData Filter Arguments will be ignored.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogListSettings SetFilters(this AzureMonitorActivityLogListSettings toolSettings, string filters)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filters = filters;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogListSettings.Filters"/>.</em></p><p>The OData filter for the list activity logs. If this argument is provided OData Filter Arguments will be ignored.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogListSettings ResetFilters(this AzureMonitorActivityLogListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filters = null;
            return toolSettings;
        }
        #endregion
        #region MaxEvents
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogListSettings.MaxEvents"/>.</em></p><p>The maximum number of records to be returned by the command.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogListSettings SetMaxEvents(this AzureMonitorActivityLogListSettings toolSettings, int? maxEvents)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MaxEvents = maxEvents;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogListSettings.MaxEvents"/>.</em></p><p>The maximum number of records to be returned by the command.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogListSettings ResetMaxEvents(this AzureMonitorActivityLogListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MaxEvents = null;
            return toolSettings;
        }
        #endregion
        #region Select
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogListSettings.Select"/>.</em></p><p>The list of event names.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogListSettings SetSelect(this AzureMonitorActivityLogListSettings toolSettings, string select)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Select = select;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogListSettings.Select"/>.</em></p><p>The list of event names.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogListSettings ResetSelect(this AzureMonitorActivityLogListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Select = null;
            return toolSettings;
        }
        #endregion
        #region Caller
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogListSettings.Caller"/>.</em></p><p>The caller to look for when querying.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogListSettings SetCaller(this AzureMonitorActivityLogListSettings toolSettings, string caller)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Caller = caller;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogListSettings.Caller"/>.</em></p><p>The caller to look for when querying.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogListSettings ResetCaller(this AzureMonitorActivityLogListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Caller = null;
            return toolSettings;
        }
        #endregion
        #region CorrelationId
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogListSettings.CorrelationId"/>.</em></p><p>The correlation id of the query.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogListSettings SetCorrelationId(this AzureMonitorActivityLogListSettings toolSettings, string correlationId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CorrelationId = correlationId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogListSettings.CorrelationId"/>.</em></p><p>The correlation id of the query.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogListSettings ResetCorrelationId(this AzureMonitorActivityLogListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CorrelationId = null;
            return toolSettings;
        }
        #endregion
        #region EndTime
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogListSettings.EndTime"/>.</em></p><p>The end time of the query. In ISO format with explicit indication of timezone: 1970-01-01T00:00:00Z, 1970-01-01T00:00:00-0500. Defaults to current time.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogListSettings SetEndTime(this AzureMonitorActivityLogListSettings toolSettings, string endTime)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndTime = endTime;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogListSettings.EndTime"/>.</em></p><p>The end time of the query. In ISO format with explicit indication of timezone: 1970-01-01T00:00:00Z, 1970-01-01T00:00:00-0500. Defaults to current time.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogListSettings ResetEndTime(this AzureMonitorActivityLogListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndTime = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogListSettings.ResourceGroup"/>.</em></p><p>The resource group.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogListSettings SetResourceGroup(this AzureMonitorActivityLogListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogListSettings.ResourceGroup"/>.</em></p><p>The resource group.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogListSettings ResetResourceGroup(this AzureMonitorActivityLogListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ResourceId
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogListSettings.ResourceId"/>.</em></p><p>The identifier of the resource.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogListSettings SetResourceId(this AzureMonitorActivityLogListSettings toolSettings, string resourceId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceId = resourceId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogListSettings.ResourceId"/>.</em></p><p>The identifier of the resource.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogListSettings ResetResourceId(this AzureMonitorActivityLogListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceId = null;
            return toolSettings;
        }
        #endregion
        #region ResourceProvider
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogListSettings.ResourceProvider"/>.</em></p><p>The resource provider.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogListSettings SetResourceProvider(this AzureMonitorActivityLogListSettings toolSettings, string resourceProvider)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceProvider = resourceProvider;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogListSettings.ResourceProvider"/>.</em></p><p>The resource provider.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogListSettings ResetResourceProvider(this AzureMonitorActivityLogListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceProvider = null;
            return toolSettings;
        }
        #endregion
        #region StartTime
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogListSettings.StartTime"/>.</em></p><p>The start time of the query. In ISO format with explicit indication of timezone: 1970-01-01T00:00:00Z, 1970-01-01T00:00:00-0500. Defaults to 1 Hour prior to the current time.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogListSettings SetStartTime(this AzureMonitorActivityLogListSettings toolSettings, string startTime)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartTime = startTime;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogListSettings.StartTime"/>.</em></p><p>The start time of the query. In ISO format with explicit indication of timezone: 1970-01-01T00:00:00Z, 1970-01-01T00:00:00-0500. Defaults to 1 Hour prior to the current time.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogListSettings ResetStartTime(this AzureMonitorActivityLogListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartTime = null;
            return toolSettings;
        }
        #endregion
        #region Status
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogListSettings.Status"/>.</em></p><p>The status value to query (ex: Failed).</p></summary>
        [Pure]
        public static AzureMonitorActivityLogListSettings SetStatus(this AzureMonitorActivityLogListSettings toolSettings, string status)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Status = status;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogListSettings.Status"/>.</em></p><p>The status value to query (ex: Failed).</p></summary>
        [Pure]
        public static AzureMonitorActivityLogListSettings ResetStatus(this AzureMonitorActivityLogListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Status = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogListSettings SetDebug(this AzureMonitorActivityLogListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogListSettings ResetDebug(this AzureMonitorActivityLogListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogListSettings SetHelp(this AzureMonitorActivityLogListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogListSettings ResetHelp(this AzureMonitorActivityLogListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogListSettings SetOutput(this AzureMonitorActivityLogListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogListSettings ResetOutput(this AzureMonitorActivityLogListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogListSettings SetQuery(this AzureMonitorActivityLogListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogListSettings ResetQuery(this AzureMonitorActivityLogListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogListSettings SetVerbose(this AzureMonitorActivityLogListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogListSettings ResetVerbose(this AzureMonitorActivityLogListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMonitorActivityLogListCategoriesSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMonitorActivityLogListCategoriesSettingsExtensions
    {
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogListCategoriesSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogListCategoriesSettings SetDebug(this AzureMonitorActivityLogListCategoriesSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogListCategoriesSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogListCategoriesSettings ResetDebug(this AzureMonitorActivityLogListCategoriesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogListCategoriesSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogListCategoriesSettings SetHelp(this AzureMonitorActivityLogListCategoriesSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogListCategoriesSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogListCategoriesSettings ResetHelp(this AzureMonitorActivityLogListCategoriesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogListCategoriesSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogListCategoriesSettings SetOutput(this AzureMonitorActivityLogListCategoriesSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogListCategoriesSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogListCategoriesSettings ResetOutput(this AzureMonitorActivityLogListCategoriesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogListCategoriesSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogListCategoriesSettings SetQuery(this AzureMonitorActivityLogListCategoriesSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogListCategoriesSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogListCategoriesSettings ResetQuery(this AzureMonitorActivityLogListCategoriesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogListCategoriesSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogListCategoriesSettings SetVerbose(this AzureMonitorActivityLogListCategoriesSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogListCategoriesSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogListCategoriesSettings ResetVerbose(this AzureMonitorActivityLogListCategoriesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMonitorAlertCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMonitorAlertCreateSettingsExtensions
    {
        #region Condition
        /// <summary><p><em>Sets <see cref="AzureMonitorAlertCreateSettings.Condition"/>.</em></p><p>The condition which triggers the rule.</p></summary>
        [Pure]
        public static AzureMonitorAlertCreateSettings SetCondition(this AzureMonitorAlertCreateSettings toolSettings, string condition)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Condition = condition;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAlertCreateSettings.Condition"/>.</em></p><p>The condition which triggers the rule.</p></summary>
        [Pure]
        public static AzureMonitorAlertCreateSettings ResetCondition(this AzureMonitorAlertCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Condition = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureMonitorAlertCreateSettings.Name"/>.</em></p><p>Name of the alert rule.</p></summary>
        [Pure]
        public static AzureMonitorAlertCreateSettings SetName(this AzureMonitorAlertCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAlertCreateSettings.Name"/>.</em></p><p>Name of the alert rule.</p></summary>
        [Pure]
        public static AzureMonitorAlertCreateSettings ResetName(this AzureMonitorAlertCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Description
        /// <summary><p><em>Sets <see cref="AzureMonitorAlertCreateSettings.Description"/>.</em></p><p>Free-text description of the rule. Defaults to the condition expression.</p></summary>
        [Pure]
        public static AzureMonitorAlertCreateSettings SetDescription(this AzureMonitorAlertCreateSettings toolSettings, string description)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Description = description;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAlertCreateSettings.Description"/>.</em></p><p>Free-text description of the rule. Defaults to the condition expression.</p></summary>
        [Pure]
        public static AzureMonitorAlertCreateSettings ResetDescription(this AzureMonitorAlertCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Description = null;
            return toolSettings;
        }
        #endregion
        #region Disabled
        /// <summary><p><em>Sets <see cref="AzureMonitorAlertCreateSettings.Disabled"/>.</em></p><p>Create the rule in a disabled state.</p></summary>
        [Pure]
        public static AzureMonitorAlertCreateSettings SetDisabled(this AzureMonitorAlertCreateSettings toolSettings, bool? disabled)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Disabled = disabled;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAlertCreateSettings.Disabled"/>.</em></p><p>Create the rule in a disabled state.</p></summary>
        [Pure]
        public static AzureMonitorAlertCreateSettings ResetDisabled(this AzureMonitorAlertCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Disabled = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureMonitorAlertCreateSettings.Disabled"/>.</em></p><p>Create the rule in a disabled state.</p></summary>
        [Pure]
        public static AzureMonitorAlertCreateSettings EnableDisabled(this AzureMonitorAlertCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Disabled = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureMonitorAlertCreateSettings.Disabled"/>.</em></p><p>Create the rule in a disabled state.</p></summary>
        [Pure]
        public static AzureMonitorAlertCreateSettings DisableDisabled(this AzureMonitorAlertCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Disabled = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureMonitorAlertCreateSettings.Disabled"/>.</em></p><p>Create the rule in a disabled state.</p></summary>
        [Pure]
        public static AzureMonitorAlertCreateSettings ToggleDisabled(this AzureMonitorAlertCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Disabled = !toolSettings.Disabled;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary><p><em>Sets <see cref="AzureMonitorAlertCreateSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorAlertCreateSettings SetLocation(this AzureMonitorAlertCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAlertCreateSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorAlertCreateSettings ResetLocation(this AzureMonitorAlertCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary><p><em>Sets <see cref="AzureMonitorAlertCreateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureMonitorAlertCreateSettings SetTags(this AzureMonitorAlertCreateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAlertCreateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureMonitorAlertCreateSettings ResetTags(this AzureMonitorAlertCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Action
        /// <summary><p><em>Sets <see cref="AzureMonitorAlertCreateSettings.Action"/>.</em></p><p>Add an action to fire when the alert is triggered.</p></summary>
        [Pure]
        public static AzureMonitorAlertCreateSettings SetAction(this AzureMonitorAlertCreateSettings toolSettings, string action)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Action = action;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAlertCreateSettings.Action"/>.</em></p><p>Add an action to fire when the alert is triggered.</p></summary>
        [Pure]
        public static AzureMonitorAlertCreateSettings ResetAction(this AzureMonitorAlertCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Action = null;
            return toolSettings;
        }
        #endregion
        #region EmailServiceOwners
        /// <summary><p><em>Sets <see cref="AzureMonitorAlertCreateSettings.EmailServiceOwners"/>.</em></p><p>Email the service owners if an alert is triggered.</p></summary>
        [Pure]
        public static AzureMonitorAlertCreateSettings SetEmailServiceOwners(this AzureMonitorAlertCreateSettings toolSettings, bool? emailServiceOwners)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EmailServiceOwners = emailServiceOwners;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAlertCreateSettings.EmailServiceOwners"/>.</em></p><p>Email the service owners if an alert is triggered.</p></summary>
        [Pure]
        public static AzureMonitorAlertCreateSettings ResetEmailServiceOwners(this AzureMonitorAlertCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EmailServiceOwners = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureMonitorAlertCreateSettings.EmailServiceOwners"/>.</em></p><p>Email the service owners if an alert is triggered.</p></summary>
        [Pure]
        public static AzureMonitorAlertCreateSettings EnableEmailServiceOwners(this AzureMonitorAlertCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EmailServiceOwners = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureMonitorAlertCreateSettings.EmailServiceOwners"/>.</em></p><p>Email the service owners if an alert is triggered.</p></summary>
        [Pure]
        public static AzureMonitorAlertCreateSettings DisableEmailServiceOwners(this AzureMonitorAlertCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EmailServiceOwners = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureMonitorAlertCreateSettings.EmailServiceOwners"/>.</em></p><p>Email the service owners if an alert is triggered.</p></summary>
        [Pure]
        public static AzureMonitorAlertCreateSettings ToggleEmailServiceOwners(this AzureMonitorAlertCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EmailServiceOwners = !toolSettings.EmailServiceOwners;
            return toolSettings;
        }
        #endregion
        #region Target
        /// <summary><p><em>Sets <see cref="AzureMonitorAlertCreateSettings.Target"/>.</em></p><p>Name or ID of the target resource.</p></summary>
        [Pure]
        public static AzureMonitorAlertCreateSettings SetTarget(this AzureMonitorAlertCreateSettings toolSettings, string target)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Target = target;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAlertCreateSettings.Target"/>.</em></p><p>Name or ID of the target resource.</p></summary>
        [Pure]
        public static AzureMonitorAlertCreateSettings ResetTarget(this AzureMonitorAlertCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Target = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureMonitorAlertCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorAlertCreateSettings SetResourceGroup(this AzureMonitorAlertCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAlertCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorAlertCreateSettings ResetResourceGroup(this AzureMonitorAlertCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region TargetNamespace
        /// <summary><p><em>Sets <see cref="AzureMonitorAlertCreateSettings.TargetNamespace"/>.</em></p><p>Target resource provider namespace.</p></summary>
        [Pure]
        public static AzureMonitorAlertCreateSettings SetTargetNamespace(this AzureMonitorAlertCreateSettings toolSettings, string targetNamespace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TargetNamespace = targetNamespace;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAlertCreateSettings.TargetNamespace"/>.</em></p><p>Target resource provider namespace.</p></summary>
        [Pure]
        public static AzureMonitorAlertCreateSettings ResetTargetNamespace(this AzureMonitorAlertCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TargetNamespace = null;
            return toolSettings;
        }
        #endregion
        #region TargetParent
        /// <summary><p><em>Sets <see cref="AzureMonitorAlertCreateSettings.TargetParent"/>.</em></p><p>Target resource parent path, if applicable.</p></summary>
        [Pure]
        public static AzureMonitorAlertCreateSettings SetTargetParent(this AzureMonitorAlertCreateSettings toolSettings, string targetParent)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TargetParent = targetParent;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAlertCreateSettings.TargetParent"/>.</em></p><p>Target resource parent path, if applicable.</p></summary>
        [Pure]
        public static AzureMonitorAlertCreateSettings ResetTargetParent(this AzureMonitorAlertCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TargetParent = null;
            return toolSettings;
        }
        #endregion
        #region TargetType
        /// <summary><p><em>Sets <see cref="AzureMonitorAlertCreateSettings.TargetType"/>.</em></p><p>Target resource type. Can also accept namespace/type format (Ex: 'Microsoft.Compute/virtualMachines)').</p></summary>
        [Pure]
        public static AzureMonitorAlertCreateSettings SetTargetType(this AzureMonitorAlertCreateSettings toolSettings, string targetType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TargetType = targetType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAlertCreateSettings.TargetType"/>.</em></p><p>Target resource type. Can also accept namespace/type format (Ex: 'Microsoft.Compute/virtualMachines)').</p></summary>
        [Pure]
        public static AzureMonitorAlertCreateSettings ResetTargetType(this AzureMonitorAlertCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TargetType = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMonitorAlertCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAlertCreateSettings SetDebug(this AzureMonitorAlertCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAlertCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAlertCreateSettings ResetDebug(this AzureMonitorAlertCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMonitorAlertCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorAlertCreateSettings SetHelp(this AzureMonitorAlertCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAlertCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorAlertCreateSettings ResetHelp(this AzureMonitorAlertCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMonitorAlertCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorAlertCreateSettings SetOutput(this AzureMonitorAlertCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAlertCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorAlertCreateSettings ResetOutput(this AzureMonitorAlertCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMonitorAlertCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorAlertCreateSettings SetQuery(this AzureMonitorAlertCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAlertCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorAlertCreateSettings ResetQuery(this AzureMonitorAlertCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMonitorAlertCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAlertCreateSettings SetVerbose(this AzureMonitorAlertCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAlertCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAlertCreateSettings ResetVerbose(this AzureMonitorAlertCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMonitorAlertDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMonitorAlertDeleteSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureMonitorAlertDeleteSettings.Name"/>.</em></p><p>Name of the alert rule.</p></summary>
        [Pure]
        public static AzureMonitorAlertDeleteSettings SetName(this AzureMonitorAlertDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAlertDeleteSettings.Name"/>.</em></p><p>Name of the alert rule.</p></summary>
        [Pure]
        public static AzureMonitorAlertDeleteSettings ResetName(this AzureMonitorAlertDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureMonitorAlertDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorAlertDeleteSettings SetResourceGroup(this AzureMonitorAlertDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAlertDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorAlertDeleteSettings ResetResourceGroup(this AzureMonitorAlertDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMonitorAlertDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAlertDeleteSettings SetDebug(this AzureMonitorAlertDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAlertDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAlertDeleteSettings ResetDebug(this AzureMonitorAlertDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMonitorAlertDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorAlertDeleteSettings SetHelp(this AzureMonitorAlertDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAlertDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorAlertDeleteSettings ResetHelp(this AzureMonitorAlertDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMonitorAlertDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorAlertDeleteSettings SetOutput(this AzureMonitorAlertDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAlertDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorAlertDeleteSettings ResetOutput(this AzureMonitorAlertDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMonitorAlertDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorAlertDeleteSettings SetQuery(this AzureMonitorAlertDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAlertDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorAlertDeleteSettings ResetQuery(this AzureMonitorAlertDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMonitorAlertDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAlertDeleteSettings SetVerbose(this AzureMonitorAlertDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAlertDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAlertDeleteSettings ResetVerbose(this AzureMonitorAlertDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMonitorAlertListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMonitorAlertListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureMonitorAlertListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorAlertListSettings SetResourceGroup(this AzureMonitorAlertListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAlertListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorAlertListSettings ResetResourceGroup(this AzureMonitorAlertListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMonitorAlertListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAlertListSettings SetDebug(this AzureMonitorAlertListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAlertListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAlertListSettings ResetDebug(this AzureMonitorAlertListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMonitorAlertListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorAlertListSettings SetHelp(this AzureMonitorAlertListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAlertListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorAlertListSettings ResetHelp(this AzureMonitorAlertListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMonitorAlertListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorAlertListSettings SetOutput(this AzureMonitorAlertListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAlertListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorAlertListSettings ResetOutput(this AzureMonitorAlertListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMonitorAlertListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorAlertListSettings SetQuery(this AzureMonitorAlertListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAlertListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorAlertListSettings ResetQuery(this AzureMonitorAlertListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMonitorAlertListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAlertListSettings SetVerbose(this AzureMonitorAlertListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAlertListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAlertListSettings ResetVerbose(this AzureMonitorAlertListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMonitorAlertListIncidentsSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMonitorAlertListIncidentsSettingsExtensions
    {
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureMonitorAlertListIncidentsSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorAlertListIncidentsSettings SetResourceGroup(this AzureMonitorAlertListIncidentsSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAlertListIncidentsSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorAlertListIncidentsSettings ResetResourceGroup(this AzureMonitorAlertListIncidentsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region RuleName
        /// <summary><p><em>Sets <see cref="AzureMonitorAlertListIncidentsSettings.RuleName"/>.</em></p><p>Name of the alert rule.</p></summary>
        [Pure]
        public static AzureMonitorAlertListIncidentsSettings SetRuleName(this AzureMonitorAlertListIncidentsSettings toolSettings, string ruleName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RuleName = ruleName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAlertListIncidentsSettings.RuleName"/>.</em></p><p>Name of the alert rule.</p></summary>
        [Pure]
        public static AzureMonitorAlertListIncidentsSettings ResetRuleName(this AzureMonitorAlertListIncidentsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RuleName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMonitorAlertListIncidentsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAlertListIncidentsSettings SetDebug(this AzureMonitorAlertListIncidentsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAlertListIncidentsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAlertListIncidentsSettings ResetDebug(this AzureMonitorAlertListIncidentsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMonitorAlertListIncidentsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorAlertListIncidentsSettings SetHelp(this AzureMonitorAlertListIncidentsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAlertListIncidentsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorAlertListIncidentsSettings ResetHelp(this AzureMonitorAlertListIncidentsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMonitorAlertListIncidentsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorAlertListIncidentsSettings SetOutput(this AzureMonitorAlertListIncidentsSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAlertListIncidentsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorAlertListIncidentsSettings ResetOutput(this AzureMonitorAlertListIncidentsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMonitorAlertListIncidentsSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorAlertListIncidentsSettings SetQuery(this AzureMonitorAlertListIncidentsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAlertListIncidentsSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorAlertListIncidentsSettings ResetQuery(this AzureMonitorAlertListIncidentsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMonitorAlertListIncidentsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAlertListIncidentsSettings SetVerbose(this AzureMonitorAlertListIncidentsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAlertListIncidentsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAlertListIncidentsSettings ResetVerbose(this AzureMonitorAlertListIncidentsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMonitorAlertShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMonitorAlertShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureMonitorAlertShowSettings.Name"/>.</em></p><p>Name of the alert rule.</p></summary>
        [Pure]
        public static AzureMonitorAlertShowSettings SetName(this AzureMonitorAlertShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAlertShowSettings.Name"/>.</em></p><p>Name of the alert rule.</p></summary>
        [Pure]
        public static AzureMonitorAlertShowSettings ResetName(this AzureMonitorAlertShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureMonitorAlertShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorAlertShowSettings SetResourceGroup(this AzureMonitorAlertShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAlertShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorAlertShowSettings ResetResourceGroup(this AzureMonitorAlertShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMonitorAlertShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAlertShowSettings SetDebug(this AzureMonitorAlertShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAlertShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAlertShowSettings ResetDebug(this AzureMonitorAlertShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMonitorAlertShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorAlertShowSettings SetHelp(this AzureMonitorAlertShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAlertShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorAlertShowSettings ResetHelp(this AzureMonitorAlertShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMonitorAlertShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorAlertShowSettings SetOutput(this AzureMonitorAlertShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAlertShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorAlertShowSettings ResetOutput(this AzureMonitorAlertShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMonitorAlertShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorAlertShowSettings SetQuery(this AzureMonitorAlertShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAlertShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorAlertShowSettings ResetQuery(this AzureMonitorAlertShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMonitorAlertShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAlertShowSettings SetVerbose(this AzureMonitorAlertShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAlertShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAlertShowSettings ResetVerbose(this AzureMonitorAlertShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMonitorAlertShowIncidentSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMonitorAlertShowIncidentSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureMonitorAlertShowIncidentSettings.Name"/>.</em></p><p>The name of the incident to retrieve.</p></summary>
        [Pure]
        public static AzureMonitorAlertShowIncidentSettings SetName(this AzureMonitorAlertShowIncidentSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAlertShowIncidentSettings.Name"/>.</em></p><p>The name of the incident to retrieve.</p></summary>
        [Pure]
        public static AzureMonitorAlertShowIncidentSettings ResetName(this AzureMonitorAlertShowIncidentSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureMonitorAlertShowIncidentSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorAlertShowIncidentSettings SetResourceGroup(this AzureMonitorAlertShowIncidentSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAlertShowIncidentSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorAlertShowIncidentSettings ResetResourceGroup(this AzureMonitorAlertShowIncidentSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region RuleName
        /// <summary><p><em>Sets <see cref="AzureMonitorAlertShowIncidentSettings.RuleName"/>.</em></p><p>Name of the alert rule.</p></summary>
        [Pure]
        public static AzureMonitorAlertShowIncidentSettings SetRuleName(this AzureMonitorAlertShowIncidentSettings toolSettings, string ruleName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RuleName = ruleName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAlertShowIncidentSettings.RuleName"/>.</em></p><p>Name of the alert rule.</p></summary>
        [Pure]
        public static AzureMonitorAlertShowIncidentSettings ResetRuleName(this AzureMonitorAlertShowIncidentSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RuleName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMonitorAlertShowIncidentSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAlertShowIncidentSettings SetDebug(this AzureMonitorAlertShowIncidentSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAlertShowIncidentSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAlertShowIncidentSettings ResetDebug(this AzureMonitorAlertShowIncidentSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMonitorAlertShowIncidentSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorAlertShowIncidentSettings SetHelp(this AzureMonitorAlertShowIncidentSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAlertShowIncidentSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorAlertShowIncidentSettings ResetHelp(this AzureMonitorAlertShowIncidentSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMonitorAlertShowIncidentSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorAlertShowIncidentSettings SetOutput(this AzureMonitorAlertShowIncidentSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAlertShowIncidentSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorAlertShowIncidentSettings ResetOutput(this AzureMonitorAlertShowIncidentSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMonitorAlertShowIncidentSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorAlertShowIncidentSettings SetQuery(this AzureMonitorAlertShowIncidentSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAlertShowIncidentSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorAlertShowIncidentSettings ResetQuery(this AzureMonitorAlertShowIncidentSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMonitorAlertShowIncidentSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAlertShowIncidentSettings SetVerbose(this AzureMonitorAlertShowIncidentSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAlertShowIncidentSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAlertShowIncidentSettings ResetVerbose(this AzureMonitorAlertShowIncidentSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMonitorAlertUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMonitorAlertUpdateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureMonitorAlertUpdateSettings.Name"/>.</em></p><p>Name of the alert rule.</p></summary>
        [Pure]
        public static AzureMonitorAlertUpdateSettings SetName(this AzureMonitorAlertUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAlertUpdateSettings.Name"/>.</em></p><p>Name of the alert rule.</p></summary>
        [Pure]
        public static AzureMonitorAlertUpdateSettings ResetName(this AzureMonitorAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Description
        /// <summary><p><em>Sets <see cref="AzureMonitorAlertUpdateSettings.Description"/>.</em></p><p>Description of the rule.</p></summary>
        [Pure]
        public static AzureMonitorAlertUpdateSettings SetDescription(this AzureMonitorAlertUpdateSettings toolSettings, string description)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Description = description;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAlertUpdateSettings.Description"/>.</em></p><p>Description of the rule.</p></summary>
        [Pure]
        public static AzureMonitorAlertUpdateSettings ResetDescription(this AzureMonitorAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Description = null;
            return toolSettings;
        }
        #endregion
        #region Enabled
        /// <summary><p><em>Sets <see cref="AzureMonitorAlertUpdateSettings.Enabled"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureMonitorAlertUpdateSettings SetEnabled(this AzureMonitorAlertUpdateSettings toolSettings, string enabled)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Enabled = enabled;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAlertUpdateSettings.Enabled"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureMonitorAlertUpdateSettings ResetEnabled(this AzureMonitorAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Enabled = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary><p><em>Sets <see cref="AzureMonitorAlertUpdateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureMonitorAlertUpdateSettings SetTags(this AzureMonitorAlertUpdateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAlertUpdateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureMonitorAlertUpdateSettings ResetTags(this AzureMonitorAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region AddAction
        /// <summary><p><em>Sets <see cref="AzureMonitorAlertUpdateSettings.AddAction"/>.</em></p><p>Add an action to fire when the alert is triggered.</p></summary>
        [Pure]
        public static AzureMonitorAlertUpdateSettings SetAddAction(this AzureMonitorAlertUpdateSettings toolSettings, string addAction)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AddAction = addAction;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAlertUpdateSettings.AddAction"/>.</em></p><p>Add an action to fire when the alert is triggered.</p></summary>
        [Pure]
        public static AzureMonitorAlertUpdateSettings ResetAddAction(this AzureMonitorAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AddAction = null;
            return toolSettings;
        }
        #endregion
        #region EmailServiceOwners
        /// <summary><p><em>Sets <see cref="AzureMonitorAlertUpdateSettings.EmailServiceOwners"/>.</em></p><p>Email the service owners if an alert is triggered.</p></summary>
        [Pure]
        public static AzureMonitorAlertUpdateSettings SetEmailServiceOwners(this AzureMonitorAlertUpdateSettings toolSettings, bool? emailServiceOwners)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EmailServiceOwners = emailServiceOwners;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAlertUpdateSettings.EmailServiceOwners"/>.</em></p><p>Email the service owners if an alert is triggered.</p></summary>
        [Pure]
        public static AzureMonitorAlertUpdateSettings ResetEmailServiceOwners(this AzureMonitorAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EmailServiceOwners = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureMonitorAlertUpdateSettings.EmailServiceOwners"/>.</em></p><p>Email the service owners if an alert is triggered.</p></summary>
        [Pure]
        public static AzureMonitorAlertUpdateSettings EnableEmailServiceOwners(this AzureMonitorAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EmailServiceOwners = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureMonitorAlertUpdateSettings.EmailServiceOwners"/>.</em></p><p>Email the service owners if an alert is triggered.</p></summary>
        [Pure]
        public static AzureMonitorAlertUpdateSettings DisableEmailServiceOwners(this AzureMonitorAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EmailServiceOwners = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureMonitorAlertUpdateSettings.EmailServiceOwners"/>.</em></p><p>Email the service owners if an alert is triggered.</p></summary>
        [Pure]
        public static AzureMonitorAlertUpdateSettings ToggleEmailServiceOwners(this AzureMonitorAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EmailServiceOwners = !toolSettings.EmailServiceOwners;
            return toolSettings;
        }
        #endregion
        #region RemoveAction
        /// <summary><p><em>Sets <see cref="AzureMonitorAlertUpdateSettings.RemoveAction"/>.</em></p><p>Remove one or more actions.</p></summary>
        [Pure]
        public static AzureMonitorAlertUpdateSettings SetRemoveAction(this AzureMonitorAlertUpdateSettings toolSettings, string removeAction)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RemoveAction = removeAction;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAlertUpdateSettings.RemoveAction"/>.</em></p><p>Remove one or more actions.</p></summary>
        [Pure]
        public static AzureMonitorAlertUpdateSettings ResetRemoveAction(this AzureMonitorAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RemoveAction = null;
            return toolSettings;
        }
        #endregion
        #region Aggregation
        /// <summary><p><em>Sets <see cref="AzureMonitorAlertUpdateSettings.Aggregation"/>.</em></p><p>Type of aggregation to apply based on --period.</p></summary>
        [Pure]
        public static AzureMonitorAlertUpdateSettings SetAggregation(this AzureMonitorAlertUpdateSettings toolSettings, MonitorAlertUpdateAggregation aggregation)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Aggregation = aggregation;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAlertUpdateSettings.Aggregation"/>.</em></p><p>Type of aggregation to apply based on --period.</p></summary>
        [Pure]
        public static AzureMonitorAlertUpdateSettings ResetAggregation(this AzureMonitorAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Aggregation = null;
            return toolSettings;
        }
        #endregion
        #region Condition
        /// <summary><p><em>Sets <see cref="AzureMonitorAlertUpdateSettings.Condition"/>.</em></p><p>The condition which triggers the rule.</p></summary>
        [Pure]
        public static AzureMonitorAlertUpdateSettings SetCondition(this AzureMonitorAlertUpdateSettings toolSettings, string condition)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Condition = condition;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAlertUpdateSettings.Condition"/>.</em></p><p>The condition which triggers the rule.</p></summary>
        [Pure]
        public static AzureMonitorAlertUpdateSettings ResetCondition(this AzureMonitorAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Condition = null;
            return toolSettings;
        }
        #endregion
        #region Metric
        /// <summary><p><em>Sets <see cref="AzureMonitorAlertUpdateSettings.Metric"/>.</em></p><p>Name of the metric to base the rule on.</p></summary>
        [Pure]
        public static AzureMonitorAlertUpdateSettings SetMetric(this AzureMonitorAlertUpdateSettings toolSettings, string metric)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Metric = metric;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAlertUpdateSettings.Metric"/>.</em></p><p>Name of the metric to base the rule on.</p></summary>
        [Pure]
        public static AzureMonitorAlertUpdateSettings ResetMetric(this AzureMonitorAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Metric = null;
            return toolSettings;
        }
        #endregion
        #region Operator
        /// <summary><p><em>Sets <see cref="AzureMonitorAlertUpdateSettings.Operator"/>.</em></p><p>How to compare the metric against the threshold.</p></summary>
        [Pure]
        public static AzureMonitorAlertUpdateSettings SetOperator(this AzureMonitorAlertUpdateSettings toolSettings, MonitorAlertUpdateOperator @operator)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Operator = @operator;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAlertUpdateSettings.Operator"/>.</em></p><p>How to compare the metric against the threshold.</p></summary>
        [Pure]
        public static AzureMonitorAlertUpdateSettings ResetOperator(this AzureMonitorAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Operator = null;
            return toolSettings;
        }
        #endregion
        #region Period
        /// <summary><p><em>Sets <see cref="AzureMonitorAlertUpdateSettings.Period"/>.</em></p><p>Time span over which to apply --aggregation, in nDnHnMnS shorthand or full ISO8601 format.</p></summary>
        [Pure]
        public static AzureMonitorAlertUpdateSettings SetPeriod(this AzureMonitorAlertUpdateSettings toolSettings, string period)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Period = period;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAlertUpdateSettings.Period"/>.</em></p><p>Time span over which to apply --aggregation, in nDnHnMnS shorthand or full ISO8601 format.</p></summary>
        [Pure]
        public static AzureMonitorAlertUpdateSettings ResetPeriod(this AzureMonitorAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Period = null;
            return toolSettings;
        }
        #endregion
        #region Threshold
        /// <summary><p><em>Sets <see cref="AzureMonitorAlertUpdateSettings.Threshold"/>.</em></p><p>Numeric threshold at which to trigger the alert.</p></summary>
        [Pure]
        public static AzureMonitorAlertUpdateSettings SetThreshold(this AzureMonitorAlertUpdateSettings toolSettings, string threshold)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Threshold = threshold;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAlertUpdateSettings.Threshold"/>.</em></p><p>Numeric threshold at which to trigger the alert.</p></summary>
        [Pure]
        public static AzureMonitorAlertUpdateSettings ResetThreshold(this AzureMonitorAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Threshold = null;
            return toolSettings;
        }
        #endregion
        #region Resource
        /// <summary><p><em>Sets <see cref="AzureMonitorAlertUpdateSettings.Resource"/>.</em></p><p>Name or ID of the target resource.</p></summary>
        [Pure]
        public static AzureMonitorAlertUpdateSettings SetResource(this AzureMonitorAlertUpdateSettings toolSettings, string resource)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = resource;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAlertUpdateSettings.Resource"/>.</em></p><p>Name or ID of the target resource.</p></summary>
        [Pure]
        public static AzureMonitorAlertUpdateSettings ResetResource(this AzureMonitorAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureMonitorAlertUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorAlertUpdateSettings SetResourceGroup(this AzureMonitorAlertUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAlertUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorAlertUpdateSettings ResetResourceGroup(this AzureMonitorAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ResourceNamespace
        /// <summary><p><em>Sets <see cref="AzureMonitorAlertUpdateSettings.ResourceNamespace"/>.</em></p><p>Target resource provider namespace.</p></summary>
        [Pure]
        public static AzureMonitorAlertUpdateSettings SetResourceNamespace(this AzureMonitorAlertUpdateSettings toolSettings, string resourceNamespace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceNamespace = resourceNamespace;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAlertUpdateSettings.ResourceNamespace"/>.</em></p><p>Target resource provider namespace.</p></summary>
        [Pure]
        public static AzureMonitorAlertUpdateSettings ResetResourceNamespace(this AzureMonitorAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceNamespace = null;
            return toolSettings;
        }
        #endregion
        #region ResourceParent
        /// <summary><p><em>Sets <see cref="AzureMonitorAlertUpdateSettings.ResourceParent"/>.</em></p><p>Target resource parent path, if applicable.</p></summary>
        [Pure]
        public static AzureMonitorAlertUpdateSettings SetResourceParent(this AzureMonitorAlertUpdateSettings toolSettings, string resourceParent)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceParent = resourceParent;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAlertUpdateSettings.ResourceParent"/>.</em></p><p>Target resource parent path, if applicable.</p></summary>
        [Pure]
        public static AzureMonitorAlertUpdateSettings ResetResourceParent(this AzureMonitorAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceParent = null;
            return toolSettings;
        }
        #endregion
        #region ResourceType
        /// <summary><p><em>Sets <see cref="AzureMonitorAlertUpdateSettings.ResourceType"/>.</em></p><p>Target resource type. Can also accept namespace/type format (Ex: 'Microsoft.Compute/virtualMachines)').</p></summary>
        [Pure]
        public static AzureMonitorAlertUpdateSettings SetResourceType(this AzureMonitorAlertUpdateSettings toolSettings, string resourceType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = resourceType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAlertUpdateSettings.ResourceType"/>.</em></p><p>Target resource type. Can also accept namespace/type format (Ex: 'Microsoft.Compute/virtualMachines)').</p></summary>
        [Pure]
        public static AzureMonitorAlertUpdateSettings ResetResourceType(this AzureMonitorAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary><p><em>Sets <see cref="AzureMonitorAlertUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureMonitorAlertUpdateSettings SetAdd(this AzureMonitorAlertUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAlertUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureMonitorAlertUpdateSettings ResetAdd(this AzureMonitorAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region ForceString
        /// <summary><p><em>Sets <see cref="AzureMonitorAlertUpdateSettings.ForceString"/>.</em></p><p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p></summary>
        [Pure]
        public static AzureMonitorAlertUpdateSettings SetForceString(this AzureMonitorAlertUpdateSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAlertUpdateSettings.ForceString"/>.</em></p><p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p></summary>
        [Pure]
        public static AzureMonitorAlertUpdateSettings ResetForceString(this AzureMonitorAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary><p><em>Sets <see cref="AzureMonitorAlertUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureMonitorAlertUpdateSettings SetRemove(this AzureMonitorAlertUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAlertUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureMonitorAlertUpdateSettings ResetRemove(this AzureMonitorAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary><p><em>Sets <see cref="AzureMonitorAlertUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureMonitorAlertUpdateSettings SetSet(this AzureMonitorAlertUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAlertUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureMonitorAlertUpdateSettings ResetSet(this AzureMonitorAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMonitorAlertUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAlertUpdateSettings SetDebug(this AzureMonitorAlertUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAlertUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAlertUpdateSettings ResetDebug(this AzureMonitorAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMonitorAlertUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorAlertUpdateSettings SetHelp(this AzureMonitorAlertUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAlertUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorAlertUpdateSettings ResetHelp(this AzureMonitorAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMonitorAlertUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorAlertUpdateSettings SetOutput(this AzureMonitorAlertUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAlertUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorAlertUpdateSettings ResetOutput(this AzureMonitorAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMonitorAlertUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorAlertUpdateSettings SetQuery(this AzureMonitorAlertUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAlertUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorAlertUpdateSettings ResetQuery(this AzureMonitorAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMonitorAlertUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAlertUpdateSettings SetVerbose(this AzureMonitorAlertUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAlertUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAlertUpdateSettings ResetVerbose(this AzureMonitorAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMonitorAutoscaleSettingsCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMonitorAutoscaleSettingsCreateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleSettingsCreateSettings.Name"/>.</em></p><p>The autoscale setting name.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsCreateSettings SetName(this AzureMonitorAutoscaleSettingsCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleSettingsCreateSettings.Name"/>.</em></p><p>The autoscale setting name.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsCreateSettings ResetName(this AzureMonitorAutoscaleSettingsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Parameters
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleSettingsCreateSettings.Parameters"/>.</em></p><p>JSON encoded parameters configuration. Use @{file} to load from a file. Use az autoscale-settings get-parameters-template to export json template.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsCreateSettings SetParameters(this AzureMonitorAutoscaleSettingsCreateSettings toolSettings, string parameters)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parameters = parameters;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleSettingsCreateSettings.Parameters"/>.</em></p><p>JSON encoded parameters configuration. Use @{file} to load from a file. Use az autoscale-settings get-parameters-template to export json template.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsCreateSettings ResetParameters(this AzureMonitorAutoscaleSettingsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parameters = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleSettingsCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsCreateSettings SetResourceGroup(this AzureMonitorAutoscaleSettingsCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleSettingsCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsCreateSettings ResetResourceGroup(this AzureMonitorAutoscaleSettingsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleSettingsCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsCreateSettings SetDebug(this AzureMonitorAutoscaleSettingsCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleSettingsCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsCreateSettings ResetDebug(this AzureMonitorAutoscaleSettingsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleSettingsCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsCreateSettings SetHelp(this AzureMonitorAutoscaleSettingsCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleSettingsCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsCreateSettings ResetHelp(this AzureMonitorAutoscaleSettingsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleSettingsCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsCreateSettings SetOutput(this AzureMonitorAutoscaleSettingsCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleSettingsCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsCreateSettings ResetOutput(this AzureMonitorAutoscaleSettingsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleSettingsCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsCreateSettings SetQuery(this AzureMonitorAutoscaleSettingsCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleSettingsCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsCreateSettings ResetQuery(this AzureMonitorAutoscaleSettingsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleSettingsCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsCreateSettings SetVerbose(this AzureMonitorAutoscaleSettingsCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleSettingsCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsCreateSettings ResetVerbose(this AzureMonitorAutoscaleSettingsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMonitorAutoscaleSettingsDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMonitorAutoscaleSettingsDeleteSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleSettingsDeleteSettings.Name"/>.</em></p><p>The autoscale setting name.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsDeleteSettings SetName(this AzureMonitorAutoscaleSettingsDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleSettingsDeleteSettings.Name"/>.</em></p><p>The autoscale setting name.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsDeleteSettings ResetName(this AzureMonitorAutoscaleSettingsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleSettingsDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsDeleteSettings SetResourceGroup(this AzureMonitorAutoscaleSettingsDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleSettingsDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsDeleteSettings ResetResourceGroup(this AzureMonitorAutoscaleSettingsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleSettingsDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsDeleteSettings SetDebug(this AzureMonitorAutoscaleSettingsDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleSettingsDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsDeleteSettings ResetDebug(this AzureMonitorAutoscaleSettingsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleSettingsDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsDeleteSettings SetHelp(this AzureMonitorAutoscaleSettingsDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleSettingsDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsDeleteSettings ResetHelp(this AzureMonitorAutoscaleSettingsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleSettingsDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsDeleteSettings SetOutput(this AzureMonitorAutoscaleSettingsDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleSettingsDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsDeleteSettings ResetOutput(this AzureMonitorAutoscaleSettingsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleSettingsDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsDeleteSettings SetQuery(this AzureMonitorAutoscaleSettingsDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleSettingsDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsDeleteSettings ResetQuery(this AzureMonitorAutoscaleSettingsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleSettingsDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsDeleteSettings SetVerbose(this AzureMonitorAutoscaleSettingsDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleSettingsDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsDeleteSettings ResetVerbose(this AzureMonitorAutoscaleSettingsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMonitorAutoscaleSettingsGetParametersTemplateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMonitorAutoscaleSettingsGetParametersTemplateSettingsExtensions
    {
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleSettingsGetParametersTemplateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsGetParametersTemplateSettings SetDebug(this AzureMonitorAutoscaleSettingsGetParametersTemplateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleSettingsGetParametersTemplateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsGetParametersTemplateSettings ResetDebug(this AzureMonitorAutoscaleSettingsGetParametersTemplateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleSettingsGetParametersTemplateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsGetParametersTemplateSettings SetHelp(this AzureMonitorAutoscaleSettingsGetParametersTemplateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleSettingsGetParametersTemplateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsGetParametersTemplateSettings ResetHelp(this AzureMonitorAutoscaleSettingsGetParametersTemplateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleSettingsGetParametersTemplateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsGetParametersTemplateSettings SetOutput(this AzureMonitorAutoscaleSettingsGetParametersTemplateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleSettingsGetParametersTemplateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsGetParametersTemplateSettings ResetOutput(this AzureMonitorAutoscaleSettingsGetParametersTemplateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleSettingsGetParametersTemplateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsGetParametersTemplateSettings SetQuery(this AzureMonitorAutoscaleSettingsGetParametersTemplateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleSettingsGetParametersTemplateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsGetParametersTemplateSettings ResetQuery(this AzureMonitorAutoscaleSettingsGetParametersTemplateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleSettingsGetParametersTemplateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsGetParametersTemplateSettings SetVerbose(this AzureMonitorAutoscaleSettingsGetParametersTemplateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleSettingsGetParametersTemplateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsGetParametersTemplateSettings ResetVerbose(this AzureMonitorAutoscaleSettingsGetParametersTemplateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMonitorAutoscaleSettingsListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMonitorAutoscaleSettingsListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleSettingsListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsListSettings SetResourceGroup(this AzureMonitorAutoscaleSettingsListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleSettingsListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsListSettings ResetResourceGroup(this AzureMonitorAutoscaleSettingsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleSettingsListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsListSettings SetDebug(this AzureMonitorAutoscaleSettingsListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleSettingsListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsListSettings ResetDebug(this AzureMonitorAutoscaleSettingsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleSettingsListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsListSettings SetHelp(this AzureMonitorAutoscaleSettingsListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleSettingsListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsListSettings ResetHelp(this AzureMonitorAutoscaleSettingsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleSettingsListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsListSettings SetOutput(this AzureMonitorAutoscaleSettingsListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleSettingsListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsListSettings ResetOutput(this AzureMonitorAutoscaleSettingsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleSettingsListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsListSettings SetQuery(this AzureMonitorAutoscaleSettingsListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleSettingsListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsListSettings ResetQuery(this AzureMonitorAutoscaleSettingsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleSettingsListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsListSettings SetVerbose(this AzureMonitorAutoscaleSettingsListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleSettingsListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsListSettings ResetVerbose(this AzureMonitorAutoscaleSettingsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMonitorAutoscaleSettingsShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMonitorAutoscaleSettingsShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleSettingsShowSettings.Name"/>.</em></p><p>The autoscale setting name.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsShowSettings SetName(this AzureMonitorAutoscaleSettingsShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleSettingsShowSettings.Name"/>.</em></p><p>The autoscale setting name.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsShowSettings ResetName(this AzureMonitorAutoscaleSettingsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleSettingsShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsShowSettings SetResourceGroup(this AzureMonitorAutoscaleSettingsShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleSettingsShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsShowSettings ResetResourceGroup(this AzureMonitorAutoscaleSettingsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleSettingsShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsShowSettings SetDebug(this AzureMonitorAutoscaleSettingsShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleSettingsShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsShowSettings ResetDebug(this AzureMonitorAutoscaleSettingsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleSettingsShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsShowSettings SetHelp(this AzureMonitorAutoscaleSettingsShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleSettingsShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsShowSettings ResetHelp(this AzureMonitorAutoscaleSettingsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleSettingsShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsShowSettings SetOutput(this AzureMonitorAutoscaleSettingsShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleSettingsShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsShowSettings ResetOutput(this AzureMonitorAutoscaleSettingsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleSettingsShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsShowSettings SetQuery(this AzureMonitorAutoscaleSettingsShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleSettingsShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsShowSettings ResetQuery(this AzureMonitorAutoscaleSettingsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleSettingsShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsShowSettings SetVerbose(this AzureMonitorAutoscaleSettingsShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleSettingsShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsShowSettings ResetVerbose(this AzureMonitorAutoscaleSettingsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMonitorAutoscaleSettingsUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMonitorAutoscaleSettingsUpdateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleSettingsUpdateSettings.Name"/>.</em></p><p>The autoscale setting name.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsUpdateSettings SetName(this AzureMonitorAutoscaleSettingsUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleSettingsUpdateSettings.Name"/>.</em></p><p>The autoscale setting name.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsUpdateSettings ResetName(this AzureMonitorAutoscaleSettingsUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleSettingsUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsUpdateSettings SetResourceGroup(this AzureMonitorAutoscaleSettingsUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleSettingsUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsUpdateSettings ResetResourceGroup(this AzureMonitorAutoscaleSettingsUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleSettingsUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsUpdateSettings SetAdd(this AzureMonitorAutoscaleSettingsUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleSettingsUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsUpdateSettings ResetAdd(this AzureMonitorAutoscaleSettingsUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region ForceString
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleSettingsUpdateSettings.ForceString"/>.</em></p><p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsUpdateSettings SetForceString(this AzureMonitorAutoscaleSettingsUpdateSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleSettingsUpdateSettings.ForceString"/>.</em></p><p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsUpdateSettings ResetForceString(this AzureMonitorAutoscaleSettingsUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleSettingsUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsUpdateSettings SetRemove(this AzureMonitorAutoscaleSettingsUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleSettingsUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsUpdateSettings ResetRemove(this AzureMonitorAutoscaleSettingsUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleSettingsUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsUpdateSettings SetSet(this AzureMonitorAutoscaleSettingsUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleSettingsUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsUpdateSettings ResetSet(this AzureMonitorAutoscaleSettingsUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleSettingsUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsUpdateSettings SetDebug(this AzureMonitorAutoscaleSettingsUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleSettingsUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsUpdateSettings ResetDebug(this AzureMonitorAutoscaleSettingsUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleSettingsUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsUpdateSettings SetHelp(this AzureMonitorAutoscaleSettingsUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleSettingsUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsUpdateSettings ResetHelp(this AzureMonitorAutoscaleSettingsUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleSettingsUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsUpdateSettings SetOutput(this AzureMonitorAutoscaleSettingsUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleSettingsUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsUpdateSettings ResetOutput(this AzureMonitorAutoscaleSettingsUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleSettingsUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsUpdateSettings SetQuery(this AzureMonitorAutoscaleSettingsUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleSettingsUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsUpdateSettings ResetQuery(this AzureMonitorAutoscaleSettingsUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleSettingsUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsUpdateSettings SetVerbose(this AzureMonitorAutoscaleSettingsUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleSettingsUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleSettingsUpdateSettings ResetVerbose(this AzureMonitorAutoscaleSettingsUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMonitorAutoscaleCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMonitorAutoscaleCreateSettingsExtensions
    {
        #region Disabled
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleCreateSettings.Disabled"/>.</em></p><p>Create the autoscale settings in a disabled state.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleCreateSettings SetDisabled(this AzureMonitorAutoscaleCreateSettings toolSettings, bool? disabled)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Disabled = disabled;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleCreateSettings.Disabled"/>.</em></p><p>Create the autoscale settings in a disabled state.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleCreateSettings ResetDisabled(this AzureMonitorAutoscaleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Disabled = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureMonitorAutoscaleCreateSettings.Disabled"/>.</em></p><p>Create the autoscale settings in a disabled state.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleCreateSettings EnableDisabled(this AzureMonitorAutoscaleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Disabled = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureMonitorAutoscaleCreateSettings.Disabled"/>.</em></p><p>Create the autoscale settings in a disabled state.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleCreateSettings DisableDisabled(this AzureMonitorAutoscaleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Disabled = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureMonitorAutoscaleCreateSettings.Disabled"/>.</em></p><p>Create the autoscale settings in a disabled state.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleCreateSettings ToggleDisabled(this AzureMonitorAutoscaleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Disabled = !toolSettings.Disabled;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleCreateSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleCreateSettings SetLocation(this AzureMonitorAutoscaleCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleCreateSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleCreateSettings ResetLocation(this AzureMonitorAutoscaleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleCreateSettings.Name"/>.</em></p><p>Name of the autoscale settings.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleCreateSettings SetName(this AzureMonitorAutoscaleCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleCreateSettings.Name"/>.</em></p><p>Name of the autoscale settings.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleCreateSettings ResetName(this AzureMonitorAutoscaleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleCreateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleCreateSettings SetTags(this AzureMonitorAutoscaleCreateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleCreateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleCreateSettings ResetTags(this AzureMonitorAutoscaleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Count
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleCreateSettings.Count"/>.</em></p><p>The numer of instances to use. If used with --min/max-count, the default number of instances to use.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleCreateSettings SetCount(this AzureMonitorAutoscaleCreateSettings toolSettings, string count)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Count = count;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleCreateSettings.Count"/>.</em></p><p>The numer of instances to use. If used with --min/max-count, the default number of instances to use.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleCreateSettings ResetCount(this AzureMonitorAutoscaleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Count = null;
            return toolSettings;
        }
        #endregion
        #region MaxCount
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleCreateSettings.MaxCount"/>.</em></p><p>The maximum number of instances.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleCreateSettings SetMaxCount(this AzureMonitorAutoscaleCreateSettings toolSettings, int? maxCount)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MaxCount = maxCount;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleCreateSettings.MaxCount"/>.</em></p><p>The maximum number of instances.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleCreateSettings ResetMaxCount(this AzureMonitorAutoscaleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MaxCount = null;
            return toolSettings;
        }
        #endregion
        #region MinCount
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleCreateSettings.MinCount"/>.</em></p><p>The minimum number of instances.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleCreateSettings SetMinCount(this AzureMonitorAutoscaleCreateSettings toolSettings, int? minCount)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MinCount = minCount;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleCreateSettings.MinCount"/>.</em></p><p>The minimum number of instances.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleCreateSettings ResetMinCount(this AzureMonitorAutoscaleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MinCount = null;
            return toolSettings;
        }
        #endregion
        #region Action
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleCreateSettings.Action"/>.</em></p><p>Add an action to fire when a scaling event occurs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleCreateSettings SetAction(this AzureMonitorAutoscaleCreateSettings toolSettings, string action)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Action = action;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleCreateSettings.Action"/>.</em></p><p>Add an action to fire when a scaling event occurs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleCreateSettings ResetAction(this AzureMonitorAutoscaleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Action = null;
            return toolSettings;
        }
        #endregion
        #region EmailAdministrator
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleCreateSettings.EmailAdministrator"/>.</em></p><p>Send email to subscription administrator on scaling.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleCreateSettings SetEmailAdministrator(this AzureMonitorAutoscaleCreateSettings toolSettings, bool? emailAdministrator)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EmailAdministrator = emailAdministrator;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleCreateSettings.EmailAdministrator"/>.</em></p><p>Send email to subscription administrator on scaling.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleCreateSettings ResetEmailAdministrator(this AzureMonitorAutoscaleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EmailAdministrator = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureMonitorAutoscaleCreateSettings.EmailAdministrator"/>.</em></p><p>Send email to subscription administrator on scaling.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleCreateSettings EnableEmailAdministrator(this AzureMonitorAutoscaleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EmailAdministrator = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureMonitorAutoscaleCreateSettings.EmailAdministrator"/>.</em></p><p>Send email to subscription administrator on scaling.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleCreateSettings DisableEmailAdministrator(this AzureMonitorAutoscaleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EmailAdministrator = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureMonitorAutoscaleCreateSettings.EmailAdministrator"/>.</em></p><p>Send email to subscription administrator on scaling.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleCreateSettings ToggleEmailAdministrator(this AzureMonitorAutoscaleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EmailAdministrator = !toolSettings.EmailAdministrator;
            return toolSettings;
        }
        #endregion
        #region EmailCoadministrators
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleCreateSettings.EmailCoadministrators"/>.</em></p><p>Send email to subscription co-administrators on scaling.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleCreateSettings SetEmailCoadministrators(this AzureMonitorAutoscaleCreateSettings toolSettings, bool? emailCoadministrators)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EmailCoadministrators = emailCoadministrators;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleCreateSettings.EmailCoadministrators"/>.</em></p><p>Send email to subscription co-administrators on scaling.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleCreateSettings ResetEmailCoadministrators(this AzureMonitorAutoscaleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EmailCoadministrators = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureMonitorAutoscaleCreateSettings.EmailCoadministrators"/>.</em></p><p>Send email to subscription co-administrators on scaling.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleCreateSettings EnableEmailCoadministrators(this AzureMonitorAutoscaleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EmailCoadministrators = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureMonitorAutoscaleCreateSettings.EmailCoadministrators"/>.</em></p><p>Send email to subscription co-administrators on scaling.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleCreateSettings DisableEmailCoadministrators(this AzureMonitorAutoscaleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EmailCoadministrators = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureMonitorAutoscaleCreateSettings.EmailCoadministrators"/>.</em></p><p>Send email to subscription co-administrators on scaling.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleCreateSettings ToggleEmailCoadministrators(this AzureMonitorAutoscaleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EmailCoadministrators = !toolSettings.EmailCoadministrators;
            return toolSettings;
        }
        #endregion
        #region Resource
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleCreateSettings.Resource"/>.</em></p><p>Name or ID of the target resource.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleCreateSettings SetResource(this AzureMonitorAutoscaleCreateSettings toolSettings, string resource)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = resource;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleCreateSettings.Resource"/>.</em></p><p>Name or ID of the target resource.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleCreateSettings ResetResource(this AzureMonitorAutoscaleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleCreateSettings SetResourceGroup(this AzureMonitorAutoscaleCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleCreateSettings ResetResourceGroup(this AzureMonitorAutoscaleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ResourceNamespace
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleCreateSettings.ResourceNamespace"/>.</em></p><p>Target resource provider namespace.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleCreateSettings SetResourceNamespace(this AzureMonitorAutoscaleCreateSettings toolSettings, string resourceNamespace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceNamespace = resourceNamespace;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleCreateSettings.ResourceNamespace"/>.</em></p><p>Target resource provider namespace.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleCreateSettings ResetResourceNamespace(this AzureMonitorAutoscaleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceNamespace = null;
            return toolSettings;
        }
        #endregion
        #region ResourceParent
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleCreateSettings.ResourceParent"/>.</em></p><p>Target resource parent path, if applicable.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleCreateSettings SetResourceParent(this AzureMonitorAutoscaleCreateSettings toolSettings, string resourceParent)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceParent = resourceParent;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleCreateSettings.ResourceParent"/>.</em></p><p>Target resource parent path, if applicable.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleCreateSettings ResetResourceParent(this AzureMonitorAutoscaleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceParent = null;
            return toolSettings;
        }
        #endregion
        #region ResourceType
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleCreateSettings.ResourceType"/>.</em></p><p>Target resource type. Can also accept namespace/type format (Ex: 'Microsoft.Compute/virtualMachines)').</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleCreateSettings SetResourceType(this AzureMonitorAutoscaleCreateSettings toolSettings, string resourceType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = resourceType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleCreateSettings.ResourceType"/>.</em></p><p>Target resource type. Can also accept namespace/type format (Ex: 'Microsoft.Compute/virtualMachines)').</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleCreateSettings ResetResourceType(this AzureMonitorAutoscaleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleCreateSettings SetDebug(this AzureMonitorAutoscaleCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleCreateSettings ResetDebug(this AzureMonitorAutoscaleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleCreateSettings SetHelp(this AzureMonitorAutoscaleCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleCreateSettings ResetHelp(this AzureMonitorAutoscaleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleCreateSettings SetOutput(this AzureMonitorAutoscaleCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleCreateSettings ResetOutput(this AzureMonitorAutoscaleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleCreateSettings SetQuery(this AzureMonitorAutoscaleCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleCreateSettings ResetQuery(this AzureMonitorAutoscaleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleCreateSettings SetVerbose(this AzureMonitorAutoscaleCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleCreateSettings ResetVerbose(this AzureMonitorAutoscaleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMonitorAutoscaleDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMonitorAutoscaleDeleteSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleDeleteSettings.Name"/>.</em></p><p>Name of the autoscale settings.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleDeleteSettings SetName(this AzureMonitorAutoscaleDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleDeleteSettings.Name"/>.</em></p><p>Name of the autoscale settings.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleDeleteSettings ResetName(this AzureMonitorAutoscaleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleDeleteSettings SetResourceGroup(this AzureMonitorAutoscaleDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleDeleteSettings ResetResourceGroup(this AzureMonitorAutoscaleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleDeleteSettings SetDebug(this AzureMonitorAutoscaleDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleDeleteSettings ResetDebug(this AzureMonitorAutoscaleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleDeleteSettings SetHelp(this AzureMonitorAutoscaleDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleDeleteSettings ResetHelp(this AzureMonitorAutoscaleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleDeleteSettings SetOutput(this AzureMonitorAutoscaleDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleDeleteSettings ResetOutput(this AzureMonitorAutoscaleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleDeleteSettings SetQuery(this AzureMonitorAutoscaleDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleDeleteSettings ResetQuery(this AzureMonitorAutoscaleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleDeleteSettings SetVerbose(this AzureMonitorAutoscaleDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleDeleteSettings ResetVerbose(this AzureMonitorAutoscaleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMonitorAutoscaleListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMonitorAutoscaleListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleListSettings SetResourceGroup(this AzureMonitorAutoscaleListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleListSettings ResetResourceGroup(this AzureMonitorAutoscaleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleListSettings SetDebug(this AzureMonitorAutoscaleListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleListSettings ResetDebug(this AzureMonitorAutoscaleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleListSettings SetHelp(this AzureMonitorAutoscaleListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleListSettings ResetHelp(this AzureMonitorAutoscaleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleListSettings SetOutput(this AzureMonitorAutoscaleListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleListSettings ResetOutput(this AzureMonitorAutoscaleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleListSettings SetQuery(this AzureMonitorAutoscaleListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleListSettings ResetQuery(this AzureMonitorAutoscaleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleListSettings SetVerbose(this AzureMonitorAutoscaleListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleListSettings ResetVerbose(this AzureMonitorAutoscaleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMonitorAutoscaleShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMonitorAutoscaleShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleShowSettings.Name"/>.</em></p><p>Name of the autoscale settings.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleShowSettings SetName(this AzureMonitorAutoscaleShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleShowSettings.Name"/>.</em></p><p>Name of the autoscale settings.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleShowSettings ResetName(this AzureMonitorAutoscaleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleShowSettings SetResourceGroup(this AzureMonitorAutoscaleShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleShowSettings ResetResourceGroup(this AzureMonitorAutoscaleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleShowSettings SetDebug(this AzureMonitorAutoscaleShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleShowSettings ResetDebug(this AzureMonitorAutoscaleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleShowSettings SetHelp(this AzureMonitorAutoscaleShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleShowSettings ResetHelp(this AzureMonitorAutoscaleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleShowSettings SetOutput(this AzureMonitorAutoscaleShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleShowSettings ResetOutput(this AzureMonitorAutoscaleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleShowSettings SetQuery(this AzureMonitorAutoscaleShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleShowSettings ResetQuery(this AzureMonitorAutoscaleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleShowSettings SetVerbose(this AzureMonitorAutoscaleShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleShowSettings ResetVerbose(this AzureMonitorAutoscaleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMonitorAutoscaleUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMonitorAutoscaleUpdateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleUpdateSettings.Name"/>.</em></p><p>Name of the autoscale settings.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleUpdateSettings SetName(this AzureMonitorAutoscaleUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleUpdateSettings.Name"/>.</em></p><p>Name of the autoscale settings.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleUpdateSettings ResetName(this AzureMonitorAutoscaleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleUpdateSettings SetResourceGroup(this AzureMonitorAutoscaleUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleUpdateSettings ResetResourceGroup(this AzureMonitorAutoscaleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Enabled
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleUpdateSettings.Enabled"/>.</em></p><p>Autoscale settings enabled status.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleUpdateSettings SetEnabled(this AzureMonitorAutoscaleUpdateSettings toolSettings, bool? enabled)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Enabled = enabled;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleUpdateSettings.Enabled"/>.</em></p><p>Autoscale settings enabled status.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleUpdateSettings ResetEnabled(this AzureMonitorAutoscaleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Enabled = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureMonitorAutoscaleUpdateSettings.Enabled"/>.</em></p><p>Autoscale settings enabled status.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleUpdateSettings EnableEnabled(this AzureMonitorAutoscaleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Enabled = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureMonitorAutoscaleUpdateSettings.Enabled"/>.</em></p><p>Autoscale settings enabled status.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleUpdateSettings DisableEnabled(this AzureMonitorAutoscaleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Enabled = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureMonitorAutoscaleUpdateSettings.Enabled"/>.</em></p><p>Autoscale settings enabled status.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleUpdateSettings ToggleEnabled(this AzureMonitorAutoscaleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Enabled = !toolSettings.Enabled;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleUpdateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleUpdateSettings SetTags(this AzureMonitorAutoscaleUpdateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleUpdateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleUpdateSettings ResetTags(this AzureMonitorAutoscaleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Count
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleUpdateSettings.Count"/>.</em></p><p>The numer of instances to use. If used with --min/max-count, the default number of instances to use.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleUpdateSettings SetCount(this AzureMonitorAutoscaleUpdateSettings toolSettings, string count)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Count = count;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleUpdateSettings.Count"/>.</em></p><p>The numer of instances to use. If used with --min/max-count, the default number of instances to use.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleUpdateSettings ResetCount(this AzureMonitorAutoscaleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Count = null;
            return toolSettings;
        }
        #endregion
        #region MaxCount
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleUpdateSettings.MaxCount"/>.</em></p><p>The maximum number of instances.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleUpdateSettings SetMaxCount(this AzureMonitorAutoscaleUpdateSettings toolSettings, int? maxCount)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MaxCount = maxCount;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleUpdateSettings.MaxCount"/>.</em></p><p>The maximum number of instances.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleUpdateSettings ResetMaxCount(this AzureMonitorAutoscaleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MaxCount = null;
            return toolSettings;
        }
        #endregion
        #region MinCount
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleUpdateSettings.MinCount"/>.</em></p><p>The minimum number of instances.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleUpdateSettings SetMinCount(this AzureMonitorAutoscaleUpdateSettings toolSettings, int? minCount)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MinCount = minCount;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleUpdateSettings.MinCount"/>.</em></p><p>The minimum number of instances.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleUpdateSettings ResetMinCount(this AzureMonitorAutoscaleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MinCount = null;
            return toolSettings;
        }
        #endregion
        #region AddAction
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleUpdateSettings.AddAction"/>.</em></p><p>Add an action to fire when a scaling event occurs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleUpdateSettings SetAddAction(this AzureMonitorAutoscaleUpdateSettings toolSettings, string addAction)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AddAction = addAction;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleUpdateSettings.AddAction"/>.</em></p><p>Add an action to fire when a scaling event occurs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleUpdateSettings ResetAddAction(this AzureMonitorAutoscaleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AddAction = null;
            return toolSettings;
        }
        #endregion
        #region EmailAdministrator
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleUpdateSettings.EmailAdministrator"/>.</em></p><p>Send email to subscription administrator on scaling.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleUpdateSettings SetEmailAdministrator(this AzureMonitorAutoscaleUpdateSettings toolSettings, bool? emailAdministrator)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EmailAdministrator = emailAdministrator;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleUpdateSettings.EmailAdministrator"/>.</em></p><p>Send email to subscription administrator on scaling.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleUpdateSettings ResetEmailAdministrator(this AzureMonitorAutoscaleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EmailAdministrator = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureMonitorAutoscaleUpdateSettings.EmailAdministrator"/>.</em></p><p>Send email to subscription administrator on scaling.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleUpdateSettings EnableEmailAdministrator(this AzureMonitorAutoscaleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EmailAdministrator = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureMonitorAutoscaleUpdateSettings.EmailAdministrator"/>.</em></p><p>Send email to subscription administrator on scaling.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleUpdateSettings DisableEmailAdministrator(this AzureMonitorAutoscaleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EmailAdministrator = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureMonitorAutoscaleUpdateSettings.EmailAdministrator"/>.</em></p><p>Send email to subscription administrator on scaling.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleUpdateSettings ToggleEmailAdministrator(this AzureMonitorAutoscaleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EmailAdministrator = !toolSettings.EmailAdministrator;
            return toolSettings;
        }
        #endregion
        #region EmailCoadministrators
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleUpdateSettings.EmailCoadministrators"/>.</em></p><p>Send email to subscription co-administrators on scaling.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleUpdateSettings SetEmailCoadministrators(this AzureMonitorAutoscaleUpdateSettings toolSettings, bool? emailCoadministrators)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EmailCoadministrators = emailCoadministrators;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleUpdateSettings.EmailCoadministrators"/>.</em></p><p>Send email to subscription co-administrators on scaling.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleUpdateSettings ResetEmailCoadministrators(this AzureMonitorAutoscaleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EmailCoadministrators = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureMonitorAutoscaleUpdateSettings.EmailCoadministrators"/>.</em></p><p>Send email to subscription co-administrators on scaling.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleUpdateSettings EnableEmailCoadministrators(this AzureMonitorAutoscaleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EmailCoadministrators = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureMonitorAutoscaleUpdateSettings.EmailCoadministrators"/>.</em></p><p>Send email to subscription co-administrators on scaling.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleUpdateSettings DisableEmailCoadministrators(this AzureMonitorAutoscaleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EmailCoadministrators = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureMonitorAutoscaleUpdateSettings.EmailCoadministrators"/>.</em></p><p>Send email to subscription co-administrators on scaling.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleUpdateSettings ToggleEmailCoadministrators(this AzureMonitorAutoscaleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EmailCoadministrators = !toolSettings.EmailCoadministrators;
            return toolSettings;
        }
        #endregion
        #region RemoveAction
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleUpdateSettings.RemoveAction"/>.</em></p><p>Remove one or more actions.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleUpdateSettings SetRemoveAction(this AzureMonitorAutoscaleUpdateSettings toolSettings, string removeAction)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RemoveAction = removeAction;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleUpdateSettings.RemoveAction"/>.</em></p><p>Remove one or more actions.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleUpdateSettings ResetRemoveAction(this AzureMonitorAutoscaleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RemoveAction = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleUpdateSettings SetAdd(this AzureMonitorAutoscaleUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleUpdateSettings ResetAdd(this AzureMonitorAutoscaleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region ForceString
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleUpdateSettings.ForceString"/>.</em></p><p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleUpdateSettings SetForceString(this AzureMonitorAutoscaleUpdateSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleUpdateSettings.ForceString"/>.</em></p><p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleUpdateSettings ResetForceString(this AzureMonitorAutoscaleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleUpdateSettings SetRemove(this AzureMonitorAutoscaleUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleUpdateSettings ResetRemove(this AzureMonitorAutoscaleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleUpdateSettings SetSet(this AzureMonitorAutoscaleUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleUpdateSettings ResetSet(this AzureMonitorAutoscaleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleUpdateSettings SetDebug(this AzureMonitorAutoscaleUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleUpdateSettings ResetDebug(this AzureMonitorAutoscaleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleUpdateSettings SetHelp(this AzureMonitorAutoscaleUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleUpdateSettings ResetHelp(this AzureMonitorAutoscaleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleUpdateSettings SetOutput(this AzureMonitorAutoscaleUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleUpdateSettings ResetOutput(this AzureMonitorAutoscaleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleUpdateSettings SetQuery(this AzureMonitorAutoscaleUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleUpdateSettings ResetQuery(this AzureMonitorAutoscaleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleUpdateSettings SetVerbose(this AzureMonitorAutoscaleUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleUpdateSettings ResetVerbose(this AzureMonitorAutoscaleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMonitorDiagnosticSettingsCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMonitorDiagnosticSettingsCreateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsCreateSettings.Name"/>.</em></p><p>The name of the diagnostic settings.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsCreateSettings SetName(this AzureMonitorDiagnosticSettingsCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsCreateSettings.Name"/>.</em></p><p>The name of the diagnostic settings.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsCreateSettings ResetName(this AzureMonitorDiagnosticSettingsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region EventHub
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsCreateSettings.EventHub"/>.</em></p><p>The name of the event hub. If none is specified, the default event hub will be selected.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsCreateSettings SetEventHub(this AzureMonitorDiagnosticSettingsCreateSettings toolSettings, string eventHub)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EventHub = eventHub;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsCreateSettings.EventHub"/>.</em></p><p>The name of the event hub. If none is specified, the default event hub will be selected.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsCreateSettings ResetEventHub(this AzureMonitorDiagnosticSettingsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EventHub = null;
            return toolSettings;
        }
        #endregion
        #region EventHubRule
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsCreateSettings.EventHubRule"/>.</em></p><p>The resource Id for the event hub authorization rule.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsCreateSettings SetEventHubRule(this AzureMonitorDiagnosticSettingsCreateSettings toolSettings, string eventHubRule)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EventHubRule = eventHubRule;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsCreateSettings.EventHubRule"/>.</em></p><p>The resource Id for the event hub authorization rule.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsCreateSettings ResetEventHubRule(this AzureMonitorDiagnosticSettingsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EventHubRule = null;
            return toolSettings;
        }
        #endregion
        #region Logs
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsCreateSettings.Logs"/>.</em></p><p>JSON encoded list of logs settings. Use '@{file}' to load from a file.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsCreateSettings SetLogs(this AzureMonitorDiagnosticSettingsCreateSettings toolSettings, string logs)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Logs = logs;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsCreateSettings.Logs"/>.</em></p><p>JSON encoded list of logs settings. Use '@{file}' to load from a file.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsCreateSettings ResetLogs(this AzureMonitorDiagnosticSettingsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Logs = null;
            return toolSettings;
        }
        #endregion
        #region Metrics
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsCreateSettings.Metrics"/>.</em></p><p>JSON encoded list of metric settings. Use '@{file}' to load from a file.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsCreateSettings SetMetrics(this AzureMonitorDiagnosticSettingsCreateSettings toolSettings, string metrics)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Metrics = metrics;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsCreateSettings.Metrics"/>.</em></p><p>JSON encoded list of metric settings. Use '@{file}' to load from a file.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsCreateSettings ResetMetrics(this AzureMonitorDiagnosticSettingsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Metrics = null;
            return toolSettings;
        }
        #endregion
        #region StorageAccount
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsCreateSettings.StorageAccount"/>.</em></p><p>Name or ID of the storage account to send diagnostic logs to.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsCreateSettings SetStorageAccount(this AzureMonitorDiagnosticSettingsCreateSettings toolSettings, string storageAccount)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageAccount = storageAccount;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsCreateSettings.StorageAccount"/>.</em></p><p>Name or ID of the storage account to send diagnostic logs to.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsCreateSettings ResetStorageAccount(this AzureMonitorDiagnosticSettingsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageAccount = null;
            return toolSettings;
        }
        #endregion
        #region Workspace
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsCreateSettings.Workspace"/>.</em></p><p>Name or ID of the Log Analytics workspace to send diagnostic logs to.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsCreateSettings SetWorkspace(this AzureMonitorDiagnosticSettingsCreateSettings toolSettings, string workspace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = workspace;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsCreateSettings.Workspace"/>.</em></p><p>Name or ID of the Log Analytics workspace to send diagnostic logs to.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsCreateSettings ResetWorkspace(this AzureMonitorDiagnosticSettingsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = null;
            return toolSettings;
        }
        #endregion
        #region Resource
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsCreateSettings.Resource"/>.</em></p><p>Name or ID of the target resource.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsCreateSettings SetResource(this AzureMonitorDiagnosticSettingsCreateSettings toolSettings, string resource)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = resource;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsCreateSettings.Resource"/>.</em></p><p>Name or ID of the target resource.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsCreateSettings ResetResource(this AzureMonitorDiagnosticSettingsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsCreateSettings.ResourceGroup"/>.</em></p><p>Name of the resource group for the Log Analytics and Storage Account when the name of the service instead of a full resource ID is given.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsCreateSettings SetResourceGroup(this AzureMonitorDiagnosticSettingsCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsCreateSettings.ResourceGroup"/>.</em></p><p>Name of the resource group for the Log Analytics and Storage Account when the name of the service instead of a full resource ID is given.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsCreateSettings ResetResourceGroup(this AzureMonitorDiagnosticSettingsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ResourceNamespace
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsCreateSettings.ResourceNamespace"/>.</em></p><p>Target resource provider namespace.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsCreateSettings SetResourceNamespace(this AzureMonitorDiagnosticSettingsCreateSettings toolSettings, string resourceNamespace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceNamespace = resourceNamespace;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsCreateSettings.ResourceNamespace"/>.</em></p><p>Target resource provider namespace.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsCreateSettings ResetResourceNamespace(this AzureMonitorDiagnosticSettingsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceNamespace = null;
            return toolSettings;
        }
        #endregion
        #region ResourceParent
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsCreateSettings.ResourceParent"/>.</em></p><p>Target resource parent path, if applicable.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsCreateSettings SetResourceParent(this AzureMonitorDiagnosticSettingsCreateSettings toolSettings, string resourceParent)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceParent = resourceParent;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsCreateSettings.ResourceParent"/>.</em></p><p>Target resource parent path, if applicable.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsCreateSettings ResetResourceParent(this AzureMonitorDiagnosticSettingsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceParent = null;
            return toolSettings;
        }
        #endregion
        #region ResourceType
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsCreateSettings.ResourceType"/>.</em></p><p>Target resource type. Can also accept namespace/type format (Ex: 'Microsoft.Compute/virtualMachines)').</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsCreateSettings SetResourceType(this AzureMonitorDiagnosticSettingsCreateSettings toolSettings, string resourceType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = resourceType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsCreateSettings.ResourceType"/>.</em></p><p>Target resource type. Can also accept namespace/type format (Ex: 'Microsoft.Compute/virtualMachines)').</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsCreateSettings ResetResourceType(this AzureMonitorDiagnosticSettingsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsCreateSettings SetDebug(this AzureMonitorDiagnosticSettingsCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsCreateSettings ResetDebug(this AzureMonitorDiagnosticSettingsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsCreateSettings SetHelp(this AzureMonitorDiagnosticSettingsCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsCreateSettings ResetHelp(this AzureMonitorDiagnosticSettingsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsCreateSettings SetOutput(this AzureMonitorDiagnosticSettingsCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsCreateSettings ResetOutput(this AzureMonitorDiagnosticSettingsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsCreateSettings SetQuery(this AzureMonitorDiagnosticSettingsCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsCreateSettings ResetQuery(this AzureMonitorDiagnosticSettingsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsCreateSettings SetVerbose(this AzureMonitorDiagnosticSettingsCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsCreateSettings ResetVerbose(this AzureMonitorDiagnosticSettingsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMonitorDiagnosticSettingsDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMonitorDiagnosticSettingsDeleteSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsDeleteSettings.Name"/>.</em></p><p>The name of the diagnostic setting.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsDeleteSettings SetName(this AzureMonitorDiagnosticSettingsDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsDeleteSettings.Name"/>.</em></p><p>The name of the diagnostic setting.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsDeleteSettings ResetName(this AzureMonitorDiagnosticSettingsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Resource
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsDeleteSettings.Resource"/>.</em></p><p>Name or ID of the target resource.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsDeleteSettings SetResource(this AzureMonitorDiagnosticSettingsDeleteSettings toolSettings, string resource)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = resource;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsDeleteSettings.Resource"/>.</em></p><p>Name or ID of the target resource.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsDeleteSettings ResetResource(this AzureMonitorDiagnosticSettingsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsDeleteSettings SetResourceGroup(this AzureMonitorDiagnosticSettingsDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsDeleteSettings ResetResourceGroup(this AzureMonitorDiagnosticSettingsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ResourceNamespace
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsDeleteSettings.ResourceNamespace"/>.</em></p><p>Target resource provider namespace.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsDeleteSettings SetResourceNamespace(this AzureMonitorDiagnosticSettingsDeleteSettings toolSettings, string resourceNamespace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceNamespace = resourceNamespace;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsDeleteSettings.ResourceNamespace"/>.</em></p><p>Target resource provider namespace.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsDeleteSettings ResetResourceNamespace(this AzureMonitorDiagnosticSettingsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceNamespace = null;
            return toolSettings;
        }
        #endregion
        #region ResourceParent
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsDeleteSettings.ResourceParent"/>.</em></p><p>Target resource parent path, if applicable.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsDeleteSettings SetResourceParent(this AzureMonitorDiagnosticSettingsDeleteSettings toolSettings, string resourceParent)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceParent = resourceParent;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsDeleteSettings.ResourceParent"/>.</em></p><p>Target resource parent path, if applicable.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsDeleteSettings ResetResourceParent(this AzureMonitorDiagnosticSettingsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceParent = null;
            return toolSettings;
        }
        #endregion
        #region ResourceType
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsDeleteSettings.ResourceType"/>.</em></p><p>Target resource type. Can also accept namespace/type format (Ex: 'Microsoft.Compute/virtualMachines)').</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsDeleteSettings SetResourceType(this AzureMonitorDiagnosticSettingsDeleteSettings toolSettings, string resourceType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = resourceType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsDeleteSettings.ResourceType"/>.</em></p><p>Target resource type. Can also accept namespace/type format (Ex: 'Microsoft.Compute/virtualMachines)').</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsDeleteSettings ResetResourceType(this AzureMonitorDiagnosticSettingsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsDeleteSettings SetDebug(this AzureMonitorDiagnosticSettingsDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsDeleteSettings ResetDebug(this AzureMonitorDiagnosticSettingsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsDeleteSettings SetHelp(this AzureMonitorDiagnosticSettingsDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsDeleteSettings ResetHelp(this AzureMonitorDiagnosticSettingsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsDeleteSettings SetOutput(this AzureMonitorDiagnosticSettingsDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsDeleteSettings ResetOutput(this AzureMonitorDiagnosticSettingsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsDeleteSettings SetQuery(this AzureMonitorDiagnosticSettingsDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsDeleteSettings ResetQuery(this AzureMonitorDiagnosticSettingsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsDeleteSettings SetVerbose(this AzureMonitorDiagnosticSettingsDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsDeleteSettings ResetVerbose(this AzureMonitorDiagnosticSettingsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMonitorDiagnosticSettingsListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMonitorDiagnosticSettingsListSettingsExtensions
    {
        #region Resource
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsListSettings.Resource"/>.</em></p><p>Name or ID of the target resource.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsListSettings SetResource(this AzureMonitorDiagnosticSettingsListSettings toolSettings, string resource)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = resource;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsListSettings.Resource"/>.</em></p><p>Name or ID of the target resource.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsListSettings ResetResource(this AzureMonitorDiagnosticSettingsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsListSettings SetResourceGroup(this AzureMonitorDiagnosticSettingsListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsListSettings ResetResourceGroup(this AzureMonitorDiagnosticSettingsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ResourceNamespace
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsListSettings.ResourceNamespace"/>.</em></p><p>Target resource provider namespace.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsListSettings SetResourceNamespace(this AzureMonitorDiagnosticSettingsListSettings toolSettings, string resourceNamespace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceNamespace = resourceNamespace;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsListSettings.ResourceNamespace"/>.</em></p><p>Target resource provider namespace.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsListSettings ResetResourceNamespace(this AzureMonitorDiagnosticSettingsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceNamespace = null;
            return toolSettings;
        }
        #endregion
        #region ResourceParent
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsListSettings.ResourceParent"/>.</em></p><p>Target resource parent path, if applicable.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsListSettings SetResourceParent(this AzureMonitorDiagnosticSettingsListSettings toolSettings, string resourceParent)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceParent = resourceParent;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsListSettings.ResourceParent"/>.</em></p><p>Target resource parent path, if applicable.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsListSettings ResetResourceParent(this AzureMonitorDiagnosticSettingsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceParent = null;
            return toolSettings;
        }
        #endregion
        #region ResourceType
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsListSettings.ResourceType"/>.</em></p><p>Target resource type. Can also accept namespace/type format (Ex: 'Microsoft.Compute/virtualMachines)').</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsListSettings SetResourceType(this AzureMonitorDiagnosticSettingsListSettings toolSettings, string resourceType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = resourceType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsListSettings.ResourceType"/>.</em></p><p>Target resource type. Can also accept namespace/type format (Ex: 'Microsoft.Compute/virtualMachines)').</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsListSettings ResetResourceType(this AzureMonitorDiagnosticSettingsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsListSettings SetDebug(this AzureMonitorDiagnosticSettingsListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsListSettings ResetDebug(this AzureMonitorDiagnosticSettingsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsListSettings SetHelp(this AzureMonitorDiagnosticSettingsListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsListSettings ResetHelp(this AzureMonitorDiagnosticSettingsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsListSettings SetOutput(this AzureMonitorDiagnosticSettingsListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsListSettings ResetOutput(this AzureMonitorDiagnosticSettingsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsListSettings SetQuery(this AzureMonitorDiagnosticSettingsListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsListSettings ResetQuery(this AzureMonitorDiagnosticSettingsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsListSettings SetVerbose(this AzureMonitorDiagnosticSettingsListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsListSettings ResetVerbose(this AzureMonitorDiagnosticSettingsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMonitorDiagnosticSettingsShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMonitorDiagnosticSettingsShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsShowSettings.Name"/>.</em></p><p>The name of the diagnostic setting.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsShowSettings SetName(this AzureMonitorDiagnosticSettingsShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsShowSettings.Name"/>.</em></p><p>The name of the diagnostic setting.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsShowSettings ResetName(this AzureMonitorDiagnosticSettingsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Resource
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsShowSettings.Resource"/>.</em></p><p>Name or ID of the target resource.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsShowSettings SetResource(this AzureMonitorDiagnosticSettingsShowSettings toolSettings, string resource)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = resource;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsShowSettings.Resource"/>.</em></p><p>Name or ID of the target resource.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsShowSettings ResetResource(this AzureMonitorDiagnosticSettingsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsShowSettings SetResourceGroup(this AzureMonitorDiagnosticSettingsShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsShowSettings ResetResourceGroup(this AzureMonitorDiagnosticSettingsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ResourceNamespace
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsShowSettings.ResourceNamespace"/>.</em></p><p>Target resource provider namespace.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsShowSettings SetResourceNamespace(this AzureMonitorDiagnosticSettingsShowSettings toolSettings, string resourceNamespace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceNamespace = resourceNamespace;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsShowSettings.ResourceNamespace"/>.</em></p><p>Target resource provider namespace.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsShowSettings ResetResourceNamespace(this AzureMonitorDiagnosticSettingsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceNamespace = null;
            return toolSettings;
        }
        #endregion
        #region ResourceParent
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsShowSettings.ResourceParent"/>.</em></p><p>Target resource parent path, if applicable.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsShowSettings SetResourceParent(this AzureMonitorDiagnosticSettingsShowSettings toolSettings, string resourceParent)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceParent = resourceParent;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsShowSettings.ResourceParent"/>.</em></p><p>Target resource parent path, if applicable.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsShowSettings ResetResourceParent(this AzureMonitorDiagnosticSettingsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceParent = null;
            return toolSettings;
        }
        #endregion
        #region ResourceType
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsShowSettings.ResourceType"/>.</em></p><p>Target resource type. Can also accept namespace/type format (Ex: 'Microsoft.Compute/virtualMachines)').</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsShowSettings SetResourceType(this AzureMonitorDiagnosticSettingsShowSettings toolSettings, string resourceType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = resourceType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsShowSettings.ResourceType"/>.</em></p><p>Target resource type. Can also accept namespace/type format (Ex: 'Microsoft.Compute/virtualMachines)').</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsShowSettings ResetResourceType(this AzureMonitorDiagnosticSettingsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsShowSettings SetDebug(this AzureMonitorDiagnosticSettingsShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsShowSettings ResetDebug(this AzureMonitorDiagnosticSettingsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsShowSettings SetHelp(this AzureMonitorDiagnosticSettingsShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsShowSettings ResetHelp(this AzureMonitorDiagnosticSettingsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsShowSettings SetOutput(this AzureMonitorDiagnosticSettingsShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsShowSettings ResetOutput(this AzureMonitorDiagnosticSettingsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsShowSettings SetQuery(this AzureMonitorDiagnosticSettingsShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsShowSettings ResetQuery(this AzureMonitorDiagnosticSettingsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsShowSettings SetVerbose(this AzureMonitorDiagnosticSettingsShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsShowSettings ResetVerbose(this AzureMonitorDiagnosticSettingsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMonitorDiagnosticSettingsUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMonitorDiagnosticSettingsUpdateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsUpdateSettings.Name"/>.</em></p><p>The name of the diagnostic setting.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsUpdateSettings SetName(this AzureMonitorDiagnosticSettingsUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsUpdateSettings.Name"/>.</em></p><p>The name of the diagnostic setting.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsUpdateSettings ResetName(this AzureMonitorDiagnosticSettingsUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Resource
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsUpdateSettings.Resource"/>.</em></p><p>Name or ID of the target resource.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsUpdateSettings SetResource(this AzureMonitorDiagnosticSettingsUpdateSettings toolSettings, string resource)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = resource;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsUpdateSettings.Resource"/>.</em></p><p>Name or ID of the target resource.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsUpdateSettings ResetResource(this AzureMonitorDiagnosticSettingsUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsUpdateSettings SetResourceGroup(this AzureMonitorDiagnosticSettingsUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsUpdateSettings ResetResourceGroup(this AzureMonitorDiagnosticSettingsUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ResourceNamespace
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsUpdateSettings.ResourceNamespace"/>.</em></p><p>Target resource provider namespace.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsUpdateSettings SetResourceNamespace(this AzureMonitorDiagnosticSettingsUpdateSettings toolSettings, string resourceNamespace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceNamespace = resourceNamespace;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsUpdateSettings.ResourceNamespace"/>.</em></p><p>Target resource provider namespace.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsUpdateSettings ResetResourceNamespace(this AzureMonitorDiagnosticSettingsUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceNamespace = null;
            return toolSettings;
        }
        #endregion
        #region ResourceParent
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsUpdateSettings.ResourceParent"/>.</em></p><p>Target resource parent path, if applicable.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsUpdateSettings SetResourceParent(this AzureMonitorDiagnosticSettingsUpdateSettings toolSettings, string resourceParent)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceParent = resourceParent;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsUpdateSettings.ResourceParent"/>.</em></p><p>Target resource parent path, if applicable.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsUpdateSettings ResetResourceParent(this AzureMonitorDiagnosticSettingsUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceParent = null;
            return toolSettings;
        }
        #endregion
        #region ResourceType
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsUpdateSettings.ResourceType"/>.</em></p><p>Target resource type. Can also accept namespace/type format (Ex: 'Microsoft.Compute/virtualMachines)').</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsUpdateSettings SetResourceType(this AzureMonitorDiagnosticSettingsUpdateSettings toolSettings, string resourceType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = resourceType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsUpdateSettings.ResourceType"/>.</em></p><p>Target resource type. Can also accept namespace/type format (Ex: 'Microsoft.Compute/virtualMachines)').</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsUpdateSettings ResetResourceType(this AzureMonitorDiagnosticSettingsUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsUpdateSettings SetAdd(this AzureMonitorDiagnosticSettingsUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsUpdateSettings ResetAdd(this AzureMonitorDiagnosticSettingsUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region ForceString
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsUpdateSettings.ForceString"/>.</em></p><p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsUpdateSettings SetForceString(this AzureMonitorDiagnosticSettingsUpdateSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsUpdateSettings.ForceString"/>.</em></p><p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsUpdateSettings ResetForceString(this AzureMonitorDiagnosticSettingsUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsUpdateSettings SetRemove(this AzureMonitorDiagnosticSettingsUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsUpdateSettings ResetRemove(this AzureMonitorDiagnosticSettingsUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsUpdateSettings SetSet(this AzureMonitorDiagnosticSettingsUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsUpdateSettings ResetSet(this AzureMonitorDiagnosticSettingsUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsUpdateSettings SetDebug(this AzureMonitorDiagnosticSettingsUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsUpdateSettings ResetDebug(this AzureMonitorDiagnosticSettingsUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsUpdateSettings SetHelp(this AzureMonitorDiagnosticSettingsUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsUpdateSettings ResetHelp(this AzureMonitorDiagnosticSettingsUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsUpdateSettings SetOutput(this AzureMonitorDiagnosticSettingsUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsUpdateSettings ResetOutput(this AzureMonitorDiagnosticSettingsUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsUpdateSettings SetQuery(this AzureMonitorDiagnosticSettingsUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsUpdateSettings ResetQuery(this AzureMonitorDiagnosticSettingsUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsUpdateSettings SetVerbose(this AzureMonitorDiagnosticSettingsUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsUpdateSettings ResetVerbose(this AzureMonitorDiagnosticSettingsUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMonitorLogProfilesCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMonitorLogProfilesCreateSettingsExtensions
    {
        #region Categories
        /// <summary><p><em>Sets <see cref="AzureMonitorLogProfilesCreateSettings.Categories"/> to a new list.</em></p><p>Space-separated categories of the logs. These categories are created as is convenient to the user. Some values are Write, Delete, and/or Action.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesCreateSettings SetCategories(this AzureMonitorLogProfilesCreateSettings toolSettings, params string[] categories)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CategoriesInternal = categories.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureMonitorLogProfilesCreateSettings.Categories"/> to a new list.</em></p><p>Space-separated categories of the logs. These categories are created as is convenient to the user. Some values are Write, Delete, and/or Action.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesCreateSettings SetCategories(this AzureMonitorLogProfilesCreateSettings toolSettings, IEnumerable<string> categories)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CategoriesInternal = categories.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureMonitorLogProfilesCreateSettings.Categories"/>.</em></p><p>Space-separated categories of the logs. These categories are created as is convenient to the user. Some values are Write, Delete, and/or Action.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesCreateSettings AddCategories(this AzureMonitorLogProfilesCreateSettings toolSettings, params string[] categories)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CategoriesInternal.AddRange(categories);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureMonitorLogProfilesCreateSettings.Categories"/>.</em></p><p>Space-separated categories of the logs. These categories are created as is convenient to the user. Some values are Write, Delete, and/or Action.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesCreateSettings AddCategories(this AzureMonitorLogProfilesCreateSettings toolSettings, IEnumerable<string> categories)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CategoriesInternal.AddRange(categories);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureMonitorLogProfilesCreateSettings.Categories"/>.</em></p><p>Space-separated categories of the logs. These categories are created as is convenient to the user. Some values are Write, Delete, and/or Action.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesCreateSettings ClearCategories(this AzureMonitorLogProfilesCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CategoriesInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureMonitorLogProfilesCreateSettings.Categories"/>.</em></p><p>Space-separated categories of the logs. These categories are created as is convenient to the user. Some values are Write, Delete, and/or Action.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesCreateSettings RemoveCategories(this AzureMonitorLogProfilesCreateSettings toolSettings, params string[] categories)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(categories);
            toolSettings.CategoriesInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureMonitorLogProfilesCreateSettings.Categories"/>.</em></p><p>Space-separated categories of the logs. These categories are created as is convenient to the user. Some values are Write, Delete, and/or Action.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesCreateSettings RemoveCategories(this AzureMonitorLogProfilesCreateSettings toolSettings, IEnumerable<string> categories)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(categories);
            toolSettings.CategoriesInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary><p><em>Sets <see cref="AzureMonitorLogProfilesCreateSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesCreateSettings SetLocation(this AzureMonitorLogProfilesCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorLogProfilesCreateSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesCreateSettings ResetLocation(this AzureMonitorLogProfilesCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region Locations
        /// <summary><p><em>Sets <see cref="AzureMonitorLogProfilesCreateSettings.Locations"/> to a new list.</em></p><p>Space-separated list of regions for which Activity Log events should be stored.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesCreateSettings SetLocations(this AzureMonitorLogProfilesCreateSettings toolSettings, params string[] locations)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LocationsInternal = locations.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureMonitorLogProfilesCreateSettings.Locations"/> to a new list.</em></p><p>Space-separated list of regions for which Activity Log events should be stored.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesCreateSettings SetLocations(this AzureMonitorLogProfilesCreateSettings toolSettings, IEnumerable<string> locations)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LocationsInternal = locations.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureMonitorLogProfilesCreateSettings.Locations"/>.</em></p><p>Space-separated list of regions for which Activity Log events should be stored.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesCreateSettings AddLocations(this AzureMonitorLogProfilesCreateSettings toolSettings, params string[] locations)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LocationsInternal.AddRange(locations);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureMonitorLogProfilesCreateSettings.Locations"/>.</em></p><p>Space-separated list of regions for which Activity Log events should be stored.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesCreateSettings AddLocations(this AzureMonitorLogProfilesCreateSettings toolSettings, IEnumerable<string> locations)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LocationsInternal.AddRange(locations);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureMonitorLogProfilesCreateSettings.Locations"/>.</em></p><p>Space-separated list of regions for which Activity Log events should be stored.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesCreateSettings ClearLocations(this AzureMonitorLogProfilesCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LocationsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureMonitorLogProfilesCreateSettings.Locations"/>.</em></p><p>Space-separated list of regions for which Activity Log events should be stored.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesCreateSettings RemoveLocations(this AzureMonitorLogProfilesCreateSettings toolSettings, params string[] locations)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(locations);
            toolSettings.LocationsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureMonitorLogProfilesCreateSettings.Locations"/>.</em></p><p>Space-separated list of regions for which Activity Log events should be stored.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesCreateSettings RemoveLocations(this AzureMonitorLogProfilesCreateSettings toolSettings, IEnumerable<string> locations)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(locations);
            toolSettings.LocationsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureMonitorLogProfilesCreateSettings.Name"/>.</em></p><p>The name of the log profile.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesCreateSettings SetName(this AzureMonitorLogProfilesCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorLogProfilesCreateSettings.Name"/>.</em></p><p>The name of the log profile.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesCreateSettings ResetName(this AzureMonitorLogProfilesCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ServiceBusRuleId
        /// <summary><p><em>Sets <see cref="AzureMonitorLogProfilesCreateSettings.ServiceBusRuleId"/>.</em></p><p>The service bus rule ID of the service bus namespace in which you would like to have Event Hubs created for streaming the Activity Log. The rule ID is of the format '{service bus resource ID}/authorizationrules/{key name}'.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesCreateSettings SetServiceBusRuleId(this AzureMonitorLogProfilesCreateSettings toolSettings, string serviceBusRuleId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServiceBusRuleId = serviceBusRuleId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorLogProfilesCreateSettings.ServiceBusRuleId"/>.</em></p><p>The service bus rule ID of the service bus namespace in which you would like to have Event Hubs created for streaming the Activity Log. The rule ID is of the format '{service bus resource ID}/authorizationrules/{key name}'.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesCreateSettings ResetServiceBusRuleId(this AzureMonitorLogProfilesCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServiceBusRuleId = null;
            return toolSettings;
        }
        #endregion
        #region StorageAccountId
        /// <summary><p><em>Sets <see cref="AzureMonitorLogProfilesCreateSettings.StorageAccountId"/>.</em></p><p>The resource id of the storage account to which you would like to send the Activity Log.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesCreateSettings SetStorageAccountId(this AzureMonitorLogProfilesCreateSettings toolSettings, string storageAccountId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageAccountId = storageAccountId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorLogProfilesCreateSettings.StorageAccountId"/>.</em></p><p>The resource id of the storage account to which you would like to send the Activity Log.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesCreateSettings ResetStorageAccountId(this AzureMonitorLogProfilesCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageAccountId = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary><p><em>Sets <see cref="AzureMonitorLogProfilesCreateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesCreateSettings SetTags(this AzureMonitorLogProfilesCreateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorLogProfilesCreateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesCreateSettings ResetTags(this AzureMonitorLogProfilesCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Days
        /// <summary><p><em>Sets <see cref="AzureMonitorLogProfilesCreateSettings.Days"/>.</em></p><p>The number of days for the retention in days. A value of 0 will retain the events indefinitely.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesCreateSettings SetDays(this AzureMonitorLogProfilesCreateSettings toolSettings, string days)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Days = days;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorLogProfilesCreateSettings.Days"/>.</em></p><p>The number of days for the retention in days. A value of 0 will retain the events indefinitely.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesCreateSettings ResetDays(this AzureMonitorLogProfilesCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Days = null;
            return toolSettings;
        }
        #endregion
        #region Enabled
        /// <summary><p><em>Sets <see cref="AzureMonitorLogProfilesCreateSettings.Enabled"/>.</em></p><p>Whether the retention policy is enabled.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesCreateSettings SetEnabled(this AzureMonitorLogProfilesCreateSettings toolSettings, bool? enabled)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Enabled = enabled;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorLogProfilesCreateSettings.Enabled"/>.</em></p><p>Whether the retention policy is enabled.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesCreateSettings ResetEnabled(this AzureMonitorLogProfilesCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Enabled = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureMonitorLogProfilesCreateSettings.Enabled"/>.</em></p><p>Whether the retention policy is enabled.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesCreateSettings EnableEnabled(this AzureMonitorLogProfilesCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Enabled = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureMonitorLogProfilesCreateSettings.Enabled"/>.</em></p><p>Whether the retention policy is enabled.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesCreateSettings DisableEnabled(this AzureMonitorLogProfilesCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Enabled = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureMonitorLogProfilesCreateSettings.Enabled"/>.</em></p><p>Whether the retention policy is enabled.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesCreateSettings ToggleEnabled(this AzureMonitorLogProfilesCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Enabled = !toolSettings.Enabled;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMonitorLogProfilesCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesCreateSettings SetDebug(this AzureMonitorLogProfilesCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorLogProfilesCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesCreateSettings ResetDebug(this AzureMonitorLogProfilesCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMonitorLogProfilesCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesCreateSettings SetHelp(this AzureMonitorLogProfilesCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorLogProfilesCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesCreateSettings ResetHelp(this AzureMonitorLogProfilesCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMonitorLogProfilesCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesCreateSettings SetOutput(this AzureMonitorLogProfilesCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorLogProfilesCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesCreateSettings ResetOutput(this AzureMonitorLogProfilesCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMonitorLogProfilesCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesCreateSettings SetQuery(this AzureMonitorLogProfilesCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorLogProfilesCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesCreateSettings ResetQuery(this AzureMonitorLogProfilesCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMonitorLogProfilesCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesCreateSettings SetVerbose(this AzureMonitorLogProfilesCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorLogProfilesCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesCreateSettings ResetVerbose(this AzureMonitorLogProfilesCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMonitorLogProfilesDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMonitorLogProfilesDeleteSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureMonitorLogProfilesDeleteSettings.Name"/>.</em></p><p>The name of the log profile.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesDeleteSettings SetName(this AzureMonitorLogProfilesDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorLogProfilesDeleteSettings.Name"/>.</em></p><p>The name of the log profile.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesDeleteSettings ResetName(this AzureMonitorLogProfilesDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMonitorLogProfilesDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesDeleteSettings SetDebug(this AzureMonitorLogProfilesDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorLogProfilesDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesDeleteSettings ResetDebug(this AzureMonitorLogProfilesDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMonitorLogProfilesDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesDeleteSettings SetHelp(this AzureMonitorLogProfilesDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorLogProfilesDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesDeleteSettings ResetHelp(this AzureMonitorLogProfilesDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMonitorLogProfilesDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesDeleteSettings SetOutput(this AzureMonitorLogProfilesDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorLogProfilesDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesDeleteSettings ResetOutput(this AzureMonitorLogProfilesDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMonitorLogProfilesDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesDeleteSettings SetQuery(this AzureMonitorLogProfilesDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorLogProfilesDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesDeleteSettings ResetQuery(this AzureMonitorLogProfilesDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMonitorLogProfilesDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesDeleteSettings SetVerbose(this AzureMonitorLogProfilesDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorLogProfilesDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesDeleteSettings ResetVerbose(this AzureMonitorLogProfilesDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMonitorLogProfilesListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMonitorLogProfilesListSettingsExtensions
    {
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMonitorLogProfilesListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesListSettings SetDebug(this AzureMonitorLogProfilesListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorLogProfilesListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesListSettings ResetDebug(this AzureMonitorLogProfilesListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMonitorLogProfilesListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesListSettings SetHelp(this AzureMonitorLogProfilesListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorLogProfilesListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesListSettings ResetHelp(this AzureMonitorLogProfilesListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMonitorLogProfilesListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesListSettings SetOutput(this AzureMonitorLogProfilesListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorLogProfilesListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesListSettings ResetOutput(this AzureMonitorLogProfilesListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMonitorLogProfilesListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesListSettings SetQuery(this AzureMonitorLogProfilesListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorLogProfilesListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesListSettings ResetQuery(this AzureMonitorLogProfilesListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMonitorLogProfilesListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesListSettings SetVerbose(this AzureMonitorLogProfilesListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorLogProfilesListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesListSettings ResetVerbose(this AzureMonitorLogProfilesListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMonitorLogProfilesShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMonitorLogProfilesShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureMonitorLogProfilesShowSettings.Name"/>.</em></p><p>The name of the log profile.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesShowSettings SetName(this AzureMonitorLogProfilesShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorLogProfilesShowSettings.Name"/>.</em></p><p>The name of the log profile.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesShowSettings ResetName(this AzureMonitorLogProfilesShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMonitorLogProfilesShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesShowSettings SetDebug(this AzureMonitorLogProfilesShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorLogProfilesShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesShowSettings ResetDebug(this AzureMonitorLogProfilesShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMonitorLogProfilesShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesShowSettings SetHelp(this AzureMonitorLogProfilesShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorLogProfilesShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesShowSettings ResetHelp(this AzureMonitorLogProfilesShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMonitorLogProfilesShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesShowSettings SetOutput(this AzureMonitorLogProfilesShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorLogProfilesShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesShowSettings ResetOutput(this AzureMonitorLogProfilesShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMonitorLogProfilesShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesShowSettings SetQuery(this AzureMonitorLogProfilesShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorLogProfilesShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesShowSettings ResetQuery(this AzureMonitorLogProfilesShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMonitorLogProfilesShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesShowSettings SetVerbose(this AzureMonitorLogProfilesShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorLogProfilesShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesShowSettings ResetVerbose(this AzureMonitorLogProfilesShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMonitorLogProfilesUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMonitorLogProfilesUpdateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureMonitorLogProfilesUpdateSettings.Name"/>.</em></p><p>The name of the log profile.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesUpdateSettings SetName(this AzureMonitorLogProfilesUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorLogProfilesUpdateSettings.Name"/>.</em></p><p>The name of the log profile.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesUpdateSettings ResetName(this AzureMonitorLogProfilesUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary><p><em>Sets <see cref="AzureMonitorLogProfilesUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesUpdateSettings SetAdd(this AzureMonitorLogProfilesUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorLogProfilesUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesUpdateSettings ResetAdd(this AzureMonitorLogProfilesUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region ForceString
        /// <summary><p><em>Sets <see cref="AzureMonitorLogProfilesUpdateSettings.ForceString"/>.</em></p><p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesUpdateSettings SetForceString(this AzureMonitorLogProfilesUpdateSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorLogProfilesUpdateSettings.ForceString"/>.</em></p><p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesUpdateSettings ResetForceString(this AzureMonitorLogProfilesUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary><p><em>Sets <see cref="AzureMonitorLogProfilesUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesUpdateSettings SetRemove(this AzureMonitorLogProfilesUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorLogProfilesUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesUpdateSettings ResetRemove(this AzureMonitorLogProfilesUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary><p><em>Sets <see cref="AzureMonitorLogProfilesUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesUpdateSettings SetSet(this AzureMonitorLogProfilesUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorLogProfilesUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesUpdateSettings ResetSet(this AzureMonitorLogProfilesUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMonitorLogProfilesUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesUpdateSettings SetDebug(this AzureMonitorLogProfilesUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorLogProfilesUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesUpdateSettings ResetDebug(this AzureMonitorLogProfilesUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMonitorLogProfilesUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesUpdateSettings SetHelp(this AzureMonitorLogProfilesUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorLogProfilesUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesUpdateSettings ResetHelp(this AzureMonitorLogProfilesUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMonitorLogProfilesUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesUpdateSettings SetOutput(this AzureMonitorLogProfilesUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorLogProfilesUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesUpdateSettings ResetOutput(this AzureMonitorLogProfilesUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMonitorLogProfilesUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesUpdateSettings SetQuery(this AzureMonitorLogProfilesUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorLogProfilesUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesUpdateSettings ResetQuery(this AzureMonitorLogProfilesUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMonitorLogProfilesUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesUpdateSettings SetVerbose(this AzureMonitorLogProfilesUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorLogProfilesUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorLogProfilesUpdateSettings ResetVerbose(this AzureMonitorLogProfilesUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMonitorMetricsListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMonitorMetricsListSettingsExtensions
    {
        #region Aggregation
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsListSettings.Aggregation"/>.</em></p><p>The list of aggregation types (space-separated) to retrieve.</p></summary>
        [Pure]
        public static AzureMonitorMetricsListSettings SetAggregation(this AzureMonitorMetricsListSettings toolSettings, MonitorMetricsListAggregation aggregation)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Aggregation = aggregation;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsListSettings.Aggregation"/>.</em></p><p>The list of aggregation types (space-separated) to retrieve.</p></summary>
        [Pure]
        public static AzureMonitorMetricsListSettings ResetAggregation(this AzureMonitorMetricsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Aggregation = null;
            return toolSettings;
        }
        #endregion
        #region Dimension
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsListSettings.Dimension"/>.</em></p><p>The list of dimensions (space-separated) the metrics are queried into.</p></summary>
        [Pure]
        public static AzureMonitorMetricsListSettings SetDimension(this AzureMonitorMetricsListSettings toolSettings, string dimension)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Dimension = dimension;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsListSettings.Dimension"/>.</em></p><p>The list of dimensions (space-separated) the metrics are queried into.</p></summary>
        [Pure]
        public static AzureMonitorMetricsListSettings ResetDimension(this AzureMonitorMetricsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Dimension = null;
            return toolSettings;
        }
        #endregion
        #region Filter
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsListSettings.Filter"/>.</em></p><p>A string used to reduce the set of metric data returned. eg. "BlobType eq '*'".</p></summary>
        [Pure]
        public static AzureMonitorMetricsListSettings SetFilter(this AzureMonitorMetricsListSettings toolSettings, string filter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = filter;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsListSettings.Filter"/>.</em></p><p>A string used to reduce the set of metric data returned. eg. "BlobType eq '*'".</p></summary>
        [Pure]
        public static AzureMonitorMetricsListSettings ResetFilter(this AzureMonitorMetricsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = null;
            return toolSettings;
        }
        #endregion
        #region Metadata
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsListSettings.Metadata"/>.</em></p><p>Returns the metadata values instead of metric data.</p></summary>
        [Pure]
        public static AzureMonitorMetricsListSettings SetMetadata(this AzureMonitorMetricsListSettings toolSettings, string metadata)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Metadata = metadata;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsListSettings.Metadata"/>.</em></p><p>Returns the metadata values instead of metric data.</p></summary>
        [Pure]
        public static AzureMonitorMetricsListSettings ResetMetadata(this AzureMonitorMetricsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Metadata = null;
            return toolSettings;
        }
        #endregion
        #region Metrics
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsListSettings.Metrics"/> to a new list.</em></p><p>Space-separated list of metric names to retrieve.</p></summary>
        [Pure]
        public static AzureMonitorMetricsListSettings SetMetrics(this AzureMonitorMetricsListSettings toolSettings, params string[] metrics)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MetricsInternal = metrics.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsListSettings.Metrics"/> to a new list.</em></p><p>Space-separated list of metric names to retrieve.</p></summary>
        [Pure]
        public static AzureMonitorMetricsListSettings SetMetrics(this AzureMonitorMetricsListSettings toolSettings, IEnumerable<string> metrics)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MetricsInternal = metrics.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureMonitorMetricsListSettings.Metrics"/>.</em></p><p>Space-separated list of metric names to retrieve.</p></summary>
        [Pure]
        public static AzureMonitorMetricsListSettings AddMetrics(this AzureMonitorMetricsListSettings toolSettings, params string[] metrics)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MetricsInternal.AddRange(metrics);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureMonitorMetricsListSettings.Metrics"/>.</em></p><p>Space-separated list of metric names to retrieve.</p></summary>
        [Pure]
        public static AzureMonitorMetricsListSettings AddMetrics(this AzureMonitorMetricsListSettings toolSettings, IEnumerable<string> metrics)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MetricsInternal.AddRange(metrics);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureMonitorMetricsListSettings.Metrics"/>.</em></p><p>Space-separated list of metric names to retrieve.</p></summary>
        [Pure]
        public static AzureMonitorMetricsListSettings ClearMetrics(this AzureMonitorMetricsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MetricsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureMonitorMetricsListSettings.Metrics"/>.</em></p><p>Space-separated list of metric names to retrieve.</p></summary>
        [Pure]
        public static AzureMonitorMetricsListSettings RemoveMetrics(this AzureMonitorMetricsListSettings toolSettings, params string[] metrics)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(metrics);
            toolSettings.MetricsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureMonitorMetricsListSettings.Metrics"/>.</em></p><p>Space-separated list of metric names to retrieve.</p></summary>
        [Pure]
        public static AzureMonitorMetricsListSettings RemoveMetrics(this AzureMonitorMetricsListSettings toolSettings, IEnumerable<string> metrics)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(metrics);
            toolSettings.MetricsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Namespace
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsListSettings.Namespace"/>.</em></p><p>Namespace to query metric definitions for.</p></summary>
        [Pure]
        public static AzureMonitorMetricsListSettings SetNamespace(this AzureMonitorMetricsListSettings toolSettings, string @namespace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = @namespace;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsListSettings.Namespace"/>.</em></p><p>Namespace to query metric definitions for.</p></summary>
        [Pure]
        public static AzureMonitorMetricsListSettings ResetNamespace(this AzureMonitorMetricsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = null;
            return toolSettings;
        }
        #endregion
        #region Orderby
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsListSettings.Orderby"/>.</em></p><p>The aggregation to use for sorting results and the direction of the sort. Only one order can be specified. Examples: sum asc.</p></summary>
        [Pure]
        public static AzureMonitorMetricsListSettings SetOrderby(this AzureMonitorMetricsListSettings toolSettings, string orderby)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Orderby = orderby;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsListSettings.Orderby"/>.</em></p><p>The aggregation to use for sorting results and the direction of the sort. Only one order can be specified. Examples: sum asc.</p></summary>
        [Pure]
        public static AzureMonitorMetricsListSettings ResetOrderby(this AzureMonitorMetricsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Orderby = null;
            return toolSettings;
        }
        #endregion
        #region Top
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsListSettings.Top"/>.</em></p><p>The maximum number of records to retrieve. Valid only if $filter is specified. Defaults to 10.</p></summary>
        [Pure]
        public static AzureMonitorMetricsListSettings SetTop(this AzureMonitorMetricsListSettings toolSettings, int? top)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = top;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsListSettings.Top"/>.</em></p><p>The maximum number of records to retrieve. Valid only if $filter is specified. Defaults to 10.</p></summary>
        [Pure]
        public static AzureMonitorMetricsListSettings ResetTop(this AzureMonitorMetricsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = null;
            return toolSettings;
        }
        #endregion
        #region Resource
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsListSettings.Resource"/>.</em></p><p>Name or ID of the target resource.</p></summary>
        [Pure]
        public static AzureMonitorMetricsListSettings SetResource(this AzureMonitorMetricsListSettings toolSettings, string resource)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = resource;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsListSettings.Resource"/>.</em></p><p>Name or ID of the target resource.</p></summary>
        [Pure]
        public static AzureMonitorMetricsListSettings ResetResource(this AzureMonitorMetricsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorMetricsListSettings SetResourceGroup(this AzureMonitorMetricsListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorMetricsListSettings ResetResourceGroup(this AzureMonitorMetricsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ResourceNamespace
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsListSettings.ResourceNamespace"/>.</em></p><p>Target resource provider namespace.</p></summary>
        [Pure]
        public static AzureMonitorMetricsListSettings SetResourceNamespace(this AzureMonitorMetricsListSettings toolSettings, string resourceNamespace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceNamespace = resourceNamespace;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsListSettings.ResourceNamespace"/>.</em></p><p>Target resource provider namespace.</p></summary>
        [Pure]
        public static AzureMonitorMetricsListSettings ResetResourceNamespace(this AzureMonitorMetricsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceNamespace = null;
            return toolSettings;
        }
        #endregion
        #region ResourceParent
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsListSettings.ResourceParent"/>.</em></p><p>Target resource parent path, if applicable.</p></summary>
        [Pure]
        public static AzureMonitorMetricsListSettings SetResourceParent(this AzureMonitorMetricsListSettings toolSettings, string resourceParent)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceParent = resourceParent;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsListSettings.ResourceParent"/>.</em></p><p>Target resource parent path, if applicable.</p></summary>
        [Pure]
        public static AzureMonitorMetricsListSettings ResetResourceParent(this AzureMonitorMetricsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceParent = null;
            return toolSettings;
        }
        #endregion
        #region ResourceType
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsListSettings.ResourceType"/>.</em></p><p>Target resource type. Can also accept namespace/type format (Ex: 'Microsoft.Compute/virtualMachines)').</p></summary>
        [Pure]
        public static AzureMonitorMetricsListSettings SetResourceType(this AzureMonitorMetricsListSettings toolSettings, string resourceType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = resourceType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsListSettings.ResourceType"/>.</em></p><p>Target resource type. Can also accept namespace/type format (Ex: 'Microsoft.Compute/virtualMachines)').</p></summary>
        [Pure]
        public static AzureMonitorMetricsListSettings ResetResourceType(this AzureMonitorMetricsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = null;
            return toolSettings;
        }
        #endregion
        #region EndTime
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsListSettings.EndTime"/>.</em></p><p>The end time of the query. In ISO format with explicit indication of timezone, 1970-01-01T00:00:00Z, 1970-01-01T00:00:00-0500. Defaults to the current time.</p></summary>
        [Pure]
        public static AzureMonitorMetricsListSettings SetEndTime(this AzureMonitorMetricsListSettings toolSettings, string endTime)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndTime = endTime;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsListSettings.EndTime"/>.</em></p><p>The end time of the query. In ISO format with explicit indication of timezone, 1970-01-01T00:00:00Z, 1970-01-01T00:00:00-0500. Defaults to the current time.</p></summary>
        [Pure]
        public static AzureMonitorMetricsListSettings ResetEndTime(this AzureMonitorMetricsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndTime = null;
            return toolSettings;
        }
        #endregion
        #region Interval
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsListSettings.Interval"/>.</em></p><p>The interval of the metric query. In ISO 8601 duration format, eg "PT1M".</p></summary>
        [Pure]
        public static AzureMonitorMetricsListSettings SetInterval(this AzureMonitorMetricsListSettings toolSettings, string interval)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Interval = interval;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsListSettings.Interval"/>.</em></p><p>The interval of the metric query. In ISO 8601 duration format, eg "PT1M".</p></summary>
        [Pure]
        public static AzureMonitorMetricsListSettings ResetInterval(this AzureMonitorMetricsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Interval = null;
            return toolSettings;
        }
        #endregion
        #region StartTime
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsListSettings.StartTime"/>.</em></p><p>The start time of the query. In ISO format with explicit indication of timezone, 1970-01-01T00:00:00Z, 1970-01-01T00:00:00-0500. Defaults to 1 Hour prior to the current time.</p></summary>
        [Pure]
        public static AzureMonitorMetricsListSettings SetStartTime(this AzureMonitorMetricsListSettings toolSettings, string startTime)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartTime = startTime;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsListSettings.StartTime"/>.</em></p><p>The start time of the query. In ISO format with explicit indication of timezone, 1970-01-01T00:00:00Z, 1970-01-01T00:00:00-0500. Defaults to 1 Hour prior to the current time.</p></summary>
        [Pure]
        public static AzureMonitorMetricsListSettings ResetStartTime(this AzureMonitorMetricsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartTime = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorMetricsListSettings SetDebug(this AzureMonitorMetricsListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorMetricsListSettings ResetDebug(this AzureMonitorMetricsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorMetricsListSettings SetHelp(this AzureMonitorMetricsListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorMetricsListSettings ResetHelp(this AzureMonitorMetricsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorMetricsListSettings SetOutput(this AzureMonitorMetricsListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorMetricsListSettings ResetOutput(this AzureMonitorMetricsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorMetricsListSettings SetQuery(this AzureMonitorMetricsListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorMetricsListSettings ResetQuery(this AzureMonitorMetricsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorMetricsListSettings SetVerbose(this AzureMonitorMetricsListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorMetricsListSettings ResetVerbose(this AzureMonitorMetricsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMonitorMetricsListDefinitionsSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMonitorMetricsListDefinitionsSettingsExtensions
    {
        #region Namespace
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsListDefinitionsSettings.Namespace"/>.</em></p><p>Namespace to query metric definitions for.</p></summary>
        [Pure]
        public static AzureMonitorMetricsListDefinitionsSettings SetNamespace(this AzureMonitorMetricsListDefinitionsSettings toolSettings, string @namespace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = @namespace;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsListDefinitionsSettings.Namespace"/>.</em></p><p>Namespace to query metric definitions for.</p></summary>
        [Pure]
        public static AzureMonitorMetricsListDefinitionsSettings ResetNamespace(this AzureMonitorMetricsListDefinitionsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = null;
            return toolSettings;
        }
        #endregion
        #region Resource
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsListDefinitionsSettings.Resource"/>.</em></p><p>Name or ID of the target resource.</p></summary>
        [Pure]
        public static AzureMonitorMetricsListDefinitionsSettings SetResource(this AzureMonitorMetricsListDefinitionsSettings toolSettings, string resource)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = resource;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsListDefinitionsSettings.Resource"/>.</em></p><p>Name or ID of the target resource.</p></summary>
        [Pure]
        public static AzureMonitorMetricsListDefinitionsSettings ResetResource(this AzureMonitorMetricsListDefinitionsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsListDefinitionsSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorMetricsListDefinitionsSettings SetResourceGroup(this AzureMonitorMetricsListDefinitionsSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsListDefinitionsSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorMetricsListDefinitionsSettings ResetResourceGroup(this AzureMonitorMetricsListDefinitionsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ResourceNamespace
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsListDefinitionsSettings.ResourceNamespace"/>.</em></p><p>Target resource provider namespace.</p></summary>
        [Pure]
        public static AzureMonitorMetricsListDefinitionsSettings SetResourceNamespace(this AzureMonitorMetricsListDefinitionsSettings toolSettings, string resourceNamespace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceNamespace = resourceNamespace;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsListDefinitionsSettings.ResourceNamespace"/>.</em></p><p>Target resource provider namespace.</p></summary>
        [Pure]
        public static AzureMonitorMetricsListDefinitionsSettings ResetResourceNamespace(this AzureMonitorMetricsListDefinitionsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceNamespace = null;
            return toolSettings;
        }
        #endregion
        #region ResourceParent
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsListDefinitionsSettings.ResourceParent"/>.</em></p><p>Target resource parent path, if applicable.</p></summary>
        [Pure]
        public static AzureMonitorMetricsListDefinitionsSettings SetResourceParent(this AzureMonitorMetricsListDefinitionsSettings toolSettings, string resourceParent)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceParent = resourceParent;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsListDefinitionsSettings.ResourceParent"/>.</em></p><p>Target resource parent path, if applicable.</p></summary>
        [Pure]
        public static AzureMonitorMetricsListDefinitionsSettings ResetResourceParent(this AzureMonitorMetricsListDefinitionsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceParent = null;
            return toolSettings;
        }
        #endregion
        #region ResourceType
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsListDefinitionsSettings.ResourceType"/>.</em></p><p>Target resource type. Can also accept namespace/type format (Ex: 'Microsoft.Compute/virtualMachines)').</p></summary>
        [Pure]
        public static AzureMonitorMetricsListDefinitionsSettings SetResourceType(this AzureMonitorMetricsListDefinitionsSettings toolSettings, string resourceType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = resourceType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsListDefinitionsSettings.ResourceType"/>.</em></p><p>Target resource type. Can also accept namespace/type format (Ex: 'Microsoft.Compute/virtualMachines)').</p></summary>
        [Pure]
        public static AzureMonitorMetricsListDefinitionsSettings ResetResourceType(this AzureMonitorMetricsListDefinitionsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsListDefinitionsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorMetricsListDefinitionsSettings SetDebug(this AzureMonitorMetricsListDefinitionsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsListDefinitionsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorMetricsListDefinitionsSettings ResetDebug(this AzureMonitorMetricsListDefinitionsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsListDefinitionsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorMetricsListDefinitionsSettings SetHelp(this AzureMonitorMetricsListDefinitionsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsListDefinitionsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorMetricsListDefinitionsSettings ResetHelp(this AzureMonitorMetricsListDefinitionsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsListDefinitionsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorMetricsListDefinitionsSettings SetOutput(this AzureMonitorMetricsListDefinitionsSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsListDefinitionsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorMetricsListDefinitionsSettings ResetOutput(this AzureMonitorMetricsListDefinitionsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsListDefinitionsSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorMetricsListDefinitionsSettings SetQuery(this AzureMonitorMetricsListDefinitionsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsListDefinitionsSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorMetricsListDefinitionsSettings ResetQuery(this AzureMonitorMetricsListDefinitionsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsListDefinitionsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorMetricsListDefinitionsSettings SetVerbose(this AzureMonitorMetricsListDefinitionsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsListDefinitionsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorMetricsListDefinitionsSettings ResetVerbose(this AzureMonitorMetricsListDefinitionsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMonitorActivityLogAlertCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMonitorActivityLogAlertCreateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertCreateSettings.Name"/>.</em></p><p>Name of the activity log alerts.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertCreateSettings SetName(this AzureMonitorActivityLogAlertCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogAlertCreateSettings.Name"/>.</em></p><p>Name of the activity log alerts.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertCreateSettings ResetName(this AzureMonitorActivityLogAlertCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertCreateSettings SetResourceGroup(this AzureMonitorActivityLogAlertCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogAlertCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertCreateSettings ResetResourceGroup(this AzureMonitorActivityLogAlertCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ActionGroup
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertCreateSettings.ActionGroup"/>.</em></p><p>Add an action group. Accepts space-separated action group identifiers. The identifier can be the action group's name or its resource ID.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertCreateSettings SetActionGroup(this AzureMonitorActivityLogAlertCreateSettings toolSettings, string actionGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ActionGroup = actionGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogAlertCreateSettings.ActionGroup"/>.</em></p><p>Add an action group. Accepts space-separated action group identifiers. The identifier can be the action group's name or its resource ID.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertCreateSettings ResetActionGroup(this AzureMonitorActivityLogAlertCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ActionGroup = null;
            return toolSettings;
        }
        #endregion
        #region Condition
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertCreateSettings.Condition"/>.</em></p><p>The condition that will cause the alert to activate. The format is FIELD=VALUE[ and FIELD=VALUE...].</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertCreateSettings SetCondition(this AzureMonitorActivityLogAlertCreateSettings toolSettings, string condition)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Condition = condition;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogAlertCreateSettings.Condition"/>.</em></p><p>The condition that will cause the alert to activate. The format is FIELD=VALUE[ and FIELD=VALUE...].</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertCreateSettings ResetCondition(this AzureMonitorActivityLogAlertCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Condition = null;
            return toolSettings;
        }
        #endregion
        #region Description
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertCreateSettings.Description"/>.</em></p><p>A description of this activity log alert.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertCreateSettings SetDescription(this AzureMonitorActivityLogAlertCreateSettings toolSettings, string description)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Description = description;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogAlertCreateSettings.Description"/>.</em></p><p>A description of this activity log alert.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertCreateSettings ResetDescription(this AzureMonitorActivityLogAlertCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Description = null;
            return toolSettings;
        }
        #endregion
        #region Disable
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertCreateSettings.Disable"/>.</em></p><p>Disable the activity log alert after it is created.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertCreateSettings SetDisable(this AzureMonitorActivityLogAlertCreateSettings toolSettings, string disable)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Disable = disable;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogAlertCreateSettings.Disable"/>.</em></p><p>Disable the activity log alert after it is created.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertCreateSettings ResetDisable(this AzureMonitorActivityLogAlertCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Disable = null;
            return toolSettings;
        }
        #endregion
        #region Scope
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertCreateSettings.Scope"/>.</em></p><p>A list of strings that will be used as prefixes.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertCreateSettings SetScope(this AzureMonitorActivityLogAlertCreateSettings toolSettings, string scope)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Scope = scope;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogAlertCreateSettings.Scope"/>.</em></p><p>A list of strings that will be used as prefixes.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertCreateSettings ResetScope(this AzureMonitorActivityLogAlertCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Scope = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertCreateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertCreateSettings SetTags(this AzureMonitorActivityLogAlertCreateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogAlertCreateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertCreateSettings ResetTags(this AzureMonitorActivityLogAlertCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region WebhookProperties
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertCreateSettings.WebhookProperties"/> to a new list.</em></p><p>Space-separated webhook properties in 'key[=value]' format. These properties are associated with the action groups added in this command.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertCreateSettings SetWebhookProperties(this AzureMonitorActivityLogAlertCreateSettings toolSettings, params string[] webhookProperties)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WebhookPropertiesInternal = webhookProperties.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertCreateSettings.WebhookProperties"/> to a new list.</em></p><p>Space-separated webhook properties in 'key[=value]' format. These properties are associated with the action groups added in this command.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertCreateSettings SetWebhookProperties(this AzureMonitorActivityLogAlertCreateSettings toolSettings, IEnumerable<string> webhookProperties)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WebhookPropertiesInternal = webhookProperties.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureMonitorActivityLogAlertCreateSettings.WebhookProperties"/>.</em></p><p>Space-separated webhook properties in 'key[=value]' format. These properties are associated with the action groups added in this command.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertCreateSettings AddWebhookProperties(this AzureMonitorActivityLogAlertCreateSettings toolSettings, params string[] webhookProperties)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WebhookPropertiesInternal.AddRange(webhookProperties);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureMonitorActivityLogAlertCreateSettings.WebhookProperties"/>.</em></p><p>Space-separated webhook properties in 'key[=value]' format. These properties are associated with the action groups added in this command.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertCreateSettings AddWebhookProperties(this AzureMonitorActivityLogAlertCreateSettings toolSettings, IEnumerable<string> webhookProperties)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WebhookPropertiesInternal.AddRange(webhookProperties);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureMonitorActivityLogAlertCreateSettings.WebhookProperties"/>.</em></p><p>Space-separated webhook properties in 'key[=value]' format. These properties are associated with the action groups added in this command.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertCreateSettings ClearWebhookProperties(this AzureMonitorActivityLogAlertCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WebhookPropertiesInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureMonitorActivityLogAlertCreateSettings.WebhookProperties"/>.</em></p><p>Space-separated webhook properties in 'key[=value]' format. These properties are associated with the action groups added in this command.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertCreateSettings RemoveWebhookProperties(this AzureMonitorActivityLogAlertCreateSettings toolSettings, params string[] webhookProperties)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(webhookProperties);
            toolSettings.WebhookPropertiesInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureMonitorActivityLogAlertCreateSettings.WebhookProperties"/>.</em></p><p>Space-separated webhook properties in 'key[=value]' format. These properties are associated with the action groups added in this command.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertCreateSettings RemoveWebhookProperties(this AzureMonitorActivityLogAlertCreateSettings toolSettings, IEnumerable<string> webhookProperties)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(webhookProperties);
            toolSettings.WebhookPropertiesInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertCreateSettings SetDebug(this AzureMonitorActivityLogAlertCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogAlertCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertCreateSettings ResetDebug(this AzureMonitorActivityLogAlertCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertCreateSettings SetHelp(this AzureMonitorActivityLogAlertCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogAlertCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertCreateSettings ResetHelp(this AzureMonitorActivityLogAlertCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertCreateSettings SetOutput(this AzureMonitorActivityLogAlertCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogAlertCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertCreateSettings ResetOutput(this AzureMonitorActivityLogAlertCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertCreateSettings SetQuery(this AzureMonitorActivityLogAlertCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogAlertCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertCreateSettings ResetQuery(this AzureMonitorActivityLogAlertCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertCreateSettings SetVerbose(this AzureMonitorActivityLogAlertCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogAlertCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertCreateSettings ResetVerbose(this AzureMonitorActivityLogAlertCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMonitorActivityLogAlertDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMonitorActivityLogAlertDeleteSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertDeleteSettings.Name"/>.</em></p><p>The name of the activity log alert.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertDeleteSettings SetName(this AzureMonitorActivityLogAlertDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogAlertDeleteSettings.Name"/>.</em></p><p>The name of the activity log alert.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertDeleteSettings ResetName(this AzureMonitorActivityLogAlertDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertDeleteSettings SetResourceGroup(this AzureMonitorActivityLogAlertDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogAlertDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertDeleteSettings ResetResourceGroup(this AzureMonitorActivityLogAlertDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertDeleteSettings SetDebug(this AzureMonitorActivityLogAlertDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogAlertDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertDeleteSettings ResetDebug(this AzureMonitorActivityLogAlertDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertDeleteSettings SetHelp(this AzureMonitorActivityLogAlertDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogAlertDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertDeleteSettings ResetHelp(this AzureMonitorActivityLogAlertDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertDeleteSettings SetOutput(this AzureMonitorActivityLogAlertDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogAlertDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertDeleteSettings ResetOutput(this AzureMonitorActivityLogAlertDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertDeleteSettings SetQuery(this AzureMonitorActivityLogAlertDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogAlertDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertDeleteSettings ResetQuery(this AzureMonitorActivityLogAlertDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertDeleteSettings SetVerbose(this AzureMonitorActivityLogAlertDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogAlertDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertDeleteSettings ResetVerbose(this AzureMonitorActivityLogAlertDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMonitorActivityLogAlertListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMonitorActivityLogAlertListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertListSettings.ResourceGroup"/>.</em></p><p>Name of the resource group under which the activity log alerts are being listed. If it is omitted, all the activity log alerts under the current subscription are listed.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertListSettings SetResourceGroup(this AzureMonitorActivityLogAlertListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogAlertListSettings.ResourceGroup"/>.</em></p><p>Name of the resource group under which the activity log alerts are being listed. If it is omitted, all the activity log alerts under the current subscription are listed.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertListSettings ResetResourceGroup(this AzureMonitorActivityLogAlertListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertListSettings SetDebug(this AzureMonitorActivityLogAlertListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogAlertListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertListSettings ResetDebug(this AzureMonitorActivityLogAlertListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertListSettings SetHelp(this AzureMonitorActivityLogAlertListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogAlertListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertListSettings ResetHelp(this AzureMonitorActivityLogAlertListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertListSettings SetOutput(this AzureMonitorActivityLogAlertListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogAlertListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertListSettings ResetOutput(this AzureMonitorActivityLogAlertListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertListSettings SetQuery(this AzureMonitorActivityLogAlertListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogAlertListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertListSettings ResetQuery(this AzureMonitorActivityLogAlertListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertListSettings SetVerbose(this AzureMonitorActivityLogAlertListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogAlertListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertListSettings ResetVerbose(this AzureMonitorActivityLogAlertListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMonitorActivityLogAlertShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMonitorActivityLogAlertShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertShowSettings.Name"/>.</em></p><p>The name of the activity log alert.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertShowSettings SetName(this AzureMonitorActivityLogAlertShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogAlertShowSettings.Name"/>.</em></p><p>The name of the activity log alert.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertShowSettings ResetName(this AzureMonitorActivityLogAlertShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertShowSettings SetResourceGroup(this AzureMonitorActivityLogAlertShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogAlertShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertShowSettings ResetResourceGroup(this AzureMonitorActivityLogAlertShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertShowSettings SetDebug(this AzureMonitorActivityLogAlertShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogAlertShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertShowSettings ResetDebug(this AzureMonitorActivityLogAlertShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertShowSettings SetHelp(this AzureMonitorActivityLogAlertShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogAlertShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertShowSettings ResetHelp(this AzureMonitorActivityLogAlertShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertShowSettings SetOutput(this AzureMonitorActivityLogAlertShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogAlertShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertShowSettings ResetOutput(this AzureMonitorActivityLogAlertShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertShowSettings SetQuery(this AzureMonitorActivityLogAlertShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogAlertShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertShowSettings ResetQuery(this AzureMonitorActivityLogAlertShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertShowSettings SetVerbose(this AzureMonitorActivityLogAlertShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogAlertShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertShowSettings ResetVerbose(this AzureMonitorActivityLogAlertShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMonitorActivityLogAlertUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMonitorActivityLogAlertUpdateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertUpdateSettings.Name"/>.</em></p><p>The name of the activity log alert.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertUpdateSettings SetName(this AzureMonitorActivityLogAlertUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogAlertUpdateSettings.Name"/>.</em></p><p>The name of the activity log alert.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertUpdateSettings ResetName(this AzureMonitorActivityLogAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertUpdateSettings SetResourceGroup(this AzureMonitorActivityLogAlertUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogAlertUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertUpdateSettings ResetResourceGroup(this AzureMonitorActivityLogAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Condition
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertUpdateSettings.Condition"/>.</em></p><p>The conditional expression that will cause the alert to activate. The format is FIELD=VALUE[ and FIELD=VALUE...].</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertUpdateSettings SetCondition(this AzureMonitorActivityLogAlertUpdateSettings toolSettings, string condition)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Condition = condition;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogAlertUpdateSettings.Condition"/>.</em></p><p>The conditional expression that will cause the alert to activate. The format is FIELD=VALUE[ and FIELD=VALUE...].</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertUpdateSettings ResetCondition(this AzureMonitorActivityLogAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Condition = null;
            return toolSettings;
        }
        #endregion
        #region Description
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertUpdateSettings.Description"/>.</em></p><p>A description of this activity log alert.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertUpdateSettings SetDescription(this AzureMonitorActivityLogAlertUpdateSettings toolSettings, string description)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Description = description;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogAlertUpdateSettings.Description"/>.</em></p><p>A description of this activity log alert.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertUpdateSettings ResetDescription(this AzureMonitorActivityLogAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Description = null;
            return toolSettings;
        }
        #endregion
        #region Enabled
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertUpdateSettings.Enabled"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertUpdateSettings SetEnabled(this AzureMonitorActivityLogAlertUpdateSettings toolSettings, bool? enabled)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Enabled = enabled;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogAlertUpdateSettings.Enabled"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertUpdateSettings ResetEnabled(this AzureMonitorActivityLogAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Enabled = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureMonitorActivityLogAlertUpdateSettings.Enabled"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertUpdateSettings EnableEnabled(this AzureMonitorActivityLogAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Enabled = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureMonitorActivityLogAlertUpdateSettings.Enabled"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertUpdateSettings DisableEnabled(this AzureMonitorActivityLogAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Enabled = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureMonitorActivityLogAlertUpdateSettings.Enabled"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertUpdateSettings ToggleEnabled(this AzureMonitorActivityLogAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Enabled = !toolSettings.Enabled;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertUpdateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertUpdateSettings SetTags(this AzureMonitorActivityLogAlertUpdateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogAlertUpdateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertUpdateSettings ResetTags(this AzureMonitorActivityLogAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertUpdateSettings SetAdd(this AzureMonitorActivityLogAlertUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogAlertUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertUpdateSettings ResetAdd(this AzureMonitorActivityLogAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region ForceString
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertUpdateSettings.ForceString"/>.</em></p><p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertUpdateSettings SetForceString(this AzureMonitorActivityLogAlertUpdateSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogAlertUpdateSettings.ForceString"/>.</em></p><p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertUpdateSettings ResetForceString(this AzureMonitorActivityLogAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertUpdateSettings SetRemove(this AzureMonitorActivityLogAlertUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogAlertUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertUpdateSettings ResetRemove(this AzureMonitorActivityLogAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertUpdateSettings SetSet(this AzureMonitorActivityLogAlertUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogAlertUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertUpdateSettings ResetSet(this AzureMonitorActivityLogAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertUpdateSettings SetDebug(this AzureMonitorActivityLogAlertUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogAlertUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertUpdateSettings ResetDebug(this AzureMonitorActivityLogAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertUpdateSettings SetHelp(this AzureMonitorActivityLogAlertUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogAlertUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertUpdateSettings ResetHelp(this AzureMonitorActivityLogAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertUpdateSettings SetOutput(this AzureMonitorActivityLogAlertUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogAlertUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertUpdateSettings ResetOutput(this AzureMonitorActivityLogAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertUpdateSettings SetQuery(this AzureMonitorActivityLogAlertUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogAlertUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertUpdateSettings ResetQuery(this AzureMonitorActivityLogAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertUpdateSettings SetVerbose(this AzureMonitorActivityLogAlertUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogAlertUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertUpdateSettings ResetVerbose(this AzureMonitorActivityLogAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMonitorAutoscaleProfileCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMonitorAutoscaleProfileCreateSettingsExtensions
    {
        #region AutoscaleName
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleProfileCreateSettings.AutoscaleName"/>.</em></p><p>Name of the autoscale settings.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileCreateSettings SetAutoscaleName(this AzureMonitorAutoscaleProfileCreateSettings toolSettings, string autoscaleName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AutoscaleName = autoscaleName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleProfileCreateSettings.AutoscaleName"/>.</em></p><p>Name of the autoscale settings.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileCreateSettings ResetAutoscaleName(this AzureMonitorAutoscaleProfileCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AutoscaleName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleProfileCreateSettings.Name"/>.</em></p><p>Name of the autoscale profile.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileCreateSettings SetName(this AzureMonitorAutoscaleProfileCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleProfileCreateSettings.Name"/>.</em></p><p>Name of the autoscale profile.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileCreateSettings ResetName(this AzureMonitorAutoscaleProfileCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleProfileCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileCreateSettings SetResourceGroup(this AzureMonitorAutoscaleProfileCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleProfileCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileCreateSettings ResetResourceGroup(this AzureMonitorAutoscaleProfileCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region CopyRules
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleProfileCreateSettings.CopyRules"/>.</em></p><p>Name of an existing schedule from which to copy the scaling rules for the new schedule.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileCreateSettings SetCopyRules(this AzureMonitorAutoscaleProfileCreateSettings toolSettings, string copyRules)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CopyRules = copyRules;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleProfileCreateSettings.CopyRules"/>.</em></p><p>Name of an existing schedule from which to copy the scaling rules for the new schedule.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileCreateSettings ResetCopyRules(this AzureMonitorAutoscaleProfileCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CopyRules = null;
            return toolSettings;
        }
        #endregion
        #region Count
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleProfileCreateSettings.Count"/>.</em></p><p>The numer of instances to use. If used with --min/max-count, the default number of instances to use.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileCreateSettings SetCount(this AzureMonitorAutoscaleProfileCreateSettings toolSettings, string count)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Count = count;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleProfileCreateSettings.Count"/>.</em></p><p>The numer of instances to use. If used with --min/max-count, the default number of instances to use.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileCreateSettings ResetCount(this AzureMonitorAutoscaleProfileCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Count = null;
            return toolSettings;
        }
        #endregion
        #region MaxCount
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleProfileCreateSettings.MaxCount"/>.</em></p><p>The maximum number of instances.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileCreateSettings SetMaxCount(this AzureMonitorAutoscaleProfileCreateSettings toolSettings, int? maxCount)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MaxCount = maxCount;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleProfileCreateSettings.MaxCount"/>.</em></p><p>The maximum number of instances.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileCreateSettings ResetMaxCount(this AzureMonitorAutoscaleProfileCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MaxCount = null;
            return toolSettings;
        }
        #endregion
        #region MinCount
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleProfileCreateSettings.MinCount"/>.</em></p><p>The minimum number of instances.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileCreateSettings SetMinCount(this AzureMonitorAutoscaleProfileCreateSettings toolSettings, int? minCount)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MinCount = minCount;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleProfileCreateSettings.MinCount"/>.</em></p><p>The minimum number of instances.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileCreateSettings ResetMinCount(this AzureMonitorAutoscaleProfileCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MinCount = null;
            return toolSettings;
        }
        #endregion
        #region Timezone
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleProfileCreateSettings.Timezone"/>.</em></p><p>Timezone name.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileCreateSettings SetTimezone(this AzureMonitorAutoscaleProfileCreateSettings toolSettings, string timezone)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Timezone = timezone;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleProfileCreateSettings.Timezone"/>.</em></p><p>Timezone name.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileCreateSettings ResetTimezone(this AzureMonitorAutoscaleProfileCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Timezone = null;
            return toolSettings;
        }
        #endregion
        #region End
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleProfileCreateSettings.End"/>.</em></p><p>When the autoscale profile ends. Format depends on the type of profile.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileCreateSettings SetEnd(this AzureMonitorAutoscaleProfileCreateSettings toolSettings, string end)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.End = end;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleProfileCreateSettings.End"/>.</em></p><p>When the autoscale profile ends. Format depends on the type of profile.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileCreateSettings ResetEnd(this AzureMonitorAutoscaleProfileCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.End = null;
            return toolSettings;
        }
        #endregion
        #region Recurrence
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleProfileCreateSettings.Recurrence"/>.</em></p><p>When the profile recurs. If omitted, a fixed (non-recurring) profile is created.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileCreateSettings SetRecurrence(this AzureMonitorAutoscaleProfileCreateSettings toolSettings, string recurrence)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Recurrence = recurrence;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleProfileCreateSettings.Recurrence"/>.</em></p><p>When the profile recurs. If omitted, a fixed (non-recurring) profile is created.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileCreateSettings ResetRecurrence(this AzureMonitorAutoscaleProfileCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Recurrence = null;
            return toolSettings;
        }
        #endregion
        #region Start
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleProfileCreateSettings.Start"/>.</em></p><p>When the autoscale profile begins. Format depends on the type of profile.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileCreateSettings SetStart(this AzureMonitorAutoscaleProfileCreateSettings toolSettings, string start)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Start = start;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleProfileCreateSettings.Start"/>.</em></p><p>When the autoscale profile begins. Format depends on the type of profile.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileCreateSettings ResetStart(this AzureMonitorAutoscaleProfileCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Start = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleProfileCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileCreateSettings SetDebug(this AzureMonitorAutoscaleProfileCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleProfileCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileCreateSettings ResetDebug(this AzureMonitorAutoscaleProfileCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleProfileCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileCreateSettings SetHelp(this AzureMonitorAutoscaleProfileCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleProfileCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileCreateSettings ResetHelp(this AzureMonitorAutoscaleProfileCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleProfileCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileCreateSettings SetOutput(this AzureMonitorAutoscaleProfileCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleProfileCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileCreateSettings ResetOutput(this AzureMonitorAutoscaleProfileCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleProfileCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileCreateSettings SetQuery(this AzureMonitorAutoscaleProfileCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleProfileCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileCreateSettings ResetQuery(this AzureMonitorAutoscaleProfileCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleProfileCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileCreateSettings SetVerbose(this AzureMonitorAutoscaleProfileCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleProfileCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileCreateSettings ResetVerbose(this AzureMonitorAutoscaleProfileCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMonitorAutoscaleProfileDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMonitorAutoscaleProfileDeleteSettingsExtensions
    {
        #region AutoscaleName
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleProfileDeleteSettings.AutoscaleName"/>.</em></p><p>Name of the autoscale settings.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileDeleteSettings SetAutoscaleName(this AzureMonitorAutoscaleProfileDeleteSettings toolSettings, string autoscaleName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AutoscaleName = autoscaleName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleProfileDeleteSettings.AutoscaleName"/>.</em></p><p>Name of the autoscale settings.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileDeleteSettings ResetAutoscaleName(this AzureMonitorAutoscaleProfileDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AutoscaleName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleProfileDeleteSettings.Name"/>.</em></p><p>Name of the autoscale profile.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileDeleteSettings SetName(this AzureMonitorAutoscaleProfileDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleProfileDeleteSettings.Name"/>.</em></p><p>Name of the autoscale profile.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileDeleteSettings ResetName(this AzureMonitorAutoscaleProfileDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleProfileDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileDeleteSettings SetResourceGroup(this AzureMonitorAutoscaleProfileDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleProfileDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileDeleteSettings ResetResourceGroup(this AzureMonitorAutoscaleProfileDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleProfileDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileDeleteSettings SetDebug(this AzureMonitorAutoscaleProfileDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleProfileDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileDeleteSettings ResetDebug(this AzureMonitorAutoscaleProfileDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleProfileDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileDeleteSettings SetHelp(this AzureMonitorAutoscaleProfileDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleProfileDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileDeleteSettings ResetHelp(this AzureMonitorAutoscaleProfileDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleProfileDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileDeleteSettings SetOutput(this AzureMonitorAutoscaleProfileDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleProfileDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileDeleteSettings ResetOutput(this AzureMonitorAutoscaleProfileDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleProfileDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileDeleteSettings SetQuery(this AzureMonitorAutoscaleProfileDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleProfileDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileDeleteSettings ResetQuery(this AzureMonitorAutoscaleProfileDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleProfileDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileDeleteSettings SetVerbose(this AzureMonitorAutoscaleProfileDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleProfileDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileDeleteSettings ResetVerbose(this AzureMonitorAutoscaleProfileDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMonitorAutoscaleProfileListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMonitorAutoscaleProfileListSettingsExtensions
    {
        #region AutoscaleName
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleProfileListSettings.AutoscaleName"/>.</em></p><p>Name of the autoscale settings.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileListSettings SetAutoscaleName(this AzureMonitorAutoscaleProfileListSettings toolSettings, string autoscaleName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AutoscaleName = autoscaleName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleProfileListSettings.AutoscaleName"/>.</em></p><p>Name of the autoscale settings.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileListSettings ResetAutoscaleName(this AzureMonitorAutoscaleProfileListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AutoscaleName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleProfileListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileListSettings SetResourceGroup(this AzureMonitorAutoscaleProfileListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleProfileListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileListSettings ResetResourceGroup(this AzureMonitorAutoscaleProfileListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleProfileListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileListSettings SetDebug(this AzureMonitorAutoscaleProfileListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleProfileListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileListSettings ResetDebug(this AzureMonitorAutoscaleProfileListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleProfileListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileListSettings SetHelp(this AzureMonitorAutoscaleProfileListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleProfileListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileListSettings ResetHelp(this AzureMonitorAutoscaleProfileListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleProfileListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileListSettings SetOutput(this AzureMonitorAutoscaleProfileListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleProfileListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileListSettings ResetOutput(this AzureMonitorAutoscaleProfileListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleProfileListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileListSettings SetQuery(this AzureMonitorAutoscaleProfileListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleProfileListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileListSettings ResetQuery(this AzureMonitorAutoscaleProfileListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleProfileListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileListSettings SetVerbose(this AzureMonitorAutoscaleProfileListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleProfileListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileListSettings ResetVerbose(this AzureMonitorAutoscaleProfileListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMonitorAutoscaleProfileListTimezonesSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMonitorAutoscaleProfileListTimezonesSettingsExtensions
    {
        #region Offset
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleProfileListTimezonesSettings.Offset"/>.</em></p><p>Filter results based on UTC hour offset.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileListTimezonesSettings SetOffset(this AzureMonitorAutoscaleProfileListTimezonesSettings toolSettings, string offset)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Offset = offset;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleProfileListTimezonesSettings.Offset"/>.</em></p><p>Filter results based on UTC hour offset.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileListTimezonesSettings ResetOffset(this AzureMonitorAutoscaleProfileListTimezonesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Offset = null;
            return toolSettings;
        }
        #endregion
        #region SearchQuery
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleProfileListTimezonesSettings.SearchQuery"/>.</em></p><p>Query text to find.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileListTimezonesSettings SetSearchQuery(this AzureMonitorAutoscaleProfileListTimezonesSettings toolSettings, string searchQuery)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SearchQuery = searchQuery;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleProfileListTimezonesSettings.SearchQuery"/>.</em></p><p>Query text to find.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileListTimezonesSettings ResetSearchQuery(this AzureMonitorAutoscaleProfileListTimezonesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SearchQuery = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleProfileListTimezonesSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileListTimezonesSettings SetDebug(this AzureMonitorAutoscaleProfileListTimezonesSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleProfileListTimezonesSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileListTimezonesSettings ResetDebug(this AzureMonitorAutoscaleProfileListTimezonesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleProfileListTimezonesSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileListTimezonesSettings SetHelp(this AzureMonitorAutoscaleProfileListTimezonesSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleProfileListTimezonesSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileListTimezonesSettings ResetHelp(this AzureMonitorAutoscaleProfileListTimezonesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleProfileListTimezonesSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileListTimezonesSettings SetOutput(this AzureMonitorAutoscaleProfileListTimezonesSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleProfileListTimezonesSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileListTimezonesSettings ResetOutput(this AzureMonitorAutoscaleProfileListTimezonesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleProfileListTimezonesSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileListTimezonesSettings SetQuery(this AzureMonitorAutoscaleProfileListTimezonesSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleProfileListTimezonesSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileListTimezonesSettings ResetQuery(this AzureMonitorAutoscaleProfileListTimezonesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleProfileListTimezonesSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileListTimezonesSettings SetVerbose(this AzureMonitorAutoscaleProfileListTimezonesSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleProfileListTimezonesSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileListTimezonesSettings ResetVerbose(this AzureMonitorAutoscaleProfileListTimezonesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMonitorAutoscaleProfileShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMonitorAutoscaleProfileShowSettingsExtensions
    {
        #region AutoscaleName
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleProfileShowSettings.AutoscaleName"/>.</em></p><p>Name of the autoscale settings.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileShowSettings SetAutoscaleName(this AzureMonitorAutoscaleProfileShowSettings toolSettings, string autoscaleName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AutoscaleName = autoscaleName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleProfileShowSettings.AutoscaleName"/>.</em></p><p>Name of the autoscale settings.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileShowSettings ResetAutoscaleName(this AzureMonitorAutoscaleProfileShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AutoscaleName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleProfileShowSettings.Name"/>.</em></p><p>Name of the autoscale profile.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileShowSettings SetName(this AzureMonitorAutoscaleProfileShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleProfileShowSettings.Name"/>.</em></p><p>Name of the autoscale profile.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileShowSettings ResetName(this AzureMonitorAutoscaleProfileShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleProfileShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileShowSettings SetResourceGroup(this AzureMonitorAutoscaleProfileShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleProfileShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileShowSettings ResetResourceGroup(this AzureMonitorAutoscaleProfileShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleProfileShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileShowSettings SetDebug(this AzureMonitorAutoscaleProfileShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleProfileShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileShowSettings ResetDebug(this AzureMonitorAutoscaleProfileShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleProfileShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileShowSettings SetHelp(this AzureMonitorAutoscaleProfileShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleProfileShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileShowSettings ResetHelp(this AzureMonitorAutoscaleProfileShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleProfileShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileShowSettings SetOutput(this AzureMonitorAutoscaleProfileShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleProfileShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileShowSettings ResetOutput(this AzureMonitorAutoscaleProfileShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleProfileShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileShowSettings SetQuery(this AzureMonitorAutoscaleProfileShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleProfileShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileShowSettings ResetQuery(this AzureMonitorAutoscaleProfileShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleProfileShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileShowSettings SetVerbose(this AzureMonitorAutoscaleProfileShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleProfileShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleProfileShowSettings ResetVerbose(this AzureMonitorAutoscaleProfileShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMonitorAutoscaleRuleCopySettingsExtensions
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMonitorAutoscaleRuleCopySettingsExtensions
    {
        #region AutoscaleName
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleRuleCopySettings.AutoscaleName"/>.</em></p><p>Name of the autoscale settings.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleCopySettings SetAutoscaleName(this AzureMonitorAutoscaleRuleCopySettings toolSettings, string autoscaleName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AutoscaleName = autoscaleName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleRuleCopySettings.AutoscaleName"/>.</em></p><p>Name of the autoscale settings.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleCopySettings ResetAutoscaleName(this AzureMonitorAutoscaleRuleCopySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AutoscaleName = null;
            return toolSettings;
        }
        #endregion
        #region DestSchedule
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleRuleCopySettings.DestSchedule"/>.</em></p><p>Name of the profile to copy rules to.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleCopySettings SetDestSchedule(this AzureMonitorAutoscaleRuleCopySettings toolSettings, string destSchedule)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DestSchedule = destSchedule;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleRuleCopySettings.DestSchedule"/>.</em></p><p>Name of the profile to copy rules to.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleCopySettings ResetDestSchedule(this AzureMonitorAutoscaleRuleCopySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DestSchedule = null;
            return toolSettings;
        }
        #endregion
        #region Index
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleRuleCopySettings.Index"/> to a new list.</em></p><p>Space-separated list of rule indices to copy, or '*' to copy all rules.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleCopySettings SetIndex(this AzureMonitorAutoscaleRuleCopySettings toolSettings, params string[] index)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IndexInternal = index.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleRuleCopySettings.Index"/> to a new list.</em></p><p>Space-separated list of rule indices to copy, or '*' to copy all rules.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleCopySettings SetIndex(this AzureMonitorAutoscaleRuleCopySettings toolSettings, IEnumerable<string> index)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IndexInternal = index.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureMonitorAutoscaleRuleCopySettings.Index"/>.</em></p><p>Space-separated list of rule indices to copy, or '*' to copy all rules.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleCopySettings AddIndex(this AzureMonitorAutoscaleRuleCopySettings toolSettings, params string[] index)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IndexInternal.AddRange(index);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureMonitorAutoscaleRuleCopySettings.Index"/>.</em></p><p>Space-separated list of rule indices to copy, or '*' to copy all rules.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleCopySettings AddIndex(this AzureMonitorAutoscaleRuleCopySettings toolSettings, IEnumerable<string> index)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IndexInternal.AddRange(index);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureMonitorAutoscaleRuleCopySettings.Index"/>.</em></p><p>Space-separated list of rule indices to copy, or '*' to copy all rules.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleCopySettings ClearIndex(this AzureMonitorAutoscaleRuleCopySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IndexInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureMonitorAutoscaleRuleCopySettings.Index"/>.</em></p><p>Space-separated list of rule indices to copy, or '*' to copy all rules.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleCopySettings RemoveIndex(this AzureMonitorAutoscaleRuleCopySettings toolSettings, params string[] index)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(index);
            toolSettings.IndexInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureMonitorAutoscaleRuleCopySettings.Index"/>.</em></p><p>Space-separated list of rule indices to copy, or '*' to copy all rules.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleCopySettings RemoveIndex(this AzureMonitorAutoscaleRuleCopySettings toolSettings, IEnumerable<string> index)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(index);
            toolSettings.IndexInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleRuleCopySettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleCopySettings SetResourceGroup(this AzureMonitorAutoscaleRuleCopySettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleRuleCopySettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleCopySettings ResetResourceGroup(this AzureMonitorAutoscaleRuleCopySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region SourceSchedule
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleRuleCopySettings.SourceSchedule"/>.</em></p><p>Name of the profile to copy rules from.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleCopySettings SetSourceSchedule(this AzureMonitorAutoscaleRuleCopySettings toolSettings, string sourceSchedule)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SourceSchedule = sourceSchedule;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleRuleCopySettings.SourceSchedule"/>.</em></p><p>Name of the profile to copy rules from.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleCopySettings ResetSourceSchedule(this AzureMonitorAutoscaleRuleCopySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SourceSchedule = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleRuleCopySettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleCopySettings SetDebug(this AzureMonitorAutoscaleRuleCopySettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleRuleCopySettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleCopySettings ResetDebug(this AzureMonitorAutoscaleRuleCopySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleRuleCopySettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleCopySettings SetHelp(this AzureMonitorAutoscaleRuleCopySettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleRuleCopySettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleCopySettings ResetHelp(this AzureMonitorAutoscaleRuleCopySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleRuleCopySettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleCopySettings SetOutput(this AzureMonitorAutoscaleRuleCopySettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleRuleCopySettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleCopySettings ResetOutput(this AzureMonitorAutoscaleRuleCopySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleRuleCopySettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleCopySettings SetQuery(this AzureMonitorAutoscaleRuleCopySettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleRuleCopySettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleCopySettings ResetQuery(this AzureMonitorAutoscaleRuleCopySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleRuleCopySettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleCopySettings SetVerbose(this AzureMonitorAutoscaleRuleCopySettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleRuleCopySettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleCopySettings ResetVerbose(this AzureMonitorAutoscaleRuleCopySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMonitorAutoscaleRuleCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMonitorAutoscaleRuleCreateSettingsExtensions
    {
        #region AutoscaleName
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleRuleCreateSettings.AutoscaleName"/>.</em></p><p>Name of the autoscale settings.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleCreateSettings SetAutoscaleName(this AzureMonitorAutoscaleRuleCreateSettings toolSettings, string autoscaleName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AutoscaleName = autoscaleName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleRuleCreateSettings.AutoscaleName"/>.</em></p><p>Name of the autoscale settings.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleCreateSettings ResetAutoscaleName(this AzureMonitorAutoscaleRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AutoscaleName = null;
            return toolSettings;
        }
        #endregion
        #region Condition
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleRuleCreateSettings.Condition"/>.</em></p><p>The condition which triggers the scaling action.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleCreateSettings SetCondition(this AzureMonitorAutoscaleRuleCreateSettings toolSettings, string condition)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Condition = condition;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleRuleCreateSettings.Condition"/>.</em></p><p>The condition which triggers the scaling action.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleCreateSettings ResetCondition(this AzureMonitorAutoscaleRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Condition = null;
            return toolSettings;
        }
        #endregion
        #region Scale
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleRuleCreateSettings.Scale"/>.</em></p><p>The direction and amount to scale.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleCreateSettings SetScale(this AzureMonitorAutoscaleRuleCreateSettings toolSettings, string scale)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Scale = scale;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleRuleCreateSettings.Scale"/>.</em></p><p>The direction and amount to scale.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleCreateSettings ResetScale(this AzureMonitorAutoscaleRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Scale = null;
            return toolSettings;
        }
        #endregion
        #region Cooldown
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleRuleCreateSettings.Cooldown"/>.</em></p><p>The number of minutes that must elapse before another scaling event can occur.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleCreateSettings SetCooldown(this AzureMonitorAutoscaleRuleCreateSettings toolSettings, string cooldown)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cooldown = cooldown;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleRuleCreateSettings.Cooldown"/>.</em></p><p>The number of minutes that must elapse before another scaling event can occur.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleCreateSettings ResetCooldown(this AzureMonitorAutoscaleRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cooldown = null;
            return toolSettings;
        }
        #endregion
        #region ProfileName
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleRuleCreateSettings.ProfileName"/>.</em></p><p>Name of the autoscale profile.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleCreateSettings SetProfileName(this AzureMonitorAutoscaleRuleCreateSettings toolSettings, string profileName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProfileName = profileName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleRuleCreateSettings.ProfileName"/>.</em></p><p>Name of the autoscale profile.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleCreateSettings ResetProfileName(this AzureMonitorAutoscaleRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProfileName = null;
            return toolSettings;
        }
        #endregion
        #region Timegrain
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleRuleCreateSettings.Timegrain"/>.</em></p><p>The way metrics are polled across instances.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleCreateSettings SetTimegrain(this AzureMonitorAutoscaleRuleCreateSettings toolSettings, string timegrain)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Timegrain = timegrain;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleRuleCreateSettings.Timegrain"/>.</em></p><p>The way metrics are polled across instances.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleCreateSettings ResetTimegrain(this AzureMonitorAutoscaleRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Timegrain = null;
            return toolSettings;
        }
        #endregion
        #region Resource
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleRuleCreateSettings.Resource"/>.</em></p><p>Name or ID of the target resource.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleCreateSettings SetResource(this AzureMonitorAutoscaleRuleCreateSettings toolSettings, string resource)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = resource;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleRuleCreateSettings.Resource"/>.</em></p><p>Name or ID of the target resource.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleCreateSettings ResetResource(this AzureMonitorAutoscaleRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleRuleCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleCreateSettings SetResourceGroup(this AzureMonitorAutoscaleRuleCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleRuleCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleCreateSettings ResetResourceGroup(this AzureMonitorAutoscaleRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ResourceNamespace
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleRuleCreateSettings.ResourceNamespace"/>.</em></p><p>Target resource provider namespace.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleCreateSettings SetResourceNamespace(this AzureMonitorAutoscaleRuleCreateSettings toolSettings, string resourceNamespace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceNamespace = resourceNamespace;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleRuleCreateSettings.ResourceNamespace"/>.</em></p><p>Target resource provider namespace.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleCreateSettings ResetResourceNamespace(this AzureMonitorAutoscaleRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceNamespace = null;
            return toolSettings;
        }
        #endregion
        #region ResourceParent
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleRuleCreateSettings.ResourceParent"/>.</em></p><p>Target resource parent path, if applicable.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleCreateSettings SetResourceParent(this AzureMonitorAutoscaleRuleCreateSettings toolSettings, string resourceParent)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceParent = resourceParent;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleRuleCreateSettings.ResourceParent"/>.</em></p><p>Target resource parent path, if applicable.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleCreateSettings ResetResourceParent(this AzureMonitorAutoscaleRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceParent = null;
            return toolSettings;
        }
        #endregion
        #region ResourceType
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleRuleCreateSettings.ResourceType"/>.</em></p><p>Target resource type. Can also accept namespace/type format (Ex: 'Microsoft.Compute/virtualMachines)').</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleCreateSettings SetResourceType(this AzureMonitorAutoscaleRuleCreateSettings toolSettings, string resourceType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = resourceType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleRuleCreateSettings.ResourceType"/>.</em></p><p>Target resource type. Can also accept namespace/type format (Ex: 'Microsoft.Compute/virtualMachines)').</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleCreateSettings ResetResourceType(this AzureMonitorAutoscaleRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleRuleCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleCreateSettings SetDebug(this AzureMonitorAutoscaleRuleCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleRuleCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleCreateSettings ResetDebug(this AzureMonitorAutoscaleRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleRuleCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleCreateSettings SetHelp(this AzureMonitorAutoscaleRuleCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleRuleCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleCreateSettings ResetHelp(this AzureMonitorAutoscaleRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleRuleCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleCreateSettings SetOutput(this AzureMonitorAutoscaleRuleCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleRuleCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleCreateSettings ResetOutput(this AzureMonitorAutoscaleRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleRuleCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleCreateSettings SetQuery(this AzureMonitorAutoscaleRuleCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleRuleCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleCreateSettings ResetQuery(this AzureMonitorAutoscaleRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleRuleCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleCreateSettings SetVerbose(this AzureMonitorAutoscaleRuleCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleRuleCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleCreateSettings ResetVerbose(this AzureMonitorAutoscaleRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMonitorAutoscaleRuleDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMonitorAutoscaleRuleDeleteSettingsExtensions
    {
        #region AutoscaleName
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleRuleDeleteSettings.AutoscaleName"/>.</em></p><p>Name of the autoscale settings.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleDeleteSettings SetAutoscaleName(this AzureMonitorAutoscaleRuleDeleteSettings toolSettings, string autoscaleName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AutoscaleName = autoscaleName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleRuleDeleteSettings.AutoscaleName"/>.</em></p><p>Name of the autoscale settings.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleDeleteSettings ResetAutoscaleName(this AzureMonitorAutoscaleRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AutoscaleName = null;
            return toolSettings;
        }
        #endregion
        #region Index
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleRuleDeleteSettings.Index"/> to a new list.</em></p><p>Space-separated list of rule indices to remove, or '*' to clear all rules.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleDeleteSettings SetIndex(this AzureMonitorAutoscaleRuleDeleteSettings toolSettings, params string[] index)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IndexInternal = index.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleRuleDeleteSettings.Index"/> to a new list.</em></p><p>Space-separated list of rule indices to remove, or '*' to clear all rules.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleDeleteSettings SetIndex(this AzureMonitorAutoscaleRuleDeleteSettings toolSettings, IEnumerable<string> index)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IndexInternal = index.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureMonitorAutoscaleRuleDeleteSettings.Index"/>.</em></p><p>Space-separated list of rule indices to remove, or '*' to clear all rules.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleDeleteSettings AddIndex(this AzureMonitorAutoscaleRuleDeleteSettings toolSettings, params string[] index)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IndexInternal.AddRange(index);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureMonitorAutoscaleRuleDeleteSettings.Index"/>.</em></p><p>Space-separated list of rule indices to remove, or '*' to clear all rules.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleDeleteSettings AddIndex(this AzureMonitorAutoscaleRuleDeleteSettings toolSettings, IEnumerable<string> index)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IndexInternal.AddRange(index);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureMonitorAutoscaleRuleDeleteSettings.Index"/>.</em></p><p>Space-separated list of rule indices to remove, or '*' to clear all rules.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleDeleteSettings ClearIndex(this AzureMonitorAutoscaleRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IndexInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureMonitorAutoscaleRuleDeleteSettings.Index"/>.</em></p><p>Space-separated list of rule indices to remove, or '*' to clear all rules.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleDeleteSettings RemoveIndex(this AzureMonitorAutoscaleRuleDeleteSettings toolSettings, params string[] index)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(index);
            toolSettings.IndexInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureMonitorAutoscaleRuleDeleteSettings.Index"/>.</em></p><p>Space-separated list of rule indices to remove, or '*' to clear all rules.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleDeleteSettings RemoveIndex(this AzureMonitorAutoscaleRuleDeleteSettings toolSettings, IEnumerable<string> index)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(index);
            toolSettings.IndexInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleRuleDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleDeleteSettings SetResourceGroup(this AzureMonitorAutoscaleRuleDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleRuleDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleDeleteSettings ResetResourceGroup(this AzureMonitorAutoscaleRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ProfileName
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleRuleDeleteSettings.ProfileName"/>.</em></p><p>Name of the autoscale profile.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleDeleteSettings SetProfileName(this AzureMonitorAutoscaleRuleDeleteSettings toolSettings, string profileName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProfileName = profileName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleRuleDeleteSettings.ProfileName"/>.</em></p><p>Name of the autoscale profile.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleDeleteSettings ResetProfileName(this AzureMonitorAutoscaleRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProfileName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleRuleDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleDeleteSettings SetDebug(this AzureMonitorAutoscaleRuleDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleRuleDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleDeleteSettings ResetDebug(this AzureMonitorAutoscaleRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleRuleDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleDeleteSettings SetHelp(this AzureMonitorAutoscaleRuleDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleRuleDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleDeleteSettings ResetHelp(this AzureMonitorAutoscaleRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleRuleDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleDeleteSettings SetOutput(this AzureMonitorAutoscaleRuleDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleRuleDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleDeleteSettings ResetOutput(this AzureMonitorAutoscaleRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleRuleDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleDeleteSettings SetQuery(this AzureMonitorAutoscaleRuleDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleRuleDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleDeleteSettings ResetQuery(this AzureMonitorAutoscaleRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleRuleDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleDeleteSettings SetVerbose(this AzureMonitorAutoscaleRuleDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleRuleDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleDeleteSettings ResetVerbose(this AzureMonitorAutoscaleRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMonitorAutoscaleRuleListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMonitorAutoscaleRuleListSettingsExtensions
    {
        #region AutoscaleName
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleRuleListSettings.AutoscaleName"/>.</em></p><p>Name of the autoscale settings.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleListSettings SetAutoscaleName(this AzureMonitorAutoscaleRuleListSettings toolSettings, string autoscaleName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AutoscaleName = autoscaleName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleRuleListSettings.AutoscaleName"/>.</em></p><p>Name of the autoscale settings.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleListSettings ResetAutoscaleName(this AzureMonitorAutoscaleRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AutoscaleName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleRuleListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleListSettings SetResourceGroup(this AzureMonitorAutoscaleRuleListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleRuleListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleListSettings ResetResourceGroup(this AzureMonitorAutoscaleRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ProfileName
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleRuleListSettings.ProfileName"/>.</em></p><p>Name of the autoscale profile.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleListSettings SetProfileName(this AzureMonitorAutoscaleRuleListSettings toolSettings, string profileName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProfileName = profileName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleRuleListSettings.ProfileName"/>.</em></p><p>Name of the autoscale profile.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleListSettings ResetProfileName(this AzureMonitorAutoscaleRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProfileName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleRuleListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleListSettings SetDebug(this AzureMonitorAutoscaleRuleListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleRuleListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleListSettings ResetDebug(this AzureMonitorAutoscaleRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleRuleListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleListSettings SetHelp(this AzureMonitorAutoscaleRuleListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleRuleListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleListSettings ResetHelp(this AzureMonitorAutoscaleRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleRuleListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleListSettings SetOutput(this AzureMonitorAutoscaleRuleListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleRuleListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleListSettings ResetOutput(this AzureMonitorAutoscaleRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleRuleListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleListSettings SetQuery(this AzureMonitorAutoscaleRuleListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleRuleListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleListSettings ResetQuery(this AzureMonitorAutoscaleRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMonitorAutoscaleRuleListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleListSettings SetVerbose(this AzureMonitorAutoscaleRuleListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorAutoscaleRuleListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorAutoscaleRuleListSettings ResetVerbose(this AzureMonitorAutoscaleRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMonitorDiagnosticSettingsCategoriesListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMonitorDiagnosticSettingsCategoriesListSettingsExtensions
    {
        #region Resource
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsCategoriesListSettings.Resource"/>.</em></p><p>Name or ID of the target resource.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsCategoriesListSettings SetResource(this AzureMonitorDiagnosticSettingsCategoriesListSettings toolSettings, string resource)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = resource;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsCategoriesListSettings.Resource"/>.</em></p><p>Name or ID of the target resource.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsCategoriesListSettings ResetResource(this AzureMonitorDiagnosticSettingsCategoriesListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsCategoriesListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsCategoriesListSettings SetResourceGroup(this AzureMonitorDiagnosticSettingsCategoriesListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsCategoriesListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsCategoriesListSettings ResetResourceGroup(this AzureMonitorDiagnosticSettingsCategoriesListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ResourceNamespace
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsCategoriesListSettings.ResourceNamespace"/>.</em></p><p>Target resource provider namespace.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsCategoriesListSettings SetResourceNamespace(this AzureMonitorDiagnosticSettingsCategoriesListSettings toolSettings, string resourceNamespace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceNamespace = resourceNamespace;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsCategoriesListSettings.ResourceNamespace"/>.</em></p><p>Target resource provider namespace.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsCategoriesListSettings ResetResourceNamespace(this AzureMonitorDiagnosticSettingsCategoriesListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceNamespace = null;
            return toolSettings;
        }
        #endregion
        #region ResourceParent
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsCategoriesListSettings.ResourceParent"/>.</em></p><p>Target resource parent path, if applicable.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsCategoriesListSettings SetResourceParent(this AzureMonitorDiagnosticSettingsCategoriesListSettings toolSettings, string resourceParent)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceParent = resourceParent;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsCategoriesListSettings.ResourceParent"/>.</em></p><p>Target resource parent path, if applicable.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsCategoriesListSettings ResetResourceParent(this AzureMonitorDiagnosticSettingsCategoriesListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceParent = null;
            return toolSettings;
        }
        #endregion
        #region ResourceType
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsCategoriesListSettings.ResourceType"/>.</em></p><p>Target resource type. Can also accept namespace/type format (Ex: 'Microsoft.Compute/virtualMachines)').</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsCategoriesListSettings SetResourceType(this AzureMonitorDiagnosticSettingsCategoriesListSettings toolSettings, string resourceType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = resourceType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsCategoriesListSettings.ResourceType"/>.</em></p><p>Target resource type. Can also accept namespace/type format (Ex: 'Microsoft.Compute/virtualMachines)').</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsCategoriesListSettings ResetResourceType(this AzureMonitorDiagnosticSettingsCategoriesListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsCategoriesListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsCategoriesListSettings SetDebug(this AzureMonitorDiagnosticSettingsCategoriesListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsCategoriesListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsCategoriesListSettings ResetDebug(this AzureMonitorDiagnosticSettingsCategoriesListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsCategoriesListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsCategoriesListSettings SetHelp(this AzureMonitorDiagnosticSettingsCategoriesListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsCategoriesListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsCategoriesListSettings ResetHelp(this AzureMonitorDiagnosticSettingsCategoriesListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsCategoriesListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsCategoriesListSettings SetOutput(this AzureMonitorDiagnosticSettingsCategoriesListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsCategoriesListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsCategoriesListSettings ResetOutput(this AzureMonitorDiagnosticSettingsCategoriesListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsCategoriesListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsCategoriesListSettings SetQuery(this AzureMonitorDiagnosticSettingsCategoriesListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsCategoriesListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsCategoriesListSettings ResetQuery(this AzureMonitorDiagnosticSettingsCategoriesListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsCategoriesListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsCategoriesListSettings SetVerbose(this AzureMonitorDiagnosticSettingsCategoriesListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsCategoriesListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsCategoriesListSettings ResetVerbose(this AzureMonitorDiagnosticSettingsCategoriesListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMonitorDiagnosticSettingsCategoriesShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMonitorDiagnosticSettingsCategoriesShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsCategoriesShowSettings.Name"/>.</em></p><p>The name of the diagnostic setting.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsCategoriesShowSettings SetName(this AzureMonitorDiagnosticSettingsCategoriesShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsCategoriesShowSettings.Name"/>.</em></p><p>The name of the diagnostic setting.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsCategoriesShowSettings ResetName(this AzureMonitorDiagnosticSettingsCategoriesShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Resource
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsCategoriesShowSettings.Resource"/>.</em></p><p>Name or ID of the target resource.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsCategoriesShowSettings SetResource(this AzureMonitorDiagnosticSettingsCategoriesShowSettings toolSettings, string resource)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = resource;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsCategoriesShowSettings.Resource"/>.</em></p><p>Name or ID of the target resource.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsCategoriesShowSettings ResetResource(this AzureMonitorDiagnosticSettingsCategoriesShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsCategoriesShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsCategoriesShowSettings SetResourceGroup(this AzureMonitorDiagnosticSettingsCategoriesShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsCategoriesShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsCategoriesShowSettings ResetResourceGroup(this AzureMonitorDiagnosticSettingsCategoriesShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ResourceNamespace
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsCategoriesShowSettings.ResourceNamespace"/>.</em></p><p>Target resource provider namespace.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsCategoriesShowSettings SetResourceNamespace(this AzureMonitorDiagnosticSettingsCategoriesShowSettings toolSettings, string resourceNamespace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceNamespace = resourceNamespace;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsCategoriesShowSettings.ResourceNamespace"/>.</em></p><p>Target resource provider namespace.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsCategoriesShowSettings ResetResourceNamespace(this AzureMonitorDiagnosticSettingsCategoriesShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceNamespace = null;
            return toolSettings;
        }
        #endregion
        #region ResourceParent
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsCategoriesShowSettings.ResourceParent"/>.</em></p><p>Target resource parent path, if applicable.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsCategoriesShowSettings SetResourceParent(this AzureMonitorDiagnosticSettingsCategoriesShowSettings toolSettings, string resourceParent)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceParent = resourceParent;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsCategoriesShowSettings.ResourceParent"/>.</em></p><p>Target resource parent path, if applicable.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsCategoriesShowSettings ResetResourceParent(this AzureMonitorDiagnosticSettingsCategoriesShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceParent = null;
            return toolSettings;
        }
        #endregion
        #region ResourceType
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsCategoriesShowSettings.ResourceType"/>.</em></p><p>Target resource type. Can also accept namespace/type format (Ex: 'Microsoft.Compute/virtualMachines)').</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsCategoriesShowSettings SetResourceType(this AzureMonitorDiagnosticSettingsCategoriesShowSettings toolSettings, string resourceType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = resourceType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsCategoriesShowSettings.ResourceType"/>.</em></p><p>Target resource type. Can also accept namespace/type format (Ex: 'Microsoft.Compute/virtualMachines)').</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsCategoriesShowSettings ResetResourceType(this AzureMonitorDiagnosticSettingsCategoriesShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsCategoriesShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsCategoriesShowSettings SetDebug(this AzureMonitorDiagnosticSettingsCategoriesShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsCategoriesShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsCategoriesShowSettings ResetDebug(this AzureMonitorDiagnosticSettingsCategoriesShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsCategoriesShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsCategoriesShowSettings SetHelp(this AzureMonitorDiagnosticSettingsCategoriesShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsCategoriesShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsCategoriesShowSettings ResetHelp(this AzureMonitorDiagnosticSettingsCategoriesShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsCategoriesShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsCategoriesShowSettings SetOutput(this AzureMonitorDiagnosticSettingsCategoriesShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsCategoriesShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsCategoriesShowSettings ResetOutput(this AzureMonitorDiagnosticSettingsCategoriesShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsCategoriesShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsCategoriesShowSettings SetQuery(this AzureMonitorDiagnosticSettingsCategoriesShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsCategoriesShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsCategoriesShowSettings ResetQuery(this AzureMonitorDiagnosticSettingsCategoriesShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMonitorDiagnosticSettingsCategoriesShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsCategoriesShowSettings SetVerbose(this AzureMonitorDiagnosticSettingsCategoriesShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorDiagnosticSettingsCategoriesShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorDiagnosticSettingsCategoriesShowSettings ResetVerbose(this AzureMonitorDiagnosticSettingsCategoriesShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMonitorMetricsAlertCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMonitorMetricsAlertCreateSettingsExtensions
    {
        #region Condition
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsAlertCreateSettings.Condition"/>.</em></p><p>The condition which triggers the rule.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertCreateSettings SetCondition(this AzureMonitorMetricsAlertCreateSettings toolSettings, string condition)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Condition = condition;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsAlertCreateSettings.Condition"/>.</em></p><p>The condition which triggers the rule.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertCreateSettings ResetCondition(this AzureMonitorMetricsAlertCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Condition = null;
            return toolSettings;
        }
        #endregion
        #region Description
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsAlertCreateSettings.Description"/>.</em></p><p>Free-text description of the rule.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertCreateSettings SetDescription(this AzureMonitorMetricsAlertCreateSettings toolSettings, string description)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Description = description;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsAlertCreateSettings.Description"/>.</em></p><p>Free-text description of the rule.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertCreateSettings ResetDescription(this AzureMonitorMetricsAlertCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Description = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsAlertCreateSettings.Name"/>.</em></p><p>Name of the alert rule.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertCreateSettings SetName(this AzureMonitorMetricsAlertCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsAlertCreateSettings.Name"/>.</em></p><p>Name of the alert rule.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertCreateSettings ResetName(this AzureMonitorMetricsAlertCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsAlertCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertCreateSettings SetResourceGroup(this AzureMonitorMetricsAlertCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsAlertCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertCreateSettings ResetResourceGroup(this AzureMonitorMetricsAlertCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Scopes
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsAlertCreateSettings.Scopes"/> to a new list.</em></p><p>Space-separated list of scopes the rule applies to.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertCreateSettings SetScopes(this AzureMonitorMetricsAlertCreateSettings toolSettings, params string[] scopes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ScopesInternal = scopes.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsAlertCreateSettings.Scopes"/> to a new list.</em></p><p>Space-separated list of scopes the rule applies to.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertCreateSettings SetScopes(this AzureMonitorMetricsAlertCreateSettings toolSettings, IEnumerable<string> scopes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ScopesInternal = scopes.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureMonitorMetricsAlertCreateSettings.Scopes"/>.</em></p><p>Space-separated list of scopes the rule applies to.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertCreateSettings AddScopes(this AzureMonitorMetricsAlertCreateSettings toolSettings, params string[] scopes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ScopesInternal.AddRange(scopes);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureMonitorMetricsAlertCreateSettings.Scopes"/>.</em></p><p>Space-separated list of scopes the rule applies to.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertCreateSettings AddScopes(this AzureMonitorMetricsAlertCreateSettings toolSettings, IEnumerable<string> scopes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ScopesInternal.AddRange(scopes);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureMonitorMetricsAlertCreateSettings.Scopes"/>.</em></p><p>Space-separated list of scopes the rule applies to.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertCreateSettings ClearScopes(this AzureMonitorMetricsAlertCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ScopesInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureMonitorMetricsAlertCreateSettings.Scopes"/>.</em></p><p>Space-separated list of scopes the rule applies to.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertCreateSettings RemoveScopes(this AzureMonitorMetricsAlertCreateSettings toolSettings, params string[] scopes)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(scopes);
            toolSettings.ScopesInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureMonitorMetricsAlertCreateSettings.Scopes"/>.</em></p><p>Space-separated list of scopes the rule applies to.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertCreateSettings RemoveScopes(this AzureMonitorMetricsAlertCreateSettings toolSettings, IEnumerable<string> scopes)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(scopes);
            toolSettings.ScopesInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Action
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsAlertCreateSettings.Action"/>.</em></p><p>Add an action group and optional webhook properties to fire when the alert is triggered.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertCreateSettings SetAction(this AzureMonitorMetricsAlertCreateSettings toolSettings, string action)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Action = action;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsAlertCreateSettings.Action"/>.</em></p><p>Add an action group and optional webhook properties to fire when the alert is triggered.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertCreateSettings ResetAction(this AzureMonitorMetricsAlertCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Action = null;
            return toolSettings;
        }
        #endregion
        #region AutoMitigate
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsAlertCreateSettings.AutoMitigate"/>.</em></p><p>Automatically resolve the alert.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertCreateSettings SetAutoMitigate(this AzureMonitorMetricsAlertCreateSettings toolSettings, bool? autoMitigate)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AutoMitigate = autoMitigate;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsAlertCreateSettings.AutoMitigate"/>.</em></p><p>Automatically resolve the alert.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertCreateSettings ResetAutoMitigate(this AzureMonitorMetricsAlertCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AutoMitigate = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureMonitorMetricsAlertCreateSettings.AutoMitigate"/>.</em></p><p>Automatically resolve the alert.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertCreateSettings EnableAutoMitigate(this AzureMonitorMetricsAlertCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AutoMitigate = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureMonitorMetricsAlertCreateSettings.AutoMitigate"/>.</em></p><p>Automatically resolve the alert.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertCreateSettings DisableAutoMitigate(this AzureMonitorMetricsAlertCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AutoMitigate = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureMonitorMetricsAlertCreateSettings.AutoMitigate"/>.</em></p><p>Automatically resolve the alert.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertCreateSettings ToggleAutoMitigate(this AzureMonitorMetricsAlertCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AutoMitigate = !toolSettings.AutoMitigate;
            return toolSettings;
        }
        #endregion
        #region Disabled
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsAlertCreateSettings.Disabled"/>.</em></p><p>Create the rule in a disabled state.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertCreateSettings SetDisabled(this AzureMonitorMetricsAlertCreateSettings toolSettings, bool? disabled)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Disabled = disabled;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsAlertCreateSettings.Disabled"/>.</em></p><p>Create the rule in a disabled state.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertCreateSettings ResetDisabled(this AzureMonitorMetricsAlertCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Disabled = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureMonitorMetricsAlertCreateSettings.Disabled"/>.</em></p><p>Create the rule in a disabled state.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertCreateSettings EnableDisabled(this AzureMonitorMetricsAlertCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Disabled = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureMonitorMetricsAlertCreateSettings.Disabled"/>.</em></p><p>Create the rule in a disabled state.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertCreateSettings DisableDisabled(this AzureMonitorMetricsAlertCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Disabled = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureMonitorMetricsAlertCreateSettings.Disabled"/>.</em></p><p>Create the rule in a disabled state.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertCreateSettings ToggleDisabled(this AzureMonitorMetricsAlertCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Disabled = !toolSettings.Disabled;
            return toolSettings;
        }
        #endregion
        #region EvaluationFrequency
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsAlertCreateSettings.EvaluationFrequency"/>.</em></p><p>Frequency with which to evaluate the rule in "##h##m##s" format.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertCreateSettings SetEvaluationFrequency(this AzureMonitorMetricsAlertCreateSettings toolSettings, string evaluationFrequency)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EvaluationFrequency = evaluationFrequency;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsAlertCreateSettings.EvaluationFrequency"/>.</em></p><p>Frequency with which to evaluate the rule in "##h##m##s" format.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertCreateSettings ResetEvaluationFrequency(this AzureMonitorMetricsAlertCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EvaluationFrequency = null;
            return toolSettings;
        }
        #endregion
        #region Severity
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsAlertCreateSettings.Severity"/>.</em></p><p>Severity of the alert from 0 (low) to 4 (high).</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertCreateSettings SetSeverity(this AzureMonitorMetricsAlertCreateSettings toolSettings, string severity)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Severity = severity;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsAlertCreateSettings.Severity"/>.</em></p><p>Severity of the alert from 0 (low) to 4 (high).</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertCreateSettings ResetSeverity(this AzureMonitorMetricsAlertCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Severity = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsAlertCreateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertCreateSettings SetTags(this AzureMonitorMetricsAlertCreateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsAlertCreateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertCreateSettings ResetTags(this AzureMonitorMetricsAlertCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region WindowSize
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsAlertCreateSettings.WindowSize"/>.</em></p><p>Time over which to aggregate metrics in "##h##m##s" format.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertCreateSettings SetWindowSize(this AzureMonitorMetricsAlertCreateSettings toolSettings, string windowSize)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WindowSize = windowSize;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsAlertCreateSettings.WindowSize"/>.</em></p><p>Time over which to aggregate metrics in "##h##m##s" format.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertCreateSettings ResetWindowSize(this AzureMonitorMetricsAlertCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WindowSize = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsAlertCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertCreateSettings SetDebug(this AzureMonitorMetricsAlertCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsAlertCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertCreateSettings ResetDebug(this AzureMonitorMetricsAlertCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsAlertCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertCreateSettings SetHelp(this AzureMonitorMetricsAlertCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsAlertCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertCreateSettings ResetHelp(this AzureMonitorMetricsAlertCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsAlertCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertCreateSettings SetOutput(this AzureMonitorMetricsAlertCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsAlertCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertCreateSettings ResetOutput(this AzureMonitorMetricsAlertCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsAlertCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertCreateSettings SetQuery(this AzureMonitorMetricsAlertCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsAlertCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertCreateSettings ResetQuery(this AzureMonitorMetricsAlertCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsAlertCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertCreateSettings SetVerbose(this AzureMonitorMetricsAlertCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsAlertCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertCreateSettings ResetVerbose(this AzureMonitorMetricsAlertCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMonitorMetricsAlertDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMonitorMetricsAlertDeleteSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsAlertDeleteSettings.Name"/>.</em></p><p>Name of the alert rule.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertDeleteSettings SetName(this AzureMonitorMetricsAlertDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsAlertDeleteSettings.Name"/>.</em></p><p>Name of the alert rule.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertDeleteSettings ResetName(this AzureMonitorMetricsAlertDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsAlertDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertDeleteSettings SetResourceGroup(this AzureMonitorMetricsAlertDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsAlertDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertDeleteSettings ResetResourceGroup(this AzureMonitorMetricsAlertDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsAlertDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertDeleteSettings SetDebug(this AzureMonitorMetricsAlertDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsAlertDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertDeleteSettings ResetDebug(this AzureMonitorMetricsAlertDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsAlertDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertDeleteSettings SetHelp(this AzureMonitorMetricsAlertDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsAlertDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertDeleteSettings ResetHelp(this AzureMonitorMetricsAlertDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsAlertDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertDeleteSettings SetOutput(this AzureMonitorMetricsAlertDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsAlertDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertDeleteSettings ResetOutput(this AzureMonitorMetricsAlertDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsAlertDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertDeleteSettings SetQuery(this AzureMonitorMetricsAlertDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsAlertDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertDeleteSettings ResetQuery(this AzureMonitorMetricsAlertDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsAlertDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertDeleteSettings SetVerbose(this AzureMonitorMetricsAlertDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsAlertDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertDeleteSettings ResetVerbose(this AzureMonitorMetricsAlertDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMonitorMetricsAlertListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMonitorMetricsAlertListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsAlertListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertListSettings SetResourceGroup(this AzureMonitorMetricsAlertListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsAlertListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertListSettings ResetResourceGroup(this AzureMonitorMetricsAlertListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsAlertListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertListSettings SetDebug(this AzureMonitorMetricsAlertListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsAlertListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertListSettings ResetDebug(this AzureMonitorMetricsAlertListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsAlertListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertListSettings SetHelp(this AzureMonitorMetricsAlertListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsAlertListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertListSettings ResetHelp(this AzureMonitorMetricsAlertListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsAlertListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertListSettings SetOutput(this AzureMonitorMetricsAlertListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsAlertListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertListSettings ResetOutput(this AzureMonitorMetricsAlertListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsAlertListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertListSettings SetQuery(this AzureMonitorMetricsAlertListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsAlertListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertListSettings ResetQuery(this AzureMonitorMetricsAlertListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsAlertListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertListSettings SetVerbose(this AzureMonitorMetricsAlertListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsAlertListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertListSettings ResetVerbose(this AzureMonitorMetricsAlertListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMonitorMetricsAlertShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMonitorMetricsAlertShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsAlertShowSettings.Name"/>.</em></p><p>Name of the alert rule.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertShowSettings SetName(this AzureMonitorMetricsAlertShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsAlertShowSettings.Name"/>.</em></p><p>Name of the alert rule.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertShowSettings ResetName(this AzureMonitorMetricsAlertShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsAlertShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertShowSettings SetResourceGroup(this AzureMonitorMetricsAlertShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsAlertShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertShowSettings ResetResourceGroup(this AzureMonitorMetricsAlertShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsAlertShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertShowSettings SetDebug(this AzureMonitorMetricsAlertShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsAlertShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertShowSettings ResetDebug(this AzureMonitorMetricsAlertShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsAlertShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertShowSettings SetHelp(this AzureMonitorMetricsAlertShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsAlertShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertShowSettings ResetHelp(this AzureMonitorMetricsAlertShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsAlertShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertShowSettings SetOutput(this AzureMonitorMetricsAlertShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsAlertShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertShowSettings ResetOutput(this AzureMonitorMetricsAlertShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsAlertShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertShowSettings SetQuery(this AzureMonitorMetricsAlertShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsAlertShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertShowSettings ResetQuery(this AzureMonitorMetricsAlertShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsAlertShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertShowSettings SetVerbose(this AzureMonitorMetricsAlertShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsAlertShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertShowSettings ResetVerbose(this AzureMonitorMetricsAlertShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMonitorMetricsAlertUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMonitorMetricsAlertUpdateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsAlertUpdateSettings.Name"/>.</em></p><p>Name of the alert rule.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertUpdateSettings SetName(this AzureMonitorMetricsAlertUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsAlertUpdateSettings.Name"/>.</em></p><p>Name of the alert rule.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertUpdateSettings ResetName(this AzureMonitorMetricsAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsAlertUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertUpdateSettings SetResourceGroup(this AzureMonitorMetricsAlertUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsAlertUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertUpdateSettings ResetResourceGroup(this AzureMonitorMetricsAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region AutoMitigate
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsAlertUpdateSettings.AutoMitigate"/>.</em></p><p>Automatically resolve the alert.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertUpdateSettings SetAutoMitigate(this AzureMonitorMetricsAlertUpdateSettings toolSettings, bool? autoMitigate)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AutoMitigate = autoMitigate;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsAlertUpdateSettings.AutoMitigate"/>.</em></p><p>Automatically resolve the alert.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertUpdateSettings ResetAutoMitigate(this AzureMonitorMetricsAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AutoMitigate = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureMonitorMetricsAlertUpdateSettings.AutoMitigate"/>.</em></p><p>Automatically resolve the alert.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertUpdateSettings EnableAutoMitigate(this AzureMonitorMetricsAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AutoMitigate = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureMonitorMetricsAlertUpdateSettings.AutoMitigate"/>.</em></p><p>Automatically resolve the alert.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertUpdateSettings DisableAutoMitigate(this AzureMonitorMetricsAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AutoMitigate = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureMonitorMetricsAlertUpdateSettings.AutoMitigate"/>.</em></p><p>Automatically resolve the alert.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertUpdateSettings ToggleAutoMitigate(this AzureMonitorMetricsAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AutoMitigate = !toolSettings.AutoMitigate;
            return toolSettings;
        }
        #endregion
        #region Description
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsAlertUpdateSettings.Description"/>.</em></p><p>Free-text description of the rule.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertUpdateSettings SetDescription(this AzureMonitorMetricsAlertUpdateSettings toolSettings, string description)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Description = description;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsAlertUpdateSettings.Description"/>.</em></p><p>Free-text description of the rule.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertUpdateSettings ResetDescription(this AzureMonitorMetricsAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Description = null;
            return toolSettings;
        }
        #endregion
        #region Enabled
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsAlertUpdateSettings.Enabled"/>.</em></p><p>Whether the metric alert rule is enabled.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertUpdateSettings SetEnabled(this AzureMonitorMetricsAlertUpdateSettings toolSettings, bool? enabled)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Enabled = enabled;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsAlertUpdateSettings.Enabled"/>.</em></p><p>Whether the metric alert rule is enabled.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertUpdateSettings ResetEnabled(this AzureMonitorMetricsAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Enabled = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureMonitorMetricsAlertUpdateSettings.Enabled"/>.</em></p><p>Whether the metric alert rule is enabled.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertUpdateSettings EnableEnabled(this AzureMonitorMetricsAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Enabled = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureMonitorMetricsAlertUpdateSettings.Enabled"/>.</em></p><p>Whether the metric alert rule is enabled.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertUpdateSettings DisableEnabled(this AzureMonitorMetricsAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Enabled = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureMonitorMetricsAlertUpdateSettings.Enabled"/>.</em></p><p>Whether the metric alert rule is enabled.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertUpdateSettings ToggleEnabled(this AzureMonitorMetricsAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Enabled = !toolSettings.Enabled;
            return toolSettings;
        }
        #endregion
        #region EvaluationFrequency
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsAlertUpdateSettings.EvaluationFrequency"/>.</em></p><p>Frequency with which to evaluate the rule in "##h##m##s" format.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertUpdateSettings SetEvaluationFrequency(this AzureMonitorMetricsAlertUpdateSettings toolSettings, string evaluationFrequency)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EvaluationFrequency = evaluationFrequency;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsAlertUpdateSettings.EvaluationFrequency"/>.</em></p><p>Frequency with which to evaluate the rule in "##h##m##s" format.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertUpdateSettings ResetEvaluationFrequency(this AzureMonitorMetricsAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EvaluationFrequency = null;
            return toolSettings;
        }
        #endregion
        #region Scopes
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsAlertUpdateSettings.Scopes"/> to a new list.</em></p><p>Space-separated list of scopes the rule applies to.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertUpdateSettings SetScopes(this AzureMonitorMetricsAlertUpdateSettings toolSettings, params string[] scopes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ScopesInternal = scopes.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsAlertUpdateSettings.Scopes"/> to a new list.</em></p><p>Space-separated list of scopes the rule applies to.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertUpdateSettings SetScopes(this AzureMonitorMetricsAlertUpdateSettings toolSettings, IEnumerable<string> scopes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ScopesInternal = scopes.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureMonitorMetricsAlertUpdateSettings.Scopes"/>.</em></p><p>Space-separated list of scopes the rule applies to.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertUpdateSettings AddScopes(this AzureMonitorMetricsAlertUpdateSettings toolSettings, params string[] scopes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ScopesInternal.AddRange(scopes);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureMonitorMetricsAlertUpdateSettings.Scopes"/>.</em></p><p>Space-separated list of scopes the rule applies to.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertUpdateSettings AddScopes(this AzureMonitorMetricsAlertUpdateSettings toolSettings, IEnumerable<string> scopes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ScopesInternal.AddRange(scopes);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureMonitorMetricsAlertUpdateSettings.Scopes"/>.</em></p><p>Space-separated list of scopes the rule applies to.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertUpdateSettings ClearScopes(this AzureMonitorMetricsAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ScopesInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureMonitorMetricsAlertUpdateSettings.Scopes"/>.</em></p><p>Space-separated list of scopes the rule applies to.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertUpdateSettings RemoveScopes(this AzureMonitorMetricsAlertUpdateSettings toolSettings, params string[] scopes)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(scopes);
            toolSettings.ScopesInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureMonitorMetricsAlertUpdateSettings.Scopes"/>.</em></p><p>Space-separated list of scopes the rule applies to.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertUpdateSettings RemoveScopes(this AzureMonitorMetricsAlertUpdateSettings toolSettings, IEnumerable<string> scopes)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(scopes);
            toolSettings.ScopesInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Severity
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsAlertUpdateSettings.Severity"/>.</em></p><p>Severity of the alert from 0 (low) to 4 (high).</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertUpdateSettings SetSeverity(this AzureMonitorMetricsAlertUpdateSettings toolSettings, string severity)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Severity = severity;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsAlertUpdateSettings.Severity"/>.</em></p><p>Severity of the alert from 0 (low) to 4 (high).</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertUpdateSettings ResetSeverity(this AzureMonitorMetricsAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Severity = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsAlertUpdateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertUpdateSettings SetTags(this AzureMonitorMetricsAlertUpdateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsAlertUpdateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertUpdateSettings ResetTags(this AzureMonitorMetricsAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region WindowSize
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsAlertUpdateSettings.WindowSize"/>.</em></p><p>Time over which to aggregate metrics in "##h##m##s" format.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertUpdateSettings SetWindowSize(this AzureMonitorMetricsAlertUpdateSettings toolSettings, string windowSize)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WindowSize = windowSize;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsAlertUpdateSettings.WindowSize"/>.</em></p><p>Time over which to aggregate metrics in "##h##m##s" format.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertUpdateSettings ResetWindowSize(this AzureMonitorMetricsAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WindowSize = null;
            return toolSettings;
        }
        #endregion
        #region AddAction
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsAlertUpdateSettings.AddAction"/>.</em></p><p>Add an action group and optional webhook properties to fire when the alert is triggered.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertUpdateSettings SetAddAction(this AzureMonitorMetricsAlertUpdateSettings toolSettings, string addAction)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AddAction = addAction;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsAlertUpdateSettings.AddAction"/>.</em></p><p>Add an action group and optional webhook properties to fire when the alert is triggered.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertUpdateSettings ResetAddAction(this AzureMonitorMetricsAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AddAction = null;
            return toolSettings;
        }
        #endregion
        #region RemoveActions
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsAlertUpdateSettings.RemoveActions"/> to a new list.</em></p><p>Space-separated list of action group names to remove.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertUpdateSettings SetRemoveActions(this AzureMonitorMetricsAlertUpdateSettings toolSettings, params string[] removeActions)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RemoveActionsInternal = removeActions.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsAlertUpdateSettings.RemoveActions"/> to a new list.</em></p><p>Space-separated list of action group names to remove.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertUpdateSettings SetRemoveActions(this AzureMonitorMetricsAlertUpdateSettings toolSettings, IEnumerable<string> removeActions)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RemoveActionsInternal = removeActions.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureMonitorMetricsAlertUpdateSettings.RemoveActions"/>.</em></p><p>Space-separated list of action group names to remove.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertUpdateSettings AddRemoveActions(this AzureMonitorMetricsAlertUpdateSettings toolSettings, params string[] removeActions)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RemoveActionsInternal.AddRange(removeActions);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureMonitorMetricsAlertUpdateSettings.RemoveActions"/>.</em></p><p>Space-separated list of action group names to remove.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertUpdateSettings AddRemoveActions(this AzureMonitorMetricsAlertUpdateSettings toolSettings, IEnumerable<string> removeActions)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RemoveActionsInternal.AddRange(removeActions);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureMonitorMetricsAlertUpdateSettings.RemoveActions"/>.</em></p><p>Space-separated list of action group names to remove.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertUpdateSettings ClearRemoveActions(this AzureMonitorMetricsAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RemoveActionsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureMonitorMetricsAlertUpdateSettings.RemoveActions"/>.</em></p><p>Space-separated list of action group names to remove.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertUpdateSettings RemoveRemoveActions(this AzureMonitorMetricsAlertUpdateSettings toolSettings, params string[] removeActions)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(removeActions);
            toolSettings.RemoveActionsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureMonitorMetricsAlertUpdateSettings.RemoveActions"/>.</em></p><p>Space-separated list of action group names to remove.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertUpdateSettings RemoveRemoveActions(this AzureMonitorMetricsAlertUpdateSettings toolSettings, IEnumerable<string> removeActions)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(removeActions);
            toolSettings.RemoveActionsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region AddCondition
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsAlertUpdateSettings.AddCondition"/>.</em></p><p>Add a condition which triggers the rule.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertUpdateSettings SetAddCondition(this AzureMonitorMetricsAlertUpdateSettings toolSettings, string addCondition)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AddCondition = addCondition;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsAlertUpdateSettings.AddCondition"/>.</em></p><p>Add a condition which triggers the rule.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertUpdateSettings ResetAddCondition(this AzureMonitorMetricsAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AddCondition = null;
            return toolSettings;
        }
        #endregion
        #region RemoveConditions
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsAlertUpdateSettings.RemoveConditions"/> to a new list.</em></p><p>Space-separated list of condition names to remove.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertUpdateSettings SetRemoveConditions(this AzureMonitorMetricsAlertUpdateSettings toolSettings, params string[] removeConditions)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RemoveConditionsInternal = removeConditions.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsAlertUpdateSettings.RemoveConditions"/> to a new list.</em></p><p>Space-separated list of condition names to remove.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertUpdateSettings SetRemoveConditions(this AzureMonitorMetricsAlertUpdateSettings toolSettings, IEnumerable<string> removeConditions)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RemoveConditionsInternal = removeConditions.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureMonitorMetricsAlertUpdateSettings.RemoveConditions"/>.</em></p><p>Space-separated list of condition names to remove.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertUpdateSettings AddRemoveConditions(this AzureMonitorMetricsAlertUpdateSettings toolSettings, params string[] removeConditions)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RemoveConditionsInternal.AddRange(removeConditions);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureMonitorMetricsAlertUpdateSettings.RemoveConditions"/>.</em></p><p>Space-separated list of condition names to remove.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertUpdateSettings AddRemoveConditions(this AzureMonitorMetricsAlertUpdateSettings toolSettings, IEnumerable<string> removeConditions)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RemoveConditionsInternal.AddRange(removeConditions);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureMonitorMetricsAlertUpdateSettings.RemoveConditions"/>.</em></p><p>Space-separated list of condition names to remove.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertUpdateSettings ClearRemoveConditions(this AzureMonitorMetricsAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RemoveConditionsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureMonitorMetricsAlertUpdateSettings.RemoveConditions"/>.</em></p><p>Space-separated list of condition names to remove.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertUpdateSettings RemoveRemoveConditions(this AzureMonitorMetricsAlertUpdateSettings toolSettings, params string[] removeConditions)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(removeConditions);
            toolSettings.RemoveConditionsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureMonitorMetricsAlertUpdateSettings.RemoveConditions"/>.</em></p><p>Space-separated list of condition names to remove.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertUpdateSettings RemoveRemoveConditions(this AzureMonitorMetricsAlertUpdateSettings toolSettings, IEnumerable<string> removeConditions)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(removeConditions);
            toolSettings.RemoveConditionsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsAlertUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertUpdateSettings SetAdd(this AzureMonitorMetricsAlertUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsAlertUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertUpdateSettings ResetAdd(this AzureMonitorMetricsAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region ForceString
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsAlertUpdateSettings.ForceString"/>.</em></p><p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertUpdateSettings SetForceString(this AzureMonitorMetricsAlertUpdateSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsAlertUpdateSettings.ForceString"/>.</em></p><p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertUpdateSettings ResetForceString(this AzureMonitorMetricsAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsAlertUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertUpdateSettings SetRemove(this AzureMonitorMetricsAlertUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsAlertUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertUpdateSettings ResetRemove(this AzureMonitorMetricsAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsAlertUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertUpdateSettings SetSet(this AzureMonitorMetricsAlertUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsAlertUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertUpdateSettings ResetSet(this AzureMonitorMetricsAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsAlertUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertUpdateSettings SetDebug(this AzureMonitorMetricsAlertUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsAlertUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertUpdateSettings ResetDebug(this AzureMonitorMetricsAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsAlertUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertUpdateSettings SetHelp(this AzureMonitorMetricsAlertUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsAlertUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertUpdateSettings ResetHelp(this AzureMonitorMetricsAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsAlertUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertUpdateSettings SetOutput(this AzureMonitorMetricsAlertUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsAlertUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertUpdateSettings ResetOutput(this AzureMonitorMetricsAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsAlertUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertUpdateSettings SetQuery(this AzureMonitorMetricsAlertUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsAlertUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertUpdateSettings ResetQuery(this AzureMonitorMetricsAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMonitorMetricsAlertUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertUpdateSettings SetVerbose(this AzureMonitorMetricsAlertUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorMetricsAlertUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorMetricsAlertUpdateSettings ResetVerbose(this AzureMonitorMetricsAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMonitorActivityLogAlertActionGroupAddSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMonitorActivityLogAlertActionGroupAddSettingsExtensions
    {
        #region ActionGroup
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertActionGroupAddSettings.ActionGroup"/>.</em></p><p>The names or the resource ids of the action groups to be added.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertActionGroupAddSettings SetActionGroup(this AzureMonitorActivityLogAlertActionGroupAddSettings toolSettings, string actionGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ActionGroup = actionGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogAlertActionGroupAddSettings.ActionGroup"/>.</em></p><p>The names or the resource ids of the action groups to be added.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertActionGroupAddSettings ResetActionGroup(this AzureMonitorActivityLogAlertActionGroupAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ActionGroup = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertActionGroupAddSettings.Name"/>.</em></p><p>Name of the activity log alerts.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertActionGroupAddSettings SetName(this AzureMonitorActivityLogAlertActionGroupAddSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogAlertActionGroupAddSettings.Name"/>.</em></p><p>Name of the activity log alerts.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertActionGroupAddSettings ResetName(this AzureMonitorActivityLogAlertActionGroupAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertActionGroupAddSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertActionGroupAddSettings SetResourceGroup(this AzureMonitorActivityLogAlertActionGroupAddSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogAlertActionGroupAddSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertActionGroupAddSettings ResetResourceGroup(this AzureMonitorActivityLogAlertActionGroupAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Reset
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertActionGroupAddSettings.Reset"/>.</em></p><p>Remove all the existing action groups before add new conditions.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertActionGroupAddSettings SetReset(this AzureMonitorActivityLogAlertActionGroupAddSettings toolSettings, string reset)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Reset = reset;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogAlertActionGroupAddSettings.Reset"/>.</em></p><p>Remove all the existing action groups before add new conditions.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertActionGroupAddSettings ResetReset(this AzureMonitorActivityLogAlertActionGroupAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Reset = null;
            return toolSettings;
        }
        #endregion
        #region Strict
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertActionGroupAddSettings.Strict"/>.</em></p><p>Fails the command if an action group to be added will change existing webhook properties.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertActionGroupAddSettings SetStrict(this AzureMonitorActivityLogAlertActionGroupAddSettings toolSettings, string strict)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Strict = strict;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogAlertActionGroupAddSettings.Strict"/>.</em></p><p>Fails the command if an action group to be added will change existing webhook properties.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertActionGroupAddSettings ResetStrict(this AzureMonitorActivityLogAlertActionGroupAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Strict = null;
            return toolSettings;
        }
        #endregion
        #region WebhookProperties
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertActionGroupAddSettings.WebhookProperties"/> to a new list.</em></p><p>Space-separated webhook properties in 'key[=value]' format. These properties will be associated with the action groups added in this command.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertActionGroupAddSettings SetWebhookProperties(this AzureMonitorActivityLogAlertActionGroupAddSettings toolSettings, params string[] webhookProperties)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WebhookPropertiesInternal = webhookProperties.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertActionGroupAddSettings.WebhookProperties"/> to a new list.</em></p><p>Space-separated webhook properties in 'key[=value]' format. These properties will be associated with the action groups added in this command.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertActionGroupAddSettings SetWebhookProperties(this AzureMonitorActivityLogAlertActionGroupAddSettings toolSettings, IEnumerable<string> webhookProperties)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WebhookPropertiesInternal = webhookProperties.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureMonitorActivityLogAlertActionGroupAddSettings.WebhookProperties"/>.</em></p><p>Space-separated webhook properties in 'key[=value]' format. These properties will be associated with the action groups added in this command.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertActionGroupAddSettings AddWebhookProperties(this AzureMonitorActivityLogAlertActionGroupAddSettings toolSettings, params string[] webhookProperties)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WebhookPropertiesInternal.AddRange(webhookProperties);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureMonitorActivityLogAlertActionGroupAddSettings.WebhookProperties"/>.</em></p><p>Space-separated webhook properties in 'key[=value]' format. These properties will be associated with the action groups added in this command.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertActionGroupAddSettings AddWebhookProperties(this AzureMonitorActivityLogAlertActionGroupAddSettings toolSettings, IEnumerable<string> webhookProperties)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WebhookPropertiesInternal.AddRange(webhookProperties);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureMonitorActivityLogAlertActionGroupAddSettings.WebhookProperties"/>.</em></p><p>Space-separated webhook properties in 'key[=value]' format. These properties will be associated with the action groups added in this command.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertActionGroupAddSettings ClearWebhookProperties(this AzureMonitorActivityLogAlertActionGroupAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WebhookPropertiesInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureMonitorActivityLogAlertActionGroupAddSettings.WebhookProperties"/>.</em></p><p>Space-separated webhook properties in 'key[=value]' format. These properties will be associated with the action groups added in this command.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertActionGroupAddSettings RemoveWebhookProperties(this AzureMonitorActivityLogAlertActionGroupAddSettings toolSettings, params string[] webhookProperties)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(webhookProperties);
            toolSettings.WebhookPropertiesInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureMonitorActivityLogAlertActionGroupAddSettings.WebhookProperties"/>.</em></p><p>Space-separated webhook properties in 'key[=value]' format. These properties will be associated with the action groups added in this command.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertActionGroupAddSettings RemoveWebhookProperties(this AzureMonitorActivityLogAlertActionGroupAddSettings toolSettings, IEnumerable<string> webhookProperties)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(webhookProperties);
            toolSettings.WebhookPropertiesInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertActionGroupAddSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertActionGroupAddSettings SetDebug(this AzureMonitorActivityLogAlertActionGroupAddSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogAlertActionGroupAddSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertActionGroupAddSettings ResetDebug(this AzureMonitorActivityLogAlertActionGroupAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertActionGroupAddSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertActionGroupAddSettings SetHelp(this AzureMonitorActivityLogAlertActionGroupAddSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogAlertActionGroupAddSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertActionGroupAddSettings ResetHelp(this AzureMonitorActivityLogAlertActionGroupAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertActionGroupAddSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertActionGroupAddSettings SetOutput(this AzureMonitorActivityLogAlertActionGroupAddSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogAlertActionGroupAddSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertActionGroupAddSettings ResetOutput(this AzureMonitorActivityLogAlertActionGroupAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertActionGroupAddSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertActionGroupAddSettings SetQuery(this AzureMonitorActivityLogAlertActionGroupAddSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogAlertActionGroupAddSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertActionGroupAddSettings ResetQuery(this AzureMonitorActivityLogAlertActionGroupAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertActionGroupAddSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertActionGroupAddSettings SetVerbose(this AzureMonitorActivityLogAlertActionGroupAddSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogAlertActionGroupAddSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertActionGroupAddSettings ResetVerbose(this AzureMonitorActivityLogAlertActionGroupAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMonitorActivityLogAlertActionGroupRemoveSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMonitorActivityLogAlertActionGroupRemoveSettingsExtensions
    {
        #region ActionGroup
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertActionGroupRemoveSettings.ActionGroup"/>.</em></p><p>The names or the resource ids of the action groups to be added.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertActionGroupRemoveSettings SetActionGroup(this AzureMonitorActivityLogAlertActionGroupRemoveSettings toolSettings, string actionGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ActionGroup = actionGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogAlertActionGroupRemoveSettings.ActionGroup"/>.</em></p><p>The names or the resource ids of the action groups to be added.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertActionGroupRemoveSettings ResetActionGroup(this AzureMonitorActivityLogAlertActionGroupRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ActionGroup = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertActionGroupRemoveSettings.Name"/>.</em></p><p>Name of the activity log alerts.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertActionGroupRemoveSettings SetName(this AzureMonitorActivityLogAlertActionGroupRemoveSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogAlertActionGroupRemoveSettings.Name"/>.</em></p><p>Name of the activity log alerts.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertActionGroupRemoveSettings ResetName(this AzureMonitorActivityLogAlertActionGroupRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertActionGroupRemoveSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertActionGroupRemoveSettings SetResourceGroup(this AzureMonitorActivityLogAlertActionGroupRemoveSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogAlertActionGroupRemoveSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertActionGroupRemoveSettings ResetResourceGroup(this AzureMonitorActivityLogAlertActionGroupRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertActionGroupRemoveSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertActionGroupRemoveSettings SetDebug(this AzureMonitorActivityLogAlertActionGroupRemoveSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogAlertActionGroupRemoveSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertActionGroupRemoveSettings ResetDebug(this AzureMonitorActivityLogAlertActionGroupRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertActionGroupRemoveSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertActionGroupRemoveSettings SetHelp(this AzureMonitorActivityLogAlertActionGroupRemoveSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogAlertActionGroupRemoveSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertActionGroupRemoveSettings ResetHelp(this AzureMonitorActivityLogAlertActionGroupRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertActionGroupRemoveSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertActionGroupRemoveSettings SetOutput(this AzureMonitorActivityLogAlertActionGroupRemoveSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogAlertActionGroupRemoveSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertActionGroupRemoveSettings ResetOutput(this AzureMonitorActivityLogAlertActionGroupRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertActionGroupRemoveSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertActionGroupRemoveSettings SetQuery(this AzureMonitorActivityLogAlertActionGroupRemoveSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogAlertActionGroupRemoveSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertActionGroupRemoveSettings ResetQuery(this AzureMonitorActivityLogAlertActionGroupRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertActionGroupRemoveSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertActionGroupRemoveSettings SetVerbose(this AzureMonitorActivityLogAlertActionGroupRemoveSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogAlertActionGroupRemoveSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertActionGroupRemoveSettings ResetVerbose(this AzureMonitorActivityLogAlertActionGroupRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMonitorActivityLogAlertScopeAddSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMonitorActivityLogAlertScopeAddSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertScopeAddSettings.Name"/>.</em></p><p>Name of the activity log alerts.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertScopeAddSettings SetName(this AzureMonitorActivityLogAlertScopeAddSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogAlertScopeAddSettings.Name"/>.</em></p><p>Name of the activity log alerts.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertScopeAddSettings ResetName(this AzureMonitorActivityLogAlertScopeAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertScopeAddSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertScopeAddSettings SetResourceGroup(this AzureMonitorActivityLogAlertScopeAddSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogAlertScopeAddSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertScopeAddSettings ResetResourceGroup(this AzureMonitorActivityLogAlertScopeAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Scope
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertScopeAddSettings.Scope"/>.</em></p><p>The scopes to add.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertScopeAddSettings SetScope(this AzureMonitorActivityLogAlertScopeAddSettings toolSettings, string scope)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Scope = scope;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogAlertScopeAddSettings.Scope"/>.</em></p><p>The scopes to add.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertScopeAddSettings ResetScope(this AzureMonitorActivityLogAlertScopeAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Scope = null;
            return toolSettings;
        }
        #endregion
        #region Reset
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertScopeAddSettings.Reset"/>.</em></p><p>Remove all the existing scopes before add new scopes.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertScopeAddSettings SetReset(this AzureMonitorActivityLogAlertScopeAddSettings toolSettings, string reset)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Reset = reset;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogAlertScopeAddSettings.Reset"/>.</em></p><p>Remove all the existing scopes before add new scopes.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertScopeAddSettings ResetReset(this AzureMonitorActivityLogAlertScopeAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Reset = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertScopeAddSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertScopeAddSettings SetDebug(this AzureMonitorActivityLogAlertScopeAddSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogAlertScopeAddSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertScopeAddSettings ResetDebug(this AzureMonitorActivityLogAlertScopeAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertScopeAddSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertScopeAddSettings SetHelp(this AzureMonitorActivityLogAlertScopeAddSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogAlertScopeAddSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertScopeAddSettings ResetHelp(this AzureMonitorActivityLogAlertScopeAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertScopeAddSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertScopeAddSettings SetOutput(this AzureMonitorActivityLogAlertScopeAddSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogAlertScopeAddSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertScopeAddSettings ResetOutput(this AzureMonitorActivityLogAlertScopeAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertScopeAddSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertScopeAddSettings SetQuery(this AzureMonitorActivityLogAlertScopeAddSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogAlertScopeAddSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertScopeAddSettings ResetQuery(this AzureMonitorActivityLogAlertScopeAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertScopeAddSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertScopeAddSettings SetVerbose(this AzureMonitorActivityLogAlertScopeAddSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogAlertScopeAddSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertScopeAddSettings ResetVerbose(this AzureMonitorActivityLogAlertScopeAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMonitorActivityLogAlertScopeRemoveSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMonitorActivityLogAlertScopeRemoveSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertScopeRemoveSettings.Name"/>.</em></p><p>Name of the activity log alerts.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertScopeRemoveSettings SetName(this AzureMonitorActivityLogAlertScopeRemoveSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogAlertScopeRemoveSettings.Name"/>.</em></p><p>Name of the activity log alerts.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertScopeRemoveSettings ResetName(this AzureMonitorActivityLogAlertScopeRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertScopeRemoveSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertScopeRemoveSettings SetResourceGroup(this AzureMonitorActivityLogAlertScopeRemoveSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogAlertScopeRemoveSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertScopeRemoveSettings ResetResourceGroup(this AzureMonitorActivityLogAlertScopeRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Scope
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertScopeRemoveSettings.Scope"/>.</em></p><p>The scopes to remove.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertScopeRemoveSettings SetScope(this AzureMonitorActivityLogAlertScopeRemoveSettings toolSettings, string scope)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Scope = scope;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogAlertScopeRemoveSettings.Scope"/>.</em></p><p>The scopes to remove.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertScopeRemoveSettings ResetScope(this AzureMonitorActivityLogAlertScopeRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Scope = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertScopeRemoveSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertScopeRemoveSettings SetDebug(this AzureMonitorActivityLogAlertScopeRemoveSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogAlertScopeRemoveSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertScopeRemoveSettings ResetDebug(this AzureMonitorActivityLogAlertScopeRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertScopeRemoveSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertScopeRemoveSettings SetHelp(this AzureMonitorActivityLogAlertScopeRemoveSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogAlertScopeRemoveSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertScopeRemoveSettings ResetHelp(this AzureMonitorActivityLogAlertScopeRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertScopeRemoveSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertScopeRemoveSettings SetOutput(this AzureMonitorActivityLogAlertScopeRemoveSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogAlertScopeRemoveSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertScopeRemoveSettings ResetOutput(this AzureMonitorActivityLogAlertScopeRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertScopeRemoveSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertScopeRemoveSettings SetQuery(this AzureMonitorActivityLogAlertScopeRemoveSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogAlertScopeRemoveSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertScopeRemoveSettings ResetQuery(this AzureMonitorActivityLogAlertScopeRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMonitorActivityLogAlertScopeRemoveSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertScopeRemoveSettings SetVerbose(this AzureMonitorActivityLogAlertScopeRemoveSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMonitorActivityLogAlertScopeRemoveSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMonitorActivityLogAlertScopeRemoveSettings ResetVerbose(this AzureMonitorActivityLogAlertScopeRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region MonitorAlertUpdateAggregation
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class MonitorAlertUpdateAggregation : Enumeration
    {
        public static MonitorAlertUpdateAggregation avg = new MonitorAlertUpdateAggregation { Value = "avg" };
        public static MonitorAlertUpdateAggregation last = new MonitorAlertUpdateAggregation { Value = "last" };
        public static MonitorAlertUpdateAggregation max = new MonitorAlertUpdateAggregation { Value = "max" };
        public static MonitorAlertUpdateAggregation min = new MonitorAlertUpdateAggregation { Value = "min" };
        public static MonitorAlertUpdateAggregation total = new MonitorAlertUpdateAggregation { Value = "total" };
    }
    #endregion
    #region MonitorMetricsListAggregation
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class MonitorMetricsListAggregation : Enumeration
    {
        public static MonitorMetricsListAggregation average = new MonitorMetricsListAggregation { Value = "average" };
        public static MonitorMetricsListAggregation count = new MonitorMetricsListAggregation { Value = "count" };
        public static MonitorMetricsListAggregation maximum = new MonitorMetricsListAggregation { Value = "maximum" };
        public static MonitorMetricsListAggregation minimum = new MonitorMetricsListAggregation { Value = "minimum" };
        public static MonitorMetricsListAggregation total = new MonitorMetricsListAggregation { Value = "total" };
    }
    #endregion
    #region MonitorAlertUpdateOperator
    /// <summary><p>Used within <see cref="AzureMonitorTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class MonitorAlertUpdateOperator : Enumeration
    {
        public static MonitorAlertUpdateOperator SmallerThan = new MonitorAlertUpdateOperator { Value = "<" };
        public static MonitorAlertUpdateOperator SmallerThanOrEqualTo = new MonitorAlertUpdateOperator { Value = "<=" };
        public static MonitorAlertUpdateOperator GreaterThan = new MonitorAlertUpdateOperator { Value = ">" };
        public static MonitorAlertUpdateOperator GreatherThanOrEqualTo = new MonitorAlertUpdateOperator { Value = ">=" };
    }
    #endregion
}
