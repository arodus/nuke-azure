// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/AzureBackup.json
// Generated with Nuke.CodeGeneration version 0.20.1 (Windows,.NETStandard,Version=v2.0)

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
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text;

namespace Nuke.Azure
{
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBackupTasks
    {
        /// <summary>
        ///   Path to the AzureBackup executable.
        /// </summary>
        public static string AzureBackupPath =>
            ToolPathResolver.TryGetEnvironmentExecutable("AZUREBACKUP_EXE") ??
            ToolPathResolver.GetPathExecutable("az");
        public static Action<OutputType, string> AzureBackupLogger { get; set; } = ProcessTasks.DefaultLogger;
        /// <summary>
        ///   Manage Azure Backups.
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBackup(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool? logOutput = null, bool? logInvocation = null, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzureBackupPath, arguments, workingDirectory, environmentVariables, timeout, logOutput, logInvocation, AzureBackupLogger, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBackup(AzureBackupSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBackupSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBackupSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBackupSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBackupSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBackupSettings.Query"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBackupSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBackup(Configure<AzureBackupSettings> configurator)
        {
            return AzureBackup(configurator(new AzureBackupSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBackupSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBackupSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBackupSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBackupSettings.Query"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBackupSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBackupSettings Settings, IReadOnlyCollection<Output> Output)> AzureBackup(CombinatorialConfigure<AzureBackupSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBackup, AzureBackupLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBackupContainerList(AzureBackupContainerListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBackupContainerListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBackupContainerListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBackupContainerListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBackupContainerListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBackupContainerListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBackupContainerListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBackupContainerListSettings.Subscription"/></li>
        ///     <li><c>--vault-name</c> via <see cref="AzureBackupContainerListSettings.VaultName"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBackupContainerListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBackupContainerList(Configure<AzureBackupContainerListSettings> configurator)
        {
            return AzureBackupContainerList(configurator(new AzureBackupContainerListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBackupContainerListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBackupContainerListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBackupContainerListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBackupContainerListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBackupContainerListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBackupContainerListSettings.Subscription"/></li>
        ///     <li><c>--vault-name</c> via <see cref="AzureBackupContainerListSettings.VaultName"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBackupContainerListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBackupContainerListSettings Settings, IReadOnlyCollection<Output> Output)> AzureBackupContainerList(CombinatorialConfigure<AzureBackupContainerListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBackupContainerList, AzureBackupLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBackupContainerShow(AzureBackupContainerShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBackupContainerShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBackupContainerShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBackupContainerShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureBackupContainerShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureBackupContainerShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBackupContainerShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBackupContainerShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBackupContainerShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBackupContainerShowSettings.Subscription"/></li>
        ///     <li><c>--vault-name</c> via <see cref="AzureBackupContainerShowSettings.VaultName"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBackupContainerShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBackupContainerShow(Configure<AzureBackupContainerShowSettings> configurator)
        {
            return AzureBackupContainerShow(configurator(new AzureBackupContainerShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBackupContainerShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBackupContainerShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureBackupContainerShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureBackupContainerShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBackupContainerShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBackupContainerShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBackupContainerShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBackupContainerShowSettings.Subscription"/></li>
        ///     <li><c>--vault-name</c> via <see cref="AzureBackupContainerShowSettings.VaultName"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBackupContainerShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBackupContainerShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureBackupContainerShow(CombinatorialConfigure<AzureBackupContainerShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBackupContainerShow, AzureBackupLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBackupItemList(AzureBackupItemListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBackupItemListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--container-name</c> via <see cref="AzureBackupItemListSettings.ContainerName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureBackupItemListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBackupItemListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBackupItemListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBackupItemListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBackupItemListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBackupItemListSettings.Subscription"/></li>
        ///     <li><c>--vault-name</c> via <see cref="AzureBackupItemListSettings.VaultName"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBackupItemListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBackupItemList(Configure<AzureBackupItemListSettings> configurator)
        {
            return AzureBackupItemList(configurator(new AzureBackupItemListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--container-name</c> via <see cref="AzureBackupItemListSettings.ContainerName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureBackupItemListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBackupItemListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBackupItemListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBackupItemListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBackupItemListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBackupItemListSettings.Subscription"/></li>
        ///     <li><c>--vault-name</c> via <see cref="AzureBackupItemListSettings.VaultName"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBackupItemListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBackupItemListSettings Settings, IReadOnlyCollection<Output> Output)> AzureBackupItemList(CombinatorialConfigure<AzureBackupItemListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBackupItemList, AzureBackupLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBackupItemSetPolicy(AzureBackupItemSetPolicySettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBackupItemSetPolicySettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--container-name</c> via <see cref="AzureBackupItemSetPolicySettings.ContainerName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureBackupItemSetPolicySettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBackupItemSetPolicySettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureBackupItemSetPolicySettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureBackupItemSetPolicySettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBackupItemSetPolicySettings.Output"/></li>
        ///     <li><c>--policy-name</c> via <see cref="AzureBackupItemSetPolicySettings.PolicyName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBackupItemSetPolicySettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBackupItemSetPolicySettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBackupItemSetPolicySettings.Subscription"/></li>
        ///     <li><c>--vault-name</c> via <see cref="AzureBackupItemSetPolicySettings.VaultName"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBackupItemSetPolicySettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBackupItemSetPolicy(Configure<AzureBackupItemSetPolicySettings> configurator)
        {
            return AzureBackupItemSetPolicy(configurator(new AzureBackupItemSetPolicySettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--container-name</c> via <see cref="AzureBackupItemSetPolicySettings.ContainerName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureBackupItemSetPolicySettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBackupItemSetPolicySettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureBackupItemSetPolicySettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureBackupItemSetPolicySettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBackupItemSetPolicySettings.Output"/></li>
        ///     <li><c>--policy-name</c> via <see cref="AzureBackupItemSetPolicySettings.PolicyName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBackupItemSetPolicySettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBackupItemSetPolicySettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBackupItemSetPolicySettings.Subscription"/></li>
        ///     <li><c>--vault-name</c> via <see cref="AzureBackupItemSetPolicySettings.VaultName"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBackupItemSetPolicySettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBackupItemSetPolicySettings Settings, IReadOnlyCollection<Output> Output)> AzureBackupItemSetPolicy(CombinatorialConfigure<AzureBackupItemSetPolicySettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBackupItemSetPolicy, AzureBackupLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBackupItemShow(AzureBackupItemShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBackupItemShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--container-name</c> via <see cref="AzureBackupItemShowSettings.ContainerName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureBackupItemShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBackupItemShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureBackupItemShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureBackupItemShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBackupItemShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBackupItemShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBackupItemShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBackupItemShowSettings.Subscription"/></li>
        ///     <li><c>--vault-name</c> via <see cref="AzureBackupItemShowSettings.VaultName"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBackupItemShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBackupItemShow(Configure<AzureBackupItemShowSettings> configurator)
        {
            return AzureBackupItemShow(configurator(new AzureBackupItemShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--container-name</c> via <see cref="AzureBackupItemShowSettings.ContainerName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureBackupItemShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBackupItemShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureBackupItemShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureBackupItemShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBackupItemShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBackupItemShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBackupItemShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBackupItemShowSettings.Subscription"/></li>
        ///     <li><c>--vault-name</c> via <see cref="AzureBackupItemShowSettings.VaultName"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBackupItemShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBackupItemShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureBackupItemShow(CombinatorialConfigure<AzureBackupItemShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBackupItemShow, AzureBackupLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBackupJobList(AzureBackupJobListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBackupJobListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBackupJobListSettings.Debug"/></li>
        ///     <li><c>--end-date</c> via <see cref="AzureBackupJobListSettings.EndDate"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBackupJobListSettings.Help"/></li>
        ///     <li><c>--operation</c> via <see cref="AzureBackupJobListSettings.Operation"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBackupJobListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBackupJobListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBackupJobListSettings.ResourceGroup"/></li>
        ///     <li><c>--start-date</c> via <see cref="AzureBackupJobListSettings.StartDate"/></li>
        ///     <li><c>--status</c> via <see cref="AzureBackupJobListSettings.Status"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBackupJobListSettings.Subscription"/></li>
        ///     <li><c>--vault-name</c> via <see cref="AzureBackupJobListSettings.VaultName"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBackupJobListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBackupJobList(Configure<AzureBackupJobListSettings> configurator)
        {
            return AzureBackupJobList(configurator(new AzureBackupJobListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBackupJobListSettings.Debug"/></li>
        ///     <li><c>--end-date</c> via <see cref="AzureBackupJobListSettings.EndDate"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBackupJobListSettings.Help"/></li>
        ///     <li><c>--operation</c> via <see cref="AzureBackupJobListSettings.Operation"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBackupJobListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBackupJobListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBackupJobListSettings.ResourceGroup"/></li>
        ///     <li><c>--start-date</c> via <see cref="AzureBackupJobListSettings.StartDate"/></li>
        ///     <li><c>--status</c> via <see cref="AzureBackupJobListSettings.Status"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBackupJobListSettings.Subscription"/></li>
        ///     <li><c>--vault-name</c> via <see cref="AzureBackupJobListSettings.VaultName"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBackupJobListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBackupJobListSettings Settings, IReadOnlyCollection<Output> Output)> AzureBackupJobList(CombinatorialConfigure<AzureBackupJobListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBackupJobList, AzureBackupLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBackupJobShow(AzureBackupJobShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBackupJobShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBackupJobShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBackupJobShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureBackupJobShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureBackupJobShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBackupJobShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBackupJobShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBackupJobShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBackupJobShowSettings.Subscription"/></li>
        ///     <li><c>--vault-name</c> via <see cref="AzureBackupJobShowSettings.VaultName"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBackupJobShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBackupJobShow(Configure<AzureBackupJobShowSettings> configurator)
        {
            return AzureBackupJobShow(configurator(new AzureBackupJobShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBackupJobShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBackupJobShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureBackupJobShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureBackupJobShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBackupJobShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBackupJobShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBackupJobShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBackupJobShowSettings.Subscription"/></li>
        ///     <li><c>--vault-name</c> via <see cref="AzureBackupJobShowSettings.VaultName"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBackupJobShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBackupJobShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureBackupJobShow(CombinatorialConfigure<AzureBackupJobShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBackupJobShow, AzureBackupLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBackupJobStop(AzureBackupJobStopSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBackupJobStopSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBackupJobStopSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBackupJobStopSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureBackupJobStopSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureBackupJobStopSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBackupJobStopSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBackupJobStopSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBackupJobStopSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBackupJobStopSettings.Subscription"/></li>
        ///     <li><c>--vault-name</c> via <see cref="AzureBackupJobStopSettings.VaultName"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBackupJobStopSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBackupJobStop(Configure<AzureBackupJobStopSettings> configurator)
        {
            return AzureBackupJobStop(configurator(new AzureBackupJobStopSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBackupJobStopSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBackupJobStopSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureBackupJobStopSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureBackupJobStopSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBackupJobStopSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBackupJobStopSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBackupJobStopSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBackupJobStopSettings.Subscription"/></li>
        ///     <li><c>--vault-name</c> via <see cref="AzureBackupJobStopSettings.VaultName"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBackupJobStopSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBackupJobStopSettings Settings, IReadOnlyCollection<Output> Output)> AzureBackupJobStop(CombinatorialConfigure<AzureBackupJobStopSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBackupJobStop, AzureBackupLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBackupJobWait(AzureBackupJobWaitSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBackupJobWaitSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBackupJobWaitSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBackupJobWaitSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureBackupJobWaitSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureBackupJobWaitSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBackupJobWaitSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBackupJobWaitSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBackupJobWaitSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBackupJobWaitSettings.Subscription"/></li>
        ///     <li><c>--timeout</c> via <see cref="AzureBackupJobWaitSettings.Timeout"/></li>
        ///     <li><c>--vault-name</c> via <see cref="AzureBackupJobWaitSettings.VaultName"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBackupJobWaitSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBackupJobWait(Configure<AzureBackupJobWaitSettings> configurator)
        {
            return AzureBackupJobWait(configurator(new AzureBackupJobWaitSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBackupJobWaitSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBackupJobWaitSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureBackupJobWaitSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureBackupJobWaitSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBackupJobWaitSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBackupJobWaitSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBackupJobWaitSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBackupJobWaitSettings.Subscription"/></li>
        ///     <li><c>--timeout</c> via <see cref="AzureBackupJobWaitSettings.Timeout"/></li>
        ///     <li><c>--vault-name</c> via <see cref="AzureBackupJobWaitSettings.VaultName"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBackupJobWaitSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBackupJobWaitSettings Settings, IReadOnlyCollection<Output> Output)> AzureBackupJobWait(CombinatorialConfigure<AzureBackupJobWaitSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBackupJobWait, AzureBackupLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBackupPolicyDelete(AzureBackupPolicyDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBackupPolicyDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBackupPolicyDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBackupPolicyDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureBackupPolicyDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureBackupPolicyDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBackupPolicyDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBackupPolicyDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBackupPolicyDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBackupPolicyDeleteSettings.Subscription"/></li>
        ///     <li><c>--vault-name</c> via <see cref="AzureBackupPolicyDeleteSettings.VaultName"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBackupPolicyDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBackupPolicyDelete(Configure<AzureBackupPolicyDeleteSettings> configurator)
        {
            return AzureBackupPolicyDelete(configurator(new AzureBackupPolicyDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBackupPolicyDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBackupPolicyDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureBackupPolicyDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureBackupPolicyDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBackupPolicyDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBackupPolicyDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBackupPolicyDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBackupPolicyDeleteSettings.Subscription"/></li>
        ///     <li><c>--vault-name</c> via <see cref="AzureBackupPolicyDeleteSettings.VaultName"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBackupPolicyDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBackupPolicyDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureBackupPolicyDelete(CombinatorialConfigure<AzureBackupPolicyDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBackupPolicyDelete, AzureBackupLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBackupPolicyGetDefaultForVm(AzureBackupPolicyGetDefaultForVmSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBackupPolicyGetDefaultForVmSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBackupPolicyGetDefaultForVmSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBackupPolicyGetDefaultForVmSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureBackupPolicyGetDefaultForVmSettings.Ids"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBackupPolicyGetDefaultForVmSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBackupPolicyGetDefaultForVmSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBackupPolicyGetDefaultForVmSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBackupPolicyGetDefaultForVmSettings.Subscription"/></li>
        ///     <li><c>--vault-name</c> via <see cref="AzureBackupPolicyGetDefaultForVmSettings.VaultName"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBackupPolicyGetDefaultForVmSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBackupPolicyGetDefaultForVm(Configure<AzureBackupPolicyGetDefaultForVmSettings> configurator)
        {
            return AzureBackupPolicyGetDefaultForVm(configurator(new AzureBackupPolicyGetDefaultForVmSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBackupPolicyGetDefaultForVmSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBackupPolicyGetDefaultForVmSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureBackupPolicyGetDefaultForVmSettings.Ids"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBackupPolicyGetDefaultForVmSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBackupPolicyGetDefaultForVmSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBackupPolicyGetDefaultForVmSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBackupPolicyGetDefaultForVmSettings.Subscription"/></li>
        ///     <li><c>--vault-name</c> via <see cref="AzureBackupPolicyGetDefaultForVmSettings.VaultName"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBackupPolicyGetDefaultForVmSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBackupPolicyGetDefaultForVmSettings Settings, IReadOnlyCollection<Output> Output)> AzureBackupPolicyGetDefaultForVm(CombinatorialConfigure<AzureBackupPolicyGetDefaultForVmSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBackupPolicyGetDefaultForVm, AzureBackupLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBackupPolicyList(AzureBackupPolicyListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBackupPolicyListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBackupPolicyListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBackupPolicyListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBackupPolicyListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBackupPolicyListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBackupPolicyListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBackupPolicyListSettings.Subscription"/></li>
        ///     <li><c>--vault-name</c> via <see cref="AzureBackupPolicyListSettings.VaultName"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBackupPolicyListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBackupPolicyList(Configure<AzureBackupPolicyListSettings> configurator)
        {
            return AzureBackupPolicyList(configurator(new AzureBackupPolicyListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBackupPolicyListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBackupPolicyListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBackupPolicyListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBackupPolicyListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBackupPolicyListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBackupPolicyListSettings.Subscription"/></li>
        ///     <li><c>--vault-name</c> via <see cref="AzureBackupPolicyListSettings.VaultName"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBackupPolicyListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBackupPolicyListSettings Settings, IReadOnlyCollection<Output> Output)> AzureBackupPolicyList(CombinatorialConfigure<AzureBackupPolicyListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBackupPolicyList, AzureBackupLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBackupPolicyListAssociatedItems(AzureBackupPolicyListAssociatedItemsSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBackupPolicyListAssociatedItemsSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBackupPolicyListAssociatedItemsSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBackupPolicyListAssociatedItemsSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureBackupPolicyListAssociatedItemsSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureBackupPolicyListAssociatedItemsSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBackupPolicyListAssociatedItemsSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBackupPolicyListAssociatedItemsSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBackupPolicyListAssociatedItemsSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBackupPolicyListAssociatedItemsSettings.Subscription"/></li>
        ///     <li><c>--vault-name</c> via <see cref="AzureBackupPolicyListAssociatedItemsSettings.VaultName"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBackupPolicyListAssociatedItemsSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBackupPolicyListAssociatedItems(Configure<AzureBackupPolicyListAssociatedItemsSettings> configurator)
        {
            return AzureBackupPolicyListAssociatedItems(configurator(new AzureBackupPolicyListAssociatedItemsSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBackupPolicyListAssociatedItemsSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBackupPolicyListAssociatedItemsSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureBackupPolicyListAssociatedItemsSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureBackupPolicyListAssociatedItemsSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBackupPolicyListAssociatedItemsSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBackupPolicyListAssociatedItemsSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBackupPolicyListAssociatedItemsSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBackupPolicyListAssociatedItemsSettings.Subscription"/></li>
        ///     <li><c>--vault-name</c> via <see cref="AzureBackupPolicyListAssociatedItemsSettings.VaultName"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBackupPolicyListAssociatedItemsSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBackupPolicyListAssociatedItemsSettings Settings, IReadOnlyCollection<Output> Output)> AzureBackupPolicyListAssociatedItems(CombinatorialConfigure<AzureBackupPolicyListAssociatedItemsSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBackupPolicyListAssociatedItems, AzureBackupLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBackupPolicySet(AzureBackupPolicySetSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBackupPolicySetSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBackupPolicySetSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBackupPolicySetSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureBackupPolicySetSettings.Ids"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBackupPolicySetSettings.Output"/></li>
        ///     <li><c>--policy</c> via <see cref="AzureBackupPolicySetSettings.Policy"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBackupPolicySetSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBackupPolicySetSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBackupPolicySetSettings.Subscription"/></li>
        ///     <li><c>--vault-name</c> via <see cref="AzureBackupPolicySetSettings.VaultName"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBackupPolicySetSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBackupPolicySet(Configure<AzureBackupPolicySetSettings> configurator)
        {
            return AzureBackupPolicySet(configurator(new AzureBackupPolicySetSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBackupPolicySetSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBackupPolicySetSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureBackupPolicySetSettings.Ids"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBackupPolicySetSettings.Output"/></li>
        ///     <li><c>--policy</c> via <see cref="AzureBackupPolicySetSettings.Policy"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBackupPolicySetSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBackupPolicySetSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBackupPolicySetSettings.Subscription"/></li>
        ///     <li><c>--vault-name</c> via <see cref="AzureBackupPolicySetSettings.VaultName"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBackupPolicySetSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBackupPolicySetSettings Settings, IReadOnlyCollection<Output> Output)> AzureBackupPolicySet(CombinatorialConfigure<AzureBackupPolicySetSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBackupPolicySet, AzureBackupLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBackupPolicyShow(AzureBackupPolicyShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBackupPolicyShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBackupPolicyShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBackupPolicyShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureBackupPolicyShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureBackupPolicyShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBackupPolicyShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBackupPolicyShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBackupPolicyShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBackupPolicyShowSettings.Subscription"/></li>
        ///     <li><c>--vault-name</c> via <see cref="AzureBackupPolicyShowSettings.VaultName"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBackupPolicyShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBackupPolicyShow(Configure<AzureBackupPolicyShowSettings> configurator)
        {
            return AzureBackupPolicyShow(configurator(new AzureBackupPolicyShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBackupPolicyShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBackupPolicyShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureBackupPolicyShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureBackupPolicyShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBackupPolicyShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBackupPolicyShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBackupPolicyShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBackupPolicyShowSettings.Subscription"/></li>
        ///     <li><c>--vault-name</c> via <see cref="AzureBackupPolicyShowSettings.VaultName"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBackupPolicyShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBackupPolicyShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureBackupPolicyShow(CombinatorialConfigure<AzureBackupPolicyShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBackupPolicyShow, AzureBackupLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBackupProtectionBackupNow(AzureBackupProtectionBackupNowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBackupProtectionBackupNowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--container-name</c> via <see cref="AzureBackupProtectionBackupNowSettings.ContainerName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureBackupProtectionBackupNowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBackupProtectionBackupNowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureBackupProtectionBackupNowSettings.Ids"/></li>
        ///     <li><c>--item-name</c> via <see cref="AzureBackupProtectionBackupNowSettings.ItemName"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBackupProtectionBackupNowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBackupProtectionBackupNowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBackupProtectionBackupNowSettings.ResourceGroup"/></li>
        ///     <li><c>--retain-until</c> via <see cref="AzureBackupProtectionBackupNowSettings.RetainUntil"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBackupProtectionBackupNowSettings.Subscription"/></li>
        ///     <li><c>--vault-name</c> via <see cref="AzureBackupProtectionBackupNowSettings.VaultName"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBackupProtectionBackupNowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBackupProtectionBackupNow(Configure<AzureBackupProtectionBackupNowSettings> configurator)
        {
            return AzureBackupProtectionBackupNow(configurator(new AzureBackupProtectionBackupNowSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--container-name</c> via <see cref="AzureBackupProtectionBackupNowSettings.ContainerName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureBackupProtectionBackupNowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBackupProtectionBackupNowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureBackupProtectionBackupNowSettings.Ids"/></li>
        ///     <li><c>--item-name</c> via <see cref="AzureBackupProtectionBackupNowSettings.ItemName"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBackupProtectionBackupNowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBackupProtectionBackupNowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBackupProtectionBackupNowSettings.ResourceGroup"/></li>
        ///     <li><c>--retain-until</c> via <see cref="AzureBackupProtectionBackupNowSettings.RetainUntil"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBackupProtectionBackupNowSettings.Subscription"/></li>
        ///     <li><c>--vault-name</c> via <see cref="AzureBackupProtectionBackupNowSettings.VaultName"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBackupProtectionBackupNowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBackupProtectionBackupNowSettings Settings, IReadOnlyCollection<Output> Output)> AzureBackupProtectionBackupNow(CombinatorialConfigure<AzureBackupProtectionBackupNowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBackupProtectionBackupNow, AzureBackupLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBackupProtectionCheckVm(AzureBackupProtectionCheckVmSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBackupProtectionCheckVmSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBackupProtectionCheckVmSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBackupProtectionCheckVmSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBackupProtectionCheckVmSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBackupProtectionCheckVmSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBackupProtectionCheckVmSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBackupProtectionCheckVmSettings.Verbose"/></li>
        ///     <li><c>--vm-id</c> via <see cref="AzureBackupProtectionCheckVmSettings.VmId"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBackupProtectionCheckVm(Configure<AzureBackupProtectionCheckVmSettings> configurator)
        {
            return AzureBackupProtectionCheckVm(configurator(new AzureBackupProtectionCheckVmSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBackupProtectionCheckVmSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBackupProtectionCheckVmSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBackupProtectionCheckVmSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBackupProtectionCheckVmSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBackupProtectionCheckVmSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBackupProtectionCheckVmSettings.Verbose"/></li>
        ///     <li><c>--vm-id</c> via <see cref="AzureBackupProtectionCheckVmSettings.VmId"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBackupProtectionCheckVmSettings Settings, IReadOnlyCollection<Output> Output)> AzureBackupProtectionCheckVm(CombinatorialConfigure<AzureBackupProtectionCheckVmSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBackupProtectionCheckVm, AzureBackupLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBackupProtectionDisable(AzureBackupProtectionDisableSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBackupProtectionDisableSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--container-name</c> via <see cref="AzureBackupProtectionDisableSettings.ContainerName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureBackupProtectionDisableSettings.Debug"/></li>
        ///     <li><c>--delete-backup-data</c> via <see cref="AzureBackupProtectionDisableSettings.DeleteBackupData"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBackupProtectionDisableSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureBackupProtectionDisableSettings.Ids"/></li>
        ///     <li><c>--item-name</c> via <see cref="AzureBackupProtectionDisableSettings.ItemName"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBackupProtectionDisableSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBackupProtectionDisableSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBackupProtectionDisableSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBackupProtectionDisableSettings.Subscription"/></li>
        ///     <li><c>--vault-name</c> via <see cref="AzureBackupProtectionDisableSettings.VaultName"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBackupProtectionDisableSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureBackupProtectionDisableSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBackupProtectionDisable(Configure<AzureBackupProtectionDisableSettings> configurator)
        {
            return AzureBackupProtectionDisable(configurator(new AzureBackupProtectionDisableSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--container-name</c> via <see cref="AzureBackupProtectionDisableSettings.ContainerName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureBackupProtectionDisableSettings.Debug"/></li>
        ///     <li><c>--delete-backup-data</c> via <see cref="AzureBackupProtectionDisableSettings.DeleteBackupData"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBackupProtectionDisableSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureBackupProtectionDisableSettings.Ids"/></li>
        ///     <li><c>--item-name</c> via <see cref="AzureBackupProtectionDisableSettings.ItemName"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBackupProtectionDisableSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBackupProtectionDisableSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBackupProtectionDisableSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBackupProtectionDisableSettings.Subscription"/></li>
        ///     <li><c>--vault-name</c> via <see cref="AzureBackupProtectionDisableSettings.VaultName"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBackupProtectionDisableSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureBackupProtectionDisableSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBackupProtectionDisableSettings Settings, IReadOnlyCollection<Output> Output)> AzureBackupProtectionDisable(CombinatorialConfigure<AzureBackupProtectionDisableSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBackupProtectionDisable, AzureBackupLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBackupProtectionEnableForVm(AzureBackupProtectionEnableForVmSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBackupProtectionEnableForVmSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBackupProtectionEnableForVmSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBackupProtectionEnableForVmSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureBackupProtectionEnableForVmSettings.Ids"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBackupProtectionEnableForVmSettings.Output"/></li>
        ///     <li><c>--policy-name</c> via <see cref="AzureBackupProtectionEnableForVmSettings.PolicyName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBackupProtectionEnableForVmSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBackupProtectionEnableForVmSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBackupProtectionEnableForVmSettings.Subscription"/></li>
        ///     <li><c>--vault-name</c> via <see cref="AzureBackupProtectionEnableForVmSettings.VaultName"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBackupProtectionEnableForVmSettings.Verbose"/></li>
        ///     <li><c>--vm</c> via <see cref="AzureBackupProtectionEnableForVmSettings.Vm"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBackupProtectionEnableForVm(Configure<AzureBackupProtectionEnableForVmSettings> configurator)
        {
            return AzureBackupProtectionEnableForVm(configurator(new AzureBackupProtectionEnableForVmSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBackupProtectionEnableForVmSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBackupProtectionEnableForVmSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureBackupProtectionEnableForVmSettings.Ids"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBackupProtectionEnableForVmSettings.Output"/></li>
        ///     <li><c>--policy-name</c> via <see cref="AzureBackupProtectionEnableForVmSettings.PolicyName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBackupProtectionEnableForVmSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBackupProtectionEnableForVmSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBackupProtectionEnableForVmSettings.Subscription"/></li>
        ///     <li><c>--vault-name</c> via <see cref="AzureBackupProtectionEnableForVmSettings.VaultName"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBackupProtectionEnableForVmSettings.Verbose"/></li>
        ///     <li><c>--vm</c> via <see cref="AzureBackupProtectionEnableForVmSettings.Vm"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBackupProtectionEnableForVmSettings Settings, IReadOnlyCollection<Output> Output)> AzureBackupProtectionEnableForVm(CombinatorialConfigure<AzureBackupProtectionEnableForVmSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBackupProtectionEnableForVm, AzureBackupLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBackupRecoverypointList(AzureBackupRecoverypointListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBackupRecoverypointListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--container-name</c> via <see cref="AzureBackupRecoverypointListSettings.ContainerName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureBackupRecoverypointListSettings.Debug"/></li>
        ///     <li><c>--end-date</c> via <see cref="AzureBackupRecoverypointListSettings.EndDate"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBackupRecoverypointListSettings.Help"/></li>
        ///     <li><c>--item-name</c> via <see cref="AzureBackupRecoverypointListSettings.ItemName"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBackupRecoverypointListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBackupRecoverypointListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBackupRecoverypointListSettings.ResourceGroup"/></li>
        ///     <li><c>--start-date</c> via <see cref="AzureBackupRecoverypointListSettings.StartDate"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBackupRecoverypointListSettings.Subscription"/></li>
        ///     <li><c>--vault-name</c> via <see cref="AzureBackupRecoverypointListSettings.VaultName"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBackupRecoverypointListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBackupRecoverypointList(Configure<AzureBackupRecoverypointListSettings> configurator)
        {
            return AzureBackupRecoverypointList(configurator(new AzureBackupRecoverypointListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--container-name</c> via <see cref="AzureBackupRecoverypointListSettings.ContainerName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureBackupRecoverypointListSettings.Debug"/></li>
        ///     <li><c>--end-date</c> via <see cref="AzureBackupRecoverypointListSettings.EndDate"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBackupRecoverypointListSettings.Help"/></li>
        ///     <li><c>--item-name</c> via <see cref="AzureBackupRecoverypointListSettings.ItemName"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBackupRecoverypointListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBackupRecoverypointListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBackupRecoverypointListSettings.ResourceGroup"/></li>
        ///     <li><c>--start-date</c> via <see cref="AzureBackupRecoverypointListSettings.StartDate"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBackupRecoverypointListSettings.Subscription"/></li>
        ///     <li><c>--vault-name</c> via <see cref="AzureBackupRecoverypointListSettings.VaultName"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBackupRecoverypointListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBackupRecoverypointListSettings Settings, IReadOnlyCollection<Output> Output)> AzureBackupRecoverypointList(CombinatorialConfigure<AzureBackupRecoverypointListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBackupRecoverypointList, AzureBackupLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBackupRecoverypointShow(AzureBackupRecoverypointShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBackupRecoverypointShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--container-name</c> via <see cref="AzureBackupRecoverypointShowSettings.ContainerName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureBackupRecoverypointShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBackupRecoverypointShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureBackupRecoverypointShowSettings.Ids"/></li>
        ///     <li><c>--item-name</c> via <see cref="AzureBackupRecoverypointShowSettings.ItemName"/></li>
        ///     <li><c>--name</c> via <see cref="AzureBackupRecoverypointShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBackupRecoverypointShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBackupRecoverypointShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBackupRecoverypointShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBackupRecoverypointShowSettings.Subscription"/></li>
        ///     <li><c>--vault-name</c> via <see cref="AzureBackupRecoverypointShowSettings.VaultName"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBackupRecoverypointShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBackupRecoverypointShow(Configure<AzureBackupRecoverypointShowSettings> configurator)
        {
            return AzureBackupRecoverypointShow(configurator(new AzureBackupRecoverypointShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--container-name</c> via <see cref="AzureBackupRecoverypointShowSettings.ContainerName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureBackupRecoverypointShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBackupRecoverypointShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureBackupRecoverypointShowSettings.Ids"/></li>
        ///     <li><c>--item-name</c> via <see cref="AzureBackupRecoverypointShowSettings.ItemName"/></li>
        ///     <li><c>--name</c> via <see cref="AzureBackupRecoverypointShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBackupRecoverypointShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBackupRecoverypointShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBackupRecoverypointShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBackupRecoverypointShowSettings.Subscription"/></li>
        ///     <li><c>--vault-name</c> via <see cref="AzureBackupRecoverypointShowSettings.VaultName"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBackupRecoverypointShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBackupRecoverypointShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureBackupRecoverypointShow(CombinatorialConfigure<AzureBackupRecoverypointShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBackupRecoverypointShow, AzureBackupLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBackupRestoreRestoreDisks(AzureBackupRestoreRestoreDisksSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBackupRestoreRestoreDisksSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--container-name</c> via <see cref="AzureBackupRestoreRestoreDisksSettings.ContainerName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureBackupRestoreRestoreDisksSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBackupRestoreRestoreDisksSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureBackupRestoreRestoreDisksSettings.Ids"/></li>
        ///     <li><c>--item-name</c> via <see cref="AzureBackupRestoreRestoreDisksSettings.ItemName"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBackupRestoreRestoreDisksSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBackupRestoreRestoreDisksSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBackupRestoreRestoreDisksSettings.ResourceGroup"/></li>
        ///     <li><c>--restore-to-staging-storage-account</c> via <see cref="AzureBackupRestoreRestoreDisksSettings.RestoreToStagingStorageAccount"/></li>
        ///     <li><c>--rp-name</c> via <see cref="AzureBackupRestoreRestoreDisksSettings.RpName"/></li>
        ///     <li><c>--storage-account</c> via <see cref="AzureBackupRestoreRestoreDisksSettings.StorageAccount"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBackupRestoreRestoreDisksSettings.Subscription"/></li>
        ///     <li><c>--vault-name</c> via <see cref="AzureBackupRestoreRestoreDisksSettings.VaultName"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBackupRestoreRestoreDisksSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBackupRestoreRestoreDisks(Configure<AzureBackupRestoreRestoreDisksSettings> configurator)
        {
            return AzureBackupRestoreRestoreDisks(configurator(new AzureBackupRestoreRestoreDisksSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--container-name</c> via <see cref="AzureBackupRestoreRestoreDisksSettings.ContainerName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureBackupRestoreRestoreDisksSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBackupRestoreRestoreDisksSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureBackupRestoreRestoreDisksSettings.Ids"/></li>
        ///     <li><c>--item-name</c> via <see cref="AzureBackupRestoreRestoreDisksSettings.ItemName"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBackupRestoreRestoreDisksSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBackupRestoreRestoreDisksSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBackupRestoreRestoreDisksSettings.ResourceGroup"/></li>
        ///     <li><c>--restore-to-staging-storage-account</c> via <see cref="AzureBackupRestoreRestoreDisksSettings.RestoreToStagingStorageAccount"/></li>
        ///     <li><c>--rp-name</c> via <see cref="AzureBackupRestoreRestoreDisksSettings.RpName"/></li>
        ///     <li><c>--storage-account</c> via <see cref="AzureBackupRestoreRestoreDisksSettings.StorageAccount"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBackupRestoreRestoreDisksSettings.Subscription"/></li>
        ///     <li><c>--vault-name</c> via <see cref="AzureBackupRestoreRestoreDisksSettings.VaultName"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBackupRestoreRestoreDisksSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBackupRestoreRestoreDisksSettings Settings, IReadOnlyCollection<Output> Output)> AzureBackupRestoreRestoreDisks(CombinatorialConfigure<AzureBackupRestoreRestoreDisksSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBackupRestoreRestoreDisks, AzureBackupLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBackupVaultCreate(AzureBackupVaultCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBackupVaultCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBackupVaultCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBackupVaultCreateSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureBackupVaultCreateSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureBackupVaultCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBackupVaultCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBackupVaultCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBackupVaultCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBackupVaultCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBackupVaultCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBackupVaultCreate(Configure<AzureBackupVaultCreateSettings> configurator)
        {
            return AzureBackupVaultCreate(configurator(new AzureBackupVaultCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBackupVaultCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBackupVaultCreateSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureBackupVaultCreateSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureBackupVaultCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBackupVaultCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBackupVaultCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBackupVaultCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBackupVaultCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBackupVaultCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBackupVaultCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureBackupVaultCreate(CombinatorialConfigure<AzureBackupVaultCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBackupVaultCreate, AzureBackupLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBackupVaultDelete(AzureBackupVaultDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBackupVaultDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBackupVaultDeleteSettings.Debug"/></li>
        ///     <li><c>--force</c> via <see cref="AzureBackupVaultDeleteSettings.Force"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBackupVaultDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureBackupVaultDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureBackupVaultDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBackupVaultDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBackupVaultDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBackupVaultDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBackupVaultDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBackupVaultDeleteSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureBackupVaultDeleteSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBackupVaultDelete(Configure<AzureBackupVaultDeleteSettings> configurator)
        {
            return AzureBackupVaultDelete(configurator(new AzureBackupVaultDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBackupVaultDeleteSettings.Debug"/></li>
        ///     <li><c>--force</c> via <see cref="AzureBackupVaultDeleteSettings.Force"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBackupVaultDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureBackupVaultDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureBackupVaultDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBackupVaultDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBackupVaultDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBackupVaultDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBackupVaultDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBackupVaultDeleteSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureBackupVaultDeleteSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBackupVaultDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureBackupVaultDelete(CombinatorialConfigure<AzureBackupVaultDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBackupVaultDelete, AzureBackupLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBackupVaultList(AzureBackupVaultListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBackupVaultListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBackupVaultListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBackupVaultListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBackupVaultListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBackupVaultListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBackupVaultListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBackupVaultListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBackupVaultListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBackupVaultList(Configure<AzureBackupVaultListSettings> configurator)
        {
            return AzureBackupVaultList(configurator(new AzureBackupVaultListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBackupVaultListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBackupVaultListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBackupVaultListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBackupVaultListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBackupVaultListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBackupVaultListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBackupVaultListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBackupVaultListSettings Settings, IReadOnlyCollection<Output> Output)> AzureBackupVaultList(CombinatorialConfigure<AzureBackupVaultListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBackupVaultList, AzureBackupLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBackupVaultShow(AzureBackupVaultShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBackupVaultShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBackupVaultShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBackupVaultShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureBackupVaultShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureBackupVaultShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBackupVaultShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBackupVaultShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBackupVaultShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBackupVaultShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBackupVaultShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBackupVaultShow(Configure<AzureBackupVaultShowSettings> configurator)
        {
            return AzureBackupVaultShow(configurator(new AzureBackupVaultShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBackupVaultShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBackupVaultShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureBackupVaultShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureBackupVaultShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBackupVaultShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBackupVaultShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBackupVaultShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBackupVaultShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBackupVaultShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBackupVaultShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureBackupVaultShow(CombinatorialConfigure<AzureBackupVaultShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBackupVaultShow, AzureBackupLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBackupRestoreFilesMountRp(AzureBackupRestoreFilesMountRpSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBackupRestoreFilesMountRpSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--container-name</c> via <see cref="AzureBackupRestoreFilesMountRpSettings.ContainerName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureBackupRestoreFilesMountRpSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBackupRestoreFilesMountRpSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureBackupRestoreFilesMountRpSettings.Ids"/></li>
        ///     <li><c>--item-name</c> via <see cref="AzureBackupRestoreFilesMountRpSettings.ItemName"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBackupRestoreFilesMountRpSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBackupRestoreFilesMountRpSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBackupRestoreFilesMountRpSettings.ResourceGroup"/></li>
        ///     <li><c>--rp-name</c> via <see cref="AzureBackupRestoreFilesMountRpSettings.RpName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBackupRestoreFilesMountRpSettings.Subscription"/></li>
        ///     <li><c>--vault-name</c> via <see cref="AzureBackupRestoreFilesMountRpSettings.VaultName"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBackupRestoreFilesMountRpSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBackupRestoreFilesMountRp(Configure<AzureBackupRestoreFilesMountRpSettings> configurator)
        {
            return AzureBackupRestoreFilesMountRp(configurator(new AzureBackupRestoreFilesMountRpSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--container-name</c> via <see cref="AzureBackupRestoreFilesMountRpSettings.ContainerName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureBackupRestoreFilesMountRpSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBackupRestoreFilesMountRpSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureBackupRestoreFilesMountRpSettings.Ids"/></li>
        ///     <li><c>--item-name</c> via <see cref="AzureBackupRestoreFilesMountRpSettings.ItemName"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBackupRestoreFilesMountRpSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBackupRestoreFilesMountRpSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBackupRestoreFilesMountRpSettings.ResourceGroup"/></li>
        ///     <li><c>--rp-name</c> via <see cref="AzureBackupRestoreFilesMountRpSettings.RpName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBackupRestoreFilesMountRpSettings.Subscription"/></li>
        ///     <li><c>--vault-name</c> via <see cref="AzureBackupRestoreFilesMountRpSettings.VaultName"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBackupRestoreFilesMountRpSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBackupRestoreFilesMountRpSettings Settings, IReadOnlyCollection<Output> Output)> AzureBackupRestoreFilesMountRp(CombinatorialConfigure<AzureBackupRestoreFilesMountRpSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBackupRestoreFilesMountRp, AzureBackupLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBackupRestoreFilesUnmountRp(AzureBackupRestoreFilesUnmountRpSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBackupRestoreFilesUnmountRpSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--container-name</c> via <see cref="AzureBackupRestoreFilesUnmountRpSettings.ContainerName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureBackupRestoreFilesUnmountRpSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBackupRestoreFilesUnmountRpSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureBackupRestoreFilesUnmountRpSettings.Ids"/></li>
        ///     <li><c>--item-name</c> via <see cref="AzureBackupRestoreFilesUnmountRpSettings.ItemName"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBackupRestoreFilesUnmountRpSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBackupRestoreFilesUnmountRpSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBackupRestoreFilesUnmountRpSettings.ResourceGroup"/></li>
        ///     <li><c>--rp-name</c> via <see cref="AzureBackupRestoreFilesUnmountRpSettings.RpName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBackupRestoreFilesUnmountRpSettings.Subscription"/></li>
        ///     <li><c>--vault-name</c> via <see cref="AzureBackupRestoreFilesUnmountRpSettings.VaultName"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBackupRestoreFilesUnmountRpSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBackupRestoreFilesUnmountRp(Configure<AzureBackupRestoreFilesUnmountRpSettings> configurator)
        {
            return AzureBackupRestoreFilesUnmountRp(configurator(new AzureBackupRestoreFilesUnmountRpSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--container-name</c> via <see cref="AzureBackupRestoreFilesUnmountRpSettings.ContainerName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureBackupRestoreFilesUnmountRpSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBackupRestoreFilesUnmountRpSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureBackupRestoreFilesUnmountRpSettings.Ids"/></li>
        ///     <li><c>--item-name</c> via <see cref="AzureBackupRestoreFilesUnmountRpSettings.ItemName"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBackupRestoreFilesUnmountRpSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBackupRestoreFilesUnmountRpSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBackupRestoreFilesUnmountRpSettings.ResourceGroup"/></li>
        ///     <li><c>--rp-name</c> via <see cref="AzureBackupRestoreFilesUnmountRpSettings.RpName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBackupRestoreFilesUnmountRpSettings.Subscription"/></li>
        ///     <li><c>--vault-name</c> via <see cref="AzureBackupRestoreFilesUnmountRpSettings.VaultName"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBackupRestoreFilesUnmountRpSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBackupRestoreFilesUnmountRpSettings Settings, IReadOnlyCollection<Output> Output)> AzureBackupRestoreFilesUnmountRp(CombinatorialConfigure<AzureBackupRestoreFilesUnmountRpSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBackupRestoreFilesUnmountRp, AzureBackupLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBackupVaultBackupPropertiesSet(AzureBackupVaultBackupPropertiesSetSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBackupVaultBackupPropertiesSetSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--backup-storage-redundancy</c> via <see cref="AzureBackupVaultBackupPropertiesSetSettings.BackupStorageRedundancy"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureBackupVaultBackupPropertiesSetSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBackupVaultBackupPropertiesSetSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureBackupVaultBackupPropertiesSetSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureBackupVaultBackupPropertiesSetSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBackupVaultBackupPropertiesSetSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBackupVaultBackupPropertiesSetSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBackupVaultBackupPropertiesSetSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBackupVaultBackupPropertiesSetSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBackupVaultBackupPropertiesSetSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBackupVaultBackupPropertiesSet(Configure<AzureBackupVaultBackupPropertiesSetSettings> configurator)
        {
            return AzureBackupVaultBackupPropertiesSet(configurator(new AzureBackupVaultBackupPropertiesSetSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--backup-storage-redundancy</c> via <see cref="AzureBackupVaultBackupPropertiesSetSettings.BackupStorageRedundancy"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureBackupVaultBackupPropertiesSetSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBackupVaultBackupPropertiesSetSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureBackupVaultBackupPropertiesSetSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureBackupVaultBackupPropertiesSetSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBackupVaultBackupPropertiesSetSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBackupVaultBackupPropertiesSetSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBackupVaultBackupPropertiesSetSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBackupVaultBackupPropertiesSetSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBackupVaultBackupPropertiesSetSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBackupVaultBackupPropertiesSetSettings Settings, IReadOnlyCollection<Output> Output)> AzureBackupVaultBackupPropertiesSet(CombinatorialConfigure<AzureBackupVaultBackupPropertiesSetSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBackupVaultBackupPropertiesSet, AzureBackupLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBackupVaultBackupPropertiesShow(AzureBackupVaultBackupPropertiesShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBackupVaultBackupPropertiesShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBackupVaultBackupPropertiesShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBackupVaultBackupPropertiesShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureBackupVaultBackupPropertiesShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureBackupVaultBackupPropertiesShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBackupVaultBackupPropertiesShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBackupVaultBackupPropertiesShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBackupVaultBackupPropertiesShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBackupVaultBackupPropertiesShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBackupVaultBackupPropertiesShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBackupVaultBackupPropertiesShow(Configure<AzureBackupVaultBackupPropertiesShowSettings> configurator)
        {
            return AzureBackupVaultBackupPropertiesShow(configurator(new AzureBackupVaultBackupPropertiesShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Backups.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/backup?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBackupVaultBackupPropertiesShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBackupVaultBackupPropertiesShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureBackupVaultBackupPropertiesShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureBackupVaultBackupPropertiesShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBackupVaultBackupPropertiesShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBackupVaultBackupPropertiesShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBackupVaultBackupPropertiesShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBackupVaultBackupPropertiesShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBackupVaultBackupPropertiesShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBackupVaultBackupPropertiesShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureBackupVaultBackupPropertiesShow(CombinatorialConfigure<AzureBackupVaultBackupPropertiesShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBackupVaultBackupPropertiesShow, AzureBackupLogger, degreeOfParallelism, completeOnFailure);
        }
    }
    #region AzureBackupSettings
    /// <summary>
    ///   Used within <see cref="AzureBackupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBackupSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBackup executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBackupTasks.AzureBackupPath;
        public override Action<OutputType, string> CustomLogger => AzureBackupTasks.AzureBackupLogger;
        /// <summary>
        ///   Increase logging verbosity to show all debug logs.
        /// </summary>
        public virtual string Debug { get; internal set; }
        /// <summary>
        ///   Show this help message and exit.
        /// </summary>
        public virtual string Help { get; internal set; }
        /// <summary>
        ///   Output format.
        /// </summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary>
        ///   JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.
        /// </summary>
        public virtual string Query { get; internal set; }
        /// <summary>
        ///   Increase logging verbosity. Use --debug for full debug logs.
        /// </summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("backup")
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureBackupContainerListSettings
    /// <summary>
    ///   Used within <see cref="AzureBackupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBackupContainerListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBackup executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBackupTasks.AzureBackupPath;
        public override Action<OutputType, string> CustomLogger => AzureBackupTasks.AzureBackupLogger;
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Name of the Recovery services vault.
        /// </summary>
        public virtual string VaultName { get; internal set; }
        /// <summary>
        ///   Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.
        /// </summary>
        public virtual string Subscription { get; internal set; }
        /// <summary>
        ///   Increase logging verbosity to show all debug logs.
        /// </summary>
        public virtual string Debug { get; internal set; }
        /// <summary>
        ///   Show this help message and exit.
        /// </summary>
        public virtual string Help { get; internal set; }
        /// <summary>
        ///   Output format.
        /// </summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary>
        ///   JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.
        /// </summary>
        public virtual string Query { get; internal set; }
        /// <summary>
        ///   Increase logging verbosity. Use --debug for full debug logs.
        /// </summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("backup container list")
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--vault-name {value}", VaultName)
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
    #region AzureBackupContainerShowSettings
    /// <summary>
    ///   Used within <see cref="AzureBackupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBackupContainerShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBackup executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBackupTasks.AzureBackupPath;
        public override Action<OutputType, string> CustomLogger => AzureBackupTasks.AzureBackupLogger;
        /// <summary>
        ///   Name of the container. You can use the backup container list command to get the name of a container.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.
        /// </summary>
        public virtual string Subscription { get; internal set; }
        /// <summary>
        ///   Name of the Recovery services vault.
        /// </summary>
        public virtual string VaultName { get; internal set; }
        /// <summary>
        ///   Increase logging verbosity to show all debug logs.
        /// </summary>
        public virtual string Debug { get; internal set; }
        /// <summary>
        ///   Show this help message and exit.
        /// </summary>
        public virtual string Help { get; internal set; }
        /// <summary>
        ///   Output format.
        /// </summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary>
        ///   JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.
        /// </summary>
        public virtual string Query { get; internal set; }
        /// <summary>
        ///   Increase logging verbosity. Use --debug for full debug logs.
        /// </summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("backup container show")
              .Add("--name {value}", Name)
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--subscription {value}", Subscription)
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
    #region AzureBackupItemListSettings
    /// <summary>
    ///   Used within <see cref="AzureBackupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBackupItemListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBackup executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBackupTasks.AzureBackupPath;
        public override Action<OutputType, string> CustomLogger => AzureBackupTasks.AzureBackupLogger;
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Name of the Recovery services vault.
        /// </summary>
        public virtual string VaultName { get; internal set; }
        /// <summary>
        ///   Name of the container.
        /// </summary>
        public virtual string ContainerName { get; internal set; }
        /// <summary>
        ///   Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.
        /// </summary>
        public virtual string Subscription { get; internal set; }
        /// <summary>
        ///   Increase logging verbosity to show all debug logs.
        /// </summary>
        public virtual string Debug { get; internal set; }
        /// <summary>
        ///   Show this help message and exit.
        /// </summary>
        public virtual string Help { get; internal set; }
        /// <summary>
        ///   Output format.
        /// </summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary>
        ///   JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.
        /// </summary>
        public virtual string Query { get; internal set; }
        /// <summary>
        ///   Increase logging verbosity. Use --debug for full debug logs.
        /// </summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("backup item list")
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--vault-name {value}", VaultName)
              .Add("--container-name {value}", ContainerName)
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
    #region AzureBackupItemSetPolicySettings
    /// <summary>
    ///   Used within <see cref="AzureBackupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBackupItemSetPolicySettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBackup executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBackupTasks.AzureBackupPath;
        public override Action<OutputType, string> CustomLogger => AzureBackupTasks.AzureBackupLogger;
        /// <summary>
        ///   Name of the container.
        /// </summary>
        public virtual string ContainerName { get; internal set; }
        /// <summary>
        ///   Name of the Backup policy. You can use the backup policy list command to get the name of a backup policy.
        /// </summary>
        public virtual string PolicyName { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of the backed up item. You can use the backup item list command to get the name of a backed up item.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.
        /// </summary>
        public virtual string Subscription { get; internal set; }
        /// <summary>
        ///   Name of the Recovery services vault.
        /// </summary>
        public virtual string VaultName { get; internal set; }
        /// <summary>
        ///   Increase logging verbosity to show all debug logs.
        /// </summary>
        public virtual string Debug { get; internal set; }
        /// <summary>
        ///   Show this help message and exit.
        /// </summary>
        public virtual string Help { get; internal set; }
        /// <summary>
        ///   Output format.
        /// </summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary>
        ///   JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.
        /// </summary>
        public virtual string Query { get; internal set; }
        /// <summary>
        ///   Increase logging verbosity. Use --debug for full debug logs.
        /// </summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("backup item set-policy")
              .Add("--container-name {value}", ContainerName)
              .Add("--policy-name {value}", PolicyName)
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--subscription {value}", Subscription)
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
    #region AzureBackupItemShowSettings
    /// <summary>
    ///   Used within <see cref="AzureBackupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBackupItemShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBackup executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBackupTasks.AzureBackupPath;
        public override Action<OutputType, string> CustomLogger => AzureBackupTasks.AzureBackupLogger;
        /// <summary>
        ///   Name of the container.
        /// </summary>
        public virtual string ContainerName { get; internal set; }
        /// <summary>
        ///   Name of the backed up item. You can use the backup item list command to get the name of a backed up item.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.
        /// </summary>
        public virtual string Subscription { get; internal set; }
        /// <summary>
        ///   Name of the Recovery services vault.
        /// </summary>
        public virtual string VaultName { get; internal set; }
        /// <summary>
        ///   Increase logging verbosity to show all debug logs.
        /// </summary>
        public virtual string Debug { get; internal set; }
        /// <summary>
        ///   Show this help message and exit.
        /// </summary>
        public virtual string Help { get; internal set; }
        /// <summary>
        ///   Output format.
        /// </summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary>
        ///   JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.
        /// </summary>
        public virtual string Query { get; internal set; }
        /// <summary>
        ///   Increase logging verbosity. Use --debug for full debug logs.
        /// </summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("backup item show")
              .Add("--container-name {value}", ContainerName)
              .Add("--name {value}", Name)
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--subscription {value}", Subscription)
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
    #region AzureBackupJobListSettings
    /// <summary>
    ///   Used within <see cref="AzureBackupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBackupJobListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBackup executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBackupTasks.AzureBackupPath;
        public override Action<OutputType, string> CustomLogger => AzureBackupTasks.AzureBackupLogger;
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Name of the Recovery services vault.
        /// </summary>
        public virtual string VaultName { get; internal set; }
        /// <summary>
        ///   The end date of the range in UTC (d-m-Y).
        /// </summary>
        public virtual string EndDate { get; internal set; }
        /// <summary>
        ///   User initiated operation.
        /// </summary>
        public virtual BackupJobListOperation Operation { get; internal set; }
        /// <summary>
        ///   The start date of the range in UTC (d-m-Y).
        /// </summary>
        public virtual string StartDate { get; internal set; }
        /// <summary>
        ///   Status of the Job.
        /// </summary>
        public virtual BackupJobListStatus Status { get; internal set; }
        /// <summary>
        ///   Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.
        /// </summary>
        public virtual string Subscription { get; internal set; }
        /// <summary>
        ///   Increase logging verbosity to show all debug logs.
        /// </summary>
        public virtual string Debug { get; internal set; }
        /// <summary>
        ///   Show this help message and exit.
        /// </summary>
        public virtual string Help { get; internal set; }
        /// <summary>
        ///   Output format.
        /// </summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary>
        ///   JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.
        /// </summary>
        public virtual string Query { get; internal set; }
        /// <summary>
        ///   Increase logging verbosity. Use --debug for full debug logs.
        /// </summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("backup job list")
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--vault-name {value}", VaultName)
              .Add("--end-date {value}", EndDate)
              .Add("--operation {value}", Operation)
              .Add("--start-date {value}", StartDate)
              .Add("--status {value}", Status)
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
    #region AzureBackupJobShowSettings
    /// <summary>
    ///   Used within <see cref="AzureBackupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBackupJobShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBackup executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBackupTasks.AzureBackupPath;
        public override Action<OutputType, string> CustomLogger => AzureBackupTasks.AzureBackupLogger;
        /// <summary>
        ///   Name of the job. You can use the backup job list command to get the name of a job.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.
        /// </summary>
        public virtual string Subscription { get; internal set; }
        /// <summary>
        ///   Name of the Recovery services vault.
        /// </summary>
        public virtual string VaultName { get; internal set; }
        /// <summary>
        ///   Increase logging verbosity to show all debug logs.
        /// </summary>
        public virtual string Debug { get; internal set; }
        /// <summary>
        ///   Show this help message and exit.
        /// </summary>
        public virtual string Help { get; internal set; }
        /// <summary>
        ///   Output format.
        /// </summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary>
        ///   JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.
        /// </summary>
        public virtual string Query { get; internal set; }
        /// <summary>
        ///   Increase logging verbosity. Use --debug for full debug logs.
        /// </summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("backup job show")
              .Add("--name {value}", Name)
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--subscription {value}", Subscription)
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
    #region AzureBackupJobStopSettings
    /// <summary>
    ///   Used within <see cref="AzureBackupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBackupJobStopSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBackup executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBackupTasks.AzureBackupPath;
        public override Action<OutputType, string> CustomLogger => AzureBackupTasks.AzureBackupLogger;
        /// <summary>
        ///   Name of the job. You can use the backup job list command to get the name of a job.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.
        /// </summary>
        public virtual string Subscription { get; internal set; }
        /// <summary>
        ///   Name of the Recovery services vault.
        /// </summary>
        public virtual string VaultName { get; internal set; }
        /// <summary>
        ///   Increase logging verbosity to show all debug logs.
        /// </summary>
        public virtual string Debug { get; internal set; }
        /// <summary>
        ///   Show this help message and exit.
        /// </summary>
        public virtual string Help { get; internal set; }
        /// <summary>
        ///   Output format.
        /// </summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary>
        ///   JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.
        /// </summary>
        public virtual string Query { get; internal set; }
        /// <summary>
        ///   Increase logging verbosity. Use --debug for full debug logs.
        /// </summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("backup job stop")
              .Add("--name {value}", Name)
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--subscription {value}", Subscription)
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
    #region AzureBackupJobWaitSettings
    /// <summary>
    ///   Used within <see cref="AzureBackupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBackupJobWaitSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBackup executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBackupTasks.AzureBackupPath;
        public override Action<OutputType, string> CustomLogger => AzureBackupTasks.AzureBackupLogger;
        /// <summary>
        ///   Name of the job. You can use the backup job list command to get the name of a job.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Maximum time, in seconds, to wait before aborting.
        /// </summary>
        public virtual string Timeout { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.
        /// </summary>
        public virtual string Subscription { get; internal set; }
        /// <summary>
        ///   Name of the Recovery services vault.
        /// </summary>
        public virtual string VaultName { get; internal set; }
        /// <summary>
        ///   Increase logging verbosity to show all debug logs.
        /// </summary>
        public virtual string Debug { get; internal set; }
        /// <summary>
        ///   Show this help message and exit.
        /// </summary>
        public virtual string Help { get; internal set; }
        /// <summary>
        ///   Output format.
        /// </summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary>
        ///   JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.
        /// </summary>
        public virtual string Query { get; internal set; }
        /// <summary>
        ///   Increase logging verbosity. Use --debug for full debug logs.
        /// </summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("backup job wait")
              .Add("--name {value}", Name)
              .Add("--timeout {value}", Timeout)
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--subscription {value}", Subscription)
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
    #region AzureBackupPolicyDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureBackupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBackupPolicyDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBackup executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBackupTasks.AzureBackupPath;
        public override Action<OutputType, string> CustomLogger => AzureBackupTasks.AzureBackupLogger;
        /// <summary>
        ///   Name of the backup policy. You can use the backup policy list command to get the name of a policy.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.
        /// </summary>
        public virtual string Subscription { get; internal set; }
        /// <summary>
        ///   Name of the Recovery services vault.
        /// </summary>
        public virtual string VaultName { get; internal set; }
        /// <summary>
        ///   Increase logging verbosity to show all debug logs.
        /// </summary>
        public virtual string Debug { get; internal set; }
        /// <summary>
        ///   Show this help message and exit.
        /// </summary>
        public virtual string Help { get; internal set; }
        /// <summary>
        ///   Output format.
        /// </summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary>
        ///   JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.
        /// </summary>
        public virtual string Query { get; internal set; }
        /// <summary>
        ///   Increase logging verbosity. Use --debug for full debug logs.
        /// </summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("backup policy delete")
              .Add("--name {value}", Name)
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--subscription {value}", Subscription)
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
    #region AzureBackupPolicyGetDefaultForVmSettings
    /// <summary>
    ///   Used within <see cref="AzureBackupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBackupPolicyGetDefaultForVmSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBackup executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBackupTasks.AzureBackupPath;
        public override Action<OutputType, string> CustomLogger => AzureBackupTasks.AzureBackupLogger;
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.
        /// </summary>
        public virtual string Subscription { get; internal set; }
        /// <summary>
        ///   Name of the Recovery services vault.
        /// </summary>
        public virtual string VaultName { get; internal set; }
        /// <summary>
        ///   Increase logging verbosity to show all debug logs.
        /// </summary>
        public virtual string Debug { get; internal set; }
        /// <summary>
        ///   Show this help message and exit.
        /// </summary>
        public virtual string Help { get; internal set; }
        /// <summary>
        ///   Output format.
        /// </summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary>
        ///   JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.
        /// </summary>
        public virtual string Query { get; internal set; }
        /// <summary>
        ///   Increase logging verbosity. Use --debug for full debug logs.
        /// </summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("backup policy get-default-for-vm")
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--subscription {value}", Subscription)
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
    #region AzureBackupPolicyListSettings
    /// <summary>
    ///   Used within <see cref="AzureBackupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBackupPolicyListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBackup executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBackupTasks.AzureBackupPath;
        public override Action<OutputType, string> CustomLogger => AzureBackupTasks.AzureBackupLogger;
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Name of the Recovery services vault.
        /// </summary>
        public virtual string VaultName { get; internal set; }
        /// <summary>
        ///   Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.
        /// </summary>
        public virtual string Subscription { get; internal set; }
        /// <summary>
        ///   Increase logging verbosity to show all debug logs.
        /// </summary>
        public virtual string Debug { get; internal set; }
        /// <summary>
        ///   Show this help message and exit.
        /// </summary>
        public virtual string Help { get; internal set; }
        /// <summary>
        ///   Output format.
        /// </summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary>
        ///   JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.
        /// </summary>
        public virtual string Query { get; internal set; }
        /// <summary>
        ///   Increase logging verbosity. Use --debug for full debug logs.
        /// </summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("backup policy list")
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--vault-name {value}", VaultName)
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
    #region AzureBackupPolicyListAssociatedItemsSettings
    /// <summary>
    ///   Used within <see cref="AzureBackupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBackupPolicyListAssociatedItemsSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBackup executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBackupTasks.AzureBackupPath;
        public override Action<OutputType, string> CustomLogger => AzureBackupTasks.AzureBackupLogger;
        /// <summary>
        ///   Name of the backup policy. You can use the backup policy list command to get the name of a policy.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.
        /// </summary>
        public virtual string Subscription { get; internal set; }
        /// <summary>
        ///   Name of the Recovery services vault.
        /// </summary>
        public virtual string VaultName { get; internal set; }
        /// <summary>
        ///   Increase logging verbosity to show all debug logs.
        /// </summary>
        public virtual string Debug { get; internal set; }
        /// <summary>
        ///   Show this help message and exit.
        /// </summary>
        public virtual string Help { get; internal set; }
        /// <summary>
        ///   Output format.
        /// </summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary>
        ///   JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.
        /// </summary>
        public virtual string Query { get; internal set; }
        /// <summary>
        ///   Increase logging verbosity. Use --debug for full debug logs.
        /// </summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("backup policy list-associated-items")
              .Add("--name {value}", Name)
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--subscription {value}", Subscription)
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
    #region AzureBackupPolicySetSettings
    /// <summary>
    ///   Used within <see cref="AzureBackupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBackupPolicySetSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBackup executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBackupTasks.AzureBackupPath;
        public override Action<OutputType, string> CustomLogger => AzureBackupTasks.AzureBackupLogger;
        /// <summary>
        ///   JSON encoded policy definition. Use the show command with JSON output to obtain a policy object. Modify the values using a file editor and pass the object.
        /// </summary>
        public virtual string Policy { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.
        /// </summary>
        public virtual string Subscription { get; internal set; }
        /// <summary>
        ///   Name of the Recovery services vault.
        /// </summary>
        public virtual string VaultName { get; internal set; }
        /// <summary>
        ///   Increase logging verbosity to show all debug logs.
        /// </summary>
        public virtual string Debug { get; internal set; }
        /// <summary>
        ///   Show this help message and exit.
        /// </summary>
        public virtual string Help { get; internal set; }
        /// <summary>
        ///   Output format.
        /// </summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary>
        ///   JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.
        /// </summary>
        public virtual string Query { get; internal set; }
        /// <summary>
        ///   Increase logging verbosity. Use --debug for full debug logs.
        /// </summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("backup policy set")
              .Add("--policy {value}", Policy)
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--subscription {value}", Subscription)
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
    #region AzureBackupPolicyShowSettings
    /// <summary>
    ///   Used within <see cref="AzureBackupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBackupPolicyShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBackup executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBackupTasks.AzureBackupPath;
        public override Action<OutputType, string> CustomLogger => AzureBackupTasks.AzureBackupLogger;
        /// <summary>
        ///   Name of the backup policy. You can use the backup policy list command to get the name of a policy.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.
        /// </summary>
        public virtual string Subscription { get; internal set; }
        /// <summary>
        ///   Name of the Recovery services vault.
        /// </summary>
        public virtual string VaultName { get; internal set; }
        /// <summary>
        ///   Increase logging verbosity to show all debug logs.
        /// </summary>
        public virtual string Debug { get; internal set; }
        /// <summary>
        ///   Show this help message and exit.
        /// </summary>
        public virtual string Help { get; internal set; }
        /// <summary>
        ///   Output format.
        /// </summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary>
        ///   JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.
        /// </summary>
        public virtual string Query { get; internal set; }
        /// <summary>
        ///   Increase logging verbosity. Use --debug for full debug logs.
        /// </summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("backup policy show")
              .Add("--name {value}", Name)
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--subscription {value}", Subscription)
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
    #region AzureBackupProtectionBackupNowSettings
    /// <summary>
    ///   Used within <see cref="AzureBackupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBackupProtectionBackupNowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBackup executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBackupTasks.AzureBackupPath;
        public override Action<OutputType, string> CustomLogger => AzureBackupTasks.AzureBackupLogger;
        /// <summary>
        ///   Name of the container.
        /// </summary>
        public virtual string ContainerName { get; internal set; }
        /// <summary>
        ///   Name of the backed up item.
        /// </summary>
        public virtual string ItemName { get; internal set; }
        /// <summary>
        ///   The date until which this backed up copy will be available for retrieval, in UTC (d-m-Y).
        /// </summary>
        public virtual string RetainUntil { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.
        /// </summary>
        public virtual string Subscription { get; internal set; }
        /// <summary>
        ///   Name of the Recovery services vault.
        /// </summary>
        public virtual string VaultName { get; internal set; }
        /// <summary>
        ///   Increase logging verbosity to show all debug logs.
        /// </summary>
        public virtual string Debug { get; internal set; }
        /// <summary>
        ///   Show this help message and exit.
        /// </summary>
        public virtual string Help { get; internal set; }
        /// <summary>
        ///   Output format.
        /// </summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary>
        ///   JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.
        /// </summary>
        public virtual string Query { get; internal set; }
        /// <summary>
        ///   Increase logging verbosity. Use --debug for full debug logs.
        /// </summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("backup protection backup-now")
              .Add("--container-name {value}", ContainerName)
              .Add("--item-name {value}", ItemName)
              .Add("--retain-until {value}", RetainUntil)
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--subscription {value}", Subscription)
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
    #region AzureBackupProtectionCheckVmSettings
    /// <summary>
    ///   Used within <see cref="AzureBackupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBackupProtectionCheckVmSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBackup executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBackupTasks.AzureBackupPath;
        public override Action<OutputType, string> CustomLogger => AzureBackupTasks.AzureBackupLogger;
        /// <summary>
        ///   ID of the virtual machine to be checked for protection.
        /// </summary>
        public virtual string VmId { get; internal set; }
        /// <summary>
        ///   Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.
        /// </summary>
        public virtual string Subscription { get; internal set; }
        /// <summary>
        ///   Increase logging verbosity to show all debug logs.
        /// </summary>
        public virtual string Debug { get; internal set; }
        /// <summary>
        ///   Show this help message and exit.
        /// </summary>
        public virtual string Help { get; internal set; }
        /// <summary>
        ///   Output format.
        /// </summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary>
        ///   JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.
        /// </summary>
        public virtual string Query { get; internal set; }
        /// <summary>
        ///   Increase logging verbosity. Use --debug for full debug logs.
        /// </summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("backup protection check-vm")
              .Add("--vm-id {value}", VmId)
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
    #region AzureBackupProtectionDisableSettings
    /// <summary>
    ///   Used within <see cref="AzureBackupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBackupProtectionDisableSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBackup executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBackupTasks.AzureBackupPath;
        public override Action<OutputType, string> CustomLogger => AzureBackupTasks.AzureBackupLogger;
        /// <summary>
        ///   Name of the container.
        /// </summary>
        public virtual string ContainerName { get; internal set; }
        /// <summary>
        ///   Name of the backed up item.
        /// </summary>
        public virtual string ItemName { get; internal set; }
        /// <summary>
        ///   Option to delete existing backed up data in the Recovery services vault.
        /// </summary>
        public virtual bool? DeleteBackupData { get; internal set; }
        /// <summary>
        ///   Do not prompt for confirmation.
        /// </summary>
        public virtual string Yes { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.
        /// </summary>
        public virtual string Subscription { get; internal set; }
        /// <summary>
        ///   Name of the Recovery services vault.
        /// </summary>
        public virtual string VaultName { get; internal set; }
        /// <summary>
        ///   Increase logging verbosity to show all debug logs.
        /// </summary>
        public virtual string Debug { get; internal set; }
        /// <summary>
        ///   Show this help message and exit.
        /// </summary>
        public virtual string Help { get; internal set; }
        /// <summary>
        ///   Output format.
        /// </summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary>
        ///   JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.
        /// </summary>
        public virtual string Query { get; internal set; }
        /// <summary>
        ///   Increase logging verbosity. Use --debug for full debug logs.
        /// </summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("backup protection disable")
              .Add("--container-name {value}", ContainerName)
              .Add("--item-name {value}", ItemName)
              .Add("--delete-backup-data", DeleteBackupData)
              .Add("--yes {value}", Yes)
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--subscription {value}", Subscription)
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
    #region AzureBackupProtectionEnableForVmSettings
    /// <summary>
    ///   Used within <see cref="AzureBackupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBackupProtectionEnableForVmSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBackup executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBackupTasks.AzureBackupPath;
        public override Action<OutputType, string> CustomLogger => AzureBackupTasks.AzureBackupLogger;
        /// <summary>
        ///   Name of the backup policy.
        /// </summary>
        public virtual string PolicyName { get; internal set; }
        /// <summary>
        ///   Name or ID of the Virtual Machine to be protected.
        /// </summary>
        public virtual string Vm { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.
        /// </summary>
        public virtual string Subscription { get; internal set; }
        /// <summary>
        ///   Name of the Recovery services vault.
        /// </summary>
        public virtual string VaultName { get; internal set; }
        /// <summary>
        ///   Increase logging verbosity to show all debug logs.
        /// </summary>
        public virtual string Debug { get; internal set; }
        /// <summary>
        ///   Show this help message and exit.
        /// </summary>
        public virtual string Help { get; internal set; }
        /// <summary>
        ///   Output format.
        /// </summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary>
        ///   JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.
        /// </summary>
        public virtual string Query { get; internal set; }
        /// <summary>
        ///   Increase logging verbosity. Use --debug for full debug logs.
        /// </summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("backup protection enable-for-vm")
              .Add("--policy-name {value}", PolicyName)
              .Add("--vm {value}", Vm)
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--subscription {value}", Subscription)
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
    #region AzureBackupRecoverypointListSettings
    /// <summary>
    ///   Used within <see cref="AzureBackupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBackupRecoverypointListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBackup executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBackupTasks.AzureBackupPath;
        public override Action<OutputType, string> CustomLogger => AzureBackupTasks.AzureBackupLogger;
        /// <summary>
        ///   Name of the container.
        /// </summary>
        public virtual string ContainerName { get; internal set; }
        /// <summary>
        ///   Name of the backed up item.
        /// </summary>
        public virtual string ItemName { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Name of the Recovery services vault.
        /// </summary>
        public virtual string VaultName { get; internal set; }
        /// <summary>
        ///   The end date of the range in UTC (d-m-Y).
        /// </summary>
        public virtual string EndDate { get; internal set; }
        /// <summary>
        ///   The start date of the range in UTC (d-m-Y).
        /// </summary>
        public virtual string StartDate { get; internal set; }
        /// <summary>
        ///   Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.
        /// </summary>
        public virtual string Subscription { get; internal set; }
        /// <summary>
        ///   Increase logging verbosity to show all debug logs.
        /// </summary>
        public virtual string Debug { get; internal set; }
        /// <summary>
        ///   Show this help message and exit.
        /// </summary>
        public virtual string Help { get; internal set; }
        /// <summary>
        ///   Output format.
        /// </summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary>
        ///   JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.
        /// </summary>
        public virtual string Query { get; internal set; }
        /// <summary>
        ///   Increase logging verbosity. Use --debug for full debug logs.
        /// </summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("backup recoverypoint list")
              .Add("--container-name {value}", ContainerName)
              .Add("--item-name {value}", ItemName)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--vault-name {value}", VaultName)
              .Add("--end-date {value}", EndDate)
              .Add("--start-date {value}", StartDate)
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
    #region AzureBackupRecoverypointShowSettings
    /// <summary>
    ///   Used within <see cref="AzureBackupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBackupRecoverypointShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBackup executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBackupTasks.AzureBackupPath;
        public override Action<OutputType, string> CustomLogger => AzureBackupTasks.AzureBackupLogger;
        /// <summary>
        ///   Name of the container.
        /// </summary>
        public virtual string ContainerName { get; internal set; }
        /// <summary>
        ///   Name of the backed up item.
        /// </summary>
        public virtual string ItemName { get; internal set; }
        /// <summary>
        ///   Name of the recovery point. You can use the backup recovery point list command to get the name of a backed up item.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.
        /// </summary>
        public virtual string Subscription { get; internal set; }
        /// <summary>
        ///   Name of the Recovery services vault.
        /// </summary>
        public virtual string VaultName { get; internal set; }
        /// <summary>
        ///   Increase logging verbosity to show all debug logs.
        /// </summary>
        public virtual string Debug { get; internal set; }
        /// <summary>
        ///   Show this help message and exit.
        /// </summary>
        public virtual string Help { get; internal set; }
        /// <summary>
        ///   Output format.
        /// </summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary>
        ///   JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.
        /// </summary>
        public virtual string Query { get; internal set; }
        /// <summary>
        ///   Increase logging verbosity. Use --debug for full debug logs.
        /// </summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("backup recoverypoint show")
              .Add("--container-name {value}", ContainerName)
              .Add("--item-name {value}", ItemName)
              .Add("--name {value}", Name)
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--subscription {value}", Subscription)
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
    #region AzureBackupRestoreRestoreDisksSettings
    /// <summary>
    ///   Used within <see cref="AzureBackupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBackupRestoreRestoreDisksSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBackup executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBackupTasks.AzureBackupPath;
        public override Action<OutputType, string> CustomLogger => AzureBackupTasks.AzureBackupLogger;
        /// <summary>
        ///   Name of the container.
        /// </summary>
        public virtual string ContainerName { get; internal set; }
        /// <summary>
        ///   Name of the backed up item.
        /// </summary>
        public virtual string ItemName { get; internal set; }
        /// <summary>
        ///   Name of the recovery point.
        /// </summary>
        public virtual string RpName { get; internal set; }
        /// <summary>
        ///   Name or ID of the staging storage account. The VM configuration will be restored to this storage account. See the help for --restore-to-staging-storage-account parameter for more info.
        /// </summary>
        public virtual string StorageAccount { get; internal set; }
        /// <summary>
        ///   Use this flag when you want disks to be restored to the staging storage account using the --storage-account parameter. When not specified, disks will be restored to their original storage accounts. Default: false.
        /// </summary>
        public virtual bool? RestoreToStagingStorageAccount { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.
        /// </summary>
        public virtual string Subscription { get; internal set; }
        /// <summary>
        ///   Name of the Recovery services vault.
        /// </summary>
        public virtual string VaultName { get; internal set; }
        /// <summary>
        ///   Increase logging verbosity to show all debug logs.
        /// </summary>
        public virtual string Debug { get; internal set; }
        /// <summary>
        ///   Show this help message and exit.
        /// </summary>
        public virtual string Help { get; internal set; }
        /// <summary>
        ///   Output format.
        /// </summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary>
        ///   JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.
        /// </summary>
        public virtual string Query { get; internal set; }
        /// <summary>
        ///   Increase logging verbosity. Use --debug for full debug logs.
        /// </summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("backup restore restore-disks")
              .Add("--container-name {value}", ContainerName)
              .Add("--item-name {value}", ItemName)
              .Add("--rp-name {value}", RpName)
              .Add("--storage-account {value}", StorageAccount)
              .Add("--restore-to-staging-storage-account", RestoreToStagingStorageAccount)
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--subscription {value}", Subscription)
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
    #region AzureBackupVaultCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureBackupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBackupVaultCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBackup executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBackupTasks.AzureBackupPath;
        public override Action<OutputType, string> CustomLogger => AzureBackupTasks.AzureBackupLogger;
        /// <summary>
        ///   Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.
        /// </summary>
        public virtual string Location { get; internal set; }
        /// <summary>
        ///   Name of the Recovery services vault.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.
        /// </summary>
        public virtual string Subscription { get; internal set; }
        /// <summary>
        ///   Increase logging verbosity to show all debug logs.
        /// </summary>
        public virtual string Debug { get; internal set; }
        /// <summary>
        ///   Show this help message and exit.
        /// </summary>
        public virtual string Help { get; internal set; }
        /// <summary>
        ///   Output format.
        /// </summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary>
        ///   JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.
        /// </summary>
        public virtual string Query { get; internal set; }
        /// <summary>
        ///   Increase logging verbosity. Use --debug for full debug logs.
        /// </summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("backup vault create")
              .Add("--location {value}", Location)
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
    #region AzureBackupVaultDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureBackupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBackupVaultDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBackup executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBackupTasks.AzureBackupPath;
        public override Action<OutputType, string> CustomLogger => AzureBackupTasks.AzureBackupLogger;
        /// <summary>
        ///   Force completion of the requested action.
        /// </summary>
        public virtual string Force { get; internal set; }
        /// <summary>
        ///   Do not prompt for confirmation.
        /// </summary>
        public virtual string Yes { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of the Recovery services vault.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.
        /// </summary>
        public virtual string Subscription { get; internal set; }
        /// <summary>
        ///   Increase logging verbosity to show all debug logs.
        /// </summary>
        public virtual string Debug { get; internal set; }
        /// <summary>
        ///   Show this help message and exit.
        /// </summary>
        public virtual string Help { get; internal set; }
        /// <summary>
        ///   Output format.
        /// </summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary>
        ///   JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.
        /// </summary>
        public virtual string Query { get; internal set; }
        /// <summary>
        ///   Increase logging verbosity. Use --debug for full debug logs.
        /// </summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("backup vault delete")
              .Add("--force {value}", Force)
              .Add("--yes {value}", Yes)
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
    #region AzureBackupVaultListSettings
    /// <summary>
    ///   Used within <see cref="AzureBackupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBackupVaultListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBackup executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBackupTasks.AzureBackupPath;
        public override Action<OutputType, string> CustomLogger => AzureBackupTasks.AzureBackupLogger;
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.
        /// </summary>
        public virtual string Subscription { get; internal set; }
        /// <summary>
        ///   Increase logging verbosity to show all debug logs.
        /// </summary>
        public virtual string Debug { get; internal set; }
        /// <summary>
        ///   Show this help message and exit.
        /// </summary>
        public virtual string Help { get; internal set; }
        /// <summary>
        ///   Output format.
        /// </summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary>
        ///   JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.
        /// </summary>
        public virtual string Query { get; internal set; }
        /// <summary>
        ///   Increase logging verbosity. Use --debug for full debug logs.
        /// </summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("backup vault list")
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
    #region AzureBackupVaultShowSettings
    /// <summary>
    ///   Used within <see cref="AzureBackupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBackupVaultShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBackup executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBackupTasks.AzureBackupPath;
        public override Action<OutputType, string> CustomLogger => AzureBackupTasks.AzureBackupLogger;
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of the Recovery services vault.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.
        /// </summary>
        public virtual string Subscription { get; internal set; }
        /// <summary>
        ///   Increase logging verbosity to show all debug logs.
        /// </summary>
        public virtual string Debug { get; internal set; }
        /// <summary>
        ///   Show this help message and exit.
        /// </summary>
        public virtual string Help { get; internal set; }
        /// <summary>
        ///   Output format.
        /// </summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary>
        ///   JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.
        /// </summary>
        public virtual string Query { get; internal set; }
        /// <summary>
        ///   Increase logging verbosity. Use --debug for full debug logs.
        /// </summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("backup vault show")
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
    #region AzureBackupRestoreFilesMountRpSettings
    /// <summary>
    ///   Used within <see cref="AzureBackupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBackupRestoreFilesMountRpSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBackup executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBackupTasks.AzureBackupPath;
        public override Action<OutputType, string> CustomLogger => AzureBackupTasks.AzureBackupLogger;
        /// <summary>
        ///   Name of the container.
        /// </summary>
        public virtual string ContainerName { get; internal set; }
        /// <summary>
        ///   Name of the backed up item.
        /// </summary>
        public virtual string ItemName { get; internal set; }
        /// <summary>
        ///   Name of the recovery point.
        /// </summary>
        public virtual string RpName { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.
        /// </summary>
        public virtual string Subscription { get; internal set; }
        /// <summary>
        ///   Name of the Recovery services vault.
        /// </summary>
        public virtual string VaultName { get; internal set; }
        /// <summary>
        ///   Increase logging verbosity to show all debug logs.
        /// </summary>
        public virtual string Debug { get; internal set; }
        /// <summary>
        ///   Show this help message and exit.
        /// </summary>
        public virtual string Help { get; internal set; }
        /// <summary>
        ///   Output format.
        /// </summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary>
        ///   JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.
        /// </summary>
        public virtual string Query { get; internal set; }
        /// <summary>
        ///   Increase logging verbosity. Use --debug for full debug logs.
        /// </summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("backup restore files mount-rp")
              .Add("--container-name {value}", ContainerName)
              .Add("--item-name {value}", ItemName)
              .Add("--rp-name {value}", RpName)
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--subscription {value}", Subscription)
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
    #region AzureBackupRestoreFilesUnmountRpSettings
    /// <summary>
    ///   Used within <see cref="AzureBackupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBackupRestoreFilesUnmountRpSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBackup executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBackupTasks.AzureBackupPath;
        public override Action<OutputType, string> CustomLogger => AzureBackupTasks.AzureBackupLogger;
        /// <summary>
        ///   Name of the container.
        /// </summary>
        public virtual string ContainerName { get; internal set; }
        /// <summary>
        ///   Name of the backed up item.
        /// </summary>
        public virtual string ItemName { get; internal set; }
        /// <summary>
        ///   Name of the recovery point.
        /// </summary>
        public virtual string RpName { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.
        /// </summary>
        public virtual string Subscription { get; internal set; }
        /// <summary>
        ///   Name of the Recovery services vault.
        /// </summary>
        public virtual string VaultName { get; internal set; }
        /// <summary>
        ///   Increase logging verbosity to show all debug logs.
        /// </summary>
        public virtual string Debug { get; internal set; }
        /// <summary>
        ///   Show this help message and exit.
        /// </summary>
        public virtual string Help { get; internal set; }
        /// <summary>
        ///   Output format.
        /// </summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary>
        ///   JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.
        /// </summary>
        public virtual string Query { get; internal set; }
        /// <summary>
        ///   Increase logging verbosity. Use --debug for full debug logs.
        /// </summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("backup restore files unmount-rp")
              .Add("--container-name {value}", ContainerName)
              .Add("--item-name {value}", ItemName)
              .Add("--rp-name {value}", RpName)
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--subscription {value}", Subscription)
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
    #region AzureBackupVaultBackupPropertiesSetSettings
    /// <summary>
    ///   Used within <see cref="AzureBackupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBackupVaultBackupPropertiesSetSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBackup executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBackupTasks.AzureBackupPath;
        public override Action<OutputType, string> CustomLogger => AzureBackupTasks.AzureBackupLogger;
        /// <summary>
        ///   Sets backup storage properties for a Recovery Services vault.
        /// </summary>
        public virtual BackupVaultBackupPropertiesSetBackupStorageRedundancy BackupStorageRedundancy { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of the Recovery services vault.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.
        /// </summary>
        public virtual string Subscription { get; internal set; }
        /// <summary>
        ///   Increase logging verbosity to show all debug logs.
        /// </summary>
        public virtual string Debug { get; internal set; }
        /// <summary>
        ///   Show this help message and exit.
        /// </summary>
        public virtual string Help { get; internal set; }
        /// <summary>
        ///   Output format.
        /// </summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary>
        ///   JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.
        /// </summary>
        public virtual string Query { get; internal set; }
        /// <summary>
        ///   Increase logging verbosity. Use --debug for full debug logs.
        /// </summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("backup vault backup-properties set")
              .Add("--backup-storage-redundancy {value}", BackupStorageRedundancy)
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
    #region AzureBackupVaultBackupPropertiesShowSettings
    /// <summary>
    ///   Used within <see cref="AzureBackupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBackupVaultBackupPropertiesShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBackup executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBackupTasks.AzureBackupPath;
        public override Action<OutputType, string> CustomLogger => AzureBackupTasks.AzureBackupLogger;
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of the Recovery services vault.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.
        /// </summary>
        public virtual string Subscription { get; internal set; }
        /// <summary>
        ///   Increase logging verbosity to show all debug logs.
        /// </summary>
        public virtual string Debug { get; internal set; }
        /// <summary>
        ///   Show this help message and exit.
        /// </summary>
        public virtual string Help { get; internal set; }
        /// <summary>
        ///   Output format.
        /// </summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary>
        ///   JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.
        /// </summary>
        public virtual string Query { get; internal set; }
        /// <summary>
        ///   Increase logging verbosity. Use --debug for full debug logs.
        /// </summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("backup vault backup-properties show")
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
    #region AzureBackupSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBackupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBackupSettingsExtensions
    {
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupSettings SetDebug(this AzureBackupSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupSettings ResetDebug(this AzureBackupSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBackupSettings SetHelp(this AzureBackupSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBackupSettings ResetHelp(this AzureBackupSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBackupSettings SetOutput(this AzureBackupSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBackupSettings ResetOutput(this AzureBackupSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBackupSettings SetQuery(this AzureBackupSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBackupSettings ResetQuery(this AzureBackupSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupSettings SetVerbose(this AzureBackupSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupSettings ResetVerbose(this AzureBackupSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBackupContainerListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBackupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBackupContainerListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupContainerListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupContainerListSettings SetResourceGroup(this AzureBackupContainerListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupContainerListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupContainerListSettings ResetResourceGroup(this AzureBackupContainerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region VaultName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupContainerListSettings.VaultName"/></em></p>
        ///   <p>Name of the Recovery services vault.</p>
        /// </summary>
        [Pure]
        public static AzureBackupContainerListSettings SetVaultName(this AzureBackupContainerListSettings toolSettings, string vaultName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = vaultName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupContainerListSettings.VaultName"/></em></p>
        ///   <p>Name of the Recovery services vault.</p>
        /// </summary>
        [Pure]
        public static AzureBackupContainerListSettings ResetVaultName(this AzureBackupContainerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupContainerListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupContainerListSettings SetSubscription(this AzureBackupContainerListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupContainerListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupContainerListSettings ResetSubscription(this AzureBackupContainerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupContainerListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupContainerListSettings SetDebug(this AzureBackupContainerListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupContainerListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupContainerListSettings ResetDebug(this AzureBackupContainerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupContainerListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBackupContainerListSettings SetHelp(this AzureBackupContainerListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupContainerListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBackupContainerListSettings ResetHelp(this AzureBackupContainerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupContainerListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBackupContainerListSettings SetOutput(this AzureBackupContainerListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupContainerListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBackupContainerListSettings ResetOutput(this AzureBackupContainerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupContainerListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBackupContainerListSettings SetQuery(this AzureBackupContainerListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupContainerListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBackupContainerListSettings ResetQuery(this AzureBackupContainerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupContainerListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupContainerListSettings SetVerbose(this AzureBackupContainerListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupContainerListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupContainerListSettings ResetVerbose(this AzureBackupContainerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBackupContainerShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBackupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBackupContainerShowSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupContainerShowSettings.Name"/></em></p>
        ///   <p>Name of the container. You can use the backup container list command to get the name of a container.</p>
        /// </summary>
        [Pure]
        public static AzureBackupContainerShowSettings SetName(this AzureBackupContainerShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupContainerShowSettings.Name"/></em></p>
        ///   <p>Name of the container. You can use the backup container list command to get the name of a container.</p>
        /// </summary>
        [Pure]
        public static AzureBackupContainerShowSettings ResetName(this AzureBackupContainerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupContainerShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupContainerShowSettings SetIds(this AzureBackupContainerShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupContainerShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupContainerShowSettings SetIds(this AzureBackupContainerShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureBackupContainerShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupContainerShowSettings AddIds(this AzureBackupContainerShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureBackupContainerShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupContainerShowSettings AddIds(this AzureBackupContainerShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureBackupContainerShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupContainerShowSettings ClearIds(this AzureBackupContainerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureBackupContainerShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupContainerShowSettings RemoveIds(this AzureBackupContainerShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureBackupContainerShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupContainerShowSettings RemoveIds(this AzureBackupContainerShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupContainerShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupContainerShowSettings SetResourceGroup(this AzureBackupContainerShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupContainerShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupContainerShowSettings ResetResourceGroup(this AzureBackupContainerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupContainerShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupContainerShowSettings SetSubscription(this AzureBackupContainerShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupContainerShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupContainerShowSettings ResetSubscription(this AzureBackupContainerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region VaultName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupContainerShowSettings.VaultName"/></em></p>
        ///   <p>Name of the Recovery services vault.</p>
        /// </summary>
        [Pure]
        public static AzureBackupContainerShowSettings SetVaultName(this AzureBackupContainerShowSettings toolSettings, string vaultName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = vaultName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupContainerShowSettings.VaultName"/></em></p>
        ///   <p>Name of the Recovery services vault.</p>
        /// </summary>
        [Pure]
        public static AzureBackupContainerShowSettings ResetVaultName(this AzureBackupContainerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupContainerShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupContainerShowSettings SetDebug(this AzureBackupContainerShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupContainerShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupContainerShowSettings ResetDebug(this AzureBackupContainerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupContainerShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBackupContainerShowSettings SetHelp(this AzureBackupContainerShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupContainerShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBackupContainerShowSettings ResetHelp(this AzureBackupContainerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupContainerShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBackupContainerShowSettings SetOutput(this AzureBackupContainerShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupContainerShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBackupContainerShowSettings ResetOutput(this AzureBackupContainerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupContainerShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBackupContainerShowSettings SetQuery(this AzureBackupContainerShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupContainerShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBackupContainerShowSettings ResetQuery(this AzureBackupContainerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupContainerShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupContainerShowSettings SetVerbose(this AzureBackupContainerShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupContainerShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupContainerShowSettings ResetVerbose(this AzureBackupContainerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBackupItemListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBackupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBackupItemListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupItemListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupItemListSettings SetResourceGroup(this AzureBackupItemListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupItemListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupItemListSettings ResetResourceGroup(this AzureBackupItemListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region VaultName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupItemListSettings.VaultName"/></em></p>
        ///   <p>Name of the Recovery services vault.</p>
        /// </summary>
        [Pure]
        public static AzureBackupItemListSettings SetVaultName(this AzureBackupItemListSettings toolSettings, string vaultName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = vaultName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupItemListSettings.VaultName"/></em></p>
        ///   <p>Name of the Recovery services vault.</p>
        /// </summary>
        [Pure]
        public static AzureBackupItemListSettings ResetVaultName(this AzureBackupItemListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = null;
            return toolSettings;
        }
        #endregion
        #region ContainerName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupItemListSettings.ContainerName"/></em></p>
        ///   <p>Name of the container.</p>
        /// </summary>
        [Pure]
        public static AzureBackupItemListSettings SetContainerName(this AzureBackupItemListSettings toolSettings, string containerName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ContainerName = containerName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupItemListSettings.ContainerName"/></em></p>
        ///   <p>Name of the container.</p>
        /// </summary>
        [Pure]
        public static AzureBackupItemListSettings ResetContainerName(this AzureBackupItemListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ContainerName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupItemListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupItemListSettings SetSubscription(this AzureBackupItemListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupItemListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupItemListSettings ResetSubscription(this AzureBackupItemListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupItemListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupItemListSettings SetDebug(this AzureBackupItemListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupItemListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupItemListSettings ResetDebug(this AzureBackupItemListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupItemListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBackupItemListSettings SetHelp(this AzureBackupItemListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupItemListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBackupItemListSettings ResetHelp(this AzureBackupItemListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupItemListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBackupItemListSettings SetOutput(this AzureBackupItemListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupItemListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBackupItemListSettings ResetOutput(this AzureBackupItemListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupItemListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBackupItemListSettings SetQuery(this AzureBackupItemListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupItemListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBackupItemListSettings ResetQuery(this AzureBackupItemListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupItemListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupItemListSettings SetVerbose(this AzureBackupItemListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupItemListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupItemListSettings ResetVerbose(this AzureBackupItemListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBackupItemSetPolicySettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBackupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBackupItemSetPolicySettingsExtensions
    {
        #region ContainerName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupItemSetPolicySettings.ContainerName"/></em></p>
        ///   <p>Name of the container.</p>
        /// </summary>
        [Pure]
        public static AzureBackupItemSetPolicySettings SetContainerName(this AzureBackupItemSetPolicySettings toolSettings, string containerName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ContainerName = containerName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupItemSetPolicySettings.ContainerName"/></em></p>
        ///   <p>Name of the container.</p>
        /// </summary>
        [Pure]
        public static AzureBackupItemSetPolicySettings ResetContainerName(this AzureBackupItemSetPolicySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ContainerName = null;
            return toolSettings;
        }
        #endregion
        #region PolicyName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupItemSetPolicySettings.PolicyName"/></em></p>
        ///   <p>Name of the Backup policy. You can use the backup policy list command to get the name of a backup policy.</p>
        /// </summary>
        [Pure]
        public static AzureBackupItemSetPolicySettings SetPolicyName(this AzureBackupItemSetPolicySettings toolSettings, string policyName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PolicyName = policyName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupItemSetPolicySettings.PolicyName"/></em></p>
        ///   <p>Name of the Backup policy. You can use the backup policy list command to get the name of a backup policy.</p>
        /// </summary>
        [Pure]
        public static AzureBackupItemSetPolicySettings ResetPolicyName(this AzureBackupItemSetPolicySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PolicyName = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupItemSetPolicySettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupItemSetPolicySettings SetIds(this AzureBackupItemSetPolicySettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupItemSetPolicySettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupItemSetPolicySettings SetIds(this AzureBackupItemSetPolicySettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureBackupItemSetPolicySettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupItemSetPolicySettings AddIds(this AzureBackupItemSetPolicySettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureBackupItemSetPolicySettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupItemSetPolicySettings AddIds(this AzureBackupItemSetPolicySettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureBackupItemSetPolicySettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupItemSetPolicySettings ClearIds(this AzureBackupItemSetPolicySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureBackupItemSetPolicySettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupItemSetPolicySettings RemoveIds(this AzureBackupItemSetPolicySettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureBackupItemSetPolicySettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupItemSetPolicySettings RemoveIds(this AzureBackupItemSetPolicySettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupItemSetPolicySettings.Name"/></em></p>
        ///   <p>Name of the backed up item. You can use the backup item list command to get the name of a backed up item.</p>
        /// </summary>
        [Pure]
        public static AzureBackupItemSetPolicySettings SetName(this AzureBackupItemSetPolicySettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupItemSetPolicySettings.Name"/></em></p>
        ///   <p>Name of the backed up item. You can use the backup item list command to get the name of a backed up item.</p>
        /// </summary>
        [Pure]
        public static AzureBackupItemSetPolicySettings ResetName(this AzureBackupItemSetPolicySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupItemSetPolicySettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupItemSetPolicySettings SetResourceGroup(this AzureBackupItemSetPolicySettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupItemSetPolicySettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupItemSetPolicySettings ResetResourceGroup(this AzureBackupItemSetPolicySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupItemSetPolicySettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupItemSetPolicySettings SetSubscription(this AzureBackupItemSetPolicySettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupItemSetPolicySettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupItemSetPolicySettings ResetSubscription(this AzureBackupItemSetPolicySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region VaultName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupItemSetPolicySettings.VaultName"/></em></p>
        ///   <p>Name of the Recovery services vault.</p>
        /// </summary>
        [Pure]
        public static AzureBackupItemSetPolicySettings SetVaultName(this AzureBackupItemSetPolicySettings toolSettings, string vaultName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = vaultName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupItemSetPolicySettings.VaultName"/></em></p>
        ///   <p>Name of the Recovery services vault.</p>
        /// </summary>
        [Pure]
        public static AzureBackupItemSetPolicySettings ResetVaultName(this AzureBackupItemSetPolicySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupItemSetPolicySettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupItemSetPolicySettings SetDebug(this AzureBackupItemSetPolicySettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupItemSetPolicySettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupItemSetPolicySettings ResetDebug(this AzureBackupItemSetPolicySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupItemSetPolicySettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBackupItemSetPolicySettings SetHelp(this AzureBackupItemSetPolicySettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupItemSetPolicySettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBackupItemSetPolicySettings ResetHelp(this AzureBackupItemSetPolicySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupItemSetPolicySettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBackupItemSetPolicySettings SetOutput(this AzureBackupItemSetPolicySettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupItemSetPolicySettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBackupItemSetPolicySettings ResetOutput(this AzureBackupItemSetPolicySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupItemSetPolicySettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBackupItemSetPolicySettings SetQuery(this AzureBackupItemSetPolicySettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupItemSetPolicySettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBackupItemSetPolicySettings ResetQuery(this AzureBackupItemSetPolicySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupItemSetPolicySettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupItemSetPolicySettings SetVerbose(this AzureBackupItemSetPolicySettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupItemSetPolicySettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupItemSetPolicySettings ResetVerbose(this AzureBackupItemSetPolicySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBackupItemShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBackupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBackupItemShowSettingsExtensions
    {
        #region ContainerName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupItemShowSettings.ContainerName"/></em></p>
        ///   <p>Name of the container.</p>
        /// </summary>
        [Pure]
        public static AzureBackupItemShowSettings SetContainerName(this AzureBackupItemShowSettings toolSettings, string containerName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ContainerName = containerName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupItemShowSettings.ContainerName"/></em></p>
        ///   <p>Name of the container.</p>
        /// </summary>
        [Pure]
        public static AzureBackupItemShowSettings ResetContainerName(this AzureBackupItemShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ContainerName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupItemShowSettings.Name"/></em></p>
        ///   <p>Name of the backed up item. You can use the backup item list command to get the name of a backed up item.</p>
        /// </summary>
        [Pure]
        public static AzureBackupItemShowSettings SetName(this AzureBackupItemShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupItemShowSettings.Name"/></em></p>
        ///   <p>Name of the backed up item. You can use the backup item list command to get the name of a backed up item.</p>
        /// </summary>
        [Pure]
        public static AzureBackupItemShowSettings ResetName(this AzureBackupItemShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupItemShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupItemShowSettings SetIds(this AzureBackupItemShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupItemShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupItemShowSettings SetIds(this AzureBackupItemShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureBackupItemShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupItemShowSettings AddIds(this AzureBackupItemShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureBackupItemShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupItemShowSettings AddIds(this AzureBackupItemShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureBackupItemShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupItemShowSettings ClearIds(this AzureBackupItemShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureBackupItemShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupItemShowSettings RemoveIds(this AzureBackupItemShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureBackupItemShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupItemShowSettings RemoveIds(this AzureBackupItemShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupItemShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupItemShowSettings SetResourceGroup(this AzureBackupItemShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupItemShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupItemShowSettings ResetResourceGroup(this AzureBackupItemShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupItemShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupItemShowSettings SetSubscription(this AzureBackupItemShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupItemShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupItemShowSettings ResetSubscription(this AzureBackupItemShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region VaultName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupItemShowSettings.VaultName"/></em></p>
        ///   <p>Name of the Recovery services vault.</p>
        /// </summary>
        [Pure]
        public static AzureBackupItemShowSettings SetVaultName(this AzureBackupItemShowSettings toolSettings, string vaultName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = vaultName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupItemShowSettings.VaultName"/></em></p>
        ///   <p>Name of the Recovery services vault.</p>
        /// </summary>
        [Pure]
        public static AzureBackupItemShowSettings ResetVaultName(this AzureBackupItemShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupItemShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupItemShowSettings SetDebug(this AzureBackupItemShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupItemShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupItemShowSettings ResetDebug(this AzureBackupItemShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupItemShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBackupItemShowSettings SetHelp(this AzureBackupItemShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupItemShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBackupItemShowSettings ResetHelp(this AzureBackupItemShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupItemShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBackupItemShowSettings SetOutput(this AzureBackupItemShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupItemShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBackupItemShowSettings ResetOutput(this AzureBackupItemShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupItemShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBackupItemShowSettings SetQuery(this AzureBackupItemShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupItemShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBackupItemShowSettings ResetQuery(this AzureBackupItemShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupItemShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupItemShowSettings SetVerbose(this AzureBackupItemShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupItemShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupItemShowSettings ResetVerbose(this AzureBackupItemShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBackupJobListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBackupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBackupJobListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupJobListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobListSettings SetResourceGroup(this AzureBackupJobListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupJobListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobListSettings ResetResourceGroup(this AzureBackupJobListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region VaultName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupJobListSettings.VaultName"/></em></p>
        ///   <p>Name of the Recovery services vault.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobListSettings SetVaultName(this AzureBackupJobListSettings toolSettings, string vaultName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = vaultName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupJobListSettings.VaultName"/></em></p>
        ///   <p>Name of the Recovery services vault.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobListSettings ResetVaultName(this AzureBackupJobListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = null;
            return toolSettings;
        }
        #endregion
        #region EndDate
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupJobListSettings.EndDate"/></em></p>
        ///   <p>The end date of the range in UTC (d-m-Y).</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobListSettings SetEndDate(this AzureBackupJobListSettings toolSettings, string endDate)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndDate = endDate;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupJobListSettings.EndDate"/></em></p>
        ///   <p>The end date of the range in UTC (d-m-Y).</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobListSettings ResetEndDate(this AzureBackupJobListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndDate = null;
            return toolSettings;
        }
        #endregion
        #region Operation
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupJobListSettings.Operation"/></em></p>
        ///   <p>User initiated operation.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobListSettings SetOperation(this AzureBackupJobListSettings toolSettings, BackupJobListOperation operation)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Operation = operation;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupJobListSettings.Operation"/></em></p>
        ///   <p>User initiated operation.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobListSettings ResetOperation(this AzureBackupJobListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Operation = null;
            return toolSettings;
        }
        #endregion
        #region StartDate
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupJobListSettings.StartDate"/></em></p>
        ///   <p>The start date of the range in UTC (d-m-Y).</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobListSettings SetStartDate(this AzureBackupJobListSettings toolSettings, string startDate)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartDate = startDate;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupJobListSettings.StartDate"/></em></p>
        ///   <p>The start date of the range in UTC (d-m-Y).</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobListSettings ResetStartDate(this AzureBackupJobListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartDate = null;
            return toolSettings;
        }
        #endregion
        #region Status
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupJobListSettings.Status"/></em></p>
        ///   <p>Status of the Job.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobListSettings SetStatus(this AzureBackupJobListSettings toolSettings, BackupJobListStatus status)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Status = status;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupJobListSettings.Status"/></em></p>
        ///   <p>Status of the Job.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobListSettings ResetStatus(this AzureBackupJobListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Status = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupJobListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobListSettings SetSubscription(this AzureBackupJobListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupJobListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobListSettings ResetSubscription(this AzureBackupJobListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupJobListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobListSettings SetDebug(this AzureBackupJobListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupJobListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobListSettings ResetDebug(this AzureBackupJobListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupJobListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobListSettings SetHelp(this AzureBackupJobListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupJobListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobListSettings ResetHelp(this AzureBackupJobListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupJobListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobListSettings SetOutput(this AzureBackupJobListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupJobListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobListSettings ResetOutput(this AzureBackupJobListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupJobListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobListSettings SetQuery(this AzureBackupJobListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupJobListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobListSettings ResetQuery(this AzureBackupJobListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupJobListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobListSettings SetVerbose(this AzureBackupJobListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupJobListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobListSettings ResetVerbose(this AzureBackupJobListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBackupJobShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBackupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBackupJobShowSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupJobShowSettings.Name"/></em></p>
        ///   <p>Name of the job. You can use the backup job list command to get the name of a job.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobShowSettings SetName(this AzureBackupJobShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupJobShowSettings.Name"/></em></p>
        ///   <p>Name of the job. You can use the backup job list command to get the name of a job.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobShowSettings ResetName(this AzureBackupJobShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupJobShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobShowSettings SetIds(this AzureBackupJobShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupJobShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobShowSettings SetIds(this AzureBackupJobShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureBackupJobShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobShowSettings AddIds(this AzureBackupJobShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureBackupJobShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobShowSettings AddIds(this AzureBackupJobShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureBackupJobShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobShowSettings ClearIds(this AzureBackupJobShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureBackupJobShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobShowSettings RemoveIds(this AzureBackupJobShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureBackupJobShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobShowSettings RemoveIds(this AzureBackupJobShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupJobShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobShowSettings SetResourceGroup(this AzureBackupJobShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupJobShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobShowSettings ResetResourceGroup(this AzureBackupJobShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupJobShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobShowSettings SetSubscription(this AzureBackupJobShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupJobShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobShowSettings ResetSubscription(this AzureBackupJobShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region VaultName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupJobShowSettings.VaultName"/></em></p>
        ///   <p>Name of the Recovery services vault.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobShowSettings SetVaultName(this AzureBackupJobShowSettings toolSettings, string vaultName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = vaultName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupJobShowSettings.VaultName"/></em></p>
        ///   <p>Name of the Recovery services vault.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobShowSettings ResetVaultName(this AzureBackupJobShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupJobShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobShowSettings SetDebug(this AzureBackupJobShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupJobShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobShowSettings ResetDebug(this AzureBackupJobShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupJobShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobShowSettings SetHelp(this AzureBackupJobShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupJobShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobShowSettings ResetHelp(this AzureBackupJobShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupJobShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobShowSettings SetOutput(this AzureBackupJobShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupJobShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobShowSettings ResetOutput(this AzureBackupJobShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupJobShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobShowSettings SetQuery(this AzureBackupJobShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupJobShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobShowSettings ResetQuery(this AzureBackupJobShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupJobShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobShowSettings SetVerbose(this AzureBackupJobShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupJobShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobShowSettings ResetVerbose(this AzureBackupJobShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBackupJobStopSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBackupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBackupJobStopSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupJobStopSettings.Name"/></em></p>
        ///   <p>Name of the job. You can use the backup job list command to get the name of a job.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobStopSettings SetName(this AzureBackupJobStopSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupJobStopSettings.Name"/></em></p>
        ///   <p>Name of the job. You can use the backup job list command to get the name of a job.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobStopSettings ResetName(this AzureBackupJobStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupJobStopSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobStopSettings SetIds(this AzureBackupJobStopSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupJobStopSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobStopSettings SetIds(this AzureBackupJobStopSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureBackupJobStopSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobStopSettings AddIds(this AzureBackupJobStopSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureBackupJobStopSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobStopSettings AddIds(this AzureBackupJobStopSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureBackupJobStopSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobStopSettings ClearIds(this AzureBackupJobStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureBackupJobStopSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobStopSettings RemoveIds(this AzureBackupJobStopSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureBackupJobStopSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobStopSettings RemoveIds(this AzureBackupJobStopSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupJobStopSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobStopSettings SetResourceGroup(this AzureBackupJobStopSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupJobStopSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobStopSettings ResetResourceGroup(this AzureBackupJobStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupJobStopSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobStopSettings SetSubscription(this AzureBackupJobStopSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupJobStopSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobStopSettings ResetSubscription(this AzureBackupJobStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region VaultName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupJobStopSettings.VaultName"/></em></p>
        ///   <p>Name of the Recovery services vault.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobStopSettings SetVaultName(this AzureBackupJobStopSettings toolSettings, string vaultName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = vaultName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupJobStopSettings.VaultName"/></em></p>
        ///   <p>Name of the Recovery services vault.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobStopSettings ResetVaultName(this AzureBackupJobStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupJobStopSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobStopSettings SetDebug(this AzureBackupJobStopSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupJobStopSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobStopSettings ResetDebug(this AzureBackupJobStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupJobStopSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobStopSettings SetHelp(this AzureBackupJobStopSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupJobStopSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobStopSettings ResetHelp(this AzureBackupJobStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupJobStopSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobStopSettings SetOutput(this AzureBackupJobStopSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupJobStopSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobStopSettings ResetOutput(this AzureBackupJobStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupJobStopSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobStopSettings SetQuery(this AzureBackupJobStopSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupJobStopSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobStopSettings ResetQuery(this AzureBackupJobStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupJobStopSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobStopSettings SetVerbose(this AzureBackupJobStopSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupJobStopSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobStopSettings ResetVerbose(this AzureBackupJobStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBackupJobWaitSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBackupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBackupJobWaitSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupJobWaitSettings.Name"/></em></p>
        ///   <p>Name of the job. You can use the backup job list command to get the name of a job.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobWaitSettings SetName(this AzureBackupJobWaitSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupJobWaitSettings.Name"/></em></p>
        ///   <p>Name of the job. You can use the backup job list command to get the name of a job.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobWaitSettings ResetName(this AzureBackupJobWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Timeout
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupJobWaitSettings.Timeout"/></em></p>
        ///   <p>Maximum time, in seconds, to wait before aborting.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobWaitSettings SetTimeout(this AzureBackupJobWaitSettings toolSettings, string timeout)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Timeout = timeout;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupJobWaitSettings.Timeout"/></em></p>
        ///   <p>Maximum time, in seconds, to wait before aborting.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobWaitSettings ResetTimeout(this AzureBackupJobWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Timeout = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupJobWaitSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobWaitSettings SetIds(this AzureBackupJobWaitSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupJobWaitSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobWaitSettings SetIds(this AzureBackupJobWaitSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureBackupJobWaitSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobWaitSettings AddIds(this AzureBackupJobWaitSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureBackupJobWaitSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobWaitSettings AddIds(this AzureBackupJobWaitSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureBackupJobWaitSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobWaitSettings ClearIds(this AzureBackupJobWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureBackupJobWaitSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobWaitSettings RemoveIds(this AzureBackupJobWaitSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureBackupJobWaitSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobWaitSettings RemoveIds(this AzureBackupJobWaitSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupJobWaitSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobWaitSettings SetResourceGroup(this AzureBackupJobWaitSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupJobWaitSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobWaitSettings ResetResourceGroup(this AzureBackupJobWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupJobWaitSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobWaitSettings SetSubscription(this AzureBackupJobWaitSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupJobWaitSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobWaitSettings ResetSubscription(this AzureBackupJobWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region VaultName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupJobWaitSettings.VaultName"/></em></p>
        ///   <p>Name of the Recovery services vault.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobWaitSettings SetVaultName(this AzureBackupJobWaitSettings toolSettings, string vaultName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = vaultName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupJobWaitSettings.VaultName"/></em></p>
        ///   <p>Name of the Recovery services vault.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobWaitSettings ResetVaultName(this AzureBackupJobWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupJobWaitSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobWaitSettings SetDebug(this AzureBackupJobWaitSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupJobWaitSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobWaitSettings ResetDebug(this AzureBackupJobWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupJobWaitSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobWaitSettings SetHelp(this AzureBackupJobWaitSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupJobWaitSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobWaitSettings ResetHelp(this AzureBackupJobWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupJobWaitSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobWaitSettings SetOutput(this AzureBackupJobWaitSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupJobWaitSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobWaitSettings ResetOutput(this AzureBackupJobWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupJobWaitSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobWaitSettings SetQuery(this AzureBackupJobWaitSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupJobWaitSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobWaitSettings ResetQuery(this AzureBackupJobWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupJobWaitSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobWaitSettings SetVerbose(this AzureBackupJobWaitSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupJobWaitSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupJobWaitSettings ResetVerbose(this AzureBackupJobWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBackupPolicyDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBackupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBackupPolicyDeleteSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupPolicyDeleteSettings.Name"/></em></p>
        ///   <p>Name of the backup policy. You can use the backup policy list command to get the name of a policy.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyDeleteSettings SetName(this AzureBackupPolicyDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupPolicyDeleteSettings.Name"/></em></p>
        ///   <p>Name of the backup policy. You can use the backup policy list command to get the name of a policy.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyDeleteSettings ResetName(this AzureBackupPolicyDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupPolicyDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyDeleteSettings SetIds(this AzureBackupPolicyDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupPolicyDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyDeleteSettings SetIds(this AzureBackupPolicyDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureBackupPolicyDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyDeleteSettings AddIds(this AzureBackupPolicyDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureBackupPolicyDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyDeleteSettings AddIds(this AzureBackupPolicyDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureBackupPolicyDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyDeleteSettings ClearIds(this AzureBackupPolicyDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureBackupPolicyDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyDeleteSettings RemoveIds(this AzureBackupPolicyDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureBackupPolicyDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyDeleteSettings RemoveIds(this AzureBackupPolicyDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupPolicyDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyDeleteSettings SetResourceGroup(this AzureBackupPolicyDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupPolicyDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyDeleteSettings ResetResourceGroup(this AzureBackupPolicyDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupPolicyDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyDeleteSettings SetSubscription(this AzureBackupPolicyDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupPolicyDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyDeleteSettings ResetSubscription(this AzureBackupPolicyDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region VaultName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupPolicyDeleteSettings.VaultName"/></em></p>
        ///   <p>Name of the Recovery services vault.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyDeleteSettings SetVaultName(this AzureBackupPolicyDeleteSettings toolSettings, string vaultName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = vaultName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupPolicyDeleteSettings.VaultName"/></em></p>
        ///   <p>Name of the Recovery services vault.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyDeleteSettings ResetVaultName(this AzureBackupPolicyDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupPolicyDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyDeleteSettings SetDebug(this AzureBackupPolicyDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupPolicyDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyDeleteSettings ResetDebug(this AzureBackupPolicyDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupPolicyDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyDeleteSettings SetHelp(this AzureBackupPolicyDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupPolicyDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyDeleteSettings ResetHelp(this AzureBackupPolicyDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupPolicyDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyDeleteSettings SetOutput(this AzureBackupPolicyDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupPolicyDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyDeleteSettings ResetOutput(this AzureBackupPolicyDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupPolicyDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyDeleteSettings SetQuery(this AzureBackupPolicyDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupPolicyDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyDeleteSettings ResetQuery(this AzureBackupPolicyDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupPolicyDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyDeleteSettings SetVerbose(this AzureBackupPolicyDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupPolicyDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyDeleteSettings ResetVerbose(this AzureBackupPolicyDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBackupPolicyGetDefaultForVmSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBackupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBackupPolicyGetDefaultForVmSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupPolicyGetDefaultForVmSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyGetDefaultForVmSettings SetIds(this AzureBackupPolicyGetDefaultForVmSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupPolicyGetDefaultForVmSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyGetDefaultForVmSettings SetIds(this AzureBackupPolicyGetDefaultForVmSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureBackupPolicyGetDefaultForVmSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyGetDefaultForVmSettings AddIds(this AzureBackupPolicyGetDefaultForVmSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureBackupPolicyGetDefaultForVmSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyGetDefaultForVmSettings AddIds(this AzureBackupPolicyGetDefaultForVmSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureBackupPolicyGetDefaultForVmSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyGetDefaultForVmSettings ClearIds(this AzureBackupPolicyGetDefaultForVmSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureBackupPolicyGetDefaultForVmSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyGetDefaultForVmSettings RemoveIds(this AzureBackupPolicyGetDefaultForVmSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureBackupPolicyGetDefaultForVmSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyGetDefaultForVmSettings RemoveIds(this AzureBackupPolicyGetDefaultForVmSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupPolicyGetDefaultForVmSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyGetDefaultForVmSettings SetResourceGroup(this AzureBackupPolicyGetDefaultForVmSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupPolicyGetDefaultForVmSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyGetDefaultForVmSettings ResetResourceGroup(this AzureBackupPolicyGetDefaultForVmSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupPolicyGetDefaultForVmSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyGetDefaultForVmSettings SetSubscription(this AzureBackupPolicyGetDefaultForVmSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupPolicyGetDefaultForVmSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyGetDefaultForVmSettings ResetSubscription(this AzureBackupPolicyGetDefaultForVmSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region VaultName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupPolicyGetDefaultForVmSettings.VaultName"/></em></p>
        ///   <p>Name of the Recovery services vault.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyGetDefaultForVmSettings SetVaultName(this AzureBackupPolicyGetDefaultForVmSettings toolSettings, string vaultName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = vaultName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupPolicyGetDefaultForVmSettings.VaultName"/></em></p>
        ///   <p>Name of the Recovery services vault.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyGetDefaultForVmSettings ResetVaultName(this AzureBackupPolicyGetDefaultForVmSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupPolicyGetDefaultForVmSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyGetDefaultForVmSettings SetDebug(this AzureBackupPolicyGetDefaultForVmSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupPolicyGetDefaultForVmSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyGetDefaultForVmSettings ResetDebug(this AzureBackupPolicyGetDefaultForVmSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupPolicyGetDefaultForVmSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyGetDefaultForVmSettings SetHelp(this AzureBackupPolicyGetDefaultForVmSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupPolicyGetDefaultForVmSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyGetDefaultForVmSettings ResetHelp(this AzureBackupPolicyGetDefaultForVmSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupPolicyGetDefaultForVmSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyGetDefaultForVmSettings SetOutput(this AzureBackupPolicyGetDefaultForVmSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupPolicyGetDefaultForVmSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyGetDefaultForVmSettings ResetOutput(this AzureBackupPolicyGetDefaultForVmSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupPolicyGetDefaultForVmSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyGetDefaultForVmSettings SetQuery(this AzureBackupPolicyGetDefaultForVmSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupPolicyGetDefaultForVmSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyGetDefaultForVmSettings ResetQuery(this AzureBackupPolicyGetDefaultForVmSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupPolicyGetDefaultForVmSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyGetDefaultForVmSettings SetVerbose(this AzureBackupPolicyGetDefaultForVmSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupPolicyGetDefaultForVmSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyGetDefaultForVmSettings ResetVerbose(this AzureBackupPolicyGetDefaultForVmSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBackupPolicyListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBackupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBackupPolicyListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupPolicyListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyListSettings SetResourceGroup(this AzureBackupPolicyListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupPolicyListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyListSettings ResetResourceGroup(this AzureBackupPolicyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region VaultName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupPolicyListSettings.VaultName"/></em></p>
        ///   <p>Name of the Recovery services vault.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyListSettings SetVaultName(this AzureBackupPolicyListSettings toolSettings, string vaultName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = vaultName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupPolicyListSettings.VaultName"/></em></p>
        ///   <p>Name of the Recovery services vault.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyListSettings ResetVaultName(this AzureBackupPolicyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupPolicyListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyListSettings SetSubscription(this AzureBackupPolicyListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupPolicyListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyListSettings ResetSubscription(this AzureBackupPolicyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupPolicyListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyListSettings SetDebug(this AzureBackupPolicyListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupPolicyListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyListSettings ResetDebug(this AzureBackupPolicyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupPolicyListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyListSettings SetHelp(this AzureBackupPolicyListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupPolicyListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyListSettings ResetHelp(this AzureBackupPolicyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupPolicyListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyListSettings SetOutput(this AzureBackupPolicyListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupPolicyListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyListSettings ResetOutput(this AzureBackupPolicyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupPolicyListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyListSettings SetQuery(this AzureBackupPolicyListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupPolicyListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyListSettings ResetQuery(this AzureBackupPolicyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupPolicyListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyListSettings SetVerbose(this AzureBackupPolicyListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupPolicyListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyListSettings ResetVerbose(this AzureBackupPolicyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBackupPolicyListAssociatedItemsSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBackupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBackupPolicyListAssociatedItemsSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupPolicyListAssociatedItemsSettings.Name"/></em></p>
        ///   <p>Name of the backup policy. You can use the backup policy list command to get the name of a policy.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyListAssociatedItemsSettings SetName(this AzureBackupPolicyListAssociatedItemsSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupPolicyListAssociatedItemsSettings.Name"/></em></p>
        ///   <p>Name of the backup policy. You can use the backup policy list command to get the name of a policy.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyListAssociatedItemsSettings ResetName(this AzureBackupPolicyListAssociatedItemsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupPolicyListAssociatedItemsSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyListAssociatedItemsSettings SetIds(this AzureBackupPolicyListAssociatedItemsSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupPolicyListAssociatedItemsSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyListAssociatedItemsSettings SetIds(this AzureBackupPolicyListAssociatedItemsSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureBackupPolicyListAssociatedItemsSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyListAssociatedItemsSettings AddIds(this AzureBackupPolicyListAssociatedItemsSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureBackupPolicyListAssociatedItemsSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyListAssociatedItemsSettings AddIds(this AzureBackupPolicyListAssociatedItemsSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureBackupPolicyListAssociatedItemsSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyListAssociatedItemsSettings ClearIds(this AzureBackupPolicyListAssociatedItemsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureBackupPolicyListAssociatedItemsSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyListAssociatedItemsSettings RemoveIds(this AzureBackupPolicyListAssociatedItemsSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureBackupPolicyListAssociatedItemsSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyListAssociatedItemsSettings RemoveIds(this AzureBackupPolicyListAssociatedItemsSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupPolicyListAssociatedItemsSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyListAssociatedItemsSettings SetResourceGroup(this AzureBackupPolicyListAssociatedItemsSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupPolicyListAssociatedItemsSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyListAssociatedItemsSettings ResetResourceGroup(this AzureBackupPolicyListAssociatedItemsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupPolicyListAssociatedItemsSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyListAssociatedItemsSettings SetSubscription(this AzureBackupPolicyListAssociatedItemsSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupPolicyListAssociatedItemsSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyListAssociatedItemsSettings ResetSubscription(this AzureBackupPolicyListAssociatedItemsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region VaultName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupPolicyListAssociatedItemsSettings.VaultName"/></em></p>
        ///   <p>Name of the Recovery services vault.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyListAssociatedItemsSettings SetVaultName(this AzureBackupPolicyListAssociatedItemsSettings toolSettings, string vaultName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = vaultName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupPolicyListAssociatedItemsSettings.VaultName"/></em></p>
        ///   <p>Name of the Recovery services vault.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyListAssociatedItemsSettings ResetVaultName(this AzureBackupPolicyListAssociatedItemsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupPolicyListAssociatedItemsSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyListAssociatedItemsSettings SetDebug(this AzureBackupPolicyListAssociatedItemsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupPolicyListAssociatedItemsSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyListAssociatedItemsSettings ResetDebug(this AzureBackupPolicyListAssociatedItemsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupPolicyListAssociatedItemsSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyListAssociatedItemsSettings SetHelp(this AzureBackupPolicyListAssociatedItemsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupPolicyListAssociatedItemsSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyListAssociatedItemsSettings ResetHelp(this AzureBackupPolicyListAssociatedItemsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupPolicyListAssociatedItemsSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyListAssociatedItemsSettings SetOutput(this AzureBackupPolicyListAssociatedItemsSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupPolicyListAssociatedItemsSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyListAssociatedItemsSettings ResetOutput(this AzureBackupPolicyListAssociatedItemsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupPolicyListAssociatedItemsSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyListAssociatedItemsSettings SetQuery(this AzureBackupPolicyListAssociatedItemsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupPolicyListAssociatedItemsSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyListAssociatedItemsSettings ResetQuery(this AzureBackupPolicyListAssociatedItemsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupPolicyListAssociatedItemsSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyListAssociatedItemsSettings SetVerbose(this AzureBackupPolicyListAssociatedItemsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupPolicyListAssociatedItemsSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyListAssociatedItemsSettings ResetVerbose(this AzureBackupPolicyListAssociatedItemsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBackupPolicySetSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBackupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBackupPolicySetSettingsExtensions
    {
        #region Policy
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupPolicySetSettings.Policy"/></em></p>
        ///   <p>JSON encoded policy definition. Use the show command with JSON output to obtain a policy object. Modify the values using a file editor and pass the object.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicySetSettings SetPolicy(this AzureBackupPolicySetSettings toolSettings, string policy)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Policy = policy;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupPolicySetSettings.Policy"/></em></p>
        ///   <p>JSON encoded policy definition. Use the show command with JSON output to obtain a policy object. Modify the values using a file editor and pass the object.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicySetSettings ResetPolicy(this AzureBackupPolicySetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Policy = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupPolicySetSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicySetSettings SetIds(this AzureBackupPolicySetSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupPolicySetSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicySetSettings SetIds(this AzureBackupPolicySetSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureBackupPolicySetSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicySetSettings AddIds(this AzureBackupPolicySetSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureBackupPolicySetSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicySetSettings AddIds(this AzureBackupPolicySetSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureBackupPolicySetSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicySetSettings ClearIds(this AzureBackupPolicySetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureBackupPolicySetSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicySetSettings RemoveIds(this AzureBackupPolicySetSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureBackupPolicySetSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicySetSettings RemoveIds(this AzureBackupPolicySetSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupPolicySetSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicySetSettings SetResourceGroup(this AzureBackupPolicySetSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupPolicySetSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicySetSettings ResetResourceGroup(this AzureBackupPolicySetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupPolicySetSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicySetSettings SetSubscription(this AzureBackupPolicySetSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupPolicySetSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicySetSettings ResetSubscription(this AzureBackupPolicySetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region VaultName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupPolicySetSettings.VaultName"/></em></p>
        ///   <p>Name of the Recovery services vault.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicySetSettings SetVaultName(this AzureBackupPolicySetSettings toolSettings, string vaultName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = vaultName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupPolicySetSettings.VaultName"/></em></p>
        ///   <p>Name of the Recovery services vault.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicySetSettings ResetVaultName(this AzureBackupPolicySetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupPolicySetSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicySetSettings SetDebug(this AzureBackupPolicySetSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupPolicySetSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicySetSettings ResetDebug(this AzureBackupPolicySetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupPolicySetSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicySetSettings SetHelp(this AzureBackupPolicySetSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupPolicySetSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicySetSettings ResetHelp(this AzureBackupPolicySetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupPolicySetSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicySetSettings SetOutput(this AzureBackupPolicySetSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupPolicySetSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicySetSettings ResetOutput(this AzureBackupPolicySetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupPolicySetSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicySetSettings SetQuery(this AzureBackupPolicySetSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupPolicySetSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicySetSettings ResetQuery(this AzureBackupPolicySetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupPolicySetSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicySetSettings SetVerbose(this AzureBackupPolicySetSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupPolicySetSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicySetSettings ResetVerbose(this AzureBackupPolicySetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBackupPolicyShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBackupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBackupPolicyShowSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupPolicyShowSettings.Name"/></em></p>
        ///   <p>Name of the backup policy. You can use the backup policy list command to get the name of a policy.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyShowSettings SetName(this AzureBackupPolicyShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupPolicyShowSettings.Name"/></em></p>
        ///   <p>Name of the backup policy. You can use the backup policy list command to get the name of a policy.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyShowSettings ResetName(this AzureBackupPolicyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupPolicyShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyShowSettings SetIds(this AzureBackupPolicyShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupPolicyShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyShowSettings SetIds(this AzureBackupPolicyShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureBackupPolicyShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyShowSettings AddIds(this AzureBackupPolicyShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureBackupPolicyShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyShowSettings AddIds(this AzureBackupPolicyShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureBackupPolicyShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyShowSettings ClearIds(this AzureBackupPolicyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureBackupPolicyShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyShowSettings RemoveIds(this AzureBackupPolicyShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureBackupPolicyShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyShowSettings RemoveIds(this AzureBackupPolicyShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupPolicyShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyShowSettings SetResourceGroup(this AzureBackupPolicyShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupPolicyShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyShowSettings ResetResourceGroup(this AzureBackupPolicyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupPolicyShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyShowSettings SetSubscription(this AzureBackupPolicyShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupPolicyShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyShowSettings ResetSubscription(this AzureBackupPolicyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region VaultName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupPolicyShowSettings.VaultName"/></em></p>
        ///   <p>Name of the Recovery services vault.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyShowSettings SetVaultName(this AzureBackupPolicyShowSettings toolSettings, string vaultName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = vaultName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupPolicyShowSettings.VaultName"/></em></p>
        ///   <p>Name of the Recovery services vault.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyShowSettings ResetVaultName(this AzureBackupPolicyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupPolicyShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyShowSettings SetDebug(this AzureBackupPolicyShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupPolicyShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyShowSettings ResetDebug(this AzureBackupPolicyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupPolicyShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyShowSettings SetHelp(this AzureBackupPolicyShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupPolicyShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyShowSettings ResetHelp(this AzureBackupPolicyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupPolicyShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyShowSettings SetOutput(this AzureBackupPolicyShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupPolicyShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyShowSettings ResetOutput(this AzureBackupPolicyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupPolicyShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyShowSettings SetQuery(this AzureBackupPolicyShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupPolicyShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyShowSettings ResetQuery(this AzureBackupPolicyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupPolicyShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyShowSettings SetVerbose(this AzureBackupPolicyShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupPolicyShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupPolicyShowSettings ResetVerbose(this AzureBackupPolicyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBackupProtectionBackupNowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBackupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBackupProtectionBackupNowSettingsExtensions
    {
        #region ContainerName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupProtectionBackupNowSettings.ContainerName"/></em></p>
        ///   <p>Name of the container.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionBackupNowSettings SetContainerName(this AzureBackupProtectionBackupNowSettings toolSettings, string containerName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ContainerName = containerName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupProtectionBackupNowSettings.ContainerName"/></em></p>
        ///   <p>Name of the container.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionBackupNowSettings ResetContainerName(this AzureBackupProtectionBackupNowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ContainerName = null;
            return toolSettings;
        }
        #endregion
        #region ItemName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupProtectionBackupNowSettings.ItemName"/></em></p>
        ///   <p>Name of the backed up item.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionBackupNowSettings SetItemName(this AzureBackupProtectionBackupNowSettings toolSettings, string itemName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ItemName = itemName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupProtectionBackupNowSettings.ItemName"/></em></p>
        ///   <p>Name of the backed up item.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionBackupNowSettings ResetItemName(this AzureBackupProtectionBackupNowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ItemName = null;
            return toolSettings;
        }
        #endregion
        #region RetainUntil
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupProtectionBackupNowSettings.RetainUntil"/></em></p>
        ///   <p>The date until which this backed up copy will be available for retrieval, in UTC (d-m-Y).</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionBackupNowSettings SetRetainUntil(this AzureBackupProtectionBackupNowSettings toolSettings, string retainUntil)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RetainUntil = retainUntil;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupProtectionBackupNowSettings.RetainUntil"/></em></p>
        ///   <p>The date until which this backed up copy will be available for retrieval, in UTC (d-m-Y).</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionBackupNowSettings ResetRetainUntil(this AzureBackupProtectionBackupNowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RetainUntil = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupProtectionBackupNowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionBackupNowSettings SetIds(this AzureBackupProtectionBackupNowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupProtectionBackupNowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionBackupNowSettings SetIds(this AzureBackupProtectionBackupNowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureBackupProtectionBackupNowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionBackupNowSettings AddIds(this AzureBackupProtectionBackupNowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureBackupProtectionBackupNowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionBackupNowSettings AddIds(this AzureBackupProtectionBackupNowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureBackupProtectionBackupNowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionBackupNowSettings ClearIds(this AzureBackupProtectionBackupNowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureBackupProtectionBackupNowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionBackupNowSettings RemoveIds(this AzureBackupProtectionBackupNowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureBackupProtectionBackupNowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionBackupNowSettings RemoveIds(this AzureBackupProtectionBackupNowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupProtectionBackupNowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionBackupNowSettings SetResourceGroup(this AzureBackupProtectionBackupNowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupProtectionBackupNowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionBackupNowSettings ResetResourceGroup(this AzureBackupProtectionBackupNowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupProtectionBackupNowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionBackupNowSettings SetSubscription(this AzureBackupProtectionBackupNowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupProtectionBackupNowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionBackupNowSettings ResetSubscription(this AzureBackupProtectionBackupNowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region VaultName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupProtectionBackupNowSettings.VaultName"/></em></p>
        ///   <p>Name of the Recovery services vault.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionBackupNowSettings SetVaultName(this AzureBackupProtectionBackupNowSettings toolSettings, string vaultName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = vaultName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupProtectionBackupNowSettings.VaultName"/></em></p>
        ///   <p>Name of the Recovery services vault.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionBackupNowSettings ResetVaultName(this AzureBackupProtectionBackupNowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupProtectionBackupNowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionBackupNowSettings SetDebug(this AzureBackupProtectionBackupNowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupProtectionBackupNowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionBackupNowSettings ResetDebug(this AzureBackupProtectionBackupNowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupProtectionBackupNowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionBackupNowSettings SetHelp(this AzureBackupProtectionBackupNowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupProtectionBackupNowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionBackupNowSettings ResetHelp(this AzureBackupProtectionBackupNowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupProtectionBackupNowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionBackupNowSettings SetOutput(this AzureBackupProtectionBackupNowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupProtectionBackupNowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionBackupNowSettings ResetOutput(this AzureBackupProtectionBackupNowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupProtectionBackupNowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionBackupNowSettings SetQuery(this AzureBackupProtectionBackupNowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupProtectionBackupNowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionBackupNowSettings ResetQuery(this AzureBackupProtectionBackupNowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupProtectionBackupNowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionBackupNowSettings SetVerbose(this AzureBackupProtectionBackupNowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupProtectionBackupNowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionBackupNowSettings ResetVerbose(this AzureBackupProtectionBackupNowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBackupProtectionCheckVmSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBackupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBackupProtectionCheckVmSettingsExtensions
    {
        #region VmId
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupProtectionCheckVmSettings.VmId"/></em></p>
        ///   <p>ID of the virtual machine to be checked for protection.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionCheckVmSettings SetVmId(this AzureBackupProtectionCheckVmSettings toolSettings, string vmId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmId = vmId;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupProtectionCheckVmSettings.VmId"/></em></p>
        ///   <p>ID of the virtual machine to be checked for protection.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionCheckVmSettings ResetVmId(this AzureBackupProtectionCheckVmSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmId = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupProtectionCheckVmSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionCheckVmSettings SetSubscription(this AzureBackupProtectionCheckVmSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupProtectionCheckVmSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionCheckVmSettings ResetSubscription(this AzureBackupProtectionCheckVmSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupProtectionCheckVmSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionCheckVmSettings SetDebug(this AzureBackupProtectionCheckVmSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupProtectionCheckVmSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionCheckVmSettings ResetDebug(this AzureBackupProtectionCheckVmSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupProtectionCheckVmSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionCheckVmSettings SetHelp(this AzureBackupProtectionCheckVmSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupProtectionCheckVmSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionCheckVmSettings ResetHelp(this AzureBackupProtectionCheckVmSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupProtectionCheckVmSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionCheckVmSettings SetOutput(this AzureBackupProtectionCheckVmSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupProtectionCheckVmSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionCheckVmSettings ResetOutput(this AzureBackupProtectionCheckVmSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupProtectionCheckVmSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionCheckVmSettings SetQuery(this AzureBackupProtectionCheckVmSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupProtectionCheckVmSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionCheckVmSettings ResetQuery(this AzureBackupProtectionCheckVmSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupProtectionCheckVmSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionCheckVmSettings SetVerbose(this AzureBackupProtectionCheckVmSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupProtectionCheckVmSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionCheckVmSettings ResetVerbose(this AzureBackupProtectionCheckVmSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBackupProtectionDisableSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBackupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBackupProtectionDisableSettingsExtensions
    {
        #region ContainerName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupProtectionDisableSettings.ContainerName"/></em></p>
        ///   <p>Name of the container.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionDisableSettings SetContainerName(this AzureBackupProtectionDisableSettings toolSettings, string containerName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ContainerName = containerName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupProtectionDisableSettings.ContainerName"/></em></p>
        ///   <p>Name of the container.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionDisableSettings ResetContainerName(this AzureBackupProtectionDisableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ContainerName = null;
            return toolSettings;
        }
        #endregion
        #region ItemName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupProtectionDisableSettings.ItemName"/></em></p>
        ///   <p>Name of the backed up item.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionDisableSettings SetItemName(this AzureBackupProtectionDisableSettings toolSettings, string itemName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ItemName = itemName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupProtectionDisableSettings.ItemName"/></em></p>
        ///   <p>Name of the backed up item.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionDisableSettings ResetItemName(this AzureBackupProtectionDisableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ItemName = null;
            return toolSettings;
        }
        #endregion
        #region DeleteBackupData
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupProtectionDisableSettings.DeleteBackupData"/></em></p>
        ///   <p>Option to delete existing backed up data in the Recovery services vault.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionDisableSettings SetDeleteBackupData(this AzureBackupProtectionDisableSettings toolSettings, bool? deleteBackupData)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DeleteBackupData = deleteBackupData;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupProtectionDisableSettings.DeleteBackupData"/></em></p>
        ///   <p>Option to delete existing backed up data in the Recovery services vault.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionDisableSettings ResetDeleteBackupData(this AzureBackupProtectionDisableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DeleteBackupData = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureBackupProtectionDisableSettings.DeleteBackupData"/></em></p>
        ///   <p>Option to delete existing backed up data in the Recovery services vault.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionDisableSettings EnableDeleteBackupData(this AzureBackupProtectionDisableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DeleteBackupData = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureBackupProtectionDisableSettings.DeleteBackupData"/></em></p>
        ///   <p>Option to delete existing backed up data in the Recovery services vault.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionDisableSettings DisableDeleteBackupData(this AzureBackupProtectionDisableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DeleteBackupData = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureBackupProtectionDisableSettings.DeleteBackupData"/></em></p>
        ///   <p>Option to delete existing backed up data in the Recovery services vault.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionDisableSettings ToggleDeleteBackupData(this AzureBackupProtectionDisableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DeleteBackupData = !toolSettings.DeleteBackupData;
            return toolSettings;
        }
        #endregion
        #region Yes
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupProtectionDisableSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionDisableSettings SetYes(this AzureBackupProtectionDisableSettings toolSettings, string yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupProtectionDisableSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionDisableSettings ResetYes(this AzureBackupProtectionDisableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupProtectionDisableSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionDisableSettings SetIds(this AzureBackupProtectionDisableSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupProtectionDisableSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionDisableSettings SetIds(this AzureBackupProtectionDisableSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureBackupProtectionDisableSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionDisableSettings AddIds(this AzureBackupProtectionDisableSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureBackupProtectionDisableSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionDisableSettings AddIds(this AzureBackupProtectionDisableSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureBackupProtectionDisableSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionDisableSettings ClearIds(this AzureBackupProtectionDisableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureBackupProtectionDisableSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionDisableSettings RemoveIds(this AzureBackupProtectionDisableSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureBackupProtectionDisableSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionDisableSettings RemoveIds(this AzureBackupProtectionDisableSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupProtectionDisableSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionDisableSettings SetResourceGroup(this AzureBackupProtectionDisableSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupProtectionDisableSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionDisableSettings ResetResourceGroup(this AzureBackupProtectionDisableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupProtectionDisableSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionDisableSettings SetSubscription(this AzureBackupProtectionDisableSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupProtectionDisableSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionDisableSettings ResetSubscription(this AzureBackupProtectionDisableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region VaultName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupProtectionDisableSettings.VaultName"/></em></p>
        ///   <p>Name of the Recovery services vault.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionDisableSettings SetVaultName(this AzureBackupProtectionDisableSettings toolSettings, string vaultName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = vaultName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupProtectionDisableSettings.VaultName"/></em></p>
        ///   <p>Name of the Recovery services vault.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionDisableSettings ResetVaultName(this AzureBackupProtectionDisableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupProtectionDisableSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionDisableSettings SetDebug(this AzureBackupProtectionDisableSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupProtectionDisableSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionDisableSettings ResetDebug(this AzureBackupProtectionDisableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupProtectionDisableSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionDisableSettings SetHelp(this AzureBackupProtectionDisableSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupProtectionDisableSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionDisableSettings ResetHelp(this AzureBackupProtectionDisableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupProtectionDisableSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionDisableSettings SetOutput(this AzureBackupProtectionDisableSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupProtectionDisableSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionDisableSettings ResetOutput(this AzureBackupProtectionDisableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupProtectionDisableSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionDisableSettings SetQuery(this AzureBackupProtectionDisableSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupProtectionDisableSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionDisableSettings ResetQuery(this AzureBackupProtectionDisableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupProtectionDisableSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionDisableSettings SetVerbose(this AzureBackupProtectionDisableSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupProtectionDisableSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionDisableSettings ResetVerbose(this AzureBackupProtectionDisableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBackupProtectionEnableForVmSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBackupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBackupProtectionEnableForVmSettingsExtensions
    {
        #region PolicyName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupProtectionEnableForVmSettings.PolicyName"/></em></p>
        ///   <p>Name of the backup policy.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionEnableForVmSettings SetPolicyName(this AzureBackupProtectionEnableForVmSettings toolSettings, string policyName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PolicyName = policyName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupProtectionEnableForVmSettings.PolicyName"/></em></p>
        ///   <p>Name of the backup policy.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionEnableForVmSettings ResetPolicyName(this AzureBackupProtectionEnableForVmSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PolicyName = null;
            return toolSettings;
        }
        #endregion
        #region Vm
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupProtectionEnableForVmSettings.Vm"/></em></p>
        ///   <p>Name or ID of the Virtual Machine to be protected.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionEnableForVmSettings SetVm(this AzureBackupProtectionEnableForVmSettings toolSettings, string vm)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Vm = vm;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupProtectionEnableForVmSettings.Vm"/></em></p>
        ///   <p>Name or ID of the Virtual Machine to be protected.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionEnableForVmSettings ResetVm(this AzureBackupProtectionEnableForVmSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Vm = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupProtectionEnableForVmSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionEnableForVmSettings SetIds(this AzureBackupProtectionEnableForVmSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupProtectionEnableForVmSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionEnableForVmSettings SetIds(this AzureBackupProtectionEnableForVmSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureBackupProtectionEnableForVmSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionEnableForVmSettings AddIds(this AzureBackupProtectionEnableForVmSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureBackupProtectionEnableForVmSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionEnableForVmSettings AddIds(this AzureBackupProtectionEnableForVmSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureBackupProtectionEnableForVmSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionEnableForVmSettings ClearIds(this AzureBackupProtectionEnableForVmSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureBackupProtectionEnableForVmSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionEnableForVmSettings RemoveIds(this AzureBackupProtectionEnableForVmSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureBackupProtectionEnableForVmSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionEnableForVmSettings RemoveIds(this AzureBackupProtectionEnableForVmSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupProtectionEnableForVmSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionEnableForVmSettings SetResourceGroup(this AzureBackupProtectionEnableForVmSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupProtectionEnableForVmSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionEnableForVmSettings ResetResourceGroup(this AzureBackupProtectionEnableForVmSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupProtectionEnableForVmSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionEnableForVmSettings SetSubscription(this AzureBackupProtectionEnableForVmSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupProtectionEnableForVmSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionEnableForVmSettings ResetSubscription(this AzureBackupProtectionEnableForVmSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region VaultName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupProtectionEnableForVmSettings.VaultName"/></em></p>
        ///   <p>Name of the Recovery services vault.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionEnableForVmSettings SetVaultName(this AzureBackupProtectionEnableForVmSettings toolSettings, string vaultName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = vaultName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupProtectionEnableForVmSettings.VaultName"/></em></p>
        ///   <p>Name of the Recovery services vault.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionEnableForVmSettings ResetVaultName(this AzureBackupProtectionEnableForVmSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupProtectionEnableForVmSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionEnableForVmSettings SetDebug(this AzureBackupProtectionEnableForVmSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupProtectionEnableForVmSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionEnableForVmSettings ResetDebug(this AzureBackupProtectionEnableForVmSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupProtectionEnableForVmSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionEnableForVmSettings SetHelp(this AzureBackupProtectionEnableForVmSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupProtectionEnableForVmSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionEnableForVmSettings ResetHelp(this AzureBackupProtectionEnableForVmSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupProtectionEnableForVmSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionEnableForVmSettings SetOutput(this AzureBackupProtectionEnableForVmSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupProtectionEnableForVmSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionEnableForVmSettings ResetOutput(this AzureBackupProtectionEnableForVmSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupProtectionEnableForVmSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionEnableForVmSettings SetQuery(this AzureBackupProtectionEnableForVmSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupProtectionEnableForVmSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionEnableForVmSettings ResetQuery(this AzureBackupProtectionEnableForVmSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupProtectionEnableForVmSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionEnableForVmSettings SetVerbose(this AzureBackupProtectionEnableForVmSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupProtectionEnableForVmSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupProtectionEnableForVmSettings ResetVerbose(this AzureBackupProtectionEnableForVmSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBackupRecoverypointListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBackupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBackupRecoverypointListSettingsExtensions
    {
        #region ContainerName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupRecoverypointListSettings.ContainerName"/></em></p>
        ///   <p>Name of the container.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRecoverypointListSettings SetContainerName(this AzureBackupRecoverypointListSettings toolSettings, string containerName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ContainerName = containerName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupRecoverypointListSettings.ContainerName"/></em></p>
        ///   <p>Name of the container.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRecoverypointListSettings ResetContainerName(this AzureBackupRecoverypointListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ContainerName = null;
            return toolSettings;
        }
        #endregion
        #region ItemName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupRecoverypointListSettings.ItemName"/></em></p>
        ///   <p>Name of the backed up item.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRecoverypointListSettings SetItemName(this AzureBackupRecoverypointListSettings toolSettings, string itemName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ItemName = itemName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupRecoverypointListSettings.ItemName"/></em></p>
        ///   <p>Name of the backed up item.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRecoverypointListSettings ResetItemName(this AzureBackupRecoverypointListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ItemName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupRecoverypointListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRecoverypointListSettings SetResourceGroup(this AzureBackupRecoverypointListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupRecoverypointListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRecoverypointListSettings ResetResourceGroup(this AzureBackupRecoverypointListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region VaultName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupRecoverypointListSettings.VaultName"/></em></p>
        ///   <p>Name of the Recovery services vault.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRecoverypointListSettings SetVaultName(this AzureBackupRecoverypointListSettings toolSettings, string vaultName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = vaultName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupRecoverypointListSettings.VaultName"/></em></p>
        ///   <p>Name of the Recovery services vault.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRecoverypointListSettings ResetVaultName(this AzureBackupRecoverypointListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = null;
            return toolSettings;
        }
        #endregion
        #region EndDate
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupRecoverypointListSettings.EndDate"/></em></p>
        ///   <p>The end date of the range in UTC (d-m-Y).</p>
        /// </summary>
        [Pure]
        public static AzureBackupRecoverypointListSettings SetEndDate(this AzureBackupRecoverypointListSettings toolSettings, string endDate)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndDate = endDate;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupRecoverypointListSettings.EndDate"/></em></p>
        ///   <p>The end date of the range in UTC (d-m-Y).</p>
        /// </summary>
        [Pure]
        public static AzureBackupRecoverypointListSettings ResetEndDate(this AzureBackupRecoverypointListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndDate = null;
            return toolSettings;
        }
        #endregion
        #region StartDate
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupRecoverypointListSettings.StartDate"/></em></p>
        ///   <p>The start date of the range in UTC (d-m-Y).</p>
        /// </summary>
        [Pure]
        public static AzureBackupRecoverypointListSettings SetStartDate(this AzureBackupRecoverypointListSettings toolSettings, string startDate)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartDate = startDate;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupRecoverypointListSettings.StartDate"/></em></p>
        ///   <p>The start date of the range in UTC (d-m-Y).</p>
        /// </summary>
        [Pure]
        public static AzureBackupRecoverypointListSettings ResetStartDate(this AzureBackupRecoverypointListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartDate = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupRecoverypointListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRecoverypointListSettings SetSubscription(this AzureBackupRecoverypointListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupRecoverypointListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRecoverypointListSettings ResetSubscription(this AzureBackupRecoverypointListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupRecoverypointListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRecoverypointListSettings SetDebug(this AzureBackupRecoverypointListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupRecoverypointListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRecoverypointListSettings ResetDebug(this AzureBackupRecoverypointListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupRecoverypointListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRecoverypointListSettings SetHelp(this AzureBackupRecoverypointListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupRecoverypointListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRecoverypointListSettings ResetHelp(this AzureBackupRecoverypointListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupRecoverypointListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRecoverypointListSettings SetOutput(this AzureBackupRecoverypointListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupRecoverypointListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRecoverypointListSettings ResetOutput(this AzureBackupRecoverypointListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupRecoverypointListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRecoverypointListSettings SetQuery(this AzureBackupRecoverypointListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupRecoverypointListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRecoverypointListSettings ResetQuery(this AzureBackupRecoverypointListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupRecoverypointListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRecoverypointListSettings SetVerbose(this AzureBackupRecoverypointListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupRecoverypointListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRecoverypointListSettings ResetVerbose(this AzureBackupRecoverypointListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBackupRecoverypointShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBackupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBackupRecoverypointShowSettingsExtensions
    {
        #region ContainerName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupRecoverypointShowSettings.ContainerName"/></em></p>
        ///   <p>Name of the container.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRecoverypointShowSettings SetContainerName(this AzureBackupRecoverypointShowSettings toolSettings, string containerName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ContainerName = containerName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupRecoverypointShowSettings.ContainerName"/></em></p>
        ///   <p>Name of the container.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRecoverypointShowSettings ResetContainerName(this AzureBackupRecoverypointShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ContainerName = null;
            return toolSettings;
        }
        #endregion
        #region ItemName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupRecoverypointShowSettings.ItemName"/></em></p>
        ///   <p>Name of the backed up item.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRecoverypointShowSettings SetItemName(this AzureBackupRecoverypointShowSettings toolSettings, string itemName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ItemName = itemName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupRecoverypointShowSettings.ItemName"/></em></p>
        ///   <p>Name of the backed up item.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRecoverypointShowSettings ResetItemName(this AzureBackupRecoverypointShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ItemName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupRecoverypointShowSettings.Name"/></em></p>
        ///   <p>Name of the recovery point. You can use the backup recovery point list command to get the name of a backed up item.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRecoverypointShowSettings SetName(this AzureBackupRecoverypointShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupRecoverypointShowSettings.Name"/></em></p>
        ///   <p>Name of the recovery point. You can use the backup recovery point list command to get the name of a backed up item.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRecoverypointShowSettings ResetName(this AzureBackupRecoverypointShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupRecoverypointShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRecoverypointShowSettings SetIds(this AzureBackupRecoverypointShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupRecoverypointShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRecoverypointShowSettings SetIds(this AzureBackupRecoverypointShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureBackupRecoverypointShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRecoverypointShowSettings AddIds(this AzureBackupRecoverypointShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureBackupRecoverypointShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRecoverypointShowSettings AddIds(this AzureBackupRecoverypointShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureBackupRecoverypointShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRecoverypointShowSettings ClearIds(this AzureBackupRecoverypointShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureBackupRecoverypointShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRecoverypointShowSettings RemoveIds(this AzureBackupRecoverypointShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureBackupRecoverypointShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRecoverypointShowSettings RemoveIds(this AzureBackupRecoverypointShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupRecoverypointShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRecoverypointShowSettings SetResourceGroup(this AzureBackupRecoverypointShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupRecoverypointShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRecoverypointShowSettings ResetResourceGroup(this AzureBackupRecoverypointShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupRecoverypointShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRecoverypointShowSettings SetSubscription(this AzureBackupRecoverypointShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupRecoverypointShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRecoverypointShowSettings ResetSubscription(this AzureBackupRecoverypointShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region VaultName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupRecoverypointShowSettings.VaultName"/></em></p>
        ///   <p>Name of the Recovery services vault.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRecoverypointShowSettings SetVaultName(this AzureBackupRecoverypointShowSettings toolSettings, string vaultName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = vaultName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupRecoverypointShowSettings.VaultName"/></em></p>
        ///   <p>Name of the Recovery services vault.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRecoverypointShowSettings ResetVaultName(this AzureBackupRecoverypointShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupRecoverypointShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRecoverypointShowSettings SetDebug(this AzureBackupRecoverypointShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupRecoverypointShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRecoverypointShowSettings ResetDebug(this AzureBackupRecoverypointShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupRecoverypointShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRecoverypointShowSettings SetHelp(this AzureBackupRecoverypointShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupRecoverypointShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRecoverypointShowSettings ResetHelp(this AzureBackupRecoverypointShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupRecoverypointShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRecoverypointShowSettings SetOutput(this AzureBackupRecoverypointShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupRecoverypointShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRecoverypointShowSettings ResetOutput(this AzureBackupRecoverypointShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupRecoverypointShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRecoverypointShowSettings SetQuery(this AzureBackupRecoverypointShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupRecoverypointShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRecoverypointShowSettings ResetQuery(this AzureBackupRecoverypointShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupRecoverypointShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRecoverypointShowSettings SetVerbose(this AzureBackupRecoverypointShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupRecoverypointShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRecoverypointShowSettings ResetVerbose(this AzureBackupRecoverypointShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBackupRestoreRestoreDisksSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBackupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBackupRestoreRestoreDisksSettingsExtensions
    {
        #region ContainerName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupRestoreRestoreDisksSettings.ContainerName"/></em></p>
        ///   <p>Name of the container.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreRestoreDisksSettings SetContainerName(this AzureBackupRestoreRestoreDisksSettings toolSettings, string containerName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ContainerName = containerName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupRestoreRestoreDisksSettings.ContainerName"/></em></p>
        ///   <p>Name of the container.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreRestoreDisksSettings ResetContainerName(this AzureBackupRestoreRestoreDisksSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ContainerName = null;
            return toolSettings;
        }
        #endregion
        #region ItemName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupRestoreRestoreDisksSettings.ItemName"/></em></p>
        ///   <p>Name of the backed up item.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreRestoreDisksSettings SetItemName(this AzureBackupRestoreRestoreDisksSettings toolSettings, string itemName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ItemName = itemName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupRestoreRestoreDisksSettings.ItemName"/></em></p>
        ///   <p>Name of the backed up item.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreRestoreDisksSettings ResetItemName(this AzureBackupRestoreRestoreDisksSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ItemName = null;
            return toolSettings;
        }
        #endregion
        #region RpName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupRestoreRestoreDisksSettings.RpName"/></em></p>
        ///   <p>Name of the recovery point.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreRestoreDisksSettings SetRpName(this AzureBackupRestoreRestoreDisksSettings toolSettings, string rpName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RpName = rpName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupRestoreRestoreDisksSettings.RpName"/></em></p>
        ///   <p>Name of the recovery point.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreRestoreDisksSettings ResetRpName(this AzureBackupRestoreRestoreDisksSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RpName = null;
            return toolSettings;
        }
        #endregion
        #region StorageAccount
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupRestoreRestoreDisksSettings.StorageAccount"/></em></p>
        ///   <p>Name or ID of the staging storage account. The VM configuration will be restored to this storage account. See the help for --restore-to-staging-storage-account parameter for more info.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreRestoreDisksSettings SetStorageAccount(this AzureBackupRestoreRestoreDisksSettings toolSettings, string storageAccount)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageAccount = storageAccount;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupRestoreRestoreDisksSettings.StorageAccount"/></em></p>
        ///   <p>Name or ID of the staging storage account. The VM configuration will be restored to this storage account. See the help for --restore-to-staging-storage-account parameter for more info.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreRestoreDisksSettings ResetStorageAccount(this AzureBackupRestoreRestoreDisksSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageAccount = null;
            return toolSettings;
        }
        #endregion
        #region RestoreToStagingStorageAccount
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupRestoreRestoreDisksSettings.RestoreToStagingStorageAccount"/></em></p>
        ///   <p>Use this flag when you want disks to be restored to the staging storage account using the --storage-account parameter. When not specified, disks will be restored to their original storage accounts. Default: false.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreRestoreDisksSettings SetRestoreToStagingStorageAccount(this AzureBackupRestoreRestoreDisksSettings toolSettings, bool? restoreToStagingStorageAccount)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RestoreToStagingStorageAccount = restoreToStagingStorageAccount;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupRestoreRestoreDisksSettings.RestoreToStagingStorageAccount"/></em></p>
        ///   <p>Use this flag when you want disks to be restored to the staging storage account using the --storage-account parameter. When not specified, disks will be restored to their original storage accounts. Default: false.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreRestoreDisksSettings ResetRestoreToStagingStorageAccount(this AzureBackupRestoreRestoreDisksSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RestoreToStagingStorageAccount = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureBackupRestoreRestoreDisksSettings.RestoreToStagingStorageAccount"/></em></p>
        ///   <p>Use this flag when you want disks to be restored to the staging storage account using the --storage-account parameter. When not specified, disks will be restored to their original storage accounts. Default: false.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreRestoreDisksSettings EnableRestoreToStagingStorageAccount(this AzureBackupRestoreRestoreDisksSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RestoreToStagingStorageAccount = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureBackupRestoreRestoreDisksSettings.RestoreToStagingStorageAccount"/></em></p>
        ///   <p>Use this flag when you want disks to be restored to the staging storage account using the --storage-account parameter. When not specified, disks will be restored to their original storage accounts. Default: false.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreRestoreDisksSettings DisableRestoreToStagingStorageAccount(this AzureBackupRestoreRestoreDisksSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RestoreToStagingStorageAccount = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureBackupRestoreRestoreDisksSettings.RestoreToStagingStorageAccount"/></em></p>
        ///   <p>Use this flag when you want disks to be restored to the staging storage account using the --storage-account parameter. When not specified, disks will be restored to their original storage accounts. Default: false.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreRestoreDisksSettings ToggleRestoreToStagingStorageAccount(this AzureBackupRestoreRestoreDisksSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RestoreToStagingStorageAccount = !toolSettings.RestoreToStagingStorageAccount;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupRestoreRestoreDisksSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreRestoreDisksSettings SetIds(this AzureBackupRestoreRestoreDisksSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupRestoreRestoreDisksSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreRestoreDisksSettings SetIds(this AzureBackupRestoreRestoreDisksSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureBackupRestoreRestoreDisksSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreRestoreDisksSettings AddIds(this AzureBackupRestoreRestoreDisksSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureBackupRestoreRestoreDisksSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreRestoreDisksSettings AddIds(this AzureBackupRestoreRestoreDisksSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureBackupRestoreRestoreDisksSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreRestoreDisksSettings ClearIds(this AzureBackupRestoreRestoreDisksSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureBackupRestoreRestoreDisksSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreRestoreDisksSettings RemoveIds(this AzureBackupRestoreRestoreDisksSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureBackupRestoreRestoreDisksSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreRestoreDisksSettings RemoveIds(this AzureBackupRestoreRestoreDisksSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupRestoreRestoreDisksSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreRestoreDisksSettings SetResourceGroup(this AzureBackupRestoreRestoreDisksSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupRestoreRestoreDisksSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreRestoreDisksSettings ResetResourceGroup(this AzureBackupRestoreRestoreDisksSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupRestoreRestoreDisksSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreRestoreDisksSettings SetSubscription(this AzureBackupRestoreRestoreDisksSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupRestoreRestoreDisksSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreRestoreDisksSettings ResetSubscription(this AzureBackupRestoreRestoreDisksSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region VaultName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupRestoreRestoreDisksSettings.VaultName"/></em></p>
        ///   <p>Name of the Recovery services vault.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreRestoreDisksSettings SetVaultName(this AzureBackupRestoreRestoreDisksSettings toolSettings, string vaultName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = vaultName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupRestoreRestoreDisksSettings.VaultName"/></em></p>
        ///   <p>Name of the Recovery services vault.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreRestoreDisksSettings ResetVaultName(this AzureBackupRestoreRestoreDisksSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupRestoreRestoreDisksSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreRestoreDisksSettings SetDebug(this AzureBackupRestoreRestoreDisksSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupRestoreRestoreDisksSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreRestoreDisksSettings ResetDebug(this AzureBackupRestoreRestoreDisksSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupRestoreRestoreDisksSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreRestoreDisksSettings SetHelp(this AzureBackupRestoreRestoreDisksSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupRestoreRestoreDisksSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreRestoreDisksSettings ResetHelp(this AzureBackupRestoreRestoreDisksSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupRestoreRestoreDisksSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreRestoreDisksSettings SetOutput(this AzureBackupRestoreRestoreDisksSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupRestoreRestoreDisksSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreRestoreDisksSettings ResetOutput(this AzureBackupRestoreRestoreDisksSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupRestoreRestoreDisksSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreRestoreDisksSettings SetQuery(this AzureBackupRestoreRestoreDisksSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupRestoreRestoreDisksSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreRestoreDisksSettings ResetQuery(this AzureBackupRestoreRestoreDisksSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupRestoreRestoreDisksSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreRestoreDisksSettings SetVerbose(this AzureBackupRestoreRestoreDisksSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupRestoreRestoreDisksSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreRestoreDisksSettings ResetVerbose(this AzureBackupRestoreRestoreDisksSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBackupVaultCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBackupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBackupVaultCreateSettingsExtensions
    {
        #region Location
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupVaultCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultCreateSettings SetLocation(this AzureBackupVaultCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupVaultCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultCreateSettings ResetLocation(this AzureBackupVaultCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupVaultCreateSettings.Name"/></em></p>
        ///   <p>Name of the Recovery services vault.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultCreateSettings SetName(this AzureBackupVaultCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupVaultCreateSettings.Name"/></em></p>
        ///   <p>Name of the Recovery services vault.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultCreateSettings ResetName(this AzureBackupVaultCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupVaultCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultCreateSettings SetResourceGroup(this AzureBackupVaultCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupVaultCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultCreateSettings ResetResourceGroup(this AzureBackupVaultCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupVaultCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultCreateSettings SetSubscription(this AzureBackupVaultCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupVaultCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultCreateSettings ResetSubscription(this AzureBackupVaultCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupVaultCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultCreateSettings SetDebug(this AzureBackupVaultCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupVaultCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultCreateSettings ResetDebug(this AzureBackupVaultCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupVaultCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultCreateSettings SetHelp(this AzureBackupVaultCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupVaultCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultCreateSettings ResetHelp(this AzureBackupVaultCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupVaultCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultCreateSettings SetOutput(this AzureBackupVaultCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupVaultCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultCreateSettings ResetOutput(this AzureBackupVaultCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupVaultCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultCreateSettings SetQuery(this AzureBackupVaultCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupVaultCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultCreateSettings ResetQuery(this AzureBackupVaultCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupVaultCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultCreateSettings SetVerbose(this AzureBackupVaultCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupVaultCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultCreateSettings ResetVerbose(this AzureBackupVaultCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBackupVaultDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBackupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBackupVaultDeleteSettingsExtensions
    {
        #region Force
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupVaultDeleteSettings.Force"/></em></p>
        ///   <p>Force completion of the requested action.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultDeleteSettings SetForce(this AzureBackupVaultDeleteSettings toolSettings, string force)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Force = force;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupVaultDeleteSettings.Force"/></em></p>
        ///   <p>Force completion of the requested action.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultDeleteSettings ResetForce(this AzureBackupVaultDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Force = null;
            return toolSettings;
        }
        #endregion
        #region Yes
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupVaultDeleteSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultDeleteSettings SetYes(this AzureBackupVaultDeleteSettings toolSettings, string yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupVaultDeleteSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultDeleteSettings ResetYes(this AzureBackupVaultDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupVaultDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultDeleteSettings SetIds(this AzureBackupVaultDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupVaultDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultDeleteSettings SetIds(this AzureBackupVaultDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureBackupVaultDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultDeleteSettings AddIds(this AzureBackupVaultDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureBackupVaultDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultDeleteSettings AddIds(this AzureBackupVaultDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureBackupVaultDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultDeleteSettings ClearIds(this AzureBackupVaultDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureBackupVaultDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultDeleteSettings RemoveIds(this AzureBackupVaultDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureBackupVaultDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultDeleteSettings RemoveIds(this AzureBackupVaultDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupVaultDeleteSettings.Name"/></em></p>
        ///   <p>Name of the Recovery services vault.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultDeleteSettings SetName(this AzureBackupVaultDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupVaultDeleteSettings.Name"/></em></p>
        ///   <p>Name of the Recovery services vault.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultDeleteSettings ResetName(this AzureBackupVaultDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupVaultDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultDeleteSettings SetResourceGroup(this AzureBackupVaultDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupVaultDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultDeleteSettings ResetResourceGroup(this AzureBackupVaultDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupVaultDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultDeleteSettings SetSubscription(this AzureBackupVaultDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupVaultDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultDeleteSettings ResetSubscription(this AzureBackupVaultDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupVaultDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultDeleteSettings SetDebug(this AzureBackupVaultDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupVaultDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultDeleteSettings ResetDebug(this AzureBackupVaultDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupVaultDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultDeleteSettings SetHelp(this AzureBackupVaultDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupVaultDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultDeleteSettings ResetHelp(this AzureBackupVaultDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupVaultDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultDeleteSettings SetOutput(this AzureBackupVaultDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupVaultDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultDeleteSettings ResetOutput(this AzureBackupVaultDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupVaultDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultDeleteSettings SetQuery(this AzureBackupVaultDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupVaultDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultDeleteSettings ResetQuery(this AzureBackupVaultDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupVaultDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultDeleteSettings SetVerbose(this AzureBackupVaultDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupVaultDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultDeleteSettings ResetVerbose(this AzureBackupVaultDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBackupVaultListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBackupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBackupVaultListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupVaultListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultListSettings SetResourceGroup(this AzureBackupVaultListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupVaultListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultListSettings ResetResourceGroup(this AzureBackupVaultListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupVaultListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultListSettings SetSubscription(this AzureBackupVaultListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupVaultListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultListSettings ResetSubscription(this AzureBackupVaultListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupVaultListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultListSettings SetDebug(this AzureBackupVaultListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupVaultListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultListSettings ResetDebug(this AzureBackupVaultListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupVaultListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultListSettings SetHelp(this AzureBackupVaultListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupVaultListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultListSettings ResetHelp(this AzureBackupVaultListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupVaultListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultListSettings SetOutput(this AzureBackupVaultListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupVaultListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultListSettings ResetOutput(this AzureBackupVaultListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupVaultListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultListSettings SetQuery(this AzureBackupVaultListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupVaultListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultListSettings ResetQuery(this AzureBackupVaultListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupVaultListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultListSettings SetVerbose(this AzureBackupVaultListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupVaultListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultListSettings ResetVerbose(this AzureBackupVaultListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBackupVaultShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBackupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBackupVaultShowSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupVaultShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultShowSettings SetIds(this AzureBackupVaultShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupVaultShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultShowSettings SetIds(this AzureBackupVaultShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureBackupVaultShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultShowSettings AddIds(this AzureBackupVaultShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureBackupVaultShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultShowSettings AddIds(this AzureBackupVaultShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureBackupVaultShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultShowSettings ClearIds(this AzureBackupVaultShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureBackupVaultShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultShowSettings RemoveIds(this AzureBackupVaultShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureBackupVaultShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultShowSettings RemoveIds(this AzureBackupVaultShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupVaultShowSettings.Name"/></em></p>
        ///   <p>Name of the Recovery services vault.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultShowSettings SetName(this AzureBackupVaultShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupVaultShowSettings.Name"/></em></p>
        ///   <p>Name of the Recovery services vault.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultShowSettings ResetName(this AzureBackupVaultShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupVaultShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultShowSettings SetResourceGroup(this AzureBackupVaultShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupVaultShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultShowSettings ResetResourceGroup(this AzureBackupVaultShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupVaultShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultShowSettings SetSubscription(this AzureBackupVaultShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupVaultShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultShowSettings ResetSubscription(this AzureBackupVaultShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupVaultShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultShowSettings SetDebug(this AzureBackupVaultShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupVaultShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultShowSettings ResetDebug(this AzureBackupVaultShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupVaultShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultShowSettings SetHelp(this AzureBackupVaultShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupVaultShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultShowSettings ResetHelp(this AzureBackupVaultShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupVaultShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultShowSettings SetOutput(this AzureBackupVaultShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupVaultShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultShowSettings ResetOutput(this AzureBackupVaultShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupVaultShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultShowSettings SetQuery(this AzureBackupVaultShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupVaultShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultShowSettings ResetQuery(this AzureBackupVaultShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupVaultShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultShowSettings SetVerbose(this AzureBackupVaultShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupVaultShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultShowSettings ResetVerbose(this AzureBackupVaultShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBackupRestoreFilesMountRpSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBackupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBackupRestoreFilesMountRpSettingsExtensions
    {
        #region ContainerName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupRestoreFilesMountRpSettings.ContainerName"/></em></p>
        ///   <p>Name of the container.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreFilesMountRpSettings SetContainerName(this AzureBackupRestoreFilesMountRpSettings toolSettings, string containerName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ContainerName = containerName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupRestoreFilesMountRpSettings.ContainerName"/></em></p>
        ///   <p>Name of the container.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreFilesMountRpSettings ResetContainerName(this AzureBackupRestoreFilesMountRpSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ContainerName = null;
            return toolSettings;
        }
        #endregion
        #region ItemName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupRestoreFilesMountRpSettings.ItemName"/></em></p>
        ///   <p>Name of the backed up item.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreFilesMountRpSettings SetItemName(this AzureBackupRestoreFilesMountRpSettings toolSettings, string itemName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ItemName = itemName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupRestoreFilesMountRpSettings.ItemName"/></em></p>
        ///   <p>Name of the backed up item.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreFilesMountRpSettings ResetItemName(this AzureBackupRestoreFilesMountRpSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ItemName = null;
            return toolSettings;
        }
        #endregion
        #region RpName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupRestoreFilesMountRpSettings.RpName"/></em></p>
        ///   <p>Name of the recovery point.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreFilesMountRpSettings SetRpName(this AzureBackupRestoreFilesMountRpSettings toolSettings, string rpName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RpName = rpName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupRestoreFilesMountRpSettings.RpName"/></em></p>
        ///   <p>Name of the recovery point.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreFilesMountRpSettings ResetRpName(this AzureBackupRestoreFilesMountRpSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RpName = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupRestoreFilesMountRpSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreFilesMountRpSettings SetIds(this AzureBackupRestoreFilesMountRpSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupRestoreFilesMountRpSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreFilesMountRpSettings SetIds(this AzureBackupRestoreFilesMountRpSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureBackupRestoreFilesMountRpSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreFilesMountRpSettings AddIds(this AzureBackupRestoreFilesMountRpSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureBackupRestoreFilesMountRpSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreFilesMountRpSettings AddIds(this AzureBackupRestoreFilesMountRpSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureBackupRestoreFilesMountRpSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreFilesMountRpSettings ClearIds(this AzureBackupRestoreFilesMountRpSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureBackupRestoreFilesMountRpSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreFilesMountRpSettings RemoveIds(this AzureBackupRestoreFilesMountRpSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureBackupRestoreFilesMountRpSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreFilesMountRpSettings RemoveIds(this AzureBackupRestoreFilesMountRpSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupRestoreFilesMountRpSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreFilesMountRpSettings SetResourceGroup(this AzureBackupRestoreFilesMountRpSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupRestoreFilesMountRpSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreFilesMountRpSettings ResetResourceGroup(this AzureBackupRestoreFilesMountRpSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupRestoreFilesMountRpSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreFilesMountRpSettings SetSubscription(this AzureBackupRestoreFilesMountRpSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupRestoreFilesMountRpSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreFilesMountRpSettings ResetSubscription(this AzureBackupRestoreFilesMountRpSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region VaultName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupRestoreFilesMountRpSettings.VaultName"/></em></p>
        ///   <p>Name of the Recovery services vault.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreFilesMountRpSettings SetVaultName(this AzureBackupRestoreFilesMountRpSettings toolSettings, string vaultName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = vaultName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupRestoreFilesMountRpSettings.VaultName"/></em></p>
        ///   <p>Name of the Recovery services vault.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreFilesMountRpSettings ResetVaultName(this AzureBackupRestoreFilesMountRpSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupRestoreFilesMountRpSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreFilesMountRpSettings SetDebug(this AzureBackupRestoreFilesMountRpSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupRestoreFilesMountRpSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreFilesMountRpSettings ResetDebug(this AzureBackupRestoreFilesMountRpSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupRestoreFilesMountRpSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreFilesMountRpSettings SetHelp(this AzureBackupRestoreFilesMountRpSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupRestoreFilesMountRpSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreFilesMountRpSettings ResetHelp(this AzureBackupRestoreFilesMountRpSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupRestoreFilesMountRpSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreFilesMountRpSettings SetOutput(this AzureBackupRestoreFilesMountRpSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupRestoreFilesMountRpSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreFilesMountRpSettings ResetOutput(this AzureBackupRestoreFilesMountRpSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupRestoreFilesMountRpSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreFilesMountRpSettings SetQuery(this AzureBackupRestoreFilesMountRpSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupRestoreFilesMountRpSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreFilesMountRpSettings ResetQuery(this AzureBackupRestoreFilesMountRpSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupRestoreFilesMountRpSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreFilesMountRpSettings SetVerbose(this AzureBackupRestoreFilesMountRpSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupRestoreFilesMountRpSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreFilesMountRpSettings ResetVerbose(this AzureBackupRestoreFilesMountRpSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBackupRestoreFilesUnmountRpSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBackupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBackupRestoreFilesUnmountRpSettingsExtensions
    {
        #region ContainerName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupRestoreFilesUnmountRpSettings.ContainerName"/></em></p>
        ///   <p>Name of the container.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreFilesUnmountRpSettings SetContainerName(this AzureBackupRestoreFilesUnmountRpSettings toolSettings, string containerName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ContainerName = containerName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupRestoreFilesUnmountRpSettings.ContainerName"/></em></p>
        ///   <p>Name of the container.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreFilesUnmountRpSettings ResetContainerName(this AzureBackupRestoreFilesUnmountRpSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ContainerName = null;
            return toolSettings;
        }
        #endregion
        #region ItemName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupRestoreFilesUnmountRpSettings.ItemName"/></em></p>
        ///   <p>Name of the backed up item.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreFilesUnmountRpSettings SetItemName(this AzureBackupRestoreFilesUnmountRpSettings toolSettings, string itemName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ItemName = itemName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupRestoreFilesUnmountRpSettings.ItemName"/></em></p>
        ///   <p>Name of the backed up item.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreFilesUnmountRpSettings ResetItemName(this AzureBackupRestoreFilesUnmountRpSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ItemName = null;
            return toolSettings;
        }
        #endregion
        #region RpName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupRestoreFilesUnmountRpSettings.RpName"/></em></p>
        ///   <p>Name of the recovery point.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreFilesUnmountRpSettings SetRpName(this AzureBackupRestoreFilesUnmountRpSettings toolSettings, string rpName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RpName = rpName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupRestoreFilesUnmountRpSettings.RpName"/></em></p>
        ///   <p>Name of the recovery point.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreFilesUnmountRpSettings ResetRpName(this AzureBackupRestoreFilesUnmountRpSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RpName = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupRestoreFilesUnmountRpSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreFilesUnmountRpSettings SetIds(this AzureBackupRestoreFilesUnmountRpSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupRestoreFilesUnmountRpSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreFilesUnmountRpSettings SetIds(this AzureBackupRestoreFilesUnmountRpSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureBackupRestoreFilesUnmountRpSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreFilesUnmountRpSettings AddIds(this AzureBackupRestoreFilesUnmountRpSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureBackupRestoreFilesUnmountRpSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreFilesUnmountRpSettings AddIds(this AzureBackupRestoreFilesUnmountRpSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureBackupRestoreFilesUnmountRpSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreFilesUnmountRpSettings ClearIds(this AzureBackupRestoreFilesUnmountRpSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureBackupRestoreFilesUnmountRpSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreFilesUnmountRpSettings RemoveIds(this AzureBackupRestoreFilesUnmountRpSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureBackupRestoreFilesUnmountRpSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreFilesUnmountRpSettings RemoveIds(this AzureBackupRestoreFilesUnmountRpSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupRestoreFilesUnmountRpSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreFilesUnmountRpSettings SetResourceGroup(this AzureBackupRestoreFilesUnmountRpSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupRestoreFilesUnmountRpSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreFilesUnmountRpSettings ResetResourceGroup(this AzureBackupRestoreFilesUnmountRpSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupRestoreFilesUnmountRpSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreFilesUnmountRpSettings SetSubscription(this AzureBackupRestoreFilesUnmountRpSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupRestoreFilesUnmountRpSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreFilesUnmountRpSettings ResetSubscription(this AzureBackupRestoreFilesUnmountRpSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region VaultName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupRestoreFilesUnmountRpSettings.VaultName"/></em></p>
        ///   <p>Name of the Recovery services vault.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreFilesUnmountRpSettings SetVaultName(this AzureBackupRestoreFilesUnmountRpSettings toolSettings, string vaultName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = vaultName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupRestoreFilesUnmountRpSettings.VaultName"/></em></p>
        ///   <p>Name of the Recovery services vault.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreFilesUnmountRpSettings ResetVaultName(this AzureBackupRestoreFilesUnmountRpSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupRestoreFilesUnmountRpSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreFilesUnmountRpSettings SetDebug(this AzureBackupRestoreFilesUnmountRpSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupRestoreFilesUnmountRpSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreFilesUnmountRpSettings ResetDebug(this AzureBackupRestoreFilesUnmountRpSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupRestoreFilesUnmountRpSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreFilesUnmountRpSettings SetHelp(this AzureBackupRestoreFilesUnmountRpSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupRestoreFilesUnmountRpSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreFilesUnmountRpSettings ResetHelp(this AzureBackupRestoreFilesUnmountRpSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupRestoreFilesUnmountRpSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreFilesUnmountRpSettings SetOutput(this AzureBackupRestoreFilesUnmountRpSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupRestoreFilesUnmountRpSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreFilesUnmountRpSettings ResetOutput(this AzureBackupRestoreFilesUnmountRpSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupRestoreFilesUnmountRpSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreFilesUnmountRpSettings SetQuery(this AzureBackupRestoreFilesUnmountRpSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupRestoreFilesUnmountRpSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreFilesUnmountRpSettings ResetQuery(this AzureBackupRestoreFilesUnmountRpSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupRestoreFilesUnmountRpSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreFilesUnmountRpSettings SetVerbose(this AzureBackupRestoreFilesUnmountRpSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupRestoreFilesUnmountRpSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupRestoreFilesUnmountRpSettings ResetVerbose(this AzureBackupRestoreFilesUnmountRpSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBackupVaultBackupPropertiesSetSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBackupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBackupVaultBackupPropertiesSetSettingsExtensions
    {
        #region BackupStorageRedundancy
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupVaultBackupPropertiesSetSettings.BackupStorageRedundancy"/></em></p>
        ///   <p>Sets backup storage properties for a Recovery Services vault.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultBackupPropertiesSetSettings SetBackupStorageRedundancy(this AzureBackupVaultBackupPropertiesSetSettings toolSettings, BackupVaultBackupPropertiesSetBackupStorageRedundancy backupStorageRedundancy)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BackupStorageRedundancy = backupStorageRedundancy;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupVaultBackupPropertiesSetSettings.BackupStorageRedundancy"/></em></p>
        ///   <p>Sets backup storage properties for a Recovery Services vault.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultBackupPropertiesSetSettings ResetBackupStorageRedundancy(this AzureBackupVaultBackupPropertiesSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BackupStorageRedundancy = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupVaultBackupPropertiesSetSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultBackupPropertiesSetSettings SetIds(this AzureBackupVaultBackupPropertiesSetSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupVaultBackupPropertiesSetSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultBackupPropertiesSetSettings SetIds(this AzureBackupVaultBackupPropertiesSetSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureBackupVaultBackupPropertiesSetSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultBackupPropertiesSetSettings AddIds(this AzureBackupVaultBackupPropertiesSetSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureBackupVaultBackupPropertiesSetSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultBackupPropertiesSetSettings AddIds(this AzureBackupVaultBackupPropertiesSetSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureBackupVaultBackupPropertiesSetSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultBackupPropertiesSetSettings ClearIds(this AzureBackupVaultBackupPropertiesSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureBackupVaultBackupPropertiesSetSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultBackupPropertiesSetSettings RemoveIds(this AzureBackupVaultBackupPropertiesSetSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureBackupVaultBackupPropertiesSetSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultBackupPropertiesSetSettings RemoveIds(this AzureBackupVaultBackupPropertiesSetSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupVaultBackupPropertiesSetSettings.Name"/></em></p>
        ///   <p>Name of the Recovery services vault.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultBackupPropertiesSetSettings SetName(this AzureBackupVaultBackupPropertiesSetSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupVaultBackupPropertiesSetSettings.Name"/></em></p>
        ///   <p>Name of the Recovery services vault.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultBackupPropertiesSetSettings ResetName(this AzureBackupVaultBackupPropertiesSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupVaultBackupPropertiesSetSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultBackupPropertiesSetSettings SetResourceGroup(this AzureBackupVaultBackupPropertiesSetSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupVaultBackupPropertiesSetSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultBackupPropertiesSetSettings ResetResourceGroup(this AzureBackupVaultBackupPropertiesSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupVaultBackupPropertiesSetSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultBackupPropertiesSetSettings SetSubscription(this AzureBackupVaultBackupPropertiesSetSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupVaultBackupPropertiesSetSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultBackupPropertiesSetSettings ResetSubscription(this AzureBackupVaultBackupPropertiesSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupVaultBackupPropertiesSetSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultBackupPropertiesSetSettings SetDebug(this AzureBackupVaultBackupPropertiesSetSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupVaultBackupPropertiesSetSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultBackupPropertiesSetSettings ResetDebug(this AzureBackupVaultBackupPropertiesSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupVaultBackupPropertiesSetSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultBackupPropertiesSetSettings SetHelp(this AzureBackupVaultBackupPropertiesSetSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupVaultBackupPropertiesSetSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultBackupPropertiesSetSettings ResetHelp(this AzureBackupVaultBackupPropertiesSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupVaultBackupPropertiesSetSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultBackupPropertiesSetSettings SetOutput(this AzureBackupVaultBackupPropertiesSetSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupVaultBackupPropertiesSetSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultBackupPropertiesSetSettings ResetOutput(this AzureBackupVaultBackupPropertiesSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupVaultBackupPropertiesSetSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultBackupPropertiesSetSettings SetQuery(this AzureBackupVaultBackupPropertiesSetSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupVaultBackupPropertiesSetSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultBackupPropertiesSetSettings ResetQuery(this AzureBackupVaultBackupPropertiesSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupVaultBackupPropertiesSetSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultBackupPropertiesSetSettings SetVerbose(this AzureBackupVaultBackupPropertiesSetSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupVaultBackupPropertiesSetSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultBackupPropertiesSetSettings ResetVerbose(this AzureBackupVaultBackupPropertiesSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBackupVaultBackupPropertiesShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBackupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBackupVaultBackupPropertiesShowSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupVaultBackupPropertiesShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultBackupPropertiesShowSettings SetIds(this AzureBackupVaultBackupPropertiesShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupVaultBackupPropertiesShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultBackupPropertiesShowSettings SetIds(this AzureBackupVaultBackupPropertiesShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureBackupVaultBackupPropertiesShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultBackupPropertiesShowSettings AddIds(this AzureBackupVaultBackupPropertiesShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureBackupVaultBackupPropertiesShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultBackupPropertiesShowSettings AddIds(this AzureBackupVaultBackupPropertiesShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureBackupVaultBackupPropertiesShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultBackupPropertiesShowSettings ClearIds(this AzureBackupVaultBackupPropertiesShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureBackupVaultBackupPropertiesShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultBackupPropertiesShowSettings RemoveIds(this AzureBackupVaultBackupPropertiesShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureBackupVaultBackupPropertiesShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultBackupPropertiesShowSettings RemoveIds(this AzureBackupVaultBackupPropertiesShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupVaultBackupPropertiesShowSettings.Name"/></em></p>
        ///   <p>Name of the Recovery services vault.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultBackupPropertiesShowSettings SetName(this AzureBackupVaultBackupPropertiesShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupVaultBackupPropertiesShowSettings.Name"/></em></p>
        ///   <p>Name of the Recovery services vault.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultBackupPropertiesShowSettings ResetName(this AzureBackupVaultBackupPropertiesShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupVaultBackupPropertiesShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultBackupPropertiesShowSettings SetResourceGroup(this AzureBackupVaultBackupPropertiesShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupVaultBackupPropertiesShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultBackupPropertiesShowSettings ResetResourceGroup(this AzureBackupVaultBackupPropertiesShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupVaultBackupPropertiesShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultBackupPropertiesShowSettings SetSubscription(this AzureBackupVaultBackupPropertiesShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupVaultBackupPropertiesShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultBackupPropertiesShowSettings ResetSubscription(this AzureBackupVaultBackupPropertiesShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupVaultBackupPropertiesShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultBackupPropertiesShowSettings SetDebug(this AzureBackupVaultBackupPropertiesShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupVaultBackupPropertiesShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultBackupPropertiesShowSettings ResetDebug(this AzureBackupVaultBackupPropertiesShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupVaultBackupPropertiesShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultBackupPropertiesShowSettings SetHelp(this AzureBackupVaultBackupPropertiesShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupVaultBackupPropertiesShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultBackupPropertiesShowSettings ResetHelp(this AzureBackupVaultBackupPropertiesShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupVaultBackupPropertiesShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultBackupPropertiesShowSettings SetOutput(this AzureBackupVaultBackupPropertiesShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupVaultBackupPropertiesShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultBackupPropertiesShowSettings ResetOutput(this AzureBackupVaultBackupPropertiesShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupVaultBackupPropertiesShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultBackupPropertiesShowSettings SetQuery(this AzureBackupVaultBackupPropertiesShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupVaultBackupPropertiesShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultBackupPropertiesShowSettings ResetQuery(this AzureBackupVaultBackupPropertiesShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBackupVaultBackupPropertiesShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultBackupPropertiesShowSettings SetVerbose(this AzureBackupVaultBackupPropertiesShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBackupVaultBackupPropertiesShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBackupVaultBackupPropertiesShowSettings ResetVerbose(this AzureBackupVaultBackupPropertiesShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region BackupJobListOperation
    /// <summary>
    ///   Used within <see cref="AzureBackupTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<BackupJobListOperation>))]
    public partial class BackupJobListOperation : Enumeration
    {
        public static BackupJobListOperation backup = new BackupJobListOperation { Value = "backup" };
        public static BackupJobListOperation configurebackup = new BackupJobListOperation { Value = "configurebackup" };
        public static BackupJobListOperation deletebackupdata = new BackupJobListOperation { Value = "deletebackupdata" };
        public static BackupJobListOperation disablebackup = new BackupJobListOperation { Value = "disablebackup" };
        public static BackupJobListOperation restore = new BackupJobListOperation { Value = "restore" };
    }
    #endregion
    #region BackupJobListStatus
    /// <summary>
    ///   Used within <see cref="AzureBackupTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<BackupJobListStatus>))]
    public partial class BackupJobListStatus : Enumeration
    {
        public static BackupJobListStatus cancelled = new BackupJobListStatus { Value = "cancelled" };
        public static BackupJobListStatus completed = new BackupJobListStatus { Value = "completed" };
        public static BackupJobListStatus completedwithwarnings = new BackupJobListStatus { Value = "completedwithwarnings" };
        public static BackupJobListStatus failed = new BackupJobListStatus { Value = "failed" };
        public static BackupJobListStatus inprogress = new BackupJobListStatus { Value = "inprogress" };
    }
    #endregion
    #region BackupVaultBackupPropertiesSetBackupStorageRedundancy
    /// <summary>
    ///   Used within <see cref="AzureBackupTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<BackupVaultBackupPropertiesSetBackupStorageRedundancy>))]
    public partial class BackupVaultBackupPropertiesSetBackupStorageRedundancy : Enumeration
    {
        public static BackupVaultBackupPropertiesSetBackupStorageRedundancy georedundant = new BackupVaultBackupPropertiesSetBackupStorageRedundancy { Value = "georedundant" };
        public static BackupVaultBackupPropertiesSetBackupStorageRedundancy locallyredundant = new BackupVaultBackupPropertiesSetBackupStorageRedundancy { Value = "locallyredundant" };
    }
    #endregion
}
