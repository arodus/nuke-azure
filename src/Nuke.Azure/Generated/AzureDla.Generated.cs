// Copyright Matthias Koch, Sebastian Karasek 2018.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

// Generated with Nuke.CodeGeneration, Version: 0.6.2 [CommitSha: ff25463a].
// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/AzureDla.json.

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
    public static partial class AzureDlaTasks
    {
        /// <summary><p>Path to the AzureDla executable.</p></summary>
        public static string AzureDlaPath => ToolPathResolver.GetPathExecutable("az");
        /// <summary><p>(PREVIEW) Manage Data Lake Analytics accounts, jobs, and catalogs.</p></summary>
        public static IReadOnlyCollection<Output> AzureDla(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool logOutput = true, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzureDlaPath, arguments, workingDirectory, environmentVariables, timeout, logOutput, null, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Analytics accounts, jobs, and catalogs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dla?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDla(Configure<AzureDlaSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlaSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Analytics accounts, jobs, and catalogs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dla?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlaAccountCreate(Configure<AzureDlaAccountCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlaAccountCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Analytics accounts, jobs, and catalogs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dla?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlaAccountDelete(Configure<AzureDlaAccountDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlaAccountDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Analytics accounts, jobs, and catalogs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dla?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlaAccountList(Configure<AzureDlaAccountListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlaAccountListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Analytics accounts, jobs, and catalogs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dla?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlaAccountShow(Configure<AzureDlaAccountShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlaAccountShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Analytics accounts, jobs, and catalogs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dla?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlaAccountUpdate(Configure<AzureDlaAccountUpdateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlaAccountUpdateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Analytics accounts, jobs, and catalogs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dla?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlaCatalog(Configure<AzureDlaCatalogSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlaCatalogSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Analytics accounts, jobs, and catalogs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dla?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlaJobCancel(Configure<AzureDlaJobCancelSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlaJobCancelSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Analytics accounts, jobs, and catalogs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dla?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlaJobList(Configure<AzureDlaJobListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlaJobListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Analytics accounts, jobs, and catalogs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dla?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlaJobShow(Configure<AzureDlaJobShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlaJobShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Analytics accounts, jobs, and catalogs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dla?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlaJobSubmit(Configure<AzureDlaJobSubmitSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlaJobSubmitSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Analytics accounts, jobs, and catalogs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dla?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlaJobWait(Configure<AzureDlaJobWaitSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlaJobWaitSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Analytics accounts, jobs, and catalogs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dla?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlaAccountBlobStorageAdd(Configure<AzureDlaAccountBlobStorageAddSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlaAccountBlobStorageAddSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Analytics accounts, jobs, and catalogs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dla?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlaAccountBlobStorageDelete(Configure<AzureDlaAccountBlobStorageDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlaAccountBlobStorageDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Analytics accounts, jobs, and catalogs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dla?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlaAccountBlobStorageList(Configure<AzureDlaAccountBlobStorageListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlaAccountBlobStorageListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Analytics accounts, jobs, and catalogs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dla?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlaAccountBlobStorageShow(Configure<AzureDlaAccountBlobStorageShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlaAccountBlobStorageShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Analytics accounts, jobs, and catalogs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dla?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlaAccountBlobStorageUpdate(Configure<AzureDlaAccountBlobStorageUpdateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlaAccountBlobStorageUpdateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Analytics accounts, jobs, and catalogs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dla?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlaAccountComputePolicyCreate(Configure<AzureDlaAccountComputePolicyCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlaAccountComputePolicyCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Analytics accounts, jobs, and catalogs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dla?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlaAccountComputePolicyDelete(Configure<AzureDlaAccountComputePolicyDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlaAccountComputePolicyDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Analytics accounts, jobs, and catalogs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dla?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlaAccountComputePolicyList(Configure<AzureDlaAccountComputePolicyListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlaAccountComputePolicyListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Analytics accounts, jobs, and catalogs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dla?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlaAccountComputePolicyShow(Configure<AzureDlaAccountComputePolicyShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlaAccountComputePolicyShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Analytics accounts, jobs, and catalogs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dla?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlaAccountComputePolicyUpdate(Configure<AzureDlaAccountComputePolicyUpdateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlaAccountComputePolicyUpdateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Analytics accounts, jobs, and catalogs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dla?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlaAccountDataLakeStoreAdd(Configure<AzureDlaAccountDataLakeStoreAddSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlaAccountDataLakeStoreAddSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Analytics accounts, jobs, and catalogs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dla?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlaAccountDataLakeStoreDelete(Configure<AzureDlaAccountDataLakeStoreDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlaAccountDataLakeStoreDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Analytics accounts, jobs, and catalogs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dla?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlaAccountDataLakeStoreList(Configure<AzureDlaAccountDataLakeStoreListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlaAccountDataLakeStoreListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Analytics accounts, jobs, and catalogs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dla?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlaAccountDataLakeStoreShow(Configure<AzureDlaAccountDataLakeStoreShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlaAccountDataLakeStoreShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Analytics accounts, jobs, and catalogs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dla?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlaAccountFirewallCreate(Configure<AzureDlaAccountFirewallCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlaAccountFirewallCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Analytics accounts, jobs, and catalogs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dla?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlaAccountFirewallDelete(Configure<AzureDlaAccountFirewallDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlaAccountFirewallDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Analytics accounts, jobs, and catalogs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dla?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlaAccountFirewallList(Configure<AzureDlaAccountFirewallListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlaAccountFirewallListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Analytics accounts, jobs, and catalogs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dla?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlaAccountFirewallShow(Configure<AzureDlaAccountFirewallShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlaAccountFirewallShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Analytics accounts, jobs, and catalogs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dla?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlaAccountFirewallUpdate(Configure<AzureDlaAccountFirewallUpdateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlaAccountFirewallUpdateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Analytics accounts, jobs, and catalogs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dla?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlaCatalogAssemblyList(Configure<AzureDlaCatalogAssemblyListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlaCatalogAssemblyListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Analytics accounts, jobs, and catalogs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dla?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlaCatalogAssemblyShow(Configure<AzureDlaCatalogAssemblyShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlaCatalogAssemblyShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Analytics accounts, jobs, and catalogs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dla?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlaCatalogCredentialCreate(Configure<AzureDlaCatalogCredentialCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlaCatalogCredentialCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Analytics accounts, jobs, and catalogs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dla?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlaCatalogCredentialDelete(Configure<AzureDlaCatalogCredentialDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlaCatalogCredentialDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Analytics accounts, jobs, and catalogs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dla?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlaCatalogCredentialList(Configure<AzureDlaCatalogCredentialListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlaCatalogCredentialListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Analytics accounts, jobs, and catalogs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dla?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlaCatalogCredentialShow(Configure<AzureDlaCatalogCredentialShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlaCatalogCredentialShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Analytics accounts, jobs, and catalogs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dla?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlaCatalogCredentialUpdate(Configure<AzureDlaCatalogCredentialUpdateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlaCatalogCredentialUpdateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Analytics accounts, jobs, and catalogs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dla?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlaCatalogDatabaseList(Configure<AzureDlaCatalogDatabaseListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlaCatalogDatabaseListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Analytics accounts, jobs, and catalogs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dla?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlaCatalogDatabaseShow(Configure<AzureDlaCatalogDatabaseShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlaCatalogDatabaseShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Analytics accounts, jobs, and catalogs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dla?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlaCatalogExternalDataSourceList(Configure<AzureDlaCatalogExternalDataSourceListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlaCatalogExternalDataSourceListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Analytics accounts, jobs, and catalogs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dla?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlaCatalogExternalDataSourceShow(Configure<AzureDlaCatalogExternalDataSourceShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlaCatalogExternalDataSourceShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Analytics accounts, jobs, and catalogs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dla?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlaCatalogPackageList(Configure<AzureDlaCatalogPackageListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlaCatalogPackageListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Analytics accounts, jobs, and catalogs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dla?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlaCatalogPackageShow(Configure<AzureDlaCatalogPackageShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlaCatalogPackageShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Analytics accounts, jobs, and catalogs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dla?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlaCatalogProcedureList(Configure<AzureDlaCatalogProcedureListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlaCatalogProcedureListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Analytics accounts, jobs, and catalogs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dla?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlaCatalogProcedureShow(Configure<AzureDlaCatalogProcedureShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlaCatalogProcedureShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Analytics accounts, jobs, and catalogs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dla?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlaCatalogSchemaList(Configure<AzureDlaCatalogSchemaListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlaCatalogSchemaListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Analytics accounts, jobs, and catalogs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dla?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlaCatalogSchemaShow(Configure<AzureDlaCatalogSchemaShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlaCatalogSchemaShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Analytics accounts, jobs, and catalogs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dla?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlaCatalogTablePartitionList(Configure<AzureDlaCatalogTablePartitionListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlaCatalogTablePartitionListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Analytics accounts, jobs, and catalogs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dla?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlaCatalogTablePartitionShow(Configure<AzureDlaCatalogTablePartitionShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlaCatalogTablePartitionShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Analytics accounts, jobs, and catalogs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dla?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlaCatalogTableStatsList(Configure<AzureDlaCatalogTableStatsListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlaCatalogTableStatsListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Analytics accounts, jobs, and catalogs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dla?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlaCatalogTableStatsShow(Configure<AzureDlaCatalogTableStatsShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlaCatalogTableStatsShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Analytics accounts, jobs, and catalogs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dla?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlaCatalogTableTypeList(Configure<AzureDlaCatalogTableTypeListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlaCatalogTableTypeListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Analytics accounts, jobs, and catalogs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dla?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlaCatalogTableTypeShow(Configure<AzureDlaCatalogTableTypeShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlaCatalogTableTypeShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Analytics accounts, jobs, and catalogs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dla?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlaCatalogTableList(Configure<AzureDlaCatalogTableListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlaCatalogTableListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Analytics accounts, jobs, and catalogs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dla?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlaCatalogTableShow(Configure<AzureDlaCatalogTableShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlaCatalogTableShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Analytics accounts, jobs, and catalogs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dla?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlaCatalogTvfList(Configure<AzureDlaCatalogTvfListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlaCatalogTvfListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Analytics accounts, jobs, and catalogs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dla?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlaCatalogTvfShow(Configure<AzureDlaCatalogTvfShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlaCatalogTvfShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Analytics accounts, jobs, and catalogs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dla?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlaCatalogViewList(Configure<AzureDlaCatalogViewListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlaCatalogViewListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Analytics accounts, jobs, and catalogs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dla?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlaCatalogViewShow(Configure<AzureDlaCatalogViewShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlaCatalogViewShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Analytics accounts, jobs, and catalogs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dla?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlaJobPipelineList(Configure<AzureDlaJobPipelineListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlaJobPipelineListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Analytics accounts, jobs, and catalogs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dla?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlaJobPipelineShow(Configure<AzureDlaJobPipelineShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlaJobPipelineShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Analytics accounts, jobs, and catalogs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dla?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlaJobRecurrenceList(Configure<AzureDlaJobRecurrenceListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlaJobRecurrenceListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Analytics accounts, jobs, and catalogs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dla?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlaJobRecurrenceShow(Configure<AzureDlaJobRecurrenceShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlaJobRecurrenceShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
    }
    #region AzureDlaSettings
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlaSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDla executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlaTasks.AzureDlaPath;
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("dla")
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureDlaAccountCreateSettings
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlaAccountCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDla executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlaTasks.AzureDlaPath;
        /// <summary><p>Name of the Data Lake Analytics account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>The default Data Lake Store account to associate with the created account.</p></summary>
        public virtual string DefaultDataLakeStore { get; internal set; }
        /// <summary><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        public virtual string Location { get; internal set; }
        /// <summary><p>The maximum degree of parallelism for this account.</p></summary>
        public virtual string MaxDegreeOfParallelism { get; internal set; }
        /// <summary><p>The maximum number of concurrent jobs for this account.</p></summary>
        public virtual int? MaxJobCount { get; internal set; }
        /// <summary><p>The number of days to retain job metadata.</p></summary>
        public virtual string QueryStoreRetention { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        public virtual string Tags { get; internal set; }
        /// <summary><p>The desired commitment tier for this account to use.</p></summary>
        public virtual DlaAccountTier Tier { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("dla account create")
              .Add("--account {value}", Account)
              .Add("--default-data-lake-store {value}", DefaultDataLakeStore)
              .Add("--location {value}", Location)
              .Add("--max-degree-of-parallelism {value}", MaxDegreeOfParallelism)
              .Add("--max-job-count {value}", MaxJobCount)
              .Add("--query-store-retention {value}", QueryStoreRetention)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--tags {value}", Tags)
              .Add("--tier {value}", Tier)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureDlaAccountDeleteSettings
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlaAccountDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDla executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlaTasks.AzureDlaPath;
        /// <summary><p>Name of the Data Lake Analytics account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>If not specified, will attempt to discover the resource group for the specified Data Lake Analytics account.</p></summary>
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
              .Add("dla account delete")
              .Add("--account {value}", Account)
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
    #region AzureDlaAccountListSettings
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlaAccountListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDla executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlaTasks.AzureDlaPath;
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
              .Add("dla account list")
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
    #region AzureDlaAccountShowSettings
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlaAccountShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDla executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlaTasks.AzureDlaPath;
        /// <summary><p>Name of the Data Lake Analytics account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>If not specified, will attempt to discover the resource group for the specified Data Lake Analytics account.</p></summary>
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
              .Add("dla account show")
              .Add("--account {value}", Account)
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
    #region AzureDlaAccountUpdateSettings
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlaAccountUpdateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDla executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlaTasks.AzureDlaPath;
        /// <summary><p>Name of the Data Lake Analytics account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>Allow or block IPs originating from Azure through the firewall.</p></summary>
        public virtual DlaAccountUpdateAllowAzureIps AllowAzureIps { get; internal set; }
        /// <summary><p>Enable or disable existing firewall rules.</p></summary>
        public virtual DlaAccountUpdateAllowAzureIps FirewallState { get; internal set; }
        /// <summary><p>The maximum degree of parallelism for this account.</p></summary>
        public virtual string MaxDegreeOfParallelism { get; internal set; }
        /// <summary><p>The maximum number of concurrent jobs for this account.</p></summary>
        public virtual int? MaxJobCount { get; internal set; }
        /// <summary><p>The number of days to retain job metadata.</p></summary>
        public virtual string QueryStoreRetention { get; internal set; }
        /// <summary><p>If not specified, will attempt to discover the resource group for the specified Data Lake Analytics account.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        public virtual string Tags { get; internal set; }
        /// <summary><p>The desired commitment tier for this account to use.</p></summary>
        public virtual DlaAccountTier Tier { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("dla account update")
              .Add("--account {value}", Account)
              .Add("--allow-azure-ips {value}", AllowAzureIps)
              .Add("--firewall-state {value}", FirewallState)
              .Add("--max-degree-of-parallelism {value}", MaxDegreeOfParallelism)
              .Add("--max-job-count {value}", MaxJobCount)
              .Add("--query-store-retention {value}", QueryStoreRetention)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--tags {value}", Tags)
              .Add("--tier {value}", Tier)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureDlaCatalogSettings
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlaCatalogSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDla executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlaTasks.AzureDlaPath;
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("dla catalog")
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureDlaJobCancelSettings
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlaJobCancelSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDla executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlaTasks.AzureDlaPath;
        /// <summary><p>Name of the Data Lake Analytics account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>JobInfo ID to cancel.</p></summary>
        public virtual string JobIdentity { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("dla job cancel")
              .Add("--account {value}", Account)
              .Add("--job-identity {value}", JobIdentity)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureDlaJobListSettings
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlaJobListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDla executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlaTasks.AzureDlaPath;
        /// <summary><p>Name of the Data Lake Analytics account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>A filter which returns jobs only by the specified friendly name.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>A filter which returns jobs only containing the specified pipeline_id.</p></summary>
        public virtual string PipelineId { get; internal set; }
        /// <summary><p>A filter which returns jobs only containing the specified recurrence_id.</p></summary>
        public virtual string RecurrenceId { get; internal set; }
        /// <summary><p>A filter which returns jobs with only the specified result(s).</p></summary>
        public virtual DlaJobListResult Result { get; internal set; }
        /// <summary><p>A filter which returns jobs with only the specified state(s).</p></summary>
        public virtual DlaJobListState State { get; internal set; }
        /// <summary><p>A filter which returns jobs only submitted after the specified time, in ISO-8601 format.</p></summary>
        public virtual string SubmittedAfter { get; internal set; }
        /// <summary><p>A filter which returns jobs only submitted before the specified time, in ISO-8601 format.</p></summary>
        public virtual string SubmittedBefore { get; internal set; }
        /// <summary><p>A filter which returns jobs only by the specified submitter.</p></summary>
        public virtual string Submitter { get; internal set; }
        /// <summary><p>Maximum number of items to return.</p></summary>
        public virtual int? Top { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("dla job list")
              .Add("--account {value}", Account)
              .Add("--name {value}", Name)
              .Add("--pipeline-id {value}", PipelineId)
              .Add("--recurrence-id {value}", RecurrenceId)
              .Add("--result {value}", Result)
              .Add("--state {value}", State)
              .Add("--submitted-after {value}", SubmittedAfter)
              .Add("--submitted-before {value}", SubmittedBefore)
              .Add("--submitter {value}", Submitter)
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
    #region AzureDlaJobShowSettings
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlaJobShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDla executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlaTasks.AzureDlaPath;
        /// <summary><p>Name of the Data Lake Analytics account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>JobInfo ID.</p></summary>
        public virtual string JobIdentity { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("dla job show")
              .Add("--account {value}", Account)
              .Add("--job-identity {value}", JobIdentity)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureDlaJobSubmitSettings
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlaJobSubmitSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDla executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlaTasks.AzureDlaPath;
        /// <summary><p>Name of the Data Lake Analytics account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>Name for the submitted job.</p></summary>
        public virtual string JobName { get; internal set; }
        /// <summary><p>Script to submit. This may be '@{file}' to load from a file.</p></summary>
        public virtual string Script { get; internal set; }
        /// <summary><p>Indicates the type of compilation to be done on this job. Valid values are: 'Semantic' (Only performs semantic checks and necessary sanity checks), 'Full' (full compilation) and 'SingleBox' (Full compilation performed locally).</p></summary>
        public virtual DlaJobSubmitCompileMode CompileMode { get; internal set; }
        /// <summary><p>Indicates that the submission should only build the job and not execute if set to true.</p></summary>
        public virtual string CompileOnly { get; internal set; }
        /// <summary><p>The degree of parallelism for the job.</p></summary>
        public virtual string DegreeOfParallelism { get; internal set; }
        /// <summary><p></p></summary>
        public virtual string PipelineId { get; internal set; }
        /// <summary><p></p></summary>
        public virtual string PipelineName { get; internal set; }
        /// <summary><p></p></summary>
        public virtual string PipelineUri { get; internal set; }
        /// <summary><p>The priority of the job.</p></summary>
        public virtual int? Priority { get; internal set; }
        /// <summary><p></p></summary>
        public virtual string RecurrenceId { get; internal set; }
        /// <summary><p></p></summary>
        public virtual string RecurrenceName { get; internal set; }
        /// <summary><p></p></summary>
        public virtual string RunId { get; internal set; }
        /// <summary><p>The runtime version to use.</p></summary>
        public virtual string RuntimeVersion { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("dla job submit")
              .Add("--account {value}", Account)
              .Add("--job-name {value}", JobName)
              .Add("--script {value}", Script)
              .Add("--compile-mode {value}", CompileMode)
              .Add("--compile-only {value}", CompileOnly)
              .Add("--degree-of-parallelism {value}", DegreeOfParallelism)
              .Add("--pipeline-id {value}", PipelineId)
              .Add("--pipeline-name {value}", PipelineName)
              .Add("--pipeline-uri {value}", PipelineUri)
              .Add("--priority {value}", Priority)
              .Add("--recurrence-id {value}", RecurrenceId)
              .Add("--recurrence-name {value}", RecurrenceName)
              .Add("--run-id {value}", RunId)
              .Add("--runtime-version {value}", RuntimeVersion)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureDlaJobWaitSettings
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlaJobWaitSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDla executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlaTasks.AzureDlaPath;
        /// <summary><p>Name of the Data Lake Analytics account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>Job ID to poll for completion.</p></summary>
        public virtual string JobId { get; internal set; }
        /// <summary><p>The maximum amount of time to wait before erroring out. Default value is to never timeout. Any value &lt;= 0 means never timeout.</p></summary>
        public virtual string MaxWaitTimeSec { get; internal set; }
        /// <summary><p>The polling interval between checks for the job status, in seconds.</p></summary>
        public virtual string WaitIntervalSec { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("dla job wait")
              .Add("--account {value}", Account)
              .Add("--job-id {value}", JobId)
              .Add("--max-wait-time-sec {value}", MaxWaitTimeSec)
              .Add("--wait-interval-sec {value}", WaitIntervalSec)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureDlaAccountBlobStorageAddSettings
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlaAccountBlobStorageAddSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDla executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlaTasks.AzureDlaPath;
        /// <summary><p>The access key associated with this Azure Storage account that will be used to connect to it.</p></summary>
        public virtual string AccessKey { get; internal set; }
        /// <summary><p>Name of the Data Lake Analytics account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p></p></summary>
        public virtual string StorageAccountName { get; internal set; }
        /// <summary><p>If not specified, will attempt to discover the resource group for the specified Data Lake Analytics account.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The optional suffix for the storage account.</p></summary>
        public virtual string Suffix { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("dla account blob-storage add")
              .Add("--access-key {value}", AccessKey)
              .Add("--account {value}", Account)
              .Add("--storage-account-name {value}", StorageAccountName)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--suffix {value}", Suffix)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureDlaAccountBlobStorageDeleteSettings
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlaAccountBlobStorageDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDla executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlaTasks.AzureDlaPath;
        /// <summary><p>Name of the Data Lake Analytics account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>The name of the Azure Storage account to remove.</p></summary>
        public virtual string StorageAccountName { get; internal set; }
        /// <summary><p>If not specified, will attempt to discover the resource group for the specified Data Lake Analytics account.</p></summary>
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
              .Add("dla account blob-storage delete")
              .Add("--account {value}", Account)
              .Add("--storage-account-name {value}", StorageAccountName)
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
    #region AzureDlaAccountBlobStorageListSettings
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlaAccountBlobStorageListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDla executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlaTasks.AzureDlaPath;
        /// <summary><p>Name of the Data Lake Analytics account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>The Boolean value of true or false to request a count of the matching resources included with the resources in the response, e.g. Categories?$count=true.</p></summary>
        public virtual string Count { get; internal set; }
        /// <summary><p>The OData filter. Optional.</p></summary>
        public virtual string Filter { get; internal set; }
        /// <summary><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        public virtual IReadOnlyList<string> Orderby => OrderbyInternal.AsReadOnly();
        internal List<string> OrderbyInternal { get; set; } = new List<string>();
        /// <summary><p>If not specified, will attempt to discover the resource group for the specified Data Lake Analytics account.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>OData Select statement. Limits the properties on each entry to just those requested, e.g. Categories?$select=CategoryName,Description. Optional.</p></summary>
        public virtual string Select { get; internal set; }
        /// <summary><p>The number of items to skip over before returning elements.</p></summary>
        public virtual string Skip { get; internal set; }
        /// <summary><p>Maximum number of items to return.</p></summary>
        public virtual int? Top { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("dla account blob-storage list")
              .Add("--account {value}", Account)
              .Add("--count {value}", Count)
              .Add("--filter {value}", Filter)
              .Add("--orderby {value}", Orderby, separator: ',')
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--select {value}", Select)
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
    #region AzureDlaAccountBlobStorageShowSettings
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlaAccountBlobStorageShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDla executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlaTasks.AzureDlaPath;
        /// <summary><p>Name of the Data Lake Analytics account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>The name of the Azure Storage account for which to retrieve the details.</p></summary>
        public virtual string StorageAccountName { get; internal set; }
        /// <summary><p>If not specified, will attempt to discover the resource group for the specified Data Lake Analytics account.</p></summary>
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
              .Add("dla account blob-storage show")
              .Add("--account {value}", Account)
              .Add("--storage-account-name {value}", StorageAccountName)
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
    #region AzureDlaAccountBlobStorageUpdateSettings
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlaAccountBlobStorageUpdateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDla executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlaTasks.AzureDlaPath;
        /// <summary><p>The access key associated with this Azure Storage account that will be used to connect to it.</p></summary>
        public virtual string AccessKey { get; internal set; }
        /// <summary><p>Name of the Data Lake Analytics account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p></p></summary>
        public virtual string StorageAccountName { get; internal set; }
        /// <summary><p>If not specified, will attempt to discover the resource group for the specified Data Lake Analytics account.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The optional suffix for the storage account.</p></summary>
        public virtual string Suffix { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("dla account blob-storage update")
              .Add("--access-key {value}", AccessKey)
              .Add("--account {value}", Account)
              .Add("--storage-account-name {value}", StorageAccountName)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--suffix {value}", Suffix)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureDlaAccountComputePolicyCreateSettings
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlaAccountComputePolicyCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDla executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlaTasks.AzureDlaPath;
        /// <summary><p>Name of the Data Lake Analytics account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>The name of the compute policy to create.</p></summary>
        public virtual string ComputePolicyName { get; internal set; }
        /// <summary><p>The Azure Active Directory object ID of the user, group, or service principal to apply the policy to.</p></summary>
        public virtual string ObjectId { get; internal set; }
        /// <summary><p>The Azure Active Directory object type associated with the supplied object ID.</p></summary>
        public virtual string ObjectType { get; internal set; }
        /// <summary><p>The maximum degree of parallelism allowed per job for this policy. At least one of `--min-priority-per-job` and `--max-dop-per-job` must be specified.</p></summary>
        public virtual string MaxDopPerJob { get; internal set; }
        /// <summary><p>The minimum priority allowed per job for this policy. At least one of `--min-priority-per-job` and `--max-dop-per-job` must be specified.</p></summary>
        public virtual string MinPriorityPerJob { get; internal set; }
        /// <summary><p>If not specified, will attempt to discover the resource group for the specified Data Lake Analytics account.</p></summary>
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
              .Add("dla account compute-policy create")
              .Add("--account {value}", Account)
              .Add("--compute-policy-name {value}", ComputePolicyName)
              .Add("--object-id {value}", ObjectId)
              .Add("--object-type {value}", ObjectType)
              .Add("--max-dop-per-job {value}", MaxDopPerJob)
              .Add("--min-priority-per-job {value}", MinPriorityPerJob)
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
    #region AzureDlaAccountComputePolicyDeleteSettings
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlaAccountComputePolicyDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDla executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlaTasks.AzureDlaPath;
        /// <summary><p>Name of the Data Lake Analytics account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>The name of the compute policy to delete.</p></summary>
        public virtual string ComputePolicyName { get; internal set; }
        /// <summary><p>If not specified, will attempt to discover the resource group for the specified Data Lake Analytics account.</p></summary>
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
              .Add("dla account compute-policy delete")
              .Add("--account {value}", Account)
              .Add("--compute-policy-name {value}", ComputePolicyName)
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
    #region AzureDlaAccountComputePolicyListSettings
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlaAccountComputePolicyListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDla executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlaTasks.AzureDlaPath;
        /// <summary><p>Name of the Data Lake Analytics account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>If not specified, will attempt to discover the resource group for the specified Data Lake Analytics account.</p></summary>
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
              .Add("dla account compute-policy list")
              .Add("--account {value}", Account)
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
    #region AzureDlaAccountComputePolicyShowSettings
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlaAccountComputePolicyShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDla executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlaTasks.AzureDlaPath;
        /// <summary><p>Name of the Data Lake Analytics account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>The name of the compute policy to retrieve.</p></summary>
        public virtual string ComputePolicyName { get; internal set; }
        /// <summary><p>If not specified, will attempt to discover the resource group for the specified Data Lake Analytics account.</p></summary>
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
              .Add("dla account compute-policy show")
              .Add("--account {value}", Account)
              .Add("--compute-policy-name {value}", ComputePolicyName)
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
    #region AzureDlaAccountComputePolicyUpdateSettings
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlaAccountComputePolicyUpdateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDla executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlaTasks.AzureDlaPath;
        /// <summary><p>Name of the Data Lake Analytics account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>The name of the compute policy to update.</p></summary>
        public virtual string ComputePolicyName { get; internal set; }
        /// <summary><p>The maximum degree of parallelism allowed per job for this policy. At least one of `--min-priority-per-job` and `--max-dop-per-job` must be specified.</p></summary>
        public virtual string MaxDopPerJob { get; internal set; }
        /// <summary><p>The minimum priority allowed per job for this policy. At least one of `--min-priority-per-job` and `--max-dop-per-job` must be specified.</p></summary>
        public virtual string MinPriorityPerJob { get; internal set; }
        /// <summary><p>If not specified, will attempt to discover the resource group for the specified Data Lake Analytics account.</p></summary>
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
              .Add("dla account compute-policy update")
              .Add("--account {value}", Account)
              .Add("--compute-policy-name {value}", ComputePolicyName)
              .Add("--max-dop-per-job {value}", MaxDopPerJob)
              .Add("--min-priority-per-job {value}", MinPriorityPerJob)
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
    #region AzureDlaAccountDataLakeStoreAddSettings
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlaAccountDataLakeStoreAddSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDla executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlaTasks.AzureDlaPath;
        /// <summary><p>Name of the Data Lake Analytics account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>The name of the Data Lake Store account to add.</p></summary>
        public virtual string DataLakeStoreAccountName { get; internal set; }
        /// <summary><p>If not specified, will attempt to discover the resource group for the specified Data Lake Analytics account.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The optional suffix for the Data Lake Store account.</p></summary>
        public virtual string Suffix { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("dla account data-lake-store add")
              .Add("--account {value}", Account)
              .Add("--data-lake-store-account-name {value}", DataLakeStoreAccountName)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--suffix {value}", Suffix)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureDlaAccountDataLakeStoreDeleteSettings
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlaAccountDataLakeStoreDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDla executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlaTasks.AzureDlaPath;
        /// <summary><p>Name of the Data Lake Analytics account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>The name of the Data Lake Store account to remove.</p></summary>
        public virtual string DataLakeStoreAccountName { get; internal set; }
        /// <summary><p>If not specified, will attempt to discover the resource group for the specified Data Lake Analytics account.</p></summary>
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
              .Add("dla account data-lake-store delete")
              .Add("--account {value}", Account)
              .Add("--data-lake-store-account-name {value}", DataLakeStoreAccountName)
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
    #region AzureDlaAccountDataLakeStoreListSettings
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlaAccountDataLakeStoreListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDla executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlaTasks.AzureDlaPath;
        /// <summary><p>Name of the Data Lake Analytics account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>The Boolean value of true or false to request a count of the matching resources included with the resources in the response, e.g. Categories?$count=true.</p></summary>
        public virtual string Count { get; internal set; }
        /// <summary><p>OData filter. Optional.</p></summary>
        public virtual string Filter { get; internal set; }
        /// <summary><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        public virtual IReadOnlyList<string> Orderby => OrderbyInternal.AsReadOnly();
        internal List<string> OrderbyInternal { get; set; } = new List<string>();
        /// <summary><p>If not specified, will attempt to discover the resource group for the specified Data Lake Analytics account.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>OData Select statement. Limits the properties on each entry to just those requested, e.g. Categories?$select=CategoryName,Description. Optional.</p></summary>
        public virtual string Select { get; internal set; }
        /// <summary><p>The number of items to skip over before returning elements.</p></summary>
        public virtual string Skip { get; internal set; }
        /// <summary><p>Maximum number of items to return.</p></summary>
        public virtual int? Top { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("dla account data-lake-store list")
              .Add("--account {value}", Account)
              .Add("--count {value}", Count)
              .Add("--filter {value}", Filter)
              .Add("--orderby {value}", Orderby, separator: ',')
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--select {value}", Select)
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
    #region AzureDlaAccountDataLakeStoreShowSettings
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlaAccountDataLakeStoreShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDla executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlaTasks.AzureDlaPath;
        /// <summary><p>Name of the Data Lake Analytics account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>The name of the Data Lake Store account to retrieve.</p></summary>
        public virtual string DataLakeStoreAccountName { get; internal set; }
        /// <summary><p>If not specified, will attempt to discover the resource group for the specified Data Lake Analytics account.</p></summary>
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
              .Add("dla account data-lake-store show")
              .Add("--account {value}", Account)
              .Add("--data-lake-store-account-name {value}", DataLakeStoreAccountName)
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
    #region AzureDlaAccountFirewallCreateSettings
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlaAccountFirewallCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDla executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlaTasks.AzureDlaPath;
        /// <summary><p>Name of the Data Lake Analytics account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>The end of the valid IP range for the firewall rule.</p></summary>
        public virtual string EndIpAddress { get; internal set; }
        /// <summary><p>The name of the firewall rule.</p></summary>
        public virtual string FirewallRuleName { get; internal set; }
        /// <summary><p>The start of the valid IP range for the firewall rule.</p></summary>
        public virtual string StartIpAddress { get; internal set; }
        /// <summary><p>If not specified, will attempt to discover the resource group for the specified Data Lake Analytics account.</p></summary>
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
              .Add("dla account firewall create")
              .Add("--account {value}", Account)
              .Add("--end-ip-address {value}", EndIpAddress)
              .Add("--firewall-rule-name {value}", FirewallRuleName)
              .Add("--start-ip-address {value}", StartIpAddress)
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
    #region AzureDlaAccountFirewallDeleteSettings
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlaAccountFirewallDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDla executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlaTasks.AzureDlaPath;
        /// <summary><p>Name of the Data Lake Analytics account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>The name of the firewall rule to delete.</p></summary>
        public virtual string FirewallRuleName { get; internal set; }
        /// <summary><p>If not specified, will attempt to discover the resource group for the specified Data Lake Analytics account.</p></summary>
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
              .Add("dla account firewall delete")
              .Add("--account {value}", Account)
              .Add("--firewall-rule-name {value}", FirewallRuleName)
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
    #region AzureDlaAccountFirewallListSettings
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlaAccountFirewallListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDla executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlaTasks.AzureDlaPath;
        /// <summary><p>Name of the Data Lake Analytics account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>If not specified, will attempt to discover the resource group for the specified Data Lake Analytics account.</p></summary>
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
              .Add("dla account firewall list")
              .Add("--account {value}", Account)
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
    #region AzureDlaAccountFirewallShowSettings
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlaAccountFirewallShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDla executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlaTasks.AzureDlaPath;
        /// <summary><p>Name of the Data Lake Analytics account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>The name of the firewall rule to retrieve.</p></summary>
        public virtual string FirewallRuleName { get; internal set; }
        /// <summary><p>If not specified, will attempt to discover the resource group for the specified Data Lake Analytics account.</p></summary>
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
              .Add("dla account firewall show")
              .Add("--account {value}", Account)
              .Add("--firewall-rule-name {value}", FirewallRuleName)
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
    #region AzureDlaAccountFirewallUpdateSettings
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlaAccountFirewallUpdateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDla executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlaTasks.AzureDlaPath;
        /// <summary><p>Name of the Data Lake Analytics account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>The name of the firewall rule to update.</p></summary>
        public virtual string FirewallRuleName { get; internal set; }
        /// <summary><p>The end IP address for the firewall rule. This can be either ipv4 or ipv6. Start and End should be in the same protocol.</p></summary>
        public virtual string EndIpAddress { get; internal set; }
        /// <summary><p>If not specified, will attempt to discover the resource group for the specified Data Lake Analytics account.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The start IP address for the firewall rule. This can be either ipv4 or ipv6. Start and End should be in the same protocol.</p></summary>
        public virtual string StartIpAddress { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("dla account firewall update")
              .Add("--account {value}", Account)
              .Add("--firewall-rule-name {value}", FirewallRuleName)
              .Add("--end-ip-address {value}", EndIpAddress)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--start-ip-address {value}", StartIpAddress)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureDlaCatalogAssemblyListSettings
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlaCatalogAssemblyListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDla executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlaTasks.AzureDlaPath;
        /// <summary><p>Name of the Data Lake Analytics account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>The name of the database containing the assembly.</p></summary>
        public virtual string DatabaseName { get; internal set; }
        /// <summary><p>The Boolean value of true or false to request a count of the matching resources included with the resources in the response, e.g. Categories?$count=true.</p></summary>
        public virtual string Count { get; internal set; }
        /// <summary><p>OData filter. Optional.</p></summary>
        public virtual string Filter { get; internal set; }
        /// <summary><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        public virtual IReadOnlyList<string> Orderby => OrderbyInternal.AsReadOnly();
        internal List<string> OrderbyInternal { get; set; } = new List<string>();
        /// <summary><p>OData Select statement. Limits the properties on each entry to just those requested, e.g. Categories?$select=CategoryName,Description. Optional.</p></summary>
        public virtual string Select { get; internal set; }
        /// <summary><p>The number of items to skip over before returning elements.</p></summary>
        public virtual string Skip { get; internal set; }
        /// <summary><p>Maximum number of items to return.</p></summary>
        public virtual int? Top { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("dla catalog assembly list")
              .Add("--account {value}", Account)
              .Add("--database-name {value}", DatabaseName)
              .Add("--count {value}", Count)
              .Add("--filter {value}", Filter)
              .Add("--orderby {value}", Orderby, separator: ',')
              .Add("--select {value}", Select)
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
    #region AzureDlaCatalogAssemblyShowSettings
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlaCatalogAssemblyShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDla executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlaTasks.AzureDlaPath;
        /// <summary><p>Name of the Data Lake Analytics account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>The name of the assembly.</p></summary>
        public virtual string AssemblyName { get; internal set; }
        /// <summary><p>The name of the database containing the assembly.</p></summary>
        public virtual string DatabaseName { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("dla catalog assembly show")
              .Add("--account {value}", Account)
              .Add("--assembly-name {value}", AssemblyName)
              .Add("--database-name {value}", DatabaseName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureDlaCatalogCredentialCreateSettings
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlaCatalogCredentialCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDla executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlaTasks.AzureDlaPath;
        /// <summary><p>Name of the Data Lake Analytics account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>The name of the credential.</p></summary>
        public virtual string CredentialName { get; internal set; }
        /// <summary><p>The name of the database in which to create the credential.</p></summary>
        public virtual string DatabaseName { get; internal set; }
        /// <summary><p></p></summary>
        public virtual string Uri { get; internal set; }
        /// <summary><p>The user name that will be used when authenticating with this credential.</p></summary>
        public virtual string UserName { get; internal set; }
        /// <summary><p>Password for the credential user. Will prompt if not given.</p></summary>
        public virtual string Password { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("dla catalog credential create")
              .Add("--account {value}", Account)
              .Add("--credential-name {value}", CredentialName)
              .Add("--database-name {value}", DatabaseName)
              .Add("--uri {value}", Uri)
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
    #region AzureDlaCatalogCredentialDeleteSettings
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlaCatalogCredentialDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDla executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlaTasks.AzureDlaPath;
        /// <summary><p>Name of the Data Lake Analytics account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>The name of the credential to delete.</p></summary>
        public virtual string CredentialName { get; internal set; }
        /// <summary><p>The name of the database containing the credential.</p></summary>
        public virtual string DatabaseName { get; internal set; }
        /// <summary><p>Indicates if the delete should be a cascading delete (which deletes all resources dependent on the credential as well as the credential) or not. If false will fail if there are any resources relying on the credential.</p></summary>
        public virtual string Cascade { get; internal set; }
        /// <summary><p>The current password for the credential and user with access to the data source. This is required if the requester is not the account owner.</p></summary>
        public virtual string Password { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("dla catalog credential delete")
              .Add("--account {value}", Account)
              .Add("--credential-name {value}", CredentialName)
              .Add("--database-name {value}", DatabaseName)
              .Add("--cascade {value}", Cascade)
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
    #region AzureDlaCatalogCredentialListSettings
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlaCatalogCredentialListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDla executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlaTasks.AzureDlaPath;
        /// <summary><p>Name of the Data Lake Analytics account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>The name of the database containing the schema.</p></summary>
        public virtual string DatabaseName { get; internal set; }
        /// <summary><p>The Boolean value of true or false to request a count of the matching resources included with the resources in the response, e.g. Categories?$count=true.</p></summary>
        public virtual string Count { get; internal set; }
        /// <summary><p>OData filter. Optional.</p></summary>
        public virtual string Filter { get; internal set; }
        /// <summary><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        public virtual IReadOnlyList<string> Orderby => OrderbyInternal.AsReadOnly();
        internal List<string> OrderbyInternal { get; set; } = new List<string>();
        /// <summary><p>OData Select statement. Limits the properties on each entry to just those requested, e.g. Categories?$select=CategoryName,Description. Optional.</p></summary>
        public virtual string Select { get; internal set; }
        /// <summary><p>The number of items to skip over before returning elements.</p></summary>
        public virtual string Skip { get; internal set; }
        /// <summary><p>Maximum number of items to return.</p></summary>
        public virtual int? Top { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("dla catalog credential list")
              .Add("--account {value}", Account)
              .Add("--database-name {value}", DatabaseName)
              .Add("--count {value}", Count)
              .Add("--filter {value}", Filter)
              .Add("--orderby {value}", Orderby, separator: ',')
              .Add("--select {value}", Select)
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
    #region AzureDlaCatalogCredentialShowSettings
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlaCatalogCredentialShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDla executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlaTasks.AzureDlaPath;
        /// <summary><p>Name of the Data Lake Analytics account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>The name of the credential.</p></summary>
        public virtual string CredentialName { get; internal set; }
        /// <summary><p>The name of the database containing the schema.</p></summary>
        public virtual string DatabaseName { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("dla catalog credential show")
              .Add("--account {value}", Account)
              .Add("--credential-name {value}", CredentialName)
              .Add("--database-name {value}", DatabaseName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureDlaCatalogCredentialUpdateSettings
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlaCatalogCredentialUpdateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDla executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlaTasks.AzureDlaPath;
        /// <summary><p>Name of the Data Lake Analytics account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>The name of the credential to update.</p></summary>
        public virtual string CredentialName { get; internal set; }
        /// <summary><p>The name of the database in which the credential exists.</p></summary>
        public virtual string DatabaseName { get; internal set; }
        /// <summary><p></p></summary>
        public virtual string Uri { get; internal set; }
        /// <summary><p>The user name associated with the credential that will have its password updated.</p></summary>
        public virtual string UserName { get; internal set; }
        /// <summary><p>New password for the credential user. Will prompt if not given.</p></summary>
        public virtual string NewPassword { get; internal set; }
        /// <summary><p>Current password for the credential user. Will prompt if not given.</p></summary>
        public virtual string Password { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("dla catalog credential update")
              .Add("--account {value}", Account)
              .Add("--credential-name {value}", CredentialName)
              .Add("--database-name {value}", DatabaseName)
              .Add("--uri {value}", Uri)
              .Add("--user-name {value}", UserName)
              .Add("--new-password {value}", NewPassword, secret: true)
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
    #region AzureDlaCatalogDatabaseListSettings
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlaCatalogDatabaseListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDla executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlaTasks.AzureDlaPath;
        /// <summary><p>Name of the Data Lake Analytics account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>The Boolean value of true or false to request a count of the matching resources included with the resources in the response, e.g. Categories?$count=true.</p></summary>
        public virtual string Count { get; internal set; }
        /// <summary><p>OData filter. Optional.</p></summary>
        public virtual string Filter { get; internal set; }
        /// <summary><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        public virtual IReadOnlyList<string> Orderby => OrderbyInternal.AsReadOnly();
        internal List<string> OrderbyInternal { get; set; } = new List<string>();
        /// <summary><p>OData Select statement. Limits the properties on each entry to just those requested, e.g. Categories?$select=CategoryName,Description. Optional.</p></summary>
        public virtual string Select { get; internal set; }
        /// <summary><p>The number of items to skip over before returning elements.</p></summary>
        public virtual string Skip { get; internal set; }
        /// <summary><p>Maximum number of items to return.</p></summary>
        public virtual int? Top { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("dla catalog database list")
              .Add("--account {value}", Account)
              .Add("--count {value}", Count)
              .Add("--filter {value}", Filter)
              .Add("--orderby {value}", Orderby, separator: ',')
              .Add("--select {value}", Select)
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
    #region AzureDlaCatalogDatabaseShowSettings
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlaCatalogDatabaseShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDla executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlaTasks.AzureDlaPath;
        /// <summary><p>Name of the Data Lake Analytics account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>The name of the database.</p></summary>
        public virtual string DatabaseName { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("dla catalog database show")
              .Add("--account {value}", Account)
              .Add("--database-name {value}", DatabaseName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureDlaCatalogExternalDataSourceListSettings
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlaCatalogExternalDataSourceListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDla executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlaTasks.AzureDlaPath;
        /// <summary><p>Name of the Data Lake Analytics account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>The name of the database containing the external data sources.</p></summary>
        public virtual string DatabaseName { get; internal set; }
        /// <summary><p>The Boolean value of true or false to request a count of the matching resources included with the resources in the response, e.g. Categories?$count=true.</p></summary>
        public virtual string Count { get; internal set; }
        /// <summary><p>OData filter. Optional.</p></summary>
        public virtual string Filter { get; internal set; }
        /// <summary><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        public virtual IReadOnlyList<string> Orderby => OrderbyInternal.AsReadOnly();
        internal List<string> OrderbyInternal { get; set; } = new List<string>();
        /// <summary><p>OData Select statement. Limits the properties on each entry to just those requested, e.g. Categories?$select=CategoryName,Description. Optional.</p></summary>
        public virtual string Select { get; internal set; }
        /// <summary><p>The number of items to skip over before returning elements.</p></summary>
        public virtual string Skip { get; internal set; }
        /// <summary><p>Maximum number of items to return.</p></summary>
        public virtual int? Top { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("dla catalog external-data-source list")
              .Add("--account {value}", Account)
              .Add("--database-name {value}", DatabaseName)
              .Add("--count {value}", Count)
              .Add("--filter {value}", Filter)
              .Add("--orderby {value}", Orderby, separator: ',')
              .Add("--select {value}", Select)
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
    #region AzureDlaCatalogExternalDataSourceShowSettings
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlaCatalogExternalDataSourceShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDla executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlaTasks.AzureDlaPath;
        /// <summary><p>Name of the Data Lake Analytics account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>The name of the database containing the external data source.</p></summary>
        public virtual string DatabaseName { get; internal set; }
        /// <summary><p>The name of the external data source.</p></summary>
        public virtual string ExternalDataSourceName { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("dla catalog external-data-source show")
              .Add("--account {value}", Account)
              .Add("--database-name {value}", DatabaseName)
              .Add("--external-data-source-name {value}", ExternalDataSourceName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureDlaCatalogPackageListSettings
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlaCatalogPackageListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDla executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlaTasks.AzureDlaPath;
        /// <summary><p>Name of the Data Lake Analytics account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>The name of the database containing the packages.</p></summary>
        public virtual string DatabaseName { get; internal set; }
        /// <summary><p>The name of the schema containing the packages.</p></summary>
        public virtual string SchemaName { get; internal set; }
        /// <summary><p>The Boolean value of true or false to request a count of the matching resources included with the resources in the response, e.g. Categories?$count=true.</p></summary>
        public virtual string Count { get; internal set; }
        /// <summary><p>OData filter. Optional.</p></summary>
        public virtual string Filter { get; internal set; }
        /// <summary><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        public virtual IReadOnlyList<string> Orderby => OrderbyInternal.AsReadOnly();
        internal List<string> OrderbyInternal { get; set; } = new List<string>();
        /// <summary><p>OData Select statement. Limits the properties on each entry to just those requested, e.g. Categories?$select=CategoryName,Description. Optional.</p></summary>
        public virtual string Select { get; internal set; }
        /// <summary><p>The number of items to skip over before returning elements.</p></summary>
        public virtual string Skip { get; internal set; }
        /// <summary><p>Maximum number of items to return.</p></summary>
        public virtual int? Top { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("dla catalog package list")
              .Add("--account {value}", Account)
              .Add("--database-name {value}", DatabaseName)
              .Add("--schema-name {value}", SchemaName)
              .Add("--count {value}", Count)
              .Add("--filter {value}", Filter)
              .Add("--orderby {value}", Orderby, separator: ',')
              .Add("--select {value}", Select)
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
    #region AzureDlaCatalogPackageShowSettings
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlaCatalogPackageShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDla executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlaTasks.AzureDlaPath;
        /// <summary><p>Name of the Data Lake Analytics account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>The name of the database containing the package.</p></summary>
        public virtual string DatabaseName { get; internal set; }
        /// <summary><p>The name of the package.</p></summary>
        public virtual string PackageName { get; internal set; }
        /// <summary><p>The name of the schema containing the package.</p></summary>
        public virtual string SchemaName { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("dla catalog package show")
              .Add("--account {value}", Account)
              .Add("--database-name {value}", DatabaseName)
              .Add("--package-name {value}", PackageName)
              .Add("--schema-name {value}", SchemaName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureDlaCatalogProcedureListSettings
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlaCatalogProcedureListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDla executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlaTasks.AzureDlaPath;
        /// <summary><p>Name of the Data Lake Analytics account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>The name of the database containing the procedures.</p></summary>
        public virtual string DatabaseName { get; internal set; }
        /// <summary><p>The name of the schema containing the procedures.</p></summary>
        public virtual string SchemaName { get; internal set; }
        /// <summary><p>The Boolean value of true or false to request a count of the matching resources included with the resources in the response, e.g. Categories?$count=true.</p></summary>
        public virtual string Count { get; internal set; }
        /// <summary><p>OData filter. Optional.</p></summary>
        public virtual string Filter { get; internal set; }
        /// <summary><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        public virtual IReadOnlyList<string> Orderby => OrderbyInternal.AsReadOnly();
        internal List<string> OrderbyInternal { get; set; } = new List<string>();
        /// <summary><p>OData Select statement. Limits the properties on each entry to just those requested, e.g. Categories?$select=CategoryName,Description. Optional.</p></summary>
        public virtual string Select { get; internal set; }
        /// <summary><p>The number of items to skip over before returning elements.</p></summary>
        public virtual string Skip { get; internal set; }
        /// <summary><p>Maximum number of items to return.</p></summary>
        public virtual int? Top { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("dla catalog procedure list")
              .Add("--account {value}", Account)
              .Add("--database-name {value}", DatabaseName)
              .Add("--schema-name {value}", SchemaName)
              .Add("--count {value}", Count)
              .Add("--filter {value}", Filter)
              .Add("--orderby {value}", Orderby, separator: ',')
              .Add("--select {value}", Select)
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
    #region AzureDlaCatalogProcedureShowSettings
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlaCatalogProcedureShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDla executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlaTasks.AzureDlaPath;
        /// <summary><p>Name of the Data Lake Analytics account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>The name of the database containing the procedure.</p></summary>
        public virtual string DatabaseName { get; internal set; }
        /// <summary><p>The name of the procedure.</p></summary>
        public virtual string ProcedureName { get; internal set; }
        /// <summary><p>The name of the schema containing the procedure.</p></summary>
        public virtual string SchemaName { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("dla catalog procedure show")
              .Add("--account {value}", Account)
              .Add("--database-name {value}", DatabaseName)
              .Add("--procedure-name {value}", ProcedureName)
              .Add("--schema-name {value}", SchemaName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureDlaCatalogSchemaListSettings
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlaCatalogSchemaListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDla executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlaTasks.AzureDlaPath;
        /// <summary><p>Name of the Data Lake Analytics account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>The name of the database containing the schema.</p></summary>
        public virtual string DatabaseName { get; internal set; }
        /// <summary><p>The Boolean value of true or false to request a count of the matching resources included with the resources in the response, e.g. Categories?$count=true.</p></summary>
        public virtual string Count { get; internal set; }
        /// <summary><p>OData filter. Optional.</p></summary>
        public virtual string Filter { get; internal set; }
        /// <summary><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        public virtual IReadOnlyList<string> Orderby => OrderbyInternal.AsReadOnly();
        internal List<string> OrderbyInternal { get; set; } = new List<string>();
        /// <summary><p>OData Select statement. Limits the properties on each entry to just those requested, e.g. Categories?$select=CategoryName,Description. Optional.</p></summary>
        public virtual string Select { get; internal set; }
        /// <summary><p>The number of items to skip over before returning elements.</p></summary>
        public virtual string Skip { get; internal set; }
        /// <summary><p>Maximum number of items to return.</p></summary>
        public virtual int? Top { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("dla catalog schema list")
              .Add("--account {value}", Account)
              .Add("--database-name {value}", DatabaseName)
              .Add("--count {value}", Count)
              .Add("--filter {value}", Filter)
              .Add("--orderby {value}", Orderby, separator: ',')
              .Add("--select {value}", Select)
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
    #region AzureDlaCatalogSchemaShowSettings
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlaCatalogSchemaShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDla executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlaTasks.AzureDlaPath;
        /// <summary><p>Name of the Data Lake Analytics account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>The name of the database containing the schema.</p></summary>
        public virtual string DatabaseName { get; internal set; }
        /// <summary><p>The name of the schema.</p></summary>
        public virtual string SchemaName { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("dla catalog schema show")
              .Add("--account {value}", Account)
              .Add("--database-name {value}", DatabaseName)
              .Add("--schema-name {value}", SchemaName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureDlaCatalogTablePartitionListSettings
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlaCatalogTablePartitionListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDla executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlaTasks.AzureDlaPath;
        /// <summary><p>Name of the Data Lake Analytics account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>The name of the database containing the partitions.</p></summary>
        public virtual string DatabaseName { get; internal set; }
        /// <summary><p>The name of the schema containing the partitions.</p></summary>
        public virtual string SchemaName { get; internal set; }
        /// <summary><p>The name of the table containing the partitions.</p></summary>
        public virtual string TableName { get; internal set; }
        /// <summary><p>The Boolean value of true or false to request a count of the matching resources included with the resources in the response, e.g. Categories?$count=true.</p></summary>
        public virtual string Count { get; internal set; }
        /// <summary><p>OData filter. Optional.</p></summary>
        public virtual string Filter { get; internal set; }
        /// <summary><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        public virtual IReadOnlyList<string> Orderby => OrderbyInternal.AsReadOnly();
        internal List<string> OrderbyInternal { get; set; } = new List<string>();
        /// <summary><p>OData Select statement. Limits the properties on each entry to just those requested, e.g. Categories?$select=CategoryName,Description. Optional.</p></summary>
        public virtual string Select { get; internal set; }
        /// <summary><p>The number of items to skip over before returning elements.</p></summary>
        public virtual string Skip { get; internal set; }
        /// <summary><p>Maximum number of items to return.</p></summary>
        public virtual int? Top { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("dla catalog table-partition list")
              .Add("--account {value}", Account)
              .Add("--database-name {value}", DatabaseName)
              .Add("--schema-name {value}", SchemaName)
              .Add("--table-name {value}", TableName)
              .Add("--count {value}", Count)
              .Add("--filter {value}", Filter)
              .Add("--orderby {value}", Orderby, separator: ',')
              .Add("--select {value}", Select)
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
    #region AzureDlaCatalogTablePartitionShowSettings
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlaCatalogTablePartitionShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDla executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlaTasks.AzureDlaPath;
        /// <summary><p>Name of the Data Lake Analytics account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>The name of the database containing the partition.</p></summary>
        public virtual string DatabaseName { get; internal set; }
        /// <summary><p>The name of the table partition.</p></summary>
        public virtual string PartitionName { get; internal set; }
        /// <summary><p>The name of the schema containing the partition.</p></summary>
        public virtual string SchemaName { get; internal set; }
        /// <summary><p>The name of the table containing the partition.</p></summary>
        public virtual string TableName { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("dla catalog table-partition show")
              .Add("--account {value}", Account)
              .Add("--database-name {value}", DatabaseName)
              .Add("--partition-name {value}", PartitionName)
              .Add("--schema-name {value}", SchemaName)
              .Add("--table-name {value}", TableName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureDlaCatalogTableStatsListSettings
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlaCatalogTableStatsListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDla executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlaTasks.AzureDlaPath;
        /// <summary><p>Name of the Data Lake Analytics account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>The name of the database.</p></summary>
        public virtual string DatabaseName { get; internal set; }
        /// <summary><p>The schema associated with the tables to list.</p></summary>
        public virtual string SchemaName { get; internal set; }
        /// <summary><p>The table to list statistics for. `--schema-name` must also be specified.</p></summary>
        public virtual string TableName { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("dla catalog table-stats list")
              .Add("--account {value}", Account)
              .Add("--database-name {value}", DatabaseName)
              .Add("--schema-name {value}", SchemaName)
              .Add("--table-name {value}", TableName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureDlaCatalogTableStatsShowSettings
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlaCatalogTableStatsShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDla executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlaTasks.AzureDlaPath;
        /// <summary><p>Name of the Data Lake Analytics account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>The name of the database containing the statistics.</p></summary>
        public virtual string DatabaseName { get; internal set; }
        /// <summary><p>The name of the schema containing the statistics.</p></summary>
        public virtual string SchemaName { get; internal set; }
        /// <summary><p>The name of the table statistics.</p></summary>
        public virtual string StatisticsName { get; internal set; }
        /// <summary><p>The name of the table containing the statistics.</p></summary>
        public virtual string TableName { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("dla catalog table-stats show")
              .Add("--account {value}", Account)
              .Add("--database-name {value}", DatabaseName)
              .Add("--schema-name {value}", SchemaName)
              .Add("--statistics-name {value}", StatisticsName)
              .Add("--table-name {value}", TableName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureDlaCatalogTableTypeListSettings
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlaCatalogTableTypeListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDla executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlaTasks.AzureDlaPath;
        /// <summary><p>Name of the Data Lake Analytics account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>The name of the database containing the table types.</p></summary>
        public virtual string DatabaseName { get; internal set; }
        /// <summary><p>The name of the schema containing the table types.</p></summary>
        public virtual string SchemaName { get; internal set; }
        /// <summary><p>The Boolean value of true or false to request a count of the matching resources included with the resources in the response, e.g. Categories?$count=true.</p></summary>
        public virtual string Count { get; internal set; }
        /// <summary><p>OData filter. Optional.</p></summary>
        public virtual string Filter { get; internal set; }
        /// <summary><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        public virtual IReadOnlyList<string> Orderby => OrderbyInternal.AsReadOnly();
        internal List<string> OrderbyInternal { get; set; } = new List<string>();
        /// <summary><p>OData Select statement. Limits the properties on each entry to just those requested, e.g. Categories?$select=CategoryName,Description. Optional.</p></summary>
        public virtual string Select { get; internal set; }
        /// <summary><p>The number of items to skip over before returning elements.</p></summary>
        public virtual string Skip { get; internal set; }
        /// <summary><p>Maximum number of items to return.</p></summary>
        public virtual int? Top { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("dla catalog table-type list")
              .Add("--account {value}", Account)
              .Add("--database-name {value}", DatabaseName)
              .Add("--schema-name {value}", SchemaName)
              .Add("--count {value}", Count)
              .Add("--filter {value}", Filter)
              .Add("--orderby {value}", Orderby, separator: ',')
              .Add("--select {value}", Select)
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
    #region AzureDlaCatalogTableTypeShowSettings
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlaCatalogTableTypeShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDla executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlaTasks.AzureDlaPath;
        /// <summary><p>Name of the Data Lake Analytics account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>The name of the database containing the table type.</p></summary>
        public virtual string DatabaseName { get; internal set; }
        /// <summary><p>The name of the schema containing the table type.</p></summary>
        public virtual string SchemaName { get; internal set; }
        /// <summary><p>The name of the table type to retrieve.</p></summary>
        public virtual string TableTypeName { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("dla catalog table-type show")
              .Add("--account {value}", Account)
              .Add("--database-name {value}", DatabaseName)
              .Add("--schema-name {value}", SchemaName)
              .Add("--table-type-name {value}", TableTypeName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureDlaCatalogTableListSettings
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlaCatalogTableListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDla executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlaTasks.AzureDlaPath;
        /// <summary><p>Name of the Data Lake Analytics account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>The name of the database.</p></summary>
        public virtual string DatabaseName { get; internal set; }
        /// <summary><p>The schema assocated with the tables to list.</p></summary>
        public virtual string SchemaName { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("dla catalog table list")
              .Add("--account {value}", Account)
              .Add("--database-name {value}", DatabaseName)
              .Add("--schema-name {value}", SchemaName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureDlaCatalogTableShowSettings
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlaCatalogTableShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDla executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlaTasks.AzureDlaPath;
        /// <summary><p>Name of the Data Lake Analytics account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>The name of the database containing the table.</p></summary>
        public virtual string DatabaseName { get; internal set; }
        /// <summary><p>The name of the schema containing the table.</p></summary>
        public virtual string SchemaName { get; internal set; }
        /// <summary><p>The name of the table.</p></summary>
        public virtual string TableName { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("dla catalog table show")
              .Add("--account {value}", Account)
              .Add("--database-name {value}", DatabaseName)
              .Add("--schema-name {value}", SchemaName)
              .Add("--table-name {value}", TableName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureDlaCatalogTvfListSettings
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlaCatalogTvfListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDla executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlaTasks.AzureDlaPath;
        /// <summary><p>Name of the Data Lake Analytics account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>The name of the database.</p></summary>
        public virtual string DatabaseName { get; internal set; }
        /// <summary><p>The name of the schema assocated with table valued functions to list.</p></summary>
        public virtual string SchemaName { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("dla catalog tvf list")
              .Add("--account {value}", Account)
              .Add("--database-name {value}", DatabaseName)
              .Add("--schema-name {value}", SchemaName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureDlaCatalogTvfShowSettings
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlaCatalogTvfShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDla executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlaTasks.AzureDlaPath;
        /// <summary><p>Name of the Data Lake Analytics account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>The name of the database containing the table valued function.</p></summary>
        public virtual string DatabaseName { get; internal set; }
        /// <summary><p>The name of the schema containing the table valued function.</p></summary>
        public virtual string SchemaName { get; internal set; }
        /// <summary><p>The name of the tableValuedFunction.</p></summary>
        public virtual string TableValuedFunctionName { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("dla catalog tvf show")
              .Add("--account {value}", Account)
              .Add("--database-name {value}", DatabaseName)
              .Add("--schema-name {value}", SchemaName)
              .Add("--table-valued-function-name {value}", TableValuedFunctionName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureDlaCatalogViewListSettings
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlaCatalogViewListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDla executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlaTasks.AzureDlaPath;
        /// <summary><p>Name of the Data Lake Analytics account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>The name of the database.</p></summary>
        public virtual string DatabaseName { get; internal set; }
        /// <summary><p>The name of the schema associated with the views to list.</p></summary>
        public virtual string SchemaName { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("dla catalog view list")
              .Add("--account {value}", Account)
              .Add("--database-name {value}", DatabaseName)
              .Add("--schema-name {value}", SchemaName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureDlaCatalogViewShowSettings
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlaCatalogViewShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDla executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlaTasks.AzureDlaPath;
        /// <summary><p>Name of the Data Lake Analytics account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>The name of the database containing the view.</p></summary>
        public virtual string DatabaseName { get; internal set; }
        /// <summary><p>The name of the schema containing the view.</p></summary>
        public virtual string SchemaName { get; internal set; }
        /// <summary><p>The name of the view.</p></summary>
        public virtual string ViewName { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("dla catalog view show")
              .Add("--account {value}", Account)
              .Add("--database-name {value}", DatabaseName)
              .Add("--schema-name {value}", SchemaName)
              .Add("--view-name {value}", ViewName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureDlaJobPipelineListSettings
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlaJobPipelineListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDla executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlaTasks.AzureDlaPath;
        /// <summary><p>Name of the Data Lake Analytics account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>The end date for when to get the list of pipelines. The startDateTime and endDateTime can be no more than 30 days apart.</p></summary>
        public virtual string EndDateTime { get; internal set; }
        /// <summary><p>The start date for when to get the list of pipelines. The startDateTime and endDateTime can be no more than 30 days apart.</p></summary>
        public virtual string StartDateTime { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("dla job pipeline list")
              .Add("--account {value}", Account)
              .Add("--end-date-time {value}", EndDateTime)
              .Add("--start-date-time {value}", StartDateTime)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureDlaJobPipelineShowSettings
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlaJobPipelineShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDla executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlaTasks.AzureDlaPath;
        /// <summary><p>Name of the Data Lake Analytics account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>Pipeline ID.</p></summary>
        public virtual string PipelineIdentity { get; internal set; }
        /// <summary><p>The end date for when to get the pipeline and aggregate its data. The startDateTime and endDateTime can be no more than 30 days apart.</p></summary>
        public virtual string EndDateTime { get; internal set; }
        /// <summary><p>The start date for when to get the pipeline and aggregate its data. The startDateTime and endDateTime can be no more than 30 days apart.</p></summary>
        public virtual string StartDateTime { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("dla job pipeline show")
              .Add("--account {value}", Account)
              .Add("--pipeline-identity {value}", PipelineIdentity)
              .Add("--end-date-time {value}", EndDateTime)
              .Add("--start-date-time {value}", StartDateTime)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureDlaJobRecurrenceListSettings
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlaJobRecurrenceListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDla executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlaTasks.AzureDlaPath;
        /// <summary><p>Name of the Data Lake Analytics account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>The end date for when to get the list of recurrences. The startDateTime and endDateTime can be no more than 30 days apart.</p></summary>
        public virtual string EndDateTime { get; internal set; }
        /// <summary><p>The start date for when to get the list of recurrences. The startDateTime and endDateTime can be no more than 30 days apart.</p></summary>
        public virtual string StartDateTime { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("dla job recurrence list")
              .Add("--account {value}", Account)
              .Add("--end-date-time {value}", EndDateTime)
              .Add("--start-date-time {value}", StartDateTime)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureDlaJobRecurrenceShowSettings
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlaJobRecurrenceShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDla executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlaTasks.AzureDlaPath;
        /// <summary><p>Name of the Data Lake Analytics account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>Recurrence ID.</p></summary>
        public virtual string RecurrenceIdentity { get; internal set; }
        /// <summary><p>The end date for when to get recurrence and aggregate its data. The startDateTime and endDateTime can be no more than 30 days apart.</p></summary>
        public virtual string EndDateTime { get; internal set; }
        /// <summary><p>The start date for when to get the recurrence and aggregate its data. The startDateTime and endDateTime can be no more than 30 days apart.</p></summary>
        public virtual string StartDateTime { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("dla job recurrence show")
              .Add("--account {value}", Account)
              .Add("--recurrence-identity {value}", RecurrenceIdentity)
              .Add("--end-date-time {value}", EndDateTime)
              .Add("--start-date-time {value}", StartDateTime)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureDlaSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlaSettingsExtensions
    {
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlaSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaSettings SetDebug(this AzureDlaSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaSettings ResetDebug(this AzureDlaSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlaSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaSettings SetHelp(this AzureDlaSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaSettings ResetHelp(this AzureDlaSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlaSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaSettings SetOutput(this AzureDlaSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaSettings ResetOutput(this AzureDlaSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlaSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaSettings SetQuery(this AzureDlaSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaSettings ResetQuery(this AzureDlaSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlaSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaSettings SetVerbose(this AzureDlaSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaSettings ResetVerbose(this AzureDlaSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlaAccountCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlaAccountCreateSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlaAccountCreateSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountCreateSettings SetAccount(this AzureDlaAccountCreateSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountCreateSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountCreateSettings ResetAccount(this AzureDlaAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region DefaultDataLakeStore
        /// <summary><p><em>Sets <see cref="AzureDlaAccountCreateSettings.DefaultDataLakeStore"/>.</em></p><p>The default Data Lake Store account to associate with the created account.</p></summary>
        [Pure]
        public static AzureDlaAccountCreateSettings SetDefaultDataLakeStore(this AzureDlaAccountCreateSettings toolSettings, string defaultDataLakeStore)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DefaultDataLakeStore = defaultDataLakeStore;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountCreateSettings.DefaultDataLakeStore"/>.</em></p><p>The default Data Lake Store account to associate with the created account.</p></summary>
        [Pure]
        public static AzureDlaAccountCreateSettings ResetDefaultDataLakeStore(this AzureDlaAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DefaultDataLakeStore = null;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary><p><em>Sets <see cref="AzureDlaAccountCreateSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureDlaAccountCreateSettings SetLocation(this AzureDlaAccountCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountCreateSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureDlaAccountCreateSettings ResetLocation(this AzureDlaAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region MaxDegreeOfParallelism
        /// <summary><p><em>Sets <see cref="AzureDlaAccountCreateSettings.MaxDegreeOfParallelism"/>.</em></p><p>The maximum degree of parallelism for this account.</p></summary>
        [Pure]
        public static AzureDlaAccountCreateSettings SetMaxDegreeOfParallelism(this AzureDlaAccountCreateSettings toolSettings, string maxDegreeOfParallelism)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MaxDegreeOfParallelism = maxDegreeOfParallelism;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountCreateSettings.MaxDegreeOfParallelism"/>.</em></p><p>The maximum degree of parallelism for this account.</p></summary>
        [Pure]
        public static AzureDlaAccountCreateSettings ResetMaxDegreeOfParallelism(this AzureDlaAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MaxDegreeOfParallelism = null;
            return toolSettings;
        }
        #endregion
        #region MaxJobCount
        /// <summary><p><em>Sets <see cref="AzureDlaAccountCreateSettings.MaxJobCount"/>.</em></p><p>The maximum number of concurrent jobs for this account.</p></summary>
        [Pure]
        public static AzureDlaAccountCreateSettings SetMaxJobCount(this AzureDlaAccountCreateSettings toolSettings, int? maxJobCount)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MaxJobCount = maxJobCount;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountCreateSettings.MaxJobCount"/>.</em></p><p>The maximum number of concurrent jobs for this account.</p></summary>
        [Pure]
        public static AzureDlaAccountCreateSettings ResetMaxJobCount(this AzureDlaAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MaxJobCount = null;
            return toolSettings;
        }
        #endregion
        #region QueryStoreRetention
        /// <summary><p><em>Sets <see cref="AzureDlaAccountCreateSettings.QueryStoreRetention"/>.</em></p><p>The number of days to retain job metadata.</p></summary>
        [Pure]
        public static AzureDlaAccountCreateSettings SetQueryStoreRetention(this AzureDlaAccountCreateSettings toolSettings, string queryStoreRetention)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.QueryStoreRetention = queryStoreRetention;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountCreateSettings.QueryStoreRetention"/>.</em></p><p>The number of days to retain job metadata.</p></summary>
        [Pure]
        public static AzureDlaAccountCreateSettings ResetQueryStoreRetention(this AzureDlaAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.QueryStoreRetention = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureDlaAccountCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureDlaAccountCreateSettings SetResourceGroup(this AzureDlaAccountCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureDlaAccountCreateSettings ResetResourceGroup(this AzureDlaAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary><p><em>Sets <see cref="AzureDlaAccountCreateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureDlaAccountCreateSettings SetTags(this AzureDlaAccountCreateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountCreateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureDlaAccountCreateSettings ResetTags(this AzureDlaAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Tier
        /// <summary><p><em>Sets <see cref="AzureDlaAccountCreateSettings.Tier"/>.</em></p><p>The desired commitment tier for this account to use.</p></summary>
        [Pure]
        public static AzureDlaAccountCreateSettings SetTier(this AzureDlaAccountCreateSettings toolSettings, DlaAccountTier tier)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tier = tier;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountCreateSettings.Tier"/>.</em></p><p>The desired commitment tier for this account to use.</p></summary>
        [Pure]
        public static AzureDlaAccountCreateSettings ResetTier(this AzureDlaAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tier = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlaAccountCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountCreateSettings SetDebug(this AzureDlaAccountCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountCreateSettings ResetDebug(this AzureDlaAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlaAccountCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaAccountCreateSettings SetHelp(this AzureDlaAccountCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaAccountCreateSettings ResetHelp(this AzureDlaAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlaAccountCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaAccountCreateSettings SetOutput(this AzureDlaAccountCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaAccountCreateSettings ResetOutput(this AzureDlaAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlaAccountCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaAccountCreateSettings SetQuery(this AzureDlaAccountCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaAccountCreateSettings ResetQuery(this AzureDlaAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlaAccountCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountCreateSettings SetVerbose(this AzureDlaAccountCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountCreateSettings ResetVerbose(this AzureDlaAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlaAccountDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlaAccountDeleteSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlaAccountDeleteSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountDeleteSettings SetAccount(this AzureDlaAccountDeleteSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountDeleteSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountDeleteSettings ResetAccount(this AzureDlaAccountDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureDlaAccountDeleteSettings.ResourceGroup"/>.</em></p><p>If not specified, will attempt to discover the resource group for the specified Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountDeleteSettings SetResourceGroup(this AzureDlaAccountDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountDeleteSettings.ResourceGroup"/>.</em></p><p>If not specified, will attempt to discover the resource group for the specified Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountDeleteSettings ResetResourceGroup(this AzureDlaAccountDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlaAccountDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountDeleteSettings SetDebug(this AzureDlaAccountDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountDeleteSettings ResetDebug(this AzureDlaAccountDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlaAccountDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaAccountDeleteSettings SetHelp(this AzureDlaAccountDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaAccountDeleteSettings ResetHelp(this AzureDlaAccountDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlaAccountDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaAccountDeleteSettings SetOutput(this AzureDlaAccountDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaAccountDeleteSettings ResetOutput(this AzureDlaAccountDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlaAccountDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaAccountDeleteSettings SetQuery(this AzureDlaAccountDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaAccountDeleteSettings ResetQuery(this AzureDlaAccountDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlaAccountDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountDeleteSettings SetVerbose(this AzureDlaAccountDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountDeleteSettings ResetVerbose(this AzureDlaAccountDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlaAccountListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlaAccountListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureDlaAccountListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureDlaAccountListSettings SetResourceGroup(this AzureDlaAccountListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureDlaAccountListSettings ResetResourceGroup(this AzureDlaAccountListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlaAccountListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountListSettings SetDebug(this AzureDlaAccountListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountListSettings ResetDebug(this AzureDlaAccountListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlaAccountListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaAccountListSettings SetHelp(this AzureDlaAccountListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaAccountListSettings ResetHelp(this AzureDlaAccountListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlaAccountListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaAccountListSettings SetOutput(this AzureDlaAccountListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaAccountListSettings ResetOutput(this AzureDlaAccountListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlaAccountListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaAccountListSettings SetQuery(this AzureDlaAccountListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaAccountListSettings ResetQuery(this AzureDlaAccountListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlaAccountListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountListSettings SetVerbose(this AzureDlaAccountListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountListSettings ResetVerbose(this AzureDlaAccountListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlaAccountShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlaAccountShowSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlaAccountShowSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountShowSettings SetAccount(this AzureDlaAccountShowSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountShowSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountShowSettings ResetAccount(this AzureDlaAccountShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureDlaAccountShowSettings.ResourceGroup"/>.</em></p><p>If not specified, will attempt to discover the resource group for the specified Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountShowSettings SetResourceGroup(this AzureDlaAccountShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountShowSettings.ResourceGroup"/>.</em></p><p>If not specified, will attempt to discover the resource group for the specified Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountShowSettings ResetResourceGroup(this AzureDlaAccountShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlaAccountShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountShowSettings SetDebug(this AzureDlaAccountShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountShowSettings ResetDebug(this AzureDlaAccountShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlaAccountShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaAccountShowSettings SetHelp(this AzureDlaAccountShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaAccountShowSettings ResetHelp(this AzureDlaAccountShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlaAccountShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaAccountShowSettings SetOutput(this AzureDlaAccountShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaAccountShowSettings ResetOutput(this AzureDlaAccountShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlaAccountShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaAccountShowSettings SetQuery(this AzureDlaAccountShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaAccountShowSettings ResetQuery(this AzureDlaAccountShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlaAccountShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountShowSettings SetVerbose(this AzureDlaAccountShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountShowSettings ResetVerbose(this AzureDlaAccountShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlaAccountUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlaAccountUpdateSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlaAccountUpdateSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountUpdateSettings SetAccount(this AzureDlaAccountUpdateSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountUpdateSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountUpdateSettings ResetAccount(this AzureDlaAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region AllowAzureIps
        /// <summary><p><em>Sets <see cref="AzureDlaAccountUpdateSettings.AllowAzureIps"/>.</em></p><p>Allow or block IPs originating from Azure through the firewall.</p></summary>
        [Pure]
        public static AzureDlaAccountUpdateSettings SetAllowAzureIps(this AzureDlaAccountUpdateSettings toolSettings, DlaAccountUpdateAllowAzureIps allowAzureIps)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AllowAzureIps = allowAzureIps;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountUpdateSettings.AllowAzureIps"/>.</em></p><p>Allow or block IPs originating from Azure through the firewall.</p></summary>
        [Pure]
        public static AzureDlaAccountUpdateSettings ResetAllowAzureIps(this AzureDlaAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AllowAzureIps = null;
            return toolSettings;
        }
        #endregion
        #region FirewallState
        /// <summary><p><em>Sets <see cref="AzureDlaAccountUpdateSettings.FirewallState"/>.</em></p><p>Enable or disable existing firewall rules.</p></summary>
        [Pure]
        public static AzureDlaAccountUpdateSettings SetFirewallState(this AzureDlaAccountUpdateSettings toolSettings, DlaAccountUpdateAllowAzureIps firewallState)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FirewallState = firewallState;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountUpdateSettings.FirewallState"/>.</em></p><p>Enable or disable existing firewall rules.</p></summary>
        [Pure]
        public static AzureDlaAccountUpdateSettings ResetFirewallState(this AzureDlaAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FirewallState = null;
            return toolSettings;
        }
        #endregion
        #region MaxDegreeOfParallelism
        /// <summary><p><em>Sets <see cref="AzureDlaAccountUpdateSettings.MaxDegreeOfParallelism"/>.</em></p><p>The maximum degree of parallelism for this account.</p></summary>
        [Pure]
        public static AzureDlaAccountUpdateSettings SetMaxDegreeOfParallelism(this AzureDlaAccountUpdateSettings toolSettings, string maxDegreeOfParallelism)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MaxDegreeOfParallelism = maxDegreeOfParallelism;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountUpdateSettings.MaxDegreeOfParallelism"/>.</em></p><p>The maximum degree of parallelism for this account.</p></summary>
        [Pure]
        public static AzureDlaAccountUpdateSettings ResetMaxDegreeOfParallelism(this AzureDlaAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MaxDegreeOfParallelism = null;
            return toolSettings;
        }
        #endregion
        #region MaxJobCount
        /// <summary><p><em>Sets <see cref="AzureDlaAccountUpdateSettings.MaxJobCount"/>.</em></p><p>The maximum number of concurrent jobs for this account.</p></summary>
        [Pure]
        public static AzureDlaAccountUpdateSettings SetMaxJobCount(this AzureDlaAccountUpdateSettings toolSettings, int? maxJobCount)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MaxJobCount = maxJobCount;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountUpdateSettings.MaxJobCount"/>.</em></p><p>The maximum number of concurrent jobs for this account.</p></summary>
        [Pure]
        public static AzureDlaAccountUpdateSettings ResetMaxJobCount(this AzureDlaAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MaxJobCount = null;
            return toolSettings;
        }
        #endregion
        #region QueryStoreRetention
        /// <summary><p><em>Sets <see cref="AzureDlaAccountUpdateSettings.QueryStoreRetention"/>.</em></p><p>The number of days to retain job metadata.</p></summary>
        [Pure]
        public static AzureDlaAccountUpdateSettings SetQueryStoreRetention(this AzureDlaAccountUpdateSettings toolSettings, string queryStoreRetention)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.QueryStoreRetention = queryStoreRetention;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountUpdateSettings.QueryStoreRetention"/>.</em></p><p>The number of days to retain job metadata.</p></summary>
        [Pure]
        public static AzureDlaAccountUpdateSettings ResetQueryStoreRetention(this AzureDlaAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.QueryStoreRetention = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureDlaAccountUpdateSettings.ResourceGroup"/>.</em></p><p>If not specified, will attempt to discover the resource group for the specified Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountUpdateSettings SetResourceGroup(this AzureDlaAccountUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountUpdateSettings.ResourceGroup"/>.</em></p><p>If not specified, will attempt to discover the resource group for the specified Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountUpdateSettings ResetResourceGroup(this AzureDlaAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary><p><em>Sets <see cref="AzureDlaAccountUpdateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureDlaAccountUpdateSettings SetTags(this AzureDlaAccountUpdateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountUpdateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureDlaAccountUpdateSettings ResetTags(this AzureDlaAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Tier
        /// <summary><p><em>Sets <see cref="AzureDlaAccountUpdateSettings.Tier"/>.</em></p><p>The desired commitment tier for this account to use.</p></summary>
        [Pure]
        public static AzureDlaAccountUpdateSettings SetTier(this AzureDlaAccountUpdateSettings toolSettings, DlaAccountTier tier)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tier = tier;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountUpdateSettings.Tier"/>.</em></p><p>The desired commitment tier for this account to use.</p></summary>
        [Pure]
        public static AzureDlaAccountUpdateSettings ResetTier(this AzureDlaAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tier = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlaAccountUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountUpdateSettings SetDebug(this AzureDlaAccountUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountUpdateSettings ResetDebug(this AzureDlaAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlaAccountUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaAccountUpdateSettings SetHelp(this AzureDlaAccountUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaAccountUpdateSettings ResetHelp(this AzureDlaAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlaAccountUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaAccountUpdateSettings SetOutput(this AzureDlaAccountUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaAccountUpdateSettings ResetOutput(this AzureDlaAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlaAccountUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaAccountUpdateSettings SetQuery(this AzureDlaAccountUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaAccountUpdateSettings ResetQuery(this AzureDlaAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlaAccountUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountUpdateSettings SetVerbose(this AzureDlaAccountUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountUpdateSettings ResetVerbose(this AzureDlaAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlaCatalogSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlaCatalogSettingsExtensions
    {
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogSettings SetDebug(this AzureDlaCatalogSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogSettings ResetDebug(this AzureDlaCatalogSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaCatalogSettings SetHelp(this AzureDlaCatalogSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaCatalogSettings ResetHelp(this AzureDlaCatalogSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaCatalogSettings SetOutput(this AzureDlaCatalogSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaCatalogSettings ResetOutput(this AzureDlaCatalogSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaCatalogSettings SetQuery(this AzureDlaCatalogSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaCatalogSettings ResetQuery(this AzureDlaCatalogSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogSettings SetVerbose(this AzureDlaCatalogSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogSettings ResetVerbose(this AzureDlaCatalogSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlaJobCancelSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlaJobCancelSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlaJobCancelSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaJobCancelSettings SetAccount(this AzureDlaJobCancelSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobCancelSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaJobCancelSettings ResetAccount(this AzureDlaJobCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region JobIdentity
        /// <summary><p><em>Sets <see cref="AzureDlaJobCancelSettings.JobIdentity"/>.</em></p><p>JobInfo ID to cancel.</p></summary>
        [Pure]
        public static AzureDlaJobCancelSettings SetJobIdentity(this AzureDlaJobCancelSettings toolSettings, string jobIdentity)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.JobIdentity = jobIdentity;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobCancelSettings.JobIdentity"/>.</em></p><p>JobInfo ID to cancel.</p></summary>
        [Pure]
        public static AzureDlaJobCancelSettings ResetJobIdentity(this AzureDlaJobCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.JobIdentity = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlaJobCancelSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaJobCancelSettings SetDebug(this AzureDlaJobCancelSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobCancelSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaJobCancelSettings ResetDebug(this AzureDlaJobCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlaJobCancelSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaJobCancelSettings SetHelp(this AzureDlaJobCancelSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobCancelSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaJobCancelSettings ResetHelp(this AzureDlaJobCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlaJobCancelSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaJobCancelSettings SetOutput(this AzureDlaJobCancelSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobCancelSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaJobCancelSettings ResetOutput(this AzureDlaJobCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlaJobCancelSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaJobCancelSettings SetQuery(this AzureDlaJobCancelSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobCancelSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaJobCancelSettings ResetQuery(this AzureDlaJobCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlaJobCancelSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaJobCancelSettings SetVerbose(this AzureDlaJobCancelSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobCancelSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaJobCancelSettings ResetVerbose(this AzureDlaJobCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlaJobListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlaJobListSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlaJobListSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaJobListSettings SetAccount(this AzureDlaJobListSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobListSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaJobListSettings ResetAccount(this AzureDlaJobListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureDlaJobListSettings.Name"/>.</em></p><p>A filter which returns jobs only by the specified friendly name.</p></summary>
        [Pure]
        public static AzureDlaJobListSettings SetName(this AzureDlaJobListSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobListSettings.Name"/>.</em></p><p>A filter which returns jobs only by the specified friendly name.</p></summary>
        [Pure]
        public static AzureDlaJobListSettings ResetName(this AzureDlaJobListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region PipelineId
        /// <summary><p><em>Sets <see cref="AzureDlaJobListSettings.PipelineId"/>.</em></p><p>A filter which returns jobs only containing the specified pipeline_id.</p></summary>
        [Pure]
        public static AzureDlaJobListSettings SetPipelineId(this AzureDlaJobListSettings toolSettings, string pipelineId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PipelineId = pipelineId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobListSettings.PipelineId"/>.</em></p><p>A filter which returns jobs only containing the specified pipeline_id.</p></summary>
        [Pure]
        public static AzureDlaJobListSettings ResetPipelineId(this AzureDlaJobListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PipelineId = null;
            return toolSettings;
        }
        #endregion
        #region RecurrenceId
        /// <summary><p><em>Sets <see cref="AzureDlaJobListSettings.RecurrenceId"/>.</em></p><p>A filter which returns jobs only containing the specified recurrence_id.</p></summary>
        [Pure]
        public static AzureDlaJobListSettings SetRecurrenceId(this AzureDlaJobListSettings toolSettings, string recurrenceId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RecurrenceId = recurrenceId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobListSettings.RecurrenceId"/>.</em></p><p>A filter which returns jobs only containing the specified recurrence_id.</p></summary>
        [Pure]
        public static AzureDlaJobListSettings ResetRecurrenceId(this AzureDlaJobListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RecurrenceId = null;
            return toolSettings;
        }
        #endregion
        #region Result
        /// <summary><p><em>Sets <see cref="AzureDlaJobListSettings.Result"/>.</em></p><p>A filter which returns jobs with only the specified result(s).</p></summary>
        [Pure]
        public static AzureDlaJobListSettings SetResult(this AzureDlaJobListSettings toolSettings, DlaJobListResult result)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Result = result;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobListSettings.Result"/>.</em></p><p>A filter which returns jobs with only the specified result(s).</p></summary>
        [Pure]
        public static AzureDlaJobListSettings ResetResult(this AzureDlaJobListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Result = null;
            return toolSettings;
        }
        #endregion
        #region State
        /// <summary><p><em>Sets <see cref="AzureDlaJobListSettings.State"/>.</em></p><p>A filter which returns jobs with only the specified state(s).</p></summary>
        [Pure]
        public static AzureDlaJobListSettings SetState(this AzureDlaJobListSettings toolSettings, DlaJobListState state)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.State = state;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobListSettings.State"/>.</em></p><p>A filter which returns jobs with only the specified state(s).</p></summary>
        [Pure]
        public static AzureDlaJobListSettings ResetState(this AzureDlaJobListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.State = null;
            return toolSettings;
        }
        #endregion
        #region SubmittedAfter
        /// <summary><p><em>Sets <see cref="AzureDlaJobListSettings.SubmittedAfter"/>.</em></p><p>A filter which returns jobs only submitted after the specified time, in ISO-8601 format.</p></summary>
        [Pure]
        public static AzureDlaJobListSettings SetSubmittedAfter(this AzureDlaJobListSettings toolSettings, string submittedAfter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SubmittedAfter = submittedAfter;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobListSettings.SubmittedAfter"/>.</em></p><p>A filter which returns jobs only submitted after the specified time, in ISO-8601 format.</p></summary>
        [Pure]
        public static AzureDlaJobListSettings ResetSubmittedAfter(this AzureDlaJobListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SubmittedAfter = null;
            return toolSettings;
        }
        #endregion
        #region SubmittedBefore
        /// <summary><p><em>Sets <see cref="AzureDlaJobListSettings.SubmittedBefore"/>.</em></p><p>A filter which returns jobs only submitted before the specified time, in ISO-8601 format.</p></summary>
        [Pure]
        public static AzureDlaJobListSettings SetSubmittedBefore(this AzureDlaJobListSettings toolSettings, string submittedBefore)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SubmittedBefore = submittedBefore;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobListSettings.SubmittedBefore"/>.</em></p><p>A filter which returns jobs only submitted before the specified time, in ISO-8601 format.</p></summary>
        [Pure]
        public static AzureDlaJobListSettings ResetSubmittedBefore(this AzureDlaJobListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SubmittedBefore = null;
            return toolSettings;
        }
        #endregion
        #region Submitter
        /// <summary><p><em>Sets <see cref="AzureDlaJobListSettings.Submitter"/>.</em></p><p>A filter which returns jobs only by the specified submitter.</p></summary>
        [Pure]
        public static AzureDlaJobListSettings SetSubmitter(this AzureDlaJobListSettings toolSettings, string submitter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Submitter = submitter;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobListSettings.Submitter"/>.</em></p><p>A filter which returns jobs only by the specified submitter.</p></summary>
        [Pure]
        public static AzureDlaJobListSettings ResetSubmitter(this AzureDlaJobListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Submitter = null;
            return toolSettings;
        }
        #endregion
        #region Top
        /// <summary><p><em>Sets <see cref="AzureDlaJobListSettings.Top"/>.</em></p><p>Maximum number of items to return.</p></summary>
        [Pure]
        public static AzureDlaJobListSettings SetTop(this AzureDlaJobListSettings toolSettings, int? top)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = top;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobListSettings.Top"/>.</em></p><p>Maximum number of items to return.</p></summary>
        [Pure]
        public static AzureDlaJobListSettings ResetTop(this AzureDlaJobListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlaJobListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaJobListSettings SetDebug(this AzureDlaJobListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaJobListSettings ResetDebug(this AzureDlaJobListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlaJobListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaJobListSettings SetHelp(this AzureDlaJobListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaJobListSettings ResetHelp(this AzureDlaJobListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlaJobListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaJobListSettings SetOutput(this AzureDlaJobListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaJobListSettings ResetOutput(this AzureDlaJobListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlaJobListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaJobListSettings SetQuery(this AzureDlaJobListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaJobListSettings ResetQuery(this AzureDlaJobListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlaJobListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaJobListSettings SetVerbose(this AzureDlaJobListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaJobListSettings ResetVerbose(this AzureDlaJobListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlaJobShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlaJobShowSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlaJobShowSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaJobShowSettings SetAccount(this AzureDlaJobShowSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobShowSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaJobShowSettings ResetAccount(this AzureDlaJobShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region JobIdentity
        /// <summary><p><em>Sets <see cref="AzureDlaJobShowSettings.JobIdentity"/>.</em></p><p>JobInfo ID.</p></summary>
        [Pure]
        public static AzureDlaJobShowSettings SetJobIdentity(this AzureDlaJobShowSettings toolSettings, string jobIdentity)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.JobIdentity = jobIdentity;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobShowSettings.JobIdentity"/>.</em></p><p>JobInfo ID.</p></summary>
        [Pure]
        public static AzureDlaJobShowSettings ResetJobIdentity(this AzureDlaJobShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.JobIdentity = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlaJobShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaJobShowSettings SetDebug(this AzureDlaJobShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaJobShowSettings ResetDebug(this AzureDlaJobShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlaJobShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaJobShowSettings SetHelp(this AzureDlaJobShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaJobShowSettings ResetHelp(this AzureDlaJobShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlaJobShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaJobShowSettings SetOutput(this AzureDlaJobShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaJobShowSettings ResetOutput(this AzureDlaJobShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlaJobShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaJobShowSettings SetQuery(this AzureDlaJobShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaJobShowSettings ResetQuery(this AzureDlaJobShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlaJobShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaJobShowSettings SetVerbose(this AzureDlaJobShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaJobShowSettings ResetVerbose(this AzureDlaJobShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlaJobSubmitSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlaJobSubmitSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlaJobSubmitSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaJobSubmitSettings SetAccount(this AzureDlaJobSubmitSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobSubmitSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaJobSubmitSettings ResetAccount(this AzureDlaJobSubmitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region JobName
        /// <summary><p><em>Sets <see cref="AzureDlaJobSubmitSettings.JobName"/>.</em></p><p>Name for the submitted job.</p></summary>
        [Pure]
        public static AzureDlaJobSubmitSettings SetJobName(this AzureDlaJobSubmitSettings toolSettings, string jobName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.JobName = jobName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobSubmitSettings.JobName"/>.</em></p><p>Name for the submitted job.</p></summary>
        [Pure]
        public static AzureDlaJobSubmitSettings ResetJobName(this AzureDlaJobSubmitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.JobName = null;
            return toolSettings;
        }
        #endregion
        #region Script
        /// <summary><p><em>Sets <see cref="AzureDlaJobSubmitSettings.Script"/>.</em></p><p>Script to submit. This may be '@{file}' to load from a file.</p></summary>
        [Pure]
        public static AzureDlaJobSubmitSettings SetScript(this AzureDlaJobSubmitSettings toolSettings, string script)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Script = script;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobSubmitSettings.Script"/>.</em></p><p>Script to submit. This may be '@{file}' to load from a file.</p></summary>
        [Pure]
        public static AzureDlaJobSubmitSettings ResetScript(this AzureDlaJobSubmitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Script = null;
            return toolSettings;
        }
        #endregion
        #region CompileMode
        /// <summary><p><em>Sets <see cref="AzureDlaJobSubmitSettings.CompileMode"/>.</em></p><p>Indicates the type of compilation to be done on this job. Valid values are: 'Semantic' (Only performs semantic checks and necessary sanity checks), 'Full' (full compilation) and 'SingleBox' (Full compilation performed locally).</p></summary>
        [Pure]
        public static AzureDlaJobSubmitSettings SetCompileMode(this AzureDlaJobSubmitSettings toolSettings, DlaJobSubmitCompileMode compileMode)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CompileMode = compileMode;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobSubmitSettings.CompileMode"/>.</em></p><p>Indicates the type of compilation to be done on this job. Valid values are: 'Semantic' (Only performs semantic checks and necessary sanity checks), 'Full' (full compilation) and 'SingleBox' (Full compilation performed locally).</p></summary>
        [Pure]
        public static AzureDlaJobSubmitSettings ResetCompileMode(this AzureDlaJobSubmitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CompileMode = null;
            return toolSettings;
        }
        #endregion
        #region CompileOnly
        /// <summary><p><em>Sets <see cref="AzureDlaJobSubmitSettings.CompileOnly"/>.</em></p><p>Indicates that the submission should only build the job and not execute if set to true.</p></summary>
        [Pure]
        public static AzureDlaJobSubmitSettings SetCompileOnly(this AzureDlaJobSubmitSettings toolSettings, string compileOnly)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CompileOnly = compileOnly;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobSubmitSettings.CompileOnly"/>.</em></p><p>Indicates that the submission should only build the job and not execute if set to true.</p></summary>
        [Pure]
        public static AzureDlaJobSubmitSettings ResetCompileOnly(this AzureDlaJobSubmitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CompileOnly = null;
            return toolSettings;
        }
        #endregion
        #region DegreeOfParallelism
        /// <summary><p><em>Sets <see cref="AzureDlaJobSubmitSettings.DegreeOfParallelism"/>.</em></p><p>The degree of parallelism for the job.</p></summary>
        [Pure]
        public static AzureDlaJobSubmitSettings SetDegreeOfParallelism(this AzureDlaJobSubmitSettings toolSettings, string degreeOfParallelism)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DegreeOfParallelism = degreeOfParallelism;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobSubmitSettings.DegreeOfParallelism"/>.</em></p><p>The degree of parallelism for the job.</p></summary>
        [Pure]
        public static AzureDlaJobSubmitSettings ResetDegreeOfParallelism(this AzureDlaJobSubmitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DegreeOfParallelism = null;
            return toolSettings;
        }
        #endregion
        #region PipelineId
        /// <summary><p><em>Sets <see cref="AzureDlaJobSubmitSettings.PipelineId"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureDlaJobSubmitSettings SetPipelineId(this AzureDlaJobSubmitSettings toolSettings, string pipelineId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PipelineId = pipelineId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobSubmitSettings.PipelineId"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureDlaJobSubmitSettings ResetPipelineId(this AzureDlaJobSubmitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PipelineId = null;
            return toolSettings;
        }
        #endregion
        #region PipelineName
        /// <summary><p><em>Sets <see cref="AzureDlaJobSubmitSettings.PipelineName"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureDlaJobSubmitSettings SetPipelineName(this AzureDlaJobSubmitSettings toolSettings, string pipelineName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PipelineName = pipelineName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobSubmitSettings.PipelineName"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureDlaJobSubmitSettings ResetPipelineName(this AzureDlaJobSubmitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PipelineName = null;
            return toolSettings;
        }
        #endregion
        #region PipelineUri
        /// <summary><p><em>Sets <see cref="AzureDlaJobSubmitSettings.PipelineUri"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureDlaJobSubmitSettings SetPipelineUri(this AzureDlaJobSubmitSettings toolSettings, string pipelineUri)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PipelineUri = pipelineUri;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobSubmitSettings.PipelineUri"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureDlaJobSubmitSettings ResetPipelineUri(this AzureDlaJobSubmitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PipelineUri = null;
            return toolSettings;
        }
        #endregion
        #region Priority
        /// <summary><p><em>Sets <see cref="AzureDlaJobSubmitSettings.Priority"/>.</em></p><p>The priority of the job.</p></summary>
        [Pure]
        public static AzureDlaJobSubmitSettings SetPriority(this AzureDlaJobSubmitSettings toolSettings, int? priority)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Priority = priority;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobSubmitSettings.Priority"/>.</em></p><p>The priority of the job.</p></summary>
        [Pure]
        public static AzureDlaJobSubmitSettings ResetPriority(this AzureDlaJobSubmitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Priority = null;
            return toolSettings;
        }
        #endregion
        #region RecurrenceId
        /// <summary><p><em>Sets <see cref="AzureDlaJobSubmitSettings.RecurrenceId"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureDlaJobSubmitSettings SetRecurrenceId(this AzureDlaJobSubmitSettings toolSettings, string recurrenceId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RecurrenceId = recurrenceId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobSubmitSettings.RecurrenceId"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureDlaJobSubmitSettings ResetRecurrenceId(this AzureDlaJobSubmitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RecurrenceId = null;
            return toolSettings;
        }
        #endregion
        #region RecurrenceName
        /// <summary><p><em>Sets <see cref="AzureDlaJobSubmitSettings.RecurrenceName"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureDlaJobSubmitSettings SetRecurrenceName(this AzureDlaJobSubmitSettings toolSettings, string recurrenceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RecurrenceName = recurrenceName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobSubmitSettings.RecurrenceName"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureDlaJobSubmitSettings ResetRecurrenceName(this AzureDlaJobSubmitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RecurrenceName = null;
            return toolSettings;
        }
        #endregion
        #region RunId
        /// <summary><p><em>Sets <see cref="AzureDlaJobSubmitSettings.RunId"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureDlaJobSubmitSettings SetRunId(this AzureDlaJobSubmitSettings toolSettings, string runId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RunId = runId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobSubmitSettings.RunId"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureDlaJobSubmitSettings ResetRunId(this AzureDlaJobSubmitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RunId = null;
            return toolSettings;
        }
        #endregion
        #region RuntimeVersion
        /// <summary><p><em>Sets <see cref="AzureDlaJobSubmitSettings.RuntimeVersion"/>.</em></p><p>The runtime version to use.</p></summary>
        [Pure]
        public static AzureDlaJobSubmitSettings SetRuntimeVersion(this AzureDlaJobSubmitSettings toolSettings, string runtimeVersion)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RuntimeVersion = runtimeVersion;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobSubmitSettings.RuntimeVersion"/>.</em></p><p>The runtime version to use.</p></summary>
        [Pure]
        public static AzureDlaJobSubmitSettings ResetRuntimeVersion(this AzureDlaJobSubmitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RuntimeVersion = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlaJobSubmitSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaJobSubmitSettings SetDebug(this AzureDlaJobSubmitSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobSubmitSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaJobSubmitSettings ResetDebug(this AzureDlaJobSubmitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlaJobSubmitSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaJobSubmitSettings SetHelp(this AzureDlaJobSubmitSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobSubmitSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaJobSubmitSettings ResetHelp(this AzureDlaJobSubmitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlaJobSubmitSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaJobSubmitSettings SetOutput(this AzureDlaJobSubmitSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobSubmitSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaJobSubmitSettings ResetOutput(this AzureDlaJobSubmitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlaJobSubmitSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaJobSubmitSettings SetQuery(this AzureDlaJobSubmitSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobSubmitSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaJobSubmitSettings ResetQuery(this AzureDlaJobSubmitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlaJobSubmitSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaJobSubmitSettings SetVerbose(this AzureDlaJobSubmitSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobSubmitSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaJobSubmitSettings ResetVerbose(this AzureDlaJobSubmitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlaJobWaitSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlaJobWaitSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlaJobWaitSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaJobWaitSettings SetAccount(this AzureDlaJobWaitSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobWaitSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaJobWaitSettings ResetAccount(this AzureDlaJobWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region JobId
        /// <summary><p><em>Sets <see cref="AzureDlaJobWaitSettings.JobId"/>.</em></p><p>Job ID to poll for completion.</p></summary>
        [Pure]
        public static AzureDlaJobWaitSettings SetJobId(this AzureDlaJobWaitSettings toolSettings, string jobId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.JobId = jobId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobWaitSettings.JobId"/>.</em></p><p>Job ID to poll for completion.</p></summary>
        [Pure]
        public static AzureDlaJobWaitSettings ResetJobId(this AzureDlaJobWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.JobId = null;
            return toolSettings;
        }
        #endregion
        #region MaxWaitTimeSec
        /// <summary><p><em>Sets <see cref="AzureDlaJobWaitSettings.MaxWaitTimeSec"/>.</em></p><p>The maximum amount of time to wait before erroring out. Default value is to never timeout. Any value &lt;= 0 means never timeout.</p></summary>
        [Pure]
        public static AzureDlaJobWaitSettings SetMaxWaitTimeSec(this AzureDlaJobWaitSettings toolSettings, string maxWaitTimeSec)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MaxWaitTimeSec = maxWaitTimeSec;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobWaitSettings.MaxWaitTimeSec"/>.</em></p><p>The maximum amount of time to wait before erroring out. Default value is to never timeout. Any value &lt;= 0 means never timeout.</p></summary>
        [Pure]
        public static AzureDlaJobWaitSettings ResetMaxWaitTimeSec(this AzureDlaJobWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MaxWaitTimeSec = null;
            return toolSettings;
        }
        #endregion
        #region WaitIntervalSec
        /// <summary><p><em>Sets <see cref="AzureDlaJobWaitSettings.WaitIntervalSec"/>.</em></p><p>The polling interval between checks for the job status, in seconds.</p></summary>
        [Pure]
        public static AzureDlaJobWaitSettings SetWaitIntervalSec(this AzureDlaJobWaitSettings toolSettings, string waitIntervalSec)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WaitIntervalSec = waitIntervalSec;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobWaitSettings.WaitIntervalSec"/>.</em></p><p>The polling interval between checks for the job status, in seconds.</p></summary>
        [Pure]
        public static AzureDlaJobWaitSettings ResetWaitIntervalSec(this AzureDlaJobWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WaitIntervalSec = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlaJobWaitSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaJobWaitSettings SetDebug(this AzureDlaJobWaitSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobWaitSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaJobWaitSettings ResetDebug(this AzureDlaJobWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlaJobWaitSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaJobWaitSettings SetHelp(this AzureDlaJobWaitSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobWaitSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaJobWaitSettings ResetHelp(this AzureDlaJobWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlaJobWaitSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaJobWaitSettings SetOutput(this AzureDlaJobWaitSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobWaitSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaJobWaitSettings ResetOutput(this AzureDlaJobWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlaJobWaitSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaJobWaitSettings SetQuery(this AzureDlaJobWaitSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobWaitSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaJobWaitSettings ResetQuery(this AzureDlaJobWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlaJobWaitSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaJobWaitSettings SetVerbose(this AzureDlaJobWaitSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobWaitSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaJobWaitSettings ResetVerbose(this AzureDlaJobWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlaAccountBlobStorageAddSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlaAccountBlobStorageAddSettingsExtensions
    {
        #region AccessKey
        /// <summary><p><em>Sets <see cref="AzureDlaAccountBlobStorageAddSettings.AccessKey"/>.</em></p><p>The access key associated with this Azure Storage account that will be used to connect to it.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageAddSettings SetAccessKey(this AzureDlaAccountBlobStorageAddSettings toolSettings, string accessKey)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccessKey = accessKey;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountBlobStorageAddSettings.AccessKey"/>.</em></p><p>The access key associated with this Azure Storage account that will be used to connect to it.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageAddSettings ResetAccessKey(this AzureDlaAccountBlobStorageAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccessKey = null;
            return toolSettings;
        }
        #endregion
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlaAccountBlobStorageAddSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageAddSettings SetAccount(this AzureDlaAccountBlobStorageAddSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountBlobStorageAddSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageAddSettings ResetAccount(this AzureDlaAccountBlobStorageAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region StorageAccountName
        /// <summary><p><em>Sets <see cref="AzureDlaAccountBlobStorageAddSettings.StorageAccountName"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageAddSettings SetStorageAccountName(this AzureDlaAccountBlobStorageAddSettings toolSettings, string storageAccountName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageAccountName = storageAccountName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountBlobStorageAddSettings.StorageAccountName"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageAddSettings ResetStorageAccountName(this AzureDlaAccountBlobStorageAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageAccountName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureDlaAccountBlobStorageAddSettings.ResourceGroup"/>.</em></p><p>If not specified, will attempt to discover the resource group for the specified Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageAddSettings SetResourceGroup(this AzureDlaAccountBlobStorageAddSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountBlobStorageAddSettings.ResourceGroup"/>.</em></p><p>If not specified, will attempt to discover the resource group for the specified Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageAddSettings ResetResourceGroup(this AzureDlaAccountBlobStorageAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Suffix
        /// <summary><p><em>Sets <see cref="AzureDlaAccountBlobStorageAddSettings.Suffix"/>.</em></p><p>The optional suffix for the storage account.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageAddSettings SetSuffix(this AzureDlaAccountBlobStorageAddSettings toolSettings, string suffix)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Suffix = suffix;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountBlobStorageAddSettings.Suffix"/>.</em></p><p>The optional suffix for the storage account.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageAddSettings ResetSuffix(this AzureDlaAccountBlobStorageAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Suffix = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlaAccountBlobStorageAddSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageAddSettings SetDebug(this AzureDlaAccountBlobStorageAddSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountBlobStorageAddSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageAddSettings ResetDebug(this AzureDlaAccountBlobStorageAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlaAccountBlobStorageAddSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageAddSettings SetHelp(this AzureDlaAccountBlobStorageAddSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountBlobStorageAddSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageAddSettings ResetHelp(this AzureDlaAccountBlobStorageAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlaAccountBlobStorageAddSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageAddSettings SetOutput(this AzureDlaAccountBlobStorageAddSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountBlobStorageAddSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageAddSettings ResetOutput(this AzureDlaAccountBlobStorageAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlaAccountBlobStorageAddSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageAddSettings SetQuery(this AzureDlaAccountBlobStorageAddSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountBlobStorageAddSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageAddSettings ResetQuery(this AzureDlaAccountBlobStorageAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlaAccountBlobStorageAddSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageAddSettings SetVerbose(this AzureDlaAccountBlobStorageAddSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountBlobStorageAddSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageAddSettings ResetVerbose(this AzureDlaAccountBlobStorageAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlaAccountBlobStorageDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlaAccountBlobStorageDeleteSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlaAccountBlobStorageDeleteSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageDeleteSettings SetAccount(this AzureDlaAccountBlobStorageDeleteSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountBlobStorageDeleteSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageDeleteSettings ResetAccount(this AzureDlaAccountBlobStorageDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region StorageAccountName
        /// <summary><p><em>Sets <see cref="AzureDlaAccountBlobStorageDeleteSettings.StorageAccountName"/>.</em></p><p>The name of the Azure Storage account to remove.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageDeleteSettings SetStorageAccountName(this AzureDlaAccountBlobStorageDeleteSettings toolSettings, string storageAccountName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageAccountName = storageAccountName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountBlobStorageDeleteSettings.StorageAccountName"/>.</em></p><p>The name of the Azure Storage account to remove.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageDeleteSettings ResetStorageAccountName(this AzureDlaAccountBlobStorageDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageAccountName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureDlaAccountBlobStorageDeleteSettings.ResourceGroup"/>.</em></p><p>If not specified, will attempt to discover the resource group for the specified Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageDeleteSettings SetResourceGroup(this AzureDlaAccountBlobStorageDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountBlobStorageDeleteSettings.ResourceGroup"/>.</em></p><p>If not specified, will attempt to discover the resource group for the specified Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageDeleteSettings ResetResourceGroup(this AzureDlaAccountBlobStorageDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlaAccountBlobStorageDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageDeleteSettings SetDebug(this AzureDlaAccountBlobStorageDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountBlobStorageDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageDeleteSettings ResetDebug(this AzureDlaAccountBlobStorageDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlaAccountBlobStorageDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageDeleteSettings SetHelp(this AzureDlaAccountBlobStorageDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountBlobStorageDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageDeleteSettings ResetHelp(this AzureDlaAccountBlobStorageDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlaAccountBlobStorageDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageDeleteSettings SetOutput(this AzureDlaAccountBlobStorageDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountBlobStorageDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageDeleteSettings ResetOutput(this AzureDlaAccountBlobStorageDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlaAccountBlobStorageDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageDeleteSettings SetQuery(this AzureDlaAccountBlobStorageDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountBlobStorageDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageDeleteSettings ResetQuery(this AzureDlaAccountBlobStorageDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlaAccountBlobStorageDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageDeleteSettings SetVerbose(this AzureDlaAccountBlobStorageDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountBlobStorageDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageDeleteSettings ResetVerbose(this AzureDlaAccountBlobStorageDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlaAccountBlobStorageListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlaAccountBlobStorageListSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlaAccountBlobStorageListSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageListSettings SetAccount(this AzureDlaAccountBlobStorageListSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountBlobStorageListSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageListSettings ResetAccount(this AzureDlaAccountBlobStorageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region Count
        /// <summary><p><em>Sets <see cref="AzureDlaAccountBlobStorageListSettings.Count"/>.</em></p><p>The Boolean value of true or false to request a count of the matching resources included with the resources in the response, e.g. Categories?$count=true.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageListSettings SetCount(this AzureDlaAccountBlobStorageListSettings toolSettings, string count)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Count = count;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountBlobStorageListSettings.Count"/>.</em></p><p>The Boolean value of true or false to request a count of the matching resources included with the resources in the response, e.g. Categories?$count=true.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageListSettings ResetCount(this AzureDlaAccountBlobStorageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Count = null;
            return toolSettings;
        }
        #endregion
        #region Filter
        /// <summary><p><em>Sets <see cref="AzureDlaAccountBlobStorageListSettings.Filter"/>.</em></p><p>The OData filter. Optional.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageListSettings SetFilter(this AzureDlaAccountBlobStorageListSettings toolSettings, string filter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = filter;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountBlobStorageListSettings.Filter"/>.</em></p><p>The OData filter. Optional.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageListSettings ResetFilter(this AzureDlaAccountBlobStorageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = null;
            return toolSettings;
        }
        #endregion
        #region Orderby
        /// <summary><p><em>Sets <see cref="AzureDlaAccountBlobStorageListSettings.Orderby"/> to a new list.</em></p><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageListSettings SetOrderby(this AzureDlaAccountBlobStorageListSettings toolSettings, params string[] orderby)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OrderbyInternal = orderby.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureDlaAccountBlobStorageListSettings.Orderby"/> to a new list.</em></p><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageListSettings SetOrderby(this AzureDlaAccountBlobStorageListSettings toolSettings, IEnumerable<string> orderby)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OrderbyInternal = orderby.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureDlaAccountBlobStorageListSettings.Orderby"/>.</em></p><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageListSettings AddOrderby(this AzureDlaAccountBlobStorageListSettings toolSettings, params string[] orderby)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OrderbyInternal.AddRange(orderby);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureDlaAccountBlobStorageListSettings.Orderby"/>.</em></p><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageListSettings AddOrderby(this AzureDlaAccountBlobStorageListSettings toolSettings, IEnumerable<string> orderby)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OrderbyInternal.AddRange(orderby);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureDlaAccountBlobStorageListSettings.Orderby"/>.</em></p><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageListSettings ClearOrderby(this AzureDlaAccountBlobStorageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OrderbyInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureDlaAccountBlobStorageListSettings.Orderby"/>.</em></p><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageListSettings RemoveOrderby(this AzureDlaAccountBlobStorageListSettings toolSettings, params string[] orderby)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(orderby);
            toolSettings.OrderbyInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureDlaAccountBlobStorageListSettings.Orderby"/>.</em></p><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageListSettings RemoveOrderby(this AzureDlaAccountBlobStorageListSettings toolSettings, IEnumerable<string> orderby)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(orderby);
            toolSettings.OrderbyInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureDlaAccountBlobStorageListSettings.ResourceGroup"/>.</em></p><p>If not specified, will attempt to discover the resource group for the specified Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageListSettings SetResourceGroup(this AzureDlaAccountBlobStorageListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountBlobStorageListSettings.ResourceGroup"/>.</em></p><p>If not specified, will attempt to discover the resource group for the specified Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageListSettings ResetResourceGroup(this AzureDlaAccountBlobStorageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Select
        /// <summary><p><em>Sets <see cref="AzureDlaAccountBlobStorageListSettings.Select"/>.</em></p><p>OData Select statement. Limits the properties on each entry to just those requested, e.g. Categories?$select=CategoryName,Description. Optional.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageListSettings SetSelect(this AzureDlaAccountBlobStorageListSettings toolSettings, string select)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Select = select;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountBlobStorageListSettings.Select"/>.</em></p><p>OData Select statement. Limits the properties on each entry to just those requested, e.g. Categories?$select=CategoryName,Description. Optional.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageListSettings ResetSelect(this AzureDlaAccountBlobStorageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Select = null;
            return toolSettings;
        }
        #endregion
        #region Skip
        /// <summary><p><em>Sets <see cref="AzureDlaAccountBlobStorageListSettings.Skip"/>.</em></p><p>The number of items to skip over before returning elements.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageListSettings SetSkip(this AzureDlaAccountBlobStorageListSettings toolSettings, string skip)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Skip = skip;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountBlobStorageListSettings.Skip"/>.</em></p><p>The number of items to skip over before returning elements.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageListSettings ResetSkip(this AzureDlaAccountBlobStorageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Skip = null;
            return toolSettings;
        }
        #endregion
        #region Top
        /// <summary><p><em>Sets <see cref="AzureDlaAccountBlobStorageListSettings.Top"/>.</em></p><p>Maximum number of items to return.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageListSettings SetTop(this AzureDlaAccountBlobStorageListSettings toolSettings, int? top)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = top;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountBlobStorageListSettings.Top"/>.</em></p><p>Maximum number of items to return.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageListSettings ResetTop(this AzureDlaAccountBlobStorageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlaAccountBlobStorageListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageListSettings SetDebug(this AzureDlaAccountBlobStorageListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountBlobStorageListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageListSettings ResetDebug(this AzureDlaAccountBlobStorageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlaAccountBlobStorageListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageListSettings SetHelp(this AzureDlaAccountBlobStorageListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountBlobStorageListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageListSettings ResetHelp(this AzureDlaAccountBlobStorageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlaAccountBlobStorageListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageListSettings SetOutput(this AzureDlaAccountBlobStorageListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountBlobStorageListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageListSettings ResetOutput(this AzureDlaAccountBlobStorageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlaAccountBlobStorageListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageListSettings SetQuery(this AzureDlaAccountBlobStorageListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountBlobStorageListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageListSettings ResetQuery(this AzureDlaAccountBlobStorageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlaAccountBlobStorageListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageListSettings SetVerbose(this AzureDlaAccountBlobStorageListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountBlobStorageListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageListSettings ResetVerbose(this AzureDlaAccountBlobStorageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlaAccountBlobStorageShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlaAccountBlobStorageShowSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlaAccountBlobStorageShowSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageShowSettings SetAccount(this AzureDlaAccountBlobStorageShowSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountBlobStorageShowSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageShowSettings ResetAccount(this AzureDlaAccountBlobStorageShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region StorageAccountName
        /// <summary><p><em>Sets <see cref="AzureDlaAccountBlobStorageShowSettings.StorageAccountName"/>.</em></p><p>The name of the Azure Storage account for which to retrieve the details.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageShowSettings SetStorageAccountName(this AzureDlaAccountBlobStorageShowSettings toolSettings, string storageAccountName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageAccountName = storageAccountName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountBlobStorageShowSettings.StorageAccountName"/>.</em></p><p>The name of the Azure Storage account for which to retrieve the details.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageShowSettings ResetStorageAccountName(this AzureDlaAccountBlobStorageShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageAccountName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureDlaAccountBlobStorageShowSettings.ResourceGroup"/>.</em></p><p>If not specified, will attempt to discover the resource group for the specified Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageShowSettings SetResourceGroup(this AzureDlaAccountBlobStorageShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountBlobStorageShowSettings.ResourceGroup"/>.</em></p><p>If not specified, will attempt to discover the resource group for the specified Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageShowSettings ResetResourceGroup(this AzureDlaAccountBlobStorageShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlaAccountBlobStorageShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageShowSettings SetDebug(this AzureDlaAccountBlobStorageShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountBlobStorageShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageShowSettings ResetDebug(this AzureDlaAccountBlobStorageShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlaAccountBlobStorageShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageShowSettings SetHelp(this AzureDlaAccountBlobStorageShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountBlobStorageShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageShowSettings ResetHelp(this AzureDlaAccountBlobStorageShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlaAccountBlobStorageShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageShowSettings SetOutput(this AzureDlaAccountBlobStorageShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountBlobStorageShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageShowSettings ResetOutput(this AzureDlaAccountBlobStorageShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlaAccountBlobStorageShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageShowSettings SetQuery(this AzureDlaAccountBlobStorageShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountBlobStorageShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageShowSettings ResetQuery(this AzureDlaAccountBlobStorageShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlaAccountBlobStorageShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageShowSettings SetVerbose(this AzureDlaAccountBlobStorageShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountBlobStorageShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageShowSettings ResetVerbose(this AzureDlaAccountBlobStorageShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlaAccountBlobStorageUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlaAccountBlobStorageUpdateSettingsExtensions
    {
        #region AccessKey
        /// <summary><p><em>Sets <see cref="AzureDlaAccountBlobStorageUpdateSettings.AccessKey"/>.</em></p><p>The access key associated with this Azure Storage account that will be used to connect to it.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageUpdateSettings SetAccessKey(this AzureDlaAccountBlobStorageUpdateSettings toolSettings, string accessKey)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccessKey = accessKey;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountBlobStorageUpdateSettings.AccessKey"/>.</em></p><p>The access key associated with this Azure Storage account that will be used to connect to it.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageUpdateSettings ResetAccessKey(this AzureDlaAccountBlobStorageUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccessKey = null;
            return toolSettings;
        }
        #endregion
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlaAccountBlobStorageUpdateSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageUpdateSettings SetAccount(this AzureDlaAccountBlobStorageUpdateSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountBlobStorageUpdateSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageUpdateSettings ResetAccount(this AzureDlaAccountBlobStorageUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region StorageAccountName
        /// <summary><p><em>Sets <see cref="AzureDlaAccountBlobStorageUpdateSettings.StorageAccountName"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageUpdateSettings SetStorageAccountName(this AzureDlaAccountBlobStorageUpdateSettings toolSettings, string storageAccountName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageAccountName = storageAccountName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountBlobStorageUpdateSettings.StorageAccountName"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageUpdateSettings ResetStorageAccountName(this AzureDlaAccountBlobStorageUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageAccountName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureDlaAccountBlobStorageUpdateSettings.ResourceGroup"/>.</em></p><p>If not specified, will attempt to discover the resource group for the specified Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageUpdateSettings SetResourceGroup(this AzureDlaAccountBlobStorageUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountBlobStorageUpdateSettings.ResourceGroup"/>.</em></p><p>If not specified, will attempt to discover the resource group for the specified Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageUpdateSettings ResetResourceGroup(this AzureDlaAccountBlobStorageUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Suffix
        /// <summary><p><em>Sets <see cref="AzureDlaAccountBlobStorageUpdateSettings.Suffix"/>.</em></p><p>The optional suffix for the storage account.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageUpdateSettings SetSuffix(this AzureDlaAccountBlobStorageUpdateSettings toolSettings, string suffix)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Suffix = suffix;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountBlobStorageUpdateSettings.Suffix"/>.</em></p><p>The optional suffix for the storage account.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageUpdateSettings ResetSuffix(this AzureDlaAccountBlobStorageUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Suffix = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlaAccountBlobStorageUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageUpdateSettings SetDebug(this AzureDlaAccountBlobStorageUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountBlobStorageUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageUpdateSettings ResetDebug(this AzureDlaAccountBlobStorageUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlaAccountBlobStorageUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageUpdateSettings SetHelp(this AzureDlaAccountBlobStorageUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountBlobStorageUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageUpdateSettings ResetHelp(this AzureDlaAccountBlobStorageUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlaAccountBlobStorageUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageUpdateSettings SetOutput(this AzureDlaAccountBlobStorageUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountBlobStorageUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageUpdateSettings ResetOutput(this AzureDlaAccountBlobStorageUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlaAccountBlobStorageUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageUpdateSettings SetQuery(this AzureDlaAccountBlobStorageUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountBlobStorageUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageUpdateSettings ResetQuery(this AzureDlaAccountBlobStorageUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlaAccountBlobStorageUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageUpdateSettings SetVerbose(this AzureDlaAccountBlobStorageUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountBlobStorageUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountBlobStorageUpdateSettings ResetVerbose(this AzureDlaAccountBlobStorageUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlaAccountComputePolicyCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlaAccountComputePolicyCreateSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlaAccountComputePolicyCreateSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyCreateSettings SetAccount(this AzureDlaAccountComputePolicyCreateSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountComputePolicyCreateSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyCreateSettings ResetAccount(this AzureDlaAccountComputePolicyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region ComputePolicyName
        /// <summary><p><em>Sets <see cref="AzureDlaAccountComputePolicyCreateSettings.ComputePolicyName"/>.</em></p><p>The name of the compute policy to create.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyCreateSettings SetComputePolicyName(this AzureDlaAccountComputePolicyCreateSettings toolSettings, string computePolicyName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ComputePolicyName = computePolicyName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountComputePolicyCreateSettings.ComputePolicyName"/>.</em></p><p>The name of the compute policy to create.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyCreateSettings ResetComputePolicyName(this AzureDlaAccountComputePolicyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ComputePolicyName = null;
            return toolSettings;
        }
        #endregion
        #region ObjectId
        /// <summary><p><em>Sets <see cref="AzureDlaAccountComputePolicyCreateSettings.ObjectId"/>.</em></p><p>The Azure Active Directory object ID of the user, group, or service principal to apply the policy to.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyCreateSettings SetObjectId(this AzureDlaAccountComputePolicyCreateSettings toolSettings, string objectId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ObjectId = objectId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountComputePolicyCreateSettings.ObjectId"/>.</em></p><p>The Azure Active Directory object ID of the user, group, or service principal to apply the policy to.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyCreateSettings ResetObjectId(this AzureDlaAccountComputePolicyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ObjectId = null;
            return toolSettings;
        }
        #endregion
        #region ObjectType
        /// <summary><p><em>Sets <see cref="AzureDlaAccountComputePolicyCreateSettings.ObjectType"/>.</em></p><p>The Azure Active Directory object type associated with the supplied object ID.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyCreateSettings SetObjectType(this AzureDlaAccountComputePolicyCreateSettings toolSettings, string objectType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ObjectType = objectType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountComputePolicyCreateSettings.ObjectType"/>.</em></p><p>The Azure Active Directory object type associated with the supplied object ID.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyCreateSettings ResetObjectType(this AzureDlaAccountComputePolicyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ObjectType = null;
            return toolSettings;
        }
        #endregion
        #region MaxDopPerJob
        /// <summary><p><em>Sets <see cref="AzureDlaAccountComputePolicyCreateSettings.MaxDopPerJob"/>.</em></p><p>The maximum degree of parallelism allowed per job for this policy. At least one of `--min-priority-per-job` and `--max-dop-per-job` must be specified.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyCreateSettings SetMaxDopPerJob(this AzureDlaAccountComputePolicyCreateSettings toolSettings, string maxDopPerJob)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MaxDopPerJob = maxDopPerJob;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountComputePolicyCreateSettings.MaxDopPerJob"/>.</em></p><p>The maximum degree of parallelism allowed per job for this policy. At least one of `--min-priority-per-job` and `--max-dop-per-job` must be specified.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyCreateSettings ResetMaxDopPerJob(this AzureDlaAccountComputePolicyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MaxDopPerJob = null;
            return toolSettings;
        }
        #endregion
        #region MinPriorityPerJob
        /// <summary><p><em>Sets <see cref="AzureDlaAccountComputePolicyCreateSettings.MinPriorityPerJob"/>.</em></p><p>The minimum priority allowed per job for this policy. At least one of `--min-priority-per-job` and `--max-dop-per-job` must be specified.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyCreateSettings SetMinPriorityPerJob(this AzureDlaAccountComputePolicyCreateSettings toolSettings, string minPriorityPerJob)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MinPriorityPerJob = minPriorityPerJob;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountComputePolicyCreateSettings.MinPriorityPerJob"/>.</em></p><p>The minimum priority allowed per job for this policy. At least one of `--min-priority-per-job` and `--max-dop-per-job` must be specified.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyCreateSettings ResetMinPriorityPerJob(this AzureDlaAccountComputePolicyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MinPriorityPerJob = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureDlaAccountComputePolicyCreateSettings.ResourceGroup"/>.</em></p><p>If not specified, will attempt to discover the resource group for the specified Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyCreateSettings SetResourceGroup(this AzureDlaAccountComputePolicyCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountComputePolicyCreateSettings.ResourceGroup"/>.</em></p><p>If not specified, will attempt to discover the resource group for the specified Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyCreateSettings ResetResourceGroup(this AzureDlaAccountComputePolicyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlaAccountComputePolicyCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyCreateSettings SetDebug(this AzureDlaAccountComputePolicyCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountComputePolicyCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyCreateSettings ResetDebug(this AzureDlaAccountComputePolicyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlaAccountComputePolicyCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyCreateSettings SetHelp(this AzureDlaAccountComputePolicyCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountComputePolicyCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyCreateSettings ResetHelp(this AzureDlaAccountComputePolicyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlaAccountComputePolicyCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyCreateSettings SetOutput(this AzureDlaAccountComputePolicyCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountComputePolicyCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyCreateSettings ResetOutput(this AzureDlaAccountComputePolicyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlaAccountComputePolicyCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyCreateSettings SetQuery(this AzureDlaAccountComputePolicyCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountComputePolicyCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyCreateSettings ResetQuery(this AzureDlaAccountComputePolicyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlaAccountComputePolicyCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyCreateSettings SetVerbose(this AzureDlaAccountComputePolicyCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountComputePolicyCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyCreateSettings ResetVerbose(this AzureDlaAccountComputePolicyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlaAccountComputePolicyDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlaAccountComputePolicyDeleteSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlaAccountComputePolicyDeleteSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyDeleteSettings SetAccount(this AzureDlaAccountComputePolicyDeleteSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountComputePolicyDeleteSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyDeleteSettings ResetAccount(this AzureDlaAccountComputePolicyDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region ComputePolicyName
        /// <summary><p><em>Sets <see cref="AzureDlaAccountComputePolicyDeleteSettings.ComputePolicyName"/>.</em></p><p>The name of the compute policy to delete.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyDeleteSettings SetComputePolicyName(this AzureDlaAccountComputePolicyDeleteSettings toolSettings, string computePolicyName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ComputePolicyName = computePolicyName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountComputePolicyDeleteSettings.ComputePolicyName"/>.</em></p><p>The name of the compute policy to delete.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyDeleteSettings ResetComputePolicyName(this AzureDlaAccountComputePolicyDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ComputePolicyName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureDlaAccountComputePolicyDeleteSettings.ResourceGroup"/>.</em></p><p>If not specified, will attempt to discover the resource group for the specified Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyDeleteSettings SetResourceGroup(this AzureDlaAccountComputePolicyDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountComputePolicyDeleteSettings.ResourceGroup"/>.</em></p><p>If not specified, will attempt to discover the resource group for the specified Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyDeleteSettings ResetResourceGroup(this AzureDlaAccountComputePolicyDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlaAccountComputePolicyDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyDeleteSettings SetDebug(this AzureDlaAccountComputePolicyDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountComputePolicyDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyDeleteSettings ResetDebug(this AzureDlaAccountComputePolicyDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlaAccountComputePolicyDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyDeleteSettings SetHelp(this AzureDlaAccountComputePolicyDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountComputePolicyDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyDeleteSettings ResetHelp(this AzureDlaAccountComputePolicyDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlaAccountComputePolicyDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyDeleteSettings SetOutput(this AzureDlaAccountComputePolicyDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountComputePolicyDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyDeleteSettings ResetOutput(this AzureDlaAccountComputePolicyDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlaAccountComputePolicyDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyDeleteSettings SetQuery(this AzureDlaAccountComputePolicyDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountComputePolicyDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyDeleteSettings ResetQuery(this AzureDlaAccountComputePolicyDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlaAccountComputePolicyDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyDeleteSettings SetVerbose(this AzureDlaAccountComputePolicyDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountComputePolicyDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyDeleteSettings ResetVerbose(this AzureDlaAccountComputePolicyDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlaAccountComputePolicyListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlaAccountComputePolicyListSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlaAccountComputePolicyListSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyListSettings SetAccount(this AzureDlaAccountComputePolicyListSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountComputePolicyListSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyListSettings ResetAccount(this AzureDlaAccountComputePolicyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureDlaAccountComputePolicyListSettings.ResourceGroup"/>.</em></p><p>If not specified, will attempt to discover the resource group for the specified Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyListSettings SetResourceGroup(this AzureDlaAccountComputePolicyListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountComputePolicyListSettings.ResourceGroup"/>.</em></p><p>If not specified, will attempt to discover the resource group for the specified Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyListSettings ResetResourceGroup(this AzureDlaAccountComputePolicyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlaAccountComputePolicyListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyListSettings SetDebug(this AzureDlaAccountComputePolicyListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountComputePolicyListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyListSettings ResetDebug(this AzureDlaAccountComputePolicyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlaAccountComputePolicyListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyListSettings SetHelp(this AzureDlaAccountComputePolicyListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountComputePolicyListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyListSettings ResetHelp(this AzureDlaAccountComputePolicyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlaAccountComputePolicyListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyListSettings SetOutput(this AzureDlaAccountComputePolicyListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountComputePolicyListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyListSettings ResetOutput(this AzureDlaAccountComputePolicyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlaAccountComputePolicyListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyListSettings SetQuery(this AzureDlaAccountComputePolicyListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountComputePolicyListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyListSettings ResetQuery(this AzureDlaAccountComputePolicyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlaAccountComputePolicyListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyListSettings SetVerbose(this AzureDlaAccountComputePolicyListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountComputePolicyListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyListSettings ResetVerbose(this AzureDlaAccountComputePolicyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlaAccountComputePolicyShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlaAccountComputePolicyShowSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlaAccountComputePolicyShowSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyShowSettings SetAccount(this AzureDlaAccountComputePolicyShowSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountComputePolicyShowSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyShowSettings ResetAccount(this AzureDlaAccountComputePolicyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region ComputePolicyName
        /// <summary><p><em>Sets <see cref="AzureDlaAccountComputePolicyShowSettings.ComputePolicyName"/>.</em></p><p>The name of the compute policy to retrieve.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyShowSettings SetComputePolicyName(this AzureDlaAccountComputePolicyShowSettings toolSettings, string computePolicyName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ComputePolicyName = computePolicyName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountComputePolicyShowSettings.ComputePolicyName"/>.</em></p><p>The name of the compute policy to retrieve.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyShowSettings ResetComputePolicyName(this AzureDlaAccountComputePolicyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ComputePolicyName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureDlaAccountComputePolicyShowSettings.ResourceGroup"/>.</em></p><p>If not specified, will attempt to discover the resource group for the specified Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyShowSettings SetResourceGroup(this AzureDlaAccountComputePolicyShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountComputePolicyShowSettings.ResourceGroup"/>.</em></p><p>If not specified, will attempt to discover the resource group for the specified Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyShowSettings ResetResourceGroup(this AzureDlaAccountComputePolicyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlaAccountComputePolicyShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyShowSettings SetDebug(this AzureDlaAccountComputePolicyShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountComputePolicyShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyShowSettings ResetDebug(this AzureDlaAccountComputePolicyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlaAccountComputePolicyShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyShowSettings SetHelp(this AzureDlaAccountComputePolicyShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountComputePolicyShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyShowSettings ResetHelp(this AzureDlaAccountComputePolicyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlaAccountComputePolicyShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyShowSettings SetOutput(this AzureDlaAccountComputePolicyShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountComputePolicyShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyShowSettings ResetOutput(this AzureDlaAccountComputePolicyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlaAccountComputePolicyShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyShowSettings SetQuery(this AzureDlaAccountComputePolicyShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountComputePolicyShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyShowSettings ResetQuery(this AzureDlaAccountComputePolicyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlaAccountComputePolicyShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyShowSettings SetVerbose(this AzureDlaAccountComputePolicyShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountComputePolicyShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyShowSettings ResetVerbose(this AzureDlaAccountComputePolicyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlaAccountComputePolicyUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlaAccountComputePolicyUpdateSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlaAccountComputePolicyUpdateSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyUpdateSettings SetAccount(this AzureDlaAccountComputePolicyUpdateSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountComputePolicyUpdateSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyUpdateSettings ResetAccount(this AzureDlaAccountComputePolicyUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region ComputePolicyName
        /// <summary><p><em>Sets <see cref="AzureDlaAccountComputePolicyUpdateSettings.ComputePolicyName"/>.</em></p><p>The name of the compute policy to update.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyUpdateSettings SetComputePolicyName(this AzureDlaAccountComputePolicyUpdateSettings toolSettings, string computePolicyName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ComputePolicyName = computePolicyName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountComputePolicyUpdateSettings.ComputePolicyName"/>.</em></p><p>The name of the compute policy to update.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyUpdateSettings ResetComputePolicyName(this AzureDlaAccountComputePolicyUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ComputePolicyName = null;
            return toolSettings;
        }
        #endregion
        #region MaxDopPerJob
        /// <summary><p><em>Sets <see cref="AzureDlaAccountComputePolicyUpdateSettings.MaxDopPerJob"/>.</em></p><p>The maximum degree of parallelism allowed per job for this policy. At least one of `--min-priority-per-job` and `--max-dop-per-job` must be specified.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyUpdateSettings SetMaxDopPerJob(this AzureDlaAccountComputePolicyUpdateSettings toolSettings, string maxDopPerJob)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MaxDopPerJob = maxDopPerJob;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountComputePolicyUpdateSettings.MaxDopPerJob"/>.</em></p><p>The maximum degree of parallelism allowed per job for this policy. At least one of `--min-priority-per-job` and `--max-dop-per-job` must be specified.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyUpdateSettings ResetMaxDopPerJob(this AzureDlaAccountComputePolicyUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MaxDopPerJob = null;
            return toolSettings;
        }
        #endregion
        #region MinPriorityPerJob
        /// <summary><p><em>Sets <see cref="AzureDlaAccountComputePolicyUpdateSettings.MinPriorityPerJob"/>.</em></p><p>The minimum priority allowed per job for this policy. At least one of `--min-priority-per-job` and `--max-dop-per-job` must be specified.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyUpdateSettings SetMinPriorityPerJob(this AzureDlaAccountComputePolicyUpdateSettings toolSettings, string minPriorityPerJob)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MinPriorityPerJob = minPriorityPerJob;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountComputePolicyUpdateSettings.MinPriorityPerJob"/>.</em></p><p>The minimum priority allowed per job for this policy. At least one of `--min-priority-per-job` and `--max-dop-per-job` must be specified.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyUpdateSettings ResetMinPriorityPerJob(this AzureDlaAccountComputePolicyUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MinPriorityPerJob = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureDlaAccountComputePolicyUpdateSettings.ResourceGroup"/>.</em></p><p>If not specified, will attempt to discover the resource group for the specified Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyUpdateSettings SetResourceGroup(this AzureDlaAccountComputePolicyUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountComputePolicyUpdateSettings.ResourceGroup"/>.</em></p><p>If not specified, will attempt to discover the resource group for the specified Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyUpdateSettings ResetResourceGroup(this AzureDlaAccountComputePolicyUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlaAccountComputePolicyUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyUpdateSettings SetDebug(this AzureDlaAccountComputePolicyUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountComputePolicyUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyUpdateSettings ResetDebug(this AzureDlaAccountComputePolicyUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlaAccountComputePolicyUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyUpdateSettings SetHelp(this AzureDlaAccountComputePolicyUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountComputePolicyUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyUpdateSettings ResetHelp(this AzureDlaAccountComputePolicyUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlaAccountComputePolicyUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyUpdateSettings SetOutput(this AzureDlaAccountComputePolicyUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountComputePolicyUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyUpdateSettings ResetOutput(this AzureDlaAccountComputePolicyUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlaAccountComputePolicyUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyUpdateSettings SetQuery(this AzureDlaAccountComputePolicyUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountComputePolicyUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyUpdateSettings ResetQuery(this AzureDlaAccountComputePolicyUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlaAccountComputePolicyUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyUpdateSettings SetVerbose(this AzureDlaAccountComputePolicyUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountComputePolicyUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountComputePolicyUpdateSettings ResetVerbose(this AzureDlaAccountComputePolicyUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlaAccountDataLakeStoreAddSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlaAccountDataLakeStoreAddSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlaAccountDataLakeStoreAddSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountDataLakeStoreAddSettings SetAccount(this AzureDlaAccountDataLakeStoreAddSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountDataLakeStoreAddSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountDataLakeStoreAddSettings ResetAccount(this AzureDlaAccountDataLakeStoreAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region DataLakeStoreAccountName
        /// <summary><p><em>Sets <see cref="AzureDlaAccountDataLakeStoreAddSettings.DataLakeStoreAccountName"/>.</em></p><p>The name of the Data Lake Store account to add.</p></summary>
        [Pure]
        public static AzureDlaAccountDataLakeStoreAddSettings SetDataLakeStoreAccountName(this AzureDlaAccountDataLakeStoreAddSettings toolSettings, string dataLakeStoreAccountName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DataLakeStoreAccountName = dataLakeStoreAccountName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountDataLakeStoreAddSettings.DataLakeStoreAccountName"/>.</em></p><p>The name of the Data Lake Store account to add.</p></summary>
        [Pure]
        public static AzureDlaAccountDataLakeStoreAddSettings ResetDataLakeStoreAccountName(this AzureDlaAccountDataLakeStoreAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DataLakeStoreAccountName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureDlaAccountDataLakeStoreAddSettings.ResourceGroup"/>.</em></p><p>If not specified, will attempt to discover the resource group for the specified Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountDataLakeStoreAddSettings SetResourceGroup(this AzureDlaAccountDataLakeStoreAddSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountDataLakeStoreAddSettings.ResourceGroup"/>.</em></p><p>If not specified, will attempt to discover the resource group for the specified Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountDataLakeStoreAddSettings ResetResourceGroup(this AzureDlaAccountDataLakeStoreAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Suffix
        /// <summary><p><em>Sets <see cref="AzureDlaAccountDataLakeStoreAddSettings.Suffix"/>.</em></p><p>The optional suffix for the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlaAccountDataLakeStoreAddSettings SetSuffix(this AzureDlaAccountDataLakeStoreAddSettings toolSettings, string suffix)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Suffix = suffix;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountDataLakeStoreAddSettings.Suffix"/>.</em></p><p>The optional suffix for the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlaAccountDataLakeStoreAddSettings ResetSuffix(this AzureDlaAccountDataLakeStoreAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Suffix = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlaAccountDataLakeStoreAddSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountDataLakeStoreAddSettings SetDebug(this AzureDlaAccountDataLakeStoreAddSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountDataLakeStoreAddSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountDataLakeStoreAddSettings ResetDebug(this AzureDlaAccountDataLakeStoreAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlaAccountDataLakeStoreAddSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaAccountDataLakeStoreAddSettings SetHelp(this AzureDlaAccountDataLakeStoreAddSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountDataLakeStoreAddSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaAccountDataLakeStoreAddSettings ResetHelp(this AzureDlaAccountDataLakeStoreAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlaAccountDataLakeStoreAddSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaAccountDataLakeStoreAddSettings SetOutput(this AzureDlaAccountDataLakeStoreAddSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountDataLakeStoreAddSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaAccountDataLakeStoreAddSettings ResetOutput(this AzureDlaAccountDataLakeStoreAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlaAccountDataLakeStoreAddSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaAccountDataLakeStoreAddSettings SetQuery(this AzureDlaAccountDataLakeStoreAddSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountDataLakeStoreAddSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaAccountDataLakeStoreAddSettings ResetQuery(this AzureDlaAccountDataLakeStoreAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlaAccountDataLakeStoreAddSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountDataLakeStoreAddSettings SetVerbose(this AzureDlaAccountDataLakeStoreAddSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountDataLakeStoreAddSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountDataLakeStoreAddSettings ResetVerbose(this AzureDlaAccountDataLakeStoreAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlaAccountDataLakeStoreDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlaAccountDataLakeStoreDeleteSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlaAccountDataLakeStoreDeleteSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountDataLakeStoreDeleteSettings SetAccount(this AzureDlaAccountDataLakeStoreDeleteSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountDataLakeStoreDeleteSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountDataLakeStoreDeleteSettings ResetAccount(this AzureDlaAccountDataLakeStoreDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region DataLakeStoreAccountName
        /// <summary><p><em>Sets <see cref="AzureDlaAccountDataLakeStoreDeleteSettings.DataLakeStoreAccountName"/>.</em></p><p>The name of the Data Lake Store account to remove.</p></summary>
        [Pure]
        public static AzureDlaAccountDataLakeStoreDeleteSettings SetDataLakeStoreAccountName(this AzureDlaAccountDataLakeStoreDeleteSettings toolSettings, string dataLakeStoreAccountName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DataLakeStoreAccountName = dataLakeStoreAccountName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountDataLakeStoreDeleteSettings.DataLakeStoreAccountName"/>.</em></p><p>The name of the Data Lake Store account to remove.</p></summary>
        [Pure]
        public static AzureDlaAccountDataLakeStoreDeleteSettings ResetDataLakeStoreAccountName(this AzureDlaAccountDataLakeStoreDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DataLakeStoreAccountName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureDlaAccountDataLakeStoreDeleteSettings.ResourceGroup"/>.</em></p><p>If not specified, will attempt to discover the resource group for the specified Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountDataLakeStoreDeleteSettings SetResourceGroup(this AzureDlaAccountDataLakeStoreDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountDataLakeStoreDeleteSettings.ResourceGroup"/>.</em></p><p>If not specified, will attempt to discover the resource group for the specified Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountDataLakeStoreDeleteSettings ResetResourceGroup(this AzureDlaAccountDataLakeStoreDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlaAccountDataLakeStoreDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountDataLakeStoreDeleteSettings SetDebug(this AzureDlaAccountDataLakeStoreDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountDataLakeStoreDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountDataLakeStoreDeleteSettings ResetDebug(this AzureDlaAccountDataLakeStoreDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlaAccountDataLakeStoreDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaAccountDataLakeStoreDeleteSettings SetHelp(this AzureDlaAccountDataLakeStoreDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountDataLakeStoreDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaAccountDataLakeStoreDeleteSettings ResetHelp(this AzureDlaAccountDataLakeStoreDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlaAccountDataLakeStoreDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaAccountDataLakeStoreDeleteSettings SetOutput(this AzureDlaAccountDataLakeStoreDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountDataLakeStoreDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaAccountDataLakeStoreDeleteSettings ResetOutput(this AzureDlaAccountDataLakeStoreDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlaAccountDataLakeStoreDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaAccountDataLakeStoreDeleteSettings SetQuery(this AzureDlaAccountDataLakeStoreDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountDataLakeStoreDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaAccountDataLakeStoreDeleteSettings ResetQuery(this AzureDlaAccountDataLakeStoreDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlaAccountDataLakeStoreDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountDataLakeStoreDeleteSettings SetVerbose(this AzureDlaAccountDataLakeStoreDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountDataLakeStoreDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountDataLakeStoreDeleteSettings ResetVerbose(this AzureDlaAccountDataLakeStoreDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlaAccountDataLakeStoreListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlaAccountDataLakeStoreListSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlaAccountDataLakeStoreListSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountDataLakeStoreListSettings SetAccount(this AzureDlaAccountDataLakeStoreListSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountDataLakeStoreListSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountDataLakeStoreListSettings ResetAccount(this AzureDlaAccountDataLakeStoreListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region Count
        /// <summary><p><em>Sets <see cref="AzureDlaAccountDataLakeStoreListSettings.Count"/>.</em></p><p>The Boolean value of true or false to request a count of the matching resources included with the resources in the response, e.g. Categories?$count=true.</p></summary>
        [Pure]
        public static AzureDlaAccountDataLakeStoreListSettings SetCount(this AzureDlaAccountDataLakeStoreListSettings toolSettings, string count)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Count = count;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountDataLakeStoreListSettings.Count"/>.</em></p><p>The Boolean value of true or false to request a count of the matching resources included with the resources in the response, e.g. Categories?$count=true.</p></summary>
        [Pure]
        public static AzureDlaAccountDataLakeStoreListSettings ResetCount(this AzureDlaAccountDataLakeStoreListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Count = null;
            return toolSettings;
        }
        #endregion
        #region Filter
        /// <summary><p><em>Sets <see cref="AzureDlaAccountDataLakeStoreListSettings.Filter"/>.</em></p><p>OData filter. Optional.</p></summary>
        [Pure]
        public static AzureDlaAccountDataLakeStoreListSettings SetFilter(this AzureDlaAccountDataLakeStoreListSettings toolSettings, string filter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = filter;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountDataLakeStoreListSettings.Filter"/>.</em></p><p>OData filter. Optional.</p></summary>
        [Pure]
        public static AzureDlaAccountDataLakeStoreListSettings ResetFilter(this AzureDlaAccountDataLakeStoreListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = null;
            return toolSettings;
        }
        #endregion
        #region Orderby
        /// <summary><p><em>Sets <see cref="AzureDlaAccountDataLakeStoreListSettings.Orderby"/> to a new list.</em></p><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        [Pure]
        public static AzureDlaAccountDataLakeStoreListSettings SetOrderby(this AzureDlaAccountDataLakeStoreListSettings toolSettings, params string[] orderby)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OrderbyInternal = orderby.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureDlaAccountDataLakeStoreListSettings.Orderby"/> to a new list.</em></p><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        [Pure]
        public static AzureDlaAccountDataLakeStoreListSettings SetOrderby(this AzureDlaAccountDataLakeStoreListSettings toolSettings, IEnumerable<string> orderby)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OrderbyInternal = orderby.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureDlaAccountDataLakeStoreListSettings.Orderby"/>.</em></p><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        [Pure]
        public static AzureDlaAccountDataLakeStoreListSettings AddOrderby(this AzureDlaAccountDataLakeStoreListSettings toolSettings, params string[] orderby)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OrderbyInternal.AddRange(orderby);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureDlaAccountDataLakeStoreListSettings.Orderby"/>.</em></p><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        [Pure]
        public static AzureDlaAccountDataLakeStoreListSettings AddOrderby(this AzureDlaAccountDataLakeStoreListSettings toolSettings, IEnumerable<string> orderby)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OrderbyInternal.AddRange(orderby);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureDlaAccountDataLakeStoreListSettings.Orderby"/>.</em></p><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        [Pure]
        public static AzureDlaAccountDataLakeStoreListSettings ClearOrderby(this AzureDlaAccountDataLakeStoreListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OrderbyInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureDlaAccountDataLakeStoreListSettings.Orderby"/>.</em></p><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        [Pure]
        public static AzureDlaAccountDataLakeStoreListSettings RemoveOrderby(this AzureDlaAccountDataLakeStoreListSettings toolSettings, params string[] orderby)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(orderby);
            toolSettings.OrderbyInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureDlaAccountDataLakeStoreListSettings.Orderby"/>.</em></p><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        [Pure]
        public static AzureDlaAccountDataLakeStoreListSettings RemoveOrderby(this AzureDlaAccountDataLakeStoreListSettings toolSettings, IEnumerable<string> orderby)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(orderby);
            toolSettings.OrderbyInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureDlaAccountDataLakeStoreListSettings.ResourceGroup"/>.</em></p><p>If not specified, will attempt to discover the resource group for the specified Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountDataLakeStoreListSettings SetResourceGroup(this AzureDlaAccountDataLakeStoreListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountDataLakeStoreListSettings.ResourceGroup"/>.</em></p><p>If not specified, will attempt to discover the resource group for the specified Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountDataLakeStoreListSettings ResetResourceGroup(this AzureDlaAccountDataLakeStoreListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Select
        /// <summary><p><em>Sets <see cref="AzureDlaAccountDataLakeStoreListSettings.Select"/>.</em></p><p>OData Select statement. Limits the properties on each entry to just those requested, e.g. Categories?$select=CategoryName,Description. Optional.</p></summary>
        [Pure]
        public static AzureDlaAccountDataLakeStoreListSettings SetSelect(this AzureDlaAccountDataLakeStoreListSettings toolSettings, string select)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Select = select;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountDataLakeStoreListSettings.Select"/>.</em></p><p>OData Select statement. Limits the properties on each entry to just those requested, e.g. Categories?$select=CategoryName,Description. Optional.</p></summary>
        [Pure]
        public static AzureDlaAccountDataLakeStoreListSettings ResetSelect(this AzureDlaAccountDataLakeStoreListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Select = null;
            return toolSettings;
        }
        #endregion
        #region Skip
        /// <summary><p><em>Sets <see cref="AzureDlaAccountDataLakeStoreListSettings.Skip"/>.</em></p><p>The number of items to skip over before returning elements.</p></summary>
        [Pure]
        public static AzureDlaAccountDataLakeStoreListSettings SetSkip(this AzureDlaAccountDataLakeStoreListSettings toolSettings, string skip)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Skip = skip;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountDataLakeStoreListSettings.Skip"/>.</em></p><p>The number of items to skip over before returning elements.</p></summary>
        [Pure]
        public static AzureDlaAccountDataLakeStoreListSettings ResetSkip(this AzureDlaAccountDataLakeStoreListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Skip = null;
            return toolSettings;
        }
        #endregion
        #region Top
        /// <summary><p><em>Sets <see cref="AzureDlaAccountDataLakeStoreListSettings.Top"/>.</em></p><p>Maximum number of items to return.</p></summary>
        [Pure]
        public static AzureDlaAccountDataLakeStoreListSettings SetTop(this AzureDlaAccountDataLakeStoreListSettings toolSettings, int? top)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = top;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountDataLakeStoreListSettings.Top"/>.</em></p><p>Maximum number of items to return.</p></summary>
        [Pure]
        public static AzureDlaAccountDataLakeStoreListSettings ResetTop(this AzureDlaAccountDataLakeStoreListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlaAccountDataLakeStoreListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountDataLakeStoreListSettings SetDebug(this AzureDlaAccountDataLakeStoreListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountDataLakeStoreListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountDataLakeStoreListSettings ResetDebug(this AzureDlaAccountDataLakeStoreListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlaAccountDataLakeStoreListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaAccountDataLakeStoreListSettings SetHelp(this AzureDlaAccountDataLakeStoreListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountDataLakeStoreListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaAccountDataLakeStoreListSettings ResetHelp(this AzureDlaAccountDataLakeStoreListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlaAccountDataLakeStoreListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaAccountDataLakeStoreListSettings SetOutput(this AzureDlaAccountDataLakeStoreListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountDataLakeStoreListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaAccountDataLakeStoreListSettings ResetOutput(this AzureDlaAccountDataLakeStoreListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlaAccountDataLakeStoreListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaAccountDataLakeStoreListSettings SetQuery(this AzureDlaAccountDataLakeStoreListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountDataLakeStoreListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaAccountDataLakeStoreListSettings ResetQuery(this AzureDlaAccountDataLakeStoreListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlaAccountDataLakeStoreListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountDataLakeStoreListSettings SetVerbose(this AzureDlaAccountDataLakeStoreListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountDataLakeStoreListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountDataLakeStoreListSettings ResetVerbose(this AzureDlaAccountDataLakeStoreListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlaAccountDataLakeStoreShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlaAccountDataLakeStoreShowSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlaAccountDataLakeStoreShowSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountDataLakeStoreShowSettings SetAccount(this AzureDlaAccountDataLakeStoreShowSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountDataLakeStoreShowSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountDataLakeStoreShowSettings ResetAccount(this AzureDlaAccountDataLakeStoreShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region DataLakeStoreAccountName
        /// <summary><p><em>Sets <see cref="AzureDlaAccountDataLakeStoreShowSettings.DataLakeStoreAccountName"/>.</em></p><p>The name of the Data Lake Store account to retrieve.</p></summary>
        [Pure]
        public static AzureDlaAccountDataLakeStoreShowSettings SetDataLakeStoreAccountName(this AzureDlaAccountDataLakeStoreShowSettings toolSettings, string dataLakeStoreAccountName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DataLakeStoreAccountName = dataLakeStoreAccountName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountDataLakeStoreShowSettings.DataLakeStoreAccountName"/>.</em></p><p>The name of the Data Lake Store account to retrieve.</p></summary>
        [Pure]
        public static AzureDlaAccountDataLakeStoreShowSettings ResetDataLakeStoreAccountName(this AzureDlaAccountDataLakeStoreShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DataLakeStoreAccountName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureDlaAccountDataLakeStoreShowSettings.ResourceGroup"/>.</em></p><p>If not specified, will attempt to discover the resource group for the specified Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountDataLakeStoreShowSettings SetResourceGroup(this AzureDlaAccountDataLakeStoreShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountDataLakeStoreShowSettings.ResourceGroup"/>.</em></p><p>If not specified, will attempt to discover the resource group for the specified Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountDataLakeStoreShowSettings ResetResourceGroup(this AzureDlaAccountDataLakeStoreShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlaAccountDataLakeStoreShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountDataLakeStoreShowSettings SetDebug(this AzureDlaAccountDataLakeStoreShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountDataLakeStoreShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountDataLakeStoreShowSettings ResetDebug(this AzureDlaAccountDataLakeStoreShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlaAccountDataLakeStoreShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaAccountDataLakeStoreShowSettings SetHelp(this AzureDlaAccountDataLakeStoreShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountDataLakeStoreShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaAccountDataLakeStoreShowSettings ResetHelp(this AzureDlaAccountDataLakeStoreShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlaAccountDataLakeStoreShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaAccountDataLakeStoreShowSettings SetOutput(this AzureDlaAccountDataLakeStoreShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountDataLakeStoreShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaAccountDataLakeStoreShowSettings ResetOutput(this AzureDlaAccountDataLakeStoreShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlaAccountDataLakeStoreShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaAccountDataLakeStoreShowSettings SetQuery(this AzureDlaAccountDataLakeStoreShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountDataLakeStoreShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaAccountDataLakeStoreShowSettings ResetQuery(this AzureDlaAccountDataLakeStoreShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlaAccountDataLakeStoreShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountDataLakeStoreShowSettings SetVerbose(this AzureDlaAccountDataLakeStoreShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountDataLakeStoreShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountDataLakeStoreShowSettings ResetVerbose(this AzureDlaAccountDataLakeStoreShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlaAccountFirewallCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlaAccountFirewallCreateSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlaAccountFirewallCreateSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallCreateSettings SetAccount(this AzureDlaAccountFirewallCreateSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountFirewallCreateSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallCreateSettings ResetAccount(this AzureDlaAccountFirewallCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region EndIpAddress
        /// <summary><p><em>Sets <see cref="AzureDlaAccountFirewallCreateSettings.EndIpAddress"/>.</em></p><p>The end of the valid IP range for the firewall rule.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallCreateSettings SetEndIpAddress(this AzureDlaAccountFirewallCreateSettings toolSettings, string endIpAddress)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndIpAddress = endIpAddress;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountFirewallCreateSettings.EndIpAddress"/>.</em></p><p>The end of the valid IP range for the firewall rule.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallCreateSettings ResetEndIpAddress(this AzureDlaAccountFirewallCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndIpAddress = null;
            return toolSettings;
        }
        #endregion
        #region FirewallRuleName
        /// <summary><p><em>Sets <see cref="AzureDlaAccountFirewallCreateSettings.FirewallRuleName"/>.</em></p><p>The name of the firewall rule.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallCreateSettings SetFirewallRuleName(this AzureDlaAccountFirewallCreateSettings toolSettings, string firewallRuleName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FirewallRuleName = firewallRuleName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountFirewallCreateSettings.FirewallRuleName"/>.</em></p><p>The name of the firewall rule.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallCreateSettings ResetFirewallRuleName(this AzureDlaAccountFirewallCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FirewallRuleName = null;
            return toolSettings;
        }
        #endregion
        #region StartIpAddress
        /// <summary><p><em>Sets <see cref="AzureDlaAccountFirewallCreateSettings.StartIpAddress"/>.</em></p><p>The start of the valid IP range for the firewall rule.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallCreateSettings SetStartIpAddress(this AzureDlaAccountFirewallCreateSettings toolSettings, string startIpAddress)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartIpAddress = startIpAddress;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountFirewallCreateSettings.StartIpAddress"/>.</em></p><p>The start of the valid IP range for the firewall rule.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallCreateSettings ResetStartIpAddress(this AzureDlaAccountFirewallCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartIpAddress = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureDlaAccountFirewallCreateSettings.ResourceGroup"/>.</em></p><p>If not specified, will attempt to discover the resource group for the specified Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallCreateSettings SetResourceGroup(this AzureDlaAccountFirewallCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountFirewallCreateSettings.ResourceGroup"/>.</em></p><p>If not specified, will attempt to discover the resource group for the specified Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallCreateSettings ResetResourceGroup(this AzureDlaAccountFirewallCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlaAccountFirewallCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallCreateSettings SetDebug(this AzureDlaAccountFirewallCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountFirewallCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallCreateSettings ResetDebug(this AzureDlaAccountFirewallCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlaAccountFirewallCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallCreateSettings SetHelp(this AzureDlaAccountFirewallCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountFirewallCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallCreateSettings ResetHelp(this AzureDlaAccountFirewallCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlaAccountFirewallCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallCreateSettings SetOutput(this AzureDlaAccountFirewallCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountFirewallCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallCreateSettings ResetOutput(this AzureDlaAccountFirewallCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlaAccountFirewallCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallCreateSettings SetQuery(this AzureDlaAccountFirewallCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountFirewallCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallCreateSettings ResetQuery(this AzureDlaAccountFirewallCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlaAccountFirewallCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallCreateSettings SetVerbose(this AzureDlaAccountFirewallCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountFirewallCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallCreateSettings ResetVerbose(this AzureDlaAccountFirewallCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlaAccountFirewallDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlaAccountFirewallDeleteSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlaAccountFirewallDeleteSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallDeleteSettings SetAccount(this AzureDlaAccountFirewallDeleteSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountFirewallDeleteSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallDeleteSettings ResetAccount(this AzureDlaAccountFirewallDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region FirewallRuleName
        /// <summary><p><em>Sets <see cref="AzureDlaAccountFirewallDeleteSettings.FirewallRuleName"/>.</em></p><p>The name of the firewall rule to delete.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallDeleteSettings SetFirewallRuleName(this AzureDlaAccountFirewallDeleteSettings toolSettings, string firewallRuleName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FirewallRuleName = firewallRuleName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountFirewallDeleteSettings.FirewallRuleName"/>.</em></p><p>The name of the firewall rule to delete.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallDeleteSettings ResetFirewallRuleName(this AzureDlaAccountFirewallDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FirewallRuleName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureDlaAccountFirewallDeleteSettings.ResourceGroup"/>.</em></p><p>If not specified, will attempt to discover the resource group for the specified Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallDeleteSettings SetResourceGroup(this AzureDlaAccountFirewallDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountFirewallDeleteSettings.ResourceGroup"/>.</em></p><p>If not specified, will attempt to discover the resource group for the specified Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallDeleteSettings ResetResourceGroup(this AzureDlaAccountFirewallDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlaAccountFirewallDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallDeleteSettings SetDebug(this AzureDlaAccountFirewallDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountFirewallDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallDeleteSettings ResetDebug(this AzureDlaAccountFirewallDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlaAccountFirewallDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallDeleteSettings SetHelp(this AzureDlaAccountFirewallDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountFirewallDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallDeleteSettings ResetHelp(this AzureDlaAccountFirewallDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlaAccountFirewallDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallDeleteSettings SetOutput(this AzureDlaAccountFirewallDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountFirewallDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallDeleteSettings ResetOutput(this AzureDlaAccountFirewallDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlaAccountFirewallDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallDeleteSettings SetQuery(this AzureDlaAccountFirewallDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountFirewallDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallDeleteSettings ResetQuery(this AzureDlaAccountFirewallDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlaAccountFirewallDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallDeleteSettings SetVerbose(this AzureDlaAccountFirewallDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountFirewallDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallDeleteSettings ResetVerbose(this AzureDlaAccountFirewallDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlaAccountFirewallListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlaAccountFirewallListSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlaAccountFirewallListSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallListSettings SetAccount(this AzureDlaAccountFirewallListSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountFirewallListSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallListSettings ResetAccount(this AzureDlaAccountFirewallListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureDlaAccountFirewallListSettings.ResourceGroup"/>.</em></p><p>If not specified, will attempt to discover the resource group for the specified Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallListSettings SetResourceGroup(this AzureDlaAccountFirewallListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountFirewallListSettings.ResourceGroup"/>.</em></p><p>If not specified, will attempt to discover the resource group for the specified Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallListSettings ResetResourceGroup(this AzureDlaAccountFirewallListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlaAccountFirewallListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallListSettings SetDebug(this AzureDlaAccountFirewallListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountFirewallListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallListSettings ResetDebug(this AzureDlaAccountFirewallListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlaAccountFirewallListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallListSettings SetHelp(this AzureDlaAccountFirewallListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountFirewallListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallListSettings ResetHelp(this AzureDlaAccountFirewallListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlaAccountFirewallListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallListSettings SetOutput(this AzureDlaAccountFirewallListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountFirewallListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallListSettings ResetOutput(this AzureDlaAccountFirewallListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlaAccountFirewallListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallListSettings SetQuery(this AzureDlaAccountFirewallListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountFirewallListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallListSettings ResetQuery(this AzureDlaAccountFirewallListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlaAccountFirewallListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallListSettings SetVerbose(this AzureDlaAccountFirewallListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountFirewallListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallListSettings ResetVerbose(this AzureDlaAccountFirewallListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlaAccountFirewallShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlaAccountFirewallShowSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlaAccountFirewallShowSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallShowSettings SetAccount(this AzureDlaAccountFirewallShowSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountFirewallShowSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallShowSettings ResetAccount(this AzureDlaAccountFirewallShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region FirewallRuleName
        /// <summary><p><em>Sets <see cref="AzureDlaAccountFirewallShowSettings.FirewallRuleName"/>.</em></p><p>The name of the firewall rule to retrieve.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallShowSettings SetFirewallRuleName(this AzureDlaAccountFirewallShowSettings toolSettings, string firewallRuleName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FirewallRuleName = firewallRuleName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountFirewallShowSettings.FirewallRuleName"/>.</em></p><p>The name of the firewall rule to retrieve.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallShowSettings ResetFirewallRuleName(this AzureDlaAccountFirewallShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FirewallRuleName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureDlaAccountFirewallShowSettings.ResourceGroup"/>.</em></p><p>If not specified, will attempt to discover the resource group for the specified Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallShowSettings SetResourceGroup(this AzureDlaAccountFirewallShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountFirewallShowSettings.ResourceGroup"/>.</em></p><p>If not specified, will attempt to discover the resource group for the specified Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallShowSettings ResetResourceGroup(this AzureDlaAccountFirewallShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlaAccountFirewallShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallShowSettings SetDebug(this AzureDlaAccountFirewallShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountFirewallShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallShowSettings ResetDebug(this AzureDlaAccountFirewallShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlaAccountFirewallShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallShowSettings SetHelp(this AzureDlaAccountFirewallShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountFirewallShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallShowSettings ResetHelp(this AzureDlaAccountFirewallShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlaAccountFirewallShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallShowSettings SetOutput(this AzureDlaAccountFirewallShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountFirewallShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallShowSettings ResetOutput(this AzureDlaAccountFirewallShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlaAccountFirewallShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallShowSettings SetQuery(this AzureDlaAccountFirewallShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountFirewallShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallShowSettings ResetQuery(this AzureDlaAccountFirewallShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlaAccountFirewallShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallShowSettings SetVerbose(this AzureDlaAccountFirewallShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountFirewallShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallShowSettings ResetVerbose(this AzureDlaAccountFirewallShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlaAccountFirewallUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlaAccountFirewallUpdateSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlaAccountFirewallUpdateSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallUpdateSettings SetAccount(this AzureDlaAccountFirewallUpdateSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountFirewallUpdateSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallUpdateSettings ResetAccount(this AzureDlaAccountFirewallUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region FirewallRuleName
        /// <summary><p><em>Sets <see cref="AzureDlaAccountFirewallUpdateSettings.FirewallRuleName"/>.</em></p><p>The name of the firewall rule to update.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallUpdateSettings SetFirewallRuleName(this AzureDlaAccountFirewallUpdateSettings toolSettings, string firewallRuleName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FirewallRuleName = firewallRuleName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountFirewallUpdateSettings.FirewallRuleName"/>.</em></p><p>The name of the firewall rule to update.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallUpdateSettings ResetFirewallRuleName(this AzureDlaAccountFirewallUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FirewallRuleName = null;
            return toolSettings;
        }
        #endregion
        #region EndIpAddress
        /// <summary><p><em>Sets <see cref="AzureDlaAccountFirewallUpdateSettings.EndIpAddress"/>.</em></p><p>The end IP address for the firewall rule. This can be either ipv4 or ipv6. Start and End should be in the same protocol.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallUpdateSettings SetEndIpAddress(this AzureDlaAccountFirewallUpdateSettings toolSettings, string endIpAddress)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndIpAddress = endIpAddress;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountFirewallUpdateSettings.EndIpAddress"/>.</em></p><p>The end IP address for the firewall rule. This can be either ipv4 or ipv6. Start and End should be in the same protocol.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallUpdateSettings ResetEndIpAddress(this AzureDlaAccountFirewallUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndIpAddress = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureDlaAccountFirewallUpdateSettings.ResourceGroup"/>.</em></p><p>If not specified, will attempt to discover the resource group for the specified Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallUpdateSettings SetResourceGroup(this AzureDlaAccountFirewallUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountFirewallUpdateSettings.ResourceGroup"/>.</em></p><p>If not specified, will attempt to discover the resource group for the specified Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallUpdateSettings ResetResourceGroup(this AzureDlaAccountFirewallUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region StartIpAddress
        /// <summary><p><em>Sets <see cref="AzureDlaAccountFirewallUpdateSettings.StartIpAddress"/>.</em></p><p>The start IP address for the firewall rule. This can be either ipv4 or ipv6. Start and End should be in the same protocol.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallUpdateSettings SetStartIpAddress(this AzureDlaAccountFirewallUpdateSettings toolSettings, string startIpAddress)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartIpAddress = startIpAddress;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountFirewallUpdateSettings.StartIpAddress"/>.</em></p><p>The start IP address for the firewall rule. This can be either ipv4 or ipv6. Start and End should be in the same protocol.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallUpdateSettings ResetStartIpAddress(this AzureDlaAccountFirewallUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartIpAddress = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlaAccountFirewallUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallUpdateSettings SetDebug(this AzureDlaAccountFirewallUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountFirewallUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallUpdateSettings ResetDebug(this AzureDlaAccountFirewallUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlaAccountFirewallUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallUpdateSettings SetHelp(this AzureDlaAccountFirewallUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountFirewallUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallUpdateSettings ResetHelp(this AzureDlaAccountFirewallUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlaAccountFirewallUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallUpdateSettings SetOutput(this AzureDlaAccountFirewallUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountFirewallUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallUpdateSettings ResetOutput(this AzureDlaAccountFirewallUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlaAccountFirewallUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallUpdateSettings SetQuery(this AzureDlaAccountFirewallUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountFirewallUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallUpdateSettings ResetQuery(this AzureDlaAccountFirewallUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlaAccountFirewallUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallUpdateSettings SetVerbose(this AzureDlaAccountFirewallUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaAccountFirewallUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaAccountFirewallUpdateSettings ResetVerbose(this AzureDlaAccountFirewallUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlaCatalogAssemblyListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlaCatalogAssemblyListSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogAssemblyListSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaCatalogAssemblyListSettings SetAccount(this AzureDlaCatalogAssemblyListSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogAssemblyListSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaCatalogAssemblyListSettings ResetAccount(this AzureDlaCatalogAssemblyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region DatabaseName
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogAssemblyListSettings.DatabaseName"/>.</em></p><p>The name of the database containing the assembly.</p></summary>
        [Pure]
        public static AzureDlaCatalogAssemblyListSettings SetDatabaseName(this AzureDlaCatalogAssemblyListSettings toolSettings, string databaseName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DatabaseName = databaseName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogAssemblyListSettings.DatabaseName"/>.</em></p><p>The name of the database containing the assembly.</p></summary>
        [Pure]
        public static AzureDlaCatalogAssemblyListSettings ResetDatabaseName(this AzureDlaCatalogAssemblyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DatabaseName = null;
            return toolSettings;
        }
        #endregion
        #region Count
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogAssemblyListSettings.Count"/>.</em></p><p>The Boolean value of true or false to request a count of the matching resources included with the resources in the response, e.g. Categories?$count=true.</p></summary>
        [Pure]
        public static AzureDlaCatalogAssemblyListSettings SetCount(this AzureDlaCatalogAssemblyListSettings toolSettings, string count)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Count = count;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogAssemblyListSettings.Count"/>.</em></p><p>The Boolean value of true or false to request a count of the matching resources included with the resources in the response, e.g. Categories?$count=true.</p></summary>
        [Pure]
        public static AzureDlaCatalogAssemblyListSettings ResetCount(this AzureDlaCatalogAssemblyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Count = null;
            return toolSettings;
        }
        #endregion
        #region Filter
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogAssemblyListSettings.Filter"/>.</em></p><p>OData filter. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogAssemblyListSettings SetFilter(this AzureDlaCatalogAssemblyListSettings toolSettings, string filter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = filter;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogAssemblyListSettings.Filter"/>.</em></p><p>OData filter. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogAssemblyListSettings ResetFilter(this AzureDlaCatalogAssemblyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = null;
            return toolSettings;
        }
        #endregion
        #region Orderby
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogAssemblyListSettings.Orderby"/> to a new list.</em></p><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogAssemblyListSettings SetOrderby(this AzureDlaCatalogAssemblyListSettings toolSettings, params string[] orderby)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OrderbyInternal = orderby.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogAssemblyListSettings.Orderby"/> to a new list.</em></p><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogAssemblyListSettings SetOrderby(this AzureDlaCatalogAssemblyListSettings toolSettings, IEnumerable<string> orderby)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OrderbyInternal = orderby.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureDlaCatalogAssemblyListSettings.Orderby"/>.</em></p><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogAssemblyListSettings AddOrderby(this AzureDlaCatalogAssemblyListSettings toolSettings, params string[] orderby)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OrderbyInternal.AddRange(orderby);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureDlaCatalogAssemblyListSettings.Orderby"/>.</em></p><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogAssemblyListSettings AddOrderby(this AzureDlaCatalogAssemblyListSettings toolSettings, IEnumerable<string> orderby)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OrderbyInternal.AddRange(orderby);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureDlaCatalogAssemblyListSettings.Orderby"/>.</em></p><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogAssemblyListSettings ClearOrderby(this AzureDlaCatalogAssemblyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OrderbyInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureDlaCatalogAssemblyListSettings.Orderby"/>.</em></p><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogAssemblyListSettings RemoveOrderby(this AzureDlaCatalogAssemblyListSettings toolSettings, params string[] orderby)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(orderby);
            toolSettings.OrderbyInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureDlaCatalogAssemblyListSettings.Orderby"/>.</em></p><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogAssemblyListSettings RemoveOrderby(this AzureDlaCatalogAssemblyListSettings toolSettings, IEnumerable<string> orderby)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(orderby);
            toolSettings.OrderbyInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Select
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogAssemblyListSettings.Select"/>.</em></p><p>OData Select statement. Limits the properties on each entry to just those requested, e.g. Categories?$select=CategoryName,Description. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogAssemblyListSettings SetSelect(this AzureDlaCatalogAssemblyListSettings toolSettings, string select)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Select = select;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogAssemblyListSettings.Select"/>.</em></p><p>OData Select statement. Limits the properties on each entry to just those requested, e.g. Categories?$select=CategoryName,Description. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogAssemblyListSettings ResetSelect(this AzureDlaCatalogAssemblyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Select = null;
            return toolSettings;
        }
        #endregion
        #region Skip
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogAssemblyListSettings.Skip"/>.</em></p><p>The number of items to skip over before returning elements.</p></summary>
        [Pure]
        public static AzureDlaCatalogAssemblyListSettings SetSkip(this AzureDlaCatalogAssemblyListSettings toolSettings, string skip)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Skip = skip;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogAssemblyListSettings.Skip"/>.</em></p><p>The number of items to skip over before returning elements.</p></summary>
        [Pure]
        public static AzureDlaCatalogAssemblyListSettings ResetSkip(this AzureDlaCatalogAssemblyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Skip = null;
            return toolSettings;
        }
        #endregion
        #region Top
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogAssemblyListSettings.Top"/>.</em></p><p>Maximum number of items to return.</p></summary>
        [Pure]
        public static AzureDlaCatalogAssemblyListSettings SetTop(this AzureDlaCatalogAssemblyListSettings toolSettings, int? top)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = top;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogAssemblyListSettings.Top"/>.</em></p><p>Maximum number of items to return.</p></summary>
        [Pure]
        public static AzureDlaCatalogAssemblyListSettings ResetTop(this AzureDlaCatalogAssemblyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogAssemblyListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogAssemblyListSettings SetDebug(this AzureDlaCatalogAssemblyListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogAssemblyListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogAssemblyListSettings ResetDebug(this AzureDlaCatalogAssemblyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogAssemblyListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaCatalogAssemblyListSettings SetHelp(this AzureDlaCatalogAssemblyListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogAssemblyListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaCatalogAssemblyListSettings ResetHelp(this AzureDlaCatalogAssemblyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogAssemblyListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaCatalogAssemblyListSettings SetOutput(this AzureDlaCatalogAssemblyListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogAssemblyListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaCatalogAssemblyListSettings ResetOutput(this AzureDlaCatalogAssemblyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogAssemblyListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaCatalogAssemblyListSettings SetQuery(this AzureDlaCatalogAssemblyListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogAssemblyListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaCatalogAssemblyListSettings ResetQuery(this AzureDlaCatalogAssemblyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogAssemblyListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogAssemblyListSettings SetVerbose(this AzureDlaCatalogAssemblyListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogAssemblyListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogAssemblyListSettings ResetVerbose(this AzureDlaCatalogAssemblyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlaCatalogAssemblyShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlaCatalogAssemblyShowSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogAssemblyShowSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaCatalogAssemblyShowSettings SetAccount(this AzureDlaCatalogAssemblyShowSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogAssemblyShowSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaCatalogAssemblyShowSettings ResetAccount(this AzureDlaCatalogAssemblyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region AssemblyName
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogAssemblyShowSettings.AssemblyName"/>.</em></p><p>The name of the assembly.</p></summary>
        [Pure]
        public static AzureDlaCatalogAssemblyShowSettings SetAssemblyName(this AzureDlaCatalogAssemblyShowSettings toolSettings, string assemblyName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AssemblyName = assemblyName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogAssemblyShowSettings.AssemblyName"/>.</em></p><p>The name of the assembly.</p></summary>
        [Pure]
        public static AzureDlaCatalogAssemblyShowSettings ResetAssemblyName(this AzureDlaCatalogAssemblyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AssemblyName = null;
            return toolSettings;
        }
        #endregion
        #region DatabaseName
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogAssemblyShowSettings.DatabaseName"/>.</em></p><p>The name of the database containing the assembly.</p></summary>
        [Pure]
        public static AzureDlaCatalogAssemblyShowSettings SetDatabaseName(this AzureDlaCatalogAssemblyShowSettings toolSettings, string databaseName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DatabaseName = databaseName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogAssemblyShowSettings.DatabaseName"/>.</em></p><p>The name of the database containing the assembly.</p></summary>
        [Pure]
        public static AzureDlaCatalogAssemblyShowSettings ResetDatabaseName(this AzureDlaCatalogAssemblyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DatabaseName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogAssemblyShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogAssemblyShowSettings SetDebug(this AzureDlaCatalogAssemblyShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogAssemblyShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogAssemblyShowSettings ResetDebug(this AzureDlaCatalogAssemblyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogAssemblyShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaCatalogAssemblyShowSettings SetHelp(this AzureDlaCatalogAssemblyShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogAssemblyShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaCatalogAssemblyShowSettings ResetHelp(this AzureDlaCatalogAssemblyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogAssemblyShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaCatalogAssemblyShowSettings SetOutput(this AzureDlaCatalogAssemblyShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogAssemblyShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaCatalogAssemblyShowSettings ResetOutput(this AzureDlaCatalogAssemblyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogAssemblyShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaCatalogAssemblyShowSettings SetQuery(this AzureDlaCatalogAssemblyShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogAssemblyShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaCatalogAssemblyShowSettings ResetQuery(this AzureDlaCatalogAssemblyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogAssemblyShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogAssemblyShowSettings SetVerbose(this AzureDlaCatalogAssemblyShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogAssemblyShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogAssemblyShowSettings ResetVerbose(this AzureDlaCatalogAssemblyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlaCatalogCredentialCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlaCatalogCredentialCreateSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogCredentialCreateSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialCreateSettings SetAccount(this AzureDlaCatalogCredentialCreateSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogCredentialCreateSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialCreateSettings ResetAccount(this AzureDlaCatalogCredentialCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region CredentialName
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogCredentialCreateSettings.CredentialName"/>.</em></p><p>The name of the credential.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialCreateSettings SetCredentialName(this AzureDlaCatalogCredentialCreateSettings toolSettings, string credentialName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CredentialName = credentialName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogCredentialCreateSettings.CredentialName"/>.</em></p><p>The name of the credential.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialCreateSettings ResetCredentialName(this AzureDlaCatalogCredentialCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CredentialName = null;
            return toolSettings;
        }
        #endregion
        #region DatabaseName
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogCredentialCreateSettings.DatabaseName"/>.</em></p><p>The name of the database in which to create the credential.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialCreateSettings SetDatabaseName(this AzureDlaCatalogCredentialCreateSettings toolSettings, string databaseName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DatabaseName = databaseName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogCredentialCreateSettings.DatabaseName"/>.</em></p><p>The name of the database in which to create the credential.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialCreateSettings ResetDatabaseName(this AzureDlaCatalogCredentialCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DatabaseName = null;
            return toolSettings;
        }
        #endregion
        #region Uri
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogCredentialCreateSettings.Uri"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialCreateSettings SetUri(this AzureDlaCatalogCredentialCreateSettings toolSettings, string uri)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Uri = uri;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogCredentialCreateSettings.Uri"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialCreateSettings ResetUri(this AzureDlaCatalogCredentialCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Uri = null;
            return toolSettings;
        }
        #endregion
        #region UserName
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogCredentialCreateSettings.UserName"/>.</em></p><p>The user name that will be used when authenticating with this credential.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialCreateSettings SetUserName(this AzureDlaCatalogCredentialCreateSettings toolSettings, string userName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UserName = userName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogCredentialCreateSettings.UserName"/>.</em></p><p>The user name that will be used when authenticating with this credential.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialCreateSettings ResetUserName(this AzureDlaCatalogCredentialCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UserName = null;
            return toolSettings;
        }
        #endregion
        #region Password
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogCredentialCreateSettings.Password"/>.</em></p><p>Password for the credential user. Will prompt if not given.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialCreateSettings SetPassword(this AzureDlaCatalogCredentialCreateSettings toolSettings, string password)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = password;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogCredentialCreateSettings.Password"/>.</em></p><p>Password for the credential user. Will prompt if not given.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialCreateSettings ResetPassword(this AzureDlaCatalogCredentialCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogCredentialCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialCreateSettings SetDebug(this AzureDlaCatalogCredentialCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogCredentialCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialCreateSettings ResetDebug(this AzureDlaCatalogCredentialCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogCredentialCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialCreateSettings SetHelp(this AzureDlaCatalogCredentialCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogCredentialCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialCreateSettings ResetHelp(this AzureDlaCatalogCredentialCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogCredentialCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialCreateSettings SetOutput(this AzureDlaCatalogCredentialCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogCredentialCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialCreateSettings ResetOutput(this AzureDlaCatalogCredentialCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogCredentialCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialCreateSettings SetQuery(this AzureDlaCatalogCredentialCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogCredentialCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialCreateSettings ResetQuery(this AzureDlaCatalogCredentialCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogCredentialCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialCreateSettings SetVerbose(this AzureDlaCatalogCredentialCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogCredentialCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialCreateSettings ResetVerbose(this AzureDlaCatalogCredentialCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlaCatalogCredentialDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlaCatalogCredentialDeleteSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogCredentialDeleteSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialDeleteSettings SetAccount(this AzureDlaCatalogCredentialDeleteSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogCredentialDeleteSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialDeleteSettings ResetAccount(this AzureDlaCatalogCredentialDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region CredentialName
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogCredentialDeleteSettings.CredentialName"/>.</em></p><p>The name of the credential to delete.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialDeleteSettings SetCredentialName(this AzureDlaCatalogCredentialDeleteSettings toolSettings, string credentialName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CredentialName = credentialName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogCredentialDeleteSettings.CredentialName"/>.</em></p><p>The name of the credential to delete.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialDeleteSettings ResetCredentialName(this AzureDlaCatalogCredentialDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CredentialName = null;
            return toolSettings;
        }
        #endregion
        #region DatabaseName
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogCredentialDeleteSettings.DatabaseName"/>.</em></p><p>The name of the database containing the credential.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialDeleteSettings SetDatabaseName(this AzureDlaCatalogCredentialDeleteSettings toolSettings, string databaseName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DatabaseName = databaseName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogCredentialDeleteSettings.DatabaseName"/>.</em></p><p>The name of the database containing the credential.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialDeleteSettings ResetDatabaseName(this AzureDlaCatalogCredentialDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DatabaseName = null;
            return toolSettings;
        }
        #endregion
        #region Cascade
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogCredentialDeleteSettings.Cascade"/>.</em></p><p>Indicates if the delete should be a cascading delete (which deletes all resources dependent on the credential as well as the credential) or not. If false will fail if there are any resources relying on the credential.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialDeleteSettings SetCascade(this AzureDlaCatalogCredentialDeleteSettings toolSettings, string cascade)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cascade = cascade;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogCredentialDeleteSettings.Cascade"/>.</em></p><p>Indicates if the delete should be a cascading delete (which deletes all resources dependent on the credential as well as the credential) or not. If false will fail if there are any resources relying on the credential.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialDeleteSettings ResetCascade(this AzureDlaCatalogCredentialDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cascade = null;
            return toolSettings;
        }
        #endregion
        #region Password
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogCredentialDeleteSettings.Password"/>.</em></p><p>The current password for the credential and user with access to the data source. This is required if the requester is not the account owner.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialDeleteSettings SetPassword(this AzureDlaCatalogCredentialDeleteSettings toolSettings, string password)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = password;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogCredentialDeleteSettings.Password"/>.</em></p><p>The current password for the credential and user with access to the data source. This is required if the requester is not the account owner.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialDeleteSettings ResetPassword(this AzureDlaCatalogCredentialDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogCredentialDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialDeleteSettings SetDebug(this AzureDlaCatalogCredentialDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogCredentialDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialDeleteSettings ResetDebug(this AzureDlaCatalogCredentialDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogCredentialDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialDeleteSettings SetHelp(this AzureDlaCatalogCredentialDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogCredentialDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialDeleteSettings ResetHelp(this AzureDlaCatalogCredentialDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogCredentialDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialDeleteSettings SetOutput(this AzureDlaCatalogCredentialDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogCredentialDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialDeleteSettings ResetOutput(this AzureDlaCatalogCredentialDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogCredentialDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialDeleteSettings SetQuery(this AzureDlaCatalogCredentialDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogCredentialDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialDeleteSettings ResetQuery(this AzureDlaCatalogCredentialDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogCredentialDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialDeleteSettings SetVerbose(this AzureDlaCatalogCredentialDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogCredentialDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialDeleteSettings ResetVerbose(this AzureDlaCatalogCredentialDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlaCatalogCredentialListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlaCatalogCredentialListSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogCredentialListSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialListSettings SetAccount(this AzureDlaCatalogCredentialListSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogCredentialListSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialListSettings ResetAccount(this AzureDlaCatalogCredentialListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region DatabaseName
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogCredentialListSettings.DatabaseName"/>.</em></p><p>The name of the database containing the schema.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialListSettings SetDatabaseName(this AzureDlaCatalogCredentialListSettings toolSettings, string databaseName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DatabaseName = databaseName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogCredentialListSettings.DatabaseName"/>.</em></p><p>The name of the database containing the schema.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialListSettings ResetDatabaseName(this AzureDlaCatalogCredentialListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DatabaseName = null;
            return toolSettings;
        }
        #endregion
        #region Count
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogCredentialListSettings.Count"/>.</em></p><p>The Boolean value of true or false to request a count of the matching resources included with the resources in the response, e.g. Categories?$count=true.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialListSettings SetCount(this AzureDlaCatalogCredentialListSettings toolSettings, string count)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Count = count;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogCredentialListSettings.Count"/>.</em></p><p>The Boolean value of true or false to request a count of the matching resources included with the resources in the response, e.g. Categories?$count=true.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialListSettings ResetCount(this AzureDlaCatalogCredentialListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Count = null;
            return toolSettings;
        }
        #endregion
        #region Filter
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogCredentialListSettings.Filter"/>.</em></p><p>OData filter. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialListSettings SetFilter(this AzureDlaCatalogCredentialListSettings toolSettings, string filter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = filter;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogCredentialListSettings.Filter"/>.</em></p><p>OData filter. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialListSettings ResetFilter(this AzureDlaCatalogCredentialListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = null;
            return toolSettings;
        }
        #endregion
        #region Orderby
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogCredentialListSettings.Orderby"/> to a new list.</em></p><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialListSettings SetOrderby(this AzureDlaCatalogCredentialListSettings toolSettings, params string[] orderby)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OrderbyInternal = orderby.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogCredentialListSettings.Orderby"/> to a new list.</em></p><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialListSettings SetOrderby(this AzureDlaCatalogCredentialListSettings toolSettings, IEnumerable<string> orderby)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OrderbyInternal = orderby.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureDlaCatalogCredentialListSettings.Orderby"/>.</em></p><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialListSettings AddOrderby(this AzureDlaCatalogCredentialListSettings toolSettings, params string[] orderby)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OrderbyInternal.AddRange(orderby);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureDlaCatalogCredentialListSettings.Orderby"/>.</em></p><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialListSettings AddOrderby(this AzureDlaCatalogCredentialListSettings toolSettings, IEnumerable<string> orderby)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OrderbyInternal.AddRange(orderby);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureDlaCatalogCredentialListSettings.Orderby"/>.</em></p><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialListSettings ClearOrderby(this AzureDlaCatalogCredentialListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OrderbyInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureDlaCatalogCredentialListSettings.Orderby"/>.</em></p><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialListSettings RemoveOrderby(this AzureDlaCatalogCredentialListSettings toolSettings, params string[] orderby)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(orderby);
            toolSettings.OrderbyInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureDlaCatalogCredentialListSettings.Orderby"/>.</em></p><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialListSettings RemoveOrderby(this AzureDlaCatalogCredentialListSettings toolSettings, IEnumerable<string> orderby)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(orderby);
            toolSettings.OrderbyInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Select
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogCredentialListSettings.Select"/>.</em></p><p>OData Select statement. Limits the properties on each entry to just those requested, e.g. Categories?$select=CategoryName,Description. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialListSettings SetSelect(this AzureDlaCatalogCredentialListSettings toolSettings, string select)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Select = select;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogCredentialListSettings.Select"/>.</em></p><p>OData Select statement. Limits the properties on each entry to just those requested, e.g. Categories?$select=CategoryName,Description. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialListSettings ResetSelect(this AzureDlaCatalogCredentialListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Select = null;
            return toolSettings;
        }
        #endregion
        #region Skip
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogCredentialListSettings.Skip"/>.</em></p><p>The number of items to skip over before returning elements.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialListSettings SetSkip(this AzureDlaCatalogCredentialListSettings toolSettings, string skip)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Skip = skip;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogCredentialListSettings.Skip"/>.</em></p><p>The number of items to skip over before returning elements.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialListSettings ResetSkip(this AzureDlaCatalogCredentialListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Skip = null;
            return toolSettings;
        }
        #endregion
        #region Top
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogCredentialListSettings.Top"/>.</em></p><p>Maximum number of items to return.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialListSettings SetTop(this AzureDlaCatalogCredentialListSettings toolSettings, int? top)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = top;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogCredentialListSettings.Top"/>.</em></p><p>Maximum number of items to return.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialListSettings ResetTop(this AzureDlaCatalogCredentialListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogCredentialListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialListSettings SetDebug(this AzureDlaCatalogCredentialListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogCredentialListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialListSettings ResetDebug(this AzureDlaCatalogCredentialListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogCredentialListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialListSettings SetHelp(this AzureDlaCatalogCredentialListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogCredentialListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialListSettings ResetHelp(this AzureDlaCatalogCredentialListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogCredentialListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialListSettings SetOutput(this AzureDlaCatalogCredentialListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogCredentialListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialListSettings ResetOutput(this AzureDlaCatalogCredentialListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogCredentialListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialListSettings SetQuery(this AzureDlaCatalogCredentialListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogCredentialListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialListSettings ResetQuery(this AzureDlaCatalogCredentialListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogCredentialListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialListSettings SetVerbose(this AzureDlaCatalogCredentialListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogCredentialListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialListSettings ResetVerbose(this AzureDlaCatalogCredentialListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlaCatalogCredentialShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlaCatalogCredentialShowSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogCredentialShowSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialShowSettings SetAccount(this AzureDlaCatalogCredentialShowSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogCredentialShowSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialShowSettings ResetAccount(this AzureDlaCatalogCredentialShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region CredentialName
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogCredentialShowSettings.CredentialName"/>.</em></p><p>The name of the credential.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialShowSettings SetCredentialName(this AzureDlaCatalogCredentialShowSettings toolSettings, string credentialName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CredentialName = credentialName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogCredentialShowSettings.CredentialName"/>.</em></p><p>The name of the credential.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialShowSettings ResetCredentialName(this AzureDlaCatalogCredentialShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CredentialName = null;
            return toolSettings;
        }
        #endregion
        #region DatabaseName
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogCredentialShowSettings.DatabaseName"/>.</em></p><p>The name of the database containing the schema.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialShowSettings SetDatabaseName(this AzureDlaCatalogCredentialShowSettings toolSettings, string databaseName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DatabaseName = databaseName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogCredentialShowSettings.DatabaseName"/>.</em></p><p>The name of the database containing the schema.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialShowSettings ResetDatabaseName(this AzureDlaCatalogCredentialShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DatabaseName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogCredentialShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialShowSettings SetDebug(this AzureDlaCatalogCredentialShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogCredentialShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialShowSettings ResetDebug(this AzureDlaCatalogCredentialShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogCredentialShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialShowSettings SetHelp(this AzureDlaCatalogCredentialShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogCredentialShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialShowSettings ResetHelp(this AzureDlaCatalogCredentialShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogCredentialShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialShowSettings SetOutput(this AzureDlaCatalogCredentialShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogCredentialShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialShowSettings ResetOutput(this AzureDlaCatalogCredentialShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogCredentialShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialShowSettings SetQuery(this AzureDlaCatalogCredentialShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogCredentialShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialShowSettings ResetQuery(this AzureDlaCatalogCredentialShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogCredentialShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialShowSettings SetVerbose(this AzureDlaCatalogCredentialShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogCredentialShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialShowSettings ResetVerbose(this AzureDlaCatalogCredentialShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlaCatalogCredentialUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlaCatalogCredentialUpdateSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogCredentialUpdateSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialUpdateSettings SetAccount(this AzureDlaCatalogCredentialUpdateSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogCredentialUpdateSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialUpdateSettings ResetAccount(this AzureDlaCatalogCredentialUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region CredentialName
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogCredentialUpdateSettings.CredentialName"/>.</em></p><p>The name of the credential to update.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialUpdateSettings SetCredentialName(this AzureDlaCatalogCredentialUpdateSettings toolSettings, string credentialName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CredentialName = credentialName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogCredentialUpdateSettings.CredentialName"/>.</em></p><p>The name of the credential to update.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialUpdateSettings ResetCredentialName(this AzureDlaCatalogCredentialUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CredentialName = null;
            return toolSettings;
        }
        #endregion
        #region DatabaseName
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogCredentialUpdateSettings.DatabaseName"/>.</em></p><p>The name of the database in which the credential exists.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialUpdateSettings SetDatabaseName(this AzureDlaCatalogCredentialUpdateSettings toolSettings, string databaseName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DatabaseName = databaseName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogCredentialUpdateSettings.DatabaseName"/>.</em></p><p>The name of the database in which the credential exists.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialUpdateSettings ResetDatabaseName(this AzureDlaCatalogCredentialUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DatabaseName = null;
            return toolSettings;
        }
        #endregion
        #region Uri
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogCredentialUpdateSettings.Uri"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialUpdateSettings SetUri(this AzureDlaCatalogCredentialUpdateSettings toolSettings, string uri)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Uri = uri;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogCredentialUpdateSettings.Uri"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialUpdateSettings ResetUri(this AzureDlaCatalogCredentialUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Uri = null;
            return toolSettings;
        }
        #endregion
        #region UserName
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogCredentialUpdateSettings.UserName"/>.</em></p><p>The user name associated with the credential that will have its password updated.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialUpdateSettings SetUserName(this AzureDlaCatalogCredentialUpdateSettings toolSettings, string userName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UserName = userName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogCredentialUpdateSettings.UserName"/>.</em></p><p>The user name associated with the credential that will have its password updated.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialUpdateSettings ResetUserName(this AzureDlaCatalogCredentialUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UserName = null;
            return toolSettings;
        }
        #endregion
        #region NewPassword
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogCredentialUpdateSettings.NewPassword"/>.</em></p><p>New password for the credential user. Will prompt if not given.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialUpdateSettings SetNewPassword(this AzureDlaCatalogCredentialUpdateSettings toolSettings, string newPassword)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NewPassword = newPassword;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogCredentialUpdateSettings.NewPassword"/>.</em></p><p>New password for the credential user. Will prompt if not given.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialUpdateSettings ResetNewPassword(this AzureDlaCatalogCredentialUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NewPassword = null;
            return toolSettings;
        }
        #endregion
        #region Password
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogCredentialUpdateSettings.Password"/>.</em></p><p>Current password for the credential user. Will prompt if not given.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialUpdateSettings SetPassword(this AzureDlaCatalogCredentialUpdateSettings toolSettings, string password)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = password;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogCredentialUpdateSettings.Password"/>.</em></p><p>Current password for the credential user. Will prompt if not given.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialUpdateSettings ResetPassword(this AzureDlaCatalogCredentialUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogCredentialUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialUpdateSettings SetDebug(this AzureDlaCatalogCredentialUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogCredentialUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialUpdateSettings ResetDebug(this AzureDlaCatalogCredentialUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogCredentialUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialUpdateSettings SetHelp(this AzureDlaCatalogCredentialUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogCredentialUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialUpdateSettings ResetHelp(this AzureDlaCatalogCredentialUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogCredentialUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialUpdateSettings SetOutput(this AzureDlaCatalogCredentialUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogCredentialUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialUpdateSettings ResetOutput(this AzureDlaCatalogCredentialUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogCredentialUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialUpdateSettings SetQuery(this AzureDlaCatalogCredentialUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogCredentialUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialUpdateSettings ResetQuery(this AzureDlaCatalogCredentialUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogCredentialUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialUpdateSettings SetVerbose(this AzureDlaCatalogCredentialUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogCredentialUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogCredentialUpdateSettings ResetVerbose(this AzureDlaCatalogCredentialUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlaCatalogDatabaseListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlaCatalogDatabaseListSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogDatabaseListSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaCatalogDatabaseListSettings SetAccount(this AzureDlaCatalogDatabaseListSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogDatabaseListSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaCatalogDatabaseListSettings ResetAccount(this AzureDlaCatalogDatabaseListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region Count
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogDatabaseListSettings.Count"/>.</em></p><p>The Boolean value of true or false to request a count of the matching resources included with the resources in the response, e.g. Categories?$count=true.</p></summary>
        [Pure]
        public static AzureDlaCatalogDatabaseListSettings SetCount(this AzureDlaCatalogDatabaseListSettings toolSettings, string count)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Count = count;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogDatabaseListSettings.Count"/>.</em></p><p>The Boolean value of true or false to request a count of the matching resources included with the resources in the response, e.g. Categories?$count=true.</p></summary>
        [Pure]
        public static AzureDlaCatalogDatabaseListSettings ResetCount(this AzureDlaCatalogDatabaseListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Count = null;
            return toolSettings;
        }
        #endregion
        #region Filter
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogDatabaseListSettings.Filter"/>.</em></p><p>OData filter. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogDatabaseListSettings SetFilter(this AzureDlaCatalogDatabaseListSettings toolSettings, string filter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = filter;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogDatabaseListSettings.Filter"/>.</em></p><p>OData filter. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogDatabaseListSettings ResetFilter(this AzureDlaCatalogDatabaseListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = null;
            return toolSettings;
        }
        #endregion
        #region Orderby
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogDatabaseListSettings.Orderby"/> to a new list.</em></p><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogDatabaseListSettings SetOrderby(this AzureDlaCatalogDatabaseListSettings toolSettings, params string[] orderby)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OrderbyInternal = orderby.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogDatabaseListSettings.Orderby"/> to a new list.</em></p><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogDatabaseListSettings SetOrderby(this AzureDlaCatalogDatabaseListSettings toolSettings, IEnumerable<string> orderby)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OrderbyInternal = orderby.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureDlaCatalogDatabaseListSettings.Orderby"/>.</em></p><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogDatabaseListSettings AddOrderby(this AzureDlaCatalogDatabaseListSettings toolSettings, params string[] orderby)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OrderbyInternal.AddRange(orderby);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureDlaCatalogDatabaseListSettings.Orderby"/>.</em></p><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogDatabaseListSettings AddOrderby(this AzureDlaCatalogDatabaseListSettings toolSettings, IEnumerable<string> orderby)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OrderbyInternal.AddRange(orderby);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureDlaCatalogDatabaseListSettings.Orderby"/>.</em></p><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogDatabaseListSettings ClearOrderby(this AzureDlaCatalogDatabaseListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OrderbyInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureDlaCatalogDatabaseListSettings.Orderby"/>.</em></p><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogDatabaseListSettings RemoveOrderby(this AzureDlaCatalogDatabaseListSettings toolSettings, params string[] orderby)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(orderby);
            toolSettings.OrderbyInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureDlaCatalogDatabaseListSettings.Orderby"/>.</em></p><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogDatabaseListSettings RemoveOrderby(this AzureDlaCatalogDatabaseListSettings toolSettings, IEnumerable<string> orderby)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(orderby);
            toolSettings.OrderbyInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Select
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogDatabaseListSettings.Select"/>.</em></p><p>OData Select statement. Limits the properties on each entry to just those requested, e.g. Categories?$select=CategoryName,Description. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogDatabaseListSettings SetSelect(this AzureDlaCatalogDatabaseListSettings toolSettings, string select)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Select = select;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogDatabaseListSettings.Select"/>.</em></p><p>OData Select statement. Limits the properties on each entry to just those requested, e.g. Categories?$select=CategoryName,Description. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogDatabaseListSettings ResetSelect(this AzureDlaCatalogDatabaseListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Select = null;
            return toolSettings;
        }
        #endregion
        #region Skip
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogDatabaseListSettings.Skip"/>.</em></p><p>The number of items to skip over before returning elements.</p></summary>
        [Pure]
        public static AzureDlaCatalogDatabaseListSettings SetSkip(this AzureDlaCatalogDatabaseListSettings toolSettings, string skip)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Skip = skip;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogDatabaseListSettings.Skip"/>.</em></p><p>The number of items to skip over before returning elements.</p></summary>
        [Pure]
        public static AzureDlaCatalogDatabaseListSettings ResetSkip(this AzureDlaCatalogDatabaseListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Skip = null;
            return toolSettings;
        }
        #endregion
        #region Top
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogDatabaseListSettings.Top"/>.</em></p><p>Maximum number of items to return.</p></summary>
        [Pure]
        public static AzureDlaCatalogDatabaseListSettings SetTop(this AzureDlaCatalogDatabaseListSettings toolSettings, int? top)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = top;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogDatabaseListSettings.Top"/>.</em></p><p>Maximum number of items to return.</p></summary>
        [Pure]
        public static AzureDlaCatalogDatabaseListSettings ResetTop(this AzureDlaCatalogDatabaseListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogDatabaseListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogDatabaseListSettings SetDebug(this AzureDlaCatalogDatabaseListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogDatabaseListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogDatabaseListSettings ResetDebug(this AzureDlaCatalogDatabaseListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogDatabaseListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaCatalogDatabaseListSettings SetHelp(this AzureDlaCatalogDatabaseListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogDatabaseListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaCatalogDatabaseListSettings ResetHelp(this AzureDlaCatalogDatabaseListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogDatabaseListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaCatalogDatabaseListSettings SetOutput(this AzureDlaCatalogDatabaseListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogDatabaseListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaCatalogDatabaseListSettings ResetOutput(this AzureDlaCatalogDatabaseListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogDatabaseListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaCatalogDatabaseListSettings SetQuery(this AzureDlaCatalogDatabaseListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogDatabaseListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaCatalogDatabaseListSettings ResetQuery(this AzureDlaCatalogDatabaseListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogDatabaseListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogDatabaseListSettings SetVerbose(this AzureDlaCatalogDatabaseListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogDatabaseListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogDatabaseListSettings ResetVerbose(this AzureDlaCatalogDatabaseListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlaCatalogDatabaseShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlaCatalogDatabaseShowSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogDatabaseShowSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaCatalogDatabaseShowSettings SetAccount(this AzureDlaCatalogDatabaseShowSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogDatabaseShowSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaCatalogDatabaseShowSettings ResetAccount(this AzureDlaCatalogDatabaseShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region DatabaseName
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogDatabaseShowSettings.DatabaseName"/>.</em></p><p>The name of the database.</p></summary>
        [Pure]
        public static AzureDlaCatalogDatabaseShowSettings SetDatabaseName(this AzureDlaCatalogDatabaseShowSettings toolSettings, string databaseName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DatabaseName = databaseName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogDatabaseShowSettings.DatabaseName"/>.</em></p><p>The name of the database.</p></summary>
        [Pure]
        public static AzureDlaCatalogDatabaseShowSettings ResetDatabaseName(this AzureDlaCatalogDatabaseShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DatabaseName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogDatabaseShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogDatabaseShowSettings SetDebug(this AzureDlaCatalogDatabaseShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogDatabaseShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogDatabaseShowSettings ResetDebug(this AzureDlaCatalogDatabaseShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogDatabaseShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaCatalogDatabaseShowSettings SetHelp(this AzureDlaCatalogDatabaseShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogDatabaseShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaCatalogDatabaseShowSettings ResetHelp(this AzureDlaCatalogDatabaseShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogDatabaseShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaCatalogDatabaseShowSettings SetOutput(this AzureDlaCatalogDatabaseShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogDatabaseShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaCatalogDatabaseShowSettings ResetOutput(this AzureDlaCatalogDatabaseShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogDatabaseShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaCatalogDatabaseShowSettings SetQuery(this AzureDlaCatalogDatabaseShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogDatabaseShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaCatalogDatabaseShowSettings ResetQuery(this AzureDlaCatalogDatabaseShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogDatabaseShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogDatabaseShowSettings SetVerbose(this AzureDlaCatalogDatabaseShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogDatabaseShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogDatabaseShowSettings ResetVerbose(this AzureDlaCatalogDatabaseShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlaCatalogExternalDataSourceListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlaCatalogExternalDataSourceListSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogExternalDataSourceListSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaCatalogExternalDataSourceListSettings SetAccount(this AzureDlaCatalogExternalDataSourceListSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogExternalDataSourceListSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaCatalogExternalDataSourceListSettings ResetAccount(this AzureDlaCatalogExternalDataSourceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region DatabaseName
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogExternalDataSourceListSettings.DatabaseName"/>.</em></p><p>The name of the database containing the external data sources.</p></summary>
        [Pure]
        public static AzureDlaCatalogExternalDataSourceListSettings SetDatabaseName(this AzureDlaCatalogExternalDataSourceListSettings toolSettings, string databaseName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DatabaseName = databaseName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogExternalDataSourceListSettings.DatabaseName"/>.</em></p><p>The name of the database containing the external data sources.</p></summary>
        [Pure]
        public static AzureDlaCatalogExternalDataSourceListSettings ResetDatabaseName(this AzureDlaCatalogExternalDataSourceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DatabaseName = null;
            return toolSettings;
        }
        #endregion
        #region Count
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogExternalDataSourceListSettings.Count"/>.</em></p><p>The Boolean value of true or false to request a count of the matching resources included with the resources in the response, e.g. Categories?$count=true.</p></summary>
        [Pure]
        public static AzureDlaCatalogExternalDataSourceListSettings SetCount(this AzureDlaCatalogExternalDataSourceListSettings toolSettings, string count)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Count = count;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogExternalDataSourceListSettings.Count"/>.</em></p><p>The Boolean value of true or false to request a count of the matching resources included with the resources in the response, e.g. Categories?$count=true.</p></summary>
        [Pure]
        public static AzureDlaCatalogExternalDataSourceListSettings ResetCount(this AzureDlaCatalogExternalDataSourceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Count = null;
            return toolSettings;
        }
        #endregion
        #region Filter
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogExternalDataSourceListSettings.Filter"/>.</em></p><p>OData filter. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogExternalDataSourceListSettings SetFilter(this AzureDlaCatalogExternalDataSourceListSettings toolSettings, string filter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = filter;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogExternalDataSourceListSettings.Filter"/>.</em></p><p>OData filter. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogExternalDataSourceListSettings ResetFilter(this AzureDlaCatalogExternalDataSourceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = null;
            return toolSettings;
        }
        #endregion
        #region Orderby
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogExternalDataSourceListSettings.Orderby"/> to a new list.</em></p><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogExternalDataSourceListSettings SetOrderby(this AzureDlaCatalogExternalDataSourceListSettings toolSettings, params string[] orderby)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OrderbyInternal = orderby.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogExternalDataSourceListSettings.Orderby"/> to a new list.</em></p><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogExternalDataSourceListSettings SetOrderby(this AzureDlaCatalogExternalDataSourceListSettings toolSettings, IEnumerable<string> orderby)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OrderbyInternal = orderby.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureDlaCatalogExternalDataSourceListSettings.Orderby"/>.</em></p><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogExternalDataSourceListSettings AddOrderby(this AzureDlaCatalogExternalDataSourceListSettings toolSettings, params string[] orderby)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OrderbyInternal.AddRange(orderby);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureDlaCatalogExternalDataSourceListSettings.Orderby"/>.</em></p><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogExternalDataSourceListSettings AddOrderby(this AzureDlaCatalogExternalDataSourceListSettings toolSettings, IEnumerable<string> orderby)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OrderbyInternal.AddRange(orderby);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureDlaCatalogExternalDataSourceListSettings.Orderby"/>.</em></p><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogExternalDataSourceListSettings ClearOrderby(this AzureDlaCatalogExternalDataSourceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OrderbyInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureDlaCatalogExternalDataSourceListSettings.Orderby"/>.</em></p><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogExternalDataSourceListSettings RemoveOrderby(this AzureDlaCatalogExternalDataSourceListSettings toolSettings, params string[] orderby)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(orderby);
            toolSettings.OrderbyInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureDlaCatalogExternalDataSourceListSettings.Orderby"/>.</em></p><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogExternalDataSourceListSettings RemoveOrderby(this AzureDlaCatalogExternalDataSourceListSettings toolSettings, IEnumerable<string> orderby)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(orderby);
            toolSettings.OrderbyInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Select
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogExternalDataSourceListSettings.Select"/>.</em></p><p>OData Select statement. Limits the properties on each entry to just those requested, e.g. Categories?$select=CategoryName,Description. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogExternalDataSourceListSettings SetSelect(this AzureDlaCatalogExternalDataSourceListSettings toolSettings, string select)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Select = select;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogExternalDataSourceListSettings.Select"/>.</em></p><p>OData Select statement. Limits the properties on each entry to just those requested, e.g. Categories?$select=CategoryName,Description. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogExternalDataSourceListSettings ResetSelect(this AzureDlaCatalogExternalDataSourceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Select = null;
            return toolSettings;
        }
        #endregion
        #region Skip
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogExternalDataSourceListSettings.Skip"/>.</em></p><p>The number of items to skip over before returning elements.</p></summary>
        [Pure]
        public static AzureDlaCatalogExternalDataSourceListSettings SetSkip(this AzureDlaCatalogExternalDataSourceListSettings toolSettings, string skip)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Skip = skip;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogExternalDataSourceListSettings.Skip"/>.</em></p><p>The number of items to skip over before returning elements.</p></summary>
        [Pure]
        public static AzureDlaCatalogExternalDataSourceListSettings ResetSkip(this AzureDlaCatalogExternalDataSourceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Skip = null;
            return toolSettings;
        }
        #endregion
        #region Top
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogExternalDataSourceListSettings.Top"/>.</em></p><p>Maximum number of items to return.</p></summary>
        [Pure]
        public static AzureDlaCatalogExternalDataSourceListSettings SetTop(this AzureDlaCatalogExternalDataSourceListSettings toolSettings, int? top)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = top;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogExternalDataSourceListSettings.Top"/>.</em></p><p>Maximum number of items to return.</p></summary>
        [Pure]
        public static AzureDlaCatalogExternalDataSourceListSettings ResetTop(this AzureDlaCatalogExternalDataSourceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogExternalDataSourceListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogExternalDataSourceListSettings SetDebug(this AzureDlaCatalogExternalDataSourceListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogExternalDataSourceListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogExternalDataSourceListSettings ResetDebug(this AzureDlaCatalogExternalDataSourceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogExternalDataSourceListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaCatalogExternalDataSourceListSettings SetHelp(this AzureDlaCatalogExternalDataSourceListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogExternalDataSourceListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaCatalogExternalDataSourceListSettings ResetHelp(this AzureDlaCatalogExternalDataSourceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogExternalDataSourceListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaCatalogExternalDataSourceListSettings SetOutput(this AzureDlaCatalogExternalDataSourceListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogExternalDataSourceListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaCatalogExternalDataSourceListSettings ResetOutput(this AzureDlaCatalogExternalDataSourceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogExternalDataSourceListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaCatalogExternalDataSourceListSettings SetQuery(this AzureDlaCatalogExternalDataSourceListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogExternalDataSourceListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaCatalogExternalDataSourceListSettings ResetQuery(this AzureDlaCatalogExternalDataSourceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogExternalDataSourceListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogExternalDataSourceListSettings SetVerbose(this AzureDlaCatalogExternalDataSourceListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogExternalDataSourceListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogExternalDataSourceListSettings ResetVerbose(this AzureDlaCatalogExternalDataSourceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlaCatalogExternalDataSourceShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlaCatalogExternalDataSourceShowSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogExternalDataSourceShowSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaCatalogExternalDataSourceShowSettings SetAccount(this AzureDlaCatalogExternalDataSourceShowSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogExternalDataSourceShowSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaCatalogExternalDataSourceShowSettings ResetAccount(this AzureDlaCatalogExternalDataSourceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region DatabaseName
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogExternalDataSourceShowSettings.DatabaseName"/>.</em></p><p>The name of the database containing the external data source.</p></summary>
        [Pure]
        public static AzureDlaCatalogExternalDataSourceShowSettings SetDatabaseName(this AzureDlaCatalogExternalDataSourceShowSettings toolSettings, string databaseName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DatabaseName = databaseName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogExternalDataSourceShowSettings.DatabaseName"/>.</em></p><p>The name of the database containing the external data source.</p></summary>
        [Pure]
        public static AzureDlaCatalogExternalDataSourceShowSettings ResetDatabaseName(this AzureDlaCatalogExternalDataSourceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DatabaseName = null;
            return toolSettings;
        }
        #endregion
        #region ExternalDataSourceName
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogExternalDataSourceShowSettings.ExternalDataSourceName"/>.</em></p><p>The name of the external data source.</p></summary>
        [Pure]
        public static AzureDlaCatalogExternalDataSourceShowSettings SetExternalDataSourceName(this AzureDlaCatalogExternalDataSourceShowSettings toolSettings, string externalDataSourceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ExternalDataSourceName = externalDataSourceName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogExternalDataSourceShowSettings.ExternalDataSourceName"/>.</em></p><p>The name of the external data source.</p></summary>
        [Pure]
        public static AzureDlaCatalogExternalDataSourceShowSettings ResetExternalDataSourceName(this AzureDlaCatalogExternalDataSourceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ExternalDataSourceName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogExternalDataSourceShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogExternalDataSourceShowSettings SetDebug(this AzureDlaCatalogExternalDataSourceShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogExternalDataSourceShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogExternalDataSourceShowSettings ResetDebug(this AzureDlaCatalogExternalDataSourceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogExternalDataSourceShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaCatalogExternalDataSourceShowSettings SetHelp(this AzureDlaCatalogExternalDataSourceShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogExternalDataSourceShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaCatalogExternalDataSourceShowSettings ResetHelp(this AzureDlaCatalogExternalDataSourceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogExternalDataSourceShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaCatalogExternalDataSourceShowSettings SetOutput(this AzureDlaCatalogExternalDataSourceShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogExternalDataSourceShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaCatalogExternalDataSourceShowSettings ResetOutput(this AzureDlaCatalogExternalDataSourceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogExternalDataSourceShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaCatalogExternalDataSourceShowSettings SetQuery(this AzureDlaCatalogExternalDataSourceShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogExternalDataSourceShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaCatalogExternalDataSourceShowSettings ResetQuery(this AzureDlaCatalogExternalDataSourceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogExternalDataSourceShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogExternalDataSourceShowSettings SetVerbose(this AzureDlaCatalogExternalDataSourceShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogExternalDataSourceShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogExternalDataSourceShowSettings ResetVerbose(this AzureDlaCatalogExternalDataSourceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlaCatalogPackageListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlaCatalogPackageListSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogPackageListSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaCatalogPackageListSettings SetAccount(this AzureDlaCatalogPackageListSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogPackageListSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaCatalogPackageListSettings ResetAccount(this AzureDlaCatalogPackageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region DatabaseName
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogPackageListSettings.DatabaseName"/>.</em></p><p>The name of the database containing the packages.</p></summary>
        [Pure]
        public static AzureDlaCatalogPackageListSettings SetDatabaseName(this AzureDlaCatalogPackageListSettings toolSettings, string databaseName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DatabaseName = databaseName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogPackageListSettings.DatabaseName"/>.</em></p><p>The name of the database containing the packages.</p></summary>
        [Pure]
        public static AzureDlaCatalogPackageListSettings ResetDatabaseName(this AzureDlaCatalogPackageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DatabaseName = null;
            return toolSettings;
        }
        #endregion
        #region SchemaName
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogPackageListSettings.SchemaName"/>.</em></p><p>The name of the schema containing the packages.</p></summary>
        [Pure]
        public static AzureDlaCatalogPackageListSettings SetSchemaName(this AzureDlaCatalogPackageListSettings toolSettings, string schemaName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SchemaName = schemaName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogPackageListSettings.SchemaName"/>.</em></p><p>The name of the schema containing the packages.</p></summary>
        [Pure]
        public static AzureDlaCatalogPackageListSettings ResetSchemaName(this AzureDlaCatalogPackageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SchemaName = null;
            return toolSettings;
        }
        #endregion
        #region Count
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogPackageListSettings.Count"/>.</em></p><p>The Boolean value of true or false to request a count of the matching resources included with the resources in the response, e.g. Categories?$count=true.</p></summary>
        [Pure]
        public static AzureDlaCatalogPackageListSettings SetCount(this AzureDlaCatalogPackageListSettings toolSettings, string count)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Count = count;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogPackageListSettings.Count"/>.</em></p><p>The Boolean value of true or false to request a count of the matching resources included with the resources in the response, e.g. Categories?$count=true.</p></summary>
        [Pure]
        public static AzureDlaCatalogPackageListSettings ResetCount(this AzureDlaCatalogPackageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Count = null;
            return toolSettings;
        }
        #endregion
        #region Filter
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogPackageListSettings.Filter"/>.</em></p><p>OData filter. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogPackageListSettings SetFilter(this AzureDlaCatalogPackageListSettings toolSettings, string filter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = filter;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogPackageListSettings.Filter"/>.</em></p><p>OData filter. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogPackageListSettings ResetFilter(this AzureDlaCatalogPackageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = null;
            return toolSettings;
        }
        #endregion
        #region Orderby
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogPackageListSettings.Orderby"/> to a new list.</em></p><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogPackageListSettings SetOrderby(this AzureDlaCatalogPackageListSettings toolSettings, params string[] orderby)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OrderbyInternal = orderby.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogPackageListSettings.Orderby"/> to a new list.</em></p><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogPackageListSettings SetOrderby(this AzureDlaCatalogPackageListSettings toolSettings, IEnumerable<string> orderby)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OrderbyInternal = orderby.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureDlaCatalogPackageListSettings.Orderby"/>.</em></p><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogPackageListSettings AddOrderby(this AzureDlaCatalogPackageListSettings toolSettings, params string[] orderby)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OrderbyInternal.AddRange(orderby);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureDlaCatalogPackageListSettings.Orderby"/>.</em></p><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogPackageListSettings AddOrderby(this AzureDlaCatalogPackageListSettings toolSettings, IEnumerable<string> orderby)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OrderbyInternal.AddRange(orderby);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureDlaCatalogPackageListSettings.Orderby"/>.</em></p><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogPackageListSettings ClearOrderby(this AzureDlaCatalogPackageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OrderbyInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureDlaCatalogPackageListSettings.Orderby"/>.</em></p><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogPackageListSettings RemoveOrderby(this AzureDlaCatalogPackageListSettings toolSettings, params string[] orderby)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(orderby);
            toolSettings.OrderbyInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureDlaCatalogPackageListSettings.Orderby"/>.</em></p><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogPackageListSettings RemoveOrderby(this AzureDlaCatalogPackageListSettings toolSettings, IEnumerable<string> orderby)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(orderby);
            toolSettings.OrderbyInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Select
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogPackageListSettings.Select"/>.</em></p><p>OData Select statement. Limits the properties on each entry to just those requested, e.g. Categories?$select=CategoryName,Description. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogPackageListSettings SetSelect(this AzureDlaCatalogPackageListSettings toolSettings, string select)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Select = select;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogPackageListSettings.Select"/>.</em></p><p>OData Select statement. Limits the properties on each entry to just those requested, e.g. Categories?$select=CategoryName,Description. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogPackageListSettings ResetSelect(this AzureDlaCatalogPackageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Select = null;
            return toolSettings;
        }
        #endregion
        #region Skip
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogPackageListSettings.Skip"/>.</em></p><p>The number of items to skip over before returning elements.</p></summary>
        [Pure]
        public static AzureDlaCatalogPackageListSettings SetSkip(this AzureDlaCatalogPackageListSettings toolSettings, string skip)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Skip = skip;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogPackageListSettings.Skip"/>.</em></p><p>The number of items to skip over before returning elements.</p></summary>
        [Pure]
        public static AzureDlaCatalogPackageListSettings ResetSkip(this AzureDlaCatalogPackageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Skip = null;
            return toolSettings;
        }
        #endregion
        #region Top
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogPackageListSettings.Top"/>.</em></p><p>Maximum number of items to return.</p></summary>
        [Pure]
        public static AzureDlaCatalogPackageListSettings SetTop(this AzureDlaCatalogPackageListSettings toolSettings, int? top)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = top;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogPackageListSettings.Top"/>.</em></p><p>Maximum number of items to return.</p></summary>
        [Pure]
        public static AzureDlaCatalogPackageListSettings ResetTop(this AzureDlaCatalogPackageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogPackageListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogPackageListSettings SetDebug(this AzureDlaCatalogPackageListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogPackageListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogPackageListSettings ResetDebug(this AzureDlaCatalogPackageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogPackageListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaCatalogPackageListSettings SetHelp(this AzureDlaCatalogPackageListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogPackageListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaCatalogPackageListSettings ResetHelp(this AzureDlaCatalogPackageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogPackageListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaCatalogPackageListSettings SetOutput(this AzureDlaCatalogPackageListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogPackageListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaCatalogPackageListSettings ResetOutput(this AzureDlaCatalogPackageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogPackageListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaCatalogPackageListSettings SetQuery(this AzureDlaCatalogPackageListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogPackageListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaCatalogPackageListSettings ResetQuery(this AzureDlaCatalogPackageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogPackageListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogPackageListSettings SetVerbose(this AzureDlaCatalogPackageListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogPackageListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogPackageListSettings ResetVerbose(this AzureDlaCatalogPackageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlaCatalogPackageShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlaCatalogPackageShowSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogPackageShowSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaCatalogPackageShowSettings SetAccount(this AzureDlaCatalogPackageShowSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogPackageShowSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaCatalogPackageShowSettings ResetAccount(this AzureDlaCatalogPackageShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region DatabaseName
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogPackageShowSettings.DatabaseName"/>.</em></p><p>The name of the database containing the package.</p></summary>
        [Pure]
        public static AzureDlaCatalogPackageShowSettings SetDatabaseName(this AzureDlaCatalogPackageShowSettings toolSettings, string databaseName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DatabaseName = databaseName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogPackageShowSettings.DatabaseName"/>.</em></p><p>The name of the database containing the package.</p></summary>
        [Pure]
        public static AzureDlaCatalogPackageShowSettings ResetDatabaseName(this AzureDlaCatalogPackageShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DatabaseName = null;
            return toolSettings;
        }
        #endregion
        #region PackageName
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogPackageShowSettings.PackageName"/>.</em></p><p>The name of the package.</p></summary>
        [Pure]
        public static AzureDlaCatalogPackageShowSettings SetPackageName(this AzureDlaCatalogPackageShowSettings toolSettings, string packageName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PackageName = packageName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogPackageShowSettings.PackageName"/>.</em></p><p>The name of the package.</p></summary>
        [Pure]
        public static AzureDlaCatalogPackageShowSettings ResetPackageName(this AzureDlaCatalogPackageShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PackageName = null;
            return toolSettings;
        }
        #endregion
        #region SchemaName
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogPackageShowSettings.SchemaName"/>.</em></p><p>The name of the schema containing the package.</p></summary>
        [Pure]
        public static AzureDlaCatalogPackageShowSettings SetSchemaName(this AzureDlaCatalogPackageShowSettings toolSettings, string schemaName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SchemaName = schemaName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogPackageShowSettings.SchemaName"/>.</em></p><p>The name of the schema containing the package.</p></summary>
        [Pure]
        public static AzureDlaCatalogPackageShowSettings ResetSchemaName(this AzureDlaCatalogPackageShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SchemaName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogPackageShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogPackageShowSettings SetDebug(this AzureDlaCatalogPackageShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogPackageShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogPackageShowSettings ResetDebug(this AzureDlaCatalogPackageShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogPackageShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaCatalogPackageShowSettings SetHelp(this AzureDlaCatalogPackageShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogPackageShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaCatalogPackageShowSettings ResetHelp(this AzureDlaCatalogPackageShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogPackageShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaCatalogPackageShowSettings SetOutput(this AzureDlaCatalogPackageShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogPackageShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaCatalogPackageShowSettings ResetOutput(this AzureDlaCatalogPackageShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogPackageShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaCatalogPackageShowSettings SetQuery(this AzureDlaCatalogPackageShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogPackageShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaCatalogPackageShowSettings ResetQuery(this AzureDlaCatalogPackageShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogPackageShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogPackageShowSettings SetVerbose(this AzureDlaCatalogPackageShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogPackageShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogPackageShowSettings ResetVerbose(this AzureDlaCatalogPackageShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlaCatalogProcedureListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlaCatalogProcedureListSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogProcedureListSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaCatalogProcedureListSettings SetAccount(this AzureDlaCatalogProcedureListSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogProcedureListSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaCatalogProcedureListSettings ResetAccount(this AzureDlaCatalogProcedureListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region DatabaseName
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogProcedureListSettings.DatabaseName"/>.</em></p><p>The name of the database containing the procedures.</p></summary>
        [Pure]
        public static AzureDlaCatalogProcedureListSettings SetDatabaseName(this AzureDlaCatalogProcedureListSettings toolSettings, string databaseName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DatabaseName = databaseName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogProcedureListSettings.DatabaseName"/>.</em></p><p>The name of the database containing the procedures.</p></summary>
        [Pure]
        public static AzureDlaCatalogProcedureListSettings ResetDatabaseName(this AzureDlaCatalogProcedureListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DatabaseName = null;
            return toolSettings;
        }
        #endregion
        #region SchemaName
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogProcedureListSettings.SchemaName"/>.</em></p><p>The name of the schema containing the procedures.</p></summary>
        [Pure]
        public static AzureDlaCatalogProcedureListSettings SetSchemaName(this AzureDlaCatalogProcedureListSettings toolSettings, string schemaName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SchemaName = schemaName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogProcedureListSettings.SchemaName"/>.</em></p><p>The name of the schema containing the procedures.</p></summary>
        [Pure]
        public static AzureDlaCatalogProcedureListSettings ResetSchemaName(this AzureDlaCatalogProcedureListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SchemaName = null;
            return toolSettings;
        }
        #endregion
        #region Count
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogProcedureListSettings.Count"/>.</em></p><p>The Boolean value of true or false to request a count of the matching resources included with the resources in the response, e.g. Categories?$count=true.</p></summary>
        [Pure]
        public static AzureDlaCatalogProcedureListSettings SetCount(this AzureDlaCatalogProcedureListSettings toolSettings, string count)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Count = count;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogProcedureListSettings.Count"/>.</em></p><p>The Boolean value of true or false to request a count of the matching resources included with the resources in the response, e.g. Categories?$count=true.</p></summary>
        [Pure]
        public static AzureDlaCatalogProcedureListSettings ResetCount(this AzureDlaCatalogProcedureListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Count = null;
            return toolSettings;
        }
        #endregion
        #region Filter
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogProcedureListSettings.Filter"/>.</em></p><p>OData filter. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogProcedureListSettings SetFilter(this AzureDlaCatalogProcedureListSettings toolSettings, string filter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = filter;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogProcedureListSettings.Filter"/>.</em></p><p>OData filter. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogProcedureListSettings ResetFilter(this AzureDlaCatalogProcedureListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = null;
            return toolSettings;
        }
        #endregion
        #region Orderby
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogProcedureListSettings.Orderby"/> to a new list.</em></p><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogProcedureListSettings SetOrderby(this AzureDlaCatalogProcedureListSettings toolSettings, params string[] orderby)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OrderbyInternal = orderby.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogProcedureListSettings.Orderby"/> to a new list.</em></p><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogProcedureListSettings SetOrderby(this AzureDlaCatalogProcedureListSettings toolSettings, IEnumerable<string> orderby)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OrderbyInternal = orderby.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureDlaCatalogProcedureListSettings.Orderby"/>.</em></p><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogProcedureListSettings AddOrderby(this AzureDlaCatalogProcedureListSettings toolSettings, params string[] orderby)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OrderbyInternal.AddRange(orderby);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureDlaCatalogProcedureListSettings.Orderby"/>.</em></p><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogProcedureListSettings AddOrderby(this AzureDlaCatalogProcedureListSettings toolSettings, IEnumerable<string> orderby)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OrderbyInternal.AddRange(orderby);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureDlaCatalogProcedureListSettings.Orderby"/>.</em></p><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogProcedureListSettings ClearOrderby(this AzureDlaCatalogProcedureListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OrderbyInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureDlaCatalogProcedureListSettings.Orderby"/>.</em></p><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogProcedureListSettings RemoveOrderby(this AzureDlaCatalogProcedureListSettings toolSettings, params string[] orderby)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(orderby);
            toolSettings.OrderbyInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureDlaCatalogProcedureListSettings.Orderby"/>.</em></p><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogProcedureListSettings RemoveOrderby(this AzureDlaCatalogProcedureListSettings toolSettings, IEnumerable<string> orderby)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(orderby);
            toolSettings.OrderbyInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Select
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogProcedureListSettings.Select"/>.</em></p><p>OData Select statement. Limits the properties on each entry to just those requested, e.g. Categories?$select=CategoryName,Description. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogProcedureListSettings SetSelect(this AzureDlaCatalogProcedureListSettings toolSettings, string select)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Select = select;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogProcedureListSettings.Select"/>.</em></p><p>OData Select statement. Limits the properties on each entry to just those requested, e.g. Categories?$select=CategoryName,Description. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogProcedureListSettings ResetSelect(this AzureDlaCatalogProcedureListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Select = null;
            return toolSettings;
        }
        #endregion
        #region Skip
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogProcedureListSettings.Skip"/>.</em></p><p>The number of items to skip over before returning elements.</p></summary>
        [Pure]
        public static AzureDlaCatalogProcedureListSettings SetSkip(this AzureDlaCatalogProcedureListSettings toolSettings, string skip)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Skip = skip;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogProcedureListSettings.Skip"/>.</em></p><p>The number of items to skip over before returning elements.</p></summary>
        [Pure]
        public static AzureDlaCatalogProcedureListSettings ResetSkip(this AzureDlaCatalogProcedureListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Skip = null;
            return toolSettings;
        }
        #endregion
        #region Top
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogProcedureListSettings.Top"/>.</em></p><p>Maximum number of items to return.</p></summary>
        [Pure]
        public static AzureDlaCatalogProcedureListSettings SetTop(this AzureDlaCatalogProcedureListSettings toolSettings, int? top)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = top;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogProcedureListSettings.Top"/>.</em></p><p>Maximum number of items to return.</p></summary>
        [Pure]
        public static AzureDlaCatalogProcedureListSettings ResetTop(this AzureDlaCatalogProcedureListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogProcedureListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogProcedureListSettings SetDebug(this AzureDlaCatalogProcedureListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogProcedureListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogProcedureListSettings ResetDebug(this AzureDlaCatalogProcedureListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogProcedureListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaCatalogProcedureListSettings SetHelp(this AzureDlaCatalogProcedureListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogProcedureListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaCatalogProcedureListSettings ResetHelp(this AzureDlaCatalogProcedureListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogProcedureListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaCatalogProcedureListSettings SetOutput(this AzureDlaCatalogProcedureListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogProcedureListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaCatalogProcedureListSettings ResetOutput(this AzureDlaCatalogProcedureListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogProcedureListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaCatalogProcedureListSettings SetQuery(this AzureDlaCatalogProcedureListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogProcedureListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaCatalogProcedureListSettings ResetQuery(this AzureDlaCatalogProcedureListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogProcedureListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogProcedureListSettings SetVerbose(this AzureDlaCatalogProcedureListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogProcedureListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogProcedureListSettings ResetVerbose(this AzureDlaCatalogProcedureListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlaCatalogProcedureShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlaCatalogProcedureShowSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogProcedureShowSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaCatalogProcedureShowSettings SetAccount(this AzureDlaCatalogProcedureShowSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogProcedureShowSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaCatalogProcedureShowSettings ResetAccount(this AzureDlaCatalogProcedureShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region DatabaseName
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogProcedureShowSettings.DatabaseName"/>.</em></p><p>The name of the database containing the procedure.</p></summary>
        [Pure]
        public static AzureDlaCatalogProcedureShowSettings SetDatabaseName(this AzureDlaCatalogProcedureShowSettings toolSettings, string databaseName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DatabaseName = databaseName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogProcedureShowSettings.DatabaseName"/>.</em></p><p>The name of the database containing the procedure.</p></summary>
        [Pure]
        public static AzureDlaCatalogProcedureShowSettings ResetDatabaseName(this AzureDlaCatalogProcedureShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DatabaseName = null;
            return toolSettings;
        }
        #endregion
        #region ProcedureName
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogProcedureShowSettings.ProcedureName"/>.</em></p><p>The name of the procedure.</p></summary>
        [Pure]
        public static AzureDlaCatalogProcedureShowSettings SetProcedureName(this AzureDlaCatalogProcedureShowSettings toolSettings, string procedureName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProcedureName = procedureName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogProcedureShowSettings.ProcedureName"/>.</em></p><p>The name of the procedure.</p></summary>
        [Pure]
        public static AzureDlaCatalogProcedureShowSettings ResetProcedureName(this AzureDlaCatalogProcedureShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProcedureName = null;
            return toolSettings;
        }
        #endregion
        #region SchemaName
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogProcedureShowSettings.SchemaName"/>.</em></p><p>The name of the schema containing the procedure.</p></summary>
        [Pure]
        public static AzureDlaCatalogProcedureShowSettings SetSchemaName(this AzureDlaCatalogProcedureShowSettings toolSettings, string schemaName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SchemaName = schemaName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogProcedureShowSettings.SchemaName"/>.</em></p><p>The name of the schema containing the procedure.</p></summary>
        [Pure]
        public static AzureDlaCatalogProcedureShowSettings ResetSchemaName(this AzureDlaCatalogProcedureShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SchemaName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogProcedureShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogProcedureShowSettings SetDebug(this AzureDlaCatalogProcedureShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogProcedureShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogProcedureShowSettings ResetDebug(this AzureDlaCatalogProcedureShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogProcedureShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaCatalogProcedureShowSettings SetHelp(this AzureDlaCatalogProcedureShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogProcedureShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaCatalogProcedureShowSettings ResetHelp(this AzureDlaCatalogProcedureShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogProcedureShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaCatalogProcedureShowSettings SetOutput(this AzureDlaCatalogProcedureShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogProcedureShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaCatalogProcedureShowSettings ResetOutput(this AzureDlaCatalogProcedureShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogProcedureShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaCatalogProcedureShowSettings SetQuery(this AzureDlaCatalogProcedureShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogProcedureShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaCatalogProcedureShowSettings ResetQuery(this AzureDlaCatalogProcedureShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogProcedureShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogProcedureShowSettings SetVerbose(this AzureDlaCatalogProcedureShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogProcedureShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogProcedureShowSettings ResetVerbose(this AzureDlaCatalogProcedureShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlaCatalogSchemaListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlaCatalogSchemaListSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogSchemaListSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaCatalogSchemaListSettings SetAccount(this AzureDlaCatalogSchemaListSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogSchemaListSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaCatalogSchemaListSettings ResetAccount(this AzureDlaCatalogSchemaListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region DatabaseName
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogSchemaListSettings.DatabaseName"/>.</em></p><p>The name of the database containing the schema.</p></summary>
        [Pure]
        public static AzureDlaCatalogSchemaListSettings SetDatabaseName(this AzureDlaCatalogSchemaListSettings toolSettings, string databaseName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DatabaseName = databaseName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogSchemaListSettings.DatabaseName"/>.</em></p><p>The name of the database containing the schema.</p></summary>
        [Pure]
        public static AzureDlaCatalogSchemaListSettings ResetDatabaseName(this AzureDlaCatalogSchemaListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DatabaseName = null;
            return toolSettings;
        }
        #endregion
        #region Count
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogSchemaListSettings.Count"/>.</em></p><p>The Boolean value of true or false to request a count of the matching resources included with the resources in the response, e.g. Categories?$count=true.</p></summary>
        [Pure]
        public static AzureDlaCatalogSchemaListSettings SetCount(this AzureDlaCatalogSchemaListSettings toolSettings, string count)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Count = count;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogSchemaListSettings.Count"/>.</em></p><p>The Boolean value of true or false to request a count of the matching resources included with the resources in the response, e.g. Categories?$count=true.</p></summary>
        [Pure]
        public static AzureDlaCatalogSchemaListSettings ResetCount(this AzureDlaCatalogSchemaListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Count = null;
            return toolSettings;
        }
        #endregion
        #region Filter
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogSchemaListSettings.Filter"/>.</em></p><p>OData filter. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogSchemaListSettings SetFilter(this AzureDlaCatalogSchemaListSettings toolSettings, string filter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = filter;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogSchemaListSettings.Filter"/>.</em></p><p>OData filter. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogSchemaListSettings ResetFilter(this AzureDlaCatalogSchemaListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = null;
            return toolSettings;
        }
        #endregion
        #region Orderby
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogSchemaListSettings.Orderby"/> to a new list.</em></p><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogSchemaListSettings SetOrderby(this AzureDlaCatalogSchemaListSettings toolSettings, params string[] orderby)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OrderbyInternal = orderby.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogSchemaListSettings.Orderby"/> to a new list.</em></p><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogSchemaListSettings SetOrderby(this AzureDlaCatalogSchemaListSettings toolSettings, IEnumerable<string> orderby)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OrderbyInternal = orderby.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureDlaCatalogSchemaListSettings.Orderby"/>.</em></p><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogSchemaListSettings AddOrderby(this AzureDlaCatalogSchemaListSettings toolSettings, params string[] orderby)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OrderbyInternal.AddRange(orderby);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureDlaCatalogSchemaListSettings.Orderby"/>.</em></p><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogSchemaListSettings AddOrderby(this AzureDlaCatalogSchemaListSettings toolSettings, IEnumerable<string> orderby)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OrderbyInternal.AddRange(orderby);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureDlaCatalogSchemaListSettings.Orderby"/>.</em></p><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogSchemaListSettings ClearOrderby(this AzureDlaCatalogSchemaListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OrderbyInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureDlaCatalogSchemaListSettings.Orderby"/>.</em></p><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogSchemaListSettings RemoveOrderby(this AzureDlaCatalogSchemaListSettings toolSettings, params string[] orderby)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(orderby);
            toolSettings.OrderbyInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureDlaCatalogSchemaListSettings.Orderby"/>.</em></p><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogSchemaListSettings RemoveOrderby(this AzureDlaCatalogSchemaListSettings toolSettings, IEnumerable<string> orderby)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(orderby);
            toolSettings.OrderbyInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Select
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogSchemaListSettings.Select"/>.</em></p><p>OData Select statement. Limits the properties on each entry to just those requested, e.g. Categories?$select=CategoryName,Description. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogSchemaListSettings SetSelect(this AzureDlaCatalogSchemaListSettings toolSettings, string select)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Select = select;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogSchemaListSettings.Select"/>.</em></p><p>OData Select statement. Limits the properties on each entry to just those requested, e.g. Categories?$select=CategoryName,Description. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogSchemaListSettings ResetSelect(this AzureDlaCatalogSchemaListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Select = null;
            return toolSettings;
        }
        #endregion
        #region Skip
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogSchemaListSettings.Skip"/>.</em></p><p>The number of items to skip over before returning elements.</p></summary>
        [Pure]
        public static AzureDlaCatalogSchemaListSettings SetSkip(this AzureDlaCatalogSchemaListSettings toolSettings, string skip)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Skip = skip;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogSchemaListSettings.Skip"/>.</em></p><p>The number of items to skip over before returning elements.</p></summary>
        [Pure]
        public static AzureDlaCatalogSchemaListSettings ResetSkip(this AzureDlaCatalogSchemaListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Skip = null;
            return toolSettings;
        }
        #endregion
        #region Top
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogSchemaListSettings.Top"/>.</em></p><p>Maximum number of items to return.</p></summary>
        [Pure]
        public static AzureDlaCatalogSchemaListSettings SetTop(this AzureDlaCatalogSchemaListSettings toolSettings, int? top)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = top;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogSchemaListSettings.Top"/>.</em></p><p>Maximum number of items to return.</p></summary>
        [Pure]
        public static AzureDlaCatalogSchemaListSettings ResetTop(this AzureDlaCatalogSchemaListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogSchemaListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogSchemaListSettings SetDebug(this AzureDlaCatalogSchemaListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogSchemaListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogSchemaListSettings ResetDebug(this AzureDlaCatalogSchemaListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogSchemaListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaCatalogSchemaListSettings SetHelp(this AzureDlaCatalogSchemaListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogSchemaListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaCatalogSchemaListSettings ResetHelp(this AzureDlaCatalogSchemaListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogSchemaListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaCatalogSchemaListSettings SetOutput(this AzureDlaCatalogSchemaListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogSchemaListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaCatalogSchemaListSettings ResetOutput(this AzureDlaCatalogSchemaListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogSchemaListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaCatalogSchemaListSettings SetQuery(this AzureDlaCatalogSchemaListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogSchemaListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaCatalogSchemaListSettings ResetQuery(this AzureDlaCatalogSchemaListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogSchemaListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogSchemaListSettings SetVerbose(this AzureDlaCatalogSchemaListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogSchemaListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogSchemaListSettings ResetVerbose(this AzureDlaCatalogSchemaListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlaCatalogSchemaShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlaCatalogSchemaShowSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogSchemaShowSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaCatalogSchemaShowSettings SetAccount(this AzureDlaCatalogSchemaShowSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogSchemaShowSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaCatalogSchemaShowSettings ResetAccount(this AzureDlaCatalogSchemaShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region DatabaseName
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogSchemaShowSettings.DatabaseName"/>.</em></p><p>The name of the database containing the schema.</p></summary>
        [Pure]
        public static AzureDlaCatalogSchemaShowSettings SetDatabaseName(this AzureDlaCatalogSchemaShowSettings toolSettings, string databaseName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DatabaseName = databaseName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogSchemaShowSettings.DatabaseName"/>.</em></p><p>The name of the database containing the schema.</p></summary>
        [Pure]
        public static AzureDlaCatalogSchemaShowSettings ResetDatabaseName(this AzureDlaCatalogSchemaShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DatabaseName = null;
            return toolSettings;
        }
        #endregion
        #region SchemaName
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogSchemaShowSettings.SchemaName"/>.</em></p><p>The name of the schema.</p></summary>
        [Pure]
        public static AzureDlaCatalogSchemaShowSettings SetSchemaName(this AzureDlaCatalogSchemaShowSettings toolSettings, string schemaName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SchemaName = schemaName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogSchemaShowSettings.SchemaName"/>.</em></p><p>The name of the schema.</p></summary>
        [Pure]
        public static AzureDlaCatalogSchemaShowSettings ResetSchemaName(this AzureDlaCatalogSchemaShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SchemaName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogSchemaShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogSchemaShowSettings SetDebug(this AzureDlaCatalogSchemaShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogSchemaShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogSchemaShowSettings ResetDebug(this AzureDlaCatalogSchemaShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogSchemaShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaCatalogSchemaShowSettings SetHelp(this AzureDlaCatalogSchemaShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogSchemaShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaCatalogSchemaShowSettings ResetHelp(this AzureDlaCatalogSchemaShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogSchemaShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaCatalogSchemaShowSettings SetOutput(this AzureDlaCatalogSchemaShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogSchemaShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaCatalogSchemaShowSettings ResetOutput(this AzureDlaCatalogSchemaShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogSchemaShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaCatalogSchemaShowSettings SetQuery(this AzureDlaCatalogSchemaShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogSchemaShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaCatalogSchemaShowSettings ResetQuery(this AzureDlaCatalogSchemaShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogSchemaShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogSchemaShowSettings SetVerbose(this AzureDlaCatalogSchemaShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogSchemaShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogSchemaShowSettings ResetVerbose(this AzureDlaCatalogSchemaShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlaCatalogTablePartitionListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlaCatalogTablePartitionListSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTablePartitionListSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaCatalogTablePartitionListSettings SetAccount(this AzureDlaCatalogTablePartitionListSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTablePartitionListSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaCatalogTablePartitionListSettings ResetAccount(this AzureDlaCatalogTablePartitionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region DatabaseName
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTablePartitionListSettings.DatabaseName"/>.</em></p><p>The name of the database containing the partitions.</p></summary>
        [Pure]
        public static AzureDlaCatalogTablePartitionListSettings SetDatabaseName(this AzureDlaCatalogTablePartitionListSettings toolSettings, string databaseName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DatabaseName = databaseName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTablePartitionListSettings.DatabaseName"/>.</em></p><p>The name of the database containing the partitions.</p></summary>
        [Pure]
        public static AzureDlaCatalogTablePartitionListSettings ResetDatabaseName(this AzureDlaCatalogTablePartitionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DatabaseName = null;
            return toolSettings;
        }
        #endregion
        #region SchemaName
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTablePartitionListSettings.SchemaName"/>.</em></p><p>The name of the schema containing the partitions.</p></summary>
        [Pure]
        public static AzureDlaCatalogTablePartitionListSettings SetSchemaName(this AzureDlaCatalogTablePartitionListSettings toolSettings, string schemaName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SchemaName = schemaName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTablePartitionListSettings.SchemaName"/>.</em></p><p>The name of the schema containing the partitions.</p></summary>
        [Pure]
        public static AzureDlaCatalogTablePartitionListSettings ResetSchemaName(this AzureDlaCatalogTablePartitionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SchemaName = null;
            return toolSettings;
        }
        #endregion
        #region TableName
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTablePartitionListSettings.TableName"/>.</em></p><p>The name of the table containing the partitions.</p></summary>
        [Pure]
        public static AzureDlaCatalogTablePartitionListSettings SetTableName(this AzureDlaCatalogTablePartitionListSettings toolSettings, string tableName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TableName = tableName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTablePartitionListSettings.TableName"/>.</em></p><p>The name of the table containing the partitions.</p></summary>
        [Pure]
        public static AzureDlaCatalogTablePartitionListSettings ResetTableName(this AzureDlaCatalogTablePartitionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TableName = null;
            return toolSettings;
        }
        #endregion
        #region Count
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTablePartitionListSettings.Count"/>.</em></p><p>The Boolean value of true or false to request a count of the matching resources included with the resources in the response, e.g. Categories?$count=true.</p></summary>
        [Pure]
        public static AzureDlaCatalogTablePartitionListSettings SetCount(this AzureDlaCatalogTablePartitionListSettings toolSettings, string count)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Count = count;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTablePartitionListSettings.Count"/>.</em></p><p>The Boolean value of true or false to request a count of the matching resources included with the resources in the response, e.g. Categories?$count=true.</p></summary>
        [Pure]
        public static AzureDlaCatalogTablePartitionListSettings ResetCount(this AzureDlaCatalogTablePartitionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Count = null;
            return toolSettings;
        }
        #endregion
        #region Filter
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTablePartitionListSettings.Filter"/>.</em></p><p>OData filter. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogTablePartitionListSettings SetFilter(this AzureDlaCatalogTablePartitionListSettings toolSettings, string filter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = filter;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTablePartitionListSettings.Filter"/>.</em></p><p>OData filter. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogTablePartitionListSettings ResetFilter(this AzureDlaCatalogTablePartitionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = null;
            return toolSettings;
        }
        #endregion
        #region Orderby
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTablePartitionListSettings.Orderby"/> to a new list.</em></p><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogTablePartitionListSettings SetOrderby(this AzureDlaCatalogTablePartitionListSettings toolSettings, params string[] orderby)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OrderbyInternal = orderby.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTablePartitionListSettings.Orderby"/> to a new list.</em></p><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogTablePartitionListSettings SetOrderby(this AzureDlaCatalogTablePartitionListSettings toolSettings, IEnumerable<string> orderby)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OrderbyInternal = orderby.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureDlaCatalogTablePartitionListSettings.Orderby"/>.</em></p><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogTablePartitionListSettings AddOrderby(this AzureDlaCatalogTablePartitionListSettings toolSettings, params string[] orderby)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OrderbyInternal.AddRange(orderby);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureDlaCatalogTablePartitionListSettings.Orderby"/>.</em></p><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogTablePartitionListSettings AddOrderby(this AzureDlaCatalogTablePartitionListSettings toolSettings, IEnumerable<string> orderby)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OrderbyInternal.AddRange(orderby);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureDlaCatalogTablePartitionListSettings.Orderby"/>.</em></p><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogTablePartitionListSettings ClearOrderby(this AzureDlaCatalogTablePartitionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OrderbyInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureDlaCatalogTablePartitionListSettings.Orderby"/>.</em></p><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogTablePartitionListSettings RemoveOrderby(this AzureDlaCatalogTablePartitionListSettings toolSettings, params string[] orderby)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(orderby);
            toolSettings.OrderbyInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureDlaCatalogTablePartitionListSettings.Orderby"/>.</em></p><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogTablePartitionListSettings RemoveOrderby(this AzureDlaCatalogTablePartitionListSettings toolSettings, IEnumerable<string> orderby)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(orderby);
            toolSettings.OrderbyInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Select
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTablePartitionListSettings.Select"/>.</em></p><p>OData Select statement. Limits the properties on each entry to just those requested, e.g. Categories?$select=CategoryName,Description. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogTablePartitionListSettings SetSelect(this AzureDlaCatalogTablePartitionListSettings toolSettings, string select)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Select = select;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTablePartitionListSettings.Select"/>.</em></p><p>OData Select statement. Limits the properties on each entry to just those requested, e.g. Categories?$select=CategoryName,Description. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogTablePartitionListSettings ResetSelect(this AzureDlaCatalogTablePartitionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Select = null;
            return toolSettings;
        }
        #endregion
        #region Skip
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTablePartitionListSettings.Skip"/>.</em></p><p>The number of items to skip over before returning elements.</p></summary>
        [Pure]
        public static AzureDlaCatalogTablePartitionListSettings SetSkip(this AzureDlaCatalogTablePartitionListSettings toolSettings, string skip)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Skip = skip;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTablePartitionListSettings.Skip"/>.</em></p><p>The number of items to skip over before returning elements.</p></summary>
        [Pure]
        public static AzureDlaCatalogTablePartitionListSettings ResetSkip(this AzureDlaCatalogTablePartitionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Skip = null;
            return toolSettings;
        }
        #endregion
        #region Top
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTablePartitionListSettings.Top"/>.</em></p><p>Maximum number of items to return.</p></summary>
        [Pure]
        public static AzureDlaCatalogTablePartitionListSettings SetTop(this AzureDlaCatalogTablePartitionListSettings toolSettings, int? top)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = top;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTablePartitionListSettings.Top"/>.</em></p><p>Maximum number of items to return.</p></summary>
        [Pure]
        public static AzureDlaCatalogTablePartitionListSettings ResetTop(this AzureDlaCatalogTablePartitionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTablePartitionListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogTablePartitionListSettings SetDebug(this AzureDlaCatalogTablePartitionListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTablePartitionListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogTablePartitionListSettings ResetDebug(this AzureDlaCatalogTablePartitionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTablePartitionListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaCatalogTablePartitionListSettings SetHelp(this AzureDlaCatalogTablePartitionListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTablePartitionListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaCatalogTablePartitionListSettings ResetHelp(this AzureDlaCatalogTablePartitionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTablePartitionListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaCatalogTablePartitionListSettings SetOutput(this AzureDlaCatalogTablePartitionListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTablePartitionListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaCatalogTablePartitionListSettings ResetOutput(this AzureDlaCatalogTablePartitionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTablePartitionListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaCatalogTablePartitionListSettings SetQuery(this AzureDlaCatalogTablePartitionListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTablePartitionListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaCatalogTablePartitionListSettings ResetQuery(this AzureDlaCatalogTablePartitionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTablePartitionListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogTablePartitionListSettings SetVerbose(this AzureDlaCatalogTablePartitionListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTablePartitionListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogTablePartitionListSettings ResetVerbose(this AzureDlaCatalogTablePartitionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlaCatalogTablePartitionShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlaCatalogTablePartitionShowSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTablePartitionShowSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaCatalogTablePartitionShowSettings SetAccount(this AzureDlaCatalogTablePartitionShowSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTablePartitionShowSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaCatalogTablePartitionShowSettings ResetAccount(this AzureDlaCatalogTablePartitionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region DatabaseName
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTablePartitionShowSettings.DatabaseName"/>.</em></p><p>The name of the database containing the partition.</p></summary>
        [Pure]
        public static AzureDlaCatalogTablePartitionShowSettings SetDatabaseName(this AzureDlaCatalogTablePartitionShowSettings toolSettings, string databaseName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DatabaseName = databaseName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTablePartitionShowSettings.DatabaseName"/>.</em></p><p>The name of the database containing the partition.</p></summary>
        [Pure]
        public static AzureDlaCatalogTablePartitionShowSettings ResetDatabaseName(this AzureDlaCatalogTablePartitionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DatabaseName = null;
            return toolSettings;
        }
        #endregion
        #region PartitionName
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTablePartitionShowSettings.PartitionName"/>.</em></p><p>The name of the table partition.</p></summary>
        [Pure]
        public static AzureDlaCatalogTablePartitionShowSettings SetPartitionName(this AzureDlaCatalogTablePartitionShowSettings toolSettings, string partitionName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PartitionName = partitionName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTablePartitionShowSettings.PartitionName"/>.</em></p><p>The name of the table partition.</p></summary>
        [Pure]
        public static AzureDlaCatalogTablePartitionShowSettings ResetPartitionName(this AzureDlaCatalogTablePartitionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PartitionName = null;
            return toolSettings;
        }
        #endregion
        #region SchemaName
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTablePartitionShowSettings.SchemaName"/>.</em></p><p>The name of the schema containing the partition.</p></summary>
        [Pure]
        public static AzureDlaCatalogTablePartitionShowSettings SetSchemaName(this AzureDlaCatalogTablePartitionShowSettings toolSettings, string schemaName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SchemaName = schemaName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTablePartitionShowSettings.SchemaName"/>.</em></p><p>The name of the schema containing the partition.</p></summary>
        [Pure]
        public static AzureDlaCatalogTablePartitionShowSettings ResetSchemaName(this AzureDlaCatalogTablePartitionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SchemaName = null;
            return toolSettings;
        }
        #endregion
        #region TableName
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTablePartitionShowSettings.TableName"/>.</em></p><p>The name of the table containing the partition.</p></summary>
        [Pure]
        public static AzureDlaCatalogTablePartitionShowSettings SetTableName(this AzureDlaCatalogTablePartitionShowSettings toolSettings, string tableName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TableName = tableName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTablePartitionShowSettings.TableName"/>.</em></p><p>The name of the table containing the partition.</p></summary>
        [Pure]
        public static AzureDlaCatalogTablePartitionShowSettings ResetTableName(this AzureDlaCatalogTablePartitionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TableName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTablePartitionShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogTablePartitionShowSettings SetDebug(this AzureDlaCatalogTablePartitionShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTablePartitionShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogTablePartitionShowSettings ResetDebug(this AzureDlaCatalogTablePartitionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTablePartitionShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaCatalogTablePartitionShowSettings SetHelp(this AzureDlaCatalogTablePartitionShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTablePartitionShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaCatalogTablePartitionShowSettings ResetHelp(this AzureDlaCatalogTablePartitionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTablePartitionShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaCatalogTablePartitionShowSettings SetOutput(this AzureDlaCatalogTablePartitionShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTablePartitionShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaCatalogTablePartitionShowSettings ResetOutput(this AzureDlaCatalogTablePartitionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTablePartitionShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaCatalogTablePartitionShowSettings SetQuery(this AzureDlaCatalogTablePartitionShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTablePartitionShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaCatalogTablePartitionShowSettings ResetQuery(this AzureDlaCatalogTablePartitionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTablePartitionShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogTablePartitionShowSettings SetVerbose(this AzureDlaCatalogTablePartitionShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTablePartitionShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogTablePartitionShowSettings ResetVerbose(this AzureDlaCatalogTablePartitionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlaCatalogTableStatsListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlaCatalogTableStatsListSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTableStatsListSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableStatsListSettings SetAccount(this AzureDlaCatalogTableStatsListSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTableStatsListSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableStatsListSettings ResetAccount(this AzureDlaCatalogTableStatsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region DatabaseName
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTableStatsListSettings.DatabaseName"/>.</em></p><p>The name of the database.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableStatsListSettings SetDatabaseName(this AzureDlaCatalogTableStatsListSettings toolSettings, string databaseName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DatabaseName = databaseName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTableStatsListSettings.DatabaseName"/>.</em></p><p>The name of the database.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableStatsListSettings ResetDatabaseName(this AzureDlaCatalogTableStatsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DatabaseName = null;
            return toolSettings;
        }
        #endregion
        #region SchemaName
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTableStatsListSettings.SchemaName"/>.</em></p><p>The schema associated with the tables to list.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableStatsListSettings SetSchemaName(this AzureDlaCatalogTableStatsListSettings toolSettings, string schemaName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SchemaName = schemaName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTableStatsListSettings.SchemaName"/>.</em></p><p>The schema associated with the tables to list.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableStatsListSettings ResetSchemaName(this AzureDlaCatalogTableStatsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SchemaName = null;
            return toolSettings;
        }
        #endregion
        #region TableName
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTableStatsListSettings.TableName"/>.</em></p><p>The table to list statistics for. `--schema-name` must also be specified.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableStatsListSettings SetTableName(this AzureDlaCatalogTableStatsListSettings toolSettings, string tableName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TableName = tableName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTableStatsListSettings.TableName"/>.</em></p><p>The table to list statistics for. `--schema-name` must also be specified.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableStatsListSettings ResetTableName(this AzureDlaCatalogTableStatsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TableName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTableStatsListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableStatsListSettings SetDebug(this AzureDlaCatalogTableStatsListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTableStatsListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableStatsListSettings ResetDebug(this AzureDlaCatalogTableStatsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTableStatsListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableStatsListSettings SetHelp(this AzureDlaCatalogTableStatsListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTableStatsListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableStatsListSettings ResetHelp(this AzureDlaCatalogTableStatsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTableStatsListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableStatsListSettings SetOutput(this AzureDlaCatalogTableStatsListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTableStatsListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableStatsListSettings ResetOutput(this AzureDlaCatalogTableStatsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTableStatsListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableStatsListSettings SetQuery(this AzureDlaCatalogTableStatsListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTableStatsListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableStatsListSettings ResetQuery(this AzureDlaCatalogTableStatsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTableStatsListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableStatsListSettings SetVerbose(this AzureDlaCatalogTableStatsListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTableStatsListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableStatsListSettings ResetVerbose(this AzureDlaCatalogTableStatsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlaCatalogTableStatsShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlaCatalogTableStatsShowSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTableStatsShowSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableStatsShowSettings SetAccount(this AzureDlaCatalogTableStatsShowSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTableStatsShowSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableStatsShowSettings ResetAccount(this AzureDlaCatalogTableStatsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region DatabaseName
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTableStatsShowSettings.DatabaseName"/>.</em></p><p>The name of the database containing the statistics.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableStatsShowSettings SetDatabaseName(this AzureDlaCatalogTableStatsShowSettings toolSettings, string databaseName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DatabaseName = databaseName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTableStatsShowSettings.DatabaseName"/>.</em></p><p>The name of the database containing the statistics.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableStatsShowSettings ResetDatabaseName(this AzureDlaCatalogTableStatsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DatabaseName = null;
            return toolSettings;
        }
        #endregion
        #region SchemaName
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTableStatsShowSettings.SchemaName"/>.</em></p><p>The name of the schema containing the statistics.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableStatsShowSettings SetSchemaName(this AzureDlaCatalogTableStatsShowSettings toolSettings, string schemaName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SchemaName = schemaName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTableStatsShowSettings.SchemaName"/>.</em></p><p>The name of the schema containing the statistics.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableStatsShowSettings ResetSchemaName(this AzureDlaCatalogTableStatsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SchemaName = null;
            return toolSettings;
        }
        #endregion
        #region StatisticsName
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTableStatsShowSettings.StatisticsName"/>.</em></p><p>The name of the table statistics.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableStatsShowSettings SetStatisticsName(this AzureDlaCatalogTableStatsShowSettings toolSettings, string statisticsName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StatisticsName = statisticsName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTableStatsShowSettings.StatisticsName"/>.</em></p><p>The name of the table statistics.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableStatsShowSettings ResetStatisticsName(this AzureDlaCatalogTableStatsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StatisticsName = null;
            return toolSettings;
        }
        #endregion
        #region TableName
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTableStatsShowSettings.TableName"/>.</em></p><p>The name of the table containing the statistics.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableStatsShowSettings SetTableName(this AzureDlaCatalogTableStatsShowSettings toolSettings, string tableName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TableName = tableName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTableStatsShowSettings.TableName"/>.</em></p><p>The name of the table containing the statistics.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableStatsShowSettings ResetTableName(this AzureDlaCatalogTableStatsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TableName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTableStatsShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableStatsShowSettings SetDebug(this AzureDlaCatalogTableStatsShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTableStatsShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableStatsShowSettings ResetDebug(this AzureDlaCatalogTableStatsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTableStatsShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableStatsShowSettings SetHelp(this AzureDlaCatalogTableStatsShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTableStatsShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableStatsShowSettings ResetHelp(this AzureDlaCatalogTableStatsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTableStatsShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableStatsShowSettings SetOutput(this AzureDlaCatalogTableStatsShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTableStatsShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableStatsShowSettings ResetOutput(this AzureDlaCatalogTableStatsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTableStatsShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableStatsShowSettings SetQuery(this AzureDlaCatalogTableStatsShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTableStatsShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableStatsShowSettings ResetQuery(this AzureDlaCatalogTableStatsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTableStatsShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableStatsShowSettings SetVerbose(this AzureDlaCatalogTableStatsShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTableStatsShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableStatsShowSettings ResetVerbose(this AzureDlaCatalogTableStatsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlaCatalogTableTypeListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlaCatalogTableTypeListSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTableTypeListSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableTypeListSettings SetAccount(this AzureDlaCatalogTableTypeListSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTableTypeListSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableTypeListSettings ResetAccount(this AzureDlaCatalogTableTypeListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region DatabaseName
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTableTypeListSettings.DatabaseName"/>.</em></p><p>The name of the database containing the table types.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableTypeListSettings SetDatabaseName(this AzureDlaCatalogTableTypeListSettings toolSettings, string databaseName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DatabaseName = databaseName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTableTypeListSettings.DatabaseName"/>.</em></p><p>The name of the database containing the table types.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableTypeListSettings ResetDatabaseName(this AzureDlaCatalogTableTypeListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DatabaseName = null;
            return toolSettings;
        }
        #endregion
        #region SchemaName
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTableTypeListSettings.SchemaName"/>.</em></p><p>The name of the schema containing the table types.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableTypeListSettings SetSchemaName(this AzureDlaCatalogTableTypeListSettings toolSettings, string schemaName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SchemaName = schemaName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTableTypeListSettings.SchemaName"/>.</em></p><p>The name of the schema containing the table types.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableTypeListSettings ResetSchemaName(this AzureDlaCatalogTableTypeListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SchemaName = null;
            return toolSettings;
        }
        #endregion
        #region Count
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTableTypeListSettings.Count"/>.</em></p><p>The Boolean value of true or false to request a count of the matching resources included with the resources in the response, e.g. Categories?$count=true.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableTypeListSettings SetCount(this AzureDlaCatalogTableTypeListSettings toolSettings, string count)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Count = count;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTableTypeListSettings.Count"/>.</em></p><p>The Boolean value of true or false to request a count of the matching resources included with the resources in the response, e.g. Categories?$count=true.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableTypeListSettings ResetCount(this AzureDlaCatalogTableTypeListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Count = null;
            return toolSettings;
        }
        #endregion
        #region Filter
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTableTypeListSettings.Filter"/>.</em></p><p>OData filter. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableTypeListSettings SetFilter(this AzureDlaCatalogTableTypeListSettings toolSettings, string filter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = filter;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTableTypeListSettings.Filter"/>.</em></p><p>OData filter. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableTypeListSettings ResetFilter(this AzureDlaCatalogTableTypeListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = null;
            return toolSettings;
        }
        #endregion
        #region Orderby
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTableTypeListSettings.Orderby"/> to a new list.</em></p><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableTypeListSettings SetOrderby(this AzureDlaCatalogTableTypeListSettings toolSettings, params string[] orderby)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OrderbyInternal = orderby.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTableTypeListSettings.Orderby"/> to a new list.</em></p><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableTypeListSettings SetOrderby(this AzureDlaCatalogTableTypeListSettings toolSettings, IEnumerable<string> orderby)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OrderbyInternal = orderby.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureDlaCatalogTableTypeListSettings.Orderby"/>.</em></p><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableTypeListSettings AddOrderby(this AzureDlaCatalogTableTypeListSettings toolSettings, params string[] orderby)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OrderbyInternal.AddRange(orderby);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureDlaCatalogTableTypeListSettings.Orderby"/>.</em></p><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableTypeListSettings AddOrderby(this AzureDlaCatalogTableTypeListSettings toolSettings, IEnumerable<string> orderby)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OrderbyInternal.AddRange(orderby);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureDlaCatalogTableTypeListSettings.Orderby"/>.</em></p><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableTypeListSettings ClearOrderby(this AzureDlaCatalogTableTypeListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OrderbyInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureDlaCatalogTableTypeListSettings.Orderby"/>.</em></p><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableTypeListSettings RemoveOrderby(this AzureDlaCatalogTableTypeListSettings toolSettings, params string[] orderby)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(orderby);
            toolSettings.OrderbyInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureDlaCatalogTableTypeListSettings.Orderby"/>.</em></p><p>OrderBy clause. One or more comma-separated expressions with an optional "asc" (the default) or "desc" depending on the order you'd like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableTypeListSettings RemoveOrderby(this AzureDlaCatalogTableTypeListSettings toolSettings, IEnumerable<string> orderby)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(orderby);
            toolSettings.OrderbyInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Select
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTableTypeListSettings.Select"/>.</em></p><p>OData Select statement. Limits the properties on each entry to just those requested, e.g. Categories?$select=CategoryName,Description. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableTypeListSettings SetSelect(this AzureDlaCatalogTableTypeListSettings toolSettings, string select)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Select = select;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTableTypeListSettings.Select"/>.</em></p><p>OData Select statement. Limits the properties on each entry to just those requested, e.g. Categories?$select=CategoryName,Description. Optional.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableTypeListSettings ResetSelect(this AzureDlaCatalogTableTypeListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Select = null;
            return toolSettings;
        }
        #endregion
        #region Skip
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTableTypeListSettings.Skip"/>.</em></p><p>The number of items to skip over before returning elements.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableTypeListSettings SetSkip(this AzureDlaCatalogTableTypeListSettings toolSettings, string skip)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Skip = skip;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTableTypeListSettings.Skip"/>.</em></p><p>The number of items to skip over before returning elements.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableTypeListSettings ResetSkip(this AzureDlaCatalogTableTypeListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Skip = null;
            return toolSettings;
        }
        #endregion
        #region Top
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTableTypeListSettings.Top"/>.</em></p><p>Maximum number of items to return.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableTypeListSettings SetTop(this AzureDlaCatalogTableTypeListSettings toolSettings, int? top)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = top;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTableTypeListSettings.Top"/>.</em></p><p>Maximum number of items to return.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableTypeListSettings ResetTop(this AzureDlaCatalogTableTypeListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTableTypeListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableTypeListSettings SetDebug(this AzureDlaCatalogTableTypeListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTableTypeListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableTypeListSettings ResetDebug(this AzureDlaCatalogTableTypeListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTableTypeListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableTypeListSettings SetHelp(this AzureDlaCatalogTableTypeListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTableTypeListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableTypeListSettings ResetHelp(this AzureDlaCatalogTableTypeListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTableTypeListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableTypeListSettings SetOutput(this AzureDlaCatalogTableTypeListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTableTypeListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableTypeListSettings ResetOutput(this AzureDlaCatalogTableTypeListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTableTypeListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableTypeListSettings SetQuery(this AzureDlaCatalogTableTypeListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTableTypeListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableTypeListSettings ResetQuery(this AzureDlaCatalogTableTypeListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTableTypeListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableTypeListSettings SetVerbose(this AzureDlaCatalogTableTypeListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTableTypeListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableTypeListSettings ResetVerbose(this AzureDlaCatalogTableTypeListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlaCatalogTableTypeShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlaCatalogTableTypeShowSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTableTypeShowSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableTypeShowSettings SetAccount(this AzureDlaCatalogTableTypeShowSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTableTypeShowSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableTypeShowSettings ResetAccount(this AzureDlaCatalogTableTypeShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region DatabaseName
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTableTypeShowSettings.DatabaseName"/>.</em></p><p>The name of the database containing the table type.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableTypeShowSettings SetDatabaseName(this AzureDlaCatalogTableTypeShowSettings toolSettings, string databaseName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DatabaseName = databaseName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTableTypeShowSettings.DatabaseName"/>.</em></p><p>The name of the database containing the table type.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableTypeShowSettings ResetDatabaseName(this AzureDlaCatalogTableTypeShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DatabaseName = null;
            return toolSettings;
        }
        #endregion
        #region SchemaName
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTableTypeShowSettings.SchemaName"/>.</em></p><p>The name of the schema containing the table type.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableTypeShowSettings SetSchemaName(this AzureDlaCatalogTableTypeShowSettings toolSettings, string schemaName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SchemaName = schemaName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTableTypeShowSettings.SchemaName"/>.</em></p><p>The name of the schema containing the table type.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableTypeShowSettings ResetSchemaName(this AzureDlaCatalogTableTypeShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SchemaName = null;
            return toolSettings;
        }
        #endregion
        #region TableTypeName
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTableTypeShowSettings.TableTypeName"/>.</em></p><p>The name of the table type to retrieve.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableTypeShowSettings SetTableTypeName(this AzureDlaCatalogTableTypeShowSettings toolSettings, string tableTypeName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TableTypeName = tableTypeName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTableTypeShowSettings.TableTypeName"/>.</em></p><p>The name of the table type to retrieve.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableTypeShowSettings ResetTableTypeName(this AzureDlaCatalogTableTypeShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TableTypeName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTableTypeShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableTypeShowSettings SetDebug(this AzureDlaCatalogTableTypeShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTableTypeShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableTypeShowSettings ResetDebug(this AzureDlaCatalogTableTypeShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTableTypeShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableTypeShowSettings SetHelp(this AzureDlaCatalogTableTypeShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTableTypeShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableTypeShowSettings ResetHelp(this AzureDlaCatalogTableTypeShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTableTypeShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableTypeShowSettings SetOutput(this AzureDlaCatalogTableTypeShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTableTypeShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableTypeShowSettings ResetOutput(this AzureDlaCatalogTableTypeShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTableTypeShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableTypeShowSettings SetQuery(this AzureDlaCatalogTableTypeShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTableTypeShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableTypeShowSettings ResetQuery(this AzureDlaCatalogTableTypeShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTableTypeShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableTypeShowSettings SetVerbose(this AzureDlaCatalogTableTypeShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTableTypeShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableTypeShowSettings ResetVerbose(this AzureDlaCatalogTableTypeShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlaCatalogTableListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlaCatalogTableListSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTableListSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableListSettings SetAccount(this AzureDlaCatalogTableListSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTableListSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableListSettings ResetAccount(this AzureDlaCatalogTableListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region DatabaseName
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTableListSettings.DatabaseName"/>.</em></p><p>The name of the database.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableListSettings SetDatabaseName(this AzureDlaCatalogTableListSettings toolSettings, string databaseName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DatabaseName = databaseName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTableListSettings.DatabaseName"/>.</em></p><p>The name of the database.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableListSettings ResetDatabaseName(this AzureDlaCatalogTableListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DatabaseName = null;
            return toolSettings;
        }
        #endregion
        #region SchemaName
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTableListSettings.SchemaName"/>.</em></p><p>The schema assocated with the tables to list.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableListSettings SetSchemaName(this AzureDlaCatalogTableListSettings toolSettings, string schemaName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SchemaName = schemaName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTableListSettings.SchemaName"/>.</em></p><p>The schema assocated with the tables to list.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableListSettings ResetSchemaName(this AzureDlaCatalogTableListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SchemaName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTableListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableListSettings SetDebug(this AzureDlaCatalogTableListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTableListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableListSettings ResetDebug(this AzureDlaCatalogTableListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTableListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableListSettings SetHelp(this AzureDlaCatalogTableListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTableListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableListSettings ResetHelp(this AzureDlaCatalogTableListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTableListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableListSettings SetOutput(this AzureDlaCatalogTableListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTableListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableListSettings ResetOutput(this AzureDlaCatalogTableListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTableListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableListSettings SetQuery(this AzureDlaCatalogTableListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTableListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableListSettings ResetQuery(this AzureDlaCatalogTableListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTableListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableListSettings SetVerbose(this AzureDlaCatalogTableListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTableListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableListSettings ResetVerbose(this AzureDlaCatalogTableListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlaCatalogTableShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlaCatalogTableShowSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTableShowSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableShowSettings SetAccount(this AzureDlaCatalogTableShowSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTableShowSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableShowSettings ResetAccount(this AzureDlaCatalogTableShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region DatabaseName
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTableShowSettings.DatabaseName"/>.</em></p><p>The name of the database containing the table.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableShowSettings SetDatabaseName(this AzureDlaCatalogTableShowSettings toolSettings, string databaseName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DatabaseName = databaseName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTableShowSettings.DatabaseName"/>.</em></p><p>The name of the database containing the table.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableShowSettings ResetDatabaseName(this AzureDlaCatalogTableShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DatabaseName = null;
            return toolSettings;
        }
        #endregion
        #region SchemaName
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTableShowSettings.SchemaName"/>.</em></p><p>The name of the schema containing the table.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableShowSettings SetSchemaName(this AzureDlaCatalogTableShowSettings toolSettings, string schemaName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SchemaName = schemaName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTableShowSettings.SchemaName"/>.</em></p><p>The name of the schema containing the table.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableShowSettings ResetSchemaName(this AzureDlaCatalogTableShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SchemaName = null;
            return toolSettings;
        }
        #endregion
        #region TableName
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTableShowSettings.TableName"/>.</em></p><p>The name of the table.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableShowSettings SetTableName(this AzureDlaCatalogTableShowSettings toolSettings, string tableName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TableName = tableName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTableShowSettings.TableName"/>.</em></p><p>The name of the table.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableShowSettings ResetTableName(this AzureDlaCatalogTableShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TableName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTableShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableShowSettings SetDebug(this AzureDlaCatalogTableShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTableShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableShowSettings ResetDebug(this AzureDlaCatalogTableShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTableShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableShowSettings SetHelp(this AzureDlaCatalogTableShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTableShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableShowSettings ResetHelp(this AzureDlaCatalogTableShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTableShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableShowSettings SetOutput(this AzureDlaCatalogTableShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTableShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableShowSettings ResetOutput(this AzureDlaCatalogTableShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTableShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableShowSettings SetQuery(this AzureDlaCatalogTableShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTableShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableShowSettings ResetQuery(this AzureDlaCatalogTableShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTableShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableShowSettings SetVerbose(this AzureDlaCatalogTableShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTableShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogTableShowSettings ResetVerbose(this AzureDlaCatalogTableShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlaCatalogTvfListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlaCatalogTvfListSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTvfListSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaCatalogTvfListSettings SetAccount(this AzureDlaCatalogTvfListSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTvfListSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaCatalogTvfListSettings ResetAccount(this AzureDlaCatalogTvfListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region DatabaseName
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTvfListSettings.DatabaseName"/>.</em></p><p>The name of the database.</p></summary>
        [Pure]
        public static AzureDlaCatalogTvfListSettings SetDatabaseName(this AzureDlaCatalogTvfListSettings toolSettings, string databaseName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DatabaseName = databaseName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTvfListSettings.DatabaseName"/>.</em></p><p>The name of the database.</p></summary>
        [Pure]
        public static AzureDlaCatalogTvfListSettings ResetDatabaseName(this AzureDlaCatalogTvfListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DatabaseName = null;
            return toolSettings;
        }
        #endregion
        #region SchemaName
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTvfListSettings.SchemaName"/>.</em></p><p>The name of the schema assocated with table valued functions to list.</p></summary>
        [Pure]
        public static AzureDlaCatalogTvfListSettings SetSchemaName(this AzureDlaCatalogTvfListSettings toolSettings, string schemaName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SchemaName = schemaName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTvfListSettings.SchemaName"/>.</em></p><p>The name of the schema assocated with table valued functions to list.</p></summary>
        [Pure]
        public static AzureDlaCatalogTvfListSettings ResetSchemaName(this AzureDlaCatalogTvfListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SchemaName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTvfListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogTvfListSettings SetDebug(this AzureDlaCatalogTvfListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTvfListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogTvfListSettings ResetDebug(this AzureDlaCatalogTvfListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTvfListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaCatalogTvfListSettings SetHelp(this AzureDlaCatalogTvfListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTvfListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaCatalogTvfListSettings ResetHelp(this AzureDlaCatalogTvfListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTvfListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaCatalogTvfListSettings SetOutput(this AzureDlaCatalogTvfListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTvfListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaCatalogTvfListSettings ResetOutput(this AzureDlaCatalogTvfListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTvfListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaCatalogTvfListSettings SetQuery(this AzureDlaCatalogTvfListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTvfListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaCatalogTvfListSettings ResetQuery(this AzureDlaCatalogTvfListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTvfListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogTvfListSettings SetVerbose(this AzureDlaCatalogTvfListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTvfListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogTvfListSettings ResetVerbose(this AzureDlaCatalogTvfListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlaCatalogTvfShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlaCatalogTvfShowSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTvfShowSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaCatalogTvfShowSettings SetAccount(this AzureDlaCatalogTvfShowSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTvfShowSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaCatalogTvfShowSettings ResetAccount(this AzureDlaCatalogTvfShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region DatabaseName
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTvfShowSettings.DatabaseName"/>.</em></p><p>The name of the database containing the table valued function.</p></summary>
        [Pure]
        public static AzureDlaCatalogTvfShowSettings SetDatabaseName(this AzureDlaCatalogTvfShowSettings toolSettings, string databaseName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DatabaseName = databaseName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTvfShowSettings.DatabaseName"/>.</em></p><p>The name of the database containing the table valued function.</p></summary>
        [Pure]
        public static AzureDlaCatalogTvfShowSettings ResetDatabaseName(this AzureDlaCatalogTvfShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DatabaseName = null;
            return toolSettings;
        }
        #endregion
        #region SchemaName
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTvfShowSettings.SchemaName"/>.</em></p><p>The name of the schema containing the table valued function.</p></summary>
        [Pure]
        public static AzureDlaCatalogTvfShowSettings SetSchemaName(this AzureDlaCatalogTvfShowSettings toolSettings, string schemaName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SchemaName = schemaName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTvfShowSettings.SchemaName"/>.</em></p><p>The name of the schema containing the table valued function.</p></summary>
        [Pure]
        public static AzureDlaCatalogTvfShowSettings ResetSchemaName(this AzureDlaCatalogTvfShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SchemaName = null;
            return toolSettings;
        }
        #endregion
        #region TableValuedFunctionName
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTvfShowSettings.TableValuedFunctionName"/>.</em></p><p>The name of the tableValuedFunction.</p></summary>
        [Pure]
        public static AzureDlaCatalogTvfShowSettings SetTableValuedFunctionName(this AzureDlaCatalogTvfShowSettings toolSettings, string tableValuedFunctionName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TableValuedFunctionName = tableValuedFunctionName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTvfShowSettings.TableValuedFunctionName"/>.</em></p><p>The name of the tableValuedFunction.</p></summary>
        [Pure]
        public static AzureDlaCatalogTvfShowSettings ResetTableValuedFunctionName(this AzureDlaCatalogTvfShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TableValuedFunctionName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTvfShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogTvfShowSettings SetDebug(this AzureDlaCatalogTvfShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTvfShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogTvfShowSettings ResetDebug(this AzureDlaCatalogTvfShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTvfShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaCatalogTvfShowSettings SetHelp(this AzureDlaCatalogTvfShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTvfShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaCatalogTvfShowSettings ResetHelp(this AzureDlaCatalogTvfShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTvfShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaCatalogTvfShowSettings SetOutput(this AzureDlaCatalogTvfShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTvfShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaCatalogTvfShowSettings ResetOutput(this AzureDlaCatalogTvfShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTvfShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaCatalogTvfShowSettings SetQuery(this AzureDlaCatalogTvfShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTvfShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaCatalogTvfShowSettings ResetQuery(this AzureDlaCatalogTvfShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogTvfShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogTvfShowSettings SetVerbose(this AzureDlaCatalogTvfShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogTvfShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogTvfShowSettings ResetVerbose(this AzureDlaCatalogTvfShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlaCatalogViewListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlaCatalogViewListSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogViewListSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaCatalogViewListSettings SetAccount(this AzureDlaCatalogViewListSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogViewListSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaCatalogViewListSettings ResetAccount(this AzureDlaCatalogViewListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region DatabaseName
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogViewListSettings.DatabaseName"/>.</em></p><p>The name of the database.</p></summary>
        [Pure]
        public static AzureDlaCatalogViewListSettings SetDatabaseName(this AzureDlaCatalogViewListSettings toolSettings, string databaseName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DatabaseName = databaseName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogViewListSettings.DatabaseName"/>.</em></p><p>The name of the database.</p></summary>
        [Pure]
        public static AzureDlaCatalogViewListSettings ResetDatabaseName(this AzureDlaCatalogViewListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DatabaseName = null;
            return toolSettings;
        }
        #endregion
        #region SchemaName
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogViewListSettings.SchemaName"/>.</em></p><p>The name of the schema associated with the views to list.</p></summary>
        [Pure]
        public static AzureDlaCatalogViewListSettings SetSchemaName(this AzureDlaCatalogViewListSettings toolSettings, string schemaName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SchemaName = schemaName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogViewListSettings.SchemaName"/>.</em></p><p>The name of the schema associated with the views to list.</p></summary>
        [Pure]
        public static AzureDlaCatalogViewListSettings ResetSchemaName(this AzureDlaCatalogViewListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SchemaName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogViewListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogViewListSettings SetDebug(this AzureDlaCatalogViewListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogViewListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogViewListSettings ResetDebug(this AzureDlaCatalogViewListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogViewListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaCatalogViewListSettings SetHelp(this AzureDlaCatalogViewListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogViewListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaCatalogViewListSettings ResetHelp(this AzureDlaCatalogViewListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogViewListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaCatalogViewListSettings SetOutput(this AzureDlaCatalogViewListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogViewListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaCatalogViewListSettings ResetOutput(this AzureDlaCatalogViewListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogViewListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaCatalogViewListSettings SetQuery(this AzureDlaCatalogViewListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogViewListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaCatalogViewListSettings ResetQuery(this AzureDlaCatalogViewListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogViewListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogViewListSettings SetVerbose(this AzureDlaCatalogViewListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogViewListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogViewListSettings ResetVerbose(this AzureDlaCatalogViewListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlaCatalogViewShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlaCatalogViewShowSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogViewShowSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaCatalogViewShowSettings SetAccount(this AzureDlaCatalogViewShowSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogViewShowSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaCatalogViewShowSettings ResetAccount(this AzureDlaCatalogViewShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region DatabaseName
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogViewShowSettings.DatabaseName"/>.</em></p><p>The name of the database containing the view.</p></summary>
        [Pure]
        public static AzureDlaCatalogViewShowSettings SetDatabaseName(this AzureDlaCatalogViewShowSettings toolSettings, string databaseName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DatabaseName = databaseName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogViewShowSettings.DatabaseName"/>.</em></p><p>The name of the database containing the view.</p></summary>
        [Pure]
        public static AzureDlaCatalogViewShowSettings ResetDatabaseName(this AzureDlaCatalogViewShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DatabaseName = null;
            return toolSettings;
        }
        #endregion
        #region SchemaName
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogViewShowSettings.SchemaName"/>.</em></p><p>The name of the schema containing the view.</p></summary>
        [Pure]
        public static AzureDlaCatalogViewShowSettings SetSchemaName(this AzureDlaCatalogViewShowSettings toolSettings, string schemaName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SchemaName = schemaName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogViewShowSettings.SchemaName"/>.</em></p><p>The name of the schema containing the view.</p></summary>
        [Pure]
        public static AzureDlaCatalogViewShowSettings ResetSchemaName(this AzureDlaCatalogViewShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SchemaName = null;
            return toolSettings;
        }
        #endregion
        #region ViewName
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogViewShowSettings.ViewName"/>.</em></p><p>The name of the view.</p></summary>
        [Pure]
        public static AzureDlaCatalogViewShowSettings SetViewName(this AzureDlaCatalogViewShowSettings toolSettings, string viewName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ViewName = viewName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogViewShowSettings.ViewName"/>.</em></p><p>The name of the view.</p></summary>
        [Pure]
        public static AzureDlaCatalogViewShowSettings ResetViewName(this AzureDlaCatalogViewShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ViewName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogViewShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogViewShowSettings SetDebug(this AzureDlaCatalogViewShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogViewShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogViewShowSettings ResetDebug(this AzureDlaCatalogViewShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogViewShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaCatalogViewShowSettings SetHelp(this AzureDlaCatalogViewShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogViewShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaCatalogViewShowSettings ResetHelp(this AzureDlaCatalogViewShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogViewShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaCatalogViewShowSettings SetOutput(this AzureDlaCatalogViewShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogViewShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaCatalogViewShowSettings ResetOutput(this AzureDlaCatalogViewShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogViewShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaCatalogViewShowSettings SetQuery(this AzureDlaCatalogViewShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogViewShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaCatalogViewShowSettings ResetQuery(this AzureDlaCatalogViewShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlaCatalogViewShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogViewShowSettings SetVerbose(this AzureDlaCatalogViewShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaCatalogViewShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaCatalogViewShowSettings ResetVerbose(this AzureDlaCatalogViewShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlaJobPipelineListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlaJobPipelineListSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlaJobPipelineListSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaJobPipelineListSettings SetAccount(this AzureDlaJobPipelineListSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobPipelineListSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaJobPipelineListSettings ResetAccount(this AzureDlaJobPipelineListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region EndDateTime
        /// <summary><p><em>Sets <see cref="AzureDlaJobPipelineListSettings.EndDateTime"/>.</em></p><p>The end date for when to get the list of pipelines. The startDateTime and endDateTime can be no more than 30 days apart.</p></summary>
        [Pure]
        public static AzureDlaJobPipelineListSettings SetEndDateTime(this AzureDlaJobPipelineListSettings toolSettings, string endDateTime)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndDateTime = endDateTime;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobPipelineListSettings.EndDateTime"/>.</em></p><p>The end date for when to get the list of pipelines. The startDateTime and endDateTime can be no more than 30 days apart.</p></summary>
        [Pure]
        public static AzureDlaJobPipelineListSettings ResetEndDateTime(this AzureDlaJobPipelineListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndDateTime = null;
            return toolSettings;
        }
        #endregion
        #region StartDateTime
        /// <summary><p><em>Sets <see cref="AzureDlaJobPipelineListSettings.StartDateTime"/>.</em></p><p>The start date for when to get the list of pipelines. The startDateTime and endDateTime can be no more than 30 days apart.</p></summary>
        [Pure]
        public static AzureDlaJobPipelineListSettings SetStartDateTime(this AzureDlaJobPipelineListSettings toolSettings, string startDateTime)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartDateTime = startDateTime;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobPipelineListSettings.StartDateTime"/>.</em></p><p>The start date for when to get the list of pipelines. The startDateTime and endDateTime can be no more than 30 days apart.</p></summary>
        [Pure]
        public static AzureDlaJobPipelineListSettings ResetStartDateTime(this AzureDlaJobPipelineListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartDateTime = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlaJobPipelineListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaJobPipelineListSettings SetDebug(this AzureDlaJobPipelineListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobPipelineListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaJobPipelineListSettings ResetDebug(this AzureDlaJobPipelineListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlaJobPipelineListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaJobPipelineListSettings SetHelp(this AzureDlaJobPipelineListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobPipelineListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaJobPipelineListSettings ResetHelp(this AzureDlaJobPipelineListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlaJobPipelineListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaJobPipelineListSettings SetOutput(this AzureDlaJobPipelineListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobPipelineListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaJobPipelineListSettings ResetOutput(this AzureDlaJobPipelineListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlaJobPipelineListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaJobPipelineListSettings SetQuery(this AzureDlaJobPipelineListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobPipelineListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaJobPipelineListSettings ResetQuery(this AzureDlaJobPipelineListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlaJobPipelineListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaJobPipelineListSettings SetVerbose(this AzureDlaJobPipelineListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobPipelineListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaJobPipelineListSettings ResetVerbose(this AzureDlaJobPipelineListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlaJobPipelineShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlaJobPipelineShowSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlaJobPipelineShowSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaJobPipelineShowSettings SetAccount(this AzureDlaJobPipelineShowSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobPipelineShowSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaJobPipelineShowSettings ResetAccount(this AzureDlaJobPipelineShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region PipelineIdentity
        /// <summary><p><em>Sets <see cref="AzureDlaJobPipelineShowSettings.PipelineIdentity"/>.</em></p><p>Pipeline ID.</p></summary>
        [Pure]
        public static AzureDlaJobPipelineShowSettings SetPipelineIdentity(this AzureDlaJobPipelineShowSettings toolSettings, string pipelineIdentity)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PipelineIdentity = pipelineIdentity;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobPipelineShowSettings.PipelineIdentity"/>.</em></p><p>Pipeline ID.</p></summary>
        [Pure]
        public static AzureDlaJobPipelineShowSettings ResetPipelineIdentity(this AzureDlaJobPipelineShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PipelineIdentity = null;
            return toolSettings;
        }
        #endregion
        #region EndDateTime
        /// <summary><p><em>Sets <see cref="AzureDlaJobPipelineShowSettings.EndDateTime"/>.</em></p><p>The end date for when to get the pipeline and aggregate its data. The startDateTime and endDateTime can be no more than 30 days apart.</p></summary>
        [Pure]
        public static AzureDlaJobPipelineShowSettings SetEndDateTime(this AzureDlaJobPipelineShowSettings toolSettings, string endDateTime)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndDateTime = endDateTime;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobPipelineShowSettings.EndDateTime"/>.</em></p><p>The end date for when to get the pipeline and aggregate its data. The startDateTime and endDateTime can be no more than 30 days apart.</p></summary>
        [Pure]
        public static AzureDlaJobPipelineShowSettings ResetEndDateTime(this AzureDlaJobPipelineShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndDateTime = null;
            return toolSettings;
        }
        #endregion
        #region StartDateTime
        /// <summary><p><em>Sets <see cref="AzureDlaJobPipelineShowSettings.StartDateTime"/>.</em></p><p>The start date for when to get the pipeline and aggregate its data. The startDateTime and endDateTime can be no more than 30 days apart.</p></summary>
        [Pure]
        public static AzureDlaJobPipelineShowSettings SetStartDateTime(this AzureDlaJobPipelineShowSettings toolSettings, string startDateTime)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartDateTime = startDateTime;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobPipelineShowSettings.StartDateTime"/>.</em></p><p>The start date for when to get the pipeline and aggregate its data. The startDateTime and endDateTime can be no more than 30 days apart.</p></summary>
        [Pure]
        public static AzureDlaJobPipelineShowSettings ResetStartDateTime(this AzureDlaJobPipelineShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartDateTime = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlaJobPipelineShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaJobPipelineShowSettings SetDebug(this AzureDlaJobPipelineShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobPipelineShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaJobPipelineShowSettings ResetDebug(this AzureDlaJobPipelineShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlaJobPipelineShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaJobPipelineShowSettings SetHelp(this AzureDlaJobPipelineShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobPipelineShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaJobPipelineShowSettings ResetHelp(this AzureDlaJobPipelineShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlaJobPipelineShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaJobPipelineShowSettings SetOutput(this AzureDlaJobPipelineShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobPipelineShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaJobPipelineShowSettings ResetOutput(this AzureDlaJobPipelineShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlaJobPipelineShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaJobPipelineShowSettings SetQuery(this AzureDlaJobPipelineShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobPipelineShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaJobPipelineShowSettings ResetQuery(this AzureDlaJobPipelineShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlaJobPipelineShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaJobPipelineShowSettings SetVerbose(this AzureDlaJobPipelineShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobPipelineShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaJobPipelineShowSettings ResetVerbose(this AzureDlaJobPipelineShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlaJobRecurrenceListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlaJobRecurrenceListSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlaJobRecurrenceListSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaJobRecurrenceListSettings SetAccount(this AzureDlaJobRecurrenceListSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobRecurrenceListSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaJobRecurrenceListSettings ResetAccount(this AzureDlaJobRecurrenceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region EndDateTime
        /// <summary><p><em>Sets <see cref="AzureDlaJobRecurrenceListSettings.EndDateTime"/>.</em></p><p>The end date for when to get the list of recurrences. The startDateTime and endDateTime can be no more than 30 days apart.</p></summary>
        [Pure]
        public static AzureDlaJobRecurrenceListSettings SetEndDateTime(this AzureDlaJobRecurrenceListSettings toolSettings, string endDateTime)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndDateTime = endDateTime;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobRecurrenceListSettings.EndDateTime"/>.</em></p><p>The end date for when to get the list of recurrences. The startDateTime and endDateTime can be no more than 30 days apart.</p></summary>
        [Pure]
        public static AzureDlaJobRecurrenceListSettings ResetEndDateTime(this AzureDlaJobRecurrenceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndDateTime = null;
            return toolSettings;
        }
        #endregion
        #region StartDateTime
        /// <summary><p><em>Sets <see cref="AzureDlaJobRecurrenceListSettings.StartDateTime"/>.</em></p><p>The start date for when to get the list of recurrences. The startDateTime and endDateTime can be no more than 30 days apart.</p></summary>
        [Pure]
        public static AzureDlaJobRecurrenceListSettings SetStartDateTime(this AzureDlaJobRecurrenceListSettings toolSettings, string startDateTime)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartDateTime = startDateTime;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobRecurrenceListSettings.StartDateTime"/>.</em></p><p>The start date for when to get the list of recurrences. The startDateTime and endDateTime can be no more than 30 days apart.</p></summary>
        [Pure]
        public static AzureDlaJobRecurrenceListSettings ResetStartDateTime(this AzureDlaJobRecurrenceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartDateTime = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlaJobRecurrenceListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaJobRecurrenceListSettings SetDebug(this AzureDlaJobRecurrenceListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobRecurrenceListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaJobRecurrenceListSettings ResetDebug(this AzureDlaJobRecurrenceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlaJobRecurrenceListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaJobRecurrenceListSettings SetHelp(this AzureDlaJobRecurrenceListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobRecurrenceListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaJobRecurrenceListSettings ResetHelp(this AzureDlaJobRecurrenceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlaJobRecurrenceListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaJobRecurrenceListSettings SetOutput(this AzureDlaJobRecurrenceListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobRecurrenceListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaJobRecurrenceListSettings ResetOutput(this AzureDlaJobRecurrenceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlaJobRecurrenceListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaJobRecurrenceListSettings SetQuery(this AzureDlaJobRecurrenceListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobRecurrenceListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaJobRecurrenceListSettings ResetQuery(this AzureDlaJobRecurrenceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlaJobRecurrenceListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaJobRecurrenceListSettings SetVerbose(this AzureDlaJobRecurrenceListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobRecurrenceListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaJobRecurrenceListSettings ResetVerbose(this AzureDlaJobRecurrenceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlaJobRecurrenceShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlaJobRecurrenceShowSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlaJobRecurrenceShowSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaJobRecurrenceShowSettings SetAccount(this AzureDlaJobRecurrenceShowSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobRecurrenceShowSettings.Account"/>.</em></p><p>Name of the Data Lake Analytics account.</p></summary>
        [Pure]
        public static AzureDlaJobRecurrenceShowSettings ResetAccount(this AzureDlaJobRecurrenceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region RecurrenceIdentity
        /// <summary><p><em>Sets <see cref="AzureDlaJobRecurrenceShowSettings.RecurrenceIdentity"/>.</em></p><p>Recurrence ID.</p></summary>
        [Pure]
        public static AzureDlaJobRecurrenceShowSettings SetRecurrenceIdentity(this AzureDlaJobRecurrenceShowSettings toolSettings, string recurrenceIdentity)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RecurrenceIdentity = recurrenceIdentity;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobRecurrenceShowSettings.RecurrenceIdentity"/>.</em></p><p>Recurrence ID.</p></summary>
        [Pure]
        public static AzureDlaJobRecurrenceShowSettings ResetRecurrenceIdentity(this AzureDlaJobRecurrenceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RecurrenceIdentity = null;
            return toolSettings;
        }
        #endregion
        #region EndDateTime
        /// <summary><p><em>Sets <see cref="AzureDlaJobRecurrenceShowSettings.EndDateTime"/>.</em></p><p>The end date for when to get recurrence and aggregate its data. The startDateTime and endDateTime can be no more than 30 days apart.</p></summary>
        [Pure]
        public static AzureDlaJobRecurrenceShowSettings SetEndDateTime(this AzureDlaJobRecurrenceShowSettings toolSettings, string endDateTime)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndDateTime = endDateTime;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobRecurrenceShowSettings.EndDateTime"/>.</em></p><p>The end date for when to get recurrence and aggregate its data. The startDateTime and endDateTime can be no more than 30 days apart.</p></summary>
        [Pure]
        public static AzureDlaJobRecurrenceShowSettings ResetEndDateTime(this AzureDlaJobRecurrenceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndDateTime = null;
            return toolSettings;
        }
        #endregion
        #region StartDateTime
        /// <summary><p><em>Sets <see cref="AzureDlaJobRecurrenceShowSettings.StartDateTime"/>.</em></p><p>The start date for when to get the recurrence and aggregate its data. The startDateTime and endDateTime can be no more than 30 days apart.</p></summary>
        [Pure]
        public static AzureDlaJobRecurrenceShowSettings SetStartDateTime(this AzureDlaJobRecurrenceShowSettings toolSettings, string startDateTime)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartDateTime = startDateTime;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobRecurrenceShowSettings.StartDateTime"/>.</em></p><p>The start date for when to get the recurrence and aggregate its data. The startDateTime and endDateTime can be no more than 30 days apart.</p></summary>
        [Pure]
        public static AzureDlaJobRecurrenceShowSettings ResetStartDateTime(this AzureDlaJobRecurrenceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartDateTime = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlaJobRecurrenceShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaJobRecurrenceShowSettings SetDebug(this AzureDlaJobRecurrenceShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobRecurrenceShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlaJobRecurrenceShowSettings ResetDebug(this AzureDlaJobRecurrenceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlaJobRecurrenceShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaJobRecurrenceShowSettings SetHelp(this AzureDlaJobRecurrenceShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobRecurrenceShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlaJobRecurrenceShowSettings ResetHelp(this AzureDlaJobRecurrenceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlaJobRecurrenceShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaJobRecurrenceShowSettings SetOutput(this AzureDlaJobRecurrenceShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobRecurrenceShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlaJobRecurrenceShowSettings ResetOutput(this AzureDlaJobRecurrenceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlaJobRecurrenceShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaJobRecurrenceShowSettings SetQuery(this AzureDlaJobRecurrenceShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobRecurrenceShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlaJobRecurrenceShowSettings ResetQuery(this AzureDlaJobRecurrenceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlaJobRecurrenceShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaJobRecurrenceShowSettings SetVerbose(this AzureDlaJobRecurrenceShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlaJobRecurrenceShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlaJobRecurrenceShowSettings ResetVerbose(this AzureDlaJobRecurrenceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region DlaAccountTier
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class DlaAccountTier : Enumeration
    {
        public static DlaAccountTier commitment_100000auhours = new DlaAccountTier { Value = "commitment_100000auhours" };
        public static DlaAccountTier commitment_10000auhours = new DlaAccountTier { Value = "commitment_10000auhours" };
        public static DlaAccountTier commitment_1000auhours = new DlaAccountTier { Value = "commitment_1000auhours" };
        public static DlaAccountTier commitment_100auhours = new DlaAccountTier { Value = "commitment_100auhours" };
        public static DlaAccountTier commitment_500000auhours = new DlaAccountTier { Value = "commitment_500000auhours" };
        public static DlaAccountTier commitment_50000auhours = new DlaAccountTier { Value = "commitment_50000auhours" };
        public static DlaAccountTier commitment_5000auhours = new DlaAccountTier { Value = "commitment_5000auhours" };
        public static DlaAccountTier commitment_500auhours = new DlaAccountTier { Value = "commitment_500auhours" };
        public static DlaAccountTier consumption = new DlaAccountTier { Value = "consumption" };
    }
    #endregion
    #region DlaAccountUpdateAllowAzureIps
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class DlaAccountUpdateAllowAzureIps : Enumeration
    {
        public static DlaAccountUpdateAllowAzureIps disabled = new DlaAccountUpdateAllowAzureIps { Value = "disabled" };
        public static DlaAccountUpdateAllowAzureIps enabled = new DlaAccountUpdateAllowAzureIps { Value = "enabled" };
    }
    #endregion
    #region DlaJobListResult
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class DlaJobListResult : Enumeration
    {
        public static DlaJobListResult cancelled = new DlaJobListResult { Value = "cancelled" };
        public static DlaJobListResult failed = new DlaJobListResult { Value = "failed" };
        public static DlaJobListResult none = new DlaJobListResult { Value = "none" };
        public static DlaJobListResult succeeded = new DlaJobListResult { Value = "succeeded" };
    }
    #endregion
    #region DlaJobListState
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class DlaJobListState : Enumeration
    {
        public static DlaJobListState accepted = new DlaJobListState { Value = "accepted" };
        public static DlaJobListState compiling = new DlaJobListState { Value = "compiling" };
        public static DlaJobListState ended = new DlaJobListState { Value = "ended" };
        public static DlaJobListState new_ = new DlaJobListState { Value = "new" };
        public static DlaJobListState paused = new DlaJobListState { Value = "paused" };
        public static DlaJobListState queued = new DlaJobListState { Value = "queued" };
        public static DlaJobListState running = new DlaJobListState { Value = "running" };
        public static DlaJobListState scheduling = new DlaJobListState { Value = "scheduling" };
        public static DlaJobListState starting = new DlaJobListState { Value = "starting" };
        public static DlaJobListState waitingforcapacity = new DlaJobListState { Value = "waitingforcapacity" };
    }
    #endregion
    #region DlaJobSubmitCompileMode
    /// <summary><p>Used within <see cref="AzureDlaTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class DlaJobSubmitCompileMode : Enumeration
    {
        public static DlaJobSubmitCompileMode full = new DlaJobSubmitCompileMode { Value = "full" };
        public static DlaJobSubmitCompileMode semantic = new DlaJobSubmitCompileMode { Value = "semantic" };
        public static DlaJobSubmitCompileMode singlebox = new DlaJobSubmitCompileMode { Value = "singlebox" };
    }
    #endregion
}
