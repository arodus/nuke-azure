// Copyright Matthias Koch, Sebastian Karasek 2018.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

// Generated with Nuke.CodeGeneration, Version: 0.5.0-alpha.15 [CommitSha: 2886d896].
// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/AzureAcr.json.

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
    public static partial class AzureAcrTasks
    {
        /// <summary><p>Path to the AzureAcr executable.</p></summary>
        public static string AzureAcrPath => ToolPathResolver.GetPathExecutable("az");
        /// <summary><p>Manage Azure Container Registries.</p></summary>
        public static IEnumerable<string> AzureAcr(string arguments, string workingDirectory = null, ProcessSettings processSettings = null)
        {
            var process = ProcessTasks.StartProcess(AzureAcrPath, arguments, workingDirectory, processSettings?.EnvironmentVariables, processSettings?.ExecutionTimeout, processSettings?.RedirectOutput ?? true);
            process.AssertZeroExitCode();
            return process.Output.Select(x => x.Text);
        }
        static partial void PreProcess(AzureAcrCheckNameSettings toolSettings);
        static partial void PostProcess(AzureAcrCheckNameSettings toolSettings);
        /// <summary><p>Manage Azure Container Registries.</p><p>For more details, visit the <a href="https://raw.githubusercontent.com/Azure/azure-docs-cli-python/live/latest/docs-ref-autogen/acr.yml">official website</a>.</p></summary>
        public static void AzureAcrCheckName(Configure<AzureAcrCheckNameSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcrCheckNameSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureAcrCreateSettings toolSettings);
        static partial void PostProcess(AzureAcrCreateSettings toolSettings);
        /// <summary><p>Manage Azure Container Registries.</p><p>For more details, visit the <a href="https://raw.githubusercontent.com/Azure/azure-docs-cli-python/live/latest/docs-ref-autogen/acr.yml">official website</a>.</p></summary>
        public static void AzureAcrCreate(Configure<AzureAcrCreateSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcrCreateSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureAcrDeleteSettings toolSettings);
        static partial void PostProcess(AzureAcrDeleteSettings toolSettings);
        /// <summary><p>Manage Azure Container Registries.</p><p>For more details, visit the <a href="https://raw.githubusercontent.com/Azure/azure-docs-cli-python/live/latest/docs-ref-autogen/acr.yml">official website</a>.</p></summary>
        public static void AzureAcrDelete(Configure<AzureAcrDeleteSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcrDeleteSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureAcrListSettings toolSettings);
        static partial void PostProcess(AzureAcrListSettings toolSettings);
        /// <summary><p>Manage Azure Container Registries.</p><p>For more details, visit the <a href="https://raw.githubusercontent.com/Azure/azure-docs-cli-python/live/latest/docs-ref-autogen/acr.yml">official website</a>.</p></summary>
        public static void AzureAcrList(Configure<AzureAcrListSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcrListSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureAcrLoginSettings toolSettings);
        static partial void PostProcess(AzureAcrLoginSettings toolSettings);
        /// <summary><p>Manage Azure Container Registries.</p><p>For more details, visit the <a href="https://raw.githubusercontent.com/Azure/azure-docs-cli-python/live/latest/docs-ref-autogen/acr.yml">official website</a>.</p></summary>
        public static void AzureAcrLogin(Configure<AzureAcrLoginSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcrLoginSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureAcrShowSettings toolSettings);
        static partial void PostProcess(AzureAcrShowSettings toolSettings);
        /// <summary><p>Manage Azure Container Registries.</p><p>For more details, visit the <a href="https://raw.githubusercontent.com/Azure/azure-docs-cli-python/live/latest/docs-ref-autogen/acr.yml">official website</a>.</p></summary>
        public static void AzureAcrShow(Configure<AzureAcrShowSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcrShowSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureAcrShowUsageSettings toolSettings);
        static partial void PostProcess(AzureAcrShowUsageSettings toolSettings);
        /// <summary><p>Manage Azure Container Registries.</p><p>For more details, visit the <a href="https://raw.githubusercontent.com/Azure/azure-docs-cli-python/live/latest/docs-ref-autogen/acr.yml">official website</a>.</p></summary>
        public static void AzureAcrShowUsage(Configure<AzureAcrShowUsageSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcrShowUsageSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureAcrUpdateSettings toolSettings);
        static partial void PostProcess(AzureAcrUpdateSettings toolSettings);
        /// <summary><p>Manage Azure Container Registries.</p><p>For more details, visit the <a href="https://raw.githubusercontent.com/Azure/azure-docs-cli-python/live/latest/docs-ref-autogen/acr.yml">official website</a>.</p></summary>
        public static void AzureAcrUpdate(Configure<AzureAcrUpdateSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcrUpdateSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureAcrCredentialRenewSettings toolSettings);
        static partial void PostProcess(AzureAcrCredentialRenewSettings toolSettings);
        /// <summary><p>Manage Azure Container Registries.</p><p>For more details, visit the <a href="https://raw.githubusercontent.com/Azure/azure-docs-cli-python/live/latest/docs-ref-autogen/acr.yml">official website</a>.</p></summary>
        public static void AzureAcrCredentialRenew(Configure<AzureAcrCredentialRenewSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcrCredentialRenewSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureAcrCredentialShowSettings toolSettings);
        static partial void PostProcess(AzureAcrCredentialShowSettings toolSettings);
        /// <summary><p>Manage Azure Container Registries.</p><p>For more details, visit the <a href="https://raw.githubusercontent.com/Azure/azure-docs-cli-python/live/latest/docs-ref-autogen/acr.yml">official website</a>.</p></summary>
        public static void AzureAcrCredentialShow(Configure<AzureAcrCredentialShowSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcrCredentialShowSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureAcrReplicationCreateSettings toolSettings);
        static partial void PostProcess(AzureAcrReplicationCreateSettings toolSettings);
        /// <summary><p>Manage Azure Container Registries.</p><p>For more details, visit the <a href="https://raw.githubusercontent.com/Azure/azure-docs-cli-python/live/latest/docs-ref-autogen/acr.yml">official website</a>.</p></summary>
        public static void AzureAcrReplicationCreate(Configure<AzureAcrReplicationCreateSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcrReplicationCreateSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureAcrReplicationDeleteSettings toolSettings);
        static partial void PostProcess(AzureAcrReplicationDeleteSettings toolSettings);
        /// <summary><p>Manage Azure Container Registries.</p><p>For more details, visit the <a href="https://raw.githubusercontent.com/Azure/azure-docs-cli-python/live/latest/docs-ref-autogen/acr.yml">official website</a>.</p></summary>
        public static void AzureAcrReplicationDelete(Configure<AzureAcrReplicationDeleteSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcrReplicationDeleteSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureAcrReplicationListSettings toolSettings);
        static partial void PostProcess(AzureAcrReplicationListSettings toolSettings);
        /// <summary><p>Manage Azure Container Registries.</p><p>For more details, visit the <a href="https://raw.githubusercontent.com/Azure/azure-docs-cli-python/live/latest/docs-ref-autogen/acr.yml">official website</a>.</p></summary>
        public static void AzureAcrReplicationList(Configure<AzureAcrReplicationListSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcrReplicationListSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureAcrReplicationShowSettings toolSettings);
        static partial void PostProcess(AzureAcrReplicationShowSettings toolSettings);
        /// <summary><p>Manage Azure Container Registries.</p><p>For more details, visit the <a href="https://raw.githubusercontent.com/Azure/azure-docs-cli-python/live/latest/docs-ref-autogen/acr.yml">official website</a>.</p></summary>
        public static void AzureAcrReplicationShow(Configure<AzureAcrReplicationShowSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcrReplicationShowSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureAcrReplicationUpdateSettings toolSettings);
        static partial void PostProcess(AzureAcrReplicationUpdateSettings toolSettings);
        /// <summary><p>Manage Azure Container Registries.</p><p>For more details, visit the <a href="https://raw.githubusercontent.com/Azure/azure-docs-cli-python/live/latest/docs-ref-autogen/acr.yml">official website</a>.</p></summary>
        public static void AzureAcrReplicationUpdate(Configure<AzureAcrReplicationUpdateSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcrReplicationUpdateSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureAcrRepositoryDeleteSettings toolSettings);
        static partial void PostProcess(AzureAcrRepositoryDeleteSettings toolSettings);
        /// <summary><p>Manage Azure Container Registries.</p><p>For more details, visit the <a href="https://raw.githubusercontent.com/Azure/azure-docs-cli-python/live/latest/docs-ref-autogen/acr.yml">official website</a>.</p></summary>
        public static void AzureAcrRepositoryDelete(Configure<AzureAcrRepositoryDeleteSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcrRepositoryDeleteSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureAcrRepositoryListSettings toolSettings);
        static partial void PostProcess(AzureAcrRepositoryListSettings toolSettings);
        /// <summary><p>Manage Azure Container Registries.</p><p>For more details, visit the <a href="https://raw.githubusercontent.com/Azure/azure-docs-cli-python/live/latest/docs-ref-autogen/acr.yml">official website</a>.</p></summary>
        public static void AzureAcrRepositoryList(Configure<AzureAcrRepositoryListSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcrRepositoryListSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureAcrRepositoryShowManifestsSettings toolSettings);
        static partial void PostProcess(AzureAcrRepositoryShowManifestsSettings toolSettings);
        /// <summary><p>Manage Azure Container Registries.</p><p>For more details, visit the <a href="https://raw.githubusercontent.com/Azure/azure-docs-cli-python/live/latest/docs-ref-autogen/acr.yml">official website</a>.</p></summary>
        public static void AzureAcrRepositoryShowManifests(Configure<AzureAcrRepositoryShowManifestsSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcrRepositoryShowManifestsSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureAcrRepositoryShowTagsSettings toolSettings);
        static partial void PostProcess(AzureAcrRepositoryShowTagsSettings toolSettings);
        /// <summary><p>Manage Azure Container Registries.</p><p>For more details, visit the <a href="https://raw.githubusercontent.com/Azure/azure-docs-cli-python/live/latest/docs-ref-autogen/acr.yml">official website</a>.</p></summary>
        public static void AzureAcrRepositoryShowTags(Configure<AzureAcrRepositoryShowTagsSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcrRepositoryShowTagsSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureAcrRepositoryUntagSettings toolSettings);
        static partial void PostProcess(AzureAcrRepositoryUntagSettings toolSettings);
        /// <summary><p>Manage Azure Container Registries.</p><p>For more details, visit the <a href="https://raw.githubusercontent.com/Azure/azure-docs-cli-python/live/latest/docs-ref-autogen/acr.yml">official website</a>.</p></summary>
        public static void AzureAcrRepositoryUntag(Configure<AzureAcrRepositoryUntagSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcrRepositoryUntagSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureAcrWebhookCreateSettings toolSettings);
        static partial void PostProcess(AzureAcrWebhookCreateSettings toolSettings);
        /// <summary><p>Manage Azure Container Registries.</p><p>For more details, visit the <a href="https://raw.githubusercontent.com/Azure/azure-docs-cli-python/live/latest/docs-ref-autogen/acr.yml">official website</a>.</p></summary>
        public static void AzureAcrWebhookCreate(Configure<AzureAcrWebhookCreateSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcrWebhookCreateSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureAcrWebhookDeleteSettings toolSettings);
        static partial void PostProcess(AzureAcrWebhookDeleteSettings toolSettings);
        /// <summary><p>Manage Azure Container Registries.</p><p>For more details, visit the <a href="https://raw.githubusercontent.com/Azure/azure-docs-cli-python/live/latest/docs-ref-autogen/acr.yml">official website</a>.</p></summary>
        public static void AzureAcrWebhookDelete(Configure<AzureAcrWebhookDeleteSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcrWebhookDeleteSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureAcrWebhookGetConfigSettings toolSettings);
        static partial void PostProcess(AzureAcrWebhookGetConfigSettings toolSettings);
        /// <summary><p>Manage Azure Container Registries.</p><p>For more details, visit the <a href="https://raw.githubusercontent.com/Azure/azure-docs-cli-python/live/latest/docs-ref-autogen/acr.yml">official website</a>.</p></summary>
        public static void AzureAcrWebhookGetConfig(Configure<AzureAcrWebhookGetConfigSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcrWebhookGetConfigSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureAcrWebhookListSettings toolSettings);
        static partial void PostProcess(AzureAcrWebhookListSettings toolSettings);
        /// <summary><p>Manage Azure Container Registries.</p><p>For more details, visit the <a href="https://raw.githubusercontent.com/Azure/azure-docs-cli-python/live/latest/docs-ref-autogen/acr.yml">official website</a>.</p></summary>
        public static void AzureAcrWebhookList(Configure<AzureAcrWebhookListSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcrWebhookListSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureAcrWebhookListEventsSettings toolSettings);
        static partial void PostProcess(AzureAcrWebhookListEventsSettings toolSettings);
        /// <summary><p>Manage Azure Container Registries.</p><p>For more details, visit the <a href="https://raw.githubusercontent.com/Azure/azure-docs-cli-python/live/latest/docs-ref-autogen/acr.yml">official website</a>.</p></summary>
        public static void AzureAcrWebhookListEvents(Configure<AzureAcrWebhookListEventsSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcrWebhookListEventsSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureAcrWebhookPingSettings toolSettings);
        static partial void PostProcess(AzureAcrWebhookPingSettings toolSettings);
        /// <summary><p>Manage Azure Container Registries.</p><p>For more details, visit the <a href="https://raw.githubusercontent.com/Azure/azure-docs-cli-python/live/latest/docs-ref-autogen/acr.yml">official website</a>.</p></summary>
        public static void AzureAcrWebhookPing(Configure<AzureAcrWebhookPingSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcrWebhookPingSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureAcrWebhookShowSettings toolSettings);
        static partial void PostProcess(AzureAcrWebhookShowSettings toolSettings);
        /// <summary><p>Manage Azure Container Registries.</p><p>For more details, visit the <a href="https://raw.githubusercontent.com/Azure/azure-docs-cli-python/live/latest/docs-ref-autogen/acr.yml">official website</a>.</p></summary>
        public static void AzureAcrWebhookShow(Configure<AzureAcrWebhookShowSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcrWebhookShowSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureAcrWebhookUpdateSettings toolSettings);
        static partial void PostProcess(AzureAcrWebhookUpdateSettings toolSettings);
        /// <summary><p>Manage Azure Container Registries.</p><p>For more details, visit the <a href="https://raw.githubusercontent.com/Azure/azure-docs-cli-python/live/latest/docs-ref-autogen/acr.yml">official website</a>.</p></summary>
        public static void AzureAcrWebhookUpdate(Configure<AzureAcrWebhookUpdateSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcrWebhookUpdateSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
    }
    #region AzureAcrCheckNameSettings
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcrCheckNameSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcr executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcrTasks.AzureAcrPath;
        /// <summary><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
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
              .Add("acr check-name")
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
    #region AzureAcrCreateSettings
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcrCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcr executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcrTasks.AzureAcrPath;
        /// <summary><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The SKU of the container registry.</p></summary>
        public virtual AcrSku Sku { get; internal set; }
        /// <summary><p>Indicates whether the admin user is enabled.</p></summary>
        public virtual bool? AdminEnabled { get; internal set; }
        /// <summary><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        public virtual string Location { get; internal set; }
        /// <summary><p>Provide the name of an existing storage account if you're recreating a container registry over a previous registry created storage account. Only applicable to Classic SKU.</p></summary>
        public virtual string StorageAccountName { get; internal set; }
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
              .Add("acr create")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--sku {value}", Sku)
              .Add("--admin-enabled", AdminEnabled)
              .Add("--location {value}", Location)
              .Add("--storage-account-name {value}", StorageAccountName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureAcrDeleteSettings
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcrDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcr executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcrTasks.AzureAcrPath;
        /// <summary><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
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
              .Add("acr delete")
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
    #region AzureAcrListSettings
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcrListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcr executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcrTasks.AzureAcrPath;
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
              .Add("acr list")
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
    #region AzureAcrLoginSettings
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcrLoginSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcr executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcrTasks.AzureAcrPath;
        /// <summary><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>The password used to log into a container registry.</p></summary>
        public virtual string Password { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The username used to log into a container registry.</p></summary>
        public virtual string Username { get; internal set; }
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
              .Add("acr login")
              .Add("--name {value}", Name)
              .Add("--password {value}", Password)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--username {value}", Username)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureAcrShowSettings
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcrShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcr executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcrTasks.AzureAcrPath;
        /// <summary><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
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
              .Add("acr show")
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
    #region AzureAcrShowUsageSettings
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcrShowUsageSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcr executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcrTasks.AzureAcrPath;
        /// <summary><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
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
              .Add("acr show-usage")
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
    #region AzureAcrUpdateSettings
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcrUpdateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcr executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcrTasks.AzureAcrPath;
        /// <summary><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Indicates whether the admin user is enabled.</p></summary>
        public virtual bool? AdminEnabled { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The SKU of the container registry.</p></summary>
        public virtual AcrSku Sku { get; internal set; }
        /// <summary><p>Provide the name of an existing storage account if you're recreating a container registry over a previous registry created storage account. Only applicable to Classic SKU.</p></summary>
        public virtual string StorageAccountName { get; internal set; }
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
              .Add("acr update")
              .Add("--name {value}", Name)
              .Add("--admin-enabled", AdminEnabled)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--sku {value}", Sku)
              .Add("--storage-account-name {value}", StorageAccountName)
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
    #region AzureAcrCredentialRenewSettings
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcrCredentialRenewSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcr executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcrTasks.AzureAcrPath;
        /// <summary><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>The name of password to regenerate.</p></summary>
        public virtual AcrCredentialRenewPasswordName PasswordName { get; internal set; }
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
              .Add("acr credential renew")
              .Add("--name {value}", Name)
              .Add("--password-name {value}", PasswordName)
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
    #region AzureAcrCredentialShowSettings
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcrCredentialShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcr executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcrTasks.AzureAcrPath;
        /// <summary><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
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
              .Add("acr credential show")
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
    #region AzureAcrReplicationCreateSettings
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcrReplicationCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcr executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcrTasks.AzureAcrPath;
        /// <summary><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        public virtual string Location { get; internal set; }
        /// <summary><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        public virtual string Registry { get; internal set; }
        /// <summary><p>The name of the replication. Default to the location name.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
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
              .Add("acr replication create")
              .Add("--location {value}", Location)
              .Add("--registry {value}", Registry)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
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
    #region AzureAcrReplicationDeleteSettings
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcrReplicationDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcr executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcrTasks.AzureAcrPath;
        /// <summary><p>The name of the replication.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        public virtual string Registry { get; internal set; }
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
              .Add("acr replication delete")
              .Add("--name {value}", Name)
              .Add("--registry {value}", Registry)
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
    #region AzureAcrReplicationListSettings
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcrReplicationListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcr executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcrTasks.AzureAcrPath;
        /// <summary><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        public virtual string Registry { get; internal set; }
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
              .Add("acr replication list")
              .Add("--registry {value}", Registry)
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
    #region AzureAcrReplicationShowSettings
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcrReplicationShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcr executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcrTasks.AzureAcrPath;
        /// <summary><p>The name of the replication.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        public virtual string Registry { get; internal set; }
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
              .Add("acr replication show")
              .Add("--name {value}", Name)
              .Add("--registry {value}", Registry)
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
    #region AzureAcrReplicationUpdateSettings
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcrReplicationUpdateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcr executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcrTasks.AzureAcrPath;
        /// <summary><p>The name of the replication.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        public virtual string Registry { get; internal set; }
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
              .Add("acr replication update")
              .Add("--name {value}", Name)
              .Add("--registry {value}", Registry)
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
    #region AzureAcrRepositoryDeleteSettings
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcrRepositoryDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcr executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcrTasks.AzureAcrPath;
        /// <summary><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>The name of the image to delete. May include a tag in the format 'name:tag' or digest in the format 'name@digest'.</p></summary>
        public virtual string Image { get; internal set; }
        /// <summary><p>The password used to log into a container registry.</p></summary>
        public virtual string Password { get; internal set; }
        /// <summary><p>The name of the repository to delete.</p></summary>
        public virtual string Repository { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The username used to log into a container registry.</p></summary>
        public virtual string Username { get; internal set; }
        /// <summary><p>Do not prompt for confirmation.</p></summary>
        public virtual string Yes { get; internal set; }
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
              .Add("acr repository delete")
              .Add("--name {value}", Name)
              .Add("--image {value}", Image)
              .Add("--password {value}", Password)
              .Add("--repository {value}", Repository)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--username {value}", Username)
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
    #region AzureAcrRepositoryListSettings
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcrRepositoryListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcr executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcrTasks.AzureAcrPath;
        /// <summary><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>The password used to log into a container registry.</p></summary>
        public virtual string Password { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The username used to log into a container registry.</p></summary>
        public virtual string Username { get; internal set; }
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
              .Add("acr repository list")
              .Add("--name {value}", Name)
              .Add("--password {value}", Password)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--username {value}", Username)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureAcrRepositoryShowManifestsSettings
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcrRepositoryShowManifestsSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcr executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcrTasks.AzureAcrPath;
        /// <summary><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>The repository to obtain manifests from.</p></summary>
        public virtual string Repository { get; internal set; }
        /// <summary><p>The password used to log into a container registry.</p></summary>
        public virtual string Password { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The username used to log into a container registry.</p></summary>
        public virtual string Username { get; internal set; }
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
              .Add("acr repository show-manifests")
              .Add("--name {value}", Name)
              .Add("--repository {value}", Repository)
              .Add("--password {value}", Password)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--username {value}", Username)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureAcrRepositoryShowTagsSettings
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcrRepositoryShowTagsSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcr executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcrTasks.AzureAcrPath;
        /// <summary><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>The repository to obtain tags from.</p></summary>
        public virtual string Repository { get; internal set; }
        /// <summary><p>The password used to log into a container registry.</p></summary>
        public virtual string Password { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The username used to log into a container registry.</p></summary>
        public virtual string Username { get; internal set; }
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
              .Add("acr repository show-tags")
              .Add("--name {value}", Name)
              .Add("--repository {value}", Repository)
              .Add("--password {value}", Password)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--username {value}", Username)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureAcrRepositoryUntagSettings
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcrRepositoryUntagSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcr executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcrTasks.AzureAcrPath;
        /// <summary><p>The name of the image to untag. May include a tag in the format 'name:tag'.</p></summary>
        public virtual string Image { get; internal set; }
        /// <summary><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>The password used to log into a container registry.</p></summary>
        public virtual string Password { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The username used to log into a container registry.</p></summary>
        public virtual string Username { get; internal set; }
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
              .Add("acr repository untag")
              .Add("--image {value}", Image)
              .Add("--name {value}", Name)
              .Add("--password {value}", Password)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--username {value}", Username)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureAcrWebhookCreateSettings
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcrWebhookCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcr executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcrTasks.AzureAcrPath;
        /// <summary><p>Space-separated list of actions that trigger the webhook to post notifications.</p></summary>
        public virtual IReadOnlyList<AcrWebhookActions> Actions => ActionsInternal.AsReadOnly();
        internal List<AcrWebhookActions> ActionsInternal { get; set; } = new List<AcrWebhookActions>();
        /// <summary><p>The name of the webhook.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        public virtual string Registry { get; internal set; }
        /// <summary><p>The service URI for the webhook to post notifications.</p></summary>
        public virtual string Uri { get; internal set; }
        /// <summary><p>Space-separated custom headers in 'key[=value]' format that will be added to the webhook notifications. Use "" to clear existing headers.</p></summary>
        public virtual string Headers { get; internal set; }
        /// <summary><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        public virtual string Location { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The scope of repositories where the event can be triggered. For example, 'foo:*' means events for all tags under repository 'foo'. 'foo:bar' means events for 'foo:bar' only. 'foo' is equivalent to 'foo:latest'. Empty means events for all repositories.</p></summary>
        public virtual string Scope { get; internal set; }
        /// <summary><p>Indicates whether the webhook is enabled.</p></summary>
        public virtual AcrWebhookStatus Status { get; internal set; }
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
              .Add("acr webhook create")
              .Add("--actions {value}", Actions, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--registry {value}", Registry)
              .Add("--uri {value}", Uri)
              .Add("--headers {value}", Headers)
              .Add("--location {value}", Location)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--scope {value}", Scope)
              .Add("--status {value}", Status)
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
    #region AzureAcrWebhookDeleteSettings
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcrWebhookDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcr executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcrTasks.AzureAcrPath;
        /// <summary><p>The name of the webhook.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        public virtual string Registry { get; internal set; }
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
              .Add("acr webhook delete")
              .Add("--name {value}", Name)
              .Add("--registry {value}", Registry)
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
    #region AzureAcrWebhookGetConfigSettings
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcrWebhookGetConfigSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcr executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcrTasks.AzureAcrPath;
        /// <summary><p>The name of the webhook.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        public virtual string Registry { get; internal set; }
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
              .Add("acr webhook get-config")
              .Add("--name {value}", Name)
              .Add("--registry {value}", Registry)
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
    #region AzureAcrWebhookListSettings
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcrWebhookListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcr executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcrTasks.AzureAcrPath;
        /// <summary><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        public virtual string Registry { get; internal set; }
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
              .Add("acr webhook list")
              .Add("--registry {value}", Registry)
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
    #region AzureAcrWebhookListEventsSettings
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcrWebhookListEventsSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcr executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcrTasks.AzureAcrPath;
        /// <summary><p>The name of the webhook.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        public virtual string Registry { get; internal set; }
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
              .Add("acr webhook list-events")
              .Add("--name {value}", Name)
              .Add("--registry {value}", Registry)
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
    #region AzureAcrWebhookPingSettings
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcrWebhookPingSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcr executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcrTasks.AzureAcrPath;
        /// <summary><p>The name of the webhook.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        public virtual string Registry { get; internal set; }
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
              .Add("acr webhook ping")
              .Add("--name {value}", Name)
              .Add("--registry {value}", Registry)
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
    #region AzureAcrWebhookShowSettings
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcrWebhookShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcr executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcrTasks.AzureAcrPath;
        /// <summary><p>The name of the webhook.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        public virtual string Registry { get; internal set; }
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
              .Add("acr webhook show")
              .Add("--name {value}", Name)
              .Add("--registry {value}", Registry)
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
    #region AzureAcrWebhookUpdateSettings
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcrWebhookUpdateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcr executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcrTasks.AzureAcrPath;
        /// <summary><p>The name of the webhook.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        public virtual string Registry { get; internal set; }
        /// <summary><p>Space-separated list of actions that trigger the webhook to post notifications.</p></summary>
        public virtual IReadOnlyList<AcrWebhookActions> Actions => ActionsInternal.AsReadOnly();
        internal List<AcrWebhookActions> ActionsInternal { get; set; } = new List<AcrWebhookActions>();
        /// <summary><p>Space-separated custom headers in 'key[=value]' format that will be added to the webhook notifications. Use "" to clear existing headers.</p></summary>
        public virtual string Headers { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The scope of repositories where the event can be triggered. For example, 'foo:*' means events for all tags under repository 'foo'. 'foo:bar' means events for 'foo:bar' only. 'foo' is equivalent to 'foo:latest'. Empty means events for all repositories.</p></summary>
        public virtual string Scope { get; internal set; }
        /// <summary><p>Indicates whether the webhook is enabled.</p></summary>
        public virtual AcrWebhookStatus Status { get; internal set; }
        /// <summary><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        public virtual string Tags { get; internal set; }
        /// <summary><p>The service URI for the webhook to post notifications.</p></summary>
        public virtual string Uri { get; internal set; }
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
              .Add("acr webhook update")
              .Add("--name {value}", Name)
              .Add("--registry {value}", Registry)
              .Add("--actions {value}", Actions, separator: ' ')
              .Add("--headers {value}", Headers)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--scope {value}", Scope)
              .Add("--status {value}", Status)
              .Add("--tags {value}", Tags)
              .Add("--uri {value}", Uri)
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
    #region AzureAcrCheckNameSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcrCheckNameSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAcrCheckNameSettings.Name"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrCheckNameSettings SetName(this AzureAcrCheckNameSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrCheckNameSettings.Name"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrCheckNameSettings ResetName(this AzureAcrCheckNameSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcrCheckNameSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrCheckNameSettings SetDebug(this AzureAcrCheckNameSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrCheckNameSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrCheckNameSettings ResetDebug(this AzureAcrCheckNameSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcrCheckNameSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrCheckNameSettings SetHelp(this AzureAcrCheckNameSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrCheckNameSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrCheckNameSettings ResetHelp(this AzureAcrCheckNameSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcrCheckNameSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrCheckNameSettings SetOutput(this AzureAcrCheckNameSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrCheckNameSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrCheckNameSettings ResetOutput(this AzureAcrCheckNameSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcrCheckNameSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrCheckNameSettings SetQuery(this AzureAcrCheckNameSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrCheckNameSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrCheckNameSettings ResetQuery(this AzureAcrCheckNameSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcrCheckNameSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrCheckNameSettings SetVerbose(this AzureAcrCheckNameSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrCheckNameSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrCheckNameSettings ResetVerbose(this AzureAcrCheckNameSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcrCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcrCreateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAcrCreateSettings.Name"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrCreateSettings SetName(this AzureAcrCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrCreateSettings.Name"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrCreateSettings ResetName(this AzureAcrCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAcrCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrCreateSettings SetResourceGroup(this AzureAcrCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrCreateSettings ResetResourceGroup(this AzureAcrCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Sku
        /// <summary><p><em>Sets <see cref="AzureAcrCreateSettings.Sku"/>.</em></p><p>The SKU of the container registry.</p></summary>
        [Pure]
        public static AzureAcrCreateSettings SetSku(this AzureAcrCreateSettings toolSettings, AcrSku sku)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = sku;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrCreateSettings.Sku"/>.</em></p><p>The SKU of the container registry.</p></summary>
        [Pure]
        public static AzureAcrCreateSettings ResetSku(this AzureAcrCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = null;
            return toolSettings;
        }
        #endregion
        #region AdminEnabled
        /// <summary><p><em>Sets <see cref="AzureAcrCreateSettings.AdminEnabled"/>.</em></p><p>Indicates whether the admin user is enabled.</p></summary>
        [Pure]
        public static AzureAcrCreateSettings SetAdminEnabled(this AzureAcrCreateSettings toolSettings, bool? adminEnabled)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdminEnabled = adminEnabled;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrCreateSettings.AdminEnabled"/>.</em></p><p>Indicates whether the admin user is enabled.</p></summary>
        [Pure]
        public static AzureAcrCreateSettings ResetAdminEnabled(this AzureAcrCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdminEnabled = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureAcrCreateSettings.AdminEnabled"/>.</em></p><p>Indicates whether the admin user is enabled.</p></summary>
        [Pure]
        public static AzureAcrCreateSettings EnableAdminEnabled(this AzureAcrCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdminEnabled = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureAcrCreateSettings.AdminEnabled"/>.</em></p><p>Indicates whether the admin user is enabled.</p></summary>
        [Pure]
        public static AzureAcrCreateSettings DisableAdminEnabled(this AzureAcrCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdminEnabled = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureAcrCreateSettings.AdminEnabled"/>.</em></p><p>Indicates whether the admin user is enabled.</p></summary>
        [Pure]
        public static AzureAcrCreateSettings ToggleAdminEnabled(this AzureAcrCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdminEnabled = !toolSettings.AdminEnabled;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary><p><em>Sets <see cref="AzureAcrCreateSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrCreateSettings SetLocation(this AzureAcrCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrCreateSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrCreateSettings ResetLocation(this AzureAcrCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region StorageAccountName
        /// <summary><p><em>Sets <see cref="AzureAcrCreateSettings.StorageAccountName"/>.</em></p><p>Provide the name of an existing storage account if you're recreating a container registry over a previous registry created storage account. Only applicable to Classic SKU.</p></summary>
        [Pure]
        public static AzureAcrCreateSettings SetStorageAccountName(this AzureAcrCreateSettings toolSettings, string storageAccountName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageAccountName = storageAccountName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrCreateSettings.StorageAccountName"/>.</em></p><p>Provide the name of an existing storage account if you're recreating a container registry over a previous registry created storage account. Only applicable to Classic SKU.</p></summary>
        [Pure]
        public static AzureAcrCreateSettings ResetStorageAccountName(this AzureAcrCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageAccountName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcrCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrCreateSettings SetDebug(this AzureAcrCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrCreateSettings ResetDebug(this AzureAcrCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcrCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrCreateSettings SetHelp(this AzureAcrCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrCreateSettings ResetHelp(this AzureAcrCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcrCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrCreateSettings SetOutput(this AzureAcrCreateSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrCreateSettings ResetOutput(this AzureAcrCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcrCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrCreateSettings SetQuery(this AzureAcrCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrCreateSettings ResetQuery(this AzureAcrCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcrCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrCreateSettings SetVerbose(this AzureAcrCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrCreateSettings ResetVerbose(this AzureAcrCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcrDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcrDeleteSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAcrDeleteSettings.Name"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrDeleteSettings SetName(this AzureAcrDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrDeleteSettings.Name"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrDeleteSettings ResetName(this AzureAcrDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAcrDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrDeleteSettings SetResourceGroup(this AzureAcrDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrDeleteSettings ResetResourceGroup(this AzureAcrDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcrDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrDeleteSettings SetDebug(this AzureAcrDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrDeleteSettings ResetDebug(this AzureAcrDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcrDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrDeleteSettings SetHelp(this AzureAcrDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrDeleteSettings ResetHelp(this AzureAcrDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcrDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrDeleteSettings SetOutput(this AzureAcrDeleteSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrDeleteSettings ResetOutput(this AzureAcrDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcrDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrDeleteSettings SetQuery(this AzureAcrDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrDeleteSettings ResetQuery(this AzureAcrDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcrDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrDeleteSettings SetVerbose(this AzureAcrDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrDeleteSettings ResetVerbose(this AzureAcrDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcrListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcrListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAcrListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrListSettings SetResourceGroup(this AzureAcrListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrListSettings ResetResourceGroup(this AzureAcrListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcrListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrListSettings SetDebug(this AzureAcrListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrListSettings ResetDebug(this AzureAcrListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcrListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrListSettings SetHelp(this AzureAcrListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrListSettings ResetHelp(this AzureAcrListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcrListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrListSettings SetOutput(this AzureAcrListSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrListSettings ResetOutput(this AzureAcrListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcrListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrListSettings SetQuery(this AzureAcrListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrListSettings ResetQuery(this AzureAcrListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcrListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrListSettings SetVerbose(this AzureAcrListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrListSettings ResetVerbose(this AzureAcrListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcrLoginSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcrLoginSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAcrLoginSettings.Name"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrLoginSettings SetName(this AzureAcrLoginSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrLoginSettings.Name"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrLoginSettings ResetName(this AzureAcrLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Password
        /// <summary><p><em>Sets <see cref="AzureAcrLoginSettings.Password"/>.</em></p><p>The password used to log into a container registry.</p></summary>
        [Pure]
        public static AzureAcrLoginSettings SetPassword(this AzureAcrLoginSettings toolSettings, string password)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = password;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrLoginSettings.Password"/>.</em></p><p>The password used to log into a container registry.</p></summary>
        [Pure]
        public static AzureAcrLoginSettings ResetPassword(this AzureAcrLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAcrLoginSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrLoginSettings SetResourceGroup(this AzureAcrLoginSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrLoginSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrLoginSettings ResetResourceGroup(this AzureAcrLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Username
        /// <summary><p><em>Sets <see cref="AzureAcrLoginSettings.Username"/>.</em></p><p>The username used to log into a container registry.</p></summary>
        [Pure]
        public static AzureAcrLoginSettings SetUsername(this AzureAcrLoginSettings toolSettings, string username)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Username = username;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrLoginSettings.Username"/>.</em></p><p>The username used to log into a container registry.</p></summary>
        [Pure]
        public static AzureAcrLoginSettings ResetUsername(this AzureAcrLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Username = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcrLoginSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrLoginSettings SetDebug(this AzureAcrLoginSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrLoginSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrLoginSettings ResetDebug(this AzureAcrLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcrLoginSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrLoginSettings SetHelp(this AzureAcrLoginSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrLoginSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrLoginSettings ResetHelp(this AzureAcrLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcrLoginSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrLoginSettings SetOutput(this AzureAcrLoginSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrLoginSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrLoginSettings ResetOutput(this AzureAcrLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcrLoginSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrLoginSettings SetQuery(this AzureAcrLoginSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrLoginSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrLoginSettings ResetQuery(this AzureAcrLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcrLoginSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrLoginSettings SetVerbose(this AzureAcrLoginSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrLoginSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrLoginSettings ResetVerbose(this AzureAcrLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcrShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcrShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAcrShowSettings.Name"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrShowSettings SetName(this AzureAcrShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrShowSettings.Name"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrShowSettings ResetName(this AzureAcrShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAcrShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrShowSettings SetResourceGroup(this AzureAcrShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrShowSettings ResetResourceGroup(this AzureAcrShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcrShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrShowSettings SetDebug(this AzureAcrShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrShowSettings ResetDebug(this AzureAcrShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcrShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrShowSettings SetHelp(this AzureAcrShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrShowSettings ResetHelp(this AzureAcrShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcrShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrShowSettings SetOutput(this AzureAcrShowSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrShowSettings ResetOutput(this AzureAcrShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcrShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrShowSettings SetQuery(this AzureAcrShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrShowSettings ResetQuery(this AzureAcrShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcrShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrShowSettings SetVerbose(this AzureAcrShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrShowSettings ResetVerbose(this AzureAcrShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcrShowUsageSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcrShowUsageSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAcrShowUsageSettings.Name"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrShowUsageSettings SetName(this AzureAcrShowUsageSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrShowUsageSettings.Name"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrShowUsageSettings ResetName(this AzureAcrShowUsageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAcrShowUsageSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrShowUsageSettings SetResourceGroup(this AzureAcrShowUsageSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrShowUsageSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrShowUsageSettings ResetResourceGroup(this AzureAcrShowUsageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcrShowUsageSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrShowUsageSettings SetDebug(this AzureAcrShowUsageSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrShowUsageSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrShowUsageSettings ResetDebug(this AzureAcrShowUsageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcrShowUsageSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrShowUsageSettings SetHelp(this AzureAcrShowUsageSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrShowUsageSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrShowUsageSettings ResetHelp(this AzureAcrShowUsageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcrShowUsageSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrShowUsageSettings SetOutput(this AzureAcrShowUsageSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrShowUsageSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrShowUsageSettings ResetOutput(this AzureAcrShowUsageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcrShowUsageSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrShowUsageSettings SetQuery(this AzureAcrShowUsageSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrShowUsageSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrShowUsageSettings ResetQuery(this AzureAcrShowUsageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcrShowUsageSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrShowUsageSettings SetVerbose(this AzureAcrShowUsageSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrShowUsageSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrShowUsageSettings ResetVerbose(this AzureAcrShowUsageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcrUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcrUpdateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAcrUpdateSettings.Name"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrUpdateSettings SetName(this AzureAcrUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrUpdateSettings.Name"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrUpdateSettings ResetName(this AzureAcrUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region AdminEnabled
        /// <summary><p><em>Sets <see cref="AzureAcrUpdateSettings.AdminEnabled"/>.</em></p><p>Indicates whether the admin user is enabled.</p></summary>
        [Pure]
        public static AzureAcrUpdateSettings SetAdminEnabled(this AzureAcrUpdateSettings toolSettings, bool? adminEnabled)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdminEnabled = adminEnabled;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrUpdateSettings.AdminEnabled"/>.</em></p><p>Indicates whether the admin user is enabled.</p></summary>
        [Pure]
        public static AzureAcrUpdateSettings ResetAdminEnabled(this AzureAcrUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdminEnabled = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureAcrUpdateSettings.AdminEnabled"/>.</em></p><p>Indicates whether the admin user is enabled.</p></summary>
        [Pure]
        public static AzureAcrUpdateSettings EnableAdminEnabled(this AzureAcrUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdminEnabled = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureAcrUpdateSettings.AdminEnabled"/>.</em></p><p>Indicates whether the admin user is enabled.</p></summary>
        [Pure]
        public static AzureAcrUpdateSettings DisableAdminEnabled(this AzureAcrUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdminEnabled = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureAcrUpdateSettings.AdminEnabled"/>.</em></p><p>Indicates whether the admin user is enabled.</p></summary>
        [Pure]
        public static AzureAcrUpdateSettings ToggleAdminEnabled(this AzureAcrUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdminEnabled = !toolSettings.AdminEnabled;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAcrUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrUpdateSettings SetResourceGroup(this AzureAcrUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrUpdateSettings ResetResourceGroup(this AzureAcrUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Sku
        /// <summary><p><em>Sets <see cref="AzureAcrUpdateSettings.Sku"/>.</em></p><p>The SKU of the container registry.</p></summary>
        [Pure]
        public static AzureAcrUpdateSettings SetSku(this AzureAcrUpdateSettings toolSettings, AcrSku sku)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = sku;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrUpdateSettings.Sku"/>.</em></p><p>The SKU of the container registry.</p></summary>
        [Pure]
        public static AzureAcrUpdateSettings ResetSku(this AzureAcrUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = null;
            return toolSettings;
        }
        #endregion
        #region StorageAccountName
        /// <summary><p><em>Sets <see cref="AzureAcrUpdateSettings.StorageAccountName"/>.</em></p><p>Provide the name of an existing storage account if you're recreating a container registry over a previous registry created storage account. Only applicable to Classic SKU.</p></summary>
        [Pure]
        public static AzureAcrUpdateSettings SetStorageAccountName(this AzureAcrUpdateSettings toolSettings, string storageAccountName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageAccountName = storageAccountName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrUpdateSettings.StorageAccountName"/>.</em></p><p>Provide the name of an existing storage account if you're recreating a container registry over a previous registry created storage account. Only applicable to Classic SKU.</p></summary>
        [Pure]
        public static AzureAcrUpdateSettings ResetStorageAccountName(this AzureAcrUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageAccountName = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary><p><em>Sets <see cref="AzureAcrUpdateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureAcrUpdateSettings SetTags(this AzureAcrUpdateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrUpdateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureAcrUpdateSettings ResetTags(this AzureAcrUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary><p><em>Sets <see cref="AzureAcrUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureAcrUpdateSettings SetAdd(this AzureAcrUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureAcrUpdateSettings ResetAdd(this AzureAcrUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary><p><em>Sets <see cref="AzureAcrUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureAcrUpdateSettings SetRemove(this AzureAcrUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureAcrUpdateSettings ResetRemove(this AzureAcrUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary><p><em>Sets <see cref="AzureAcrUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureAcrUpdateSettings SetSet(this AzureAcrUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureAcrUpdateSettings ResetSet(this AzureAcrUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcrUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrUpdateSettings SetDebug(this AzureAcrUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrUpdateSettings ResetDebug(this AzureAcrUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcrUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrUpdateSettings SetHelp(this AzureAcrUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrUpdateSettings ResetHelp(this AzureAcrUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcrUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrUpdateSettings SetOutput(this AzureAcrUpdateSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrUpdateSettings ResetOutput(this AzureAcrUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcrUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrUpdateSettings SetQuery(this AzureAcrUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrUpdateSettings ResetQuery(this AzureAcrUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcrUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrUpdateSettings SetVerbose(this AzureAcrUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrUpdateSettings ResetVerbose(this AzureAcrUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcrCredentialRenewSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcrCredentialRenewSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAcrCredentialRenewSettings.Name"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrCredentialRenewSettings SetName(this AzureAcrCredentialRenewSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrCredentialRenewSettings.Name"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrCredentialRenewSettings ResetName(this AzureAcrCredentialRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region PasswordName
        /// <summary><p><em>Sets <see cref="AzureAcrCredentialRenewSettings.PasswordName"/>.</em></p><p>The name of password to regenerate.</p></summary>
        [Pure]
        public static AzureAcrCredentialRenewSettings SetPasswordName(this AzureAcrCredentialRenewSettings toolSettings, AcrCredentialRenewPasswordName passwordName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PasswordName = passwordName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrCredentialRenewSettings.PasswordName"/>.</em></p><p>The name of password to regenerate.</p></summary>
        [Pure]
        public static AzureAcrCredentialRenewSettings ResetPasswordName(this AzureAcrCredentialRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PasswordName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAcrCredentialRenewSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrCredentialRenewSettings SetResourceGroup(this AzureAcrCredentialRenewSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrCredentialRenewSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrCredentialRenewSettings ResetResourceGroup(this AzureAcrCredentialRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcrCredentialRenewSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrCredentialRenewSettings SetDebug(this AzureAcrCredentialRenewSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrCredentialRenewSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrCredentialRenewSettings ResetDebug(this AzureAcrCredentialRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcrCredentialRenewSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrCredentialRenewSettings SetHelp(this AzureAcrCredentialRenewSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrCredentialRenewSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrCredentialRenewSettings ResetHelp(this AzureAcrCredentialRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcrCredentialRenewSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrCredentialRenewSettings SetOutput(this AzureAcrCredentialRenewSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrCredentialRenewSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrCredentialRenewSettings ResetOutput(this AzureAcrCredentialRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcrCredentialRenewSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrCredentialRenewSettings SetQuery(this AzureAcrCredentialRenewSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrCredentialRenewSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrCredentialRenewSettings ResetQuery(this AzureAcrCredentialRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcrCredentialRenewSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrCredentialRenewSettings SetVerbose(this AzureAcrCredentialRenewSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrCredentialRenewSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrCredentialRenewSettings ResetVerbose(this AzureAcrCredentialRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcrCredentialShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcrCredentialShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAcrCredentialShowSettings.Name"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrCredentialShowSettings SetName(this AzureAcrCredentialShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrCredentialShowSettings.Name"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrCredentialShowSettings ResetName(this AzureAcrCredentialShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAcrCredentialShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrCredentialShowSettings SetResourceGroup(this AzureAcrCredentialShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrCredentialShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrCredentialShowSettings ResetResourceGroup(this AzureAcrCredentialShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcrCredentialShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrCredentialShowSettings SetDebug(this AzureAcrCredentialShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrCredentialShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrCredentialShowSettings ResetDebug(this AzureAcrCredentialShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcrCredentialShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrCredentialShowSettings SetHelp(this AzureAcrCredentialShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrCredentialShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrCredentialShowSettings ResetHelp(this AzureAcrCredentialShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcrCredentialShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrCredentialShowSettings SetOutput(this AzureAcrCredentialShowSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrCredentialShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrCredentialShowSettings ResetOutput(this AzureAcrCredentialShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcrCredentialShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrCredentialShowSettings SetQuery(this AzureAcrCredentialShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrCredentialShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrCredentialShowSettings ResetQuery(this AzureAcrCredentialShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcrCredentialShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrCredentialShowSettings SetVerbose(this AzureAcrCredentialShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrCredentialShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrCredentialShowSettings ResetVerbose(this AzureAcrCredentialShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcrReplicationCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcrReplicationCreateSettingsExtensions
    {
        #region Location
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationCreateSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrReplicationCreateSettings SetLocation(this AzureAcrReplicationCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationCreateSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrReplicationCreateSettings ResetLocation(this AzureAcrReplicationCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region Registry
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationCreateSettings.Registry"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrReplicationCreateSettings SetRegistry(this AzureAcrReplicationCreateSettings toolSettings, string registry)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Registry = registry;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationCreateSettings.Registry"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrReplicationCreateSettings ResetRegistry(this AzureAcrReplicationCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Registry = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationCreateSettings.Name"/>.</em></p><p>The name of the replication. Default to the location name.</p></summary>
        [Pure]
        public static AzureAcrReplicationCreateSettings SetName(this AzureAcrReplicationCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationCreateSettings.Name"/>.</em></p><p>The name of the replication. Default to the location name.</p></summary>
        [Pure]
        public static AzureAcrReplicationCreateSettings ResetName(this AzureAcrReplicationCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrReplicationCreateSettings SetResourceGroup(this AzureAcrReplicationCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrReplicationCreateSettings ResetResourceGroup(this AzureAcrReplicationCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationCreateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureAcrReplicationCreateSettings SetTags(this AzureAcrReplicationCreateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationCreateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureAcrReplicationCreateSettings ResetTags(this AzureAcrReplicationCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrReplicationCreateSettings SetDebug(this AzureAcrReplicationCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrReplicationCreateSettings ResetDebug(this AzureAcrReplicationCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrReplicationCreateSettings SetHelp(this AzureAcrReplicationCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrReplicationCreateSettings ResetHelp(this AzureAcrReplicationCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrReplicationCreateSettings SetOutput(this AzureAcrReplicationCreateSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrReplicationCreateSettings ResetOutput(this AzureAcrReplicationCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrReplicationCreateSettings SetQuery(this AzureAcrReplicationCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrReplicationCreateSettings ResetQuery(this AzureAcrReplicationCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrReplicationCreateSettings SetVerbose(this AzureAcrReplicationCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrReplicationCreateSettings ResetVerbose(this AzureAcrReplicationCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcrReplicationDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcrReplicationDeleteSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationDeleteSettings.Name"/>.</em></p><p>The name of the replication.</p></summary>
        [Pure]
        public static AzureAcrReplicationDeleteSettings SetName(this AzureAcrReplicationDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationDeleteSettings.Name"/>.</em></p><p>The name of the replication.</p></summary>
        [Pure]
        public static AzureAcrReplicationDeleteSettings ResetName(this AzureAcrReplicationDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Registry
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationDeleteSettings.Registry"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrReplicationDeleteSettings SetRegistry(this AzureAcrReplicationDeleteSettings toolSettings, string registry)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Registry = registry;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationDeleteSettings.Registry"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrReplicationDeleteSettings ResetRegistry(this AzureAcrReplicationDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Registry = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrReplicationDeleteSettings SetResourceGroup(this AzureAcrReplicationDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrReplicationDeleteSettings ResetResourceGroup(this AzureAcrReplicationDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrReplicationDeleteSettings SetDebug(this AzureAcrReplicationDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrReplicationDeleteSettings ResetDebug(this AzureAcrReplicationDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrReplicationDeleteSettings SetHelp(this AzureAcrReplicationDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrReplicationDeleteSettings ResetHelp(this AzureAcrReplicationDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrReplicationDeleteSettings SetOutput(this AzureAcrReplicationDeleteSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrReplicationDeleteSettings ResetOutput(this AzureAcrReplicationDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrReplicationDeleteSettings SetQuery(this AzureAcrReplicationDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrReplicationDeleteSettings ResetQuery(this AzureAcrReplicationDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrReplicationDeleteSettings SetVerbose(this AzureAcrReplicationDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrReplicationDeleteSettings ResetVerbose(this AzureAcrReplicationDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcrReplicationListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcrReplicationListSettingsExtensions
    {
        #region Registry
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationListSettings.Registry"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrReplicationListSettings SetRegistry(this AzureAcrReplicationListSettings toolSettings, string registry)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Registry = registry;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationListSettings.Registry"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrReplicationListSettings ResetRegistry(this AzureAcrReplicationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Registry = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrReplicationListSettings SetResourceGroup(this AzureAcrReplicationListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrReplicationListSettings ResetResourceGroup(this AzureAcrReplicationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrReplicationListSettings SetDebug(this AzureAcrReplicationListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrReplicationListSettings ResetDebug(this AzureAcrReplicationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrReplicationListSettings SetHelp(this AzureAcrReplicationListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrReplicationListSettings ResetHelp(this AzureAcrReplicationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrReplicationListSettings SetOutput(this AzureAcrReplicationListSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrReplicationListSettings ResetOutput(this AzureAcrReplicationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrReplicationListSettings SetQuery(this AzureAcrReplicationListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrReplicationListSettings ResetQuery(this AzureAcrReplicationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrReplicationListSettings SetVerbose(this AzureAcrReplicationListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrReplicationListSettings ResetVerbose(this AzureAcrReplicationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcrReplicationShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcrReplicationShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationShowSettings.Name"/>.</em></p><p>The name of the replication.</p></summary>
        [Pure]
        public static AzureAcrReplicationShowSettings SetName(this AzureAcrReplicationShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationShowSettings.Name"/>.</em></p><p>The name of the replication.</p></summary>
        [Pure]
        public static AzureAcrReplicationShowSettings ResetName(this AzureAcrReplicationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Registry
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationShowSettings.Registry"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrReplicationShowSettings SetRegistry(this AzureAcrReplicationShowSettings toolSettings, string registry)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Registry = registry;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationShowSettings.Registry"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrReplicationShowSettings ResetRegistry(this AzureAcrReplicationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Registry = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrReplicationShowSettings SetResourceGroup(this AzureAcrReplicationShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrReplicationShowSettings ResetResourceGroup(this AzureAcrReplicationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrReplicationShowSettings SetDebug(this AzureAcrReplicationShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrReplicationShowSettings ResetDebug(this AzureAcrReplicationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrReplicationShowSettings SetHelp(this AzureAcrReplicationShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrReplicationShowSettings ResetHelp(this AzureAcrReplicationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrReplicationShowSettings SetOutput(this AzureAcrReplicationShowSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrReplicationShowSettings ResetOutput(this AzureAcrReplicationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrReplicationShowSettings SetQuery(this AzureAcrReplicationShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrReplicationShowSettings ResetQuery(this AzureAcrReplicationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrReplicationShowSettings SetVerbose(this AzureAcrReplicationShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrReplicationShowSettings ResetVerbose(this AzureAcrReplicationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcrReplicationUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcrReplicationUpdateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationUpdateSettings.Name"/>.</em></p><p>The name of the replication.</p></summary>
        [Pure]
        public static AzureAcrReplicationUpdateSettings SetName(this AzureAcrReplicationUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationUpdateSettings.Name"/>.</em></p><p>The name of the replication.</p></summary>
        [Pure]
        public static AzureAcrReplicationUpdateSettings ResetName(this AzureAcrReplicationUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Registry
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationUpdateSettings.Registry"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrReplicationUpdateSettings SetRegistry(this AzureAcrReplicationUpdateSettings toolSettings, string registry)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Registry = registry;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationUpdateSettings.Registry"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrReplicationUpdateSettings ResetRegistry(this AzureAcrReplicationUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Registry = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrReplicationUpdateSettings SetResourceGroup(this AzureAcrReplicationUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrReplicationUpdateSettings ResetResourceGroup(this AzureAcrReplicationUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationUpdateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureAcrReplicationUpdateSettings SetTags(this AzureAcrReplicationUpdateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationUpdateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureAcrReplicationUpdateSettings ResetTags(this AzureAcrReplicationUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureAcrReplicationUpdateSettings SetAdd(this AzureAcrReplicationUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureAcrReplicationUpdateSettings ResetAdd(this AzureAcrReplicationUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureAcrReplicationUpdateSettings SetRemove(this AzureAcrReplicationUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureAcrReplicationUpdateSettings ResetRemove(this AzureAcrReplicationUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureAcrReplicationUpdateSettings SetSet(this AzureAcrReplicationUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureAcrReplicationUpdateSettings ResetSet(this AzureAcrReplicationUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrReplicationUpdateSettings SetDebug(this AzureAcrReplicationUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrReplicationUpdateSettings ResetDebug(this AzureAcrReplicationUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrReplicationUpdateSettings SetHelp(this AzureAcrReplicationUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrReplicationUpdateSettings ResetHelp(this AzureAcrReplicationUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrReplicationUpdateSettings SetOutput(this AzureAcrReplicationUpdateSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrReplicationUpdateSettings ResetOutput(this AzureAcrReplicationUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrReplicationUpdateSettings SetQuery(this AzureAcrReplicationUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrReplicationUpdateSettings ResetQuery(this AzureAcrReplicationUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcrReplicationUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrReplicationUpdateSettings SetVerbose(this AzureAcrReplicationUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrReplicationUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrReplicationUpdateSettings ResetVerbose(this AzureAcrReplicationUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcrRepositoryDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcrRepositoryDeleteSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryDeleteSettings.Name"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrRepositoryDeleteSettings SetName(this AzureAcrRepositoryDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryDeleteSettings.Name"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrRepositoryDeleteSettings ResetName(this AzureAcrRepositoryDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Image
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryDeleteSettings.Image"/>.</em></p><p>The name of the image to delete. May include a tag in the format 'name:tag' or digest in the format 'name@digest'.</p></summary>
        [Pure]
        public static AzureAcrRepositoryDeleteSettings SetImage(this AzureAcrRepositoryDeleteSettings toolSettings, string image)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Image = image;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryDeleteSettings.Image"/>.</em></p><p>The name of the image to delete. May include a tag in the format 'name:tag' or digest in the format 'name@digest'.</p></summary>
        [Pure]
        public static AzureAcrRepositoryDeleteSettings ResetImage(this AzureAcrRepositoryDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Image = null;
            return toolSettings;
        }
        #endregion
        #region Password
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryDeleteSettings.Password"/>.</em></p><p>The password used to log into a container registry.</p></summary>
        [Pure]
        public static AzureAcrRepositoryDeleteSettings SetPassword(this AzureAcrRepositoryDeleteSettings toolSettings, string password)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = password;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryDeleteSettings.Password"/>.</em></p><p>The password used to log into a container registry.</p></summary>
        [Pure]
        public static AzureAcrRepositoryDeleteSettings ResetPassword(this AzureAcrRepositoryDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = null;
            return toolSettings;
        }
        #endregion
        #region Repository
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryDeleteSettings.Repository"/>.</em></p><p>The name of the repository to delete.</p></summary>
        [Pure]
        public static AzureAcrRepositoryDeleteSettings SetRepository(this AzureAcrRepositoryDeleteSettings toolSettings, string repository)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Repository = repository;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryDeleteSettings.Repository"/>.</em></p><p>The name of the repository to delete.</p></summary>
        [Pure]
        public static AzureAcrRepositoryDeleteSettings ResetRepository(this AzureAcrRepositoryDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Repository = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrRepositoryDeleteSettings SetResourceGroup(this AzureAcrRepositoryDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrRepositoryDeleteSettings ResetResourceGroup(this AzureAcrRepositoryDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Username
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryDeleteSettings.Username"/>.</em></p><p>The username used to log into a container registry.</p></summary>
        [Pure]
        public static AzureAcrRepositoryDeleteSettings SetUsername(this AzureAcrRepositoryDeleteSettings toolSettings, string username)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Username = username;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryDeleteSettings.Username"/>.</em></p><p>The username used to log into a container registry.</p></summary>
        [Pure]
        public static AzureAcrRepositoryDeleteSettings ResetUsername(this AzureAcrRepositoryDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Username = null;
            return toolSettings;
        }
        #endregion
        #region Yes
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryDeleteSettings.Yes"/>.</em></p><p>Do not prompt for confirmation.</p></summary>
        [Pure]
        public static AzureAcrRepositoryDeleteSettings SetYes(this AzureAcrRepositoryDeleteSettings toolSettings, string yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryDeleteSettings.Yes"/>.</em></p><p>Do not prompt for confirmation.</p></summary>
        [Pure]
        public static AzureAcrRepositoryDeleteSettings ResetYes(this AzureAcrRepositoryDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrRepositoryDeleteSettings SetDebug(this AzureAcrRepositoryDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrRepositoryDeleteSettings ResetDebug(this AzureAcrRepositoryDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrRepositoryDeleteSettings SetHelp(this AzureAcrRepositoryDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrRepositoryDeleteSettings ResetHelp(this AzureAcrRepositoryDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrRepositoryDeleteSettings SetOutput(this AzureAcrRepositoryDeleteSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrRepositoryDeleteSettings ResetOutput(this AzureAcrRepositoryDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrRepositoryDeleteSettings SetQuery(this AzureAcrRepositoryDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrRepositoryDeleteSettings ResetQuery(this AzureAcrRepositoryDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrRepositoryDeleteSettings SetVerbose(this AzureAcrRepositoryDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrRepositoryDeleteSettings ResetVerbose(this AzureAcrRepositoryDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcrRepositoryListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcrRepositoryListSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryListSettings.Name"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrRepositoryListSettings SetName(this AzureAcrRepositoryListSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryListSettings.Name"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrRepositoryListSettings ResetName(this AzureAcrRepositoryListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Password
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryListSettings.Password"/>.</em></p><p>The password used to log into a container registry.</p></summary>
        [Pure]
        public static AzureAcrRepositoryListSettings SetPassword(this AzureAcrRepositoryListSettings toolSettings, string password)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = password;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryListSettings.Password"/>.</em></p><p>The password used to log into a container registry.</p></summary>
        [Pure]
        public static AzureAcrRepositoryListSettings ResetPassword(this AzureAcrRepositoryListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrRepositoryListSettings SetResourceGroup(this AzureAcrRepositoryListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrRepositoryListSettings ResetResourceGroup(this AzureAcrRepositoryListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Username
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryListSettings.Username"/>.</em></p><p>The username used to log into a container registry.</p></summary>
        [Pure]
        public static AzureAcrRepositoryListSettings SetUsername(this AzureAcrRepositoryListSettings toolSettings, string username)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Username = username;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryListSettings.Username"/>.</em></p><p>The username used to log into a container registry.</p></summary>
        [Pure]
        public static AzureAcrRepositoryListSettings ResetUsername(this AzureAcrRepositoryListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Username = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrRepositoryListSettings SetDebug(this AzureAcrRepositoryListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrRepositoryListSettings ResetDebug(this AzureAcrRepositoryListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrRepositoryListSettings SetHelp(this AzureAcrRepositoryListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrRepositoryListSettings ResetHelp(this AzureAcrRepositoryListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrRepositoryListSettings SetOutput(this AzureAcrRepositoryListSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrRepositoryListSettings ResetOutput(this AzureAcrRepositoryListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrRepositoryListSettings SetQuery(this AzureAcrRepositoryListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrRepositoryListSettings ResetQuery(this AzureAcrRepositoryListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrRepositoryListSettings SetVerbose(this AzureAcrRepositoryListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrRepositoryListSettings ResetVerbose(this AzureAcrRepositoryListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcrRepositoryShowManifestsSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcrRepositoryShowManifestsSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryShowManifestsSettings.Name"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowManifestsSettings SetName(this AzureAcrRepositoryShowManifestsSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryShowManifestsSettings.Name"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowManifestsSettings ResetName(this AzureAcrRepositoryShowManifestsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Repository
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryShowManifestsSettings.Repository"/>.</em></p><p>The repository to obtain manifests from.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowManifestsSettings SetRepository(this AzureAcrRepositoryShowManifestsSettings toolSettings, string repository)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Repository = repository;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryShowManifestsSettings.Repository"/>.</em></p><p>The repository to obtain manifests from.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowManifestsSettings ResetRepository(this AzureAcrRepositoryShowManifestsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Repository = null;
            return toolSettings;
        }
        #endregion
        #region Password
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryShowManifestsSettings.Password"/>.</em></p><p>The password used to log into a container registry.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowManifestsSettings SetPassword(this AzureAcrRepositoryShowManifestsSettings toolSettings, string password)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = password;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryShowManifestsSettings.Password"/>.</em></p><p>The password used to log into a container registry.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowManifestsSettings ResetPassword(this AzureAcrRepositoryShowManifestsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryShowManifestsSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowManifestsSettings SetResourceGroup(this AzureAcrRepositoryShowManifestsSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryShowManifestsSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowManifestsSettings ResetResourceGroup(this AzureAcrRepositoryShowManifestsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Username
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryShowManifestsSettings.Username"/>.</em></p><p>The username used to log into a container registry.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowManifestsSettings SetUsername(this AzureAcrRepositoryShowManifestsSettings toolSettings, string username)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Username = username;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryShowManifestsSettings.Username"/>.</em></p><p>The username used to log into a container registry.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowManifestsSettings ResetUsername(this AzureAcrRepositoryShowManifestsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Username = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryShowManifestsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowManifestsSettings SetDebug(this AzureAcrRepositoryShowManifestsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryShowManifestsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowManifestsSettings ResetDebug(this AzureAcrRepositoryShowManifestsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryShowManifestsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowManifestsSettings SetHelp(this AzureAcrRepositoryShowManifestsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryShowManifestsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowManifestsSettings ResetHelp(this AzureAcrRepositoryShowManifestsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryShowManifestsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowManifestsSettings SetOutput(this AzureAcrRepositoryShowManifestsSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryShowManifestsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowManifestsSettings ResetOutput(this AzureAcrRepositoryShowManifestsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryShowManifestsSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowManifestsSettings SetQuery(this AzureAcrRepositoryShowManifestsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryShowManifestsSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowManifestsSettings ResetQuery(this AzureAcrRepositoryShowManifestsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryShowManifestsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowManifestsSettings SetVerbose(this AzureAcrRepositoryShowManifestsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryShowManifestsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowManifestsSettings ResetVerbose(this AzureAcrRepositoryShowManifestsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcrRepositoryShowTagsSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcrRepositoryShowTagsSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryShowTagsSettings.Name"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowTagsSettings SetName(this AzureAcrRepositoryShowTagsSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryShowTagsSettings.Name"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowTagsSettings ResetName(this AzureAcrRepositoryShowTagsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Repository
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryShowTagsSettings.Repository"/>.</em></p><p>The repository to obtain tags from.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowTagsSettings SetRepository(this AzureAcrRepositoryShowTagsSettings toolSettings, string repository)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Repository = repository;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryShowTagsSettings.Repository"/>.</em></p><p>The repository to obtain tags from.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowTagsSettings ResetRepository(this AzureAcrRepositoryShowTagsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Repository = null;
            return toolSettings;
        }
        #endregion
        #region Password
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryShowTagsSettings.Password"/>.</em></p><p>The password used to log into a container registry.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowTagsSettings SetPassword(this AzureAcrRepositoryShowTagsSettings toolSettings, string password)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = password;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryShowTagsSettings.Password"/>.</em></p><p>The password used to log into a container registry.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowTagsSettings ResetPassword(this AzureAcrRepositoryShowTagsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryShowTagsSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowTagsSettings SetResourceGroup(this AzureAcrRepositoryShowTagsSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryShowTagsSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowTagsSettings ResetResourceGroup(this AzureAcrRepositoryShowTagsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Username
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryShowTagsSettings.Username"/>.</em></p><p>The username used to log into a container registry.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowTagsSettings SetUsername(this AzureAcrRepositoryShowTagsSettings toolSettings, string username)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Username = username;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryShowTagsSettings.Username"/>.</em></p><p>The username used to log into a container registry.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowTagsSettings ResetUsername(this AzureAcrRepositoryShowTagsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Username = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryShowTagsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowTagsSettings SetDebug(this AzureAcrRepositoryShowTagsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryShowTagsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowTagsSettings ResetDebug(this AzureAcrRepositoryShowTagsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryShowTagsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowTagsSettings SetHelp(this AzureAcrRepositoryShowTagsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryShowTagsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowTagsSettings ResetHelp(this AzureAcrRepositoryShowTagsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryShowTagsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowTagsSettings SetOutput(this AzureAcrRepositoryShowTagsSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryShowTagsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowTagsSettings ResetOutput(this AzureAcrRepositoryShowTagsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryShowTagsSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowTagsSettings SetQuery(this AzureAcrRepositoryShowTagsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryShowTagsSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowTagsSettings ResetQuery(this AzureAcrRepositoryShowTagsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryShowTagsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowTagsSettings SetVerbose(this AzureAcrRepositoryShowTagsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryShowTagsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrRepositoryShowTagsSettings ResetVerbose(this AzureAcrRepositoryShowTagsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcrRepositoryUntagSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcrRepositoryUntagSettingsExtensions
    {
        #region Image
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryUntagSettings.Image"/>.</em></p><p>The name of the image to untag. May include a tag in the format 'name:tag'.</p></summary>
        [Pure]
        public static AzureAcrRepositoryUntagSettings SetImage(this AzureAcrRepositoryUntagSettings toolSettings, string image)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Image = image;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryUntagSettings.Image"/>.</em></p><p>The name of the image to untag. May include a tag in the format 'name:tag'.</p></summary>
        [Pure]
        public static AzureAcrRepositoryUntagSettings ResetImage(this AzureAcrRepositoryUntagSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Image = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryUntagSettings.Name"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrRepositoryUntagSettings SetName(this AzureAcrRepositoryUntagSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryUntagSettings.Name"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrRepositoryUntagSettings ResetName(this AzureAcrRepositoryUntagSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Password
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryUntagSettings.Password"/>.</em></p><p>The password used to log into a container registry.</p></summary>
        [Pure]
        public static AzureAcrRepositoryUntagSettings SetPassword(this AzureAcrRepositoryUntagSettings toolSettings, string password)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = password;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryUntagSettings.Password"/>.</em></p><p>The password used to log into a container registry.</p></summary>
        [Pure]
        public static AzureAcrRepositoryUntagSettings ResetPassword(this AzureAcrRepositoryUntagSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryUntagSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrRepositoryUntagSettings SetResourceGroup(this AzureAcrRepositoryUntagSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryUntagSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrRepositoryUntagSettings ResetResourceGroup(this AzureAcrRepositoryUntagSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Username
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryUntagSettings.Username"/>.</em></p><p>The username used to log into a container registry.</p></summary>
        [Pure]
        public static AzureAcrRepositoryUntagSettings SetUsername(this AzureAcrRepositoryUntagSettings toolSettings, string username)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Username = username;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryUntagSettings.Username"/>.</em></p><p>The username used to log into a container registry.</p></summary>
        [Pure]
        public static AzureAcrRepositoryUntagSettings ResetUsername(this AzureAcrRepositoryUntagSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Username = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryUntagSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrRepositoryUntagSettings SetDebug(this AzureAcrRepositoryUntagSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryUntagSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrRepositoryUntagSettings ResetDebug(this AzureAcrRepositoryUntagSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryUntagSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrRepositoryUntagSettings SetHelp(this AzureAcrRepositoryUntagSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryUntagSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrRepositoryUntagSettings ResetHelp(this AzureAcrRepositoryUntagSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryUntagSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrRepositoryUntagSettings SetOutput(this AzureAcrRepositoryUntagSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryUntagSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrRepositoryUntagSettings ResetOutput(this AzureAcrRepositoryUntagSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryUntagSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrRepositoryUntagSettings SetQuery(this AzureAcrRepositoryUntagSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryUntagSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrRepositoryUntagSettings ResetQuery(this AzureAcrRepositoryUntagSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcrRepositoryUntagSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrRepositoryUntagSettings SetVerbose(this AzureAcrRepositoryUntagSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrRepositoryUntagSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrRepositoryUntagSettings ResetVerbose(this AzureAcrRepositoryUntagSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcrWebhookCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcrWebhookCreateSettingsExtensions
    {
        #region Actions
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookCreateSettings.Actions"/> to a new list.</em></p><p>Space-separated list of actions that trigger the webhook to post notifications.</p></summary>
        [Pure]
        public static AzureAcrWebhookCreateSettings SetActions(this AzureAcrWebhookCreateSettings toolSettings, params AcrWebhookActions[] actions)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ActionsInternal = actions.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookCreateSettings.Actions"/> to a new list.</em></p><p>Space-separated list of actions that trigger the webhook to post notifications.</p></summary>
        [Pure]
        public static AzureAcrWebhookCreateSettings SetActions(this AzureAcrWebhookCreateSettings toolSettings, IEnumerable<AcrWebhookActions> actions)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ActionsInternal = actions.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureAcrWebhookCreateSettings.Actions"/>.</em></p><p>Space-separated list of actions that trigger the webhook to post notifications.</p></summary>
        [Pure]
        public static AzureAcrWebhookCreateSettings AddActions(this AzureAcrWebhookCreateSettings toolSettings, params AcrWebhookActions[] actions)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ActionsInternal.AddRange(actions);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureAcrWebhookCreateSettings.Actions"/>.</em></p><p>Space-separated list of actions that trigger the webhook to post notifications.</p></summary>
        [Pure]
        public static AzureAcrWebhookCreateSettings AddActions(this AzureAcrWebhookCreateSettings toolSettings, IEnumerable<AcrWebhookActions> actions)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ActionsInternal.AddRange(actions);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureAcrWebhookCreateSettings.Actions"/>.</em></p><p>Space-separated list of actions that trigger the webhook to post notifications.</p></summary>
        [Pure]
        public static AzureAcrWebhookCreateSettings ClearActions(this AzureAcrWebhookCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ActionsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureAcrWebhookCreateSettings.Actions"/>.</em></p><p>Space-separated list of actions that trigger the webhook to post notifications.</p></summary>
        [Pure]
        public static AzureAcrWebhookCreateSettings RemoveActions(this AzureAcrWebhookCreateSettings toolSettings, params AcrWebhookActions[] actions)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<AcrWebhookActions>(actions);
            toolSettings.ActionsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureAcrWebhookCreateSettings.Actions"/>.</em></p><p>Space-separated list of actions that trigger the webhook to post notifications.</p></summary>
        [Pure]
        public static AzureAcrWebhookCreateSettings RemoveActions(this AzureAcrWebhookCreateSettings toolSettings, IEnumerable<AcrWebhookActions> actions)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<AcrWebhookActions>(actions);
            toolSettings.ActionsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookCreateSettings.Name"/>.</em></p><p>The name of the webhook.</p></summary>
        [Pure]
        public static AzureAcrWebhookCreateSettings SetName(this AzureAcrWebhookCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookCreateSettings.Name"/>.</em></p><p>The name of the webhook.</p></summary>
        [Pure]
        public static AzureAcrWebhookCreateSettings ResetName(this AzureAcrWebhookCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Registry
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookCreateSettings.Registry"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrWebhookCreateSettings SetRegistry(this AzureAcrWebhookCreateSettings toolSettings, string registry)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Registry = registry;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookCreateSettings.Registry"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrWebhookCreateSettings ResetRegistry(this AzureAcrWebhookCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Registry = null;
            return toolSettings;
        }
        #endregion
        #region Uri
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookCreateSettings.Uri"/>.</em></p><p>The service URI for the webhook to post notifications.</p></summary>
        [Pure]
        public static AzureAcrWebhookCreateSettings SetUri(this AzureAcrWebhookCreateSettings toolSettings, string uri)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Uri = uri;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookCreateSettings.Uri"/>.</em></p><p>The service URI for the webhook to post notifications.</p></summary>
        [Pure]
        public static AzureAcrWebhookCreateSettings ResetUri(this AzureAcrWebhookCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Uri = null;
            return toolSettings;
        }
        #endregion
        #region Headers
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookCreateSettings.Headers"/>.</em></p><p>Space-separated custom headers in 'key[=value]' format that will be added to the webhook notifications. Use "" to clear existing headers.</p></summary>
        [Pure]
        public static AzureAcrWebhookCreateSettings SetHeaders(this AzureAcrWebhookCreateSettings toolSettings, string headers)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Headers = headers;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookCreateSettings.Headers"/>.</em></p><p>Space-separated custom headers in 'key[=value]' format that will be added to the webhook notifications. Use "" to clear existing headers.</p></summary>
        [Pure]
        public static AzureAcrWebhookCreateSettings ResetHeaders(this AzureAcrWebhookCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Headers = null;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookCreateSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrWebhookCreateSettings SetLocation(this AzureAcrWebhookCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookCreateSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrWebhookCreateSettings ResetLocation(this AzureAcrWebhookCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrWebhookCreateSettings SetResourceGroup(this AzureAcrWebhookCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrWebhookCreateSettings ResetResourceGroup(this AzureAcrWebhookCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Scope
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookCreateSettings.Scope"/>.</em></p><p>The scope of repositories where the event can be triggered. For example, 'foo:*' means events for all tags under repository 'foo'. 'foo:bar' means events for 'foo:bar' only. 'foo' is equivalent to 'foo:latest'. Empty means events for all repositories.</p></summary>
        [Pure]
        public static AzureAcrWebhookCreateSettings SetScope(this AzureAcrWebhookCreateSettings toolSettings, string scope)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Scope = scope;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookCreateSettings.Scope"/>.</em></p><p>The scope of repositories where the event can be triggered. For example, 'foo:*' means events for all tags under repository 'foo'. 'foo:bar' means events for 'foo:bar' only. 'foo' is equivalent to 'foo:latest'. Empty means events for all repositories.</p></summary>
        [Pure]
        public static AzureAcrWebhookCreateSettings ResetScope(this AzureAcrWebhookCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Scope = null;
            return toolSettings;
        }
        #endregion
        #region Status
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookCreateSettings.Status"/>.</em></p><p>Indicates whether the webhook is enabled.</p></summary>
        [Pure]
        public static AzureAcrWebhookCreateSettings SetStatus(this AzureAcrWebhookCreateSettings toolSettings, AcrWebhookStatus status)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Status = status;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookCreateSettings.Status"/>.</em></p><p>Indicates whether the webhook is enabled.</p></summary>
        [Pure]
        public static AzureAcrWebhookCreateSettings ResetStatus(this AzureAcrWebhookCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Status = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookCreateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureAcrWebhookCreateSettings SetTags(this AzureAcrWebhookCreateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookCreateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureAcrWebhookCreateSettings ResetTags(this AzureAcrWebhookCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrWebhookCreateSettings SetDebug(this AzureAcrWebhookCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrWebhookCreateSettings ResetDebug(this AzureAcrWebhookCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrWebhookCreateSettings SetHelp(this AzureAcrWebhookCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrWebhookCreateSettings ResetHelp(this AzureAcrWebhookCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrWebhookCreateSettings SetOutput(this AzureAcrWebhookCreateSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrWebhookCreateSettings ResetOutput(this AzureAcrWebhookCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrWebhookCreateSettings SetQuery(this AzureAcrWebhookCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrWebhookCreateSettings ResetQuery(this AzureAcrWebhookCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrWebhookCreateSettings SetVerbose(this AzureAcrWebhookCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrWebhookCreateSettings ResetVerbose(this AzureAcrWebhookCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcrWebhookDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcrWebhookDeleteSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookDeleteSettings.Name"/>.</em></p><p>The name of the webhook.</p></summary>
        [Pure]
        public static AzureAcrWebhookDeleteSettings SetName(this AzureAcrWebhookDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookDeleteSettings.Name"/>.</em></p><p>The name of the webhook.</p></summary>
        [Pure]
        public static AzureAcrWebhookDeleteSettings ResetName(this AzureAcrWebhookDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Registry
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookDeleteSettings.Registry"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrWebhookDeleteSettings SetRegistry(this AzureAcrWebhookDeleteSettings toolSettings, string registry)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Registry = registry;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookDeleteSettings.Registry"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrWebhookDeleteSettings ResetRegistry(this AzureAcrWebhookDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Registry = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrWebhookDeleteSettings SetResourceGroup(this AzureAcrWebhookDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrWebhookDeleteSettings ResetResourceGroup(this AzureAcrWebhookDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrWebhookDeleteSettings SetDebug(this AzureAcrWebhookDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrWebhookDeleteSettings ResetDebug(this AzureAcrWebhookDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrWebhookDeleteSettings SetHelp(this AzureAcrWebhookDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrWebhookDeleteSettings ResetHelp(this AzureAcrWebhookDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrWebhookDeleteSettings SetOutput(this AzureAcrWebhookDeleteSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrWebhookDeleteSettings ResetOutput(this AzureAcrWebhookDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrWebhookDeleteSettings SetQuery(this AzureAcrWebhookDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrWebhookDeleteSettings ResetQuery(this AzureAcrWebhookDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrWebhookDeleteSettings SetVerbose(this AzureAcrWebhookDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrWebhookDeleteSettings ResetVerbose(this AzureAcrWebhookDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcrWebhookGetConfigSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcrWebhookGetConfigSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookGetConfigSettings.Name"/>.</em></p><p>The name of the webhook.</p></summary>
        [Pure]
        public static AzureAcrWebhookGetConfigSettings SetName(this AzureAcrWebhookGetConfigSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookGetConfigSettings.Name"/>.</em></p><p>The name of the webhook.</p></summary>
        [Pure]
        public static AzureAcrWebhookGetConfigSettings ResetName(this AzureAcrWebhookGetConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Registry
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookGetConfigSettings.Registry"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrWebhookGetConfigSettings SetRegistry(this AzureAcrWebhookGetConfigSettings toolSettings, string registry)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Registry = registry;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookGetConfigSettings.Registry"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrWebhookGetConfigSettings ResetRegistry(this AzureAcrWebhookGetConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Registry = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookGetConfigSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrWebhookGetConfigSettings SetResourceGroup(this AzureAcrWebhookGetConfigSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookGetConfigSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrWebhookGetConfigSettings ResetResourceGroup(this AzureAcrWebhookGetConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookGetConfigSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrWebhookGetConfigSettings SetDebug(this AzureAcrWebhookGetConfigSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookGetConfigSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrWebhookGetConfigSettings ResetDebug(this AzureAcrWebhookGetConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookGetConfigSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrWebhookGetConfigSettings SetHelp(this AzureAcrWebhookGetConfigSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookGetConfigSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrWebhookGetConfigSettings ResetHelp(this AzureAcrWebhookGetConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookGetConfigSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrWebhookGetConfigSettings SetOutput(this AzureAcrWebhookGetConfigSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookGetConfigSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrWebhookGetConfigSettings ResetOutput(this AzureAcrWebhookGetConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookGetConfigSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrWebhookGetConfigSettings SetQuery(this AzureAcrWebhookGetConfigSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookGetConfigSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrWebhookGetConfigSettings ResetQuery(this AzureAcrWebhookGetConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookGetConfigSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrWebhookGetConfigSettings SetVerbose(this AzureAcrWebhookGetConfigSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookGetConfigSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrWebhookGetConfigSettings ResetVerbose(this AzureAcrWebhookGetConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcrWebhookListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcrWebhookListSettingsExtensions
    {
        #region Registry
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookListSettings.Registry"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrWebhookListSettings SetRegistry(this AzureAcrWebhookListSettings toolSettings, string registry)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Registry = registry;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookListSettings.Registry"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrWebhookListSettings ResetRegistry(this AzureAcrWebhookListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Registry = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrWebhookListSettings SetResourceGroup(this AzureAcrWebhookListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrWebhookListSettings ResetResourceGroup(this AzureAcrWebhookListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrWebhookListSettings SetDebug(this AzureAcrWebhookListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrWebhookListSettings ResetDebug(this AzureAcrWebhookListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrWebhookListSettings SetHelp(this AzureAcrWebhookListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrWebhookListSettings ResetHelp(this AzureAcrWebhookListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrWebhookListSettings SetOutput(this AzureAcrWebhookListSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrWebhookListSettings ResetOutput(this AzureAcrWebhookListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrWebhookListSettings SetQuery(this AzureAcrWebhookListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrWebhookListSettings ResetQuery(this AzureAcrWebhookListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrWebhookListSettings SetVerbose(this AzureAcrWebhookListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrWebhookListSettings ResetVerbose(this AzureAcrWebhookListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcrWebhookListEventsSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcrWebhookListEventsSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookListEventsSettings.Name"/>.</em></p><p>The name of the webhook.</p></summary>
        [Pure]
        public static AzureAcrWebhookListEventsSettings SetName(this AzureAcrWebhookListEventsSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookListEventsSettings.Name"/>.</em></p><p>The name of the webhook.</p></summary>
        [Pure]
        public static AzureAcrWebhookListEventsSettings ResetName(this AzureAcrWebhookListEventsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Registry
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookListEventsSettings.Registry"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrWebhookListEventsSettings SetRegistry(this AzureAcrWebhookListEventsSettings toolSettings, string registry)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Registry = registry;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookListEventsSettings.Registry"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrWebhookListEventsSettings ResetRegistry(this AzureAcrWebhookListEventsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Registry = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookListEventsSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrWebhookListEventsSettings SetResourceGroup(this AzureAcrWebhookListEventsSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookListEventsSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrWebhookListEventsSettings ResetResourceGroup(this AzureAcrWebhookListEventsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookListEventsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrWebhookListEventsSettings SetDebug(this AzureAcrWebhookListEventsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookListEventsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrWebhookListEventsSettings ResetDebug(this AzureAcrWebhookListEventsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookListEventsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrWebhookListEventsSettings SetHelp(this AzureAcrWebhookListEventsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookListEventsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrWebhookListEventsSettings ResetHelp(this AzureAcrWebhookListEventsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookListEventsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrWebhookListEventsSettings SetOutput(this AzureAcrWebhookListEventsSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookListEventsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrWebhookListEventsSettings ResetOutput(this AzureAcrWebhookListEventsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookListEventsSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrWebhookListEventsSettings SetQuery(this AzureAcrWebhookListEventsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookListEventsSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrWebhookListEventsSettings ResetQuery(this AzureAcrWebhookListEventsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookListEventsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrWebhookListEventsSettings SetVerbose(this AzureAcrWebhookListEventsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookListEventsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrWebhookListEventsSettings ResetVerbose(this AzureAcrWebhookListEventsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcrWebhookPingSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcrWebhookPingSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookPingSettings.Name"/>.</em></p><p>The name of the webhook.</p></summary>
        [Pure]
        public static AzureAcrWebhookPingSettings SetName(this AzureAcrWebhookPingSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookPingSettings.Name"/>.</em></p><p>The name of the webhook.</p></summary>
        [Pure]
        public static AzureAcrWebhookPingSettings ResetName(this AzureAcrWebhookPingSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Registry
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookPingSettings.Registry"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrWebhookPingSettings SetRegistry(this AzureAcrWebhookPingSettings toolSettings, string registry)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Registry = registry;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookPingSettings.Registry"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrWebhookPingSettings ResetRegistry(this AzureAcrWebhookPingSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Registry = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookPingSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrWebhookPingSettings SetResourceGroup(this AzureAcrWebhookPingSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookPingSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrWebhookPingSettings ResetResourceGroup(this AzureAcrWebhookPingSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookPingSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrWebhookPingSettings SetDebug(this AzureAcrWebhookPingSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookPingSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrWebhookPingSettings ResetDebug(this AzureAcrWebhookPingSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookPingSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrWebhookPingSettings SetHelp(this AzureAcrWebhookPingSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookPingSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrWebhookPingSettings ResetHelp(this AzureAcrWebhookPingSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookPingSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrWebhookPingSettings SetOutput(this AzureAcrWebhookPingSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookPingSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrWebhookPingSettings ResetOutput(this AzureAcrWebhookPingSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookPingSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrWebhookPingSettings SetQuery(this AzureAcrWebhookPingSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookPingSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrWebhookPingSettings ResetQuery(this AzureAcrWebhookPingSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookPingSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrWebhookPingSettings SetVerbose(this AzureAcrWebhookPingSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookPingSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrWebhookPingSettings ResetVerbose(this AzureAcrWebhookPingSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcrWebhookShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcrWebhookShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookShowSettings.Name"/>.</em></p><p>The name of the webhook.</p></summary>
        [Pure]
        public static AzureAcrWebhookShowSettings SetName(this AzureAcrWebhookShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookShowSettings.Name"/>.</em></p><p>The name of the webhook.</p></summary>
        [Pure]
        public static AzureAcrWebhookShowSettings ResetName(this AzureAcrWebhookShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Registry
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookShowSettings.Registry"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrWebhookShowSettings SetRegistry(this AzureAcrWebhookShowSettings toolSettings, string registry)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Registry = registry;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookShowSettings.Registry"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrWebhookShowSettings ResetRegistry(this AzureAcrWebhookShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Registry = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrWebhookShowSettings SetResourceGroup(this AzureAcrWebhookShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrWebhookShowSettings ResetResourceGroup(this AzureAcrWebhookShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrWebhookShowSettings SetDebug(this AzureAcrWebhookShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrWebhookShowSettings ResetDebug(this AzureAcrWebhookShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrWebhookShowSettings SetHelp(this AzureAcrWebhookShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrWebhookShowSettings ResetHelp(this AzureAcrWebhookShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrWebhookShowSettings SetOutput(this AzureAcrWebhookShowSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrWebhookShowSettings ResetOutput(this AzureAcrWebhookShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrWebhookShowSettings SetQuery(this AzureAcrWebhookShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrWebhookShowSettings ResetQuery(this AzureAcrWebhookShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrWebhookShowSettings SetVerbose(this AzureAcrWebhookShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrWebhookShowSettings ResetVerbose(this AzureAcrWebhookShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcrWebhookUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcrWebhookUpdateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookUpdateSettings.Name"/>.</em></p><p>The name of the webhook.</p></summary>
        [Pure]
        public static AzureAcrWebhookUpdateSettings SetName(this AzureAcrWebhookUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookUpdateSettings.Name"/>.</em></p><p>The name of the webhook.</p></summary>
        [Pure]
        public static AzureAcrWebhookUpdateSettings ResetName(this AzureAcrWebhookUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Registry
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookUpdateSettings.Registry"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrWebhookUpdateSettings SetRegistry(this AzureAcrWebhookUpdateSettings toolSettings, string registry)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Registry = registry;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookUpdateSettings.Registry"/>.</em></p><p>The name of the container registry. You can configure the default registry name using `az configure --defaults acr=&amp;lt;registry name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrWebhookUpdateSettings ResetRegistry(this AzureAcrWebhookUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Registry = null;
            return toolSettings;
        }
        #endregion
        #region Actions
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookUpdateSettings.Actions"/> to a new list.</em></p><p>Space-separated list of actions that trigger the webhook to post notifications.</p></summary>
        [Pure]
        public static AzureAcrWebhookUpdateSettings SetActions(this AzureAcrWebhookUpdateSettings toolSettings, params AcrWebhookActions[] actions)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ActionsInternal = actions.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookUpdateSettings.Actions"/> to a new list.</em></p><p>Space-separated list of actions that trigger the webhook to post notifications.</p></summary>
        [Pure]
        public static AzureAcrWebhookUpdateSettings SetActions(this AzureAcrWebhookUpdateSettings toolSettings, IEnumerable<AcrWebhookActions> actions)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ActionsInternal = actions.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureAcrWebhookUpdateSettings.Actions"/>.</em></p><p>Space-separated list of actions that trigger the webhook to post notifications.</p></summary>
        [Pure]
        public static AzureAcrWebhookUpdateSettings AddActions(this AzureAcrWebhookUpdateSettings toolSettings, params AcrWebhookActions[] actions)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ActionsInternal.AddRange(actions);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureAcrWebhookUpdateSettings.Actions"/>.</em></p><p>Space-separated list of actions that trigger the webhook to post notifications.</p></summary>
        [Pure]
        public static AzureAcrWebhookUpdateSettings AddActions(this AzureAcrWebhookUpdateSettings toolSettings, IEnumerable<AcrWebhookActions> actions)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ActionsInternal.AddRange(actions);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureAcrWebhookUpdateSettings.Actions"/>.</em></p><p>Space-separated list of actions that trigger the webhook to post notifications.</p></summary>
        [Pure]
        public static AzureAcrWebhookUpdateSettings ClearActions(this AzureAcrWebhookUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ActionsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureAcrWebhookUpdateSettings.Actions"/>.</em></p><p>Space-separated list of actions that trigger the webhook to post notifications.</p></summary>
        [Pure]
        public static AzureAcrWebhookUpdateSettings RemoveActions(this AzureAcrWebhookUpdateSettings toolSettings, params AcrWebhookActions[] actions)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<AcrWebhookActions>(actions);
            toolSettings.ActionsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureAcrWebhookUpdateSettings.Actions"/>.</em></p><p>Space-separated list of actions that trigger the webhook to post notifications.</p></summary>
        [Pure]
        public static AzureAcrWebhookUpdateSettings RemoveActions(this AzureAcrWebhookUpdateSettings toolSettings, IEnumerable<AcrWebhookActions> actions)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<AcrWebhookActions>(actions);
            toolSettings.ActionsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Headers
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookUpdateSettings.Headers"/>.</em></p><p>Space-separated custom headers in 'key[=value]' format that will be added to the webhook notifications. Use "" to clear existing headers.</p></summary>
        [Pure]
        public static AzureAcrWebhookUpdateSettings SetHeaders(this AzureAcrWebhookUpdateSettings toolSettings, string headers)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Headers = headers;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookUpdateSettings.Headers"/>.</em></p><p>Space-separated custom headers in 'key[=value]' format that will be added to the webhook notifications. Use "" to clear existing headers.</p></summary>
        [Pure]
        public static AzureAcrWebhookUpdateSettings ResetHeaders(this AzureAcrWebhookUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Headers = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrWebhookUpdateSettings SetResourceGroup(this AzureAcrWebhookUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcrWebhookUpdateSettings ResetResourceGroup(this AzureAcrWebhookUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Scope
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookUpdateSettings.Scope"/>.</em></p><p>The scope of repositories where the event can be triggered. For example, 'foo:*' means events for all tags under repository 'foo'. 'foo:bar' means events for 'foo:bar' only. 'foo' is equivalent to 'foo:latest'. Empty means events for all repositories.</p></summary>
        [Pure]
        public static AzureAcrWebhookUpdateSettings SetScope(this AzureAcrWebhookUpdateSettings toolSettings, string scope)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Scope = scope;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookUpdateSettings.Scope"/>.</em></p><p>The scope of repositories where the event can be triggered. For example, 'foo:*' means events for all tags under repository 'foo'. 'foo:bar' means events for 'foo:bar' only. 'foo' is equivalent to 'foo:latest'. Empty means events for all repositories.</p></summary>
        [Pure]
        public static AzureAcrWebhookUpdateSettings ResetScope(this AzureAcrWebhookUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Scope = null;
            return toolSettings;
        }
        #endregion
        #region Status
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookUpdateSettings.Status"/>.</em></p><p>Indicates whether the webhook is enabled.</p></summary>
        [Pure]
        public static AzureAcrWebhookUpdateSettings SetStatus(this AzureAcrWebhookUpdateSettings toolSettings, AcrWebhookStatus status)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Status = status;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookUpdateSettings.Status"/>.</em></p><p>Indicates whether the webhook is enabled.</p></summary>
        [Pure]
        public static AzureAcrWebhookUpdateSettings ResetStatus(this AzureAcrWebhookUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Status = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookUpdateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureAcrWebhookUpdateSettings SetTags(this AzureAcrWebhookUpdateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookUpdateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureAcrWebhookUpdateSettings ResetTags(this AzureAcrWebhookUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Uri
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookUpdateSettings.Uri"/>.</em></p><p>The service URI for the webhook to post notifications.</p></summary>
        [Pure]
        public static AzureAcrWebhookUpdateSettings SetUri(this AzureAcrWebhookUpdateSettings toolSettings, string uri)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Uri = uri;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookUpdateSettings.Uri"/>.</em></p><p>The service URI for the webhook to post notifications.</p></summary>
        [Pure]
        public static AzureAcrWebhookUpdateSettings ResetUri(this AzureAcrWebhookUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Uri = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureAcrWebhookUpdateSettings SetAdd(this AzureAcrWebhookUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureAcrWebhookUpdateSettings ResetAdd(this AzureAcrWebhookUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureAcrWebhookUpdateSettings SetRemove(this AzureAcrWebhookUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureAcrWebhookUpdateSettings ResetRemove(this AzureAcrWebhookUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureAcrWebhookUpdateSettings SetSet(this AzureAcrWebhookUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureAcrWebhookUpdateSettings ResetSet(this AzureAcrWebhookUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrWebhookUpdateSettings SetDebug(this AzureAcrWebhookUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcrWebhookUpdateSettings ResetDebug(this AzureAcrWebhookUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrWebhookUpdateSettings SetHelp(this AzureAcrWebhookUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcrWebhookUpdateSettings ResetHelp(this AzureAcrWebhookUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrWebhookUpdateSettings SetOutput(this AzureAcrWebhookUpdateSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcrWebhookUpdateSettings ResetOutput(this AzureAcrWebhookUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrWebhookUpdateSettings SetQuery(this AzureAcrWebhookUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAcrWebhookUpdateSettings ResetQuery(this AzureAcrWebhookUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcrWebhookUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrWebhookUpdateSettings SetVerbose(this AzureAcrWebhookUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcrWebhookUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcrWebhookUpdateSettings ResetVerbose(this AzureAcrWebhookUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AcrSku
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    public partial class AcrSku : Enumeration
    {
        public static AcrSku basic = new AcrSku { Value = "basic" };
        public static AcrSku classic = new AcrSku { Value = "classic" };
        public static AcrSku premium = new AcrSku { Value = "premium" };
        public static AcrSku standard = new AcrSku { Value = "standard" };
    }
    #endregion
    #region AcrCredentialRenewPasswordName
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    public partial class AcrCredentialRenewPasswordName : Enumeration
    {
        public static AcrCredentialRenewPasswordName password = new AcrCredentialRenewPasswordName { Value = "password" };
        public static AcrCredentialRenewPasswordName password2 = new AcrCredentialRenewPasswordName { Value = "password2" };
    }
    #endregion
    #region AcrWebhookActions
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    public partial class AcrWebhookActions : Enumeration
    {
        public static AcrWebhookActions delete = new AcrWebhookActions { Value = "delete" };
        public static AcrWebhookActions push = new AcrWebhookActions { Value = "push" };
    }
    #endregion
    #region AcrWebhookStatus
    /// <summary><p>Used within <see cref="AzureAcrTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    public partial class AcrWebhookStatus : Enumeration
    {
        public static AcrWebhookStatus disabled = new AcrWebhookStatus { Value = "disabled" };
        public static AcrWebhookStatus enabled = new AcrWebhookStatus { Value = "enabled" };
    }
    #endregion
}
