// Copyright Matthias Koch, Sebastian Karasek 2018.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

// Generated with Nuke.CodeGeneration, Version: 0.5.0 [CommitSha: 3eaf2b72].
// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/AzureKeyvault.json.

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
    public static partial class AzureKeyvaultTasks
    {
        /// <summary><p>Path to the AzureKeyvault executable.</p></summary>
        public static string AzureKeyvaultPath => ToolPathResolver.GetPathExecutable("az");
        /// <summary><p>Safeguard and maintain control of keys, secrets, and certificates.</p></summary>
        public static IEnumerable<string> AzureKeyvault(string arguments, string workingDirectory = null, ProcessSettings processSettings = null)
        {
            var process = ProcessTasks.StartProcess(AzureKeyvaultPath, arguments, workingDirectory, processSettings?.EnvironmentVariables, processSettings?.ExecutionTimeout, processSettings?.RedirectOutput ?? true);
            process.AssertZeroExitCode();
            return process.Output.Select(x => x.Text);
        }
        static partial void PreProcess(AzureKeyvaultCreateSettings toolSettings);
        static partial void PostProcess(AzureKeyvaultCreateSettings toolSettings);
        /// <summary><p>Safeguard and maintain control of keys, secrets, and certificates.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/keyvault?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureKeyvaultCreate(Configure<AzureKeyvaultCreateSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureKeyvaultCreateSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureKeyvaultDeleteSettings toolSettings);
        static partial void PostProcess(AzureKeyvaultDeleteSettings toolSettings);
        /// <summary><p>Safeguard and maintain control of keys, secrets, and certificates.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/keyvault?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureKeyvaultDelete(Configure<AzureKeyvaultDeleteSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureKeyvaultDeleteSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureKeyvaultDeletePolicySettings toolSettings);
        static partial void PostProcess(AzureKeyvaultDeletePolicySettings toolSettings);
        /// <summary><p>Safeguard and maintain control of keys, secrets, and certificates.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/keyvault?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureKeyvaultDeletePolicy(Configure<AzureKeyvaultDeletePolicySettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureKeyvaultDeletePolicySettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureKeyvaultListSettings toolSettings);
        static partial void PostProcess(AzureKeyvaultListSettings toolSettings);
        /// <summary><p>Safeguard and maintain control of keys, secrets, and certificates.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/keyvault?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureKeyvaultList(Configure<AzureKeyvaultListSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureKeyvaultListSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureKeyvaultListDeletedSettings toolSettings);
        static partial void PostProcess(AzureKeyvaultListDeletedSettings toolSettings);
        /// <summary><p>Safeguard and maintain control of keys, secrets, and certificates.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/keyvault?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureKeyvaultListDeleted(Configure<AzureKeyvaultListDeletedSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureKeyvaultListDeletedSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureKeyvaultPurgeSettings toolSettings);
        static partial void PostProcess(AzureKeyvaultPurgeSettings toolSettings);
        /// <summary><p>Safeguard and maintain control of keys, secrets, and certificates.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/keyvault?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureKeyvaultPurge(Configure<AzureKeyvaultPurgeSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureKeyvaultPurgeSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureKeyvaultRecoverSettings toolSettings);
        static partial void PostProcess(AzureKeyvaultRecoverSettings toolSettings);
        /// <summary><p>Safeguard and maintain control of keys, secrets, and certificates.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/keyvault?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureKeyvaultRecover(Configure<AzureKeyvaultRecoverSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureKeyvaultRecoverSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureKeyvaultSetPolicySettings toolSettings);
        static partial void PostProcess(AzureKeyvaultSetPolicySettings toolSettings);
        /// <summary><p>Safeguard and maintain control of keys, secrets, and certificates.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/keyvault?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureKeyvaultSetPolicy(Configure<AzureKeyvaultSetPolicySettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureKeyvaultSetPolicySettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureKeyvaultShowSettings toolSettings);
        static partial void PostProcess(AzureKeyvaultShowSettings toolSettings);
        /// <summary><p>Safeguard and maintain control of keys, secrets, and certificates.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/keyvault?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureKeyvaultShow(Configure<AzureKeyvaultShowSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureKeyvaultShowSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureKeyvaultUpdateSettings toolSettings);
        static partial void PostProcess(AzureKeyvaultUpdateSettings toolSettings);
        /// <summary><p>Safeguard and maintain control of keys, secrets, and certificates.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/keyvault?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureKeyvaultUpdate(Configure<AzureKeyvaultUpdateSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureKeyvaultUpdateSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureKeyvaultCertificateCreateSettings toolSettings);
        static partial void PostProcess(AzureKeyvaultCertificateCreateSettings toolSettings);
        /// <summary><p>Safeguard and maintain control of keys, secrets, and certificates.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/keyvault?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureKeyvaultCertificateCreate(Configure<AzureKeyvaultCertificateCreateSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureKeyvaultCertificateCreateSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureKeyvaultCertificateDeleteSettings toolSettings);
        static partial void PostProcess(AzureKeyvaultCertificateDeleteSettings toolSettings);
        /// <summary><p>Safeguard and maintain control of keys, secrets, and certificates.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/keyvault?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureKeyvaultCertificateDelete(Configure<AzureKeyvaultCertificateDeleteSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureKeyvaultCertificateDeleteSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureKeyvaultCertificateDownloadSettings toolSettings);
        static partial void PostProcess(AzureKeyvaultCertificateDownloadSettings toolSettings);
        /// <summary><p>Safeguard and maintain control of keys, secrets, and certificates.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/keyvault?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureKeyvaultCertificateDownload(Configure<AzureKeyvaultCertificateDownloadSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureKeyvaultCertificateDownloadSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureKeyvaultCertificateGetDefaultPolicySettings toolSettings);
        static partial void PostProcess(AzureKeyvaultCertificateGetDefaultPolicySettings toolSettings);
        /// <summary><p>Safeguard and maintain control of keys, secrets, and certificates.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/keyvault?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureKeyvaultCertificateGetDefaultPolicy(Configure<AzureKeyvaultCertificateGetDefaultPolicySettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureKeyvaultCertificateGetDefaultPolicySettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureKeyvaultCertificateImportSettings toolSettings);
        static partial void PostProcess(AzureKeyvaultCertificateImportSettings toolSettings);
        /// <summary><p>Safeguard and maintain control of keys, secrets, and certificates.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/keyvault?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureKeyvaultCertificateImport(Configure<AzureKeyvaultCertificateImportSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureKeyvaultCertificateImportSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureKeyvaultCertificateListSettings toolSettings);
        static partial void PostProcess(AzureKeyvaultCertificateListSettings toolSettings);
        /// <summary><p>Safeguard and maintain control of keys, secrets, and certificates.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/keyvault?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureKeyvaultCertificateList(Configure<AzureKeyvaultCertificateListSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureKeyvaultCertificateListSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureKeyvaultCertificateListDeletedSettings toolSettings);
        static partial void PostProcess(AzureKeyvaultCertificateListDeletedSettings toolSettings);
        /// <summary><p>Safeguard and maintain control of keys, secrets, and certificates.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/keyvault?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureKeyvaultCertificateListDeleted(Configure<AzureKeyvaultCertificateListDeletedSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureKeyvaultCertificateListDeletedSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureKeyvaultCertificateListVersionsSettings toolSettings);
        static partial void PostProcess(AzureKeyvaultCertificateListVersionsSettings toolSettings);
        /// <summary><p>Safeguard and maintain control of keys, secrets, and certificates.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/keyvault?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureKeyvaultCertificateListVersions(Configure<AzureKeyvaultCertificateListVersionsSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureKeyvaultCertificateListVersionsSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureKeyvaultCertificatePurgeSettings toolSettings);
        static partial void PostProcess(AzureKeyvaultCertificatePurgeSettings toolSettings);
        /// <summary><p>Safeguard and maintain control of keys, secrets, and certificates.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/keyvault?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureKeyvaultCertificatePurge(Configure<AzureKeyvaultCertificatePurgeSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureKeyvaultCertificatePurgeSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureKeyvaultCertificateRecoverSettings toolSettings);
        static partial void PostProcess(AzureKeyvaultCertificateRecoverSettings toolSettings);
        /// <summary><p>Safeguard and maintain control of keys, secrets, and certificates.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/keyvault?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureKeyvaultCertificateRecover(Configure<AzureKeyvaultCertificateRecoverSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureKeyvaultCertificateRecoverSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureKeyvaultCertificateSetAttributesSettings toolSettings);
        static partial void PostProcess(AzureKeyvaultCertificateSetAttributesSettings toolSettings);
        /// <summary><p>Safeguard and maintain control of keys, secrets, and certificates.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/keyvault?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureKeyvaultCertificateSetAttributes(Configure<AzureKeyvaultCertificateSetAttributesSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureKeyvaultCertificateSetAttributesSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureKeyvaultCertificateShowSettings toolSettings);
        static partial void PostProcess(AzureKeyvaultCertificateShowSettings toolSettings);
        /// <summary><p>Safeguard and maintain control of keys, secrets, and certificates.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/keyvault?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureKeyvaultCertificateShow(Configure<AzureKeyvaultCertificateShowSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureKeyvaultCertificateShowSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureKeyvaultCertificateShowDeletedSettings toolSettings);
        static partial void PostProcess(AzureKeyvaultCertificateShowDeletedSettings toolSettings);
        /// <summary><p>Safeguard and maintain control of keys, secrets, and certificates.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/keyvault?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureKeyvaultCertificateShowDeleted(Configure<AzureKeyvaultCertificateShowDeletedSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureKeyvaultCertificateShowDeletedSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureKeyvaultKeyBackupSettings toolSettings);
        static partial void PostProcess(AzureKeyvaultKeyBackupSettings toolSettings);
        /// <summary><p>Safeguard and maintain control of keys, secrets, and certificates.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/keyvault?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureKeyvaultKeyBackup(Configure<AzureKeyvaultKeyBackupSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureKeyvaultKeyBackupSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureKeyvaultKeyCreateSettings toolSettings);
        static partial void PostProcess(AzureKeyvaultKeyCreateSettings toolSettings);
        /// <summary><p>Safeguard and maintain control of keys, secrets, and certificates.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/keyvault?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureKeyvaultKeyCreate(Configure<AzureKeyvaultKeyCreateSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureKeyvaultKeyCreateSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureKeyvaultKeyDeleteSettings toolSettings);
        static partial void PostProcess(AzureKeyvaultKeyDeleteSettings toolSettings);
        /// <summary><p>Safeguard and maintain control of keys, secrets, and certificates.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/keyvault?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureKeyvaultKeyDelete(Configure<AzureKeyvaultKeyDeleteSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureKeyvaultKeyDeleteSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureKeyvaultKeyImportSettings toolSettings);
        static partial void PostProcess(AzureKeyvaultKeyImportSettings toolSettings);
        /// <summary><p>Safeguard and maintain control of keys, secrets, and certificates.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/keyvault?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureKeyvaultKeyImport(Configure<AzureKeyvaultKeyImportSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureKeyvaultKeyImportSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureKeyvaultKeyListSettings toolSettings);
        static partial void PostProcess(AzureKeyvaultKeyListSettings toolSettings);
        /// <summary><p>Safeguard and maintain control of keys, secrets, and certificates.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/keyvault?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureKeyvaultKeyList(Configure<AzureKeyvaultKeyListSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureKeyvaultKeyListSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureKeyvaultKeyListDeletedSettings toolSettings);
        static partial void PostProcess(AzureKeyvaultKeyListDeletedSettings toolSettings);
        /// <summary><p>Safeguard and maintain control of keys, secrets, and certificates.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/keyvault?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureKeyvaultKeyListDeleted(Configure<AzureKeyvaultKeyListDeletedSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureKeyvaultKeyListDeletedSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureKeyvaultKeyListVersionsSettings toolSettings);
        static partial void PostProcess(AzureKeyvaultKeyListVersionsSettings toolSettings);
        /// <summary><p>Safeguard and maintain control of keys, secrets, and certificates.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/keyvault?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureKeyvaultKeyListVersions(Configure<AzureKeyvaultKeyListVersionsSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureKeyvaultKeyListVersionsSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureKeyvaultKeyPurgeSettings toolSettings);
        static partial void PostProcess(AzureKeyvaultKeyPurgeSettings toolSettings);
        /// <summary><p>Safeguard and maintain control of keys, secrets, and certificates.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/keyvault?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureKeyvaultKeyPurge(Configure<AzureKeyvaultKeyPurgeSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureKeyvaultKeyPurgeSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureKeyvaultKeyRecoverSettings toolSettings);
        static partial void PostProcess(AzureKeyvaultKeyRecoverSettings toolSettings);
        /// <summary><p>Safeguard and maintain control of keys, secrets, and certificates.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/keyvault?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureKeyvaultKeyRecover(Configure<AzureKeyvaultKeyRecoverSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureKeyvaultKeyRecoverSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureKeyvaultKeyRestoreSettings toolSettings);
        static partial void PostProcess(AzureKeyvaultKeyRestoreSettings toolSettings);
        /// <summary><p>Safeguard and maintain control of keys, secrets, and certificates.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/keyvault?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureKeyvaultKeyRestore(Configure<AzureKeyvaultKeyRestoreSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureKeyvaultKeyRestoreSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureKeyvaultKeySetAttributesSettings toolSettings);
        static partial void PostProcess(AzureKeyvaultKeySetAttributesSettings toolSettings);
        /// <summary><p>Safeguard and maintain control of keys, secrets, and certificates.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/keyvault?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureKeyvaultKeySetAttributes(Configure<AzureKeyvaultKeySetAttributesSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureKeyvaultKeySetAttributesSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureKeyvaultKeyShowSettings toolSettings);
        static partial void PostProcess(AzureKeyvaultKeyShowSettings toolSettings);
        /// <summary><p>Safeguard and maintain control of keys, secrets, and certificates.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/keyvault?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureKeyvaultKeyShow(Configure<AzureKeyvaultKeyShowSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureKeyvaultKeyShowSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureKeyvaultKeyShowDeletedSettings toolSettings);
        static partial void PostProcess(AzureKeyvaultKeyShowDeletedSettings toolSettings);
        /// <summary><p>Safeguard and maintain control of keys, secrets, and certificates.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/keyvault?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureKeyvaultKeyShowDeleted(Configure<AzureKeyvaultKeyShowDeletedSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureKeyvaultKeyShowDeletedSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureKeyvaultSecretBackupSettings toolSettings);
        static partial void PostProcess(AzureKeyvaultSecretBackupSettings toolSettings);
        /// <summary><p>Safeguard and maintain control of keys, secrets, and certificates.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/keyvault?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureKeyvaultSecretBackup(Configure<AzureKeyvaultSecretBackupSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureKeyvaultSecretBackupSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureKeyvaultSecretDeleteSettings toolSettings);
        static partial void PostProcess(AzureKeyvaultSecretDeleteSettings toolSettings);
        /// <summary><p>Safeguard and maintain control of keys, secrets, and certificates.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/keyvault?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureKeyvaultSecretDelete(Configure<AzureKeyvaultSecretDeleteSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureKeyvaultSecretDeleteSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureKeyvaultSecretDownloadSettings toolSettings);
        static partial void PostProcess(AzureKeyvaultSecretDownloadSettings toolSettings);
        /// <summary><p>Safeguard and maintain control of keys, secrets, and certificates.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/keyvault?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureKeyvaultSecretDownload(Configure<AzureKeyvaultSecretDownloadSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureKeyvaultSecretDownloadSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureKeyvaultSecretListSettings toolSettings);
        static partial void PostProcess(AzureKeyvaultSecretListSettings toolSettings);
        /// <summary><p>Safeguard and maintain control of keys, secrets, and certificates.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/keyvault?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureKeyvaultSecretList(Configure<AzureKeyvaultSecretListSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureKeyvaultSecretListSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureKeyvaultSecretListDeletedSettings toolSettings);
        static partial void PostProcess(AzureKeyvaultSecretListDeletedSettings toolSettings);
        /// <summary><p>Safeguard and maintain control of keys, secrets, and certificates.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/keyvault?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureKeyvaultSecretListDeleted(Configure<AzureKeyvaultSecretListDeletedSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureKeyvaultSecretListDeletedSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureKeyvaultSecretListVersionsSettings toolSettings);
        static partial void PostProcess(AzureKeyvaultSecretListVersionsSettings toolSettings);
        /// <summary><p>Safeguard and maintain control of keys, secrets, and certificates.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/keyvault?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureKeyvaultSecretListVersions(Configure<AzureKeyvaultSecretListVersionsSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureKeyvaultSecretListVersionsSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureKeyvaultSecretPurgeSettings toolSettings);
        static partial void PostProcess(AzureKeyvaultSecretPurgeSettings toolSettings);
        /// <summary><p>Safeguard and maintain control of keys, secrets, and certificates.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/keyvault?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureKeyvaultSecretPurge(Configure<AzureKeyvaultSecretPurgeSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureKeyvaultSecretPurgeSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureKeyvaultSecretRecoverSettings toolSettings);
        static partial void PostProcess(AzureKeyvaultSecretRecoverSettings toolSettings);
        /// <summary><p>Safeguard and maintain control of keys, secrets, and certificates.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/keyvault?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureKeyvaultSecretRecover(Configure<AzureKeyvaultSecretRecoverSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureKeyvaultSecretRecoverSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureKeyvaultSecretRestoreSettings toolSettings);
        static partial void PostProcess(AzureKeyvaultSecretRestoreSettings toolSettings);
        /// <summary><p>Safeguard and maintain control of keys, secrets, and certificates.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/keyvault?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureKeyvaultSecretRestore(Configure<AzureKeyvaultSecretRestoreSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureKeyvaultSecretRestoreSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureKeyvaultSecretSetSettings toolSettings);
        static partial void PostProcess(AzureKeyvaultSecretSetSettings toolSettings);
        /// <summary><p>Safeguard and maintain control of keys, secrets, and certificates.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/keyvault?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureKeyvaultSecretSet(Configure<AzureKeyvaultSecretSetSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureKeyvaultSecretSetSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureKeyvaultSecretSetAttributesSettings toolSettings);
        static partial void PostProcess(AzureKeyvaultSecretSetAttributesSettings toolSettings);
        /// <summary><p>Safeguard and maintain control of keys, secrets, and certificates.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/keyvault?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureKeyvaultSecretSetAttributes(Configure<AzureKeyvaultSecretSetAttributesSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureKeyvaultSecretSetAttributesSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureKeyvaultSecretShowSettings toolSettings);
        static partial void PostProcess(AzureKeyvaultSecretShowSettings toolSettings);
        /// <summary><p>Safeguard and maintain control of keys, secrets, and certificates.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/keyvault?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureKeyvaultSecretShow(Configure<AzureKeyvaultSecretShowSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureKeyvaultSecretShowSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureKeyvaultSecretShowDeletedSettings toolSettings);
        static partial void PostProcess(AzureKeyvaultSecretShowDeletedSettings toolSettings);
        /// <summary><p>Safeguard and maintain control of keys, secrets, and certificates.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/keyvault?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureKeyvaultSecretShowDeleted(Configure<AzureKeyvaultSecretShowDeletedSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureKeyvaultSecretShowDeletedSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureKeyvaultCertificateContactAddSettings toolSettings);
        static partial void PostProcess(AzureKeyvaultCertificateContactAddSettings toolSettings);
        /// <summary><p>Safeguard and maintain control of keys, secrets, and certificates.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/keyvault?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureKeyvaultCertificateContactAdd(Configure<AzureKeyvaultCertificateContactAddSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureKeyvaultCertificateContactAddSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureKeyvaultCertificateContactDeleteSettings toolSettings);
        static partial void PostProcess(AzureKeyvaultCertificateContactDeleteSettings toolSettings);
        /// <summary><p>Safeguard and maintain control of keys, secrets, and certificates.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/keyvault?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureKeyvaultCertificateContactDelete(Configure<AzureKeyvaultCertificateContactDeleteSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureKeyvaultCertificateContactDeleteSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureKeyvaultCertificateContactListSettings toolSettings);
        static partial void PostProcess(AzureKeyvaultCertificateContactListSettings toolSettings);
        /// <summary><p>Safeguard and maintain control of keys, secrets, and certificates.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/keyvault?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureKeyvaultCertificateContactList(Configure<AzureKeyvaultCertificateContactListSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureKeyvaultCertificateContactListSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureKeyvaultCertificateIssuerCreateSettings toolSettings);
        static partial void PostProcess(AzureKeyvaultCertificateIssuerCreateSettings toolSettings);
        /// <summary><p>Safeguard and maintain control of keys, secrets, and certificates.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/keyvault?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureKeyvaultCertificateIssuerCreate(Configure<AzureKeyvaultCertificateIssuerCreateSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureKeyvaultCertificateIssuerCreateSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureKeyvaultCertificateIssuerDeleteSettings toolSettings);
        static partial void PostProcess(AzureKeyvaultCertificateIssuerDeleteSettings toolSettings);
        /// <summary><p>Safeguard and maintain control of keys, secrets, and certificates.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/keyvault?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureKeyvaultCertificateIssuerDelete(Configure<AzureKeyvaultCertificateIssuerDeleteSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureKeyvaultCertificateIssuerDeleteSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureKeyvaultCertificateIssuerListSettings toolSettings);
        static partial void PostProcess(AzureKeyvaultCertificateIssuerListSettings toolSettings);
        /// <summary><p>Safeguard and maintain control of keys, secrets, and certificates.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/keyvault?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureKeyvaultCertificateIssuerList(Configure<AzureKeyvaultCertificateIssuerListSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureKeyvaultCertificateIssuerListSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureKeyvaultCertificateIssuerShowSettings toolSettings);
        static partial void PostProcess(AzureKeyvaultCertificateIssuerShowSettings toolSettings);
        /// <summary><p>Safeguard and maintain control of keys, secrets, and certificates.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/keyvault?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureKeyvaultCertificateIssuerShow(Configure<AzureKeyvaultCertificateIssuerShowSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureKeyvaultCertificateIssuerShowSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureKeyvaultCertificateIssuerUpdateSettings toolSettings);
        static partial void PostProcess(AzureKeyvaultCertificateIssuerUpdateSettings toolSettings);
        /// <summary><p>Safeguard and maintain control of keys, secrets, and certificates.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/keyvault?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureKeyvaultCertificateIssuerUpdate(Configure<AzureKeyvaultCertificateIssuerUpdateSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureKeyvaultCertificateIssuerUpdateSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureKeyvaultCertificatePendingDeleteSettings toolSettings);
        static partial void PostProcess(AzureKeyvaultCertificatePendingDeleteSettings toolSettings);
        /// <summary><p>Safeguard and maintain control of keys, secrets, and certificates.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/keyvault?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureKeyvaultCertificatePendingDelete(Configure<AzureKeyvaultCertificatePendingDeleteSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureKeyvaultCertificatePendingDeleteSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureKeyvaultCertificatePendingMergeSettings toolSettings);
        static partial void PostProcess(AzureKeyvaultCertificatePendingMergeSettings toolSettings);
        /// <summary><p>Safeguard and maintain control of keys, secrets, and certificates.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/keyvault?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureKeyvaultCertificatePendingMerge(Configure<AzureKeyvaultCertificatePendingMergeSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureKeyvaultCertificatePendingMergeSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureKeyvaultCertificatePendingShowSettings toolSettings);
        static partial void PostProcess(AzureKeyvaultCertificatePendingShowSettings toolSettings);
        /// <summary><p>Safeguard and maintain control of keys, secrets, and certificates.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/keyvault?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureKeyvaultCertificatePendingShow(Configure<AzureKeyvaultCertificatePendingShowSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureKeyvaultCertificatePendingShowSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureKeyvaultCertificateIssuerAdminAddSettings toolSettings);
        static partial void PostProcess(AzureKeyvaultCertificateIssuerAdminAddSettings toolSettings);
        /// <summary><p>Safeguard and maintain control of keys, secrets, and certificates.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/keyvault?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureKeyvaultCertificateIssuerAdminAdd(Configure<AzureKeyvaultCertificateIssuerAdminAddSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureKeyvaultCertificateIssuerAdminAddSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureKeyvaultCertificateIssuerAdminDeleteSettings toolSettings);
        static partial void PostProcess(AzureKeyvaultCertificateIssuerAdminDeleteSettings toolSettings);
        /// <summary><p>Safeguard and maintain control of keys, secrets, and certificates.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/keyvault?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureKeyvaultCertificateIssuerAdminDelete(Configure<AzureKeyvaultCertificateIssuerAdminDeleteSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureKeyvaultCertificateIssuerAdminDeleteSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureKeyvaultCertificateIssuerAdminListSettings toolSettings);
        static partial void PostProcess(AzureKeyvaultCertificateIssuerAdminListSettings toolSettings);
        /// <summary><p>Safeguard and maintain control of keys, secrets, and certificates.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/keyvault?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureKeyvaultCertificateIssuerAdminList(Configure<AzureKeyvaultCertificateIssuerAdminListSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureKeyvaultCertificateIssuerAdminListSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
    }
    #region AzureKeyvaultCreateSettings
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureKeyvaultCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureKeyvault executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureKeyvaultTasks.AzureKeyvaultPath;
        /// <summary><p>Name of the key vault.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Enable vault deletion recovery for the vault, and all contained entities.</p></summary>
        public virtual bool? EnableSoftDelete { get; internal set; }
        /// <summary><p>Allow Virtual Machines to retrieve certificates stored as secrets from the vault.</p></summary>
        public virtual bool? EnabledForDeployment { get; internal set; }
        /// <summary><p>Allow Disk Encryption to retrieve secrets from the vault and unwrap keys.</p></summary>
        public virtual bool? EnabledForDiskEncryption { get; internal set; }
        /// <summary><p>Allow Resource Manager to retrieve secrets from the vault.</p></summary>
        public virtual bool? EnabledForTemplateDeployment { get; internal set; }
        /// <summary><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        public virtual string Location { get; internal set; }
        /// <summary><p>Don't add permissions for the current user/service principal in the new vault.</p></summary>
        public virtual bool? NoSelfPerms { get; internal set; }
        /// <summary><p>SKU details.</p></summary>
        public virtual KeyvaultCreateSku Sku { get; internal set; }
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
              .Add("keyvault create")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--enable-soft-delete", EnableSoftDelete)
              .Add("--enabled-for-deployment", EnabledForDeployment)
              .Add("--enabled-for-disk-encryption", EnabledForDiskEncryption)
              .Add("--enabled-for-template-deployment", EnabledForTemplateDeployment)
              .Add("--location {value}", Location)
              .Add("--no-self-perms", NoSelfPerms)
              .Add("--sku {value}", Sku)
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
    #region AzureKeyvaultDeleteSettings
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureKeyvaultDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureKeyvault executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureKeyvaultTasks.AzureKeyvaultPath;
        /// <summary><p>Name of the key vault.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Proceed only if Key Vault belongs to the specified resource group.</p></summary>
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
              .Add("keyvault delete")
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
    #region AzureKeyvaultDeletePolicySettings
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureKeyvaultDeletePolicySettings : ToolSettings
    {
        /// <summary><p>Path to the AzureKeyvault executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureKeyvaultTasks.AzureKeyvaultPath;
        /// <summary><p>Name of the key vault.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>A GUID that identifies the principal that will receive permissions.</p></summary>
        public virtual string ObjectId { get; internal set; }
        /// <summary><p>Proceed only if Key Vault belongs to the specified resource group.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name of a service principal that will receive permissions.</p></summary>
        public virtual string Spn { get; internal set; }
        /// <summary><p>Name of a user principal that will receive permissions.</p></summary>
        public virtual string Upn { get; internal set; }
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
              .Add("keyvault delete-policy")
              .Add("--name {value}", Name)
              .Add("--object-id {value}", ObjectId)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--spn {value}", Spn)
              .Add("--upn {value}", Upn)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureKeyvaultListSettings
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureKeyvaultListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureKeyvault executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureKeyvaultTasks.AzureKeyvaultPath;
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
              .Add("keyvault list")
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
    #region AzureKeyvaultListDeletedSettings
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureKeyvaultListDeletedSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureKeyvault executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureKeyvaultTasks.AzureKeyvaultPath;
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
              .Add("keyvault list-deleted")
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureKeyvaultPurgeSettings
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureKeyvaultPurgeSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureKeyvault executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureKeyvaultTasks.AzureKeyvaultPath;
        /// <summary><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        public virtual string Location { get; internal set; }
        /// <summary><p>Name of the key vault.</p></summary>
        public virtual string Name { get; internal set; }
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
              .Add("keyvault purge")
              .Add("--location {value}", Location)
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
    #region AzureKeyvaultRecoverSettings
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureKeyvaultRecoverSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureKeyvault executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureKeyvaultTasks.AzureKeyvaultPath;
        /// <summary><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        public virtual string Location { get; internal set; }
        /// <summary><p>Name of the key vault.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Proceed only if Key Vault belongs to the specified resource group.</p></summary>
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
              .Add("keyvault recover")
              .Add("--location {value}", Location)
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
    #region AzureKeyvaultSetPolicySettings
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureKeyvaultSetPolicySettings : ToolSettings
    {
        /// <summary><p>Path to the AzureKeyvault executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureKeyvaultTasks.AzureKeyvaultPath;
        /// <summary><p>Name of the key vault.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>A GUID that identifies the principal that will receive permissions.</p></summary>
        public virtual string ObjectId { get; internal set; }
        /// <summary><p>Proceed only if Key Vault belongs to the specified resource group.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name of a service principal that will receive permissions.</p></summary>
        public virtual string Spn { get; internal set; }
        /// <summary><p>Name of a user principal that will receive permissions.</p></summary>
        public virtual string Upn { get; internal set; }
        /// <summary><p>Space-separated list of certificate permissions to assign.</p></summary>
        public virtual IReadOnlyList<KeyvaultSetPolicyCertificatePermissions> CertificatePermissions => CertificatePermissionsInternal.AsReadOnly();
        internal List<KeyvaultSetPolicyCertificatePermissions> CertificatePermissionsInternal { get; set; } = new List<KeyvaultSetPolicyCertificatePermissions>();
        /// <summary><p>Space-separated list of key permissions to assign.</p></summary>
        public virtual IReadOnlyList<KeyvaultSetPolicyKeyPermissions> KeyPermissions => KeyPermissionsInternal.AsReadOnly();
        internal List<KeyvaultSetPolicyKeyPermissions> KeyPermissionsInternal { get; set; } = new List<KeyvaultSetPolicyKeyPermissions>();
        /// <summary><p>Space-separated list of secret permissions to assign.</p></summary>
        public virtual IReadOnlyList<KeyvaultSetPolicySecretPermissions> SecretPermissions => SecretPermissionsInternal.AsReadOnly();
        internal List<KeyvaultSetPolicySecretPermissions> SecretPermissionsInternal { get; set; } = new List<KeyvaultSetPolicySecretPermissions>();
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
              .Add("keyvault set-policy")
              .Add("--name {value}", Name)
              .Add("--object-id {value}", ObjectId)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--spn {value}", Spn)
              .Add("--upn {value}", Upn)
              .Add("--certificate-permissions {value}", CertificatePermissions, separator: ' ')
              .Add("--key-permissions {value}", KeyPermissions, separator: ' ')
              .Add("--secret-permissions {value}", SecretPermissions, separator: ' ')
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureKeyvaultShowSettings
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureKeyvaultShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureKeyvault executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureKeyvaultTasks.AzureKeyvaultPath;
        /// <summary><p>Name of the key vault.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Proceed only if Key Vault belongs to the specified resource group.</p></summary>
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
              .Add("keyvault show")
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
    #region AzureKeyvaultUpdateSettings
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureKeyvaultUpdateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureKeyvault executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureKeyvaultTasks.AzureKeyvaultPath;
        /// <summary><p>Name of the key vault.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Allow Virtual Machines to retrieve certificates stored as secrets from the vault.</p></summary>
        public virtual bool? EnabledForDeployment { get; internal set; }
        /// <summary><p>Allow Disk Encryption to retrieve secrets from the vault and unwrap keys.</p></summary>
        public virtual bool? EnabledForDiskEncryption { get; internal set; }
        /// <summary><p>Allow Resource Manager to retrieve secrets from the vault.</p></summary>
        public virtual bool? EnabledForTemplateDeployment { get; internal set; }
        /// <summary><p>Proceed only if Key Vault belongs to the specified resource group.</p></summary>
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
              .Add("keyvault update")
              .Add("--name {value}", Name)
              .Add("--enabled-for-deployment", EnabledForDeployment)
              .Add("--enabled-for-disk-encryption", EnabledForDiskEncryption)
              .Add("--enabled-for-template-deployment", EnabledForTemplateDeployment)
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
    #region AzureKeyvaultCertificateCreateSettings
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureKeyvaultCertificateCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureKeyvault executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureKeyvaultTasks.AzureKeyvaultPath;
        /// <summary><p>Name of the certificate.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>JSON encoded policy defintion. Use @{file} to load from a file.</p></summary>
        public virtual string Policy { get; internal set; }
        /// <summary><p>Name of the key vault.</p></summary>
        public virtual string VaultName { get; internal set; }
        /// <summary><p>Create certificate in disabled state.</p></summary>
        public virtual bool? Disabled { get; internal set; }
        /// <summary><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        public virtual string Tags { get; internal set; }
        /// <summary><p>Number of months the certificate is valid for. Overrides the value specified with --policy/-p.</p></summary>
        public virtual int? Validity { get; internal set; }
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
              .Add("keyvault certificate create")
              .Add("--name {value}", Name)
              .Add("--policy {value}", Policy)
              .Add("--vault-name {value}", VaultName)
              .Add("--disabled", Disabled)
              .Add("--tags {value}", Tags)
              .Add("--validity {value}", Validity)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureKeyvaultCertificateDeleteSettings
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureKeyvaultCertificateDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureKeyvault executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureKeyvaultTasks.AzureKeyvaultPath;
        /// <summary><p>Name of the certificate.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of the key vault.</p></summary>
        public virtual string VaultName { get; internal set; }
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
              .Add("keyvault certificate delete")
              .Add("--name {value}", Name)
              .Add("--vault-name {value}", VaultName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureKeyvaultCertificateDownloadSettings
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureKeyvaultCertificateDownloadSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureKeyvault executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureKeyvaultTasks.AzureKeyvaultPath;
        /// <summary><p>File to receive the binary certificate contents.</p></summary>
        public virtual string File { get; internal set; }
        /// <summary><p>Name of the certificate.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of the key vault.</p></summary>
        public virtual string VaultName { get; internal set; }
        /// <summary><p>Encoding of the certificate. DER will create a binary DER formatted x509 certificate, and PEM will create a base64 PEM x509 certificate.</p></summary>
        public virtual KeyvaultCertificateDownloadEncoding Encoding { get; internal set; }
        /// <summary><p>The certificate version. If omitted, uses the latest version.</p></summary>
        public virtual string Version { get; internal set; }
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
              .Add("keyvault certificate download")
              .Add("--file {value}", File)
              .Add("--name {value}", Name)
              .Add("--vault-name {value}", VaultName)
              .Add("--encoding {value}", Encoding)
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
    #region AzureKeyvaultCertificateGetDefaultPolicySettings
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureKeyvaultCertificateGetDefaultPolicySettings : ToolSettings
    {
        /// <summary><p>Path to the AzureKeyvault executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureKeyvaultTasks.AzureKeyvaultPath;
        /// <summary><p>Create a fully formed policy structure with default values.</p></summary>
        public virtual string Scaffold { get; internal set; }
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
              .Add("keyvault certificate get-default-policy")
              .Add("--scaffold {value}", Scaffold)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureKeyvaultCertificateImportSettings
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureKeyvaultCertificateImportSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureKeyvault executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureKeyvaultTasks.AzureKeyvaultPath;
        /// <summary><p>PKCS12 file or PEM file containing the certificate and private key.</p></summary>
        public virtual string File { get; internal set; }
        /// <summary><p>Name of the certificate.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of the key vault.</p></summary>
        public virtual string VaultName { get; internal set; }
        /// <summary><p>Import the certificate in disabled state.</p></summary>
        public virtual bool? Disabled { get; internal set; }
        /// <summary><p>If the private key in certificate is encrypted, the password used for encryption.</p></summary>
        public virtual string Password { get; internal set; }
        /// <summary><p>JSON encoded policy defintion. Use @{file} to load from a file.</p></summary>
        public virtual string Policy { get; internal set; }
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
              .Add("keyvault certificate import")
              .Add("--file {value}", File)
              .Add("--name {value}", Name)
              .Add("--vault-name {value}", VaultName)
              .Add("--disabled", Disabled)
              .Add("--password {value}", Password)
              .Add("--policy {value}", Policy)
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
    #region AzureKeyvaultCertificateListSettings
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureKeyvaultCertificateListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureKeyvault executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureKeyvaultTasks.AzureKeyvaultPath;
        /// <summary><p>Name of the key vault.</p></summary>
        public virtual string VaultName { get; internal set; }
        /// <summary><p>Maximum number of results to return in a page. If not specified the service will return up to 25 results.</p></summary>
        public virtual string Maxresults { get; internal set; }
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
              .Add("keyvault certificate list")
              .Add("--vault-name {value}", VaultName)
              .Add("--maxresults {value}", Maxresults)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureKeyvaultCertificateListDeletedSettings
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureKeyvaultCertificateListDeletedSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureKeyvault executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureKeyvaultTasks.AzureKeyvaultPath;
        /// <summary><p>Name of the key vault.</p></summary>
        public virtual string VaultName { get; internal set; }
        /// <summary><p>Maximum number of results to return in a page. If not specified the service will return up to 25 results.</p></summary>
        public virtual string Maxresults { get; internal set; }
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
              .Add("keyvault certificate list-deleted")
              .Add("--vault-name {value}", VaultName)
              .Add("--maxresults {value}", Maxresults)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureKeyvaultCertificateListVersionsSettings
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureKeyvaultCertificateListVersionsSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureKeyvault executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureKeyvaultTasks.AzureKeyvaultPath;
        /// <summary><p>Name of the certificate.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of the key vault.</p></summary>
        public virtual string VaultName { get; internal set; }
        /// <summary><p>Maximum number of results to return in a page. If not specified the service will return up to 25 results.</p></summary>
        public virtual string Maxresults { get; internal set; }
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
              .Add("keyvault certificate list-versions")
              .Add("--name {value}", Name)
              .Add("--vault-name {value}", VaultName)
              .Add("--maxresults {value}", Maxresults)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureKeyvaultCertificatePurgeSettings
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureKeyvaultCertificatePurgeSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureKeyvault executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureKeyvaultTasks.AzureKeyvaultPath;
        /// <summary><p>Name of the certificate.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of the key vault.</p></summary>
        public virtual string VaultName { get; internal set; }
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
              .Add("keyvault certificate purge")
              .Add("--name {value}", Name)
              .Add("--vault-name {value}", VaultName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureKeyvaultCertificateRecoverSettings
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureKeyvaultCertificateRecoverSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureKeyvault executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureKeyvaultTasks.AzureKeyvaultPath;
        /// <summary><p>Name of the certificate.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of the key vault.</p></summary>
        public virtual string VaultName { get; internal set; }
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
              .Add("keyvault certificate recover")
              .Add("--name {value}", Name)
              .Add("--vault-name {value}", VaultName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureKeyvaultCertificateSetAttributesSettings
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureKeyvaultCertificateSetAttributesSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureKeyvault executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureKeyvaultTasks.AzureKeyvaultPath;
        /// <summary><p>Name of the certificate.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of the key vault.</p></summary>
        public virtual string VaultName { get; internal set; }
        /// <summary><p>Enable the certificate.</p></summary>
        public virtual bool? Enabled { get; internal set; }
        /// <summary><p>JSON encoded policy defintion. Use @{file} to load from a file.</p></summary>
        public virtual string Policy { get; internal set; }
        /// <summary><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        public virtual string Tags { get; internal set; }
        /// <summary><p>The certificate version. If omitted, uses the latest version.</p></summary>
        public virtual string Version { get; internal set; }
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
              .Add("keyvault certificate set-attributes")
              .Add("--name {value}", Name)
              .Add("--vault-name {value}", VaultName)
              .Add("--enabled", Enabled)
              .Add("--policy {value}", Policy)
              .Add("--tags {value}", Tags)
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
    #region AzureKeyvaultCertificateShowSettings
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureKeyvaultCertificateShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureKeyvault executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureKeyvaultTasks.AzureKeyvaultPath;
        /// <summary><p>Name of the certificate.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of the key vault.</p></summary>
        public virtual string VaultName { get; internal set; }
        /// <summary><p>The certificate version. If omitted, uses the latest version.</p></summary>
        public virtual string Version { get; internal set; }
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
              .Add("keyvault certificate show")
              .Add("--name {value}", Name)
              .Add("--vault-name {value}", VaultName)
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
    #region AzureKeyvaultCertificateShowDeletedSettings
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureKeyvaultCertificateShowDeletedSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureKeyvault executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureKeyvaultTasks.AzureKeyvaultPath;
        /// <summary><p>Name of the certificate.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of the key vault.</p></summary>
        public virtual string VaultName { get; internal set; }
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
              .Add("keyvault certificate show-deleted")
              .Add("--name {value}", Name)
              .Add("--vault-name {value}", VaultName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureKeyvaultKeyBackupSettings
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureKeyvaultKeyBackupSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureKeyvault executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureKeyvaultTasks.AzureKeyvaultPath;
        /// <summary><p>Local file path in which to store key backup.</p></summary>
        public virtual string File { get; internal set; }
        /// <summary><p>Name of the key.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of the key vault.</p></summary>
        public virtual string VaultName { get; internal set; }
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
              .Add("keyvault key backup")
              .Add("--file {value}", File)
              .Add("--name {value}", Name)
              .Add("--vault-name {value}", VaultName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureKeyvaultKeyCreateSettings
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureKeyvaultKeyCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureKeyvault executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureKeyvaultTasks.AzureKeyvaultPath;
        /// <summary><p>Name of the key.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Specifies the type of key protection.</p></summary>
        public virtual KeyvaultKeyProtection Protection { get; internal set; }
        /// <summary><p>Name of the key vault.</p></summary>
        public virtual string VaultName { get; internal set; }
        /// <summary><p>Create key in disabled state.</p></summary>
        public virtual bool? Disabled { get; internal set; }
        /// <summary><p>Expiration UTC datetime  (Y-m-d'T'H:M:S'Z').</p></summary>
        public virtual string Expires { get; internal set; }
        /// <summary><p>Key not usable before the provided UTC datetime  (Y-m-d'T'H:M:S'Z').</p></summary>
        public virtual string NotBefore { get; internal set; }
        /// <summary><p>Space-separated list of permitted JSON web key operations.</p></summary>
        public virtual IReadOnlyList<KeyvaultKeyOps> Ops => OpsInternal.AsReadOnly();
        internal List<KeyvaultKeyOps> OpsInternal { get; set; } = new List<KeyvaultKeyOps>();
        /// <summary><p>The key size in bytes. For example, 1024 or 2048.</p></summary>
        public virtual string Size { get; internal set; }
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
              .Add("keyvault key create")
              .Add("--name {value}", Name)
              .Add("--protection {value}", Protection)
              .Add("--vault-name {value}", VaultName)
              .Add("--disabled", Disabled)
              .Add("--expires {value}", Expires)
              .Add("--not-before {value}", NotBefore)
              .Add("--ops {value}", Ops, separator: ' ')
              .Add("--size {value}", Size)
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
    #region AzureKeyvaultKeyDeleteSettings
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureKeyvaultKeyDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureKeyvault executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureKeyvaultTasks.AzureKeyvaultPath;
        /// <summary><p>Name of the key.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of the key vault.</p></summary>
        public virtual string VaultName { get; internal set; }
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
              .Add("keyvault key delete")
              .Add("--name {value}", Name)
              .Add("--vault-name {value}", VaultName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureKeyvaultKeyImportSettings
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureKeyvaultKeyImportSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureKeyvault executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureKeyvaultTasks.AzureKeyvaultPath;
        /// <summary><p>Name of the key.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of the key vault.</p></summary>
        public virtual string VaultName { get; internal set; }
        /// <summary><p>Create key in disabled state.</p></summary>
        public virtual bool? Disabled { get; internal set; }
        /// <summary><p>Expiration UTC datetime  (Y-m-d'T'H:M:S'Z').</p></summary>
        public virtual string Expires { get; internal set; }
        /// <summary><p>Key not usable before the provided UTC datetime  (Y-m-d'T'H:M:S'Z').</p></summary>
        public virtual string NotBefore { get; internal set; }
        /// <summary><p>Space-separated list of permitted JSON web key operations.</p></summary>
        public virtual IReadOnlyList<KeyvaultKeyOps> Ops => OpsInternal.AsReadOnly();
        internal List<KeyvaultKeyOps> OpsInternal { get; set; } = new List<KeyvaultKeyOps>();
        /// <summary><p>Specifies the type of key protection.</p></summary>
        public virtual KeyvaultKeyProtection Protection { get; internal set; }
        /// <summary><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        public virtual string Tags { get; internal set; }
        /// <summary><p>BYOK file containing the key to be imported. Must not be password protected.</p></summary>
        public virtual string ByokFile { get; internal set; }
        /// <summary><p>PEM file containing the key to be imported.</p></summary>
        public virtual string PemFile { get; internal set; }
        /// <summary><p>Password of PEM file.</p></summary>
        public virtual string PemPassword { get; internal set; }
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
              .Add("keyvault key import")
              .Add("--name {value}", Name)
              .Add("--vault-name {value}", VaultName)
              .Add("--disabled", Disabled)
              .Add("--expires {value}", Expires)
              .Add("--not-before {value}", NotBefore)
              .Add("--ops {value}", Ops, separator: ' ')
              .Add("--protection {value}", Protection)
              .Add("--tags {value}", Tags)
              .Add("--byok-file {value}", ByokFile)
              .Add("--pem-file {value}", PemFile)
              .Add("--pem-password {value}", PemPassword)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureKeyvaultKeyListSettings
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureKeyvaultKeyListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureKeyvault executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureKeyvaultTasks.AzureKeyvaultPath;
        /// <summary><p>Name of the key vault.</p></summary>
        public virtual string VaultName { get; internal set; }
        /// <summary><p>Maximum number of results to return in a page. If not specified the service will return up to 25 results.</p></summary>
        public virtual string Maxresults { get; internal set; }
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
              .Add("keyvault key list")
              .Add("--vault-name {value}", VaultName)
              .Add("--maxresults {value}", Maxresults)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureKeyvaultKeyListDeletedSettings
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureKeyvaultKeyListDeletedSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureKeyvault executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureKeyvaultTasks.AzureKeyvaultPath;
        /// <summary><p>Name of the key vault.</p></summary>
        public virtual string VaultName { get; internal set; }
        /// <summary><p>Maximum number of results to return in a page. If not specified the service will return up to 25 results.</p></summary>
        public virtual string Maxresults { get; internal set; }
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
              .Add("keyvault key list-deleted")
              .Add("--vault-name {value}", VaultName)
              .Add("--maxresults {value}", Maxresults)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureKeyvaultKeyListVersionsSettings
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureKeyvaultKeyListVersionsSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureKeyvault executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureKeyvaultTasks.AzureKeyvaultPath;
        /// <summary><p>Name of the key.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of the key vault.</p></summary>
        public virtual string VaultName { get; internal set; }
        /// <summary><p>Maximum number of results to return in a page. If not specified the service will return up to 25 results.</p></summary>
        public virtual string Maxresults { get; internal set; }
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
              .Add("keyvault key list-versions")
              .Add("--name {value}", Name)
              .Add("--vault-name {value}", VaultName)
              .Add("--maxresults {value}", Maxresults)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureKeyvaultKeyPurgeSettings
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureKeyvaultKeyPurgeSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureKeyvault executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureKeyvaultTasks.AzureKeyvaultPath;
        /// <summary><p>Name of the key.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of the key vault.</p></summary>
        public virtual string VaultName { get; internal set; }
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
              .Add("keyvault key purge")
              .Add("--name {value}", Name)
              .Add("--vault-name {value}", VaultName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureKeyvaultKeyRecoverSettings
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureKeyvaultKeyRecoverSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureKeyvault executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureKeyvaultTasks.AzureKeyvaultPath;
        /// <summary><p>Name of the key.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of the key vault.</p></summary>
        public virtual string VaultName { get; internal set; }
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
              .Add("keyvault key recover")
              .Add("--name {value}", Name)
              .Add("--vault-name {value}", VaultName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureKeyvaultKeyRestoreSettings
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureKeyvaultKeyRestoreSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureKeyvault executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureKeyvaultTasks.AzureKeyvaultPath;
        /// <summary><p>Local key backup from which to restore key.</p></summary>
        public virtual string File { get; internal set; }
        /// <summary><p>Name of the key vault.</p></summary>
        public virtual string VaultName { get; internal set; }
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
              .Add("keyvault key restore")
              .Add("--file {value}", File)
              .Add("--vault-name {value}", VaultName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureKeyvaultKeySetAttributesSettings
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureKeyvaultKeySetAttributesSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureKeyvault executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureKeyvaultTasks.AzureKeyvaultPath;
        /// <summary><p>Name of the key.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of the key vault.</p></summary>
        public virtual string VaultName { get; internal set; }
        /// <summary><p>Enable the key.</p></summary>
        public virtual bool? Enabled { get; internal set; }
        /// <summary><p>Expiration UTC datetime  (Y-m-d'T'H:M:S'Z').</p></summary>
        public virtual string Expires { get; internal set; }
        /// <summary><p>Key not usable before the provided UTC datetime  (Y-m-d'T'H:M:S'Z').</p></summary>
        public virtual string NotBefore { get; internal set; }
        /// <summary><p>Space-separated list of permitted JSON web key operations.</p></summary>
        public virtual IReadOnlyList<KeyvaultKeyOps> Ops => OpsInternal.AsReadOnly();
        internal List<KeyvaultKeyOps> OpsInternal { get; set; } = new List<KeyvaultKeyOps>();
        /// <summary><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        public virtual string Tags { get; internal set; }
        /// <summary><p>The key version. If omitted, uses the latest version.</p></summary>
        public virtual string Version { get; internal set; }
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
              .Add("keyvault key set-attributes")
              .Add("--name {value}", Name)
              .Add("--vault-name {value}", VaultName)
              .Add("--enabled", Enabled)
              .Add("--expires {value}", Expires)
              .Add("--not-before {value}", NotBefore)
              .Add("--ops {value}", Ops, separator: ' ')
              .Add("--tags {value}", Tags)
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
    #region AzureKeyvaultKeyShowSettings
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureKeyvaultKeyShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureKeyvault executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureKeyvaultTasks.AzureKeyvaultPath;
        /// <summary><p>Name of the key.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of the key vault.</p></summary>
        public virtual string VaultName { get; internal set; }
        /// <summary><p>The key version. If omitted, uses the latest version.</p></summary>
        public virtual string Version { get; internal set; }
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
              .Add("keyvault key show")
              .Add("--name {value}", Name)
              .Add("--vault-name {value}", VaultName)
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
    #region AzureKeyvaultKeyShowDeletedSettings
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureKeyvaultKeyShowDeletedSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureKeyvault executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureKeyvaultTasks.AzureKeyvaultPath;
        /// <summary><p>Name of the key.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of the key vault.</p></summary>
        public virtual string VaultName { get; internal set; }
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
              .Add("keyvault key show-deleted")
              .Add("--name {value}", Name)
              .Add("--vault-name {value}", VaultName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureKeyvaultSecretBackupSettings
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureKeyvaultSecretBackupSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureKeyvault executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureKeyvaultTasks.AzureKeyvaultPath;
        /// <summary><p></p></summary>
        public virtual string FilePath { get; internal set; }
        /// <summary><p>Name of the secret.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of the key vault.</p></summary>
        public virtual string VaultName { get; internal set; }
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
              .Add("keyvault secret backup")
              .Add("--file-path {value}", FilePath)
              .Add("--name {value}", Name)
              .Add("--vault-name {value}", VaultName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureKeyvaultSecretDeleteSettings
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureKeyvaultSecretDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureKeyvault executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureKeyvaultTasks.AzureKeyvaultPath;
        /// <summary><p>Name of the secret.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of the key vault.</p></summary>
        public virtual string VaultName { get; internal set; }
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
              .Add("keyvault secret delete")
              .Add("--name {value}", Name)
              .Add("--vault-name {value}", VaultName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureKeyvaultSecretDownloadSettings
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureKeyvaultSecretDownloadSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureKeyvault executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureKeyvaultTasks.AzureKeyvaultPath;
        /// <summary><p>File to receive the secret contents.</p></summary>
        public virtual string File { get; internal set; }
        /// <summary><p>Name of the secret.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of the key vault.</p></summary>
        public virtual string VaultName { get; internal set; }
        /// <summary><p>Encoding of the destination file. By default, will look for the 'file-encoding' tag on the secret. Otherwise will assume 'utf-8'.</p></summary>
        public virtual KeyvaultSecretEncoding Encoding { get; internal set; }
        /// <summary><p>The secret version. If omitted, uses the latest version.</p></summary>
        public virtual string Version { get; internal set; }
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
              .Add("keyvault secret download")
              .Add("--file {value}", File)
              .Add("--name {value}", Name)
              .Add("--vault-name {value}", VaultName)
              .Add("--encoding {value}", Encoding)
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
    #region AzureKeyvaultSecretListSettings
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureKeyvaultSecretListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureKeyvault executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureKeyvaultTasks.AzureKeyvaultPath;
        /// <summary><p>Name of the key vault.</p></summary>
        public virtual string VaultName { get; internal set; }
        /// <summary><p>Maximum number of results to return in a page. If not specified the service will return up to 25 results.</p></summary>
        public virtual string Maxresults { get; internal set; }
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
              .Add("keyvault secret list")
              .Add("--vault-name {value}", VaultName)
              .Add("--maxresults {value}", Maxresults)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureKeyvaultSecretListDeletedSettings
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureKeyvaultSecretListDeletedSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureKeyvault executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureKeyvaultTasks.AzureKeyvaultPath;
        /// <summary><p>Name of the key vault.</p></summary>
        public virtual string VaultName { get; internal set; }
        /// <summary><p>Maximum number of results to return in a page. If not specified the service will return up to 25 results.</p></summary>
        public virtual string Maxresults { get; internal set; }
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
              .Add("keyvault secret list-deleted")
              .Add("--vault-name {value}", VaultName)
              .Add("--maxresults {value}", Maxresults)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureKeyvaultSecretListVersionsSettings
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureKeyvaultSecretListVersionsSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureKeyvault executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureKeyvaultTasks.AzureKeyvaultPath;
        /// <summary><p>Name of the secret.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of the key vault.</p></summary>
        public virtual string VaultName { get; internal set; }
        /// <summary><p>Maximum number of results to return in a page. If not specified the service will return up to 25 results.</p></summary>
        public virtual string Maxresults { get; internal set; }
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
              .Add("keyvault secret list-versions")
              .Add("--name {value}", Name)
              .Add("--vault-name {value}", VaultName)
              .Add("--maxresults {value}", Maxresults)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureKeyvaultSecretPurgeSettings
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureKeyvaultSecretPurgeSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureKeyvault executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureKeyvaultTasks.AzureKeyvaultPath;
        /// <summary><p>Name of the secret.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of the key vault.</p></summary>
        public virtual string VaultName { get; internal set; }
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
              .Add("keyvault secret purge")
              .Add("--name {value}", Name)
              .Add("--vault-name {value}", VaultName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureKeyvaultSecretRecoverSettings
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureKeyvaultSecretRecoverSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureKeyvault executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureKeyvaultTasks.AzureKeyvaultPath;
        /// <summary><p>Name of the secret.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of the key vault.</p></summary>
        public virtual string VaultName { get; internal set; }
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
              .Add("keyvault secret recover")
              .Add("--name {value}", Name)
              .Add("--vault-name {value}", VaultName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureKeyvaultSecretRestoreSettings
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureKeyvaultSecretRestoreSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureKeyvault executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureKeyvaultTasks.AzureKeyvaultPath;
        /// <summary><p></p></summary>
        public virtual string FilePath { get; internal set; }
        /// <summary><p>Name of the key vault.</p></summary>
        public virtual string VaultName { get; internal set; }
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
              .Add("keyvault secret restore")
              .Add("--file-path {value}", FilePath)
              .Add("--vault-name {value}", VaultName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureKeyvaultSecretSetSettings
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureKeyvaultSecretSetSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureKeyvault executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureKeyvaultTasks.AzureKeyvaultPath;
        /// <summary><p>Name of the secret.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of the key vault.</p></summary>
        public virtual string VaultName { get; internal set; }
        /// <summary><p>Description of the secret contents (e.g. password, connection string, etc).</p></summary>
        public virtual string Description { get; internal set; }
        /// <summary><p>Create secret in disabled state.</p></summary>
        public virtual bool? Disabled { get; internal set; }
        /// <summary><p>Expiration UTC datetime  (Y-m-d'T'H:M:S'Z').</p></summary>
        public virtual string Expires { get; internal set; }
        /// <summary><p>Key not usable before the provided UTC datetime  (Y-m-d'T'H:M:S'Z').</p></summary>
        public virtual string NotBefore { get; internal set; }
        /// <summary><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        public virtual string Tags { get; internal set; }
        /// <summary><p>Source file encoding. The value is saved as a tag (`file-encoding=&amp;lt;val&amp;gt;`) and used during download to automatically encode the resulting file.</p></summary>
        public virtual KeyvaultSecretEncoding Encoding { get; internal set; }
        /// <summary><p>Source file for secret. Use in conjunction with '--encoding'.</p></summary>
        public virtual string File { get; internal set; }
        /// <summary><p>Plain text secret value. Cannot be used with '--file' or '--encoding'.</p></summary>
        public virtual string Value { get; internal set; }
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
              .Add("keyvault secret set")
              .Add("--name {value}", Name)
              .Add("--vault-name {value}", VaultName)
              .Add("--description {value}", Description)
              .Add("--disabled", Disabled)
              .Add("--expires {value}", Expires)
              .Add("--not-before {value}", NotBefore)
              .Add("--tags {value}", Tags)
              .Add("--encoding {value}", Encoding)
              .Add("--file {value}", File)
              .Add("--value {value}", Value)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureKeyvaultSecretSetAttributesSettings
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureKeyvaultSecretSetAttributesSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureKeyvault executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureKeyvaultTasks.AzureKeyvaultPath;
        /// <summary><p>Name of the secret.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of the key vault.</p></summary>
        public virtual string VaultName { get; internal set; }
        /// <summary><p>Type of the secret value such as a password.</p></summary>
        public virtual string ContentType { get; internal set; }
        /// <summary><p>Enable the secret.</p></summary>
        public virtual bool? Enabled { get; internal set; }
        /// <summary><p>Expiration UTC datetime  (Y-m-d'T'H:M:S'Z').</p></summary>
        public virtual string Expires { get; internal set; }
        /// <summary><p>Key not usable before the provided UTC datetime  (Y-m-d'T'H:M:S'Z').</p></summary>
        public virtual string NotBefore { get; internal set; }
        /// <summary><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        public virtual string Tags { get; internal set; }
        /// <summary><p>The secret version. If omitted, uses the latest version.</p></summary>
        public virtual string Version { get; internal set; }
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
              .Add("keyvault secret set-attributes")
              .Add("--name {value}", Name)
              .Add("--vault-name {value}", VaultName)
              .Add("--content-type {value}", ContentType)
              .Add("--enabled", Enabled)
              .Add("--expires {value}", Expires)
              .Add("--not-before {value}", NotBefore)
              .Add("--tags {value}", Tags)
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
    #region AzureKeyvaultSecretShowSettings
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureKeyvaultSecretShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureKeyvault executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureKeyvaultTasks.AzureKeyvaultPath;
        /// <summary><p>Name of the secret.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of the key vault.</p></summary>
        public virtual string VaultName { get; internal set; }
        /// <summary><p>The secret version. If omitted, uses the latest version.</p></summary>
        public virtual string Version { get; internal set; }
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
              .Add("keyvault secret show")
              .Add("--name {value}", Name)
              .Add("--vault-name {value}", VaultName)
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
    #region AzureKeyvaultSecretShowDeletedSettings
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureKeyvaultSecretShowDeletedSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureKeyvault executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureKeyvaultTasks.AzureKeyvaultPath;
        /// <summary><p>Name of the secret.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of the key vault.</p></summary>
        public virtual string VaultName { get; internal set; }
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
              .Add("keyvault secret show-deleted")
              .Add("--name {value}", Name)
              .Add("--vault-name {value}", VaultName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureKeyvaultCertificateContactAddSettings
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureKeyvaultCertificateContactAddSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureKeyvault executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureKeyvaultTasks.AzureKeyvaultPath;
        /// <summary><p>Contact e-mail address. Must be unique.</p></summary>
        public virtual string Email { get; internal set; }
        /// <summary><p>Name of the key vault.</p></summary>
        public virtual string VaultName { get; internal set; }
        /// <summary><p>Full contact name.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Contact phone number.</p></summary>
        public virtual string Phone { get; internal set; }
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
              .Add("keyvault certificate contact add")
              .Add("--email {value}", Email)
              .Add("--vault-name {value}", VaultName)
              .Add("--name {value}", Name)
              .Add("--phone {value}", Phone)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureKeyvaultCertificateContactDeleteSettings
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureKeyvaultCertificateContactDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureKeyvault executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureKeyvaultTasks.AzureKeyvaultPath;
        /// <summary><p>Contact e-mail address. Must be unique.</p></summary>
        public virtual string Email { get; internal set; }
        /// <summary><p>Name of the key vault.</p></summary>
        public virtual string VaultName { get; internal set; }
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
              .Add("keyvault certificate contact delete")
              .Add("--email {value}", Email)
              .Add("--vault-name {value}", VaultName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureKeyvaultCertificateContactListSettings
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureKeyvaultCertificateContactListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureKeyvault executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureKeyvaultTasks.AzureKeyvaultPath;
        /// <summary><p>Name of the key vault.</p></summary>
        public virtual string VaultName { get; internal set; }
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
              .Add("keyvault certificate contact list")
              .Add("--vault-name {value}", VaultName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureKeyvaultCertificateIssuerCreateSettings
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureKeyvaultCertificateIssuerCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureKeyvault executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureKeyvaultTasks.AzureKeyvaultPath;
        /// <summary><p>Certificate issuer name.</p></summary>
        public virtual string IssuerName { get; internal set; }
        /// <summary><p>The certificate provider name. Must be registered with your tenant ID and in your region.</p></summary>
        public virtual string ProviderName { get; internal set; }
        /// <summary><p>Name of the key vault.</p></summary>
        public virtual string VaultName { get; internal set; }
        /// <summary><p>Set issuer to disabled state.</p></summary>
        public virtual bool? Disabled { get; internal set; }
        /// <summary><p>The issuer account id/username/etc.</p></summary>
        public virtual string AccountId { get; internal set; }
        /// <summary><p>The issuer account password/secret/etc.</p></summary>
        public virtual string Password { get; internal set; }
        /// <summary><p>The organization id.</p></summary>
        public virtual string OrganizationId { get; internal set; }
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
              .Add("keyvault certificate issuer create")
              .Add("--issuer-name {value}", IssuerName)
              .Add("--provider-name {value}", ProviderName)
              .Add("--vault-name {value}", VaultName)
              .Add("--disabled", Disabled)
              .Add("--account-id {value}", AccountId)
              .Add("--password {value}", Password)
              .Add("--organization-id {value}", OrganizationId)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureKeyvaultCertificateIssuerDeleteSettings
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureKeyvaultCertificateIssuerDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureKeyvault executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureKeyvaultTasks.AzureKeyvaultPath;
        /// <summary><p>Certificate issuer name.</p></summary>
        public virtual string IssuerName { get; internal set; }
        /// <summary><p>Name of the key vault.</p></summary>
        public virtual string VaultName { get; internal set; }
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
              .Add("keyvault certificate issuer delete")
              .Add("--issuer-name {value}", IssuerName)
              .Add("--vault-name {value}", VaultName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureKeyvaultCertificateIssuerListSettings
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureKeyvaultCertificateIssuerListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureKeyvault executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureKeyvaultTasks.AzureKeyvaultPath;
        /// <summary><p>Name of the key vault.</p></summary>
        public virtual string VaultName { get; internal set; }
        /// <summary><p>Maximum number of results to return in a page. If not specified the service will return up to 25 results.</p></summary>
        public virtual string Maxresults { get; internal set; }
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
              .Add("keyvault certificate issuer list")
              .Add("--vault-name {value}", VaultName)
              .Add("--maxresults {value}", Maxresults)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureKeyvaultCertificateIssuerShowSettings
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureKeyvaultCertificateIssuerShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureKeyvault executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureKeyvaultTasks.AzureKeyvaultPath;
        /// <summary><p>Certificate issuer name.</p></summary>
        public virtual string IssuerName { get; internal set; }
        /// <summary><p>Name of the key vault.</p></summary>
        public virtual string VaultName { get; internal set; }
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
              .Add("keyvault certificate issuer show")
              .Add("--issuer-name {value}", IssuerName)
              .Add("--vault-name {value}", VaultName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureKeyvaultCertificateIssuerUpdateSettings
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureKeyvaultCertificateIssuerUpdateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureKeyvault executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureKeyvaultTasks.AzureKeyvaultPath;
        /// <summary><p>Certificate issuer name.</p></summary>
        public virtual string IssuerName { get; internal set; }
        /// <summary><p>Name of the key vault.</p></summary>
        public virtual string VaultName { get; internal set; }
        /// <summary><p>Set issuer enabled state.</p></summary>
        public virtual bool? Enabled { get; internal set; }
        /// <summary><p>The certificate provider name. Must be registered with your tenant ID and in your region.</p></summary>
        public virtual string ProviderName { get; internal set; }
        /// <summary><p>The issuer account id/username/etc.</p></summary>
        public virtual string AccountId { get; internal set; }
        /// <summary><p>The issuer account password/secret/etc.</p></summary>
        public virtual string Password { get; internal set; }
        /// <summary><p>The organization id.</p></summary>
        public virtual string OrganizationId { get; internal set; }
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
              .Add("keyvault certificate issuer update")
              .Add("--issuer-name {value}", IssuerName)
              .Add("--vault-name {value}", VaultName)
              .Add("--enabled", Enabled)
              .Add("--provider-name {value}", ProviderName)
              .Add("--account-id {value}", AccountId)
              .Add("--password {value}", Password)
              .Add("--organization-id {value}", OrganizationId)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureKeyvaultCertificatePendingDeleteSettings
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureKeyvaultCertificatePendingDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureKeyvault executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureKeyvaultTasks.AzureKeyvaultPath;
        /// <summary><p>Name of the pending certificate.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of the key vault.</p></summary>
        public virtual string VaultName { get; internal set; }
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
              .Add("keyvault certificate pending delete")
              .Add("--name {value}", Name)
              .Add("--vault-name {value}", VaultName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureKeyvaultCertificatePendingMergeSettings
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureKeyvaultCertificatePendingMergeSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureKeyvault executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureKeyvaultTasks.AzureKeyvaultPath;
        /// <summary><p>File containing the certificate or certificate chain to merge.</p></summary>
        public virtual string File { get; internal set; }
        /// <summary><p>Name of the pending certificate.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of the key vault.</p></summary>
        public virtual string VaultName { get; internal set; }
        /// <summary><p>Create certificate in disabled state.</p></summary>
        public virtual bool? Disabled { get; internal set; }
        /// <summary><p>Expiration UTC datetime  (Y-m-d'T'H:M:S'Z').</p></summary>
        public virtual string Expires { get; internal set; }
        /// <summary><p>Key not usable before the provided UTC datetime  (Y-m-d'T'H:M:S'Z').</p></summary>
        public virtual string NotBefore { get; internal set; }
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
              .Add("keyvault certificate pending merge")
              .Add("--file {value}", File)
              .Add("--name {value}", Name)
              .Add("--vault-name {value}", VaultName)
              .Add("--disabled", Disabled)
              .Add("--expires {value}", Expires)
              .Add("--not-before {value}", NotBefore)
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
    #region AzureKeyvaultCertificatePendingShowSettings
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureKeyvaultCertificatePendingShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureKeyvault executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureKeyvaultTasks.AzureKeyvaultPath;
        /// <summary><p>Name of the pending certificate.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of the key vault.</p></summary>
        public virtual string VaultName { get; internal set; }
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
              .Add("keyvault certificate pending show")
              .Add("--name {value}", Name)
              .Add("--vault-name {value}", VaultName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureKeyvaultCertificateIssuerAdminAddSettings
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureKeyvaultCertificateIssuerAdminAddSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureKeyvault executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureKeyvaultTasks.AzureKeyvaultPath;
        /// <summary><p>Admin e-mail address. Must be unique within the vault.</p></summary>
        public virtual string Email { get; internal set; }
        /// <summary><p>Certificate issuer name.</p></summary>
        public virtual string IssuerName { get; internal set; }
        /// <summary><p>Name of the key vault.</p></summary>
        public virtual string VaultName { get; internal set; }
        /// <summary><p></p></summary>
        public virtual string FirstName { get; internal set; }
        /// <summary><p></p></summary>
        public virtual string LastName { get; internal set; }
        /// <summary><p>Amin phone number.</p></summary>
        public virtual string Phone { get; internal set; }
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
              .Add("keyvault certificate issuer admin add")
              .Add("--email {value}", Email)
              .Add("--issuer-name {value}", IssuerName)
              .Add("--vault-name {value}", VaultName)
              .Add("--first-name {value}", FirstName)
              .Add("--last-name {value}", LastName)
              .Add("--phone {value}", Phone)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureKeyvaultCertificateIssuerAdminDeleteSettings
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureKeyvaultCertificateIssuerAdminDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureKeyvault executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureKeyvaultTasks.AzureKeyvaultPath;
        /// <summary><p>Admin e-mail address. Must be unique within the vault.</p></summary>
        public virtual string Email { get; internal set; }
        /// <summary><p>Certificate issuer name.</p></summary>
        public virtual string IssuerName { get; internal set; }
        /// <summary><p>Name of the key vault.</p></summary>
        public virtual string VaultName { get; internal set; }
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
              .Add("keyvault certificate issuer admin delete")
              .Add("--email {value}", Email)
              .Add("--issuer-name {value}", IssuerName)
              .Add("--vault-name {value}", VaultName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureKeyvaultCertificateIssuerAdminListSettings
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureKeyvaultCertificateIssuerAdminListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureKeyvault executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureKeyvaultTasks.AzureKeyvaultPath;
        /// <summary><p>Certificate issuer name.</p></summary>
        public virtual string IssuerName { get; internal set; }
        /// <summary><p>Name of the key vault.</p></summary>
        public virtual string VaultName { get; internal set; }
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
              .Add("keyvault certificate issuer admin list")
              .Add("--issuer-name {value}", IssuerName)
              .Add("--vault-name {value}", VaultName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureKeyvaultCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureKeyvaultCreateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCreateSettings.Name"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultCreateSettings SetName(this AzureKeyvaultCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCreateSettings.Name"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultCreateSettings ResetName(this AzureKeyvaultCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureKeyvaultCreateSettings SetResourceGroup(this AzureKeyvaultCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureKeyvaultCreateSettings ResetResourceGroup(this AzureKeyvaultCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region EnableSoftDelete
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCreateSettings.EnableSoftDelete"/>.</em></p><p>Enable vault deletion recovery for the vault, and all contained entities.</p></summary>
        [Pure]
        public static AzureKeyvaultCreateSettings SetEnableSoftDelete(this AzureKeyvaultCreateSettings toolSettings, bool? enableSoftDelete)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableSoftDelete = enableSoftDelete;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCreateSettings.EnableSoftDelete"/>.</em></p><p>Enable vault deletion recovery for the vault, and all contained entities.</p></summary>
        [Pure]
        public static AzureKeyvaultCreateSettings ResetEnableSoftDelete(this AzureKeyvaultCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableSoftDelete = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureKeyvaultCreateSettings.EnableSoftDelete"/>.</em></p><p>Enable vault deletion recovery for the vault, and all contained entities.</p></summary>
        [Pure]
        public static AzureKeyvaultCreateSettings EnableEnableSoftDelete(this AzureKeyvaultCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableSoftDelete = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureKeyvaultCreateSettings.EnableSoftDelete"/>.</em></p><p>Enable vault deletion recovery for the vault, and all contained entities.</p></summary>
        [Pure]
        public static AzureKeyvaultCreateSettings DisableEnableSoftDelete(this AzureKeyvaultCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableSoftDelete = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureKeyvaultCreateSettings.EnableSoftDelete"/>.</em></p><p>Enable vault deletion recovery for the vault, and all contained entities.</p></summary>
        [Pure]
        public static AzureKeyvaultCreateSettings ToggleEnableSoftDelete(this AzureKeyvaultCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableSoftDelete = !toolSettings.EnableSoftDelete;
            return toolSettings;
        }
        #endregion
        #region EnabledForDeployment
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCreateSettings.EnabledForDeployment"/>.</em></p><p>Allow Virtual Machines to retrieve certificates stored as secrets from the vault.</p></summary>
        [Pure]
        public static AzureKeyvaultCreateSettings SetEnabledForDeployment(this AzureKeyvaultCreateSettings toolSettings, bool? enabledForDeployment)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnabledForDeployment = enabledForDeployment;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCreateSettings.EnabledForDeployment"/>.</em></p><p>Allow Virtual Machines to retrieve certificates stored as secrets from the vault.</p></summary>
        [Pure]
        public static AzureKeyvaultCreateSettings ResetEnabledForDeployment(this AzureKeyvaultCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnabledForDeployment = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureKeyvaultCreateSettings.EnabledForDeployment"/>.</em></p><p>Allow Virtual Machines to retrieve certificates stored as secrets from the vault.</p></summary>
        [Pure]
        public static AzureKeyvaultCreateSettings EnableEnabledForDeployment(this AzureKeyvaultCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnabledForDeployment = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureKeyvaultCreateSettings.EnabledForDeployment"/>.</em></p><p>Allow Virtual Machines to retrieve certificates stored as secrets from the vault.</p></summary>
        [Pure]
        public static AzureKeyvaultCreateSettings DisableEnabledForDeployment(this AzureKeyvaultCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnabledForDeployment = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureKeyvaultCreateSettings.EnabledForDeployment"/>.</em></p><p>Allow Virtual Machines to retrieve certificates stored as secrets from the vault.</p></summary>
        [Pure]
        public static AzureKeyvaultCreateSettings ToggleEnabledForDeployment(this AzureKeyvaultCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnabledForDeployment = !toolSettings.EnabledForDeployment;
            return toolSettings;
        }
        #endregion
        #region EnabledForDiskEncryption
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCreateSettings.EnabledForDiskEncryption"/>.</em></p><p>Allow Disk Encryption to retrieve secrets from the vault and unwrap keys.</p></summary>
        [Pure]
        public static AzureKeyvaultCreateSettings SetEnabledForDiskEncryption(this AzureKeyvaultCreateSettings toolSettings, bool? enabledForDiskEncryption)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnabledForDiskEncryption = enabledForDiskEncryption;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCreateSettings.EnabledForDiskEncryption"/>.</em></p><p>Allow Disk Encryption to retrieve secrets from the vault and unwrap keys.</p></summary>
        [Pure]
        public static AzureKeyvaultCreateSettings ResetEnabledForDiskEncryption(this AzureKeyvaultCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnabledForDiskEncryption = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureKeyvaultCreateSettings.EnabledForDiskEncryption"/>.</em></p><p>Allow Disk Encryption to retrieve secrets from the vault and unwrap keys.</p></summary>
        [Pure]
        public static AzureKeyvaultCreateSettings EnableEnabledForDiskEncryption(this AzureKeyvaultCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnabledForDiskEncryption = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureKeyvaultCreateSettings.EnabledForDiskEncryption"/>.</em></p><p>Allow Disk Encryption to retrieve secrets from the vault and unwrap keys.</p></summary>
        [Pure]
        public static AzureKeyvaultCreateSettings DisableEnabledForDiskEncryption(this AzureKeyvaultCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnabledForDiskEncryption = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureKeyvaultCreateSettings.EnabledForDiskEncryption"/>.</em></p><p>Allow Disk Encryption to retrieve secrets from the vault and unwrap keys.</p></summary>
        [Pure]
        public static AzureKeyvaultCreateSettings ToggleEnabledForDiskEncryption(this AzureKeyvaultCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnabledForDiskEncryption = !toolSettings.EnabledForDiskEncryption;
            return toolSettings;
        }
        #endregion
        #region EnabledForTemplateDeployment
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCreateSettings.EnabledForTemplateDeployment"/>.</em></p><p>Allow Resource Manager to retrieve secrets from the vault.</p></summary>
        [Pure]
        public static AzureKeyvaultCreateSettings SetEnabledForTemplateDeployment(this AzureKeyvaultCreateSettings toolSettings, bool? enabledForTemplateDeployment)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnabledForTemplateDeployment = enabledForTemplateDeployment;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCreateSettings.EnabledForTemplateDeployment"/>.</em></p><p>Allow Resource Manager to retrieve secrets from the vault.</p></summary>
        [Pure]
        public static AzureKeyvaultCreateSettings ResetEnabledForTemplateDeployment(this AzureKeyvaultCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnabledForTemplateDeployment = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureKeyvaultCreateSettings.EnabledForTemplateDeployment"/>.</em></p><p>Allow Resource Manager to retrieve secrets from the vault.</p></summary>
        [Pure]
        public static AzureKeyvaultCreateSettings EnableEnabledForTemplateDeployment(this AzureKeyvaultCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnabledForTemplateDeployment = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureKeyvaultCreateSettings.EnabledForTemplateDeployment"/>.</em></p><p>Allow Resource Manager to retrieve secrets from the vault.</p></summary>
        [Pure]
        public static AzureKeyvaultCreateSettings DisableEnabledForTemplateDeployment(this AzureKeyvaultCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnabledForTemplateDeployment = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureKeyvaultCreateSettings.EnabledForTemplateDeployment"/>.</em></p><p>Allow Resource Manager to retrieve secrets from the vault.</p></summary>
        [Pure]
        public static AzureKeyvaultCreateSettings ToggleEnabledForTemplateDeployment(this AzureKeyvaultCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnabledForTemplateDeployment = !toolSettings.EnabledForTemplateDeployment;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCreateSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureKeyvaultCreateSettings SetLocation(this AzureKeyvaultCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCreateSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureKeyvaultCreateSettings ResetLocation(this AzureKeyvaultCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region NoSelfPerms
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCreateSettings.NoSelfPerms"/>.</em></p><p>Don't add permissions for the current user/service principal in the new vault.</p></summary>
        [Pure]
        public static AzureKeyvaultCreateSettings SetNoSelfPerms(this AzureKeyvaultCreateSettings toolSettings, bool? noSelfPerms)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoSelfPerms = noSelfPerms;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCreateSettings.NoSelfPerms"/>.</em></p><p>Don't add permissions for the current user/service principal in the new vault.</p></summary>
        [Pure]
        public static AzureKeyvaultCreateSettings ResetNoSelfPerms(this AzureKeyvaultCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoSelfPerms = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureKeyvaultCreateSettings.NoSelfPerms"/>.</em></p><p>Don't add permissions for the current user/service principal in the new vault.</p></summary>
        [Pure]
        public static AzureKeyvaultCreateSettings EnableNoSelfPerms(this AzureKeyvaultCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoSelfPerms = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureKeyvaultCreateSettings.NoSelfPerms"/>.</em></p><p>Don't add permissions for the current user/service principal in the new vault.</p></summary>
        [Pure]
        public static AzureKeyvaultCreateSettings DisableNoSelfPerms(this AzureKeyvaultCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoSelfPerms = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureKeyvaultCreateSettings.NoSelfPerms"/>.</em></p><p>Don't add permissions for the current user/service principal in the new vault.</p></summary>
        [Pure]
        public static AzureKeyvaultCreateSettings ToggleNoSelfPerms(this AzureKeyvaultCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoSelfPerms = !toolSettings.NoSelfPerms;
            return toolSettings;
        }
        #endregion
        #region Sku
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCreateSettings.Sku"/>.</em></p><p>SKU details.</p></summary>
        [Pure]
        public static AzureKeyvaultCreateSettings SetSku(this AzureKeyvaultCreateSettings toolSettings, KeyvaultCreateSku sku)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = sku;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCreateSettings.Sku"/>.</em></p><p>SKU details.</p></summary>
        [Pure]
        public static AzureKeyvaultCreateSettings ResetSku(this AzureKeyvaultCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCreateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureKeyvaultCreateSettings SetTags(this AzureKeyvaultCreateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCreateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureKeyvaultCreateSettings ResetTags(this AzureKeyvaultCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCreateSettings SetDebug(this AzureKeyvaultCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCreateSettings ResetDebug(this AzureKeyvaultCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultCreateSettings SetHelp(this AzureKeyvaultCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultCreateSettings ResetHelp(this AzureKeyvaultCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultCreateSettings SetOutput(this AzureKeyvaultCreateSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultCreateSettings ResetOutput(this AzureKeyvaultCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultCreateSettings SetQuery(this AzureKeyvaultCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultCreateSettings ResetQuery(this AzureKeyvaultCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCreateSettings SetVerbose(this AzureKeyvaultCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCreateSettings ResetVerbose(this AzureKeyvaultCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureKeyvaultDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureKeyvaultDeleteSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureKeyvaultDeleteSettings.Name"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultDeleteSettings SetName(this AzureKeyvaultDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultDeleteSettings.Name"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultDeleteSettings ResetName(this AzureKeyvaultDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureKeyvaultDeleteSettings.ResourceGroup"/>.</em></p><p>Proceed only if Key Vault belongs to the specified resource group.</p></summary>
        [Pure]
        public static AzureKeyvaultDeleteSettings SetResourceGroup(this AzureKeyvaultDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultDeleteSettings.ResourceGroup"/>.</em></p><p>Proceed only if Key Vault belongs to the specified resource group.</p></summary>
        [Pure]
        public static AzureKeyvaultDeleteSettings ResetResourceGroup(this AzureKeyvaultDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureKeyvaultDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultDeleteSettings SetDebug(this AzureKeyvaultDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultDeleteSettings ResetDebug(this AzureKeyvaultDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureKeyvaultDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultDeleteSettings SetHelp(this AzureKeyvaultDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultDeleteSettings ResetHelp(this AzureKeyvaultDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureKeyvaultDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultDeleteSettings SetOutput(this AzureKeyvaultDeleteSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultDeleteSettings ResetOutput(this AzureKeyvaultDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureKeyvaultDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultDeleteSettings SetQuery(this AzureKeyvaultDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultDeleteSettings ResetQuery(this AzureKeyvaultDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureKeyvaultDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultDeleteSettings SetVerbose(this AzureKeyvaultDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultDeleteSettings ResetVerbose(this AzureKeyvaultDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureKeyvaultDeletePolicySettingsExtensions
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureKeyvaultDeletePolicySettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureKeyvaultDeletePolicySettings.Name"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultDeletePolicySettings SetName(this AzureKeyvaultDeletePolicySettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultDeletePolicySettings.Name"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultDeletePolicySettings ResetName(this AzureKeyvaultDeletePolicySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ObjectId
        /// <summary><p><em>Sets <see cref="AzureKeyvaultDeletePolicySettings.ObjectId"/>.</em></p><p>A GUID that identifies the principal that will receive permissions.</p></summary>
        [Pure]
        public static AzureKeyvaultDeletePolicySettings SetObjectId(this AzureKeyvaultDeletePolicySettings toolSettings, string objectId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ObjectId = objectId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultDeletePolicySettings.ObjectId"/>.</em></p><p>A GUID that identifies the principal that will receive permissions.</p></summary>
        [Pure]
        public static AzureKeyvaultDeletePolicySettings ResetObjectId(this AzureKeyvaultDeletePolicySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ObjectId = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureKeyvaultDeletePolicySettings.ResourceGroup"/>.</em></p><p>Proceed only if Key Vault belongs to the specified resource group.</p></summary>
        [Pure]
        public static AzureKeyvaultDeletePolicySettings SetResourceGroup(this AzureKeyvaultDeletePolicySettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultDeletePolicySettings.ResourceGroup"/>.</em></p><p>Proceed only if Key Vault belongs to the specified resource group.</p></summary>
        [Pure]
        public static AzureKeyvaultDeletePolicySettings ResetResourceGroup(this AzureKeyvaultDeletePolicySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Spn
        /// <summary><p><em>Sets <see cref="AzureKeyvaultDeletePolicySettings.Spn"/>.</em></p><p>Name of a service principal that will receive permissions.</p></summary>
        [Pure]
        public static AzureKeyvaultDeletePolicySettings SetSpn(this AzureKeyvaultDeletePolicySettings toolSettings, string spn)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Spn = spn;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultDeletePolicySettings.Spn"/>.</em></p><p>Name of a service principal that will receive permissions.</p></summary>
        [Pure]
        public static AzureKeyvaultDeletePolicySettings ResetSpn(this AzureKeyvaultDeletePolicySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Spn = null;
            return toolSettings;
        }
        #endregion
        #region Upn
        /// <summary><p><em>Sets <see cref="AzureKeyvaultDeletePolicySettings.Upn"/>.</em></p><p>Name of a user principal that will receive permissions.</p></summary>
        [Pure]
        public static AzureKeyvaultDeletePolicySettings SetUpn(this AzureKeyvaultDeletePolicySettings toolSettings, string upn)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Upn = upn;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultDeletePolicySettings.Upn"/>.</em></p><p>Name of a user principal that will receive permissions.</p></summary>
        [Pure]
        public static AzureKeyvaultDeletePolicySettings ResetUpn(this AzureKeyvaultDeletePolicySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Upn = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureKeyvaultDeletePolicySettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultDeletePolicySettings SetDebug(this AzureKeyvaultDeletePolicySettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultDeletePolicySettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultDeletePolicySettings ResetDebug(this AzureKeyvaultDeletePolicySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureKeyvaultDeletePolicySettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultDeletePolicySettings SetHelp(this AzureKeyvaultDeletePolicySettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultDeletePolicySettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultDeletePolicySettings ResetHelp(this AzureKeyvaultDeletePolicySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureKeyvaultDeletePolicySettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultDeletePolicySettings SetOutput(this AzureKeyvaultDeletePolicySettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultDeletePolicySettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultDeletePolicySettings ResetOutput(this AzureKeyvaultDeletePolicySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureKeyvaultDeletePolicySettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultDeletePolicySettings SetQuery(this AzureKeyvaultDeletePolicySettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultDeletePolicySettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultDeletePolicySettings ResetQuery(this AzureKeyvaultDeletePolicySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureKeyvaultDeletePolicySettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultDeletePolicySettings SetVerbose(this AzureKeyvaultDeletePolicySettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultDeletePolicySettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultDeletePolicySettings ResetVerbose(this AzureKeyvaultDeletePolicySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureKeyvaultListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureKeyvaultListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureKeyvaultListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureKeyvaultListSettings SetResourceGroup(this AzureKeyvaultListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureKeyvaultListSettings ResetResourceGroup(this AzureKeyvaultListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureKeyvaultListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultListSettings SetDebug(this AzureKeyvaultListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultListSettings ResetDebug(this AzureKeyvaultListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureKeyvaultListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultListSettings SetHelp(this AzureKeyvaultListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultListSettings ResetHelp(this AzureKeyvaultListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureKeyvaultListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultListSettings SetOutput(this AzureKeyvaultListSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultListSettings ResetOutput(this AzureKeyvaultListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureKeyvaultListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultListSettings SetQuery(this AzureKeyvaultListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultListSettings ResetQuery(this AzureKeyvaultListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureKeyvaultListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultListSettings SetVerbose(this AzureKeyvaultListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultListSettings ResetVerbose(this AzureKeyvaultListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureKeyvaultListDeletedSettingsExtensions
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureKeyvaultListDeletedSettingsExtensions
    {
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureKeyvaultListDeletedSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultListDeletedSettings SetDebug(this AzureKeyvaultListDeletedSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultListDeletedSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultListDeletedSettings ResetDebug(this AzureKeyvaultListDeletedSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureKeyvaultListDeletedSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultListDeletedSettings SetHelp(this AzureKeyvaultListDeletedSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultListDeletedSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultListDeletedSettings ResetHelp(this AzureKeyvaultListDeletedSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureKeyvaultListDeletedSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultListDeletedSettings SetOutput(this AzureKeyvaultListDeletedSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultListDeletedSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultListDeletedSettings ResetOutput(this AzureKeyvaultListDeletedSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureKeyvaultListDeletedSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultListDeletedSettings SetQuery(this AzureKeyvaultListDeletedSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultListDeletedSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultListDeletedSettings ResetQuery(this AzureKeyvaultListDeletedSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureKeyvaultListDeletedSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultListDeletedSettings SetVerbose(this AzureKeyvaultListDeletedSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultListDeletedSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultListDeletedSettings ResetVerbose(this AzureKeyvaultListDeletedSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureKeyvaultPurgeSettingsExtensions
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureKeyvaultPurgeSettingsExtensions
    {
        #region Location
        /// <summary><p><em>Sets <see cref="AzureKeyvaultPurgeSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureKeyvaultPurgeSettings SetLocation(this AzureKeyvaultPurgeSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultPurgeSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureKeyvaultPurgeSettings ResetLocation(this AzureKeyvaultPurgeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureKeyvaultPurgeSettings.Name"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultPurgeSettings SetName(this AzureKeyvaultPurgeSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultPurgeSettings.Name"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultPurgeSettings ResetName(this AzureKeyvaultPurgeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureKeyvaultPurgeSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultPurgeSettings SetDebug(this AzureKeyvaultPurgeSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultPurgeSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultPurgeSettings ResetDebug(this AzureKeyvaultPurgeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureKeyvaultPurgeSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultPurgeSettings SetHelp(this AzureKeyvaultPurgeSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultPurgeSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultPurgeSettings ResetHelp(this AzureKeyvaultPurgeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureKeyvaultPurgeSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultPurgeSettings SetOutput(this AzureKeyvaultPurgeSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultPurgeSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultPurgeSettings ResetOutput(this AzureKeyvaultPurgeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureKeyvaultPurgeSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultPurgeSettings SetQuery(this AzureKeyvaultPurgeSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultPurgeSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultPurgeSettings ResetQuery(this AzureKeyvaultPurgeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureKeyvaultPurgeSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultPurgeSettings SetVerbose(this AzureKeyvaultPurgeSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultPurgeSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultPurgeSettings ResetVerbose(this AzureKeyvaultPurgeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureKeyvaultRecoverSettingsExtensions
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureKeyvaultRecoverSettingsExtensions
    {
        #region Location
        /// <summary><p><em>Sets <see cref="AzureKeyvaultRecoverSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureKeyvaultRecoverSettings SetLocation(this AzureKeyvaultRecoverSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultRecoverSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureKeyvaultRecoverSettings ResetLocation(this AzureKeyvaultRecoverSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureKeyvaultRecoverSettings.Name"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultRecoverSettings SetName(this AzureKeyvaultRecoverSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultRecoverSettings.Name"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultRecoverSettings ResetName(this AzureKeyvaultRecoverSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureKeyvaultRecoverSettings.ResourceGroup"/>.</em></p><p>Proceed only if Key Vault belongs to the specified resource group.</p></summary>
        [Pure]
        public static AzureKeyvaultRecoverSettings SetResourceGroup(this AzureKeyvaultRecoverSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultRecoverSettings.ResourceGroup"/>.</em></p><p>Proceed only if Key Vault belongs to the specified resource group.</p></summary>
        [Pure]
        public static AzureKeyvaultRecoverSettings ResetResourceGroup(this AzureKeyvaultRecoverSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureKeyvaultRecoverSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultRecoverSettings SetDebug(this AzureKeyvaultRecoverSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultRecoverSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultRecoverSettings ResetDebug(this AzureKeyvaultRecoverSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureKeyvaultRecoverSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultRecoverSettings SetHelp(this AzureKeyvaultRecoverSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultRecoverSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultRecoverSettings ResetHelp(this AzureKeyvaultRecoverSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureKeyvaultRecoverSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultRecoverSettings SetOutput(this AzureKeyvaultRecoverSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultRecoverSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultRecoverSettings ResetOutput(this AzureKeyvaultRecoverSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureKeyvaultRecoverSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultRecoverSettings SetQuery(this AzureKeyvaultRecoverSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultRecoverSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultRecoverSettings ResetQuery(this AzureKeyvaultRecoverSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureKeyvaultRecoverSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultRecoverSettings SetVerbose(this AzureKeyvaultRecoverSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultRecoverSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultRecoverSettings ResetVerbose(this AzureKeyvaultRecoverSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureKeyvaultSetPolicySettingsExtensions
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureKeyvaultSetPolicySettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSetPolicySettings.Name"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultSetPolicySettings SetName(this AzureKeyvaultSetPolicySettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSetPolicySettings.Name"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultSetPolicySettings ResetName(this AzureKeyvaultSetPolicySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ObjectId
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSetPolicySettings.ObjectId"/>.</em></p><p>A GUID that identifies the principal that will receive permissions.</p></summary>
        [Pure]
        public static AzureKeyvaultSetPolicySettings SetObjectId(this AzureKeyvaultSetPolicySettings toolSettings, string objectId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ObjectId = objectId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSetPolicySettings.ObjectId"/>.</em></p><p>A GUID that identifies the principal that will receive permissions.</p></summary>
        [Pure]
        public static AzureKeyvaultSetPolicySettings ResetObjectId(this AzureKeyvaultSetPolicySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ObjectId = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSetPolicySettings.ResourceGroup"/>.</em></p><p>Proceed only if Key Vault belongs to the specified resource group.</p></summary>
        [Pure]
        public static AzureKeyvaultSetPolicySettings SetResourceGroup(this AzureKeyvaultSetPolicySettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSetPolicySettings.ResourceGroup"/>.</em></p><p>Proceed only if Key Vault belongs to the specified resource group.</p></summary>
        [Pure]
        public static AzureKeyvaultSetPolicySettings ResetResourceGroup(this AzureKeyvaultSetPolicySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Spn
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSetPolicySettings.Spn"/>.</em></p><p>Name of a service principal that will receive permissions.</p></summary>
        [Pure]
        public static AzureKeyvaultSetPolicySettings SetSpn(this AzureKeyvaultSetPolicySettings toolSettings, string spn)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Spn = spn;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSetPolicySettings.Spn"/>.</em></p><p>Name of a service principal that will receive permissions.</p></summary>
        [Pure]
        public static AzureKeyvaultSetPolicySettings ResetSpn(this AzureKeyvaultSetPolicySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Spn = null;
            return toolSettings;
        }
        #endregion
        #region Upn
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSetPolicySettings.Upn"/>.</em></p><p>Name of a user principal that will receive permissions.</p></summary>
        [Pure]
        public static AzureKeyvaultSetPolicySettings SetUpn(this AzureKeyvaultSetPolicySettings toolSettings, string upn)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Upn = upn;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSetPolicySettings.Upn"/>.</em></p><p>Name of a user principal that will receive permissions.</p></summary>
        [Pure]
        public static AzureKeyvaultSetPolicySettings ResetUpn(this AzureKeyvaultSetPolicySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Upn = null;
            return toolSettings;
        }
        #endregion
        #region CertificatePermissions
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSetPolicySettings.CertificatePermissions"/> to a new list.</em></p><p>Space-separated list of certificate permissions to assign.</p></summary>
        [Pure]
        public static AzureKeyvaultSetPolicySettings SetCertificatePermissions(this AzureKeyvaultSetPolicySettings toolSettings, params KeyvaultSetPolicyCertificatePermissions[] certificatePermissions)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertificatePermissionsInternal = certificatePermissions.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSetPolicySettings.CertificatePermissions"/> to a new list.</em></p><p>Space-separated list of certificate permissions to assign.</p></summary>
        [Pure]
        public static AzureKeyvaultSetPolicySettings SetCertificatePermissions(this AzureKeyvaultSetPolicySettings toolSettings, IEnumerable<KeyvaultSetPolicyCertificatePermissions> certificatePermissions)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertificatePermissionsInternal = certificatePermissions.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureKeyvaultSetPolicySettings.CertificatePermissions"/>.</em></p><p>Space-separated list of certificate permissions to assign.</p></summary>
        [Pure]
        public static AzureKeyvaultSetPolicySettings AddCertificatePermissions(this AzureKeyvaultSetPolicySettings toolSettings, params KeyvaultSetPolicyCertificatePermissions[] certificatePermissions)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertificatePermissionsInternal.AddRange(certificatePermissions);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureKeyvaultSetPolicySettings.CertificatePermissions"/>.</em></p><p>Space-separated list of certificate permissions to assign.</p></summary>
        [Pure]
        public static AzureKeyvaultSetPolicySettings AddCertificatePermissions(this AzureKeyvaultSetPolicySettings toolSettings, IEnumerable<KeyvaultSetPolicyCertificatePermissions> certificatePermissions)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertificatePermissionsInternal.AddRange(certificatePermissions);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureKeyvaultSetPolicySettings.CertificatePermissions"/>.</em></p><p>Space-separated list of certificate permissions to assign.</p></summary>
        [Pure]
        public static AzureKeyvaultSetPolicySettings ClearCertificatePermissions(this AzureKeyvaultSetPolicySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertificatePermissionsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureKeyvaultSetPolicySettings.CertificatePermissions"/>.</em></p><p>Space-separated list of certificate permissions to assign.</p></summary>
        [Pure]
        public static AzureKeyvaultSetPolicySettings RemoveCertificatePermissions(this AzureKeyvaultSetPolicySettings toolSettings, params KeyvaultSetPolicyCertificatePermissions[] certificatePermissions)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<KeyvaultSetPolicyCertificatePermissions>(certificatePermissions);
            toolSettings.CertificatePermissionsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureKeyvaultSetPolicySettings.CertificatePermissions"/>.</em></p><p>Space-separated list of certificate permissions to assign.</p></summary>
        [Pure]
        public static AzureKeyvaultSetPolicySettings RemoveCertificatePermissions(this AzureKeyvaultSetPolicySettings toolSettings, IEnumerable<KeyvaultSetPolicyCertificatePermissions> certificatePermissions)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<KeyvaultSetPolicyCertificatePermissions>(certificatePermissions);
            toolSettings.CertificatePermissionsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region KeyPermissions
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSetPolicySettings.KeyPermissions"/> to a new list.</em></p><p>Space-separated list of key permissions to assign.</p></summary>
        [Pure]
        public static AzureKeyvaultSetPolicySettings SetKeyPermissions(this AzureKeyvaultSetPolicySettings toolSettings, params KeyvaultSetPolicyKeyPermissions[] keyPermissions)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyPermissionsInternal = keyPermissions.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSetPolicySettings.KeyPermissions"/> to a new list.</em></p><p>Space-separated list of key permissions to assign.</p></summary>
        [Pure]
        public static AzureKeyvaultSetPolicySettings SetKeyPermissions(this AzureKeyvaultSetPolicySettings toolSettings, IEnumerable<KeyvaultSetPolicyKeyPermissions> keyPermissions)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyPermissionsInternal = keyPermissions.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureKeyvaultSetPolicySettings.KeyPermissions"/>.</em></p><p>Space-separated list of key permissions to assign.</p></summary>
        [Pure]
        public static AzureKeyvaultSetPolicySettings AddKeyPermissions(this AzureKeyvaultSetPolicySettings toolSettings, params KeyvaultSetPolicyKeyPermissions[] keyPermissions)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyPermissionsInternal.AddRange(keyPermissions);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureKeyvaultSetPolicySettings.KeyPermissions"/>.</em></p><p>Space-separated list of key permissions to assign.</p></summary>
        [Pure]
        public static AzureKeyvaultSetPolicySettings AddKeyPermissions(this AzureKeyvaultSetPolicySettings toolSettings, IEnumerable<KeyvaultSetPolicyKeyPermissions> keyPermissions)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyPermissionsInternal.AddRange(keyPermissions);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureKeyvaultSetPolicySettings.KeyPermissions"/>.</em></p><p>Space-separated list of key permissions to assign.</p></summary>
        [Pure]
        public static AzureKeyvaultSetPolicySettings ClearKeyPermissions(this AzureKeyvaultSetPolicySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyPermissionsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureKeyvaultSetPolicySettings.KeyPermissions"/>.</em></p><p>Space-separated list of key permissions to assign.</p></summary>
        [Pure]
        public static AzureKeyvaultSetPolicySettings RemoveKeyPermissions(this AzureKeyvaultSetPolicySettings toolSettings, params KeyvaultSetPolicyKeyPermissions[] keyPermissions)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<KeyvaultSetPolicyKeyPermissions>(keyPermissions);
            toolSettings.KeyPermissionsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureKeyvaultSetPolicySettings.KeyPermissions"/>.</em></p><p>Space-separated list of key permissions to assign.</p></summary>
        [Pure]
        public static AzureKeyvaultSetPolicySettings RemoveKeyPermissions(this AzureKeyvaultSetPolicySettings toolSettings, IEnumerable<KeyvaultSetPolicyKeyPermissions> keyPermissions)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<KeyvaultSetPolicyKeyPermissions>(keyPermissions);
            toolSettings.KeyPermissionsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region SecretPermissions
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSetPolicySettings.SecretPermissions"/> to a new list.</em></p><p>Space-separated list of secret permissions to assign.</p></summary>
        [Pure]
        public static AzureKeyvaultSetPolicySettings SetSecretPermissions(this AzureKeyvaultSetPolicySettings toolSettings, params KeyvaultSetPolicySecretPermissions[] secretPermissions)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SecretPermissionsInternal = secretPermissions.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSetPolicySettings.SecretPermissions"/> to a new list.</em></p><p>Space-separated list of secret permissions to assign.</p></summary>
        [Pure]
        public static AzureKeyvaultSetPolicySettings SetSecretPermissions(this AzureKeyvaultSetPolicySettings toolSettings, IEnumerable<KeyvaultSetPolicySecretPermissions> secretPermissions)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SecretPermissionsInternal = secretPermissions.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureKeyvaultSetPolicySettings.SecretPermissions"/>.</em></p><p>Space-separated list of secret permissions to assign.</p></summary>
        [Pure]
        public static AzureKeyvaultSetPolicySettings AddSecretPermissions(this AzureKeyvaultSetPolicySettings toolSettings, params KeyvaultSetPolicySecretPermissions[] secretPermissions)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SecretPermissionsInternal.AddRange(secretPermissions);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureKeyvaultSetPolicySettings.SecretPermissions"/>.</em></p><p>Space-separated list of secret permissions to assign.</p></summary>
        [Pure]
        public static AzureKeyvaultSetPolicySettings AddSecretPermissions(this AzureKeyvaultSetPolicySettings toolSettings, IEnumerable<KeyvaultSetPolicySecretPermissions> secretPermissions)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SecretPermissionsInternal.AddRange(secretPermissions);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureKeyvaultSetPolicySettings.SecretPermissions"/>.</em></p><p>Space-separated list of secret permissions to assign.</p></summary>
        [Pure]
        public static AzureKeyvaultSetPolicySettings ClearSecretPermissions(this AzureKeyvaultSetPolicySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SecretPermissionsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureKeyvaultSetPolicySettings.SecretPermissions"/>.</em></p><p>Space-separated list of secret permissions to assign.</p></summary>
        [Pure]
        public static AzureKeyvaultSetPolicySettings RemoveSecretPermissions(this AzureKeyvaultSetPolicySettings toolSettings, params KeyvaultSetPolicySecretPermissions[] secretPermissions)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<KeyvaultSetPolicySecretPermissions>(secretPermissions);
            toolSettings.SecretPermissionsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureKeyvaultSetPolicySettings.SecretPermissions"/>.</em></p><p>Space-separated list of secret permissions to assign.</p></summary>
        [Pure]
        public static AzureKeyvaultSetPolicySettings RemoveSecretPermissions(this AzureKeyvaultSetPolicySettings toolSettings, IEnumerable<KeyvaultSetPolicySecretPermissions> secretPermissions)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<KeyvaultSetPolicySecretPermissions>(secretPermissions);
            toolSettings.SecretPermissionsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSetPolicySettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultSetPolicySettings SetDebug(this AzureKeyvaultSetPolicySettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSetPolicySettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultSetPolicySettings ResetDebug(this AzureKeyvaultSetPolicySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSetPolicySettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultSetPolicySettings SetHelp(this AzureKeyvaultSetPolicySettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSetPolicySettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultSetPolicySettings ResetHelp(this AzureKeyvaultSetPolicySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSetPolicySettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultSetPolicySettings SetOutput(this AzureKeyvaultSetPolicySettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSetPolicySettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultSetPolicySettings ResetOutput(this AzureKeyvaultSetPolicySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSetPolicySettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultSetPolicySettings SetQuery(this AzureKeyvaultSetPolicySettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSetPolicySettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultSetPolicySettings ResetQuery(this AzureKeyvaultSetPolicySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSetPolicySettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultSetPolicySettings SetVerbose(this AzureKeyvaultSetPolicySettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSetPolicySettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultSetPolicySettings ResetVerbose(this AzureKeyvaultSetPolicySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureKeyvaultShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureKeyvaultShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureKeyvaultShowSettings.Name"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultShowSettings SetName(this AzureKeyvaultShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultShowSettings.Name"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultShowSettings ResetName(this AzureKeyvaultShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureKeyvaultShowSettings.ResourceGroup"/>.</em></p><p>Proceed only if Key Vault belongs to the specified resource group.</p></summary>
        [Pure]
        public static AzureKeyvaultShowSettings SetResourceGroup(this AzureKeyvaultShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultShowSettings.ResourceGroup"/>.</em></p><p>Proceed only if Key Vault belongs to the specified resource group.</p></summary>
        [Pure]
        public static AzureKeyvaultShowSettings ResetResourceGroup(this AzureKeyvaultShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureKeyvaultShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultShowSettings SetDebug(this AzureKeyvaultShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultShowSettings ResetDebug(this AzureKeyvaultShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureKeyvaultShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultShowSettings SetHelp(this AzureKeyvaultShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultShowSettings ResetHelp(this AzureKeyvaultShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureKeyvaultShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultShowSettings SetOutput(this AzureKeyvaultShowSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultShowSettings ResetOutput(this AzureKeyvaultShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureKeyvaultShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultShowSettings SetQuery(this AzureKeyvaultShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultShowSettings ResetQuery(this AzureKeyvaultShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureKeyvaultShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultShowSettings SetVerbose(this AzureKeyvaultShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultShowSettings ResetVerbose(this AzureKeyvaultShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureKeyvaultUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureKeyvaultUpdateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureKeyvaultUpdateSettings.Name"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultUpdateSettings SetName(this AzureKeyvaultUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultUpdateSettings.Name"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultUpdateSettings ResetName(this AzureKeyvaultUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region EnabledForDeployment
        /// <summary><p><em>Sets <see cref="AzureKeyvaultUpdateSettings.EnabledForDeployment"/>.</em></p><p>Allow Virtual Machines to retrieve certificates stored as secrets from the vault.</p></summary>
        [Pure]
        public static AzureKeyvaultUpdateSettings SetEnabledForDeployment(this AzureKeyvaultUpdateSettings toolSettings, bool? enabledForDeployment)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnabledForDeployment = enabledForDeployment;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultUpdateSettings.EnabledForDeployment"/>.</em></p><p>Allow Virtual Machines to retrieve certificates stored as secrets from the vault.</p></summary>
        [Pure]
        public static AzureKeyvaultUpdateSettings ResetEnabledForDeployment(this AzureKeyvaultUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnabledForDeployment = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureKeyvaultUpdateSettings.EnabledForDeployment"/>.</em></p><p>Allow Virtual Machines to retrieve certificates stored as secrets from the vault.</p></summary>
        [Pure]
        public static AzureKeyvaultUpdateSettings EnableEnabledForDeployment(this AzureKeyvaultUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnabledForDeployment = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureKeyvaultUpdateSettings.EnabledForDeployment"/>.</em></p><p>Allow Virtual Machines to retrieve certificates stored as secrets from the vault.</p></summary>
        [Pure]
        public static AzureKeyvaultUpdateSettings DisableEnabledForDeployment(this AzureKeyvaultUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnabledForDeployment = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureKeyvaultUpdateSettings.EnabledForDeployment"/>.</em></p><p>Allow Virtual Machines to retrieve certificates stored as secrets from the vault.</p></summary>
        [Pure]
        public static AzureKeyvaultUpdateSettings ToggleEnabledForDeployment(this AzureKeyvaultUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnabledForDeployment = !toolSettings.EnabledForDeployment;
            return toolSettings;
        }
        #endregion
        #region EnabledForDiskEncryption
        /// <summary><p><em>Sets <see cref="AzureKeyvaultUpdateSettings.EnabledForDiskEncryption"/>.</em></p><p>Allow Disk Encryption to retrieve secrets from the vault and unwrap keys.</p></summary>
        [Pure]
        public static AzureKeyvaultUpdateSettings SetEnabledForDiskEncryption(this AzureKeyvaultUpdateSettings toolSettings, bool? enabledForDiskEncryption)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnabledForDiskEncryption = enabledForDiskEncryption;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultUpdateSettings.EnabledForDiskEncryption"/>.</em></p><p>Allow Disk Encryption to retrieve secrets from the vault and unwrap keys.</p></summary>
        [Pure]
        public static AzureKeyvaultUpdateSettings ResetEnabledForDiskEncryption(this AzureKeyvaultUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnabledForDiskEncryption = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureKeyvaultUpdateSettings.EnabledForDiskEncryption"/>.</em></p><p>Allow Disk Encryption to retrieve secrets from the vault and unwrap keys.</p></summary>
        [Pure]
        public static AzureKeyvaultUpdateSettings EnableEnabledForDiskEncryption(this AzureKeyvaultUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnabledForDiskEncryption = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureKeyvaultUpdateSettings.EnabledForDiskEncryption"/>.</em></p><p>Allow Disk Encryption to retrieve secrets from the vault and unwrap keys.</p></summary>
        [Pure]
        public static AzureKeyvaultUpdateSettings DisableEnabledForDiskEncryption(this AzureKeyvaultUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnabledForDiskEncryption = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureKeyvaultUpdateSettings.EnabledForDiskEncryption"/>.</em></p><p>Allow Disk Encryption to retrieve secrets from the vault and unwrap keys.</p></summary>
        [Pure]
        public static AzureKeyvaultUpdateSettings ToggleEnabledForDiskEncryption(this AzureKeyvaultUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnabledForDiskEncryption = !toolSettings.EnabledForDiskEncryption;
            return toolSettings;
        }
        #endregion
        #region EnabledForTemplateDeployment
        /// <summary><p><em>Sets <see cref="AzureKeyvaultUpdateSettings.EnabledForTemplateDeployment"/>.</em></p><p>Allow Resource Manager to retrieve secrets from the vault.</p></summary>
        [Pure]
        public static AzureKeyvaultUpdateSettings SetEnabledForTemplateDeployment(this AzureKeyvaultUpdateSettings toolSettings, bool? enabledForTemplateDeployment)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnabledForTemplateDeployment = enabledForTemplateDeployment;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultUpdateSettings.EnabledForTemplateDeployment"/>.</em></p><p>Allow Resource Manager to retrieve secrets from the vault.</p></summary>
        [Pure]
        public static AzureKeyvaultUpdateSettings ResetEnabledForTemplateDeployment(this AzureKeyvaultUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnabledForTemplateDeployment = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureKeyvaultUpdateSettings.EnabledForTemplateDeployment"/>.</em></p><p>Allow Resource Manager to retrieve secrets from the vault.</p></summary>
        [Pure]
        public static AzureKeyvaultUpdateSettings EnableEnabledForTemplateDeployment(this AzureKeyvaultUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnabledForTemplateDeployment = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureKeyvaultUpdateSettings.EnabledForTemplateDeployment"/>.</em></p><p>Allow Resource Manager to retrieve secrets from the vault.</p></summary>
        [Pure]
        public static AzureKeyvaultUpdateSettings DisableEnabledForTemplateDeployment(this AzureKeyvaultUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnabledForTemplateDeployment = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureKeyvaultUpdateSettings.EnabledForTemplateDeployment"/>.</em></p><p>Allow Resource Manager to retrieve secrets from the vault.</p></summary>
        [Pure]
        public static AzureKeyvaultUpdateSettings ToggleEnabledForTemplateDeployment(this AzureKeyvaultUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnabledForTemplateDeployment = !toolSettings.EnabledForTemplateDeployment;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureKeyvaultUpdateSettings.ResourceGroup"/>.</em></p><p>Proceed only if Key Vault belongs to the specified resource group.</p></summary>
        [Pure]
        public static AzureKeyvaultUpdateSettings SetResourceGroup(this AzureKeyvaultUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultUpdateSettings.ResourceGroup"/>.</em></p><p>Proceed only if Key Vault belongs to the specified resource group.</p></summary>
        [Pure]
        public static AzureKeyvaultUpdateSettings ResetResourceGroup(this AzureKeyvaultUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary><p><em>Sets <see cref="AzureKeyvaultUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureKeyvaultUpdateSettings SetAdd(this AzureKeyvaultUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureKeyvaultUpdateSettings ResetAdd(this AzureKeyvaultUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary><p><em>Sets <see cref="AzureKeyvaultUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureKeyvaultUpdateSettings SetRemove(this AzureKeyvaultUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureKeyvaultUpdateSettings ResetRemove(this AzureKeyvaultUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary><p><em>Sets <see cref="AzureKeyvaultUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureKeyvaultUpdateSettings SetSet(this AzureKeyvaultUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureKeyvaultUpdateSettings ResetSet(this AzureKeyvaultUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureKeyvaultUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultUpdateSettings SetDebug(this AzureKeyvaultUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultUpdateSettings ResetDebug(this AzureKeyvaultUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureKeyvaultUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultUpdateSettings SetHelp(this AzureKeyvaultUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultUpdateSettings ResetHelp(this AzureKeyvaultUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureKeyvaultUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultUpdateSettings SetOutput(this AzureKeyvaultUpdateSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultUpdateSettings ResetOutput(this AzureKeyvaultUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureKeyvaultUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultUpdateSettings SetQuery(this AzureKeyvaultUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultUpdateSettings ResetQuery(this AzureKeyvaultUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureKeyvaultUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultUpdateSettings SetVerbose(this AzureKeyvaultUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultUpdateSettings ResetVerbose(this AzureKeyvaultUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureKeyvaultCertificateCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureKeyvaultCertificateCreateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateCreateSettings.Name"/>.</em></p><p>Name of the certificate.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateCreateSettings SetName(this AzureKeyvaultCertificateCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateCreateSettings.Name"/>.</em></p><p>Name of the certificate.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateCreateSettings ResetName(this AzureKeyvaultCertificateCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Policy
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateCreateSettings.Policy"/>.</em></p><p>JSON encoded policy defintion. Use @{file} to load from a file.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateCreateSettings SetPolicy(this AzureKeyvaultCertificateCreateSettings toolSettings, string policy)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Policy = policy;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateCreateSettings.Policy"/>.</em></p><p>JSON encoded policy defintion. Use @{file} to load from a file.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateCreateSettings ResetPolicy(this AzureKeyvaultCertificateCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Policy = null;
            return toolSettings;
        }
        #endregion
        #region VaultName
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateCreateSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateCreateSettings SetVaultName(this AzureKeyvaultCertificateCreateSettings toolSettings, string vaultName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = vaultName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateCreateSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateCreateSettings ResetVaultName(this AzureKeyvaultCertificateCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = null;
            return toolSettings;
        }
        #endregion
        #region Disabled
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateCreateSettings.Disabled"/>.</em></p><p>Create certificate in disabled state.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateCreateSettings SetDisabled(this AzureKeyvaultCertificateCreateSettings toolSettings, bool? disabled)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Disabled = disabled;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateCreateSettings.Disabled"/>.</em></p><p>Create certificate in disabled state.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateCreateSettings ResetDisabled(this AzureKeyvaultCertificateCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Disabled = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureKeyvaultCertificateCreateSettings.Disabled"/>.</em></p><p>Create certificate in disabled state.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateCreateSettings EnableDisabled(this AzureKeyvaultCertificateCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Disabled = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureKeyvaultCertificateCreateSettings.Disabled"/>.</em></p><p>Create certificate in disabled state.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateCreateSettings DisableDisabled(this AzureKeyvaultCertificateCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Disabled = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureKeyvaultCertificateCreateSettings.Disabled"/>.</em></p><p>Create certificate in disabled state.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateCreateSettings ToggleDisabled(this AzureKeyvaultCertificateCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Disabled = !toolSettings.Disabled;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateCreateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateCreateSettings SetTags(this AzureKeyvaultCertificateCreateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateCreateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateCreateSettings ResetTags(this AzureKeyvaultCertificateCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Validity
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateCreateSettings.Validity"/>.</em></p><p>Number of months the certificate is valid for. Overrides the value specified with --policy/-p.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateCreateSettings SetValidity(this AzureKeyvaultCertificateCreateSettings toolSettings, int? validity)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Validity = validity;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateCreateSettings.Validity"/>.</em></p><p>Number of months the certificate is valid for. Overrides the value specified with --policy/-p.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateCreateSettings ResetValidity(this AzureKeyvaultCertificateCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Validity = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateCreateSettings SetDebug(this AzureKeyvaultCertificateCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateCreateSettings ResetDebug(this AzureKeyvaultCertificateCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateCreateSettings SetHelp(this AzureKeyvaultCertificateCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateCreateSettings ResetHelp(this AzureKeyvaultCertificateCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateCreateSettings SetOutput(this AzureKeyvaultCertificateCreateSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateCreateSettings ResetOutput(this AzureKeyvaultCertificateCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateCreateSettings SetQuery(this AzureKeyvaultCertificateCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateCreateSettings ResetQuery(this AzureKeyvaultCertificateCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateCreateSettings SetVerbose(this AzureKeyvaultCertificateCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateCreateSettings ResetVerbose(this AzureKeyvaultCertificateCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureKeyvaultCertificateDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureKeyvaultCertificateDeleteSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateDeleteSettings.Name"/>.</em></p><p>Name of the certificate.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateDeleteSettings SetName(this AzureKeyvaultCertificateDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateDeleteSettings.Name"/>.</em></p><p>Name of the certificate.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateDeleteSettings ResetName(this AzureKeyvaultCertificateDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region VaultName
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateDeleteSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateDeleteSettings SetVaultName(this AzureKeyvaultCertificateDeleteSettings toolSettings, string vaultName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = vaultName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateDeleteSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateDeleteSettings ResetVaultName(this AzureKeyvaultCertificateDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateDeleteSettings SetDebug(this AzureKeyvaultCertificateDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateDeleteSettings ResetDebug(this AzureKeyvaultCertificateDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateDeleteSettings SetHelp(this AzureKeyvaultCertificateDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateDeleteSettings ResetHelp(this AzureKeyvaultCertificateDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateDeleteSettings SetOutput(this AzureKeyvaultCertificateDeleteSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateDeleteSettings ResetOutput(this AzureKeyvaultCertificateDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateDeleteSettings SetQuery(this AzureKeyvaultCertificateDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateDeleteSettings ResetQuery(this AzureKeyvaultCertificateDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateDeleteSettings SetVerbose(this AzureKeyvaultCertificateDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateDeleteSettings ResetVerbose(this AzureKeyvaultCertificateDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureKeyvaultCertificateDownloadSettingsExtensions
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureKeyvaultCertificateDownloadSettingsExtensions
    {
        #region File
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateDownloadSettings.File"/>.</em></p><p>File to receive the binary certificate contents.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateDownloadSettings SetFile(this AzureKeyvaultCertificateDownloadSettings toolSettings, string file)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.File = file;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateDownloadSettings.File"/>.</em></p><p>File to receive the binary certificate contents.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateDownloadSettings ResetFile(this AzureKeyvaultCertificateDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.File = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateDownloadSettings.Name"/>.</em></p><p>Name of the certificate.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateDownloadSettings SetName(this AzureKeyvaultCertificateDownloadSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateDownloadSettings.Name"/>.</em></p><p>Name of the certificate.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateDownloadSettings ResetName(this AzureKeyvaultCertificateDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region VaultName
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateDownloadSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateDownloadSettings SetVaultName(this AzureKeyvaultCertificateDownloadSettings toolSettings, string vaultName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = vaultName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateDownloadSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateDownloadSettings ResetVaultName(this AzureKeyvaultCertificateDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = null;
            return toolSettings;
        }
        #endregion
        #region Encoding
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateDownloadSettings.Encoding"/>.</em></p><p>Encoding of the certificate. DER will create a binary DER formatted x509 certificate, and PEM will create a base64 PEM x509 certificate.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateDownloadSettings SetEncoding(this AzureKeyvaultCertificateDownloadSettings toolSettings, KeyvaultCertificateDownloadEncoding encoding)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Encoding = encoding;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateDownloadSettings.Encoding"/>.</em></p><p>Encoding of the certificate. DER will create a binary DER formatted x509 certificate, and PEM will create a base64 PEM x509 certificate.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateDownloadSettings ResetEncoding(this AzureKeyvaultCertificateDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Encoding = null;
            return toolSettings;
        }
        #endregion
        #region Version
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateDownloadSettings.Version"/>.</em></p><p>The certificate version. If omitted, uses the latest version.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateDownloadSettings SetVersion(this AzureKeyvaultCertificateDownloadSettings toolSettings, string version)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = version;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateDownloadSettings.Version"/>.</em></p><p>The certificate version. If omitted, uses the latest version.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateDownloadSettings ResetVersion(this AzureKeyvaultCertificateDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateDownloadSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateDownloadSettings SetDebug(this AzureKeyvaultCertificateDownloadSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateDownloadSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateDownloadSettings ResetDebug(this AzureKeyvaultCertificateDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateDownloadSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateDownloadSettings SetHelp(this AzureKeyvaultCertificateDownloadSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateDownloadSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateDownloadSettings ResetHelp(this AzureKeyvaultCertificateDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateDownloadSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateDownloadSettings SetOutput(this AzureKeyvaultCertificateDownloadSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateDownloadSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateDownloadSettings ResetOutput(this AzureKeyvaultCertificateDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateDownloadSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateDownloadSettings SetQuery(this AzureKeyvaultCertificateDownloadSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateDownloadSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateDownloadSettings ResetQuery(this AzureKeyvaultCertificateDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateDownloadSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateDownloadSettings SetVerbose(this AzureKeyvaultCertificateDownloadSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateDownloadSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateDownloadSettings ResetVerbose(this AzureKeyvaultCertificateDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureKeyvaultCertificateGetDefaultPolicySettingsExtensions
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureKeyvaultCertificateGetDefaultPolicySettingsExtensions
    {
        #region Scaffold
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateGetDefaultPolicySettings.Scaffold"/>.</em></p><p>Create a fully formed policy structure with default values.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateGetDefaultPolicySettings SetScaffold(this AzureKeyvaultCertificateGetDefaultPolicySettings toolSettings, string scaffold)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Scaffold = scaffold;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateGetDefaultPolicySettings.Scaffold"/>.</em></p><p>Create a fully formed policy structure with default values.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateGetDefaultPolicySettings ResetScaffold(this AzureKeyvaultCertificateGetDefaultPolicySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Scaffold = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateGetDefaultPolicySettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateGetDefaultPolicySettings SetDebug(this AzureKeyvaultCertificateGetDefaultPolicySettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateGetDefaultPolicySettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateGetDefaultPolicySettings ResetDebug(this AzureKeyvaultCertificateGetDefaultPolicySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateGetDefaultPolicySettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateGetDefaultPolicySettings SetHelp(this AzureKeyvaultCertificateGetDefaultPolicySettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateGetDefaultPolicySettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateGetDefaultPolicySettings ResetHelp(this AzureKeyvaultCertificateGetDefaultPolicySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateGetDefaultPolicySettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateGetDefaultPolicySettings SetOutput(this AzureKeyvaultCertificateGetDefaultPolicySettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateGetDefaultPolicySettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateGetDefaultPolicySettings ResetOutput(this AzureKeyvaultCertificateGetDefaultPolicySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateGetDefaultPolicySettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateGetDefaultPolicySettings SetQuery(this AzureKeyvaultCertificateGetDefaultPolicySettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateGetDefaultPolicySettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateGetDefaultPolicySettings ResetQuery(this AzureKeyvaultCertificateGetDefaultPolicySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateGetDefaultPolicySettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateGetDefaultPolicySettings SetVerbose(this AzureKeyvaultCertificateGetDefaultPolicySettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateGetDefaultPolicySettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateGetDefaultPolicySettings ResetVerbose(this AzureKeyvaultCertificateGetDefaultPolicySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureKeyvaultCertificateImportSettingsExtensions
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureKeyvaultCertificateImportSettingsExtensions
    {
        #region File
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateImportSettings.File"/>.</em></p><p>PKCS12 file or PEM file containing the certificate and private key.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateImportSettings SetFile(this AzureKeyvaultCertificateImportSettings toolSettings, string file)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.File = file;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateImportSettings.File"/>.</em></p><p>PKCS12 file or PEM file containing the certificate and private key.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateImportSettings ResetFile(this AzureKeyvaultCertificateImportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.File = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateImportSettings.Name"/>.</em></p><p>Name of the certificate.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateImportSettings SetName(this AzureKeyvaultCertificateImportSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateImportSettings.Name"/>.</em></p><p>Name of the certificate.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateImportSettings ResetName(this AzureKeyvaultCertificateImportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region VaultName
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateImportSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateImportSettings SetVaultName(this AzureKeyvaultCertificateImportSettings toolSettings, string vaultName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = vaultName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateImportSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateImportSettings ResetVaultName(this AzureKeyvaultCertificateImportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = null;
            return toolSettings;
        }
        #endregion
        #region Disabled
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateImportSettings.Disabled"/>.</em></p><p>Import the certificate in disabled state.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateImportSettings SetDisabled(this AzureKeyvaultCertificateImportSettings toolSettings, bool? disabled)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Disabled = disabled;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateImportSettings.Disabled"/>.</em></p><p>Import the certificate in disabled state.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateImportSettings ResetDisabled(this AzureKeyvaultCertificateImportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Disabled = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureKeyvaultCertificateImportSettings.Disabled"/>.</em></p><p>Import the certificate in disabled state.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateImportSettings EnableDisabled(this AzureKeyvaultCertificateImportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Disabled = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureKeyvaultCertificateImportSettings.Disabled"/>.</em></p><p>Import the certificate in disabled state.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateImportSettings DisableDisabled(this AzureKeyvaultCertificateImportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Disabled = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureKeyvaultCertificateImportSettings.Disabled"/>.</em></p><p>Import the certificate in disabled state.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateImportSettings ToggleDisabled(this AzureKeyvaultCertificateImportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Disabled = !toolSettings.Disabled;
            return toolSettings;
        }
        #endregion
        #region Password
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateImportSettings.Password"/>.</em></p><p>If the private key in certificate is encrypted, the password used for encryption.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateImportSettings SetPassword(this AzureKeyvaultCertificateImportSettings toolSettings, string password)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = password;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateImportSettings.Password"/>.</em></p><p>If the private key in certificate is encrypted, the password used for encryption.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateImportSettings ResetPassword(this AzureKeyvaultCertificateImportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = null;
            return toolSettings;
        }
        #endregion
        #region Policy
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateImportSettings.Policy"/>.</em></p><p>JSON encoded policy defintion. Use @{file} to load from a file.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateImportSettings SetPolicy(this AzureKeyvaultCertificateImportSettings toolSettings, string policy)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Policy = policy;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateImportSettings.Policy"/>.</em></p><p>JSON encoded policy defintion. Use @{file} to load from a file.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateImportSettings ResetPolicy(this AzureKeyvaultCertificateImportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Policy = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateImportSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateImportSettings SetTags(this AzureKeyvaultCertificateImportSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateImportSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateImportSettings ResetTags(this AzureKeyvaultCertificateImportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateImportSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateImportSettings SetDebug(this AzureKeyvaultCertificateImportSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateImportSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateImportSettings ResetDebug(this AzureKeyvaultCertificateImportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateImportSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateImportSettings SetHelp(this AzureKeyvaultCertificateImportSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateImportSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateImportSettings ResetHelp(this AzureKeyvaultCertificateImportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateImportSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateImportSettings SetOutput(this AzureKeyvaultCertificateImportSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateImportSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateImportSettings ResetOutput(this AzureKeyvaultCertificateImportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateImportSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateImportSettings SetQuery(this AzureKeyvaultCertificateImportSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateImportSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateImportSettings ResetQuery(this AzureKeyvaultCertificateImportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateImportSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateImportSettings SetVerbose(this AzureKeyvaultCertificateImportSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateImportSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateImportSettings ResetVerbose(this AzureKeyvaultCertificateImportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureKeyvaultCertificateListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureKeyvaultCertificateListSettingsExtensions
    {
        #region VaultName
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateListSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateListSettings SetVaultName(this AzureKeyvaultCertificateListSettings toolSettings, string vaultName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = vaultName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateListSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateListSettings ResetVaultName(this AzureKeyvaultCertificateListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = null;
            return toolSettings;
        }
        #endregion
        #region Maxresults
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateListSettings.Maxresults"/>.</em></p><p>Maximum number of results to return in a page. If not specified the service will return up to 25 results.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateListSettings SetMaxresults(this AzureKeyvaultCertificateListSettings toolSettings, string maxresults)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Maxresults = maxresults;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateListSettings.Maxresults"/>.</em></p><p>Maximum number of results to return in a page. If not specified the service will return up to 25 results.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateListSettings ResetMaxresults(this AzureKeyvaultCertificateListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Maxresults = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateListSettings SetDebug(this AzureKeyvaultCertificateListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateListSettings ResetDebug(this AzureKeyvaultCertificateListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateListSettings SetHelp(this AzureKeyvaultCertificateListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateListSettings ResetHelp(this AzureKeyvaultCertificateListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateListSettings SetOutput(this AzureKeyvaultCertificateListSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateListSettings ResetOutput(this AzureKeyvaultCertificateListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateListSettings SetQuery(this AzureKeyvaultCertificateListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateListSettings ResetQuery(this AzureKeyvaultCertificateListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateListSettings SetVerbose(this AzureKeyvaultCertificateListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateListSettings ResetVerbose(this AzureKeyvaultCertificateListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureKeyvaultCertificateListDeletedSettingsExtensions
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureKeyvaultCertificateListDeletedSettingsExtensions
    {
        #region VaultName
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateListDeletedSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateListDeletedSettings SetVaultName(this AzureKeyvaultCertificateListDeletedSettings toolSettings, string vaultName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = vaultName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateListDeletedSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateListDeletedSettings ResetVaultName(this AzureKeyvaultCertificateListDeletedSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = null;
            return toolSettings;
        }
        #endregion
        #region Maxresults
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateListDeletedSettings.Maxresults"/>.</em></p><p>Maximum number of results to return in a page. If not specified the service will return up to 25 results.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateListDeletedSettings SetMaxresults(this AzureKeyvaultCertificateListDeletedSettings toolSettings, string maxresults)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Maxresults = maxresults;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateListDeletedSettings.Maxresults"/>.</em></p><p>Maximum number of results to return in a page. If not specified the service will return up to 25 results.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateListDeletedSettings ResetMaxresults(this AzureKeyvaultCertificateListDeletedSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Maxresults = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateListDeletedSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateListDeletedSettings SetDebug(this AzureKeyvaultCertificateListDeletedSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateListDeletedSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateListDeletedSettings ResetDebug(this AzureKeyvaultCertificateListDeletedSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateListDeletedSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateListDeletedSettings SetHelp(this AzureKeyvaultCertificateListDeletedSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateListDeletedSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateListDeletedSettings ResetHelp(this AzureKeyvaultCertificateListDeletedSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateListDeletedSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateListDeletedSettings SetOutput(this AzureKeyvaultCertificateListDeletedSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateListDeletedSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateListDeletedSettings ResetOutput(this AzureKeyvaultCertificateListDeletedSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateListDeletedSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateListDeletedSettings SetQuery(this AzureKeyvaultCertificateListDeletedSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateListDeletedSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateListDeletedSettings ResetQuery(this AzureKeyvaultCertificateListDeletedSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateListDeletedSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateListDeletedSettings SetVerbose(this AzureKeyvaultCertificateListDeletedSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateListDeletedSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateListDeletedSettings ResetVerbose(this AzureKeyvaultCertificateListDeletedSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureKeyvaultCertificateListVersionsSettingsExtensions
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureKeyvaultCertificateListVersionsSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateListVersionsSettings.Name"/>.</em></p><p>Name of the certificate.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateListVersionsSettings SetName(this AzureKeyvaultCertificateListVersionsSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateListVersionsSettings.Name"/>.</em></p><p>Name of the certificate.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateListVersionsSettings ResetName(this AzureKeyvaultCertificateListVersionsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region VaultName
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateListVersionsSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateListVersionsSettings SetVaultName(this AzureKeyvaultCertificateListVersionsSettings toolSettings, string vaultName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = vaultName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateListVersionsSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateListVersionsSettings ResetVaultName(this AzureKeyvaultCertificateListVersionsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = null;
            return toolSettings;
        }
        #endregion
        #region Maxresults
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateListVersionsSettings.Maxresults"/>.</em></p><p>Maximum number of results to return in a page. If not specified the service will return up to 25 results.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateListVersionsSettings SetMaxresults(this AzureKeyvaultCertificateListVersionsSettings toolSettings, string maxresults)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Maxresults = maxresults;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateListVersionsSettings.Maxresults"/>.</em></p><p>Maximum number of results to return in a page. If not specified the service will return up to 25 results.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateListVersionsSettings ResetMaxresults(this AzureKeyvaultCertificateListVersionsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Maxresults = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateListVersionsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateListVersionsSettings SetDebug(this AzureKeyvaultCertificateListVersionsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateListVersionsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateListVersionsSettings ResetDebug(this AzureKeyvaultCertificateListVersionsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateListVersionsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateListVersionsSettings SetHelp(this AzureKeyvaultCertificateListVersionsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateListVersionsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateListVersionsSettings ResetHelp(this AzureKeyvaultCertificateListVersionsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateListVersionsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateListVersionsSettings SetOutput(this AzureKeyvaultCertificateListVersionsSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateListVersionsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateListVersionsSettings ResetOutput(this AzureKeyvaultCertificateListVersionsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateListVersionsSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateListVersionsSettings SetQuery(this AzureKeyvaultCertificateListVersionsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateListVersionsSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateListVersionsSettings ResetQuery(this AzureKeyvaultCertificateListVersionsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateListVersionsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateListVersionsSettings SetVerbose(this AzureKeyvaultCertificateListVersionsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateListVersionsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateListVersionsSettings ResetVerbose(this AzureKeyvaultCertificateListVersionsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureKeyvaultCertificatePurgeSettingsExtensions
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureKeyvaultCertificatePurgeSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificatePurgeSettings.Name"/>.</em></p><p>Name of the certificate.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificatePurgeSettings SetName(this AzureKeyvaultCertificatePurgeSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificatePurgeSettings.Name"/>.</em></p><p>Name of the certificate.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificatePurgeSettings ResetName(this AzureKeyvaultCertificatePurgeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region VaultName
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificatePurgeSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificatePurgeSettings SetVaultName(this AzureKeyvaultCertificatePurgeSettings toolSettings, string vaultName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = vaultName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificatePurgeSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificatePurgeSettings ResetVaultName(this AzureKeyvaultCertificatePurgeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificatePurgeSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificatePurgeSettings SetDebug(this AzureKeyvaultCertificatePurgeSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificatePurgeSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificatePurgeSettings ResetDebug(this AzureKeyvaultCertificatePurgeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificatePurgeSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificatePurgeSettings SetHelp(this AzureKeyvaultCertificatePurgeSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificatePurgeSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificatePurgeSettings ResetHelp(this AzureKeyvaultCertificatePurgeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificatePurgeSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificatePurgeSettings SetOutput(this AzureKeyvaultCertificatePurgeSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificatePurgeSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificatePurgeSettings ResetOutput(this AzureKeyvaultCertificatePurgeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificatePurgeSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificatePurgeSettings SetQuery(this AzureKeyvaultCertificatePurgeSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificatePurgeSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificatePurgeSettings ResetQuery(this AzureKeyvaultCertificatePurgeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificatePurgeSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificatePurgeSettings SetVerbose(this AzureKeyvaultCertificatePurgeSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificatePurgeSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificatePurgeSettings ResetVerbose(this AzureKeyvaultCertificatePurgeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureKeyvaultCertificateRecoverSettingsExtensions
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureKeyvaultCertificateRecoverSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateRecoverSettings.Name"/>.</em></p><p>Name of the certificate.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateRecoverSettings SetName(this AzureKeyvaultCertificateRecoverSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateRecoverSettings.Name"/>.</em></p><p>Name of the certificate.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateRecoverSettings ResetName(this AzureKeyvaultCertificateRecoverSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region VaultName
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateRecoverSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateRecoverSettings SetVaultName(this AzureKeyvaultCertificateRecoverSettings toolSettings, string vaultName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = vaultName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateRecoverSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateRecoverSettings ResetVaultName(this AzureKeyvaultCertificateRecoverSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateRecoverSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateRecoverSettings SetDebug(this AzureKeyvaultCertificateRecoverSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateRecoverSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateRecoverSettings ResetDebug(this AzureKeyvaultCertificateRecoverSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateRecoverSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateRecoverSettings SetHelp(this AzureKeyvaultCertificateRecoverSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateRecoverSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateRecoverSettings ResetHelp(this AzureKeyvaultCertificateRecoverSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateRecoverSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateRecoverSettings SetOutput(this AzureKeyvaultCertificateRecoverSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateRecoverSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateRecoverSettings ResetOutput(this AzureKeyvaultCertificateRecoverSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateRecoverSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateRecoverSettings SetQuery(this AzureKeyvaultCertificateRecoverSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateRecoverSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateRecoverSettings ResetQuery(this AzureKeyvaultCertificateRecoverSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateRecoverSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateRecoverSettings SetVerbose(this AzureKeyvaultCertificateRecoverSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateRecoverSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateRecoverSettings ResetVerbose(this AzureKeyvaultCertificateRecoverSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureKeyvaultCertificateSetAttributesSettingsExtensions
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureKeyvaultCertificateSetAttributesSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateSetAttributesSettings.Name"/>.</em></p><p>Name of the certificate.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateSetAttributesSettings SetName(this AzureKeyvaultCertificateSetAttributesSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateSetAttributesSettings.Name"/>.</em></p><p>Name of the certificate.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateSetAttributesSettings ResetName(this AzureKeyvaultCertificateSetAttributesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region VaultName
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateSetAttributesSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateSetAttributesSettings SetVaultName(this AzureKeyvaultCertificateSetAttributesSettings toolSettings, string vaultName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = vaultName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateSetAttributesSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateSetAttributesSettings ResetVaultName(this AzureKeyvaultCertificateSetAttributesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = null;
            return toolSettings;
        }
        #endregion
        #region Enabled
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateSetAttributesSettings.Enabled"/>.</em></p><p>Enable the certificate.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateSetAttributesSettings SetEnabled(this AzureKeyvaultCertificateSetAttributesSettings toolSettings, bool? enabled)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Enabled = enabled;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateSetAttributesSettings.Enabled"/>.</em></p><p>Enable the certificate.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateSetAttributesSettings ResetEnabled(this AzureKeyvaultCertificateSetAttributesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Enabled = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureKeyvaultCertificateSetAttributesSettings.Enabled"/>.</em></p><p>Enable the certificate.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateSetAttributesSettings EnableEnabled(this AzureKeyvaultCertificateSetAttributesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Enabled = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureKeyvaultCertificateSetAttributesSettings.Enabled"/>.</em></p><p>Enable the certificate.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateSetAttributesSettings DisableEnabled(this AzureKeyvaultCertificateSetAttributesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Enabled = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureKeyvaultCertificateSetAttributesSettings.Enabled"/>.</em></p><p>Enable the certificate.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateSetAttributesSettings ToggleEnabled(this AzureKeyvaultCertificateSetAttributesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Enabled = !toolSettings.Enabled;
            return toolSettings;
        }
        #endregion
        #region Policy
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateSetAttributesSettings.Policy"/>.</em></p><p>JSON encoded policy defintion. Use @{file} to load from a file.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateSetAttributesSettings SetPolicy(this AzureKeyvaultCertificateSetAttributesSettings toolSettings, string policy)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Policy = policy;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateSetAttributesSettings.Policy"/>.</em></p><p>JSON encoded policy defintion. Use @{file} to load from a file.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateSetAttributesSettings ResetPolicy(this AzureKeyvaultCertificateSetAttributesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Policy = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateSetAttributesSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateSetAttributesSettings SetTags(this AzureKeyvaultCertificateSetAttributesSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateSetAttributesSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateSetAttributesSettings ResetTags(this AzureKeyvaultCertificateSetAttributesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Version
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateSetAttributesSettings.Version"/>.</em></p><p>The certificate version. If omitted, uses the latest version.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateSetAttributesSettings SetVersion(this AzureKeyvaultCertificateSetAttributesSettings toolSettings, string version)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = version;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateSetAttributesSettings.Version"/>.</em></p><p>The certificate version. If omitted, uses the latest version.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateSetAttributesSettings ResetVersion(this AzureKeyvaultCertificateSetAttributesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateSetAttributesSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateSetAttributesSettings SetDebug(this AzureKeyvaultCertificateSetAttributesSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateSetAttributesSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateSetAttributesSettings ResetDebug(this AzureKeyvaultCertificateSetAttributesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateSetAttributesSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateSetAttributesSettings SetHelp(this AzureKeyvaultCertificateSetAttributesSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateSetAttributesSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateSetAttributesSettings ResetHelp(this AzureKeyvaultCertificateSetAttributesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateSetAttributesSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateSetAttributesSettings SetOutput(this AzureKeyvaultCertificateSetAttributesSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateSetAttributesSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateSetAttributesSettings ResetOutput(this AzureKeyvaultCertificateSetAttributesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateSetAttributesSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateSetAttributesSettings SetQuery(this AzureKeyvaultCertificateSetAttributesSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateSetAttributesSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateSetAttributesSettings ResetQuery(this AzureKeyvaultCertificateSetAttributesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateSetAttributesSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateSetAttributesSettings SetVerbose(this AzureKeyvaultCertificateSetAttributesSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateSetAttributesSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateSetAttributesSettings ResetVerbose(this AzureKeyvaultCertificateSetAttributesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureKeyvaultCertificateShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureKeyvaultCertificateShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateShowSettings.Name"/>.</em></p><p>Name of the certificate.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateShowSettings SetName(this AzureKeyvaultCertificateShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateShowSettings.Name"/>.</em></p><p>Name of the certificate.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateShowSettings ResetName(this AzureKeyvaultCertificateShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region VaultName
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateShowSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateShowSettings SetVaultName(this AzureKeyvaultCertificateShowSettings toolSettings, string vaultName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = vaultName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateShowSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateShowSettings ResetVaultName(this AzureKeyvaultCertificateShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = null;
            return toolSettings;
        }
        #endregion
        #region Version
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateShowSettings.Version"/>.</em></p><p>The certificate version. If omitted, uses the latest version.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateShowSettings SetVersion(this AzureKeyvaultCertificateShowSettings toolSettings, string version)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = version;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateShowSettings.Version"/>.</em></p><p>The certificate version. If omitted, uses the latest version.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateShowSettings ResetVersion(this AzureKeyvaultCertificateShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateShowSettings SetDebug(this AzureKeyvaultCertificateShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateShowSettings ResetDebug(this AzureKeyvaultCertificateShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateShowSettings SetHelp(this AzureKeyvaultCertificateShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateShowSettings ResetHelp(this AzureKeyvaultCertificateShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateShowSettings SetOutput(this AzureKeyvaultCertificateShowSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateShowSettings ResetOutput(this AzureKeyvaultCertificateShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateShowSettings SetQuery(this AzureKeyvaultCertificateShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateShowSettings ResetQuery(this AzureKeyvaultCertificateShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateShowSettings SetVerbose(this AzureKeyvaultCertificateShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateShowSettings ResetVerbose(this AzureKeyvaultCertificateShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureKeyvaultCertificateShowDeletedSettingsExtensions
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureKeyvaultCertificateShowDeletedSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateShowDeletedSettings.Name"/>.</em></p><p>Name of the certificate.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateShowDeletedSettings SetName(this AzureKeyvaultCertificateShowDeletedSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateShowDeletedSettings.Name"/>.</em></p><p>Name of the certificate.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateShowDeletedSettings ResetName(this AzureKeyvaultCertificateShowDeletedSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region VaultName
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateShowDeletedSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateShowDeletedSettings SetVaultName(this AzureKeyvaultCertificateShowDeletedSettings toolSettings, string vaultName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = vaultName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateShowDeletedSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateShowDeletedSettings ResetVaultName(this AzureKeyvaultCertificateShowDeletedSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateShowDeletedSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateShowDeletedSettings SetDebug(this AzureKeyvaultCertificateShowDeletedSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateShowDeletedSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateShowDeletedSettings ResetDebug(this AzureKeyvaultCertificateShowDeletedSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateShowDeletedSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateShowDeletedSettings SetHelp(this AzureKeyvaultCertificateShowDeletedSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateShowDeletedSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateShowDeletedSettings ResetHelp(this AzureKeyvaultCertificateShowDeletedSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateShowDeletedSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateShowDeletedSettings SetOutput(this AzureKeyvaultCertificateShowDeletedSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateShowDeletedSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateShowDeletedSettings ResetOutput(this AzureKeyvaultCertificateShowDeletedSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateShowDeletedSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateShowDeletedSettings SetQuery(this AzureKeyvaultCertificateShowDeletedSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateShowDeletedSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateShowDeletedSettings ResetQuery(this AzureKeyvaultCertificateShowDeletedSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateShowDeletedSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateShowDeletedSettings SetVerbose(this AzureKeyvaultCertificateShowDeletedSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateShowDeletedSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateShowDeletedSettings ResetVerbose(this AzureKeyvaultCertificateShowDeletedSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureKeyvaultKeyBackupSettingsExtensions
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureKeyvaultKeyBackupSettingsExtensions
    {
        #region File
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyBackupSettings.File"/>.</em></p><p>Local file path in which to store key backup.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyBackupSettings SetFile(this AzureKeyvaultKeyBackupSettings toolSettings, string file)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.File = file;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyBackupSettings.File"/>.</em></p><p>Local file path in which to store key backup.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyBackupSettings ResetFile(this AzureKeyvaultKeyBackupSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.File = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyBackupSettings.Name"/>.</em></p><p>Name of the key.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyBackupSettings SetName(this AzureKeyvaultKeyBackupSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyBackupSettings.Name"/>.</em></p><p>Name of the key.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyBackupSettings ResetName(this AzureKeyvaultKeyBackupSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region VaultName
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyBackupSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyBackupSettings SetVaultName(this AzureKeyvaultKeyBackupSettings toolSettings, string vaultName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = vaultName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyBackupSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyBackupSettings ResetVaultName(this AzureKeyvaultKeyBackupSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyBackupSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyBackupSettings SetDebug(this AzureKeyvaultKeyBackupSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyBackupSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyBackupSettings ResetDebug(this AzureKeyvaultKeyBackupSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyBackupSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyBackupSettings SetHelp(this AzureKeyvaultKeyBackupSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyBackupSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyBackupSettings ResetHelp(this AzureKeyvaultKeyBackupSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyBackupSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyBackupSettings SetOutput(this AzureKeyvaultKeyBackupSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyBackupSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyBackupSettings ResetOutput(this AzureKeyvaultKeyBackupSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyBackupSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyBackupSettings SetQuery(this AzureKeyvaultKeyBackupSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyBackupSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyBackupSettings ResetQuery(this AzureKeyvaultKeyBackupSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyBackupSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyBackupSettings SetVerbose(this AzureKeyvaultKeyBackupSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyBackupSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyBackupSettings ResetVerbose(this AzureKeyvaultKeyBackupSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureKeyvaultKeyCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureKeyvaultKeyCreateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyCreateSettings.Name"/>.</em></p><p>Name of the key.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyCreateSettings SetName(this AzureKeyvaultKeyCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyCreateSettings.Name"/>.</em></p><p>Name of the key.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyCreateSettings ResetName(this AzureKeyvaultKeyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Protection
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyCreateSettings.Protection"/>.</em></p><p>Specifies the type of key protection.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyCreateSettings SetProtection(this AzureKeyvaultKeyCreateSettings toolSettings, KeyvaultKeyProtection protection)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Protection = protection;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyCreateSettings.Protection"/>.</em></p><p>Specifies the type of key protection.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyCreateSettings ResetProtection(this AzureKeyvaultKeyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Protection = null;
            return toolSettings;
        }
        #endregion
        #region VaultName
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyCreateSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyCreateSettings SetVaultName(this AzureKeyvaultKeyCreateSettings toolSettings, string vaultName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = vaultName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyCreateSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyCreateSettings ResetVaultName(this AzureKeyvaultKeyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = null;
            return toolSettings;
        }
        #endregion
        #region Disabled
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyCreateSettings.Disabled"/>.</em></p><p>Create key in disabled state.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyCreateSettings SetDisabled(this AzureKeyvaultKeyCreateSettings toolSettings, bool? disabled)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Disabled = disabled;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyCreateSettings.Disabled"/>.</em></p><p>Create key in disabled state.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyCreateSettings ResetDisabled(this AzureKeyvaultKeyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Disabled = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureKeyvaultKeyCreateSettings.Disabled"/>.</em></p><p>Create key in disabled state.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyCreateSettings EnableDisabled(this AzureKeyvaultKeyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Disabled = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureKeyvaultKeyCreateSettings.Disabled"/>.</em></p><p>Create key in disabled state.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyCreateSettings DisableDisabled(this AzureKeyvaultKeyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Disabled = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureKeyvaultKeyCreateSettings.Disabled"/>.</em></p><p>Create key in disabled state.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyCreateSettings ToggleDisabled(this AzureKeyvaultKeyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Disabled = !toolSettings.Disabled;
            return toolSettings;
        }
        #endregion
        #region Expires
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyCreateSettings.Expires"/>.</em></p><p>Expiration UTC datetime  (Y-m-d'T'H:M:S'Z').</p></summary>
        [Pure]
        public static AzureKeyvaultKeyCreateSettings SetExpires(this AzureKeyvaultKeyCreateSettings toolSettings, string expires)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expires = expires;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyCreateSettings.Expires"/>.</em></p><p>Expiration UTC datetime  (Y-m-d'T'H:M:S'Z').</p></summary>
        [Pure]
        public static AzureKeyvaultKeyCreateSettings ResetExpires(this AzureKeyvaultKeyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expires = null;
            return toolSettings;
        }
        #endregion
        #region NotBefore
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyCreateSettings.NotBefore"/>.</em></p><p>Key not usable before the provided UTC datetime  (Y-m-d'T'H:M:S'Z').</p></summary>
        [Pure]
        public static AzureKeyvaultKeyCreateSettings SetNotBefore(this AzureKeyvaultKeyCreateSettings toolSettings, string notBefore)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NotBefore = notBefore;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyCreateSettings.NotBefore"/>.</em></p><p>Key not usable before the provided UTC datetime  (Y-m-d'T'H:M:S'Z').</p></summary>
        [Pure]
        public static AzureKeyvaultKeyCreateSettings ResetNotBefore(this AzureKeyvaultKeyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NotBefore = null;
            return toolSettings;
        }
        #endregion
        #region Ops
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyCreateSettings.Ops"/> to a new list.</em></p><p>Space-separated list of permitted JSON web key operations.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyCreateSettings SetOps(this AzureKeyvaultKeyCreateSettings toolSettings, params KeyvaultKeyOps[] ops)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OpsInternal = ops.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyCreateSettings.Ops"/> to a new list.</em></p><p>Space-separated list of permitted JSON web key operations.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyCreateSettings SetOps(this AzureKeyvaultKeyCreateSettings toolSettings, IEnumerable<KeyvaultKeyOps> ops)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OpsInternal = ops.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureKeyvaultKeyCreateSettings.Ops"/>.</em></p><p>Space-separated list of permitted JSON web key operations.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyCreateSettings AddOps(this AzureKeyvaultKeyCreateSettings toolSettings, params KeyvaultKeyOps[] ops)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OpsInternal.AddRange(ops);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureKeyvaultKeyCreateSettings.Ops"/>.</em></p><p>Space-separated list of permitted JSON web key operations.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyCreateSettings AddOps(this AzureKeyvaultKeyCreateSettings toolSettings, IEnumerable<KeyvaultKeyOps> ops)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OpsInternal.AddRange(ops);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureKeyvaultKeyCreateSettings.Ops"/>.</em></p><p>Space-separated list of permitted JSON web key operations.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyCreateSettings ClearOps(this AzureKeyvaultKeyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OpsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureKeyvaultKeyCreateSettings.Ops"/>.</em></p><p>Space-separated list of permitted JSON web key operations.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyCreateSettings RemoveOps(this AzureKeyvaultKeyCreateSettings toolSettings, params KeyvaultKeyOps[] ops)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<KeyvaultKeyOps>(ops);
            toolSettings.OpsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureKeyvaultKeyCreateSettings.Ops"/>.</em></p><p>Space-separated list of permitted JSON web key operations.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyCreateSettings RemoveOps(this AzureKeyvaultKeyCreateSettings toolSettings, IEnumerable<KeyvaultKeyOps> ops)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<KeyvaultKeyOps>(ops);
            toolSettings.OpsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Size
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyCreateSettings.Size"/>.</em></p><p>The key size in bytes. For example, 1024 or 2048.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyCreateSettings SetSize(this AzureKeyvaultKeyCreateSettings toolSettings, string size)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Size = size;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyCreateSettings.Size"/>.</em></p><p>The key size in bytes. For example, 1024 or 2048.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyCreateSettings ResetSize(this AzureKeyvaultKeyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Size = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyCreateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyCreateSettings SetTags(this AzureKeyvaultKeyCreateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyCreateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyCreateSettings ResetTags(this AzureKeyvaultKeyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyCreateSettings SetDebug(this AzureKeyvaultKeyCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyCreateSettings ResetDebug(this AzureKeyvaultKeyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyCreateSettings SetHelp(this AzureKeyvaultKeyCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyCreateSettings ResetHelp(this AzureKeyvaultKeyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyCreateSettings SetOutput(this AzureKeyvaultKeyCreateSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyCreateSettings ResetOutput(this AzureKeyvaultKeyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyCreateSettings SetQuery(this AzureKeyvaultKeyCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyCreateSettings ResetQuery(this AzureKeyvaultKeyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyCreateSettings SetVerbose(this AzureKeyvaultKeyCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyCreateSettings ResetVerbose(this AzureKeyvaultKeyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureKeyvaultKeyDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureKeyvaultKeyDeleteSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyDeleteSettings.Name"/>.</em></p><p>Name of the key.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyDeleteSettings SetName(this AzureKeyvaultKeyDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyDeleteSettings.Name"/>.</em></p><p>Name of the key.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyDeleteSettings ResetName(this AzureKeyvaultKeyDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region VaultName
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyDeleteSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyDeleteSettings SetVaultName(this AzureKeyvaultKeyDeleteSettings toolSettings, string vaultName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = vaultName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyDeleteSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyDeleteSettings ResetVaultName(this AzureKeyvaultKeyDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyDeleteSettings SetDebug(this AzureKeyvaultKeyDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyDeleteSettings ResetDebug(this AzureKeyvaultKeyDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyDeleteSettings SetHelp(this AzureKeyvaultKeyDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyDeleteSettings ResetHelp(this AzureKeyvaultKeyDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyDeleteSettings SetOutput(this AzureKeyvaultKeyDeleteSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyDeleteSettings ResetOutput(this AzureKeyvaultKeyDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyDeleteSettings SetQuery(this AzureKeyvaultKeyDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyDeleteSettings ResetQuery(this AzureKeyvaultKeyDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyDeleteSettings SetVerbose(this AzureKeyvaultKeyDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyDeleteSettings ResetVerbose(this AzureKeyvaultKeyDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureKeyvaultKeyImportSettingsExtensions
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureKeyvaultKeyImportSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyImportSettings.Name"/>.</em></p><p>Name of the key.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyImportSettings SetName(this AzureKeyvaultKeyImportSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyImportSettings.Name"/>.</em></p><p>Name of the key.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyImportSettings ResetName(this AzureKeyvaultKeyImportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region VaultName
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyImportSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyImportSettings SetVaultName(this AzureKeyvaultKeyImportSettings toolSettings, string vaultName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = vaultName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyImportSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyImportSettings ResetVaultName(this AzureKeyvaultKeyImportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = null;
            return toolSettings;
        }
        #endregion
        #region Disabled
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyImportSettings.Disabled"/>.</em></p><p>Create key in disabled state.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyImportSettings SetDisabled(this AzureKeyvaultKeyImportSettings toolSettings, bool? disabled)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Disabled = disabled;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyImportSettings.Disabled"/>.</em></p><p>Create key in disabled state.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyImportSettings ResetDisabled(this AzureKeyvaultKeyImportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Disabled = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureKeyvaultKeyImportSettings.Disabled"/>.</em></p><p>Create key in disabled state.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyImportSettings EnableDisabled(this AzureKeyvaultKeyImportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Disabled = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureKeyvaultKeyImportSettings.Disabled"/>.</em></p><p>Create key in disabled state.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyImportSettings DisableDisabled(this AzureKeyvaultKeyImportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Disabled = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureKeyvaultKeyImportSettings.Disabled"/>.</em></p><p>Create key in disabled state.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyImportSettings ToggleDisabled(this AzureKeyvaultKeyImportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Disabled = !toolSettings.Disabled;
            return toolSettings;
        }
        #endregion
        #region Expires
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyImportSettings.Expires"/>.</em></p><p>Expiration UTC datetime  (Y-m-d'T'H:M:S'Z').</p></summary>
        [Pure]
        public static AzureKeyvaultKeyImportSettings SetExpires(this AzureKeyvaultKeyImportSettings toolSettings, string expires)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expires = expires;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyImportSettings.Expires"/>.</em></p><p>Expiration UTC datetime  (Y-m-d'T'H:M:S'Z').</p></summary>
        [Pure]
        public static AzureKeyvaultKeyImportSettings ResetExpires(this AzureKeyvaultKeyImportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expires = null;
            return toolSettings;
        }
        #endregion
        #region NotBefore
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyImportSettings.NotBefore"/>.</em></p><p>Key not usable before the provided UTC datetime  (Y-m-d'T'H:M:S'Z').</p></summary>
        [Pure]
        public static AzureKeyvaultKeyImportSettings SetNotBefore(this AzureKeyvaultKeyImportSettings toolSettings, string notBefore)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NotBefore = notBefore;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyImportSettings.NotBefore"/>.</em></p><p>Key not usable before the provided UTC datetime  (Y-m-d'T'H:M:S'Z').</p></summary>
        [Pure]
        public static AzureKeyvaultKeyImportSettings ResetNotBefore(this AzureKeyvaultKeyImportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NotBefore = null;
            return toolSettings;
        }
        #endregion
        #region Ops
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyImportSettings.Ops"/> to a new list.</em></p><p>Space-separated list of permitted JSON web key operations.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyImportSettings SetOps(this AzureKeyvaultKeyImportSettings toolSettings, params KeyvaultKeyOps[] ops)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OpsInternal = ops.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyImportSettings.Ops"/> to a new list.</em></p><p>Space-separated list of permitted JSON web key operations.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyImportSettings SetOps(this AzureKeyvaultKeyImportSettings toolSettings, IEnumerable<KeyvaultKeyOps> ops)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OpsInternal = ops.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureKeyvaultKeyImportSettings.Ops"/>.</em></p><p>Space-separated list of permitted JSON web key operations.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyImportSettings AddOps(this AzureKeyvaultKeyImportSettings toolSettings, params KeyvaultKeyOps[] ops)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OpsInternal.AddRange(ops);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureKeyvaultKeyImportSettings.Ops"/>.</em></p><p>Space-separated list of permitted JSON web key operations.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyImportSettings AddOps(this AzureKeyvaultKeyImportSettings toolSettings, IEnumerable<KeyvaultKeyOps> ops)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OpsInternal.AddRange(ops);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureKeyvaultKeyImportSettings.Ops"/>.</em></p><p>Space-separated list of permitted JSON web key operations.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyImportSettings ClearOps(this AzureKeyvaultKeyImportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OpsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureKeyvaultKeyImportSettings.Ops"/>.</em></p><p>Space-separated list of permitted JSON web key operations.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyImportSettings RemoveOps(this AzureKeyvaultKeyImportSettings toolSettings, params KeyvaultKeyOps[] ops)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<KeyvaultKeyOps>(ops);
            toolSettings.OpsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureKeyvaultKeyImportSettings.Ops"/>.</em></p><p>Space-separated list of permitted JSON web key operations.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyImportSettings RemoveOps(this AzureKeyvaultKeyImportSettings toolSettings, IEnumerable<KeyvaultKeyOps> ops)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<KeyvaultKeyOps>(ops);
            toolSettings.OpsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Protection
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyImportSettings.Protection"/>.</em></p><p>Specifies the type of key protection.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyImportSettings SetProtection(this AzureKeyvaultKeyImportSettings toolSettings, KeyvaultKeyProtection protection)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Protection = protection;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyImportSettings.Protection"/>.</em></p><p>Specifies the type of key protection.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyImportSettings ResetProtection(this AzureKeyvaultKeyImportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Protection = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyImportSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyImportSettings SetTags(this AzureKeyvaultKeyImportSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyImportSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyImportSettings ResetTags(this AzureKeyvaultKeyImportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region ByokFile
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyImportSettings.ByokFile"/>.</em></p><p>BYOK file containing the key to be imported. Must not be password protected.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyImportSettings SetByokFile(this AzureKeyvaultKeyImportSettings toolSettings, string byokFile)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ByokFile = byokFile;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyImportSettings.ByokFile"/>.</em></p><p>BYOK file containing the key to be imported. Must not be password protected.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyImportSettings ResetByokFile(this AzureKeyvaultKeyImportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ByokFile = null;
            return toolSettings;
        }
        #endregion
        #region PemFile
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyImportSettings.PemFile"/>.</em></p><p>PEM file containing the key to be imported.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyImportSettings SetPemFile(this AzureKeyvaultKeyImportSettings toolSettings, string pemFile)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PemFile = pemFile;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyImportSettings.PemFile"/>.</em></p><p>PEM file containing the key to be imported.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyImportSettings ResetPemFile(this AzureKeyvaultKeyImportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PemFile = null;
            return toolSettings;
        }
        #endregion
        #region PemPassword
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyImportSettings.PemPassword"/>.</em></p><p>Password of PEM file.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyImportSettings SetPemPassword(this AzureKeyvaultKeyImportSettings toolSettings, string pemPassword)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PemPassword = pemPassword;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyImportSettings.PemPassword"/>.</em></p><p>Password of PEM file.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyImportSettings ResetPemPassword(this AzureKeyvaultKeyImportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PemPassword = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyImportSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyImportSettings SetDebug(this AzureKeyvaultKeyImportSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyImportSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyImportSettings ResetDebug(this AzureKeyvaultKeyImportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyImportSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyImportSettings SetHelp(this AzureKeyvaultKeyImportSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyImportSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyImportSettings ResetHelp(this AzureKeyvaultKeyImportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyImportSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyImportSettings SetOutput(this AzureKeyvaultKeyImportSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyImportSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyImportSettings ResetOutput(this AzureKeyvaultKeyImportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyImportSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyImportSettings SetQuery(this AzureKeyvaultKeyImportSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyImportSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyImportSettings ResetQuery(this AzureKeyvaultKeyImportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyImportSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyImportSettings SetVerbose(this AzureKeyvaultKeyImportSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyImportSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyImportSettings ResetVerbose(this AzureKeyvaultKeyImportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureKeyvaultKeyListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureKeyvaultKeyListSettingsExtensions
    {
        #region VaultName
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyListSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyListSettings SetVaultName(this AzureKeyvaultKeyListSettings toolSettings, string vaultName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = vaultName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyListSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyListSettings ResetVaultName(this AzureKeyvaultKeyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = null;
            return toolSettings;
        }
        #endregion
        #region Maxresults
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyListSettings.Maxresults"/>.</em></p><p>Maximum number of results to return in a page. If not specified the service will return up to 25 results.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyListSettings SetMaxresults(this AzureKeyvaultKeyListSettings toolSettings, string maxresults)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Maxresults = maxresults;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyListSettings.Maxresults"/>.</em></p><p>Maximum number of results to return in a page. If not specified the service will return up to 25 results.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyListSettings ResetMaxresults(this AzureKeyvaultKeyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Maxresults = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyListSettings SetDebug(this AzureKeyvaultKeyListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyListSettings ResetDebug(this AzureKeyvaultKeyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyListSettings SetHelp(this AzureKeyvaultKeyListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyListSettings ResetHelp(this AzureKeyvaultKeyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyListSettings SetOutput(this AzureKeyvaultKeyListSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyListSettings ResetOutput(this AzureKeyvaultKeyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyListSettings SetQuery(this AzureKeyvaultKeyListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyListSettings ResetQuery(this AzureKeyvaultKeyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyListSettings SetVerbose(this AzureKeyvaultKeyListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyListSettings ResetVerbose(this AzureKeyvaultKeyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureKeyvaultKeyListDeletedSettingsExtensions
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureKeyvaultKeyListDeletedSettingsExtensions
    {
        #region VaultName
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyListDeletedSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyListDeletedSettings SetVaultName(this AzureKeyvaultKeyListDeletedSettings toolSettings, string vaultName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = vaultName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyListDeletedSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyListDeletedSettings ResetVaultName(this AzureKeyvaultKeyListDeletedSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = null;
            return toolSettings;
        }
        #endregion
        #region Maxresults
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyListDeletedSettings.Maxresults"/>.</em></p><p>Maximum number of results to return in a page. If not specified the service will return up to 25 results.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyListDeletedSettings SetMaxresults(this AzureKeyvaultKeyListDeletedSettings toolSettings, string maxresults)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Maxresults = maxresults;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyListDeletedSettings.Maxresults"/>.</em></p><p>Maximum number of results to return in a page. If not specified the service will return up to 25 results.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyListDeletedSettings ResetMaxresults(this AzureKeyvaultKeyListDeletedSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Maxresults = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyListDeletedSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyListDeletedSettings SetDebug(this AzureKeyvaultKeyListDeletedSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyListDeletedSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyListDeletedSettings ResetDebug(this AzureKeyvaultKeyListDeletedSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyListDeletedSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyListDeletedSettings SetHelp(this AzureKeyvaultKeyListDeletedSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyListDeletedSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyListDeletedSettings ResetHelp(this AzureKeyvaultKeyListDeletedSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyListDeletedSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyListDeletedSettings SetOutput(this AzureKeyvaultKeyListDeletedSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyListDeletedSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyListDeletedSettings ResetOutput(this AzureKeyvaultKeyListDeletedSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyListDeletedSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyListDeletedSettings SetQuery(this AzureKeyvaultKeyListDeletedSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyListDeletedSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyListDeletedSettings ResetQuery(this AzureKeyvaultKeyListDeletedSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyListDeletedSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyListDeletedSettings SetVerbose(this AzureKeyvaultKeyListDeletedSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyListDeletedSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyListDeletedSettings ResetVerbose(this AzureKeyvaultKeyListDeletedSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureKeyvaultKeyListVersionsSettingsExtensions
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureKeyvaultKeyListVersionsSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyListVersionsSettings.Name"/>.</em></p><p>Name of the key.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyListVersionsSettings SetName(this AzureKeyvaultKeyListVersionsSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyListVersionsSettings.Name"/>.</em></p><p>Name of the key.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyListVersionsSettings ResetName(this AzureKeyvaultKeyListVersionsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region VaultName
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyListVersionsSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyListVersionsSettings SetVaultName(this AzureKeyvaultKeyListVersionsSettings toolSettings, string vaultName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = vaultName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyListVersionsSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyListVersionsSettings ResetVaultName(this AzureKeyvaultKeyListVersionsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = null;
            return toolSettings;
        }
        #endregion
        #region Maxresults
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyListVersionsSettings.Maxresults"/>.</em></p><p>Maximum number of results to return in a page. If not specified the service will return up to 25 results.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyListVersionsSettings SetMaxresults(this AzureKeyvaultKeyListVersionsSettings toolSettings, string maxresults)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Maxresults = maxresults;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyListVersionsSettings.Maxresults"/>.</em></p><p>Maximum number of results to return in a page. If not specified the service will return up to 25 results.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyListVersionsSettings ResetMaxresults(this AzureKeyvaultKeyListVersionsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Maxresults = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyListVersionsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyListVersionsSettings SetDebug(this AzureKeyvaultKeyListVersionsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyListVersionsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyListVersionsSettings ResetDebug(this AzureKeyvaultKeyListVersionsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyListVersionsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyListVersionsSettings SetHelp(this AzureKeyvaultKeyListVersionsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyListVersionsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyListVersionsSettings ResetHelp(this AzureKeyvaultKeyListVersionsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyListVersionsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyListVersionsSettings SetOutput(this AzureKeyvaultKeyListVersionsSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyListVersionsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyListVersionsSettings ResetOutput(this AzureKeyvaultKeyListVersionsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyListVersionsSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyListVersionsSettings SetQuery(this AzureKeyvaultKeyListVersionsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyListVersionsSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyListVersionsSettings ResetQuery(this AzureKeyvaultKeyListVersionsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyListVersionsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyListVersionsSettings SetVerbose(this AzureKeyvaultKeyListVersionsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyListVersionsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyListVersionsSettings ResetVerbose(this AzureKeyvaultKeyListVersionsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureKeyvaultKeyPurgeSettingsExtensions
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureKeyvaultKeyPurgeSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyPurgeSettings.Name"/>.</em></p><p>Name of the key.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyPurgeSettings SetName(this AzureKeyvaultKeyPurgeSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyPurgeSettings.Name"/>.</em></p><p>Name of the key.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyPurgeSettings ResetName(this AzureKeyvaultKeyPurgeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region VaultName
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyPurgeSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyPurgeSettings SetVaultName(this AzureKeyvaultKeyPurgeSettings toolSettings, string vaultName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = vaultName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyPurgeSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyPurgeSettings ResetVaultName(this AzureKeyvaultKeyPurgeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyPurgeSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyPurgeSettings SetDebug(this AzureKeyvaultKeyPurgeSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyPurgeSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyPurgeSettings ResetDebug(this AzureKeyvaultKeyPurgeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyPurgeSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyPurgeSettings SetHelp(this AzureKeyvaultKeyPurgeSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyPurgeSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyPurgeSettings ResetHelp(this AzureKeyvaultKeyPurgeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyPurgeSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyPurgeSettings SetOutput(this AzureKeyvaultKeyPurgeSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyPurgeSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyPurgeSettings ResetOutput(this AzureKeyvaultKeyPurgeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyPurgeSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyPurgeSettings SetQuery(this AzureKeyvaultKeyPurgeSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyPurgeSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyPurgeSettings ResetQuery(this AzureKeyvaultKeyPurgeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyPurgeSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyPurgeSettings SetVerbose(this AzureKeyvaultKeyPurgeSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyPurgeSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyPurgeSettings ResetVerbose(this AzureKeyvaultKeyPurgeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureKeyvaultKeyRecoverSettingsExtensions
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureKeyvaultKeyRecoverSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyRecoverSettings.Name"/>.</em></p><p>Name of the key.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyRecoverSettings SetName(this AzureKeyvaultKeyRecoverSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyRecoverSettings.Name"/>.</em></p><p>Name of the key.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyRecoverSettings ResetName(this AzureKeyvaultKeyRecoverSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region VaultName
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyRecoverSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyRecoverSettings SetVaultName(this AzureKeyvaultKeyRecoverSettings toolSettings, string vaultName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = vaultName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyRecoverSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyRecoverSettings ResetVaultName(this AzureKeyvaultKeyRecoverSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyRecoverSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyRecoverSettings SetDebug(this AzureKeyvaultKeyRecoverSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyRecoverSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyRecoverSettings ResetDebug(this AzureKeyvaultKeyRecoverSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyRecoverSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyRecoverSettings SetHelp(this AzureKeyvaultKeyRecoverSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyRecoverSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyRecoverSettings ResetHelp(this AzureKeyvaultKeyRecoverSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyRecoverSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyRecoverSettings SetOutput(this AzureKeyvaultKeyRecoverSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyRecoverSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyRecoverSettings ResetOutput(this AzureKeyvaultKeyRecoverSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyRecoverSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyRecoverSettings SetQuery(this AzureKeyvaultKeyRecoverSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyRecoverSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyRecoverSettings ResetQuery(this AzureKeyvaultKeyRecoverSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyRecoverSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyRecoverSettings SetVerbose(this AzureKeyvaultKeyRecoverSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyRecoverSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyRecoverSettings ResetVerbose(this AzureKeyvaultKeyRecoverSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureKeyvaultKeyRestoreSettingsExtensions
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureKeyvaultKeyRestoreSettingsExtensions
    {
        #region File
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyRestoreSettings.File"/>.</em></p><p>Local key backup from which to restore key.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyRestoreSettings SetFile(this AzureKeyvaultKeyRestoreSettings toolSettings, string file)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.File = file;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyRestoreSettings.File"/>.</em></p><p>Local key backup from which to restore key.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyRestoreSettings ResetFile(this AzureKeyvaultKeyRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.File = null;
            return toolSettings;
        }
        #endregion
        #region VaultName
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyRestoreSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyRestoreSettings SetVaultName(this AzureKeyvaultKeyRestoreSettings toolSettings, string vaultName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = vaultName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyRestoreSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyRestoreSettings ResetVaultName(this AzureKeyvaultKeyRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyRestoreSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyRestoreSettings SetDebug(this AzureKeyvaultKeyRestoreSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyRestoreSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyRestoreSettings ResetDebug(this AzureKeyvaultKeyRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyRestoreSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyRestoreSettings SetHelp(this AzureKeyvaultKeyRestoreSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyRestoreSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyRestoreSettings ResetHelp(this AzureKeyvaultKeyRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyRestoreSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyRestoreSettings SetOutput(this AzureKeyvaultKeyRestoreSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyRestoreSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyRestoreSettings ResetOutput(this AzureKeyvaultKeyRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyRestoreSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyRestoreSettings SetQuery(this AzureKeyvaultKeyRestoreSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyRestoreSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyRestoreSettings ResetQuery(this AzureKeyvaultKeyRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyRestoreSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyRestoreSettings SetVerbose(this AzureKeyvaultKeyRestoreSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyRestoreSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyRestoreSettings ResetVerbose(this AzureKeyvaultKeyRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureKeyvaultKeySetAttributesSettingsExtensions
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureKeyvaultKeySetAttributesSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeySetAttributesSettings.Name"/>.</em></p><p>Name of the key.</p></summary>
        [Pure]
        public static AzureKeyvaultKeySetAttributesSettings SetName(this AzureKeyvaultKeySetAttributesSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeySetAttributesSettings.Name"/>.</em></p><p>Name of the key.</p></summary>
        [Pure]
        public static AzureKeyvaultKeySetAttributesSettings ResetName(this AzureKeyvaultKeySetAttributesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region VaultName
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeySetAttributesSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultKeySetAttributesSettings SetVaultName(this AzureKeyvaultKeySetAttributesSettings toolSettings, string vaultName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = vaultName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeySetAttributesSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultKeySetAttributesSettings ResetVaultName(this AzureKeyvaultKeySetAttributesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = null;
            return toolSettings;
        }
        #endregion
        #region Enabled
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeySetAttributesSettings.Enabled"/>.</em></p><p>Enable the key.</p></summary>
        [Pure]
        public static AzureKeyvaultKeySetAttributesSettings SetEnabled(this AzureKeyvaultKeySetAttributesSettings toolSettings, bool? enabled)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Enabled = enabled;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeySetAttributesSettings.Enabled"/>.</em></p><p>Enable the key.</p></summary>
        [Pure]
        public static AzureKeyvaultKeySetAttributesSettings ResetEnabled(this AzureKeyvaultKeySetAttributesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Enabled = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureKeyvaultKeySetAttributesSettings.Enabled"/>.</em></p><p>Enable the key.</p></summary>
        [Pure]
        public static AzureKeyvaultKeySetAttributesSettings EnableEnabled(this AzureKeyvaultKeySetAttributesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Enabled = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureKeyvaultKeySetAttributesSettings.Enabled"/>.</em></p><p>Enable the key.</p></summary>
        [Pure]
        public static AzureKeyvaultKeySetAttributesSettings DisableEnabled(this AzureKeyvaultKeySetAttributesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Enabled = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureKeyvaultKeySetAttributesSettings.Enabled"/>.</em></p><p>Enable the key.</p></summary>
        [Pure]
        public static AzureKeyvaultKeySetAttributesSettings ToggleEnabled(this AzureKeyvaultKeySetAttributesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Enabled = !toolSettings.Enabled;
            return toolSettings;
        }
        #endregion
        #region Expires
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeySetAttributesSettings.Expires"/>.</em></p><p>Expiration UTC datetime  (Y-m-d'T'H:M:S'Z').</p></summary>
        [Pure]
        public static AzureKeyvaultKeySetAttributesSettings SetExpires(this AzureKeyvaultKeySetAttributesSettings toolSettings, string expires)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expires = expires;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeySetAttributesSettings.Expires"/>.</em></p><p>Expiration UTC datetime  (Y-m-d'T'H:M:S'Z').</p></summary>
        [Pure]
        public static AzureKeyvaultKeySetAttributesSettings ResetExpires(this AzureKeyvaultKeySetAttributesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expires = null;
            return toolSettings;
        }
        #endregion
        #region NotBefore
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeySetAttributesSettings.NotBefore"/>.</em></p><p>Key not usable before the provided UTC datetime  (Y-m-d'T'H:M:S'Z').</p></summary>
        [Pure]
        public static AzureKeyvaultKeySetAttributesSettings SetNotBefore(this AzureKeyvaultKeySetAttributesSettings toolSettings, string notBefore)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NotBefore = notBefore;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeySetAttributesSettings.NotBefore"/>.</em></p><p>Key not usable before the provided UTC datetime  (Y-m-d'T'H:M:S'Z').</p></summary>
        [Pure]
        public static AzureKeyvaultKeySetAttributesSettings ResetNotBefore(this AzureKeyvaultKeySetAttributesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NotBefore = null;
            return toolSettings;
        }
        #endregion
        #region Ops
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeySetAttributesSettings.Ops"/> to a new list.</em></p><p>Space-separated list of permitted JSON web key operations.</p></summary>
        [Pure]
        public static AzureKeyvaultKeySetAttributesSettings SetOps(this AzureKeyvaultKeySetAttributesSettings toolSettings, params KeyvaultKeyOps[] ops)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OpsInternal = ops.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeySetAttributesSettings.Ops"/> to a new list.</em></p><p>Space-separated list of permitted JSON web key operations.</p></summary>
        [Pure]
        public static AzureKeyvaultKeySetAttributesSettings SetOps(this AzureKeyvaultKeySetAttributesSettings toolSettings, IEnumerable<KeyvaultKeyOps> ops)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OpsInternal = ops.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureKeyvaultKeySetAttributesSettings.Ops"/>.</em></p><p>Space-separated list of permitted JSON web key operations.</p></summary>
        [Pure]
        public static AzureKeyvaultKeySetAttributesSettings AddOps(this AzureKeyvaultKeySetAttributesSettings toolSettings, params KeyvaultKeyOps[] ops)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OpsInternal.AddRange(ops);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureKeyvaultKeySetAttributesSettings.Ops"/>.</em></p><p>Space-separated list of permitted JSON web key operations.</p></summary>
        [Pure]
        public static AzureKeyvaultKeySetAttributesSettings AddOps(this AzureKeyvaultKeySetAttributesSettings toolSettings, IEnumerable<KeyvaultKeyOps> ops)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OpsInternal.AddRange(ops);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureKeyvaultKeySetAttributesSettings.Ops"/>.</em></p><p>Space-separated list of permitted JSON web key operations.</p></summary>
        [Pure]
        public static AzureKeyvaultKeySetAttributesSettings ClearOps(this AzureKeyvaultKeySetAttributesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OpsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureKeyvaultKeySetAttributesSettings.Ops"/>.</em></p><p>Space-separated list of permitted JSON web key operations.</p></summary>
        [Pure]
        public static AzureKeyvaultKeySetAttributesSettings RemoveOps(this AzureKeyvaultKeySetAttributesSettings toolSettings, params KeyvaultKeyOps[] ops)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<KeyvaultKeyOps>(ops);
            toolSettings.OpsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureKeyvaultKeySetAttributesSettings.Ops"/>.</em></p><p>Space-separated list of permitted JSON web key operations.</p></summary>
        [Pure]
        public static AzureKeyvaultKeySetAttributesSettings RemoveOps(this AzureKeyvaultKeySetAttributesSettings toolSettings, IEnumerable<KeyvaultKeyOps> ops)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<KeyvaultKeyOps>(ops);
            toolSettings.OpsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeySetAttributesSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureKeyvaultKeySetAttributesSettings SetTags(this AzureKeyvaultKeySetAttributesSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeySetAttributesSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureKeyvaultKeySetAttributesSettings ResetTags(this AzureKeyvaultKeySetAttributesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Version
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeySetAttributesSettings.Version"/>.</em></p><p>The key version. If omitted, uses the latest version.</p></summary>
        [Pure]
        public static AzureKeyvaultKeySetAttributesSettings SetVersion(this AzureKeyvaultKeySetAttributesSettings toolSettings, string version)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = version;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeySetAttributesSettings.Version"/>.</em></p><p>The key version. If omitted, uses the latest version.</p></summary>
        [Pure]
        public static AzureKeyvaultKeySetAttributesSettings ResetVersion(this AzureKeyvaultKeySetAttributesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeySetAttributesSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultKeySetAttributesSettings SetDebug(this AzureKeyvaultKeySetAttributesSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeySetAttributesSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultKeySetAttributesSettings ResetDebug(this AzureKeyvaultKeySetAttributesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeySetAttributesSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultKeySetAttributesSettings SetHelp(this AzureKeyvaultKeySetAttributesSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeySetAttributesSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultKeySetAttributesSettings ResetHelp(this AzureKeyvaultKeySetAttributesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeySetAttributesSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultKeySetAttributesSettings SetOutput(this AzureKeyvaultKeySetAttributesSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeySetAttributesSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultKeySetAttributesSettings ResetOutput(this AzureKeyvaultKeySetAttributesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeySetAttributesSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultKeySetAttributesSettings SetQuery(this AzureKeyvaultKeySetAttributesSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeySetAttributesSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultKeySetAttributesSettings ResetQuery(this AzureKeyvaultKeySetAttributesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeySetAttributesSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultKeySetAttributesSettings SetVerbose(this AzureKeyvaultKeySetAttributesSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeySetAttributesSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultKeySetAttributesSettings ResetVerbose(this AzureKeyvaultKeySetAttributesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureKeyvaultKeyShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureKeyvaultKeyShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyShowSettings.Name"/>.</em></p><p>Name of the key.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyShowSettings SetName(this AzureKeyvaultKeyShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyShowSettings.Name"/>.</em></p><p>Name of the key.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyShowSettings ResetName(this AzureKeyvaultKeyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region VaultName
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyShowSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyShowSettings SetVaultName(this AzureKeyvaultKeyShowSettings toolSettings, string vaultName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = vaultName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyShowSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyShowSettings ResetVaultName(this AzureKeyvaultKeyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = null;
            return toolSettings;
        }
        #endregion
        #region Version
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyShowSettings.Version"/>.</em></p><p>The key version. If omitted, uses the latest version.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyShowSettings SetVersion(this AzureKeyvaultKeyShowSettings toolSettings, string version)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = version;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyShowSettings.Version"/>.</em></p><p>The key version. If omitted, uses the latest version.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyShowSettings ResetVersion(this AzureKeyvaultKeyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyShowSettings SetDebug(this AzureKeyvaultKeyShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyShowSettings ResetDebug(this AzureKeyvaultKeyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyShowSettings SetHelp(this AzureKeyvaultKeyShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyShowSettings ResetHelp(this AzureKeyvaultKeyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyShowSettings SetOutput(this AzureKeyvaultKeyShowSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyShowSettings ResetOutput(this AzureKeyvaultKeyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyShowSettings SetQuery(this AzureKeyvaultKeyShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyShowSettings ResetQuery(this AzureKeyvaultKeyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyShowSettings SetVerbose(this AzureKeyvaultKeyShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyShowSettings ResetVerbose(this AzureKeyvaultKeyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureKeyvaultKeyShowDeletedSettingsExtensions
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureKeyvaultKeyShowDeletedSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyShowDeletedSettings.Name"/>.</em></p><p>Name of the key.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyShowDeletedSettings SetName(this AzureKeyvaultKeyShowDeletedSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyShowDeletedSettings.Name"/>.</em></p><p>Name of the key.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyShowDeletedSettings ResetName(this AzureKeyvaultKeyShowDeletedSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region VaultName
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyShowDeletedSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyShowDeletedSettings SetVaultName(this AzureKeyvaultKeyShowDeletedSettings toolSettings, string vaultName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = vaultName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyShowDeletedSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyShowDeletedSettings ResetVaultName(this AzureKeyvaultKeyShowDeletedSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyShowDeletedSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyShowDeletedSettings SetDebug(this AzureKeyvaultKeyShowDeletedSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyShowDeletedSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyShowDeletedSettings ResetDebug(this AzureKeyvaultKeyShowDeletedSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyShowDeletedSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyShowDeletedSettings SetHelp(this AzureKeyvaultKeyShowDeletedSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyShowDeletedSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyShowDeletedSettings ResetHelp(this AzureKeyvaultKeyShowDeletedSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyShowDeletedSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyShowDeletedSettings SetOutput(this AzureKeyvaultKeyShowDeletedSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyShowDeletedSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyShowDeletedSettings ResetOutput(this AzureKeyvaultKeyShowDeletedSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyShowDeletedSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyShowDeletedSettings SetQuery(this AzureKeyvaultKeyShowDeletedSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyShowDeletedSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyShowDeletedSettings ResetQuery(this AzureKeyvaultKeyShowDeletedSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureKeyvaultKeyShowDeletedSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyShowDeletedSettings SetVerbose(this AzureKeyvaultKeyShowDeletedSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultKeyShowDeletedSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultKeyShowDeletedSettings ResetVerbose(this AzureKeyvaultKeyShowDeletedSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureKeyvaultSecretBackupSettingsExtensions
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureKeyvaultSecretBackupSettingsExtensions
    {
        #region FilePath
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretBackupSettings.FilePath"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureKeyvaultSecretBackupSettings SetFilePath(this AzureKeyvaultSecretBackupSettings toolSettings, string filePath)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FilePath = filePath;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretBackupSettings.FilePath"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureKeyvaultSecretBackupSettings ResetFilePath(this AzureKeyvaultSecretBackupSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FilePath = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretBackupSettings.Name"/>.</em></p><p>Name of the secret.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretBackupSettings SetName(this AzureKeyvaultSecretBackupSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretBackupSettings.Name"/>.</em></p><p>Name of the secret.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretBackupSettings ResetName(this AzureKeyvaultSecretBackupSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region VaultName
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretBackupSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretBackupSettings SetVaultName(this AzureKeyvaultSecretBackupSettings toolSettings, string vaultName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = vaultName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretBackupSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretBackupSettings ResetVaultName(this AzureKeyvaultSecretBackupSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretBackupSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretBackupSettings SetDebug(this AzureKeyvaultSecretBackupSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretBackupSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretBackupSettings ResetDebug(this AzureKeyvaultSecretBackupSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretBackupSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretBackupSettings SetHelp(this AzureKeyvaultSecretBackupSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretBackupSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretBackupSettings ResetHelp(this AzureKeyvaultSecretBackupSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretBackupSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretBackupSettings SetOutput(this AzureKeyvaultSecretBackupSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretBackupSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretBackupSettings ResetOutput(this AzureKeyvaultSecretBackupSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretBackupSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretBackupSettings SetQuery(this AzureKeyvaultSecretBackupSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretBackupSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretBackupSettings ResetQuery(this AzureKeyvaultSecretBackupSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretBackupSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretBackupSettings SetVerbose(this AzureKeyvaultSecretBackupSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretBackupSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretBackupSettings ResetVerbose(this AzureKeyvaultSecretBackupSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureKeyvaultSecretDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureKeyvaultSecretDeleteSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretDeleteSettings.Name"/>.</em></p><p>Name of the secret.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretDeleteSettings SetName(this AzureKeyvaultSecretDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretDeleteSettings.Name"/>.</em></p><p>Name of the secret.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretDeleteSettings ResetName(this AzureKeyvaultSecretDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region VaultName
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretDeleteSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretDeleteSettings SetVaultName(this AzureKeyvaultSecretDeleteSettings toolSettings, string vaultName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = vaultName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretDeleteSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretDeleteSettings ResetVaultName(this AzureKeyvaultSecretDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretDeleteSettings SetDebug(this AzureKeyvaultSecretDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretDeleteSettings ResetDebug(this AzureKeyvaultSecretDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretDeleteSettings SetHelp(this AzureKeyvaultSecretDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretDeleteSettings ResetHelp(this AzureKeyvaultSecretDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretDeleteSettings SetOutput(this AzureKeyvaultSecretDeleteSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretDeleteSettings ResetOutput(this AzureKeyvaultSecretDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretDeleteSettings SetQuery(this AzureKeyvaultSecretDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretDeleteSettings ResetQuery(this AzureKeyvaultSecretDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretDeleteSettings SetVerbose(this AzureKeyvaultSecretDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretDeleteSettings ResetVerbose(this AzureKeyvaultSecretDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureKeyvaultSecretDownloadSettingsExtensions
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureKeyvaultSecretDownloadSettingsExtensions
    {
        #region File
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretDownloadSettings.File"/>.</em></p><p>File to receive the secret contents.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretDownloadSettings SetFile(this AzureKeyvaultSecretDownloadSettings toolSettings, string file)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.File = file;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretDownloadSettings.File"/>.</em></p><p>File to receive the secret contents.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretDownloadSettings ResetFile(this AzureKeyvaultSecretDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.File = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretDownloadSettings.Name"/>.</em></p><p>Name of the secret.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretDownloadSettings SetName(this AzureKeyvaultSecretDownloadSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretDownloadSettings.Name"/>.</em></p><p>Name of the secret.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretDownloadSettings ResetName(this AzureKeyvaultSecretDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region VaultName
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretDownloadSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretDownloadSettings SetVaultName(this AzureKeyvaultSecretDownloadSettings toolSettings, string vaultName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = vaultName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretDownloadSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretDownloadSettings ResetVaultName(this AzureKeyvaultSecretDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = null;
            return toolSettings;
        }
        #endregion
        #region Encoding
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretDownloadSettings.Encoding"/>.</em></p><p>Encoding of the destination file. By default, will look for the 'file-encoding' tag on the secret. Otherwise will assume 'utf-8'.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretDownloadSettings SetEncoding(this AzureKeyvaultSecretDownloadSettings toolSettings, KeyvaultSecretEncoding encoding)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Encoding = encoding;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretDownloadSettings.Encoding"/>.</em></p><p>Encoding of the destination file. By default, will look for the 'file-encoding' tag on the secret. Otherwise will assume 'utf-8'.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretDownloadSettings ResetEncoding(this AzureKeyvaultSecretDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Encoding = null;
            return toolSettings;
        }
        #endregion
        #region Version
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretDownloadSettings.Version"/>.</em></p><p>The secret version. If omitted, uses the latest version.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretDownloadSettings SetVersion(this AzureKeyvaultSecretDownloadSettings toolSettings, string version)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = version;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretDownloadSettings.Version"/>.</em></p><p>The secret version. If omitted, uses the latest version.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretDownloadSettings ResetVersion(this AzureKeyvaultSecretDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretDownloadSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretDownloadSettings SetDebug(this AzureKeyvaultSecretDownloadSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretDownloadSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretDownloadSettings ResetDebug(this AzureKeyvaultSecretDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretDownloadSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretDownloadSettings SetHelp(this AzureKeyvaultSecretDownloadSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretDownloadSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretDownloadSettings ResetHelp(this AzureKeyvaultSecretDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretDownloadSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretDownloadSettings SetOutput(this AzureKeyvaultSecretDownloadSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretDownloadSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretDownloadSettings ResetOutput(this AzureKeyvaultSecretDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretDownloadSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretDownloadSettings SetQuery(this AzureKeyvaultSecretDownloadSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretDownloadSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretDownloadSettings ResetQuery(this AzureKeyvaultSecretDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretDownloadSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretDownloadSettings SetVerbose(this AzureKeyvaultSecretDownloadSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretDownloadSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretDownloadSettings ResetVerbose(this AzureKeyvaultSecretDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureKeyvaultSecretListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureKeyvaultSecretListSettingsExtensions
    {
        #region VaultName
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretListSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretListSettings SetVaultName(this AzureKeyvaultSecretListSettings toolSettings, string vaultName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = vaultName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretListSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretListSettings ResetVaultName(this AzureKeyvaultSecretListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = null;
            return toolSettings;
        }
        #endregion
        #region Maxresults
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretListSettings.Maxresults"/>.</em></p><p>Maximum number of results to return in a page. If not specified the service will return up to 25 results.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretListSettings SetMaxresults(this AzureKeyvaultSecretListSettings toolSettings, string maxresults)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Maxresults = maxresults;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretListSettings.Maxresults"/>.</em></p><p>Maximum number of results to return in a page. If not specified the service will return up to 25 results.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretListSettings ResetMaxresults(this AzureKeyvaultSecretListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Maxresults = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretListSettings SetDebug(this AzureKeyvaultSecretListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretListSettings ResetDebug(this AzureKeyvaultSecretListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretListSettings SetHelp(this AzureKeyvaultSecretListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretListSettings ResetHelp(this AzureKeyvaultSecretListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretListSettings SetOutput(this AzureKeyvaultSecretListSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretListSettings ResetOutput(this AzureKeyvaultSecretListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretListSettings SetQuery(this AzureKeyvaultSecretListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretListSettings ResetQuery(this AzureKeyvaultSecretListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretListSettings SetVerbose(this AzureKeyvaultSecretListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretListSettings ResetVerbose(this AzureKeyvaultSecretListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureKeyvaultSecretListDeletedSettingsExtensions
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureKeyvaultSecretListDeletedSettingsExtensions
    {
        #region VaultName
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretListDeletedSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretListDeletedSettings SetVaultName(this AzureKeyvaultSecretListDeletedSettings toolSettings, string vaultName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = vaultName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretListDeletedSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretListDeletedSettings ResetVaultName(this AzureKeyvaultSecretListDeletedSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = null;
            return toolSettings;
        }
        #endregion
        #region Maxresults
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretListDeletedSettings.Maxresults"/>.</em></p><p>Maximum number of results to return in a page. If not specified the service will return up to 25 results.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretListDeletedSettings SetMaxresults(this AzureKeyvaultSecretListDeletedSettings toolSettings, string maxresults)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Maxresults = maxresults;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretListDeletedSettings.Maxresults"/>.</em></p><p>Maximum number of results to return in a page. If not specified the service will return up to 25 results.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretListDeletedSettings ResetMaxresults(this AzureKeyvaultSecretListDeletedSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Maxresults = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretListDeletedSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretListDeletedSettings SetDebug(this AzureKeyvaultSecretListDeletedSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretListDeletedSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretListDeletedSettings ResetDebug(this AzureKeyvaultSecretListDeletedSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretListDeletedSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretListDeletedSettings SetHelp(this AzureKeyvaultSecretListDeletedSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretListDeletedSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretListDeletedSettings ResetHelp(this AzureKeyvaultSecretListDeletedSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretListDeletedSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretListDeletedSettings SetOutput(this AzureKeyvaultSecretListDeletedSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretListDeletedSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretListDeletedSettings ResetOutput(this AzureKeyvaultSecretListDeletedSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretListDeletedSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretListDeletedSettings SetQuery(this AzureKeyvaultSecretListDeletedSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretListDeletedSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretListDeletedSettings ResetQuery(this AzureKeyvaultSecretListDeletedSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretListDeletedSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretListDeletedSettings SetVerbose(this AzureKeyvaultSecretListDeletedSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretListDeletedSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretListDeletedSettings ResetVerbose(this AzureKeyvaultSecretListDeletedSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureKeyvaultSecretListVersionsSettingsExtensions
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureKeyvaultSecretListVersionsSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretListVersionsSettings.Name"/>.</em></p><p>Name of the secret.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretListVersionsSettings SetName(this AzureKeyvaultSecretListVersionsSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretListVersionsSettings.Name"/>.</em></p><p>Name of the secret.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretListVersionsSettings ResetName(this AzureKeyvaultSecretListVersionsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region VaultName
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretListVersionsSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretListVersionsSettings SetVaultName(this AzureKeyvaultSecretListVersionsSettings toolSettings, string vaultName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = vaultName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretListVersionsSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretListVersionsSettings ResetVaultName(this AzureKeyvaultSecretListVersionsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = null;
            return toolSettings;
        }
        #endregion
        #region Maxresults
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretListVersionsSettings.Maxresults"/>.</em></p><p>Maximum number of results to return in a page. If not specified the service will return up to 25 results.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretListVersionsSettings SetMaxresults(this AzureKeyvaultSecretListVersionsSettings toolSettings, string maxresults)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Maxresults = maxresults;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretListVersionsSettings.Maxresults"/>.</em></p><p>Maximum number of results to return in a page. If not specified the service will return up to 25 results.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretListVersionsSettings ResetMaxresults(this AzureKeyvaultSecretListVersionsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Maxresults = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretListVersionsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretListVersionsSettings SetDebug(this AzureKeyvaultSecretListVersionsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretListVersionsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretListVersionsSettings ResetDebug(this AzureKeyvaultSecretListVersionsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretListVersionsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretListVersionsSettings SetHelp(this AzureKeyvaultSecretListVersionsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretListVersionsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretListVersionsSettings ResetHelp(this AzureKeyvaultSecretListVersionsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretListVersionsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretListVersionsSettings SetOutput(this AzureKeyvaultSecretListVersionsSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretListVersionsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretListVersionsSettings ResetOutput(this AzureKeyvaultSecretListVersionsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretListVersionsSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretListVersionsSettings SetQuery(this AzureKeyvaultSecretListVersionsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretListVersionsSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretListVersionsSettings ResetQuery(this AzureKeyvaultSecretListVersionsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretListVersionsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretListVersionsSettings SetVerbose(this AzureKeyvaultSecretListVersionsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretListVersionsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretListVersionsSettings ResetVerbose(this AzureKeyvaultSecretListVersionsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureKeyvaultSecretPurgeSettingsExtensions
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureKeyvaultSecretPurgeSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretPurgeSettings.Name"/>.</em></p><p>Name of the secret.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretPurgeSettings SetName(this AzureKeyvaultSecretPurgeSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretPurgeSettings.Name"/>.</em></p><p>Name of the secret.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretPurgeSettings ResetName(this AzureKeyvaultSecretPurgeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region VaultName
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretPurgeSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretPurgeSettings SetVaultName(this AzureKeyvaultSecretPurgeSettings toolSettings, string vaultName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = vaultName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretPurgeSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretPurgeSettings ResetVaultName(this AzureKeyvaultSecretPurgeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretPurgeSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretPurgeSettings SetDebug(this AzureKeyvaultSecretPurgeSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretPurgeSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretPurgeSettings ResetDebug(this AzureKeyvaultSecretPurgeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretPurgeSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretPurgeSettings SetHelp(this AzureKeyvaultSecretPurgeSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretPurgeSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretPurgeSettings ResetHelp(this AzureKeyvaultSecretPurgeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretPurgeSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretPurgeSettings SetOutput(this AzureKeyvaultSecretPurgeSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretPurgeSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretPurgeSettings ResetOutput(this AzureKeyvaultSecretPurgeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretPurgeSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretPurgeSettings SetQuery(this AzureKeyvaultSecretPurgeSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretPurgeSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretPurgeSettings ResetQuery(this AzureKeyvaultSecretPurgeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretPurgeSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretPurgeSettings SetVerbose(this AzureKeyvaultSecretPurgeSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretPurgeSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretPurgeSettings ResetVerbose(this AzureKeyvaultSecretPurgeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureKeyvaultSecretRecoverSettingsExtensions
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureKeyvaultSecretRecoverSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretRecoverSettings.Name"/>.</em></p><p>Name of the secret.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretRecoverSettings SetName(this AzureKeyvaultSecretRecoverSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretRecoverSettings.Name"/>.</em></p><p>Name of the secret.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretRecoverSettings ResetName(this AzureKeyvaultSecretRecoverSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region VaultName
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretRecoverSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretRecoverSettings SetVaultName(this AzureKeyvaultSecretRecoverSettings toolSettings, string vaultName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = vaultName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretRecoverSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretRecoverSettings ResetVaultName(this AzureKeyvaultSecretRecoverSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretRecoverSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretRecoverSettings SetDebug(this AzureKeyvaultSecretRecoverSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretRecoverSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretRecoverSettings ResetDebug(this AzureKeyvaultSecretRecoverSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretRecoverSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretRecoverSettings SetHelp(this AzureKeyvaultSecretRecoverSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretRecoverSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretRecoverSettings ResetHelp(this AzureKeyvaultSecretRecoverSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretRecoverSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretRecoverSettings SetOutput(this AzureKeyvaultSecretRecoverSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretRecoverSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretRecoverSettings ResetOutput(this AzureKeyvaultSecretRecoverSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretRecoverSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretRecoverSettings SetQuery(this AzureKeyvaultSecretRecoverSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretRecoverSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretRecoverSettings ResetQuery(this AzureKeyvaultSecretRecoverSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretRecoverSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretRecoverSettings SetVerbose(this AzureKeyvaultSecretRecoverSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretRecoverSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretRecoverSettings ResetVerbose(this AzureKeyvaultSecretRecoverSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureKeyvaultSecretRestoreSettingsExtensions
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureKeyvaultSecretRestoreSettingsExtensions
    {
        #region FilePath
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretRestoreSettings.FilePath"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureKeyvaultSecretRestoreSettings SetFilePath(this AzureKeyvaultSecretRestoreSettings toolSettings, string filePath)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FilePath = filePath;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretRestoreSettings.FilePath"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureKeyvaultSecretRestoreSettings ResetFilePath(this AzureKeyvaultSecretRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FilePath = null;
            return toolSettings;
        }
        #endregion
        #region VaultName
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretRestoreSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretRestoreSettings SetVaultName(this AzureKeyvaultSecretRestoreSettings toolSettings, string vaultName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = vaultName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretRestoreSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretRestoreSettings ResetVaultName(this AzureKeyvaultSecretRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretRestoreSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretRestoreSettings SetDebug(this AzureKeyvaultSecretRestoreSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretRestoreSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretRestoreSettings ResetDebug(this AzureKeyvaultSecretRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretRestoreSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretRestoreSettings SetHelp(this AzureKeyvaultSecretRestoreSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretRestoreSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretRestoreSettings ResetHelp(this AzureKeyvaultSecretRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretRestoreSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretRestoreSettings SetOutput(this AzureKeyvaultSecretRestoreSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretRestoreSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretRestoreSettings ResetOutput(this AzureKeyvaultSecretRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretRestoreSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretRestoreSettings SetQuery(this AzureKeyvaultSecretRestoreSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretRestoreSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretRestoreSettings ResetQuery(this AzureKeyvaultSecretRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretRestoreSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretRestoreSettings SetVerbose(this AzureKeyvaultSecretRestoreSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretRestoreSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretRestoreSettings ResetVerbose(this AzureKeyvaultSecretRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureKeyvaultSecretSetSettingsExtensions
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureKeyvaultSecretSetSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretSetSettings.Name"/>.</em></p><p>Name of the secret.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretSetSettings SetName(this AzureKeyvaultSecretSetSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretSetSettings.Name"/>.</em></p><p>Name of the secret.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretSetSettings ResetName(this AzureKeyvaultSecretSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region VaultName
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretSetSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretSetSettings SetVaultName(this AzureKeyvaultSecretSetSettings toolSettings, string vaultName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = vaultName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretSetSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretSetSettings ResetVaultName(this AzureKeyvaultSecretSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = null;
            return toolSettings;
        }
        #endregion
        #region Description
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretSetSettings.Description"/>.</em></p><p>Description of the secret contents (e.g. password, connection string, etc).</p></summary>
        [Pure]
        public static AzureKeyvaultSecretSetSettings SetDescription(this AzureKeyvaultSecretSetSettings toolSettings, string description)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Description = description;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretSetSettings.Description"/>.</em></p><p>Description of the secret contents (e.g. password, connection string, etc).</p></summary>
        [Pure]
        public static AzureKeyvaultSecretSetSettings ResetDescription(this AzureKeyvaultSecretSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Description = null;
            return toolSettings;
        }
        #endregion
        #region Disabled
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretSetSettings.Disabled"/>.</em></p><p>Create secret in disabled state.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretSetSettings SetDisabled(this AzureKeyvaultSecretSetSettings toolSettings, bool? disabled)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Disabled = disabled;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretSetSettings.Disabled"/>.</em></p><p>Create secret in disabled state.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretSetSettings ResetDisabled(this AzureKeyvaultSecretSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Disabled = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureKeyvaultSecretSetSettings.Disabled"/>.</em></p><p>Create secret in disabled state.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretSetSettings EnableDisabled(this AzureKeyvaultSecretSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Disabled = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureKeyvaultSecretSetSettings.Disabled"/>.</em></p><p>Create secret in disabled state.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretSetSettings DisableDisabled(this AzureKeyvaultSecretSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Disabled = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureKeyvaultSecretSetSettings.Disabled"/>.</em></p><p>Create secret in disabled state.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretSetSettings ToggleDisabled(this AzureKeyvaultSecretSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Disabled = !toolSettings.Disabled;
            return toolSettings;
        }
        #endregion
        #region Expires
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretSetSettings.Expires"/>.</em></p><p>Expiration UTC datetime  (Y-m-d'T'H:M:S'Z').</p></summary>
        [Pure]
        public static AzureKeyvaultSecretSetSettings SetExpires(this AzureKeyvaultSecretSetSettings toolSettings, string expires)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expires = expires;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretSetSettings.Expires"/>.</em></p><p>Expiration UTC datetime  (Y-m-d'T'H:M:S'Z').</p></summary>
        [Pure]
        public static AzureKeyvaultSecretSetSettings ResetExpires(this AzureKeyvaultSecretSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expires = null;
            return toolSettings;
        }
        #endregion
        #region NotBefore
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretSetSettings.NotBefore"/>.</em></p><p>Key not usable before the provided UTC datetime  (Y-m-d'T'H:M:S'Z').</p></summary>
        [Pure]
        public static AzureKeyvaultSecretSetSettings SetNotBefore(this AzureKeyvaultSecretSetSettings toolSettings, string notBefore)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NotBefore = notBefore;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretSetSettings.NotBefore"/>.</em></p><p>Key not usable before the provided UTC datetime  (Y-m-d'T'H:M:S'Z').</p></summary>
        [Pure]
        public static AzureKeyvaultSecretSetSettings ResetNotBefore(this AzureKeyvaultSecretSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NotBefore = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretSetSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretSetSettings SetTags(this AzureKeyvaultSecretSetSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretSetSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretSetSettings ResetTags(this AzureKeyvaultSecretSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Encoding
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretSetSettings.Encoding"/>.</em></p><p>Source file encoding. The value is saved as a tag (`file-encoding=&amp;lt;val&amp;gt;`) and used during download to automatically encode the resulting file.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretSetSettings SetEncoding(this AzureKeyvaultSecretSetSettings toolSettings, KeyvaultSecretEncoding encoding)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Encoding = encoding;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretSetSettings.Encoding"/>.</em></p><p>Source file encoding. The value is saved as a tag (`file-encoding=&amp;lt;val&amp;gt;`) and used during download to automatically encode the resulting file.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretSetSettings ResetEncoding(this AzureKeyvaultSecretSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Encoding = null;
            return toolSettings;
        }
        #endregion
        #region File
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretSetSettings.File"/>.</em></p><p>Source file for secret. Use in conjunction with '--encoding'.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretSetSettings SetFile(this AzureKeyvaultSecretSetSettings toolSettings, string file)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.File = file;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretSetSettings.File"/>.</em></p><p>Source file for secret. Use in conjunction with '--encoding'.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretSetSettings ResetFile(this AzureKeyvaultSecretSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.File = null;
            return toolSettings;
        }
        #endregion
        #region Value
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretSetSettings.Value"/>.</em></p><p>Plain text secret value. Cannot be used with '--file' or '--encoding'.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretSetSettings SetValue(this AzureKeyvaultSecretSetSettings toolSettings, string value)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Value = value;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretSetSettings.Value"/>.</em></p><p>Plain text secret value. Cannot be used with '--file' or '--encoding'.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretSetSettings ResetValue(this AzureKeyvaultSecretSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Value = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretSetSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretSetSettings SetDebug(this AzureKeyvaultSecretSetSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretSetSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretSetSettings ResetDebug(this AzureKeyvaultSecretSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretSetSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretSetSettings SetHelp(this AzureKeyvaultSecretSetSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretSetSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretSetSettings ResetHelp(this AzureKeyvaultSecretSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretSetSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretSetSettings SetOutput(this AzureKeyvaultSecretSetSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretSetSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretSetSettings ResetOutput(this AzureKeyvaultSecretSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretSetSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretSetSettings SetQuery(this AzureKeyvaultSecretSetSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretSetSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretSetSettings ResetQuery(this AzureKeyvaultSecretSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretSetSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretSetSettings SetVerbose(this AzureKeyvaultSecretSetSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretSetSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretSetSettings ResetVerbose(this AzureKeyvaultSecretSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureKeyvaultSecretSetAttributesSettingsExtensions
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureKeyvaultSecretSetAttributesSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretSetAttributesSettings.Name"/>.</em></p><p>Name of the secret.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretSetAttributesSettings SetName(this AzureKeyvaultSecretSetAttributesSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretSetAttributesSettings.Name"/>.</em></p><p>Name of the secret.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretSetAttributesSettings ResetName(this AzureKeyvaultSecretSetAttributesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region VaultName
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretSetAttributesSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretSetAttributesSettings SetVaultName(this AzureKeyvaultSecretSetAttributesSettings toolSettings, string vaultName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = vaultName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretSetAttributesSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretSetAttributesSettings ResetVaultName(this AzureKeyvaultSecretSetAttributesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = null;
            return toolSettings;
        }
        #endregion
        #region ContentType
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretSetAttributesSettings.ContentType"/>.</em></p><p>Type of the secret value such as a password.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretSetAttributesSettings SetContentType(this AzureKeyvaultSecretSetAttributesSettings toolSettings, string contentType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ContentType = contentType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretSetAttributesSettings.ContentType"/>.</em></p><p>Type of the secret value such as a password.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretSetAttributesSettings ResetContentType(this AzureKeyvaultSecretSetAttributesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ContentType = null;
            return toolSettings;
        }
        #endregion
        #region Enabled
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretSetAttributesSettings.Enabled"/>.</em></p><p>Enable the secret.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretSetAttributesSettings SetEnabled(this AzureKeyvaultSecretSetAttributesSettings toolSettings, bool? enabled)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Enabled = enabled;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretSetAttributesSettings.Enabled"/>.</em></p><p>Enable the secret.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretSetAttributesSettings ResetEnabled(this AzureKeyvaultSecretSetAttributesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Enabled = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureKeyvaultSecretSetAttributesSettings.Enabled"/>.</em></p><p>Enable the secret.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretSetAttributesSettings EnableEnabled(this AzureKeyvaultSecretSetAttributesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Enabled = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureKeyvaultSecretSetAttributesSettings.Enabled"/>.</em></p><p>Enable the secret.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretSetAttributesSettings DisableEnabled(this AzureKeyvaultSecretSetAttributesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Enabled = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureKeyvaultSecretSetAttributesSettings.Enabled"/>.</em></p><p>Enable the secret.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretSetAttributesSettings ToggleEnabled(this AzureKeyvaultSecretSetAttributesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Enabled = !toolSettings.Enabled;
            return toolSettings;
        }
        #endregion
        #region Expires
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretSetAttributesSettings.Expires"/>.</em></p><p>Expiration UTC datetime  (Y-m-d'T'H:M:S'Z').</p></summary>
        [Pure]
        public static AzureKeyvaultSecretSetAttributesSettings SetExpires(this AzureKeyvaultSecretSetAttributesSettings toolSettings, string expires)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expires = expires;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretSetAttributesSettings.Expires"/>.</em></p><p>Expiration UTC datetime  (Y-m-d'T'H:M:S'Z').</p></summary>
        [Pure]
        public static AzureKeyvaultSecretSetAttributesSettings ResetExpires(this AzureKeyvaultSecretSetAttributesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expires = null;
            return toolSettings;
        }
        #endregion
        #region NotBefore
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretSetAttributesSettings.NotBefore"/>.</em></p><p>Key not usable before the provided UTC datetime  (Y-m-d'T'H:M:S'Z').</p></summary>
        [Pure]
        public static AzureKeyvaultSecretSetAttributesSettings SetNotBefore(this AzureKeyvaultSecretSetAttributesSettings toolSettings, string notBefore)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NotBefore = notBefore;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretSetAttributesSettings.NotBefore"/>.</em></p><p>Key not usable before the provided UTC datetime  (Y-m-d'T'H:M:S'Z').</p></summary>
        [Pure]
        public static AzureKeyvaultSecretSetAttributesSettings ResetNotBefore(this AzureKeyvaultSecretSetAttributesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NotBefore = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretSetAttributesSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretSetAttributesSettings SetTags(this AzureKeyvaultSecretSetAttributesSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretSetAttributesSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretSetAttributesSettings ResetTags(this AzureKeyvaultSecretSetAttributesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Version
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretSetAttributesSettings.Version"/>.</em></p><p>The secret version. If omitted, uses the latest version.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretSetAttributesSettings SetVersion(this AzureKeyvaultSecretSetAttributesSettings toolSettings, string version)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = version;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretSetAttributesSettings.Version"/>.</em></p><p>The secret version. If omitted, uses the latest version.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretSetAttributesSettings ResetVersion(this AzureKeyvaultSecretSetAttributesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretSetAttributesSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretSetAttributesSettings SetDebug(this AzureKeyvaultSecretSetAttributesSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretSetAttributesSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretSetAttributesSettings ResetDebug(this AzureKeyvaultSecretSetAttributesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretSetAttributesSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretSetAttributesSettings SetHelp(this AzureKeyvaultSecretSetAttributesSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretSetAttributesSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretSetAttributesSettings ResetHelp(this AzureKeyvaultSecretSetAttributesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretSetAttributesSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretSetAttributesSettings SetOutput(this AzureKeyvaultSecretSetAttributesSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretSetAttributesSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretSetAttributesSettings ResetOutput(this AzureKeyvaultSecretSetAttributesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretSetAttributesSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretSetAttributesSettings SetQuery(this AzureKeyvaultSecretSetAttributesSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretSetAttributesSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretSetAttributesSettings ResetQuery(this AzureKeyvaultSecretSetAttributesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretSetAttributesSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretSetAttributesSettings SetVerbose(this AzureKeyvaultSecretSetAttributesSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretSetAttributesSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretSetAttributesSettings ResetVerbose(this AzureKeyvaultSecretSetAttributesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureKeyvaultSecretShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureKeyvaultSecretShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretShowSettings.Name"/>.</em></p><p>Name of the secret.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretShowSettings SetName(this AzureKeyvaultSecretShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretShowSettings.Name"/>.</em></p><p>Name of the secret.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretShowSettings ResetName(this AzureKeyvaultSecretShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region VaultName
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretShowSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretShowSettings SetVaultName(this AzureKeyvaultSecretShowSettings toolSettings, string vaultName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = vaultName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretShowSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretShowSettings ResetVaultName(this AzureKeyvaultSecretShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = null;
            return toolSettings;
        }
        #endregion
        #region Version
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretShowSettings.Version"/>.</em></p><p>The secret version. If omitted, uses the latest version.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretShowSettings SetVersion(this AzureKeyvaultSecretShowSettings toolSettings, string version)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = version;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretShowSettings.Version"/>.</em></p><p>The secret version. If omitted, uses the latest version.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretShowSettings ResetVersion(this AzureKeyvaultSecretShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretShowSettings SetDebug(this AzureKeyvaultSecretShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretShowSettings ResetDebug(this AzureKeyvaultSecretShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretShowSettings SetHelp(this AzureKeyvaultSecretShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretShowSettings ResetHelp(this AzureKeyvaultSecretShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretShowSettings SetOutput(this AzureKeyvaultSecretShowSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretShowSettings ResetOutput(this AzureKeyvaultSecretShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretShowSettings SetQuery(this AzureKeyvaultSecretShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretShowSettings ResetQuery(this AzureKeyvaultSecretShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretShowSettings SetVerbose(this AzureKeyvaultSecretShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretShowSettings ResetVerbose(this AzureKeyvaultSecretShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureKeyvaultSecretShowDeletedSettingsExtensions
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureKeyvaultSecretShowDeletedSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretShowDeletedSettings.Name"/>.</em></p><p>Name of the secret.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretShowDeletedSettings SetName(this AzureKeyvaultSecretShowDeletedSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretShowDeletedSettings.Name"/>.</em></p><p>Name of the secret.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretShowDeletedSettings ResetName(this AzureKeyvaultSecretShowDeletedSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region VaultName
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretShowDeletedSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretShowDeletedSettings SetVaultName(this AzureKeyvaultSecretShowDeletedSettings toolSettings, string vaultName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = vaultName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretShowDeletedSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretShowDeletedSettings ResetVaultName(this AzureKeyvaultSecretShowDeletedSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretShowDeletedSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretShowDeletedSettings SetDebug(this AzureKeyvaultSecretShowDeletedSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretShowDeletedSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretShowDeletedSettings ResetDebug(this AzureKeyvaultSecretShowDeletedSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretShowDeletedSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretShowDeletedSettings SetHelp(this AzureKeyvaultSecretShowDeletedSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretShowDeletedSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretShowDeletedSettings ResetHelp(this AzureKeyvaultSecretShowDeletedSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretShowDeletedSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretShowDeletedSettings SetOutput(this AzureKeyvaultSecretShowDeletedSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretShowDeletedSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretShowDeletedSettings ResetOutput(this AzureKeyvaultSecretShowDeletedSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretShowDeletedSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretShowDeletedSettings SetQuery(this AzureKeyvaultSecretShowDeletedSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretShowDeletedSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretShowDeletedSettings ResetQuery(this AzureKeyvaultSecretShowDeletedSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureKeyvaultSecretShowDeletedSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretShowDeletedSettings SetVerbose(this AzureKeyvaultSecretShowDeletedSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultSecretShowDeletedSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultSecretShowDeletedSettings ResetVerbose(this AzureKeyvaultSecretShowDeletedSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureKeyvaultCertificateContactAddSettingsExtensions
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureKeyvaultCertificateContactAddSettingsExtensions
    {
        #region Email
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateContactAddSettings.Email"/>.</em></p><p>Contact e-mail address. Must be unique.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateContactAddSettings SetEmail(this AzureKeyvaultCertificateContactAddSettings toolSettings, string email)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Email = email;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateContactAddSettings.Email"/>.</em></p><p>Contact e-mail address. Must be unique.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateContactAddSettings ResetEmail(this AzureKeyvaultCertificateContactAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Email = null;
            return toolSettings;
        }
        #endregion
        #region VaultName
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateContactAddSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateContactAddSettings SetVaultName(this AzureKeyvaultCertificateContactAddSettings toolSettings, string vaultName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = vaultName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateContactAddSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateContactAddSettings ResetVaultName(this AzureKeyvaultCertificateContactAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateContactAddSettings.Name"/>.</em></p><p>Full contact name.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateContactAddSettings SetName(this AzureKeyvaultCertificateContactAddSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateContactAddSettings.Name"/>.</em></p><p>Full contact name.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateContactAddSettings ResetName(this AzureKeyvaultCertificateContactAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Phone
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateContactAddSettings.Phone"/>.</em></p><p>Contact phone number.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateContactAddSettings SetPhone(this AzureKeyvaultCertificateContactAddSettings toolSettings, string phone)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Phone = phone;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateContactAddSettings.Phone"/>.</em></p><p>Contact phone number.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateContactAddSettings ResetPhone(this AzureKeyvaultCertificateContactAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Phone = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateContactAddSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateContactAddSettings SetDebug(this AzureKeyvaultCertificateContactAddSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateContactAddSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateContactAddSettings ResetDebug(this AzureKeyvaultCertificateContactAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateContactAddSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateContactAddSettings SetHelp(this AzureKeyvaultCertificateContactAddSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateContactAddSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateContactAddSettings ResetHelp(this AzureKeyvaultCertificateContactAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateContactAddSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateContactAddSettings SetOutput(this AzureKeyvaultCertificateContactAddSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateContactAddSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateContactAddSettings ResetOutput(this AzureKeyvaultCertificateContactAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateContactAddSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateContactAddSettings SetQuery(this AzureKeyvaultCertificateContactAddSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateContactAddSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateContactAddSettings ResetQuery(this AzureKeyvaultCertificateContactAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateContactAddSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateContactAddSettings SetVerbose(this AzureKeyvaultCertificateContactAddSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateContactAddSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateContactAddSettings ResetVerbose(this AzureKeyvaultCertificateContactAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureKeyvaultCertificateContactDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureKeyvaultCertificateContactDeleteSettingsExtensions
    {
        #region Email
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateContactDeleteSettings.Email"/>.</em></p><p>Contact e-mail address. Must be unique.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateContactDeleteSettings SetEmail(this AzureKeyvaultCertificateContactDeleteSettings toolSettings, string email)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Email = email;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateContactDeleteSettings.Email"/>.</em></p><p>Contact e-mail address. Must be unique.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateContactDeleteSettings ResetEmail(this AzureKeyvaultCertificateContactDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Email = null;
            return toolSettings;
        }
        #endregion
        #region VaultName
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateContactDeleteSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateContactDeleteSettings SetVaultName(this AzureKeyvaultCertificateContactDeleteSettings toolSettings, string vaultName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = vaultName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateContactDeleteSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateContactDeleteSettings ResetVaultName(this AzureKeyvaultCertificateContactDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateContactDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateContactDeleteSettings SetDebug(this AzureKeyvaultCertificateContactDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateContactDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateContactDeleteSettings ResetDebug(this AzureKeyvaultCertificateContactDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateContactDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateContactDeleteSettings SetHelp(this AzureKeyvaultCertificateContactDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateContactDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateContactDeleteSettings ResetHelp(this AzureKeyvaultCertificateContactDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateContactDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateContactDeleteSettings SetOutput(this AzureKeyvaultCertificateContactDeleteSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateContactDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateContactDeleteSettings ResetOutput(this AzureKeyvaultCertificateContactDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateContactDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateContactDeleteSettings SetQuery(this AzureKeyvaultCertificateContactDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateContactDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateContactDeleteSettings ResetQuery(this AzureKeyvaultCertificateContactDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateContactDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateContactDeleteSettings SetVerbose(this AzureKeyvaultCertificateContactDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateContactDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateContactDeleteSettings ResetVerbose(this AzureKeyvaultCertificateContactDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureKeyvaultCertificateContactListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureKeyvaultCertificateContactListSettingsExtensions
    {
        #region VaultName
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateContactListSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateContactListSettings SetVaultName(this AzureKeyvaultCertificateContactListSettings toolSettings, string vaultName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = vaultName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateContactListSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateContactListSettings ResetVaultName(this AzureKeyvaultCertificateContactListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateContactListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateContactListSettings SetDebug(this AzureKeyvaultCertificateContactListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateContactListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateContactListSettings ResetDebug(this AzureKeyvaultCertificateContactListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateContactListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateContactListSettings SetHelp(this AzureKeyvaultCertificateContactListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateContactListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateContactListSettings ResetHelp(this AzureKeyvaultCertificateContactListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateContactListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateContactListSettings SetOutput(this AzureKeyvaultCertificateContactListSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateContactListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateContactListSettings ResetOutput(this AzureKeyvaultCertificateContactListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateContactListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateContactListSettings SetQuery(this AzureKeyvaultCertificateContactListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateContactListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateContactListSettings ResetQuery(this AzureKeyvaultCertificateContactListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateContactListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateContactListSettings SetVerbose(this AzureKeyvaultCertificateContactListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateContactListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateContactListSettings ResetVerbose(this AzureKeyvaultCertificateContactListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureKeyvaultCertificateIssuerCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureKeyvaultCertificateIssuerCreateSettingsExtensions
    {
        #region IssuerName
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateIssuerCreateSettings.IssuerName"/>.</em></p><p>Certificate issuer name.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerCreateSettings SetIssuerName(this AzureKeyvaultCertificateIssuerCreateSettings toolSettings, string issuerName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IssuerName = issuerName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateIssuerCreateSettings.IssuerName"/>.</em></p><p>Certificate issuer name.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerCreateSettings ResetIssuerName(this AzureKeyvaultCertificateIssuerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IssuerName = null;
            return toolSettings;
        }
        #endregion
        #region ProviderName
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateIssuerCreateSettings.ProviderName"/>.</em></p><p>The certificate provider name. Must be registered with your tenant ID and in your region.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerCreateSettings SetProviderName(this AzureKeyvaultCertificateIssuerCreateSettings toolSettings, string providerName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProviderName = providerName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateIssuerCreateSettings.ProviderName"/>.</em></p><p>The certificate provider name. Must be registered with your tenant ID and in your region.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerCreateSettings ResetProviderName(this AzureKeyvaultCertificateIssuerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProviderName = null;
            return toolSettings;
        }
        #endregion
        #region VaultName
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateIssuerCreateSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerCreateSettings SetVaultName(this AzureKeyvaultCertificateIssuerCreateSettings toolSettings, string vaultName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = vaultName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateIssuerCreateSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerCreateSettings ResetVaultName(this AzureKeyvaultCertificateIssuerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = null;
            return toolSettings;
        }
        #endregion
        #region Disabled
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateIssuerCreateSettings.Disabled"/>.</em></p><p>Set issuer to disabled state.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerCreateSettings SetDisabled(this AzureKeyvaultCertificateIssuerCreateSettings toolSettings, bool? disabled)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Disabled = disabled;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateIssuerCreateSettings.Disabled"/>.</em></p><p>Set issuer to disabled state.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerCreateSettings ResetDisabled(this AzureKeyvaultCertificateIssuerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Disabled = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureKeyvaultCertificateIssuerCreateSettings.Disabled"/>.</em></p><p>Set issuer to disabled state.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerCreateSettings EnableDisabled(this AzureKeyvaultCertificateIssuerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Disabled = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureKeyvaultCertificateIssuerCreateSettings.Disabled"/>.</em></p><p>Set issuer to disabled state.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerCreateSettings DisableDisabled(this AzureKeyvaultCertificateIssuerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Disabled = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureKeyvaultCertificateIssuerCreateSettings.Disabled"/>.</em></p><p>Set issuer to disabled state.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerCreateSettings ToggleDisabled(this AzureKeyvaultCertificateIssuerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Disabled = !toolSettings.Disabled;
            return toolSettings;
        }
        #endregion
        #region AccountId
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateIssuerCreateSettings.AccountId"/>.</em></p><p>The issuer account id/username/etc.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerCreateSettings SetAccountId(this AzureKeyvaultCertificateIssuerCreateSettings toolSettings, string accountId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountId = accountId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateIssuerCreateSettings.AccountId"/>.</em></p><p>The issuer account id/username/etc.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerCreateSettings ResetAccountId(this AzureKeyvaultCertificateIssuerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountId = null;
            return toolSettings;
        }
        #endregion
        #region Password
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateIssuerCreateSettings.Password"/>.</em></p><p>The issuer account password/secret/etc.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerCreateSettings SetPassword(this AzureKeyvaultCertificateIssuerCreateSettings toolSettings, string password)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = password;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateIssuerCreateSettings.Password"/>.</em></p><p>The issuer account password/secret/etc.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerCreateSettings ResetPassword(this AzureKeyvaultCertificateIssuerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = null;
            return toolSettings;
        }
        #endregion
        #region OrganizationId
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateIssuerCreateSettings.OrganizationId"/>.</em></p><p>The organization id.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerCreateSettings SetOrganizationId(this AzureKeyvaultCertificateIssuerCreateSettings toolSettings, string organizationId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OrganizationId = organizationId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateIssuerCreateSettings.OrganizationId"/>.</em></p><p>The organization id.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerCreateSettings ResetOrganizationId(this AzureKeyvaultCertificateIssuerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OrganizationId = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateIssuerCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerCreateSettings SetDebug(this AzureKeyvaultCertificateIssuerCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateIssuerCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerCreateSettings ResetDebug(this AzureKeyvaultCertificateIssuerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateIssuerCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerCreateSettings SetHelp(this AzureKeyvaultCertificateIssuerCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateIssuerCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerCreateSettings ResetHelp(this AzureKeyvaultCertificateIssuerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateIssuerCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerCreateSettings SetOutput(this AzureKeyvaultCertificateIssuerCreateSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateIssuerCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerCreateSettings ResetOutput(this AzureKeyvaultCertificateIssuerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateIssuerCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerCreateSettings SetQuery(this AzureKeyvaultCertificateIssuerCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateIssuerCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerCreateSettings ResetQuery(this AzureKeyvaultCertificateIssuerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateIssuerCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerCreateSettings SetVerbose(this AzureKeyvaultCertificateIssuerCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateIssuerCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerCreateSettings ResetVerbose(this AzureKeyvaultCertificateIssuerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureKeyvaultCertificateIssuerDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureKeyvaultCertificateIssuerDeleteSettingsExtensions
    {
        #region IssuerName
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateIssuerDeleteSettings.IssuerName"/>.</em></p><p>Certificate issuer name.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerDeleteSettings SetIssuerName(this AzureKeyvaultCertificateIssuerDeleteSettings toolSettings, string issuerName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IssuerName = issuerName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateIssuerDeleteSettings.IssuerName"/>.</em></p><p>Certificate issuer name.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerDeleteSettings ResetIssuerName(this AzureKeyvaultCertificateIssuerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IssuerName = null;
            return toolSettings;
        }
        #endregion
        #region VaultName
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateIssuerDeleteSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerDeleteSettings SetVaultName(this AzureKeyvaultCertificateIssuerDeleteSettings toolSettings, string vaultName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = vaultName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateIssuerDeleteSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerDeleteSettings ResetVaultName(this AzureKeyvaultCertificateIssuerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateIssuerDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerDeleteSettings SetDebug(this AzureKeyvaultCertificateIssuerDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateIssuerDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerDeleteSettings ResetDebug(this AzureKeyvaultCertificateIssuerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateIssuerDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerDeleteSettings SetHelp(this AzureKeyvaultCertificateIssuerDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateIssuerDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerDeleteSettings ResetHelp(this AzureKeyvaultCertificateIssuerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateIssuerDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerDeleteSettings SetOutput(this AzureKeyvaultCertificateIssuerDeleteSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateIssuerDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerDeleteSettings ResetOutput(this AzureKeyvaultCertificateIssuerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateIssuerDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerDeleteSettings SetQuery(this AzureKeyvaultCertificateIssuerDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateIssuerDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerDeleteSettings ResetQuery(this AzureKeyvaultCertificateIssuerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateIssuerDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerDeleteSettings SetVerbose(this AzureKeyvaultCertificateIssuerDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateIssuerDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerDeleteSettings ResetVerbose(this AzureKeyvaultCertificateIssuerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureKeyvaultCertificateIssuerListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureKeyvaultCertificateIssuerListSettingsExtensions
    {
        #region VaultName
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateIssuerListSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerListSettings SetVaultName(this AzureKeyvaultCertificateIssuerListSettings toolSettings, string vaultName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = vaultName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateIssuerListSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerListSettings ResetVaultName(this AzureKeyvaultCertificateIssuerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = null;
            return toolSettings;
        }
        #endregion
        #region Maxresults
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateIssuerListSettings.Maxresults"/>.</em></p><p>Maximum number of results to return in a page. If not specified the service will return up to 25 results.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerListSettings SetMaxresults(this AzureKeyvaultCertificateIssuerListSettings toolSettings, string maxresults)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Maxresults = maxresults;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateIssuerListSettings.Maxresults"/>.</em></p><p>Maximum number of results to return in a page. If not specified the service will return up to 25 results.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerListSettings ResetMaxresults(this AzureKeyvaultCertificateIssuerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Maxresults = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateIssuerListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerListSettings SetDebug(this AzureKeyvaultCertificateIssuerListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateIssuerListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerListSettings ResetDebug(this AzureKeyvaultCertificateIssuerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateIssuerListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerListSettings SetHelp(this AzureKeyvaultCertificateIssuerListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateIssuerListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerListSettings ResetHelp(this AzureKeyvaultCertificateIssuerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateIssuerListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerListSettings SetOutput(this AzureKeyvaultCertificateIssuerListSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateIssuerListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerListSettings ResetOutput(this AzureKeyvaultCertificateIssuerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateIssuerListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerListSettings SetQuery(this AzureKeyvaultCertificateIssuerListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateIssuerListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerListSettings ResetQuery(this AzureKeyvaultCertificateIssuerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateIssuerListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerListSettings SetVerbose(this AzureKeyvaultCertificateIssuerListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateIssuerListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerListSettings ResetVerbose(this AzureKeyvaultCertificateIssuerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureKeyvaultCertificateIssuerShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureKeyvaultCertificateIssuerShowSettingsExtensions
    {
        #region IssuerName
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateIssuerShowSettings.IssuerName"/>.</em></p><p>Certificate issuer name.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerShowSettings SetIssuerName(this AzureKeyvaultCertificateIssuerShowSettings toolSettings, string issuerName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IssuerName = issuerName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateIssuerShowSettings.IssuerName"/>.</em></p><p>Certificate issuer name.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerShowSettings ResetIssuerName(this AzureKeyvaultCertificateIssuerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IssuerName = null;
            return toolSettings;
        }
        #endregion
        #region VaultName
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateIssuerShowSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerShowSettings SetVaultName(this AzureKeyvaultCertificateIssuerShowSettings toolSettings, string vaultName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = vaultName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateIssuerShowSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerShowSettings ResetVaultName(this AzureKeyvaultCertificateIssuerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateIssuerShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerShowSettings SetDebug(this AzureKeyvaultCertificateIssuerShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateIssuerShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerShowSettings ResetDebug(this AzureKeyvaultCertificateIssuerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateIssuerShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerShowSettings SetHelp(this AzureKeyvaultCertificateIssuerShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateIssuerShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerShowSettings ResetHelp(this AzureKeyvaultCertificateIssuerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateIssuerShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerShowSettings SetOutput(this AzureKeyvaultCertificateIssuerShowSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateIssuerShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerShowSettings ResetOutput(this AzureKeyvaultCertificateIssuerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateIssuerShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerShowSettings SetQuery(this AzureKeyvaultCertificateIssuerShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateIssuerShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerShowSettings ResetQuery(this AzureKeyvaultCertificateIssuerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateIssuerShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerShowSettings SetVerbose(this AzureKeyvaultCertificateIssuerShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateIssuerShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerShowSettings ResetVerbose(this AzureKeyvaultCertificateIssuerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureKeyvaultCertificateIssuerUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureKeyvaultCertificateIssuerUpdateSettingsExtensions
    {
        #region IssuerName
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateIssuerUpdateSettings.IssuerName"/>.</em></p><p>Certificate issuer name.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerUpdateSettings SetIssuerName(this AzureKeyvaultCertificateIssuerUpdateSettings toolSettings, string issuerName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IssuerName = issuerName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateIssuerUpdateSettings.IssuerName"/>.</em></p><p>Certificate issuer name.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerUpdateSettings ResetIssuerName(this AzureKeyvaultCertificateIssuerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IssuerName = null;
            return toolSettings;
        }
        #endregion
        #region VaultName
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateIssuerUpdateSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerUpdateSettings SetVaultName(this AzureKeyvaultCertificateIssuerUpdateSettings toolSettings, string vaultName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = vaultName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateIssuerUpdateSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerUpdateSettings ResetVaultName(this AzureKeyvaultCertificateIssuerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = null;
            return toolSettings;
        }
        #endregion
        #region Enabled
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateIssuerUpdateSettings.Enabled"/>.</em></p><p>Set issuer enabled state.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerUpdateSettings SetEnabled(this AzureKeyvaultCertificateIssuerUpdateSettings toolSettings, bool? enabled)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Enabled = enabled;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateIssuerUpdateSettings.Enabled"/>.</em></p><p>Set issuer enabled state.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerUpdateSettings ResetEnabled(this AzureKeyvaultCertificateIssuerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Enabled = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureKeyvaultCertificateIssuerUpdateSettings.Enabled"/>.</em></p><p>Set issuer enabled state.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerUpdateSettings EnableEnabled(this AzureKeyvaultCertificateIssuerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Enabled = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureKeyvaultCertificateIssuerUpdateSettings.Enabled"/>.</em></p><p>Set issuer enabled state.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerUpdateSettings DisableEnabled(this AzureKeyvaultCertificateIssuerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Enabled = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureKeyvaultCertificateIssuerUpdateSettings.Enabled"/>.</em></p><p>Set issuer enabled state.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerUpdateSettings ToggleEnabled(this AzureKeyvaultCertificateIssuerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Enabled = !toolSettings.Enabled;
            return toolSettings;
        }
        #endregion
        #region ProviderName
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateIssuerUpdateSettings.ProviderName"/>.</em></p><p>The certificate provider name. Must be registered with your tenant ID and in your region.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerUpdateSettings SetProviderName(this AzureKeyvaultCertificateIssuerUpdateSettings toolSettings, string providerName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProviderName = providerName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateIssuerUpdateSettings.ProviderName"/>.</em></p><p>The certificate provider name. Must be registered with your tenant ID and in your region.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerUpdateSettings ResetProviderName(this AzureKeyvaultCertificateIssuerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProviderName = null;
            return toolSettings;
        }
        #endregion
        #region AccountId
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateIssuerUpdateSettings.AccountId"/>.</em></p><p>The issuer account id/username/etc.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerUpdateSettings SetAccountId(this AzureKeyvaultCertificateIssuerUpdateSettings toolSettings, string accountId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountId = accountId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateIssuerUpdateSettings.AccountId"/>.</em></p><p>The issuer account id/username/etc.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerUpdateSettings ResetAccountId(this AzureKeyvaultCertificateIssuerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountId = null;
            return toolSettings;
        }
        #endregion
        #region Password
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateIssuerUpdateSettings.Password"/>.</em></p><p>The issuer account password/secret/etc.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerUpdateSettings SetPassword(this AzureKeyvaultCertificateIssuerUpdateSettings toolSettings, string password)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = password;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateIssuerUpdateSettings.Password"/>.</em></p><p>The issuer account password/secret/etc.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerUpdateSettings ResetPassword(this AzureKeyvaultCertificateIssuerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = null;
            return toolSettings;
        }
        #endregion
        #region OrganizationId
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateIssuerUpdateSettings.OrganizationId"/>.</em></p><p>The organization id.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerUpdateSettings SetOrganizationId(this AzureKeyvaultCertificateIssuerUpdateSettings toolSettings, string organizationId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OrganizationId = organizationId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateIssuerUpdateSettings.OrganizationId"/>.</em></p><p>The organization id.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerUpdateSettings ResetOrganizationId(this AzureKeyvaultCertificateIssuerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OrganizationId = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateIssuerUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerUpdateSettings SetDebug(this AzureKeyvaultCertificateIssuerUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateIssuerUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerUpdateSettings ResetDebug(this AzureKeyvaultCertificateIssuerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateIssuerUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerUpdateSettings SetHelp(this AzureKeyvaultCertificateIssuerUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateIssuerUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerUpdateSettings ResetHelp(this AzureKeyvaultCertificateIssuerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateIssuerUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerUpdateSettings SetOutput(this AzureKeyvaultCertificateIssuerUpdateSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateIssuerUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerUpdateSettings ResetOutput(this AzureKeyvaultCertificateIssuerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateIssuerUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerUpdateSettings SetQuery(this AzureKeyvaultCertificateIssuerUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateIssuerUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerUpdateSettings ResetQuery(this AzureKeyvaultCertificateIssuerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateIssuerUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerUpdateSettings SetVerbose(this AzureKeyvaultCertificateIssuerUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateIssuerUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerUpdateSettings ResetVerbose(this AzureKeyvaultCertificateIssuerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureKeyvaultCertificatePendingDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureKeyvaultCertificatePendingDeleteSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificatePendingDeleteSettings.Name"/>.</em></p><p>Name of the pending certificate.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificatePendingDeleteSettings SetName(this AzureKeyvaultCertificatePendingDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificatePendingDeleteSettings.Name"/>.</em></p><p>Name of the pending certificate.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificatePendingDeleteSettings ResetName(this AzureKeyvaultCertificatePendingDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region VaultName
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificatePendingDeleteSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificatePendingDeleteSettings SetVaultName(this AzureKeyvaultCertificatePendingDeleteSettings toolSettings, string vaultName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = vaultName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificatePendingDeleteSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificatePendingDeleteSettings ResetVaultName(this AzureKeyvaultCertificatePendingDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificatePendingDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificatePendingDeleteSettings SetDebug(this AzureKeyvaultCertificatePendingDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificatePendingDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificatePendingDeleteSettings ResetDebug(this AzureKeyvaultCertificatePendingDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificatePendingDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificatePendingDeleteSettings SetHelp(this AzureKeyvaultCertificatePendingDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificatePendingDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificatePendingDeleteSettings ResetHelp(this AzureKeyvaultCertificatePendingDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificatePendingDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificatePendingDeleteSettings SetOutput(this AzureKeyvaultCertificatePendingDeleteSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificatePendingDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificatePendingDeleteSettings ResetOutput(this AzureKeyvaultCertificatePendingDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificatePendingDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificatePendingDeleteSettings SetQuery(this AzureKeyvaultCertificatePendingDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificatePendingDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificatePendingDeleteSettings ResetQuery(this AzureKeyvaultCertificatePendingDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificatePendingDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificatePendingDeleteSettings SetVerbose(this AzureKeyvaultCertificatePendingDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificatePendingDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificatePendingDeleteSettings ResetVerbose(this AzureKeyvaultCertificatePendingDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureKeyvaultCertificatePendingMergeSettingsExtensions
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureKeyvaultCertificatePendingMergeSettingsExtensions
    {
        #region File
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificatePendingMergeSettings.File"/>.</em></p><p>File containing the certificate or certificate chain to merge.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificatePendingMergeSettings SetFile(this AzureKeyvaultCertificatePendingMergeSettings toolSettings, string file)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.File = file;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificatePendingMergeSettings.File"/>.</em></p><p>File containing the certificate or certificate chain to merge.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificatePendingMergeSettings ResetFile(this AzureKeyvaultCertificatePendingMergeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.File = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificatePendingMergeSettings.Name"/>.</em></p><p>Name of the pending certificate.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificatePendingMergeSettings SetName(this AzureKeyvaultCertificatePendingMergeSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificatePendingMergeSettings.Name"/>.</em></p><p>Name of the pending certificate.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificatePendingMergeSettings ResetName(this AzureKeyvaultCertificatePendingMergeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region VaultName
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificatePendingMergeSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificatePendingMergeSettings SetVaultName(this AzureKeyvaultCertificatePendingMergeSettings toolSettings, string vaultName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = vaultName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificatePendingMergeSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificatePendingMergeSettings ResetVaultName(this AzureKeyvaultCertificatePendingMergeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = null;
            return toolSettings;
        }
        #endregion
        #region Disabled
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificatePendingMergeSettings.Disabled"/>.</em></p><p>Create certificate in disabled state.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificatePendingMergeSettings SetDisabled(this AzureKeyvaultCertificatePendingMergeSettings toolSettings, bool? disabled)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Disabled = disabled;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificatePendingMergeSettings.Disabled"/>.</em></p><p>Create certificate in disabled state.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificatePendingMergeSettings ResetDisabled(this AzureKeyvaultCertificatePendingMergeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Disabled = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureKeyvaultCertificatePendingMergeSettings.Disabled"/>.</em></p><p>Create certificate in disabled state.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificatePendingMergeSettings EnableDisabled(this AzureKeyvaultCertificatePendingMergeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Disabled = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureKeyvaultCertificatePendingMergeSettings.Disabled"/>.</em></p><p>Create certificate in disabled state.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificatePendingMergeSettings DisableDisabled(this AzureKeyvaultCertificatePendingMergeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Disabled = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureKeyvaultCertificatePendingMergeSettings.Disabled"/>.</em></p><p>Create certificate in disabled state.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificatePendingMergeSettings ToggleDisabled(this AzureKeyvaultCertificatePendingMergeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Disabled = !toolSettings.Disabled;
            return toolSettings;
        }
        #endregion
        #region Expires
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificatePendingMergeSettings.Expires"/>.</em></p><p>Expiration UTC datetime  (Y-m-d'T'H:M:S'Z').</p></summary>
        [Pure]
        public static AzureKeyvaultCertificatePendingMergeSettings SetExpires(this AzureKeyvaultCertificatePendingMergeSettings toolSettings, string expires)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expires = expires;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificatePendingMergeSettings.Expires"/>.</em></p><p>Expiration UTC datetime  (Y-m-d'T'H:M:S'Z').</p></summary>
        [Pure]
        public static AzureKeyvaultCertificatePendingMergeSettings ResetExpires(this AzureKeyvaultCertificatePendingMergeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expires = null;
            return toolSettings;
        }
        #endregion
        #region NotBefore
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificatePendingMergeSettings.NotBefore"/>.</em></p><p>Key not usable before the provided UTC datetime  (Y-m-d'T'H:M:S'Z').</p></summary>
        [Pure]
        public static AzureKeyvaultCertificatePendingMergeSettings SetNotBefore(this AzureKeyvaultCertificatePendingMergeSettings toolSettings, string notBefore)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NotBefore = notBefore;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificatePendingMergeSettings.NotBefore"/>.</em></p><p>Key not usable before the provided UTC datetime  (Y-m-d'T'H:M:S'Z').</p></summary>
        [Pure]
        public static AzureKeyvaultCertificatePendingMergeSettings ResetNotBefore(this AzureKeyvaultCertificatePendingMergeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NotBefore = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificatePendingMergeSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificatePendingMergeSettings SetTags(this AzureKeyvaultCertificatePendingMergeSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificatePendingMergeSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificatePendingMergeSettings ResetTags(this AzureKeyvaultCertificatePendingMergeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificatePendingMergeSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificatePendingMergeSettings SetDebug(this AzureKeyvaultCertificatePendingMergeSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificatePendingMergeSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificatePendingMergeSettings ResetDebug(this AzureKeyvaultCertificatePendingMergeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificatePendingMergeSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificatePendingMergeSettings SetHelp(this AzureKeyvaultCertificatePendingMergeSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificatePendingMergeSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificatePendingMergeSettings ResetHelp(this AzureKeyvaultCertificatePendingMergeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificatePendingMergeSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificatePendingMergeSettings SetOutput(this AzureKeyvaultCertificatePendingMergeSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificatePendingMergeSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificatePendingMergeSettings ResetOutput(this AzureKeyvaultCertificatePendingMergeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificatePendingMergeSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificatePendingMergeSettings SetQuery(this AzureKeyvaultCertificatePendingMergeSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificatePendingMergeSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificatePendingMergeSettings ResetQuery(this AzureKeyvaultCertificatePendingMergeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificatePendingMergeSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificatePendingMergeSettings SetVerbose(this AzureKeyvaultCertificatePendingMergeSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificatePendingMergeSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificatePendingMergeSettings ResetVerbose(this AzureKeyvaultCertificatePendingMergeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureKeyvaultCertificatePendingShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureKeyvaultCertificatePendingShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificatePendingShowSettings.Name"/>.</em></p><p>Name of the pending certificate.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificatePendingShowSettings SetName(this AzureKeyvaultCertificatePendingShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificatePendingShowSettings.Name"/>.</em></p><p>Name of the pending certificate.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificatePendingShowSettings ResetName(this AzureKeyvaultCertificatePendingShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region VaultName
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificatePendingShowSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificatePendingShowSettings SetVaultName(this AzureKeyvaultCertificatePendingShowSettings toolSettings, string vaultName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = vaultName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificatePendingShowSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificatePendingShowSettings ResetVaultName(this AzureKeyvaultCertificatePendingShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificatePendingShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificatePendingShowSettings SetDebug(this AzureKeyvaultCertificatePendingShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificatePendingShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificatePendingShowSettings ResetDebug(this AzureKeyvaultCertificatePendingShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificatePendingShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificatePendingShowSettings SetHelp(this AzureKeyvaultCertificatePendingShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificatePendingShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificatePendingShowSettings ResetHelp(this AzureKeyvaultCertificatePendingShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificatePendingShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificatePendingShowSettings SetOutput(this AzureKeyvaultCertificatePendingShowSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificatePendingShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificatePendingShowSettings ResetOutput(this AzureKeyvaultCertificatePendingShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificatePendingShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificatePendingShowSettings SetQuery(this AzureKeyvaultCertificatePendingShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificatePendingShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificatePendingShowSettings ResetQuery(this AzureKeyvaultCertificatePendingShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificatePendingShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificatePendingShowSettings SetVerbose(this AzureKeyvaultCertificatePendingShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificatePendingShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificatePendingShowSettings ResetVerbose(this AzureKeyvaultCertificatePendingShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureKeyvaultCertificateIssuerAdminAddSettingsExtensions
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureKeyvaultCertificateIssuerAdminAddSettingsExtensions
    {
        #region Email
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateIssuerAdminAddSettings.Email"/>.</em></p><p>Admin e-mail address. Must be unique within the vault.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerAdminAddSettings SetEmail(this AzureKeyvaultCertificateIssuerAdminAddSettings toolSettings, string email)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Email = email;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateIssuerAdminAddSettings.Email"/>.</em></p><p>Admin e-mail address. Must be unique within the vault.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerAdminAddSettings ResetEmail(this AzureKeyvaultCertificateIssuerAdminAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Email = null;
            return toolSettings;
        }
        #endregion
        #region IssuerName
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateIssuerAdminAddSettings.IssuerName"/>.</em></p><p>Certificate issuer name.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerAdminAddSettings SetIssuerName(this AzureKeyvaultCertificateIssuerAdminAddSettings toolSettings, string issuerName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IssuerName = issuerName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateIssuerAdminAddSettings.IssuerName"/>.</em></p><p>Certificate issuer name.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerAdminAddSettings ResetIssuerName(this AzureKeyvaultCertificateIssuerAdminAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IssuerName = null;
            return toolSettings;
        }
        #endregion
        #region VaultName
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateIssuerAdminAddSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerAdminAddSettings SetVaultName(this AzureKeyvaultCertificateIssuerAdminAddSettings toolSettings, string vaultName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = vaultName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateIssuerAdminAddSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerAdminAddSettings ResetVaultName(this AzureKeyvaultCertificateIssuerAdminAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = null;
            return toolSettings;
        }
        #endregion
        #region FirstName
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateIssuerAdminAddSettings.FirstName"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerAdminAddSettings SetFirstName(this AzureKeyvaultCertificateIssuerAdminAddSettings toolSettings, string firstName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FirstName = firstName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateIssuerAdminAddSettings.FirstName"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerAdminAddSettings ResetFirstName(this AzureKeyvaultCertificateIssuerAdminAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FirstName = null;
            return toolSettings;
        }
        #endregion
        #region LastName
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateIssuerAdminAddSettings.LastName"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerAdminAddSettings SetLastName(this AzureKeyvaultCertificateIssuerAdminAddSettings toolSettings, string lastName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LastName = lastName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateIssuerAdminAddSettings.LastName"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerAdminAddSettings ResetLastName(this AzureKeyvaultCertificateIssuerAdminAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LastName = null;
            return toolSettings;
        }
        #endregion
        #region Phone
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateIssuerAdminAddSettings.Phone"/>.</em></p><p>Amin phone number.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerAdminAddSettings SetPhone(this AzureKeyvaultCertificateIssuerAdminAddSettings toolSettings, string phone)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Phone = phone;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateIssuerAdminAddSettings.Phone"/>.</em></p><p>Amin phone number.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerAdminAddSettings ResetPhone(this AzureKeyvaultCertificateIssuerAdminAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Phone = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateIssuerAdminAddSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerAdminAddSettings SetDebug(this AzureKeyvaultCertificateIssuerAdminAddSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateIssuerAdminAddSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerAdminAddSettings ResetDebug(this AzureKeyvaultCertificateIssuerAdminAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateIssuerAdminAddSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerAdminAddSettings SetHelp(this AzureKeyvaultCertificateIssuerAdminAddSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateIssuerAdminAddSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerAdminAddSettings ResetHelp(this AzureKeyvaultCertificateIssuerAdminAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateIssuerAdminAddSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerAdminAddSettings SetOutput(this AzureKeyvaultCertificateIssuerAdminAddSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateIssuerAdminAddSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerAdminAddSettings ResetOutput(this AzureKeyvaultCertificateIssuerAdminAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateIssuerAdminAddSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerAdminAddSettings SetQuery(this AzureKeyvaultCertificateIssuerAdminAddSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateIssuerAdminAddSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerAdminAddSettings ResetQuery(this AzureKeyvaultCertificateIssuerAdminAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateIssuerAdminAddSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerAdminAddSettings SetVerbose(this AzureKeyvaultCertificateIssuerAdminAddSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateIssuerAdminAddSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerAdminAddSettings ResetVerbose(this AzureKeyvaultCertificateIssuerAdminAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureKeyvaultCertificateIssuerAdminDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureKeyvaultCertificateIssuerAdminDeleteSettingsExtensions
    {
        #region Email
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateIssuerAdminDeleteSettings.Email"/>.</em></p><p>Admin e-mail address. Must be unique within the vault.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerAdminDeleteSettings SetEmail(this AzureKeyvaultCertificateIssuerAdminDeleteSettings toolSettings, string email)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Email = email;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateIssuerAdminDeleteSettings.Email"/>.</em></p><p>Admin e-mail address. Must be unique within the vault.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerAdminDeleteSettings ResetEmail(this AzureKeyvaultCertificateIssuerAdminDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Email = null;
            return toolSettings;
        }
        #endregion
        #region IssuerName
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateIssuerAdminDeleteSettings.IssuerName"/>.</em></p><p>Certificate issuer name.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerAdminDeleteSettings SetIssuerName(this AzureKeyvaultCertificateIssuerAdminDeleteSettings toolSettings, string issuerName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IssuerName = issuerName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateIssuerAdminDeleteSettings.IssuerName"/>.</em></p><p>Certificate issuer name.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerAdminDeleteSettings ResetIssuerName(this AzureKeyvaultCertificateIssuerAdminDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IssuerName = null;
            return toolSettings;
        }
        #endregion
        #region VaultName
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateIssuerAdminDeleteSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerAdminDeleteSettings SetVaultName(this AzureKeyvaultCertificateIssuerAdminDeleteSettings toolSettings, string vaultName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = vaultName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateIssuerAdminDeleteSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerAdminDeleteSettings ResetVaultName(this AzureKeyvaultCertificateIssuerAdminDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateIssuerAdminDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerAdminDeleteSettings SetDebug(this AzureKeyvaultCertificateIssuerAdminDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateIssuerAdminDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerAdminDeleteSettings ResetDebug(this AzureKeyvaultCertificateIssuerAdminDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateIssuerAdminDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerAdminDeleteSettings SetHelp(this AzureKeyvaultCertificateIssuerAdminDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateIssuerAdminDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerAdminDeleteSettings ResetHelp(this AzureKeyvaultCertificateIssuerAdminDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateIssuerAdminDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerAdminDeleteSettings SetOutput(this AzureKeyvaultCertificateIssuerAdminDeleteSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateIssuerAdminDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerAdminDeleteSettings ResetOutput(this AzureKeyvaultCertificateIssuerAdminDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateIssuerAdminDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerAdminDeleteSettings SetQuery(this AzureKeyvaultCertificateIssuerAdminDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateIssuerAdminDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerAdminDeleteSettings ResetQuery(this AzureKeyvaultCertificateIssuerAdminDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateIssuerAdminDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerAdminDeleteSettings SetVerbose(this AzureKeyvaultCertificateIssuerAdminDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateIssuerAdminDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerAdminDeleteSettings ResetVerbose(this AzureKeyvaultCertificateIssuerAdminDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureKeyvaultCertificateIssuerAdminListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureKeyvaultCertificateIssuerAdminListSettingsExtensions
    {
        #region IssuerName
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateIssuerAdminListSettings.IssuerName"/>.</em></p><p>Certificate issuer name.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerAdminListSettings SetIssuerName(this AzureKeyvaultCertificateIssuerAdminListSettings toolSettings, string issuerName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IssuerName = issuerName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateIssuerAdminListSettings.IssuerName"/>.</em></p><p>Certificate issuer name.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerAdminListSettings ResetIssuerName(this AzureKeyvaultCertificateIssuerAdminListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IssuerName = null;
            return toolSettings;
        }
        #endregion
        #region VaultName
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateIssuerAdminListSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerAdminListSettings SetVaultName(this AzureKeyvaultCertificateIssuerAdminListSettings toolSettings, string vaultName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = vaultName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateIssuerAdminListSettings.VaultName"/>.</em></p><p>Name of the key vault.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerAdminListSettings ResetVaultName(this AzureKeyvaultCertificateIssuerAdminListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateIssuerAdminListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerAdminListSettings SetDebug(this AzureKeyvaultCertificateIssuerAdminListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateIssuerAdminListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerAdminListSettings ResetDebug(this AzureKeyvaultCertificateIssuerAdminListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateIssuerAdminListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerAdminListSettings SetHelp(this AzureKeyvaultCertificateIssuerAdminListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateIssuerAdminListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerAdminListSettings ResetHelp(this AzureKeyvaultCertificateIssuerAdminListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateIssuerAdminListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerAdminListSettings SetOutput(this AzureKeyvaultCertificateIssuerAdminListSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateIssuerAdminListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerAdminListSettings ResetOutput(this AzureKeyvaultCertificateIssuerAdminListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateIssuerAdminListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerAdminListSettings SetQuery(this AzureKeyvaultCertificateIssuerAdminListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateIssuerAdminListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerAdminListSettings ResetQuery(this AzureKeyvaultCertificateIssuerAdminListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureKeyvaultCertificateIssuerAdminListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerAdminListSettings SetVerbose(this AzureKeyvaultCertificateIssuerAdminListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureKeyvaultCertificateIssuerAdminListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureKeyvaultCertificateIssuerAdminListSettings ResetVerbose(this AzureKeyvaultCertificateIssuerAdminListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region KeyvaultCreateSku
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    public partial class KeyvaultCreateSku : Enumeration
    {
        public static KeyvaultCreateSku premium = new KeyvaultCreateSku { Value = "premium" };
        public static KeyvaultCreateSku standard = new KeyvaultCreateSku { Value = "standard" };
    }
    #endregion
    #region KeyvaultSetPolicyCertificatePermissions
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    public partial class KeyvaultSetPolicyCertificatePermissions : Enumeration
    {
        public static KeyvaultSetPolicyCertificatePermissions create = new KeyvaultSetPolicyCertificatePermissions { Value = "create" };
        public static KeyvaultSetPolicyCertificatePermissions delete = new KeyvaultSetPolicyCertificatePermissions { Value = "delete" };
        public static KeyvaultSetPolicyCertificatePermissions deleteissuers = new KeyvaultSetPolicyCertificatePermissions { Value = "deleteissuers" };
        public static KeyvaultSetPolicyCertificatePermissions get = new KeyvaultSetPolicyCertificatePermissions { Value = "get" };
        public static KeyvaultSetPolicyCertificatePermissions getissuers = new KeyvaultSetPolicyCertificatePermissions { Value = "getissuers" };
        public static KeyvaultSetPolicyCertificatePermissions import = new KeyvaultSetPolicyCertificatePermissions { Value = "import" };
        public static KeyvaultSetPolicyCertificatePermissions list = new KeyvaultSetPolicyCertificatePermissions { Value = "list" };
        public static KeyvaultSetPolicyCertificatePermissions listissuers = new KeyvaultSetPolicyCertificatePermissions { Value = "listissuers" };
        public static KeyvaultSetPolicyCertificatePermissions managecontacts = new KeyvaultSetPolicyCertificatePermissions { Value = "managecontacts" };
        public static KeyvaultSetPolicyCertificatePermissions manageissuers = new KeyvaultSetPolicyCertificatePermissions { Value = "manageissuers" };
        public static KeyvaultSetPolicyCertificatePermissions purge = new KeyvaultSetPolicyCertificatePermissions { Value = "purge" };
        public static KeyvaultSetPolicyCertificatePermissions recover = new KeyvaultSetPolicyCertificatePermissions { Value = "recover" };
        public static KeyvaultSetPolicyCertificatePermissions setissuers = new KeyvaultSetPolicyCertificatePermissions { Value = "setissuers" };
        public static KeyvaultSetPolicyCertificatePermissions update = new KeyvaultSetPolicyCertificatePermissions { Value = "update" };
    }
    #endregion
    #region KeyvaultSetPolicyKeyPermissions
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    public partial class KeyvaultSetPolicyKeyPermissions : Enumeration
    {
        public static KeyvaultSetPolicyKeyPermissions backup = new KeyvaultSetPolicyKeyPermissions { Value = "backup" };
        public static KeyvaultSetPolicyKeyPermissions create = new KeyvaultSetPolicyKeyPermissions { Value = "create" };
        public static KeyvaultSetPolicyKeyPermissions decrypt = new KeyvaultSetPolicyKeyPermissions { Value = "decrypt" };
        public static KeyvaultSetPolicyKeyPermissions delete = new KeyvaultSetPolicyKeyPermissions { Value = "delete" };
        public static KeyvaultSetPolicyKeyPermissions encrypt = new KeyvaultSetPolicyKeyPermissions { Value = "encrypt" };
        public static KeyvaultSetPolicyKeyPermissions get = new KeyvaultSetPolicyKeyPermissions { Value = "get" };
        public static KeyvaultSetPolicyKeyPermissions import = new KeyvaultSetPolicyKeyPermissions { Value = "import" };
        public static KeyvaultSetPolicyKeyPermissions list = new KeyvaultSetPolicyKeyPermissions { Value = "list" };
        public static KeyvaultSetPolicyKeyPermissions purge = new KeyvaultSetPolicyKeyPermissions { Value = "purge" };
        public static KeyvaultSetPolicyKeyPermissions recover = new KeyvaultSetPolicyKeyPermissions { Value = "recover" };
        public static KeyvaultSetPolicyKeyPermissions restore = new KeyvaultSetPolicyKeyPermissions { Value = "restore" };
        public static KeyvaultSetPolicyKeyPermissions sign = new KeyvaultSetPolicyKeyPermissions { Value = "sign" };
        public static KeyvaultSetPolicyKeyPermissions unwrapkey = new KeyvaultSetPolicyKeyPermissions { Value = "unwrapkey" };
        public static KeyvaultSetPolicyKeyPermissions update = new KeyvaultSetPolicyKeyPermissions { Value = "update" };
        public static KeyvaultSetPolicyKeyPermissions verify = new KeyvaultSetPolicyKeyPermissions { Value = "verify" };
        public static KeyvaultSetPolicyKeyPermissions wrapkey = new KeyvaultSetPolicyKeyPermissions { Value = "wrapkey" };
    }
    #endregion
    #region KeyvaultSetPolicySecretPermissions
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    public partial class KeyvaultSetPolicySecretPermissions : Enumeration
    {
        public static KeyvaultSetPolicySecretPermissions backup = new KeyvaultSetPolicySecretPermissions { Value = "backup" };
        public static KeyvaultSetPolicySecretPermissions delete = new KeyvaultSetPolicySecretPermissions { Value = "delete" };
        public static KeyvaultSetPolicySecretPermissions get = new KeyvaultSetPolicySecretPermissions { Value = "get" };
        public static KeyvaultSetPolicySecretPermissions list = new KeyvaultSetPolicySecretPermissions { Value = "list" };
        public static KeyvaultSetPolicySecretPermissions purge = new KeyvaultSetPolicySecretPermissions { Value = "purge" };
        public static KeyvaultSetPolicySecretPermissions recover = new KeyvaultSetPolicySecretPermissions { Value = "recover" };
        public static KeyvaultSetPolicySecretPermissions restore = new KeyvaultSetPolicySecretPermissions { Value = "restore" };
        public static KeyvaultSetPolicySecretPermissions set = new KeyvaultSetPolicySecretPermissions { Value = "set" };
    }
    #endregion
    #region KeyvaultCertificateDownloadEncoding
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    public partial class KeyvaultCertificateDownloadEncoding : Enumeration
    {
        public static KeyvaultCertificateDownloadEncoding der = new KeyvaultCertificateDownloadEncoding { Value = "der" };
        public static KeyvaultCertificateDownloadEncoding pem = new KeyvaultCertificateDownloadEncoding { Value = "pem" };
    }
    #endregion
    #region KeyvaultSecretEncoding
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    public partial class KeyvaultSecretEncoding : Enumeration
    {
        public static KeyvaultSecretEncoding ascii = new KeyvaultSecretEncoding { Value = "ascii" };
        public static KeyvaultSecretEncoding base64 = new KeyvaultSecretEncoding { Value = "base64" };
        public static KeyvaultSecretEncoding hex = new KeyvaultSecretEncoding { Value = "hex" };
        public static KeyvaultSecretEncoding utf_16be = new KeyvaultSecretEncoding { Value = "utf-16be" };
        public static KeyvaultSecretEncoding utf_16le = new KeyvaultSecretEncoding { Value = "utf-16le" };
        public static KeyvaultSecretEncoding utf_8 = new KeyvaultSecretEncoding { Value = "utf-8" };
    }
    #endregion
    #region KeyvaultKeyProtection
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    public partial class KeyvaultKeyProtection : Enumeration
    {
        public static KeyvaultKeyProtection hsm = new KeyvaultKeyProtection { Value = "hsm" };
        public static KeyvaultKeyProtection software = new KeyvaultKeyProtection { Value = "software" };
    }
    #endregion
    #region KeyvaultKeyOps
    /// <summary><p>Used within <see cref="AzureKeyvaultTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    public partial class KeyvaultKeyOps : Enumeration
    {
        public static KeyvaultKeyOps decrypt = new KeyvaultKeyOps { Value = "decrypt" };
        public static KeyvaultKeyOps encrypt = new KeyvaultKeyOps { Value = "encrypt" };
        public static KeyvaultKeyOps sign = new KeyvaultKeyOps { Value = "sign" };
        public static KeyvaultKeyOps unwrapkey = new KeyvaultKeyOps { Value = "unwrapkey" };
        public static KeyvaultKeyOps verify = new KeyvaultKeyOps { Value = "verify" };
        public static KeyvaultKeyOps wrapkey = new KeyvaultKeyOps { Value = "wrapkey" };
    }
    #endregion
}
