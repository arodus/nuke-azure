// Copyright Matthias Koch, Sebastian Karasek 2018.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

// Generated with Nuke.CodeGeneration, Version: 0.5.0 [CommitSha: 3eaf2b72].
// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/AzureAms.json.

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
    public static partial class AzureAmsTasks
    {
        /// <summary><p>Path to the AzureAms executable.</p></summary>
        public static string AzureAmsPath => ToolPathResolver.GetPathExecutable("az");
        /// <summary><p>Manage Azure Media Services resources.</p></summary>
        public static IEnumerable<string> AzureAms(string arguments, string workingDirectory = null, ProcessSettings processSettings = null)
        {
            var process = ProcessTasks.StartProcess(AzureAmsPath, arguments, workingDirectory, processSettings?.EnvironmentVariables, processSettings?.ExecutionTimeout, processSettings?.RedirectOutput ?? true);
            process.AssertZeroExitCode();
            return process.Output.Select(x => x.Text);
        }
        static partial void PreProcess(AzureAmsSettings toolSettings);
        static partial void PostProcess(AzureAmsSettings toolSettings);
        /// <summary><p>Manage Azure Media Services resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ams?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureAms(Configure<AzureAmsSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAmsSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureAmsAccountCreateSettings toolSettings);
        static partial void PostProcess(AzureAmsAccountCreateSettings toolSettings);
        /// <summary><p>Manage Azure Media Services resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ams?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureAmsAccountCreate(Configure<AzureAmsAccountCreateSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAmsAccountCreateSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureAmsAccountDeleteSettings toolSettings);
        static partial void PostProcess(AzureAmsAccountDeleteSettings toolSettings);
        /// <summary><p>Manage Azure Media Services resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ams?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureAmsAccountDelete(Configure<AzureAmsAccountDeleteSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAmsAccountDeleteSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureAmsAccountListSettings toolSettings);
        static partial void PostProcess(AzureAmsAccountListSettings toolSettings);
        /// <summary><p>Manage Azure Media Services resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ams?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureAmsAccountList(Configure<AzureAmsAccountListSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAmsAccountListSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureAmsAccountShowSettings toolSettings);
        static partial void PostProcess(AzureAmsAccountShowSettings toolSettings);
        /// <summary><p>Manage Azure Media Services resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ams?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureAmsAccountShow(Configure<AzureAmsAccountShowSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAmsAccountShowSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureAmsAccountUpdateSettings toolSettings);
        static partial void PostProcess(AzureAmsAccountUpdateSettings toolSettings);
        /// <summary><p>Manage Azure Media Services resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ams?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureAmsAccountUpdate(Configure<AzureAmsAccountUpdateSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAmsAccountUpdateSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureAmsAssetCreateSettings toolSettings);
        static partial void PostProcess(AzureAmsAssetCreateSettings toolSettings);
        /// <summary><p>Manage Azure Media Services resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ams?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureAmsAssetCreate(Configure<AzureAmsAssetCreateSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAmsAssetCreateSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureAmsAssetDeleteSettings toolSettings);
        static partial void PostProcess(AzureAmsAssetDeleteSettings toolSettings);
        /// <summary><p>Manage Azure Media Services resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ams?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureAmsAssetDelete(Configure<AzureAmsAssetDeleteSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAmsAssetDeleteSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureAmsAssetGetSasUrlsSettings toolSettings);
        static partial void PostProcess(AzureAmsAssetGetSasUrlsSettings toolSettings);
        /// <summary><p>Manage Azure Media Services resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ams?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureAmsAssetGetSasUrls(Configure<AzureAmsAssetGetSasUrlsSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAmsAssetGetSasUrlsSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureAmsAssetListSettings toolSettings);
        static partial void PostProcess(AzureAmsAssetListSettings toolSettings);
        /// <summary><p>Manage Azure Media Services resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ams?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureAmsAssetList(Configure<AzureAmsAssetListSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAmsAssetListSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureAmsAssetShowSettings toolSettings);
        static partial void PostProcess(AzureAmsAssetShowSettings toolSettings);
        /// <summary><p>Manage Azure Media Services resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ams?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureAmsAssetShow(Configure<AzureAmsAssetShowSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAmsAssetShowSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureAmsAssetUpdateSettings toolSettings);
        static partial void PostProcess(AzureAmsAssetUpdateSettings toolSettings);
        /// <summary><p>Manage Azure Media Services resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ams?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureAmsAssetUpdate(Configure<AzureAmsAssetUpdateSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAmsAssetUpdateSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureAmsJobCancelSettings toolSettings);
        static partial void PostProcess(AzureAmsJobCancelSettings toolSettings);
        /// <summary><p>Manage Azure Media Services resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ams?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureAmsJobCancel(Configure<AzureAmsJobCancelSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAmsJobCancelSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureAmsJobDeleteSettings toolSettings);
        static partial void PostProcess(AzureAmsJobDeleteSettings toolSettings);
        /// <summary><p>Manage Azure Media Services resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ams?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureAmsJobDelete(Configure<AzureAmsJobDeleteSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAmsJobDeleteSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureAmsJobListSettings toolSettings);
        static partial void PostProcess(AzureAmsJobListSettings toolSettings);
        /// <summary><p>Manage Azure Media Services resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ams?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureAmsJobList(Configure<AzureAmsJobListSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAmsJobListSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureAmsJobShowSettings toolSettings);
        static partial void PostProcess(AzureAmsJobShowSettings toolSettings);
        /// <summary><p>Manage Azure Media Services resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ams?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureAmsJobShow(Configure<AzureAmsJobShowSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAmsJobShowSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureAmsJobStartSettings toolSettings);
        static partial void PostProcess(AzureAmsJobStartSettings toolSettings);
        /// <summary><p>Manage Azure Media Services resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ams?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureAmsJobStart(Configure<AzureAmsJobStartSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAmsJobStartSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureAmsStreamingSettings toolSettings);
        static partial void PostProcess(AzureAmsStreamingSettings toolSettings);
        /// <summary><p>Manage Azure Media Services resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ams?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureAmsStreaming(Configure<AzureAmsStreamingSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAmsStreamingSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureAmsTransformCreateSettings toolSettings);
        static partial void PostProcess(AzureAmsTransformCreateSettings toolSettings);
        /// <summary><p>Manage Azure Media Services resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ams?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureAmsTransformCreate(Configure<AzureAmsTransformCreateSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAmsTransformCreateSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureAmsTransformDeleteSettings toolSettings);
        static partial void PostProcess(AzureAmsTransformDeleteSettings toolSettings);
        /// <summary><p>Manage Azure Media Services resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ams?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureAmsTransformDelete(Configure<AzureAmsTransformDeleteSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAmsTransformDeleteSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureAmsTransformListSettings toolSettings);
        static partial void PostProcess(AzureAmsTransformListSettings toolSettings);
        /// <summary><p>Manage Azure Media Services resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ams?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureAmsTransformList(Configure<AzureAmsTransformListSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAmsTransformListSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureAmsTransformShowSettings toolSettings);
        static partial void PostProcess(AzureAmsTransformShowSettings toolSettings);
        /// <summary><p>Manage Azure Media Services resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ams?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureAmsTransformShow(Configure<AzureAmsTransformShowSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAmsTransformShowSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureAmsTransformUpdateSettings toolSettings);
        static partial void PostProcess(AzureAmsTransformUpdateSettings toolSettings);
        /// <summary><p>Manage Azure Media Services resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ams?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureAmsTransformUpdate(Configure<AzureAmsTransformUpdateSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAmsTransformUpdateSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureAmsAccountSpCreateSettings toolSettings);
        static partial void PostProcess(AzureAmsAccountSpCreateSettings toolSettings);
        /// <summary><p>Manage Azure Media Services resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ams?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureAmsAccountSpCreate(Configure<AzureAmsAccountSpCreateSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAmsAccountSpCreateSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureAmsAccountSpResetCredentialsSettings toolSettings);
        static partial void PostProcess(AzureAmsAccountSpResetCredentialsSettings toolSettings);
        /// <summary><p>Manage Azure Media Services resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ams?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureAmsAccountSpResetCredentials(Configure<AzureAmsAccountSpResetCredentialsSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAmsAccountSpResetCredentialsSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureAmsAccountStorageAddSettings toolSettings);
        static partial void PostProcess(AzureAmsAccountStorageAddSettings toolSettings);
        /// <summary><p>Manage Azure Media Services resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ams?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureAmsAccountStorageAdd(Configure<AzureAmsAccountStorageAddSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAmsAccountStorageAddSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureAmsAccountStorageRemoveSettings toolSettings);
        static partial void PostProcess(AzureAmsAccountStorageRemoveSettings toolSettings);
        /// <summary><p>Manage Azure Media Services resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ams?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureAmsAccountStorageRemove(Configure<AzureAmsAccountStorageRemoveSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAmsAccountStorageRemoveSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureAmsStreamingEndpointListSettings toolSettings);
        static partial void PostProcess(AzureAmsStreamingEndpointListSettings toolSettings);
        /// <summary><p>Manage Azure Media Services resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ams?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureAmsStreamingEndpointList(Configure<AzureAmsStreamingEndpointListSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAmsStreamingEndpointListSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureAmsStreamingEndpointStartSettings toolSettings);
        static partial void PostProcess(AzureAmsStreamingEndpointStartSettings toolSettings);
        /// <summary><p>Manage Azure Media Services resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ams?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureAmsStreamingEndpointStart(Configure<AzureAmsStreamingEndpointStartSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAmsStreamingEndpointStartSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureAmsStreamingEndpointStopSettings toolSettings);
        static partial void PostProcess(AzureAmsStreamingEndpointStopSettings toolSettings);
        /// <summary><p>Manage Azure Media Services resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ams?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureAmsStreamingEndpointStop(Configure<AzureAmsStreamingEndpointStopSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAmsStreamingEndpointStopSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureAmsStreamingLocatorCreateSettings toolSettings);
        static partial void PostProcess(AzureAmsStreamingLocatorCreateSettings toolSettings);
        /// <summary><p>Manage Azure Media Services resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ams?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureAmsStreamingLocatorCreate(Configure<AzureAmsStreamingLocatorCreateSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAmsStreamingLocatorCreateSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureAmsStreamingLocatorDeleteSettings toolSettings);
        static partial void PostProcess(AzureAmsStreamingLocatorDeleteSettings toolSettings);
        /// <summary><p>Manage Azure Media Services resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ams?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureAmsStreamingLocatorDelete(Configure<AzureAmsStreamingLocatorDeleteSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAmsStreamingLocatorDeleteSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureAmsStreamingLocatorGetPathsSettings toolSettings);
        static partial void PostProcess(AzureAmsStreamingLocatorGetPathsSettings toolSettings);
        /// <summary><p>Manage Azure Media Services resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ams?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureAmsStreamingLocatorGetPaths(Configure<AzureAmsStreamingLocatorGetPathsSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAmsStreamingLocatorGetPathsSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureAmsStreamingLocatorListSettings toolSettings);
        static partial void PostProcess(AzureAmsStreamingLocatorListSettings toolSettings);
        /// <summary><p>Manage Azure Media Services resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ams?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureAmsStreamingLocatorList(Configure<AzureAmsStreamingLocatorListSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAmsStreamingLocatorListSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureAmsStreamingLocatorShowSettings toolSettings);
        static partial void PostProcess(AzureAmsStreamingLocatorShowSettings toolSettings);
        /// <summary><p>Manage Azure Media Services resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ams?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureAmsStreamingLocatorShow(Configure<AzureAmsStreamingLocatorShowSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAmsStreamingLocatorShowSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureAmsStreamingPolicyCreateSettings toolSettings);
        static partial void PostProcess(AzureAmsStreamingPolicyCreateSettings toolSettings);
        /// <summary><p>Manage Azure Media Services resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ams?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureAmsStreamingPolicyCreate(Configure<AzureAmsStreamingPolicyCreateSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAmsStreamingPolicyCreateSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureAmsStreamingPolicyDeleteSettings toolSettings);
        static partial void PostProcess(AzureAmsStreamingPolicyDeleteSettings toolSettings);
        /// <summary><p>Manage Azure Media Services resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ams?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureAmsStreamingPolicyDelete(Configure<AzureAmsStreamingPolicyDeleteSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAmsStreamingPolicyDeleteSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureAmsStreamingPolicyListSettings toolSettings);
        static partial void PostProcess(AzureAmsStreamingPolicyListSettings toolSettings);
        /// <summary><p>Manage Azure Media Services resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ams?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureAmsStreamingPolicyList(Configure<AzureAmsStreamingPolicyListSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAmsStreamingPolicyListSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureAmsStreamingPolicyShowSettings toolSettings);
        static partial void PostProcess(AzureAmsStreamingPolicyShowSettings toolSettings);
        /// <summary><p>Manage Azure Media Services resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ams?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureAmsStreamingPolicyShow(Configure<AzureAmsStreamingPolicyShowSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAmsStreamingPolicyShowSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureAmsTransformOutputAddSettings toolSettings);
        static partial void PostProcess(AzureAmsTransformOutputAddSettings toolSettings);
        /// <summary><p>Manage Azure Media Services resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ams?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureAmsTransformOutputAdd(Configure<AzureAmsTransformOutputAddSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAmsTransformOutputAddSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureAmsTransformOutputRemoveSettings toolSettings);
        static partial void PostProcess(AzureAmsTransformOutputRemoveSettings toolSettings);
        /// <summary><p>Manage Azure Media Services resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ams?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureAmsTransformOutputRemove(Configure<AzureAmsTransformOutputRemoveSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAmsTransformOutputRemoveSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
    }
    #region AzureAmsSettings
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAmsSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAms executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAmsTasks.AzureAmsPath;
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
              .Add("ams")
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureAmsAccountCreateSettings
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAmsAccountCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAms executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAmsTasks.AzureAmsPath;
        /// <summary><p>The name of the Azure Media Services account.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The name or resource ID of the primary storage account to attach to the Azure Media Services account. Blob only accounts are not allowed as primary.</p></summary>
        public virtual string StorageAccount { get; internal set; }
        /// <summary><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        public virtual string Location { get; internal set; }
        /// <summary><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        public virtual string Tags { get; internal set; }
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
              .Add("ams account create")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--storage-account {value}", StorageAccount)
              .Add("--location {value}", Location)
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
    #region AzureAmsAccountDeleteSettings
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAmsAccountDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAms executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAmsTasks.AzureAmsPath;
        /// <summary><p>The name of the Azure Media Services account.</p></summary>
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
              .Add("ams account delete")
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
    #region AzureAmsAccountListSettings
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAmsAccountListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAms executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAmsTasks.AzureAmsPath;
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
              .Add("ams account list")
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
    #region AzureAmsAccountShowSettings
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAmsAccountShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAms executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAmsTasks.AzureAmsPath;
        /// <summary><p>The name of the Azure Media Services account.</p></summary>
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
              .Add("ams account show")
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
    #region AzureAmsAccountUpdateSettings
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAmsAccountUpdateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAms executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAmsTasks.AzureAmsPath;
        /// <summary><p>The name of the Azure Media Services account.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        public virtual string Tags { get; internal set; }
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
              .Add("ams account update")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--tags {value}", Tags)
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
    #region AzureAmsAssetCreateSettings
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAmsAssetCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAms executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAmsTasks.AzureAmsPath;
        /// <summary><p>The name of the Azure Media Services account.</p></summary>
        public virtual string AccountName { get; internal set; }
        /// <summary><p>The name of the asset.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The alternate id of the asset.</p></summary>
        public virtual string AlternateId { get; internal set; }
        /// <summary><p>The asset description.</p></summary>
        public virtual string Description { get; internal set; }
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
              .Add("ams asset create")
              .Add("--account-name {value}", AccountName)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--alternate-id {value}", AlternateId)
              .Add("--description {value}", Description)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureAmsAssetDeleteSettings
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAmsAssetDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAms executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAmsTasks.AzureAmsPath;
        /// <summary><p>The name of the Azure Media Services account.</p></summary>
        public virtual string AccountName { get; internal set; }
        /// <summary><p>The name of the asset.</p></summary>
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
              .Add("ams asset delete")
              .Add("--account-name {value}", AccountName)
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
    #region AzureAmsAssetGetSasUrlsSettings
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAmsAssetGetSasUrlsSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAms executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAmsTasks.AzureAmsPath;
        /// <summary><p>The name of the Azure Media Services account.</p></summary>
        public virtual string AccountName { get; internal set; }
        /// <summary><p>The name of the asset.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Specifies the UTC datetime (Y-m-d'T'H:M:S'Z') at which the SAS becomes invalid.</p></summary>
        public virtual string Expiry { get; internal set; }
        /// <summary><p>The permissions to set on the SAS URL.</p></summary>
        public virtual AmsAssetGetSasUrlsPermissions Permissions { get; internal set; }
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
              .Add("ams asset get-sas-urls")
              .Add("--account-name {value}", AccountName)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--expiry {value}", Expiry)
              .Add("--permissions {value}", Permissions)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureAmsAssetListSettings
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAmsAssetListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAms executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAmsTasks.AzureAmsPath;
        /// <summary><p>The name of the Azure Media Services account.</p></summary>
        public virtual string AccountName { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Restricts the set of items returned.</p></summary>
        public virtual string Filter { get; internal set; }
        /// <summary><p>Specifies the the key by which the result collection should be ordered.</p></summary>
        public virtual string Orderby { get; internal set; }
        /// <summary><p>Specifies a non-negative integer n that limits the number of items returned from a collection. The service returns the number of available items up to but not greater than the specified value n.</p></summary>
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
              .Add("ams asset list")
              .Add("--account-name {value}", AccountName)
              .Add("--resource-group {value}", ResourceGroup)
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
    #region AzureAmsAssetShowSettings
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAmsAssetShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAms executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAmsTasks.AzureAmsPath;
        /// <summary><p>The name of the Azure Media Services account.</p></summary>
        public virtual string AccountName { get; internal set; }
        /// <summary><p>The name of the asset.</p></summary>
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
              .Add("ams asset show")
              .Add("--account-name {value}", AccountName)
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
    #region AzureAmsAssetUpdateSettings
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAmsAssetUpdateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAms executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAmsTasks.AzureAmsPath;
        /// <summary><p>The name of the Azure Media Services account.</p></summary>
        public virtual string AccountName { get; internal set; }
        /// <summary><p>The name of the asset.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The alternate id of the asset.</p></summary>
        public virtual string AlternateId { get; internal set; }
        /// <summary><p>The asset description.</p></summary>
        public virtual string Description { get; internal set; }
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
              .Add("ams asset update")
              .Add("--account-name {value}", AccountName)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--alternate-id {value}", AlternateId)
              .Add("--description {value}", Description)
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
    #region AzureAmsJobCancelSettings
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAmsJobCancelSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAms executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAmsTasks.AzureAmsPath;
        /// <summary><p>The name of the Azure Media Services account.</p></summary>
        public virtual string AccountName { get; internal set; }
        /// <summary><p>The name of the job.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The name of the transform.</p></summary>
        public virtual string TransformName { get; internal set; }
        /// <summary><p>Delete the job being cancelled.</p></summary>
        public virtual string Delete { get; internal set; }
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
              .Add("ams job cancel")
              .Add("--account-name {value}", AccountName)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--transform-name {value}", TransformName)
              .Add("--delete {value}", Delete)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureAmsJobDeleteSettings
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAmsJobDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAms executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAmsTasks.AzureAmsPath;
        /// <summary><p>The name of the Azure Media Services account.</p></summary>
        public virtual string AccountName { get; internal set; }
        /// <summary><p>The name of the job.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The name of the transform.</p></summary>
        public virtual string TransformName { get; internal set; }
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
              .Add("ams job delete")
              .Add("--account-name {value}", AccountName)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--transform-name {value}", TransformName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureAmsJobListSettings
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAmsJobListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAms executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAmsTasks.AzureAmsPath;
        /// <summary><p>The name of the Azure Media Services account.</p></summary>
        public virtual string AccountName { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The name of the transform.</p></summary>
        public virtual string TransformName { get; internal set; }
        /// <summary><p>Restricts the set of items returned.</p></summary>
        public virtual string Filter { get; internal set; }
        /// <summary><p>Specifies a non-negative integer n that excludes the first n items of the queried collection from the result. The service returns items starting at position n+1.</p></summary>
        public virtual string Skip { get; internal set; }
        /// <summary><p>Specifies a non-negative integer n that limits the number of items returned from a collection. The service returns the number of available items up to but not greater than the specified value n.</p></summary>
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
              .Add("ams job list")
              .Add("--account-name {value}", AccountName)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--transform-name {value}", TransformName)
              .Add("--filter {value}", Filter)
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
    #region AzureAmsJobShowSettings
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAmsJobShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAms executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAmsTasks.AzureAmsPath;
        /// <summary><p>The name of the Azure Media Services account.</p></summary>
        public virtual string AccountName { get; internal set; }
        /// <summary><p>The name of the job.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The name of the transform.</p></summary>
        public virtual string TransformName { get; internal set; }
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
              .Add("ams job show")
              .Add("--account-name {value}", AccountName)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--transform-name {value}", TransformName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureAmsJobStartSettings
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAmsJobStartSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAms executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAmsTasks.AzureAmsPath;
        /// <summary><p>The name of the Azure Media Services account.</p></summary>
        public virtual string AccountName { get; internal set; }
        /// <summary><p>The name of the job.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Space-separated list of output asset names.</p></summary>
        public virtual IReadOnlyList<string> OutputAssetNames => OutputAssetNamesInternal.AsReadOnly();
        internal List<string> OutputAssetNamesInternal { get; set; } = new List<string>();
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The name of the transform.</p></summary>
        public virtual string TransformName { get; internal set; }
        /// <summary><p>The job description.</p></summary>
        public virtual string Description { get; internal set; }
        /// <summary><p>Space-separated list of files. It can be used to tell the service to only use the files specified from the input asset.</p></summary>
        public virtual IReadOnlyList<string> Files => FilesInternal.AsReadOnly();
        internal List<string> FilesInternal { get; set; } = new List<string>();
        /// <summary><p>The priority with which the job should be processed.</p></summary>
        public virtual AmsJobStartPriority Priority { get; internal set; }
        /// <summary><p>The name of the input asset.</p></summary>
        public virtual string InputAssetName { get; internal set; }
        /// <summary><p>Base uri for http job input. It will be concatenated with provided file names. If no base uri is given, then the provided file list is assumed to be fully qualified uris.</p></summary>
        public virtual string BaseUri { get; internal set; }
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
              .Add("ams job start")
              .Add("--account-name {value}", AccountName)
              .Add("--name {value}", Name)
              .Add("--output-asset-names {value}", OutputAssetNames, separator: ' ')
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--transform-name {value}", TransformName)
              .Add("--description {value}", Description)
              .Add("--files {value}", Files, separator: ' ')
              .Add("--priority {value}", Priority)
              .Add("--input-asset-name {value}", InputAssetName)
              .Add("--base-uri {value}", BaseUri)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureAmsStreamingSettings
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAmsStreamingSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAms executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAmsTasks.AzureAmsPath;
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
              .Add("ams streaming")
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureAmsTransformCreateSettings
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAmsTransformCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAms executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAmsTasks.AzureAmsPath;
        /// <summary><p>The name of the Azure Media Services account.</p></summary>
        public virtual string AccountName { get; internal set; }
        /// <summary><p>The name of the transform.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Space-separated list of built-in preset names.</p></summary>
        public virtual IReadOnlyList<AmsTransformPresetNames> PresetNames => PresetNamesInternal.AsReadOnly();
        internal List<AmsTransformPresetNames> PresetNamesInternal { get; set; } = new List<AmsTransformPresetNames>();
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The description of the transform.</p></summary>
        public virtual string Description { get; internal set; }
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
              .Add("ams transform create")
              .Add("--account-name {value}", AccountName)
              .Add("--name {value}", Name)
              .Add("--preset-names {value}", PresetNames, separator: ' ')
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--description {value}", Description)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureAmsTransformDeleteSettings
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAmsTransformDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAms executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAmsTasks.AzureAmsPath;
        /// <summary><p>The name of the Azure Media Services account.</p></summary>
        public virtual string AccountName { get; internal set; }
        /// <summary><p>The name of the transform.</p></summary>
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
              .Add("ams transform delete")
              .Add("--account-name {value}", AccountName)
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
    #region AzureAmsTransformListSettings
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAmsTransformListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAms executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAmsTasks.AzureAmsPath;
        /// <summary><p>The name of the Azure Media Services account.</p></summary>
        public virtual string AccountName { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Restricts the set of items returned.</p></summary>
        public virtual string Filter { get; internal set; }
        /// <summary><p>Specifies a non-negative integer n that excludes the first n items of the queried collection from the result. The service returns items starting at position n+1.</p></summary>
        public virtual string Skip { get; internal set; }
        /// <summary><p>Specifies a non-negative integer n that limits the number of items returned from a collection. The service returns the number of available items up to but not greater than the specified value n.</p></summary>
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
              .Add("ams transform list")
              .Add("--account-name {value}", AccountName)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--filter {value}", Filter)
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
    #region AzureAmsTransformShowSettings
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAmsTransformShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAms executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAmsTasks.AzureAmsPath;
        /// <summary><p>The name of the Azure Media Services account.</p></summary>
        public virtual string AccountName { get; internal set; }
        /// <summary><p>The name of the transform.</p></summary>
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
              .Add("ams transform show")
              .Add("--account-name {value}", AccountName)
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
    #region AzureAmsTransformUpdateSettings
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAmsTransformUpdateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAms executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAmsTasks.AzureAmsPath;
        /// <summary><p>The name of the Azure Media Services account.</p></summary>
        public virtual string AccountName { get; internal set; }
        /// <summary><p>The name of the transform.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The description of the transform.</p></summary>
        public virtual string Description { get; internal set; }
        /// <summary><p>Space-separated list of built-in preset names.</p></summary>
        public virtual IReadOnlyList<AmsTransformPresetNames> PresetNames => PresetNamesInternal.AsReadOnly();
        internal List<AmsTransformPresetNames> PresetNamesInternal { get; set; } = new List<AmsTransformPresetNames>();
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
              .Add("ams transform update")
              .Add("--account-name {value}", AccountName)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--description {value}", Description)
              .Add("--preset-names {value}", PresetNames, separator: ' ')
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
    #region AzureAmsAccountSpCreateSettings
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAmsAccountSpCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAms executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAmsTasks.AzureAmsPath;
        /// <summary><p>The name of the Azure Media Services account.</p></summary>
        public virtual string AccountName { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The app name or app URI to associate the RBAC with. If not present, a default name like '{amsaccountname}-access-sp' will be generated.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>The password used to log in. Also known as 'Client Secret'. If not present, a random secret will be generated.</p></summary>
        public virtual string Password { get; internal set; }
        /// <summary><p>The role of the service principal.</p></summary>
        public virtual string Role { get; internal set; }
        /// <summary><p>Enables xml output format.</p></summary>
        public virtual string Xml { get; internal set; }
        /// <summary><p>Number of years for which the secret will be valid. Default: 1 year.</p></summary>
        public virtual int? Years { get; internal set; }
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
              .Add("ams account sp create")
              .Add("--account-name {value}", AccountName)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--name {value}", Name)
              .Add("--password {value}", Password)
              .Add("--role {value}", Role)
              .Add("--xml {value}", Xml)
              .Add("--years {value}", Years)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureAmsAccountSpResetCredentialsSettings
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAmsAccountSpResetCredentialsSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAms executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAmsTasks.AzureAmsPath;
        /// <summary><p>The name of the Azure Media Services account.</p></summary>
        public virtual string AccountName { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The app name or app URI to associate the RBAC with. If not present, a default name like '{amsaccountname}-access-sp' will be generated.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>The password used to log in. Also known as 'Client Secret'. If not present, a random secret will be generated.</p></summary>
        public virtual string Password { get; internal set; }
        /// <summary><p>The role of the service principal.</p></summary>
        public virtual string Role { get; internal set; }
        /// <summary><p>Enables xml output format.</p></summary>
        public virtual string Xml { get; internal set; }
        /// <summary><p>Number of years for which the secret will be valid. Default: 1 year.</p></summary>
        public virtual int? Years { get; internal set; }
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
              .Add("ams account sp reset-credentials")
              .Add("--account-name {value}", AccountName)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--name {value}", Name)
              .Add("--password {value}", Password)
              .Add("--role {value}", Role)
              .Add("--xml {value}", Xml)
              .Add("--years {value}", Years)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureAmsAccountStorageAddSettings
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAmsAccountStorageAddSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAms executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAmsTasks.AzureAmsPath;
        /// <summary><p>The name of the Azure Media Services account.</p></summary>
        public virtual string AccountName { get; internal set; }
        /// <summary><p>The name or resource ID of the secondary storage account to detach from the Azure Media Services account.</p></summary>
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
              .Add("ams account storage add")
              .Add("--account-name {value}", AccountName)
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
    #region AzureAmsAccountStorageRemoveSettings
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAmsAccountStorageRemoveSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAms executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAmsTasks.AzureAmsPath;
        /// <summary><p>The name of the Azure Media Services account.</p></summary>
        public virtual string AccountName { get; internal set; }
        /// <summary><p>The name or resource ID of the secondary storage account to detach from the Azure Media Services account.</p></summary>
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
              .Add("ams account storage remove")
              .Add("--account-name {value}", AccountName)
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
    #region AzureAmsStreamingEndpointListSettings
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAmsStreamingEndpointListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAms executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAmsTasks.AzureAmsPath;
        /// <summary><p>The name of the Azure Media Services account.</p></summary>
        public virtual string AccountName { get; internal set; }
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
              .Add("ams streaming endpoint list")
              .Add("--account-name {value}", AccountName)
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
    #region AzureAmsStreamingEndpointStartSettings
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAmsStreamingEndpointStartSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAms executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAmsTasks.AzureAmsPath;
        /// <summary><p>The name of the Azure Media Services account.</p></summary>
        public virtual string AccountName { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The name of the StreamingEndpoint.</p></summary>
        public virtual string StreamingEndpointName { get; internal set; }
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
              .Add("ams streaming endpoint start")
              .Add("--account-name {value}", AccountName)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--streaming-endpoint-name {value}", StreamingEndpointName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureAmsStreamingEndpointStopSettings
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAmsStreamingEndpointStopSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAms executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAmsTasks.AzureAmsPath;
        /// <summary><p>The name of the Azure Media Services account.</p></summary>
        public virtual string AccountName { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The name of the StreamingEndpoint.</p></summary>
        public virtual string StreamingEndpointName { get; internal set; }
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
              .Add("ams streaming endpoint stop")
              .Add("--account-name {value}", AccountName)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--streaming-endpoint-name {value}", StreamingEndpointName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureAmsStreamingLocatorCreateSettings
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAmsStreamingLocatorCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAms executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAmsTasks.AzureAmsPath;
        /// <summary><p>The name of the Azure Media Services account.</p></summary>
        public virtual string AccountName { get; internal set; }
        /// <summary><p>The name of the asset used by the streaming locator.</p></summary>
        public virtual string AssetName { get; internal set; }
        /// <summary><p>The name of the streaming locator.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The name of the streaming policy used by the streaming locator.</p></summary>
        public virtual string StreamingPolicyName { get; internal set; }
        /// <summary><p>The default content key policy name used by the streaming locator.</p></summary>
        public virtual string ContentPolicyName { get; internal set; }
        /// <summary><p>End time (Y-m-d'T'H:M:S'Z') of the streaming locator.</p></summary>
        public virtual string EndTime { get; internal set; }
        /// <summary><p>Start time (Y-m-d'T'H:M:S'Z') of the streaming locator.</p></summary>
        public virtual string StartTime { get; internal set; }
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
              .Add("ams streaming locator create")
              .Add("--account-name {value}", AccountName)
              .Add("--asset-name {value}", AssetName)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--streaming-policy-name {value}", StreamingPolicyName)
              .Add("--content-policy-name {value}", ContentPolicyName)
              .Add("--end-time {value}", EndTime)
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
    #region AzureAmsStreamingLocatorDeleteSettings
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAmsStreamingLocatorDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAms executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAmsTasks.AzureAmsPath;
        /// <summary><p>The name of the Azure Media Services account.</p></summary>
        public virtual string AccountName { get; internal set; }
        /// <summary><p>The name of the streaming locator.</p></summary>
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
              .Add("ams streaming locator delete")
              .Add("--account-name {value}", AccountName)
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
    #region AzureAmsStreamingLocatorGetPathsSettings
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAmsStreamingLocatorGetPathsSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAms executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAmsTasks.AzureAmsPath;
        /// <summary><p>The name of the Azure Media Services account.</p></summary>
        public virtual string AccountName { get; internal set; }
        /// <summary><p>The name of the streaming locator.</p></summary>
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
              .Add("ams streaming locator get-paths")
              .Add("--account-name {value}", AccountName)
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
    #region AzureAmsStreamingLocatorListSettings
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAmsStreamingLocatorListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAms executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAmsTasks.AzureAmsPath;
        /// <summary><p>The name of the Azure Media Services account.</p></summary>
        public virtual string AccountName { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Restricts the set of items returned.</p></summary>
        public virtual string Filter { get; internal set; }
        /// <summary><p>Specifies the the key by which the result collection should be ordered.</p></summary>
        public virtual string Orderby { get; internal set; }
        /// <summary><p>Specifies a non-negative integer n that limits the number of items returned from a collection. The service returns the number of available items up to but not greater than the specified value n.</p></summary>
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
              .Add("ams streaming locator list")
              .Add("--account-name {value}", AccountName)
              .Add("--resource-group {value}", ResourceGroup)
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
    #region AzureAmsStreamingLocatorShowSettings
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAmsStreamingLocatorShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAms executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAmsTasks.AzureAmsPath;
        /// <summary><p>The name of the Azure Media Services account.</p></summary>
        public virtual string AccountName { get; internal set; }
        /// <summary><p>The name of the streaming locator.</p></summary>
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
              .Add("ams streaming locator show")
              .Add("--account-name {value}", AccountName)
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
    #region AzureAmsStreamingPolicyCreateSettings
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAmsStreamingPolicyCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAms executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAmsTasks.AzureAmsPath;
        /// <summary><p>The name of the Azure Media Services account.</p></summary>
        public virtual string AccountName { get; internal set; }
        /// <summary><p>The name of the streaming policy.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The default content key policy name used by the streaming locator.</p></summary>
        public virtual string ContentPolicyName { get; internal set; }
        /// <summary><p>Enable Dash protocol.</p></summary>
        public virtual bool? Dash { get; internal set; }
        /// <summary><p>Enable Download protocol.</p></summary>
        public virtual bool? Download { get; internal set; }
        /// <summary><p>Enable HLS protocol.</p></summary>
        public virtual bool? Hls { get; internal set; }
        /// <summary><p>Enable SmoothStreaming protocol.</p></summary>
        public virtual bool? SmoothStreaming { get; internal set; }
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
              .Add("ams streaming policy create")
              .Add("--account-name {value}", AccountName)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--content-policy-name {value}", ContentPolicyName)
              .Add("--dash", Dash)
              .Add("--download", Download)
              .Add("--hls", Hls)
              .Add("--smooth-streaming", SmoothStreaming)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureAmsStreamingPolicyDeleteSettings
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAmsStreamingPolicyDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAms executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAmsTasks.AzureAmsPath;
        /// <summary><p>The name of the Azure Media Services account.</p></summary>
        public virtual string AccountName { get; internal set; }
        /// <summary><p>The name of the streaming policy.</p></summary>
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
              .Add("ams streaming policy delete")
              .Add("--account-name {value}", AccountName)
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
    #region AzureAmsStreamingPolicyListSettings
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAmsStreamingPolicyListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAms executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAmsTasks.AzureAmsPath;
        /// <summary><p>The name of the Azure Media Services account.</p></summary>
        public virtual string AccountName { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Restricts the set of items returned.</p></summary>
        public virtual string Filter { get; internal set; }
        /// <summary><p>Specifies the the key by which the result collection should be ordered.</p></summary>
        public virtual string Orderby { get; internal set; }
        /// <summary><p>Specifies a non-negative integer n that limits the number of items returned from a collection. The service returns the number of available items up to but not greater than the specified value n.</p></summary>
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
              .Add("ams streaming policy list")
              .Add("--account-name {value}", AccountName)
              .Add("--resource-group {value}", ResourceGroup)
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
    #region AzureAmsStreamingPolicyShowSettings
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAmsStreamingPolicyShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAms executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAmsTasks.AzureAmsPath;
        /// <summary><p>The name of the Azure Media Services account.</p></summary>
        public virtual string AccountName { get; internal set; }
        /// <summary><p>The name of the streaming policy.</p></summary>
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
              .Add("ams streaming policy show")
              .Add("--account-name {value}", AccountName)
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
    #region AzureAmsTransformOutputAddSettings
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAmsTransformOutputAddSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAms executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAmsTasks.AzureAmsPath;
        /// <summary><p>The name of the Azure Media Services account.</p></summary>
        public virtual string AccountName { get; internal set; }
        /// <summary><p>The name of the transform.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Space-separated list of built-in preset names.</p></summary>
        public virtual IReadOnlyList<AmsTransformPresetNames> PresetNames => PresetNamesInternal.AsReadOnly();
        internal List<AmsTransformPresetNames> PresetNamesInternal { get; set; } = new List<AmsTransformPresetNames>();
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
              .Add("ams transform output add")
              .Add("--account-name {value}", AccountName)
              .Add("--name {value}", Name)
              .Add("--preset-names {value}", PresetNames, separator: ' ')
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
    #region AzureAmsTransformOutputRemoveSettings
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAmsTransformOutputRemoveSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAms executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAmsTasks.AzureAmsPath;
        /// <summary><p>The name of the Azure Media Services account.</p></summary>
        public virtual string AccountName { get; internal set; }
        /// <summary><p>The name of the transform.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Space-separated list of built-in preset names.</p></summary>
        public virtual IReadOnlyList<AmsTransformPresetNames> PresetNames => PresetNamesInternal.AsReadOnly();
        internal List<AmsTransformPresetNames> PresetNamesInternal { get; set; } = new List<AmsTransformPresetNames>();
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
              .Add("ams transform output remove")
              .Add("--account-name {value}", AccountName)
              .Add("--name {value}", Name)
              .Add("--preset-names {value}", PresetNames, separator: ' ')
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
    #region AzureAmsSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAmsSettingsExtensions
    {
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAmsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAmsSettings SetDebug(this AzureAmsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAmsSettings ResetDebug(this AzureAmsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAmsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAmsSettings SetHelp(this AzureAmsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAmsSettings ResetHelp(this AzureAmsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAmsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAmsSettings SetOutput(this AzureAmsSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAmsSettings ResetOutput(this AzureAmsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAmsSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAmsSettings SetQuery(this AzureAmsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAmsSettings ResetQuery(this AzureAmsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAmsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAmsSettings SetVerbose(this AzureAmsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAmsSettings ResetVerbose(this AzureAmsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAmsAccountCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAmsAccountCreateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAmsAccountCreateSettings.Name"/>.</em></p><p>The name of the Azure Media Services account.</p></summary>
        [Pure]
        public static AzureAmsAccountCreateSettings SetName(this AzureAmsAccountCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAccountCreateSettings.Name"/>.</em></p><p>The name of the Azure Media Services account.</p></summary>
        [Pure]
        public static AzureAmsAccountCreateSettings ResetName(this AzureAmsAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAmsAccountCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAmsAccountCreateSettings SetResourceGroup(this AzureAmsAccountCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAccountCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAmsAccountCreateSettings ResetResourceGroup(this AzureAmsAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region StorageAccount
        /// <summary><p><em>Sets <see cref="AzureAmsAccountCreateSettings.StorageAccount"/>.</em></p><p>The name or resource ID of the primary storage account to attach to the Azure Media Services account. Blob only accounts are not allowed as primary.</p></summary>
        [Pure]
        public static AzureAmsAccountCreateSettings SetStorageAccount(this AzureAmsAccountCreateSettings toolSettings, string storageAccount)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageAccount = storageAccount;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAccountCreateSettings.StorageAccount"/>.</em></p><p>The name or resource ID of the primary storage account to attach to the Azure Media Services account. Blob only accounts are not allowed as primary.</p></summary>
        [Pure]
        public static AzureAmsAccountCreateSettings ResetStorageAccount(this AzureAmsAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageAccount = null;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary><p><em>Sets <see cref="AzureAmsAccountCreateSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAmsAccountCreateSettings SetLocation(this AzureAmsAccountCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAccountCreateSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAmsAccountCreateSettings ResetLocation(this AzureAmsAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary><p><em>Sets <see cref="AzureAmsAccountCreateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureAmsAccountCreateSettings SetTags(this AzureAmsAccountCreateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAccountCreateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureAmsAccountCreateSettings ResetTags(this AzureAmsAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAmsAccountCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAmsAccountCreateSettings SetDebug(this AzureAmsAccountCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAccountCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAmsAccountCreateSettings ResetDebug(this AzureAmsAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAmsAccountCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAmsAccountCreateSettings SetHelp(this AzureAmsAccountCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAccountCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAmsAccountCreateSettings ResetHelp(this AzureAmsAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAmsAccountCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAmsAccountCreateSettings SetOutput(this AzureAmsAccountCreateSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAccountCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAmsAccountCreateSettings ResetOutput(this AzureAmsAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAmsAccountCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAmsAccountCreateSettings SetQuery(this AzureAmsAccountCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAccountCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAmsAccountCreateSettings ResetQuery(this AzureAmsAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAmsAccountCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAmsAccountCreateSettings SetVerbose(this AzureAmsAccountCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAccountCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAmsAccountCreateSettings ResetVerbose(this AzureAmsAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAmsAccountDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAmsAccountDeleteSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAmsAccountDeleteSettings.Name"/>.</em></p><p>The name of the Azure Media Services account.</p></summary>
        [Pure]
        public static AzureAmsAccountDeleteSettings SetName(this AzureAmsAccountDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAccountDeleteSettings.Name"/>.</em></p><p>The name of the Azure Media Services account.</p></summary>
        [Pure]
        public static AzureAmsAccountDeleteSettings ResetName(this AzureAmsAccountDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAmsAccountDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAmsAccountDeleteSettings SetResourceGroup(this AzureAmsAccountDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAccountDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAmsAccountDeleteSettings ResetResourceGroup(this AzureAmsAccountDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAmsAccountDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAmsAccountDeleteSettings SetDebug(this AzureAmsAccountDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAccountDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAmsAccountDeleteSettings ResetDebug(this AzureAmsAccountDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAmsAccountDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAmsAccountDeleteSettings SetHelp(this AzureAmsAccountDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAccountDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAmsAccountDeleteSettings ResetHelp(this AzureAmsAccountDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAmsAccountDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAmsAccountDeleteSettings SetOutput(this AzureAmsAccountDeleteSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAccountDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAmsAccountDeleteSettings ResetOutput(this AzureAmsAccountDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAmsAccountDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAmsAccountDeleteSettings SetQuery(this AzureAmsAccountDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAccountDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAmsAccountDeleteSettings ResetQuery(this AzureAmsAccountDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAmsAccountDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAmsAccountDeleteSettings SetVerbose(this AzureAmsAccountDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAccountDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAmsAccountDeleteSettings ResetVerbose(this AzureAmsAccountDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAmsAccountListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAmsAccountListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAmsAccountListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAmsAccountListSettings SetResourceGroup(this AzureAmsAccountListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAccountListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAmsAccountListSettings ResetResourceGroup(this AzureAmsAccountListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAmsAccountListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAmsAccountListSettings SetDebug(this AzureAmsAccountListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAccountListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAmsAccountListSettings ResetDebug(this AzureAmsAccountListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAmsAccountListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAmsAccountListSettings SetHelp(this AzureAmsAccountListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAccountListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAmsAccountListSettings ResetHelp(this AzureAmsAccountListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAmsAccountListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAmsAccountListSettings SetOutput(this AzureAmsAccountListSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAccountListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAmsAccountListSettings ResetOutput(this AzureAmsAccountListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAmsAccountListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAmsAccountListSettings SetQuery(this AzureAmsAccountListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAccountListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAmsAccountListSettings ResetQuery(this AzureAmsAccountListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAmsAccountListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAmsAccountListSettings SetVerbose(this AzureAmsAccountListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAccountListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAmsAccountListSettings ResetVerbose(this AzureAmsAccountListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAmsAccountShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAmsAccountShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAmsAccountShowSettings.Name"/>.</em></p><p>The name of the Azure Media Services account.</p></summary>
        [Pure]
        public static AzureAmsAccountShowSettings SetName(this AzureAmsAccountShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAccountShowSettings.Name"/>.</em></p><p>The name of the Azure Media Services account.</p></summary>
        [Pure]
        public static AzureAmsAccountShowSettings ResetName(this AzureAmsAccountShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAmsAccountShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAmsAccountShowSettings SetResourceGroup(this AzureAmsAccountShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAccountShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAmsAccountShowSettings ResetResourceGroup(this AzureAmsAccountShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAmsAccountShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAmsAccountShowSettings SetDebug(this AzureAmsAccountShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAccountShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAmsAccountShowSettings ResetDebug(this AzureAmsAccountShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAmsAccountShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAmsAccountShowSettings SetHelp(this AzureAmsAccountShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAccountShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAmsAccountShowSettings ResetHelp(this AzureAmsAccountShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAmsAccountShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAmsAccountShowSettings SetOutput(this AzureAmsAccountShowSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAccountShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAmsAccountShowSettings ResetOutput(this AzureAmsAccountShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAmsAccountShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAmsAccountShowSettings SetQuery(this AzureAmsAccountShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAccountShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAmsAccountShowSettings ResetQuery(this AzureAmsAccountShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAmsAccountShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAmsAccountShowSettings SetVerbose(this AzureAmsAccountShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAccountShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAmsAccountShowSettings ResetVerbose(this AzureAmsAccountShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAmsAccountUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAmsAccountUpdateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAmsAccountUpdateSettings.Name"/>.</em></p><p>The name of the Azure Media Services account.</p></summary>
        [Pure]
        public static AzureAmsAccountUpdateSettings SetName(this AzureAmsAccountUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAccountUpdateSettings.Name"/>.</em></p><p>The name of the Azure Media Services account.</p></summary>
        [Pure]
        public static AzureAmsAccountUpdateSettings ResetName(this AzureAmsAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAmsAccountUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAmsAccountUpdateSettings SetResourceGroup(this AzureAmsAccountUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAccountUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAmsAccountUpdateSettings ResetResourceGroup(this AzureAmsAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary><p><em>Sets <see cref="AzureAmsAccountUpdateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureAmsAccountUpdateSettings SetTags(this AzureAmsAccountUpdateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAccountUpdateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureAmsAccountUpdateSettings ResetTags(this AzureAmsAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary><p><em>Sets <see cref="AzureAmsAccountUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureAmsAccountUpdateSettings SetAdd(this AzureAmsAccountUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAccountUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureAmsAccountUpdateSettings ResetAdd(this AzureAmsAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary><p><em>Sets <see cref="AzureAmsAccountUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureAmsAccountUpdateSettings SetRemove(this AzureAmsAccountUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAccountUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureAmsAccountUpdateSettings ResetRemove(this AzureAmsAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary><p><em>Sets <see cref="AzureAmsAccountUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureAmsAccountUpdateSettings SetSet(this AzureAmsAccountUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAccountUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureAmsAccountUpdateSettings ResetSet(this AzureAmsAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAmsAccountUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAmsAccountUpdateSettings SetDebug(this AzureAmsAccountUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAccountUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAmsAccountUpdateSettings ResetDebug(this AzureAmsAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAmsAccountUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAmsAccountUpdateSettings SetHelp(this AzureAmsAccountUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAccountUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAmsAccountUpdateSettings ResetHelp(this AzureAmsAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAmsAccountUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAmsAccountUpdateSettings SetOutput(this AzureAmsAccountUpdateSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAccountUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAmsAccountUpdateSettings ResetOutput(this AzureAmsAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAmsAccountUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAmsAccountUpdateSettings SetQuery(this AzureAmsAccountUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAccountUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAmsAccountUpdateSettings ResetQuery(this AzureAmsAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAmsAccountUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAmsAccountUpdateSettings SetVerbose(this AzureAmsAccountUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAccountUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAmsAccountUpdateSettings ResetVerbose(this AzureAmsAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAmsAssetCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAmsAssetCreateSettingsExtensions
    {
        #region AccountName
        /// <summary><p><em>Sets <see cref="AzureAmsAssetCreateSettings.AccountName"/>.</em></p><p>The name of the Azure Media Services account.</p></summary>
        [Pure]
        public static AzureAmsAssetCreateSettings SetAccountName(this AzureAmsAssetCreateSettings toolSettings, string accountName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = accountName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAssetCreateSettings.AccountName"/>.</em></p><p>The name of the Azure Media Services account.</p></summary>
        [Pure]
        public static AzureAmsAssetCreateSettings ResetAccountName(this AzureAmsAssetCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAmsAssetCreateSettings.Name"/>.</em></p><p>The name of the asset.</p></summary>
        [Pure]
        public static AzureAmsAssetCreateSettings SetName(this AzureAmsAssetCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAssetCreateSettings.Name"/>.</em></p><p>The name of the asset.</p></summary>
        [Pure]
        public static AzureAmsAssetCreateSettings ResetName(this AzureAmsAssetCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAmsAssetCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAmsAssetCreateSettings SetResourceGroup(this AzureAmsAssetCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAssetCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAmsAssetCreateSettings ResetResourceGroup(this AzureAmsAssetCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region AlternateId
        /// <summary><p><em>Sets <see cref="AzureAmsAssetCreateSettings.AlternateId"/>.</em></p><p>The alternate id of the asset.</p></summary>
        [Pure]
        public static AzureAmsAssetCreateSettings SetAlternateId(this AzureAmsAssetCreateSettings toolSettings, string alternateId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AlternateId = alternateId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAssetCreateSettings.AlternateId"/>.</em></p><p>The alternate id of the asset.</p></summary>
        [Pure]
        public static AzureAmsAssetCreateSettings ResetAlternateId(this AzureAmsAssetCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AlternateId = null;
            return toolSettings;
        }
        #endregion
        #region Description
        /// <summary><p><em>Sets <see cref="AzureAmsAssetCreateSettings.Description"/>.</em></p><p>The asset description.</p></summary>
        [Pure]
        public static AzureAmsAssetCreateSettings SetDescription(this AzureAmsAssetCreateSettings toolSettings, string description)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Description = description;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAssetCreateSettings.Description"/>.</em></p><p>The asset description.</p></summary>
        [Pure]
        public static AzureAmsAssetCreateSettings ResetDescription(this AzureAmsAssetCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Description = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAmsAssetCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAmsAssetCreateSettings SetDebug(this AzureAmsAssetCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAssetCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAmsAssetCreateSettings ResetDebug(this AzureAmsAssetCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAmsAssetCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAmsAssetCreateSettings SetHelp(this AzureAmsAssetCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAssetCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAmsAssetCreateSettings ResetHelp(this AzureAmsAssetCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAmsAssetCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAmsAssetCreateSettings SetOutput(this AzureAmsAssetCreateSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAssetCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAmsAssetCreateSettings ResetOutput(this AzureAmsAssetCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAmsAssetCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAmsAssetCreateSettings SetQuery(this AzureAmsAssetCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAssetCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAmsAssetCreateSettings ResetQuery(this AzureAmsAssetCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAmsAssetCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAmsAssetCreateSettings SetVerbose(this AzureAmsAssetCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAssetCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAmsAssetCreateSettings ResetVerbose(this AzureAmsAssetCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAmsAssetDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAmsAssetDeleteSettingsExtensions
    {
        #region AccountName
        /// <summary><p><em>Sets <see cref="AzureAmsAssetDeleteSettings.AccountName"/>.</em></p><p>The name of the Azure Media Services account.</p></summary>
        [Pure]
        public static AzureAmsAssetDeleteSettings SetAccountName(this AzureAmsAssetDeleteSettings toolSettings, string accountName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = accountName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAssetDeleteSettings.AccountName"/>.</em></p><p>The name of the Azure Media Services account.</p></summary>
        [Pure]
        public static AzureAmsAssetDeleteSettings ResetAccountName(this AzureAmsAssetDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAmsAssetDeleteSettings.Name"/>.</em></p><p>The name of the asset.</p></summary>
        [Pure]
        public static AzureAmsAssetDeleteSettings SetName(this AzureAmsAssetDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAssetDeleteSettings.Name"/>.</em></p><p>The name of the asset.</p></summary>
        [Pure]
        public static AzureAmsAssetDeleteSettings ResetName(this AzureAmsAssetDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAmsAssetDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAmsAssetDeleteSettings SetResourceGroup(this AzureAmsAssetDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAssetDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAmsAssetDeleteSettings ResetResourceGroup(this AzureAmsAssetDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAmsAssetDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAmsAssetDeleteSettings SetDebug(this AzureAmsAssetDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAssetDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAmsAssetDeleteSettings ResetDebug(this AzureAmsAssetDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAmsAssetDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAmsAssetDeleteSettings SetHelp(this AzureAmsAssetDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAssetDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAmsAssetDeleteSettings ResetHelp(this AzureAmsAssetDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAmsAssetDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAmsAssetDeleteSettings SetOutput(this AzureAmsAssetDeleteSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAssetDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAmsAssetDeleteSettings ResetOutput(this AzureAmsAssetDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAmsAssetDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAmsAssetDeleteSettings SetQuery(this AzureAmsAssetDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAssetDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAmsAssetDeleteSettings ResetQuery(this AzureAmsAssetDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAmsAssetDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAmsAssetDeleteSettings SetVerbose(this AzureAmsAssetDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAssetDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAmsAssetDeleteSettings ResetVerbose(this AzureAmsAssetDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAmsAssetGetSasUrlsSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAmsAssetGetSasUrlsSettingsExtensions
    {
        #region AccountName
        /// <summary><p><em>Sets <see cref="AzureAmsAssetGetSasUrlsSettings.AccountName"/>.</em></p><p>The name of the Azure Media Services account.</p></summary>
        [Pure]
        public static AzureAmsAssetGetSasUrlsSettings SetAccountName(this AzureAmsAssetGetSasUrlsSettings toolSettings, string accountName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = accountName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAssetGetSasUrlsSettings.AccountName"/>.</em></p><p>The name of the Azure Media Services account.</p></summary>
        [Pure]
        public static AzureAmsAssetGetSasUrlsSettings ResetAccountName(this AzureAmsAssetGetSasUrlsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAmsAssetGetSasUrlsSettings.Name"/>.</em></p><p>The name of the asset.</p></summary>
        [Pure]
        public static AzureAmsAssetGetSasUrlsSettings SetName(this AzureAmsAssetGetSasUrlsSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAssetGetSasUrlsSettings.Name"/>.</em></p><p>The name of the asset.</p></summary>
        [Pure]
        public static AzureAmsAssetGetSasUrlsSettings ResetName(this AzureAmsAssetGetSasUrlsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAmsAssetGetSasUrlsSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAmsAssetGetSasUrlsSettings SetResourceGroup(this AzureAmsAssetGetSasUrlsSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAssetGetSasUrlsSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAmsAssetGetSasUrlsSettings ResetResourceGroup(this AzureAmsAssetGetSasUrlsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Expiry
        /// <summary><p><em>Sets <see cref="AzureAmsAssetGetSasUrlsSettings.Expiry"/>.</em></p><p>Specifies the UTC datetime (Y-m-d'T'H:M:S'Z') at which the SAS becomes invalid.</p></summary>
        [Pure]
        public static AzureAmsAssetGetSasUrlsSettings SetExpiry(this AzureAmsAssetGetSasUrlsSettings toolSettings, string expiry)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expiry = expiry;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAssetGetSasUrlsSettings.Expiry"/>.</em></p><p>Specifies the UTC datetime (Y-m-d'T'H:M:S'Z') at which the SAS becomes invalid.</p></summary>
        [Pure]
        public static AzureAmsAssetGetSasUrlsSettings ResetExpiry(this AzureAmsAssetGetSasUrlsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expiry = null;
            return toolSettings;
        }
        #endregion
        #region Permissions
        /// <summary><p><em>Sets <see cref="AzureAmsAssetGetSasUrlsSettings.Permissions"/>.</em></p><p>The permissions to set on the SAS URL.</p></summary>
        [Pure]
        public static AzureAmsAssetGetSasUrlsSettings SetPermissions(this AzureAmsAssetGetSasUrlsSettings toolSettings, AmsAssetGetSasUrlsPermissions permissions)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Permissions = permissions;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAssetGetSasUrlsSettings.Permissions"/>.</em></p><p>The permissions to set on the SAS URL.</p></summary>
        [Pure]
        public static AzureAmsAssetGetSasUrlsSettings ResetPermissions(this AzureAmsAssetGetSasUrlsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Permissions = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAmsAssetGetSasUrlsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAmsAssetGetSasUrlsSettings SetDebug(this AzureAmsAssetGetSasUrlsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAssetGetSasUrlsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAmsAssetGetSasUrlsSettings ResetDebug(this AzureAmsAssetGetSasUrlsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAmsAssetGetSasUrlsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAmsAssetGetSasUrlsSettings SetHelp(this AzureAmsAssetGetSasUrlsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAssetGetSasUrlsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAmsAssetGetSasUrlsSettings ResetHelp(this AzureAmsAssetGetSasUrlsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAmsAssetGetSasUrlsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAmsAssetGetSasUrlsSettings SetOutput(this AzureAmsAssetGetSasUrlsSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAssetGetSasUrlsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAmsAssetGetSasUrlsSettings ResetOutput(this AzureAmsAssetGetSasUrlsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAmsAssetGetSasUrlsSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAmsAssetGetSasUrlsSettings SetQuery(this AzureAmsAssetGetSasUrlsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAssetGetSasUrlsSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAmsAssetGetSasUrlsSettings ResetQuery(this AzureAmsAssetGetSasUrlsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAmsAssetGetSasUrlsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAmsAssetGetSasUrlsSettings SetVerbose(this AzureAmsAssetGetSasUrlsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAssetGetSasUrlsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAmsAssetGetSasUrlsSettings ResetVerbose(this AzureAmsAssetGetSasUrlsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAmsAssetListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAmsAssetListSettingsExtensions
    {
        #region AccountName
        /// <summary><p><em>Sets <see cref="AzureAmsAssetListSettings.AccountName"/>.</em></p><p>The name of the Azure Media Services account.</p></summary>
        [Pure]
        public static AzureAmsAssetListSettings SetAccountName(this AzureAmsAssetListSettings toolSettings, string accountName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = accountName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAssetListSettings.AccountName"/>.</em></p><p>The name of the Azure Media Services account.</p></summary>
        [Pure]
        public static AzureAmsAssetListSettings ResetAccountName(this AzureAmsAssetListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAmsAssetListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAmsAssetListSettings SetResourceGroup(this AzureAmsAssetListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAssetListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAmsAssetListSettings ResetResourceGroup(this AzureAmsAssetListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Filter
        /// <summary><p><em>Sets <see cref="AzureAmsAssetListSettings.Filter"/>.</em></p><p>Restricts the set of items returned.</p></summary>
        [Pure]
        public static AzureAmsAssetListSettings SetFilter(this AzureAmsAssetListSettings toolSettings, string filter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = filter;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAssetListSettings.Filter"/>.</em></p><p>Restricts the set of items returned.</p></summary>
        [Pure]
        public static AzureAmsAssetListSettings ResetFilter(this AzureAmsAssetListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = null;
            return toolSettings;
        }
        #endregion
        #region Orderby
        /// <summary><p><em>Sets <see cref="AzureAmsAssetListSettings.Orderby"/>.</em></p><p>Specifies the the key by which the result collection should be ordered.</p></summary>
        [Pure]
        public static AzureAmsAssetListSettings SetOrderby(this AzureAmsAssetListSettings toolSettings, string orderby)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Orderby = orderby;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAssetListSettings.Orderby"/>.</em></p><p>Specifies the the key by which the result collection should be ordered.</p></summary>
        [Pure]
        public static AzureAmsAssetListSettings ResetOrderby(this AzureAmsAssetListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Orderby = null;
            return toolSettings;
        }
        #endregion
        #region Top
        /// <summary><p><em>Sets <see cref="AzureAmsAssetListSettings.Top"/>.</em></p><p>Specifies a non-negative integer n that limits the number of items returned from a collection. The service returns the number of available items up to but not greater than the specified value n.</p></summary>
        [Pure]
        public static AzureAmsAssetListSettings SetTop(this AzureAmsAssetListSettings toolSettings, string top)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = top;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAssetListSettings.Top"/>.</em></p><p>Specifies a non-negative integer n that limits the number of items returned from a collection. The service returns the number of available items up to but not greater than the specified value n.</p></summary>
        [Pure]
        public static AzureAmsAssetListSettings ResetTop(this AzureAmsAssetListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAmsAssetListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAmsAssetListSettings SetDebug(this AzureAmsAssetListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAssetListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAmsAssetListSettings ResetDebug(this AzureAmsAssetListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAmsAssetListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAmsAssetListSettings SetHelp(this AzureAmsAssetListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAssetListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAmsAssetListSettings ResetHelp(this AzureAmsAssetListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAmsAssetListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAmsAssetListSettings SetOutput(this AzureAmsAssetListSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAssetListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAmsAssetListSettings ResetOutput(this AzureAmsAssetListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAmsAssetListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAmsAssetListSettings SetQuery(this AzureAmsAssetListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAssetListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAmsAssetListSettings ResetQuery(this AzureAmsAssetListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAmsAssetListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAmsAssetListSettings SetVerbose(this AzureAmsAssetListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAssetListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAmsAssetListSettings ResetVerbose(this AzureAmsAssetListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAmsAssetShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAmsAssetShowSettingsExtensions
    {
        #region AccountName
        /// <summary><p><em>Sets <see cref="AzureAmsAssetShowSettings.AccountName"/>.</em></p><p>The name of the Azure Media Services account.</p></summary>
        [Pure]
        public static AzureAmsAssetShowSettings SetAccountName(this AzureAmsAssetShowSettings toolSettings, string accountName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = accountName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAssetShowSettings.AccountName"/>.</em></p><p>The name of the Azure Media Services account.</p></summary>
        [Pure]
        public static AzureAmsAssetShowSettings ResetAccountName(this AzureAmsAssetShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAmsAssetShowSettings.Name"/>.</em></p><p>The name of the asset.</p></summary>
        [Pure]
        public static AzureAmsAssetShowSettings SetName(this AzureAmsAssetShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAssetShowSettings.Name"/>.</em></p><p>The name of the asset.</p></summary>
        [Pure]
        public static AzureAmsAssetShowSettings ResetName(this AzureAmsAssetShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAmsAssetShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAmsAssetShowSettings SetResourceGroup(this AzureAmsAssetShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAssetShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAmsAssetShowSettings ResetResourceGroup(this AzureAmsAssetShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAmsAssetShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAmsAssetShowSettings SetDebug(this AzureAmsAssetShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAssetShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAmsAssetShowSettings ResetDebug(this AzureAmsAssetShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAmsAssetShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAmsAssetShowSettings SetHelp(this AzureAmsAssetShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAssetShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAmsAssetShowSettings ResetHelp(this AzureAmsAssetShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAmsAssetShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAmsAssetShowSettings SetOutput(this AzureAmsAssetShowSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAssetShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAmsAssetShowSettings ResetOutput(this AzureAmsAssetShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAmsAssetShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAmsAssetShowSettings SetQuery(this AzureAmsAssetShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAssetShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAmsAssetShowSettings ResetQuery(this AzureAmsAssetShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAmsAssetShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAmsAssetShowSettings SetVerbose(this AzureAmsAssetShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAssetShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAmsAssetShowSettings ResetVerbose(this AzureAmsAssetShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAmsAssetUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAmsAssetUpdateSettingsExtensions
    {
        #region AccountName
        /// <summary><p><em>Sets <see cref="AzureAmsAssetUpdateSettings.AccountName"/>.</em></p><p>The name of the Azure Media Services account.</p></summary>
        [Pure]
        public static AzureAmsAssetUpdateSettings SetAccountName(this AzureAmsAssetUpdateSettings toolSettings, string accountName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = accountName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAssetUpdateSettings.AccountName"/>.</em></p><p>The name of the Azure Media Services account.</p></summary>
        [Pure]
        public static AzureAmsAssetUpdateSettings ResetAccountName(this AzureAmsAssetUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAmsAssetUpdateSettings.Name"/>.</em></p><p>The name of the asset.</p></summary>
        [Pure]
        public static AzureAmsAssetUpdateSettings SetName(this AzureAmsAssetUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAssetUpdateSettings.Name"/>.</em></p><p>The name of the asset.</p></summary>
        [Pure]
        public static AzureAmsAssetUpdateSettings ResetName(this AzureAmsAssetUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAmsAssetUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAmsAssetUpdateSettings SetResourceGroup(this AzureAmsAssetUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAssetUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAmsAssetUpdateSettings ResetResourceGroup(this AzureAmsAssetUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region AlternateId
        /// <summary><p><em>Sets <see cref="AzureAmsAssetUpdateSettings.AlternateId"/>.</em></p><p>The alternate id of the asset.</p></summary>
        [Pure]
        public static AzureAmsAssetUpdateSettings SetAlternateId(this AzureAmsAssetUpdateSettings toolSettings, string alternateId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AlternateId = alternateId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAssetUpdateSettings.AlternateId"/>.</em></p><p>The alternate id of the asset.</p></summary>
        [Pure]
        public static AzureAmsAssetUpdateSettings ResetAlternateId(this AzureAmsAssetUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AlternateId = null;
            return toolSettings;
        }
        #endregion
        #region Description
        /// <summary><p><em>Sets <see cref="AzureAmsAssetUpdateSettings.Description"/>.</em></p><p>The asset description.</p></summary>
        [Pure]
        public static AzureAmsAssetUpdateSettings SetDescription(this AzureAmsAssetUpdateSettings toolSettings, string description)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Description = description;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAssetUpdateSettings.Description"/>.</em></p><p>The asset description.</p></summary>
        [Pure]
        public static AzureAmsAssetUpdateSettings ResetDescription(this AzureAmsAssetUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Description = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary><p><em>Sets <see cref="AzureAmsAssetUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureAmsAssetUpdateSettings SetAdd(this AzureAmsAssetUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAssetUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureAmsAssetUpdateSettings ResetAdd(this AzureAmsAssetUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary><p><em>Sets <see cref="AzureAmsAssetUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureAmsAssetUpdateSettings SetRemove(this AzureAmsAssetUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAssetUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureAmsAssetUpdateSettings ResetRemove(this AzureAmsAssetUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary><p><em>Sets <see cref="AzureAmsAssetUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureAmsAssetUpdateSettings SetSet(this AzureAmsAssetUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAssetUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureAmsAssetUpdateSettings ResetSet(this AzureAmsAssetUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAmsAssetUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAmsAssetUpdateSettings SetDebug(this AzureAmsAssetUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAssetUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAmsAssetUpdateSettings ResetDebug(this AzureAmsAssetUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAmsAssetUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAmsAssetUpdateSettings SetHelp(this AzureAmsAssetUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAssetUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAmsAssetUpdateSettings ResetHelp(this AzureAmsAssetUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAmsAssetUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAmsAssetUpdateSettings SetOutput(this AzureAmsAssetUpdateSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAssetUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAmsAssetUpdateSettings ResetOutput(this AzureAmsAssetUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAmsAssetUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAmsAssetUpdateSettings SetQuery(this AzureAmsAssetUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAssetUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAmsAssetUpdateSettings ResetQuery(this AzureAmsAssetUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAmsAssetUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAmsAssetUpdateSettings SetVerbose(this AzureAmsAssetUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAssetUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAmsAssetUpdateSettings ResetVerbose(this AzureAmsAssetUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAmsJobCancelSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAmsJobCancelSettingsExtensions
    {
        #region AccountName
        /// <summary><p><em>Sets <see cref="AzureAmsJobCancelSettings.AccountName"/>.</em></p><p>The name of the Azure Media Services account.</p></summary>
        [Pure]
        public static AzureAmsJobCancelSettings SetAccountName(this AzureAmsJobCancelSettings toolSettings, string accountName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = accountName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsJobCancelSettings.AccountName"/>.</em></p><p>The name of the Azure Media Services account.</p></summary>
        [Pure]
        public static AzureAmsJobCancelSettings ResetAccountName(this AzureAmsJobCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAmsJobCancelSettings.Name"/>.</em></p><p>The name of the job.</p></summary>
        [Pure]
        public static AzureAmsJobCancelSettings SetName(this AzureAmsJobCancelSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsJobCancelSettings.Name"/>.</em></p><p>The name of the job.</p></summary>
        [Pure]
        public static AzureAmsJobCancelSettings ResetName(this AzureAmsJobCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAmsJobCancelSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAmsJobCancelSettings SetResourceGroup(this AzureAmsJobCancelSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsJobCancelSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAmsJobCancelSettings ResetResourceGroup(this AzureAmsJobCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region TransformName
        /// <summary><p><em>Sets <see cref="AzureAmsJobCancelSettings.TransformName"/>.</em></p><p>The name of the transform.</p></summary>
        [Pure]
        public static AzureAmsJobCancelSettings SetTransformName(this AzureAmsJobCancelSettings toolSettings, string transformName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TransformName = transformName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsJobCancelSettings.TransformName"/>.</em></p><p>The name of the transform.</p></summary>
        [Pure]
        public static AzureAmsJobCancelSettings ResetTransformName(this AzureAmsJobCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TransformName = null;
            return toolSettings;
        }
        #endregion
        #region Delete
        /// <summary><p><em>Sets <see cref="AzureAmsJobCancelSettings.Delete"/>.</em></p><p>Delete the job being cancelled.</p></summary>
        [Pure]
        public static AzureAmsJobCancelSettings SetDelete(this AzureAmsJobCancelSettings toolSettings, string delete)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Delete = delete;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsJobCancelSettings.Delete"/>.</em></p><p>Delete the job being cancelled.</p></summary>
        [Pure]
        public static AzureAmsJobCancelSettings ResetDelete(this AzureAmsJobCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Delete = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAmsJobCancelSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAmsJobCancelSettings SetDebug(this AzureAmsJobCancelSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsJobCancelSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAmsJobCancelSettings ResetDebug(this AzureAmsJobCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAmsJobCancelSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAmsJobCancelSettings SetHelp(this AzureAmsJobCancelSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsJobCancelSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAmsJobCancelSettings ResetHelp(this AzureAmsJobCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAmsJobCancelSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAmsJobCancelSettings SetOutput(this AzureAmsJobCancelSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsJobCancelSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAmsJobCancelSettings ResetOutput(this AzureAmsJobCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAmsJobCancelSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAmsJobCancelSettings SetQuery(this AzureAmsJobCancelSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsJobCancelSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAmsJobCancelSettings ResetQuery(this AzureAmsJobCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAmsJobCancelSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAmsJobCancelSettings SetVerbose(this AzureAmsJobCancelSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsJobCancelSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAmsJobCancelSettings ResetVerbose(this AzureAmsJobCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAmsJobDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAmsJobDeleteSettingsExtensions
    {
        #region AccountName
        /// <summary><p><em>Sets <see cref="AzureAmsJobDeleteSettings.AccountName"/>.</em></p><p>The name of the Azure Media Services account.</p></summary>
        [Pure]
        public static AzureAmsJobDeleteSettings SetAccountName(this AzureAmsJobDeleteSettings toolSettings, string accountName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = accountName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsJobDeleteSettings.AccountName"/>.</em></p><p>The name of the Azure Media Services account.</p></summary>
        [Pure]
        public static AzureAmsJobDeleteSettings ResetAccountName(this AzureAmsJobDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAmsJobDeleteSettings.Name"/>.</em></p><p>The name of the job.</p></summary>
        [Pure]
        public static AzureAmsJobDeleteSettings SetName(this AzureAmsJobDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsJobDeleteSettings.Name"/>.</em></p><p>The name of the job.</p></summary>
        [Pure]
        public static AzureAmsJobDeleteSettings ResetName(this AzureAmsJobDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAmsJobDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAmsJobDeleteSettings SetResourceGroup(this AzureAmsJobDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsJobDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAmsJobDeleteSettings ResetResourceGroup(this AzureAmsJobDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region TransformName
        /// <summary><p><em>Sets <see cref="AzureAmsJobDeleteSettings.TransformName"/>.</em></p><p>The name of the transform.</p></summary>
        [Pure]
        public static AzureAmsJobDeleteSettings SetTransformName(this AzureAmsJobDeleteSettings toolSettings, string transformName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TransformName = transformName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsJobDeleteSettings.TransformName"/>.</em></p><p>The name of the transform.</p></summary>
        [Pure]
        public static AzureAmsJobDeleteSettings ResetTransformName(this AzureAmsJobDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TransformName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAmsJobDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAmsJobDeleteSettings SetDebug(this AzureAmsJobDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsJobDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAmsJobDeleteSettings ResetDebug(this AzureAmsJobDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAmsJobDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAmsJobDeleteSettings SetHelp(this AzureAmsJobDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsJobDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAmsJobDeleteSettings ResetHelp(this AzureAmsJobDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAmsJobDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAmsJobDeleteSettings SetOutput(this AzureAmsJobDeleteSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsJobDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAmsJobDeleteSettings ResetOutput(this AzureAmsJobDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAmsJobDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAmsJobDeleteSettings SetQuery(this AzureAmsJobDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsJobDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAmsJobDeleteSettings ResetQuery(this AzureAmsJobDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAmsJobDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAmsJobDeleteSettings SetVerbose(this AzureAmsJobDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsJobDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAmsJobDeleteSettings ResetVerbose(this AzureAmsJobDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAmsJobListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAmsJobListSettingsExtensions
    {
        #region AccountName
        /// <summary><p><em>Sets <see cref="AzureAmsJobListSettings.AccountName"/>.</em></p><p>The name of the Azure Media Services account.</p></summary>
        [Pure]
        public static AzureAmsJobListSettings SetAccountName(this AzureAmsJobListSettings toolSettings, string accountName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = accountName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsJobListSettings.AccountName"/>.</em></p><p>The name of the Azure Media Services account.</p></summary>
        [Pure]
        public static AzureAmsJobListSettings ResetAccountName(this AzureAmsJobListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAmsJobListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAmsJobListSettings SetResourceGroup(this AzureAmsJobListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsJobListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAmsJobListSettings ResetResourceGroup(this AzureAmsJobListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region TransformName
        /// <summary><p><em>Sets <see cref="AzureAmsJobListSettings.TransformName"/>.</em></p><p>The name of the transform.</p></summary>
        [Pure]
        public static AzureAmsJobListSettings SetTransformName(this AzureAmsJobListSettings toolSettings, string transformName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TransformName = transformName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsJobListSettings.TransformName"/>.</em></p><p>The name of the transform.</p></summary>
        [Pure]
        public static AzureAmsJobListSettings ResetTransformName(this AzureAmsJobListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TransformName = null;
            return toolSettings;
        }
        #endregion
        #region Filter
        /// <summary><p><em>Sets <see cref="AzureAmsJobListSettings.Filter"/>.</em></p><p>Restricts the set of items returned.</p></summary>
        [Pure]
        public static AzureAmsJobListSettings SetFilter(this AzureAmsJobListSettings toolSettings, string filter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = filter;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsJobListSettings.Filter"/>.</em></p><p>Restricts the set of items returned.</p></summary>
        [Pure]
        public static AzureAmsJobListSettings ResetFilter(this AzureAmsJobListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = null;
            return toolSettings;
        }
        #endregion
        #region Skip
        /// <summary><p><em>Sets <see cref="AzureAmsJobListSettings.Skip"/>.</em></p><p>Specifies a non-negative integer n that excludes the first n items of the queried collection from the result. The service returns items starting at position n+1.</p></summary>
        [Pure]
        public static AzureAmsJobListSettings SetSkip(this AzureAmsJobListSettings toolSettings, string skip)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Skip = skip;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsJobListSettings.Skip"/>.</em></p><p>Specifies a non-negative integer n that excludes the first n items of the queried collection from the result. The service returns items starting at position n+1.</p></summary>
        [Pure]
        public static AzureAmsJobListSettings ResetSkip(this AzureAmsJobListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Skip = null;
            return toolSettings;
        }
        #endregion
        #region Top
        /// <summary><p><em>Sets <see cref="AzureAmsJobListSettings.Top"/>.</em></p><p>Specifies a non-negative integer n that limits the number of items returned from a collection. The service returns the number of available items up to but not greater than the specified value n.</p></summary>
        [Pure]
        public static AzureAmsJobListSettings SetTop(this AzureAmsJobListSettings toolSettings, string top)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = top;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsJobListSettings.Top"/>.</em></p><p>Specifies a non-negative integer n that limits the number of items returned from a collection. The service returns the number of available items up to but not greater than the specified value n.</p></summary>
        [Pure]
        public static AzureAmsJobListSettings ResetTop(this AzureAmsJobListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAmsJobListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAmsJobListSettings SetDebug(this AzureAmsJobListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsJobListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAmsJobListSettings ResetDebug(this AzureAmsJobListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAmsJobListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAmsJobListSettings SetHelp(this AzureAmsJobListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsJobListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAmsJobListSettings ResetHelp(this AzureAmsJobListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAmsJobListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAmsJobListSettings SetOutput(this AzureAmsJobListSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsJobListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAmsJobListSettings ResetOutput(this AzureAmsJobListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAmsJobListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAmsJobListSettings SetQuery(this AzureAmsJobListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsJobListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAmsJobListSettings ResetQuery(this AzureAmsJobListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAmsJobListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAmsJobListSettings SetVerbose(this AzureAmsJobListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsJobListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAmsJobListSettings ResetVerbose(this AzureAmsJobListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAmsJobShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAmsJobShowSettingsExtensions
    {
        #region AccountName
        /// <summary><p><em>Sets <see cref="AzureAmsJobShowSettings.AccountName"/>.</em></p><p>The name of the Azure Media Services account.</p></summary>
        [Pure]
        public static AzureAmsJobShowSettings SetAccountName(this AzureAmsJobShowSettings toolSettings, string accountName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = accountName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsJobShowSettings.AccountName"/>.</em></p><p>The name of the Azure Media Services account.</p></summary>
        [Pure]
        public static AzureAmsJobShowSettings ResetAccountName(this AzureAmsJobShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAmsJobShowSettings.Name"/>.</em></p><p>The name of the job.</p></summary>
        [Pure]
        public static AzureAmsJobShowSettings SetName(this AzureAmsJobShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsJobShowSettings.Name"/>.</em></p><p>The name of the job.</p></summary>
        [Pure]
        public static AzureAmsJobShowSettings ResetName(this AzureAmsJobShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAmsJobShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAmsJobShowSettings SetResourceGroup(this AzureAmsJobShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsJobShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAmsJobShowSettings ResetResourceGroup(this AzureAmsJobShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region TransformName
        /// <summary><p><em>Sets <see cref="AzureAmsJobShowSettings.TransformName"/>.</em></p><p>The name of the transform.</p></summary>
        [Pure]
        public static AzureAmsJobShowSettings SetTransformName(this AzureAmsJobShowSettings toolSettings, string transformName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TransformName = transformName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsJobShowSettings.TransformName"/>.</em></p><p>The name of the transform.</p></summary>
        [Pure]
        public static AzureAmsJobShowSettings ResetTransformName(this AzureAmsJobShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TransformName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAmsJobShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAmsJobShowSettings SetDebug(this AzureAmsJobShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsJobShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAmsJobShowSettings ResetDebug(this AzureAmsJobShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAmsJobShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAmsJobShowSettings SetHelp(this AzureAmsJobShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsJobShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAmsJobShowSettings ResetHelp(this AzureAmsJobShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAmsJobShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAmsJobShowSettings SetOutput(this AzureAmsJobShowSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsJobShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAmsJobShowSettings ResetOutput(this AzureAmsJobShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAmsJobShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAmsJobShowSettings SetQuery(this AzureAmsJobShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsJobShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAmsJobShowSettings ResetQuery(this AzureAmsJobShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAmsJobShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAmsJobShowSettings SetVerbose(this AzureAmsJobShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsJobShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAmsJobShowSettings ResetVerbose(this AzureAmsJobShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAmsJobStartSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAmsJobStartSettingsExtensions
    {
        #region AccountName
        /// <summary><p><em>Sets <see cref="AzureAmsJobStartSettings.AccountName"/>.</em></p><p>The name of the Azure Media Services account.</p></summary>
        [Pure]
        public static AzureAmsJobStartSettings SetAccountName(this AzureAmsJobStartSettings toolSettings, string accountName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = accountName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsJobStartSettings.AccountName"/>.</em></p><p>The name of the Azure Media Services account.</p></summary>
        [Pure]
        public static AzureAmsJobStartSettings ResetAccountName(this AzureAmsJobStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAmsJobStartSettings.Name"/>.</em></p><p>The name of the job.</p></summary>
        [Pure]
        public static AzureAmsJobStartSettings SetName(this AzureAmsJobStartSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsJobStartSettings.Name"/>.</em></p><p>The name of the job.</p></summary>
        [Pure]
        public static AzureAmsJobStartSettings ResetName(this AzureAmsJobStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region OutputAssetNames
        /// <summary><p><em>Sets <see cref="AzureAmsJobStartSettings.OutputAssetNames"/> to a new list.</em></p><p>Space-separated list of output asset names.</p></summary>
        [Pure]
        public static AzureAmsJobStartSettings SetOutputAssetNames(this AzureAmsJobStartSettings toolSettings, params string[] outputAssetNames)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OutputAssetNamesInternal = outputAssetNames.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureAmsJobStartSettings.OutputAssetNames"/> to a new list.</em></p><p>Space-separated list of output asset names.</p></summary>
        [Pure]
        public static AzureAmsJobStartSettings SetOutputAssetNames(this AzureAmsJobStartSettings toolSettings, IEnumerable<string> outputAssetNames)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OutputAssetNamesInternal = outputAssetNames.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureAmsJobStartSettings.OutputAssetNames"/>.</em></p><p>Space-separated list of output asset names.</p></summary>
        [Pure]
        public static AzureAmsJobStartSettings AddOutputAssetNames(this AzureAmsJobStartSettings toolSettings, params string[] outputAssetNames)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OutputAssetNamesInternal.AddRange(outputAssetNames);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureAmsJobStartSettings.OutputAssetNames"/>.</em></p><p>Space-separated list of output asset names.</p></summary>
        [Pure]
        public static AzureAmsJobStartSettings AddOutputAssetNames(this AzureAmsJobStartSettings toolSettings, IEnumerable<string> outputAssetNames)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OutputAssetNamesInternal.AddRange(outputAssetNames);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureAmsJobStartSettings.OutputAssetNames"/>.</em></p><p>Space-separated list of output asset names.</p></summary>
        [Pure]
        public static AzureAmsJobStartSettings ClearOutputAssetNames(this AzureAmsJobStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OutputAssetNamesInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureAmsJobStartSettings.OutputAssetNames"/>.</em></p><p>Space-separated list of output asset names.</p></summary>
        [Pure]
        public static AzureAmsJobStartSettings RemoveOutputAssetNames(this AzureAmsJobStartSettings toolSettings, params string[] outputAssetNames)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(outputAssetNames);
            toolSettings.OutputAssetNamesInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureAmsJobStartSettings.OutputAssetNames"/>.</em></p><p>Space-separated list of output asset names.</p></summary>
        [Pure]
        public static AzureAmsJobStartSettings RemoveOutputAssetNames(this AzureAmsJobStartSettings toolSettings, IEnumerable<string> outputAssetNames)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(outputAssetNames);
            toolSettings.OutputAssetNamesInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAmsJobStartSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAmsJobStartSettings SetResourceGroup(this AzureAmsJobStartSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsJobStartSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAmsJobStartSettings ResetResourceGroup(this AzureAmsJobStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region TransformName
        /// <summary><p><em>Sets <see cref="AzureAmsJobStartSettings.TransformName"/>.</em></p><p>The name of the transform.</p></summary>
        [Pure]
        public static AzureAmsJobStartSettings SetTransformName(this AzureAmsJobStartSettings toolSettings, string transformName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TransformName = transformName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsJobStartSettings.TransformName"/>.</em></p><p>The name of the transform.</p></summary>
        [Pure]
        public static AzureAmsJobStartSettings ResetTransformName(this AzureAmsJobStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TransformName = null;
            return toolSettings;
        }
        #endregion
        #region Description
        /// <summary><p><em>Sets <see cref="AzureAmsJobStartSettings.Description"/>.</em></p><p>The job description.</p></summary>
        [Pure]
        public static AzureAmsJobStartSettings SetDescription(this AzureAmsJobStartSettings toolSettings, string description)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Description = description;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsJobStartSettings.Description"/>.</em></p><p>The job description.</p></summary>
        [Pure]
        public static AzureAmsJobStartSettings ResetDescription(this AzureAmsJobStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Description = null;
            return toolSettings;
        }
        #endregion
        #region Files
        /// <summary><p><em>Sets <see cref="AzureAmsJobStartSettings.Files"/> to a new list.</em></p><p>Space-separated list of files. It can be used to tell the service to only use the files specified from the input asset.</p></summary>
        [Pure]
        public static AzureAmsJobStartSettings SetFiles(this AzureAmsJobStartSettings toolSettings, params string[] files)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FilesInternal = files.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureAmsJobStartSettings.Files"/> to a new list.</em></p><p>Space-separated list of files. It can be used to tell the service to only use the files specified from the input asset.</p></summary>
        [Pure]
        public static AzureAmsJobStartSettings SetFiles(this AzureAmsJobStartSettings toolSettings, IEnumerable<string> files)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FilesInternal = files.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureAmsJobStartSettings.Files"/>.</em></p><p>Space-separated list of files. It can be used to tell the service to only use the files specified from the input asset.</p></summary>
        [Pure]
        public static AzureAmsJobStartSettings AddFiles(this AzureAmsJobStartSettings toolSettings, params string[] files)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FilesInternal.AddRange(files);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureAmsJobStartSettings.Files"/>.</em></p><p>Space-separated list of files. It can be used to tell the service to only use the files specified from the input asset.</p></summary>
        [Pure]
        public static AzureAmsJobStartSettings AddFiles(this AzureAmsJobStartSettings toolSettings, IEnumerable<string> files)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FilesInternal.AddRange(files);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureAmsJobStartSettings.Files"/>.</em></p><p>Space-separated list of files. It can be used to tell the service to only use the files specified from the input asset.</p></summary>
        [Pure]
        public static AzureAmsJobStartSettings ClearFiles(this AzureAmsJobStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FilesInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureAmsJobStartSettings.Files"/>.</em></p><p>Space-separated list of files. It can be used to tell the service to only use the files specified from the input asset.</p></summary>
        [Pure]
        public static AzureAmsJobStartSettings RemoveFiles(this AzureAmsJobStartSettings toolSettings, params string[] files)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(files);
            toolSettings.FilesInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureAmsJobStartSettings.Files"/>.</em></p><p>Space-separated list of files. It can be used to tell the service to only use the files specified from the input asset.</p></summary>
        [Pure]
        public static AzureAmsJobStartSettings RemoveFiles(this AzureAmsJobStartSettings toolSettings, IEnumerable<string> files)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(files);
            toolSettings.FilesInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Priority
        /// <summary><p><em>Sets <see cref="AzureAmsJobStartSettings.Priority"/>.</em></p><p>The priority with which the job should be processed.</p></summary>
        [Pure]
        public static AzureAmsJobStartSettings SetPriority(this AzureAmsJobStartSettings toolSettings, AmsJobStartPriority priority)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Priority = priority;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsJobStartSettings.Priority"/>.</em></p><p>The priority with which the job should be processed.</p></summary>
        [Pure]
        public static AzureAmsJobStartSettings ResetPriority(this AzureAmsJobStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Priority = null;
            return toolSettings;
        }
        #endregion
        #region InputAssetName
        /// <summary><p><em>Sets <see cref="AzureAmsJobStartSettings.InputAssetName"/>.</em></p><p>The name of the input asset.</p></summary>
        [Pure]
        public static AzureAmsJobStartSettings SetInputAssetName(this AzureAmsJobStartSettings toolSettings, string inputAssetName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InputAssetName = inputAssetName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsJobStartSettings.InputAssetName"/>.</em></p><p>The name of the input asset.</p></summary>
        [Pure]
        public static AzureAmsJobStartSettings ResetInputAssetName(this AzureAmsJobStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InputAssetName = null;
            return toolSettings;
        }
        #endregion
        #region BaseUri
        /// <summary><p><em>Sets <see cref="AzureAmsJobStartSettings.BaseUri"/>.</em></p><p>Base uri for http job input. It will be concatenated with provided file names. If no base uri is given, then the provided file list is assumed to be fully qualified uris.</p></summary>
        [Pure]
        public static AzureAmsJobStartSettings SetBaseUri(this AzureAmsJobStartSettings toolSettings, string baseUri)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BaseUri = baseUri;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsJobStartSettings.BaseUri"/>.</em></p><p>Base uri for http job input. It will be concatenated with provided file names. If no base uri is given, then the provided file list is assumed to be fully qualified uris.</p></summary>
        [Pure]
        public static AzureAmsJobStartSettings ResetBaseUri(this AzureAmsJobStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BaseUri = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAmsJobStartSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAmsJobStartSettings SetDebug(this AzureAmsJobStartSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsJobStartSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAmsJobStartSettings ResetDebug(this AzureAmsJobStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAmsJobStartSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAmsJobStartSettings SetHelp(this AzureAmsJobStartSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsJobStartSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAmsJobStartSettings ResetHelp(this AzureAmsJobStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAmsJobStartSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAmsJobStartSettings SetOutput(this AzureAmsJobStartSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsJobStartSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAmsJobStartSettings ResetOutput(this AzureAmsJobStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAmsJobStartSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAmsJobStartSettings SetQuery(this AzureAmsJobStartSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsJobStartSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAmsJobStartSettings ResetQuery(this AzureAmsJobStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAmsJobStartSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAmsJobStartSettings SetVerbose(this AzureAmsJobStartSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsJobStartSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAmsJobStartSettings ResetVerbose(this AzureAmsJobStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAmsStreamingSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAmsStreamingSettingsExtensions
    {
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAmsStreamingSettings SetDebug(this AzureAmsStreamingSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAmsStreamingSettings ResetDebug(this AzureAmsStreamingSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAmsStreamingSettings SetHelp(this AzureAmsStreamingSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAmsStreamingSettings ResetHelp(this AzureAmsStreamingSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAmsStreamingSettings SetOutput(this AzureAmsStreamingSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAmsStreamingSettings ResetOutput(this AzureAmsStreamingSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAmsStreamingSettings SetQuery(this AzureAmsStreamingSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAmsStreamingSettings ResetQuery(this AzureAmsStreamingSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAmsStreamingSettings SetVerbose(this AzureAmsStreamingSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAmsStreamingSettings ResetVerbose(this AzureAmsStreamingSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAmsTransformCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAmsTransformCreateSettingsExtensions
    {
        #region AccountName
        /// <summary><p><em>Sets <see cref="AzureAmsTransformCreateSettings.AccountName"/>.</em></p><p>The name of the Azure Media Services account.</p></summary>
        [Pure]
        public static AzureAmsTransformCreateSettings SetAccountName(this AzureAmsTransformCreateSettings toolSettings, string accountName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = accountName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsTransformCreateSettings.AccountName"/>.</em></p><p>The name of the Azure Media Services account.</p></summary>
        [Pure]
        public static AzureAmsTransformCreateSettings ResetAccountName(this AzureAmsTransformCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAmsTransformCreateSettings.Name"/>.</em></p><p>The name of the transform.</p></summary>
        [Pure]
        public static AzureAmsTransformCreateSettings SetName(this AzureAmsTransformCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsTransformCreateSettings.Name"/>.</em></p><p>The name of the transform.</p></summary>
        [Pure]
        public static AzureAmsTransformCreateSettings ResetName(this AzureAmsTransformCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region PresetNames
        /// <summary><p><em>Sets <see cref="AzureAmsTransformCreateSettings.PresetNames"/> to a new list.</em></p><p>Space-separated list of built-in preset names.</p></summary>
        [Pure]
        public static AzureAmsTransformCreateSettings SetPresetNames(this AzureAmsTransformCreateSettings toolSettings, params AmsTransformPresetNames[] presetNames)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PresetNamesInternal = presetNames.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureAmsTransformCreateSettings.PresetNames"/> to a new list.</em></p><p>Space-separated list of built-in preset names.</p></summary>
        [Pure]
        public static AzureAmsTransformCreateSettings SetPresetNames(this AzureAmsTransformCreateSettings toolSettings, IEnumerable<AmsTransformPresetNames> presetNames)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PresetNamesInternal = presetNames.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureAmsTransformCreateSettings.PresetNames"/>.</em></p><p>Space-separated list of built-in preset names.</p></summary>
        [Pure]
        public static AzureAmsTransformCreateSettings AddPresetNames(this AzureAmsTransformCreateSettings toolSettings, params AmsTransformPresetNames[] presetNames)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PresetNamesInternal.AddRange(presetNames);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureAmsTransformCreateSettings.PresetNames"/>.</em></p><p>Space-separated list of built-in preset names.</p></summary>
        [Pure]
        public static AzureAmsTransformCreateSettings AddPresetNames(this AzureAmsTransformCreateSettings toolSettings, IEnumerable<AmsTransformPresetNames> presetNames)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PresetNamesInternal.AddRange(presetNames);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureAmsTransformCreateSettings.PresetNames"/>.</em></p><p>Space-separated list of built-in preset names.</p></summary>
        [Pure]
        public static AzureAmsTransformCreateSettings ClearPresetNames(this AzureAmsTransformCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PresetNamesInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureAmsTransformCreateSettings.PresetNames"/>.</em></p><p>Space-separated list of built-in preset names.</p></summary>
        [Pure]
        public static AzureAmsTransformCreateSettings RemovePresetNames(this AzureAmsTransformCreateSettings toolSettings, params AmsTransformPresetNames[] presetNames)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<AmsTransformPresetNames>(presetNames);
            toolSettings.PresetNamesInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureAmsTransformCreateSettings.PresetNames"/>.</em></p><p>Space-separated list of built-in preset names.</p></summary>
        [Pure]
        public static AzureAmsTransformCreateSettings RemovePresetNames(this AzureAmsTransformCreateSettings toolSettings, IEnumerable<AmsTransformPresetNames> presetNames)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<AmsTransformPresetNames>(presetNames);
            toolSettings.PresetNamesInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAmsTransformCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAmsTransformCreateSettings SetResourceGroup(this AzureAmsTransformCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsTransformCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAmsTransformCreateSettings ResetResourceGroup(this AzureAmsTransformCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Description
        /// <summary><p><em>Sets <see cref="AzureAmsTransformCreateSettings.Description"/>.</em></p><p>The description of the transform.</p></summary>
        [Pure]
        public static AzureAmsTransformCreateSettings SetDescription(this AzureAmsTransformCreateSettings toolSettings, string description)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Description = description;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsTransformCreateSettings.Description"/>.</em></p><p>The description of the transform.</p></summary>
        [Pure]
        public static AzureAmsTransformCreateSettings ResetDescription(this AzureAmsTransformCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Description = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAmsTransformCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAmsTransformCreateSettings SetDebug(this AzureAmsTransformCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsTransformCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAmsTransformCreateSettings ResetDebug(this AzureAmsTransformCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAmsTransformCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAmsTransformCreateSettings SetHelp(this AzureAmsTransformCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsTransformCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAmsTransformCreateSettings ResetHelp(this AzureAmsTransformCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAmsTransformCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAmsTransformCreateSettings SetOutput(this AzureAmsTransformCreateSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsTransformCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAmsTransformCreateSettings ResetOutput(this AzureAmsTransformCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAmsTransformCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAmsTransformCreateSettings SetQuery(this AzureAmsTransformCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsTransformCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAmsTransformCreateSettings ResetQuery(this AzureAmsTransformCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAmsTransformCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAmsTransformCreateSettings SetVerbose(this AzureAmsTransformCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsTransformCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAmsTransformCreateSettings ResetVerbose(this AzureAmsTransformCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAmsTransformDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAmsTransformDeleteSettingsExtensions
    {
        #region AccountName
        /// <summary><p><em>Sets <see cref="AzureAmsTransformDeleteSettings.AccountName"/>.</em></p><p>The name of the Azure Media Services account.</p></summary>
        [Pure]
        public static AzureAmsTransformDeleteSettings SetAccountName(this AzureAmsTransformDeleteSettings toolSettings, string accountName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = accountName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsTransformDeleteSettings.AccountName"/>.</em></p><p>The name of the Azure Media Services account.</p></summary>
        [Pure]
        public static AzureAmsTransformDeleteSettings ResetAccountName(this AzureAmsTransformDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAmsTransformDeleteSettings.Name"/>.</em></p><p>The name of the transform.</p></summary>
        [Pure]
        public static AzureAmsTransformDeleteSettings SetName(this AzureAmsTransformDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsTransformDeleteSettings.Name"/>.</em></p><p>The name of the transform.</p></summary>
        [Pure]
        public static AzureAmsTransformDeleteSettings ResetName(this AzureAmsTransformDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAmsTransformDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAmsTransformDeleteSettings SetResourceGroup(this AzureAmsTransformDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsTransformDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAmsTransformDeleteSettings ResetResourceGroup(this AzureAmsTransformDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAmsTransformDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAmsTransformDeleteSettings SetDebug(this AzureAmsTransformDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsTransformDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAmsTransformDeleteSettings ResetDebug(this AzureAmsTransformDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAmsTransformDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAmsTransformDeleteSettings SetHelp(this AzureAmsTransformDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsTransformDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAmsTransformDeleteSettings ResetHelp(this AzureAmsTransformDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAmsTransformDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAmsTransformDeleteSettings SetOutput(this AzureAmsTransformDeleteSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsTransformDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAmsTransformDeleteSettings ResetOutput(this AzureAmsTransformDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAmsTransformDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAmsTransformDeleteSettings SetQuery(this AzureAmsTransformDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsTransformDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAmsTransformDeleteSettings ResetQuery(this AzureAmsTransformDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAmsTransformDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAmsTransformDeleteSettings SetVerbose(this AzureAmsTransformDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsTransformDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAmsTransformDeleteSettings ResetVerbose(this AzureAmsTransformDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAmsTransformListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAmsTransformListSettingsExtensions
    {
        #region AccountName
        /// <summary><p><em>Sets <see cref="AzureAmsTransformListSettings.AccountName"/>.</em></p><p>The name of the Azure Media Services account.</p></summary>
        [Pure]
        public static AzureAmsTransformListSettings SetAccountName(this AzureAmsTransformListSettings toolSettings, string accountName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = accountName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsTransformListSettings.AccountName"/>.</em></p><p>The name of the Azure Media Services account.</p></summary>
        [Pure]
        public static AzureAmsTransformListSettings ResetAccountName(this AzureAmsTransformListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAmsTransformListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAmsTransformListSettings SetResourceGroup(this AzureAmsTransformListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsTransformListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAmsTransformListSettings ResetResourceGroup(this AzureAmsTransformListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Filter
        /// <summary><p><em>Sets <see cref="AzureAmsTransformListSettings.Filter"/>.</em></p><p>Restricts the set of items returned.</p></summary>
        [Pure]
        public static AzureAmsTransformListSettings SetFilter(this AzureAmsTransformListSettings toolSettings, string filter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = filter;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsTransformListSettings.Filter"/>.</em></p><p>Restricts the set of items returned.</p></summary>
        [Pure]
        public static AzureAmsTransformListSettings ResetFilter(this AzureAmsTransformListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = null;
            return toolSettings;
        }
        #endregion
        #region Skip
        /// <summary><p><em>Sets <see cref="AzureAmsTransformListSettings.Skip"/>.</em></p><p>Specifies a non-negative integer n that excludes the first n items of the queried collection from the result. The service returns items starting at position n+1.</p></summary>
        [Pure]
        public static AzureAmsTransformListSettings SetSkip(this AzureAmsTransformListSettings toolSettings, string skip)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Skip = skip;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsTransformListSettings.Skip"/>.</em></p><p>Specifies a non-negative integer n that excludes the first n items of the queried collection from the result. The service returns items starting at position n+1.</p></summary>
        [Pure]
        public static AzureAmsTransformListSettings ResetSkip(this AzureAmsTransformListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Skip = null;
            return toolSettings;
        }
        #endregion
        #region Top
        /// <summary><p><em>Sets <see cref="AzureAmsTransformListSettings.Top"/>.</em></p><p>Specifies a non-negative integer n that limits the number of items returned from a collection. The service returns the number of available items up to but not greater than the specified value n.</p></summary>
        [Pure]
        public static AzureAmsTransformListSettings SetTop(this AzureAmsTransformListSettings toolSettings, string top)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = top;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsTransformListSettings.Top"/>.</em></p><p>Specifies a non-negative integer n that limits the number of items returned from a collection. The service returns the number of available items up to but not greater than the specified value n.</p></summary>
        [Pure]
        public static AzureAmsTransformListSettings ResetTop(this AzureAmsTransformListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAmsTransformListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAmsTransformListSettings SetDebug(this AzureAmsTransformListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsTransformListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAmsTransformListSettings ResetDebug(this AzureAmsTransformListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAmsTransformListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAmsTransformListSettings SetHelp(this AzureAmsTransformListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsTransformListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAmsTransformListSettings ResetHelp(this AzureAmsTransformListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAmsTransformListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAmsTransformListSettings SetOutput(this AzureAmsTransformListSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsTransformListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAmsTransformListSettings ResetOutput(this AzureAmsTransformListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAmsTransformListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAmsTransformListSettings SetQuery(this AzureAmsTransformListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsTransformListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAmsTransformListSettings ResetQuery(this AzureAmsTransformListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAmsTransformListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAmsTransformListSettings SetVerbose(this AzureAmsTransformListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsTransformListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAmsTransformListSettings ResetVerbose(this AzureAmsTransformListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAmsTransformShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAmsTransformShowSettingsExtensions
    {
        #region AccountName
        /// <summary><p><em>Sets <see cref="AzureAmsTransformShowSettings.AccountName"/>.</em></p><p>The name of the Azure Media Services account.</p></summary>
        [Pure]
        public static AzureAmsTransformShowSettings SetAccountName(this AzureAmsTransformShowSettings toolSettings, string accountName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = accountName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsTransformShowSettings.AccountName"/>.</em></p><p>The name of the Azure Media Services account.</p></summary>
        [Pure]
        public static AzureAmsTransformShowSettings ResetAccountName(this AzureAmsTransformShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAmsTransformShowSettings.Name"/>.</em></p><p>The name of the transform.</p></summary>
        [Pure]
        public static AzureAmsTransformShowSettings SetName(this AzureAmsTransformShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsTransformShowSettings.Name"/>.</em></p><p>The name of the transform.</p></summary>
        [Pure]
        public static AzureAmsTransformShowSettings ResetName(this AzureAmsTransformShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAmsTransformShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAmsTransformShowSettings SetResourceGroup(this AzureAmsTransformShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsTransformShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAmsTransformShowSettings ResetResourceGroup(this AzureAmsTransformShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAmsTransformShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAmsTransformShowSettings SetDebug(this AzureAmsTransformShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsTransformShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAmsTransformShowSettings ResetDebug(this AzureAmsTransformShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAmsTransformShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAmsTransformShowSettings SetHelp(this AzureAmsTransformShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsTransformShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAmsTransformShowSettings ResetHelp(this AzureAmsTransformShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAmsTransformShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAmsTransformShowSettings SetOutput(this AzureAmsTransformShowSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsTransformShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAmsTransformShowSettings ResetOutput(this AzureAmsTransformShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAmsTransformShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAmsTransformShowSettings SetQuery(this AzureAmsTransformShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsTransformShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAmsTransformShowSettings ResetQuery(this AzureAmsTransformShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAmsTransformShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAmsTransformShowSettings SetVerbose(this AzureAmsTransformShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsTransformShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAmsTransformShowSettings ResetVerbose(this AzureAmsTransformShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAmsTransformUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAmsTransformUpdateSettingsExtensions
    {
        #region AccountName
        /// <summary><p><em>Sets <see cref="AzureAmsTransformUpdateSettings.AccountName"/>.</em></p><p>The name of the Azure Media Services account.</p></summary>
        [Pure]
        public static AzureAmsTransformUpdateSettings SetAccountName(this AzureAmsTransformUpdateSettings toolSettings, string accountName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = accountName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsTransformUpdateSettings.AccountName"/>.</em></p><p>The name of the Azure Media Services account.</p></summary>
        [Pure]
        public static AzureAmsTransformUpdateSettings ResetAccountName(this AzureAmsTransformUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAmsTransformUpdateSettings.Name"/>.</em></p><p>The name of the transform.</p></summary>
        [Pure]
        public static AzureAmsTransformUpdateSettings SetName(this AzureAmsTransformUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsTransformUpdateSettings.Name"/>.</em></p><p>The name of the transform.</p></summary>
        [Pure]
        public static AzureAmsTransformUpdateSettings ResetName(this AzureAmsTransformUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAmsTransformUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAmsTransformUpdateSettings SetResourceGroup(this AzureAmsTransformUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsTransformUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAmsTransformUpdateSettings ResetResourceGroup(this AzureAmsTransformUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Description
        /// <summary><p><em>Sets <see cref="AzureAmsTransformUpdateSettings.Description"/>.</em></p><p>The description of the transform.</p></summary>
        [Pure]
        public static AzureAmsTransformUpdateSettings SetDescription(this AzureAmsTransformUpdateSettings toolSettings, string description)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Description = description;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsTransformUpdateSettings.Description"/>.</em></p><p>The description of the transform.</p></summary>
        [Pure]
        public static AzureAmsTransformUpdateSettings ResetDescription(this AzureAmsTransformUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Description = null;
            return toolSettings;
        }
        #endregion
        #region PresetNames
        /// <summary><p><em>Sets <see cref="AzureAmsTransformUpdateSettings.PresetNames"/> to a new list.</em></p><p>Space-separated list of built-in preset names.</p></summary>
        [Pure]
        public static AzureAmsTransformUpdateSettings SetPresetNames(this AzureAmsTransformUpdateSettings toolSettings, params AmsTransformPresetNames[] presetNames)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PresetNamesInternal = presetNames.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureAmsTransformUpdateSettings.PresetNames"/> to a new list.</em></p><p>Space-separated list of built-in preset names.</p></summary>
        [Pure]
        public static AzureAmsTransformUpdateSettings SetPresetNames(this AzureAmsTransformUpdateSettings toolSettings, IEnumerable<AmsTransformPresetNames> presetNames)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PresetNamesInternal = presetNames.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureAmsTransformUpdateSettings.PresetNames"/>.</em></p><p>Space-separated list of built-in preset names.</p></summary>
        [Pure]
        public static AzureAmsTransformUpdateSettings AddPresetNames(this AzureAmsTransformUpdateSettings toolSettings, params AmsTransformPresetNames[] presetNames)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PresetNamesInternal.AddRange(presetNames);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureAmsTransformUpdateSettings.PresetNames"/>.</em></p><p>Space-separated list of built-in preset names.</p></summary>
        [Pure]
        public static AzureAmsTransformUpdateSettings AddPresetNames(this AzureAmsTransformUpdateSettings toolSettings, IEnumerable<AmsTransformPresetNames> presetNames)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PresetNamesInternal.AddRange(presetNames);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureAmsTransformUpdateSettings.PresetNames"/>.</em></p><p>Space-separated list of built-in preset names.</p></summary>
        [Pure]
        public static AzureAmsTransformUpdateSettings ClearPresetNames(this AzureAmsTransformUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PresetNamesInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureAmsTransformUpdateSettings.PresetNames"/>.</em></p><p>Space-separated list of built-in preset names.</p></summary>
        [Pure]
        public static AzureAmsTransformUpdateSettings RemovePresetNames(this AzureAmsTransformUpdateSettings toolSettings, params AmsTransformPresetNames[] presetNames)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<AmsTransformPresetNames>(presetNames);
            toolSettings.PresetNamesInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureAmsTransformUpdateSettings.PresetNames"/>.</em></p><p>Space-separated list of built-in preset names.</p></summary>
        [Pure]
        public static AzureAmsTransformUpdateSettings RemovePresetNames(this AzureAmsTransformUpdateSettings toolSettings, IEnumerable<AmsTransformPresetNames> presetNames)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<AmsTransformPresetNames>(presetNames);
            toolSettings.PresetNamesInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary><p><em>Sets <see cref="AzureAmsTransformUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureAmsTransformUpdateSettings SetAdd(this AzureAmsTransformUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsTransformUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureAmsTransformUpdateSettings ResetAdd(this AzureAmsTransformUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary><p><em>Sets <see cref="AzureAmsTransformUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureAmsTransformUpdateSettings SetRemove(this AzureAmsTransformUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsTransformUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureAmsTransformUpdateSettings ResetRemove(this AzureAmsTransformUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary><p><em>Sets <see cref="AzureAmsTransformUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureAmsTransformUpdateSettings SetSet(this AzureAmsTransformUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsTransformUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureAmsTransformUpdateSettings ResetSet(this AzureAmsTransformUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAmsTransformUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAmsTransformUpdateSettings SetDebug(this AzureAmsTransformUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsTransformUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAmsTransformUpdateSettings ResetDebug(this AzureAmsTransformUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAmsTransformUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAmsTransformUpdateSettings SetHelp(this AzureAmsTransformUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsTransformUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAmsTransformUpdateSettings ResetHelp(this AzureAmsTransformUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAmsTransformUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAmsTransformUpdateSettings SetOutput(this AzureAmsTransformUpdateSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsTransformUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAmsTransformUpdateSettings ResetOutput(this AzureAmsTransformUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAmsTransformUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAmsTransformUpdateSettings SetQuery(this AzureAmsTransformUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsTransformUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAmsTransformUpdateSettings ResetQuery(this AzureAmsTransformUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAmsTransformUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAmsTransformUpdateSettings SetVerbose(this AzureAmsTransformUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsTransformUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAmsTransformUpdateSettings ResetVerbose(this AzureAmsTransformUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAmsAccountSpCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAmsAccountSpCreateSettingsExtensions
    {
        #region AccountName
        /// <summary><p><em>Sets <see cref="AzureAmsAccountSpCreateSettings.AccountName"/>.</em></p><p>The name of the Azure Media Services account.</p></summary>
        [Pure]
        public static AzureAmsAccountSpCreateSettings SetAccountName(this AzureAmsAccountSpCreateSettings toolSettings, string accountName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = accountName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAccountSpCreateSettings.AccountName"/>.</em></p><p>The name of the Azure Media Services account.</p></summary>
        [Pure]
        public static AzureAmsAccountSpCreateSettings ResetAccountName(this AzureAmsAccountSpCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAmsAccountSpCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAmsAccountSpCreateSettings SetResourceGroup(this AzureAmsAccountSpCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAccountSpCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAmsAccountSpCreateSettings ResetResourceGroup(this AzureAmsAccountSpCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAmsAccountSpCreateSettings.Name"/>.</em></p><p>The app name or app URI to associate the RBAC with. If not present, a default name like '{amsaccountname}-access-sp' will be generated.</p></summary>
        [Pure]
        public static AzureAmsAccountSpCreateSettings SetName(this AzureAmsAccountSpCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAccountSpCreateSettings.Name"/>.</em></p><p>The app name or app URI to associate the RBAC with. If not present, a default name like '{amsaccountname}-access-sp' will be generated.</p></summary>
        [Pure]
        public static AzureAmsAccountSpCreateSettings ResetName(this AzureAmsAccountSpCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Password
        /// <summary><p><em>Sets <see cref="AzureAmsAccountSpCreateSettings.Password"/>.</em></p><p>The password used to log in. Also known as 'Client Secret'. If not present, a random secret will be generated.</p></summary>
        [Pure]
        public static AzureAmsAccountSpCreateSettings SetPassword(this AzureAmsAccountSpCreateSettings toolSettings, string password)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = password;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAccountSpCreateSettings.Password"/>.</em></p><p>The password used to log in. Also known as 'Client Secret'. If not present, a random secret will be generated.</p></summary>
        [Pure]
        public static AzureAmsAccountSpCreateSettings ResetPassword(this AzureAmsAccountSpCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = null;
            return toolSettings;
        }
        #endregion
        #region Role
        /// <summary><p><em>Sets <see cref="AzureAmsAccountSpCreateSettings.Role"/>.</em></p><p>The role of the service principal.</p></summary>
        [Pure]
        public static AzureAmsAccountSpCreateSettings SetRole(this AzureAmsAccountSpCreateSettings toolSettings, string role)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Role = role;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAccountSpCreateSettings.Role"/>.</em></p><p>The role of the service principal.</p></summary>
        [Pure]
        public static AzureAmsAccountSpCreateSettings ResetRole(this AzureAmsAccountSpCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Role = null;
            return toolSettings;
        }
        #endregion
        #region Xml
        /// <summary><p><em>Sets <see cref="AzureAmsAccountSpCreateSettings.Xml"/>.</em></p><p>Enables xml output format.</p></summary>
        [Pure]
        public static AzureAmsAccountSpCreateSettings SetXml(this AzureAmsAccountSpCreateSettings toolSettings, string xml)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Xml = xml;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAccountSpCreateSettings.Xml"/>.</em></p><p>Enables xml output format.</p></summary>
        [Pure]
        public static AzureAmsAccountSpCreateSettings ResetXml(this AzureAmsAccountSpCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Xml = null;
            return toolSettings;
        }
        #endregion
        #region Years
        /// <summary><p><em>Sets <see cref="AzureAmsAccountSpCreateSettings.Years"/>.</em></p><p>Number of years for which the secret will be valid. Default: 1 year.</p></summary>
        [Pure]
        public static AzureAmsAccountSpCreateSettings SetYears(this AzureAmsAccountSpCreateSettings toolSettings, int? years)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Years = years;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAccountSpCreateSettings.Years"/>.</em></p><p>Number of years for which the secret will be valid. Default: 1 year.</p></summary>
        [Pure]
        public static AzureAmsAccountSpCreateSettings ResetYears(this AzureAmsAccountSpCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Years = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAmsAccountSpCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAmsAccountSpCreateSettings SetDebug(this AzureAmsAccountSpCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAccountSpCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAmsAccountSpCreateSettings ResetDebug(this AzureAmsAccountSpCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAmsAccountSpCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAmsAccountSpCreateSettings SetHelp(this AzureAmsAccountSpCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAccountSpCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAmsAccountSpCreateSettings ResetHelp(this AzureAmsAccountSpCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAmsAccountSpCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAmsAccountSpCreateSettings SetOutput(this AzureAmsAccountSpCreateSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAccountSpCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAmsAccountSpCreateSettings ResetOutput(this AzureAmsAccountSpCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAmsAccountSpCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAmsAccountSpCreateSettings SetQuery(this AzureAmsAccountSpCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAccountSpCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAmsAccountSpCreateSettings ResetQuery(this AzureAmsAccountSpCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAmsAccountSpCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAmsAccountSpCreateSettings SetVerbose(this AzureAmsAccountSpCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAccountSpCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAmsAccountSpCreateSettings ResetVerbose(this AzureAmsAccountSpCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAmsAccountSpResetCredentialsSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAmsAccountSpResetCredentialsSettingsExtensions
    {
        #region AccountName
        /// <summary><p><em>Sets <see cref="AzureAmsAccountSpResetCredentialsSettings.AccountName"/>.</em></p><p>The name of the Azure Media Services account.</p></summary>
        [Pure]
        public static AzureAmsAccountSpResetCredentialsSettings SetAccountName(this AzureAmsAccountSpResetCredentialsSettings toolSettings, string accountName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = accountName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAccountSpResetCredentialsSettings.AccountName"/>.</em></p><p>The name of the Azure Media Services account.</p></summary>
        [Pure]
        public static AzureAmsAccountSpResetCredentialsSettings ResetAccountName(this AzureAmsAccountSpResetCredentialsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAmsAccountSpResetCredentialsSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAmsAccountSpResetCredentialsSettings SetResourceGroup(this AzureAmsAccountSpResetCredentialsSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAccountSpResetCredentialsSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAmsAccountSpResetCredentialsSettings ResetResourceGroup(this AzureAmsAccountSpResetCredentialsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAmsAccountSpResetCredentialsSettings.Name"/>.</em></p><p>The app name or app URI to associate the RBAC with. If not present, a default name like '{amsaccountname}-access-sp' will be generated.</p></summary>
        [Pure]
        public static AzureAmsAccountSpResetCredentialsSettings SetName(this AzureAmsAccountSpResetCredentialsSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAccountSpResetCredentialsSettings.Name"/>.</em></p><p>The app name or app URI to associate the RBAC with. If not present, a default name like '{amsaccountname}-access-sp' will be generated.</p></summary>
        [Pure]
        public static AzureAmsAccountSpResetCredentialsSettings ResetName(this AzureAmsAccountSpResetCredentialsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Password
        /// <summary><p><em>Sets <see cref="AzureAmsAccountSpResetCredentialsSettings.Password"/>.</em></p><p>The password used to log in. Also known as 'Client Secret'. If not present, a random secret will be generated.</p></summary>
        [Pure]
        public static AzureAmsAccountSpResetCredentialsSettings SetPassword(this AzureAmsAccountSpResetCredentialsSettings toolSettings, string password)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = password;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAccountSpResetCredentialsSettings.Password"/>.</em></p><p>The password used to log in. Also known as 'Client Secret'. If not present, a random secret will be generated.</p></summary>
        [Pure]
        public static AzureAmsAccountSpResetCredentialsSettings ResetPassword(this AzureAmsAccountSpResetCredentialsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = null;
            return toolSettings;
        }
        #endregion
        #region Role
        /// <summary><p><em>Sets <see cref="AzureAmsAccountSpResetCredentialsSettings.Role"/>.</em></p><p>The role of the service principal.</p></summary>
        [Pure]
        public static AzureAmsAccountSpResetCredentialsSettings SetRole(this AzureAmsAccountSpResetCredentialsSettings toolSettings, string role)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Role = role;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAccountSpResetCredentialsSettings.Role"/>.</em></p><p>The role of the service principal.</p></summary>
        [Pure]
        public static AzureAmsAccountSpResetCredentialsSettings ResetRole(this AzureAmsAccountSpResetCredentialsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Role = null;
            return toolSettings;
        }
        #endregion
        #region Xml
        /// <summary><p><em>Sets <see cref="AzureAmsAccountSpResetCredentialsSettings.Xml"/>.</em></p><p>Enables xml output format.</p></summary>
        [Pure]
        public static AzureAmsAccountSpResetCredentialsSettings SetXml(this AzureAmsAccountSpResetCredentialsSettings toolSettings, string xml)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Xml = xml;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAccountSpResetCredentialsSettings.Xml"/>.</em></p><p>Enables xml output format.</p></summary>
        [Pure]
        public static AzureAmsAccountSpResetCredentialsSettings ResetXml(this AzureAmsAccountSpResetCredentialsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Xml = null;
            return toolSettings;
        }
        #endregion
        #region Years
        /// <summary><p><em>Sets <see cref="AzureAmsAccountSpResetCredentialsSettings.Years"/>.</em></p><p>Number of years for which the secret will be valid. Default: 1 year.</p></summary>
        [Pure]
        public static AzureAmsAccountSpResetCredentialsSettings SetYears(this AzureAmsAccountSpResetCredentialsSettings toolSettings, int? years)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Years = years;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAccountSpResetCredentialsSettings.Years"/>.</em></p><p>Number of years for which the secret will be valid. Default: 1 year.</p></summary>
        [Pure]
        public static AzureAmsAccountSpResetCredentialsSettings ResetYears(this AzureAmsAccountSpResetCredentialsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Years = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAmsAccountSpResetCredentialsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAmsAccountSpResetCredentialsSettings SetDebug(this AzureAmsAccountSpResetCredentialsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAccountSpResetCredentialsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAmsAccountSpResetCredentialsSettings ResetDebug(this AzureAmsAccountSpResetCredentialsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAmsAccountSpResetCredentialsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAmsAccountSpResetCredentialsSettings SetHelp(this AzureAmsAccountSpResetCredentialsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAccountSpResetCredentialsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAmsAccountSpResetCredentialsSettings ResetHelp(this AzureAmsAccountSpResetCredentialsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAmsAccountSpResetCredentialsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAmsAccountSpResetCredentialsSettings SetOutput(this AzureAmsAccountSpResetCredentialsSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAccountSpResetCredentialsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAmsAccountSpResetCredentialsSettings ResetOutput(this AzureAmsAccountSpResetCredentialsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAmsAccountSpResetCredentialsSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAmsAccountSpResetCredentialsSettings SetQuery(this AzureAmsAccountSpResetCredentialsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAccountSpResetCredentialsSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAmsAccountSpResetCredentialsSettings ResetQuery(this AzureAmsAccountSpResetCredentialsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAmsAccountSpResetCredentialsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAmsAccountSpResetCredentialsSettings SetVerbose(this AzureAmsAccountSpResetCredentialsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAccountSpResetCredentialsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAmsAccountSpResetCredentialsSettings ResetVerbose(this AzureAmsAccountSpResetCredentialsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAmsAccountStorageAddSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAmsAccountStorageAddSettingsExtensions
    {
        #region AccountName
        /// <summary><p><em>Sets <see cref="AzureAmsAccountStorageAddSettings.AccountName"/>.</em></p><p>The name of the Azure Media Services account.</p></summary>
        [Pure]
        public static AzureAmsAccountStorageAddSettings SetAccountName(this AzureAmsAccountStorageAddSettings toolSettings, string accountName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = accountName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAccountStorageAddSettings.AccountName"/>.</em></p><p>The name of the Azure Media Services account.</p></summary>
        [Pure]
        public static AzureAmsAccountStorageAddSettings ResetAccountName(this AzureAmsAccountStorageAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAmsAccountStorageAddSettings.Name"/>.</em></p><p>The name or resource ID of the secondary storage account to detach from the Azure Media Services account.</p></summary>
        [Pure]
        public static AzureAmsAccountStorageAddSettings SetName(this AzureAmsAccountStorageAddSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAccountStorageAddSettings.Name"/>.</em></p><p>The name or resource ID of the secondary storage account to detach from the Azure Media Services account.</p></summary>
        [Pure]
        public static AzureAmsAccountStorageAddSettings ResetName(this AzureAmsAccountStorageAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAmsAccountStorageAddSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAmsAccountStorageAddSettings SetResourceGroup(this AzureAmsAccountStorageAddSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAccountStorageAddSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAmsAccountStorageAddSettings ResetResourceGroup(this AzureAmsAccountStorageAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAmsAccountStorageAddSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAmsAccountStorageAddSettings SetDebug(this AzureAmsAccountStorageAddSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAccountStorageAddSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAmsAccountStorageAddSettings ResetDebug(this AzureAmsAccountStorageAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAmsAccountStorageAddSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAmsAccountStorageAddSettings SetHelp(this AzureAmsAccountStorageAddSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAccountStorageAddSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAmsAccountStorageAddSettings ResetHelp(this AzureAmsAccountStorageAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAmsAccountStorageAddSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAmsAccountStorageAddSettings SetOutput(this AzureAmsAccountStorageAddSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAccountStorageAddSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAmsAccountStorageAddSettings ResetOutput(this AzureAmsAccountStorageAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAmsAccountStorageAddSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAmsAccountStorageAddSettings SetQuery(this AzureAmsAccountStorageAddSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAccountStorageAddSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAmsAccountStorageAddSettings ResetQuery(this AzureAmsAccountStorageAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAmsAccountStorageAddSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAmsAccountStorageAddSettings SetVerbose(this AzureAmsAccountStorageAddSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAccountStorageAddSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAmsAccountStorageAddSettings ResetVerbose(this AzureAmsAccountStorageAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAmsAccountStorageRemoveSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAmsAccountStorageRemoveSettingsExtensions
    {
        #region AccountName
        /// <summary><p><em>Sets <see cref="AzureAmsAccountStorageRemoveSettings.AccountName"/>.</em></p><p>The name of the Azure Media Services account.</p></summary>
        [Pure]
        public static AzureAmsAccountStorageRemoveSettings SetAccountName(this AzureAmsAccountStorageRemoveSettings toolSettings, string accountName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = accountName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAccountStorageRemoveSettings.AccountName"/>.</em></p><p>The name of the Azure Media Services account.</p></summary>
        [Pure]
        public static AzureAmsAccountStorageRemoveSettings ResetAccountName(this AzureAmsAccountStorageRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAmsAccountStorageRemoveSettings.Name"/>.</em></p><p>The name or resource ID of the secondary storage account to detach from the Azure Media Services account.</p></summary>
        [Pure]
        public static AzureAmsAccountStorageRemoveSettings SetName(this AzureAmsAccountStorageRemoveSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAccountStorageRemoveSettings.Name"/>.</em></p><p>The name or resource ID of the secondary storage account to detach from the Azure Media Services account.</p></summary>
        [Pure]
        public static AzureAmsAccountStorageRemoveSettings ResetName(this AzureAmsAccountStorageRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAmsAccountStorageRemoveSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAmsAccountStorageRemoveSettings SetResourceGroup(this AzureAmsAccountStorageRemoveSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAccountStorageRemoveSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAmsAccountStorageRemoveSettings ResetResourceGroup(this AzureAmsAccountStorageRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAmsAccountStorageRemoveSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAmsAccountStorageRemoveSettings SetDebug(this AzureAmsAccountStorageRemoveSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAccountStorageRemoveSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAmsAccountStorageRemoveSettings ResetDebug(this AzureAmsAccountStorageRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAmsAccountStorageRemoveSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAmsAccountStorageRemoveSettings SetHelp(this AzureAmsAccountStorageRemoveSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAccountStorageRemoveSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAmsAccountStorageRemoveSettings ResetHelp(this AzureAmsAccountStorageRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAmsAccountStorageRemoveSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAmsAccountStorageRemoveSettings SetOutput(this AzureAmsAccountStorageRemoveSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAccountStorageRemoveSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAmsAccountStorageRemoveSettings ResetOutput(this AzureAmsAccountStorageRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAmsAccountStorageRemoveSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAmsAccountStorageRemoveSettings SetQuery(this AzureAmsAccountStorageRemoveSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAccountStorageRemoveSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAmsAccountStorageRemoveSettings ResetQuery(this AzureAmsAccountStorageRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAmsAccountStorageRemoveSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAmsAccountStorageRemoveSettings SetVerbose(this AzureAmsAccountStorageRemoveSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsAccountStorageRemoveSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAmsAccountStorageRemoveSettings ResetVerbose(this AzureAmsAccountStorageRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAmsStreamingEndpointListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAmsStreamingEndpointListSettingsExtensions
    {
        #region AccountName
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingEndpointListSettings.AccountName"/>.</em></p><p>The name of the Azure Media Services account.</p></summary>
        [Pure]
        public static AzureAmsStreamingEndpointListSettings SetAccountName(this AzureAmsStreamingEndpointListSettings toolSettings, string accountName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = accountName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingEndpointListSettings.AccountName"/>.</em></p><p>The name of the Azure Media Services account.</p></summary>
        [Pure]
        public static AzureAmsStreamingEndpointListSettings ResetAccountName(this AzureAmsStreamingEndpointListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingEndpointListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAmsStreamingEndpointListSettings SetResourceGroup(this AzureAmsStreamingEndpointListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingEndpointListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAmsStreamingEndpointListSettings ResetResourceGroup(this AzureAmsStreamingEndpointListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingEndpointListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAmsStreamingEndpointListSettings SetDebug(this AzureAmsStreamingEndpointListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingEndpointListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAmsStreamingEndpointListSettings ResetDebug(this AzureAmsStreamingEndpointListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingEndpointListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAmsStreamingEndpointListSettings SetHelp(this AzureAmsStreamingEndpointListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingEndpointListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAmsStreamingEndpointListSettings ResetHelp(this AzureAmsStreamingEndpointListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingEndpointListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAmsStreamingEndpointListSettings SetOutput(this AzureAmsStreamingEndpointListSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingEndpointListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAmsStreamingEndpointListSettings ResetOutput(this AzureAmsStreamingEndpointListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingEndpointListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAmsStreamingEndpointListSettings SetQuery(this AzureAmsStreamingEndpointListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingEndpointListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAmsStreamingEndpointListSettings ResetQuery(this AzureAmsStreamingEndpointListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingEndpointListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAmsStreamingEndpointListSettings SetVerbose(this AzureAmsStreamingEndpointListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingEndpointListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAmsStreamingEndpointListSettings ResetVerbose(this AzureAmsStreamingEndpointListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAmsStreamingEndpointStartSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAmsStreamingEndpointStartSettingsExtensions
    {
        #region AccountName
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingEndpointStartSettings.AccountName"/>.</em></p><p>The name of the Azure Media Services account.</p></summary>
        [Pure]
        public static AzureAmsStreamingEndpointStartSettings SetAccountName(this AzureAmsStreamingEndpointStartSettings toolSettings, string accountName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = accountName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingEndpointStartSettings.AccountName"/>.</em></p><p>The name of the Azure Media Services account.</p></summary>
        [Pure]
        public static AzureAmsStreamingEndpointStartSettings ResetAccountName(this AzureAmsStreamingEndpointStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingEndpointStartSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAmsStreamingEndpointStartSettings SetResourceGroup(this AzureAmsStreamingEndpointStartSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingEndpointStartSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAmsStreamingEndpointStartSettings ResetResourceGroup(this AzureAmsStreamingEndpointStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region StreamingEndpointName
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingEndpointStartSettings.StreamingEndpointName"/>.</em></p><p>The name of the StreamingEndpoint.</p></summary>
        [Pure]
        public static AzureAmsStreamingEndpointStartSettings SetStreamingEndpointName(this AzureAmsStreamingEndpointStartSettings toolSettings, string streamingEndpointName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StreamingEndpointName = streamingEndpointName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingEndpointStartSettings.StreamingEndpointName"/>.</em></p><p>The name of the StreamingEndpoint.</p></summary>
        [Pure]
        public static AzureAmsStreamingEndpointStartSettings ResetStreamingEndpointName(this AzureAmsStreamingEndpointStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StreamingEndpointName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingEndpointStartSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAmsStreamingEndpointStartSettings SetDebug(this AzureAmsStreamingEndpointStartSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingEndpointStartSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAmsStreamingEndpointStartSettings ResetDebug(this AzureAmsStreamingEndpointStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingEndpointStartSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAmsStreamingEndpointStartSettings SetHelp(this AzureAmsStreamingEndpointStartSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingEndpointStartSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAmsStreamingEndpointStartSettings ResetHelp(this AzureAmsStreamingEndpointStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingEndpointStartSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAmsStreamingEndpointStartSettings SetOutput(this AzureAmsStreamingEndpointStartSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingEndpointStartSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAmsStreamingEndpointStartSettings ResetOutput(this AzureAmsStreamingEndpointStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingEndpointStartSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAmsStreamingEndpointStartSettings SetQuery(this AzureAmsStreamingEndpointStartSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingEndpointStartSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAmsStreamingEndpointStartSettings ResetQuery(this AzureAmsStreamingEndpointStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingEndpointStartSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAmsStreamingEndpointStartSettings SetVerbose(this AzureAmsStreamingEndpointStartSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingEndpointStartSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAmsStreamingEndpointStartSettings ResetVerbose(this AzureAmsStreamingEndpointStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAmsStreamingEndpointStopSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAmsStreamingEndpointStopSettingsExtensions
    {
        #region AccountName
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingEndpointStopSettings.AccountName"/>.</em></p><p>The name of the Azure Media Services account.</p></summary>
        [Pure]
        public static AzureAmsStreamingEndpointStopSettings SetAccountName(this AzureAmsStreamingEndpointStopSettings toolSettings, string accountName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = accountName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingEndpointStopSettings.AccountName"/>.</em></p><p>The name of the Azure Media Services account.</p></summary>
        [Pure]
        public static AzureAmsStreamingEndpointStopSettings ResetAccountName(this AzureAmsStreamingEndpointStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingEndpointStopSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAmsStreamingEndpointStopSettings SetResourceGroup(this AzureAmsStreamingEndpointStopSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingEndpointStopSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAmsStreamingEndpointStopSettings ResetResourceGroup(this AzureAmsStreamingEndpointStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region StreamingEndpointName
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingEndpointStopSettings.StreamingEndpointName"/>.</em></p><p>The name of the StreamingEndpoint.</p></summary>
        [Pure]
        public static AzureAmsStreamingEndpointStopSettings SetStreamingEndpointName(this AzureAmsStreamingEndpointStopSettings toolSettings, string streamingEndpointName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StreamingEndpointName = streamingEndpointName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingEndpointStopSettings.StreamingEndpointName"/>.</em></p><p>The name of the StreamingEndpoint.</p></summary>
        [Pure]
        public static AzureAmsStreamingEndpointStopSettings ResetStreamingEndpointName(this AzureAmsStreamingEndpointStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StreamingEndpointName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingEndpointStopSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAmsStreamingEndpointStopSettings SetDebug(this AzureAmsStreamingEndpointStopSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingEndpointStopSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAmsStreamingEndpointStopSettings ResetDebug(this AzureAmsStreamingEndpointStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingEndpointStopSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAmsStreamingEndpointStopSettings SetHelp(this AzureAmsStreamingEndpointStopSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingEndpointStopSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAmsStreamingEndpointStopSettings ResetHelp(this AzureAmsStreamingEndpointStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingEndpointStopSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAmsStreamingEndpointStopSettings SetOutput(this AzureAmsStreamingEndpointStopSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingEndpointStopSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAmsStreamingEndpointStopSettings ResetOutput(this AzureAmsStreamingEndpointStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingEndpointStopSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAmsStreamingEndpointStopSettings SetQuery(this AzureAmsStreamingEndpointStopSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingEndpointStopSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAmsStreamingEndpointStopSettings ResetQuery(this AzureAmsStreamingEndpointStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingEndpointStopSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAmsStreamingEndpointStopSettings SetVerbose(this AzureAmsStreamingEndpointStopSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingEndpointStopSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAmsStreamingEndpointStopSettings ResetVerbose(this AzureAmsStreamingEndpointStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAmsStreamingLocatorCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAmsStreamingLocatorCreateSettingsExtensions
    {
        #region AccountName
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingLocatorCreateSettings.AccountName"/>.</em></p><p>The name of the Azure Media Services account.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorCreateSettings SetAccountName(this AzureAmsStreamingLocatorCreateSettings toolSettings, string accountName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = accountName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingLocatorCreateSettings.AccountName"/>.</em></p><p>The name of the Azure Media Services account.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorCreateSettings ResetAccountName(this AzureAmsStreamingLocatorCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = null;
            return toolSettings;
        }
        #endregion
        #region AssetName
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingLocatorCreateSettings.AssetName"/>.</em></p><p>The name of the asset used by the streaming locator.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorCreateSettings SetAssetName(this AzureAmsStreamingLocatorCreateSettings toolSettings, string assetName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AssetName = assetName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingLocatorCreateSettings.AssetName"/>.</em></p><p>The name of the asset used by the streaming locator.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorCreateSettings ResetAssetName(this AzureAmsStreamingLocatorCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AssetName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingLocatorCreateSettings.Name"/>.</em></p><p>The name of the streaming locator.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorCreateSettings SetName(this AzureAmsStreamingLocatorCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingLocatorCreateSettings.Name"/>.</em></p><p>The name of the streaming locator.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorCreateSettings ResetName(this AzureAmsStreamingLocatorCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingLocatorCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorCreateSettings SetResourceGroup(this AzureAmsStreamingLocatorCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingLocatorCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorCreateSettings ResetResourceGroup(this AzureAmsStreamingLocatorCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region StreamingPolicyName
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingLocatorCreateSettings.StreamingPolicyName"/>.</em></p><p>The name of the streaming policy used by the streaming locator.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorCreateSettings SetStreamingPolicyName(this AzureAmsStreamingLocatorCreateSettings toolSettings, string streamingPolicyName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StreamingPolicyName = streamingPolicyName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingLocatorCreateSettings.StreamingPolicyName"/>.</em></p><p>The name of the streaming policy used by the streaming locator.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorCreateSettings ResetStreamingPolicyName(this AzureAmsStreamingLocatorCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StreamingPolicyName = null;
            return toolSettings;
        }
        #endregion
        #region ContentPolicyName
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingLocatorCreateSettings.ContentPolicyName"/>.</em></p><p>The default content key policy name used by the streaming locator.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorCreateSettings SetContentPolicyName(this AzureAmsStreamingLocatorCreateSettings toolSettings, string contentPolicyName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ContentPolicyName = contentPolicyName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingLocatorCreateSettings.ContentPolicyName"/>.</em></p><p>The default content key policy name used by the streaming locator.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorCreateSettings ResetContentPolicyName(this AzureAmsStreamingLocatorCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ContentPolicyName = null;
            return toolSettings;
        }
        #endregion
        #region EndTime
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingLocatorCreateSettings.EndTime"/>.</em></p><p>End time (Y-m-d'T'H:M:S'Z') of the streaming locator.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorCreateSettings SetEndTime(this AzureAmsStreamingLocatorCreateSettings toolSettings, string endTime)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndTime = endTime;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingLocatorCreateSettings.EndTime"/>.</em></p><p>End time (Y-m-d'T'H:M:S'Z') of the streaming locator.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorCreateSettings ResetEndTime(this AzureAmsStreamingLocatorCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndTime = null;
            return toolSettings;
        }
        #endregion
        #region StartTime
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingLocatorCreateSettings.StartTime"/>.</em></p><p>Start time (Y-m-d'T'H:M:S'Z') of the streaming locator.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorCreateSettings SetStartTime(this AzureAmsStreamingLocatorCreateSettings toolSettings, string startTime)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartTime = startTime;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingLocatorCreateSettings.StartTime"/>.</em></p><p>Start time (Y-m-d'T'H:M:S'Z') of the streaming locator.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorCreateSettings ResetStartTime(this AzureAmsStreamingLocatorCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartTime = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingLocatorCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorCreateSettings SetDebug(this AzureAmsStreamingLocatorCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingLocatorCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorCreateSettings ResetDebug(this AzureAmsStreamingLocatorCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingLocatorCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorCreateSettings SetHelp(this AzureAmsStreamingLocatorCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingLocatorCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorCreateSettings ResetHelp(this AzureAmsStreamingLocatorCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingLocatorCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorCreateSettings SetOutput(this AzureAmsStreamingLocatorCreateSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingLocatorCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorCreateSettings ResetOutput(this AzureAmsStreamingLocatorCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingLocatorCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorCreateSettings SetQuery(this AzureAmsStreamingLocatorCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingLocatorCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorCreateSettings ResetQuery(this AzureAmsStreamingLocatorCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingLocatorCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorCreateSettings SetVerbose(this AzureAmsStreamingLocatorCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingLocatorCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorCreateSettings ResetVerbose(this AzureAmsStreamingLocatorCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAmsStreamingLocatorDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAmsStreamingLocatorDeleteSettingsExtensions
    {
        #region AccountName
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingLocatorDeleteSettings.AccountName"/>.</em></p><p>The name of the Azure Media Services account.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorDeleteSettings SetAccountName(this AzureAmsStreamingLocatorDeleteSettings toolSettings, string accountName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = accountName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingLocatorDeleteSettings.AccountName"/>.</em></p><p>The name of the Azure Media Services account.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorDeleteSettings ResetAccountName(this AzureAmsStreamingLocatorDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingLocatorDeleteSettings.Name"/>.</em></p><p>The name of the streaming locator.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorDeleteSettings SetName(this AzureAmsStreamingLocatorDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingLocatorDeleteSettings.Name"/>.</em></p><p>The name of the streaming locator.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorDeleteSettings ResetName(this AzureAmsStreamingLocatorDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingLocatorDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorDeleteSettings SetResourceGroup(this AzureAmsStreamingLocatorDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingLocatorDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorDeleteSettings ResetResourceGroup(this AzureAmsStreamingLocatorDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingLocatorDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorDeleteSettings SetDebug(this AzureAmsStreamingLocatorDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingLocatorDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorDeleteSettings ResetDebug(this AzureAmsStreamingLocatorDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingLocatorDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorDeleteSettings SetHelp(this AzureAmsStreamingLocatorDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingLocatorDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorDeleteSettings ResetHelp(this AzureAmsStreamingLocatorDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingLocatorDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorDeleteSettings SetOutput(this AzureAmsStreamingLocatorDeleteSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingLocatorDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorDeleteSettings ResetOutput(this AzureAmsStreamingLocatorDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingLocatorDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorDeleteSettings SetQuery(this AzureAmsStreamingLocatorDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingLocatorDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorDeleteSettings ResetQuery(this AzureAmsStreamingLocatorDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingLocatorDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorDeleteSettings SetVerbose(this AzureAmsStreamingLocatorDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingLocatorDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorDeleteSettings ResetVerbose(this AzureAmsStreamingLocatorDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAmsStreamingLocatorGetPathsSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAmsStreamingLocatorGetPathsSettingsExtensions
    {
        #region AccountName
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingLocatorGetPathsSettings.AccountName"/>.</em></p><p>The name of the Azure Media Services account.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorGetPathsSettings SetAccountName(this AzureAmsStreamingLocatorGetPathsSettings toolSettings, string accountName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = accountName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingLocatorGetPathsSettings.AccountName"/>.</em></p><p>The name of the Azure Media Services account.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorGetPathsSettings ResetAccountName(this AzureAmsStreamingLocatorGetPathsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingLocatorGetPathsSettings.Name"/>.</em></p><p>The name of the streaming locator.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorGetPathsSettings SetName(this AzureAmsStreamingLocatorGetPathsSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingLocatorGetPathsSettings.Name"/>.</em></p><p>The name of the streaming locator.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorGetPathsSettings ResetName(this AzureAmsStreamingLocatorGetPathsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingLocatorGetPathsSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorGetPathsSettings SetResourceGroup(this AzureAmsStreamingLocatorGetPathsSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingLocatorGetPathsSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorGetPathsSettings ResetResourceGroup(this AzureAmsStreamingLocatorGetPathsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingLocatorGetPathsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorGetPathsSettings SetDebug(this AzureAmsStreamingLocatorGetPathsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingLocatorGetPathsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorGetPathsSettings ResetDebug(this AzureAmsStreamingLocatorGetPathsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingLocatorGetPathsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorGetPathsSettings SetHelp(this AzureAmsStreamingLocatorGetPathsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingLocatorGetPathsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorGetPathsSettings ResetHelp(this AzureAmsStreamingLocatorGetPathsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingLocatorGetPathsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorGetPathsSettings SetOutput(this AzureAmsStreamingLocatorGetPathsSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingLocatorGetPathsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorGetPathsSettings ResetOutput(this AzureAmsStreamingLocatorGetPathsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingLocatorGetPathsSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorGetPathsSettings SetQuery(this AzureAmsStreamingLocatorGetPathsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingLocatorGetPathsSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorGetPathsSettings ResetQuery(this AzureAmsStreamingLocatorGetPathsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingLocatorGetPathsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorGetPathsSettings SetVerbose(this AzureAmsStreamingLocatorGetPathsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingLocatorGetPathsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorGetPathsSettings ResetVerbose(this AzureAmsStreamingLocatorGetPathsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAmsStreamingLocatorListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAmsStreamingLocatorListSettingsExtensions
    {
        #region AccountName
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingLocatorListSettings.AccountName"/>.</em></p><p>The name of the Azure Media Services account.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorListSettings SetAccountName(this AzureAmsStreamingLocatorListSettings toolSettings, string accountName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = accountName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingLocatorListSettings.AccountName"/>.</em></p><p>The name of the Azure Media Services account.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorListSettings ResetAccountName(this AzureAmsStreamingLocatorListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingLocatorListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorListSettings SetResourceGroup(this AzureAmsStreamingLocatorListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingLocatorListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorListSettings ResetResourceGroup(this AzureAmsStreamingLocatorListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Filter
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingLocatorListSettings.Filter"/>.</em></p><p>Restricts the set of items returned.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorListSettings SetFilter(this AzureAmsStreamingLocatorListSettings toolSettings, string filter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = filter;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingLocatorListSettings.Filter"/>.</em></p><p>Restricts the set of items returned.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorListSettings ResetFilter(this AzureAmsStreamingLocatorListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = null;
            return toolSettings;
        }
        #endregion
        #region Orderby
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingLocatorListSettings.Orderby"/>.</em></p><p>Specifies the the key by which the result collection should be ordered.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorListSettings SetOrderby(this AzureAmsStreamingLocatorListSettings toolSettings, string orderby)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Orderby = orderby;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingLocatorListSettings.Orderby"/>.</em></p><p>Specifies the the key by which the result collection should be ordered.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorListSettings ResetOrderby(this AzureAmsStreamingLocatorListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Orderby = null;
            return toolSettings;
        }
        #endregion
        #region Top
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingLocatorListSettings.Top"/>.</em></p><p>Specifies a non-negative integer n that limits the number of items returned from a collection. The service returns the number of available items up to but not greater than the specified value n.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorListSettings SetTop(this AzureAmsStreamingLocatorListSettings toolSettings, string top)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = top;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingLocatorListSettings.Top"/>.</em></p><p>Specifies a non-negative integer n that limits the number of items returned from a collection. The service returns the number of available items up to but not greater than the specified value n.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorListSettings ResetTop(this AzureAmsStreamingLocatorListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingLocatorListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorListSettings SetDebug(this AzureAmsStreamingLocatorListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingLocatorListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorListSettings ResetDebug(this AzureAmsStreamingLocatorListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingLocatorListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorListSettings SetHelp(this AzureAmsStreamingLocatorListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingLocatorListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorListSettings ResetHelp(this AzureAmsStreamingLocatorListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingLocatorListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorListSettings SetOutput(this AzureAmsStreamingLocatorListSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingLocatorListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorListSettings ResetOutput(this AzureAmsStreamingLocatorListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingLocatorListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorListSettings SetQuery(this AzureAmsStreamingLocatorListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingLocatorListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorListSettings ResetQuery(this AzureAmsStreamingLocatorListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingLocatorListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorListSettings SetVerbose(this AzureAmsStreamingLocatorListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingLocatorListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorListSettings ResetVerbose(this AzureAmsStreamingLocatorListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAmsStreamingLocatorShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAmsStreamingLocatorShowSettingsExtensions
    {
        #region AccountName
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingLocatorShowSettings.AccountName"/>.</em></p><p>The name of the Azure Media Services account.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorShowSettings SetAccountName(this AzureAmsStreamingLocatorShowSettings toolSettings, string accountName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = accountName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingLocatorShowSettings.AccountName"/>.</em></p><p>The name of the Azure Media Services account.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorShowSettings ResetAccountName(this AzureAmsStreamingLocatorShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingLocatorShowSettings.Name"/>.</em></p><p>The name of the streaming locator.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorShowSettings SetName(this AzureAmsStreamingLocatorShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingLocatorShowSettings.Name"/>.</em></p><p>The name of the streaming locator.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorShowSettings ResetName(this AzureAmsStreamingLocatorShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingLocatorShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorShowSettings SetResourceGroup(this AzureAmsStreamingLocatorShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingLocatorShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorShowSettings ResetResourceGroup(this AzureAmsStreamingLocatorShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingLocatorShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorShowSettings SetDebug(this AzureAmsStreamingLocatorShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingLocatorShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorShowSettings ResetDebug(this AzureAmsStreamingLocatorShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingLocatorShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorShowSettings SetHelp(this AzureAmsStreamingLocatorShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingLocatorShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorShowSettings ResetHelp(this AzureAmsStreamingLocatorShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingLocatorShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorShowSettings SetOutput(this AzureAmsStreamingLocatorShowSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingLocatorShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorShowSettings ResetOutput(this AzureAmsStreamingLocatorShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingLocatorShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorShowSettings SetQuery(this AzureAmsStreamingLocatorShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingLocatorShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorShowSettings ResetQuery(this AzureAmsStreamingLocatorShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingLocatorShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorShowSettings SetVerbose(this AzureAmsStreamingLocatorShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingLocatorShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAmsStreamingLocatorShowSettings ResetVerbose(this AzureAmsStreamingLocatorShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAmsStreamingPolicyCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAmsStreamingPolicyCreateSettingsExtensions
    {
        #region AccountName
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingPolicyCreateSettings.AccountName"/>.</em></p><p>The name of the Azure Media Services account.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyCreateSettings SetAccountName(this AzureAmsStreamingPolicyCreateSettings toolSettings, string accountName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = accountName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingPolicyCreateSettings.AccountName"/>.</em></p><p>The name of the Azure Media Services account.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyCreateSettings ResetAccountName(this AzureAmsStreamingPolicyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingPolicyCreateSettings.Name"/>.</em></p><p>The name of the streaming policy.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyCreateSettings SetName(this AzureAmsStreamingPolicyCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingPolicyCreateSettings.Name"/>.</em></p><p>The name of the streaming policy.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyCreateSettings ResetName(this AzureAmsStreamingPolicyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingPolicyCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyCreateSettings SetResourceGroup(this AzureAmsStreamingPolicyCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingPolicyCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyCreateSettings ResetResourceGroup(this AzureAmsStreamingPolicyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ContentPolicyName
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingPolicyCreateSettings.ContentPolicyName"/>.</em></p><p>The default content key policy name used by the streaming locator.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyCreateSettings SetContentPolicyName(this AzureAmsStreamingPolicyCreateSettings toolSettings, string contentPolicyName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ContentPolicyName = contentPolicyName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingPolicyCreateSettings.ContentPolicyName"/>.</em></p><p>The default content key policy name used by the streaming locator.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyCreateSettings ResetContentPolicyName(this AzureAmsStreamingPolicyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ContentPolicyName = null;
            return toolSettings;
        }
        #endregion
        #region Dash
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingPolicyCreateSettings.Dash"/>.</em></p><p>Enable Dash protocol.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyCreateSettings SetDash(this AzureAmsStreamingPolicyCreateSettings toolSettings, bool? dash)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Dash = dash;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingPolicyCreateSettings.Dash"/>.</em></p><p>Enable Dash protocol.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyCreateSettings ResetDash(this AzureAmsStreamingPolicyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Dash = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureAmsStreamingPolicyCreateSettings.Dash"/>.</em></p><p>Enable Dash protocol.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyCreateSettings EnableDash(this AzureAmsStreamingPolicyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Dash = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureAmsStreamingPolicyCreateSettings.Dash"/>.</em></p><p>Enable Dash protocol.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyCreateSettings DisableDash(this AzureAmsStreamingPolicyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Dash = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureAmsStreamingPolicyCreateSettings.Dash"/>.</em></p><p>Enable Dash protocol.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyCreateSettings ToggleDash(this AzureAmsStreamingPolicyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Dash = !toolSettings.Dash;
            return toolSettings;
        }
        #endregion
        #region Download
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingPolicyCreateSettings.Download"/>.</em></p><p>Enable Download protocol.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyCreateSettings SetDownload(this AzureAmsStreamingPolicyCreateSettings toolSettings, bool? download)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Download = download;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingPolicyCreateSettings.Download"/>.</em></p><p>Enable Download protocol.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyCreateSettings ResetDownload(this AzureAmsStreamingPolicyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Download = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureAmsStreamingPolicyCreateSettings.Download"/>.</em></p><p>Enable Download protocol.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyCreateSettings EnableDownload(this AzureAmsStreamingPolicyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Download = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureAmsStreamingPolicyCreateSettings.Download"/>.</em></p><p>Enable Download protocol.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyCreateSettings DisableDownload(this AzureAmsStreamingPolicyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Download = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureAmsStreamingPolicyCreateSettings.Download"/>.</em></p><p>Enable Download protocol.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyCreateSettings ToggleDownload(this AzureAmsStreamingPolicyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Download = !toolSettings.Download;
            return toolSettings;
        }
        #endregion
        #region Hls
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingPolicyCreateSettings.Hls"/>.</em></p><p>Enable HLS protocol.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyCreateSettings SetHls(this AzureAmsStreamingPolicyCreateSettings toolSettings, bool? hls)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Hls = hls;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingPolicyCreateSettings.Hls"/>.</em></p><p>Enable HLS protocol.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyCreateSettings ResetHls(this AzureAmsStreamingPolicyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Hls = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureAmsStreamingPolicyCreateSettings.Hls"/>.</em></p><p>Enable HLS protocol.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyCreateSettings EnableHls(this AzureAmsStreamingPolicyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Hls = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureAmsStreamingPolicyCreateSettings.Hls"/>.</em></p><p>Enable HLS protocol.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyCreateSettings DisableHls(this AzureAmsStreamingPolicyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Hls = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureAmsStreamingPolicyCreateSettings.Hls"/>.</em></p><p>Enable HLS protocol.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyCreateSettings ToggleHls(this AzureAmsStreamingPolicyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Hls = !toolSettings.Hls;
            return toolSettings;
        }
        #endregion
        #region SmoothStreaming
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingPolicyCreateSettings.SmoothStreaming"/>.</em></p><p>Enable SmoothStreaming protocol.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyCreateSettings SetSmoothStreaming(this AzureAmsStreamingPolicyCreateSettings toolSettings, bool? smoothStreaming)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SmoothStreaming = smoothStreaming;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingPolicyCreateSettings.SmoothStreaming"/>.</em></p><p>Enable SmoothStreaming protocol.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyCreateSettings ResetSmoothStreaming(this AzureAmsStreamingPolicyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SmoothStreaming = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureAmsStreamingPolicyCreateSettings.SmoothStreaming"/>.</em></p><p>Enable SmoothStreaming protocol.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyCreateSettings EnableSmoothStreaming(this AzureAmsStreamingPolicyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SmoothStreaming = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureAmsStreamingPolicyCreateSettings.SmoothStreaming"/>.</em></p><p>Enable SmoothStreaming protocol.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyCreateSettings DisableSmoothStreaming(this AzureAmsStreamingPolicyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SmoothStreaming = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureAmsStreamingPolicyCreateSettings.SmoothStreaming"/>.</em></p><p>Enable SmoothStreaming protocol.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyCreateSettings ToggleSmoothStreaming(this AzureAmsStreamingPolicyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SmoothStreaming = !toolSettings.SmoothStreaming;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingPolicyCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyCreateSettings SetDebug(this AzureAmsStreamingPolicyCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingPolicyCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyCreateSettings ResetDebug(this AzureAmsStreamingPolicyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingPolicyCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyCreateSettings SetHelp(this AzureAmsStreamingPolicyCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingPolicyCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyCreateSettings ResetHelp(this AzureAmsStreamingPolicyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingPolicyCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyCreateSettings SetOutput(this AzureAmsStreamingPolicyCreateSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingPolicyCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyCreateSettings ResetOutput(this AzureAmsStreamingPolicyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingPolicyCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyCreateSettings SetQuery(this AzureAmsStreamingPolicyCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingPolicyCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyCreateSettings ResetQuery(this AzureAmsStreamingPolicyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingPolicyCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyCreateSettings SetVerbose(this AzureAmsStreamingPolicyCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingPolicyCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyCreateSettings ResetVerbose(this AzureAmsStreamingPolicyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAmsStreamingPolicyDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAmsStreamingPolicyDeleteSettingsExtensions
    {
        #region AccountName
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingPolicyDeleteSettings.AccountName"/>.</em></p><p>The name of the Azure Media Services account.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyDeleteSettings SetAccountName(this AzureAmsStreamingPolicyDeleteSettings toolSettings, string accountName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = accountName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingPolicyDeleteSettings.AccountName"/>.</em></p><p>The name of the Azure Media Services account.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyDeleteSettings ResetAccountName(this AzureAmsStreamingPolicyDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingPolicyDeleteSettings.Name"/>.</em></p><p>The name of the streaming policy.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyDeleteSettings SetName(this AzureAmsStreamingPolicyDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingPolicyDeleteSettings.Name"/>.</em></p><p>The name of the streaming policy.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyDeleteSettings ResetName(this AzureAmsStreamingPolicyDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingPolicyDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyDeleteSettings SetResourceGroup(this AzureAmsStreamingPolicyDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingPolicyDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyDeleteSettings ResetResourceGroup(this AzureAmsStreamingPolicyDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingPolicyDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyDeleteSettings SetDebug(this AzureAmsStreamingPolicyDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingPolicyDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyDeleteSettings ResetDebug(this AzureAmsStreamingPolicyDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingPolicyDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyDeleteSettings SetHelp(this AzureAmsStreamingPolicyDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingPolicyDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyDeleteSettings ResetHelp(this AzureAmsStreamingPolicyDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingPolicyDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyDeleteSettings SetOutput(this AzureAmsStreamingPolicyDeleteSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingPolicyDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyDeleteSettings ResetOutput(this AzureAmsStreamingPolicyDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingPolicyDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyDeleteSettings SetQuery(this AzureAmsStreamingPolicyDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingPolicyDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyDeleteSettings ResetQuery(this AzureAmsStreamingPolicyDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingPolicyDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyDeleteSettings SetVerbose(this AzureAmsStreamingPolicyDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingPolicyDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyDeleteSettings ResetVerbose(this AzureAmsStreamingPolicyDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAmsStreamingPolicyListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAmsStreamingPolicyListSettingsExtensions
    {
        #region AccountName
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingPolicyListSettings.AccountName"/>.</em></p><p>The name of the Azure Media Services account.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyListSettings SetAccountName(this AzureAmsStreamingPolicyListSettings toolSettings, string accountName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = accountName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingPolicyListSettings.AccountName"/>.</em></p><p>The name of the Azure Media Services account.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyListSettings ResetAccountName(this AzureAmsStreamingPolicyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingPolicyListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyListSettings SetResourceGroup(this AzureAmsStreamingPolicyListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingPolicyListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyListSettings ResetResourceGroup(this AzureAmsStreamingPolicyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Filter
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingPolicyListSettings.Filter"/>.</em></p><p>Restricts the set of items returned.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyListSettings SetFilter(this AzureAmsStreamingPolicyListSettings toolSettings, string filter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = filter;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingPolicyListSettings.Filter"/>.</em></p><p>Restricts the set of items returned.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyListSettings ResetFilter(this AzureAmsStreamingPolicyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = null;
            return toolSettings;
        }
        #endregion
        #region Orderby
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingPolicyListSettings.Orderby"/>.</em></p><p>Specifies the the key by which the result collection should be ordered.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyListSettings SetOrderby(this AzureAmsStreamingPolicyListSettings toolSettings, string orderby)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Orderby = orderby;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingPolicyListSettings.Orderby"/>.</em></p><p>Specifies the the key by which the result collection should be ordered.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyListSettings ResetOrderby(this AzureAmsStreamingPolicyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Orderby = null;
            return toolSettings;
        }
        #endregion
        #region Top
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingPolicyListSettings.Top"/>.</em></p><p>Specifies a non-negative integer n that limits the number of items returned from a collection. The service returns the number of available items up to but not greater than the specified value n.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyListSettings SetTop(this AzureAmsStreamingPolicyListSettings toolSettings, string top)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = top;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingPolicyListSettings.Top"/>.</em></p><p>Specifies a non-negative integer n that limits the number of items returned from a collection. The service returns the number of available items up to but not greater than the specified value n.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyListSettings ResetTop(this AzureAmsStreamingPolicyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingPolicyListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyListSettings SetDebug(this AzureAmsStreamingPolicyListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingPolicyListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyListSettings ResetDebug(this AzureAmsStreamingPolicyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingPolicyListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyListSettings SetHelp(this AzureAmsStreamingPolicyListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingPolicyListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyListSettings ResetHelp(this AzureAmsStreamingPolicyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingPolicyListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyListSettings SetOutput(this AzureAmsStreamingPolicyListSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingPolicyListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyListSettings ResetOutput(this AzureAmsStreamingPolicyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingPolicyListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyListSettings SetQuery(this AzureAmsStreamingPolicyListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingPolicyListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyListSettings ResetQuery(this AzureAmsStreamingPolicyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingPolicyListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyListSettings SetVerbose(this AzureAmsStreamingPolicyListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingPolicyListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyListSettings ResetVerbose(this AzureAmsStreamingPolicyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAmsStreamingPolicyShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAmsStreamingPolicyShowSettingsExtensions
    {
        #region AccountName
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingPolicyShowSettings.AccountName"/>.</em></p><p>The name of the Azure Media Services account.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyShowSettings SetAccountName(this AzureAmsStreamingPolicyShowSettings toolSettings, string accountName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = accountName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingPolicyShowSettings.AccountName"/>.</em></p><p>The name of the Azure Media Services account.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyShowSettings ResetAccountName(this AzureAmsStreamingPolicyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingPolicyShowSettings.Name"/>.</em></p><p>The name of the streaming policy.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyShowSettings SetName(this AzureAmsStreamingPolicyShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingPolicyShowSettings.Name"/>.</em></p><p>The name of the streaming policy.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyShowSettings ResetName(this AzureAmsStreamingPolicyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingPolicyShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyShowSettings SetResourceGroup(this AzureAmsStreamingPolicyShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingPolicyShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyShowSettings ResetResourceGroup(this AzureAmsStreamingPolicyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingPolicyShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyShowSettings SetDebug(this AzureAmsStreamingPolicyShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingPolicyShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyShowSettings ResetDebug(this AzureAmsStreamingPolicyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingPolicyShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyShowSettings SetHelp(this AzureAmsStreamingPolicyShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingPolicyShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyShowSettings ResetHelp(this AzureAmsStreamingPolicyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingPolicyShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyShowSettings SetOutput(this AzureAmsStreamingPolicyShowSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingPolicyShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyShowSettings ResetOutput(this AzureAmsStreamingPolicyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingPolicyShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyShowSettings SetQuery(this AzureAmsStreamingPolicyShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingPolicyShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyShowSettings ResetQuery(this AzureAmsStreamingPolicyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAmsStreamingPolicyShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyShowSettings SetVerbose(this AzureAmsStreamingPolicyShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsStreamingPolicyShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAmsStreamingPolicyShowSettings ResetVerbose(this AzureAmsStreamingPolicyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAmsTransformOutputAddSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAmsTransformOutputAddSettingsExtensions
    {
        #region AccountName
        /// <summary><p><em>Sets <see cref="AzureAmsTransformOutputAddSettings.AccountName"/>.</em></p><p>The name of the Azure Media Services account.</p></summary>
        [Pure]
        public static AzureAmsTransformOutputAddSettings SetAccountName(this AzureAmsTransformOutputAddSettings toolSettings, string accountName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = accountName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsTransformOutputAddSettings.AccountName"/>.</em></p><p>The name of the Azure Media Services account.</p></summary>
        [Pure]
        public static AzureAmsTransformOutputAddSettings ResetAccountName(this AzureAmsTransformOutputAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAmsTransformOutputAddSettings.Name"/>.</em></p><p>The name of the transform.</p></summary>
        [Pure]
        public static AzureAmsTransformOutputAddSettings SetName(this AzureAmsTransformOutputAddSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsTransformOutputAddSettings.Name"/>.</em></p><p>The name of the transform.</p></summary>
        [Pure]
        public static AzureAmsTransformOutputAddSettings ResetName(this AzureAmsTransformOutputAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region PresetNames
        /// <summary><p><em>Sets <see cref="AzureAmsTransformOutputAddSettings.PresetNames"/> to a new list.</em></p><p>Space-separated list of built-in preset names.</p></summary>
        [Pure]
        public static AzureAmsTransformOutputAddSettings SetPresetNames(this AzureAmsTransformOutputAddSettings toolSettings, params AmsTransformPresetNames[] presetNames)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PresetNamesInternal = presetNames.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureAmsTransformOutputAddSettings.PresetNames"/> to a new list.</em></p><p>Space-separated list of built-in preset names.</p></summary>
        [Pure]
        public static AzureAmsTransformOutputAddSettings SetPresetNames(this AzureAmsTransformOutputAddSettings toolSettings, IEnumerable<AmsTransformPresetNames> presetNames)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PresetNamesInternal = presetNames.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureAmsTransformOutputAddSettings.PresetNames"/>.</em></p><p>Space-separated list of built-in preset names.</p></summary>
        [Pure]
        public static AzureAmsTransformOutputAddSettings AddPresetNames(this AzureAmsTransformOutputAddSettings toolSettings, params AmsTransformPresetNames[] presetNames)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PresetNamesInternal.AddRange(presetNames);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureAmsTransformOutputAddSettings.PresetNames"/>.</em></p><p>Space-separated list of built-in preset names.</p></summary>
        [Pure]
        public static AzureAmsTransformOutputAddSettings AddPresetNames(this AzureAmsTransformOutputAddSettings toolSettings, IEnumerable<AmsTransformPresetNames> presetNames)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PresetNamesInternal.AddRange(presetNames);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureAmsTransformOutputAddSettings.PresetNames"/>.</em></p><p>Space-separated list of built-in preset names.</p></summary>
        [Pure]
        public static AzureAmsTransformOutputAddSettings ClearPresetNames(this AzureAmsTransformOutputAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PresetNamesInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureAmsTransformOutputAddSettings.PresetNames"/>.</em></p><p>Space-separated list of built-in preset names.</p></summary>
        [Pure]
        public static AzureAmsTransformOutputAddSettings RemovePresetNames(this AzureAmsTransformOutputAddSettings toolSettings, params AmsTransformPresetNames[] presetNames)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<AmsTransformPresetNames>(presetNames);
            toolSettings.PresetNamesInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureAmsTransformOutputAddSettings.PresetNames"/>.</em></p><p>Space-separated list of built-in preset names.</p></summary>
        [Pure]
        public static AzureAmsTransformOutputAddSettings RemovePresetNames(this AzureAmsTransformOutputAddSettings toolSettings, IEnumerable<AmsTransformPresetNames> presetNames)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<AmsTransformPresetNames>(presetNames);
            toolSettings.PresetNamesInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAmsTransformOutputAddSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAmsTransformOutputAddSettings SetResourceGroup(this AzureAmsTransformOutputAddSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsTransformOutputAddSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAmsTransformOutputAddSettings ResetResourceGroup(this AzureAmsTransformOutputAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAmsTransformOutputAddSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAmsTransformOutputAddSettings SetDebug(this AzureAmsTransformOutputAddSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsTransformOutputAddSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAmsTransformOutputAddSettings ResetDebug(this AzureAmsTransformOutputAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAmsTransformOutputAddSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAmsTransformOutputAddSettings SetHelp(this AzureAmsTransformOutputAddSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsTransformOutputAddSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAmsTransformOutputAddSettings ResetHelp(this AzureAmsTransformOutputAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAmsTransformOutputAddSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAmsTransformOutputAddSettings SetOutput(this AzureAmsTransformOutputAddSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsTransformOutputAddSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAmsTransformOutputAddSettings ResetOutput(this AzureAmsTransformOutputAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAmsTransformOutputAddSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAmsTransformOutputAddSettings SetQuery(this AzureAmsTransformOutputAddSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsTransformOutputAddSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAmsTransformOutputAddSettings ResetQuery(this AzureAmsTransformOutputAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAmsTransformOutputAddSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAmsTransformOutputAddSettings SetVerbose(this AzureAmsTransformOutputAddSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsTransformOutputAddSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAmsTransformOutputAddSettings ResetVerbose(this AzureAmsTransformOutputAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAmsTransformOutputRemoveSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAmsTransformOutputRemoveSettingsExtensions
    {
        #region AccountName
        /// <summary><p><em>Sets <see cref="AzureAmsTransformOutputRemoveSettings.AccountName"/>.</em></p><p>The name of the Azure Media Services account.</p></summary>
        [Pure]
        public static AzureAmsTransformOutputRemoveSettings SetAccountName(this AzureAmsTransformOutputRemoveSettings toolSettings, string accountName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = accountName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsTransformOutputRemoveSettings.AccountName"/>.</em></p><p>The name of the Azure Media Services account.</p></summary>
        [Pure]
        public static AzureAmsTransformOutputRemoveSettings ResetAccountName(this AzureAmsTransformOutputRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAmsTransformOutputRemoveSettings.Name"/>.</em></p><p>The name of the transform.</p></summary>
        [Pure]
        public static AzureAmsTransformOutputRemoveSettings SetName(this AzureAmsTransformOutputRemoveSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsTransformOutputRemoveSettings.Name"/>.</em></p><p>The name of the transform.</p></summary>
        [Pure]
        public static AzureAmsTransformOutputRemoveSettings ResetName(this AzureAmsTransformOutputRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region PresetNames
        /// <summary><p><em>Sets <see cref="AzureAmsTransformOutputRemoveSettings.PresetNames"/> to a new list.</em></p><p>Space-separated list of built-in preset names.</p></summary>
        [Pure]
        public static AzureAmsTransformOutputRemoveSettings SetPresetNames(this AzureAmsTransformOutputRemoveSettings toolSettings, params AmsTransformPresetNames[] presetNames)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PresetNamesInternal = presetNames.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureAmsTransformOutputRemoveSettings.PresetNames"/> to a new list.</em></p><p>Space-separated list of built-in preset names.</p></summary>
        [Pure]
        public static AzureAmsTransformOutputRemoveSettings SetPresetNames(this AzureAmsTransformOutputRemoveSettings toolSettings, IEnumerable<AmsTransformPresetNames> presetNames)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PresetNamesInternal = presetNames.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureAmsTransformOutputRemoveSettings.PresetNames"/>.</em></p><p>Space-separated list of built-in preset names.</p></summary>
        [Pure]
        public static AzureAmsTransformOutputRemoveSettings AddPresetNames(this AzureAmsTransformOutputRemoveSettings toolSettings, params AmsTransformPresetNames[] presetNames)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PresetNamesInternal.AddRange(presetNames);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureAmsTransformOutputRemoveSettings.PresetNames"/>.</em></p><p>Space-separated list of built-in preset names.</p></summary>
        [Pure]
        public static AzureAmsTransformOutputRemoveSettings AddPresetNames(this AzureAmsTransformOutputRemoveSettings toolSettings, IEnumerable<AmsTransformPresetNames> presetNames)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PresetNamesInternal.AddRange(presetNames);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureAmsTransformOutputRemoveSettings.PresetNames"/>.</em></p><p>Space-separated list of built-in preset names.</p></summary>
        [Pure]
        public static AzureAmsTransformOutputRemoveSettings ClearPresetNames(this AzureAmsTransformOutputRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PresetNamesInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureAmsTransformOutputRemoveSettings.PresetNames"/>.</em></p><p>Space-separated list of built-in preset names.</p></summary>
        [Pure]
        public static AzureAmsTransformOutputRemoveSettings RemovePresetNames(this AzureAmsTransformOutputRemoveSettings toolSettings, params AmsTransformPresetNames[] presetNames)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<AmsTransformPresetNames>(presetNames);
            toolSettings.PresetNamesInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureAmsTransformOutputRemoveSettings.PresetNames"/>.</em></p><p>Space-separated list of built-in preset names.</p></summary>
        [Pure]
        public static AzureAmsTransformOutputRemoveSettings RemovePresetNames(this AzureAmsTransformOutputRemoveSettings toolSettings, IEnumerable<AmsTransformPresetNames> presetNames)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<AmsTransformPresetNames>(presetNames);
            toolSettings.PresetNamesInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAmsTransformOutputRemoveSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAmsTransformOutputRemoveSettings SetResourceGroup(this AzureAmsTransformOutputRemoveSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsTransformOutputRemoveSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAmsTransformOutputRemoveSettings ResetResourceGroup(this AzureAmsTransformOutputRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAmsTransformOutputRemoveSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAmsTransformOutputRemoveSettings SetDebug(this AzureAmsTransformOutputRemoveSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsTransformOutputRemoveSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAmsTransformOutputRemoveSettings ResetDebug(this AzureAmsTransformOutputRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAmsTransformOutputRemoveSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAmsTransformOutputRemoveSettings SetHelp(this AzureAmsTransformOutputRemoveSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsTransformOutputRemoveSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAmsTransformOutputRemoveSettings ResetHelp(this AzureAmsTransformOutputRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAmsTransformOutputRemoveSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAmsTransformOutputRemoveSettings SetOutput(this AzureAmsTransformOutputRemoveSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsTransformOutputRemoveSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAmsTransformOutputRemoveSettings ResetOutput(this AzureAmsTransformOutputRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAmsTransformOutputRemoveSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAmsTransformOutputRemoveSettings SetQuery(this AzureAmsTransformOutputRemoveSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsTransformOutputRemoveSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAmsTransformOutputRemoveSettings ResetQuery(this AzureAmsTransformOutputRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAmsTransformOutputRemoveSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAmsTransformOutputRemoveSettings SetVerbose(this AzureAmsTransformOutputRemoveSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAmsTransformOutputRemoveSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAmsTransformOutputRemoveSettings ResetVerbose(this AzureAmsTransformOutputRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AmsAssetGetSasUrlsPermissions
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    public partial class AmsAssetGetSasUrlsPermissions : Enumeration
    {
        public static AmsAssetGetSasUrlsPermissions read = new AmsAssetGetSasUrlsPermissions { Value = "read" };
        public static AmsAssetGetSasUrlsPermissions readwrite = new AmsAssetGetSasUrlsPermissions { Value = "readwrite" };
        public static AmsAssetGetSasUrlsPermissions readwritedelete = new AmsAssetGetSasUrlsPermissions { Value = "readwritedelete" };
    }
    #endregion
    #region AmsJobStartPriority
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    public partial class AmsJobStartPriority : Enumeration
    {
        public static AmsJobStartPriority high = new AmsJobStartPriority { Value = "high" };
        public static AmsJobStartPriority low = new AmsJobStartPriority { Value = "low" };
        public static AmsJobStartPriority normal = new AmsJobStartPriority { Value = "normal" };
    }
    #endregion
    #region AmsTransformPresetNames
    /// <summary><p>Used within <see cref="AzureAmsTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    public partial class AmsTransformPresetNames : Enumeration
    {
        public static AmsTransformPresetNames aacgoodqualityaudio = new AmsTransformPresetNames { Value = "aacgoodqualityaudio" };
        public static AmsTransformPresetNames adaptivestreaming = new AmsTransformPresetNames { Value = "adaptivestreaming" };
        public static AmsTransformPresetNames audioanalyzer = new AmsTransformPresetNames { Value = "audioanalyzer" };
        public static AmsTransformPresetNames h264multiplebitrate1080p = new AmsTransformPresetNames { Value = "h264multiplebitrate1080p" };
        public static AmsTransformPresetNames h264multiplebitrate720p = new AmsTransformPresetNames { Value = "h264multiplebitrate720p" };
        public static AmsTransformPresetNames h264multiplebitratesd = new AmsTransformPresetNames { Value = "h264multiplebitratesd" };
        public static AmsTransformPresetNames videoanalyzer = new AmsTransformPresetNames { Value = "videoanalyzer" };
    }
    #endregion
}
