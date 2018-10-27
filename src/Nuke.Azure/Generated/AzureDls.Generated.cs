// Copyright Matthias Koch, Sebastian Karasek 2018.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

// Generated with Nuke.CodeGeneration, Version: 0.6.2 [CommitSha: ff25463a].
// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/AzureDls.json.

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
    public static partial class AzureDlsTasks
    {
        /// <summary><p>Path to the AzureDls executable.</p></summary>
        public static string AzureDlsPath => ToolPathResolver.GetPathExecutable("az");
        /// <summary><p>(PREVIEW) Manage Data Lake Store accounts and filesystems.</p></summary>
        public static IReadOnlyCollection<Output> AzureDls(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool logOutput = true, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzureDlsPath, arguments, workingDirectory, environmentVariables, timeout, logOutput, null, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Store accounts and filesystems.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dls?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDls(Configure<AzureDlsSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlsSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Store accounts and filesystems.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dls?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlsFsAppend(Configure<AzureDlsFsAppendSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlsFsAppendSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Store accounts and filesystems.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dls?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlsFsCreate(Configure<AzureDlsFsCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlsFsCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Store accounts and filesystems.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dls?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlsFsDelete(Configure<AzureDlsFsDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlsFsDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Store accounts and filesystems.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dls?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlsFsDownload(Configure<AzureDlsFsDownloadSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlsFsDownloadSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Store accounts and filesystems.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dls?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlsFsJoin(Configure<AzureDlsFsJoinSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlsFsJoinSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Store accounts and filesystems.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dls?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlsFsList(Configure<AzureDlsFsListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlsFsListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Store accounts and filesystems.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dls?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlsFsMove(Configure<AzureDlsFsMoveSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlsFsMoveSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Store accounts and filesystems.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dls?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlsFsPreview(Configure<AzureDlsFsPreviewSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlsFsPreviewSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Store accounts and filesystems.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dls?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlsFsRemoveExpiry(Configure<AzureDlsFsRemoveExpirySettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlsFsRemoveExpirySettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Store accounts and filesystems.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dls?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlsFsSetExpiry(Configure<AzureDlsFsSetExpirySettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlsFsSetExpirySettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Store accounts and filesystems.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dls?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlsFsShow(Configure<AzureDlsFsShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlsFsShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Store accounts and filesystems.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dls?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlsFsTest(Configure<AzureDlsFsTestSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlsFsTestSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Store accounts and filesystems.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dls?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlsFsUpload(Configure<AzureDlsFsUploadSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlsFsUploadSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Store accounts and filesystems.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dls?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlsAccountCreate(Configure<AzureDlsAccountCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlsAccountCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Store accounts and filesystems.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dls?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlsAccountDelete(Configure<AzureDlsAccountDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlsAccountDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Store accounts and filesystems.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dls?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlsAccountEnableKeyVault(Configure<AzureDlsAccountEnableKeyVaultSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlsAccountEnableKeyVaultSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Store accounts and filesystems.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dls?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlsAccountList(Configure<AzureDlsAccountListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlsAccountListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Store accounts and filesystems.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dls?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlsAccountShow(Configure<AzureDlsAccountShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlsAccountShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Store accounts and filesystems.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dls?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlsAccountUpdate(Configure<AzureDlsAccountUpdateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlsAccountUpdateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Store accounts and filesystems.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dls?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlsAccountFirewallCreate(Configure<AzureDlsAccountFirewallCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlsAccountFirewallCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Store accounts and filesystems.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dls?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlsAccountFirewallDelete(Configure<AzureDlsAccountFirewallDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlsAccountFirewallDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Store accounts and filesystems.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dls?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlsAccountFirewallList(Configure<AzureDlsAccountFirewallListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlsAccountFirewallListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Store accounts and filesystems.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dls?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlsAccountFirewallShow(Configure<AzureDlsAccountFirewallShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlsAccountFirewallShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Store accounts and filesystems.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dls?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlsAccountFirewallUpdate(Configure<AzureDlsAccountFirewallUpdateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlsAccountFirewallUpdateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Store accounts and filesystems.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dls?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlsAccountTrustedProviderCreate(Configure<AzureDlsAccountTrustedProviderCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlsAccountTrustedProviderCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Store accounts and filesystems.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dls?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlsAccountTrustedProviderDelete(Configure<AzureDlsAccountTrustedProviderDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlsAccountTrustedProviderDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Store accounts and filesystems.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dls?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlsAccountTrustedProviderList(Configure<AzureDlsAccountTrustedProviderListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlsAccountTrustedProviderListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Store accounts and filesystems.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dls?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlsAccountTrustedProviderShow(Configure<AzureDlsAccountTrustedProviderShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlsAccountTrustedProviderShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Store accounts and filesystems.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dls?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlsAccountTrustedProviderUpdate(Configure<AzureDlsAccountTrustedProviderUpdateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlsAccountTrustedProviderUpdateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Store accounts and filesystems.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dls?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlsAccountNetworkRuleCreate(Configure<AzureDlsAccountNetworkRuleCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlsAccountNetworkRuleCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Store accounts and filesystems.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dls?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlsAccountNetworkRuleDelete(Configure<AzureDlsAccountNetworkRuleDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlsAccountNetworkRuleDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Store accounts and filesystems.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dls?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlsAccountNetworkRuleList(Configure<AzureDlsAccountNetworkRuleListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlsAccountNetworkRuleListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Store accounts and filesystems.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dls?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlsAccountNetworkRuleShow(Configure<AzureDlsAccountNetworkRuleShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlsAccountNetworkRuleShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Store accounts and filesystems.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dls?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlsAccountNetworkRuleUpdate(Configure<AzureDlsAccountNetworkRuleUpdateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlsAccountNetworkRuleUpdateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Store accounts and filesystems.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dls?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlsFsAccessRemoveAll(Configure<AzureDlsFsAccessRemoveAllSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlsFsAccessRemoveAllSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Store accounts and filesystems.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dls?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlsFsAccessRemoveEntry(Configure<AzureDlsFsAccessRemoveEntrySettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlsFsAccessRemoveEntrySettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Store accounts and filesystems.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dls?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlsFsAccessSet(Configure<AzureDlsFsAccessSetSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlsFsAccessSetSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Store accounts and filesystems.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dls?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlsFsAccessSetEntry(Configure<AzureDlsFsAccessSetEntrySettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlsFsAccessSetEntrySettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Store accounts and filesystems.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dls?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlsFsAccessSetOwner(Configure<AzureDlsFsAccessSetOwnerSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlsFsAccessSetOwnerSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Store accounts and filesystems.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dls?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlsFsAccessSetPermission(Configure<AzureDlsFsAccessSetPermissionSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlsFsAccessSetPermissionSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>(PREVIEW) Manage Data Lake Store accounts and filesystems.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dls?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDlsFsAccessShow(Configure<AzureDlsFsAccessShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDlsFsAccessShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
    }
    #region AzureDlsSettings
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlsSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDls executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlsTasks.AzureDlsPath;
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("dls")
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureDlsFsAppendSettings
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlsFsAppendSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDls executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlsTasks.AzureDlsPath;
        /// <summary><p>Name of the Data Lake Store account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>Content to be appended to the file.</p></summary>
        public virtual string Content { get; internal set; }
        /// <summary><p>The path in the specified Data Lake Store account where the action should take place. In the format '/folder/file.txt', where the first '/' after the DNS indicates the root of the file system.</p></summary>
        public virtual string Path { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("dls fs append")
              .Add("--account {value}", Account)
              .Add("--content {value}", Content)
              .Add("--path {value}", Path)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureDlsFsCreateSettings
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlsFsCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDls executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlsTasks.AzureDlsPath;
        /// <summary><p>Name of the Data Lake Store account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>The path in the specified Data Lake Store account where the action should take place. In the format '/folder/file.txt', where the first '/' after the DNS indicates the root of the file system.</p></summary>
        public virtual string Path { get; internal set; }
        /// <summary><p>Content for the file to contain upon creation.</p></summary>
        public virtual string Content { get; internal set; }
        /// <summary><p>Indicates that this new item is a folder and not a file.</p></summary>
        public virtual string Folder { get; internal set; }
        /// <summary><p>Indicates that, if the file or folder exists, it should be overwritten.</p></summary>
        public virtual string Force { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("dls fs create")
              .Add("--account {value}", Account)
              .Add("--path {value}", Path)
              .Add("--content {value}", Content)
              .Add("--folder {value}", Folder)
              .Add("--force {value}", Force)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureDlsFsDeleteSettings
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlsFsDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDls executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlsTasks.AzureDlsPath;
        /// <summary><p>Name of the Data Lake Store account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>The path in the specified Data Lake Store account where the action should take place. In the format '/folder/file.txt', where the first '/' after the DNS indicates the root of the file system.</p></summary>
        public virtual string Path { get; internal set; }
        /// <summary><p>Indicates this should be a recursive delete of the folder.</p></summary>
        public virtual string Recurse { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("dls fs delete")
              .Add("--account {value}", Account)
              .Add("--path {value}", Path)
              .Add("--recurse {value}", Recurse)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureDlsFsDownloadSettings
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlsFsDownloadSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDls executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlsTasks.AzureDlsPath;
        /// <summary><p>Name of the Data Lake Store account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>The local path where the file or folder will be downloaded to.</p></summary>
        public virtual string DestinationPath { get; internal set; }
        /// <summary><p>The full path in the Data Lake Store filesystem to download the file or folder from.</p></summary>
        public virtual string SourcePath { get; internal set; }
        /// <summary><p>Size of a block, in bytes.</p></summary>
        public virtual string BlockSize { get; internal set; }
        /// <summary><p>Size of the transfer buffer, in bytes.</p></summary>
        public virtual string BufferSize { get; internal set; }
        /// <summary><p>Size of a chunk, in bytes.</p></summary>
        public virtual string ChunkSize { get; internal set; }
        /// <summary><p>Indicates that, if the destination file or folder exists, it should be overwritten.</p></summary>
        public virtual string Overwrite { get; internal set; }
        /// <summary><p></p></summary>
        public virtual string ProgressCallback { get; internal set; }
        /// <summary><p>Parallelism of the download. Default: The number of cores in the local machine.</p></summary>
        public virtual string ThreadCount { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("dls fs download")
              .Add("--account {value}", Account)
              .Add("--destination-path {value}", DestinationPath)
              .Add("--source-path {value}", SourcePath)
              .Add("--block-size {value}", BlockSize)
              .Add("--buffer-size {value}", BufferSize)
              .Add("--chunk-size {value}", ChunkSize)
              .Add("--overwrite {value}", Overwrite)
              .Add("--progress-callback {value}", ProgressCallback)
              .Add("--thread-count {value}", ThreadCount)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureDlsFsJoinSettings
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlsFsJoinSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDls executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlsTasks.AzureDlsPath;
        /// <summary><p>Name of the Data Lake Store account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>The destination path in the Data Lake Store account.</p></summary>
        public virtual string DestinationPath { get; internal set; }
        /// <summary><p>The space-separated list of files in the Data Lake Store account to join.</p></summary>
        public virtual string SourcePaths { get; internal set; }
        /// <summary><p>Indicates that, if the destination file already exists, it should be overwritten.</p></summary>
        public virtual string Force { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("dls fs join")
              .Add("--account {value}", Account)
              .Add("--destination-path {value}", DestinationPath)
              .Add("--source-paths {value}", SourcePaths)
              .Add("--force {value}", Force)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureDlsFsListSettings
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlsFsListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDls executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlsTasks.AzureDlsPath;
        /// <summary><p>Name of the Data Lake Store account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>The path in the specified Data Lake Store account where the action should take place. In the format '/folder/file.txt', where the first '/' after the DNS indicates the root of the file system.</p></summary>
        public virtual string Path { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("dls fs list")
              .Add("--account {value}", Account)
              .Add("--path {value}", Path)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureDlsFsMoveSettings
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlsFsMoveSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDls executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlsTasks.AzureDlsPath;
        /// <summary><p>Name of the Data Lake Store account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>The destination path in the Data Lake Store account.</p></summary>
        public virtual string DestinationPath { get; internal set; }
        /// <summary><p>The file or folder to move.</p></summary>
        public virtual string SourcePath { get; internal set; }
        /// <summary><p>Indicates that, if the destination file or folder already exists, it should be overwritten and replaced with the file or folder being moved.</p></summary>
        public virtual string Force { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("dls fs move")
              .Add("--account {value}", Account)
              .Add("--destination-path {value}", DestinationPath)
              .Add("--source-path {value}", SourcePath)
              .Add("--force {value}", Force)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureDlsFsPreviewSettings
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlsFsPreviewSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDls executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlsTasks.AzureDlsPath;
        /// <summary><p>Name of the Data Lake Store account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>The path in the specified Data Lake Store account where the action should take place. In the format '/folder/file.txt', where the first '/' after the DNS indicates the root of the file system.</p></summary>
        public virtual string Path { get; internal set; }
        /// <summary><p>Indicates that, if the preview is larger than 1MB, still retrieve it. This can potentially be very slow, depending on how large the file is.</p></summary>
        public virtual string Force { get; internal set; }
        /// <summary><p>The amount of data to preview in bytes.</p></summary>
        public virtual string Length { get; internal set; }
        /// <summary><p>The position in bytes to start the preview from.</p></summary>
        public virtual string Offset { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("dls fs preview")
              .Add("--account {value}", Account)
              .Add("--path {value}", Path)
              .Add("--force {value}", Force)
              .Add("--length {value}", Length)
              .Add("--offset {value}", Offset)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureDlsFsRemoveExpirySettings
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlsFsRemoveExpirySettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDls executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlsTasks.AzureDlsPath;
        /// <summary><p>Name of the Data Lake Store account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>The path in the specified Data Lake Store account where the action should take place. In the format '/folder/file.txt', where the first '/' after the DNS indicates the root of the file system.</p></summary>
        public virtual string Path { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("dls fs remove-expiry")
              .Add("--account {value}", Account)
              .Add("--path {value}", Path)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureDlsFsSetExpirySettings
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlsFsSetExpirySettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDls executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlsTasks.AzureDlsPath;
        /// <summary><p>Name of the Data Lake Store account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>The absolute value of the expiration time expressed as milliseconds since the epoch.</p></summary>
        public virtual string ExpirationTime { get; internal set; }
        /// <summary><p>The path in the specified Data Lake Store account where the action should take place. In the format '/folder/file.txt', where the first '/' after the DNS indicates the root of the file system.</p></summary>
        public virtual string Path { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("dls fs set-expiry")
              .Add("--account {value}", Account)
              .Add("--expiration-time {value}", ExpirationTime)
              .Add("--path {value}", Path)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureDlsFsShowSettings
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlsFsShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDls executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlsTasks.AzureDlsPath;
        /// <summary><p>Name of the Data Lake Store account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>The path in the specified Data Lake Store account where the action should take place. In the format '/folder/file.txt', where the first '/' after the DNS indicates the root of the file system.</p></summary>
        public virtual string Path { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("dls fs show")
              .Add("--account {value}", Account)
              .Add("--path {value}", Path)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureDlsFsTestSettings
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlsFsTestSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDls executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlsTasks.AzureDlsPath;
        /// <summary><p>Name of the Data Lake Store account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>The path in the specified Data Lake Store account where the action should take place. In the format '/folder/file.txt', where the first '/' after the DNS indicates the root of the file system.</p></summary>
        public virtual string Path { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("dls fs test")
              .Add("--account {value}", Account)
              .Add("--path {value}", Path)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureDlsFsUploadSettings
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlsFsUploadSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDls executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlsTasks.AzureDlsPath;
        /// <summary><p>Name of the Data Lake Store account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>The full path in the Data Lake Store filesystem to upload the file or folder to.</p></summary>
        public virtual string DestinationPath { get; internal set; }
        /// <summary><p>The path to the file or folder to upload.</p></summary>
        public virtual string SourcePath { get; internal set; }
        /// <summary><p>Size of a block, in bytes.</p></summary>
        public virtual string BlockSize { get; internal set; }
        /// <summary><p>Size of the transfer buffer, in bytes.</p></summary>
        public virtual string BufferSize { get; internal set; }
        /// <summary><p>Size of a chunk, in bytes.</p></summary>
        public virtual string ChunkSize { get; internal set; }
        /// <summary><p>Indicates that, if the destination file or folder exists, it should be overwritten.</p></summary>
        public virtual string Overwrite { get; internal set; }
        /// <summary><p></p></summary>
        public virtual string ProgressCallback { get; internal set; }
        /// <summary><p>Parallelism of the upload. Default: The number of cores in the local machine.</p></summary>
        public virtual string ThreadCount { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("dls fs upload")
              .Add("--account {value}", Account)
              .Add("--destination-path {value}", DestinationPath)
              .Add("--source-path {value}", SourcePath)
              .Add("--block-size {value}", BlockSize)
              .Add("--buffer-size {value}", BufferSize)
              .Add("--chunk-size {value}", ChunkSize)
              .Add("--overwrite {value}", Overwrite)
              .Add("--progress-callback {value}", ProgressCallback)
              .Add("--thread-count {value}", ThreadCount)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureDlsAccountCreateSettings
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlsAccountCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDls executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlsTasks.AzureDlsPath;
        /// <summary><p>Name of the Data Lake Store account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>Name of the default group to give permissions to for freshly created files and folders in the Data Lake Store account.</p></summary>
        public virtual string DefaultGroup { get; internal set; }
        /// <summary><p>Indicates that the account will not have any form of encryption applied to it.</p></summary>
        public virtual string DisableEncryption { get; internal set; }
        /// <summary><p>Indicates what type of encryption to provision the account with. By default, encryption is ServiceManaged. If no encryption is desired, it must be explicitly set with the --disable-encryption flag.</p></summary>
        public virtual DlsAccountCreateEncryptionType EncryptionType { get; internal set; }
        /// <summary><p>Key name for the user-assigned encryption type.</p></summary>
        public virtual string KeyName { get; internal set; }
        /// <summary><p>Key vault for the user-assigned encryption type.</p></summary>
        public virtual string KeyVaultId { get; internal set; }
        /// <summary><p>Key version for the user-assigned encryption type.</p></summary>
        public virtual string KeyVersion { get; internal set; }
        /// <summary><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        public virtual string Location { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        public virtual string Tags { get; internal set; }
        /// <summary><p>The desired commitment tier for this account to use.</p></summary>
        public virtual DlsAccountTier Tier { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("dls account create")
              .Add("--account {value}", Account)
              .Add("--default-group {value}", DefaultGroup)
              .Add("--disable-encryption {value}", DisableEncryption)
              .Add("--encryption-type {value}", EncryptionType)
              .Add("--key-name {value}", KeyName)
              .Add("--key-vault-id {value}", KeyVaultId)
              .Add("--key-version {value}", KeyVersion)
              .Add("--location {value}", Location)
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
    #region AzureDlsAccountDeleteSettings
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlsAccountDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDls executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlsTasks.AzureDlsPath;
        /// <summary><p>Name of the Data Lake Store account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>If not specified, will attempt to discover the resource group for the specified Data Lake Store account.</p></summary>
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
              .Add("dls account delete")
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
    #region AzureDlsAccountEnableKeyVaultSettings
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlsAccountEnableKeyVaultSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDls executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlsTasks.AzureDlsPath;
        /// <summary><p>Name of the Data Lake Store account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>If not specified, will attempt to discover the resource group for the specified Data Lake Store account.</p></summary>
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
              .Add("dls account enable-key-vault")
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
    #region AzureDlsAccountListSettings
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlsAccountListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDls executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlsTasks.AzureDlsPath;
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
              .Add("dls account list")
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
    #region AzureDlsAccountShowSettings
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlsAccountShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDls executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlsTasks.AzureDlsPath;
        /// <summary><p>Name of the Data Lake Store account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>If not specified, will attempt to discover the resource group for the specified Data Lake Store account.</p></summary>
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
              .Add("dls account show")
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
    #region AzureDlsAccountUpdateSettings
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlsAccountUpdateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDls executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlsTasks.AzureDlsPath;
        /// <summary><p>Name of the Data Lake Store account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>Allow/block Azure originating IPs through the firewall.</p></summary>
        public virtual DlsAccountUpdateAllowAzureIps AllowAzureIps { get; internal set; }
        /// <summary><p></p></summary>
        public virtual string DefaultGroup { get; internal set; }
        /// <summary><p>Enable/disable existing firewall rules.</p></summary>
        public virtual DlsAccountUpdateAllowAzureIps FirewallState { get; internal set; }
        /// <summary><p></p></summary>
        public virtual string KeyVersion { get; internal set; }
        /// <summary><p>If not specified, will attempt to discover the resource group for the specified Data Lake Store account.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        public virtual string Tags { get; internal set; }
        /// <summary><p>The desired commitment tier for this account to use.</p></summary>
        public virtual DlsAccountTier Tier { get; internal set; }
        /// <summary><p>Enable/disable the existing trusted ID providers.</p></summary>
        public virtual DlsAccountUpdateAllowAzureIps TrustedIdProviderState { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("dls account update")
              .Add("--account {value}", Account)
              .Add("--allow-azure-ips {value}", AllowAzureIps)
              .Add("--default-group {value}", DefaultGroup)
              .Add("--firewall-state {value}", FirewallState)
              .Add("--key-version {value}", KeyVersion)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--tags {value}", Tags)
              .Add("--tier {value}", Tier)
              .Add("--trusted-id-provider-state {value}", TrustedIdProviderState)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureDlsAccountFirewallCreateSettings
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlsAccountFirewallCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDls executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlsTasks.AzureDlsPath;
        /// <summary><p>Name of the Data Lake Store account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>The end of the valid ip range for the firewall rule.</p></summary>
        public virtual string EndIpAddress { get; internal set; }
        /// <summary><p>The name of the firewall rule.</p></summary>
        public virtual string FirewallRuleName { get; internal set; }
        /// <summary><p>The start of the valid ip range for the firewall rule.</p></summary>
        public virtual string StartIpAddress { get; internal set; }
        /// <summary><p>If not specified, will attempt to discover the resource group for the specified Data Lake Store account.</p></summary>
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
              .Add("dls account firewall create")
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
    #region AzureDlsAccountFirewallDeleteSettings
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlsAccountFirewallDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDls executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlsTasks.AzureDlsPath;
        /// <summary><p>Name of the Data Lake Store account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>The name of the firewall rule to delete.</p></summary>
        public virtual string FirewallRuleName { get; internal set; }
        /// <summary><p>If not specified, will attempt to discover the resource group for the specified Data Lake Store account.</p></summary>
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
              .Add("dls account firewall delete")
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
    #region AzureDlsAccountFirewallListSettings
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlsAccountFirewallListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDls executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlsTasks.AzureDlsPath;
        /// <summary><p>Name of the Data Lake Store account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>If not specified, will attempt to discover the resource group for the specified Data Lake Store account.</p></summary>
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
              .Add("dls account firewall list")
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
    #region AzureDlsAccountFirewallShowSettings
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlsAccountFirewallShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDls executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlsTasks.AzureDlsPath;
        /// <summary><p>Name of the Data Lake Store account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>The name of the firewall rule to retrieve.</p></summary>
        public virtual string FirewallRuleName { get; internal set; }
        /// <summary><p>If not specified, will attempt to discover the resource group for the specified Data Lake Store account.</p></summary>
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
              .Add("dls account firewall show")
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
    #region AzureDlsAccountFirewallUpdateSettings
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlsAccountFirewallUpdateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDls executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlsTasks.AzureDlsPath;
        /// <summary><p>Name of the Data Lake Store account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>The name of the firewall rule to update.</p></summary>
        public virtual string FirewallRuleName { get; internal set; }
        /// <summary><p>The end IP address for the firewall rule. This can be either ipv4 or ipv6. Start and End should be in the same protocol.</p></summary>
        public virtual string EndIpAddress { get; internal set; }
        /// <summary><p>If not specified, will attempt to discover the resource group for the specified Data Lake Store account.</p></summary>
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
              .Add("dls account firewall update")
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
    #region AzureDlsAccountTrustedProviderCreateSettings
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlsAccountTrustedProviderCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDls executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlsTasks.AzureDlsPath;
        /// <summary><p>Name of the Data Lake Store account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>The URL of this trusted identity provider.</p></summary>
        public virtual string IdProvider { get; internal set; }
        /// <summary><p>The name of the trusted identity provider. This is used for differentiation of providers in the account.</p></summary>
        public virtual string TrustedIdProviderName { get; internal set; }
        /// <summary><p>If not specified, will attempt to discover the resource group for the specified Data Lake Store account.</p></summary>
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
              .Add("dls account trusted-provider create")
              .Add("--account {value}", Account)
              .Add("--id-provider {value}", IdProvider)
              .Add("--trusted-id-provider-name {value}", TrustedIdProviderName)
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
    #region AzureDlsAccountTrustedProviderDeleteSettings
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlsAccountTrustedProviderDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDls executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlsTasks.AzureDlsPath;
        /// <summary><p>Name of the Data Lake Store account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>The name of the trusted identity provider to delete.</p></summary>
        public virtual string TrustedIdProviderName { get; internal set; }
        /// <summary><p>If not specified, will attempt to discover the resource group for the specified Data Lake Store account.</p></summary>
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
              .Add("dls account trusted-provider delete")
              .Add("--account {value}", Account)
              .Add("--trusted-id-provider-name {value}", TrustedIdProviderName)
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
    #region AzureDlsAccountTrustedProviderListSettings
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlsAccountTrustedProviderListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDls executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlsTasks.AzureDlsPath;
        /// <summary><p>Name of the Data Lake Store account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>If not specified, will attempt to discover the resource group for the specified Data Lake Store account.</p></summary>
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
              .Add("dls account trusted-provider list")
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
    #region AzureDlsAccountTrustedProviderShowSettings
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlsAccountTrustedProviderShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDls executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlsTasks.AzureDlsPath;
        /// <summary><p>Name of the Data Lake Store account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>The name of the trusted identity provider to retrieve.</p></summary>
        public virtual string TrustedIdProviderName { get; internal set; }
        /// <summary><p>If not specified, will attempt to discover the resource group for the specified Data Lake Store account.</p></summary>
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
              .Add("dls account trusted-provider show")
              .Add("--account {value}", Account)
              .Add("--trusted-id-provider-name {value}", TrustedIdProviderName)
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
    #region AzureDlsAccountTrustedProviderUpdateSettings
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlsAccountTrustedProviderUpdateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDls executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlsTasks.AzureDlsPath;
        /// <summary><p>Name of the Data Lake Store account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>The name of the trusted identity provider. This is used for differentiation of providers in the account.</p></summary>
        public virtual string TrustedIdProviderName { get; internal set; }
        /// <summary><p>The URL of this trusted identity provider.</p></summary>
        public virtual string IdProvider { get; internal set; }
        /// <summary><p>If not specified, will attempt to discover the resource group for the specified Data Lake Store account.</p></summary>
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
              .Add("dls account trusted-provider update")
              .Add("--account {value}", Account)
              .Add("--trusted-id-provider-name {value}", TrustedIdProviderName)
              .Add("--id-provider {value}", IdProvider)
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
    #region AzureDlsAccountNetworkRuleCreateSettings
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlsAccountNetworkRuleCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDls executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlsTasks.AzureDlsPath;
        /// <summary><p>Name of the Data Lake Store account.</p></summary>
        public virtual string AccountName { get; internal set; }
        /// <summary><p>The virtual network rule name.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>The subnet name or id for the virtual network rule.</p></summary>
        public virtual string Subnet { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The name of the virtual network rule.</p></summary>
        public virtual string VnetName { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("dls account network-rule create")
              .Add("--account-name {value}", AccountName)
              .Add("--name {value}", Name)
              .Add("--subnet {value}", Subnet)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--vnet-name {value}", VnetName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureDlsAccountNetworkRuleDeleteSettings
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlsAccountNetworkRuleDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDls executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlsTasks.AzureDlsPath;
        /// <summary><p>Name of the Data Lake Store account.</p></summary>
        public virtual string AccountName { get; internal set; }
        /// <summary><p>The virtual network rule name.</p></summary>
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
              .Add("dls account network-rule delete")
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
    #region AzureDlsAccountNetworkRuleListSettings
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlsAccountNetworkRuleListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDls executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlsTasks.AzureDlsPath;
        /// <summary><p>Name of the Data Lake Store account.</p></summary>
        public virtual string AccountName { get; internal set; }
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
              .Add("dls account network-rule list")
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
    #region AzureDlsAccountNetworkRuleShowSettings
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlsAccountNetworkRuleShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDls executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlsTasks.AzureDlsPath;
        /// <summary><p>Name of the Data Lake Store account.</p></summary>
        public virtual string AccountName { get; internal set; }
        /// <summary><p>The virtual network rule name.</p></summary>
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
              .Add("dls account network-rule show")
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
    #region AzureDlsAccountNetworkRuleUpdateSettings
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlsAccountNetworkRuleUpdateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDls executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlsTasks.AzureDlsPath;
        /// <summary><p>Name of the Data Lake Store account.</p></summary>
        public virtual string AccountName { get; internal set; }
        /// <summary><p>The virtual network rule name.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name or ID of the subnet that allows access to DLS. If subnet name is provided, --name must be provided.</p></summary>
        public virtual string Subnet { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The virtual network rule name.</p></summary>
        public virtual string VnetName { get; internal set; }
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
              .Add("dls account network-rule update")
              .Add("--account-name {value}", AccountName)
              .Add("--name {value}", Name)
              .Add("--subnet {value}", Subnet)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--vnet-name {value}", VnetName)
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
    #region AzureDlsFsAccessRemoveAllSettings
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlsFsAccessRemoveAllSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDls executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlsTasks.AzureDlsPath;
        /// <summary><p>Name of the Data Lake Store account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>The path in the specified Data Lake Store account where the action should take place. In the format '/folder/file.txt', where the first '/' after the DNS indicates the root of the file system.</p></summary>
        public virtual string Path { get; internal set; }
        /// <summary><p>A switch that, if specified, indicates that the remove ACL operation should remove the default ACL of the folder. Otherwise the regular ACL is removed.</p></summary>
        public virtual string DefaultAcl { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("dls fs access remove-all")
              .Add("--account {value}", Account)
              .Add("--path {value}", Path)
              .Add("--default-acl {value}", DefaultAcl)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureDlsFsAccessRemoveEntrySettings
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlsFsAccessRemoveEntrySettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDls executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlsTasks.AzureDlsPath;
        /// <summary><p>Name of the Data Lake Store account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>The ACL specification to set on the path in the format '[default:]user|group|other:[entity id or UPN]:r|-w|-x|-,[default:]user|group|other:[entity id or UPN]:r|-w|-x|-,...'.</p></summary>
        public virtual string AclSpec { get; internal set; }
        /// <summary><p>The path in the specified Data Lake Store account where the action should take place. In the format '/folder/file.txt', where the first '/' after the DNS indicates the root of the file system.</p></summary>
        public virtual string Path { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("dls fs access remove-entry")
              .Add("--account {value}", Account)
              .Add("--acl-spec {value}", AclSpec)
              .Add("--path {value}", Path)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureDlsFsAccessSetSettings
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlsFsAccessSetSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDls executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlsTasks.AzureDlsPath;
        /// <summary><p>Name of the Data Lake Store account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>The ACL specification to set on the path in the format '[default:]user|group|other:[entity id or UPN]:r|-w|-x|-,[default:]user|group|other:[entity id or UPN]:r|-w|-x|-,...'.</p></summary>
        public virtual string AclSpec { get; internal set; }
        /// <summary><p>The path in the specified Data Lake Store account where the action should take place. In the format '/folder/file.txt', where the first '/' after the DNS indicates the root of the file system.</p></summary>
        public virtual string Path { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("dls fs access set")
              .Add("--account {value}", Account)
              .Add("--acl-spec {value}", AclSpec)
              .Add("--path {value}", Path)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureDlsFsAccessSetEntrySettings
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlsFsAccessSetEntrySettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDls executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlsTasks.AzureDlsPath;
        /// <summary><p>Name of the Data Lake Store account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>The ACL specification to set on the path in the format '[default:]user|group|other:[entity id or UPN]:r|-w|-x|-,[default:]user|group|other:[entity id or UPN]:r|-w|-x|-,...'.</p></summary>
        public virtual string AclSpec { get; internal set; }
        /// <summary><p>The path in the specified Data Lake Store account where the action should take place. In the format '/folder/file.txt', where the first '/' after the DNS indicates the root of the file system.</p></summary>
        public virtual string Path { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("dls fs access set-entry")
              .Add("--account {value}", Account)
              .Add("--acl-spec {value}", AclSpec)
              .Add("--path {value}", Path)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureDlsFsAccessSetOwnerSettings
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlsFsAccessSetOwnerSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDls executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlsTasks.AzureDlsPath;
        /// <summary><p>Name of the Data Lake Store account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>The path in the specified Data Lake Store account where the action should take place. In the format '/folder/file.txt', where the first '/' after the DNS indicates the root of the file system.</p></summary>
        public virtual string Path { get; internal set; }
        /// <summary><p>The group Azure Active Directory object ID or user principal name to set as the owning group.</p></summary>
        public virtual string Group { get; internal set; }
        /// <summary><p>The user Azure Active Directory object ID or user principal name to set as the owner.</p></summary>
        public virtual string Owner { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("dls fs access set-owner")
              .Add("--account {value}", Account)
              .Add("--path {value}", Path)
              .Add("--group {value}", Group)
              .Add("--owner {value}", Owner)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureDlsFsAccessSetPermissionSettings
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlsFsAccessSetPermissionSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDls executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlsTasks.AzureDlsPath;
        /// <summary><p>Name of the Data Lake Store account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>The path in the specified Data Lake Store account where the action should take place. In the format '/folder/file.txt', where the first '/' after the DNS indicates the root of the file system.</p></summary>
        public virtual string Path { get; internal set; }
        /// <summary><p>The octal representation of the permissions for user, group and mask.</p></summary>
        public virtual string Permission { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("dls fs access set-permission")
              .Add("--account {value}", Account)
              .Add("--path {value}", Path)
              .Add("--permission {value}", Permission)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureDlsFsAccessShowSettings
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDlsFsAccessShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDls executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDlsTasks.AzureDlsPath;
        /// <summary><p>Name of the Data Lake Store account.</p></summary>
        public virtual string Account { get; internal set; }
        /// <summary><p>The path in the specified Data Lake Store account where the action should take place. In the format '/folder/file.txt', where the first '/' after the DNS indicates the root of the file system.</p></summary>
        public virtual string Path { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("dls fs access show")
              .Add("--account {value}", Account)
              .Add("--path {value}", Path)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureDlsSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlsSettingsExtensions
    {
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsSettings SetDebug(this AzureDlsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsSettings ResetDebug(this AzureDlsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsSettings SetHelp(this AzureDlsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsSettings ResetHelp(this AzureDlsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsSettings SetOutput(this AzureDlsSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsSettings ResetOutput(this AzureDlsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlsSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsSettings SetQuery(this AzureDlsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsSettings ResetQuery(this AzureDlsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsSettings SetVerbose(this AzureDlsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsSettings ResetVerbose(this AzureDlsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlsFsAppendSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlsFsAppendSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlsFsAppendSettings.Account"/>.</em></p><p>Name of the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsFsAppendSettings SetAccount(this AzureDlsFsAppendSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsAppendSettings.Account"/>.</em></p><p>Name of the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsFsAppendSettings ResetAccount(this AzureDlsFsAppendSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region Content
        /// <summary><p><em>Sets <see cref="AzureDlsFsAppendSettings.Content"/>.</em></p><p>Content to be appended to the file.</p></summary>
        [Pure]
        public static AzureDlsFsAppendSettings SetContent(this AzureDlsFsAppendSettings toolSettings, string content)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Content = content;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsAppendSettings.Content"/>.</em></p><p>Content to be appended to the file.</p></summary>
        [Pure]
        public static AzureDlsFsAppendSettings ResetContent(this AzureDlsFsAppendSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Content = null;
            return toolSettings;
        }
        #endregion
        #region Path
        /// <summary><p><em>Sets <see cref="AzureDlsFsAppendSettings.Path"/>.</em></p><p>The path in the specified Data Lake Store account where the action should take place. In the format '/folder/file.txt', where the first '/' after the DNS indicates the root of the file system.</p></summary>
        [Pure]
        public static AzureDlsFsAppendSettings SetPath(this AzureDlsFsAppendSettings toolSettings, string path)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = path;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsAppendSettings.Path"/>.</em></p><p>The path in the specified Data Lake Store account where the action should take place. In the format '/folder/file.txt', where the first '/' after the DNS indicates the root of the file system.</p></summary>
        [Pure]
        public static AzureDlsFsAppendSettings ResetPath(this AzureDlsFsAppendSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlsFsAppendSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsFsAppendSettings SetDebug(this AzureDlsFsAppendSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsAppendSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsFsAppendSettings ResetDebug(this AzureDlsFsAppendSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlsFsAppendSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsFsAppendSettings SetHelp(this AzureDlsFsAppendSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsAppendSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsFsAppendSettings ResetHelp(this AzureDlsFsAppendSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlsFsAppendSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsFsAppendSettings SetOutput(this AzureDlsFsAppendSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsAppendSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsFsAppendSettings ResetOutput(this AzureDlsFsAppendSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlsFsAppendSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsFsAppendSettings SetQuery(this AzureDlsFsAppendSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsAppendSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsFsAppendSettings ResetQuery(this AzureDlsFsAppendSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlsFsAppendSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsFsAppendSettings SetVerbose(this AzureDlsFsAppendSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsAppendSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsFsAppendSettings ResetVerbose(this AzureDlsFsAppendSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlsFsCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlsFsCreateSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlsFsCreateSettings.Account"/>.</em></p><p>Name of the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsFsCreateSettings SetAccount(this AzureDlsFsCreateSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsCreateSettings.Account"/>.</em></p><p>Name of the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsFsCreateSettings ResetAccount(this AzureDlsFsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region Path
        /// <summary><p><em>Sets <see cref="AzureDlsFsCreateSettings.Path"/>.</em></p><p>The path in the specified Data Lake Store account where the action should take place. In the format '/folder/file.txt', where the first '/' after the DNS indicates the root of the file system.</p></summary>
        [Pure]
        public static AzureDlsFsCreateSettings SetPath(this AzureDlsFsCreateSettings toolSettings, string path)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = path;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsCreateSettings.Path"/>.</em></p><p>The path in the specified Data Lake Store account where the action should take place. In the format '/folder/file.txt', where the first '/' after the DNS indicates the root of the file system.</p></summary>
        [Pure]
        public static AzureDlsFsCreateSettings ResetPath(this AzureDlsFsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = null;
            return toolSettings;
        }
        #endregion
        #region Content
        /// <summary><p><em>Sets <see cref="AzureDlsFsCreateSettings.Content"/>.</em></p><p>Content for the file to contain upon creation.</p></summary>
        [Pure]
        public static AzureDlsFsCreateSettings SetContent(this AzureDlsFsCreateSettings toolSettings, string content)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Content = content;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsCreateSettings.Content"/>.</em></p><p>Content for the file to contain upon creation.</p></summary>
        [Pure]
        public static AzureDlsFsCreateSettings ResetContent(this AzureDlsFsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Content = null;
            return toolSettings;
        }
        #endregion
        #region Folder
        /// <summary><p><em>Sets <see cref="AzureDlsFsCreateSettings.Folder"/>.</em></p><p>Indicates that this new item is a folder and not a file.</p></summary>
        [Pure]
        public static AzureDlsFsCreateSettings SetFolder(this AzureDlsFsCreateSettings toolSettings, string folder)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Folder = folder;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsCreateSettings.Folder"/>.</em></p><p>Indicates that this new item is a folder and not a file.</p></summary>
        [Pure]
        public static AzureDlsFsCreateSettings ResetFolder(this AzureDlsFsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Folder = null;
            return toolSettings;
        }
        #endregion
        #region Force
        /// <summary><p><em>Sets <see cref="AzureDlsFsCreateSettings.Force"/>.</em></p><p>Indicates that, if the file or folder exists, it should be overwritten.</p></summary>
        [Pure]
        public static AzureDlsFsCreateSettings SetForce(this AzureDlsFsCreateSettings toolSettings, string force)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Force = force;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsCreateSettings.Force"/>.</em></p><p>Indicates that, if the file or folder exists, it should be overwritten.</p></summary>
        [Pure]
        public static AzureDlsFsCreateSettings ResetForce(this AzureDlsFsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Force = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlsFsCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsFsCreateSettings SetDebug(this AzureDlsFsCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsFsCreateSettings ResetDebug(this AzureDlsFsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlsFsCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsFsCreateSettings SetHelp(this AzureDlsFsCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsFsCreateSettings ResetHelp(this AzureDlsFsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlsFsCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsFsCreateSettings SetOutput(this AzureDlsFsCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsFsCreateSettings ResetOutput(this AzureDlsFsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlsFsCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsFsCreateSettings SetQuery(this AzureDlsFsCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsFsCreateSettings ResetQuery(this AzureDlsFsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlsFsCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsFsCreateSettings SetVerbose(this AzureDlsFsCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsFsCreateSettings ResetVerbose(this AzureDlsFsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlsFsDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlsFsDeleteSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlsFsDeleteSettings.Account"/>.</em></p><p>Name of the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsFsDeleteSettings SetAccount(this AzureDlsFsDeleteSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsDeleteSettings.Account"/>.</em></p><p>Name of the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsFsDeleteSettings ResetAccount(this AzureDlsFsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region Path
        /// <summary><p><em>Sets <see cref="AzureDlsFsDeleteSettings.Path"/>.</em></p><p>The path in the specified Data Lake Store account where the action should take place. In the format '/folder/file.txt', where the first '/' after the DNS indicates the root of the file system.</p></summary>
        [Pure]
        public static AzureDlsFsDeleteSettings SetPath(this AzureDlsFsDeleteSettings toolSettings, string path)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = path;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsDeleteSettings.Path"/>.</em></p><p>The path in the specified Data Lake Store account where the action should take place. In the format '/folder/file.txt', where the first '/' after the DNS indicates the root of the file system.</p></summary>
        [Pure]
        public static AzureDlsFsDeleteSettings ResetPath(this AzureDlsFsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = null;
            return toolSettings;
        }
        #endregion
        #region Recurse
        /// <summary><p><em>Sets <see cref="AzureDlsFsDeleteSettings.Recurse"/>.</em></p><p>Indicates this should be a recursive delete of the folder.</p></summary>
        [Pure]
        public static AzureDlsFsDeleteSettings SetRecurse(this AzureDlsFsDeleteSettings toolSettings, string recurse)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Recurse = recurse;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsDeleteSettings.Recurse"/>.</em></p><p>Indicates this should be a recursive delete of the folder.</p></summary>
        [Pure]
        public static AzureDlsFsDeleteSettings ResetRecurse(this AzureDlsFsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Recurse = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlsFsDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsFsDeleteSettings SetDebug(this AzureDlsFsDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsFsDeleteSettings ResetDebug(this AzureDlsFsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlsFsDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsFsDeleteSettings SetHelp(this AzureDlsFsDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsFsDeleteSettings ResetHelp(this AzureDlsFsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlsFsDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsFsDeleteSettings SetOutput(this AzureDlsFsDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsFsDeleteSettings ResetOutput(this AzureDlsFsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlsFsDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsFsDeleteSettings SetQuery(this AzureDlsFsDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsFsDeleteSettings ResetQuery(this AzureDlsFsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlsFsDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsFsDeleteSettings SetVerbose(this AzureDlsFsDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsFsDeleteSettings ResetVerbose(this AzureDlsFsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlsFsDownloadSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlsFsDownloadSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlsFsDownloadSettings.Account"/>.</em></p><p>Name of the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsFsDownloadSettings SetAccount(this AzureDlsFsDownloadSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsDownloadSettings.Account"/>.</em></p><p>Name of the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsFsDownloadSettings ResetAccount(this AzureDlsFsDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region DestinationPath
        /// <summary><p><em>Sets <see cref="AzureDlsFsDownloadSettings.DestinationPath"/>.</em></p><p>The local path where the file or folder will be downloaded to.</p></summary>
        [Pure]
        public static AzureDlsFsDownloadSettings SetDestinationPath(this AzureDlsFsDownloadSettings toolSettings, string destinationPath)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DestinationPath = destinationPath;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsDownloadSettings.DestinationPath"/>.</em></p><p>The local path where the file or folder will be downloaded to.</p></summary>
        [Pure]
        public static AzureDlsFsDownloadSettings ResetDestinationPath(this AzureDlsFsDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DestinationPath = null;
            return toolSettings;
        }
        #endregion
        #region SourcePath
        /// <summary><p><em>Sets <see cref="AzureDlsFsDownloadSettings.SourcePath"/>.</em></p><p>The full path in the Data Lake Store filesystem to download the file or folder from.</p></summary>
        [Pure]
        public static AzureDlsFsDownloadSettings SetSourcePath(this AzureDlsFsDownloadSettings toolSettings, string sourcePath)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SourcePath = sourcePath;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsDownloadSettings.SourcePath"/>.</em></p><p>The full path in the Data Lake Store filesystem to download the file or folder from.</p></summary>
        [Pure]
        public static AzureDlsFsDownloadSettings ResetSourcePath(this AzureDlsFsDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SourcePath = null;
            return toolSettings;
        }
        #endregion
        #region BlockSize
        /// <summary><p><em>Sets <see cref="AzureDlsFsDownloadSettings.BlockSize"/>.</em></p><p>Size of a block, in bytes.</p></summary>
        [Pure]
        public static AzureDlsFsDownloadSettings SetBlockSize(this AzureDlsFsDownloadSettings toolSettings, string blockSize)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BlockSize = blockSize;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsDownloadSettings.BlockSize"/>.</em></p><p>Size of a block, in bytes.</p></summary>
        [Pure]
        public static AzureDlsFsDownloadSettings ResetBlockSize(this AzureDlsFsDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BlockSize = null;
            return toolSettings;
        }
        #endregion
        #region BufferSize
        /// <summary><p><em>Sets <see cref="AzureDlsFsDownloadSettings.BufferSize"/>.</em></p><p>Size of the transfer buffer, in bytes.</p></summary>
        [Pure]
        public static AzureDlsFsDownloadSettings SetBufferSize(this AzureDlsFsDownloadSettings toolSettings, string bufferSize)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BufferSize = bufferSize;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsDownloadSettings.BufferSize"/>.</em></p><p>Size of the transfer buffer, in bytes.</p></summary>
        [Pure]
        public static AzureDlsFsDownloadSettings ResetBufferSize(this AzureDlsFsDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BufferSize = null;
            return toolSettings;
        }
        #endregion
        #region ChunkSize
        /// <summary><p><em>Sets <see cref="AzureDlsFsDownloadSettings.ChunkSize"/>.</em></p><p>Size of a chunk, in bytes.</p></summary>
        [Pure]
        public static AzureDlsFsDownloadSettings SetChunkSize(this AzureDlsFsDownloadSettings toolSettings, string chunkSize)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ChunkSize = chunkSize;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsDownloadSettings.ChunkSize"/>.</em></p><p>Size of a chunk, in bytes.</p></summary>
        [Pure]
        public static AzureDlsFsDownloadSettings ResetChunkSize(this AzureDlsFsDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ChunkSize = null;
            return toolSettings;
        }
        #endregion
        #region Overwrite
        /// <summary><p><em>Sets <see cref="AzureDlsFsDownloadSettings.Overwrite"/>.</em></p><p>Indicates that, if the destination file or folder exists, it should be overwritten.</p></summary>
        [Pure]
        public static AzureDlsFsDownloadSettings SetOverwrite(this AzureDlsFsDownloadSettings toolSettings, string overwrite)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Overwrite = overwrite;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsDownloadSettings.Overwrite"/>.</em></p><p>Indicates that, if the destination file or folder exists, it should be overwritten.</p></summary>
        [Pure]
        public static AzureDlsFsDownloadSettings ResetOverwrite(this AzureDlsFsDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Overwrite = null;
            return toolSettings;
        }
        #endregion
        #region ProgressCallback
        /// <summary><p><em>Sets <see cref="AzureDlsFsDownloadSettings.ProgressCallback"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureDlsFsDownloadSettings SetProgressCallback(this AzureDlsFsDownloadSettings toolSettings, string progressCallback)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProgressCallback = progressCallback;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsDownloadSettings.ProgressCallback"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureDlsFsDownloadSettings ResetProgressCallback(this AzureDlsFsDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProgressCallback = null;
            return toolSettings;
        }
        #endregion
        #region ThreadCount
        /// <summary><p><em>Sets <see cref="AzureDlsFsDownloadSettings.ThreadCount"/>.</em></p><p>Parallelism of the download. Default: The number of cores in the local machine.</p></summary>
        [Pure]
        public static AzureDlsFsDownloadSettings SetThreadCount(this AzureDlsFsDownloadSettings toolSettings, string threadCount)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ThreadCount = threadCount;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsDownloadSettings.ThreadCount"/>.</em></p><p>Parallelism of the download. Default: The number of cores in the local machine.</p></summary>
        [Pure]
        public static AzureDlsFsDownloadSettings ResetThreadCount(this AzureDlsFsDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ThreadCount = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlsFsDownloadSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsFsDownloadSettings SetDebug(this AzureDlsFsDownloadSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsDownloadSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsFsDownloadSettings ResetDebug(this AzureDlsFsDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlsFsDownloadSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsFsDownloadSettings SetHelp(this AzureDlsFsDownloadSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsDownloadSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsFsDownloadSettings ResetHelp(this AzureDlsFsDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlsFsDownloadSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsFsDownloadSettings SetOutput(this AzureDlsFsDownloadSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsDownloadSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsFsDownloadSettings ResetOutput(this AzureDlsFsDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlsFsDownloadSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsFsDownloadSettings SetQuery(this AzureDlsFsDownloadSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsDownloadSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsFsDownloadSettings ResetQuery(this AzureDlsFsDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlsFsDownloadSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsFsDownloadSettings SetVerbose(this AzureDlsFsDownloadSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsDownloadSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsFsDownloadSettings ResetVerbose(this AzureDlsFsDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlsFsJoinSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlsFsJoinSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlsFsJoinSettings.Account"/>.</em></p><p>Name of the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsFsJoinSettings SetAccount(this AzureDlsFsJoinSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsJoinSettings.Account"/>.</em></p><p>Name of the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsFsJoinSettings ResetAccount(this AzureDlsFsJoinSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region DestinationPath
        /// <summary><p><em>Sets <see cref="AzureDlsFsJoinSettings.DestinationPath"/>.</em></p><p>The destination path in the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsFsJoinSettings SetDestinationPath(this AzureDlsFsJoinSettings toolSettings, string destinationPath)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DestinationPath = destinationPath;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsJoinSettings.DestinationPath"/>.</em></p><p>The destination path in the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsFsJoinSettings ResetDestinationPath(this AzureDlsFsJoinSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DestinationPath = null;
            return toolSettings;
        }
        #endregion
        #region SourcePaths
        /// <summary><p><em>Sets <see cref="AzureDlsFsJoinSettings.SourcePaths"/>.</em></p><p>The space-separated list of files in the Data Lake Store account to join.</p></summary>
        [Pure]
        public static AzureDlsFsJoinSettings SetSourcePaths(this AzureDlsFsJoinSettings toolSettings, string sourcePaths)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SourcePaths = sourcePaths;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsJoinSettings.SourcePaths"/>.</em></p><p>The space-separated list of files in the Data Lake Store account to join.</p></summary>
        [Pure]
        public static AzureDlsFsJoinSettings ResetSourcePaths(this AzureDlsFsJoinSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SourcePaths = null;
            return toolSettings;
        }
        #endregion
        #region Force
        /// <summary><p><em>Sets <see cref="AzureDlsFsJoinSettings.Force"/>.</em></p><p>Indicates that, if the destination file already exists, it should be overwritten.</p></summary>
        [Pure]
        public static AzureDlsFsJoinSettings SetForce(this AzureDlsFsJoinSettings toolSettings, string force)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Force = force;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsJoinSettings.Force"/>.</em></p><p>Indicates that, if the destination file already exists, it should be overwritten.</p></summary>
        [Pure]
        public static AzureDlsFsJoinSettings ResetForce(this AzureDlsFsJoinSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Force = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlsFsJoinSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsFsJoinSettings SetDebug(this AzureDlsFsJoinSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsJoinSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsFsJoinSettings ResetDebug(this AzureDlsFsJoinSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlsFsJoinSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsFsJoinSettings SetHelp(this AzureDlsFsJoinSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsJoinSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsFsJoinSettings ResetHelp(this AzureDlsFsJoinSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlsFsJoinSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsFsJoinSettings SetOutput(this AzureDlsFsJoinSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsJoinSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsFsJoinSettings ResetOutput(this AzureDlsFsJoinSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlsFsJoinSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsFsJoinSettings SetQuery(this AzureDlsFsJoinSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsJoinSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsFsJoinSettings ResetQuery(this AzureDlsFsJoinSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlsFsJoinSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsFsJoinSettings SetVerbose(this AzureDlsFsJoinSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsJoinSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsFsJoinSettings ResetVerbose(this AzureDlsFsJoinSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlsFsListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlsFsListSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlsFsListSettings.Account"/>.</em></p><p>Name of the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsFsListSettings SetAccount(this AzureDlsFsListSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsListSettings.Account"/>.</em></p><p>Name of the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsFsListSettings ResetAccount(this AzureDlsFsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region Path
        /// <summary><p><em>Sets <see cref="AzureDlsFsListSettings.Path"/>.</em></p><p>The path in the specified Data Lake Store account where the action should take place. In the format '/folder/file.txt', where the first '/' after the DNS indicates the root of the file system.</p></summary>
        [Pure]
        public static AzureDlsFsListSettings SetPath(this AzureDlsFsListSettings toolSettings, string path)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = path;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsListSettings.Path"/>.</em></p><p>The path in the specified Data Lake Store account where the action should take place. In the format '/folder/file.txt', where the first '/' after the DNS indicates the root of the file system.</p></summary>
        [Pure]
        public static AzureDlsFsListSettings ResetPath(this AzureDlsFsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlsFsListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsFsListSettings SetDebug(this AzureDlsFsListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsFsListSettings ResetDebug(this AzureDlsFsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlsFsListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsFsListSettings SetHelp(this AzureDlsFsListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsFsListSettings ResetHelp(this AzureDlsFsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlsFsListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsFsListSettings SetOutput(this AzureDlsFsListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsFsListSettings ResetOutput(this AzureDlsFsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlsFsListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsFsListSettings SetQuery(this AzureDlsFsListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsFsListSettings ResetQuery(this AzureDlsFsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlsFsListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsFsListSettings SetVerbose(this AzureDlsFsListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsFsListSettings ResetVerbose(this AzureDlsFsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlsFsMoveSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlsFsMoveSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlsFsMoveSettings.Account"/>.</em></p><p>Name of the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsFsMoveSettings SetAccount(this AzureDlsFsMoveSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsMoveSettings.Account"/>.</em></p><p>Name of the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsFsMoveSettings ResetAccount(this AzureDlsFsMoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region DestinationPath
        /// <summary><p><em>Sets <see cref="AzureDlsFsMoveSettings.DestinationPath"/>.</em></p><p>The destination path in the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsFsMoveSettings SetDestinationPath(this AzureDlsFsMoveSettings toolSettings, string destinationPath)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DestinationPath = destinationPath;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsMoveSettings.DestinationPath"/>.</em></p><p>The destination path in the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsFsMoveSettings ResetDestinationPath(this AzureDlsFsMoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DestinationPath = null;
            return toolSettings;
        }
        #endregion
        #region SourcePath
        /// <summary><p><em>Sets <see cref="AzureDlsFsMoveSettings.SourcePath"/>.</em></p><p>The file or folder to move.</p></summary>
        [Pure]
        public static AzureDlsFsMoveSettings SetSourcePath(this AzureDlsFsMoveSettings toolSettings, string sourcePath)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SourcePath = sourcePath;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsMoveSettings.SourcePath"/>.</em></p><p>The file or folder to move.</p></summary>
        [Pure]
        public static AzureDlsFsMoveSettings ResetSourcePath(this AzureDlsFsMoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SourcePath = null;
            return toolSettings;
        }
        #endregion
        #region Force
        /// <summary><p><em>Sets <see cref="AzureDlsFsMoveSettings.Force"/>.</em></p><p>Indicates that, if the destination file or folder already exists, it should be overwritten and replaced with the file or folder being moved.</p></summary>
        [Pure]
        public static AzureDlsFsMoveSettings SetForce(this AzureDlsFsMoveSettings toolSettings, string force)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Force = force;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsMoveSettings.Force"/>.</em></p><p>Indicates that, if the destination file or folder already exists, it should be overwritten and replaced with the file or folder being moved.</p></summary>
        [Pure]
        public static AzureDlsFsMoveSettings ResetForce(this AzureDlsFsMoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Force = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlsFsMoveSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsFsMoveSettings SetDebug(this AzureDlsFsMoveSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsMoveSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsFsMoveSettings ResetDebug(this AzureDlsFsMoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlsFsMoveSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsFsMoveSettings SetHelp(this AzureDlsFsMoveSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsMoveSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsFsMoveSettings ResetHelp(this AzureDlsFsMoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlsFsMoveSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsFsMoveSettings SetOutput(this AzureDlsFsMoveSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsMoveSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsFsMoveSettings ResetOutput(this AzureDlsFsMoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlsFsMoveSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsFsMoveSettings SetQuery(this AzureDlsFsMoveSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsMoveSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsFsMoveSettings ResetQuery(this AzureDlsFsMoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlsFsMoveSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsFsMoveSettings SetVerbose(this AzureDlsFsMoveSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsMoveSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsFsMoveSettings ResetVerbose(this AzureDlsFsMoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlsFsPreviewSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlsFsPreviewSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlsFsPreviewSettings.Account"/>.</em></p><p>Name of the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsFsPreviewSettings SetAccount(this AzureDlsFsPreviewSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsPreviewSettings.Account"/>.</em></p><p>Name of the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsFsPreviewSettings ResetAccount(this AzureDlsFsPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region Path
        /// <summary><p><em>Sets <see cref="AzureDlsFsPreviewSettings.Path"/>.</em></p><p>The path in the specified Data Lake Store account where the action should take place. In the format '/folder/file.txt', where the first '/' after the DNS indicates the root of the file system.</p></summary>
        [Pure]
        public static AzureDlsFsPreviewSettings SetPath(this AzureDlsFsPreviewSettings toolSettings, string path)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = path;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsPreviewSettings.Path"/>.</em></p><p>The path in the specified Data Lake Store account where the action should take place. In the format '/folder/file.txt', where the first '/' after the DNS indicates the root of the file system.</p></summary>
        [Pure]
        public static AzureDlsFsPreviewSettings ResetPath(this AzureDlsFsPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = null;
            return toolSettings;
        }
        #endregion
        #region Force
        /// <summary><p><em>Sets <see cref="AzureDlsFsPreviewSettings.Force"/>.</em></p><p>Indicates that, if the preview is larger than 1MB, still retrieve it. This can potentially be very slow, depending on how large the file is.</p></summary>
        [Pure]
        public static AzureDlsFsPreviewSettings SetForce(this AzureDlsFsPreviewSettings toolSettings, string force)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Force = force;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsPreviewSettings.Force"/>.</em></p><p>Indicates that, if the preview is larger than 1MB, still retrieve it. This can potentially be very slow, depending on how large the file is.</p></summary>
        [Pure]
        public static AzureDlsFsPreviewSettings ResetForce(this AzureDlsFsPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Force = null;
            return toolSettings;
        }
        #endregion
        #region Length
        /// <summary><p><em>Sets <see cref="AzureDlsFsPreviewSettings.Length"/>.</em></p><p>The amount of data to preview in bytes.</p></summary>
        [Pure]
        public static AzureDlsFsPreviewSettings SetLength(this AzureDlsFsPreviewSettings toolSettings, string length)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Length = length;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsPreviewSettings.Length"/>.</em></p><p>The amount of data to preview in bytes.</p></summary>
        [Pure]
        public static AzureDlsFsPreviewSettings ResetLength(this AzureDlsFsPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Length = null;
            return toolSettings;
        }
        #endregion
        #region Offset
        /// <summary><p><em>Sets <see cref="AzureDlsFsPreviewSettings.Offset"/>.</em></p><p>The position in bytes to start the preview from.</p></summary>
        [Pure]
        public static AzureDlsFsPreviewSettings SetOffset(this AzureDlsFsPreviewSettings toolSettings, string offset)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Offset = offset;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsPreviewSettings.Offset"/>.</em></p><p>The position in bytes to start the preview from.</p></summary>
        [Pure]
        public static AzureDlsFsPreviewSettings ResetOffset(this AzureDlsFsPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Offset = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlsFsPreviewSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsFsPreviewSettings SetDebug(this AzureDlsFsPreviewSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsPreviewSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsFsPreviewSettings ResetDebug(this AzureDlsFsPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlsFsPreviewSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsFsPreviewSettings SetHelp(this AzureDlsFsPreviewSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsPreviewSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsFsPreviewSettings ResetHelp(this AzureDlsFsPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlsFsPreviewSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsFsPreviewSettings SetOutput(this AzureDlsFsPreviewSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsPreviewSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsFsPreviewSettings ResetOutput(this AzureDlsFsPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlsFsPreviewSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsFsPreviewSettings SetQuery(this AzureDlsFsPreviewSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsPreviewSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsFsPreviewSettings ResetQuery(this AzureDlsFsPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlsFsPreviewSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsFsPreviewSettings SetVerbose(this AzureDlsFsPreviewSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsPreviewSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsFsPreviewSettings ResetVerbose(this AzureDlsFsPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlsFsRemoveExpirySettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlsFsRemoveExpirySettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlsFsRemoveExpirySettings.Account"/>.</em></p><p>Name of the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsFsRemoveExpirySettings SetAccount(this AzureDlsFsRemoveExpirySettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsRemoveExpirySettings.Account"/>.</em></p><p>Name of the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsFsRemoveExpirySettings ResetAccount(this AzureDlsFsRemoveExpirySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region Path
        /// <summary><p><em>Sets <see cref="AzureDlsFsRemoveExpirySettings.Path"/>.</em></p><p>The path in the specified Data Lake Store account where the action should take place. In the format '/folder/file.txt', where the first '/' after the DNS indicates the root of the file system.</p></summary>
        [Pure]
        public static AzureDlsFsRemoveExpirySettings SetPath(this AzureDlsFsRemoveExpirySettings toolSettings, string path)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = path;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsRemoveExpirySettings.Path"/>.</em></p><p>The path in the specified Data Lake Store account where the action should take place. In the format '/folder/file.txt', where the first '/' after the DNS indicates the root of the file system.</p></summary>
        [Pure]
        public static AzureDlsFsRemoveExpirySettings ResetPath(this AzureDlsFsRemoveExpirySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlsFsRemoveExpirySettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsFsRemoveExpirySettings SetDebug(this AzureDlsFsRemoveExpirySettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsRemoveExpirySettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsFsRemoveExpirySettings ResetDebug(this AzureDlsFsRemoveExpirySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlsFsRemoveExpirySettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsFsRemoveExpirySettings SetHelp(this AzureDlsFsRemoveExpirySettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsRemoveExpirySettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsFsRemoveExpirySettings ResetHelp(this AzureDlsFsRemoveExpirySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlsFsRemoveExpirySettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsFsRemoveExpirySettings SetOutput(this AzureDlsFsRemoveExpirySettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsRemoveExpirySettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsFsRemoveExpirySettings ResetOutput(this AzureDlsFsRemoveExpirySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlsFsRemoveExpirySettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsFsRemoveExpirySettings SetQuery(this AzureDlsFsRemoveExpirySettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsRemoveExpirySettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsFsRemoveExpirySettings ResetQuery(this AzureDlsFsRemoveExpirySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlsFsRemoveExpirySettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsFsRemoveExpirySettings SetVerbose(this AzureDlsFsRemoveExpirySettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsRemoveExpirySettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsFsRemoveExpirySettings ResetVerbose(this AzureDlsFsRemoveExpirySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlsFsSetExpirySettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlsFsSetExpirySettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlsFsSetExpirySettings.Account"/>.</em></p><p>Name of the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsFsSetExpirySettings SetAccount(this AzureDlsFsSetExpirySettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsSetExpirySettings.Account"/>.</em></p><p>Name of the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsFsSetExpirySettings ResetAccount(this AzureDlsFsSetExpirySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region ExpirationTime
        /// <summary><p><em>Sets <see cref="AzureDlsFsSetExpirySettings.ExpirationTime"/>.</em></p><p>The absolute value of the expiration time expressed as milliseconds since the epoch.</p></summary>
        [Pure]
        public static AzureDlsFsSetExpirySettings SetExpirationTime(this AzureDlsFsSetExpirySettings toolSettings, string expirationTime)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ExpirationTime = expirationTime;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsSetExpirySettings.ExpirationTime"/>.</em></p><p>The absolute value of the expiration time expressed as milliseconds since the epoch.</p></summary>
        [Pure]
        public static AzureDlsFsSetExpirySettings ResetExpirationTime(this AzureDlsFsSetExpirySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ExpirationTime = null;
            return toolSettings;
        }
        #endregion
        #region Path
        /// <summary><p><em>Sets <see cref="AzureDlsFsSetExpirySettings.Path"/>.</em></p><p>The path in the specified Data Lake Store account where the action should take place. In the format '/folder/file.txt', where the first '/' after the DNS indicates the root of the file system.</p></summary>
        [Pure]
        public static AzureDlsFsSetExpirySettings SetPath(this AzureDlsFsSetExpirySettings toolSettings, string path)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = path;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsSetExpirySettings.Path"/>.</em></p><p>The path in the specified Data Lake Store account where the action should take place. In the format '/folder/file.txt', where the first '/' after the DNS indicates the root of the file system.</p></summary>
        [Pure]
        public static AzureDlsFsSetExpirySettings ResetPath(this AzureDlsFsSetExpirySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlsFsSetExpirySettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsFsSetExpirySettings SetDebug(this AzureDlsFsSetExpirySettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsSetExpirySettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsFsSetExpirySettings ResetDebug(this AzureDlsFsSetExpirySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlsFsSetExpirySettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsFsSetExpirySettings SetHelp(this AzureDlsFsSetExpirySettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsSetExpirySettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsFsSetExpirySettings ResetHelp(this AzureDlsFsSetExpirySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlsFsSetExpirySettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsFsSetExpirySettings SetOutput(this AzureDlsFsSetExpirySettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsSetExpirySettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsFsSetExpirySettings ResetOutput(this AzureDlsFsSetExpirySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlsFsSetExpirySettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsFsSetExpirySettings SetQuery(this AzureDlsFsSetExpirySettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsSetExpirySettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsFsSetExpirySettings ResetQuery(this AzureDlsFsSetExpirySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlsFsSetExpirySettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsFsSetExpirySettings SetVerbose(this AzureDlsFsSetExpirySettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsSetExpirySettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsFsSetExpirySettings ResetVerbose(this AzureDlsFsSetExpirySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlsFsShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlsFsShowSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlsFsShowSettings.Account"/>.</em></p><p>Name of the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsFsShowSettings SetAccount(this AzureDlsFsShowSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsShowSettings.Account"/>.</em></p><p>Name of the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsFsShowSettings ResetAccount(this AzureDlsFsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region Path
        /// <summary><p><em>Sets <see cref="AzureDlsFsShowSettings.Path"/>.</em></p><p>The path in the specified Data Lake Store account where the action should take place. In the format '/folder/file.txt', where the first '/' after the DNS indicates the root of the file system.</p></summary>
        [Pure]
        public static AzureDlsFsShowSettings SetPath(this AzureDlsFsShowSettings toolSettings, string path)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = path;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsShowSettings.Path"/>.</em></p><p>The path in the specified Data Lake Store account where the action should take place. In the format '/folder/file.txt', where the first '/' after the DNS indicates the root of the file system.</p></summary>
        [Pure]
        public static AzureDlsFsShowSettings ResetPath(this AzureDlsFsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlsFsShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsFsShowSettings SetDebug(this AzureDlsFsShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsFsShowSettings ResetDebug(this AzureDlsFsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlsFsShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsFsShowSettings SetHelp(this AzureDlsFsShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsFsShowSettings ResetHelp(this AzureDlsFsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlsFsShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsFsShowSettings SetOutput(this AzureDlsFsShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsFsShowSettings ResetOutput(this AzureDlsFsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlsFsShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsFsShowSettings SetQuery(this AzureDlsFsShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsFsShowSettings ResetQuery(this AzureDlsFsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlsFsShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsFsShowSettings SetVerbose(this AzureDlsFsShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsFsShowSettings ResetVerbose(this AzureDlsFsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlsFsTestSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlsFsTestSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlsFsTestSettings.Account"/>.</em></p><p>Name of the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsFsTestSettings SetAccount(this AzureDlsFsTestSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsTestSettings.Account"/>.</em></p><p>Name of the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsFsTestSettings ResetAccount(this AzureDlsFsTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region Path
        /// <summary><p><em>Sets <see cref="AzureDlsFsTestSettings.Path"/>.</em></p><p>The path in the specified Data Lake Store account where the action should take place. In the format '/folder/file.txt', where the first '/' after the DNS indicates the root of the file system.</p></summary>
        [Pure]
        public static AzureDlsFsTestSettings SetPath(this AzureDlsFsTestSettings toolSettings, string path)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = path;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsTestSettings.Path"/>.</em></p><p>The path in the specified Data Lake Store account where the action should take place. In the format '/folder/file.txt', where the first '/' after the DNS indicates the root of the file system.</p></summary>
        [Pure]
        public static AzureDlsFsTestSettings ResetPath(this AzureDlsFsTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlsFsTestSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsFsTestSettings SetDebug(this AzureDlsFsTestSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsTestSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsFsTestSettings ResetDebug(this AzureDlsFsTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlsFsTestSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsFsTestSettings SetHelp(this AzureDlsFsTestSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsTestSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsFsTestSettings ResetHelp(this AzureDlsFsTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlsFsTestSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsFsTestSettings SetOutput(this AzureDlsFsTestSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsTestSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsFsTestSettings ResetOutput(this AzureDlsFsTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlsFsTestSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsFsTestSettings SetQuery(this AzureDlsFsTestSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsTestSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsFsTestSettings ResetQuery(this AzureDlsFsTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlsFsTestSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsFsTestSettings SetVerbose(this AzureDlsFsTestSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsTestSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsFsTestSettings ResetVerbose(this AzureDlsFsTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlsFsUploadSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlsFsUploadSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlsFsUploadSettings.Account"/>.</em></p><p>Name of the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsFsUploadSettings SetAccount(this AzureDlsFsUploadSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsUploadSettings.Account"/>.</em></p><p>Name of the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsFsUploadSettings ResetAccount(this AzureDlsFsUploadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region DestinationPath
        /// <summary><p><em>Sets <see cref="AzureDlsFsUploadSettings.DestinationPath"/>.</em></p><p>The full path in the Data Lake Store filesystem to upload the file or folder to.</p></summary>
        [Pure]
        public static AzureDlsFsUploadSettings SetDestinationPath(this AzureDlsFsUploadSettings toolSettings, string destinationPath)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DestinationPath = destinationPath;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsUploadSettings.DestinationPath"/>.</em></p><p>The full path in the Data Lake Store filesystem to upload the file or folder to.</p></summary>
        [Pure]
        public static AzureDlsFsUploadSettings ResetDestinationPath(this AzureDlsFsUploadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DestinationPath = null;
            return toolSettings;
        }
        #endregion
        #region SourcePath
        /// <summary><p><em>Sets <see cref="AzureDlsFsUploadSettings.SourcePath"/>.</em></p><p>The path to the file or folder to upload.</p></summary>
        [Pure]
        public static AzureDlsFsUploadSettings SetSourcePath(this AzureDlsFsUploadSettings toolSettings, string sourcePath)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SourcePath = sourcePath;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsUploadSettings.SourcePath"/>.</em></p><p>The path to the file or folder to upload.</p></summary>
        [Pure]
        public static AzureDlsFsUploadSettings ResetSourcePath(this AzureDlsFsUploadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SourcePath = null;
            return toolSettings;
        }
        #endregion
        #region BlockSize
        /// <summary><p><em>Sets <see cref="AzureDlsFsUploadSettings.BlockSize"/>.</em></p><p>Size of a block, in bytes.</p></summary>
        [Pure]
        public static AzureDlsFsUploadSettings SetBlockSize(this AzureDlsFsUploadSettings toolSettings, string blockSize)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BlockSize = blockSize;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsUploadSettings.BlockSize"/>.</em></p><p>Size of a block, in bytes.</p></summary>
        [Pure]
        public static AzureDlsFsUploadSettings ResetBlockSize(this AzureDlsFsUploadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BlockSize = null;
            return toolSettings;
        }
        #endregion
        #region BufferSize
        /// <summary><p><em>Sets <see cref="AzureDlsFsUploadSettings.BufferSize"/>.</em></p><p>Size of the transfer buffer, in bytes.</p></summary>
        [Pure]
        public static AzureDlsFsUploadSettings SetBufferSize(this AzureDlsFsUploadSettings toolSettings, string bufferSize)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BufferSize = bufferSize;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsUploadSettings.BufferSize"/>.</em></p><p>Size of the transfer buffer, in bytes.</p></summary>
        [Pure]
        public static AzureDlsFsUploadSettings ResetBufferSize(this AzureDlsFsUploadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BufferSize = null;
            return toolSettings;
        }
        #endregion
        #region ChunkSize
        /// <summary><p><em>Sets <see cref="AzureDlsFsUploadSettings.ChunkSize"/>.</em></p><p>Size of a chunk, in bytes.</p></summary>
        [Pure]
        public static AzureDlsFsUploadSettings SetChunkSize(this AzureDlsFsUploadSettings toolSettings, string chunkSize)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ChunkSize = chunkSize;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsUploadSettings.ChunkSize"/>.</em></p><p>Size of a chunk, in bytes.</p></summary>
        [Pure]
        public static AzureDlsFsUploadSettings ResetChunkSize(this AzureDlsFsUploadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ChunkSize = null;
            return toolSettings;
        }
        #endregion
        #region Overwrite
        /// <summary><p><em>Sets <see cref="AzureDlsFsUploadSettings.Overwrite"/>.</em></p><p>Indicates that, if the destination file or folder exists, it should be overwritten.</p></summary>
        [Pure]
        public static AzureDlsFsUploadSettings SetOverwrite(this AzureDlsFsUploadSettings toolSettings, string overwrite)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Overwrite = overwrite;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsUploadSettings.Overwrite"/>.</em></p><p>Indicates that, if the destination file or folder exists, it should be overwritten.</p></summary>
        [Pure]
        public static AzureDlsFsUploadSettings ResetOverwrite(this AzureDlsFsUploadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Overwrite = null;
            return toolSettings;
        }
        #endregion
        #region ProgressCallback
        /// <summary><p><em>Sets <see cref="AzureDlsFsUploadSettings.ProgressCallback"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureDlsFsUploadSettings SetProgressCallback(this AzureDlsFsUploadSettings toolSettings, string progressCallback)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProgressCallback = progressCallback;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsUploadSettings.ProgressCallback"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureDlsFsUploadSettings ResetProgressCallback(this AzureDlsFsUploadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProgressCallback = null;
            return toolSettings;
        }
        #endregion
        #region ThreadCount
        /// <summary><p><em>Sets <see cref="AzureDlsFsUploadSettings.ThreadCount"/>.</em></p><p>Parallelism of the upload. Default: The number of cores in the local machine.</p></summary>
        [Pure]
        public static AzureDlsFsUploadSettings SetThreadCount(this AzureDlsFsUploadSettings toolSettings, string threadCount)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ThreadCount = threadCount;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsUploadSettings.ThreadCount"/>.</em></p><p>Parallelism of the upload. Default: The number of cores in the local machine.</p></summary>
        [Pure]
        public static AzureDlsFsUploadSettings ResetThreadCount(this AzureDlsFsUploadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ThreadCount = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlsFsUploadSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsFsUploadSettings SetDebug(this AzureDlsFsUploadSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsUploadSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsFsUploadSettings ResetDebug(this AzureDlsFsUploadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlsFsUploadSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsFsUploadSettings SetHelp(this AzureDlsFsUploadSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsUploadSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsFsUploadSettings ResetHelp(this AzureDlsFsUploadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlsFsUploadSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsFsUploadSettings SetOutput(this AzureDlsFsUploadSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsUploadSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsFsUploadSettings ResetOutput(this AzureDlsFsUploadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlsFsUploadSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsFsUploadSettings SetQuery(this AzureDlsFsUploadSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsUploadSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsFsUploadSettings ResetQuery(this AzureDlsFsUploadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlsFsUploadSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsFsUploadSettings SetVerbose(this AzureDlsFsUploadSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsUploadSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsFsUploadSettings ResetVerbose(this AzureDlsFsUploadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlsAccountCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlsAccountCreateSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlsAccountCreateSettings.Account"/>.</em></p><p>Name of the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsAccountCreateSettings SetAccount(this AzureDlsAccountCreateSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountCreateSettings.Account"/>.</em></p><p>Name of the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsAccountCreateSettings ResetAccount(this AzureDlsAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region DefaultGroup
        /// <summary><p><em>Sets <see cref="AzureDlsAccountCreateSettings.DefaultGroup"/>.</em></p><p>Name of the default group to give permissions to for freshly created files and folders in the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsAccountCreateSettings SetDefaultGroup(this AzureDlsAccountCreateSettings toolSettings, string defaultGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DefaultGroup = defaultGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountCreateSettings.DefaultGroup"/>.</em></p><p>Name of the default group to give permissions to for freshly created files and folders in the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsAccountCreateSettings ResetDefaultGroup(this AzureDlsAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DefaultGroup = null;
            return toolSettings;
        }
        #endregion
        #region DisableEncryption
        /// <summary><p><em>Sets <see cref="AzureDlsAccountCreateSettings.DisableEncryption"/>.</em></p><p>Indicates that the account will not have any form of encryption applied to it.</p></summary>
        [Pure]
        public static AzureDlsAccountCreateSettings SetDisableEncryption(this AzureDlsAccountCreateSettings toolSettings, string disableEncryption)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableEncryption = disableEncryption;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountCreateSettings.DisableEncryption"/>.</em></p><p>Indicates that the account will not have any form of encryption applied to it.</p></summary>
        [Pure]
        public static AzureDlsAccountCreateSettings ResetDisableEncryption(this AzureDlsAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableEncryption = null;
            return toolSettings;
        }
        #endregion
        #region EncryptionType
        /// <summary><p><em>Sets <see cref="AzureDlsAccountCreateSettings.EncryptionType"/>.</em></p><p>Indicates what type of encryption to provision the account with. By default, encryption is ServiceManaged. If no encryption is desired, it must be explicitly set with the --disable-encryption flag.</p></summary>
        [Pure]
        public static AzureDlsAccountCreateSettings SetEncryptionType(this AzureDlsAccountCreateSettings toolSettings, DlsAccountCreateEncryptionType encryptionType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EncryptionType = encryptionType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountCreateSettings.EncryptionType"/>.</em></p><p>Indicates what type of encryption to provision the account with. By default, encryption is ServiceManaged. If no encryption is desired, it must be explicitly set with the --disable-encryption flag.</p></summary>
        [Pure]
        public static AzureDlsAccountCreateSettings ResetEncryptionType(this AzureDlsAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EncryptionType = null;
            return toolSettings;
        }
        #endregion
        #region KeyName
        /// <summary><p><em>Sets <see cref="AzureDlsAccountCreateSettings.KeyName"/>.</em></p><p>Key name for the user-assigned encryption type.</p></summary>
        [Pure]
        public static AzureDlsAccountCreateSettings SetKeyName(this AzureDlsAccountCreateSettings toolSettings, string keyName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyName = keyName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountCreateSettings.KeyName"/>.</em></p><p>Key name for the user-assigned encryption type.</p></summary>
        [Pure]
        public static AzureDlsAccountCreateSettings ResetKeyName(this AzureDlsAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyName = null;
            return toolSettings;
        }
        #endregion
        #region KeyVaultId
        /// <summary><p><em>Sets <see cref="AzureDlsAccountCreateSettings.KeyVaultId"/>.</em></p><p>Key vault for the user-assigned encryption type.</p></summary>
        [Pure]
        public static AzureDlsAccountCreateSettings SetKeyVaultId(this AzureDlsAccountCreateSettings toolSettings, string keyVaultId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyVaultId = keyVaultId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountCreateSettings.KeyVaultId"/>.</em></p><p>Key vault for the user-assigned encryption type.</p></summary>
        [Pure]
        public static AzureDlsAccountCreateSettings ResetKeyVaultId(this AzureDlsAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyVaultId = null;
            return toolSettings;
        }
        #endregion
        #region KeyVersion
        /// <summary><p><em>Sets <see cref="AzureDlsAccountCreateSettings.KeyVersion"/>.</em></p><p>Key version for the user-assigned encryption type.</p></summary>
        [Pure]
        public static AzureDlsAccountCreateSettings SetKeyVersion(this AzureDlsAccountCreateSettings toolSettings, string keyVersion)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyVersion = keyVersion;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountCreateSettings.KeyVersion"/>.</em></p><p>Key version for the user-assigned encryption type.</p></summary>
        [Pure]
        public static AzureDlsAccountCreateSettings ResetKeyVersion(this AzureDlsAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyVersion = null;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary><p><em>Sets <see cref="AzureDlsAccountCreateSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureDlsAccountCreateSettings SetLocation(this AzureDlsAccountCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountCreateSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureDlsAccountCreateSettings ResetLocation(this AzureDlsAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureDlsAccountCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureDlsAccountCreateSettings SetResourceGroup(this AzureDlsAccountCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureDlsAccountCreateSettings ResetResourceGroup(this AzureDlsAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary><p><em>Sets <see cref="AzureDlsAccountCreateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureDlsAccountCreateSettings SetTags(this AzureDlsAccountCreateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountCreateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureDlsAccountCreateSettings ResetTags(this AzureDlsAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Tier
        /// <summary><p><em>Sets <see cref="AzureDlsAccountCreateSettings.Tier"/>.</em></p><p>The desired commitment tier for this account to use.</p></summary>
        [Pure]
        public static AzureDlsAccountCreateSettings SetTier(this AzureDlsAccountCreateSettings toolSettings, DlsAccountTier tier)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tier = tier;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountCreateSettings.Tier"/>.</em></p><p>The desired commitment tier for this account to use.</p></summary>
        [Pure]
        public static AzureDlsAccountCreateSettings ResetTier(this AzureDlsAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tier = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlsAccountCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountCreateSettings SetDebug(this AzureDlsAccountCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountCreateSettings ResetDebug(this AzureDlsAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlsAccountCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsAccountCreateSettings SetHelp(this AzureDlsAccountCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsAccountCreateSettings ResetHelp(this AzureDlsAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlsAccountCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsAccountCreateSettings SetOutput(this AzureDlsAccountCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsAccountCreateSettings ResetOutput(this AzureDlsAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlsAccountCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsAccountCreateSettings SetQuery(this AzureDlsAccountCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsAccountCreateSettings ResetQuery(this AzureDlsAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlsAccountCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountCreateSettings SetVerbose(this AzureDlsAccountCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountCreateSettings ResetVerbose(this AzureDlsAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlsAccountDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlsAccountDeleteSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlsAccountDeleteSettings.Account"/>.</em></p><p>Name of the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsAccountDeleteSettings SetAccount(this AzureDlsAccountDeleteSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountDeleteSettings.Account"/>.</em></p><p>Name of the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsAccountDeleteSettings ResetAccount(this AzureDlsAccountDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureDlsAccountDeleteSettings.ResourceGroup"/>.</em></p><p>If not specified, will attempt to discover the resource group for the specified Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsAccountDeleteSettings SetResourceGroup(this AzureDlsAccountDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountDeleteSettings.ResourceGroup"/>.</em></p><p>If not specified, will attempt to discover the resource group for the specified Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsAccountDeleteSettings ResetResourceGroup(this AzureDlsAccountDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlsAccountDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountDeleteSettings SetDebug(this AzureDlsAccountDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountDeleteSettings ResetDebug(this AzureDlsAccountDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlsAccountDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsAccountDeleteSettings SetHelp(this AzureDlsAccountDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsAccountDeleteSettings ResetHelp(this AzureDlsAccountDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlsAccountDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsAccountDeleteSettings SetOutput(this AzureDlsAccountDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsAccountDeleteSettings ResetOutput(this AzureDlsAccountDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlsAccountDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsAccountDeleteSettings SetQuery(this AzureDlsAccountDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsAccountDeleteSettings ResetQuery(this AzureDlsAccountDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlsAccountDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountDeleteSettings SetVerbose(this AzureDlsAccountDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountDeleteSettings ResetVerbose(this AzureDlsAccountDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlsAccountEnableKeyVaultSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlsAccountEnableKeyVaultSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlsAccountEnableKeyVaultSettings.Account"/>.</em></p><p>Name of the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsAccountEnableKeyVaultSettings SetAccount(this AzureDlsAccountEnableKeyVaultSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountEnableKeyVaultSettings.Account"/>.</em></p><p>Name of the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsAccountEnableKeyVaultSettings ResetAccount(this AzureDlsAccountEnableKeyVaultSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureDlsAccountEnableKeyVaultSettings.ResourceGroup"/>.</em></p><p>If not specified, will attempt to discover the resource group for the specified Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsAccountEnableKeyVaultSettings SetResourceGroup(this AzureDlsAccountEnableKeyVaultSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountEnableKeyVaultSettings.ResourceGroup"/>.</em></p><p>If not specified, will attempt to discover the resource group for the specified Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsAccountEnableKeyVaultSettings ResetResourceGroup(this AzureDlsAccountEnableKeyVaultSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlsAccountEnableKeyVaultSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountEnableKeyVaultSettings SetDebug(this AzureDlsAccountEnableKeyVaultSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountEnableKeyVaultSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountEnableKeyVaultSettings ResetDebug(this AzureDlsAccountEnableKeyVaultSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlsAccountEnableKeyVaultSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsAccountEnableKeyVaultSettings SetHelp(this AzureDlsAccountEnableKeyVaultSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountEnableKeyVaultSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsAccountEnableKeyVaultSettings ResetHelp(this AzureDlsAccountEnableKeyVaultSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlsAccountEnableKeyVaultSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsAccountEnableKeyVaultSettings SetOutput(this AzureDlsAccountEnableKeyVaultSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountEnableKeyVaultSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsAccountEnableKeyVaultSettings ResetOutput(this AzureDlsAccountEnableKeyVaultSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlsAccountEnableKeyVaultSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsAccountEnableKeyVaultSettings SetQuery(this AzureDlsAccountEnableKeyVaultSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountEnableKeyVaultSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsAccountEnableKeyVaultSettings ResetQuery(this AzureDlsAccountEnableKeyVaultSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlsAccountEnableKeyVaultSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountEnableKeyVaultSettings SetVerbose(this AzureDlsAccountEnableKeyVaultSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountEnableKeyVaultSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountEnableKeyVaultSettings ResetVerbose(this AzureDlsAccountEnableKeyVaultSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlsAccountListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlsAccountListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureDlsAccountListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureDlsAccountListSettings SetResourceGroup(this AzureDlsAccountListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureDlsAccountListSettings ResetResourceGroup(this AzureDlsAccountListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlsAccountListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountListSettings SetDebug(this AzureDlsAccountListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountListSettings ResetDebug(this AzureDlsAccountListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlsAccountListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsAccountListSettings SetHelp(this AzureDlsAccountListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsAccountListSettings ResetHelp(this AzureDlsAccountListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlsAccountListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsAccountListSettings SetOutput(this AzureDlsAccountListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsAccountListSettings ResetOutput(this AzureDlsAccountListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlsAccountListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsAccountListSettings SetQuery(this AzureDlsAccountListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsAccountListSettings ResetQuery(this AzureDlsAccountListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlsAccountListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountListSettings SetVerbose(this AzureDlsAccountListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountListSettings ResetVerbose(this AzureDlsAccountListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlsAccountShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlsAccountShowSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlsAccountShowSettings.Account"/>.</em></p><p>Name of the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsAccountShowSettings SetAccount(this AzureDlsAccountShowSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountShowSettings.Account"/>.</em></p><p>Name of the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsAccountShowSettings ResetAccount(this AzureDlsAccountShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureDlsAccountShowSettings.ResourceGroup"/>.</em></p><p>If not specified, will attempt to discover the resource group for the specified Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsAccountShowSettings SetResourceGroup(this AzureDlsAccountShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountShowSettings.ResourceGroup"/>.</em></p><p>If not specified, will attempt to discover the resource group for the specified Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsAccountShowSettings ResetResourceGroup(this AzureDlsAccountShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlsAccountShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountShowSettings SetDebug(this AzureDlsAccountShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountShowSettings ResetDebug(this AzureDlsAccountShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlsAccountShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsAccountShowSettings SetHelp(this AzureDlsAccountShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsAccountShowSettings ResetHelp(this AzureDlsAccountShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlsAccountShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsAccountShowSettings SetOutput(this AzureDlsAccountShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsAccountShowSettings ResetOutput(this AzureDlsAccountShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlsAccountShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsAccountShowSettings SetQuery(this AzureDlsAccountShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsAccountShowSettings ResetQuery(this AzureDlsAccountShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlsAccountShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountShowSettings SetVerbose(this AzureDlsAccountShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountShowSettings ResetVerbose(this AzureDlsAccountShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlsAccountUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlsAccountUpdateSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlsAccountUpdateSettings.Account"/>.</em></p><p>Name of the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsAccountUpdateSettings SetAccount(this AzureDlsAccountUpdateSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountUpdateSettings.Account"/>.</em></p><p>Name of the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsAccountUpdateSettings ResetAccount(this AzureDlsAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region AllowAzureIps
        /// <summary><p><em>Sets <see cref="AzureDlsAccountUpdateSettings.AllowAzureIps"/>.</em></p><p>Allow/block Azure originating IPs through the firewall.</p></summary>
        [Pure]
        public static AzureDlsAccountUpdateSettings SetAllowAzureIps(this AzureDlsAccountUpdateSettings toolSettings, DlsAccountUpdateAllowAzureIps allowAzureIps)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AllowAzureIps = allowAzureIps;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountUpdateSettings.AllowAzureIps"/>.</em></p><p>Allow/block Azure originating IPs through the firewall.</p></summary>
        [Pure]
        public static AzureDlsAccountUpdateSettings ResetAllowAzureIps(this AzureDlsAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AllowAzureIps = null;
            return toolSettings;
        }
        #endregion
        #region DefaultGroup
        /// <summary><p><em>Sets <see cref="AzureDlsAccountUpdateSettings.DefaultGroup"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureDlsAccountUpdateSettings SetDefaultGroup(this AzureDlsAccountUpdateSettings toolSettings, string defaultGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DefaultGroup = defaultGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountUpdateSettings.DefaultGroup"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureDlsAccountUpdateSettings ResetDefaultGroup(this AzureDlsAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DefaultGroup = null;
            return toolSettings;
        }
        #endregion
        #region FirewallState
        /// <summary><p><em>Sets <see cref="AzureDlsAccountUpdateSettings.FirewallState"/>.</em></p><p>Enable/disable existing firewall rules.</p></summary>
        [Pure]
        public static AzureDlsAccountUpdateSettings SetFirewallState(this AzureDlsAccountUpdateSettings toolSettings, DlsAccountUpdateAllowAzureIps firewallState)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FirewallState = firewallState;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountUpdateSettings.FirewallState"/>.</em></p><p>Enable/disable existing firewall rules.</p></summary>
        [Pure]
        public static AzureDlsAccountUpdateSettings ResetFirewallState(this AzureDlsAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FirewallState = null;
            return toolSettings;
        }
        #endregion
        #region KeyVersion
        /// <summary><p><em>Sets <see cref="AzureDlsAccountUpdateSettings.KeyVersion"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureDlsAccountUpdateSettings SetKeyVersion(this AzureDlsAccountUpdateSettings toolSettings, string keyVersion)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyVersion = keyVersion;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountUpdateSettings.KeyVersion"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureDlsAccountUpdateSettings ResetKeyVersion(this AzureDlsAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyVersion = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureDlsAccountUpdateSettings.ResourceGroup"/>.</em></p><p>If not specified, will attempt to discover the resource group for the specified Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsAccountUpdateSettings SetResourceGroup(this AzureDlsAccountUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountUpdateSettings.ResourceGroup"/>.</em></p><p>If not specified, will attempt to discover the resource group for the specified Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsAccountUpdateSettings ResetResourceGroup(this AzureDlsAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary><p><em>Sets <see cref="AzureDlsAccountUpdateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureDlsAccountUpdateSettings SetTags(this AzureDlsAccountUpdateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountUpdateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureDlsAccountUpdateSettings ResetTags(this AzureDlsAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Tier
        /// <summary><p><em>Sets <see cref="AzureDlsAccountUpdateSettings.Tier"/>.</em></p><p>The desired commitment tier for this account to use.</p></summary>
        [Pure]
        public static AzureDlsAccountUpdateSettings SetTier(this AzureDlsAccountUpdateSettings toolSettings, DlsAccountTier tier)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tier = tier;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountUpdateSettings.Tier"/>.</em></p><p>The desired commitment tier for this account to use.</p></summary>
        [Pure]
        public static AzureDlsAccountUpdateSettings ResetTier(this AzureDlsAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tier = null;
            return toolSettings;
        }
        #endregion
        #region TrustedIdProviderState
        /// <summary><p><em>Sets <see cref="AzureDlsAccountUpdateSettings.TrustedIdProviderState"/>.</em></p><p>Enable/disable the existing trusted ID providers.</p></summary>
        [Pure]
        public static AzureDlsAccountUpdateSettings SetTrustedIdProviderState(this AzureDlsAccountUpdateSettings toolSettings, DlsAccountUpdateAllowAzureIps trustedIdProviderState)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TrustedIdProviderState = trustedIdProviderState;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountUpdateSettings.TrustedIdProviderState"/>.</em></p><p>Enable/disable the existing trusted ID providers.</p></summary>
        [Pure]
        public static AzureDlsAccountUpdateSettings ResetTrustedIdProviderState(this AzureDlsAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TrustedIdProviderState = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlsAccountUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountUpdateSettings SetDebug(this AzureDlsAccountUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountUpdateSettings ResetDebug(this AzureDlsAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlsAccountUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsAccountUpdateSettings SetHelp(this AzureDlsAccountUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsAccountUpdateSettings ResetHelp(this AzureDlsAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlsAccountUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsAccountUpdateSettings SetOutput(this AzureDlsAccountUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsAccountUpdateSettings ResetOutput(this AzureDlsAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlsAccountUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsAccountUpdateSettings SetQuery(this AzureDlsAccountUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsAccountUpdateSettings ResetQuery(this AzureDlsAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlsAccountUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountUpdateSettings SetVerbose(this AzureDlsAccountUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountUpdateSettings ResetVerbose(this AzureDlsAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlsAccountFirewallCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlsAccountFirewallCreateSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlsAccountFirewallCreateSettings.Account"/>.</em></p><p>Name of the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallCreateSettings SetAccount(this AzureDlsAccountFirewallCreateSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountFirewallCreateSettings.Account"/>.</em></p><p>Name of the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallCreateSettings ResetAccount(this AzureDlsAccountFirewallCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region EndIpAddress
        /// <summary><p><em>Sets <see cref="AzureDlsAccountFirewallCreateSettings.EndIpAddress"/>.</em></p><p>The end of the valid ip range for the firewall rule.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallCreateSettings SetEndIpAddress(this AzureDlsAccountFirewallCreateSettings toolSettings, string endIpAddress)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndIpAddress = endIpAddress;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountFirewallCreateSettings.EndIpAddress"/>.</em></p><p>The end of the valid ip range for the firewall rule.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallCreateSettings ResetEndIpAddress(this AzureDlsAccountFirewallCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndIpAddress = null;
            return toolSettings;
        }
        #endregion
        #region FirewallRuleName
        /// <summary><p><em>Sets <see cref="AzureDlsAccountFirewallCreateSettings.FirewallRuleName"/>.</em></p><p>The name of the firewall rule.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallCreateSettings SetFirewallRuleName(this AzureDlsAccountFirewallCreateSettings toolSettings, string firewallRuleName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FirewallRuleName = firewallRuleName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountFirewallCreateSettings.FirewallRuleName"/>.</em></p><p>The name of the firewall rule.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallCreateSettings ResetFirewallRuleName(this AzureDlsAccountFirewallCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FirewallRuleName = null;
            return toolSettings;
        }
        #endregion
        #region StartIpAddress
        /// <summary><p><em>Sets <see cref="AzureDlsAccountFirewallCreateSettings.StartIpAddress"/>.</em></p><p>The start of the valid ip range for the firewall rule.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallCreateSettings SetStartIpAddress(this AzureDlsAccountFirewallCreateSettings toolSettings, string startIpAddress)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartIpAddress = startIpAddress;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountFirewallCreateSettings.StartIpAddress"/>.</em></p><p>The start of the valid ip range for the firewall rule.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallCreateSettings ResetStartIpAddress(this AzureDlsAccountFirewallCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartIpAddress = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureDlsAccountFirewallCreateSettings.ResourceGroup"/>.</em></p><p>If not specified, will attempt to discover the resource group for the specified Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallCreateSettings SetResourceGroup(this AzureDlsAccountFirewallCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountFirewallCreateSettings.ResourceGroup"/>.</em></p><p>If not specified, will attempt to discover the resource group for the specified Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallCreateSettings ResetResourceGroup(this AzureDlsAccountFirewallCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlsAccountFirewallCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallCreateSettings SetDebug(this AzureDlsAccountFirewallCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountFirewallCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallCreateSettings ResetDebug(this AzureDlsAccountFirewallCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlsAccountFirewallCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallCreateSettings SetHelp(this AzureDlsAccountFirewallCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountFirewallCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallCreateSettings ResetHelp(this AzureDlsAccountFirewallCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlsAccountFirewallCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallCreateSettings SetOutput(this AzureDlsAccountFirewallCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountFirewallCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallCreateSettings ResetOutput(this AzureDlsAccountFirewallCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlsAccountFirewallCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallCreateSettings SetQuery(this AzureDlsAccountFirewallCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountFirewallCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallCreateSettings ResetQuery(this AzureDlsAccountFirewallCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlsAccountFirewallCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallCreateSettings SetVerbose(this AzureDlsAccountFirewallCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountFirewallCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallCreateSettings ResetVerbose(this AzureDlsAccountFirewallCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlsAccountFirewallDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlsAccountFirewallDeleteSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlsAccountFirewallDeleteSettings.Account"/>.</em></p><p>Name of the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallDeleteSettings SetAccount(this AzureDlsAccountFirewallDeleteSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountFirewallDeleteSettings.Account"/>.</em></p><p>Name of the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallDeleteSettings ResetAccount(this AzureDlsAccountFirewallDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region FirewallRuleName
        /// <summary><p><em>Sets <see cref="AzureDlsAccountFirewallDeleteSettings.FirewallRuleName"/>.</em></p><p>The name of the firewall rule to delete.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallDeleteSettings SetFirewallRuleName(this AzureDlsAccountFirewallDeleteSettings toolSettings, string firewallRuleName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FirewallRuleName = firewallRuleName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountFirewallDeleteSettings.FirewallRuleName"/>.</em></p><p>The name of the firewall rule to delete.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallDeleteSettings ResetFirewallRuleName(this AzureDlsAccountFirewallDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FirewallRuleName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureDlsAccountFirewallDeleteSettings.ResourceGroup"/>.</em></p><p>If not specified, will attempt to discover the resource group for the specified Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallDeleteSettings SetResourceGroup(this AzureDlsAccountFirewallDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountFirewallDeleteSettings.ResourceGroup"/>.</em></p><p>If not specified, will attempt to discover the resource group for the specified Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallDeleteSettings ResetResourceGroup(this AzureDlsAccountFirewallDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlsAccountFirewallDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallDeleteSettings SetDebug(this AzureDlsAccountFirewallDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountFirewallDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallDeleteSettings ResetDebug(this AzureDlsAccountFirewallDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlsAccountFirewallDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallDeleteSettings SetHelp(this AzureDlsAccountFirewallDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountFirewallDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallDeleteSettings ResetHelp(this AzureDlsAccountFirewallDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlsAccountFirewallDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallDeleteSettings SetOutput(this AzureDlsAccountFirewallDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountFirewallDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallDeleteSettings ResetOutput(this AzureDlsAccountFirewallDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlsAccountFirewallDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallDeleteSettings SetQuery(this AzureDlsAccountFirewallDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountFirewallDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallDeleteSettings ResetQuery(this AzureDlsAccountFirewallDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlsAccountFirewallDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallDeleteSettings SetVerbose(this AzureDlsAccountFirewallDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountFirewallDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallDeleteSettings ResetVerbose(this AzureDlsAccountFirewallDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlsAccountFirewallListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlsAccountFirewallListSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlsAccountFirewallListSettings.Account"/>.</em></p><p>Name of the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallListSettings SetAccount(this AzureDlsAccountFirewallListSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountFirewallListSettings.Account"/>.</em></p><p>Name of the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallListSettings ResetAccount(this AzureDlsAccountFirewallListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureDlsAccountFirewallListSettings.ResourceGroup"/>.</em></p><p>If not specified, will attempt to discover the resource group for the specified Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallListSettings SetResourceGroup(this AzureDlsAccountFirewallListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountFirewallListSettings.ResourceGroup"/>.</em></p><p>If not specified, will attempt to discover the resource group for the specified Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallListSettings ResetResourceGroup(this AzureDlsAccountFirewallListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlsAccountFirewallListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallListSettings SetDebug(this AzureDlsAccountFirewallListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountFirewallListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallListSettings ResetDebug(this AzureDlsAccountFirewallListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlsAccountFirewallListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallListSettings SetHelp(this AzureDlsAccountFirewallListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountFirewallListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallListSettings ResetHelp(this AzureDlsAccountFirewallListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlsAccountFirewallListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallListSettings SetOutput(this AzureDlsAccountFirewallListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountFirewallListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallListSettings ResetOutput(this AzureDlsAccountFirewallListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlsAccountFirewallListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallListSettings SetQuery(this AzureDlsAccountFirewallListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountFirewallListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallListSettings ResetQuery(this AzureDlsAccountFirewallListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlsAccountFirewallListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallListSettings SetVerbose(this AzureDlsAccountFirewallListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountFirewallListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallListSettings ResetVerbose(this AzureDlsAccountFirewallListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlsAccountFirewallShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlsAccountFirewallShowSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlsAccountFirewallShowSettings.Account"/>.</em></p><p>Name of the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallShowSettings SetAccount(this AzureDlsAccountFirewallShowSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountFirewallShowSettings.Account"/>.</em></p><p>Name of the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallShowSettings ResetAccount(this AzureDlsAccountFirewallShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region FirewallRuleName
        /// <summary><p><em>Sets <see cref="AzureDlsAccountFirewallShowSettings.FirewallRuleName"/>.</em></p><p>The name of the firewall rule to retrieve.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallShowSettings SetFirewallRuleName(this AzureDlsAccountFirewallShowSettings toolSettings, string firewallRuleName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FirewallRuleName = firewallRuleName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountFirewallShowSettings.FirewallRuleName"/>.</em></p><p>The name of the firewall rule to retrieve.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallShowSettings ResetFirewallRuleName(this AzureDlsAccountFirewallShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FirewallRuleName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureDlsAccountFirewallShowSettings.ResourceGroup"/>.</em></p><p>If not specified, will attempt to discover the resource group for the specified Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallShowSettings SetResourceGroup(this AzureDlsAccountFirewallShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountFirewallShowSettings.ResourceGroup"/>.</em></p><p>If not specified, will attempt to discover the resource group for the specified Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallShowSettings ResetResourceGroup(this AzureDlsAccountFirewallShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlsAccountFirewallShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallShowSettings SetDebug(this AzureDlsAccountFirewallShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountFirewallShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallShowSettings ResetDebug(this AzureDlsAccountFirewallShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlsAccountFirewallShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallShowSettings SetHelp(this AzureDlsAccountFirewallShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountFirewallShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallShowSettings ResetHelp(this AzureDlsAccountFirewallShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlsAccountFirewallShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallShowSettings SetOutput(this AzureDlsAccountFirewallShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountFirewallShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallShowSettings ResetOutput(this AzureDlsAccountFirewallShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlsAccountFirewallShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallShowSettings SetQuery(this AzureDlsAccountFirewallShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountFirewallShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallShowSettings ResetQuery(this AzureDlsAccountFirewallShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlsAccountFirewallShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallShowSettings SetVerbose(this AzureDlsAccountFirewallShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountFirewallShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallShowSettings ResetVerbose(this AzureDlsAccountFirewallShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlsAccountFirewallUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlsAccountFirewallUpdateSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlsAccountFirewallUpdateSettings.Account"/>.</em></p><p>Name of the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallUpdateSettings SetAccount(this AzureDlsAccountFirewallUpdateSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountFirewallUpdateSettings.Account"/>.</em></p><p>Name of the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallUpdateSettings ResetAccount(this AzureDlsAccountFirewallUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region FirewallRuleName
        /// <summary><p><em>Sets <see cref="AzureDlsAccountFirewallUpdateSettings.FirewallRuleName"/>.</em></p><p>The name of the firewall rule to update.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallUpdateSettings SetFirewallRuleName(this AzureDlsAccountFirewallUpdateSettings toolSettings, string firewallRuleName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FirewallRuleName = firewallRuleName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountFirewallUpdateSettings.FirewallRuleName"/>.</em></p><p>The name of the firewall rule to update.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallUpdateSettings ResetFirewallRuleName(this AzureDlsAccountFirewallUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FirewallRuleName = null;
            return toolSettings;
        }
        #endregion
        #region EndIpAddress
        /// <summary><p><em>Sets <see cref="AzureDlsAccountFirewallUpdateSettings.EndIpAddress"/>.</em></p><p>The end IP address for the firewall rule. This can be either ipv4 or ipv6. Start and End should be in the same protocol.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallUpdateSettings SetEndIpAddress(this AzureDlsAccountFirewallUpdateSettings toolSettings, string endIpAddress)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndIpAddress = endIpAddress;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountFirewallUpdateSettings.EndIpAddress"/>.</em></p><p>The end IP address for the firewall rule. This can be either ipv4 or ipv6. Start and End should be in the same protocol.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallUpdateSettings ResetEndIpAddress(this AzureDlsAccountFirewallUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndIpAddress = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureDlsAccountFirewallUpdateSettings.ResourceGroup"/>.</em></p><p>If not specified, will attempt to discover the resource group for the specified Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallUpdateSettings SetResourceGroup(this AzureDlsAccountFirewallUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountFirewallUpdateSettings.ResourceGroup"/>.</em></p><p>If not specified, will attempt to discover the resource group for the specified Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallUpdateSettings ResetResourceGroup(this AzureDlsAccountFirewallUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region StartIpAddress
        /// <summary><p><em>Sets <see cref="AzureDlsAccountFirewallUpdateSettings.StartIpAddress"/>.</em></p><p>The start IP address for the firewall rule. This can be either ipv4 or ipv6. Start and End should be in the same protocol.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallUpdateSettings SetStartIpAddress(this AzureDlsAccountFirewallUpdateSettings toolSettings, string startIpAddress)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartIpAddress = startIpAddress;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountFirewallUpdateSettings.StartIpAddress"/>.</em></p><p>The start IP address for the firewall rule. This can be either ipv4 or ipv6. Start and End should be in the same protocol.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallUpdateSettings ResetStartIpAddress(this AzureDlsAccountFirewallUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartIpAddress = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlsAccountFirewallUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallUpdateSettings SetDebug(this AzureDlsAccountFirewallUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountFirewallUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallUpdateSettings ResetDebug(this AzureDlsAccountFirewallUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlsAccountFirewallUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallUpdateSettings SetHelp(this AzureDlsAccountFirewallUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountFirewallUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallUpdateSettings ResetHelp(this AzureDlsAccountFirewallUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlsAccountFirewallUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallUpdateSettings SetOutput(this AzureDlsAccountFirewallUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountFirewallUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallUpdateSettings ResetOutput(this AzureDlsAccountFirewallUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlsAccountFirewallUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallUpdateSettings SetQuery(this AzureDlsAccountFirewallUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountFirewallUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallUpdateSettings ResetQuery(this AzureDlsAccountFirewallUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlsAccountFirewallUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallUpdateSettings SetVerbose(this AzureDlsAccountFirewallUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountFirewallUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountFirewallUpdateSettings ResetVerbose(this AzureDlsAccountFirewallUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlsAccountTrustedProviderCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlsAccountTrustedProviderCreateSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlsAccountTrustedProviderCreateSettings.Account"/>.</em></p><p>Name of the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsAccountTrustedProviderCreateSettings SetAccount(this AzureDlsAccountTrustedProviderCreateSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountTrustedProviderCreateSettings.Account"/>.</em></p><p>Name of the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsAccountTrustedProviderCreateSettings ResetAccount(this AzureDlsAccountTrustedProviderCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region IdProvider
        /// <summary><p><em>Sets <see cref="AzureDlsAccountTrustedProviderCreateSettings.IdProvider"/>.</em></p><p>The URL of this trusted identity provider.</p></summary>
        [Pure]
        public static AzureDlsAccountTrustedProviderCreateSettings SetIdProvider(this AzureDlsAccountTrustedProviderCreateSettings toolSettings, string idProvider)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdProvider = idProvider;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountTrustedProviderCreateSettings.IdProvider"/>.</em></p><p>The URL of this trusted identity provider.</p></summary>
        [Pure]
        public static AzureDlsAccountTrustedProviderCreateSettings ResetIdProvider(this AzureDlsAccountTrustedProviderCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdProvider = null;
            return toolSettings;
        }
        #endregion
        #region TrustedIdProviderName
        /// <summary><p><em>Sets <see cref="AzureDlsAccountTrustedProviderCreateSettings.TrustedIdProviderName"/>.</em></p><p>The name of the trusted identity provider. This is used for differentiation of providers in the account.</p></summary>
        [Pure]
        public static AzureDlsAccountTrustedProviderCreateSettings SetTrustedIdProviderName(this AzureDlsAccountTrustedProviderCreateSettings toolSettings, string trustedIdProviderName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TrustedIdProviderName = trustedIdProviderName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountTrustedProviderCreateSettings.TrustedIdProviderName"/>.</em></p><p>The name of the trusted identity provider. This is used for differentiation of providers in the account.</p></summary>
        [Pure]
        public static AzureDlsAccountTrustedProviderCreateSettings ResetTrustedIdProviderName(this AzureDlsAccountTrustedProviderCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TrustedIdProviderName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureDlsAccountTrustedProviderCreateSettings.ResourceGroup"/>.</em></p><p>If not specified, will attempt to discover the resource group for the specified Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsAccountTrustedProviderCreateSettings SetResourceGroup(this AzureDlsAccountTrustedProviderCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountTrustedProviderCreateSettings.ResourceGroup"/>.</em></p><p>If not specified, will attempt to discover the resource group for the specified Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsAccountTrustedProviderCreateSettings ResetResourceGroup(this AzureDlsAccountTrustedProviderCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlsAccountTrustedProviderCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountTrustedProviderCreateSettings SetDebug(this AzureDlsAccountTrustedProviderCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountTrustedProviderCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountTrustedProviderCreateSettings ResetDebug(this AzureDlsAccountTrustedProviderCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlsAccountTrustedProviderCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsAccountTrustedProviderCreateSettings SetHelp(this AzureDlsAccountTrustedProviderCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountTrustedProviderCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsAccountTrustedProviderCreateSettings ResetHelp(this AzureDlsAccountTrustedProviderCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlsAccountTrustedProviderCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsAccountTrustedProviderCreateSettings SetOutput(this AzureDlsAccountTrustedProviderCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountTrustedProviderCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsAccountTrustedProviderCreateSettings ResetOutput(this AzureDlsAccountTrustedProviderCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlsAccountTrustedProviderCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsAccountTrustedProviderCreateSettings SetQuery(this AzureDlsAccountTrustedProviderCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountTrustedProviderCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsAccountTrustedProviderCreateSettings ResetQuery(this AzureDlsAccountTrustedProviderCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlsAccountTrustedProviderCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountTrustedProviderCreateSettings SetVerbose(this AzureDlsAccountTrustedProviderCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountTrustedProviderCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountTrustedProviderCreateSettings ResetVerbose(this AzureDlsAccountTrustedProviderCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlsAccountTrustedProviderDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlsAccountTrustedProviderDeleteSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlsAccountTrustedProviderDeleteSettings.Account"/>.</em></p><p>Name of the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsAccountTrustedProviderDeleteSettings SetAccount(this AzureDlsAccountTrustedProviderDeleteSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountTrustedProviderDeleteSettings.Account"/>.</em></p><p>Name of the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsAccountTrustedProviderDeleteSettings ResetAccount(this AzureDlsAccountTrustedProviderDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region TrustedIdProviderName
        /// <summary><p><em>Sets <see cref="AzureDlsAccountTrustedProviderDeleteSettings.TrustedIdProviderName"/>.</em></p><p>The name of the trusted identity provider to delete.</p></summary>
        [Pure]
        public static AzureDlsAccountTrustedProviderDeleteSettings SetTrustedIdProviderName(this AzureDlsAccountTrustedProviderDeleteSettings toolSettings, string trustedIdProviderName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TrustedIdProviderName = trustedIdProviderName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountTrustedProviderDeleteSettings.TrustedIdProviderName"/>.</em></p><p>The name of the trusted identity provider to delete.</p></summary>
        [Pure]
        public static AzureDlsAccountTrustedProviderDeleteSettings ResetTrustedIdProviderName(this AzureDlsAccountTrustedProviderDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TrustedIdProviderName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureDlsAccountTrustedProviderDeleteSettings.ResourceGroup"/>.</em></p><p>If not specified, will attempt to discover the resource group for the specified Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsAccountTrustedProviderDeleteSettings SetResourceGroup(this AzureDlsAccountTrustedProviderDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountTrustedProviderDeleteSettings.ResourceGroup"/>.</em></p><p>If not specified, will attempt to discover the resource group for the specified Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsAccountTrustedProviderDeleteSettings ResetResourceGroup(this AzureDlsAccountTrustedProviderDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlsAccountTrustedProviderDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountTrustedProviderDeleteSettings SetDebug(this AzureDlsAccountTrustedProviderDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountTrustedProviderDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountTrustedProviderDeleteSettings ResetDebug(this AzureDlsAccountTrustedProviderDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlsAccountTrustedProviderDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsAccountTrustedProviderDeleteSettings SetHelp(this AzureDlsAccountTrustedProviderDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountTrustedProviderDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsAccountTrustedProviderDeleteSettings ResetHelp(this AzureDlsAccountTrustedProviderDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlsAccountTrustedProviderDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsAccountTrustedProviderDeleteSettings SetOutput(this AzureDlsAccountTrustedProviderDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountTrustedProviderDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsAccountTrustedProviderDeleteSettings ResetOutput(this AzureDlsAccountTrustedProviderDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlsAccountTrustedProviderDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsAccountTrustedProviderDeleteSettings SetQuery(this AzureDlsAccountTrustedProviderDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountTrustedProviderDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsAccountTrustedProviderDeleteSettings ResetQuery(this AzureDlsAccountTrustedProviderDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlsAccountTrustedProviderDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountTrustedProviderDeleteSettings SetVerbose(this AzureDlsAccountTrustedProviderDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountTrustedProviderDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountTrustedProviderDeleteSettings ResetVerbose(this AzureDlsAccountTrustedProviderDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlsAccountTrustedProviderListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlsAccountTrustedProviderListSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlsAccountTrustedProviderListSettings.Account"/>.</em></p><p>Name of the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsAccountTrustedProviderListSettings SetAccount(this AzureDlsAccountTrustedProviderListSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountTrustedProviderListSettings.Account"/>.</em></p><p>Name of the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsAccountTrustedProviderListSettings ResetAccount(this AzureDlsAccountTrustedProviderListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureDlsAccountTrustedProviderListSettings.ResourceGroup"/>.</em></p><p>If not specified, will attempt to discover the resource group for the specified Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsAccountTrustedProviderListSettings SetResourceGroup(this AzureDlsAccountTrustedProviderListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountTrustedProviderListSettings.ResourceGroup"/>.</em></p><p>If not specified, will attempt to discover the resource group for the specified Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsAccountTrustedProviderListSettings ResetResourceGroup(this AzureDlsAccountTrustedProviderListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlsAccountTrustedProviderListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountTrustedProviderListSettings SetDebug(this AzureDlsAccountTrustedProviderListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountTrustedProviderListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountTrustedProviderListSettings ResetDebug(this AzureDlsAccountTrustedProviderListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlsAccountTrustedProviderListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsAccountTrustedProviderListSettings SetHelp(this AzureDlsAccountTrustedProviderListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountTrustedProviderListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsAccountTrustedProviderListSettings ResetHelp(this AzureDlsAccountTrustedProviderListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlsAccountTrustedProviderListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsAccountTrustedProviderListSettings SetOutput(this AzureDlsAccountTrustedProviderListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountTrustedProviderListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsAccountTrustedProviderListSettings ResetOutput(this AzureDlsAccountTrustedProviderListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlsAccountTrustedProviderListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsAccountTrustedProviderListSettings SetQuery(this AzureDlsAccountTrustedProviderListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountTrustedProviderListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsAccountTrustedProviderListSettings ResetQuery(this AzureDlsAccountTrustedProviderListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlsAccountTrustedProviderListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountTrustedProviderListSettings SetVerbose(this AzureDlsAccountTrustedProviderListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountTrustedProviderListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountTrustedProviderListSettings ResetVerbose(this AzureDlsAccountTrustedProviderListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlsAccountTrustedProviderShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlsAccountTrustedProviderShowSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlsAccountTrustedProviderShowSettings.Account"/>.</em></p><p>Name of the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsAccountTrustedProviderShowSettings SetAccount(this AzureDlsAccountTrustedProviderShowSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountTrustedProviderShowSettings.Account"/>.</em></p><p>Name of the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsAccountTrustedProviderShowSettings ResetAccount(this AzureDlsAccountTrustedProviderShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region TrustedIdProviderName
        /// <summary><p><em>Sets <see cref="AzureDlsAccountTrustedProviderShowSettings.TrustedIdProviderName"/>.</em></p><p>The name of the trusted identity provider to retrieve.</p></summary>
        [Pure]
        public static AzureDlsAccountTrustedProviderShowSettings SetTrustedIdProviderName(this AzureDlsAccountTrustedProviderShowSettings toolSettings, string trustedIdProviderName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TrustedIdProviderName = trustedIdProviderName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountTrustedProviderShowSettings.TrustedIdProviderName"/>.</em></p><p>The name of the trusted identity provider to retrieve.</p></summary>
        [Pure]
        public static AzureDlsAccountTrustedProviderShowSettings ResetTrustedIdProviderName(this AzureDlsAccountTrustedProviderShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TrustedIdProviderName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureDlsAccountTrustedProviderShowSettings.ResourceGroup"/>.</em></p><p>If not specified, will attempt to discover the resource group for the specified Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsAccountTrustedProviderShowSettings SetResourceGroup(this AzureDlsAccountTrustedProviderShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountTrustedProviderShowSettings.ResourceGroup"/>.</em></p><p>If not specified, will attempt to discover the resource group for the specified Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsAccountTrustedProviderShowSettings ResetResourceGroup(this AzureDlsAccountTrustedProviderShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlsAccountTrustedProviderShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountTrustedProviderShowSettings SetDebug(this AzureDlsAccountTrustedProviderShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountTrustedProviderShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountTrustedProviderShowSettings ResetDebug(this AzureDlsAccountTrustedProviderShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlsAccountTrustedProviderShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsAccountTrustedProviderShowSettings SetHelp(this AzureDlsAccountTrustedProviderShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountTrustedProviderShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsAccountTrustedProviderShowSettings ResetHelp(this AzureDlsAccountTrustedProviderShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlsAccountTrustedProviderShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsAccountTrustedProviderShowSettings SetOutput(this AzureDlsAccountTrustedProviderShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountTrustedProviderShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsAccountTrustedProviderShowSettings ResetOutput(this AzureDlsAccountTrustedProviderShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlsAccountTrustedProviderShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsAccountTrustedProviderShowSettings SetQuery(this AzureDlsAccountTrustedProviderShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountTrustedProviderShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsAccountTrustedProviderShowSettings ResetQuery(this AzureDlsAccountTrustedProviderShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlsAccountTrustedProviderShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountTrustedProviderShowSettings SetVerbose(this AzureDlsAccountTrustedProviderShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountTrustedProviderShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountTrustedProviderShowSettings ResetVerbose(this AzureDlsAccountTrustedProviderShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlsAccountTrustedProviderUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlsAccountTrustedProviderUpdateSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlsAccountTrustedProviderUpdateSettings.Account"/>.</em></p><p>Name of the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsAccountTrustedProviderUpdateSettings SetAccount(this AzureDlsAccountTrustedProviderUpdateSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountTrustedProviderUpdateSettings.Account"/>.</em></p><p>Name of the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsAccountTrustedProviderUpdateSettings ResetAccount(this AzureDlsAccountTrustedProviderUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region TrustedIdProviderName
        /// <summary><p><em>Sets <see cref="AzureDlsAccountTrustedProviderUpdateSettings.TrustedIdProviderName"/>.</em></p><p>The name of the trusted identity provider. This is used for differentiation of providers in the account.</p></summary>
        [Pure]
        public static AzureDlsAccountTrustedProviderUpdateSettings SetTrustedIdProviderName(this AzureDlsAccountTrustedProviderUpdateSettings toolSettings, string trustedIdProviderName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TrustedIdProviderName = trustedIdProviderName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountTrustedProviderUpdateSettings.TrustedIdProviderName"/>.</em></p><p>The name of the trusted identity provider. This is used for differentiation of providers in the account.</p></summary>
        [Pure]
        public static AzureDlsAccountTrustedProviderUpdateSettings ResetTrustedIdProviderName(this AzureDlsAccountTrustedProviderUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TrustedIdProviderName = null;
            return toolSettings;
        }
        #endregion
        #region IdProvider
        /// <summary><p><em>Sets <see cref="AzureDlsAccountTrustedProviderUpdateSettings.IdProvider"/>.</em></p><p>The URL of this trusted identity provider.</p></summary>
        [Pure]
        public static AzureDlsAccountTrustedProviderUpdateSettings SetIdProvider(this AzureDlsAccountTrustedProviderUpdateSettings toolSettings, string idProvider)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdProvider = idProvider;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountTrustedProviderUpdateSettings.IdProvider"/>.</em></p><p>The URL of this trusted identity provider.</p></summary>
        [Pure]
        public static AzureDlsAccountTrustedProviderUpdateSettings ResetIdProvider(this AzureDlsAccountTrustedProviderUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdProvider = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureDlsAccountTrustedProviderUpdateSettings.ResourceGroup"/>.</em></p><p>If not specified, will attempt to discover the resource group for the specified Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsAccountTrustedProviderUpdateSettings SetResourceGroup(this AzureDlsAccountTrustedProviderUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountTrustedProviderUpdateSettings.ResourceGroup"/>.</em></p><p>If not specified, will attempt to discover the resource group for the specified Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsAccountTrustedProviderUpdateSettings ResetResourceGroup(this AzureDlsAccountTrustedProviderUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlsAccountTrustedProviderUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountTrustedProviderUpdateSettings SetDebug(this AzureDlsAccountTrustedProviderUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountTrustedProviderUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountTrustedProviderUpdateSettings ResetDebug(this AzureDlsAccountTrustedProviderUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlsAccountTrustedProviderUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsAccountTrustedProviderUpdateSettings SetHelp(this AzureDlsAccountTrustedProviderUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountTrustedProviderUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsAccountTrustedProviderUpdateSettings ResetHelp(this AzureDlsAccountTrustedProviderUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlsAccountTrustedProviderUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsAccountTrustedProviderUpdateSettings SetOutput(this AzureDlsAccountTrustedProviderUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountTrustedProviderUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsAccountTrustedProviderUpdateSettings ResetOutput(this AzureDlsAccountTrustedProviderUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlsAccountTrustedProviderUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsAccountTrustedProviderUpdateSettings SetQuery(this AzureDlsAccountTrustedProviderUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountTrustedProviderUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsAccountTrustedProviderUpdateSettings ResetQuery(this AzureDlsAccountTrustedProviderUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlsAccountTrustedProviderUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountTrustedProviderUpdateSettings SetVerbose(this AzureDlsAccountTrustedProviderUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountTrustedProviderUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountTrustedProviderUpdateSettings ResetVerbose(this AzureDlsAccountTrustedProviderUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlsAccountNetworkRuleCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlsAccountNetworkRuleCreateSettingsExtensions
    {
        #region AccountName
        /// <summary><p><em>Sets <see cref="AzureDlsAccountNetworkRuleCreateSettings.AccountName"/>.</em></p><p>Name of the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleCreateSettings SetAccountName(this AzureDlsAccountNetworkRuleCreateSettings toolSettings, string accountName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = accountName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountNetworkRuleCreateSettings.AccountName"/>.</em></p><p>Name of the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleCreateSettings ResetAccountName(this AzureDlsAccountNetworkRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureDlsAccountNetworkRuleCreateSettings.Name"/>.</em></p><p>The virtual network rule name.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleCreateSettings SetName(this AzureDlsAccountNetworkRuleCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountNetworkRuleCreateSettings.Name"/>.</em></p><p>The virtual network rule name.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleCreateSettings ResetName(this AzureDlsAccountNetworkRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Subnet
        /// <summary><p><em>Sets <see cref="AzureDlsAccountNetworkRuleCreateSettings.Subnet"/>.</em></p><p>The subnet name or id for the virtual network rule.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleCreateSettings SetSubnet(this AzureDlsAccountNetworkRuleCreateSettings toolSettings, string subnet)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subnet = subnet;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountNetworkRuleCreateSettings.Subnet"/>.</em></p><p>The subnet name or id for the virtual network rule.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleCreateSettings ResetSubnet(this AzureDlsAccountNetworkRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subnet = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureDlsAccountNetworkRuleCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleCreateSettings SetResourceGroup(this AzureDlsAccountNetworkRuleCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountNetworkRuleCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleCreateSettings ResetResourceGroup(this AzureDlsAccountNetworkRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region VnetName
        /// <summary><p><em>Sets <see cref="AzureDlsAccountNetworkRuleCreateSettings.VnetName"/>.</em></p><p>The name of the virtual network rule.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleCreateSettings SetVnetName(this AzureDlsAccountNetworkRuleCreateSettings toolSettings, string vnetName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VnetName = vnetName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountNetworkRuleCreateSettings.VnetName"/>.</em></p><p>The name of the virtual network rule.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleCreateSettings ResetVnetName(this AzureDlsAccountNetworkRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VnetName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlsAccountNetworkRuleCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleCreateSettings SetDebug(this AzureDlsAccountNetworkRuleCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountNetworkRuleCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleCreateSettings ResetDebug(this AzureDlsAccountNetworkRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlsAccountNetworkRuleCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleCreateSettings SetHelp(this AzureDlsAccountNetworkRuleCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountNetworkRuleCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleCreateSettings ResetHelp(this AzureDlsAccountNetworkRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlsAccountNetworkRuleCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleCreateSettings SetOutput(this AzureDlsAccountNetworkRuleCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountNetworkRuleCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleCreateSettings ResetOutput(this AzureDlsAccountNetworkRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlsAccountNetworkRuleCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleCreateSettings SetQuery(this AzureDlsAccountNetworkRuleCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountNetworkRuleCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleCreateSettings ResetQuery(this AzureDlsAccountNetworkRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlsAccountNetworkRuleCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleCreateSettings SetVerbose(this AzureDlsAccountNetworkRuleCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountNetworkRuleCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleCreateSettings ResetVerbose(this AzureDlsAccountNetworkRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlsAccountNetworkRuleDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlsAccountNetworkRuleDeleteSettingsExtensions
    {
        #region AccountName
        /// <summary><p><em>Sets <see cref="AzureDlsAccountNetworkRuleDeleteSettings.AccountName"/>.</em></p><p>Name of the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleDeleteSettings SetAccountName(this AzureDlsAccountNetworkRuleDeleteSettings toolSettings, string accountName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = accountName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountNetworkRuleDeleteSettings.AccountName"/>.</em></p><p>Name of the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleDeleteSettings ResetAccountName(this AzureDlsAccountNetworkRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureDlsAccountNetworkRuleDeleteSettings.Name"/>.</em></p><p>The virtual network rule name.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleDeleteSettings SetName(this AzureDlsAccountNetworkRuleDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountNetworkRuleDeleteSettings.Name"/>.</em></p><p>The virtual network rule name.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleDeleteSettings ResetName(this AzureDlsAccountNetworkRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureDlsAccountNetworkRuleDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleDeleteSettings SetResourceGroup(this AzureDlsAccountNetworkRuleDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountNetworkRuleDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleDeleteSettings ResetResourceGroup(this AzureDlsAccountNetworkRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlsAccountNetworkRuleDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleDeleteSettings SetDebug(this AzureDlsAccountNetworkRuleDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountNetworkRuleDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleDeleteSettings ResetDebug(this AzureDlsAccountNetworkRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlsAccountNetworkRuleDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleDeleteSettings SetHelp(this AzureDlsAccountNetworkRuleDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountNetworkRuleDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleDeleteSettings ResetHelp(this AzureDlsAccountNetworkRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlsAccountNetworkRuleDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleDeleteSettings SetOutput(this AzureDlsAccountNetworkRuleDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountNetworkRuleDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleDeleteSettings ResetOutput(this AzureDlsAccountNetworkRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlsAccountNetworkRuleDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleDeleteSettings SetQuery(this AzureDlsAccountNetworkRuleDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountNetworkRuleDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleDeleteSettings ResetQuery(this AzureDlsAccountNetworkRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlsAccountNetworkRuleDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleDeleteSettings SetVerbose(this AzureDlsAccountNetworkRuleDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountNetworkRuleDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleDeleteSettings ResetVerbose(this AzureDlsAccountNetworkRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlsAccountNetworkRuleListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlsAccountNetworkRuleListSettingsExtensions
    {
        #region AccountName
        /// <summary><p><em>Sets <see cref="AzureDlsAccountNetworkRuleListSettings.AccountName"/>.</em></p><p>Name of the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleListSettings SetAccountName(this AzureDlsAccountNetworkRuleListSettings toolSettings, string accountName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = accountName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountNetworkRuleListSettings.AccountName"/>.</em></p><p>Name of the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleListSettings ResetAccountName(this AzureDlsAccountNetworkRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureDlsAccountNetworkRuleListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleListSettings SetResourceGroup(this AzureDlsAccountNetworkRuleListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountNetworkRuleListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleListSettings ResetResourceGroup(this AzureDlsAccountNetworkRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlsAccountNetworkRuleListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleListSettings SetDebug(this AzureDlsAccountNetworkRuleListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountNetworkRuleListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleListSettings ResetDebug(this AzureDlsAccountNetworkRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlsAccountNetworkRuleListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleListSettings SetHelp(this AzureDlsAccountNetworkRuleListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountNetworkRuleListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleListSettings ResetHelp(this AzureDlsAccountNetworkRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlsAccountNetworkRuleListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleListSettings SetOutput(this AzureDlsAccountNetworkRuleListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountNetworkRuleListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleListSettings ResetOutput(this AzureDlsAccountNetworkRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlsAccountNetworkRuleListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleListSettings SetQuery(this AzureDlsAccountNetworkRuleListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountNetworkRuleListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleListSettings ResetQuery(this AzureDlsAccountNetworkRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlsAccountNetworkRuleListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleListSettings SetVerbose(this AzureDlsAccountNetworkRuleListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountNetworkRuleListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleListSettings ResetVerbose(this AzureDlsAccountNetworkRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlsAccountNetworkRuleShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlsAccountNetworkRuleShowSettingsExtensions
    {
        #region AccountName
        /// <summary><p><em>Sets <see cref="AzureDlsAccountNetworkRuleShowSettings.AccountName"/>.</em></p><p>Name of the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleShowSettings SetAccountName(this AzureDlsAccountNetworkRuleShowSettings toolSettings, string accountName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = accountName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountNetworkRuleShowSettings.AccountName"/>.</em></p><p>Name of the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleShowSettings ResetAccountName(this AzureDlsAccountNetworkRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureDlsAccountNetworkRuleShowSettings.Name"/>.</em></p><p>The virtual network rule name.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleShowSettings SetName(this AzureDlsAccountNetworkRuleShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountNetworkRuleShowSettings.Name"/>.</em></p><p>The virtual network rule name.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleShowSettings ResetName(this AzureDlsAccountNetworkRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureDlsAccountNetworkRuleShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleShowSettings SetResourceGroup(this AzureDlsAccountNetworkRuleShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountNetworkRuleShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleShowSettings ResetResourceGroup(this AzureDlsAccountNetworkRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlsAccountNetworkRuleShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleShowSettings SetDebug(this AzureDlsAccountNetworkRuleShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountNetworkRuleShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleShowSettings ResetDebug(this AzureDlsAccountNetworkRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlsAccountNetworkRuleShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleShowSettings SetHelp(this AzureDlsAccountNetworkRuleShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountNetworkRuleShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleShowSettings ResetHelp(this AzureDlsAccountNetworkRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlsAccountNetworkRuleShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleShowSettings SetOutput(this AzureDlsAccountNetworkRuleShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountNetworkRuleShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleShowSettings ResetOutput(this AzureDlsAccountNetworkRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlsAccountNetworkRuleShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleShowSettings SetQuery(this AzureDlsAccountNetworkRuleShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountNetworkRuleShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleShowSettings ResetQuery(this AzureDlsAccountNetworkRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlsAccountNetworkRuleShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleShowSettings SetVerbose(this AzureDlsAccountNetworkRuleShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountNetworkRuleShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleShowSettings ResetVerbose(this AzureDlsAccountNetworkRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlsAccountNetworkRuleUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlsAccountNetworkRuleUpdateSettingsExtensions
    {
        #region AccountName
        /// <summary><p><em>Sets <see cref="AzureDlsAccountNetworkRuleUpdateSettings.AccountName"/>.</em></p><p>Name of the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleUpdateSettings SetAccountName(this AzureDlsAccountNetworkRuleUpdateSettings toolSettings, string accountName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = accountName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountNetworkRuleUpdateSettings.AccountName"/>.</em></p><p>Name of the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleUpdateSettings ResetAccountName(this AzureDlsAccountNetworkRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureDlsAccountNetworkRuleUpdateSettings.Name"/>.</em></p><p>The virtual network rule name.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleUpdateSettings SetName(this AzureDlsAccountNetworkRuleUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountNetworkRuleUpdateSettings.Name"/>.</em></p><p>The virtual network rule name.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleUpdateSettings ResetName(this AzureDlsAccountNetworkRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Subnet
        /// <summary><p><em>Sets <see cref="AzureDlsAccountNetworkRuleUpdateSettings.Subnet"/>.</em></p><p>Name or ID of the subnet that allows access to DLS. If subnet name is provided, --name must be provided.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleUpdateSettings SetSubnet(this AzureDlsAccountNetworkRuleUpdateSettings toolSettings, string subnet)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subnet = subnet;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountNetworkRuleUpdateSettings.Subnet"/>.</em></p><p>Name or ID of the subnet that allows access to DLS. If subnet name is provided, --name must be provided.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleUpdateSettings ResetSubnet(this AzureDlsAccountNetworkRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subnet = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureDlsAccountNetworkRuleUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleUpdateSettings SetResourceGroup(this AzureDlsAccountNetworkRuleUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountNetworkRuleUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleUpdateSettings ResetResourceGroup(this AzureDlsAccountNetworkRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region VnetName
        /// <summary><p><em>Sets <see cref="AzureDlsAccountNetworkRuleUpdateSettings.VnetName"/>.</em></p><p>The virtual network rule name.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleUpdateSettings SetVnetName(this AzureDlsAccountNetworkRuleUpdateSettings toolSettings, string vnetName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VnetName = vnetName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountNetworkRuleUpdateSettings.VnetName"/>.</em></p><p>The virtual network rule name.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleUpdateSettings ResetVnetName(this AzureDlsAccountNetworkRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VnetName = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary><p><em>Sets <see cref="AzureDlsAccountNetworkRuleUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleUpdateSettings SetAdd(this AzureDlsAccountNetworkRuleUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountNetworkRuleUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleUpdateSettings ResetAdd(this AzureDlsAccountNetworkRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region ForceString
        /// <summary><p><em>Sets <see cref="AzureDlsAccountNetworkRuleUpdateSettings.ForceString"/>.</em></p><p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleUpdateSettings SetForceString(this AzureDlsAccountNetworkRuleUpdateSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountNetworkRuleUpdateSettings.ForceString"/>.</em></p><p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleUpdateSettings ResetForceString(this AzureDlsAccountNetworkRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary><p><em>Sets <see cref="AzureDlsAccountNetworkRuleUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleUpdateSettings SetRemove(this AzureDlsAccountNetworkRuleUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountNetworkRuleUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleUpdateSettings ResetRemove(this AzureDlsAccountNetworkRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary><p><em>Sets <see cref="AzureDlsAccountNetworkRuleUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleUpdateSettings SetSet(this AzureDlsAccountNetworkRuleUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountNetworkRuleUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleUpdateSettings ResetSet(this AzureDlsAccountNetworkRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlsAccountNetworkRuleUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleUpdateSettings SetDebug(this AzureDlsAccountNetworkRuleUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountNetworkRuleUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleUpdateSettings ResetDebug(this AzureDlsAccountNetworkRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlsAccountNetworkRuleUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleUpdateSettings SetHelp(this AzureDlsAccountNetworkRuleUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountNetworkRuleUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleUpdateSettings ResetHelp(this AzureDlsAccountNetworkRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlsAccountNetworkRuleUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleUpdateSettings SetOutput(this AzureDlsAccountNetworkRuleUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountNetworkRuleUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleUpdateSettings ResetOutput(this AzureDlsAccountNetworkRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlsAccountNetworkRuleUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleUpdateSettings SetQuery(this AzureDlsAccountNetworkRuleUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountNetworkRuleUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleUpdateSettings ResetQuery(this AzureDlsAccountNetworkRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlsAccountNetworkRuleUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleUpdateSettings SetVerbose(this AzureDlsAccountNetworkRuleUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsAccountNetworkRuleUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsAccountNetworkRuleUpdateSettings ResetVerbose(this AzureDlsAccountNetworkRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlsFsAccessRemoveAllSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlsFsAccessRemoveAllSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlsFsAccessRemoveAllSettings.Account"/>.</em></p><p>Name of the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsFsAccessRemoveAllSettings SetAccount(this AzureDlsFsAccessRemoveAllSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsAccessRemoveAllSettings.Account"/>.</em></p><p>Name of the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsFsAccessRemoveAllSettings ResetAccount(this AzureDlsFsAccessRemoveAllSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region Path
        /// <summary><p><em>Sets <see cref="AzureDlsFsAccessRemoveAllSettings.Path"/>.</em></p><p>The path in the specified Data Lake Store account where the action should take place. In the format '/folder/file.txt', where the first '/' after the DNS indicates the root of the file system.</p></summary>
        [Pure]
        public static AzureDlsFsAccessRemoveAllSettings SetPath(this AzureDlsFsAccessRemoveAllSettings toolSettings, string path)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = path;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsAccessRemoveAllSettings.Path"/>.</em></p><p>The path in the specified Data Lake Store account where the action should take place. In the format '/folder/file.txt', where the first '/' after the DNS indicates the root of the file system.</p></summary>
        [Pure]
        public static AzureDlsFsAccessRemoveAllSettings ResetPath(this AzureDlsFsAccessRemoveAllSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = null;
            return toolSettings;
        }
        #endregion
        #region DefaultAcl
        /// <summary><p><em>Sets <see cref="AzureDlsFsAccessRemoveAllSettings.DefaultAcl"/>.</em></p><p>A switch that, if specified, indicates that the remove ACL operation should remove the default ACL of the folder. Otherwise the regular ACL is removed.</p></summary>
        [Pure]
        public static AzureDlsFsAccessRemoveAllSettings SetDefaultAcl(this AzureDlsFsAccessRemoveAllSettings toolSettings, string defaultAcl)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DefaultAcl = defaultAcl;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsAccessRemoveAllSettings.DefaultAcl"/>.</em></p><p>A switch that, if specified, indicates that the remove ACL operation should remove the default ACL of the folder. Otherwise the regular ACL is removed.</p></summary>
        [Pure]
        public static AzureDlsFsAccessRemoveAllSettings ResetDefaultAcl(this AzureDlsFsAccessRemoveAllSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DefaultAcl = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlsFsAccessRemoveAllSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsFsAccessRemoveAllSettings SetDebug(this AzureDlsFsAccessRemoveAllSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsAccessRemoveAllSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsFsAccessRemoveAllSettings ResetDebug(this AzureDlsFsAccessRemoveAllSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlsFsAccessRemoveAllSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsFsAccessRemoveAllSettings SetHelp(this AzureDlsFsAccessRemoveAllSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsAccessRemoveAllSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsFsAccessRemoveAllSettings ResetHelp(this AzureDlsFsAccessRemoveAllSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlsFsAccessRemoveAllSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsFsAccessRemoveAllSettings SetOutput(this AzureDlsFsAccessRemoveAllSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsAccessRemoveAllSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsFsAccessRemoveAllSettings ResetOutput(this AzureDlsFsAccessRemoveAllSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlsFsAccessRemoveAllSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsFsAccessRemoveAllSettings SetQuery(this AzureDlsFsAccessRemoveAllSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsAccessRemoveAllSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsFsAccessRemoveAllSettings ResetQuery(this AzureDlsFsAccessRemoveAllSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlsFsAccessRemoveAllSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsFsAccessRemoveAllSettings SetVerbose(this AzureDlsFsAccessRemoveAllSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsAccessRemoveAllSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsFsAccessRemoveAllSettings ResetVerbose(this AzureDlsFsAccessRemoveAllSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlsFsAccessRemoveEntrySettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlsFsAccessRemoveEntrySettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlsFsAccessRemoveEntrySettings.Account"/>.</em></p><p>Name of the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsFsAccessRemoveEntrySettings SetAccount(this AzureDlsFsAccessRemoveEntrySettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsAccessRemoveEntrySettings.Account"/>.</em></p><p>Name of the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsFsAccessRemoveEntrySettings ResetAccount(this AzureDlsFsAccessRemoveEntrySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region AclSpec
        /// <summary><p><em>Sets <see cref="AzureDlsFsAccessRemoveEntrySettings.AclSpec"/>.</em></p><p>The ACL specification to set on the path in the format '[default:]user|group|other:[entity id or UPN]:r|-w|-x|-,[default:]user|group|other:[entity id or UPN]:r|-w|-x|-,...'.</p></summary>
        [Pure]
        public static AzureDlsFsAccessRemoveEntrySettings SetAclSpec(this AzureDlsFsAccessRemoveEntrySettings toolSettings, string aclSpec)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AclSpec = aclSpec;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsAccessRemoveEntrySettings.AclSpec"/>.</em></p><p>The ACL specification to set on the path in the format '[default:]user|group|other:[entity id or UPN]:r|-w|-x|-,[default:]user|group|other:[entity id or UPN]:r|-w|-x|-,...'.</p></summary>
        [Pure]
        public static AzureDlsFsAccessRemoveEntrySettings ResetAclSpec(this AzureDlsFsAccessRemoveEntrySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AclSpec = null;
            return toolSettings;
        }
        #endregion
        #region Path
        /// <summary><p><em>Sets <see cref="AzureDlsFsAccessRemoveEntrySettings.Path"/>.</em></p><p>The path in the specified Data Lake Store account where the action should take place. In the format '/folder/file.txt', where the first '/' after the DNS indicates the root of the file system.</p></summary>
        [Pure]
        public static AzureDlsFsAccessRemoveEntrySettings SetPath(this AzureDlsFsAccessRemoveEntrySettings toolSettings, string path)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = path;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsAccessRemoveEntrySettings.Path"/>.</em></p><p>The path in the specified Data Lake Store account where the action should take place. In the format '/folder/file.txt', where the first '/' after the DNS indicates the root of the file system.</p></summary>
        [Pure]
        public static AzureDlsFsAccessRemoveEntrySettings ResetPath(this AzureDlsFsAccessRemoveEntrySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlsFsAccessRemoveEntrySettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsFsAccessRemoveEntrySettings SetDebug(this AzureDlsFsAccessRemoveEntrySettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsAccessRemoveEntrySettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsFsAccessRemoveEntrySettings ResetDebug(this AzureDlsFsAccessRemoveEntrySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlsFsAccessRemoveEntrySettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsFsAccessRemoveEntrySettings SetHelp(this AzureDlsFsAccessRemoveEntrySettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsAccessRemoveEntrySettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsFsAccessRemoveEntrySettings ResetHelp(this AzureDlsFsAccessRemoveEntrySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlsFsAccessRemoveEntrySettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsFsAccessRemoveEntrySettings SetOutput(this AzureDlsFsAccessRemoveEntrySettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsAccessRemoveEntrySettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsFsAccessRemoveEntrySettings ResetOutput(this AzureDlsFsAccessRemoveEntrySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlsFsAccessRemoveEntrySettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsFsAccessRemoveEntrySettings SetQuery(this AzureDlsFsAccessRemoveEntrySettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsAccessRemoveEntrySettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsFsAccessRemoveEntrySettings ResetQuery(this AzureDlsFsAccessRemoveEntrySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlsFsAccessRemoveEntrySettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsFsAccessRemoveEntrySettings SetVerbose(this AzureDlsFsAccessRemoveEntrySettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsAccessRemoveEntrySettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsFsAccessRemoveEntrySettings ResetVerbose(this AzureDlsFsAccessRemoveEntrySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlsFsAccessSetSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlsFsAccessSetSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlsFsAccessSetSettings.Account"/>.</em></p><p>Name of the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsFsAccessSetSettings SetAccount(this AzureDlsFsAccessSetSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsAccessSetSettings.Account"/>.</em></p><p>Name of the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsFsAccessSetSettings ResetAccount(this AzureDlsFsAccessSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region AclSpec
        /// <summary><p><em>Sets <see cref="AzureDlsFsAccessSetSettings.AclSpec"/>.</em></p><p>The ACL specification to set on the path in the format '[default:]user|group|other:[entity id or UPN]:r|-w|-x|-,[default:]user|group|other:[entity id or UPN]:r|-w|-x|-,...'.</p></summary>
        [Pure]
        public static AzureDlsFsAccessSetSettings SetAclSpec(this AzureDlsFsAccessSetSettings toolSettings, string aclSpec)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AclSpec = aclSpec;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsAccessSetSettings.AclSpec"/>.</em></p><p>The ACL specification to set on the path in the format '[default:]user|group|other:[entity id or UPN]:r|-w|-x|-,[default:]user|group|other:[entity id or UPN]:r|-w|-x|-,...'.</p></summary>
        [Pure]
        public static AzureDlsFsAccessSetSettings ResetAclSpec(this AzureDlsFsAccessSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AclSpec = null;
            return toolSettings;
        }
        #endregion
        #region Path
        /// <summary><p><em>Sets <see cref="AzureDlsFsAccessSetSettings.Path"/>.</em></p><p>The path in the specified Data Lake Store account where the action should take place. In the format '/folder/file.txt', where the first '/' after the DNS indicates the root of the file system.</p></summary>
        [Pure]
        public static AzureDlsFsAccessSetSettings SetPath(this AzureDlsFsAccessSetSettings toolSettings, string path)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = path;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsAccessSetSettings.Path"/>.</em></p><p>The path in the specified Data Lake Store account where the action should take place. In the format '/folder/file.txt', where the first '/' after the DNS indicates the root of the file system.</p></summary>
        [Pure]
        public static AzureDlsFsAccessSetSettings ResetPath(this AzureDlsFsAccessSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlsFsAccessSetSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsFsAccessSetSettings SetDebug(this AzureDlsFsAccessSetSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsAccessSetSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsFsAccessSetSettings ResetDebug(this AzureDlsFsAccessSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlsFsAccessSetSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsFsAccessSetSettings SetHelp(this AzureDlsFsAccessSetSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsAccessSetSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsFsAccessSetSettings ResetHelp(this AzureDlsFsAccessSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlsFsAccessSetSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsFsAccessSetSettings SetOutput(this AzureDlsFsAccessSetSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsAccessSetSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsFsAccessSetSettings ResetOutput(this AzureDlsFsAccessSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlsFsAccessSetSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsFsAccessSetSettings SetQuery(this AzureDlsFsAccessSetSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsAccessSetSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsFsAccessSetSettings ResetQuery(this AzureDlsFsAccessSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlsFsAccessSetSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsFsAccessSetSettings SetVerbose(this AzureDlsFsAccessSetSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsAccessSetSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsFsAccessSetSettings ResetVerbose(this AzureDlsFsAccessSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlsFsAccessSetEntrySettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlsFsAccessSetEntrySettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlsFsAccessSetEntrySettings.Account"/>.</em></p><p>Name of the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsFsAccessSetEntrySettings SetAccount(this AzureDlsFsAccessSetEntrySettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsAccessSetEntrySettings.Account"/>.</em></p><p>Name of the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsFsAccessSetEntrySettings ResetAccount(this AzureDlsFsAccessSetEntrySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region AclSpec
        /// <summary><p><em>Sets <see cref="AzureDlsFsAccessSetEntrySettings.AclSpec"/>.</em></p><p>The ACL specification to set on the path in the format '[default:]user|group|other:[entity id or UPN]:r|-w|-x|-,[default:]user|group|other:[entity id or UPN]:r|-w|-x|-,...'.</p></summary>
        [Pure]
        public static AzureDlsFsAccessSetEntrySettings SetAclSpec(this AzureDlsFsAccessSetEntrySettings toolSettings, string aclSpec)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AclSpec = aclSpec;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsAccessSetEntrySettings.AclSpec"/>.</em></p><p>The ACL specification to set on the path in the format '[default:]user|group|other:[entity id or UPN]:r|-w|-x|-,[default:]user|group|other:[entity id or UPN]:r|-w|-x|-,...'.</p></summary>
        [Pure]
        public static AzureDlsFsAccessSetEntrySettings ResetAclSpec(this AzureDlsFsAccessSetEntrySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AclSpec = null;
            return toolSettings;
        }
        #endregion
        #region Path
        /// <summary><p><em>Sets <see cref="AzureDlsFsAccessSetEntrySettings.Path"/>.</em></p><p>The path in the specified Data Lake Store account where the action should take place. In the format '/folder/file.txt', where the first '/' after the DNS indicates the root of the file system.</p></summary>
        [Pure]
        public static AzureDlsFsAccessSetEntrySettings SetPath(this AzureDlsFsAccessSetEntrySettings toolSettings, string path)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = path;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsAccessSetEntrySettings.Path"/>.</em></p><p>The path in the specified Data Lake Store account where the action should take place. In the format '/folder/file.txt', where the first '/' after the DNS indicates the root of the file system.</p></summary>
        [Pure]
        public static AzureDlsFsAccessSetEntrySettings ResetPath(this AzureDlsFsAccessSetEntrySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlsFsAccessSetEntrySettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsFsAccessSetEntrySettings SetDebug(this AzureDlsFsAccessSetEntrySettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsAccessSetEntrySettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsFsAccessSetEntrySettings ResetDebug(this AzureDlsFsAccessSetEntrySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlsFsAccessSetEntrySettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsFsAccessSetEntrySettings SetHelp(this AzureDlsFsAccessSetEntrySettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsAccessSetEntrySettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsFsAccessSetEntrySettings ResetHelp(this AzureDlsFsAccessSetEntrySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlsFsAccessSetEntrySettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsFsAccessSetEntrySettings SetOutput(this AzureDlsFsAccessSetEntrySettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsAccessSetEntrySettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsFsAccessSetEntrySettings ResetOutput(this AzureDlsFsAccessSetEntrySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlsFsAccessSetEntrySettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsFsAccessSetEntrySettings SetQuery(this AzureDlsFsAccessSetEntrySettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsAccessSetEntrySettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsFsAccessSetEntrySettings ResetQuery(this AzureDlsFsAccessSetEntrySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlsFsAccessSetEntrySettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsFsAccessSetEntrySettings SetVerbose(this AzureDlsFsAccessSetEntrySettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsAccessSetEntrySettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsFsAccessSetEntrySettings ResetVerbose(this AzureDlsFsAccessSetEntrySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlsFsAccessSetOwnerSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlsFsAccessSetOwnerSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlsFsAccessSetOwnerSettings.Account"/>.</em></p><p>Name of the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsFsAccessSetOwnerSettings SetAccount(this AzureDlsFsAccessSetOwnerSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsAccessSetOwnerSettings.Account"/>.</em></p><p>Name of the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsFsAccessSetOwnerSettings ResetAccount(this AzureDlsFsAccessSetOwnerSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region Path
        /// <summary><p><em>Sets <see cref="AzureDlsFsAccessSetOwnerSettings.Path"/>.</em></p><p>The path in the specified Data Lake Store account where the action should take place. In the format '/folder/file.txt', where the first '/' after the DNS indicates the root of the file system.</p></summary>
        [Pure]
        public static AzureDlsFsAccessSetOwnerSettings SetPath(this AzureDlsFsAccessSetOwnerSettings toolSettings, string path)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = path;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsAccessSetOwnerSettings.Path"/>.</em></p><p>The path in the specified Data Lake Store account where the action should take place. In the format '/folder/file.txt', where the first '/' after the DNS indicates the root of the file system.</p></summary>
        [Pure]
        public static AzureDlsFsAccessSetOwnerSettings ResetPath(this AzureDlsFsAccessSetOwnerSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = null;
            return toolSettings;
        }
        #endregion
        #region Group
        /// <summary><p><em>Sets <see cref="AzureDlsFsAccessSetOwnerSettings.Group"/>.</em></p><p>The group Azure Active Directory object ID or user principal name to set as the owning group.</p></summary>
        [Pure]
        public static AzureDlsFsAccessSetOwnerSettings SetGroup(this AzureDlsFsAccessSetOwnerSettings toolSettings, string group)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Group = group;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsAccessSetOwnerSettings.Group"/>.</em></p><p>The group Azure Active Directory object ID or user principal name to set as the owning group.</p></summary>
        [Pure]
        public static AzureDlsFsAccessSetOwnerSettings ResetGroup(this AzureDlsFsAccessSetOwnerSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Group = null;
            return toolSettings;
        }
        #endregion
        #region Owner
        /// <summary><p><em>Sets <see cref="AzureDlsFsAccessSetOwnerSettings.Owner"/>.</em></p><p>The user Azure Active Directory object ID or user principal name to set as the owner.</p></summary>
        [Pure]
        public static AzureDlsFsAccessSetOwnerSettings SetOwner(this AzureDlsFsAccessSetOwnerSettings toolSettings, string owner)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Owner = owner;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsAccessSetOwnerSettings.Owner"/>.</em></p><p>The user Azure Active Directory object ID or user principal name to set as the owner.</p></summary>
        [Pure]
        public static AzureDlsFsAccessSetOwnerSettings ResetOwner(this AzureDlsFsAccessSetOwnerSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Owner = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlsFsAccessSetOwnerSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsFsAccessSetOwnerSettings SetDebug(this AzureDlsFsAccessSetOwnerSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsAccessSetOwnerSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsFsAccessSetOwnerSettings ResetDebug(this AzureDlsFsAccessSetOwnerSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlsFsAccessSetOwnerSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsFsAccessSetOwnerSettings SetHelp(this AzureDlsFsAccessSetOwnerSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsAccessSetOwnerSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsFsAccessSetOwnerSettings ResetHelp(this AzureDlsFsAccessSetOwnerSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlsFsAccessSetOwnerSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsFsAccessSetOwnerSettings SetOutput(this AzureDlsFsAccessSetOwnerSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsAccessSetOwnerSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsFsAccessSetOwnerSettings ResetOutput(this AzureDlsFsAccessSetOwnerSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlsFsAccessSetOwnerSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsFsAccessSetOwnerSettings SetQuery(this AzureDlsFsAccessSetOwnerSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsAccessSetOwnerSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsFsAccessSetOwnerSettings ResetQuery(this AzureDlsFsAccessSetOwnerSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlsFsAccessSetOwnerSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsFsAccessSetOwnerSettings SetVerbose(this AzureDlsFsAccessSetOwnerSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsAccessSetOwnerSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsFsAccessSetOwnerSettings ResetVerbose(this AzureDlsFsAccessSetOwnerSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlsFsAccessSetPermissionSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlsFsAccessSetPermissionSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlsFsAccessSetPermissionSettings.Account"/>.</em></p><p>Name of the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsFsAccessSetPermissionSettings SetAccount(this AzureDlsFsAccessSetPermissionSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsAccessSetPermissionSettings.Account"/>.</em></p><p>Name of the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsFsAccessSetPermissionSettings ResetAccount(this AzureDlsFsAccessSetPermissionSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region Path
        /// <summary><p><em>Sets <see cref="AzureDlsFsAccessSetPermissionSettings.Path"/>.</em></p><p>The path in the specified Data Lake Store account where the action should take place. In the format '/folder/file.txt', where the first '/' after the DNS indicates the root of the file system.</p></summary>
        [Pure]
        public static AzureDlsFsAccessSetPermissionSettings SetPath(this AzureDlsFsAccessSetPermissionSettings toolSettings, string path)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = path;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsAccessSetPermissionSettings.Path"/>.</em></p><p>The path in the specified Data Lake Store account where the action should take place. In the format '/folder/file.txt', where the first '/' after the DNS indicates the root of the file system.</p></summary>
        [Pure]
        public static AzureDlsFsAccessSetPermissionSettings ResetPath(this AzureDlsFsAccessSetPermissionSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = null;
            return toolSettings;
        }
        #endregion
        #region Permission
        /// <summary><p><em>Sets <see cref="AzureDlsFsAccessSetPermissionSettings.Permission"/>.</em></p><p>The octal representation of the permissions for user, group and mask.</p></summary>
        [Pure]
        public static AzureDlsFsAccessSetPermissionSettings SetPermission(this AzureDlsFsAccessSetPermissionSettings toolSettings, string permission)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Permission = permission;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsAccessSetPermissionSettings.Permission"/>.</em></p><p>The octal representation of the permissions for user, group and mask.</p></summary>
        [Pure]
        public static AzureDlsFsAccessSetPermissionSettings ResetPermission(this AzureDlsFsAccessSetPermissionSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Permission = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlsFsAccessSetPermissionSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsFsAccessSetPermissionSettings SetDebug(this AzureDlsFsAccessSetPermissionSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsAccessSetPermissionSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsFsAccessSetPermissionSettings ResetDebug(this AzureDlsFsAccessSetPermissionSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlsFsAccessSetPermissionSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsFsAccessSetPermissionSettings SetHelp(this AzureDlsFsAccessSetPermissionSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsAccessSetPermissionSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsFsAccessSetPermissionSettings ResetHelp(this AzureDlsFsAccessSetPermissionSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlsFsAccessSetPermissionSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsFsAccessSetPermissionSettings SetOutput(this AzureDlsFsAccessSetPermissionSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsAccessSetPermissionSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsFsAccessSetPermissionSettings ResetOutput(this AzureDlsFsAccessSetPermissionSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlsFsAccessSetPermissionSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsFsAccessSetPermissionSettings SetQuery(this AzureDlsFsAccessSetPermissionSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsAccessSetPermissionSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsFsAccessSetPermissionSettings ResetQuery(this AzureDlsFsAccessSetPermissionSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlsFsAccessSetPermissionSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsFsAccessSetPermissionSettings SetVerbose(this AzureDlsFsAccessSetPermissionSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsAccessSetPermissionSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsFsAccessSetPermissionSettings ResetVerbose(this AzureDlsFsAccessSetPermissionSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDlsFsAccessShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDlsFsAccessShowSettingsExtensions
    {
        #region Account
        /// <summary><p><em>Sets <see cref="AzureDlsFsAccessShowSettings.Account"/>.</em></p><p>Name of the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsFsAccessShowSettings SetAccount(this AzureDlsFsAccessShowSettings toolSettings, string account)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = account;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsAccessShowSettings.Account"/>.</em></p><p>Name of the Data Lake Store account.</p></summary>
        [Pure]
        public static AzureDlsFsAccessShowSettings ResetAccount(this AzureDlsFsAccessShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Account = null;
            return toolSettings;
        }
        #endregion
        #region Path
        /// <summary><p><em>Sets <see cref="AzureDlsFsAccessShowSettings.Path"/>.</em></p><p>The path in the specified Data Lake Store account where the action should take place. In the format '/folder/file.txt', where the first '/' after the DNS indicates the root of the file system.</p></summary>
        [Pure]
        public static AzureDlsFsAccessShowSettings SetPath(this AzureDlsFsAccessShowSettings toolSettings, string path)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = path;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsAccessShowSettings.Path"/>.</em></p><p>The path in the specified Data Lake Store account where the action should take place. In the format '/folder/file.txt', where the first '/' after the DNS indicates the root of the file system.</p></summary>
        [Pure]
        public static AzureDlsFsAccessShowSettings ResetPath(this AzureDlsFsAccessShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDlsFsAccessShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsFsAccessShowSettings SetDebug(this AzureDlsFsAccessShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsAccessShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDlsFsAccessShowSettings ResetDebug(this AzureDlsFsAccessShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDlsFsAccessShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsFsAccessShowSettings SetHelp(this AzureDlsFsAccessShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsAccessShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDlsFsAccessShowSettings ResetHelp(this AzureDlsFsAccessShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDlsFsAccessShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsFsAccessShowSettings SetOutput(this AzureDlsFsAccessShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsAccessShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDlsFsAccessShowSettings ResetOutput(this AzureDlsFsAccessShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDlsFsAccessShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsFsAccessShowSettings SetQuery(this AzureDlsFsAccessShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsAccessShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDlsFsAccessShowSettings ResetQuery(this AzureDlsFsAccessShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDlsFsAccessShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsFsAccessShowSettings SetVerbose(this AzureDlsFsAccessShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDlsFsAccessShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDlsFsAccessShowSettings ResetVerbose(this AzureDlsFsAccessShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region DlsAccountCreateEncryptionType
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class DlsAccountCreateEncryptionType : Enumeration
    {
        public static DlsAccountCreateEncryptionType servicemanaged = new DlsAccountCreateEncryptionType { Value = "servicemanaged" };
        public static DlsAccountCreateEncryptionType usermanaged = new DlsAccountCreateEncryptionType { Value = "usermanaged" };
    }
    #endregion
    #region DlsAccountTier
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class DlsAccountTier : Enumeration
    {
        public static DlsAccountTier commitment_100tb = new DlsAccountTier { Value = "commitment_100tb" };
        public static DlsAccountTier commitment_10tb = new DlsAccountTier { Value = "commitment_10tb" };
        public static DlsAccountTier commitment_1pb = new DlsAccountTier { Value = "commitment_1pb" };
        public static DlsAccountTier commitment_1tb = new DlsAccountTier { Value = "commitment_1tb" };
        public static DlsAccountTier commitment_500tb = new DlsAccountTier { Value = "commitment_500tb" };
        public static DlsAccountTier commitment_5pb = new DlsAccountTier { Value = "commitment_5pb" };
        public static DlsAccountTier consumption = new DlsAccountTier { Value = "consumption" };
    }
    #endregion
    #region DlsAccountUpdateAllowAzureIps
    /// <summary><p>Used within <see cref="AzureDlsTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class DlsAccountUpdateAllowAzureIps : Enumeration
    {
        public static DlsAccountUpdateAllowAzureIps disabled = new DlsAccountUpdateAllowAzureIps { Value = "disabled" };
        public static DlsAccountUpdateAllowAzureIps enabled = new DlsAccountUpdateAllowAzureIps { Value = "enabled" };
    }
    #endregion
}
