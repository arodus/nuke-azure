// Copyright Matthias Koch, Sebastian Karasek 2018.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

// Generated with Nuke.CodeGeneration, Version: 0.5.3 [CommitSha: 0aff3c55].
// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/AzureWebapp.json.

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
    public static partial class AzureWebappTasks
    {
        /// <summary><p>Path to the AzureWebapp executable.</p></summary>
        public static string AzureWebappPath => ToolPathResolver.GetPathExecutable("az");
        /// <summary><p>Manage web apps.</p></summary>
        public static IEnumerable<string> AzureWebapp(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool redirectOutput = false, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzureWebappPath, arguments, workingDirectory, environmentVariables, timeout, redirectOutput, outputFilter);
            process.AssertZeroExitCode();
            return process.HasOutput ? process.Output.Select(x => x.Text) : null;
        }
        static partial void PreProcess(AzureWebappBrowseSettings toolSettings);
        static partial void PostProcess(AzureWebappBrowseSettings toolSettings);
        /// <summary><p>Manage web apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/webapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureWebappBrowse(Configure<AzureWebappBrowseSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureWebappBrowseSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureWebappCreateSettings toolSettings);
        static partial void PostProcess(AzureWebappCreateSettings toolSettings);
        /// <summary><p>Manage web apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/webapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureWebappCreate(Configure<AzureWebappCreateSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureWebappCreateSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureWebappDeleteSettings toolSettings);
        static partial void PostProcess(AzureWebappDeleteSettings toolSettings);
        /// <summary><p>Manage web apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/webapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureWebappDelete(Configure<AzureWebappDeleteSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureWebappDeleteSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureWebappListSettings toolSettings);
        static partial void PostProcess(AzureWebappListSettings toolSettings);
        /// <summary><p>Manage web apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/webapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureWebappList(Configure<AzureWebappListSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureWebappListSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureWebappListRuntimesSettings toolSettings);
        static partial void PostProcess(AzureWebappListRuntimesSettings toolSettings);
        /// <summary><p>Manage web apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/webapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureWebappListRuntimes(Configure<AzureWebappListRuntimesSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureWebappListRuntimesSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureWebappRestartSettings toolSettings);
        static partial void PostProcess(AzureWebappRestartSettings toolSettings);
        /// <summary><p>Manage web apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/webapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureWebappRestart(Configure<AzureWebappRestartSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureWebappRestartSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureWebappShowSettings toolSettings);
        static partial void PostProcess(AzureWebappShowSettings toolSettings);
        /// <summary><p>Manage web apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/webapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureWebappShow(Configure<AzureWebappShowSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureWebappShowSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureWebappStartSettings toolSettings);
        static partial void PostProcess(AzureWebappStartSettings toolSettings);
        /// <summary><p>Manage web apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/webapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureWebappStart(Configure<AzureWebappStartSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureWebappStartSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureWebappStopSettings toolSettings);
        static partial void PostProcess(AzureWebappStopSettings toolSettings);
        /// <summary><p>Manage web apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/webapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureWebappStop(Configure<AzureWebappStopSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureWebappStopSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureWebappUpdateSettings toolSettings);
        static partial void PostProcess(AzureWebappUpdateSettings toolSettings);
        /// <summary><p>Manage web apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/webapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureWebappUpdate(Configure<AzureWebappUpdateSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureWebappUpdateSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureWebappAuthShowSettings toolSettings);
        static partial void PostProcess(AzureWebappAuthShowSettings toolSettings);
        /// <summary><p>Manage web apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/webapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureWebappAuthShow(Configure<AzureWebappAuthShowSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureWebappAuthShowSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureWebappAuthUpdateSettings toolSettings);
        static partial void PostProcess(AzureWebappAuthUpdateSettings toolSettings);
        /// <summary><p>Manage web apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/webapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureWebappAuthUpdate(Configure<AzureWebappAuthUpdateSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureWebappAuthUpdateSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureWebappConfigSetSettings toolSettings);
        static partial void PostProcess(AzureWebappConfigSetSettings toolSettings);
        /// <summary><p>Manage web apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/webapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureWebappConfigSet(Configure<AzureWebappConfigSetSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureWebappConfigSetSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureWebappConfigShowSettings toolSettings);
        static partial void PostProcess(AzureWebappConfigShowSettings toolSettings);
        /// <summary><p>Manage web apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/webapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureWebappConfigShow(Configure<AzureWebappConfigShowSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureWebappConfigShowSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureWebappDeploymentListPublishingProfilesSettings toolSettings);
        static partial void PostProcess(AzureWebappDeploymentListPublishingProfilesSettings toolSettings);
        /// <summary><p>Manage web apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/webapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureWebappDeploymentListPublishingProfiles(Configure<AzureWebappDeploymentListPublishingProfilesSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureWebappDeploymentListPublishingProfilesSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureWebappIdentityAssignSettings toolSettings);
        static partial void PostProcess(AzureWebappIdentityAssignSettings toolSettings);
        /// <summary><p>Manage web apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/webapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureWebappIdentityAssign(Configure<AzureWebappIdentityAssignSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureWebappIdentityAssignSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureWebappIdentityShowSettings toolSettings);
        static partial void PostProcess(AzureWebappIdentityShowSettings toolSettings);
        /// <summary><p>Manage web apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/webapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureWebappIdentityShow(Configure<AzureWebappIdentityShowSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureWebappIdentityShowSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureWebappLogConfigSettings toolSettings);
        static partial void PostProcess(AzureWebappLogConfigSettings toolSettings);
        /// <summary><p>Manage web apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/webapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureWebappLogConfig(Configure<AzureWebappLogConfigSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureWebappLogConfigSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureWebappLogDownloadSettings toolSettings);
        static partial void PostProcess(AzureWebappLogDownloadSettings toolSettings);
        /// <summary><p>Manage web apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/webapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureWebappLogDownload(Configure<AzureWebappLogDownloadSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureWebappLogDownloadSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureWebappLogShowSettings toolSettings);
        static partial void PostProcess(AzureWebappLogShowSettings toolSettings);
        /// <summary><p>Manage web apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/webapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureWebappLogShow(Configure<AzureWebappLogShowSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureWebappLogShowSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureWebappLogTailSettings toolSettings);
        static partial void PostProcess(AzureWebappLogTailSettings toolSettings);
        /// <summary><p>Manage web apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/webapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureWebappLogTail(Configure<AzureWebappLogTailSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureWebappLogTailSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureWebappTrafficRoutingClearSettings toolSettings);
        static partial void PostProcess(AzureWebappTrafficRoutingClearSettings toolSettings);
        /// <summary><p>Manage web apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/webapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureWebappTrafficRoutingClear(Configure<AzureWebappTrafficRoutingClearSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureWebappTrafficRoutingClearSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureWebappTrafficRoutingSetSettings toolSettings);
        static partial void PostProcess(AzureWebappTrafficRoutingSetSettings toolSettings);
        /// <summary><p>Manage web apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/webapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureWebappTrafficRoutingSet(Configure<AzureWebappTrafficRoutingSetSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureWebappTrafficRoutingSetSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureWebappTrafficRoutingShowSettings toolSettings);
        static partial void PostProcess(AzureWebappTrafficRoutingShowSettings toolSettings);
        /// <summary><p>Manage web apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/webapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureWebappTrafficRoutingShow(Configure<AzureWebappTrafficRoutingShowSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureWebappTrafficRoutingShowSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureWebappConfigAppsettingsDeleteSettings toolSettings);
        static partial void PostProcess(AzureWebappConfigAppsettingsDeleteSettings toolSettings);
        /// <summary><p>Manage web apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/webapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureWebappConfigAppsettingsDelete(Configure<AzureWebappConfigAppsettingsDeleteSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureWebappConfigAppsettingsDeleteSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureWebappConfigAppsettingsListSettings toolSettings);
        static partial void PostProcess(AzureWebappConfigAppsettingsListSettings toolSettings);
        /// <summary><p>Manage web apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/webapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureWebappConfigAppsettingsList(Configure<AzureWebappConfigAppsettingsListSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureWebappConfigAppsettingsListSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureWebappConfigAppsettingsSetSettings toolSettings);
        static partial void PostProcess(AzureWebappConfigAppsettingsSetSettings toolSettings);
        /// <summary><p>Manage web apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/webapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureWebappConfigAppsettingsSet(Configure<AzureWebappConfigAppsettingsSetSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureWebappConfigAppsettingsSetSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureWebappConfigBackupCreateSettings toolSettings);
        static partial void PostProcess(AzureWebappConfigBackupCreateSettings toolSettings);
        /// <summary><p>Manage web apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/webapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureWebappConfigBackupCreate(Configure<AzureWebappConfigBackupCreateSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureWebappConfigBackupCreateSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureWebappConfigBackupListSettings toolSettings);
        static partial void PostProcess(AzureWebappConfigBackupListSettings toolSettings);
        /// <summary><p>Manage web apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/webapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureWebappConfigBackupList(Configure<AzureWebappConfigBackupListSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureWebappConfigBackupListSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureWebappConfigBackupRestoreSettings toolSettings);
        static partial void PostProcess(AzureWebappConfigBackupRestoreSettings toolSettings);
        /// <summary><p>Manage web apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/webapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureWebappConfigBackupRestore(Configure<AzureWebappConfigBackupRestoreSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureWebappConfigBackupRestoreSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureWebappConfigBackupShowSettings toolSettings);
        static partial void PostProcess(AzureWebappConfigBackupShowSettings toolSettings);
        /// <summary><p>Manage web apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/webapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureWebappConfigBackupShow(Configure<AzureWebappConfigBackupShowSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureWebappConfigBackupShowSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureWebappConfigBackupUpdateSettings toolSettings);
        static partial void PostProcess(AzureWebappConfigBackupUpdateSettings toolSettings);
        /// <summary><p>Manage web apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/webapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureWebappConfigBackupUpdate(Configure<AzureWebappConfigBackupUpdateSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureWebappConfigBackupUpdateSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureWebappConfigConnectionStringDeleteSettings toolSettings);
        static partial void PostProcess(AzureWebappConfigConnectionStringDeleteSettings toolSettings);
        /// <summary><p>Manage web apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/webapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureWebappConfigConnectionStringDelete(Configure<AzureWebappConfigConnectionStringDeleteSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureWebappConfigConnectionStringDeleteSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureWebappConfigConnectionStringListSettings toolSettings);
        static partial void PostProcess(AzureWebappConfigConnectionStringListSettings toolSettings);
        /// <summary><p>Manage web apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/webapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureWebappConfigConnectionStringList(Configure<AzureWebappConfigConnectionStringListSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureWebappConfigConnectionStringListSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureWebappConfigConnectionStringSetSettings toolSettings);
        static partial void PostProcess(AzureWebappConfigConnectionStringSetSettings toolSettings);
        /// <summary><p>Manage web apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/webapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureWebappConfigConnectionStringSet(Configure<AzureWebappConfigConnectionStringSetSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureWebappConfigConnectionStringSetSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureWebappConfigContainerDeleteSettings toolSettings);
        static partial void PostProcess(AzureWebappConfigContainerDeleteSettings toolSettings);
        /// <summary><p>Manage web apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/webapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureWebappConfigContainerDelete(Configure<AzureWebappConfigContainerDeleteSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureWebappConfigContainerDeleteSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureWebappConfigContainerSetSettings toolSettings);
        static partial void PostProcess(AzureWebappConfigContainerSetSettings toolSettings);
        /// <summary><p>Manage web apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/webapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureWebappConfigContainerSet(Configure<AzureWebappConfigContainerSetSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureWebappConfigContainerSetSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureWebappConfigContainerShowSettings toolSettings);
        static partial void PostProcess(AzureWebappConfigContainerShowSettings toolSettings);
        /// <summary><p>Manage web apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/webapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureWebappConfigContainerShow(Configure<AzureWebappConfigContainerShowSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureWebappConfigContainerShowSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureWebappConfigHostnameAddSettings toolSettings);
        static partial void PostProcess(AzureWebappConfigHostnameAddSettings toolSettings);
        /// <summary><p>Manage web apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/webapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureWebappConfigHostnameAdd(Configure<AzureWebappConfigHostnameAddSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureWebappConfigHostnameAddSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureWebappConfigHostnameDeleteSettings toolSettings);
        static partial void PostProcess(AzureWebappConfigHostnameDeleteSettings toolSettings);
        /// <summary><p>Manage web apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/webapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureWebappConfigHostnameDelete(Configure<AzureWebappConfigHostnameDeleteSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureWebappConfigHostnameDeleteSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureWebappConfigHostnameGetExternalIpSettings toolSettings);
        static partial void PostProcess(AzureWebappConfigHostnameGetExternalIpSettings toolSettings);
        /// <summary><p>Manage web apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/webapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureWebappConfigHostnameGetExternalIp(Configure<AzureWebappConfigHostnameGetExternalIpSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureWebappConfigHostnameGetExternalIpSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureWebappConfigHostnameListSettings toolSettings);
        static partial void PostProcess(AzureWebappConfigHostnameListSettings toolSettings);
        /// <summary><p>Manage web apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/webapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureWebappConfigHostnameList(Configure<AzureWebappConfigHostnameListSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureWebappConfigHostnameListSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureWebappConfigSslBindSettings toolSettings);
        static partial void PostProcess(AzureWebappConfigSslBindSettings toolSettings);
        /// <summary><p>Manage web apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/webapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureWebappConfigSslBind(Configure<AzureWebappConfigSslBindSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureWebappConfigSslBindSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureWebappConfigSslDeleteSettings toolSettings);
        static partial void PostProcess(AzureWebappConfigSslDeleteSettings toolSettings);
        /// <summary><p>Manage web apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/webapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureWebappConfigSslDelete(Configure<AzureWebappConfigSslDeleteSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureWebappConfigSslDeleteSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureWebappConfigSslListSettings toolSettings);
        static partial void PostProcess(AzureWebappConfigSslListSettings toolSettings);
        /// <summary><p>Manage web apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/webapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureWebappConfigSslList(Configure<AzureWebappConfigSslListSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureWebappConfigSslListSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureWebappConfigSslUnbindSettings toolSettings);
        static partial void PostProcess(AzureWebappConfigSslUnbindSettings toolSettings);
        /// <summary><p>Manage web apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/webapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureWebappConfigSslUnbind(Configure<AzureWebappConfigSslUnbindSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureWebappConfigSslUnbindSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureWebappConfigSslUploadSettings toolSettings);
        static partial void PostProcess(AzureWebappConfigSslUploadSettings toolSettings);
        /// <summary><p>Manage web apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/webapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureWebappConfigSslUpload(Configure<AzureWebappConfigSslUploadSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureWebappConfigSslUploadSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureWebappDeploymentContainerConfigSettings toolSettings);
        static partial void PostProcess(AzureWebappDeploymentContainerConfigSettings toolSettings);
        /// <summary><p>Manage web apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/webapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureWebappDeploymentContainerConfig(Configure<AzureWebappDeploymentContainerConfigSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureWebappDeploymentContainerConfigSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureWebappDeploymentContainerShowCdUrlSettings toolSettings);
        static partial void PostProcess(AzureWebappDeploymentContainerShowCdUrlSettings toolSettings);
        /// <summary><p>Manage web apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/webapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureWebappDeploymentContainerShowCdUrl(Configure<AzureWebappDeploymentContainerShowCdUrlSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureWebappDeploymentContainerShowCdUrlSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureWebappDeploymentSlotAutoSwapSettings toolSettings);
        static partial void PostProcess(AzureWebappDeploymentSlotAutoSwapSettings toolSettings);
        /// <summary><p>Manage web apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/webapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureWebappDeploymentSlotAutoSwap(Configure<AzureWebappDeploymentSlotAutoSwapSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureWebappDeploymentSlotAutoSwapSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureWebappDeploymentSlotCreateSettings toolSettings);
        static partial void PostProcess(AzureWebappDeploymentSlotCreateSettings toolSettings);
        /// <summary><p>Manage web apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/webapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureWebappDeploymentSlotCreate(Configure<AzureWebappDeploymentSlotCreateSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureWebappDeploymentSlotCreateSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureWebappDeploymentSlotDeleteSettings toolSettings);
        static partial void PostProcess(AzureWebappDeploymentSlotDeleteSettings toolSettings);
        /// <summary><p>Manage web apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/webapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureWebappDeploymentSlotDelete(Configure<AzureWebappDeploymentSlotDeleteSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureWebappDeploymentSlotDeleteSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureWebappDeploymentSlotListSettings toolSettings);
        static partial void PostProcess(AzureWebappDeploymentSlotListSettings toolSettings);
        /// <summary><p>Manage web apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/webapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureWebappDeploymentSlotList(Configure<AzureWebappDeploymentSlotListSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureWebappDeploymentSlotListSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureWebappDeploymentSlotSwapSettings toolSettings);
        static partial void PostProcess(AzureWebappDeploymentSlotSwapSettings toolSettings);
        /// <summary><p>Manage web apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/webapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureWebappDeploymentSlotSwap(Configure<AzureWebappDeploymentSlotSwapSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureWebappDeploymentSlotSwapSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureWebappDeploymentSourceConfigSettings toolSettings);
        static partial void PostProcess(AzureWebappDeploymentSourceConfigSettings toolSettings);
        /// <summary><p>Manage web apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/webapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureWebappDeploymentSourceConfig(Configure<AzureWebappDeploymentSourceConfigSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureWebappDeploymentSourceConfigSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureWebappDeploymentSourceConfigLocalGitSettings toolSettings);
        static partial void PostProcess(AzureWebappDeploymentSourceConfigLocalGitSettings toolSettings);
        /// <summary><p>Manage web apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/webapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureWebappDeploymentSourceConfigLocalGit(Configure<AzureWebappDeploymentSourceConfigLocalGitSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureWebappDeploymentSourceConfigLocalGitSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureWebappDeploymentSourceConfigZipSettings toolSettings);
        static partial void PostProcess(AzureWebappDeploymentSourceConfigZipSettings toolSettings);
        /// <summary><p>Manage web apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/webapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureWebappDeploymentSourceConfigZip(Configure<AzureWebappDeploymentSourceConfigZipSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureWebappDeploymentSourceConfigZipSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureWebappDeploymentSourceDeleteSettings toolSettings);
        static partial void PostProcess(AzureWebappDeploymentSourceDeleteSettings toolSettings);
        /// <summary><p>Manage web apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/webapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureWebappDeploymentSourceDelete(Configure<AzureWebappDeploymentSourceDeleteSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureWebappDeploymentSourceDeleteSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureWebappDeploymentSourceShowSettings toolSettings);
        static partial void PostProcess(AzureWebappDeploymentSourceShowSettings toolSettings);
        /// <summary><p>Manage web apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/webapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureWebappDeploymentSourceShow(Configure<AzureWebappDeploymentSourceShowSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureWebappDeploymentSourceShowSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureWebappDeploymentSourceSyncSettings toolSettings);
        static partial void PostProcess(AzureWebappDeploymentSourceSyncSettings toolSettings);
        /// <summary><p>Manage web apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/webapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureWebappDeploymentSourceSync(Configure<AzureWebappDeploymentSourceSyncSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureWebappDeploymentSourceSyncSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureWebappDeploymentSourceUpdateTokenSettings toolSettings);
        static partial void PostProcess(AzureWebappDeploymentSourceUpdateTokenSettings toolSettings);
        /// <summary><p>Manage web apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/webapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureWebappDeploymentSourceUpdateToken(Configure<AzureWebappDeploymentSourceUpdateTokenSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureWebappDeploymentSourceUpdateTokenSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureWebappDeploymentUserSetSettings toolSettings);
        static partial void PostProcess(AzureWebappDeploymentUserSetSettings toolSettings);
        /// <summary><p>Manage web apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/webapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureWebappDeploymentUserSet(Configure<AzureWebappDeploymentUserSetSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureWebappDeploymentUserSetSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureWebappDeploymentUserShowSettings toolSettings);
        static partial void PostProcess(AzureWebappDeploymentUserShowSettings toolSettings);
        /// <summary><p>Manage web apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/webapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureWebappDeploymentUserShow(Configure<AzureWebappDeploymentUserShowSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureWebappDeploymentUserShowSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
    }
    #region AzureWebappBrowseSettings
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureWebappBrowseSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureWebapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureWebappTasks.AzureWebappPath;
        /// <summary><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Enable viewing the log stream immediately after launching the web app.</p></summary>
        public virtual string Logs { get; internal set; }
        /// <summary><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        public virtual string Slot { get; internal set; }
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
              .Add("webapp browse")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--logs {value}", Logs)
              .Add("--slot {value}", Slot)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureWebappCreateSettings
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureWebappCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureWebapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureWebappTasks.AzureWebappPath;
        /// <summary><p>Name of the new webapp.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name or resource id of the app service plan. Use 'appservice plan create' to get one.</p></summary>
        public virtual string Plan { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Linux only. Container image name from Docker Hub, e.g. publisher/image-name:tag.</p></summary>
        public virtual string DeploymentContainerImageName { get; internal set; }
        /// <summary><p>Enable local git.</p></summary>
        public virtual string DeploymentLocalGit { get; internal set; }
        /// <summary><p>The branch to deploy.</p></summary>
        public virtual string DeploymentSourceBranch { get; internal set; }
        /// <summary><p>Git repository URL to link with manual integration.</p></summary>
        public virtual string DeploymentSourceUrl { get; internal set; }
        /// <summary><p>Linux only. Config file for multicontainer apps. (local or remote).</p></summary>
        public virtual string MulticontainerConfigFile { get; internal set; }
        /// <summary><p>Linux only.</p></summary>
        public virtual WebappMulticontainerConfigType MulticontainerConfigType { get; internal set; }
        /// <summary><p>Canonicalized web runtime in the format of Framework|Version, e.g. "PHP|5.6". Use 'az webapp list-runtimes' for available list.</p></summary>
        public virtual string Runtime { get; internal set; }
        /// <summary><p>Linux only. The web's startup file.</p></summary>
        public virtual string StartupFile { get; internal set; }
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
              .Add("webapp create")
              .Add("--name {value}", Name)
              .Add("--plan {value}", Plan)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--deployment-container-image-name {value}", DeploymentContainerImageName)
              .Add("--deployment-local-git {value}", DeploymentLocalGit)
              .Add("--deployment-source-branch {value}", DeploymentSourceBranch)
              .Add("--deployment-source-url {value}", DeploymentSourceUrl)
              .Add("--multicontainer-config-file {value}", MulticontainerConfigFile)
              .Add("--multicontainer-config-type {value}", MulticontainerConfigType)
              .Add("--runtime {value}", Runtime)
              .Add("--startup-file {value}", StartupFile)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureWebappDeleteSettings
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureWebappDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureWebapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureWebappTasks.AzureWebappPath;
        /// <summary><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Keep DNS registration.</p></summary>
        public virtual string KeepDnsRegistration { get; internal set; }
        /// <summary><p>Keep empty app service plan.</p></summary>
        public virtual string KeepEmptyPlan { get; internal set; }
        /// <summary><p>Keep app metrics.</p></summary>
        public virtual string KeepMetrics { get; internal set; }
        /// <summary><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        public virtual string Slot { get; internal set; }
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
              .Add("webapp delete")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--keep-dns-registration {value}", KeepDnsRegistration)
              .Add("--keep-empty-plan {value}", KeepEmptyPlan)
              .Add("--keep-metrics {value}", KeepMetrics)
              .Add("--slot {value}", Slot)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureWebappListSettings
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureWebappListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureWebapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureWebappTasks.AzureWebappPath;
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
              .Add("webapp list")
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
    #region AzureWebappListRuntimesSettings
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureWebappListRuntimesSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureWebapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureWebappTasks.AzureWebappPath;
        /// <summary><p>List runtime stacks for linux based webapps.</p></summary>
        public virtual string Linux { get; internal set; }
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
              .Add("webapp list-runtimes")
              .Add("--linux {value}", Linux)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureWebappRestartSettings
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureWebappRestartSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureWebapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureWebappTasks.AzureWebappPath;
        /// <summary><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        public virtual string Slot { get; internal set; }
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
              .Add("webapp restart")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--slot {value}", Slot)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureWebappShowSettings
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureWebappShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureWebapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureWebappTasks.AzureWebappPath;
        /// <summary><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        public virtual string Slot { get; internal set; }
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
              .Add("webapp show")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--slot {value}", Slot)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureWebappStartSettings
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureWebappStartSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureWebapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureWebappTasks.AzureWebappPath;
        /// <summary><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        public virtual string Slot { get; internal set; }
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
              .Add("webapp start")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--slot {value}", Slot)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureWebappStopSettings
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureWebappStopSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureWebapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureWebappTasks.AzureWebappPath;
        /// <summary><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        public virtual string Slot { get; internal set; }
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
              .Add("webapp stop")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--slot {value}", Slot)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureWebappUpdateSettings
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureWebappUpdateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureWebapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureWebappTasks.AzureWebappPath;
        /// <summary><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Enables sending session affinity cookies.</p></summary>
        public virtual bool? ClientAffinityEnabled { get; internal set; }
        /// <summary><p>If true, web app hostname is force registered with DNS.</p></summary>
        public virtual bool? ForceDnsRegistration { get; internal set; }
        /// <summary><p>Redirect all traffic made to an app using HTTP to HTTPS.</p></summary>
        public virtual bool? HttpsOnly { get; internal set; }
        /// <summary><p>If true, custom (non *.azurewebsites.net) domains associated with web app are not verified.</p></summary>
        public virtual bool? SkipCustomDomainVerification { get; internal set; }
        /// <summary><p>If true web app hostname is not registered with DNS on creation.</p></summary>
        public virtual bool? SkipDnsRegistration { get; internal set; }
        /// <summary><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        public virtual string Slot { get; internal set; }
        /// <summary><p>Time to live in seconds for web app's default domain name.</p></summary>
        public virtual bool? TtlInSeconds { get; internal set; }
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
              .Add("webapp update")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--client-affinity-enabled", ClientAffinityEnabled)
              .Add("--force-dns-registration", ForceDnsRegistration)
              .Add("--https-only", HttpsOnly)
              .Add("--skip-custom-domain-verification", SkipCustomDomainVerification)
              .Add("--skip-dns-registration", SkipDnsRegistration)
              .Add("--slot {value}", Slot)
              .Add("--ttl-in-seconds", TtlInSeconds)
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
    #region AzureWebappAuthShowSettings
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureWebappAuthShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureWebapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureWebappTasks.AzureWebappPath;
        /// <summary><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        public virtual string Slot { get; internal set; }
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
              .Add("webapp auth show")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--slot {value}", Slot)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureWebappAuthUpdateSettings
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureWebappAuthUpdateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureWebapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureWebappTasks.AzureWebappPath;
        /// <summary><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p></p></summary>
        public virtual WebappAuthUpdateAction Action { get; internal set; }
        /// <summary><p>One or more urls (space-delimited).</p></summary>
        public virtual string AllowedExternalRedirectUrls { get; internal set; }
        /// <summary><p></p></summary>
        public virtual bool? Enabled { get; internal set; }
        /// <summary><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        public virtual string Slot { get; internal set; }
        /// <summary><p>Hours, must be formattable into a float.</p></summary>
        public virtual string TokenRefreshExtensionHours { get; internal set; }
        /// <summary><p>Use App Service Token Store.</p></summary>
        public virtual bool? TokenStore { get; internal set; }
        /// <summary><p>One or more token audiences (space-delimited).</p></summary>
        public virtual string AadAllowedTokenAudiences { get; internal set; }
        /// <summary><p>Application ID to integrate AAD organization account Sign-in into your web app.</p></summary>
        public virtual string AadClientId { get; internal set; }
        /// <summary><p>AAD application secret.</p></summary>
        public virtual string AadClientSecret { get; internal set; }
        /// <summary><p>This url can be found in the JSON output returned from your active directory endpoint using your tenantID. The endpoint can be queried from 'az cloud show' at "endpoints.activeDirectory". The tenantID can be found using 'az account show'. Get the "issuer" from the JSON at &lt;active directory endpoint&gt;/&lt;tenantId&gt;/.well-known/openid-configuration.</p></summary>
        public virtual string AadTokenIssuerUrl { get; internal set; }
        /// <summary><p>Application ID to integrate Facebook Sign-in into your web app.</p></summary>
        public virtual string FacebookAppId { get; internal set; }
        /// <summary><p>Facebook Application client secret.</p></summary>
        public virtual string FacebookAppSecret { get; internal set; }
        /// <summary><p>One or more facebook authentication scopes (space-delimited).</p></summary>
        public virtual string FacebookOauthScopes { get; internal set; }
        /// <summary><p>Application ID to integrate Google Sign-in into your web app.</p></summary>
        public virtual string GoogleClientId { get; internal set; }
        /// <summary><p>Google Application client secret.</p></summary>
        public virtual string GoogleClientSecret { get; internal set; }
        /// <summary><p>One or more Google authentication scopes (space-delimited).</p></summary>
        public virtual string GoogleOauthScopes { get; internal set; }
        /// <summary><p>AAD V2 Application ID to integrate Microsoft account Sign-in into your web app.</p></summary>
        public virtual string MicrosoftAccountClientId { get; internal set; }
        /// <summary><p>AAD V2 Application client secret.</p></summary>
        public virtual string MicrosoftAccountClientSecret { get; internal set; }
        /// <summary><p>One or more Microsoft authentification scopes (space-delimited).</p></summary>
        public virtual string MicrosoftAccountOauthScopes { get; internal set; }
        /// <summary><p>Application ID to integrate Twitter Sign-in into your web app.</p></summary>
        public virtual string TwitterConsumerKey { get; internal set; }
        /// <summary><p>Twitter Application client secret.</p></summary>
        public virtual string TwitterConsumerSecret { get; internal set; }
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
              .Add("webapp auth update")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--action {value}", Action)
              .Add("--allowed-external-redirect-urls {value}", AllowedExternalRedirectUrls)
              .Add("--enabled", Enabled)
              .Add("--slot {value}", Slot)
              .Add("--token-refresh-extension-hours {value}", TokenRefreshExtensionHours)
              .Add("--token-store", TokenStore)
              .Add("--aad-allowed-token-audiences {value}", AadAllowedTokenAudiences)
              .Add("--aad-client-id {value}", AadClientId)
              .Add("--aad-client-secret {value}", AadClientSecret, secret: true)
              .Add("--aad-token-issuer-url {value}", AadTokenIssuerUrl)
              .Add("--facebook-app-id {value}", FacebookAppId)
              .Add("--facebook-app-secret {value}", FacebookAppSecret, secret: true)
              .Add("--facebook-oauth-scopes {value}", FacebookOauthScopes)
              .Add("--google-client-id {value}", GoogleClientId)
              .Add("--google-client-secret {value}", GoogleClientSecret, secret: true)
              .Add("--google-oauth-scopes {value}", GoogleOauthScopes)
              .Add("--microsoft-account-client-id {value}", MicrosoftAccountClientId)
              .Add("--microsoft-account-client-secret {value}", MicrosoftAccountClientSecret, secret: true)
              .Add("--microsoft-account-oauth-scopes {value}", MicrosoftAccountOauthScopes)
              .Add("--twitter-consumer-key {value}", TwitterConsumerKey)
              .Add("--twitter-consumer-secret {value}", TwitterConsumerSecret, secret: true)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureWebappConfigSetSettings
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureWebappConfigSetSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureWebapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureWebappTasks.AzureWebappPath;
        /// <summary><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Ensure webapp gets loaded all the time, rather unloaded after been idle. Recommended when you have continuous web jobs running.</p></summary>
        public virtual bool? AlwaysOn { get; internal set; }
        /// <summary><p>Enable or disable auto heal.</p></summary>
        public virtual bool? AutoHealEnabled { get; internal set; }
        /// <summary><p>Configures a web site to allow clients to connect over http2.0.</p></summary>
        public virtual bool? Http20Enabled { get; internal set; }
        /// <summary><p>The java container, e.g., Tomcat, Jetty.</p></summary>
        public virtual string JavaContainer { get; internal set; }
        /// <summary><p>The version of the java container, e.g., '8.0.23' for Tomcat.</p></summary>
        public virtual string JavaContainerVersion { get; internal set; }
        /// <summary><p>The version used to run your web app if using Java, e.g., '1.7' for Java 7, '1.8' for Java 8.</p></summary>
        public virtual string JavaVersion { get; internal set; }
        /// <summary><p>The runtime stack used for your linux-based webapp, e.g., "RUBY|2.3", "NODE|6.6", "PHP|5.6", "DOTNETCORE|1.1.0". See &lt;a href="https://aka.ms/linux-stacks"&gt;https://aka.ms/linux-stacks&lt;/a&gt; for more info.</p></summary>
        public virtual string LinuxFxVersion { get; internal set; }
        /// <summary><p>The minimum version of TLS required for SSL requests, e.g., '1.0', '1.1', '1.2'.</p></summary>
        public virtual string MinTlsVersion { get; internal set; }
        /// <summary><p>The version used to run your web app if using .NET Framework, e.g., 'v4.0' for .NET 4.6 and 'v3.0' for .NET 3.5.</p></summary>
        public virtual string NetFrameworkVersion { get; internal set; }
        /// <summary><p>The version used to run your web app if using PHP, e.g., 5.5, 5.6, 7.0.</p></summary>
        public virtual string PhpVersion { get; internal set; }
        /// <summary><p>The version used to run your web app if using Python, e.g., 2.7, 3.4.</p></summary>
        public virtual string PythonVersion { get; internal set; }
        /// <summary><p>Enable or disable remote debugging.</p></summary>
        public virtual bool? RemoteDebuggingEnabled { get; internal set; }
        /// <summary><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        public virtual string Slot { get; internal set; }
        /// <summary><p>The startup file for linux hosted web apps, e.g. 'process.json' for Node.js web.</p></summary>
        public virtual string StartupFile { get; internal set; }
        /// <summary><p>Use 32 bits worker process or not.</p></summary>
        public virtual bool? Use32bitWorkerProcess { get; internal set; }
        /// <summary><p>Enable or disable web sockets.</p></summary>
        public virtual bool? WebSocketsEnabled { get; internal set; }
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
              .Add("webapp config set")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--always-on", AlwaysOn)
              .Add("--auto-heal-enabled", AutoHealEnabled)
              .Add("--http20-enabled", Http20Enabled)
              .Add("--java-container {value}", JavaContainer)
              .Add("--java-container-version {value}", JavaContainerVersion)
              .Add("--java-version {value}", JavaVersion)
              .Add("--linux-fx-version {value}", LinuxFxVersion)
              .Add("--min-tls-version {value}", MinTlsVersion)
              .Add("--net-framework-version {value}", NetFrameworkVersion)
              .Add("--php-version {value}", PhpVersion)
              .Add("--python-version {value}", PythonVersion)
              .Add("--remote-debugging-enabled", RemoteDebuggingEnabled)
              .Add("--slot {value}", Slot)
              .Add("--startup-file {value}", StartupFile)
              .Add("--use-32bit-worker-process", Use32bitWorkerProcess)
              .Add("--web-sockets-enabled", WebSocketsEnabled)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureWebappConfigShowSettings
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureWebappConfigShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureWebapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureWebappTasks.AzureWebappPath;
        /// <summary><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        public virtual string Slot { get; internal set; }
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
              .Add("webapp config show")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--slot {value}", Slot)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureWebappDeploymentListPublishingProfilesSettings
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureWebappDeploymentListPublishingProfilesSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureWebapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureWebappTasks.AzureWebappPath;
        /// <summary><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        public virtual string Slot { get; internal set; }
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
              .Add("webapp deployment list-publishing-profiles")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--slot {value}", Slot)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureWebappIdentityAssignSettings
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureWebappIdentityAssignSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureWebapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureWebappTasks.AzureWebappPath;
        /// <summary><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Disable the identity.</p></summary>
        public virtual string DisableMsi { get; internal set; }
        /// <summary><p>Role name or id the managed identity will be assigned.</p></summary>
        public virtual string Role { get; internal set; }
        /// <summary><p>The scope the managed identity has access to.</p></summary>
        public virtual string Scope { get; internal set; }
        /// <summary><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        public virtual string Slot { get; internal set; }
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
              .Add("webapp identity assign")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--disable-msi {value}", DisableMsi)
              .Add("--role {value}", Role)
              .Add("--scope {value}", Scope)
              .Add("--slot {value}", Slot)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureWebappIdentityShowSettings
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureWebappIdentityShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureWebapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureWebappTasks.AzureWebappPath;
        /// <summary><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        public virtual string Slot { get; internal set; }
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
              .Add("webapp identity show")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--slot {value}", Slot)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureWebappLogConfigSettings
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureWebappLogConfigSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureWebapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureWebappTasks.AzureWebappPath;
        /// <summary><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Configure application logging to file system.</p></summary>
        public virtual bool? ApplicationLogging { get; internal set; }
        /// <summary><p>Configure detailed error messages.</p></summary>
        public virtual bool? DetailedErrorMessages { get; internal set; }
        /// <summary><p>Configure gathering STDOUT and STDERR output from container.</p></summary>
        public virtual WebappLogConfigDockerContainerLogging DockerContainerLogging { get; internal set; }
        /// <summary><p>Configure failed request tracing.</p></summary>
        public virtual bool? FailedRequestTracing { get; internal set; }
        /// <summary><p>Logging level.</p></summary>
        public virtual WebappLogConfigLevel Level { get; internal set; }
        /// <summary><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        public virtual string Slot { get; internal set; }
        /// <summary><p>Configure Web server logging.</p></summary>
        public virtual WebappLogConfigDockerContainerLogging WebServerLogging { get; internal set; }
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
              .Add("webapp log config")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--application-logging", ApplicationLogging)
              .Add("--detailed-error-messages", DetailedErrorMessages)
              .Add("--docker-container-logging {value}", DockerContainerLogging)
              .Add("--failed-request-tracing", FailedRequestTracing)
              .Add("--level {value}", Level)
              .Add("--slot {value}", Slot)
              .Add("--web-server-logging {value}", WebServerLogging)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureWebappLogDownloadSettings
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureWebappLogDownloadSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureWebapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureWebappTasks.AzureWebappPath;
        /// <summary><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The downloaded zipped log file path.</p></summary>
        public virtual string LogFile { get; internal set; }
        /// <summary><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        public virtual string Slot { get; internal set; }
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
              .Add("webapp log download")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--log-file {value}", LogFile)
              .Add("--slot {value}", Slot)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureWebappLogShowSettings
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureWebappLogShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureWebapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureWebappTasks.AzureWebappPath;
        /// <summary><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        public virtual string Slot { get; internal set; }
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
              .Add("webapp log show")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--slot {value}", Slot)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureWebappLogTailSettings
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureWebappLogTailSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureWebapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureWebappTasks.AzureWebappPath;
        /// <summary><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>By default all live traces configured by 'az webapp log config' will be shown, but you can scope to certain providers/folders, e.g. 'application', 'http', etc. For details, check out &lt;a href="https://github.com/projectkudu/kudu/wiki/Diagnostic-Log-Stream"&gt;https://github.com/projectkudu/kudu/wiki/Diagnostic-Log-Stream&lt;/a&gt;.</p></summary>
        public virtual string Provider { get; internal set; }
        /// <summary><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        public virtual string Slot { get; internal set; }
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
              .Add("webapp log tail")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--provider {value}", Provider)
              .Add("--slot {value}", Slot)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureWebappTrafficRoutingClearSettings
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureWebappTrafficRoutingClearSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureWebapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureWebappTasks.AzureWebappPath;
        /// <summary><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
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
              .Add("webapp traffic-routing clear")
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
    #region AzureWebappTrafficRoutingSetSettings
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureWebappTrafficRoutingSetSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureWebapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureWebappTasks.AzureWebappPath;
        /// <summary><p>Space-separated slot routings in a format of &lt;slot-name&gt;=&lt;percentage&gt; e.g. staging=50. Unused traffic percentage will go to the Production slot.</p></summary>
        public virtual string Distribution { get; internal set; }
        /// <summary><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
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
              .Add("webapp traffic-routing set")
              .Add("--distribution {value}", Distribution)
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
    #region AzureWebappTrafficRoutingShowSettings
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureWebappTrafficRoutingShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureWebapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureWebappTasks.AzureWebappPath;
        /// <summary><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
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
              .Add("webapp traffic-routing show")
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
    #region AzureWebappConfigAppsettingsDeleteSettings
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureWebappConfigAppsettingsDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureWebapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureWebappTasks.AzureWebappPath;
        /// <summary><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Space-separated appsettings names.</p></summary>
        public virtual string SettingNames { get; internal set; }
        /// <summary><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        public virtual string Slot { get; internal set; }
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
              .Add("webapp config appsettings delete")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--setting-names {value}", SettingNames)
              .Add("--slot {value}", Slot)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureWebappConfigAppsettingsListSettings
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureWebappConfigAppsettingsListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureWebapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureWebappTasks.AzureWebappPath;
        /// <summary><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        public virtual string Slot { get; internal set; }
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
              .Add("webapp config appsettings list")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--slot {value}", Slot)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureWebappConfigAppsettingsSetSettings
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureWebappConfigAppsettingsSetSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureWebapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureWebappTasks.AzureWebappPath;
        /// <summary><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Space-separated appsettings in a format of &lt;name&gt;=&lt;value&gt;.</p></summary>
        public virtual string Settings { get; internal set; }
        /// <summary><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        public virtual string Slot { get; internal set; }
        /// <summary><p>Space-separated slot appsettings in a format of &lt;name&gt;=&lt;value&gt;.</p></summary>
        public virtual string SlotSettings { get; internal set; }
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
              .Add("webapp config appsettings set")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--settings {value}", Settings)
              .Add("--slot {value}", Slot)
              .Add("--slot-settings {value}", SlotSettings)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureWebappConfigBackupCreateSettings
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureWebappConfigBackupCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureWebapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureWebappTasks.AzureWebappPath;
        /// <summary><p>URL with SAS token to the blob storage container.</p></summary>
        public virtual string ContainerUrl { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The name of the webapp.</p></summary>
        public virtual string WebappName { get; internal set; }
        /// <summary><p>Name of the backup. If unspecified, the backup will be named with the webapp name and a timestamp.</p></summary>
        public virtual string BackupName { get; internal set; }
        /// <summary><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        public virtual string Slot { get; internal set; }
        /// <summary><p>Connection string for the database in the backup.</p></summary>
        public virtual string DbConnectionString { get; internal set; }
        /// <summary><p>Name of the database in the backup.</p></summary>
        public virtual string DbName { get; internal set; }
        /// <summary><p>Type of database in the backup.</p></summary>
        public virtual WebappConfigBackupDbType DbType { get; internal set; }
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
              .Add("webapp config backup create")
              .Add("--container-url {value}", ContainerUrl)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--webapp-name {value}", WebappName)
              .Add("--backup-name {value}", BackupName)
              .Add("--slot {value}", Slot)
              .Add("--db-connection-string {value}", DbConnectionString)
              .Add("--db-name {value}", DbName)
              .Add("--db-type {value}", DbType)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureWebappConfigBackupListSettings
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureWebappConfigBackupListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureWebapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureWebappTasks.AzureWebappPath;
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The name of the webapp.</p></summary>
        public virtual string WebappName { get; internal set; }
        /// <summary><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        public virtual string Slot { get; internal set; }
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
              .Add("webapp config backup list")
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--webapp-name {value}", WebappName)
              .Add("--slot {value}", Slot)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureWebappConfigBackupRestoreSettings
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureWebappConfigBackupRestoreSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureWebapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureWebappTasks.AzureWebappPath;
        /// <summary><p>Name of the backup to restore.</p></summary>
        public virtual string BackupName { get; internal set; }
        /// <summary><p>URL with SAS token to the blob storage container.</p></summary>
        public virtual string ContainerUrl { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The name of the webapp.</p></summary>
        public virtual string WebappName { get; internal set; }
        /// <summary><p>Ignores custom hostnames stored in the backup.</p></summary>
        public virtual string IgnoreHostnameConflict { get; internal set; }
        /// <summary><p>Overwrite the source webapp, if --target-name is not specified.</p></summary>
        public virtual string Overwrite { get; internal set; }
        /// <summary><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        public virtual string Slot { get; internal set; }
        /// <summary><p>The name to use for the restored webapp. If unspecified, will default to the name that was used when the backup was created.</p></summary>
        public virtual string TargetName { get; internal set; }
        /// <summary><p>Connection string for the database in the backup.</p></summary>
        public virtual string DbConnectionString { get; internal set; }
        /// <summary><p>Name of the database in the backup.</p></summary>
        public virtual string DbName { get; internal set; }
        /// <summary><p>Type of database in the backup.</p></summary>
        public virtual WebappConfigBackupDbType DbType { get; internal set; }
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
              .Add("webapp config backup restore")
              .Add("--backup-name {value}", BackupName)
              .Add("--container-url {value}", ContainerUrl)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--webapp-name {value}", WebappName)
              .Add("--ignore-hostname-conflict {value}", IgnoreHostnameConflict)
              .Add("--overwrite {value}", Overwrite)
              .Add("--slot {value}", Slot)
              .Add("--target-name {value}", TargetName)
              .Add("--db-connection-string {value}", DbConnectionString)
              .Add("--db-name {value}", DbName)
              .Add("--db-type {value}", DbType)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureWebappConfigBackupShowSettings
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureWebappConfigBackupShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureWebapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureWebappTasks.AzureWebappPath;
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The name of the webapp.</p></summary>
        public virtual string WebappName { get; internal set; }
        /// <summary><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        public virtual string Slot { get; internal set; }
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
              .Add("webapp config backup show")
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--webapp-name {value}", WebappName)
              .Add("--slot {value}", Slot)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureWebappConfigBackupUpdateSettings
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureWebappConfigBackupUpdateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureWebapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureWebappTasks.AzureWebappPath;
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The name of the webapp.</p></summary>
        public virtual string WebappName { get; internal set; }
        /// <summary><p>Name of the backup. If unspecified, the backup will be named with the webapp name and a timestamp.</p></summary>
        public virtual string BackupName { get; internal set; }
        /// <summary><p>URL with SAS token to the blob storage container.</p></summary>
        public virtual string ContainerUrl { get; internal set; }
        /// <summary><p>How often to backup. Use a number followed by d or h, e.g. 5d = 5 days, 2h = 2 hours.</p></summary>
        public virtual string Frequency { get; internal set; }
        /// <summary><p>Always keep one backup, regardless of how old it is.</p></summary>
        public virtual bool? RetainOne { get; internal set; }
        /// <summary><p>How many days to keep a backup before automatically deleting it. Set to 0 for indefinite retention.</p></summary>
        public virtual string Retention { get; internal set; }
        /// <summary><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        public virtual string Slot { get; internal set; }
        /// <summary><p>Connection string for the database in the backup.</p></summary>
        public virtual string DbConnectionString { get; internal set; }
        /// <summary><p>Name of the database in the backup.</p></summary>
        public virtual string DbName { get; internal set; }
        /// <summary><p>Type of database in the backup.</p></summary>
        public virtual WebappConfigBackupDbType DbType { get; internal set; }
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
              .Add("webapp config backup update")
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--webapp-name {value}", WebappName)
              .Add("--backup-name {value}", BackupName)
              .Add("--container-url {value}", ContainerUrl)
              .Add("--frequency {value}", Frequency)
              .Add("--retain-one", RetainOne)
              .Add("--retention {value}", Retention)
              .Add("--slot {value}", Slot)
              .Add("--db-connection-string {value}", DbConnectionString)
              .Add("--db-name {value}", DbName)
              .Add("--db-type {value}", DbType)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureWebappConfigConnectionStringDeleteSettings
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureWebappConfigConnectionStringDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureWebapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureWebappTasks.AzureWebappPath;
        /// <summary><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Space-separated connection-string names.</p></summary>
        public virtual string SettingNames { get; internal set; }
        /// <summary><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        public virtual string Slot { get; internal set; }
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
              .Add("webapp config connection-string delete")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--setting-names {value}", SettingNames)
              .Add("--slot {value}", Slot)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureWebappConfigConnectionStringListSettings
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureWebappConfigConnectionStringListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureWebapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureWebappTasks.AzureWebappPath;
        /// <summary><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        public virtual string Slot { get; internal set; }
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
              .Add("webapp config connection-string list")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--slot {value}", Slot)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureWebappConfigConnectionStringSetSettings
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureWebappConfigConnectionStringSetSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureWebapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureWebappTasks.AzureWebappPath;
        /// <summary><p>Connection string type.</p></summary>
        public virtual WebappConfigConnectionStringSetConnectionStringType ConnectionStringType { get; internal set; }
        /// <summary><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Space-separated connection-string in a format of &lt;name&gt;=&lt;value&gt;.</p></summary>
        public virtual string Settings { get; internal set; }
        /// <summary><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        public virtual string Slot { get; internal set; }
        /// <summary><p>Space-separated slot connection-string in a format of &lt;name&gt;=&lt;value&gt;.</p></summary>
        public virtual string SlotSettings { get; internal set; }
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
              .Add("webapp config connection-string set")
              .Add("--connection-string-type {value}", ConnectionStringType)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--settings {value}", Settings)
              .Add("--slot {value}", Slot)
              .Add("--slot-settings {value}", SlotSettings)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureWebappConfigContainerDeleteSettings
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureWebappConfigContainerDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureWebapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureWebappTasks.AzureWebappPath;
        /// <summary><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        public virtual string Slot { get; internal set; }
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
              .Add("webapp config container delete")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--slot {value}", Slot)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureWebappConfigContainerSetSettings
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureWebappConfigContainerSetSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureWebapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureWebappTasks.AzureWebappPath;
        /// <summary><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The container custom image name and optionally the tag name.</p></summary>
        public virtual string DockerCustomImageName { get; internal set; }
        /// <summary><p>The container registry server password.</p></summary>
        public virtual string DockerRegistryServerPassword { get; internal set; }
        /// <summary><p>The container registry server url.</p></summary>
        public virtual string DockerRegistryServerUrl { get; internal set; }
        /// <summary><p>The container registry server username.</p></summary>
        public virtual string DockerRegistryServerUser { get; internal set; }
        /// <summary><p>Enables platform storage (custom container only).</p></summary>
        public virtual bool? EnableAppServiceStorage { get; internal set; }
        /// <summary><p>Config file for multicontainer apps.</p></summary>
        public virtual string MulticontainerConfigFile { get; internal set; }
        /// <summary><p>Config type.</p></summary>
        public virtual WebappMulticontainerConfigType MulticontainerConfigType { get; internal set; }
        /// <summary><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        public virtual string Slot { get; internal set; }
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
              .Add("webapp config container set")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--docker-custom-image-name {value}", DockerCustomImageName)
              .Add("--docker-registry-server-password {value}", DockerRegistryServerPassword, secret: true)
              .Add("--docker-registry-server-url {value}", DockerRegistryServerUrl)
              .Add("--docker-registry-server-user {value}", DockerRegistryServerUser)
              .Add("--enable-app-service-storage", EnableAppServiceStorage)
              .Add("--multicontainer-config-file {value}", MulticontainerConfigFile)
              .Add("--multicontainer-config-type {value}", MulticontainerConfigType)
              .Add("--slot {value}", Slot)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureWebappConfigContainerShowSettings
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureWebappConfigContainerShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureWebapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureWebappTasks.AzureWebappPath;
        /// <summary><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Shows decoded config if a multicontainer config is set.</p></summary>
        public virtual string ShowMulticontainerConfig { get; internal set; }
        /// <summary><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        public virtual string Slot { get; internal set; }
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
              .Add("webapp config container show")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--show-multicontainer-config {value}", ShowMulticontainerConfig)
              .Add("--slot {value}", Slot)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureWebappConfigHostnameAddSettings
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureWebappConfigHostnameAddSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureWebapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureWebappTasks.AzureWebappPath;
        /// <summary><p>Hostname assigned to the site, such as custom domains.</p></summary>
        public virtual string Hostname { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Webapp name. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        public virtual string WebappName { get; internal set; }
        /// <summary><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        public virtual string Slot { get; internal set; }
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
              .Add("webapp config hostname add")
              .Add("--hostname {value}", Hostname)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--webapp-name {value}", WebappName)
              .Add("--slot {value}", Slot)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureWebappConfigHostnameDeleteSettings
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureWebappConfigHostnameDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureWebapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureWebappTasks.AzureWebappPath;
        /// <summary><p>Hostname assigned to the site, such as custom domains.</p></summary>
        public virtual string Hostname { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Webapp name. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        public virtual string WebappName { get; internal set; }
        /// <summary><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        public virtual string Slot { get; internal set; }
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
              .Add("webapp config hostname delete")
              .Add("--hostname {value}", Hostname)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--webapp-name {value}", WebappName)
              .Add("--slot {value}", Slot)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureWebappConfigHostnameGetExternalIpSettings
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureWebappConfigHostnameGetExternalIpSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureWebapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureWebappTasks.AzureWebappPath;
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Webapp name. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        public virtual string WebappName { get; internal set; }
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
              .Add("webapp config hostname get-external-ip")
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--webapp-name {value}", WebappName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureWebappConfigHostnameListSettings
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureWebappConfigHostnameListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureWebapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureWebappTasks.AzureWebappPath;
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        public virtual string WebappName { get; internal set; }
        /// <summary><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        public virtual string Slot { get; internal set; }
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
              .Add("webapp config hostname list")
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--webapp-name {value}", WebappName)
              .Add("--slot {value}", Slot)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureWebappConfigSslBindSettings
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureWebappConfigSslBindSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureWebapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureWebappTasks.AzureWebappPath;
        /// <summary><p>The ssl cert thumbprint.</p></summary>
        public virtual string CertificateThumbprint { get; internal set; }
        /// <summary><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The ssl cert type.</p></summary>
        public virtual WebappConfigSslBindSslType SslType { get; internal set; }
        /// <summary><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        public virtual string Slot { get; internal set; }
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
              .Add("webapp config ssl bind")
              .Add("--certificate-thumbprint {value}", CertificateThumbprint)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--ssl-type {value}", SslType)
              .Add("--slot {value}", Slot)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureWebappConfigSslDeleteSettings
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureWebappConfigSslDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureWebapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureWebappTasks.AzureWebappPath;
        /// <summary><p>The ssl cert thumbprint.</p></summary>
        public virtual string CertificateThumbprint { get; internal set; }
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
              .Add("webapp config ssl delete")
              .Add("--certificate-thumbprint {value}", CertificateThumbprint)
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
    #region AzureWebappConfigSslListSettings
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureWebappConfigSslListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureWebapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureWebappTasks.AzureWebappPath;
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
              .Add("webapp config ssl list")
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
    #region AzureWebappConfigSslUnbindSettings
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureWebappConfigSslUnbindSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureWebapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureWebappTasks.AzureWebappPath;
        /// <summary><p>The ssl cert thumbprint.</p></summary>
        public virtual string CertificateThumbprint { get; internal set; }
        /// <summary><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        public virtual string Slot { get; internal set; }
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
              .Add("webapp config ssl unbind")
              .Add("--certificate-thumbprint {value}", CertificateThumbprint)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--slot {value}", Slot)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureWebappConfigSslUploadSettings
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureWebappConfigSslUploadSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureWebapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureWebappTasks.AzureWebappPath;
        /// <summary><p>The filepath for the .pfx file.</p></summary>
        public virtual string CertificateFile { get; internal set; }
        /// <summary><p>The ssl cert password.</p></summary>
        public virtual string CertificatePassword { get; internal set; }
        /// <summary><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
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
              .Add("webapp config ssl upload")
              .Add("--certificate-file {value}", CertificateFile)
              .Add("--certificate-password {value}", CertificatePassword, secret: true)
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
    #region AzureWebappDeploymentContainerConfigSettings
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureWebappDeploymentContainerConfigSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureWebapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureWebappTasks.AzureWebappPath;
        /// <summary><p>Enable/disable continuous deployment.</p></summary>
        public virtual bool? EnableCd { get; internal set; }
        /// <summary><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        public virtual string Slot { get; internal set; }
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
              .Add("webapp deployment container config")
              .Add("--enable-cd", EnableCd)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--slot {value}", Slot)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureWebappDeploymentContainerShowCdUrlSettings
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureWebappDeploymentContainerShowCdUrlSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureWebapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureWebappTasks.AzureWebappPath;
        /// <summary><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        public virtual string Slot { get; internal set; }
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
              .Add("webapp deployment container show-cd-url")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--slot {value}", Slot)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureWebappDeploymentSlotAutoSwapSettings
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureWebappDeploymentSlotAutoSwapSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureWebapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureWebappTasks.AzureWebappPath;
        /// <summary><p>Name of the webapp.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The name of the slot.</p></summary>
        public virtual string Slot { get; internal set; }
        /// <summary><p>Target slot to auto swap.</p></summary>
        public virtual string AutoSwapSlot { get; internal set; }
        /// <summary><p>Disable auto swap.</p></summary>
        public virtual string Disable { get; internal set; }
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
              .Add("webapp deployment slot auto-swap")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--slot {value}", Slot)
              .Add("--auto-swap-slot {value}", AutoSwapSlot)
              .Add("--disable {value}", Disable)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureWebappDeploymentSlotCreateSettings
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureWebappDeploymentSlotCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureWebapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureWebappTasks.AzureWebappPath;
        /// <summary><p>Name of the webapp.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The name of the slot.</p></summary>
        public virtual string Slot { get; internal set; }
        /// <summary><p>Source slot to clone configurations from. Use webapp's name to refer to the production slot.</p></summary>
        public virtual string ConfigurationSource { get; internal set; }
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
              .Add("webapp deployment slot create")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--slot {value}", Slot)
              .Add("--configuration-source {value}", ConfigurationSource)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureWebappDeploymentSlotDeleteSettings
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureWebappDeploymentSlotDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureWebapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureWebappTasks.AzureWebappPath;
        /// <summary><p>Name of the webapp.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The name of the slot.</p></summary>
        public virtual string Slot { get; internal set; }
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
              .Add("webapp deployment slot delete")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--slot {value}", Slot)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureWebappDeploymentSlotListSettings
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureWebappDeploymentSlotListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureWebapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureWebappTasks.AzureWebappPath;
        /// <summary><p>Name of the webapp.</p></summary>
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
              .Add("webapp deployment slot list")
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
    #region AzureWebappDeploymentSlotSwapSettings
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureWebappDeploymentSlotSwapSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureWebapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureWebappTasks.AzureWebappPath;
        /// <summary><p>Name of the webapp.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The name of the slot.</p></summary>
        public virtual string Slot { get; internal set; }
        /// <summary><p>Swap types. use 'preview' to apply target slot's settings on the source slot first; use 'swap' to complete it; use 'reset' to reset the swap.</p></summary>
        public virtual WebappDeploymentSlotSwapAction Action { get; internal set; }
        /// <summary><p>Target slot to swap, default to 'production'.</p></summary>
        public virtual string TargetSlot { get; internal set; }
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
              .Add("webapp deployment slot swap")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--slot {value}", Slot)
              .Add("--action {value}", Action)
              .Add("--target-slot {value}", TargetSlot)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureWebappDeploymentSourceConfigSettings
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureWebappDeploymentSourceConfigSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureWebapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureWebappTasks.AzureWebappPath;
        /// <summary><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Repository url to pull the latest source from, e.g. &lt;a href="https://github.com/foo/foo-web"&gt;https://github.com/foo/foo-web&lt;/a&gt;.</p></summary>
        public virtual string RepoUrl { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The branch name of the repository.</p></summary>
        public virtual string Branch { get; internal set; }
        /// <summary><p>Git access token required for auto sync.</p></summary>
        public virtual string GitToken { get; internal set; }
        /// <summary><p>Disable automatic sync between source control and web.</p></summary>
        public virtual string ManualIntegration { get; internal set; }
        /// <summary><p>Repository type.</p></summary>
        public virtual WebappDeploymentSourceConfigRepositoryType RepositoryType { get; internal set; }
        /// <summary><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        public virtual string Slot { get; internal set; }
        /// <summary><p>Working directory of the application. Default will be root of the repo.</p></summary>
        public virtual string AppWorkingDir { get; internal set; }
        /// <summary><p>To create a new Visual Studio Team Services (VSTS) account if it doesn't exist already.</p></summary>
        public virtual string CdAccountCreate { get; internal set; }
        /// <summary><p>Web application framework you used to develop your app. Default is AspNet.</p></summary>
        public virtual WebappDeploymentSourceConfigCdAppType CdAppType { get; internal set; }
        /// <summary><p>URL of the Visual Studio Team Services (VSTS) project to use for continuous delivery. URL should be in format https://&amp;lt;accountname&amp;gt;.visualstudio.com/&amp;lt;projectname&amp;gt;.</p></summary>
        public virtual string CdProjectUrl { get; internal set; }
        /// <summary><p>Task runner for nodejs. Default is None.</p></summary>
        public virtual WebappDeploymentSourceConfigNodejsTaskRunner NodejsTaskRunner { get; internal set; }
        /// <summary><p>Password for the private repository.</p></summary>
        public virtual string PrivateRepoPassword { get; internal set; }
        /// <summary><p>Username for the private repository.</p></summary>
        public virtual string PrivateRepoUsername { get; internal set; }
        /// <summary><p>Framework used for Python application. Default is Django.</p></summary>
        public virtual WebappDeploymentSourceConfigPythonFramework PythonFramework { get; internal set; }
        /// <summary><p>Python version used for application. Default is Python 3.5.3 x86.</p></summary>
        public virtual WebappDeploymentSourceConfigPythonVersion PythonVersion { get; internal set; }
        /// <summary><p>Name of the slot to be used for deployment and later promote to production. If slot is not available, it will be created. Default: Not configured.</p></summary>
        public virtual string SlotSwap { get; internal set; }
        /// <summary><p>Name of the web app to be used for load testing. If web app is not available, it will be created. Default: Disable.</p></summary>
        public virtual string Test { get; internal set; }
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
              .Add("webapp deployment source config")
              .Add("--name {value}", Name)
              .Add("--repo-url {value}", RepoUrl)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--branch {value}", Branch)
              .Add("--git-token {value}", GitToken)
              .Add("--manual-integration {value}", ManualIntegration)
              .Add("--repository-type {value}", RepositoryType)
              .Add("--slot {value}", Slot)
              .Add("--app-working-dir {value}", AppWorkingDir)
              .Add("--cd-account-create {value}", CdAccountCreate)
              .Add("--cd-app-type {value}", CdAppType)
              .Add("--cd-project-url {value}", CdProjectUrl)
              .Add("--nodejs-task-runner {value}", NodejsTaskRunner)
              .Add("--private-repo-password {value}", PrivateRepoPassword, secret: true)
              .Add("--private-repo-username {value}", PrivateRepoUsername)
              .Add("--python-framework {value}", PythonFramework)
              .Add("--python-version {value}", PythonVersion)
              .Add("--slot-swap {value}", SlotSwap)
              .Add("--test {value}", Test)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureWebappDeploymentSourceConfigLocalGitSettings
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureWebappDeploymentSourceConfigLocalGitSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureWebapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureWebappTasks.AzureWebappPath;
        /// <summary><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        public virtual string Slot { get; internal set; }
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
              .Add("webapp deployment source config-local-git")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--slot {value}", Slot)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureWebappDeploymentSourceConfigZipSettings
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureWebappDeploymentSourceConfigZipSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureWebapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureWebappTasks.AzureWebappPath;
        /// <summary><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>A zip file path for deployment.</p></summary>
        public virtual string Src { get; internal set; }
        /// <summary><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        public virtual string Slot { get; internal set; }
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
              .Add("webapp deployment source config-zip")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--src {value}", Src)
              .Add("--slot {value}", Slot)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureWebappDeploymentSourceDeleteSettings
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureWebappDeploymentSourceDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureWebapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureWebappTasks.AzureWebappPath;
        /// <summary><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        public virtual string Slot { get; internal set; }
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
              .Add("webapp deployment source delete")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--slot {value}", Slot)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureWebappDeploymentSourceShowSettings
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureWebappDeploymentSourceShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureWebapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureWebappTasks.AzureWebappPath;
        /// <summary><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        public virtual string Slot { get; internal set; }
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
              .Add("webapp deployment source show")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--slot {value}", Slot)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureWebappDeploymentSourceSyncSettings
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureWebappDeploymentSourceSyncSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureWebapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureWebappTasks.AzureWebappPath;
        /// <summary><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        public virtual string Slot { get; internal set; }
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
              .Add("webapp deployment source sync")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--slot {value}", Slot)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureWebappDeploymentSourceUpdateTokenSettings
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureWebappDeploymentSourceUpdateTokenSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureWebapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureWebappTasks.AzureWebappPath;
        /// <summary><p>Git access token required for auto sync.</p></summary>
        public virtual string GitToken { get; internal set; }
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
              .Add("webapp deployment source update-token")
              .Add("--git-token {value}", GitToken)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureWebappDeploymentUserSetSettings
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureWebappDeploymentUserSetSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureWebapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureWebappTasks.AzureWebappPath;
        /// <summary><p>User name.</p></summary>
        public virtual string UserName { get; internal set; }
        /// <summary><p>Password, will prompt if not specified.</p></summary>
        public virtual string Password { get; internal set; }
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
              .Add("webapp deployment user set")
              .Add("--user-name {value}", UserName)
              .Add("--password {value}", Password, secret: true)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureWebappDeploymentUserShowSettings
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureWebappDeploymentUserShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureWebapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureWebappTasks.AzureWebappPath;
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
              .Add("webapp deployment user show")
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureWebappBrowseSettingsExtensions
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureWebappBrowseSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureWebappBrowseSettings.Name"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappBrowseSettings SetName(this AzureWebappBrowseSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappBrowseSettings.Name"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappBrowseSettings ResetName(this AzureWebappBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureWebappBrowseSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappBrowseSettings SetResourceGroup(this AzureWebappBrowseSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappBrowseSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappBrowseSettings ResetResourceGroup(this AzureWebappBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Logs
        /// <summary><p><em>Sets <see cref="AzureWebappBrowseSettings.Logs"/>.</em></p><p>Enable viewing the log stream immediately after launching the web app.</p></summary>
        [Pure]
        public static AzureWebappBrowseSettings SetLogs(this AzureWebappBrowseSettings toolSettings, string logs)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Logs = logs;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappBrowseSettings.Logs"/>.</em></p><p>Enable viewing the log stream immediately after launching the web app.</p></summary>
        [Pure]
        public static AzureWebappBrowseSettings ResetLogs(this AzureWebappBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Logs = null;
            return toolSettings;
        }
        #endregion
        #region Slot
        /// <summary><p><em>Sets <see cref="AzureWebappBrowseSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappBrowseSettings SetSlot(this AzureWebappBrowseSettings toolSettings, string slot)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = slot;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappBrowseSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappBrowseSettings ResetSlot(this AzureWebappBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureWebappBrowseSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappBrowseSettings SetDebug(this AzureWebappBrowseSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappBrowseSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappBrowseSettings ResetDebug(this AzureWebappBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureWebappBrowseSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappBrowseSettings SetHelp(this AzureWebappBrowseSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappBrowseSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappBrowseSettings ResetHelp(this AzureWebappBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureWebappBrowseSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappBrowseSettings SetOutput(this AzureWebappBrowseSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappBrowseSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappBrowseSettings ResetOutput(this AzureWebappBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureWebappBrowseSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappBrowseSettings SetQuery(this AzureWebappBrowseSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappBrowseSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappBrowseSettings ResetQuery(this AzureWebappBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureWebappBrowseSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappBrowseSettings SetVerbose(this AzureWebappBrowseSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappBrowseSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappBrowseSettings ResetVerbose(this AzureWebappBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureWebappCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureWebappCreateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureWebappCreateSettings.Name"/>.</em></p><p>Name of the new webapp.</p></summary>
        [Pure]
        public static AzureWebappCreateSettings SetName(this AzureWebappCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappCreateSettings.Name"/>.</em></p><p>Name of the new webapp.</p></summary>
        [Pure]
        public static AzureWebappCreateSettings ResetName(this AzureWebappCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Plan
        /// <summary><p><em>Sets <see cref="AzureWebappCreateSettings.Plan"/>.</em></p><p>Name or resource id of the app service plan. Use 'appservice plan create' to get one.</p></summary>
        [Pure]
        public static AzureWebappCreateSettings SetPlan(this AzureWebappCreateSettings toolSettings, string plan)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Plan = plan;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappCreateSettings.Plan"/>.</em></p><p>Name or resource id of the app service plan. Use 'appservice plan create' to get one.</p></summary>
        [Pure]
        public static AzureWebappCreateSettings ResetPlan(this AzureWebappCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Plan = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureWebappCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappCreateSettings SetResourceGroup(this AzureWebappCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappCreateSettings ResetResourceGroup(this AzureWebappCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region DeploymentContainerImageName
        /// <summary><p><em>Sets <see cref="AzureWebappCreateSettings.DeploymentContainerImageName"/>.</em></p><p>Linux only. Container image name from Docker Hub, e.g. publisher/image-name:tag.</p></summary>
        [Pure]
        public static AzureWebappCreateSettings SetDeploymentContainerImageName(this AzureWebappCreateSettings toolSettings, string deploymentContainerImageName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DeploymentContainerImageName = deploymentContainerImageName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappCreateSettings.DeploymentContainerImageName"/>.</em></p><p>Linux only. Container image name from Docker Hub, e.g. publisher/image-name:tag.</p></summary>
        [Pure]
        public static AzureWebappCreateSettings ResetDeploymentContainerImageName(this AzureWebappCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DeploymentContainerImageName = null;
            return toolSettings;
        }
        #endregion
        #region DeploymentLocalGit
        /// <summary><p><em>Sets <see cref="AzureWebappCreateSettings.DeploymentLocalGit"/>.</em></p><p>Enable local git.</p></summary>
        [Pure]
        public static AzureWebappCreateSettings SetDeploymentLocalGit(this AzureWebappCreateSettings toolSettings, string deploymentLocalGit)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DeploymentLocalGit = deploymentLocalGit;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappCreateSettings.DeploymentLocalGit"/>.</em></p><p>Enable local git.</p></summary>
        [Pure]
        public static AzureWebappCreateSettings ResetDeploymentLocalGit(this AzureWebappCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DeploymentLocalGit = null;
            return toolSettings;
        }
        #endregion
        #region DeploymentSourceBranch
        /// <summary><p><em>Sets <see cref="AzureWebappCreateSettings.DeploymentSourceBranch"/>.</em></p><p>The branch to deploy.</p></summary>
        [Pure]
        public static AzureWebappCreateSettings SetDeploymentSourceBranch(this AzureWebappCreateSettings toolSettings, string deploymentSourceBranch)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DeploymentSourceBranch = deploymentSourceBranch;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappCreateSettings.DeploymentSourceBranch"/>.</em></p><p>The branch to deploy.</p></summary>
        [Pure]
        public static AzureWebappCreateSettings ResetDeploymentSourceBranch(this AzureWebappCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DeploymentSourceBranch = null;
            return toolSettings;
        }
        #endregion
        #region DeploymentSourceUrl
        /// <summary><p><em>Sets <see cref="AzureWebappCreateSettings.DeploymentSourceUrl"/>.</em></p><p>Git repository URL to link with manual integration.</p></summary>
        [Pure]
        public static AzureWebappCreateSettings SetDeploymentSourceUrl(this AzureWebappCreateSettings toolSettings, string deploymentSourceUrl)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DeploymentSourceUrl = deploymentSourceUrl;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappCreateSettings.DeploymentSourceUrl"/>.</em></p><p>Git repository URL to link with manual integration.</p></summary>
        [Pure]
        public static AzureWebappCreateSettings ResetDeploymentSourceUrl(this AzureWebappCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DeploymentSourceUrl = null;
            return toolSettings;
        }
        #endregion
        #region MulticontainerConfigFile
        /// <summary><p><em>Sets <see cref="AzureWebappCreateSettings.MulticontainerConfigFile"/>.</em></p><p>Linux only. Config file for multicontainer apps. (local or remote).</p></summary>
        [Pure]
        public static AzureWebappCreateSettings SetMulticontainerConfigFile(this AzureWebappCreateSettings toolSettings, string multicontainerConfigFile)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MulticontainerConfigFile = multicontainerConfigFile;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappCreateSettings.MulticontainerConfigFile"/>.</em></p><p>Linux only. Config file for multicontainer apps. (local or remote).</p></summary>
        [Pure]
        public static AzureWebappCreateSettings ResetMulticontainerConfigFile(this AzureWebappCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MulticontainerConfigFile = null;
            return toolSettings;
        }
        #endregion
        #region MulticontainerConfigType
        /// <summary><p><em>Sets <see cref="AzureWebappCreateSettings.MulticontainerConfigType"/>.</em></p><p>Linux only.</p></summary>
        [Pure]
        public static AzureWebappCreateSettings SetMulticontainerConfigType(this AzureWebappCreateSettings toolSettings, WebappMulticontainerConfigType multicontainerConfigType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MulticontainerConfigType = multicontainerConfigType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappCreateSettings.MulticontainerConfigType"/>.</em></p><p>Linux only.</p></summary>
        [Pure]
        public static AzureWebappCreateSettings ResetMulticontainerConfigType(this AzureWebappCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MulticontainerConfigType = null;
            return toolSettings;
        }
        #endregion
        #region Runtime
        /// <summary><p><em>Sets <see cref="AzureWebappCreateSettings.Runtime"/>.</em></p><p>Canonicalized web runtime in the format of Framework|Version, e.g. "PHP|5.6". Use 'az webapp list-runtimes' for available list.</p></summary>
        [Pure]
        public static AzureWebappCreateSettings SetRuntime(this AzureWebappCreateSettings toolSettings, string runtime)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Runtime = runtime;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappCreateSettings.Runtime"/>.</em></p><p>Canonicalized web runtime in the format of Framework|Version, e.g. "PHP|5.6". Use 'az webapp list-runtimes' for available list.</p></summary>
        [Pure]
        public static AzureWebappCreateSettings ResetRuntime(this AzureWebappCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Runtime = null;
            return toolSettings;
        }
        #endregion
        #region StartupFile
        /// <summary><p><em>Sets <see cref="AzureWebappCreateSettings.StartupFile"/>.</em></p><p>Linux only. The web's startup file.</p></summary>
        [Pure]
        public static AzureWebappCreateSettings SetStartupFile(this AzureWebappCreateSettings toolSettings, string startupFile)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartupFile = startupFile;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappCreateSettings.StartupFile"/>.</em></p><p>Linux only. The web's startup file.</p></summary>
        [Pure]
        public static AzureWebappCreateSettings ResetStartupFile(this AzureWebappCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartupFile = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureWebappCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappCreateSettings SetDebug(this AzureWebappCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappCreateSettings ResetDebug(this AzureWebappCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureWebappCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappCreateSettings SetHelp(this AzureWebappCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappCreateSettings ResetHelp(this AzureWebappCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureWebappCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappCreateSettings SetOutput(this AzureWebappCreateSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappCreateSettings ResetOutput(this AzureWebappCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureWebappCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappCreateSettings SetQuery(this AzureWebappCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappCreateSettings ResetQuery(this AzureWebappCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureWebappCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappCreateSettings SetVerbose(this AzureWebappCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappCreateSettings ResetVerbose(this AzureWebappCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureWebappDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureWebappDeleteSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureWebappDeleteSettings.Name"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappDeleteSettings SetName(this AzureWebappDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeleteSettings.Name"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappDeleteSettings ResetName(this AzureWebappDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureWebappDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappDeleteSettings SetResourceGroup(this AzureWebappDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappDeleteSettings ResetResourceGroup(this AzureWebappDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region KeepDnsRegistration
        /// <summary><p><em>Sets <see cref="AzureWebappDeleteSettings.KeepDnsRegistration"/>.</em></p><p>Keep DNS registration.</p></summary>
        [Pure]
        public static AzureWebappDeleteSettings SetKeepDnsRegistration(this AzureWebappDeleteSettings toolSettings, string keepDnsRegistration)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeepDnsRegistration = keepDnsRegistration;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeleteSettings.KeepDnsRegistration"/>.</em></p><p>Keep DNS registration.</p></summary>
        [Pure]
        public static AzureWebappDeleteSettings ResetKeepDnsRegistration(this AzureWebappDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeepDnsRegistration = null;
            return toolSettings;
        }
        #endregion
        #region KeepEmptyPlan
        /// <summary><p><em>Sets <see cref="AzureWebappDeleteSettings.KeepEmptyPlan"/>.</em></p><p>Keep empty app service plan.</p></summary>
        [Pure]
        public static AzureWebappDeleteSettings SetKeepEmptyPlan(this AzureWebappDeleteSettings toolSettings, string keepEmptyPlan)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeepEmptyPlan = keepEmptyPlan;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeleteSettings.KeepEmptyPlan"/>.</em></p><p>Keep empty app service plan.</p></summary>
        [Pure]
        public static AzureWebappDeleteSettings ResetKeepEmptyPlan(this AzureWebappDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeepEmptyPlan = null;
            return toolSettings;
        }
        #endregion
        #region KeepMetrics
        /// <summary><p><em>Sets <see cref="AzureWebappDeleteSettings.KeepMetrics"/>.</em></p><p>Keep app metrics.</p></summary>
        [Pure]
        public static AzureWebappDeleteSettings SetKeepMetrics(this AzureWebappDeleteSettings toolSettings, string keepMetrics)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeepMetrics = keepMetrics;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeleteSettings.KeepMetrics"/>.</em></p><p>Keep app metrics.</p></summary>
        [Pure]
        public static AzureWebappDeleteSettings ResetKeepMetrics(this AzureWebappDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeepMetrics = null;
            return toolSettings;
        }
        #endregion
        #region Slot
        /// <summary><p><em>Sets <see cref="AzureWebappDeleteSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappDeleteSettings SetSlot(this AzureWebappDeleteSettings toolSettings, string slot)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = slot;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeleteSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappDeleteSettings ResetSlot(this AzureWebappDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureWebappDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappDeleteSettings SetDebug(this AzureWebappDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappDeleteSettings ResetDebug(this AzureWebappDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureWebappDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappDeleteSettings SetHelp(this AzureWebappDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappDeleteSettings ResetHelp(this AzureWebappDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureWebappDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappDeleteSettings SetOutput(this AzureWebappDeleteSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappDeleteSettings ResetOutput(this AzureWebappDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureWebappDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappDeleteSettings SetQuery(this AzureWebappDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappDeleteSettings ResetQuery(this AzureWebappDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureWebappDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappDeleteSettings SetVerbose(this AzureWebappDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappDeleteSettings ResetVerbose(this AzureWebappDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureWebappListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureWebappListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureWebappListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappListSettings SetResourceGroup(this AzureWebappListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappListSettings ResetResourceGroup(this AzureWebappListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureWebappListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappListSettings SetDebug(this AzureWebappListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappListSettings ResetDebug(this AzureWebappListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureWebappListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappListSettings SetHelp(this AzureWebappListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappListSettings ResetHelp(this AzureWebappListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureWebappListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappListSettings SetOutput(this AzureWebappListSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappListSettings ResetOutput(this AzureWebappListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureWebappListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappListSettings SetQuery(this AzureWebappListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappListSettings ResetQuery(this AzureWebappListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureWebappListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappListSettings SetVerbose(this AzureWebappListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappListSettings ResetVerbose(this AzureWebappListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureWebappListRuntimesSettingsExtensions
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureWebappListRuntimesSettingsExtensions
    {
        #region Linux
        /// <summary><p><em>Sets <see cref="AzureWebappListRuntimesSettings.Linux"/>.</em></p><p>List runtime stacks for linux based webapps.</p></summary>
        [Pure]
        public static AzureWebappListRuntimesSettings SetLinux(this AzureWebappListRuntimesSettings toolSettings, string linux)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Linux = linux;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappListRuntimesSettings.Linux"/>.</em></p><p>List runtime stacks for linux based webapps.</p></summary>
        [Pure]
        public static AzureWebappListRuntimesSettings ResetLinux(this AzureWebappListRuntimesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Linux = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureWebappListRuntimesSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappListRuntimesSettings SetDebug(this AzureWebappListRuntimesSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappListRuntimesSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappListRuntimesSettings ResetDebug(this AzureWebappListRuntimesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureWebappListRuntimesSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappListRuntimesSettings SetHelp(this AzureWebappListRuntimesSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappListRuntimesSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappListRuntimesSettings ResetHelp(this AzureWebappListRuntimesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureWebappListRuntimesSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappListRuntimesSettings SetOutput(this AzureWebappListRuntimesSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappListRuntimesSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappListRuntimesSettings ResetOutput(this AzureWebappListRuntimesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureWebappListRuntimesSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappListRuntimesSettings SetQuery(this AzureWebappListRuntimesSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappListRuntimesSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappListRuntimesSettings ResetQuery(this AzureWebappListRuntimesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureWebappListRuntimesSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappListRuntimesSettings SetVerbose(this AzureWebappListRuntimesSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappListRuntimesSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappListRuntimesSettings ResetVerbose(this AzureWebappListRuntimesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureWebappRestartSettingsExtensions
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureWebappRestartSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureWebappRestartSettings.Name"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappRestartSettings SetName(this AzureWebappRestartSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappRestartSettings.Name"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappRestartSettings ResetName(this AzureWebappRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureWebappRestartSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappRestartSettings SetResourceGroup(this AzureWebappRestartSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappRestartSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappRestartSettings ResetResourceGroup(this AzureWebappRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Slot
        /// <summary><p><em>Sets <see cref="AzureWebappRestartSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappRestartSettings SetSlot(this AzureWebappRestartSettings toolSettings, string slot)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = slot;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappRestartSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappRestartSettings ResetSlot(this AzureWebappRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureWebappRestartSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappRestartSettings SetDebug(this AzureWebappRestartSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappRestartSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappRestartSettings ResetDebug(this AzureWebappRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureWebappRestartSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappRestartSettings SetHelp(this AzureWebappRestartSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappRestartSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappRestartSettings ResetHelp(this AzureWebappRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureWebappRestartSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappRestartSettings SetOutput(this AzureWebappRestartSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappRestartSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappRestartSettings ResetOutput(this AzureWebappRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureWebappRestartSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappRestartSettings SetQuery(this AzureWebappRestartSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappRestartSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappRestartSettings ResetQuery(this AzureWebappRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureWebappRestartSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappRestartSettings SetVerbose(this AzureWebappRestartSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappRestartSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappRestartSettings ResetVerbose(this AzureWebappRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureWebappShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureWebappShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureWebappShowSettings.Name"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappShowSettings SetName(this AzureWebappShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappShowSettings.Name"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappShowSettings ResetName(this AzureWebappShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureWebappShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappShowSettings SetResourceGroup(this AzureWebappShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappShowSettings ResetResourceGroup(this AzureWebappShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Slot
        /// <summary><p><em>Sets <see cref="AzureWebappShowSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappShowSettings SetSlot(this AzureWebappShowSettings toolSettings, string slot)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = slot;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappShowSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappShowSettings ResetSlot(this AzureWebappShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureWebappShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappShowSettings SetDebug(this AzureWebappShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappShowSettings ResetDebug(this AzureWebappShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureWebappShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappShowSettings SetHelp(this AzureWebappShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappShowSettings ResetHelp(this AzureWebappShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureWebappShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappShowSettings SetOutput(this AzureWebappShowSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappShowSettings ResetOutput(this AzureWebappShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureWebappShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappShowSettings SetQuery(this AzureWebappShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappShowSettings ResetQuery(this AzureWebappShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureWebappShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappShowSettings SetVerbose(this AzureWebappShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappShowSettings ResetVerbose(this AzureWebappShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureWebappStartSettingsExtensions
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureWebappStartSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureWebappStartSettings.Name"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappStartSettings SetName(this AzureWebappStartSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappStartSettings.Name"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappStartSettings ResetName(this AzureWebappStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureWebappStartSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappStartSettings SetResourceGroup(this AzureWebappStartSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappStartSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappStartSettings ResetResourceGroup(this AzureWebappStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Slot
        /// <summary><p><em>Sets <see cref="AzureWebappStartSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappStartSettings SetSlot(this AzureWebappStartSettings toolSettings, string slot)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = slot;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappStartSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappStartSettings ResetSlot(this AzureWebappStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureWebappStartSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappStartSettings SetDebug(this AzureWebappStartSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappStartSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappStartSettings ResetDebug(this AzureWebappStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureWebappStartSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappStartSettings SetHelp(this AzureWebappStartSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappStartSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappStartSettings ResetHelp(this AzureWebappStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureWebappStartSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappStartSettings SetOutput(this AzureWebappStartSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappStartSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappStartSettings ResetOutput(this AzureWebappStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureWebappStartSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappStartSettings SetQuery(this AzureWebappStartSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappStartSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappStartSettings ResetQuery(this AzureWebappStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureWebappStartSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappStartSettings SetVerbose(this AzureWebappStartSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappStartSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappStartSettings ResetVerbose(this AzureWebappStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureWebappStopSettingsExtensions
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureWebappStopSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureWebappStopSettings.Name"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappStopSettings SetName(this AzureWebappStopSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappStopSettings.Name"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappStopSettings ResetName(this AzureWebappStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureWebappStopSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappStopSettings SetResourceGroup(this AzureWebappStopSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappStopSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappStopSettings ResetResourceGroup(this AzureWebappStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Slot
        /// <summary><p><em>Sets <see cref="AzureWebappStopSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappStopSettings SetSlot(this AzureWebappStopSettings toolSettings, string slot)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = slot;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappStopSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappStopSettings ResetSlot(this AzureWebappStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureWebappStopSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappStopSettings SetDebug(this AzureWebappStopSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappStopSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappStopSettings ResetDebug(this AzureWebappStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureWebappStopSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappStopSettings SetHelp(this AzureWebappStopSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappStopSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappStopSettings ResetHelp(this AzureWebappStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureWebappStopSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappStopSettings SetOutput(this AzureWebappStopSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappStopSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappStopSettings ResetOutput(this AzureWebappStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureWebappStopSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappStopSettings SetQuery(this AzureWebappStopSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappStopSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappStopSettings ResetQuery(this AzureWebappStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureWebappStopSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappStopSettings SetVerbose(this AzureWebappStopSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappStopSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappStopSettings ResetVerbose(this AzureWebappStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureWebappUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureWebappUpdateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureWebappUpdateSettings.Name"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappUpdateSettings SetName(this AzureWebappUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappUpdateSettings.Name"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappUpdateSettings ResetName(this AzureWebappUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureWebappUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappUpdateSettings SetResourceGroup(this AzureWebappUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappUpdateSettings ResetResourceGroup(this AzureWebappUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ClientAffinityEnabled
        /// <summary><p><em>Sets <see cref="AzureWebappUpdateSettings.ClientAffinityEnabled"/>.</em></p><p>Enables sending session affinity cookies.</p></summary>
        [Pure]
        public static AzureWebappUpdateSettings SetClientAffinityEnabled(this AzureWebappUpdateSettings toolSettings, bool? clientAffinityEnabled)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClientAffinityEnabled = clientAffinityEnabled;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappUpdateSettings.ClientAffinityEnabled"/>.</em></p><p>Enables sending session affinity cookies.</p></summary>
        [Pure]
        public static AzureWebappUpdateSettings ResetClientAffinityEnabled(this AzureWebappUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClientAffinityEnabled = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureWebappUpdateSettings.ClientAffinityEnabled"/>.</em></p><p>Enables sending session affinity cookies.</p></summary>
        [Pure]
        public static AzureWebappUpdateSettings EnableClientAffinityEnabled(this AzureWebappUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClientAffinityEnabled = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureWebappUpdateSettings.ClientAffinityEnabled"/>.</em></p><p>Enables sending session affinity cookies.</p></summary>
        [Pure]
        public static AzureWebappUpdateSettings DisableClientAffinityEnabled(this AzureWebappUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClientAffinityEnabled = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureWebappUpdateSettings.ClientAffinityEnabled"/>.</em></p><p>Enables sending session affinity cookies.</p></summary>
        [Pure]
        public static AzureWebappUpdateSettings ToggleClientAffinityEnabled(this AzureWebappUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClientAffinityEnabled = !toolSettings.ClientAffinityEnabled;
            return toolSettings;
        }
        #endregion
        #region ForceDnsRegistration
        /// <summary><p><em>Sets <see cref="AzureWebappUpdateSettings.ForceDnsRegistration"/>.</em></p><p>If true, web app hostname is force registered with DNS.</p></summary>
        [Pure]
        public static AzureWebappUpdateSettings SetForceDnsRegistration(this AzureWebappUpdateSettings toolSettings, bool? forceDnsRegistration)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceDnsRegistration = forceDnsRegistration;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappUpdateSettings.ForceDnsRegistration"/>.</em></p><p>If true, web app hostname is force registered with DNS.</p></summary>
        [Pure]
        public static AzureWebappUpdateSettings ResetForceDnsRegistration(this AzureWebappUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceDnsRegistration = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureWebappUpdateSettings.ForceDnsRegistration"/>.</em></p><p>If true, web app hostname is force registered with DNS.</p></summary>
        [Pure]
        public static AzureWebappUpdateSettings EnableForceDnsRegistration(this AzureWebappUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceDnsRegistration = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureWebappUpdateSettings.ForceDnsRegistration"/>.</em></p><p>If true, web app hostname is force registered with DNS.</p></summary>
        [Pure]
        public static AzureWebappUpdateSettings DisableForceDnsRegistration(this AzureWebappUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceDnsRegistration = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureWebappUpdateSettings.ForceDnsRegistration"/>.</em></p><p>If true, web app hostname is force registered with DNS.</p></summary>
        [Pure]
        public static AzureWebappUpdateSettings ToggleForceDnsRegistration(this AzureWebappUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceDnsRegistration = !toolSettings.ForceDnsRegistration;
            return toolSettings;
        }
        #endregion
        #region HttpsOnly
        /// <summary><p><em>Sets <see cref="AzureWebappUpdateSettings.HttpsOnly"/>.</em></p><p>Redirect all traffic made to an app using HTTP to HTTPS.</p></summary>
        [Pure]
        public static AzureWebappUpdateSettings SetHttpsOnly(this AzureWebappUpdateSettings toolSettings, bool? httpsOnly)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HttpsOnly = httpsOnly;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappUpdateSettings.HttpsOnly"/>.</em></p><p>Redirect all traffic made to an app using HTTP to HTTPS.</p></summary>
        [Pure]
        public static AzureWebappUpdateSettings ResetHttpsOnly(this AzureWebappUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HttpsOnly = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureWebappUpdateSettings.HttpsOnly"/>.</em></p><p>Redirect all traffic made to an app using HTTP to HTTPS.</p></summary>
        [Pure]
        public static AzureWebappUpdateSettings EnableHttpsOnly(this AzureWebappUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HttpsOnly = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureWebappUpdateSettings.HttpsOnly"/>.</em></p><p>Redirect all traffic made to an app using HTTP to HTTPS.</p></summary>
        [Pure]
        public static AzureWebappUpdateSettings DisableHttpsOnly(this AzureWebappUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HttpsOnly = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureWebappUpdateSettings.HttpsOnly"/>.</em></p><p>Redirect all traffic made to an app using HTTP to HTTPS.</p></summary>
        [Pure]
        public static AzureWebappUpdateSettings ToggleHttpsOnly(this AzureWebappUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HttpsOnly = !toolSettings.HttpsOnly;
            return toolSettings;
        }
        #endregion
        #region SkipCustomDomainVerification
        /// <summary><p><em>Sets <see cref="AzureWebappUpdateSettings.SkipCustomDomainVerification"/>.</em></p><p>If true, custom (non *.azurewebsites.net) domains associated with web app are not verified.</p></summary>
        [Pure]
        public static AzureWebappUpdateSettings SetSkipCustomDomainVerification(this AzureWebappUpdateSettings toolSettings, bool? skipCustomDomainVerification)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkipCustomDomainVerification = skipCustomDomainVerification;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappUpdateSettings.SkipCustomDomainVerification"/>.</em></p><p>If true, custom (non *.azurewebsites.net) domains associated with web app are not verified.</p></summary>
        [Pure]
        public static AzureWebappUpdateSettings ResetSkipCustomDomainVerification(this AzureWebappUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkipCustomDomainVerification = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureWebappUpdateSettings.SkipCustomDomainVerification"/>.</em></p><p>If true, custom (non *.azurewebsites.net) domains associated with web app are not verified.</p></summary>
        [Pure]
        public static AzureWebappUpdateSettings EnableSkipCustomDomainVerification(this AzureWebappUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkipCustomDomainVerification = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureWebappUpdateSettings.SkipCustomDomainVerification"/>.</em></p><p>If true, custom (non *.azurewebsites.net) domains associated with web app are not verified.</p></summary>
        [Pure]
        public static AzureWebappUpdateSettings DisableSkipCustomDomainVerification(this AzureWebappUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkipCustomDomainVerification = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureWebappUpdateSettings.SkipCustomDomainVerification"/>.</em></p><p>If true, custom (non *.azurewebsites.net) domains associated with web app are not verified.</p></summary>
        [Pure]
        public static AzureWebappUpdateSettings ToggleSkipCustomDomainVerification(this AzureWebappUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkipCustomDomainVerification = !toolSettings.SkipCustomDomainVerification;
            return toolSettings;
        }
        #endregion
        #region SkipDnsRegistration
        /// <summary><p><em>Sets <see cref="AzureWebappUpdateSettings.SkipDnsRegistration"/>.</em></p><p>If true web app hostname is not registered with DNS on creation.</p></summary>
        [Pure]
        public static AzureWebappUpdateSettings SetSkipDnsRegistration(this AzureWebappUpdateSettings toolSettings, bool? skipDnsRegistration)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkipDnsRegistration = skipDnsRegistration;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappUpdateSettings.SkipDnsRegistration"/>.</em></p><p>If true web app hostname is not registered with DNS on creation.</p></summary>
        [Pure]
        public static AzureWebappUpdateSettings ResetSkipDnsRegistration(this AzureWebappUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkipDnsRegistration = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureWebappUpdateSettings.SkipDnsRegistration"/>.</em></p><p>If true web app hostname is not registered with DNS on creation.</p></summary>
        [Pure]
        public static AzureWebappUpdateSettings EnableSkipDnsRegistration(this AzureWebappUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkipDnsRegistration = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureWebappUpdateSettings.SkipDnsRegistration"/>.</em></p><p>If true web app hostname is not registered with DNS on creation.</p></summary>
        [Pure]
        public static AzureWebappUpdateSettings DisableSkipDnsRegistration(this AzureWebappUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkipDnsRegistration = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureWebappUpdateSettings.SkipDnsRegistration"/>.</em></p><p>If true web app hostname is not registered with DNS on creation.</p></summary>
        [Pure]
        public static AzureWebappUpdateSettings ToggleSkipDnsRegistration(this AzureWebappUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkipDnsRegistration = !toolSettings.SkipDnsRegistration;
            return toolSettings;
        }
        #endregion
        #region Slot
        /// <summary><p><em>Sets <see cref="AzureWebappUpdateSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappUpdateSettings SetSlot(this AzureWebappUpdateSettings toolSettings, string slot)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = slot;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappUpdateSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappUpdateSettings ResetSlot(this AzureWebappUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = null;
            return toolSettings;
        }
        #endregion
        #region TtlInSeconds
        /// <summary><p><em>Sets <see cref="AzureWebappUpdateSettings.TtlInSeconds"/>.</em></p><p>Time to live in seconds for web app's default domain name.</p></summary>
        [Pure]
        public static AzureWebappUpdateSettings SetTtlInSeconds(this AzureWebappUpdateSettings toolSettings, bool? ttlInSeconds)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TtlInSeconds = ttlInSeconds;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappUpdateSettings.TtlInSeconds"/>.</em></p><p>Time to live in seconds for web app's default domain name.</p></summary>
        [Pure]
        public static AzureWebappUpdateSettings ResetTtlInSeconds(this AzureWebappUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TtlInSeconds = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureWebappUpdateSettings.TtlInSeconds"/>.</em></p><p>Time to live in seconds for web app's default domain name.</p></summary>
        [Pure]
        public static AzureWebappUpdateSettings EnableTtlInSeconds(this AzureWebappUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TtlInSeconds = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureWebappUpdateSettings.TtlInSeconds"/>.</em></p><p>Time to live in seconds for web app's default domain name.</p></summary>
        [Pure]
        public static AzureWebappUpdateSettings DisableTtlInSeconds(this AzureWebappUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TtlInSeconds = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureWebappUpdateSettings.TtlInSeconds"/>.</em></p><p>Time to live in seconds for web app's default domain name.</p></summary>
        [Pure]
        public static AzureWebappUpdateSettings ToggleTtlInSeconds(this AzureWebappUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TtlInSeconds = !toolSettings.TtlInSeconds;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary><p><em>Sets <see cref="AzureWebappUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureWebappUpdateSettings SetAdd(this AzureWebappUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureWebappUpdateSettings ResetAdd(this AzureWebappUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary><p><em>Sets <see cref="AzureWebappUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureWebappUpdateSettings SetRemove(this AzureWebappUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureWebappUpdateSettings ResetRemove(this AzureWebappUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary><p><em>Sets <see cref="AzureWebappUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureWebappUpdateSettings SetSet(this AzureWebappUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureWebappUpdateSettings ResetSet(this AzureWebappUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureWebappUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappUpdateSettings SetDebug(this AzureWebappUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappUpdateSettings ResetDebug(this AzureWebappUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureWebappUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappUpdateSettings SetHelp(this AzureWebappUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappUpdateSettings ResetHelp(this AzureWebappUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureWebappUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappUpdateSettings SetOutput(this AzureWebappUpdateSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappUpdateSettings ResetOutput(this AzureWebappUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureWebappUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappUpdateSettings SetQuery(this AzureWebappUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappUpdateSettings ResetQuery(this AzureWebappUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureWebappUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappUpdateSettings SetVerbose(this AzureWebappUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappUpdateSettings ResetVerbose(this AzureWebappUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureWebappAuthShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureWebappAuthShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureWebappAuthShowSettings.Name"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappAuthShowSettings SetName(this AzureWebappAuthShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappAuthShowSettings.Name"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappAuthShowSettings ResetName(this AzureWebappAuthShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureWebappAuthShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappAuthShowSettings SetResourceGroup(this AzureWebappAuthShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappAuthShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappAuthShowSettings ResetResourceGroup(this AzureWebappAuthShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Slot
        /// <summary><p><em>Sets <see cref="AzureWebappAuthShowSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappAuthShowSettings SetSlot(this AzureWebappAuthShowSettings toolSettings, string slot)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = slot;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappAuthShowSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappAuthShowSettings ResetSlot(this AzureWebappAuthShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureWebappAuthShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappAuthShowSettings SetDebug(this AzureWebappAuthShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappAuthShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappAuthShowSettings ResetDebug(this AzureWebappAuthShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureWebappAuthShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappAuthShowSettings SetHelp(this AzureWebappAuthShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappAuthShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappAuthShowSettings ResetHelp(this AzureWebappAuthShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureWebappAuthShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappAuthShowSettings SetOutput(this AzureWebappAuthShowSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappAuthShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappAuthShowSettings ResetOutput(this AzureWebappAuthShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureWebappAuthShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappAuthShowSettings SetQuery(this AzureWebappAuthShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappAuthShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappAuthShowSettings ResetQuery(this AzureWebappAuthShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureWebappAuthShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappAuthShowSettings SetVerbose(this AzureWebappAuthShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappAuthShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappAuthShowSettings ResetVerbose(this AzureWebappAuthShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureWebappAuthUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureWebappAuthUpdateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureWebappAuthUpdateSettings.Name"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappAuthUpdateSettings SetName(this AzureWebappAuthUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappAuthUpdateSettings.Name"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappAuthUpdateSettings ResetName(this AzureWebappAuthUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureWebappAuthUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappAuthUpdateSettings SetResourceGroup(this AzureWebappAuthUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappAuthUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappAuthUpdateSettings ResetResourceGroup(this AzureWebappAuthUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Action
        /// <summary><p><em>Sets <see cref="AzureWebappAuthUpdateSettings.Action"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureWebappAuthUpdateSettings SetAction(this AzureWebappAuthUpdateSettings toolSettings, WebappAuthUpdateAction action)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Action = action;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappAuthUpdateSettings.Action"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureWebappAuthUpdateSettings ResetAction(this AzureWebappAuthUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Action = null;
            return toolSettings;
        }
        #endregion
        #region AllowedExternalRedirectUrls
        /// <summary><p><em>Sets <see cref="AzureWebappAuthUpdateSettings.AllowedExternalRedirectUrls"/>.</em></p><p>One or more urls (space-delimited).</p></summary>
        [Pure]
        public static AzureWebappAuthUpdateSettings SetAllowedExternalRedirectUrls(this AzureWebappAuthUpdateSettings toolSettings, string allowedExternalRedirectUrls)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AllowedExternalRedirectUrls = allowedExternalRedirectUrls;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappAuthUpdateSettings.AllowedExternalRedirectUrls"/>.</em></p><p>One or more urls (space-delimited).</p></summary>
        [Pure]
        public static AzureWebappAuthUpdateSettings ResetAllowedExternalRedirectUrls(this AzureWebappAuthUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AllowedExternalRedirectUrls = null;
            return toolSettings;
        }
        #endregion
        #region Enabled
        /// <summary><p><em>Sets <see cref="AzureWebappAuthUpdateSettings.Enabled"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureWebappAuthUpdateSettings SetEnabled(this AzureWebappAuthUpdateSettings toolSettings, bool? enabled)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Enabled = enabled;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappAuthUpdateSettings.Enabled"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureWebappAuthUpdateSettings ResetEnabled(this AzureWebappAuthUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Enabled = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureWebappAuthUpdateSettings.Enabled"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureWebappAuthUpdateSettings EnableEnabled(this AzureWebappAuthUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Enabled = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureWebappAuthUpdateSettings.Enabled"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureWebappAuthUpdateSettings DisableEnabled(this AzureWebappAuthUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Enabled = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureWebappAuthUpdateSettings.Enabled"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureWebappAuthUpdateSettings ToggleEnabled(this AzureWebappAuthUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Enabled = !toolSettings.Enabled;
            return toolSettings;
        }
        #endregion
        #region Slot
        /// <summary><p><em>Sets <see cref="AzureWebappAuthUpdateSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappAuthUpdateSettings SetSlot(this AzureWebappAuthUpdateSettings toolSettings, string slot)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = slot;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappAuthUpdateSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappAuthUpdateSettings ResetSlot(this AzureWebappAuthUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = null;
            return toolSettings;
        }
        #endregion
        #region TokenRefreshExtensionHours
        /// <summary><p><em>Sets <see cref="AzureWebappAuthUpdateSettings.TokenRefreshExtensionHours"/>.</em></p><p>Hours, must be formattable into a float.</p></summary>
        [Pure]
        public static AzureWebappAuthUpdateSettings SetTokenRefreshExtensionHours(this AzureWebappAuthUpdateSettings toolSettings, string tokenRefreshExtensionHours)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TokenRefreshExtensionHours = tokenRefreshExtensionHours;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappAuthUpdateSettings.TokenRefreshExtensionHours"/>.</em></p><p>Hours, must be formattable into a float.</p></summary>
        [Pure]
        public static AzureWebappAuthUpdateSettings ResetTokenRefreshExtensionHours(this AzureWebappAuthUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TokenRefreshExtensionHours = null;
            return toolSettings;
        }
        #endregion
        #region TokenStore
        /// <summary><p><em>Sets <see cref="AzureWebappAuthUpdateSettings.TokenStore"/>.</em></p><p>Use App Service Token Store.</p></summary>
        [Pure]
        public static AzureWebappAuthUpdateSettings SetTokenStore(this AzureWebappAuthUpdateSettings toolSettings, bool? tokenStore)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TokenStore = tokenStore;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappAuthUpdateSettings.TokenStore"/>.</em></p><p>Use App Service Token Store.</p></summary>
        [Pure]
        public static AzureWebappAuthUpdateSettings ResetTokenStore(this AzureWebappAuthUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TokenStore = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureWebappAuthUpdateSettings.TokenStore"/>.</em></p><p>Use App Service Token Store.</p></summary>
        [Pure]
        public static AzureWebappAuthUpdateSettings EnableTokenStore(this AzureWebappAuthUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TokenStore = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureWebappAuthUpdateSettings.TokenStore"/>.</em></p><p>Use App Service Token Store.</p></summary>
        [Pure]
        public static AzureWebappAuthUpdateSettings DisableTokenStore(this AzureWebappAuthUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TokenStore = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureWebappAuthUpdateSettings.TokenStore"/>.</em></p><p>Use App Service Token Store.</p></summary>
        [Pure]
        public static AzureWebappAuthUpdateSettings ToggleTokenStore(this AzureWebappAuthUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TokenStore = !toolSettings.TokenStore;
            return toolSettings;
        }
        #endregion
        #region AadAllowedTokenAudiences
        /// <summary><p><em>Sets <see cref="AzureWebappAuthUpdateSettings.AadAllowedTokenAudiences"/>.</em></p><p>One or more token audiences (space-delimited).</p></summary>
        [Pure]
        public static AzureWebappAuthUpdateSettings SetAadAllowedTokenAudiences(this AzureWebappAuthUpdateSettings toolSettings, string aadAllowedTokenAudiences)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AadAllowedTokenAudiences = aadAllowedTokenAudiences;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappAuthUpdateSettings.AadAllowedTokenAudiences"/>.</em></p><p>One or more token audiences (space-delimited).</p></summary>
        [Pure]
        public static AzureWebappAuthUpdateSettings ResetAadAllowedTokenAudiences(this AzureWebappAuthUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AadAllowedTokenAudiences = null;
            return toolSettings;
        }
        #endregion
        #region AadClientId
        /// <summary><p><em>Sets <see cref="AzureWebappAuthUpdateSettings.AadClientId"/>.</em></p><p>Application ID to integrate AAD organization account Sign-in into your web app.</p></summary>
        [Pure]
        public static AzureWebappAuthUpdateSettings SetAadClientId(this AzureWebappAuthUpdateSettings toolSettings, string aadClientId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AadClientId = aadClientId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappAuthUpdateSettings.AadClientId"/>.</em></p><p>Application ID to integrate AAD organization account Sign-in into your web app.</p></summary>
        [Pure]
        public static AzureWebappAuthUpdateSettings ResetAadClientId(this AzureWebappAuthUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AadClientId = null;
            return toolSettings;
        }
        #endregion
        #region AadClientSecret
        /// <summary><p><em>Sets <see cref="AzureWebappAuthUpdateSettings.AadClientSecret"/>.</em></p><p>AAD application secret.</p></summary>
        [Pure]
        public static AzureWebappAuthUpdateSettings SetAadClientSecret(this AzureWebappAuthUpdateSettings toolSettings, string aadClientSecret)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AadClientSecret = aadClientSecret;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappAuthUpdateSettings.AadClientSecret"/>.</em></p><p>AAD application secret.</p></summary>
        [Pure]
        public static AzureWebappAuthUpdateSettings ResetAadClientSecret(this AzureWebappAuthUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AadClientSecret = null;
            return toolSettings;
        }
        #endregion
        #region AadTokenIssuerUrl
        /// <summary><p><em>Sets <see cref="AzureWebappAuthUpdateSettings.AadTokenIssuerUrl"/>.</em></p><p>This url can be found in the JSON output returned from your active directory endpoint using your tenantID. The endpoint can be queried from 'az cloud show' at "endpoints.activeDirectory". The tenantID can be found using 'az account show'. Get the "issuer" from the JSON at &lt;active directory endpoint&gt;/&lt;tenantId&gt;/.well-known/openid-configuration.</p></summary>
        [Pure]
        public static AzureWebappAuthUpdateSettings SetAadTokenIssuerUrl(this AzureWebappAuthUpdateSettings toolSettings, string aadTokenIssuerUrl)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AadTokenIssuerUrl = aadTokenIssuerUrl;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappAuthUpdateSettings.AadTokenIssuerUrl"/>.</em></p><p>This url can be found in the JSON output returned from your active directory endpoint using your tenantID. The endpoint can be queried from 'az cloud show' at "endpoints.activeDirectory". The tenantID can be found using 'az account show'. Get the "issuer" from the JSON at &lt;active directory endpoint&gt;/&lt;tenantId&gt;/.well-known/openid-configuration.</p></summary>
        [Pure]
        public static AzureWebappAuthUpdateSettings ResetAadTokenIssuerUrl(this AzureWebappAuthUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AadTokenIssuerUrl = null;
            return toolSettings;
        }
        #endregion
        #region FacebookAppId
        /// <summary><p><em>Sets <see cref="AzureWebappAuthUpdateSettings.FacebookAppId"/>.</em></p><p>Application ID to integrate Facebook Sign-in into your web app.</p></summary>
        [Pure]
        public static AzureWebappAuthUpdateSettings SetFacebookAppId(this AzureWebappAuthUpdateSettings toolSettings, string facebookAppId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FacebookAppId = facebookAppId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappAuthUpdateSettings.FacebookAppId"/>.</em></p><p>Application ID to integrate Facebook Sign-in into your web app.</p></summary>
        [Pure]
        public static AzureWebappAuthUpdateSettings ResetFacebookAppId(this AzureWebappAuthUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FacebookAppId = null;
            return toolSettings;
        }
        #endregion
        #region FacebookAppSecret
        /// <summary><p><em>Sets <see cref="AzureWebappAuthUpdateSettings.FacebookAppSecret"/>.</em></p><p>Facebook Application client secret.</p></summary>
        [Pure]
        public static AzureWebappAuthUpdateSettings SetFacebookAppSecret(this AzureWebappAuthUpdateSettings toolSettings, string facebookAppSecret)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FacebookAppSecret = facebookAppSecret;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappAuthUpdateSettings.FacebookAppSecret"/>.</em></p><p>Facebook Application client secret.</p></summary>
        [Pure]
        public static AzureWebappAuthUpdateSettings ResetFacebookAppSecret(this AzureWebappAuthUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FacebookAppSecret = null;
            return toolSettings;
        }
        #endregion
        #region FacebookOauthScopes
        /// <summary><p><em>Sets <see cref="AzureWebappAuthUpdateSettings.FacebookOauthScopes"/>.</em></p><p>One or more facebook authentication scopes (space-delimited).</p></summary>
        [Pure]
        public static AzureWebappAuthUpdateSettings SetFacebookOauthScopes(this AzureWebappAuthUpdateSettings toolSettings, string facebookOauthScopes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FacebookOauthScopes = facebookOauthScopes;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappAuthUpdateSettings.FacebookOauthScopes"/>.</em></p><p>One or more facebook authentication scopes (space-delimited).</p></summary>
        [Pure]
        public static AzureWebappAuthUpdateSettings ResetFacebookOauthScopes(this AzureWebappAuthUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FacebookOauthScopes = null;
            return toolSettings;
        }
        #endregion
        #region GoogleClientId
        /// <summary><p><em>Sets <see cref="AzureWebappAuthUpdateSettings.GoogleClientId"/>.</em></p><p>Application ID to integrate Google Sign-in into your web app.</p></summary>
        [Pure]
        public static AzureWebappAuthUpdateSettings SetGoogleClientId(this AzureWebappAuthUpdateSettings toolSettings, string googleClientId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GoogleClientId = googleClientId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappAuthUpdateSettings.GoogleClientId"/>.</em></p><p>Application ID to integrate Google Sign-in into your web app.</p></summary>
        [Pure]
        public static AzureWebappAuthUpdateSettings ResetGoogleClientId(this AzureWebappAuthUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GoogleClientId = null;
            return toolSettings;
        }
        #endregion
        #region GoogleClientSecret
        /// <summary><p><em>Sets <see cref="AzureWebappAuthUpdateSettings.GoogleClientSecret"/>.</em></p><p>Google Application client secret.</p></summary>
        [Pure]
        public static AzureWebappAuthUpdateSettings SetGoogleClientSecret(this AzureWebappAuthUpdateSettings toolSettings, string googleClientSecret)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GoogleClientSecret = googleClientSecret;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappAuthUpdateSettings.GoogleClientSecret"/>.</em></p><p>Google Application client secret.</p></summary>
        [Pure]
        public static AzureWebappAuthUpdateSettings ResetGoogleClientSecret(this AzureWebappAuthUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GoogleClientSecret = null;
            return toolSettings;
        }
        #endregion
        #region GoogleOauthScopes
        /// <summary><p><em>Sets <see cref="AzureWebappAuthUpdateSettings.GoogleOauthScopes"/>.</em></p><p>One or more Google authentication scopes (space-delimited).</p></summary>
        [Pure]
        public static AzureWebappAuthUpdateSettings SetGoogleOauthScopes(this AzureWebappAuthUpdateSettings toolSettings, string googleOauthScopes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GoogleOauthScopes = googleOauthScopes;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappAuthUpdateSettings.GoogleOauthScopes"/>.</em></p><p>One or more Google authentication scopes (space-delimited).</p></summary>
        [Pure]
        public static AzureWebappAuthUpdateSettings ResetGoogleOauthScopes(this AzureWebappAuthUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GoogleOauthScopes = null;
            return toolSettings;
        }
        #endregion
        #region MicrosoftAccountClientId
        /// <summary><p><em>Sets <see cref="AzureWebappAuthUpdateSettings.MicrosoftAccountClientId"/>.</em></p><p>AAD V2 Application ID to integrate Microsoft account Sign-in into your web app.</p></summary>
        [Pure]
        public static AzureWebappAuthUpdateSettings SetMicrosoftAccountClientId(this AzureWebappAuthUpdateSettings toolSettings, string microsoftAccountClientId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MicrosoftAccountClientId = microsoftAccountClientId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappAuthUpdateSettings.MicrosoftAccountClientId"/>.</em></p><p>AAD V2 Application ID to integrate Microsoft account Sign-in into your web app.</p></summary>
        [Pure]
        public static AzureWebappAuthUpdateSettings ResetMicrosoftAccountClientId(this AzureWebappAuthUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MicrosoftAccountClientId = null;
            return toolSettings;
        }
        #endregion
        #region MicrosoftAccountClientSecret
        /// <summary><p><em>Sets <see cref="AzureWebappAuthUpdateSettings.MicrosoftAccountClientSecret"/>.</em></p><p>AAD V2 Application client secret.</p></summary>
        [Pure]
        public static AzureWebappAuthUpdateSettings SetMicrosoftAccountClientSecret(this AzureWebappAuthUpdateSettings toolSettings, string microsoftAccountClientSecret)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MicrosoftAccountClientSecret = microsoftAccountClientSecret;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappAuthUpdateSettings.MicrosoftAccountClientSecret"/>.</em></p><p>AAD V2 Application client secret.</p></summary>
        [Pure]
        public static AzureWebappAuthUpdateSettings ResetMicrosoftAccountClientSecret(this AzureWebappAuthUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MicrosoftAccountClientSecret = null;
            return toolSettings;
        }
        #endregion
        #region MicrosoftAccountOauthScopes
        /// <summary><p><em>Sets <see cref="AzureWebappAuthUpdateSettings.MicrosoftAccountOauthScopes"/>.</em></p><p>One or more Microsoft authentification scopes (space-delimited).</p></summary>
        [Pure]
        public static AzureWebappAuthUpdateSettings SetMicrosoftAccountOauthScopes(this AzureWebappAuthUpdateSettings toolSettings, string microsoftAccountOauthScopes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MicrosoftAccountOauthScopes = microsoftAccountOauthScopes;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappAuthUpdateSettings.MicrosoftAccountOauthScopes"/>.</em></p><p>One or more Microsoft authentification scopes (space-delimited).</p></summary>
        [Pure]
        public static AzureWebappAuthUpdateSettings ResetMicrosoftAccountOauthScopes(this AzureWebappAuthUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MicrosoftAccountOauthScopes = null;
            return toolSettings;
        }
        #endregion
        #region TwitterConsumerKey
        /// <summary><p><em>Sets <see cref="AzureWebappAuthUpdateSettings.TwitterConsumerKey"/>.</em></p><p>Application ID to integrate Twitter Sign-in into your web app.</p></summary>
        [Pure]
        public static AzureWebappAuthUpdateSettings SetTwitterConsumerKey(this AzureWebappAuthUpdateSettings toolSettings, string twitterConsumerKey)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TwitterConsumerKey = twitterConsumerKey;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappAuthUpdateSettings.TwitterConsumerKey"/>.</em></p><p>Application ID to integrate Twitter Sign-in into your web app.</p></summary>
        [Pure]
        public static AzureWebappAuthUpdateSettings ResetTwitterConsumerKey(this AzureWebappAuthUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TwitterConsumerKey = null;
            return toolSettings;
        }
        #endregion
        #region TwitterConsumerSecret
        /// <summary><p><em>Sets <see cref="AzureWebappAuthUpdateSettings.TwitterConsumerSecret"/>.</em></p><p>Twitter Application client secret.</p></summary>
        [Pure]
        public static AzureWebappAuthUpdateSettings SetTwitterConsumerSecret(this AzureWebappAuthUpdateSettings toolSettings, string twitterConsumerSecret)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TwitterConsumerSecret = twitterConsumerSecret;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappAuthUpdateSettings.TwitterConsumerSecret"/>.</em></p><p>Twitter Application client secret.</p></summary>
        [Pure]
        public static AzureWebappAuthUpdateSettings ResetTwitterConsumerSecret(this AzureWebappAuthUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TwitterConsumerSecret = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureWebappAuthUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappAuthUpdateSettings SetDebug(this AzureWebappAuthUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappAuthUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappAuthUpdateSettings ResetDebug(this AzureWebappAuthUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureWebappAuthUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappAuthUpdateSettings SetHelp(this AzureWebappAuthUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappAuthUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappAuthUpdateSettings ResetHelp(this AzureWebappAuthUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureWebappAuthUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappAuthUpdateSettings SetOutput(this AzureWebappAuthUpdateSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappAuthUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappAuthUpdateSettings ResetOutput(this AzureWebappAuthUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureWebappAuthUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappAuthUpdateSettings SetQuery(this AzureWebappAuthUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappAuthUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappAuthUpdateSettings ResetQuery(this AzureWebappAuthUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureWebappAuthUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappAuthUpdateSettings SetVerbose(this AzureWebappAuthUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappAuthUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappAuthUpdateSettings ResetVerbose(this AzureWebappAuthUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureWebappConfigSetSettingsExtensions
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureWebappConfigSetSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureWebappConfigSetSettings.Name"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappConfigSetSettings SetName(this AzureWebappConfigSetSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigSetSettings.Name"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappConfigSetSettings ResetName(this AzureWebappConfigSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureWebappConfigSetSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappConfigSetSettings SetResourceGroup(this AzureWebappConfigSetSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigSetSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappConfigSetSettings ResetResourceGroup(this AzureWebappConfigSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region AlwaysOn
        /// <summary><p><em>Sets <see cref="AzureWebappConfigSetSettings.AlwaysOn"/>.</em></p><p>Ensure webapp gets loaded all the time, rather unloaded after been idle. Recommended when you have continuous web jobs running.</p></summary>
        [Pure]
        public static AzureWebappConfigSetSettings SetAlwaysOn(this AzureWebappConfigSetSettings toolSettings, bool? alwaysOn)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AlwaysOn = alwaysOn;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigSetSettings.AlwaysOn"/>.</em></p><p>Ensure webapp gets loaded all the time, rather unloaded after been idle. Recommended when you have continuous web jobs running.</p></summary>
        [Pure]
        public static AzureWebappConfigSetSettings ResetAlwaysOn(this AzureWebappConfigSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AlwaysOn = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureWebappConfigSetSettings.AlwaysOn"/>.</em></p><p>Ensure webapp gets loaded all the time, rather unloaded after been idle. Recommended when you have continuous web jobs running.</p></summary>
        [Pure]
        public static AzureWebappConfigSetSettings EnableAlwaysOn(this AzureWebappConfigSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AlwaysOn = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureWebappConfigSetSettings.AlwaysOn"/>.</em></p><p>Ensure webapp gets loaded all the time, rather unloaded after been idle. Recommended when you have continuous web jobs running.</p></summary>
        [Pure]
        public static AzureWebappConfigSetSettings DisableAlwaysOn(this AzureWebappConfigSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AlwaysOn = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureWebappConfigSetSettings.AlwaysOn"/>.</em></p><p>Ensure webapp gets loaded all the time, rather unloaded after been idle. Recommended when you have continuous web jobs running.</p></summary>
        [Pure]
        public static AzureWebappConfigSetSettings ToggleAlwaysOn(this AzureWebappConfigSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AlwaysOn = !toolSettings.AlwaysOn;
            return toolSettings;
        }
        #endregion
        #region AutoHealEnabled
        /// <summary><p><em>Sets <see cref="AzureWebappConfigSetSettings.AutoHealEnabled"/>.</em></p><p>Enable or disable auto heal.</p></summary>
        [Pure]
        public static AzureWebappConfigSetSettings SetAutoHealEnabled(this AzureWebappConfigSetSettings toolSettings, bool? autoHealEnabled)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AutoHealEnabled = autoHealEnabled;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigSetSettings.AutoHealEnabled"/>.</em></p><p>Enable or disable auto heal.</p></summary>
        [Pure]
        public static AzureWebappConfigSetSettings ResetAutoHealEnabled(this AzureWebappConfigSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AutoHealEnabled = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureWebappConfigSetSettings.AutoHealEnabled"/>.</em></p><p>Enable or disable auto heal.</p></summary>
        [Pure]
        public static AzureWebappConfigSetSettings EnableAutoHealEnabled(this AzureWebappConfigSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AutoHealEnabled = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureWebappConfigSetSettings.AutoHealEnabled"/>.</em></p><p>Enable or disable auto heal.</p></summary>
        [Pure]
        public static AzureWebappConfigSetSettings DisableAutoHealEnabled(this AzureWebappConfigSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AutoHealEnabled = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureWebappConfigSetSettings.AutoHealEnabled"/>.</em></p><p>Enable or disable auto heal.</p></summary>
        [Pure]
        public static AzureWebappConfigSetSettings ToggleAutoHealEnabled(this AzureWebappConfigSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AutoHealEnabled = !toolSettings.AutoHealEnabled;
            return toolSettings;
        }
        #endregion
        #region Http20Enabled
        /// <summary><p><em>Sets <see cref="AzureWebappConfigSetSettings.Http20Enabled"/>.</em></p><p>Configures a web site to allow clients to connect over http2.0.</p></summary>
        [Pure]
        public static AzureWebappConfigSetSettings SetHttp20Enabled(this AzureWebappConfigSetSettings toolSettings, bool? http20Enabled)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Http20Enabled = http20Enabled;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigSetSettings.Http20Enabled"/>.</em></p><p>Configures a web site to allow clients to connect over http2.0.</p></summary>
        [Pure]
        public static AzureWebappConfigSetSettings ResetHttp20Enabled(this AzureWebappConfigSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Http20Enabled = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureWebappConfigSetSettings.Http20Enabled"/>.</em></p><p>Configures a web site to allow clients to connect over http2.0.</p></summary>
        [Pure]
        public static AzureWebappConfigSetSettings EnableHttp20Enabled(this AzureWebappConfigSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Http20Enabled = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureWebappConfigSetSettings.Http20Enabled"/>.</em></p><p>Configures a web site to allow clients to connect over http2.0.</p></summary>
        [Pure]
        public static AzureWebappConfigSetSettings DisableHttp20Enabled(this AzureWebappConfigSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Http20Enabled = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureWebappConfigSetSettings.Http20Enabled"/>.</em></p><p>Configures a web site to allow clients to connect over http2.0.</p></summary>
        [Pure]
        public static AzureWebappConfigSetSettings ToggleHttp20Enabled(this AzureWebappConfigSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Http20Enabled = !toolSettings.Http20Enabled;
            return toolSettings;
        }
        #endregion
        #region JavaContainer
        /// <summary><p><em>Sets <see cref="AzureWebappConfigSetSettings.JavaContainer"/>.</em></p><p>The java container, e.g., Tomcat, Jetty.</p></summary>
        [Pure]
        public static AzureWebappConfigSetSettings SetJavaContainer(this AzureWebappConfigSetSettings toolSettings, string javaContainer)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.JavaContainer = javaContainer;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigSetSettings.JavaContainer"/>.</em></p><p>The java container, e.g., Tomcat, Jetty.</p></summary>
        [Pure]
        public static AzureWebappConfigSetSettings ResetJavaContainer(this AzureWebappConfigSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.JavaContainer = null;
            return toolSettings;
        }
        #endregion
        #region JavaContainerVersion
        /// <summary><p><em>Sets <see cref="AzureWebappConfigSetSettings.JavaContainerVersion"/>.</em></p><p>The version of the java container, e.g., '8.0.23' for Tomcat.</p></summary>
        [Pure]
        public static AzureWebappConfigSetSettings SetJavaContainerVersion(this AzureWebappConfigSetSettings toolSettings, string javaContainerVersion)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.JavaContainerVersion = javaContainerVersion;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigSetSettings.JavaContainerVersion"/>.</em></p><p>The version of the java container, e.g., '8.0.23' for Tomcat.</p></summary>
        [Pure]
        public static AzureWebappConfigSetSettings ResetJavaContainerVersion(this AzureWebappConfigSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.JavaContainerVersion = null;
            return toolSettings;
        }
        #endregion
        #region JavaVersion
        /// <summary><p><em>Sets <see cref="AzureWebappConfigSetSettings.JavaVersion"/>.</em></p><p>The version used to run your web app if using Java, e.g., '1.7' for Java 7, '1.8' for Java 8.</p></summary>
        [Pure]
        public static AzureWebappConfigSetSettings SetJavaVersion(this AzureWebappConfigSetSettings toolSettings, string javaVersion)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.JavaVersion = javaVersion;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigSetSettings.JavaVersion"/>.</em></p><p>The version used to run your web app if using Java, e.g., '1.7' for Java 7, '1.8' for Java 8.</p></summary>
        [Pure]
        public static AzureWebappConfigSetSettings ResetJavaVersion(this AzureWebappConfigSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.JavaVersion = null;
            return toolSettings;
        }
        #endregion
        #region LinuxFxVersion
        /// <summary><p><em>Sets <see cref="AzureWebappConfigSetSettings.LinuxFxVersion"/>.</em></p><p>The runtime stack used for your linux-based webapp, e.g., "RUBY|2.3", "NODE|6.6", "PHP|5.6", "DOTNETCORE|1.1.0". See &lt;a href="https://aka.ms/linux-stacks"&gt;https://aka.ms/linux-stacks&lt;/a&gt; for more info.</p></summary>
        [Pure]
        public static AzureWebappConfigSetSettings SetLinuxFxVersion(this AzureWebappConfigSetSettings toolSettings, string linuxFxVersion)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LinuxFxVersion = linuxFxVersion;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigSetSettings.LinuxFxVersion"/>.</em></p><p>The runtime stack used for your linux-based webapp, e.g., "RUBY|2.3", "NODE|6.6", "PHP|5.6", "DOTNETCORE|1.1.0". See &lt;a href="https://aka.ms/linux-stacks"&gt;https://aka.ms/linux-stacks&lt;/a&gt; for more info.</p></summary>
        [Pure]
        public static AzureWebappConfigSetSettings ResetLinuxFxVersion(this AzureWebappConfigSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LinuxFxVersion = null;
            return toolSettings;
        }
        #endregion
        #region MinTlsVersion
        /// <summary><p><em>Sets <see cref="AzureWebappConfigSetSettings.MinTlsVersion"/>.</em></p><p>The minimum version of TLS required for SSL requests, e.g., '1.0', '1.1', '1.2'.</p></summary>
        [Pure]
        public static AzureWebappConfigSetSettings SetMinTlsVersion(this AzureWebappConfigSetSettings toolSettings, string minTlsVersion)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MinTlsVersion = minTlsVersion;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigSetSettings.MinTlsVersion"/>.</em></p><p>The minimum version of TLS required for SSL requests, e.g., '1.0', '1.1', '1.2'.</p></summary>
        [Pure]
        public static AzureWebappConfigSetSettings ResetMinTlsVersion(this AzureWebappConfigSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MinTlsVersion = null;
            return toolSettings;
        }
        #endregion
        #region NetFrameworkVersion
        /// <summary><p><em>Sets <see cref="AzureWebappConfigSetSettings.NetFrameworkVersion"/>.</em></p><p>The version used to run your web app if using .NET Framework, e.g., 'v4.0' for .NET 4.6 and 'v3.0' for .NET 3.5.</p></summary>
        [Pure]
        public static AzureWebappConfigSetSettings SetNetFrameworkVersion(this AzureWebappConfigSetSettings toolSettings, string netFrameworkVersion)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NetFrameworkVersion = netFrameworkVersion;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigSetSettings.NetFrameworkVersion"/>.</em></p><p>The version used to run your web app if using .NET Framework, e.g., 'v4.0' for .NET 4.6 and 'v3.0' for .NET 3.5.</p></summary>
        [Pure]
        public static AzureWebappConfigSetSettings ResetNetFrameworkVersion(this AzureWebappConfigSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NetFrameworkVersion = null;
            return toolSettings;
        }
        #endregion
        #region PhpVersion
        /// <summary><p><em>Sets <see cref="AzureWebappConfigSetSettings.PhpVersion"/>.</em></p><p>The version used to run your web app if using PHP, e.g., 5.5, 5.6, 7.0.</p></summary>
        [Pure]
        public static AzureWebappConfigSetSettings SetPhpVersion(this AzureWebappConfigSetSettings toolSettings, string phpVersion)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PhpVersion = phpVersion;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigSetSettings.PhpVersion"/>.</em></p><p>The version used to run your web app if using PHP, e.g., 5.5, 5.6, 7.0.</p></summary>
        [Pure]
        public static AzureWebappConfigSetSettings ResetPhpVersion(this AzureWebappConfigSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PhpVersion = null;
            return toolSettings;
        }
        #endregion
        #region PythonVersion
        /// <summary><p><em>Sets <see cref="AzureWebappConfigSetSettings.PythonVersion"/>.</em></p><p>The version used to run your web app if using Python, e.g., 2.7, 3.4.</p></summary>
        [Pure]
        public static AzureWebappConfigSetSettings SetPythonVersion(this AzureWebappConfigSetSettings toolSettings, string pythonVersion)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PythonVersion = pythonVersion;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigSetSettings.PythonVersion"/>.</em></p><p>The version used to run your web app if using Python, e.g., 2.7, 3.4.</p></summary>
        [Pure]
        public static AzureWebappConfigSetSettings ResetPythonVersion(this AzureWebappConfigSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PythonVersion = null;
            return toolSettings;
        }
        #endregion
        #region RemoteDebuggingEnabled
        /// <summary><p><em>Sets <see cref="AzureWebappConfigSetSettings.RemoteDebuggingEnabled"/>.</em></p><p>Enable or disable remote debugging.</p></summary>
        [Pure]
        public static AzureWebappConfigSetSettings SetRemoteDebuggingEnabled(this AzureWebappConfigSetSettings toolSettings, bool? remoteDebuggingEnabled)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RemoteDebuggingEnabled = remoteDebuggingEnabled;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigSetSettings.RemoteDebuggingEnabled"/>.</em></p><p>Enable or disable remote debugging.</p></summary>
        [Pure]
        public static AzureWebappConfigSetSettings ResetRemoteDebuggingEnabled(this AzureWebappConfigSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RemoteDebuggingEnabled = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureWebappConfigSetSettings.RemoteDebuggingEnabled"/>.</em></p><p>Enable or disable remote debugging.</p></summary>
        [Pure]
        public static AzureWebappConfigSetSettings EnableRemoteDebuggingEnabled(this AzureWebappConfigSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RemoteDebuggingEnabled = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureWebappConfigSetSettings.RemoteDebuggingEnabled"/>.</em></p><p>Enable or disable remote debugging.</p></summary>
        [Pure]
        public static AzureWebappConfigSetSettings DisableRemoteDebuggingEnabled(this AzureWebappConfigSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RemoteDebuggingEnabled = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureWebappConfigSetSettings.RemoteDebuggingEnabled"/>.</em></p><p>Enable or disable remote debugging.</p></summary>
        [Pure]
        public static AzureWebappConfigSetSettings ToggleRemoteDebuggingEnabled(this AzureWebappConfigSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RemoteDebuggingEnabled = !toolSettings.RemoteDebuggingEnabled;
            return toolSettings;
        }
        #endregion
        #region Slot
        /// <summary><p><em>Sets <see cref="AzureWebappConfigSetSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappConfigSetSettings SetSlot(this AzureWebappConfigSetSettings toolSettings, string slot)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = slot;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigSetSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappConfigSetSettings ResetSlot(this AzureWebappConfigSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = null;
            return toolSettings;
        }
        #endregion
        #region StartupFile
        /// <summary><p><em>Sets <see cref="AzureWebappConfigSetSettings.StartupFile"/>.</em></p><p>The startup file for linux hosted web apps, e.g. 'process.json' for Node.js web.</p></summary>
        [Pure]
        public static AzureWebappConfigSetSettings SetStartupFile(this AzureWebappConfigSetSettings toolSettings, string startupFile)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartupFile = startupFile;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigSetSettings.StartupFile"/>.</em></p><p>The startup file for linux hosted web apps, e.g. 'process.json' for Node.js web.</p></summary>
        [Pure]
        public static AzureWebappConfigSetSettings ResetStartupFile(this AzureWebappConfigSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartupFile = null;
            return toolSettings;
        }
        #endregion
        #region Use32bitWorkerProcess
        /// <summary><p><em>Sets <see cref="AzureWebappConfigSetSettings.Use32bitWorkerProcess"/>.</em></p><p>Use 32 bits worker process or not.</p></summary>
        [Pure]
        public static AzureWebappConfigSetSettings SetUse32bitWorkerProcess(this AzureWebappConfigSetSettings toolSettings, bool? use32bitWorkerProcess)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Use32bitWorkerProcess = use32bitWorkerProcess;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigSetSettings.Use32bitWorkerProcess"/>.</em></p><p>Use 32 bits worker process or not.</p></summary>
        [Pure]
        public static AzureWebappConfigSetSettings ResetUse32bitWorkerProcess(this AzureWebappConfigSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Use32bitWorkerProcess = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureWebappConfigSetSettings.Use32bitWorkerProcess"/>.</em></p><p>Use 32 bits worker process or not.</p></summary>
        [Pure]
        public static AzureWebappConfigSetSettings EnableUse32bitWorkerProcess(this AzureWebappConfigSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Use32bitWorkerProcess = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureWebappConfigSetSettings.Use32bitWorkerProcess"/>.</em></p><p>Use 32 bits worker process or not.</p></summary>
        [Pure]
        public static AzureWebappConfigSetSettings DisableUse32bitWorkerProcess(this AzureWebappConfigSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Use32bitWorkerProcess = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureWebappConfigSetSettings.Use32bitWorkerProcess"/>.</em></p><p>Use 32 bits worker process or not.</p></summary>
        [Pure]
        public static AzureWebappConfigSetSettings ToggleUse32bitWorkerProcess(this AzureWebappConfigSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Use32bitWorkerProcess = !toolSettings.Use32bitWorkerProcess;
            return toolSettings;
        }
        #endregion
        #region WebSocketsEnabled
        /// <summary><p><em>Sets <see cref="AzureWebappConfigSetSettings.WebSocketsEnabled"/>.</em></p><p>Enable or disable web sockets.</p></summary>
        [Pure]
        public static AzureWebappConfigSetSettings SetWebSocketsEnabled(this AzureWebappConfigSetSettings toolSettings, bool? webSocketsEnabled)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WebSocketsEnabled = webSocketsEnabled;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigSetSettings.WebSocketsEnabled"/>.</em></p><p>Enable or disable web sockets.</p></summary>
        [Pure]
        public static AzureWebappConfigSetSettings ResetWebSocketsEnabled(this AzureWebappConfigSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WebSocketsEnabled = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureWebappConfigSetSettings.WebSocketsEnabled"/>.</em></p><p>Enable or disable web sockets.</p></summary>
        [Pure]
        public static AzureWebappConfigSetSettings EnableWebSocketsEnabled(this AzureWebappConfigSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WebSocketsEnabled = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureWebappConfigSetSettings.WebSocketsEnabled"/>.</em></p><p>Enable or disable web sockets.</p></summary>
        [Pure]
        public static AzureWebappConfigSetSettings DisableWebSocketsEnabled(this AzureWebappConfigSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WebSocketsEnabled = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureWebappConfigSetSettings.WebSocketsEnabled"/>.</em></p><p>Enable or disable web sockets.</p></summary>
        [Pure]
        public static AzureWebappConfigSetSettings ToggleWebSocketsEnabled(this AzureWebappConfigSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WebSocketsEnabled = !toolSettings.WebSocketsEnabled;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureWebappConfigSetSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigSetSettings SetDebug(this AzureWebappConfigSetSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigSetSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigSetSettings ResetDebug(this AzureWebappConfigSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureWebappConfigSetSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappConfigSetSettings SetHelp(this AzureWebappConfigSetSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigSetSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappConfigSetSettings ResetHelp(this AzureWebappConfigSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureWebappConfigSetSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappConfigSetSettings SetOutput(this AzureWebappConfigSetSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigSetSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappConfigSetSettings ResetOutput(this AzureWebappConfigSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureWebappConfigSetSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappConfigSetSettings SetQuery(this AzureWebappConfigSetSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigSetSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappConfigSetSettings ResetQuery(this AzureWebappConfigSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureWebappConfigSetSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigSetSettings SetVerbose(this AzureWebappConfigSetSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigSetSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigSetSettings ResetVerbose(this AzureWebappConfigSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureWebappConfigShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureWebappConfigShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureWebappConfigShowSettings.Name"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappConfigShowSettings SetName(this AzureWebappConfigShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigShowSettings.Name"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappConfigShowSettings ResetName(this AzureWebappConfigShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureWebappConfigShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappConfigShowSettings SetResourceGroup(this AzureWebappConfigShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappConfigShowSettings ResetResourceGroup(this AzureWebappConfigShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Slot
        /// <summary><p><em>Sets <see cref="AzureWebappConfigShowSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappConfigShowSettings SetSlot(this AzureWebappConfigShowSettings toolSettings, string slot)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = slot;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigShowSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappConfigShowSettings ResetSlot(this AzureWebappConfigShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureWebappConfigShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigShowSettings SetDebug(this AzureWebappConfigShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigShowSettings ResetDebug(this AzureWebappConfigShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureWebappConfigShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappConfigShowSettings SetHelp(this AzureWebappConfigShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappConfigShowSettings ResetHelp(this AzureWebappConfigShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureWebappConfigShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappConfigShowSettings SetOutput(this AzureWebappConfigShowSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappConfigShowSettings ResetOutput(this AzureWebappConfigShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureWebappConfigShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappConfigShowSettings SetQuery(this AzureWebappConfigShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappConfigShowSettings ResetQuery(this AzureWebappConfigShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureWebappConfigShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigShowSettings SetVerbose(this AzureWebappConfigShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigShowSettings ResetVerbose(this AzureWebappConfigShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureWebappDeploymentListPublishingProfilesSettingsExtensions
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureWebappDeploymentListPublishingProfilesSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentListPublishingProfilesSettings.Name"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappDeploymentListPublishingProfilesSettings SetName(this AzureWebappDeploymentListPublishingProfilesSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentListPublishingProfilesSettings.Name"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappDeploymentListPublishingProfilesSettings ResetName(this AzureWebappDeploymentListPublishingProfilesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentListPublishingProfilesSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappDeploymentListPublishingProfilesSettings SetResourceGroup(this AzureWebappDeploymentListPublishingProfilesSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentListPublishingProfilesSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappDeploymentListPublishingProfilesSettings ResetResourceGroup(this AzureWebappDeploymentListPublishingProfilesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Slot
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentListPublishingProfilesSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappDeploymentListPublishingProfilesSettings SetSlot(this AzureWebappDeploymentListPublishingProfilesSettings toolSettings, string slot)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = slot;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentListPublishingProfilesSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappDeploymentListPublishingProfilesSettings ResetSlot(this AzureWebappDeploymentListPublishingProfilesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentListPublishingProfilesSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappDeploymentListPublishingProfilesSettings SetDebug(this AzureWebappDeploymentListPublishingProfilesSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentListPublishingProfilesSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappDeploymentListPublishingProfilesSettings ResetDebug(this AzureWebappDeploymentListPublishingProfilesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentListPublishingProfilesSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappDeploymentListPublishingProfilesSettings SetHelp(this AzureWebappDeploymentListPublishingProfilesSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentListPublishingProfilesSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappDeploymentListPublishingProfilesSettings ResetHelp(this AzureWebappDeploymentListPublishingProfilesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentListPublishingProfilesSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappDeploymentListPublishingProfilesSettings SetOutput(this AzureWebappDeploymentListPublishingProfilesSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentListPublishingProfilesSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappDeploymentListPublishingProfilesSettings ResetOutput(this AzureWebappDeploymentListPublishingProfilesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentListPublishingProfilesSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappDeploymentListPublishingProfilesSettings SetQuery(this AzureWebappDeploymentListPublishingProfilesSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentListPublishingProfilesSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappDeploymentListPublishingProfilesSettings ResetQuery(this AzureWebappDeploymentListPublishingProfilesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentListPublishingProfilesSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappDeploymentListPublishingProfilesSettings SetVerbose(this AzureWebappDeploymentListPublishingProfilesSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentListPublishingProfilesSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappDeploymentListPublishingProfilesSettings ResetVerbose(this AzureWebappDeploymentListPublishingProfilesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureWebappIdentityAssignSettingsExtensions
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureWebappIdentityAssignSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureWebappIdentityAssignSettings.Name"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappIdentityAssignSettings SetName(this AzureWebappIdentityAssignSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappIdentityAssignSettings.Name"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappIdentityAssignSettings ResetName(this AzureWebappIdentityAssignSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureWebappIdentityAssignSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappIdentityAssignSettings SetResourceGroup(this AzureWebappIdentityAssignSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappIdentityAssignSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappIdentityAssignSettings ResetResourceGroup(this AzureWebappIdentityAssignSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region DisableMsi
        /// <summary><p><em>Sets <see cref="AzureWebappIdentityAssignSettings.DisableMsi"/>.</em></p><p>Disable the identity.</p></summary>
        [Pure]
        public static AzureWebappIdentityAssignSettings SetDisableMsi(this AzureWebappIdentityAssignSettings toolSettings, string disableMsi)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableMsi = disableMsi;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappIdentityAssignSettings.DisableMsi"/>.</em></p><p>Disable the identity.</p></summary>
        [Pure]
        public static AzureWebappIdentityAssignSettings ResetDisableMsi(this AzureWebappIdentityAssignSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableMsi = null;
            return toolSettings;
        }
        #endregion
        #region Role
        /// <summary><p><em>Sets <see cref="AzureWebappIdentityAssignSettings.Role"/>.</em></p><p>Role name or id the managed identity will be assigned.</p></summary>
        [Pure]
        public static AzureWebappIdentityAssignSettings SetRole(this AzureWebappIdentityAssignSettings toolSettings, string role)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Role = role;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappIdentityAssignSettings.Role"/>.</em></p><p>Role name or id the managed identity will be assigned.</p></summary>
        [Pure]
        public static AzureWebappIdentityAssignSettings ResetRole(this AzureWebappIdentityAssignSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Role = null;
            return toolSettings;
        }
        #endregion
        #region Scope
        /// <summary><p><em>Sets <see cref="AzureWebappIdentityAssignSettings.Scope"/>.</em></p><p>The scope the managed identity has access to.</p></summary>
        [Pure]
        public static AzureWebappIdentityAssignSettings SetScope(this AzureWebappIdentityAssignSettings toolSettings, string scope)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Scope = scope;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappIdentityAssignSettings.Scope"/>.</em></p><p>The scope the managed identity has access to.</p></summary>
        [Pure]
        public static AzureWebappIdentityAssignSettings ResetScope(this AzureWebappIdentityAssignSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Scope = null;
            return toolSettings;
        }
        #endregion
        #region Slot
        /// <summary><p><em>Sets <see cref="AzureWebappIdentityAssignSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappIdentityAssignSettings SetSlot(this AzureWebappIdentityAssignSettings toolSettings, string slot)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = slot;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappIdentityAssignSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappIdentityAssignSettings ResetSlot(this AzureWebappIdentityAssignSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureWebappIdentityAssignSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappIdentityAssignSettings SetDebug(this AzureWebappIdentityAssignSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappIdentityAssignSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappIdentityAssignSettings ResetDebug(this AzureWebappIdentityAssignSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureWebappIdentityAssignSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappIdentityAssignSettings SetHelp(this AzureWebappIdentityAssignSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappIdentityAssignSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappIdentityAssignSettings ResetHelp(this AzureWebappIdentityAssignSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureWebappIdentityAssignSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappIdentityAssignSettings SetOutput(this AzureWebappIdentityAssignSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappIdentityAssignSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappIdentityAssignSettings ResetOutput(this AzureWebappIdentityAssignSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureWebappIdentityAssignSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappIdentityAssignSettings SetQuery(this AzureWebappIdentityAssignSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappIdentityAssignSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappIdentityAssignSettings ResetQuery(this AzureWebappIdentityAssignSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureWebappIdentityAssignSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappIdentityAssignSettings SetVerbose(this AzureWebappIdentityAssignSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappIdentityAssignSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappIdentityAssignSettings ResetVerbose(this AzureWebappIdentityAssignSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureWebappIdentityShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureWebappIdentityShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureWebappIdentityShowSettings.Name"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappIdentityShowSettings SetName(this AzureWebappIdentityShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappIdentityShowSettings.Name"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappIdentityShowSettings ResetName(this AzureWebappIdentityShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureWebappIdentityShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappIdentityShowSettings SetResourceGroup(this AzureWebappIdentityShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappIdentityShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappIdentityShowSettings ResetResourceGroup(this AzureWebappIdentityShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Slot
        /// <summary><p><em>Sets <see cref="AzureWebappIdentityShowSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappIdentityShowSettings SetSlot(this AzureWebappIdentityShowSettings toolSettings, string slot)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = slot;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappIdentityShowSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappIdentityShowSettings ResetSlot(this AzureWebappIdentityShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureWebappIdentityShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappIdentityShowSettings SetDebug(this AzureWebappIdentityShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappIdentityShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappIdentityShowSettings ResetDebug(this AzureWebappIdentityShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureWebappIdentityShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappIdentityShowSettings SetHelp(this AzureWebappIdentityShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappIdentityShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappIdentityShowSettings ResetHelp(this AzureWebappIdentityShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureWebappIdentityShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappIdentityShowSettings SetOutput(this AzureWebappIdentityShowSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappIdentityShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappIdentityShowSettings ResetOutput(this AzureWebappIdentityShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureWebappIdentityShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappIdentityShowSettings SetQuery(this AzureWebappIdentityShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappIdentityShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappIdentityShowSettings ResetQuery(this AzureWebappIdentityShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureWebappIdentityShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappIdentityShowSettings SetVerbose(this AzureWebappIdentityShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappIdentityShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappIdentityShowSettings ResetVerbose(this AzureWebappIdentityShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureWebappLogConfigSettingsExtensions
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureWebappLogConfigSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureWebappLogConfigSettings.Name"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappLogConfigSettings SetName(this AzureWebappLogConfigSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappLogConfigSettings.Name"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappLogConfigSettings ResetName(this AzureWebappLogConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureWebappLogConfigSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappLogConfigSettings SetResourceGroup(this AzureWebappLogConfigSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappLogConfigSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappLogConfigSettings ResetResourceGroup(this AzureWebappLogConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ApplicationLogging
        /// <summary><p><em>Sets <see cref="AzureWebappLogConfigSettings.ApplicationLogging"/>.</em></p><p>Configure application logging to file system.</p></summary>
        [Pure]
        public static AzureWebappLogConfigSettings SetApplicationLogging(this AzureWebappLogConfigSettings toolSettings, bool? applicationLogging)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ApplicationLogging = applicationLogging;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappLogConfigSettings.ApplicationLogging"/>.</em></p><p>Configure application logging to file system.</p></summary>
        [Pure]
        public static AzureWebappLogConfigSettings ResetApplicationLogging(this AzureWebappLogConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ApplicationLogging = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureWebappLogConfigSettings.ApplicationLogging"/>.</em></p><p>Configure application logging to file system.</p></summary>
        [Pure]
        public static AzureWebappLogConfigSettings EnableApplicationLogging(this AzureWebappLogConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ApplicationLogging = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureWebappLogConfigSettings.ApplicationLogging"/>.</em></p><p>Configure application logging to file system.</p></summary>
        [Pure]
        public static AzureWebappLogConfigSettings DisableApplicationLogging(this AzureWebappLogConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ApplicationLogging = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureWebappLogConfigSettings.ApplicationLogging"/>.</em></p><p>Configure application logging to file system.</p></summary>
        [Pure]
        public static AzureWebappLogConfigSettings ToggleApplicationLogging(this AzureWebappLogConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ApplicationLogging = !toolSettings.ApplicationLogging;
            return toolSettings;
        }
        #endregion
        #region DetailedErrorMessages
        /// <summary><p><em>Sets <see cref="AzureWebappLogConfigSettings.DetailedErrorMessages"/>.</em></p><p>Configure detailed error messages.</p></summary>
        [Pure]
        public static AzureWebappLogConfigSettings SetDetailedErrorMessages(this AzureWebappLogConfigSettings toolSettings, bool? detailedErrorMessages)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DetailedErrorMessages = detailedErrorMessages;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappLogConfigSettings.DetailedErrorMessages"/>.</em></p><p>Configure detailed error messages.</p></summary>
        [Pure]
        public static AzureWebappLogConfigSettings ResetDetailedErrorMessages(this AzureWebappLogConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DetailedErrorMessages = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureWebappLogConfigSettings.DetailedErrorMessages"/>.</em></p><p>Configure detailed error messages.</p></summary>
        [Pure]
        public static AzureWebappLogConfigSettings EnableDetailedErrorMessages(this AzureWebappLogConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DetailedErrorMessages = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureWebappLogConfigSettings.DetailedErrorMessages"/>.</em></p><p>Configure detailed error messages.</p></summary>
        [Pure]
        public static AzureWebappLogConfigSettings DisableDetailedErrorMessages(this AzureWebappLogConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DetailedErrorMessages = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureWebappLogConfigSettings.DetailedErrorMessages"/>.</em></p><p>Configure detailed error messages.</p></summary>
        [Pure]
        public static AzureWebappLogConfigSettings ToggleDetailedErrorMessages(this AzureWebappLogConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DetailedErrorMessages = !toolSettings.DetailedErrorMessages;
            return toolSettings;
        }
        #endregion
        #region DockerContainerLogging
        /// <summary><p><em>Sets <see cref="AzureWebappLogConfigSettings.DockerContainerLogging"/>.</em></p><p>Configure gathering STDOUT and STDERR output from container.</p></summary>
        [Pure]
        public static AzureWebappLogConfigSettings SetDockerContainerLogging(this AzureWebappLogConfigSettings toolSettings, WebappLogConfigDockerContainerLogging dockerContainerLogging)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DockerContainerLogging = dockerContainerLogging;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappLogConfigSettings.DockerContainerLogging"/>.</em></p><p>Configure gathering STDOUT and STDERR output from container.</p></summary>
        [Pure]
        public static AzureWebappLogConfigSettings ResetDockerContainerLogging(this AzureWebappLogConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DockerContainerLogging = null;
            return toolSettings;
        }
        #endregion
        #region FailedRequestTracing
        /// <summary><p><em>Sets <see cref="AzureWebappLogConfigSettings.FailedRequestTracing"/>.</em></p><p>Configure failed request tracing.</p></summary>
        [Pure]
        public static AzureWebappLogConfigSettings SetFailedRequestTracing(this AzureWebappLogConfigSettings toolSettings, bool? failedRequestTracing)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FailedRequestTracing = failedRequestTracing;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappLogConfigSettings.FailedRequestTracing"/>.</em></p><p>Configure failed request tracing.</p></summary>
        [Pure]
        public static AzureWebappLogConfigSettings ResetFailedRequestTracing(this AzureWebappLogConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FailedRequestTracing = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureWebappLogConfigSettings.FailedRequestTracing"/>.</em></p><p>Configure failed request tracing.</p></summary>
        [Pure]
        public static AzureWebappLogConfigSettings EnableFailedRequestTracing(this AzureWebappLogConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FailedRequestTracing = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureWebappLogConfigSettings.FailedRequestTracing"/>.</em></p><p>Configure failed request tracing.</p></summary>
        [Pure]
        public static AzureWebappLogConfigSettings DisableFailedRequestTracing(this AzureWebappLogConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FailedRequestTracing = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureWebappLogConfigSettings.FailedRequestTracing"/>.</em></p><p>Configure failed request tracing.</p></summary>
        [Pure]
        public static AzureWebappLogConfigSettings ToggleFailedRequestTracing(this AzureWebappLogConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FailedRequestTracing = !toolSettings.FailedRequestTracing;
            return toolSettings;
        }
        #endregion
        #region Level
        /// <summary><p><em>Sets <see cref="AzureWebappLogConfigSettings.Level"/>.</em></p><p>Logging level.</p></summary>
        [Pure]
        public static AzureWebappLogConfigSettings SetLevel(this AzureWebappLogConfigSettings toolSettings, WebappLogConfigLevel level)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Level = level;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappLogConfigSettings.Level"/>.</em></p><p>Logging level.</p></summary>
        [Pure]
        public static AzureWebappLogConfigSettings ResetLevel(this AzureWebappLogConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Level = null;
            return toolSettings;
        }
        #endregion
        #region Slot
        /// <summary><p><em>Sets <see cref="AzureWebappLogConfigSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappLogConfigSettings SetSlot(this AzureWebappLogConfigSettings toolSettings, string slot)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = slot;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappLogConfigSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappLogConfigSettings ResetSlot(this AzureWebappLogConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = null;
            return toolSettings;
        }
        #endregion
        #region WebServerLogging
        /// <summary><p><em>Sets <see cref="AzureWebappLogConfigSettings.WebServerLogging"/>.</em></p><p>Configure Web server logging.</p></summary>
        [Pure]
        public static AzureWebappLogConfigSettings SetWebServerLogging(this AzureWebappLogConfigSettings toolSettings, WebappLogConfigDockerContainerLogging webServerLogging)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WebServerLogging = webServerLogging;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappLogConfigSettings.WebServerLogging"/>.</em></p><p>Configure Web server logging.</p></summary>
        [Pure]
        public static AzureWebappLogConfigSettings ResetWebServerLogging(this AzureWebappLogConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WebServerLogging = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureWebappLogConfigSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappLogConfigSettings SetDebug(this AzureWebappLogConfigSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappLogConfigSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappLogConfigSettings ResetDebug(this AzureWebappLogConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureWebappLogConfigSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappLogConfigSettings SetHelp(this AzureWebappLogConfigSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappLogConfigSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappLogConfigSettings ResetHelp(this AzureWebappLogConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureWebappLogConfigSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappLogConfigSettings SetOutput(this AzureWebappLogConfigSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappLogConfigSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappLogConfigSettings ResetOutput(this AzureWebappLogConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureWebappLogConfigSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappLogConfigSettings SetQuery(this AzureWebappLogConfigSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappLogConfigSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappLogConfigSettings ResetQuery(this AzureWebappLogConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureWebappLogConfigSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappLogConfigSettings SetVerbose(this AzureWebappLogConfigSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappLogConfigSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappLogConfigSettings ResetVerbose(this AzureWebappLogConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureWebappLogDownloadSettingsExtensions
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureWebappLogDownloadSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureWebappLogDownloadSettings.Name"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappLogDownloadSettings SetName(this AzureWebappLogDownloadSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappLogDownloadSettings.Name"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappLogDownloadSettings ResetName(this AzureWebappLogDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureWebappLogDownloadSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappLogDownloadSettings SetResourceGroup(this AzureWebappLogDownloadSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappLogDownloadSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappLogDownloadSettings ResetResourceGroup(this AzureWebappLogDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region LogFile
        /// <summary><p><em>Sets <see cref="AzureWebappLogDownloadSettings.LogFile"/>.</em></p><p>The downloaded zipped log file path.</p></summary>
        [Pure]
        public static AzureWebappLogDownloadSettings SetLogFile(this AzureWebappLogDownloadSettings toolSettings, string logFile)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFile = logFile;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappLogDownloadSettings.LogFile"/>.</em></p><p>The downloaded zipped log file path.</p></summary>
        [Pure]
        public static AzureWebappLogDownloadSettings ResetLogFile(this AzureWebappLogDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFile = null;
            return toolSettings;
        }
        #endregion
        #region Slot
        /// <summary><p><em>Sets <see cref="AzureWebappLogDownloadSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappLogDownloadSettings SetSlot(this AzureWebappLogDownloadSettings toolSettings, string slot)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = slot;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappLogDownloadSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappLogDownloadSettings ResetSlot(this AzureWebappLogDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureWebappLogDownloadSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappLogDownloadSettings SetDebug(this AzureWebappLogDownloadSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappLogDownloadSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappLogDownloadSettings ResetDebug(this AzureWebappLogDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureWebappLogDownloadSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappLogDownloadSettings SetHelp(this AzureWebappLogDownloadSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappLogDownloadSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappLogDownloadSettings ResetHelp(this AzureWebappLogDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureWebappLogDownloadSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappLogDownloadSettings SetOutput(this AzureWebappLogDownloadSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappLogDownloadSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappLogDownloadSettings ResetOutput(this AzureWebappLogDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureWebappLogDownloadSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappLogDownloadSettings SetQuery(this AzureWebappLogDownloadSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappLogDownloadSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappLogDownloadSettings ResetQuery(this AzureWebappLogDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureWebappLogDownloadSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappLogDownloadSettings SetVerbose(this AzureWebappLogDownloadSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappLogDownloadSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappLogDownloadSettings ResetVerbose(this AzureWebappLogDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureWebappLogShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureWebappLogShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureWebappLogShowSettings.Name"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappLogShowSettings SetName(this AzureWebappLogShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappLogShowSettings.Name"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappLogShowSettings ResetName(this AzureWebappLogShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureWebappLogShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappLogShowSettings SetResourceGroup(this AzureWebappLogShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappLogShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappLogShowSettings ResetResourceGroup(this AzureWebappLogShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Slot
        /// <summary><p><em>Sets <see cref="AzureWebappLogShowSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappLogShowSettings SetSlot(this AzureWebappLogShowSettings toolSettings, string slot)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = slot;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappLogShowSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappLogShowSettings ResetSlot(this AzureWebappLogShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureWebappLogShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappLogShowSettings SetDebug(this AzureWebappLogShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappLogShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappLogShowSettings ResetDebug(this AzureWebappLogShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureWebappLogShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappLogShowSettings SetHelp(this AzureWebappLogShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappLogShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappLogShowSettings ResetHelp(this AzureWebappLogShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureWebappLogShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappLogShowSettings SetOutput(this AzureWebappLogShowSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappLogShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappLogShowSettings ResetOutput(this AzureWebappLogShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureWebappLogShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappLogShowSettings SetQuery(this AzureWebappLogShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappLogShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappLogShowSettings ResetQuery(this AzureWebappLogShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureWebappLogShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappLogShowSettings SetVerbose(this AzureWebappLogShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappLogShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappLogShowSettings ResetVerbose(this AzureWebappLogShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureWebappLogTailSettingsExtensions
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureWebappLogTailSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureWebappLogTailSettings.Name"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappLogTailSettings SetName(this AzureWebappLogTailSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappLogTailSettings.Name"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappLogTailSettings ResetName(this AzureWebappLogTailSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureWebappLogTailSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappLogTailSettings SetResourceGroup(this AzureWebappLogTailSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappLogTailSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappLogTailSettings ResetResourceGroup(this AzureWebappLogTailSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Provider
        /// <summary><p><em>Sets <see cref="AzureWebappLogTailSettings.Provider"/>.</em></p><p>By default all live traces configured by 'az webapp log config' will be shown, but you can scope to certain providers/folders, e.g. 'application', 'http', etc. For details, check out &lt;a href="https://github.com/projectkudu/kudu/wiki/Diagnostic-Log-Stream"&gt;https://github.com/projectkudu/kudu/wiki/Diagnostic-Log-Stream&lt;/a&gt;.</p></summary>
        [Pure]
        public static AzureWebappLogTailSettings SetProvider(this AzureWebappLogTailSettings toolSettings, string provider)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Provider = provider;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappLogTailSettings.Provider"/>.</em></p><p>By default all live traces configured by 'az webapp log config' will be shown, but you can scope to certain providers/folders, e.g. 'application', 'http', etc. For details, check out &lt;a href="https://github.com/projectkudu/kudu/wiki/Diagnostic-Log-Stream"&gt;https://github.com/projectkudu/kudu/wiki/Diagnostic-Log-Stream&lt;/a&gt;.</p></summary>
        [Pure]
        public static AzureWebappLogTailSettings ResetProvider(this AzureWebappLogTailSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Provider = null;
            return toolSettings;
        }
        #endregion
        #region Slot
        /// <summary><p><em>Sets <see cref="AzureWebappLogTailSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappLogTailSettings SetSlot(this AzureWebappLogTailSettings toolSettings, string slot)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = slot;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappLogTailSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappLogTailSettings ResetSlot(this AzureWebappLogTailSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureWebappLogTailSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappLogTailSettings SetDebug(this AzureWebappLogTailSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappLogTailSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappLogTailSettings ResetDebug(this AzureWebappLogTailSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureWebappLogTailSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappLogTailSettings SetHelp(this AzureWebappLogTailSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappLogTailSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappLogTailSettings ResetHelp(this AzureWebappLogTailSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureWebappLogTailSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappLogTailSettings SetOutput(this AzureWebappLogTailSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappLogTailSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappLogTailSettings ResetOutput(this AzureWebappLogTailSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureWebappLogTailSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappLogTailSettings SetQuery(this AzureWebappLogTailSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappLogTailSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappLogTailSettings ResetQuery(this AzureWebappLogTailSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureWebappLogTailSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappLogTailSettings SetVerbose(this AzureWebappLogTailSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappLogTailSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappLogTailSettings ResetVerbose(this AzureWebappLogTailSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureWebappTrafficRoutingClearSettingsExtensions
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureWebappTrafficRoutingClearSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureWebappTrafficRoutingClearSettings.Name"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappTrafficRoutingClearSettings SetName(this AzureWebappTrafficRoutingClearSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappTrafficRoutingClearSettings.Name"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappTrafficRoutingClearSettings ResetName(this AzureWebappTrafficRoutingClearSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureWebappTrafficRoutingClearSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappTrafficRoutingClearSettings SetResourceGroup(this AzureWebappTrafficRoutingClearSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappTrafficRoutingClearSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappTrafficRoutingClearSettings ResetResourceGroup(this AzureWebappTrafficRoutingClearSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureWebappTrafficRoutingClearSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappTrafficRoutingClearSettings SetDebug(this AzureWebappTrafficRoutingClearSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappTrafficRoutingClearSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappTrafficRoutingClearSettings ResetDebug(this AzureWebappTrafficRoutingClearSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureWebappTrafficRoutingClearSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappTrafficRoutingClearSettings SetHelp(this AzureWebappTrafficRoutingClearSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappTrafficRoutingClearSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappTrafficRoutingClearSettings ResetHelp(this AzureWebappTrafficRoutingClearSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureWebappTrafficRoutingClearSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappTrafficRoutingClearSettings SetOutput(this AzureWebappTrafficRoutingClearSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappTrafficRoutingClearSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappTrafficRoutingClearSettings ResetOutput(this AzureWebappTrafficRoutingClearSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureWebappTrafficRoutingClearSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappTrafficRoutingClearSettings SetQuery(this AzureWebappTrafficRoutingClearSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappTrafficRoutingClearSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappTrafficRoutingClearSettings ResetQuery(this AzureWebappTrafficRoutingClearSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureWebappTrafficRoutingClearSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappTrafficRoutingClearSettings SetVerbose(this AzureWebappTrafficRoutingClearSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappTrafficRoutingClearSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappTrafficRoutingClearSettings ResetVerbose(this AzureWebappTrafficRoutingClearSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureWebappTrafficRoutingSetSettingsExtensions
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureWebappTrafficRoutingSetSettingsExtensions
    {
        #region Distribution
        /// <summary><p><em>Sets <see cref="AzureWebappTrafficRoutingSetSettings.Distribution"/>.</em></p><p>Space-separated slot routings in a format of &lt;slot-name&gt;=&lt;percentage&gt; e.g. staging=50. Unused traffic percentage will go to the Production slot.</p></summary>
        [Pure]
        public static AzureWebappTrafficRoutingSetSettings SetDistribution(this AzureWebappTrafficRoutingSetSettings toolSettings, string distribution)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Distribution = distribution;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappTrafficRoutingSetSettings.Distribution"/>.</em></p><p>Space-separated slot routings in a format of &lt;slot-name&gt;=&lt;percentage&gt; e.g. staging=50. Unused traffic percentage will go to the Production slot.</p></summary>
        [Pure]
        public static AzureWebappTrafficRoutingSetSettings ResetDistribution(this AzureWebappTrafficRoutingSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Distribution = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureWebappTrafficRoutingSetSettings.Name"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappTrafficRoutingSetSettings SetName(this AzureWebappTrafficRoutingSetSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappTrafficRoutingSetSettings.Name"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappTrafficRoutingSetSettings ResetName(this AzureWebappTrafficRoutingSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureWebappTrafficRoutingSetSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappTrafficRoutingSetSettings SetResourceGroup(this AzureWebappTrafficRoutingSetSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappTrafficRoutingSetSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappTrafficRoutingSetSettings ResetResourceGroup(this AzureWebappTrafficRoutingSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureWebappTrafficRoutingSetSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappTrafficRoutingSetSettings SetDebug(this AzureWebappTrafficRoutingSetSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappTrafficRoutingSetSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappTrafficRoutingSetSettings ResetDebug(this AzureWebappTrafficRoutingSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureWebappTrafficRoutingSetSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappTrafficRoutingSetSettings SetHelp(this AzureWebappTrafficRoutingSetSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappTrafficRoutingSetSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappTrafficRoutingSetSettings ResetHelp(this AzureWebappTrafficRoutingSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureWebappTrafficRoutingSetSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappTrafficRoutingSetSettings SetOutput(this AzureWebappTrafficRoutingSetSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappTrafficRoutingSetSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappTrafficRoutingSetSettings ResetOutput(this AzureWebappTrafficRoutingSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureWebappTrafficRoutingSetSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappTrafficRoutingSetSettings SetQuery(this AzureWebappTrafficRoutingSetSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappTrafficRoutingSetSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappTrafficRoutingSetSettings ResetQuery(this AzureWebappTrafficRoutingSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureWebappTrafficRoutingSetSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappTrafficRoutingSetSettings SetVerbose(this AzureWebappTrafficRoutingSetSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappTrafficRoutingSetSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappTrafficRoutingSetSettings ResetVerbose(this AzureWebappTrafficRoutingSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureWebappTrafficRoutingShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureWebappTrafficRoutingShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureWebappTrafficRoutingShowSettings.Name"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappTrafficRoutingShowSettings SetName(this AzureWebappTrafficRoutingShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappTrafficRoutingShowSettings.Name"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappTrafficRoutingShowSettings ResetName(this AzureWebappTrafficRoutingShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureWebappTrafficRoutingShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappTrafficRoutingShowSettings SetResourceGroup(this AzureWebappTrafficRoutingShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappTrafficRoutingShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappTrafficRoutingShowSettings ResetResourceGroup(this AzureWebappTrafficRoutingShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureWebappTrafficRoutingShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappTrafficRoutingShowSettings SetDebug(this AzureWebappTrafficRoutingShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappTrafficRoutingShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappTrafficRoutingShowSettings ResetDebug(this AzureWebappTrafficRoutingShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureWebappTrafficRoutingShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappTrafficRoutingShowSettings SetHelp(this AzureWebappTrafficRoutingShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappTrafficRoutingShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappTrafficRoutingShowSettings ResetHelp(this AzureWebappTrafficRoutingShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureWebappTrafficRoutingShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappTrafficRoutingShowSettings SetOutput(this AzureWebappTrafficRoutingShowSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappTrafficRoutingShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappTrafficRoutingShowSettings ResetOutput(this AzureWebappTrafficRoutingShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureWebappTrafficRoutingShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappTrafficRoutingShowSettings SetQuery(this AzureWebappTrafficRoutingShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappTrafficRoutingShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappTrafficRoutingShowSettings ResetQuery(this AzureWebappTrafficRoutingShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureWebappTrafficRoutingShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappTrafficRoutingShowSettings SetVerbose(this AzureWebappTrafficRoutingShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappTrafficRoutingShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappTrafficRoutingShowSettings ResetVerbose(this AzureWebappTrafficRoutingShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureWebappConfigAppsettingsDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureWebappConfigAppsettingsDeleteSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureWebappConfigAppsettingsDeleteSettings.Name"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappConfigAppsettingsDeleteSettings SetName(this AzureWebappConfigAppsettingsDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigAppsettingsDeleteSettings.Name"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappConfigAppsettingsDeleteSettings ResetName(this AzureWebappConfigAppsettingsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureWebappConfigAppsettingsDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappConfigAppsettingsDeleteSettings SetResourceGroup(this AzureWebappConfigAppsettingsDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigAppsettingsDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappConfigAppsettingsDeleteSettings ResetResourceGroup(this AzureWebappConfigAppsettingsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region SettingNames
        /// <summary><p><em>Sets <see cref="AzureWebappConfigAppsettingsDeleteSettings.SettingNames"/>.</em></p><p>Space-separated appsettings names.</p></summary>
        [Pure]
        public static AzureWebappConfigAppsettingsDeleteSettings SetSettingNames(this AzureWebappConfigAppsettingsDeleteSettings toolSettings, string settingNames)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SettingNames = settingNames;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigAppsettingsDeleteSettings.SettingNames"/>.</em></p><p>Space-separated appsettings names.</p></summary>
        [Pure]
        public static AzureWebappConfigAppsettingsDeleteSettings ResetSettingNames(this AzureWebappConfigAppsettingsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SettingNames = null;
            return toolSettings;
        }
        #endregion
        #region Slot
        /// <summary><p><em>Sets <see cref="AzureWebappConfigAppsettingsDeleteSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappConfigAppsettingsDeleteSettings SetSlot(this AzureWebappConfigAppsettingsDeleteSettings toolSettings, string slot)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = slot;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigAppsettingsDeleteSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappConfigAppsettingsDeleteSettings ResetSlot(this AzureWebappConfigAppsettingsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureWebappConfigAppsettingsDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigAppsettingsDeleteSettings SetDebug(this AzureWebappConfigAppsettingsDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigAppsettingsDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigAppsettingsDeleteSettings ResetDebug(this AzureWebappConfigAppsettingsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureWebappConfigAppsettingsDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappConfigAppsettingsDeleteSettings SetHelp(this AzureWebappConfigAppsettingsDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigAppsettingsDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappConfigAppsettingsDeleteSettings ResetHelp(this AzureWebappConfigAppsettingsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureWebappConfigAppsettingsDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappConfigAppsettingsDeleteSettings SetOutput(this AzureWebappConfigAppsettingsDeleteSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigAppsettingsDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappConfigAppsettingsDeleteSettings ResetOutput(this AzureWebappConfigAppsettingsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureWebappConfigAppsettingsDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappConfigAppsettingsDeleteSettings SetQuery(this AzureWebappConfigAppsettingsDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigAppsettingsDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappConfigAppsettingsDeleteSettings ResetQuery(this AzureWebappConfigAppsettingsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureWebappConfigAppsettingsDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigAppsettingsDeleteSettings SetVerbose(this AzureWebappConfigAppsettingsDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigAppsettingsDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigAppsettingsDeleteSettings ResetVerbose(this AzureWebappConfigAppsettingsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureWebappConfigAppsettingsListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureWebappConfigAppsettingsListSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureWebappConfigAppsettingsListSettings.Name"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappConfigAppsettingsListSettings SetName(this AzureWebappConfigAppsettingsListSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigAppsettingsListSettings.Name"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappConfigAppsettingsListSettings ResetName(this AzureWebappConfigAppsettingsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureWebappConfigAppsettingsListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappConfigAppsettingsListSettings SetResourceGroup(this AzureWebappConfigAppsettingsListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigAppsettingsListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappConfigAppsettingsListSettings ResetResourceGroup(this AzureWebappConfigAppsettingsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Slot
        /// <summary><p><em>Sets <see cref="AzureWebappConfigAppsettingsListSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappConfigAppsettingsListSettings SetSlot(this AzureWebappConfigAppsettingsListSettings toolSettings, string slot)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = slot;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigAppsettingsListSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappConfigAppsettingsListSettings ResetSlot(this AzureWebappConfigAppsettingsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureWebappConfigAppsettingsListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigAppsettingsListSettings SetDebug(this AzureWebappConfigAppsettingsListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigAppsettingsListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigAppsettingsListSettings ResetDebug(this AzureWebappConfigAppsettingsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureWebappConfigAppsettingsListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappConfigAppsettingsListSettings SetHelp(this AzureWebappConfigAppsettingsListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigAppsettingsListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappConfigAppsettingsListSettings ResetHelp(this AzureWebappConfigAppsettingsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureWebappConfigAppsettingsListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappConfigAppsettingsListSettings SetOutput(this AzureWebappConfigAppsettingsListSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigAppsettingsListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappConfigAppsettingsListSettings ResetOutput(this AzureWebappConfigAppsettingsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureWebappConfigAppsettingsListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappConfigAppsettingsListSettings SetQuery(this AzureWebappConfigAppsettingsListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigAppsettingsListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappConfigAppsettingsListSettings ResetQuery(this AzureWebappConfigAppsettingsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureWebappConfigAppsettingsListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigAppsettingsListSettings SetVerbose(this AzureWebappConfigAppsettingsListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigAppsettingsListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigAppsettingsListSettings ResetVerbose(this AzureWebappConfigAppsettingsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureWebappConfigAppsettingsSetSettingsExtensions
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureWebappConfigAppsettingsSetSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureWebappConfigAppsettingsSetSettings.Name"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappConfigAppsettingsSetSettings SetName(this AzureWebappConfigAppsettingsSetSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigAppsettingsSetSettings.Name"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappConfigAppsettingsSetSettings ResetName(this AzureWebappConfigAppsettingsSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureWebappConfigAppsettingsSetSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappConfigAppsettingsSetSettings SetResourceGroup(this AzureWebappConfigAppsettingsSetSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigAppsettingsSetSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappConfigAppsettingsSetSettings ResetResourceGroup(this AzureWebappConfigAppsettingsSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Settings
        /// <summary><p><em>Sets <see cref="AzureWebappConfigAppsettingsSetSettings.Settings"/>.</em></p><p>Space-separated appsettings in a format of &lt;name&gt;=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureWebappConfigAppsettingsSetSettings SetSettings(this AzureWebappConfigAppsettingsSetSettings toolSettings, string settings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Settings = settings;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigAppsettingsSetSettings.Settings"/>.</em></p><p>Space-separated appsettings in a format of &lt;name&gt;=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureWebappConfigAppsettingsSetSettings ResetSettings(this AzureWebappConfigAppsettingsSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Settings = null;
            return toolSettings;
        }
        #endregion
        #region Slot
        /// <summary><p><em>Sets <see cref="AzureWebappConfigAppsettingsSetSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappConfigAppsettingsSetSettings SetSlot(this AzureWebappConfigAppsettingsSetSettings toolSettings, string slot)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = slot;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigAppsettingsSetSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappConfigAppsettingsSetSettings ResetSlot(this AzureWebappConfigAppsettingsSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = null;
            return toolSettings;
        }
        #endregion
        #region SlotSettings
        /// <summary><p><em>Sets <see cref="AzureWebappConfigAppsettingsSetSettings.SlotSettings"/>.</em></p><p>Space-separated slot appsettings in a format of &lt;name&gt;=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureWebappConfigAppsettingsSetSettings SetSlotSettings(this AzureWebappConfigAppsettingsSetSettings toolSettings, string slotSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SlotSettings = slotSettings;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigAppsettingsSetSettings.SlotSettings"/>.</em></p><p>Space-separated slot appsettings in a format of &lt;name&gt;=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureWebappConfigAppsettingsSetSettings ResetSlotSettings(this AzureWebappConfigAppsettingsSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SlotSettings = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureWebappConfigAppsettingsSetSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigAppsettingsSetSettings SetDebug(this AzureWebappConfigAppsettingsSetSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigAppsettingsSetSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigAppsettingsSetSettings ResetDebug(this AzureWebappConfigAppsettingsSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureWebappConfigAppsettingsSetSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappConfigAppsettingsSetSettings SetHelp(this AzureWebappConfigAppsettingsSetSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigAppsettingsSetSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappConfigAppsettingsSetSettings ResetHelp(this AzureWebappConfigAppsettingsSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureWebappConfigAppsettingsSetSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappConfigAppsettingsSetSettings SetOutput(this AzureWebappConfigAppsettingsSetSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigAppsettingsSetSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappConfigAppsettingsSetSettings ResetOutput(this AzureWebappConfigAppsettingsSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureWebappConfigAppsettingsSetSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappConfigAppsettingsSetSettings SetQuery(this AzureWebappConfigAppsettingsSetSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigAppsettingsSetSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappConfigAppsettingsSetSettings ResetQuery(this AzureWebappConfigAppsettingsSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureWebappConfigAppsettingsSetSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigAppsettingsSetSettings SetVerbose(this AzureWebappConfigAppsettingsSetSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigAppsettingsSetSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigAppsettingsSetSettings ResetVerbose(this AzureWebappConfigAppsettingsSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureWebappConfigBackupCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureWebappConfigBackupCreateSettingsExtensions
    {
        #region ContainerUrl
        /// <summary><p><em>Sets <see cref="AzureWebappConfigBackupCreateSettings.ContainerUrl"/>.</em></p><p>URL with SAS token to the blob storage container.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupCreateSettings SetContainerUrl(this AzureWebappConfigBackupCreateSettings toolSettings, string containerUrl)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ContainerUrl = containerUrl;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigBackupCreateSettings.ContainerUrl"/>.</em></p><p>URL with SAS token to the blob storage container.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupCreateSettings ResetContainerUrl(this AzureWebappConfigBackupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ContainerUrl = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureWebappConfigBackupCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupCreateSettings SetResourceGroup(this AzureWebappConfigBackupCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigBackupCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupCreateSettings ResetResourceGroup(this AzureWebappConfigBackupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region WebappName
        /// <summary><p><em>Sets <see cref="AzureWebappConfigBackupCreateSettings.WebappName"/>.</em></p><p>The name of the webapp.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupCreateSettings SetWebappName(this AzureWebappConfigBackupCreateSettings toolSettings, string webappName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WebappName = webappName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigBackupCreateSettings.WebappName"/>.</em></p><p>The name of the webapp.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupCreateSettings ResetWebappName(this AzureWebappConfigBackupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WebappName = null;
            return toolSettings;
        }
        #endregion
        #region BackupName
        /// <summary><p><em>Sets <see cref="AzureWebappConfigBackupCreateSettings.BackupName"/>.</em></p><p>Name of the backup. If unspecified, the backup will be named with the webapp name and a timestamp.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupCreateSettings SetBackupName(this AzureWebappConfigBackupCreateSettings toolSettings, string backupName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BackupName = backupName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigBackupCreateSettings.BackupName"/>.</em></p><p>Name of the backup. If unspecified, the backup will be named with the webapp name and a timestamp.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupCreateSettings ResetBackupName(this AzureWebappConfigBackupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BackupName = null;
            return toolSettings;
        }
        #endregion
        #region Slot
        /// <summary><p><em>Sets <see cref="AzureWebappConfigBackupCreateSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupCreateSettings SetSlot(this AzureWebappConfigBackupCreateSettings toolSettings, string slot)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = slot;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigBackupCreateSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupCreateSettings ResetSlot(this AzureWebappConfigBackupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = null;
            return toolSettings;
        }
        #endregion
        #region DbConnectionString
        /// <summary><p><em>Sets <see cref="AzureWebappConfigBackupCreateSettings.DbConnectionString"/>.</em></p><p>Connection string for the database in the backup.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupCreateSettings SetDbConnectionString(this AzureWebappConfigBackupCreateSettings toolSettings, string dbConnectionString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DbConnectionString = dbConnectionString;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigBackupCreateSettings.DbConnectionString"/>.</em></p><p>Connection string for the database in the backup.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupCreateSettings ResetDbConnectionString(this AzureWebappConfigBackupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DbConnectionString = null;
            return toolSettings;
        }
        #endregion
        #region DbName
        /// <summary><p><em>Sets <see cref="AzureWebappConfigBackupCreateSettings.DbName"/>.</em></p><p>Name of the database in the backup.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupCreateSettings SetDbName(this AzureWebappConfigBackupCreateSettings toolSettings, string dbName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DbName = dbName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigBackupCreateSettings.DbName"/>.</em></p><p>Name of the database in the backup.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupCreateSettings ResetDbName(this AzureWebappConfigBackupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DbName = null;
            return toolSettings;
        }
        #endregion
        #region DbType
        /// <summary><p><em>Sets <see cref="AzureWebappConfigBackupCreateSettings.DbType"/>.</em></p><p>Type of database in the backup.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupCreateSettings SetDbType(this AzureWebappConfigBackupCreateSettings toolSettings, WebappConfigBackupDbType dbType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DbType = dbType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigBackupCreateSettings.DbType"/>.</em></p><p>Type of database in the backup.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupCreateSettings ResetDbType(this AzureWebappConfigBackupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DbType = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureWebappConfigBackupCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupCreateSettings SetDebug(this AzureWebappConfigBackupCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigBackupCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupCreateSettings ResetDebug(this AzureWebappConfigBackupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureWebappConfigBackupCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupCreateSettings SetHelp(this AzureWebappConfigBackupCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigBackupCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupCreateSettings ResetHelp(this AzureWebappConfigBackupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureWebappConfigBackupCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupCreateSettings SetOutput(this AzureWebappConfigBackupCreateSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigBackupCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupCreateSettings ResetOutput(this AzureWebappConfigBackupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureWebappConfigBackupCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupCreateSettings SetQuery(this AzureWebappConfigBackupCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigBackupCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupCreateSettings ResetQuery(this AzureWebappConfigBackupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureWebappConfigBackupCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupCreateSettings SetVerbose(this AzureWebappConfigBackupCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigBackupCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupCreateSettings ResetVerbose(this AzureWebappConfigBackupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureWebappConfigBackupListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureWebappConfigBackupListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureWebappConfigBackupListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupListSettings SetResourceGroup(this AzureWebappConfigBackupListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigBackupListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupListSettings ResetResourceGroup(this AzureWebappConfigBackupListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region WebappName
        /// <summary><p><em>Sets <see cref="AzureWebappConfigBackupListSettings.WebappName"/>.</em></p><p>The name of the webapp.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupListSettings SetWebappName(this AzureWebappConfigBackupListSettings toolSettings, string webappName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WebappName = webappName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigBackupListSettings.WebappName"/>.</em></p><p>The name of the webapp.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupListSettings ResetWebappName(this AzureWebappConfigBackupListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WebappName = null;
            return toolSettings;
        }
        #endregion
        #region Slot
        /// <summary><p><em>Sets <see cref="AzureWebappConfigBackupListSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupListSettings SetSlot(this AzureWebappConfigBackupListSettings toolSettings, string slot)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = slot;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigBackupListSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupListSettings ResetSlot(this AzureWebappConfigBackupListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureWebappConfigBackupListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupListSettings SetDebug(this AzureWebappConfigBackupListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigBackupListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupListSettings ResetDebug(this AzureWebappConfigBackupListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureWebappConfigBackupListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupListSettings SetHelp(this AzureWebappConfigBackupListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigBackupListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupListSettings ResetHelp(this AzureWebappConfigBackupListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureWebappConfigBackupListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupListSettings SetOutput(this AzureWebappConfigBackupListSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigBackupListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupListSettings ResetOutput(this AzureWebappConfigBackupListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureWebappConfigBackupListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupListSettings SetQuery(this AzureWebappConfigBackupListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigBackupListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupListSettings ResetQuery(this AzureWebappConfigBackupListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureWebappConfigBackupListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupListSettings SetVerbose(this AzureWebappConfigBackupListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigBackupListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupListSettings ResetVerbose(this AzureWebappConfigBackupListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureWebappConfigBackupRestoreSettingsExtensions
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureWebappConfigBackupRestoreSettingsExtensions
    {
        #region BackupName
        /// <summary><p><em>Sets <see cref="AzureWebappConfigBackupRestoreSettings.BackupName"/>.</em></p><p>Name of the backup to restore.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupRestoreSettings SetBackupName(this AzureWebappConfigBackupRestoreSettings toolSettings, string backupName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BackupName = backupName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigBackupRestoreSettings.BackupName"/>.</em></p><p>Name of the backup to restore.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupRestoreSettings ResetBackupName(this AzureWebappConfigBackupRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BackupName = null;
            return toolSettings;
        }
        #endregion
        #region ContainerUrl
        /// <summary><p><em>Sets <see cref="AzureWebappConfigBackupRestoreSettings.ContainerUrl"/>.</em></p><p>URL with SAS token to the blob storage container.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupRestoreSettings SetContainerUrl(this AzureWebappConfigBackupRestoreSettings toolSettings, string containerUrl)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ContainerUrl = containerUrl;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigBackupRestoreSettings.ContainerUrl"/>.</em></p><p>URL with SAS token to the blob storage container.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupRestoreSettings ResetContainerUrl(this AzureWebappConfigBackupRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ContainerUrl = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureWebappConfigBackupRestoreSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupRestoreSettings SetResourceGroup(this AzureWebappConfigBackupRestoreSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigBackupRestoreSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupRestoreSettings ResetResourceGroup(this AzureWebappConfigBackupRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region WebappName
        /// <summary><p><em>Sets <see cref="AzureWebappConfigBackupRestoreSettings.WebappName"/>.</em></p><p>The name of the webapp.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupRestoreSettings SetWebappName(this AzureWebappConfigBackupRestoreSettings toolSettings, string webappName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WebappName = webappName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigBackupRestoreSettings.WebappName"/>.</em></p><p>The name of the webapp.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupRestoreSettings ResetWebappName(this AzureWebappConfigBackupRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WebappName = null;
            return toolSettings;
        }
        #endregion
        #region IgnoreHostnameConflict
        /// <summary><p><em>Sets <see cref="AzureWebappConfigBackupRestoreSettings.IgnoreHostnameConflict"/>.</em></p><p>Ignores custom hostnames stored in the backup.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupRestoreSettings SetIgnoreHostnameConflict(this AzureWebappConfigBackupRestoreSettings toolSettings, string ignoreHostnameConflict)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IgnoreHostnameConflict = ignoreHostnameConflict;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigBackupRestoreSettings.IgnoreHostnameConflict"/>.</em></p><p>Ignores custom hostnames stored in the backup.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupRestoreSettings ResetIgnoreHostnameConflict(this AzureWebappConfigBackupRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IgnoreHostnameConflict = null;
            return toolSettings;
        }
        #endregion
        #region Overwrite
        /// <summary><p><em>Sets <see cref="AzureWebappConfigBackupRestoreSettings.Overwrite"/>.</em></p><p>Overwrite the source webapp, if --target-name is not specified.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupRestoreSettings SetOverwrite(this AzureWebappConfigBackupRestoreSettings toolSettings, string overwrite)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Overwrite = overwrite;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigBackupRestoreSettings.Overwrite"/>.</em></p><p>Overwrite the source webapp, if --target-name is not specified.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupRestoreSettings ResetOverwrite(this AzureWebappConfigBackupRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Overwrite = null;
            return toolSettings;
        }
        #endregion
        #region Slot
        /// <summary><p><em>Sets <see cref="AzureWebappConfigBackupRestoreSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupRestoreSettings SetSlot(this AzureWebappConfigBackupRestoreSettings toolSettings, string slot)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = slot;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigBackupRestoreSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupRestoreSettings ResetSlot(this AzureWebappConfigBackupRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = null;
            return toolSettings;
        }
        #endregion
        #region TargetName
        /// <summary><p><em>Sets <see cref="AzureWebappConfigBackupRestoreSettings.TargetName"/>.</em></p><p>The name to use for the restored webapp. If unspecified, will default to the name that was used when the backup was created.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupRestoreSettings SetTargetName(this AzureWebappConfigBackupRestoreSettings toolSettings, string targetName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TargetName = targetName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigBackupRestoreSettings.TargetName"/>.</em></p><p>The name to use for the restored webapp. If unspecified, will default to the name that was used when the backup was created.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupRestoreSettings ResetTargetName(this AzureWebappConfigBackupRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TargetName = null;
            return toolSettings;
        }
        #endregion
        #region DbConnectionString
        /// <summary><p><em>Sets <see cref="AzureWebappConfigBackupRestoreSettings.DbConnectionString"/>.</em></p><p>Connection string for the database in the backup.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupRestoreSettings SetDbConnectionString(this AzureWebappConfigBackupRestoreSettings toolSettings, string dbConnectionString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DbConnectionString = dbConnectionString;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigBackupRestoreSettings.DbConnectionString"/>.</em></p><p>Connection string for the database in the backup.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupRestoreSettings ResetDbConnectionString(this AzureWebappConfigBackupRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DbConnectionString = null;
            return toolSettings;
        }
        #endregion
        #region DbName
        /// <summary><p><em>Sets <see cref="AzureWebappConfigBackupRestoreSettings.DbName"/>.</em></p><p>Name of the database in the backup.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupRestoreSettings SetDbName(this AzureWebappConfigBackupRestoreSettings toolSettings, string dbName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DbName = dbName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigBackupRestoreSettings.DbName"/>.</em></p><p>Name of the database in the backup.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupRestoreSettings ResetDbName(this AzureWebappConfigBackupRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DbName = null;
            return toolSettings;
        }
        #endregion
        #region DbType
        /// <summary><p><em>Sets <see cref="AzureWebappConfigBackupRestoreSettings.DbType"/>.</em></p><p>Type of database in the backup.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupRestoreSettings SetDbType(this AzureWebappConfigBackupRestoreSettings toolSettings, WebappConfigBackupDbType dbType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DbType = dbType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigBackupRestoreSettings.DbType"/>.</em></p><p>Type of database in the backup.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupRestoreSettings ResetDbType(this AzureWebappConfigBackupRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DbType = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureWebappConfigBackupRestoreSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupRestoreSettings SetDebug(this AzureWebappConfigBackupRestoreSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigBackupRestoreSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupRestoreSettings ResetDebug(this AzureWebappConfigBackupRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureWebappConfigBackupRestoreSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupRestoreSettings SetHelp(this AzureWebappConfigBackupRestoreSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigBackupRestoreSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupRestoreSettings ResetHelp(this AzureWebappConfigBackupRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureWebappConfigBackupRestoreSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupRestoreSettings SetOutput(this AzureWebappConfigBackupRestoreSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigBackupRestoreSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupRestoreSettings ResetOutput(this AzureWebappConfigBackupRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureWebappConfigBackupRestoreSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupRestoreSettings SetQuery(this AzureWebappConfigBackupRestoreSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigBackupRestoreSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupRestoreSettings ResetQuery(this AzureWebappConfigBackupRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureWebappConfigBackupRestoreSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupRestoreSettings SetVerbose(this AzureWebappConfigBackupRestoreSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigBackupRestoreSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupRestoreSettings ResetVerbose(this AzureWebappConfigBackupRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureWebappConfigBackupShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureWebappConfigBackupShowSettingsExtensions
    {
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureWebappConfigBackupShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupShowSettings SetResourceGroup(this AzureWebappConfigBackupShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigBackupShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupShowSettings ResetResourceGroup(this AzureWebappConfigBackupShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region WebappName
        /// <summary><p><em>Sets <see cref="AzureWebappConfigBackupShowSettings.WebappName"/>.</em></p><p>The name of the webapp.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupShowSettings SetWebappName(this AzureWebappConfigBackupShowSettings toolSettings, string webappName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WebappName = webappName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigBackupShowSettings.WebappName"/>.</em></p><p>The name of the webapp.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupShowSettings ResetWebappName(this AzureWebappConfigBackupShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WebappName = null;
            return toolSettings;
        }
        #endregion
        #region Slot
        /// <summary><p><em>Sets <see cref="AzureWebappConfigBackupShowSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupShowSettings SetSlot(this AzureWebappConfigBackupShowSettings toolSettings, string slot)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = slot;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigBackupShowSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupShowSettings ResetSlot(this AzureWebappConfigBackupShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureWebappConfigBackupShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupShowSettings SetDebug(this AzureWebappConfigBackupShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigBackupShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupShowSettings ResetDebug(this AzureWebappConfigBackupShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureWebappConfigBackupShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupShowSettings SetHelp(this AzureWebappConfigBackupShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigBackupShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupShowSettings ResetHelp(this AzureWebappConfigBackupShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureWebappConfigBackupShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupShowSettings SetOutput(this AzureWebappConfigBackupShowSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigBackupShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupShowSettings ResetOutput(this AzureWebappConfigBackupShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureWebappConfigBackupShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupShowSettings SetQuery(this AzureWebappConfigBackupShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigBackupShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupShowSettings ResetQuery(this AzureWebappConfigBackupShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureWebappConfigBackupShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupShowSettings SetVerbose(this AzureWebappConfigBackupShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigBackupShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupShowSettings ResetVerbose(this AzureWebappConfigBackupShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureWebappConfigBackupUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureWebappConfigBackupUpdateSettingsExtensions
    {
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureWebappConfigBackupUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupUpdateSettings SetResourceGroup(this AzureWebappConfigBackupUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigBackupUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupUpdateSettings ResetResourceGroup(this AzureWebappConfigBackupUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region WebappName
        /// <summary><p><em>Sets <see cref="AzureWebappConfigBackupUpdateSettings.WebappName"/>.</em></p><p>The name of the webapp.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupUpdateSettings SetWebappName(this AzureWebappConfigBackupUpdateSettings toolSettings, string webappName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WebappName = webappName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigBackupUpdateSettings.WebappName"/>.</em></p><p>The name of the webapp.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupUpdateSettings ResetWebappName(this AzureWebappConfigBackupUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WebappName = null;
            return toolSettings;
        }
        #endregion
        #region BackupName
        /// <summary><p><em>Sets <see cref="AzureWebappConfigBackupUpdateSettings.BackupName"/>.</em></p><p>Name of the backup. If unspecified, the backup will be named with the webapp name and a timestamp.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupUpdateSettings SetBackupName(this AzureWebappConfigBackupUpdateSettings toolSettings, string backupName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BackupName = backupName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigBackupUpdateSettings.BackupName"/>.</em></p><p>Name of the backup. If unspecified, the backup will be named with the webapp name and a timestamp.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupUpdateSettings ResetBackupName(this AzureWebappConfigBackupUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BackupName = null;
            return toolSettings;
        }
        #endregion
        #region ContainerUrl
        /// <summary><p><em>Sets <see cref="AzureWebappConfigBackupUpdateSettings.ContainerUrl"/>.</em></p><p>URL with SAS token to the blob storage container.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupUpdateSettings SetContainerUrl(this AzureWebappConfigBackupUpdateSettings toolSettings, string containerUrl)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ContainerUrl = containerUrl;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigBackupUpdateSettings.ContainerUrl"/>.</em></p><p>URL with SAS token to the blob storage container.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupUpdateSettings ResetContainerUrl(this AzureWebappConfigBackupUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ContainerUrl = null;
            return toolSettings;
        }
        #endregion
        #region Frequency
        /// <summary><p><em>Sets <see cref="AzureWebappConfigBackupUpdateSettings.Frequency"/>.</em></p><p>How often to backup. Use a number followed by d or h, e.g. 5d = 5 days, 2h = 2 hours.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupUpdateSettings SetFrequency(this AzureWebappConfigBackupUpdateSettings toolSettings, string frequency)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Frequency = frequency;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigBackupUpdateSettings.Frequency"/>.</em></p><p>How often to backup. Use a number followed by d or h, e.g. 5d = 5 days, 2h = 2 hours.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupUpdateSettings ResetFrequency(this AzureWebappConfigBackupUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Frequency = null;
            return toolSettings;
        }
        #endregion
        #region RetainOne
        /// <summary><p><em>Sets <see cref="AzureWebappConfigBackupUpdateSettings.RetainOne"/>.</em></p><p>Always keep one backup, regardless of how old it is.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupUpdateSettings SetRetainOne(this AzureWebappConfigBackupUpdateSettings toolSettings, bool? retainOne)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RetainOne = retainOne;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigBackupUpdateSettings.RetainOne"/>.</em></p><p>Always keep one backup, regardless of how old it is.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupUpdateSettings ResetRetainOne(this AzureWebappConfigBackupUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RetainOne = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureWebappConfigBackupUpdateSettings.RetainOne"/>.</em></p><p>Always keep one backup, regardless of how old it is.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupUpdateSettings EnableRetainOne(this AzureWebappConfigBackupUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RetainOne = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureWebappConfigBackupUpdateSettings.RetainOne"/>.</em></p><p>Always keep one backup, regardless of how old it is.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupUpdateSettings DisableRetainOne(this AzureWebappConfigBackupUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RetainOne = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureWebappConfigBackupUpdateSettings.RetainOne"/>.</em></p><p>Always keep one backup, regardless of how old it is.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupUpdateSettings ToggleRetainOne(this AzureWebappConfigBackupUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RetainOne = !toolSettings.RetainOne;
            return toolSettings;
        }
        #endregion
        #region Retention
        /// <summary><p><em>Sets <see cref="AzureWebappConfigBackupUpdateSettings.Retention"/>.</em></p><p>How many days to keep a backup before automatically deleting it. Set to 0 for indefinite retention.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupUpdateSettings SetRetention(this AzureWebappConfigBackupUpdateSettings toolSettings, string retention)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Retention = retention;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigBackupUpdateSettings.Retention"/>.</em></p><p>How many days to keep a backup before automatically deleting it. Set to 0 for indefinite retention.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupUpdateSettings ResetRetention(this AzureWebappConfigBackupUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Retention = null;
            return toolSettings;
        }
        #endregion
        #region Slot
        /// <summary><p><em>Sets <see cref="AzureWebappConfigBackupUpdateSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupUpdateSettings SetSlot(this AzureWebappConfigBackupUpdateSettings toolSettings, string slot)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = slot;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigBackupUpdateSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupUpdateSettings ResetSlot(this AzureWebappConfigBackupUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = null;
            return toolSettings;
        }
        #endregion
        #region DbConnectionString
        /// <summary><p><em>Sets <see cref="AzureWebappConfigBackupUpdateSettings.DbConnectionString"/>.</em></p><p>Connection string for the database in the backup.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupUpdateSettings SetDbConnectionString(this AzureWebappConfigBackupUpdateSettings toolSettings, string dbConnectionString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DbConnectionString = dbConnectionString;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigBackupUpdateSettings.DbConnectionString"/>.</em></p><p>Connection string for the database in the backup.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupUpdateSettings ResetDbConnectionString(this AzureWebappConfigBackupUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DbConnectionString = null;
            return toolSettings;
        }
        #endregion
        #region DbName
        /// <summary><p><em>Sets <see cref="AzureWebappConfigBackupUpdateSettings.DbName"/>.</em></p><p>Name of the database in the backup.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupUpdateSettings SetDbName(this AzureWebappConfigBackupUpdateSettings toolSettings, string dbName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DbName = dbName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigBackupUpdateSettings.DbName"/>.</em></p><p>Name of the database in the backup.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupUpdateSettings ResetDbName(this AzureWebappConfigBackupUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DbName = null;
            return toolSettings;
        }
        #endregion
        #region DbType
        /// <summary><p><em>Sets <see cref="AzureWebappConfigBackupUpdateSettings.DbType"/>.</em></p><p>Type of database in the backup.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupUpdateSettings SetDbType(this AzureWebappConfigBackupUpdateSettings toolSettings, WebappConfigBackupDbType dbType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DbType = dbType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigBackupUpdateSettings.DbType"/>.</em></p><p>Type of database in the backup.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupUpdateSettings ResetDbType(this AzureWebappConfigBackupUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DbType = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureWebappConfigBackupUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupUpdateSettings SetDebug(this AzureWebappConfigBackupUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigBackupUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupUpdateSettings ResetDebug(this AzureWebappConfigBackupUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureWebappConfigBackupUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupUpdateSettings SetHelp(this AzureWebappConfigBackupUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigBackupUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupUpdateSettings ResetHelp(this AzureWebappConfigBackupUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureWebappConfigBackupUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupUpdateSettings SetOutput(this AzureWebappConfigBackupUpdateSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigBackupUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupUpdateSettings ResetOutput(this AzureWebappConfigBackupUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureWebappConfigBackupUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupUpdateSettings SetQuery(this AzureWebappConfigBackupUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigBackupUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupUpdateSettings ResetQuery(this AzureWebappConfigBackupUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureWebappConfigBackupUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupUpdateSettings SetVerbose(this AzureWebappConfigBackupUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigBackupUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigBackupUpdateSettings ResetVerbose(this AzureWebappConfigBackupUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureWebappConfigConnectionStringDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureWebappConfigConnectionStringDeleteSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureWebappConfigConnectionStringDeleteSettings.Name"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappConfigConnectionStringDeleteSettings SetName(this AzureWebappConfigConnectionStringDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigConnectionStringDeleteSettings.Name"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappConfigConnectionStringDeleteSettings ResetName(this AzureWebappConfigConnectionStringDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureWebappConfigConnectionStringDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappConfigConnectionStringDeleteSettings SetResourceGroup(this AzureWebappConfigConnectionStringDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigConnectionStringDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappConfigConnectionStringDeleteSettings ResetResourceGroup(this AzureWebappConfigConnectionStringDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region SettingNames
        /// <summary><p><em>Sets <see cref="AzureWebappConfigConnectionStringDeleteSettings.SettingNames"/>.</em></p><p>Space-separated connection-string names.</p></summary>
        [Pure]
        public static AzureWebappConfigConnectionStringDeleteSettings SetSettingNames(this AzureWebappConfigConnectionStringDeleteSettings toolSettings, string settingNames)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SettingNames = settingNames;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigConnectionStringDeleteSettings.SettingNames"/>.</em></p><p>Space-separated connection-string names.</p></summary>
        [Pure]
        public static AzureWebappConfigConnectionStringDeleteSettings ResetSettingNames(this AzureWebappConfigConnectionStringDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SettingNames = null;
            return toolSettings;
        }
        #endregion
        #region Slot
        /// <summary><p><em>Sets <see cref="AzureWebappConfigConnectionStringDeleteSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappConfigConnectionStringDeleteSettings SetSlot(this AzureWebappConfigConnectionStringDeleteSettings toolSettings, string slot)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = slot;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigConnectionStringDeleteSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappConfigConnectionStringDeleteSettings ResetSlot(this AzureWebappConfigConnectionStringDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureWebappConfigConnectionStringDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigConnectionStringDeleteSettings SetDebug(this AzureWebappConfigConnectionStringDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigConnectionStringDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigConnectionStringDeleteSettings ResetDebug(this AzureWebappConfigConnectionStringDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureWebappConfigConnectionStringDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappConfigConnectionStringDeleteSettings SetHelp(this AzureWebappConfigConnectionStringDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigConnectionStringDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappConfigConnectionStringDeleteSettings ResetHelp(this AzureWebappConfigConnectionStringDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureWebappConfigConnectionStringDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappConfigConnectionStringDeleteSettings SetOutput(this AzureWebappConfigConnectionStringDeleteSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigConnectionStringDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappConfigConnectionStringDeleteSettings ResetOutput(this AzureWebappConfigConnectionStringDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureWebappConfigConnectionStringDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappConfigConnectionStringDeleteSettings SetQuery(this AzureWebappConfigConnectionStringDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigConnectionStringDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappConfigConnectionStringDeleteSettings ResetQuery(this AzureWebappConfigConnectionStringDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureWebappConfigConnectionStringDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigConnectionStringDeleteSettings SetVerbose(this AzureWebappConfigConnectionStringDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigConnectionStringDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigConnectionStringDeleteSettings ResetVerbose(this AzureWebappConfigConnectionStringDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureWebappConfigConnectionStringListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureWebappConfigConnectionStringListSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureWebappConfigConnectionStringListSettings.Name"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappConfigConnectionStringListSettings SetName(this AzureWebappConfigConnectionStringListSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigConnectionStringListSettings.Name"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappConfigConnectionStringListSettings ResetName(this AzureWebappConfigConnectionStringListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureWebappConfigConnectionStringListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappConfigConnectionStringListSettings SetResourceGroup(this AzureWebappConfigConnectionStringListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigConnectionStringListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappConfigConnectionStringListSettings ResetResourceGroup(this AzureWebappConfigConnectionStringListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Slot
        /// <summary><p><em>Sets <see cref="AzureWebappConfigConnectionStringListSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappConfigConnectionStringListSettings SetSlot(this AzureWebappConfigConnectionStringListSettings toolSettings, string slot)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = slot;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigConnectionStringListSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappConfigConnectionStringListSettings ResetSlot(this AzureWebappConfigConnectionStringListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureWebappConfigConnectionStringListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigConnectionStringListSettings SetDebug(this AzureWebappConfigConnectionStringListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigConnectionStringListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigConnectionStringListSettings ResetDebug(this AzureWebappConfigConnectionStringListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureWebappConfigConnectionStringListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappConfigConnectionStringListSettings SetHelp(this AzureWebappConfigConnectionStringListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigConnectionStringListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappConfigConnectionStringListSettings ResetHelp(this AzureWebappConfigConnectionStringListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureWebappConfigConnectionStringListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappConfigConnectionStringListSettings SetOutput(this AzureWebappConfigConnectionStringListSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigConnectionStringListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappConfigConnectionStringListSettings ResetOutput(this AzureWebappConfigConnectionStringListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureWebappConfigConnectionStringListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappConfigConnectionStringListSettings SetQuery(this AzureWebappConfigConnectionStringListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigConnectionStringListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappConfigConnectionStringListSettings ResetQuery(this AzureWebappConfigConnectionStringListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureWebappConfigConnectionStringListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigConnectionStringListSettings SetVerbose(this AzureWebappConfigConnectionStringListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigConnectionStringListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigConnectionStringListSettings ResetVerbose(this AzureWebappConfigConnectionStringListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureWebappConfigConnectionStringSetSettingsExtensions
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureWebappConfigConnectionStringSetSettingsExtensions
    {
        #region ConnectionStringType
        /// <summary><p><em>Sets <see cref="AzureWebappConfigConnectionStringSetSettings.ConnectionStringType"/>.</em></p><p>Connection string type.</p></summary>
        [Pure]
        public static AzureWebappConfigConnectionStringSetSettings SetConnectionStringType(this AzureWebappConfigConnectionStringSetSettings toolSettings, WebappConfigConnectionStringSetConnectionStringType connectionStringType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ConnectionStringType = connectionStringType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigConnectionStringSetSettings.ConnectionStringType"/>.</em></p><p>Connection string type.</p></summary>
        [Pure]
        public static AzureWebappConfigConnectionStringSetSettings ResetConnectionStringType(this AzureWebappConfigConnectionStringSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ConnectionStringType = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureWebappConfigConnectionStringSetSettings.Name"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappConfigConnectionStringSetSettings SetName(this AzureWebappConfigConnectionStringSetSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigConnectionStringSetSettings.Name"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappConfigConnectionStringSetSettings ResetName(this AzureWebappConfigConnectionStringSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureWebappConfigConnectionStringSetSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappConfigConnectionStringSetSettings SetResourceGroup(this AzureWebappConfigConnectionStringSetSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigConnectionStringSetSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappConfigConnectionStringSetSettings ResetResourceGroup(this AzureWebappConfigConnectionStringSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Settings
        /// <summary><p><em>Sets <see cref="AzureWebappConfigConnectionStringSetSettings.Settings"/>.</em></p><p>Space-separated connection-string in a format of &lt;name&gt;=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureWebappConfigConnectionStringSetSettings SetSettings(this AzureWebappConfigConnectionStringSetSettings toolSettings, string settings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Settings = settings;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigConnectionStringSetSettings.Settings"/>.</em></p><p>Space-separated connection-string in a format of &lt;name&gt;=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureWebappConfigConnectionStringSetSettings ResetSettings(this AzureWebappConfigConnectionStringSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Settings = null;
            return toolSettings;
        }
        #endregion
        #region Slot
        /// <summary><p><em>Sets <see cref="AzureWebappConfigConnectionStringSetSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappConfigConnectionStringSetSettings SetSlot(this AzureWebappConfigConnectionStringSetSettings toolSettings, string slot)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = slot;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigConnectionStringSetSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappConfigConnectionStringSetSettings ResetSlot(this AzureWebappConfigConnectionStringSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = null;
            return toolSettings;
        }
        #endregion
        #region SlotSettings
        /// <summary><p><em>Sets <see cref="AzureWebappConfigConnectionStringSetSettings.SlotSettings"/>.</em></p><p>Space-separated slot connection-string in a format of &lt;name&gt;=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureWebappConfigConnectionStringSetSettings SetSlotSettings(this AzureWebappConfigConnectionStringSetSettings toolSettings, string slotSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SlotSettings = slotSettings;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigConnectionStringSetSettings.SlotSettings"/>.</em></p><p>Space-separated slot connection-string in a format of &lt;name&gt;=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureWebappConfigConnectionStringSetSettings ResetSlotSettings(this AzureWebappConfigConnectionStringSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SlotSettings = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureWebappConfigConnectionStringSetSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigConnectionStringSetSettings SetDebug(this AzureWebappConfigConnectionStringSetSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigConnectionStringSetSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigConnectionStringSetSettings ResetDebug(this AzureWebappConfigConnectionStringSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureWebappConfigConnectionStringSetSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappConfigConnectionStringSetSettings SetHelp(this AzureWebappConfigConnectionStringSetSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigConnectionStringSetSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappConfigConnectionStringSetSettings ResetHelp(this AzureWebappConfigConnectionStringSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureWebappConfigConnectionStringSetSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappConfigConnectionStringSetSettings SetOutput(this AzureWebappConfigConnectionStringSetSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigConnectionStringSetSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappConfigConnectionStringSetSettings ResetOutput(this AzureWebappConfigConnectionStringSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureWebappConfigConnectionStringSetSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappConfigConnectionStringSetSettings SetQuery(this AzureWebappConfigConnectionStringSetSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigConnectionStringSetSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappConfigConnectionStringSetSettings ResetQuery(this AzureWebappConfigConnectionStringSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureWebappConfigConnectionStringSetSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigConnectionStringSetSettings SetVerbose(this AzureWebappConfigConnectionStringSetSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigConnectionStringSetSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigConnectionStringSetSettings ResetVerbose(this AzureWebappConfigConnectionStringSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureWebappConfigContainerDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureWebappConfigContainerDeleteSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureWebappConfigContainerDeleteSettings.Name"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappConfigContainerDeleteSettings SetName(this AzureWebappConfigContainerDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigContainerDeleteSettings.Name"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappConfigContainerDeleteSettings ResetName(this AzureWebappConfigContainerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureWebappConfigContainerDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappConfigContainerDeleteSettings SetResourceGroup(this AzureWebappConfigContainerDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigContainerDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappConfigContainerDeleteSettings ResetResourceGroup(this AzureWebappConfigContainerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Slot
        /// <summary><p><em>Sets <see cref="AzureWebappConfigContainerDeleteSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappConfigContainerDeleteSettings SetSlot(this AzureWebappConfigContainerDeleteSettings toolSettings, string slot)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = slot;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigContainerDeleteSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappConfigContainerDeleteSettings ResetSlot(this AzureWebappConfigContainerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureWebappConfigContainerDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigContainerDeleteSettings SetDebug(this AzureWebappConfigContainerDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigContainerDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigContainerDeleteSettings ResetDebug(this AzureWebappConfigContainerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureWebappConfigContainerDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappConfigContainerDeleteSettings SetHelp(this AzureWebappConfigContainerDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigContainerDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappConfigContainerDeleteSettings ResetHelp(this AzureWebappConfigContainerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureWebappConfigContainerDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappConfigContainerDeleteSettings SetOutput(this AzureWebappConfigContainerDeleteSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigContainerDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappConfigContainerDeleteSettings ResetOutput(this AzureWebappConfigContainerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureWebappConfigContainerDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappConfigContainerDeleteSettings SetQuery(this AzureWebappConfigContainerDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigContainerDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappConfigContainerDeleteSettings ResetQuery(this AzureWebappConfigContainerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureWebappConfigContainerDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigContainerDeleteSettings SetVerbose(this AzureWebappConfigContainerDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigContainerDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigContainerDeleteSettings ResetVerbose(this AzureWebappConfigContainerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureWebappConfigContainerSetSettingsExtensions
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureWebappConfigContainerSetSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureWebappConfigContainerSetSettings.Name"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappConfigContainerSetSettings SetName(this AzureWebappConfigContainerSetSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigContainerSetSettings.Name"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappConfigContainerSetSettings ResetName(this AzureWebappConfigContainerSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureWebappConfigContainerSetSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappConfigContainerSetSettings SetResourceGroup(this AzureWebappConfigContainerSetSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigContainerSetSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappConfigContainerSetSettings ResetResourceGroup(this AzureWebappConfigContainerSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region DockerCustomImageName
        /// <summary><p><em>Sets <see cref="AzureWebappConfigContainerSetSettings.DockerCustomImageName"/>.</em></p><p>The container custom image name and optionally the tag name.</p></summary>
        [Pure]
        public static AzureWebappConfigContainerSetSettings SetDockerCustomImageName(this AzureWebappConfigContainerSetSettings toolSettings, string dockerCustomImageName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DockerCustomImageName = dockerCustomImageName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigContainerSetSettings.DockerCustomImageName"/>.</em></p><p>The container custom image name and optionally the tag name.</p></summary>
        [Pure]
        public static AzureWebappConfigContainerSetSettings ResetDockerCustomImageName(this AzureWebappConfigContainerSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DockerCustomImageName = null;
            return toolSettings;
        }
        #endregion
        #region DockerRegistryServerPassword
        /// <summary><p><em>Sets <see cref="AzureWebappConfigContainerSetSettings.DockerRegistryServerPassword"/>.</em></p><p>The container registry server password.</p></summary>
        [Pure]
        public static AzureWebappConfigContainerSetSettings SetDockerRegistryServerPassword(this AzureWebappConfigContainerSetSettings toolSettings, string dockerRegistryServerPassword)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DockerRegistryServerPassword = dockerRegistryServerPassword;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigContainerSetSettings.DockerRegistryServerPassword"/>.</em></p><p>The container registry server password.</p></summary>
        [Pure]
        public static AzureWebappConfigContainerSetSettings ResetDockerRegistryServerPassword(this AzureWebappConfigContainerSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DockerRegistryServerPassword = null;
            return toolSettings;
        }
        #endregion
        #region DockerRegistryServerUrl
        /// <summary><p><em>Sets <see cref="AzureWebappConfigContainerSetSettings.DockerRegistryServerUrl"/>.</em></p><p>The container registry server url.</p></summary>
        [Pure]
        public static AzureWebappConfigContainerSetSettings SetDockerRegistryServerUrl(this AzureWebappConfigContainerSetSettings toolSettings, string dockerRegistryServerUrl)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DockerRegistryServerUrl = dockerRegistryServerUrl;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigContainerSetSettings.DockerRegistryServerUrl"/>.</em></p><p>The container registry server url.</p></summary>
        [Pure]
        public static AzureWebappConfigContainerSetSettings ResetDockerRegistryServerUrl(this AzureWebappConfigContainerSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DockerRegistryServerUrl = null;
            return toolSettings;
        }
        #endregion
        #region DockerRegistryServerUser
        /// <summary><p><em>Sets <see cref="AzureWebappConfigContainerSetSettings.DockerRegistryServerUser"/>.</em></p><p>The container registry server username.</p></summary>
        [Pure]
        public static AzureWebappConfigContainerSetSettings SetDockerRegistryServerUser(this AzureWebappConfigContainerSetSettings toolSettings, string dockerRegistryServerUser)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DockerRegistryServerUser = dockerRegistryServerUser;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigContainerSetSettings.DockerRegistryServerUser"/>.</em></p><p>The container registry server username.</p></summary>
        [Pure]
        public static AzureWebappConfigContainerSetSettings ResetDockerRegistryServerUser(this AzureWebappConfigContainerSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DockerRegistryServerUser = null;
            return toolSettings;
        }
        #endregion
        #region EnableAppServiceStorage
        /// <summary><p><em>Sets <see cref="AzureWebappConfigContainerSetSettings.EnableAppServiceStorage"/>.</em></p><p>Enables platform storage (custom container only).</p></summary>
        [Pure]
        public static AzureWebappConfigContainerSetSettings SetEnableAppServiceStorage(this AzureWebappConfigContainerSetSettings toolSettings, bool? enableAppServiceStorage)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableAppServiceStorage = enableAppServiceStorage;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigContainerSetSettings.EnableAppServiceStorage"/>.</em></p><p>Enables platform storage (custom container only).</p></summary>
        [Pure]
        public static AzureWebappConfigContainerSetSettings ResetEnableAppServiceStorage(this AzureWebappConfigContainerSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableAppServiceStorage = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureWebappConfigContainerSetSettings.EnableAppServiceStorage"/>.</em></p><p>Enables platform storage (custom container only).</p></summary>
        [Pure]
        public static AzureWebappConfigContainerSetSettings EnableEnableAppServiceStorage(this AzureWebappConfigContainerSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableAppServiceStorage = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureWebappConfigContainerSetSettings.EnableAppServiceStorage"/>.</em></p><p>Enables platform storage (custom container only).</p></summary>
        [Pure]
        public static AzureWebappConfigContainerSetSettings DisableEnableAppServiceStorage(this AzureWebappConfigContainerSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableAppServiceStorage = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureWebappConfigContainerSetSettings.EnableAppServiceStorage"/>.</em></p><p>Enables platform storage (custom container only).</p></summary>
        [Pure]
        public static AzureWebappConfigContainerSetSettings ToggleEnableAppServiceStorage(this AzureWebappConfigContainerSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableAppServiceStorage = !toolSettings.EnableAppServiceStorage;
            return toolSettings;
        }
        #endregion
        #region MulticontainerConfigFile
        /// <summary><p><em>Sets <see cref="AzureWebappConfigContainerSetSettings.MulticontainerConfigFile"/>.</em></p><p>Config file for multicontainer apps.</p></summary>
        [Pure]
        public static AzureWebappConfigContainerSetSettings SetMulticontainerConfigFile(this AzureWebappConfigContainerSetSettings toolSettings, string multicontainerConfigFile)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MulticontainerConfigFile = multicontainerConfigFile;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigContainerSetSettings.MulticontainerConfigFile"/>.</em></p><p>Config file for multicontainer apps.</p></summary>
        [Pure]
        public static AzureWebappConfigContainerSetSettings ResetMulticontainerConfigFile(this AzureWebappConfigContainerSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MulticontainerConfigFile = null;
            return toolSettings;
        }
        #endregion
        #region MulticontainerConfigType
        /// <summary><p><em>Sets <see cref="AzureWebappConfigContainerSetSettings.MulticontainerConfigType"/>.</em></p><p>Config type.</p></summary>
        [Pure]
        public static AzureWebappConfigContainerSetSettings SetMulticontainerConfigType(this AzureWebappConfigContainerSetSettings toolSettings, WebappMulticontainerConfigType multicontainerConfigType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MulticontainerConfigType = multicontainerConfigType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigContainerSetSettings.MulticontainerConfigType"/>.</em></p><p>Config type.</p></summary>
        [Pure]
        public static AzureWebappConfigContainerSetSettings ResetMulticontainerConfigType(this AzureWebappConfigContainerSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MulticontainerConfigType = null;
            return toolSettings;
        }
        #endregion
        #region Slot
        /// <summary><p><em>Sets <see cref="AzureWebappConfigContainerSetSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappConfigContainerSetSettings SetSlot(this AzureWebappConfigContainerSetSettings toolSettings, string slot)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = slot;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigContainerSetSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappConfigContainerSetSettings ResetSlot(this AzureWebappConfigContainerSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureWebappConfigContainerSetSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigContainerSetSettings SetDebug(this AzureWebappConfigContainerSetSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigContainerSetSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigContainerSetSettings ResetDebug(this AzureWebappConfigContainerSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureWebappConfigContainerSetSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappConfigContainerSetSettings SetHelp(this AzureWebappConfigContainerSetSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigContainerSetSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappConfigContainerSetSettings ResetHelp(this AzureWebappConfigContainerSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureWebappConfigContainerSetSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappConfigContainerSetSettings SetOutput(this AzureWebappConfigContainerSetSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigContainerSetSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappConfigContainerSetSettings ResetOutput(this AzureWebappConfigContainerSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureWebappConfigContainerSetSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappConfigContainerSetSettings SetQuery(this AzureWebappConfigContainerSetSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigContainerSetSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappConfigContainerSetSettings ResetQuery(this AzureWebappConfigContainerSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureWebappConfigContainerSetSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigContainerSetSettings SetVerbose(this AzureWebappConfigContainerSetSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigContainerSetSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigContainerSetSettings ResetVerbose(this AzureWebappConfigContainerSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureWebappConfigContainerShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureWebappConfigContainerShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureWebappConfigContainerShowSettings.Name"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappConfigContainerShowSettings SetName(this AzureWebappConfigContainerShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigContainerShowSettings.Name"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappConfigContainerShowSettings ResetName(this AzureWebappConfigContainerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureWebappConfigContainerShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappConfigContainerShowSettings SetResourceGroup(this AzureWebappConfigContainerShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigContainerShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappConfigContainerShowSettings ResetResourceGroup(this AzureWebappConfigContainerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ShowMulticontainerConfig
        /// <summary><p><em>Sets <see cref="AzureWebappConfigContainerShowSettings.ShowMulticontainerConfig"/>.</em></p><p>Shows decoded config if a multicontainer config is set.</p></summary>
        [Pure]
        public static AzureWebappConfigContainerShowSettings SetShowMulticontainerConfig(this AzureWebappConfigContainerShowSettings toolSettings, string showMulticontainerConfig)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowMulticontainerConfig = showMulticontainerConfig;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigContainerShowSettings.ShowMulticontainerConfig"/>.</em></p><p>Shows decoded config if a multicontainer config is set.</p></summary>
        [Pure]
        public static AzureWebappConfigContainerShowSettings ResetShowMulticontainerConfig(this AzureWebappConfigContainerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowMulticontainerConfig = null;
            return toolSettings;
        }
        #endregion
        #region Slot
        /// <summary><p><em>Sets <see cref="AzureWebappConfigContainerShowSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappConfigContainerShowSettings SetSlot(this AzureWebappConfigContainerShowSettings toolSettings, string slot)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = slot;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigContainerShowSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappConfigContainerShowSettings ResetSlot(this AzureWebappConfigContainerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureWebappConfigContainerShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigContainerShowSettings SetDebug(this AzureWebappConfigContainerShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigContainerShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigContainerShowSettings ResetDebug(this AzureWebappConfigContainerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureWebappConfigContainerShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappConfigContainerShowSettings SetHelp(this AzureWebappConfigContainerShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigContainerShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappConfigContainerShowSettings ResetHelp(this AzureWebappConfigContainerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureWebappConfigContainerShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappConfigContainerShowSettings SetOutput(this AzureWebappConfigContainerShowSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigContainerShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappConfigContainerShowSettings ResetOutput(this AzureWebappConfigContainerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureWebappConfigContainerShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappConfigContainerShowSettings SetQuery(this AzureWebappConfigContainerShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigContainerShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappConfigContainerShowSettings ResetQuery(this AzureWebappConfigContainerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureWebappConfigContainerShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigContainerShowSettings SetVerbose(this AzureWebappConfigContainerShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigContainerShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigContainerShowSettings ResetVerbose(this AzureWebappConfigContainerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureWebappConfigHostnameAddSettingsExtensions
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureWebappConfigHostnameAddSettingsExtensions
    {
        #region Hostname
        /// <summary><p><em>Sets <see cref="AzureWebappConfigHostnameAddSettings.Hostname"/>.</em></p><p>Hostname assigned to the site, such as custom domains.</p></summary>
        [Pure]
        public static AzureWebappConfigHostnameAddSettings SetHostname(this AzureWebappConfigHostnameAddSettings toolSettings, string hostname)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Hostname = hostname;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigHostnameAddSettings.Hostname"/>.</em></p><p>Hostname assigned to the site, such as custom domains.</p></summary>
        [Pure]
        public static AzureWebappConfigHostnameAddSettings ResetHostname(this AzureWebappConfigHostnameAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Hostname = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureWebappConfigHostnameAddSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappConfigHostnameAddSettings SetResourceGroup(this AzureWebappConfigHostnameAddSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigHostnameAddSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappConfigHostnameAddSettings ResetResourceGroup(this AzureWebappConfigHostnameAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region WebappName
        /// <summary><p><em>Sets <see cref="AzureWebappConfigHostnameAddSettings.WebappName"/>.</em></p><p>Webapp name. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappConfigHostnameAddSettings SetWebappName(this AzureWebappConfigHostnameAddSettings toolSettings, string webappName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WebappName = webappName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigHostnameAddSettings.WebappName"/>.</em></p><p>Webapp name. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappConfigHostnameAddSettings ResetWebappName(this AzureWebappConfigHostnameAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WebappName = null;
            return toolSettings;
        }
        #endregion
        #region Slot
        /// <summary><p><em>Sets <see cref="AzureWebappConfigHostnameAddSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappConfigHostnameAddSettings SetSlot(this AzureWebappConfigHostnameAddSettings toolSettings, string slot)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = slot;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigHostnameAddSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappConfigHostnameAddSettings ResetSlot(this AzureWebappConfigHostnameAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureWebappConfigHostnameAddSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigHostnameAddSettings SetDebug(this AzureWebappConfigHostnameAddSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigHostnameAddSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigHostnameAddSettings ResetDebug(this AzureWebappConfigHostnameAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureWebappConfigHostnameAddSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappConfigHostnameAddSettings SetHelp(this AzureWebappConfigHostnameAddSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigHostnameAddSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappConfigHostnameAddSettings ResetHelp(this AzureWebappConfigHostnameAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureWebappConfigHostnameAddSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappConfigHostnameAddSettings SetOutput(this AzureWebappConfigHostnameAddSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigHostnameAddSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappConfigHostnameAddSettings ResetOutput(this AzureWebappConfigHostnameAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureWebappConfigHostnameAddSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappConfigHostnameAddSettings SetQuery(this AzureWebappConfigHostnameAddSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigHostnameAddSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappConfigHostnameAddSettings ResetQuery(this AzureWebappConfigHostnameAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureWebappConfigHostnameAddSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigHostnameAddSettings SetVerbose(this AzureWebappConfigHostnameAddSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigHostnameAddSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigHostnameAddSettings ResetVerbose(this AzureWebappConfigHostnameAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureWebappConfigHostnameDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureWebappConfigHostnameDeleteSettingsExtensions
    {
        #region Hostname
        /// <summary><p><em>Sets <see cref="AzureWebappConfigHostnameDeleteSettings.Hostname"/>.</em></p><p>Hostname assigned to the site, such as custom domains.</p></summary>
        [Pure]
        public static AzureWebappConfigHostnameDeleteSettings SetHostname(this AzureWebappConfigHostnameDeleteSettings toolSettings, string hostname)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Hostname = hostname;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigHostnameDeleteSettings.Hostname"/>.</em></p><p>Hostname assigned to the site, such as custom domains.</p></summary>
        [Pure]
        public static AzureWebappConfigHostnameDeleteSettings ResetHostname(this AzureWebappConfigHostnameDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Hostname = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureWebappConfigHostnameDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappConfigHostnameDeleteSettings SetResourceGroup(this AzureWebappConfigHostnameDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigHostnameDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappConfigHostnameDeleteSettings ResetResourceGroup(this AzureWebappConfigHostnameDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region WebappName
        /// <summary><p><em>Sets <see cref="AzureWebappConfigHostnameDeleteSettings.WebappName"/>.</em></p><p>Webapp name. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappConfigHostnameDeleteSettings SetWebappName(this AzureWebappConfigHostnameDeleteSettings toolSettings, string webappName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WebappName = webappName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigHostnameDeleteSettings.WebappName"/>.</em></p><p>Webapp name. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappConfigHostnameDeleteSettings ResetWebappName(this AzureWebappConfigHostnameDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WebappName = null;
            return toolSettings;
        }
        #endregion
        #region Slot
        /// <summary><p><em>Sets <see cref="AzureWebappConfigHostnameDeleteSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappConfigHostnameDeleteSettings SetSlot(this AzureWebappConfigHostnameDeleteSettings toolSettings, string slot)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = slot;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigHostnameDeleteSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappConfigHostnameDeleteSettings ResetSlot(this AzureWebappConfigHostnameDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureWebappConfigHostnameDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigHostnameDeleteSettings SetDebug(this AzureWebappConfigHostnameDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigHostnameDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigHostnameDeleteSettings ResetDebug(this AzureWebappConfigHostnameDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureWebappConfigHostnameDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappConfigHostnameDeleteSettings SetHelp(this AzureWebappConfigHostnameDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigHostnameDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappConfigHostnameDeleteSettings ResetHelp(this AzureWebappConfigHostnameDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureWebappConfigHostnameDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappConfigHostnameDeleteSettings SetOutput(this AzureWebappConfigHostnameDeleteSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigHostnameDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappConfigHostnameDeleteSettings ResetOutput(this AzureWebappConfigHostnameDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureWebappConfigHostnameDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappConfigHostnameDeleteSettings SetQuery(this AzureWebappConfigHostnameDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigHostnameDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappConfigHostnameDeleteSettings ResetQuery(this AzureWebappConfigHostnameDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureWebappConfigHostnameDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigHostnameDeleteSettings SetVerbose(this AzureWebappConfigHostnameDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigHostnameDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigHostnameDeleteSettings ResetVerbose(this AzureWebappConfigHostnameDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureWebappConfigHostnameGetExternalIpSettingsExtensions
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureWebappConfigHostnameGetExternalIpSettingsExtensions
    {
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureWebappConfigHostnameGetExternalIpSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappConfigHostnameGetExternalIpSettings SetResourceGroup(this AzureWebappConfigHostnameGetExternalIpSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigHostnameGetExternalIpSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappConfigHostnameGetExternalIpSettings ResetResourceGroup(this AzureWebappConfigHostnameGetExternalIpSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region WebappName
        /// <summary><p><em>Sets <see cref="AzureWebappConfigHostnameGetExternalIpSettings.WebappName"/>.</em></p><p>Webapp name. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappConfigHostnameGetExternalIpSettings SetWebappName(this AzureWebappConfigHostnameGetExternalIpSettings toolSettings, string webappName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WebappName = webappName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigHostnameGetExternalIpSettings.WebappName"/>.</em></p><p>Webapp name. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappConfigHostnameGetExternalIpSettings ResetWebappName(this AzureWebappConfigHostnameGetExternalIpSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WebappName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureWebappConfigHostnameGetExternalIpSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigHostnameGetExternalIpSettings SetDebug(this AzureWebappConfigHostnameGetExternalIpSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigHostnameGetExternalIpSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigHostnameGetExternalIpSettings ResetDebug(this AzureWebappConfigHostnameGetExternalIpSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureWebappConfigHostnameGetExternalIpSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappConfigHostnameGetExternalIpSettings SetHelp(this AzureWebappConfigHostnameGetExternalIpSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigHostnameGetExternalIpSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappConfigHostnameGetExternalIpSettings ResetHelp(this AzureWebappConfigHostnameGetExternalIpSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureWebappConfigHostnameGetExternalIpSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappConfigHostnameGetExternalIpSettings SetOutput(this AzureWebappConfigHostnameGetExternalIpSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigHostnameGetExternalIpSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappConfigHostnameGetExternalIpSettings ResetOutput(this AzureWebappConfigHostnameGetExternalIpSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureWebappConfigHostnameGetExternalIpSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappConfigHostnameGetExternalIpSettings SetQuery(this AzureWebappConfigHostnameGetExternalIpSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigHostnameGetExternalIpSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappConfigHostnameGetExternalIpSettings ResetQuery(this AzureWebappConfigHostnameGetExternalIpSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureWebappConfigHostnameGetExternalIpSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigHostnameGetExternalIpSettings SetVerbose(this AzureWebappConfigHostnameGetExternalIpSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigHostnameGetExternalIpSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigHostnameGetExternalIpSettings ResetVerbose(this AzureWebappConfigHostnameGetExternalIpSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureWebappConfigHostnameListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureWebappConfigHostnameListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureWebappConfigHostnameListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappConfigHostnameListSettings SetResourceGroup(this AzureWebappConfigHostnameListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigHostnameListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappConfigHostnameListSettings ResetResourceGroup(this AzureWebappConfigHostnameListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region WebappName
        /// <summary><p><em>Sets <see cref="AzureWebappConfigHostnameListSettings.WebappName"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappConfigHostnameListSettings SetWebappName(this AzureWebappConfigHostnameListSettings toolSettings, string webappName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WebappName = webappName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigHostnameListSettings.WebappName"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappConfigHostnameListSettings ResetWebappName(this AzureWebappConfigHostnameListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WebappName = null;
            return toolSettings;
        }
        #endregion
        #region Slot
        /// <summary><p><em>Sets <see cref="AzureWebappConfigHostnameListSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappConfigHostnameListSettings SetSlot(this AzureWebappConfigHostnameListSettings toolSettings, string slot)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = slot;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigHostnameListSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappConfigHostnameListSettings ResetSlot(this AzureWebappConfigHostnameListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureWebappConfigHostnameListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigHostnameListSettings SetDebug(this AzureWebappConfigHostnameListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigHostnameListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigHostnameListSettings ResetDebug(this AzureWebappConfigHostnameListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureWebappConfigHostnameListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappConfigHostnameListSettings SetHelp(this AzureWebappConfigHostnameListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigHostnameListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappConfigHostnameListSettings ResetHelp(this AzureWebappConfigHostnameListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureWebappConfigHostnameListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappConfigHostnameListSettings SetOutput(this AzureWebappConfigHostnameListSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigHostnameListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappConfigHostnameListSettings ResetOutput(this AzureWebappConfigHostnameListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureWebappConfigHostnameListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappConfigHostnameListSettings SetQuery(this AzureWebappConfigHostnameListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigHostnameListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappConfigHostnameListSettings ResetQuery(this AzureWebappConfigHostnameListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureWebappConfigHostnameListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigHostnameListSettings SetVerbose(this AzureWebappConfigHostnameListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigHostnameListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigHostnameListSettings ResetVerbose(this AzureWebappConfigHostnameListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureWebappConfigSslBindSettingsExtensions
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureWebappConfigSslBindSettingsExtensions
    {
        #region CertificateThumbprint
        /// <summary><p><em>Sets <see cref="AzureWebappConfigSslBindSettings.CertificateThumbprint"/>.</em></p><p>The ssl cert thumbprint.</p></summary>
        [Pure]
        public static AzureWebappConfigSslBindSettings SetCertificateThumbprint(this AzureWebappConfigSslBindSettings toolSettings, string certificateThumbprint)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertificateThumbprint = certificateThumbprint;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigSslBindSettings.CertificateThumbprint"/>.</em></p><p>The ssl cert thumbprint.</p></summary>
        [Pure]
        public static AzureWebappConfigSslBindSettings ResetCertificateThumbprint(this AzureWebappConfigSslBindSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertificateThumbprint = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureWebappConfigSslBindSettings.Name"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappConfigSslBindSettings SetName(this AzureWebappConfigSslBindSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigSslBindSettings.Name"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappConfigSslBindSettings ResetName(this AzureWebappConfigSslBindSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureWebappConfigSslBindSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappConfigSslBindSettings SetResourceGroup(this AzureWebappConfigSslBindSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigSslBindSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappConfigSslBindSettings ResetResourceGroup(this AzureWebappConfigSslBindSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region SslType
        /// <summary><p><em>Sets <see cref="AzureWebappConfigSslBindSettings.SslType"/>.</em></p><p>The ssl cert type.</p></summary>
        [Pure]
        public static AzureWebappConfigSslBindSettings SetSslType(this AzureWebappConfigSslBindSettings toolSettings, WebappConfigSslBindSslType sslType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SslType = sslType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigSslBindSettings.SslType"/>.</em></p><p>The ssl cert type.</p></summary>
        [Pure]
        public static AzureWebappConfigSslBindSettings ResetSslType(this AzureWebappConfigSslBindSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SslType = null;
            return toolSettings;
        }
        #endregion
        #region Slot
        /// <summary><p><em>Sets <see cref="AzureWebappConfigSslBindSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappConfigSslBindSettings SetSlot(this AzureWebappConfigSslBindSettings toolSettings, string slot)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = slot;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigSslBindSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappConfigSslBindSettings ResetSlot(this AzureWebappConfigSslBindSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureWebappConfigSslBindSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigSslBindSettings SetDebug(this AzureWebappConfigSslBindSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigSslBindSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigSslBindSettings ResetDebug(this AzureWebappConfigSslBindSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureWebappConfigSslBindSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappConfigSslBindSettings SetHelp(this AzureWebappConfigSslBindSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigSslBindSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappConfigSslBindSettings ResetHelp(this AzureWebappConfigSslBindSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureWebappConfigSslBindSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappConfigSslBindSettings SetOutput(this AzureWebappConfigSslBindSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigSslBindSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappConfigSslBindSettings ResetOutput(this AzureWebappConfigSslBindSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureWebappConfigSslBindSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappConfigSslBindSettings SetQuery(this AzureWebappConfigSslBindSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigSslBindSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappConfigSslBindSettings ResetQuery(this AzureWebappConfigSslBindSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureWebappConfigSslBindSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigSslBindSettings SetVerbose(this AzureWebappConfigSslBindSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigSslBindSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigSslBindSettings ResetVerbose(this AzureWebappConfigSslBindSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureWebappConfigSslDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureWebappConfigSslDeleteSettingsExtensions
    {
        #region CertificateThumbprint
        /// <summary><p><em>Sets <see cref="AzureWebappConfigSslDeleteSettings.CertificateThumbprint"/>.</em></p><p>The ssl cert thumbprint.</p></summary>
        [Pure]
        public static AzureWebappConfigSslDeleteSettings SetCertificateThumbprint(this AzureWebappConfigSslDeleteSettings toolSettings, string certificateThumbprint)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertificateThumbprint = certificateThumbprint;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigSslDeleteSettings.CertificateThumbprint"/>.</em></p><p>The ssl cert thumbprint.</p></summary>
        [Pure]
        public static AzureWebappConfigSslDeleteSettings ResetCertificateThumbprint(this AzureWebappConfigSslDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertificateThumbprint = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureWebappConfigSslDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappConfigSslDeleteSettings SetResourceGroup(this AzureWebappConfigSslDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigSslDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappConfigSslDeleteSettings ResetResourceGroup(this AzureWebappConfigSslDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureWebappConfigSslDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigSslDeleteSettings SetDebug(this AzureWebappConfigSslDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigSslDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigSslDeleteSettings ResetDebug(this AzureWebappConfigSslDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureWebappConfigSslDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappConfigSslDeleteSettings SetHelp(this AzureWebappConfigSslDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigSslDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappConfigSslDeleteSettings ResetHelp(this AzureWebappConfigSslDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureWebappConfigSslDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappConfigSslDeleteSettings SetOutput(this AzureWebappConfigSslDeleteSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigSslDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappConfigSslDeleteSettings ResetOutput(this AzureWebappConfigSslDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureWebappConfigSslDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappConfigSslDeleteSettings SetQuery(this AzureWebappConfigSslDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigSslDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappConfigSslDeleteSettings ResetQuery(this AzureWebappConfigSslDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureWebappConfigSslDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigSslDeleteSettings SetVerbose(this AzureWebappConfigSslDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigSslDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigSslDeleteSettings ResetVerbose(this AzureWebappConfigSslDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureWebappConfigSslListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureWebappConfigSslListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureWebappConfigSslListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappConfigSslListSettings SetResourceGroup(this AzureWebappConfigSslListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigSslListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappConfigSslListSettings ResetResourceGroup(this AzureWebappConfigSslListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureWebappConfigSslListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigSslListSettings SetDebug(this AzureWebappConfigSslListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigSslListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigSslListSettings ResetDebug(this AzureWebappConfigSslListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureWebappConfigSslListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappConfigSslListSettings SetHelp(this AzureWebappConfigSslListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigSslListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappConfigSslListSettings ResetHelp(this AzureWebappConfigSslListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureWebappConfigSslListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappConfigSslListSettings SetOutput(this AzureWebappConfigSslListSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigSslListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappConfigSslListSettings ResetOutput(this AzureWebappConfigSslListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureWebappConfigSslListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappConfigSslListSettings SetQuery(this AzureWebappConfigSslListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigSslListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappConfigSslListSettings ResetQuery(this AzureWebappConfigSslListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureWebappConfigSslListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigSslListSettings SetVerbose(this AzureWebappConfigSslListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigSslListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigSslListSettings ResetVerbose(this AzureWebappConfigSslListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureWebappConfigSslUnbindSettingsExtensions
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureWebappConfigSslUnbindSettingsExtensions
    {
        #region CertificateThumbprint
        /// <summary><p><em>Sets <see cref="AzureWebappConfigSslUnbindSettings.CertificateThumbprint"/>.</em></p><p>The ssl cert thumbprint.</p></summary>
        [Pure]
        public static AzureWebappConfigSslUnbindSettings SetCertificateThumbprint(this AzureWebappConfigSslUnbindSettings toolSettings, string certificateThumbprint)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertificateThumbprint = certificateThumbprint;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigSslUnbindSettings.CertificateThumbprint"/>.</em></p><p>The ssl cert thumbprint.</p></summary>
        [Pure]
        public static AzureWebappConfigSslUnbindSettings ResetCertificateThumbprint(this AzureWebappConfigSslUnbindSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertificateThumbprint = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureWebappConfigSslUnbindSettings.Name"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappConfigSslUnbindSettings SetName(this AzureWebappConfigSslUnbindSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigSslUnbindSettings.Name"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappConfigSslUnbindSettings ResetName(this AzureWebappConfigSslUnbindSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureWebappConfigSslUnbindSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappConfigSslUnbindSettings SetResourceGroup(this AzureWebappConfigSslUnbindSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigSslUnbindSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappConfigSslUnbindSettings ResetResourceGroup(this AzureWebappConfigSslUnbindSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Slot
        /// <summary><p><em>Sets <see cref="AzureWebappConfigSslUnbindSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappConfigSslUnbindSettings SetSlot(this AzureWebappConfigSslUnbindSettings toolSettings, string slot)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = slot;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigSslUnbindSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappConfigSslUnbindSettings ResetSlot(this AzureWebappConfigSslUnbindSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureWebappConfigSslUnbindSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigSslUnbindSettings SetDebug(this AzureWebappConfigSslUnbindSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigSslUnbindSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigSslUnbindSettings ResetDebug(this AzureWebappConfigSslUnbindSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureWebappConfigSslUnbindSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappConfigSslUnbindSettings SetHelp(this AzureWebappConfigSslUnbindSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigSslUnbindSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappConfigSslUnbindSettings ResetHelp(this AzureWebappConfigSslUnbindSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureWebappConfigSslUnbindSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappConfigSslUnbindSettings SetOutput(this AzureWebappConfigSslUnbindSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigSslUnbindSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappConfigSslUnbindSettings ResetOutput(this AzureWebappConfigSslUnbindSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureWebappConfigSslUnbindSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappConfigSslUnbindSettings SetQuery(this AzureWebappConfigSslUnbindSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigSslUnbindSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappConfigSslUnbindSettings ResetQuery(this AzureWebappConfigSslUnbindSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureWebappConfigSslUnbindSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigSslUnbindSettings SetVerbose(this AzureWebappConfigSslUnbindSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigSslUnbindSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigSslUnbindSettings ResetVerbose(this AzureWebappConfigSslUnbindSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureWebappConfigSslUploadSettingsExtensions
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureWebappConfigSslUploadSettingsExtensions
    {
        #region CertificateFile
        /// <summary><p><em>Sets <see cref="AzureWebappConfigSslUploadSettings.CertificateFile"/>.</em></p><p>The filepath for the .pfx file.</p></summary>
        [Pure]
        public static AzureWebappConfigSslUploadSettings SetCertificateFile(this AzureWebappConfigSslUploadSettings toolSettings, string certificateFile)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertificateFile = certificateFile;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigSslUploadSettings.CertificateFile"/>.</em></p><p>The filepath for the .pfx file.</p></summary>
        [Pure]
        public static AzureWebappConfigSslUploadSettings ResetCertificateFile(this AzureWebappConfigSslUploadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertificateFile = null;
            return toolSettings;
        }
        #endregion
        #region CertificatePassword
        /// <summary><p><em>Sets <see cref="AzureWebappConfigSslUploadSettings.CertificatePassword"/>.</em></p><p>The ssl cert password.</p></summary>
        [Pure]
        public static AzureWebappConfigSslUploadSettings SetCertificatePassword(this AzureWebappConfigSslUploadSettings toolSettings, string certificatePassword)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertificatePassword = certificatePassword;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigSslUploadSettings.CertificatePassword"/>.</em></p><p>The ssl cert password.</p></summary>
        [Pure]
        public static AzureWebappConfigSslUploadSettings ResetCertificatePassword(this AzureWebappConfigSslUploadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertificatePassword = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureWebappConfigSslUploadSettings.Name"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappConfigSslUploadSettings SetName(this AzureWebappConfigSslUploadSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigSslUploadSettings.Name"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappConfigSslUploadSettings ResetName(this AzureWebappConfigSslUploadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureWebappConfigSslUploadSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappConfigSslUploadSettings SetResourceGroup(this AzureWebappConfigSslUploadSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigSslUploadSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappConfigSslUploadSettings ResetResourceGroup(this AzureWebappConfigSslUploadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureWebappConfigSslUploadSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigSslUploadSettings SetDebug(this AzureWebappConfigSslUploadSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigSslUploadSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigSslUploadSettings ResetDebug(this AzureWebappConfigSslUploadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureWebappConfigSslUploadSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappConfigSslUploadSettings SetHelp(this AzureWebappConfigSslUploadSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigSslUploadSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappConfigSslUploadSettings ResetHelp(this AzureWebappConfigSslUploadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureWebappConfigSslUploadSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappConfigSslUploadSettings SetOutput(this AzureWebappConfigSslUploadSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigSslUploadSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappConfigSslUploadSettings ResetOutput(this AzureWebappConfigSslUploadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureWebappConfigSslUploadSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappConfigSslUploadSettings SetQuery(this AzureWebappConfigSslUploadSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigSslUploadSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappConfigSslUploadSettings ResetQuery(this AzureWebappConfigSslUploadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureWebappConfigSslUploadSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigSslUploadSettings SetVerbose(this AzureWebappConfigSslUploadSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappConfigSslUploadSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappConfigSslUploadSettings ResetVerbose(this AzureWebappConfigSslUploadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureWebappDeploymentContainerConfigSettingsExtensions
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureWebappDeploymentContainerConfigSettingsExtensions
    {
        #region EnableCd
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentContainerConfigSettings.EnableCd"/>.</em></p><p>Enable/disable continuous deployment.</p></summary>
        [Pure]
        public static AzureWebappDeploymentContainerConfigSettings SetEnableCd(this AzureWebappDeploymentContainerConfigSettings toolSettings, bool? enableCd)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableCd = enableCd;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentContainerConfigSettings.EnableCd"/>.</em></p><p>Enable/disable continuous deployment.</p></summary>
        [Pure]
        public static AzureWebappDeploymentContainerConfigSettings ResetEnableCd(this AzureWebappDeploymentContainerConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableCd = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureWebappDeploymentContainerConfigSettings.EnableCd"/>.</em></p><p>Enable/disable continuous deployment.</p></summary>
        [Pure]
        public static AzureWebappDeploymentContainerConfigSettings EnableEnableCd(this AzureWebappDeploymentContainerConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableCd = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureWebappDeploymentContainerConfigSettings.EnableCd"/>.</em></p><p>Enable/disable continuous deployment.</p></summary>
        [Pure]
        public static AzureWebappDeploymentContainerConfigSettings DisableEnableCd(this AzureWebappDeploymentContainerConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableCd = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureWebappDeploymentContainerConfigSettings.EnableCd"/>.</em></p><p>Enable/disable continuous deployment.</p></summary>
        [Pure]
        public static AzureWebappDeploymentContainerConfigSettings ToggleEnableCd(this AzureWebappDeploymentContainerConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableCd = !toolSettings.EnableCd;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentContainerConfigSettings.Name"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappDeploymentContainerConfigSettings SetName(this AzureWebappDeploymentContainerConfigSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentContainerConfigSettings.Name"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappDeploymentContainerConfigSettings ResetName(this AzureWebappDeploymentContainerConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentContainerConfigSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappDeploymentContainerConfigSettings SetResourceGroup(this AzureWebappDeploymentContainerConfigSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentContainerConfigSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappDeploymentContainerConfigSettings ResetResourceGroup(this AzureWebappDeploymentContainerConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Slot
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentContainerConfigSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappDeploymentContainerConfigSettings SetSlot(this AzureWebappDeploymentContainerConfigSettings toolSettings, string slot)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = slot;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentContainerConfigSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappDeploymentContainerConfigSettings ResetSlot(this AzureWebappDeploymentContainerConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentContainerConfigSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappDeploymentContainerConfigSettings SetDebug(this AzureWebappDeploymentContainerConfigSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentContainerConfigSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappDeploymentContainerConfigSettings ResetDebug(this AzureWebappDeploymentContainerConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentContainerConfigSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappDeploymentContainerConfigSettings SetHelp(this AzureWebappDeploymentContainerConfigSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentContainerConfigSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappDeploymentContainerConfigSettings ResetHelp(this AzureWebappDeploymentContainerConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentContainerConfigSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappDeploymentContainerConfigSettings SetOutput(this AzureWebappDeploymentContainerConfigSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentContainerConfigSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappDeploymentContainerConfigSettings ResetOutput(this AzureWebappDeploymentContainerConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentContainerConfigSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappDeploymentContainerConfigSettings SetQuery(this AzureWebappDeploymentContainerConfigSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentContainerConfigSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappDeploymentContainerConfigSettings ResetQuery(this AzureWebappDeploymentContainerConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentContainerConfigSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappDeploymentContainerConfigSettings SetVerbose(this AzureWebappDeploymentContainerConfigSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentContainerConfigSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappDeploymentContainerConfigSettings ResetVerbose(this AzureWebappDeploymentContainerConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureWebappDeploymentContainerShowCdUrlSettingsExtensions
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureWebappDeploymentContainerShowCdUrlSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentContainerShowCdUrlSettings.Name"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappDeploymentContainerShowCdUrlSettings SetName(this AzureWebappDeploymentContainerShowCdUrlSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentContainerShowCdUrlSettings.Name"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappDeploymentContainerShowCdUrlSettings ResetName(this AzureWebappDeploymentContainerShowCdUrlSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentContainerShowCdUrlSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappDeploymentContainerShowCdUrlSettings SetResourceGroup(this AzureWebappDeploymentContainerShowCdUrlSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentContainerShowCdUrlSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappDeploymentContainerShowCdUrlSettings ResetResourceGroup(this AzureWebappDeploymentContainerShowCdUrlSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Slot
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentContainerShowCdUrlSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappDeploymentContainerShowCdUrlSettings SetSlot(this AzureWebappDeploymentContainerShowCdUrlSettings toolSettings, string slot)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = slot;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentContainerShowCdUrlSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappDeploymentContainerShowCdUrlSettings ResetSlot(this AzureWebappDeploymentContainerShowCdUrlSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentContainerShowCdUrlSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappDeploymentContainerShowCdUrlSettings SetDebug(this AzureWebappDeploymentContainerShowCdUrlSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentContainerShowCdUrlSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappDeploymentContainerShowCdUrlSettings ResetDebug(this AzureWebappDeploymentContainerShowCdUrlSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentContainerShowCdUrlSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappDeploymentContainerShowCdUrlSettings SetHelp(this AzureWebappDeploymentContainerShowCdUrlSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentContainerShowCdUrlSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappDeploymentContainerShowCdUrlSettings ResetHelp(this AzureWebappDeploymentContainerShowCdUrlSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentContainerShowCdUrlSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappDeploymentContainerShowCdUrlSettings SetOutput(this AzureWebappDeploymentContainerShowCdUrlSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentContainerShowCdUrlSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappDeploymentContainerShowCdUrlSettings ResetOutput(this AzureWebappDeploymentContainerShowCdUrlSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentContainerShowCdUrlSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappDeploymentContainerShowCdUrlSettings SetQuery(this AzureWebappDeploymentContainerShowCdUrlSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentContainerShowCdUrlSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappDeploymentContainerShowCdUrlSettings ResetQuery(this AzureWebappDeploymentContainerShowCdUrlSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentContainerShowCdUrlSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappDeploymentContainerShowCdUrlSettings SetVerbose(this AzureWebappDeploymentContainerShowCdUrlSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentContainerShowCdUrlSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappDeploymentContainerShowCdUrlSettings ResetVerbose(this AzureWebappDeploymentContainerShowCdUrlSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureWebappDeploymentSlotAutoSwapSettingsExtensions
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureWebappDeploymentSlotAutoSwapSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSlotAutoSwapSettings.Name"/>.</em></p><p>Name of the webapp.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotAutoSwapSettings SetName(this AzureWebappDeploymentSlotAutoSwapSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSlotAutoSwapSettings.Name"/>.</em></p><p>Name of the webapp.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotAutoSwapSettings ResetName(this AzureWebappDeploymentSlotAutoSwapSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSlotAutoSwapSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotAutoSwapSettings SetResourceGroup(this AzureWebappDeploymentSlotAutoSwapSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSlotAutoSwapSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotAutoSwapSettings ResetResourceGroup(this AzureWebappDeploymentSlotAutoSwapSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Slot
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSlotAutoSwapSettings.Slot"/>.</em></p><p>The name of the slot.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotAutoSwapSettings SetSlot(this AzureWebappDeploymentSlotAutoSwapSettings toolSettings, string slot)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = slot;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSlotAutoSwapSettings.Slot"/>.</em></p><p>The name of the slot.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotAutoSwapSettings ResetSlot(this AzureWebappDeploymentSlotAutoSwapSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = null;
            return toolSettings;
        }
        #endregion
        #region AutoSwapSlot
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSlotAutoSwapSettings.AutoSwapSlot"/>.</em></p><p>Target slot to auto swap.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotAutoSwapSettings SetAutoSwapSlot(this AzureWebappDeploymentSlotAutoSwapSettings toolSettings, string autoSwapSlot)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AutoSwapSlot = autoSwapSlot;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSlotAutoSwapSettings.AutoSwapSlot"/>.</em></p><p>Target slot to auto swap.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotAutoSwapSettings ResetAutoSwapSlot(this AzureWebappDeploymentSlotAutoSwapSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AutoSwapSlot = null;
            return toolSettings;
        }
        #endregion
        #region Disable
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSlotAutoSwapSettings.Disable"/>.</em></p><p>Disable auto swap.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotAutoSwapSettings SetDisable(this AzureWebappDeploymentSlotAutoSwapSettings toolSettings, string disable)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Disable = disable;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSlotAutoSwapSettings.Disable"/>.</em></p><p>Disable auto swap.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotAutoSwapSettings ResetDisable(this AzureWebappDeploymentSlotAutoSwapSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Disable = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSlotAutoSwapSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotAutoSwapSettings SetDebug(this AzureWebappDeploymentSlotAutoSwapSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSlotAutoSwapSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotAutoSwapSettings ResetDebug(this AzureWebappDeploymentSlotAutoSwapSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSlotAutoSwapSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotAutoSwapSettings SetHelp(this AzureWebappDeploymentSlotAutoSwapSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSlotAutoSwapSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotAutoSwapSettings ResetHelp(this AzureWebappDeploymentSlotAutoSwapSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSlotAutoSwapSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotAutoSwapSettings SetOutput(this AzureWebappDeploymentSlotAutoSwapSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSlotAutoSwapSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotAutoSwapSettings ResetOutput(this AzureWebappDeploymentSlotAutoSwapSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSlotAutoSwapSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotAutoSwapSettings SetQuery(this AzureWebappDeploymentSlotAutoSwapSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSlotAutoSwapSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotAutoSwapSettings ResetQuery(this AzureWebappDeploymentSlotAutoSwapSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSlotAutoSwapSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotAutoSwapSettings SetVerbose(this AzureWebappDeploymentSlotAutoSwapSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSlotAutoSwapSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotAutoSwapSettings ResetVerbose(this AzureWebappDeploymentSlotAutoSwapSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureWebappDeploymentSlotCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureWebappDeploymentSlotCreateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSlotCreateSettings.Name"/>.</em></p><p>Name of the webapp.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotCreateSettings SetName(this AzureWebappDeploymentSlotCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSlotCreateSettings.Name"/>.</em></p><p>Name of the webapp.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotCreateSettings ResetName(this AzureWebappDeploymentSlotCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSlotCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotCreateSettings SetResourceGroup(this AzureWebappDeploymentSlotCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSlotCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotCreateSettings ResetResourceGroup(this AzureWebappDeploymentSlotCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Slot
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSlotCreateSettings.Slot"/>.</em></p><p>The name of the slot.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotCreateSettings SetSlot(this AzureWebappDeploymentSlotCreateSettings toolSettings, string slot)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = slot;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSlotCreateSettings.Slot"/>.</em></p><p>The name of the slot.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotCreateSettings ResetSlot(this AzureWebappDeploymentSlotCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = null;
            return toolSettings;
        }
        #endregion
        #region ConfigurationSource
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSlotCreateSettings.ConfigurationSource"/>.</em></p><p>Source slot to clone configurations from. Use webapp's name to refer to the production slot.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotCreateSettings SetConfigurationSource(this AzureWebappDeploymentSlotCreateSettings toolSettings, string configurationSource)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ConfigurationSource = configurationSource;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSlotCreateSettings.ConfigurationSource"/>.</em></p><p>Source slot to clone configurations from. Use webapp's name to refer to the production slot.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotCreateSettings ResetConfigurationSource(this AzureWebappDeploymentSlotCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ConfigurationSource = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSlotCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotCreateSettings SetDebug(this AzureWebappDeploymentSlotCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSlotCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotCreateSettings ResetDebug(this AzureWebappDeploymentSlotCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSlotCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotCreateSettings SetHelp(this AzureWebappDeploymentSlotCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSlotCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotCreateSettings ResetHelp(this AzureWebappDeploymentSlotCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSlotCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotCreateSettings SetOutput(this AzureWebappDeploymentSlotCreateSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSlotCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotCreateSettings ResetOutput(this AzureWebappDeploymentSlotCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSlotCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotCreateSettings SetQuery(this AzureWebappDeploymentSlotCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSlotCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotCreateSettings ResetQuery(this AzureWebappDeploymentSlotCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSlotCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotCreateSettings SetVerbose(this AzureWebappDeploymentSlotCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSlotCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotCreateSettings ResetVerbose(this AzureWebappDeploymentSlotCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureWebappDeploymentSlotDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureWebappDeploymentSlotDeleteSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSlotDeleteSettings.Name"/>.</em></p><p>Name of the webapp.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotDeleteSettings SetName(this AzureWebappDeploymentSlotDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSlotDeleteSettings.Name"/>.</em></p><p>Name of the webapp.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotDeleteSettings ResetName(this AzureWebappDeploymentSlotDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSlotDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotDeleteSettings SetResourceGroup(this AzureWebappDeploymentSlotDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSlotDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotDeleteSettings ResetResourceGroup(this AzureWebappDeploymentSlotDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Slot
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSlotDeleteSettings.Slot"/>.</em></p><p>The name of the slot.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotDeleteSettings SetSlot(this AzureWebappDeploymentSlotDeleteSettings toolSettings, string slot)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = slot;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSlotDeleteSettings.Slot"/>.</em></p><p>The name of the slot.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotDeleteSettings ResetSlot(this AzureWebappDeploymentSlotDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSlotDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotDeleteSettings SetDebug(this AzureWebappDeploymentSlotDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSlotDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotDeleteSettings ResetDebug(this AzureWebappDeploymentSlotDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSlotDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotDeleteSettings SetHelp(this AzureWebappDeploymentSlotDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSlotDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotDeleteSettings ResetHelp(this AzureWebappDeploymentSlotDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSlotDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotDeleteSettings SetOutput(this AzureWebappDeploymentSlotDeleteSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSlotDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotDeleteSettings ResetOutput(this AzureWebappDeploymentSlotDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSlotDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotDeleteSettings SetQuery(this AzureWebappDeploymentSlotDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSlotDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotDeleteSettings ResetQuery(this AzureWebappDeploymentSlotDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSlotDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotDeleteSettings SetVerbose(this AzureWebappDeploymentSlotDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSlotDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotDeleteSettings ResetVerbose(this AzureWebappDeploymentSlotDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureWebappDeploymentSlotListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureWebappDeploymentSlotListSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSlotListSettings.Name"/>.</em></p><p>Name of the webapp.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotListSettings SetName(this AzureWebappDeploymentSlotListSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSlotListSettings.Name"/>.</em></p><p>Name of the webapp.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotListSettings ResetName(this AzureWebappDeploymentSlotListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSlotListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotListSettings SetResourceGroup(this AzureWebappDeploymentSlotListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSlotListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotListSettings ResetResourceGroup(this AzureWebappDeploymentSlotListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSlotListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotListSettings SetDebug(this AzureWebappDeploymentSlotListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSlotListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotListSettings ResetDebug(this AzureWebappDeploymentSlotListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSlotListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotListSettings SetHelp(this AzureWebappDeploymentSlotListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSlotListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotListSettings ResetHelp(this AzureWebappDeploymentSlotListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSlotListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotListSettings SetOutput(this AzureWebappDeploymentSlotListSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSlotListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotListSettings ResetOutput(this AzureWebappDeploymentSlotListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSlotListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotListSettings SetQuery(this AzureWebappDeploymentSlotListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSlotListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotListSettings ResetQuery(this AzureWebappDeploymentSlotListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSlotListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotListSettings SetVerbose(this AzureWebappDeploymentSlotListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSlotListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotListSettings ResetVerbose(this AzureWebappDeploymentSlotListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureWebappDeploymentSlotSwapSettingsExtensions
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureWebappDeploymentSlotSwapSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSlotSwapSettings.Name"/>.</em></p><p>Name of the webapp.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotSwapSettings SetName(this AzureWebappDeploymentSlotSwapSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSlotSwapSettings.Name"/>.</em></p><p>Name of the webapp.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotSwapSettings ResetName(this AzureWebappDeploymentSlotSwapSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSlotSwapSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotSwapSettings SetResourceGroup(this AzureWebappDeploymentSlotSwapSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSlotSwapSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotSwapSettings ResetResourceGroup(this AzureWebappDeploymentSlotSwapSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Slot
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSlotSwapSettings.Slot"/>.</em></p><p>The name of the slot.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotSwapSettings SetSlot(this AzureWebappDeploymentSlotSwapSettings toolSettings, string slot)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = slot;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSlotSwapSettings.Slot"/>.</em></p><p>The name of the slot.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotSwapSettings ResetSlot(this AzureWebappDeploymentSlotSwapSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = null;
            return toolSettings;
        }
        #endregion
        #region Action
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSlotSwapSettings.Action"/>.</em></p><p>Swap types. use 'preview' to apply target slot's settings on the source slot first; use 'swap' to complete it; use 'reset' to reset the swap.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotSwapSettings SetAction(this AzureWebappDeploymentSlotSwapSettings toolSettings, WebappDeploymentSlotSwapAction action)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Action = action;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSlotSwapSettings.Action"/>.</em></p><p>Swap types. use 'preview' to apply target slot's settings on the source slot first; use 'swap' to complete it; use 'reset' to reset the swap.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotSwapSettings ResetAction(this AzureWebappDeploymentSlotSwapSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Action = null;
            return toolSettings;
        }
        #endregion
        #region TargetSlot
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSlotSwapSettings.TargetSlot"/>.</em></p><p>Target slot to swap, default to 'production'.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotSwapSettings SetTargetSlot(this AzureWebappDeploymentSlotSwapSettings toolSettings, string targetSlot)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TargetSlot = targetSlot;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSlotSwapSettings.TargetSlot"/>.</em></p><p>Target slot to swap, default to 'production'.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotSwapSettings ResetTargetSlot(this AzureWebappDeploymentSlotSwapSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TargetSlot = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSlotSwapSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotSwapSettings SetDebug(this AzureWebappDeploymentSlotSwapSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSlotSwapSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotSwapSettings ResetDebug(this AzureWebappDeploymentSlotSwapSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSlotSwapSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotSwapSettings SetHelp(this AzureWebappDeploymentSlotSwapSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSlotSwapSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotSwapSettings ResetHelp(this AzureWebappDeploymentSlotSwapSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSlotSwapSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotSwapSettings SetOutput(this AzureWebappDeploymentSlotSwapSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSlotSwapSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotSwapSettings ResetOutput(this AzureWebappDeploymentSlotSwapSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSlotSwapSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotSwapSettings SetQuery(this AzureWebappDeploymentSlotSwapSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSlotSwapSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotSwapSettings ResetQuery(this AzureWebappDeploymentSlotSwapSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSlotSwapSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotSwapSettings SetVerbose(this AzureWebappDeploymentSlotSwapSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSlotSwapSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSlotSwapSettings ResetVerbose(this AzureWebappDeploymentSlotSwapSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureWebappDeploymentSourceConfigSettingsExtensions
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureWebappDeploymentSourceConfigSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSourceConfigSettings.Name"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceConfigSettings SetName(this AzureWebappDeploymentSourceConfigSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSourceConfigSettings.Name"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceConfigSettings ResetName(this AzureWebappDeploymentSourceConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region RepoUrl
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSourceConfigSettings.RepoUrl"/>.</em></p><p>Repository url to pull the latest source from, e.g. &lt;a href="https://github.com/foo/foo-web"&gt;https://github.com/foo/foo-web&lt;/a&gt;.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceConfigSettings SetRepoUrl(this AzureWebappDeploymentSourceConfigSettings toolSettings, string repoUrl)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RepoUrl = repoUrl;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSourceConfigSettings.RepoUrl"/>.</em></p><p>Repository url to pull the latest source from, e.g. &lt;a href="https://github.com/foo/foo-web"&gt;https://github.com/foo/foo-web&lt;/a&gt;.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceConfigSettings ResetRepoUrl(this AzureWebappDeploymentSourceConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RepoUrl = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSourceConfigSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceConfigSettings SetResourceGroup(this AzureWebappDeploymentSourceConfigSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSourceConfigSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceConfigSettings ResetResourceGroup(this AzureWebappDeploymentSourceConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Branch
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSourceConfigSettings.Branch"/>.</em></p><p>The branch name of the repository.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceConfigSettings SetBranch(this AzureWebappDeploymentSourceConfigSettings toolSettings, string branch)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Branch = branch;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSourceConfigSettings.Branch"/>.</em></p><p>The branch name of the repository.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceConfigSettings ResetBranch(this AzureWebappDeploymentSourceConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Branch = null;
            return toolSettings;
        }
        #endregion
        #region GitToken
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSourceConfigSettings.GitToken"/>.</em></p><p>Git access token required for auto sync.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceConfigSettings SetGitToken(this AzureWebappDeploymentSourceConfigSettings toolSettings, string gitToken)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GitToken = gitToken;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSourceConfigSettings.GitToken"/>.</em></p><p>Git access token required for auto sync.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceConfigSettings ResetGitToken(this AzureWebappDeploymentSourceConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GitToken = null;
            return toolSettings;
        }
        #endregion
        #region ManualIntegration
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSourceConfigSettings.ManualIntegration"/>.</em></p><p>Disable automatic sync between source control and web.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceConfigSettings SetManualIntegration(this AzureWebappDeploymentSourceConfigSettings toolSettings, string manualIntegration)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ManualIntegration = manualIntegration;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSourceConfigSettings.ManualIntegration"/>.</em></p><p>Disable automatic sync between source control and web.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceConfigSettings ResetManualIntegration(this AzureWebappDeploymentSourceConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ManualIntegration = null;
            return toolSettings;
        }
        #endregion
        #region RepositoryType
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSourceConfigSettings.RepositoryType"/>.</em></p><p>Repository type.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceConfigSettings SetRepositoryType(this AzureWebappDeploymentSourceConfigSettings toolSettings, WebappDeploymentSourceConfigRepositoryType repositoryType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RepositoryType = repositoryType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSourceConfigSettings.RepositoryType"/>.</em></p><p>Repository type.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceConfigSettings ResetRepositoryType(this AzureWebappDeploymentSourceConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RepositoryType = null;
            return toolSettings;
        }
        #endregion
        #region Slot
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSourceConfigSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceConfigSettings SetSlot(this AzureWebappDeploymentSourceConfigSettings toolSettings, string slot)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = slot;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSourceConfigSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceConfigSettings ResetSlot(this AzureWebappDeploymentSourceConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = null;
            return toolSettings;
        }
        #endregion
        #region AppWorkingDir
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSourceConfigSettings.AppWorkingDir"/>.</em></p><p>Working directory of the application. Default will be root of the repo.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceConfigSettings SetAppWorkingDir(this AzureWebappDeploymentSourceConfigSettings toolSettings, string appWorkingDir)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AppWorkingDir = appWorkingDir;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSourceConfigSettings.AppWorkingDir"/>.</em></p><p>Working directory of the application. Default will be root of the repo.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceConfigSettings ResetAppWorkingDir(this AzureWebappDeploymentSourceConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AppWorkingDir = null;
            return toolSettings;
        }
        #endregion
        #region CdAccountCreate
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSourceConfigSettings.CdAccountCreate"/>.</em></p><p>To create a new Visual Studio Team Services (VSTS) account if it doesn't exist already.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceConfigSettings SetCdAccountCreate(this AzureWebappDeploymentSourceConfigSettings toolSettings, string cdAccountCreate)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CdAccountCreate = cdAccountCreate;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSourceConfigSettings.CdAccountCreate"/>.</em></p><p>To create a new Visual Studio Team Services (VSTS) account if it doesn't exist already.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceConfigSettings ResetCdAccountCreate(this AzureWebappDeploymentSourceConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CdAccountCreate = null;
            return toolSettings;
        }
        #endregion
        #region CdAppType
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSourceConfigSettings.CdAppType"/>.</em></p><p>Web application framework you used to develop your app. Default is AspNet.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceConfigSettings SetCdAppType(this AzureWebappDeploymentSourceConfigSettings toolSettings, WebappDeploymentSourceConfigCdAppType cdAppType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CdAppType = cdAppType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSourceConfigSettings.CdAppType"/>.</em></p><p>Web application framework you used to develop your app. Default is AspNet.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceConfigSettings ResetCdAppType(this AzureWebappDeploymentSourceConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CdAppType = null;
            return toolSettings;
        }
        #endregion
        #region CdProjectUrl
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSourceConfigSettings.CdProjectUrl"/>.</em></p><p>URL of the Visual Studio Team Services (VSTS) project to use for continuous delivery. URL should be in format https://&amp;lt;accountname&amp;gt;.visualstudio.com/&amp;lt;projectname&amp;gt;.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceConfigSettings SetCdProjectUrl(this AzureWebappDeploymentSourceConfigSettings toolSettings, string cdProjectUrl)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CdProjectUrl = cdProjectUrl;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSourceConfigSettings.CdProjectUrl"/>.</em></p><p>URL of the Visual Studio Team Services (VSTS) project to use for continuous delivery. URL should be in format https://&amp;lt;accountname&amp;gt;.visualstudio.com/&amp;lt;projectname&amp;gt;.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceConfigSettings ResetCdProjectUrl(this AzureWebappDeploymentSourceConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CdProjectUrl = null;
            return toolSettings;
        }
        #endregion
        #region NodejsTaskRunner
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSourceConfigSettings.NodejsTaskRunner"/>.</em></p><p>Task runner for nodejs. Default is None.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceConfigSettings SetNodejsTaskRunner(this AzureWebappDeploymentSourceConfigSettings toolSettings, WebappDeploymentSourceConfigNodejsTaskRunner nodejsTaskRunner)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NodejsTaskRunner = nodejsTaskRunner;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSourceConfigSettings.NodejsTaskRunner"/>.</em></p><p>Task runner for nodejs. Default is None.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceConfigSettings ResetNodejsTaskRunner(this AzureWebappDeploymentSourceConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NodejsTaskRunner = null;
            return toolSettings;
        }
        #endregion
        #region PrivateRepoPassword
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSourceConfigSettings.PrivateRepoPassword"/>.</em></p><p>Password for the private repository.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceConfigSettings SetPrivateRepoPassword(this AzureWebappDeploymentSourceConfigSettings toolSettings, string privateRepoPassword)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PrivateRepoPassword = privateRepoPassword;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSourceConfigSettings.PrivateRepoPassword"/>.</em></p><p>Password for the private repository.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceConfigSettings ResetPrivateRepoPassword(this AzureWebappDeploymentSourceConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PrivateRepoPassword = null;
            return toolSettings;
        }
        #endregion
        #region PrivateRepoUsername
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSourceConfigSettings.PrivateRepoUsername"/>.</em></p><p>Username for the private repository.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceConfigSettings SetPrivateRepoUsername(this AzureWebappDeploymentSourceConfigSettings toolSettings, string privateRepoUsername)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PrivateRepoUsername = privateRepoUsername;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSourceConfigSettings.PrivateRepoUsername"/>.</em></p><p>Username for the private repository.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceConfigSettings ResetPrivateRepoUsername(this AzureWebappDeploymentSourceConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PrivateRepoUsername = null;
            return toolSettings;
        }
        #endregion
        #region PythonFramework
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSourceConfigSettings.PythonFramework"/>.</em></p><p>Framework used for Python application. Default is Django.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceConfigSettings SetPythonFramework(this AzureWebappDeploymentSourceConfigSettings toolSettings, WebappDeploymentSourceConfigPythonFramework pythonFramework)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PythonFramework = pythonFramework;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSourceConfigSettings.PythonFramework"/>.</em></p><p>Framework used for Python application. Default is Django.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceConfigSettings ResetPythonFramework(this AzureWebappDeploymentSourceConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PythonFramework = null;
            return toolSettings;
        }
        #endregion
        #region PythonVersion
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSourceConfigSettings.PythonVersion"/>.</em></p><p>Python version used for application. Default is Python 3.5.3 x86.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceConfigSettings SetPythonVersion(this AzureWebappDeploymentSourceConfigSettings toolSettings, WebappDeploymentSourceConfigPythonVersion pythonVersion)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PythonVersion = pythonVersion;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSourceConfigSettings.PythonVersion"/>.</em></p><p>Python version used for application. Default is Python 3.5.3 x86.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceConfigSettings ResetPythonVersion(this AzureWebappDeploymentSourceConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PythonVersion = null;
            return toolSettings;
        }
        #endregion
        #region SlotSwap
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSourceConfigSettings.SlotSwap"/>.</em></p><p>Name of the slot to be used for deployment and later promote to production. If slot is not available, it will be created. Default: Not configured.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceConfigSettings SetSlotSwap(this AzureWebappDeploymentSourceConfigSettings toolSettings, string slotSwap)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SlotSwap = slotSwap;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSourceConfigSettings.SlotSwap"/>.</em></p><p>Name of the slot to be used for deployment and later promote to production. If slot is not available, it will be created. Default: Not configured.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceConfigSettings ResetSlotSwap(this AzureWebappDeploymentSourceConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SlotSwap = null;
            return toolSettings;
        }
        #endregion
        #region Test
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSourceConfigSettings.Test"/>.</em></p><p>Name of the web app to be used for load testing. If web app is not available, it will be created. Default: Disable.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceConfigSettings SetTest(this AzureWebappDeploymentSourceConfigSettings toolSettings, string test)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Test = test;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSourceConfigSettings.Test"/>.</em></p><p>Name of the web app to be used for load testing. If web app is not available, it will be created. Default: Disable.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceConfigSettings ResetTest(this AzureWebappDeploymentSourceConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Test = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSourceConfigSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceConfigSettings SetDebug(this AzureWebappDeploymentSourceConfigSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSourceConfigSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceConfigSettings ResetDebug(this AzureWebappDeploymentSourceConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSourceConfigSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceConfigSettings SetHelp(this AzureWebappDeploymentSourceConfigSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSourceConfigSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceConfigSettings ResetHelp(this AzureWebappDeploymentSourceConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSourceConfigSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceConfigSettings SetOutput(this AzureWebappDeploymentSourceConfigSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSourceConfigSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceConfigSettings ResetOutput(this AzureWebappDeploymentSourceConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSourceConfigSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceConfigSettings SetQuery(this AzureWebappDeploymentSourceConfigSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSourceConfigSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceConfigSettings ResetQuery(this AzureWebappDeploymentSourceConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSourceConfigSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceConfigSettings SetVerbose(this AzureWebappDeploymentSourceConfigSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSourceConfigSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceConfigSettings ResetVerbose(this AzureWebappDeploymentSourceConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureWebappDeploymentSourceConfigLocalGitSettingsExtensions
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureWebappDeploymentSourceConfigLocalGitSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSourceConfigLocalGitSettings.Name"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceConfigLocalGitSettings SetName(this AzureWebappDeploymentSourceConfigLocalGitSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSourceConfigLocalGitSettings.Name"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceConfigLocalGitSettings ResetName(this AzureWebappDeploymentSourceConfigLocalGitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSourceConfigLocalGitSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceConfigLocalGitSettings SetResourceGroup(this AzureWebappDeploymentSourceConfigLocalGitSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSourceConfigLocalGitSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceConfigLocalGitSettings ResetResourceGroup(this AzureWebappDeploymentSourceConfigLocalGitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Slot
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSourceConfigLocalGitSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceConfigLocalGitSettings SetSlot(this AzureWebappDeploymentSourceConfigLocalGitSettings toolSettings, string slot)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = slot;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSourceConfigLocalGitSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceConfigLocalGitSettings ResetSlot(this AzureWebappDeploymentSourceConfigLocalGitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSourceConfigLocalGitSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceConfigLocalGitSettings SetDebug(this AzureWebappDeploymentSourceConfigLocalGitSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSourceConfigLocalGitSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceConfigLocalGitSettings ResetDebug(this AzureWebappDeploymentSourceConfigLocalGitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSourceConfigLocalGitSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceConfigLocalGitSettings SetHelp(this AzureWebappDeploymentSourceConfigLocalGitSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSourceConfigLocalGitSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceConfigLocalGitSettings ResetHelp(this AzureWebappDeploymentSourceConfigLocalGitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSourceConfigLocalGitSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceConfigLocalGitSettings SetOutput(this AzureWebappDeploymentSourceConfigLocalGitSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSourceConfigLocalGitSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceConfigLocalGitSettings ResetOutput(this AzureWebappDeploymentSourceConfigLocalGitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSourceConfigLocalGitSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceConfigLocalGitSettings SetQuery(this AzureWebappDeploymentSourceConfigLocalGitSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSourceConfigLocalGitSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceConfigLocalGitSettings ResetQuery(this AzureWebappDeploymentSourceConfigLocalGitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSourceConfigLocalGitSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceConfigLocalGitSettings SetVerbose(this AzureWebappDeploymentSourceConfigLocalGitSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSourceConfigLocalGitSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceConfigLocalGitSettings ResetVerbose(this AzureWebappDeploymentSourceConfigLocalGitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureWebappDeploymentSourceConfigZipSettingsExtensions
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureWebappDeploymentSourceConfigZipSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSourceConfigZipSettings.Name"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceConfigZipSettings SetName(this AzureWebappDeploymentSourceConfigZipSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSourceConfigZipSettings.Name"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceConfigZipSettings ResetName(this AzureWebappDeploymentSourceConfigZipSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSourceConfigZipSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceConfigZipSettings SetResourceGroup(this AzureWebappDeploymentSourceConfigZipSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSourceConfigZipSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceConfigZipSettings ResetResourceGroup(this AzureWebappDeploymentSourceConfigZipSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Src
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSourceConfigZipSettings.Src"/>.</em></p><p>A zip file path for deployment.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceConfigZipSettings SetSrc(this AzureWebappDeploymentSourceConfigZipSettings toolSettings, string src)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Src = src;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSourceConfigZipSettings.Src"/>.</em></p><p>A zip file path for deployment.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceConfigZipSettings ResetSrc(this AzureWebappDeploymentSourceConfigZipSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Src = null;
            return toolSettings;
        }
        #endregion
        #region Slot
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSourceConfigZipSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceConfigZipSettings SetSlot(this AzureWebappDeploymentSourceConfigZipSettings toolSettings, string slot)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = slot;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSourceConfigZipSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceConfigZipSettings ResetSlot(this AzureWebappDeploymentSourceConfigZipSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSourceConfigZipSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceConfigZipSettings SetDebug(this AzureWebappDeploymentSourceConfigZipSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSourceConfigZipSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceConfigZipSettings ResetDebug(this AzureWebappDeploymentSourceConfigZipSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSourceConfigZipSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceConfigZipSettings SetHelp(this AzureWebappDeploymentSourceConfigZipSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSourceConfigZipSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceConfigZipSettings ResetHelp(this AzureWebappDeploymentSourceConfigZipSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSourceConfigZipSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceConfigZipSettings SetOutput(this AzureWebappDeploymentSourceConfigZipSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSourceConfigZipSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceConfigZipSettings ResetOutput(this AzureWebappDeploymentSourceConfigZipSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSourceConfigZipSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceConfigZipSettings SetQuery(this AzureWebappDeploymentSourceConfigZipSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSourceConfigZipSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceConfigZipSettings ResetQuery(this AzureWebappDeploymentSourceConfigZipSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSourceConfigZipSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceConfigZipSettings SetVerbose(this AzureWebappDeploymentSourceConfigZipSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSourceConfigZipSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceConfigZipSettings ResetVerbose(this AzureWebappDeploymentSourceConfigZipSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureWebappDeploymentSourceDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureWebappDeploymentSourceDeleteSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSourceDeleteSettings.Name"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceDeleteSettings SetName(this AzureWebappDeploymentSourceDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSourceDeleteSettings.Name"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceDeleteSettings ResetName(this AzureWebappDeploymentSourceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSourceDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceDeleteSettings SetResourceGroup(this AzureWebappDeploymentSourceDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSourceDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceDeleteSettings ResetResourceGroup(this AzureWebappDeploymentSourceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Slot
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSourceDeleteSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceDeleteSettings SetSlot(this AzureWebappDeploymentSourceDeleteSettings toolSettings, string slot)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = slot;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSourceDeleteSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceDeleteSettings ResetSlot(this AzureWebappDeploymentSourceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSourceDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceDeleteSettings SetDebug(this AzureWebappDeploymentSourceDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSourceDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceDeleteSettings ResetDebug(this AzureWebappDeploymentSourceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSourceDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceDeleteSettings SetHelp(this AzureWebappDeploymentSourceDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSourceDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceDeleteSettings ResetHelp(this AzureWebappDeploymentSourceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSourceDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceDeleteSettings SetOutput(this AzureWebappDeploymentSourceDeleteSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSourceDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceDeleteSettings ResetOutput(this AzureWebappDeploymentSourceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSourceDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceDeleteSettings SetQuery(this AzureWebappDeploymentSourceDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSourceDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceDeleteSettings ResetQuery(this AzureWebappDeploymentSourceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSourceDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceDeleteSettings SetVerbose(this AzureWebappDeploymentSourceDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSourceDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceDeleteSettings ResetVerbose(this AzureWebappDeploymentSourceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureWebappDeploymentSourceShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureWebappDeploymentSourceShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSourceShowSettings.Name"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceShowSettings SetName(this AzureWebappDeploymentSourceShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSourceShowSettings.Name"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceShowSettings ResetName(this AzureWebappDeploymentSourceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSourceShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceShowSettings SetResourceGroup(this AzureWebappDeploymentSourceShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSourceShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceShowSettings ResetResourceGroup(this AzureWebappDeploymentSourceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Slot
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSourceShowSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceShowSettings SetSlot(this AzureWebappDeploymentSourceShowSettings toolSettings, string slot)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = slot;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSourceShowSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceShowSettings ResetSlot(this AzureWebappDeploymentSourceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSourceShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceShowSettings SetDebug(this AzureWebappDeploymentSourceShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSourceShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceShowSettings ResetDebug(this AzureWebappDeploymentSourceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSourceShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceShowSettings SetHelp(this AzureWebappDeploymentSourceShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSourceShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceShowSettings ResetHelp(this AzureWebappDeploymentSourceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSourceShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceShowSettings SetOutput(this AzureWebappDeploymentSourceShowSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSourceShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceShowSettings ResetOutput(this AzureWebappDeploymentSourceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSourceShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceShowSettings SetQuery(this AzureWebappDeploymentSourceShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSourceShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceShowSettings ResetQuery(this AzureWebappDeploymentSourceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSourceShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceShowSettings SetVerbose(this AzureWebappDeploymentSourceShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSourceShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceShowSettings ResetVerbose(this AzureWebappDeploymentSourceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureWebappDeploymentSourceSyncSettingsExtensions
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureWebappDeploymentSourceSyncSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSourceSyncSettings.Name"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceSyncSettings SetName(this AzureWebappDeploymentSourceSyncSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSourceSyncSettings.Name"/>.</em></p><p>Name of the web. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceSyncSettings ResetName(this AzureWebappDeploymentSourceSyncSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSourceSyncSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceSyncSettings SetResourceGroup(this AzureWebappDeploymentSourceSyncSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSourceSyncSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceSyncSettings ResetResourceGroup(this AzureWebappDeploymentSourceSyncSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Slot
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSourceSyncSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceSyncSettings SetSlot(this AzureWebappDeploymentSourceSyncSettings toolSettings, string slot)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = slot;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSourceSyncSettings.Slot"/>.</em></p><p>The name of the slot. Default to the productions slot if not specified.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceSyncSettings ResetSlot(this AzureWebappDeploymentSourceSyncSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Slot = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSourceSyncSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceSyncSettings SetDebug(this AzureWebappDeploymentSourceSyncSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSourceSyncSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceSyncSettings ResetDebug(this AzureWebappDeploymentSourceSyncSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSourceSyncSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceSyncSettings SetHelp(this AzureWebappDeploymentSourceSyncSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSourceSyncSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceSyncSettings ResetHelp(this AzureWebappDeploymentSourceSyncSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSourceSyncSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceSyncSettings SetOutput(this AzureWebappDeploymentSourceSyncSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSourceSyncSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceSyncSettings ResetOutput(this AzureWebappDeploymentSourceSyncSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSourceSyncSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceSyncSettings SetQuery(this AzureWebappDeploymentSourceSyncSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSourceSyncSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceSyncSettings ResetQuery(this AzureWebappDeploymentSourceSyncSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSourceSyncSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceSyncSettings SetVerbose(this AzureWebappDeploymentSourceSyncSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSourceSyncSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceSyncSettings ResetVerbose(this AzureWebappDeploymentSourceSyncSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureWebappDeploymentSourceUpdateTokenSettingsExtensions
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureWebappDeploymentSourceUpdateTokenSettingsExtensions
    {
        #region GitToken
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSourceUpdateTokenSettings.GitToken"/>.</em></p><p>Git access token required for auto sync.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceUpdateTokenSettings SetGitToken(this AzureWebappDeploymentSourceUpdateTokenSettings toolSettings, string gitToken)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GitToken = gitToken;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSourceUpdateTokenSettings.GitToken"/>.</em></p><p>Git access token required for auto sync.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceUpdateTokenSettings ResetGitToken(this AzureWebappDeploymentSourceUpdateTokenSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GitToken = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSourceUpdateTokenSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceUpdateTokenSettings SetDebug(this AzureWebappDeploymentSourceUpdateTokenSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSourceUpdateTokenSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceUpdateTokenSettings ResetDebug(this AzureWebappDeploymentSourceUpdateTokenSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSourceUpdateTokenSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceUpdateTokenSettings SetHelp(this AzureWebappDeploymentSourceUpdateTokenSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSourceUpdateTokenSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceUpdateTokenSettings ResetHelp(this AzureWebappDeploymentSourceUpdateTokenSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSourceUpdateTokenSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceUpdateTokenSettings SetOutput(this AzureWebappDeploymentSourceUpdateTokenSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSourceUpdateTokenSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceUpdateTokenSettings ResetOutput(this AzureWebappDeploymentSourceUpdateTokenSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSourceUpdateTokenSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceUpdateTokenSettings SetQuery(this AzureWebappDeploymentSourceUpdateTokenSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSourceUpdateTokenSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceUpdateTokenSettings ResetQuery(this AzureWebappDeploymentSourceUpdateTokenSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentSourceUpdateTokenSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceUpdateTokenSettings SetVerbose(this AzureWebappDeploymentSourceUpdateTokenSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentSourceUpdateTokenSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappDeploymentSourceUpdateTokenSettings ResetVerbose(this AzureWebappDeploymentSourceUpdateTokenSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureWebappDeploymentUserSetSettingsExtensions
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureWebappDeploymentUserSetSettingsExtensions
    {
        #region UserName
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentUserSetSettings.UserName"/>.</em></p><p>User name.</p></summary>
        [Pure]
        public static AzureWebappDeploymentUserSetSettings SetUserName(this AzureWebappDeploymentUserSetSettings toolSettings, string userName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UserName = userName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentUserSetSettings.UserName"/>.</em></p><p>User name.</p></summary>
        [Pure]
        public static AzureWebappDeploymentUserSetSettings ResetUserName(this AzureWebappDeploymentUserSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UserName = null;
            return toolSettings;
        }
        #endregion
        #region Password
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentUserSetSettings.Password"/>.</em></p><p>Password, will prompt if not specified.</p></summary>
        [Pure]
        public static AzureWebappDeploymentUserSetSettings SetPassword(this AzureWebappDeploymentUserSetSettings toolSettings, string password)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = password;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentUserSetSettings.Password"/>.</em></p><p>Password, will prompt if not specified.</p></summary>
        [Pure]
        public static AzureWebappDeploymentUserSetSettings ResetPassword(this AzureWebappDeploymentUserSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentUserSetSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappDeploymentUserSetSettings SetDebug(this AzureWebappDeploymentUserSetSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentUserSetSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappDeploymentUserSetSettings ResetDebug(this AzureWebappDeploymentUserSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentUserSetSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappDeploymentUserSetSettings SetHelp(this AzureWebappDeploymentUserSetSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentUserSetSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappDeploymentUserSetSettings ResetHelp(this AzureWebappDeploymentUserSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentUserSetSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappDeploymentUserSetSettings SetOutput(this AzureWebappDeploymentUserSetSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentUserSetSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappDeploymentUserSetSettings ResetOutput(this AzureWebappDeploymentUserSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentUserSetSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappDeploymentUserSetSettings SetQuery(this AzureWebappDeploymentUserSetSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentUserSetSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappDeploymentUserSetSettings ResetQuery(this AzureWebappDeploymentUserSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentUserSetSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappDeploymentUserSetSettings SetVerbose(this AzureWebappDeploymentUserSetSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentUserSetSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappDeploymentUserSetSettings ResetVerbose(this AzureWebappDeploymentUserSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureWebappDeploymentUserShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureWebappDeploymentUserShowSettingsExtensions
    {
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentUserShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappDeploymentUserShowSettings SetDebug(this AzureWebappDeploymentUserShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentUserShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureWebappDeploymentUserShowSettings ResetDebug(this AzureWebappDeploymentUserShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentUserShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappDeploymentUserShowSettings SetHelp(this AzureWebappDeploymentUserShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentUserShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureWebappDeploymentUserShowSettings ResetHelp(this AzureWebappDeploymentUserShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentUserShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappDeploymentUserShowSettings SetOutput(this AzureWebappDeploymentUserShowSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentUserShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureWebappDeploymentUserShowSettings ResetOutput(this AzureWebappDeploymentUserShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentUserShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappDeploymentUserShowSettings SetQuery(this AzureWebappDeploymentUserShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentUserShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureWebappDeploymentUserShowSettings ResetQuery(this AzureWebappDeploymentUserShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureWebappDeploymentUserShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappDeploymentUserShowSettings SetVerbose(this AzureWebappDeploymentUserShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureWebappDeploymentUserShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureWebappDeploymentUserShowSettings ResetVerbose(this AzureWebappDeploymentUserShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region WebappMulticontainerConfigType
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    public partial class WebappMulticontainerConfigType : Enumeration
    {
        public static WebappMulticontainerConfigType compose = new WebappMulticontainerConfigType { Value = "compose" };
        public static WebappMulticontainerConfigType kube = new WebappMulticontainerConfigType { Value = "kube" };
    }
    #endregion
    #region WebappAuthUpdateAction
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    public partial class WebappAuthUpdateAction : Enumeration
    {
        public static WebappAuthUpdateAction allowanonymous = new WebappAuthUpdateAction { Value = "allowanonymous" };
        public static WebappAuthUpdateAction loginwithazureactivedirectory = new WebappAuthUpdateAction { Value = "loginwithazureactivedirectory" };
        public static WebappAuthUpdateAction loginwithfacebook = new WebappAuthUpdateAction { Value = "loginwithfacebook" };
        public static WebappAuthUpdateAction loginwithgoogle = new WebappAuthUpdateAction { Value = "loginwithgoogle" };
        public static WebappAuthUpdateAction loginwithmicrosoftaccount = new WebappAuthUpdateAction { Value = "loginwithmicrosoftaccount" };
        public static WebappAuthUpdateAction loginwithtwitter = new WebappAuthUpdateAction { Value = "loginwithtwitter" };
    }
    #endregion
    #region WebappDeploymentSlotSwapAction
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    public partial class WebappDeploymentSlotSwapAction : Enumeration
    {
        public static WebappDeploymentSlotSwapAction preview = new WebappDeploymentSlotSwapAction { Value = "preview" };
        public static WebappDeploymentSlotSwapAction reset = new WebappDeploymentSlotSwapAction { Value = "reset" };
        public static WebappDeploymentSlotSwapAction swap = new WebappDeploymentSlotSwapAction { Value = "swap" };
    }
    #endregion
    #region WebappLogConfigDockerContainerLogging
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    public partial class WebappLogConfigDockerContainerLogging : Enumeration
    {
        public static WebappLogConfigDockerContainerLogging filesystem = new WebappLogConfigDockerContainerLogging { Value = "filesystem" };
        public static WebappLogConfigDockerContainerLogging off = new WebappLogConfigDockerContainerLogging { Value = "off" };
    }
    #endregion
    #region WebappLogConfigLevel
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    public partial class WebappLogConfigLevel : Enumeration
    {
        public static WebappLogConfigLevel error = new WebappLogConfigLevel { Value = "error" };
        public static WebappLogConfigLevel information = new WebappLogConfigLevel { Value = "information" };
        public static WebappLogConfigLevel verbose = new WebappLogConfigLevel { Value = "verbose" };
        public static WebappLogConfigLevel warning = new WebappLogConfigLevel { Value = "warning" };
    }
    #endregion
    #region WebappConfigBackupDbType
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    public partial class WebappConfigBackupDbType : Enumeration
    {
        public static WebappConfigBackupDbType localmysql = new WebappConfigBackupDbType { Value = "localmysql" };
        public static WebappConfigBackupDbType mysql = new WebappConfigBackupDbType { Value = "mysql" };
        public static WebappConfigBackupDbType postgresql = new WebappConfigBackupDbType { Value = "postgresql" };
        public static WebappConfigBackupDbType sqlazure = new WebappConfigBackupDbType { Value = "sqlazure" };
    }
    #endregion
    #region WebappConfigConnectionStringSetConnectionStringType
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    public partial class WebappConfigConnectionStringSetConnectionStringType : Enumeration
    {
        public static WebappConfigConnectionStringSetConnectionStringType apihub = new WebappConfigConnectionStringSetConnectionStringType { Value = "apihub" };
        public static WebappConfigConnectionStringSetConnectionStringType custom = new WebappConfigConnectionStringSetConnectionStringType { Value = "custom" };
        public static WebappConfigConnectionStringSetConnectionStringType docdb = new WebappConfigConnectionStringSetConnectionStringType { Value = "docdb" };
        public static WebappConfigConnectionStringSetConnectionStringType eventhub = new WebappConfigConnectionStringSetConnectionStringType { Value = "eventhub" };
        public static WebappConfigConnectionStringSetConnectionStringType mysql = new WebappConfigConnectionStringSetConnectionStringType { Value = "mysql" };
        public static WebappConfigConnectionStringSetConnectionStringType notificationhub = new WebappConfigConnectionStringSetConnectionStringType { Value = "notificationhub" };
        public static WebappConfigConnectionStringSetConnectionStringType postgresql = new WebappConfigConnectionStringSetConnectionStringType { Value = "postgresql" };
        public static WebappConfigConnectionStringSetConnectionStringType rediscache = new WebappConfigConnectionStringSetConnectionStringType { Value = "rediscache" };
        public static WebappConfigConnectionStringSetConnectionStringType sqlazure = new WebappConfigConnectionStringSetConnectionStringType { Value = "sqlazure" };
        public static WebappConfigConnectionStringSetConnectionStringType sqlserver = new WebappConfigConnectionStringSetConnectionStringType { Value = "sqlserver" };
        public static WebappConfigConnectionStringSetConnectionStringType servicebus = new WebappConfigConnectionStringSetConnectionStringType { Value = "servicebus" };
    }
    #endregion
    #region WebappConfigSslBindSslType
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    public partial class WebappConfigSslBindSslType : Enumeration
    {
        public static WebappConfigSslBindSslType ip = new WebappConfigSslBindSslType { Value = "ip" };
        public static WebappConfigSslBindSslType sni = new WebappConfigSslBindSslType { Value = "sni" };
    }
    #endregion
    #region WebappDeploymentSourceConfigRepositoryType
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    public partial class WebappDeploymentSourceConfigRepositoryType : Enumeration
    {
        public static WebappDeploymentSourceConfigRepositoryType externalgit = new WebappDeploymentSourceConfigRepositoryType { Value = "externalgit" };
        public static WebappDeploymentSourceConfigRepositoryType git = new WebappDeploymentSourceConfigRepositoryType { Value = "git" };
        public static WebappDeploymentSourceConfigRepositoryType github = new WebappDeploymentSourceConfigRepositoryType { Value = "github" };
        public static WebappDeploymentSourceConfigRepositoryType localgit = new WebappDeploymentSourceConfigRepositoryType { Value = "localgit" };
        public static WebappDeploymentSourceConfigRepositoryType mercurial = new WebappDeploymentSourceConfigRepositoryType { Value = "mercurial" };
        public static WebappDeploymentSourceConfigRepositoryType vsts = new WebappDeploymentSourceConfigRepositoryType { Value = "vsts" };
    }
    #endregion
    #region WebappDeploymentSourceConfigCdAppType
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    public partial class WebappDeploymentSourceConfigCdAppType : Enumeration
    {
        public static WebappDeploymentSourceConfigCdAppType aspnet = new WebappDeploymentSourceConfigCdAppType { Value = "aspnet" };
        public static WebappDeploymentSourceConfigCdAppType aspnetcore = new WebappDeploymentSourceConfigCdAppType { Value = "aspnetcore" };
        public static WebappDeploymentSourceConfigCdAppType nodejs = new WebappDeploymentSourceConfigCdAppType { Value = "nodejs" };
        public static WebappDeploymentSourceConfigCdAppType php = new WebappDeploymentSourceConfigCdAppType { Value = "php" };
        public static WebappDeploymentSourceConfigCdAppType python = new WebappDeploymentSourceConfigCdAppType { Value = "python" };
    }
    #endregion
    #region WebappDeploymentSourceConfigNodejsTaskRunner
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    public partial class WebappDeploymentSourceConfigNodejsTaskRunner : Enumeration
    {
        public static WebappDeploymentSourceConfigNodejsTaskRunner grunt = new WebappDeploymentSourceConfigNodejsTaskRunner { Value = "grunt" };
        public static WebappDeploymentSourceConfigNodejsTaskRunner gulp = new WebappDeploymentSourceConfigNodejsTaskRunner { Value = "gulp" };
        public static WebappDeploymentSourceConfigNodejsTaskRunner none = new WebappDeploymentSourceConfigNodejsTaskRunner { Value = "none" };
    }
    #endregion
    #region WebappDeploymentSourceConfigPythonFramework
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    public partial class WebappDeploymentSourceConfigPythonFramework : Enumeration
    {
        public static WebappDeploymentSourceConfigPythonFramework bottle = new WebappDeploymentSourceConfigPythonFramework { Value = "bottle" };
        public static WebappDeploymentSourceConfigPythonFramework django = new WebappDeploymentSourceConfigPythonFramework { Value = "django" };
        public static WebappDeploymentSourceConfigPythonFramework flask = new WebappDeploymentSourceConfigPythonFramework { Value = "flask" };
    }
    #endregion
    #region WebappDeploymentSourceConfigPythonVersion
    /// <summary><p>Used within <see cref="AzureWebappTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    public partial class WebappDeploymentSourceConfigPythonVersion : Enumeration
    {
        public static WebappDeploymentSourceConfigPythonVersion python_2_7_12_x64 = new WebappDeploymentSourceConfigPythonVersion { Value = "python 2.7.12 x64" };
        public static WebappDeploymentSourceConfigPythonVersion python_2_7_12_x86 = new WebappDeploymentSourceConfigPythonVersion { Value = "python 2.7.12 x86" };
        public static WebappDeploymentSourceConfigPythonVersion python_2_7_13_x64 = new WebappDeploymentSourceConfigPythonVersion { Value = "python 2.7.13 x64" };
        public static WebappDeploymentSourceConfigPythonVersion python_2_7_13_x86 = new WebappDeploymentSourceConfigPythonVersion { Value = "python 2.7.13 x86" };
        public static WebappDeploymentSourceConfigPythonVersion python_3_5_3_x64 = new WebappDeploymentSourceConfigPythonVersion { Value = "python 3.5.3 x64" };
        public static WebappDeploymentSourceConfigPythonVersion python_3_5_3_x86 = new WebappDeploymentSourceConfigPythonVersion { Value = "python 3.5.3 x86" };
        public static WebappDeploymentSourceConfigPythonVersion python_3_6_0_x64 = new WebappDeploymentSourceConfigPythonVersion { Value = "python 3.6.0 x64" };
        public static WebappDeploymentSourceConfigPythonVersion python_3_6_0_x86 = new WebappDeploymentSourceConfigPythonVersion { Value = "python 3.6.0 x86" };
        public static WebappDeploymentSourceConfigPythonVersion python_3_6_1_x86 = new WebappDeploymentSourceConfigPythonVersion { Value = "python 3.6.1 x86" };
        public static WebappDeploymentSourceConfigPythonVersion python_3_6_2_x64 = new WebappDeploymentSourceConfigPythonVersion { Value = "python 3.6.2 x64" };
    }
    #endregion
}
